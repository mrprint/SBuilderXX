using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBuilderXX;

namespace SBuilderXX.Tests
{
    [TestClass]
    public class CompressionTests
    {
        private string _tmp;
        private IOverwriteConfirmer _originalConfirmer;

        [TestInitialize]
        public void SetUp()
        {
            _tmp = Path.Combine(Path.GetTempPath(),
                "sbxx_zip_" + Guid.NewGuid() + ".sbp");

            _originalConfirmer = moduleFILE_IO.OverwriteConfirmer;
            moduleFILE_IO.OverwriteConfirmer = new SpyConfirmer { ReturnValue = true };

            TestState.Reset();
        }

        [TestCleanup]
        public void TearDown()
        {
            moduleFILE_IO.OverwriteConfirmer = _originalConfirmer;

            if (File.Exists(_tmp)) File.Delete(_tmp);
            string dir = Path.GetDirectoryName(_tmp) ?? string.Empty;
            string stem = Path.GetFileNameWithoutExtension(_tmp);
            foreach (string bak in Directory.GetFiles(dir, stem + "_*.bak"))
                try { File.Delete(bak); } catch { }

            TestState.Reset();
        }


        // ==========================================================
        //  F I L E   F O R M A T
        // ==========================================================

        [TestMethod]
        public void SaveFileXmlZip_ProducesValidZipFile()
        {
            moduleMAIN.ProjectName = "Zip Format Test";
            moduleFILE_IO.SaveFileXmlZip(_tmp);

            Assert.IsTrue(File.Exists(_tmp));

            byte[] header = File.ReadAllBytes(_tmp).Take(4).ToArray();
            Assert.AreEqual(0x50, header[0], "Byte 0 must be 'P'");
            Assert.AreEqual(0x4B, header[1], "Byte 1 must be 'K'");
            Assert.AreEqual(0x03, header[2], "Byte 2 must be 0x03");
            Assert.AreEqual(0x04, header[3], "Byte 3 must be 0x04");
        }

        [TestMethod]
        public void SaveFileXmlZip_ContainsSingleEntryNamedProjectXml()
        {
            moduleMAIN.ProjectName = "Entry Name Test";
            moduleFILE_IO.SaveFileXmlZip(_tmp);

            using (var archive = ZipFile.OpenRead(_tmp))
            {
                Assert.AreEqual(1, archive.Entries.Count);
                Assert.AreEqual(moduleFILE_IO.ZipEntryName, archive.Entries[0].FullName);
            }
        }

        [TestMethod]
        public void SaveFileXmlZip_EntryContainsValidXml()
        {
            moduleMAIN.ProjectName = "XML Inside Zip";
            moduleFILE_IO.SaveFileXmlZip(_tmp);

            using (var archive = ZipFile.OpenRead(_tmp))
            using (Stream stream = archive.Entries[0].Open())
            {
                TestState.AssertDoesNotThrow(
                    () => System.Xml.Linq.XDocument.Load(stream),
                    "ZIP entry must contain well-formed XML");
            }
        }

        [TestMethod]
        public void SaveFileXmlZip_IsSmaller_ThanUncompressedXml()
        {
            moduleLINES.NoOfLines = 20;
            moduleLINES.Lines = new moduleLINES.GLine[21];
            for (int i = 1; i <= 20; i++)
                moduleLINES.Lines[i] = TestState.MakeLine(
                    "Long line name number " + i, "RDW",
                    "{GUID-" + i + "-0000-0000-000000000000}",
                    System.Drawing.Color.Red.ToArgb(),
                    (38.0 + i * 0.01, -9.0, 0, 30),
                    (38.1 + i * 0.01, -9.1, 0, 30),
                    (38.2 + i * 0.01, -9.2, 0, 30));

            string xmlTmp = _tmp + ".plain.xml";
            try
            {
                moduleFILE_IO.SaveFileXml(xmlTmp);
                moduleFILE_IO.SaveFileXmlZip(_tmp);

                long xmlSize = new FileInfo(xmlTmp).Length;
                long zipSize = new FileInfo(_tmp).Length;

                Assert.IsTrue(zipSize < xmlSize,
                    $"ZIP ({zipSize} B) must be smaller than plain XML ({xmlSize} B)");
            }
            finally
            {
                if (File.Exists(xmlTmp)) File.Delete(xmlTmp);
            }
        }


