using System;
using System.Drawing;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBuilderXX;

namespace SBuilderXX.Tests
{
    [TestClass]
    public class XmlSaveLoadTests
    {
        private string _tmpFile;

        [TestInitialize]
        public void SetUp()
        {
            _tmpFile = Path.Combine(Path.GetTempPath(),
                                    "sbxx_test_" + Guid.NewGuid() + ".xml");
            TestState.Reset();
        }

        [TestCleanup]
        public void TearDown()
        {
            if (File.Exists(_tmpFile))
                File.Delete(_tmpFile);
            TestState.Reset();
        }


        // ==========================================================
        //  H E A D E R
        // ==========================================================

        [TestMethod]
        public void Header_AllFields_RoundTrip()
        {
            moduleMAIN.ProjectName = "My Test Project";
            moduleMAIN.BGLProjectFolder = @"C:\Scenery\LPPT";
            moduleMAIN.Zoom = 7;
            moduleMAIN.LatDispCenter = 38.7813203;
            moduleMAIN.LonDispCenter = -9.136076;
            moduleMAIN.QMIDLevel = 9;

            SaveAndReload();

            Assert.AreEqual("My Test Project", moduleMAIN.ProjectName);
            Assert.AreEqual(@"C:\Scenery\LPPT", moduleMAIN.BGLProjectFolder);
            Assert.AreEqual(7, moduleMAIN.Zoom);
            Assert.AreEqual(38.7813203, moduleMAIN.LatDispCenter, 1e-10);
            Assert.AreEqual(-9.136076, moduleMAIN.LonDispCenter, 1e-10);
            Assert.AreEqual(9, moduleMAIN.QMIDLevel);
        }

        [TestMethod]
        public void Header_EmptyProjectName_RoundTrip()
        {
            moduleMAIN.ProjectName = string.Empty;
            SaveAndReload();
            Assert.AreEqual(string.Empty, moduleMAIN.ProjectName);
        }

        [TestMethod]
        public void Header_ProjectNameWithXmlSpecialChars_RoundTrip()
        {
            moduleMAIN.ProjectName = "Test <Project> & \"Quotes\"";
            SaveAndReload();
            Assert.AreEqual("Test <Project> & \"Quotes\"", moduleMAIN.ProjectName);
        }

        [TestMethod]
        public void Header_NegativeCoordinates_RoundTrip()
        {
            moduleMAIN.LatDispCenter = -33.8688;
            moduleMAIN.LonDispCenter = 151.2093;
            SaveAndReload();
            Assert.AreEqual(-33.8688, moduleMAIN.LatDispCenter, 1e-10);
            Assert.AreEqual(151.2093, moduleMAIN.LonDispCenter, 1e-10);
        }

        [TestMethod]
        public void Header_ExtremeCoordinates_RoundTrip()
        {
            moduleMAIN.LatDispCenter = -90.0;
            moduleMAIN.LonDispCenter = 180.0;
            SaveAndReload();
            Assert.AreEqual(-90.0, moduleMAIN.LatDispCenter, 1e-15);
            Assert.AreEqual(180.0, moduleMAIN.LonDispCenter, 1e-15);
        }


        // ==========================================================
        //  M A P S
        // ==========================================================

        [TestMethod]
        public void Maps_ZeroMaps_RoundTrip()
        {
            moduleMAPS.NoOfMaps = 0;
            SaveAndReload();
            Assert.AreEqual(0, moduleMAPS.NoOfMaps);
        }

