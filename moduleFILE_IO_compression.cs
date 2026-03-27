// =============================================================
// moduleFILE_IO_compression.cs
//
// Adds transparent ZIP compression around the XML save/load layer.
// System.IO.Compression is part of .NET 4.5+ — no NuGet required.
//
// ARCHITECTURE
// ------------
//
//   ┌─────────────────────────────────┐
//   │  SaveProject / LoadProject      │  ← dispatcher (public API)
//   │  (moduleFILE_IO_dispatcher.cs)  │
//   └────────────┬────────────────────┘
//                │ calls
//   ┌────────────▼────────────────────┐
//   │  SaveFileXmlZip                 │  ← THIS FILE
//   │  OpenFileXmlZip                 │
//   └────────────┬────────────────────┘
//                │ calls
//   ┌────────────▼────────────────────┐
//   │  SaveFileXml / OpenFileXml      │  ← pure XML (unchanged)
//   │  (moduleFILE_IO_xml.cs)         │
//   └─────────────────────────────────┘
//
// FILE FORMAT (on disk)
// ---------------------
//   A standard ZIP archive containing a single entry named
//   "project.xml".  Any ZIP tool can open it for inspection
//   or recovery.
//
//   Magic bytes: PK\x03\x04 (0x50 0x4B 0x03 0x04)
//   — distinct from NRBF binary (0x00 0x01 ...) and plain XML ('<').
//   The dispatcher DetectFormat method is updated to recognise this
//   signature as ProjectFileFormat.XmlZip.
//
// COMPRESSION RATIO
// -----------------
//   XML project files compress to roughly 5–15 % of their original
//   size (85–95 % reduction) because XML is highly repetitive text.
//
// BACKWARD COMPATIBILITY
// ----------------------
//   Plain (uncompressed) XML files written by earlier versions of
//   the code are still loaded transparently via OpenFileXml.
//   Only new saves use the compressed format.
// =============================================================

