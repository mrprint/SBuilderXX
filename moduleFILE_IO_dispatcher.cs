// =============================================================
// moduleFILE_IO_dispatcher.cs
//
// Transparent format detection so callers never need to know
// whether a .SBP file is the old BinaryFormatter format, a plain
// XML file, or the current compressed XML-in-ZIP format.
//
// PUBLIC SURFACE (replace all existing call-sites with these):
//
//   moduleFILE_IO.LoadProject(filename)   <- replaces OpenFile()
//   moduleFILE_IO.SaveProject(filename)   <- replaces SaveFile()
//
// Format routing
// --------------
//   Save  -> always writes XmlZip (ZIP containing project.xml)
//   Load  -> detects format from file header bytes, routes to
//             the appropriate reader automatically:
//
//   50 4B 03 04          -> XmlZip  (ZIP magic "PK\x03\x04")
//   EF BB BF / FF FE /
//   FE FF / first '<'   -> Xml     (plain XML, legacy load only)
//   00 01 00 00 00       -> Binary  (NRBF BinaryFormatter, legacy)
//   anything else        -> Unknown (error message, state untouched)
//
// Binary overwrite protection
// ---------------------------
//   SaveProject will never silently overwrite a binary .SBP file.
//   If the target file exists and is detected as Binary, the user
//   is warned and must explicitly confirm.  On confirmation the
//   original binary file is backed up with a timestamp before the
//   new XmlZip file is written.
//   The confirmation dialog is injectable (IOverwriteConfirmer) for
//   automated/test use without a real MessageBox.
// =============================================================

using System;
using System.IO;
using System.Windows.Forms;

namespace SBuilderXX
{
    // ----------------------------------------------------------
    //  Seam for testability: lets tests inject a fake dialog
    //  instead of popping a real MessageBox.
    // ----------------------------------------------------------

    /// <summary>
    /// Asks the user whether a legacy binary project file should
    /// be replaced with the new XML format.
    /// </summary>
    public interface IOverwriteConfirmer
    {
        /// <summary>Returns true if the overwrite should proceed.</summary>
        bool ConfirmOverwrite(string filename);
    }

    /// <summary>Production implementation - shows a WinForms MessageBox.</summary>
    internal sealed class MessageBoxConfirmer : IOverwriteConfirmer
    {
        internal static readonly MessageBoxConfirmer Instance = new MessageBoxConfirmer();

        public bool ConfirmOverwrite(string filename)
        {
            string msg =
                "The file below is a legacy binary SBuilderXX project:\n\n" +
                "    " + filename + "\n\n" +
                "Saving will convert it to the new compressed XML format.\n" +
                "The original binary file will be overwritten and\n" +
                "cannot be recovered unless you have a backup.\n\n" +
                "Do you want to continue?";

            return MessageBox.Show(
                msg,
                "Overwrite legacy binary project?",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2)   // default = No (safe)
                == DialogResult.Yes;
        }
    }


    static partial class moduleFILE_IO
    {
        // ----------------------------------------------------------
        //  Overwrite confirmer - swappable for tests.
        // ----------------------------------------------------------
        internal static IOverwriteConfirmer OverwriteConfirmer =
            MessageBoxConfirmer.Instance;


        // ----------------------------------------------------------
        //  P U B L I C   A P I
        // ----------------------------------------------------------