        [TestMethod]
        public void Maps_SingleMap_RoundTrip()
        {
            moduleMAPS.NoOfMaps = 1;
            moduleMAPS.Maps = new moduleMAPS.Map[2];
            moduleMAPS.Maps[1].Name = "Summer Map";
            moduleMAPS.Maps[1].BMPSu = @"C:\Tex\summer.bmp";
            moduleMAPS.Maps[1].BMPSp = @"C:\Tex\spring.bmp";
            moduleMAPS.Maps[1].BMPFa = @"C:\Tex\fall.bmp";
            moduleMAPS.Maps[1].BMPWi = @"C:\Tex\winter.bmp";
            moduleMAPS.Maps[1].BMPHw = @"C:\Tex\hardwinter.bmp";
            moduleMAPS.Maps[1].BMPLm = @"C:\Tex\lm.bmp";
            moduleMAPS.Maps[1].COLS = 256;
            moduleMAPS.Maps[1].ROWS = 256;
            moduleMAPS.Maps[1].NLAT = 39.0;
            moduleMAPS.Maps[1].SLAT = 38.0;
            moduleMAPS.Maps[1].ELON = -8.0;
            moduleMAPS.Maps[1].WLON = -10.0;

            SaveAndReload();

            Assert.AreEqual(1, moduleMAPS.NoOfMaps);
            Assert.AreEqual("Summer Map", moduleMAPS.Maps[1].Name);
            Assert.AreEqual(@"C:\Tex\summer.bmp", moduleMAPS.Maps[1].BMPSu);
            Assert.AreEqual(256, moduleMAPS.Maps[1].COLS);
            Assert.AreEqual(256, moduleMAPS.Maps[1].ROWS);
            Assert.AreEqual(39.0, moduleMAPS.Maps[1].NLAT, 1e-10);
            Assert.AreEqual(-10.0, moduleMAPS.Maps[1].WLON, 1e-10);
        }

        [TestMethod]
        public void Maps_MultipleMaps_CountPreserved()
        {
            moduleMAPS.NoOfMaps = 3;
            moduleMAPS.Maps = new moduleMAPS.Map[4];
            for (int i = 1; i <= 3; i++)
                moduleMAPS.Maps[i].Name = "Map_" + i;

            SaveAndReload();

            Assert.AreEqual(3, moduleMAPS.NoOfMaps);
            Assert.AreEqual("Map_1", moduleMAPS.Maps[1].Name);
            Assert.AreEqual("Map_2", moduleMAPS.Maps[2].Name);
            Assert.AreEqual("Map_3", moduleMAPS.Maps[3].Name);
        }


        // ==========================================================
        //  L I N E S
        // ==========================================================

        [TestMethod]
        public void Lines_ZeroLines_RoundTrip()
        {
            moduleLINES.NoOfLines = 0;
            SaveAndReload();
            Assert.AreEqual(0, moduleLINES.NoOfLines);
        }

        [TestMethod]
        public void Lines_SingleLine_AllFieldsRoundTrip()
        {
            int argb = Color.FromArgb(255, 0, 128, 255).ToArgb();
            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine(
                "Test Line", "RDW",
                "{12345678-1234-1234-1234-123456789ABC}",
                argb,
                (38.78, -9.13, 0.0, 50.0),
                (38.79, -9.12, 10.0, 60.0),
                (38.80, -9.11, 20.0, 70.0));

            SaveAndReload();

            Assert.AreEqual(1, moduleLINES.NoOfLines);
            var l = moduleLINES.Lines[1];
            Assert.AreEqual("Test Line", l.Name);
            Assert.AreEqual("RDW", l.Type);
            Assert.AreEqual("{12345678-1234-1234-1234-123456789ABC}", l.Guid);
            Assert.AreEqual(argb, l.ColorArgb);
            Assert.AreEqual(3, l.NoOfPoints);
            Assert.AreEqual(38.78, l.GLPoints[1].lat, 1e-10);
            Assert.AreEqual(-9.13, l.GLPoints[1].lon, 1e-10);
            Assert.AreEqual(0.0, l.GLPoints[1].alt, 1e-10);
            Assert.AreEqual(50.0, l.GLPoints[1].wid, 1e-10);
            Assert.AreEqual(38.80, l.GLPoints[3].lat, 1e-10);
            Assert.AreEqual(20.0, l.GLPoints[3].alt, 1e-10);
        }

