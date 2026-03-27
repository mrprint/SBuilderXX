// =============================================================
// FormatDispatcherTests.cs  —  MSTest version
// =============================================================

using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBuilderXX;

namespace SBuilderXX.Tests
{
    // ----------------------------------------------------------
    //  Test double: spy confirmer with configurable return value
    //  (shared with CompressionTests via same namespace)
    // ----------------------------------------------------------

    internal sealed class SpyConfirmer : IOverwriteConfirmer
    {
        public bool ReturnValue { get; set; } = true;
        public bool WasCalled { get; private set; }
        public int CallCount { get; private set; }
        public string LastFilename { get; private set; }

        public bool ConfirmOverwrite(string filename)
        {
            WasCalled = true;
            CallCount++;
            LastFilename = filename;
            return ReturnValue;
        }

        public void Reset()
        {
            WasCalled = false;
            CallCount = 0;
            LastFilename = null;
            ReturnValue = true;
        }
    }


    [TestClass]
    public class FormatDispatcherTests
    {
        private string _tmpXml;
        private string _tmpBin;
        private string _tmpUnknown;

        private IOverwriteConfirmer _originalConfirmer;
        private SpyConfirmer _spy;

        [TestInitialize]
        public void SetUp()
        {
            string tmp = Path.GetTempPath();
            _tmpXml = Path.Combine(tmp, "sbxx_disp_xml_" + Guid.NewGuid() + ".sbp");
            _tmpBin = Path.Combine(tmp, "sbxx_disp_bin_" + Guid.NewGuid() + ".sbp");
            _tmpUnknown = Path.Combine(tmp, "sbxx_disp_unknown_" + Guid.NewGuid() + ".sbp");

            _spy = new SpyConfirmer { ReturnValue = true };
            _originalConfirmer = moduleFILE_IO.OverwriteConfirmer;
            moduleFILE_IO.OverwriteConfirmer = _spy;

            TestState.Reset();
        }

        [TestCleanup]
        public void TearDown()
        {
            moduleFILE_IO.OverwriteConfirmer = _originalConfirmer;

            foreach (string f in new[] { _tmpXml, _tmpBin, _tmpUnknown })
            {
                if (File.Exists(f)) File.Delete(f);
                string dir = Path.GetDirectoryName(f) ?? string.Empty;
                string stem = Path.GetFileNameWithoutExtension(f);
                foreach (string bak in Directory.GetFiles(dir, stem + "_*.bak"))
                    try { File.Delete(bak); } catch { }
            }

            TestState.Reset();
        }

        private static void WriteBinaryStub(string path)
        {
            byte[] header = { 0x00, 0x01, 0x00, 0x00, 0x00 };
            byte[] pad = new byte[100];
            byte[] full = new byte[header.Length + pad.Length];
            Buffer.BlockCopy(header, 0, full, 0, header.Length);
            Buffer.BlockCopy(pad, 0, full, header.Length, pad.Length);
            File.WriteAllBytes(path, full);
        }


        // ==========================================================
        //  S A V E P R O J E C T
        // ==========================================================

        [TestMethod]
        public void SaveProject_NewFile_WritesXml_ReturnsTrue()
        {
            moduleMAIN.ProjectName = "New File Test";
            bool result = moduleFILE_IO.SaveProject(_tmpXml);

            Assert.IsTrue(result);
            Assert.IsTrue(File.Exists(_tmpXml));
            // Saved as XmlZip — first bytes are PK magic, not '<'
            byte[] h = File.ReadAllBytes(_tmpXml).Take(4).ToArray();
            Assert.AreEqual(0x50, h[0]);
            Assert.AreEqual(0x4B, h[1]);
        }

        [TestMethod]
        public void SaveProject_NewFile_DoesNotAskForConfirmation()
        {
            moduleMAIN.ProjectName = "No Confirm Needed";
            moduleFILE_IO.SaveProject(_tmpXml);
            Assert.IsFalse(_spy.WasCalled);
        }

        [TestMethod]
        public void SaveProject_OverwriteExistingXmlFile_DoesNotAskForConfirmation()
        {
            moduleMAIN.ProjectName = "First Save";
            moduleFILE_IO.SaveProject(_tmpXml);
            _spy.Reset();

            moduleMAIN.ProjectName = "Second Save";
            moduleFILE_IO.SaveProject(_tmpXml);

            Assert.IsFalse(_spy.WasCalled);
        }