        /// <summary>
        /// Loads a project file in any supported format.
        /// Detects automatically whether the file is Binary (legacy),
        /// plain XML (legacy), or the current compressed XmlZip format.
        /// </summary>
        public static void LoadProject(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show("File not found:\n" + filename, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            switch (DetectFormat(filename))
            {
                case ProjectFileFormat.XmlZip:
                    OpenFileXmlZip(filename);   // current format
                    break;

                case ProjectFileFormat.Xml:
                    OpenFileXml(filename);      // plain XML (written by older builds)
                    break;

                case ProjectFileFormat.Binary:
                    OpenFile(filename);         // legacy BinaryFormatter
                    break;

                default:
                    MessageBox.Show(
                        "Unrecognised file format.\n" +
                        "The file is not a recognised SBuilderXX project file.",
                        "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        /// <summary>
        /// Saves the current project as a compressed XML-in-ZIP file.
        ///
        /// If the target already exists and is a legacy binary project,
        /// the user is warned and must confirm before it is overwritten.
        /// On confirmation the original is backed up with a timestamp.
        ///
        /// Returns true if the file was saved, false if cancelled.
        /// </summary>
        public static bool SaveProject(string filename)
        {
            if (File.Exists(filename))
            {
                ProjectFileFormat existing = DetectFormat(filename);

                if (existing == ProjectFileFormat.Binary)
                {
                    if (!OverwriteConfirmer.ConfirmOverwrite(filename))
                        return false;   // user said No

                    // Back up before overwriting so there is always a
                    // recovery path even if the user later regrets it.
                    CreateBinaryBackup(filename);
                }
                // XmlZip, plain Xml, Unknown: overwrite freely.
            }

            SaveFileXmlZip(filename);
            return true;
        }


        // ----------------------------------------------------------
        //  B A C K U P   H E L P E R
        // ----------------------------------------------------------

        /// <summary>
        /// Copies <paramref name="filename"/> to a timestamped .bak
        /// file in the same directory before it is overwritten.
        /// Example: MyProject.sbp -> MyProject_20240315_143022.sbp.bak
        /// Silently swallows failures - backup is best-effort.
        /// </summary>
        private static void CreateBinaryBackup(string filename)
        {
            try
            {
                string dir = Path.GetDirectoryName(filename) ?? string.Empty;
                string baseName = Path.GetFileNameWithoutExtension(filename);
                string ext = Path.GetExtension(filename);
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string backupPath = Path.Combine(dir,
                    baseName + "_" + timestamp + ext + ".bak");

                File.Copy(filename, backupPath, overwrite: false);
            }
            catch
            {
                // Backup failure must never block the save.
            }
        }


        // ----------------------------------------------------------
        //  F O R M A T   D E T E C T I O N
        // ----------------------------------------------------------

        private enum ProjectFileFormat
        {
            Unknown,
            Binary,     // .NET BinaryFormatter NRBF stream
            Xml,        // Plain UTF-8 XML (legacy, load only)
            XmlZip      // ZIP archive containing project.xml (current format)
        }

        /// <summary>
        /// Reads the first 5 bytes of the file and classifies its format.
        ///
        /// Signature table
        /// ---------------
        ///   50 4B 03 04          -> XmlZip  (ZIP "PK\x03\x04" magic)
        ///   EF BB BF             -> Xml     (UTF-8 BOM)
        ///   FF FE                -> Xml     (UTF-16 LE BOM)
        ///   FE FF                -> Xml     (UTF-16 BE BOM)
        ///   first non-WS = '<'  -> Xml     (plain ASCII / UTF-8)
        ///   00 01 00 00 00       -> Binary  (NRBF stream header)
        ///   anything else        -> Unknown
        /// </summary>
        private static ProjectFileFormat DetectFormat(string filename)
        {
            try
            {
                byte[] h = ReadFirstBytes(filename, 5);
                if (h == null || h.Length == 0)
                    return ProjectFileFormat.Unknown;

                // ---- XmlZip (ZIP) — must be checked before XML ----------
                // ZIP local-file-header signature: PK\x03\x04
                if (h.Length >= 4 &&
                    h[0] == 0x50 && h[1] == 0x4B &&
                    h[2] == 0x03 && h[3] == 0x04)
                    return ProjectFileFormat.XmlZip;

                // ---- Plain XML ------------------------------------------
                if (h.Length >= 3 &&
                    h[0] == 0xEF && h[1] == 0xBB && h[2] == 0xBF)
                    return ProjectFileFormat.Xml;   // UTF-8 BOM

                if (FirstNonWhitespaceByte(h) == (byte)'<')
                    return ProjectFileFormat.Xml;   // plain text XML

                if (h.Length >= 2 && h[0] == 0xFF && h[1] == 0xFE)
                    return ProjectFileFormat.Xml;   // UTF-16 LE BOM

                if (h.Length >= 2 && h[0] == 0xFE && h[1] == 0xFF)
                    return ProjectFileFormat.Xml;   // UTF-16 BE BOM

                // ---- BinaryFormatter (NRBF) ------------------------------
                if (h.Length >= 5 &&
                    h[0] == 0x00 && h[1] == 0x01 &&
                    h[2] == 0x00 && h[3] == 0x00 && h[4] == 0x00)
                    return ProjectFileFormat.Binary;

                return ProjectFileFormat.Unknown;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not read file header:\n" + ex.Message, "",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return ProjectFileFormat.Unknown;
            }
        }

        private static byte[] ReadFirstBytes(string filename, int count)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open,
                                                  FileAccess.Read, FileShare.Read))
            {
                byte[] buf = new byte[count];
                int read = fs.Read(buf, 0, count);
                if (read < count)
                {
                    byte[] trimmed = new byte[read];
                    Array.Copy(buf, trimmed, read);
                    return trimmed;
                }
                return buf;
            }
        }

        private static byte FirstNonWhitespaceByte(byte[] bytes)
        {
            foreach (byte b in bytes)
                if (b != (byte)' ' && b != (byte)'\t' &&
                    b != (byte)'\r' && b != (byte)'\n')
                    return b;
            return 0;
        }
    }
}