        [TestMethod]
        public void Lines_BoundingBox_RecalculatedCorrectly()
        {
            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine("BB", "", "{}", 0,
                (10.0, 20.0, 0, 0),
                (30.0, -10.0, 0, 0),
                (20.0, 50.0, 0, 0));

            SaveAndReload();

            var l = moduleLINES.Lines[1];
            Assert.AreEqual(30.0, l.NLAT, 1e-10);
            Assert.AreEqual(10.0, l.SLAT, 1e-10);
            Assert.AreEqual(50.0, l.ELON, 1e-10);
            Assert.AreEqual(-10.0, l.WLON, 1e-10);
        }

        [TestMethod]
        public void Lines_EmptyName_GetsAutoName()
        {
            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine("", "", "{}", 0,
                (1.0, 2.0, 0, 0), (3.0, 4.0, 0, 0));

            SaveAndReload();

            Assert.IsFalse(string.IsNullOrEmpty(moduleLINES.Lines[1].Name),
                "Empty line name should be auto-filled after reload");
        }

        [TestMethod]
        public void Lines_MultipleLines_IndependentData()
        {
            moduleLINES.NoOfLines = 2;
            moduleLINES.Lines = new moduleLINES.GLine[3];
            moduleLINES.Lines[1] = TestState.MakeLine("Line A", "T1", "{AA}", Color.Red.ToArgb(),
                (1.0, 2.0, 0, 10));
            moduleLINES.Lines[2] = TestState.MakeLine("Line B", "T2", "{BB}", Color.Blue.ToArgb(),
                (5.0, 6.0, 100, 20), (7.0, 8.0, 200, 30));

            SaveAndReload();

            Assert.AreEqual(2, moduleLINES.NoOfLines);
            Assert.AreEqual("Line A", moduleLINES.Lines[1].Name);
            Assert.AreEqual(1, moduleLINES.Lines[1].NoOfPoints);
            Assert.AreEqual("Line B", moduleLINES.Lines[2].Name);
            Assert.AreEqual(2, moduleLINES.Lines[2].NoOfPoints);
            Assert.AreEqual(100.0, moduleLINES.Lines[2].GLPoints[1].alt, 1e-10);
        }

        [TestMethod]
        public void Lines_HighPrecisionCoordinates_NoLoss()
        {
            double precLat = 38.781320312500000123;
            double precLon = -9.136076000000000456;

            moduleLINES.NoOfLines = 1;
            moduleLINES.Lines = new moduleLINES.GLine[2];
            moduleLINES.Lines[1] = TestState.MakeLine("Prec", "", "{}", 0,
                (precLat, precLon, 0, 0));

            SaveAndReload();

            Assert.AreEqual(precLat, moduleLINES.Lines[1].GLPoints[1].lat, 1e-15);
            Assert.AreEqual(precLon, moduleLINES.Lines[1].GLPoints[1].lon, 1e-15);
        }


        // ==========================================================
        //  P O L Y G O N S
        // ==========================================================

        [TestMethod]
        public void Polys_ZeroPolys_RoundTrip()
        {
            modulePOLYS.NoOfPolys = 0;
            SaveAndReload();
            Assert.AreEqual(0, modulePOLYS.NoOfPolys);
        }