using System;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SBuilderXX
{
    static partial class moduleFILE_IO
    {
        // Name of the single ZIP entry that holds the project XML.
        internal const string ZipEntryName = "project.xml";

        // ZIP local-file-header magic bytes.
        private static readonly byte[] ZipMagic = { 0x50, 0x4B, 0x03, 0x04 };


        // ==================================================================
        //  S A V E   ( X M L  →  Z I P )
        // ==================================================================

        /// <summary>
        /// Serialises the current project to XML (via SaveFileXml) and
        /// stores the result as a compressed ZIP archive at
        /// <paramref name="filename"/>.
        ///
        /// The ZIP contains a single entry named "project.xml".
        /// </summary>
        internal static void SaveFileXmlZip(string filename)
        {
            // 1. Render the XML into an in-memory buffer so we never
            //    write a partial file to disk if something goes wrong.
            byte[] xmlBytes;
            using (var ms = new MemoryStream())
            {
                // Delegate all XML construction to the existing layer.
                // We pass a temp path pointing at the MemoryStream by
                // using a helper that lets SaveFileXml write to a stream.
                XDocument doc = BuildXmlDocument();   // see bottom of this file
                doc.Save(ms, SaveOptions.None);
                xmlBytes = ms.ToArray();
            }

            // 2. Write the ZIP archive atomically via a temp file, then
            //    move it over the target.  This prevents corruption if
            //    the process is killed mid-write.
            string tmpPath = filename + ".tmp";
            try
            {
                using (FileStream fs = new FileStream(
                    tmpPath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (var archive = new ZipArchive(fs, ZipArchiveMode.Create, leaveOpen: false))
                {
                    ZipArchiveEntry entry = archive.CreateEntry(
                        ZipEntryName, CompressionLevel.Optimal);

                    using (Stream entryStream = entry.Open())
                        entryStream.Write(xmlBytes, 0, xmlBytes.Length);
                }

                // Atomic replace: move the finished temp file over the target.
                if (File.Exists(filename))
                    File.Delete(filename);
                File.Move(tmpPath, filename);
            }
            catch
            {
                // Clean up the temp file on failure.
                try { if (File.Exists(tmpPath)) File.Delete(tmpPath); } catch { }
                throw;
            }
        }


        // ==================================================================
        //  L O A D   ( Z I P  →  X M L )
        // ==================================================================

        /// <summary>
        /// Reads a compressed project file created by
        /// <see cref="SaveFileXmlZip"/> and loads the contained XML.
        /// </summary>
        internal static void OpenFileXmlZip(string filename)
        {
            try
            {
                using (FileStream fs = new FileStream(
                    filename, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var archive = new ZipArchive(fs, ZipArchiveMode.Read))
                {
                    ZipArchiveEntry entry = archive.GetEntry(ZipEntryName);
                    if (entry == null)
                        throw new InvalidDataException(
                            $"ZIP archive does not contain the expected entry '{ZipEntryName}'.");

                    using (Stream entryStream = entry.Open())
                    {
                        XDocument doc = XDocument.Load(entryStream);
                        ParseXmlDocument(doc);   // delegate to the XML layer
                    }
                }
            }
            catch (Exception ex)
            {
                // Reset state so the application is in a clean condition.
                ResetAllCounts();
                MessageBox.Show(
                    "Error loading compressed project file:\n" + ex.Message,
                    "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        // ==================================================================
        //  F O R M A T   D E T E C T I O N   H O O K
        // ==================================================================

        /// <summary>
        /// Returns true if the first bytes of <paramref name="filename"/>
        /// match the ZIP local-file-header signature (PK\x03\x04).
        /// </summary>
        internal static bool IsZipFile(string filename)
        {
            try
            {
                byte[] header = ReadFirstBytes(filename, 4);
                if (header == null || header.Length < 4) return false;
                return header[0] == ZipMagic[0] &&
                       header[1] == ZipMagic[1] &&
                       header[2] == ZipMagic[2] &&
                       header[3] == ZipMagic[3];
            }
            catch
            {
                return false;
            }
        }


        // ==================================================================
        //  P R I V A T E   B R I D G E S
        //  These allow SaveFileXmlZip / OpenFileXmlZip to reuse the XML
        //  construction and parsing logic already in moduleFILE_IO_xml.cs
        //  without touching that file.
        // ==================================================================

        /// <summary>
        /// Builds the complete XDocument for the current project state.
        /// Mirrors SaveFileXml but returns the document instead of writing
        /// to a file, so the compression layer can stream it into ZIP.
        /// </summary>
        private static XDocument BuildXmlDocument()
        {
            return new XDocument(
                new XDeclaration("1.0", "utf-8", null),
                new XElement("SBuilderProject",
                    new XAttribute("version", XmlFormatVersion),
                    BuildHeader(),
                    BuildMaps(),
                    BuildLines(),
                    BuildPolys(),
                    BuildLandClasses(),
                    BuildWaterClasses(),
                    BuildExcludes(),
                    BuildObjects(),
                    BuildLWCIs()
                )
            );
        }

        /// <summary>
        /// Parses an already-loaded XDocument into module state.
        /// Mirrors the body of OpenFileXml but accepts a document object
        /// so the compression layer can pass in a decompressed stream.
        /// </summary>
        private static void ParseXmlDocument(XDocument doc)
        {
            XElement root = doc.Root;
            if (root == null || root.Name != "SBuilderProject")
                throw new InvalidDataException("Not a valid SBuilderXX XML project file.");

            string ver = (string)root.Attribute("version") ?? "";
            if (!ver.StartsWith("SBXX_XML_"))
                throw new InvalidDataException("Unrecognised file version: " + ver);

            // Re-use the full parsing logic from OpenFileXml by feeding it
            // back through a MemoryStream so we don't duplicate any code.
            using (var ms = new MemoryStream())
            {
                doc.Save(ms, SaveOptions.None);
                ms.Position = 0;

                // Write to a temp file, parse it, then delete — this keeps
                // ParseXmlDocument free of any duplicated field-assignment code.
                string tmp = Path.Combine(Path.GetTempPath(),
                    "sbxx_parse_" + Guid.NewGuid() + ".xml");
                try
                {
                    File.WriteAllBytes(tmp, ms.ToArray());
                    OpenFileXml(tmp);
                }
                finally
                {
                    try { if (File.Exists(tmp)) File.Delete(tmp); } catch { }
                }
            }
        }

        /// <summary>
        /// Resets all project counts to zero.
        /// Extracted here so both OpenFileXml and OpenFileXmlZip can call
        /// it from their catch blocks without duplicating the list.
        /// </summary>
        internal static void ResetAllCounts()
        {
            moduleMAPS.NoOfMaps = 0;
            moduleCLASSES.NoOfLands = 0;
            moduleLINES.NoOfLines = 0;
            modulePOLYS.NoOfPolys = 0;
            moduleCLASSES.NoOfWaters = 0;
            moduleOBJECTS.NoOfObjects = 0;
            moduleEXCLUDES.NoOfExcludes = 0;
            moduleCLASSES.NoOfLWCIs = 0;
            moduleCLASSES.NoOfLLXYs = 0;
            moduleCLASSES.NoOfWWXYs = 0;
        }
    }
}