        // ==========================================================
        //  R O U N D - T R I P   C O R R E C T N E S S
        // ==========================================================

        [TestMethod]
        public void SaveAndLoad_Header_RoundTrip()
        {
            moduleMAIN.ProjectName = "Zip Round Trip";
            moduleMAIN.Zoom = 9;
            moduleMAIN.LatDispCenter = 38.7813203;
            moduleMAIN.LonDispCenter = -9.136076;
            moduleMAIN.QMIDLevel = 7;

            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);

            Assert.AreEqual("Zip Round Trip", moduleMAIN.ProjectName);
            Assert.AreEqual(9, moduleMAIN.Zoom);
            Assert.AreEqual(38.7813203, moduleMAIN.LatDispCenter, 1e-10);
            Assert.AreEqual(-9.136076, moduleMAIN.LonDispCenter, 1e-10);
            Assert.AreEqual(7, moduleMAIN.QMIDLevel);
        }

        [TestMethod]
        public void SaveAndLoad_Lines_RoundTrip()
        {
            moduleLINES.NoOfLines = 2;
            moduleLINES.Lines = new moduleLINES.GLine[3];
            moduleLINES.Lines[1] = TestState.MakeLine(
                "Road A", "RDW", "{AA}", System.Drawing.Color.Red.ToArgb(),
                (10.0, 20.0, 0, 30), (11.0, 21.0, 5, 30));
            moduleLINES.Lines[2] = TestState.MakeLine(
                "Road B", "RDW", "{BB}", System.Drawing.Color.Blue.ToArgb(),
                (50.0, -1.0, 0, 20));

            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);