        [TestMethod]
        public void Polys_SinglePoly_AllFieldsRoundTrip()
        {
            int argb = Color.FromArgb(128, 255, 255, 0).ToArgb();
            modulePOLYS.NoOfPolys = 1;
            modulePOLYS.Polys = new modulePOLYS.GPoly[2];
            modulePOLYS.Polys[1] = TestState.MakePoly(
                "Test Poly", "LCP",
                "{ABCDEF01-1234-1234-1234-ABCDEF012345}",
                argb,
                (38.0, -9.0, 5.0), (38.1, -9.1, 5.0), (38.0, -9.1, 5.0));

            SaveAndReload();

            Assert.AreEqual(1, modulePOLYS.NoOfPolys);
            var p = modulePOLYS.Polys[1];
            Assert.AreEqual("Test Poly", p.Name);
            Assert.AreEqual("LCP", p.Type);
            Assert.AreEqual("{ABCDEF01-1234-1234-1234-ABCDEF012345}", p.Guid);
            Assert.AreEqual(argb, p.ColorArgb);
            Assert.AreEqual(3, p.NoOfPoints);
            Assert.AreEqual(38.0, p.GPoints[1].lat, 1e-10);
            Assert.AreEqual(-9.0, p.GPoints[1].lon, 1e-10);
            Assert.AreEqual(5.0, p.GPoints[1].alt, 1e-10);
        }

        [TestMethod]
        public void Polys_WithChildRefs_RoundTrip()
        {
            modulePOLYS.NoOfPolys = 2;
            modulePOLYS.Polys = new modulePOLYS.GPoly[3];
            modulePOLYS.Polys[1] = TestState.MakePoly("Parent", "LCP", "{P1}", 0,
                (1.0, 1.0, 0), (2.0, 1.0, 0), (2.0, 2.0, 0));
            modulePOLYS.Polys[1].NoOfChilds = 1;
            modulePOLYS.Polys[1].Childs = new int[2] { 0, 2 };
            modulePOLYS.Polys[2] = TestState.MakePoly("Child", "LCP", "{P2}", 0,
                (1.1, 1.1, 0), (1.9, 1.1, 0), (1.9, 1.9, 0));

            SaveAndReload();

            Assert.AreEqual(2, modulePOLYS.NoOfPolys);
            Assert.AreEqual(1, modulePOLYS.Polys[1].NoOfChilds);
            Assert.AreEqual(2, modulePOLYS.Polys[1].Childs[1]);
        }

        [TestMethod]
        public void Polys_BoundingBox_RecalculatedCorrectly()
        {
            modulePOLYS.NoOfPolys = 1;
            modulePOLYS.Polys = new modulePOLYS.GPoly[2];
            modulePOLYS.Polys[1] = TestState.MakePoly("BB", "", "{}", 0,
                (-10.0, -20.0, 0), (10.0, 20.0, 0));

            SaveAndReload();

            var p = modulePOLYS.Polys[1];
            Assert.AreEqual(10.0, p.NLAT, 1e-10);
            Assert.AreEqual(-10.0, p.SLAT, 1e-10);
            Assert.AreEqual(20.0, p.ELON, 1e-10);
            Assert.AreEqual(-20.0, p.WLON, 1e-10);
        }


        // ==========================================================
        //  E X C L U D E S
        // ==========================================================

        [TestMethod]
        public void Excludes_ZeroExcludes_RoundTrip()
        {
            moduleEXCLUDES.NoOfExcludes = 0;
            SaveAndReload();
            Assert.AreEqual(0, moduleEXCLUDES.NoOfExcludes);
        }

        [TestMethod]
        public void Excludes_SingleExclude_RoundTrip()
        {
            moduleEXCLUDES.NoOfExcludes = 1;
            moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[2];
            moduleEXCLUDES.Excludes[1].Flag = 7;
            moduleEXCLUDES.Excludes[1].NLAT = 39.5;
            moduleEXCLUDES.Excludes[1].SLAT = 38.5;
            moduleEXCLUDES.Excludes[1].ELON = -8.0;
            moduleEXCLUDES.Excludes[1].WLON = -10.0;

            SaveAndReload();

            Assert.AreEqual(1, moduleEXCLUDES.NoOfExcludes);
            Assert.AreEqual(7, moduleEXCLUDES.Excludes[1].Flag);
            Assert.AreEqual(39.5, moduleEXCLUDES.Excludes[1].NLAT, 1e-10);
            Assert.AreEqual(-10.0, moduleEXCLUDES.Excludes[1].WLON, 1e-10);
        }