        [TestMethod]
        public void SaveProject_ProducesLoadableFile()
        {
            moduleMAIN.ProjectName = "Save Then Load";
            moduleMAIN.Zoom = 5;

            moduleFILE_IO.SaveProject(_tmpXml);
            TestState.Reset();
            moduleFILE_IO.LoadProject(_tmpXml);

            Assert.AreEqual("Save Then Load", moduleMAIN.ProjectName);
            Assert.AreEqual(5, moduleMAIN.Zoom);
        }


        // ==========================================================
        //  B I N A R Y   O V E R W R I T E   G U A R D
        // ==========================================================

        [TestMethod]
        public void SaveProject_TargetIsBinary_AsksForConfirmation()
        {
            WriteBinaryStub(_tmpBin);
            moduleMAIN.ProjectName = "Should Ask";
            moduleFILE_IO.SaveProject(_tmpBin);
            Assert.IsTrue(_spy.WasCalled);
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_ConfirmerReceivesCorrectFilename()
        {
            WriteBinaryStub(_tmpBin);
            moduleFILE_IO.SaveProject(_tmpBin);
            Assert.AreEqual(_tmpBin, _spy.LastFilename);
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_UserConfirms_FileOverwritten()
        {
            WriteBinaryStub(_tmpBin);
            _spy.ReturnValue = true;

            bool result = moduleFILE_IO.SaveProject(_tmpBin);

            Assert.IsTrue(result);
            // File should now be a ZIP (XmlZip), not NRBF binary.
            byte[] h = File.ReadAllBytes(_tmpBin).Take(4).ToArray();
            Assert.AreEqual(0x50, h[0]);
            Assert.AreEqual(0x4B, h[1]);
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_UserDenies_ReturnsFalse()
        {
            WriteBinaryStub(_tmpBin);
            _spy.ReturnValue = false;
            bool result = moduleFILE_IO.SaveProject(_tmpBin);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_UserDenies_FileContentUnchanged()
        {
            WriteBinaryStub(_tmpBin);
            byte[] originalBytes = File.ReadAllBytes(_tmpBin);
            _spy.ReturnValue = false;

            moduleFILE_IO.SaveProject(_tmpBin);

            CollectionAssert.AreEqual(originalBytes, File.ReadAllBytes(_tmpBin));
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_ConfirmedTwice_CalledTwice()
        {
            WriteBinaryStub(_tmpBin);
            _spy.ReturnValue = false;

            moduleFILE_IO.SaveProject(_tmpBin);
            moduleFILE_IO.SaveProject(_tmpBin);

            Assert.AreEqual(2, _spy.CallCount);
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_UserConfirms_BackupFileCreated()
        {
            WriteBinaryStub(_tmpBin);
            _spy.ReturnValue = true;
            moduleFILE_IO.SaveProject(_tmpBin);

            string dir = Path.GetDirectoryName(_tmpBin);
            string stem = Path.GetFileNameWithoutExtension(_tmpBin);
            string[] baks = Directory.GetFiles(dir, stem + "_*.bak");

            Assert.AreEqual(1, baks.Length);
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_UserConfirms_BackupMatchesOriginal()
        {
            WriteBinaryStub(_tmpBin);
            byte[] originalBytes = File.ReadAllBytes(_tmpBin);
            _spy.ReturnValue = true;
            moduleFILE_IO.SaveProject(_tmpBin);

            string dir = Path.GetDirectoryName(_tmpBin);
            string stem = Path.GetFileNameWithoutExtension(_tmpBin);
            string bak = Directory.GetFiles(dir, stem + "_*.bak").Single();

            CollectionAssert.AreEqual(originalBytes, File.ReadAllBytes(bak));
        }

        [TestMethod]
        public void SaveProject_TargetIsBinary_UserDenies_NoBackupCreated()
        {
            WriteBinaryStub(_tmpBin);
            _spy.ReturnValue = false;
            moduleFILE_IO.SaveProject(_tmpBin);

            string dir = Path.GetDirectoryName(_tmpBin);
            string stem = Path.GetFileNameWithoutExtension(_tmpBin);
            Assert.AreEqual(0, Directory.GetFiles(dir, stem + "_*.bak").Length);
        }

        [TestMethod]
        public void SaveProject_TargetIsUnknownFormat_OverwritesWithoutAsking()
        {
            File.WriteAllBytes(_tmpUnknown, new byte[] { 0xDE, 0xAD, 0xBE, 0xEF });
            moduleMAIN.ProjectName = "Unknown Overwrite";
            bool result = moduleFILE_IO.SaveProject(_tmpUnknown);

            Assert.IsTrue(result);
            Assert.IsFalse(_spy.WasCalled);
        }


        // ==========================================================
        //  L O A D P R O J E C T   r o u t i n g
        // ==========================================================

        [TestMethod]
        public void LoadProject_XmlFile_LoadsCorrectly()
        {
            moduleMAIN.ProjectName = "XML Route Test";
            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine(
                "Road", "RDW", "{GUID}", System.Drawing.Color.Red.ToArgb(),
                (10.0, 20.0, 0, 30));

            moduleFILE_IO.SaveProject(_tmpXml);
            TestState.Reset();
            moduleFILE_IO.LoadProject(_tmpXml);

            Assert.AreEqual("XML Route Test", moduleMAIN.ProjectName);
            Assert.AreEqual(1, moduleLINES.NoOfLines);
            Assert.AreEqual("Road", moduleLINES.Lines[1].Name);
        }

        [TestMethod]
        public void LoadProject_BinaryFile_DoesNotThrow()
        {
            WriteBinaryStub(_tmpBin);
            TestState.AssertDoesNotThrow(() => moduleFILE_IO.LoadProject(_tmpBin));
        }

        [TestMethod]
        public void LoadProject_BinaryFile_ResetsCountsOnBadPayload()
        {
            moduleLINES.NoOfLines = 5;
            WriteBinaryStub(_tmpBin);
            moduleFILE_IO.LoadProject(_tmpBin);
            Assert.AreEqual(0, moduleLINES.NoOfLines);
        }


        // ==========================================================
        //  U N K N O W N   F O R M A T
        // ==========================================================

        [TestMethod]
        public void LoadProject_UnknownFormat_DoesNotThrow()
        {
            File.WriteAllBytes(_tmpUnknown, new byte[] { 0xDE, 0xAD, 0xBE, 0xEF, 0x00 });
            TestState.AssertDoesNotThrow(() => moduleFILE_IO.LoadProject(_tmpUnknown));
        }

        [TestMethod]
        public void LoadProject_UnknownFormat_LeavesStateUntouched()
        {
            moduleMAIN.ProjectName = "Should Stay";
            moduleLINES.NoOfLines = 3;

            File.WriteAllBytes(_tmpUnknown, new byte[] { 0xDE, 0xAD, 0xBE, 0xEF, 0x00 });
            moduleFILE_IO.LoadProject(_tmpUnknown);

            Assert.AreEqual("Should Stay", moduleMAIN.ProjectName);
            Assert.AreEqual(3, moduleLINES.NoOfLines);
        }

        [TestMethod]
        public void LoadProject_EmptyFile_DoesNotThrow()
        {
            File.WriteAllBytes(_tmpUnknown, new byte[0]);
            TestState.AssertDoesNotThrow(() => moduleFILE_IO.LoadProject(_tmpUnknown));
        }

        [TestMethod]
        public void LoadProject_FileNotFound_DoesNotThrow()
        {
            TestState.AssertDoesNotThrow(
                () => moduleFILE_IO.LoadProject(@"C:\does_not_exist_sbxx_dispatcher.sbp"));
        }


        // ==========================================================
        //  D E T E C T I O N   s i g n a t u r e   t e s t s
        //  MSTest has no [TestCase] — each signature gets its own method.
        // ==========================================================

        [TestMethod]
        public void Detection_PlainXmlDeclaration_RecognisedAsXml()
            => RunXmlSignatureTest(new byte[] { (byte)'<', (byte)'?', (byte)'x', (byte)'m', (byte)'l' }, false);

        [TestMethod]
        public void Detection_XmlWithLeadingWhitespace_RecognisedAsXml()
            => RunXmlSignatureTest(new byte[] { (byte)' ', (byte)'\n', (byte)'<', (byte)'S', (byte)'B' }, false);

        [TestMethod]
        public void Detection_Utf8Bom_RecognisedAsXml()
            => RunXmlSignatureTest(new byte[] { 0xEF, 0xBB, 0xBF, (byte)'<', (byte)'S' }, true);

        [TestMethod]
        public void Detection_Utf16LeBom_DoesNotThrow()
        {
            File.WriteAllBytes(_tmpXml, new byte[] { 0xFF, 0xFE, (byte)'<', 0x00, (byte)'S' });
            TestState.AssertDoesNotThrow(() => moduleFILE_IO.LoadProject(_tmpXml));
        }

        [TestMethod]
        public void Detection_Utf16BeBom_DoesNotThrow()
        {
            File.WriteAllBytes(_tmpXml, new byte[] { 0xFE, 0xFF, 0x00, (byte)'<', (byte)'S' });
            TestState.AssertDoesNotThrow(() => moduleFILE_IO.LoadProject(_tmpXml));
        }

        [TestMethod]
        public void Detection_NrbfSignature_RecognisedAsBinary()
        {
            File.WriteAllBytes(_tmpBin, new byte[] { 0x00, 0x01, 0x00, 0x00, 0x00 });
            TestState.AssertDoesNotThrow(() => moduleFILE_IO.LoadProject(_tmpBin));
        }

        private void RunXmlSignatureTest(byte[] headerBytes, bool hasBom)
        {
            string minimalXml =
                "<?xml version=\"1.0\"?>" +
                "<SBuilderProject version=\"SBXX_XML_100\">" +
                "<Header><Name>Sig Test</Name><BGLFolder/>" +
                "<Zoom>0</Zoom><LatCenter>0</LatCenter>" +
                "<LonCenter>0</LonCenter><QMIDLevel>0</QMIDLevel></Header>" +
                "<Maps count=\"0\"/><Lines count=\"0\"/><Polys count=\"0\"/>" +
                "<LandClasses count=\"0\"/><WaterClasses count=\"0\"/>" +
                "<Excludes count=\"0\"/><Objects count=\"0\"/><LWCIs count=\"0\"/>" +
                "</SBuilderProject>";

            if (hasBom)
            {
                byte[] xmlBytes = System.Text.Encoding.UTF8.GetBytes(minimalXml);
                byte[] all = new byte[headerBytes.Length + xmlBytes.Length];
                Buffer.BlockCopy(headerBytes, 0, all, 0, headerBytes.Length);
                Buffer.BlockCopy(xmlBytes, 0, all, headerBytes.Length, xmlBytes.Length);
                File.WriteAllBytes(_tmpXml, all);
            }
            else
            {
                File.WriteAllText(_tmpXml, minimalXml);
            }

            TestState.Reset();
            TestState.AssertDoesNotThrow(() => moduleFILE_IO.LoadProject(_tmpXml));
            if (!hasBom)
                Assert.AreEqual("Sig Test", moduleMAIN.ProjectName);
        }


        // ==========================================================
        //  I D E M P O T E N C E
        // ==========================================================

        [TestMethod]
        public void SaveLoadSaveLoad_IdempotentRoundTrip()
        {
            moduleMAIN.ProjectName = "Idempotent";
            moduleMAIN.Zoom = 6;
            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine(
                "Idem Line", "RDW", "{IDEM}", System.Drawing.Color.Green.ToArgb(),
                (51.5, -0.1, 0, 25));

            string tmp2 = _tmpXml + "_second.xml";
            try
            {
                moduleFILE_IO.SaveProject(_tmpXml);
                TestState.Reset();
                moduleFILE_IO.LoadProject(_tmpXml);

                moduleFILE_IO.SaveProject(tmp2);
                TestState.Reset();
                moduleFILE_IO.LoadProject(tmp2);

                Assert.AreEqual("Idempotent", moduleMAIN.ProjectName);
                Assert.AreEqual(6, moduleMAIN.Zoom);
                Assert.AreEqual(1, moduleLINES.NoOfLines);
                Assert.AreEqual("Idem Line", moduleLINES.Lines[1].Name);
                Assert.AreEqual(51.5, moduleLINES.Lines[1].GLPoints[1].lat, 1e-10);
            }
            finally
            {
                if (File.Exists(tmp2)) File.Delete(tmp2);
            }
        }
    }
}