            Assert.AreEqual(2, moduleLINES.NoOfLines);
            Assert.AreEqual("Road A", moduleLINES.Lines[1].Name);
            Assert.AreEqual(2, moduleLINES.Lines[1].NoOfPoints);
            Assert.AreEqual(11.0, moduleLINES.Lines[1].GLPoints[2].lat, 1e-10);
            Assert.AreEqual("Road B", moduleLINES.Lines[2].Name);
            Assert.AreEqual(1, moduleLINES.Lines[2].NoOfPoints);
        }

        [TestMethod]
        public void SaveAndLoad_Polys_RoundTrip()
        {
            modulePOLYS.NoOfPolys = 1;
            modulePOLYS.Polys = new modulePOLYS.GPoly[2];
            modulePOLYS.Polys[1] = TestState.MakePoly(
                "Forest", "LCP", "{FF}", System.Drawing.Color.Green.ToArgb(),
                (1.0, 1.0, 0), (2.0, 1.0, 0), (2.0, 2.0, 0));

            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);

            Assert.AreEqual(1, modulePOLYS.NoOfPolys);
            Assert.AreEqual("Forest", modulePOLYS.Polys[1].Name);
            Assert.AreEqual(3, modulePOLYS.Polys[1].NoOfPoints);
        }

        [TestMethod]
        public void SaveAndLoad_Objects_RoundTrip()
        {
            moduleOBJECTS.NoOfObjects = 1;
            moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[2];
            moduleOBJECTS.Objects[1].Type = 2;
            moduleOBJECTS.Objects[1].Description = "Hangar";
            moduleOBJECTS.Objects[1].Heading = 180.0f;
            moduleOBJECTS.Objects[1].lat = 51.477;
            moduleOBJECTS.Objects[1].lon = -0.001;

            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);

            Assert.AreEqual(1, moduleOBJECTS.NoOfObjects);
            Assert.AreEqual("Hangar", moduleOBJECTS.Objects[1].Description);
            Assert.AreEqual(180.0f, moduleOBJECTS.Objects[1].Heading, 1e-4f);
            Assert.AreEqual(51.477, moduleOBJECTS.Objects[1].lat, 1e-10);
        }

        [TestMethod]
        public void SaveAndLoad_Excludes_RoundTrip()
        {
            moduleEXCLUDES.NoOfExcludes = 1;
            moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[2];
            moduleEXCLUDES.Excludes[1].Flag = 5;
            moduleEXCLUDES.Excludes[1].NLAT = 40.0;
            moduleEXCLUDES.Excludes[1].SLAT = 39.0;
            moduleEXCLUDES.Excludes[1].ELON = -7.0;
            moduleEXCLUDES.Excludes[1].WLON = -9.0;

            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);

            Assert.AreEqual(1, moduleEXCLUDES.NoOfExcludes);
            Assert.AreEqual(5, moduleEXCLUDES.Excludes[1].Flag);
            Assert.AreEqual(40.0, moduleEXCLUDES.Excludes[1].NLAT, 1e-10);
            Assert.AreEqual(-9.0, moduleEXCLUDES.Excludes[1].WLON, 1e-10);
        }

        [TestMethod]
        public void SaveAndLoad_SpecialCharsInName_RoundTrip()
        {
            moduleMAIN.ProjectName = "Test <Project> & \"Quotes\"";
            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);
            Assert.AreEqual("Test <Project> & \"Quotes\"", moduleMAIN.ProjectName);
        }

        [TestMethod]
        public void SaveAndLoad_EmptyProject_RoundTrip()
        {
            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);

            Assert.AreEqual(0, moduleLINES.NoOfLines);
            Assert.AreEqual(0, modulePOLYS.NoOfPolys);
            Assert.AreEqual(0, moduleOBJECTS.NoOfObjects);
        }

        [TestMethod]
        public void SaveAndLoad_HighPrecisionCoordinates_NoLoss()
        {
            double lat = 38.781320312500000123;
            double lon = -9.136076000000000456;

            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine("P", "", "{}", 0, (lat, lon, 0, 0));

            moduleFILE_IO.SaveFileXmlZip(_tmp);
            TestState.Reset();
            moduleFILE_IO.OpenFileXmlZip(_tmp);

            Assert.AreEqual(lat, moduleLINES.Lines[1].GLPoints[1].lat, 1e-15);
            Assert.AreEqual(lon, moduleLINES.Lines[1].GLPoints[1].lon, 1e-15);
        }


        // ==========================================================
        //  D I S P A T C H E R   R O U T I N G
        // ==========================================================

        [TestMethod]
        public void SaveProject_WritesXmlZip_NotPlainXml()
        {
            moduleMAIN.ProjectName = "Dispatcher Zip Test";
            moduleFILE_IO.SaveProject(_tmp);

            byte[] header = File.ReadAllBytes(_tmp).Take(4).ToArray();
            Assert.AreEqual(0x50, header[0]);
            Assert.AreEqual(0x4B, header[1]);
            Assert.AreEqual(0x03, header[2]);
            Assert.AreEqual(0x04, header[3]);
        }

        [TestMethod]
        public void LoadProject_XmlZipFile_RoutesToOpenFileXmlZip()
        {
            moduleMAIN.ProjectName = "ZIP Route";
            moduleFILE_IO.SaveProject(_tmp);
            TestState.Reset();
            moduleFILE_IO.LoadProject(_tmp);
            Assert.AreEqual("ZIP Route", moduleMAIN.ProjectName);
        }

        [TestMethod]
        public void LoadProject_PlainXmlFile_StillLoadsCorrectly()
        {
            moduleMAIN.ProjectName = "Plain XML Legacy";
            moduleFILE_IO.SaveFileXml(_tmp);
            TestState.Reset();
            moduleFILE_IO.LoadProject(_tmp);
            Assert.AreEqual("Plain XML Legacy", moduleMAIN.ProjectName);
        }


        // ==========================================================
        //  E R R O R   H A N D L I N G
        // ==========================================================

        [TestMethod]
        public void OpenFileXmlZip_FileNotFound_DoesNotThrow()
        {
            TestState.AssertDoesNotThrow(
                () => moduleFILE_IO.OpenFileXmlZip(@"C:\no_such_file.sbp"));
        }

        [TestMethod]
        public void OpenFileXmlZip_CorruptZip_ResetsAllCounts()
        {
            moduleLINES.NoOfLines = 5;
            File.WriteAllBytes(_tmp, new byte[] { 0x50, 0x4B, 0x03, 0x04, 0xDE, 0xAD, 0xBE, 0xEF });
            moduleFILE_IO.OpenFileXmlZip(_tmp);
            Assert.AreEqual(0, moduleLINES.NoOfLines);
        }

        [TestMethod]
        public void OpenFileXmlZip_ValidZip_WrongEntryName_ResetsAllCounts()
        {
            moduleLINES.NoOfLines = 3;
            using (FileStream fs = new FileStream(_tmp, FileMode.Create))
            using (var archive = new ZipArchive(fs, ZipArchiveMode.Create))
            {
                ZipArchiveEntry entry = archive.CreateEntry("wrong_name.xml");
                using (StreamWriter sw = new StreamWriter(entry.Open()))
                    sw.Write("<SBuilderProject/>");
            }

            moduleFILE_IO.OpenFileXmlZip(_tmp);
            Assert.AreEqual(0, moduleLINES.NoOfLines);
        }

        [TestMethod]
        public void OpenFileXmlZip_ValidZip_InvalidXmlInEntry_ResetsAllCounts()
        {
            moduleLINES.NoOfLines = 4;
            using (FileStream fs = new FileStream(_tmp, FileMode.Create))
            using (var archive = new ZipArchive(fs, ZipArchiveMode.Create))
            {
                ZipArchiveEntry entry = archive.CreateEntry(moduleFILE_IO.ZipEntryName);
                using (StreamWriter sw = new StreamWriter(entry.Open()))
                    sw.Write("THIS IS NOT XML <<<>>>");
            }

            moduleFILE_IO.OpenFileXmlZip(_tmp);
            Assert.AreEqual(0, moduleLINES.NoOfLines);
        }

        [TestMethod]
        public void SaveFileXmlZip_NoTmpFileLeftAfterSuccess()
        {
            moduleMAIN.ProjectName = "No Temp Leak";
            moduleFILE_IO.SaveFileXmlZip(_tmp);
            Assert.IsFalse(File.Exists(_tmp + ".tmp"));
        }


        // ==========================================================
        //  I D E M P O T E N C E
        // ==========================================================

        [TestMethod]
        public void SaveLoadSaveLoad_ZipIdempotentRoundTrip()
        {
            moduleMAIN.ProjectName = "Zip Idempotent";
            moduleMAIN.Zoom = 8;
            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine(
                "Idem", "RDW", "{ID}", System.Drawing.Color.Cyan.ToArgb(),
                (51.5, -0.1, 0, 25));

            string tmp2 = _tmp + "_2.sbp";
            try
            {
                moduleFILE_IO.SaveProject(_tmp);
                TestState.Reset();
                moduleFILE_IO.LoadProject(_tmp);

                moduleFILE_IO.SaveProject(tmp2);
                TestState.Reset();
                moduleFILE_IO.LoadProject(tmp2);

                Assert.AreEqual("Zip Idempotent", moduleMAIN.ProjectName);
                Assert.AreEqual(8, moduleMAIN.Zoom);
                Assert.AreEqual(1, moduleLINES.NoOfLines);
                Assert.AreEqual("Idem", moduleLINES.Lines[1].Name);
            }
            finally
            {
                if (File.Exists(tmp2)) File.Delete(tmp2);
            }
        }
    }
}