        [TestMethod]
        public void Excludes_MultipleExcludes_CountPreserved()
        {
            moduleEXCLUDES.NoOfExcludes = 3;
            moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[4];
            for (int i = 1; i <= 3; i++)
                moduleEXCLUDES.Excludes[i].Flag = i * 10;

            SaveAndReload();

            Assert.AreEqual(3, moduleEXCLUDES.NoOfExcludes);
            Assert.AreEqual(10, moduleEXCLUDES.Excludes[1].Flag);
            Assert.AreEqual(20, moduleEXCLUDES.Excludes[2].Flag);
            Assert.AreEqual(30, moduleEXCLUDES.Excludes[3].Flag);
        }


        // ==========================================================
        //  O B J E C T S
        // ==========================================================

        [TestMethod]
        public void Objects_ZeroObjects_RoundTrip()
        {
            moduleOBJECTS.NoOfObjects = 0;
            SaveAndReload();
            Assert.AreEqual(0, moduleOBJECTS.NoOfObjects);
        }

        [TestMethod]
        public void Objects_SingleObject_AllFieldsRoundTrip()
        {
            moduleOBJECTS.NoOfObjects = 1;
            moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[2];
            moduleOBJECTS.Objects[1].Type = 3;
            moduleOBJECTS.Objects[1].Description = "Test Windsock";
            moduleOBJECTS.Objects[1].Width = 5.5f;
            moduleOBJECTS.Objects[1].Length = 12.3f;
            moduleOBJECTS.Objects[1].Heading = 270.0f;
            moduleOBJECTS.Objects[1].Pitch = 0.0f;
            moduleOBJECTS.Objects[1].Bank = 0.0f;
            moduleOBJECTS.Objects[1].BiasX = 0.1f;
            moduleOBJECTS.Objects[1].BiasY = 0.2f;
            moduleOBJECTS.Objects[1].BiasZ = 0.3f;
            moduleOBJECTS.Objects[1].lat = 38.7813203;
            moduleOBJECTS.Objects[1].lon = -9.136076;
            moduleOBJECTS.Objects[1].Altitude = 100.0f;
            moduleOBJECTS.Objects[1].AGL = 1;
            moduleOBJECTS.Objects[1].Complexity = 2;

            SaveAndReload();

            Assert.AreEqual(1, moduleOBJECTS.NoOfObjects);
            var o = moduleOBJECTS.Objects[1];
            Assert.AreEqual(3, o.Type);
            Assert.AreEqual("Test Windsock", o.Description);
            Assert.AreEqual(5.5f, o.Width, 1e-5f);
            Assert.AreEqual(12.3f, o.Length, 1e-5f);
            Assert.AreEqual(270.0f, o.Heading, 1e-5f);
            Assert.AreEqual(0.1f, o.BiasX, 1e-5f);
            Assert.AreEqual(38.7813203, o.lat, 1e-10);
            Assert.AreEqual(-9.136076, o.lon, 1e-10);
            Assert.AreEqual(100.0f, o.Altitude, 1e-5f);
            Assert.AreEqual(1, o.AGL);
            Assert.AreEqual(2, o.Complexity);
        }

        [TestMethod]
        public void Objects_DescriptionWithSpecialChars_RoundTrip()
        {
            moduleOBJECTS.NoOfObjects = 1;
            moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[2];
            moduleOBJECTS.Objects[1].Description = "Sign: \"Arrivals & Departures\" <Gate 3>";

            SaveAndReload();

            Assert.AreEqual("Sign: \"Arrivals & Departures\" <Gate 3>",
                moduleOBJECTS.Objects[1].Description);
        }

        [TestMethod]
        public void Objects_Altitude_PreservesDoubleNotFloat()
        {
            double precAlt = 12345.6789012345;

            moduleOBJECTS.NoOfObjects = 1;
            moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[2];
            moduleOBJECTS.Objects[1].lat = 51.477;
            moduleOBJECTS.Objects[1].lon = -0.001;
            moduleOBJECTS.Objects[1].Altitude = precAlt;

            SaveAndReload();

            Assert.AreEqual(precAlt, moduleOBJECTS.Objects[1].Altitude, 1e-9,
                "Altitude must round-trip as double, not float");
        }


        // ==========================================================
        //  L W C I s
        // ==========================================================

        [TestMethod]
        public void LWCIs_Zero_RoundTrip()
        {
            moduleCLASSES.NoOfLWCIs = 0;
            SaveAndReload();
            Assert.AreEqual(0, moduleCLASSES.NoOfLWCIs);
        }

        [TestMethod]
        public void LWCIs_SingleEntry_RoundTrip()
        {
            moduleCLASSES.NoOfLWCIs = 1;
            moduleCLASSES.LWCIs = new moduleCLASSES.LWCIndex[2];
            moduleCLASSES.LWCIs[1].Text = "LAND 11 11 11";
            moduleCLASSES.LWCIs[1].ColorArgb = Color.Red.ToArgb();

            SaveAndReload();

            Assert.AreEqual(1, moduleCLASSES.NoOfLWCIs);
            Assert.AreEqual("LAND 11 11 11", moduleCLASSES.LWCIs[1].Text);
            Assert.AreEqual(Color.Red.ToArgb(), moduleCLASSES.LWCIs[1].ColorArgb);
        }


        // ==========================================================
        //  L A N D  /  W A T E R   C L A S S E S
        // ==========================================================

        [TestMethod]
        public void LandClasses_Zero_RoundTrip()
        {
            moduleCLASSES.NoOfLLXYs = 0;
            SaveAndReload();
            Assert.AreEqual(0, moduleCLASSES.NoOfLLXYs);
            Assert.AreEqual(0, moduleCLASSES.NoOfLands);
        }

        [TestMethod]
        public void LandClasses_SingleCell_RoundTrip()
        {
            moduleCLASSES.NoOfLLXYs = 1;
            moduleCLASSES.LLands = new byte[257, 257, 1];
            moduleCLASSES.LL_XY[5, 3].Pointer = 0;
            moduleCLASSES.LL_XY[5, 3].NoOfLWs = 2;

            byte lcByte1 = moduleCLASSES.ILC[11];
            byte lcByte2 = moduleCLASSES.ILC[12];
            moduleCLASSES.LLands[10, 20, 0] = lcByte1;
            moduleCLASSES.LLands[30, 40, 0] = lcByte2;
            moduleCLASSES.NoOfLands = 2;

            SaveAndReload();

            Assert.AreEqual(1, moduleCLASSES.NoOfLLXYs);
            Assert.AreEqual(2, moduleCLASSES.NoOfLands);
            Assert.AreEqual(0, moduleCLASSES.LL_XY[5, 3].Pointer);
            Assert.AreEqual(2, moduleCLASSES.LL_XY[5, 3].NoOfLWs);
            Assert.AreEqual(lcByte1, moduleCLASSES.LLands[10, 20, 0]);
            Assert.AreEqual(lcByte2, moduleCLASSES.LLands[30, 40, 0]);
        }

        [TestMethod]
        public void WaterClasses_Zero_RoundTrip()
        {
            moduleCLASSES.NoOfWWXYs = 0;
            SaveAndReload();
            Assert.AreEqual(0, moduleCLASSES.NoOfWWXYs);
            Assert.AreEqual(0, moduleCLASSES.NoOfWaters);
        }

        [TestMethod]
        public void WaterClasses_SingleCell_RoundTrip()
        {
            moduleCLASSES.NoOfWWXYs = 1;
            moduleCLASSES.WWaters = new byte[257, 257, 1];
            moduleCLASSES.WW_XY[7, 2].Pointer = 0;
            moduleCLASSES.WW_XY[7, 2].NoOfLWs = 1;

            byte wcByte = moduleCLASSES.IWC[1];
            moduleCLASSES.WWaters[50, 60, 0] = wcByte;
            moduleCLASSES.NoOfWaters = 1;

            SaveAndReload();

            Assert.AreEqual(1, moduleCLASSES.NoOfWWXYs);
            Assert.AreEqual(1, moduleCLASSES.NoOfWaters);
            Assert.AreEqual(wcByte, moduleCLASSES.WWaters[50, 60, 0]);
        }


        // ==========================================================
        //  F I L E - L E V E L   B E H A V I O U R
        // ==========================================================

        [TestMethod]
        public void OpenFileXml_FileNotFound_DoesNotThrow()
        {
            TestState.AssertDoesNotThrow(
                () => moduleFILE_IO.OpenFileXml(@"C:\does_not_exist_sbxx_test.xml"));
        }

        [TestMethod]
        public void OpenFileXml_InvalidXml_ResetsAllCounts()
        {
            moduleLINES.NoOfLines = 5;
            File.WriteAllText(_tmpFile, "THIS IS NOT XML <<<>>>");
            moduleFILE_IO.OpenFileXml(_tmpFile);

            Assert.AreEqual(0, moduleMAPS.NoOfMaps);
            Assert.AreEqual(0, moduleLINES.NoOfLines);
            Assert.AreEqual(0, modulePOLYS.NoOfPolys);
            Assert.AreEqual(0, moduleOBJECTS.NoOfObjects);
            Assert.AreEqual(0, moduleEXCLUDES.NoOfExcludes);
        }

        [TestMethod]
        public void OpenFileXml_WrongVersionTag_ResetsAllCounts()
        {
            File.WriteAllText(_tmpFile,
                "<?xml version=\"1.0\"?>" +
                "<SBuilderProject version=\"TOTALLY_DIFFERENT_APP_1.0\">" +
                "<Header><n>X</n></Header>" +
                "</SBuilderProject>");

            moduleFILE_IO.OpenFileXml(_tmpFile);
            Assert.AreEqual(0, moduleLINES.NoOfLines);
        }

        [TestMethod]
        public void SaveFileXml_CreatesFile()
        {
            moduleMAIN.ProjectName = "File Creation Test";
            moduleFILE_IO.SaveFileXml(_tmpFile);
            Assert.IsTrue(File.Exists(_tmpFile), "SaveFileXml must create the output file");
            Assert.IsTrue(new FileInfo(_tmpFile).Length > 0, "Output file must not be empty");
        }

        [TestMethod]
        public void SaveFileXml_ProducesValidXml()
        {
            moduleMAIN.ProjectName = "XML Valid Test";
            moduleFILE_IO.SaveFileXml(_tmpFile);
            TestState.AssertDoesNotThrow(
                () => System.Xml.Linq.XDocument.Load(_tmpFile),
                "Saved file must be well-formed XML");
        }

        [TestMethod]
        public void SaveAndLoad_ComplexProject_FullRoundTrip()
        {
            moduleMAIN.ProjectName = "Complex Round-Trip";
            moduleMAIN.BGLProjectFolder = @"D:\MSFS\Scenery\LPPT";
            moduleMAIN.Zoom = 8;
            moduleMAIN.LatDispCenter = 38.7813203;
            moduleMAIN.LonDispCenter = -9.136076;
            moduleMAIN.QMIDLevel = 7;

            moduleMAPS.NoOfMaps = 1;
            moduleMAPS.Maps = new moduleMAPS.Map[2];
            moduleMAPS.Maps[1].Name = "Base Map";
            moduleMAPS.Maps[1].COLS = 512; moduleMAPS.Maps[1].ROWS = 512;
            moduleMAPS.Maps[1].NLAT = 39.0; moduleMAPS.Maps[1].SLAT = 38.0;
            moduleMAPS.Maps[1].ELON = -8.5; moduleMAPS.Maps[1].WLON = -9.5;

            moduleLINES.NoOfLines = 2;
            moduleLINES.Lines = new moduleLINES.GLine[3];
            moduleLINES.Lines[1] = TestState.MakeLine("Road A", "RDW", "{GUID-1}", Color.Red.ToArgb(),
                (38.0, -9.0, 0, 30), (38.1, -9.1, 0, 30));
            moduleLINES.Lines[2] = TestState.MakeLine("Road B", "RDW", "{GUID-2}", Color.Blue.ToArgb(),
                (38.2, -9.2, 5, 20), (38.3, -9.3, 5, 20), (38.4, -9.4, 5, 20));

            modulePOLYS.NoOfPolys = 1;
            modulePOLYS.Polys = new modulePOLYS.GPoly[2];
            modulePOLYS.Polys[1] = TestState.MakePoly("Flattn", "FLX", "{GUID-P1}",
                Color.Yellow.ToArgb(),
                (38.5, -9.0, 50), (38.6, -9.0, 50), (38.6, -9.1, 50), (38.5, -9.1, 50));

            moduleEXCLUDES.NoOfExcludes = 1;
            moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[2];
            moduleEXCLUDES.Excludes[1].Flag = 3;
            moduleEXCLUDES.Excludes[1].NLAT = 39.0;
            moduleEXCLUDES.Excludes[1].SLAT = 38.0;
            moduleEXCLUDES.Excludes[1].ELON = -8.5;
            moduleEXCLUDES.Excludes[1].WLON = -9.5;

            moduleOBJECTS.NoOfObjects = 1;
            moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[2];
            moduleOBJECTS.Objects[1].Type = 1;
            moduleOBJECTS.Objects[1].Description = "Wind Cone";
            moduleOBJECTS.Objects[1].Heading = 90.0f;
            moduleOBJECTS.Objects[1].lat = 38.75;
            moduleOBJECTS.Objects[1].lon = -9.10;
            moduleOBJECTS.Objects[1].Altitude = 110.0f;
            moduleOBJECTS.Objects[1].AGL = 1;

            SaveAndReload();

            Assert.AreEqual("Complex Round-Trip", moduleMAIN.ProjectName);
            Assert.AreEqual(8, moduleMAIN.Zoom);
            Assert.AreEqual(1, moduleMAPS.NoOfMaps);
            Assert.AreEqual("Base Map", moduleMAPS.Maps[1].Name);
            Assert.AreEqual(512, moduleMAPS.Maps[1].COLS);
            Assert.AreEqual(2, moduleLINES.NoOfLines);
            Assert.AreEqual("Road A", moduleLINES.Lines[1].Name);
            Assert.AreEqual(2, moduleLINES.Lines[1].NoOfPoints);
            Assert.AreEqual("Road B", moduleLINES.Lines[2].Name);
            Assert.AreEqual(3, moduleLINES.Lines[2].NoOfPoints);
            Assert.AreEqual(1, modulePOLYS.NoOfPolys);
            Assert.AreEqual("Flattn", modulePOLYS.Polys[1].Name);
            Assert.AreEqual(4, modulePOLYS.Polys[1].NoOfPoints);
            Assert.AreEqual(1, moduleEXCLUDES.NoOfExcludes);
            Assert.AreEqual(3, moduleEXCLUDES.Excludes[1].Flag);
            Assert.AreEqual(1, moduleOBJECTS.NoOfObjects);
            Assert.AreEqual("Wind Cone", moduleOBJECTS.Objects[1].Description);
            Assert.AreEqual(90.0f, moduleOBJECTS.Objects[1].Heading, 1e-4f);
        }


        // ==========================================================
        //  H E L P E R
        // ==========================================================

        private void SaveAndReload()
        {
            moduleFILE_IO.SaveFileXml(_tmpFile);
            TestState.Reset();
            moduleFILE_IO.OpenFileXml(_tmpFile);
        }
    }
}
