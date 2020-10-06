using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SBuilderXX
{
    static class moduleFILE_IO
    {
        private struct LegacyPoly
        {
            public int LClass;
            public string Guid;
        }

        private static LegacyPoly[] LegacyPolys;
        private static int NoOfLegacyPolys;

        private struct LegacyLine
        {
            public int Legacy;
            public string Guid;
            public string Type;
        }

        private static LegacyLine[] LegacyLines;
        private static int NoOfLegacyLines;
        internal static string SBPDir;
        internal static string SBXDir;
        internal static string SURDir;
        internal static string OBJDir;
        internal static string RAWDir;
        internal static string LIBDir;
        internal static string TEXDir;
        internal static string BMPDir;
        internal static string SHPDir;
        internal static string KMLDir;
        internal static string BackUpFileName;
        internal static int BackUpSeconds;
        internal static int BackUpFileCounter;
        internal const string SettingsKey = "Settings"; // INI File Key constant.
        internal static string[] RecentFiles = new string[5];

        internal static void GetSettings()
        {
            Dictionary<string, string> IniSettings = new Dictionary<string, string>();

            try
            {
                // [Main]
                IniSettings.Add("LonIniCenter", (-9.136076).ToString());
                IniSettings.Add("LatIniCenter", (38.7813203).ToString());
                IniSettings.Add("DecimalDegrees", "False");
                IniSettings.Add("MeasuringMeters", "True");
                IniSettings.Add("BGLFolder", My.MyProject.Application.Info.DirectoryPath + @"\Scenery");
                IniSettings.Add("OriginalTerrainCFG", "False");
                IniSettings.Add("NameOfSim", "FSX");
                IniSettings.Add("SimPath", My.MyProject.Application.Info.DirectoryPath + @"\Tools");

                // [Edit]
                IniSettings.Add("BackUpON", "False");
                IniSettings.Add("BackUpSeconds", "60");
                IniSettings.Add("AskDelete", "True");
                IniSettings.Add("ShowAbout", "True");
                IniSettings.Add("BorderON", "True");
                IniSettings.Add("ShowLabels", "True");
                IniSettings.Add("SelectedPointColor", ArgbFromColor(Color.Green));
                IniSettings.Add("UnselectedPointColor", ArgbFromColor(Color.Red));

                // [Misc]
                IniSettings.Add("AutoLinePolyJoin", "False");
                IniSettings.Add("DisplayJoin", "True");
                IniSettings.Add("DirJoin", "True");
                IniSettings.Add("NameJoin", "True");
                IniSettings.Add("NoEndsSmooth", "True");
                IniSettings.Add("CornerSmooth", "True");
                IniSettings.Add("SampleDistance", "10");
                IniSettings.Add("SmoothDistance", "50");
                IniSettings.Add("DefaultLC", "11");
                IniSettings.Add("DefaultWC", "12");
                // IniSettings.Add("DemoAppId01082013GAL", "Here_app_id")
                // IniSettings.Add("AJKnXv84fjrb0KIHawS0Tg", "Here_app_code")
                IniSettings.Add("GoogleMapsAPI", "");
                IniSettings.Add("MakeSlopeXY", "False");

                // [Grid]
                IniSettings.Add("GridColor", ArgbFromColor(Color.Green));
                IniSettings.Add("GridLODColor", ArgbFromColor(Color.Red));
                IniSettings.Add("GridWidth", "1");
                IniSettings.Add("ZoomOnQMID", "True");
                IniSettings.Add("CenterOnMouseWheel", "False");

                // [Aircraft]
                IniSettings.Add("ShowAircraftPeriod", "5000");
                IniSettings.Add("AircraftAltitudeOffset", (0.5).ToString());
                IniSettings.Add("ExtraExtrusionAltitude", "-20M");

                // [Objects]
                IniSettings.Add("Rwy12Path", My.MyProject.Application.Info.DirectoryPath + @"\Rwy12");
                IniSettings.Add("MacroAPIPath", My.MyProject.Application.Info.DirectoryPath + @"\API");
                IniSettings.Add("MacroASDPath", My.MyProject.Application.Info.DirectoryPath + @"\ASD");
                IniSettings.Add("LibObjectsPath", My.MyProject.Application.Info.DirectoryPath + @"\LibObjects");

                // [Lines]
                IniSettings.Add("DefaultLineAltitude", "0");
                IniSettings.Add("DefaultLineWidth", "50");
                IniSettings.Add("LinePenWidth", "1");
                IniSettings.Add("SelectedLineColor", ArgbFromColor(Color.Green));
                IniSettings.Add("DefaultLineColor", ArgbFromColor(Color.Blue));
                IniSettings.Add("MakeClosedLineFromPoly", "False");

                // [Polys]
                IniSettings.Add("DefaultPolyAltitude", "0");
                IniSettings.Add("PolyPenWidth", "1");
                IniSettings.Add("PolyFILL", "True");
                IniSettings.Add("DefaultPolyColor", "80FFFF00");
                IniSettings.Add("PolyColorBorder", ArgbFromColor(Color.Black));

                // [Shapes]
                IniSettings.Add("ShapeLineGuid", "{89ABCDEF-EDCB-A987-6543-210FEDCBA000}");
                IniSettings.Add("ShapeLineAltitude", "0");
                IniSettings.Add("ShapeLineWidth", "50");
                IniSettings.Add("ShapeLineColor", ArgbFromColor(Color.Blue));
                IniSettings.Add("ShapePolyGuid", "{9ABCDEF0-FEDC-BA98-7654-3210FEDCB000}");
                IniSettings.Add("ShapePolyAltitude", "0");
                IniSettings.Add("ShapePolyColor", ArgbFromColor(Color.Pink));
                IniSettings.Add("AddToCells", "True");

                // [Tiles]
                IniSettings.Add("ActiveTileFolder", "");
                IniSettings.Add("ReprojectMercatorTiles", "True");
                IniSettings.Add("SummerVariations", "July,August,September");
                IniSettings.Add("SpringVariations", "April,May,June");
                IniSettings.Add("FallVariations", "October,November");
                IniSettings.Add("WinterVariations", "December,February,March");
                IniSettings.Add("HardWinterVariations", "January");
                IniSettings.Add("CompressionQuality", "85");

                // [BLN]
                IniSettings.Add("BLNSeparator", ",");
                IniSettings.Add("BLNPolyGuid", "{9ABCDEF0-FEDC-BA98-7654-3210FEDCB000}");
                IniSettings.Add("BLNPolyColor", ArgbFromColor(Color.Red));
                IniSettings.Add("BLNLineGuid", "{89ABCDEF-EDCB-A987-6543-210FEDCBA000}");
                IniSettings.Add("BLNLineColor", ArgbFromColor(Color.Red));
                IniSettings.Add("BLNIsPolyAlt", "True");
                IniSettings.Add("BLNIsLineAlt", "True");
                IniSettings.Add("BLNStartWidth", "35");
                IniSettings.Add("BLNEndWidth", "35");
                IniSettings.Add("BLNLineFromPoly", "True");
                IniSettings.Add("BLNExportAltitudes", "True");

                // [RecentDirs]
                IniSettings.Add("SBPDir", "");
                IniSettings.Add("SBXDir", "");
                IniSettings.Add("SHPDir", "");
                IniSettings.Add("SURDir", "");
                IniSettings.Add("TEXDir", "");
                IniSettings.Add("BMPDir", "");
                IniSettings.Add("OBJDir", "");
                IniSettings.Add("RAWDir", "");
                IniSettings.Add("LIBDir", "");
                IniSettings.Add("KMLDir", "");
                IniSettings.Add("RecentFile1", "");
                IniSettings.Add("RecentFile2", "");
                IniSettings.Add("RecentFile3", "");
                IniSettings.Add("RecentFile4", "");
                string myLine, A, B;
                int N;
                if (File.Exists(moduleMAIN.AppIni))
                {
                    File.Copy(moduleMAIN.AppIni, moduleMAIN.AppPath + @"\SBuilderXX_backup.ini", true);
                    using (var file = File.OpenText(moduleMAIN.AppIni))
                    {
                        while ((myLine = file.ReadLine()) != null)
                        {
                            N = myLine.IndexOf("=");
                            if (N != -1)
                            {
                                A = myLine.Substring(0, N);
                                if (IniSettings.ContainsKey(A))
                                {
                                    B = myLine.Substring(N + 1);
                                    IniSettings.Remove(A);
                                    IniSettings.Add(A, B);
                                }
                            }
                        }
                    }
                }

                // [Main]
                moduleMAIN.LonIniCenter = Convert.ToDouble(IniSettings["LonIniCenter"]);
                moduleMAIN.LatIniCenter = Convert.ToDouble(IniSettings["LatIniCenter"]);
                moduleMAIN.DecimalDegrees = Convert.ToBoolean(IniSettings["DecimalDegrees"]);
                moduleMAIN.MeasuringMeters = Convert.ToBoolean(IniSettings["MeasuringMeters"]);
                moduleMAIN.BGLFolder = IniSettings["BGLFolder"];
                moduleMAIN.OriginalTerrainCFG = Convert.ToBoolean(IniSettings["OriginalTerrainCFG"]);
                moduleMAIN.NameOfSim = IniSettings["NameOfSim"];
                moduleMAIN.SimPath = IniSettings["SimPath"];

                // [Edit]
                moduleEDIT.BackUpON = Convert.ToBoolean(IniSettings["BackUpON"]);
                BackUpSeconds = (int)Convert.ToDouble(IniSettings["BackUpSeconds"]);
                moduleMAPS.BorderON = Convert.ToBoolean(IniSettings["BorderON"]);
                moduleMAIN.AskDelete = Convert.ToBoolean(IniSettings["AskDelete"]);
                moduleMAIN.ShowAbout = Convert.ToBoolean(IniSettings["ShowAbout"]);
                moduleMAIN.ShowLabels = Convert.ToBoolean(IniSettings["ShowLabels"]);
                modulePOINTS.SelectedPointColor = ColorFromArgb(IniSettings["SelectedPointColor"]);
                modulePOINTS.UnselectedPointColor = ColorFromArgb(IniSettings["UnselectedPointColor"]);

                // [Misc]
                moduleLINES.AutoLinePolyJoin = Convert.ToBoolean(IniSettings["AutoLinePolyJoin"]);
                moduleLINES.DisplayJoin = Convert.ToBoolean(IniSettings["DisplayJoin"]);
                moduleLINES.DirJoin = Convert.ToBoolean(IniSettings["DirJoin"]);
                moduleLINES.NameJoin = Convert.ToBoolean(IniSettings["NameJoin"]);
                moduleMAIN.NoEndsSmooth = Convert.ToBoolean(IniSettings["NoEndsSmooth"]);
                moduleMAIN.CornerSmooth = Convert.ToBoolean(IniSettings["CornerSmooth"]);
                moduleMAIN.SampleDistance = Convert.ToDouble(IniSettings["SampleDistance"]);
                moduleMAIN.SmoothDistance = Convert.ToDouble(IniSettings["SmoothDistance"]);
                moduleCLASSES.DefaultLC = Convert.ToByte(IniSettings["DefaultLC"]);
                moduleCLASSES.DefaultWC = Convert.ToByte(IniSettings["DefaultWC"]);
                // Here_app_id = CStr(IniSettings.Item("Here_app_id"))
                // Here_app_code = CStr(IniSettings.Item("Here_app_code"))
                moduleMAPS.GoogleMapsAPI = IniSettings["GoogleMapsAPI"];
                moduleMAIN.MakeSlopeXY = Convert.ToBoolean(IniSettings["MakeSlopeXY"]);

                // [Grid]
                moduleMAIN.GridColor = ColorFromArgb(IniSettings["GridColor"]);
                moduleMAIN.GridLODColor = ColorFromArgb(IniSettings["GridLODColor"]);
                moduleMAIN.GridWidth = (int)Convert.ToDouble(IniSettings["GridWidth"]);
                moduleMAIN.ZoomOnQMID = Convert.ToBoolean(IniSettings["ZoomOnQMID"]);
                if (moduleMAIN.GridWidth > 2)
                    moduleMAIN.GridWidth = 2;
                moduleMAIN.CenterOnMouseWheel = Convert.ToBoolean(IniSettings["CenterOnMouseWheel"]);

                // [Aircraft]
                moduleMAIN.ShowAircraftPeriod = (int)Convert.ToDouble(IniSettings["ShowAircraftPeriod"]);
                moduleMAIN.AircraftAltitudeOffset = Convert.ToDouble(IniSettings["AircraftAltitudeOffset"]);
                moduleLINES.ExtraExtrusionAltitude = IniSettings["ExtraExtrusionAltitude"];

                // [Objects]
                moduleOBJECTS.Rwy12Path = IniSettings["Rwy12Path"];
                moduleMACROS.MacroAPIPath = IniSettings["MacroAPIPath"];
                moduleMACROS.MacroASDPath = IniSettings["MacroASDPath"];
                moduleOBJECTS.LibObjectsPath = IniSettings["LibObjectsPath"];

                // [Lines]
                moduleLINES.DefaultLineAltitude = Convert.ToDouble(IniSettings["DefaultLineAltitude"]);
                moduleLINES.DefaultLineWidth = Convert.ToDouble(IniSettings["DefaultLineWidth"]);
                moduleLINES.LinePenWidth = (int)Convert.ToDouble(IniSettings["LinePenWidth"]);
                if (moduleLINES.LinePenWidth > 2)
                    moduleLINES.LinePenWidth = 2;
                moduleLINES.SelectedLineColor = ColorFromArgb(IniSettings["SelectedLineColor"]);
                moduleLINES.DefaultLineColor = ColorFromArgb(IniSettings["DefaultLineColor"]);
                modulePOLYS.MakeClosedLineFromPoly = Convert.ToBoolean(IniSettings["MakeClosedLineFromPoly"]);

                // [Polys]
                modulePOLYS.DefaultPolyAltitude = Convert.ToDouble(IniSettings["DefaultPolyAltitude"]);
                modulePOLYS.PolyPenWidth = (int)Convert.ToDouble(IniSettings["PolyPenWidth"]);
                if (modulePOLYS.PolyPenWidth > 2)
                    modulePOLYS.PolyPenWidth = 2;
                modulePOLYS.PolyFILL = Convert.ToBoolean(IniSettings["PolyFILL"]);
                modulePOLYS.DefaultPolyColor = ColorFromArgb(IniSettings["DefaultPolyColor"]);
                modulePOLYS.PolyColorBorder = ColorFromArgb(IniSettings["PolyColorBorder"]);

                // [Shapes]
                moduleSHAPE.ShapeLineGuid = IniSettings["ShapeLineGuid"];
                moduleSHAPE.ShapeLineAltitude = Convert.ToDouble(IniSettings["ShapeLineAltitude"]);
                moduleSHAPE.ShapeLineWidth = Convert.ToDouble(IniSettings["ShapeLineWidth"]);
                moduleSHAPE.ShapeLineColor = ColorFromArgb(IniSettings["ShapeLineColor"]);
                moduleSHAPE.ShapePolyGuid = IniSettings["ShapePolyGuid"];
                moduleSHAPE.ShapePolyAltitude = Convert.ToDouble(IniSettings["ShapePolyAltitude"]);
                moduleSHAPE.ShapePolyColor = ColorFromArgb(IniSettings["ShapePolyColor"]);
                moduleSHAPE.AddToCells = Convert.ToBoolean(IniSettings["AddToCells"]);

                // [Tiles]
                moduleTILES.ActiveTileFolder = IniSettings["ActiveTileFolder"];
                moduleTILES.ReprojectMercatorTiles = Convert.ToBoolean(IniSettings["ReprojectMercatorTiles"]);
                moduleTILES.SummerVariations = IniSettings["SummerVariations"];
                moduleTILES.SpringVariations = IniSettings["SpringVariations"];
                moduleTILES.FallVariations = IniSettings["FallVariations"];
                moduleTILES.WinterVariations = IniSettings["WinterVariations"];
                moduleTILES.HardWinterVariations = IniSettings["HardWinterVariations"];
                moduleTILES.CompressionQuality = (int)Convert.ToSingle(IniSettings["CompressionQuality"]);

                // [BLN]
                moduleSURFER.BLNSeparator = IniSettings["BLNSeparator"];
                if (moduleSURFER.BLNSeparator == "tab")
                    moduleSURFER.BLNSeparator = "\t";
                moduleSURFER.BLNPolyGuid = IniSettings["BLNPolyGuid"];
                moduleSURFER.BLNPolyColor = ColorFromArgb(IniSettings["BLNPolyColor"]);
                moduleSURFER.BLNLineGuid = IniSettings["BLNLineGuid"];
                moduleSURFER.BLNLineColor = ColorFromArgb(IniSettings["BLNLineColor"]);
                moduleSURFER.BLNIsPolyAlt = Convert.ToBoolean(IniSettings["BLNIsPolyAlt"]);
                moduleSURFER.BLNIsLineAlt = Convert.ToBoolean(IniSettings["BLNIsLineAlt"]);
                moduleSURFER.BLNStartWidth = Convert.ToDouble(IniSettings["BLNStartWidth"]);
                moduleSURFER.BLNEndWidth = Convert.ToDouble(IniSettings["BLNEndWidth"]);
                moduleSURFER.BLNLineFromPoly = Convert.ToBoolean(IniSettings["BLNLineFromPoly"]);
                moduleSURFER.BLNExportAltitudes = Convert.ToBoolean(IniSettings["BLNExportAltitudes"]);

                // [RecentDirs]
                SHPDir = IniSettings["SHPDir"];
                SBPDir = IniSettings["SBPDir"];
                SBXDir = IniSettings["SBXDir"];
                SURDir = IniSettings["SURDir"];
                TEXDir = IniSettings["TEXDir"];
                BMPDir = IniSettings["BMPDir"];
                OBJDir = IniSettings["OBJDir"];
                RAWDir = IniSettings["RAWDir"];
                LIBDir = IniSettings["LIBDir"];
                KMLDir = IniSettings["KMLDir"];

                // [RecentFiles]
                RecentFiles[1] = IniSettings["RecentFile1"];
                RecentFiles[2] = IniSettings["RecentFile2"];
                RecentFiles[3] = IniSettings["RecentFile3"];
                RecentFiles[4] = IniSettings["RecentFile4"];

                // PRINT INI FILE
                // **************
                WriteSettings();
                return;
            }
            catch (Exception)
            {
                string A = "Error in reading/writing the INI file! If you can not" + Environment.NewLine;
                A = A + "determine the cause of this error, delete the INI file" + Environment.NewLine;
                A = A + "and SBuilderXX will recreate it! SBuilderXX will stop now!";
                MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0);
            }
        }

        internal static void WriteSettings()
        {
            int NF = FileSystem.FreeFile();
            FileSystem.FileOpen(NF, moduleMAIN.AppIni, OpenMode.Output);
            FileSystem.PrintLine(NF, "[Recent Files]");
            FileSystem.PrintLine(NF, "RecentFile1=" + RecentFiles[1]);
            FileSystem.PrintLine(NF, "RecentFile2=" + RecentFiles[2]);
            FileSystem.PrintLine(NF, "RecentFile3=" + RecentFiles[3]);
            FileSystem.PrintLine(NF, "RecentFile4=" + RecentFiles[4]);
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[RecentDirs]");
            FileSystem.PrintLine(NF, "SBPDir=" + SBPDir);
            FileSystem.PrintLine(NF, "SBXDir=" + SBXDir);
            FileSystem.PrintLine(NF, "SHPDir=" + SHPDir);
            FileSystem.PrintLine(NF, "SURDir=" + SURDir);
            FileSystem.PrintLine(NF, "TEXDir=" + TEXDir);
            FileSystem.PrintLine(NF, "BMPDir=" + BMPDir);
            FileSystem.PrintLine(NF, "OBJDir=" + OBJDir);
            FileSystem.PrintLine(NF, "RAWDir=" + RAWDir);
            FileSystem.PrintLine(NF, "LIBDir=" + LIBDir);
            FileSystem.PrintLine(NF, "KMLDir=" + KMLDir);
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Main]");
            FileSystem.PrintLine(NF, "LonIniCenter=" + moduleMAIN.LonIniCenter.ToString());
            FileSystem.PrintLine(NF, "LatIniCenter=" + moduleMAIN.LatIniCenter.ToString());
            FileSystem.PrintLine(NF, "DecimalDegrees=" + moduleMAIN.DecimalDegrees.ToString());
            FileSystem.PrintLine(NF, "MeasuringMeters=" + moduleMAIN.MeasuringMeters.ToString());
            FileSystem.PrintLine(NF, "BGLFolder=" + moduleMAIN.BGLFolder);
            FileSystem.PrintLine(NF, "OriginalTerrainCFG=" + moduleMAIN.OriginalTerrainCFG.ToString());
            // after October 2017
            FileSystem.PrintLine(NF, "NameOfSim=" + moduleMAIN.NameOfSim);
            FileSystem.PrintLine(NF, "SimPath=" + moduleMAIN.SimPath);
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Edit]");
            FileSystem.PrintLine(NF, "BackUpON=" + moduleEDIT.BackUpON.ToString());
            FileSystem.PrintLine(NF, "BackUpSeconds=" + BackUpSeconds.ToString());
            FileSystem.PrintLine(NF, "AskDelete=" + moduleMAIN.AskDelete.ToString());
            FileSystem.PrintLine(NF, "BorderON=" + moduleMAPS.BorderON.ToString());
            FileSystem.PrintLine(NF, "ShowAbout=" + moduleMAIN.ShowAbout.ToString());
            FileSystem.PrintLine(NF, "ShowLabels=" + moduleMAIN.ShowLabels.ToString());
            FileSystem.PrintLine(NF, "SelectedPointColor=" + ArgbFromColor(modulePOINTS.SelectedPointColor));
            FileSystem.PrintLine(NF, "UnselectedPointColor=" + ArgbFromColor(modulePOINTS.UnselectedPointColor));
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Miscelaneous]");
            FileSystem.PrintLine(NF, "AutoLinePolyJoin=" + moduleLINES.AutoLinePolyJoin.ToString());
            FileSystem.PrintLine(NF, "DisplayJoin=" + moduleLINES.DisplayJoin.ToString());
            FileSystem.PrintLine(NF, "DirJoin=" + moduleLINES.DirJoin.ToString());
            FileSystem.PrintLine(NF, "NameJoin=" + moduleLINES.NameJoin.ToString());
            FileSystem.PrintLine(NF, "NoEndsSmooth=" + moduleMAIN.NoEndsSmooth.ToString());
            FileSystem.PrintLine(NF, "CornerSmooth=" + moduleMAIN.CornerSmooth.ToString());
            FileSystem.PrintLine(NF, "SampleDistance=" + moduleMAIN.SampleDistance.ToString());
            FileSystem.PrintLine(NF, "SmoothDistance=" + moduleMAIN.SmoothDistance.ToString());
            FileSystem.PrintLine(NF, "DefaultLC=" + moduleCLASSES.DefaultLC.ToString());
            FileSystem.PrintLine(NF, "DefaultWC=" + moduleCLASSES.DefaultWC.ToString());
            // PrintLine(NF, "Here_app_id=" & Here_app_id)
            // PrintLine(NF, "Here_app_code=" & Here_app_code)
            FileSystem.PrintLine(NF, "GoogleMapsAPI=" + moduleMAPS.GoogleMapsAPI);
            FileSystem.PrintLine(NF, "MakeSlopeXY=" + moduleMAIN.MakeSlopeXY.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Grids]");
            FileSystem.PrintLine(NF, "GridColor=" + ArgbFromColor(moduleMAIN.GridColor));
            FileSystem.PrintLine(NF, "GridLODColor=" + ArgbFromColor(moduleMAIN.GridLODColor));
            FileSystem.PrintLine(NF, "GridWidth=" + moduleMAIN.GridWidth.ToString());
            FileSystem.PrintLine(NF, "ZoomOnQMID=" + moduleMAIN.ZoomOnQMID.ToString());
            FileSystem.PrintLine(NF, "CenterOnMouseWheel=" + moduleMAIN.CenterOnMouseWheel.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Aircraft]");
            FileSystem.PrintLine(NF, "ShowAircraftPeriod=" + moduleMAIN.ShowAircraftPeriod.ToString());
            FileSystem.PrintLine(NF, "AircraftAltitudeOffset=" + moduleMAIN.AircraftAltitudeOffset.ToString());
            FileSystem.PrintLine(NF, "ExtraExtrusionAltitude=" + moduleLINES.ExtraExtrusionAltitude);
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Objects]");
            FileSystem.PrintLine(NF, "Rwy12Path=" + moduleOBJECTS.Rwy12Path);
            FileSystem.PrintLine(NF, "MacroAPIPath=" + moduleMACROS.MacroAPIPath);
            FileSystem.PrintLine(NF, "MacroASDPath=" + moduleMACROS.MacroASDPath);
            FileSystem.PrintLine(NF, "LibObjectsPath=" + moduleOBJECTS.LibObjectsPath);
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Lines]");
            FileSystem.PrintLine(NF, "DefaultLineAltitude=" + moduleLINES.DefaultLineAltitude.ToString());
            FileSystem.PrintLine(NF, "DefaultLineWidth=" + moduleLINES.DefaultLineWidth.ToString());
            FileSystem.PrintLine(NF, "LinePenWidth=" + moduleLINES.LinePenWidth.ToString());
            FileSystem.PrintLine(NF, "SelectedLineColor=" + ArgbFromColor(moduleLINES.SelectedLineColor));
            FileSystem.PrintLine(NF, "DefaultLineColor=" + ArgbFromColor(moduleLINES.DefaultLineColor));
            FileSystem.PrintLine(NF, "MakeClosedLineFromPoly=" + modulePOLYS.MakeClosedLineFromPoly.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Polys]");
            FileSystem.PrintLine(NF, "DefaultPolyAltitude=" + modulePOLYS.DefaultPolyAltitude.ToString());
            FileSystem.PrintLine(NF, "PolyPenWidth=" + modulePOLYS.PolyPenWidth.ToString());
            FileSystem.PrintLine(NF, "PolyFILL=" + modulePOLYS.PolyFILL.ToString());
            FileSystem.PrintLine(NF, "DefaultPolyColor=" + ArgbFromColor(modulePOLYS.DefaultPolyColor));
            FileSystem.PrintLine(NF, "PolyColorBorder=" + ArgbFromColor(modulePOLYS.PolyColorBorder));
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Shapes]");
            FileSystem.PrintLine(NF, "ShapeLineGuid=" + moduleSHAPE.ShapeLineGuid);
            FileSystem.PrintLine(NF, "ShapeLineAltitude=" + moduleSHAPE.ShapeLineAltitude.ToString());
            FileSystem.PrintLine(NF, "ShapeLineWidth=" + moduleSHAPE.ShapeLineWidth.ToString());
            FileSystem.PrintLine(NF, "ShapeLineColor=" + ArgbFromColor(moduleSHAPE.ShapeLineColor));
            FileSystem.PrintLine(NF, "ShapePolyGuid=" + moduleSHAPE.ShapePolyGuid);
            FileSystem.PrintLine(NF, "ShapePolyAltitude=" + moduleSHAPE.ShapePolyAltitude.ToString());
            FileSystem.PrintLine(NF, "ShapePolyColor=" + ArgbFromColor(moduleSHAPE.ShapePolyColor));
            FileSystem.PrintLine(NF, "AddToCells=" + moduleSHAPE.AddToCells.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Tiles]");
            FileSystem.PrintLine(NF, "ActiveTileFolder=" + moduleTILES.ActiveTileFolder);
            FileSystem.PrintLine(NF, "ReprojectMercatorTiles=" + moduleTILES.ReprojectMercatorTiles.ToString());
            FileSystem.PrintLine(NF, "SummerVariations=" + moduleTILES.SummerVariations);
            FileSystem.PrintLine(NF, "SpringVariations=" + moduleTILES.SpringVariations);
            FileSystem.PrintLine(NF, "FallVariations=" + moduleTILES.FallVariations);
            FileSystem.PrintLine(NF, "WinterVariations=" + moduleTILES.WinterVariations);
            FileSystem.PrintLine(NF, "HardWinterVariations=" + moduleTILES.HardWinterVariations);
            FileSystem.PrintLine(NF, "CompressionQuality=" + moduleTILES.CompressionQuality.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[BLN]");
            if (moduleSURFER.BLNSeparator == "\t")
            {
                FileSystem.PrintLine(NF, "BLNSeparator=tab");
            }
            else
            {
                FileSystem.PrintLine(NF, "BLNSeparator=" + moduleSURFER.BLNSeparator);
            }

            FileSystem.PrintLine(NF, "BLNPolyGuid=" + moduleSURFER.BLNPolyGuid);
            FileSystem.PrintLine(NF, "BLNPolyColor=" + ArgbFromColor(moduleSURFER.BLNPolyColor));
            FileSystem.PrintLine(NF, "BLNLineGuid=" + moduleSURFER.BLNLineGuid);
            FileSystem.PrintLine(NF, "BLNLineColor=" + ArgbFromColor(moduleSURFER.BLNLineColor));
            FileSystem.PrintLine(NF, "BLNIsPolyAlt=" + moduleSURFER.BLNIsPolyAlt.ToString());
            FileSystem.PrintLine(NF, "BLNIsLineAlt=" + moduleSURFER.BLNIsLineAlt.ToString());
            FileSystem.PrintLine(NF, "BLNStartWidth=" + moduleSURFER.BLNStartWidth.ToString());
            FileSystem.PrintLine(NF, "BLNEndWidth=" + moduleSURFER.BLNEndWidth.ToString());
            FileSystem.PrintLine(NF, "BLNLineFromPoly=" + moduleSURFER.BLNLineFromPoly.ToString());
            FileSystem.PrintLine(NF, "BLNExportAltitudes=" + moduleSURFER.BLNExportAltitudes.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.FileClose(NF);
        }

        public static void SetRecentFiles()
        {
            RecentFiles[1] = GetString("Recent Files", "RecentFile1", "");
            if (string.IsNullOrEmpty(RecentFiles[1]))
                return;
            My.MyProject.Forms.FrmStart.RecentFileSeparatorMenuItem.Visible = true;
            My.MyProject.Forms.FrmStart.RecentFile1MenuItem.Visible = true;
            My.MyProject.Forms.FrmStart.RecentFile1MenuItem.Text = TrimFile(RecentFiles[1], 35);
            RecentFiles[2] = GetString("Recent Files", "RecentFile2", "");
            if (string.IsNullOrEmpty(RecentFiles[2]))
                return;
            My.MyProject.Forms.FrmStart.RecentFile2MenuItem.Visible = true;
            My.MyProject.Forms.FrmStart.RecentFile2MenuItem.Text = TrimFile(RecentFiles[2], 35);
            RecentFiles[3] = GetString("Recent Files", "RecentFile3", "");
            if (string.IsNullOrEmpty(RecentFiles[3]))
                return;
            My.MyProject.Forms.FrmStart.RecentFile3MenuItem.Visible = true;
            My.MyProject.Forms.FrmStart.RecentFile3MenuItem.Text = TrimFile(RecentFiles[3], 35);
            RecentFiles[4] = GetString("Recent Files", "RecentFile4", "");
            if (string.IsNullOrEmpty(RecentFiles[4]))
                return;
            My.MyProject.Forms.FrmStart.RecentFile4MenuItem.Visible = true;
            My.MyProject.Forms.FrmStart.RecentFile4MenuItem.Text = TrimFile(RecentFiles[4], 35);
        }

        private static string GetString(string A, string B, string C)
        {
            string GetStringRet = default;
            string D, B1;
            B1 = B;
            D = ReadIniValue(moduleMAIN.AppIni, A, ref B1).Trim();
            if (string.IsNullOrEmpty(D))
            {
                WriteIniValue(ref moduleMAIN.AppIni, ref A, ref B, ref C);
                GetStringRet = C;
            }
            else
            {
                GetStringRet = D;
            }

            return GetStringRet;
        }

        internal static void WriteRecentFiles(string OpenFileName)
        {
            int I;
            string strFile, KEY;

            // Copy RecentFile1 to RecentFile2, and so on.
            for (I = 3; I >= 1; I -= 1)
            {
                KEY = "RecentFile" + I;
                strFile = ReadIniValue(moduleMAIN.AppIni, "Recent Files", ref KEY);
                if (!string.IsNullOrEmpty(strFile))
                {
                    KEY = "RecentFile" + (I + 1);
                    string argPutKey = "Recent Files";
                    WriteIniValue(ref moduleMAIN.AppIni, ref argPutKey, ref KEY, ref strFile);
                }
            }
            // Write the open file to first recent file.
            string argPutKey1 = "Recent Files";
            string argPutVariable = "RecentFile1";
            WriteIniValue(ref moduleMAIN.AppIni, ref argPutKey1, ref argPutVariable, ref OpenFileName);
        }

        internal static string ReadIniValue(string INIpath, string KEY, ref string Variable)
        {
            string ReadIniValueRet = default;
            int NF;
            string Temp;
            string LcaseTemp;
            bool ReadyToRead = default(bool);
            NF = FileSystem.FreeFile();
            ReadIniValueRet = "";
            KEY = "[" + KEY.ToLower() + "]";
            Variable = Variable.ToLower();
            FileSystem.FileOpen(NF, INIpath, OpenMode.Binary);
            FileSystem.FileClose(NF);
            FileSystem.SetAttr(INIpath, FileAttribute.Archive);
            FileSystem.FileOpen(NF, INIpath, OpenMode.Input);
            while (!FileSystem.EOF(NF))
            {
                Temp = FileSystem.LineInput(NF);
                LcaseTemp = Temp.ToLower();
                if (LcaseTemp.IndexOf("[") != -1)
                    ReadyToRead = false;
                if ((LcaseTemp ?? "") == (KEY ?? ""))
                    ReadyToRead = true;
                if (LcaseTemp.IndexOf("[") == -1 & ReadyToRead)
                {
                    if (LcaseTemp.IndexOf(Variable + "=") == 0)
                    {
                        ReadIniValueRet = Temp.Substring((Variable + "=").Length);
                        FileSystem.FileClose(NF);
                        return ReadIniValueRet;
                    }
                }
            }

            FileSystem.FileClose(NF);
            return ReadIniValueRet;
        }

        internal static void WriteIniValue(ref string INIpath, ref string PutKey, ref string PutVariable, ref string PutValue)
        {
            string Temp;
            string LcaseTemp;
            string ReadKey;
            string ReadVariable;
            int LOKEY;
            int HIKEY;
            int KEYLEN;
            int VAR;
            int VARENDOFLINE;
            int NF;
            NF = FileSystem.FreeFile();
            ReadKey = Environment.NewLine + "[" + PutKey.ToLower() + "]\r";
            KEYLEN = ReadKey.Length;
            ReadVariable = "\n" + PutVariable.ToLower() + "=";
            FileSystem.FileOpen(NF, INIpath, OpenMode.Binary);
            FileSystem.FileClose(NF);
            FileSystem.SetAttr(INIpath, FileAttribute.Archive);
            FileSystem.FileOpen(NF, INIpath, OpenMode.Input);
            Temp = FileSystem.InputString(NF, (int)FileSystem.LOF(NF));
            Temp = Environment.NewLine + Temp + "[]";
            FileSystem.FileClose(NF);
            LcaseTemp = Temp.ToLower();
            LOKEY = LcaseTemp.IndexOf(ReadKey);
            if (LOKEY == -1)
                goto AddKey;
            HIKEY = LcaseTemp.IndexOf("[", LOKEY + KEYLEN);
            VAR = LcaseTemp.IndexOf(ReadVariable, LOKEY);
            if (VAR > HIKEY | VAR < LOKEY)
                goto AddVariable;
            goto RenewVariable;
        AddKey:
            ;
            Temp = Temp.Substring(0, Temp.Length - 2);
            Temp = Temp + Environment.NewLine + Environment.NewLine + "[" + PutKey + "]" + Environment.NewLine + PutVariable + "=" + PutValue;
            goto TrimFinalString;
        AddVariable:
            ;
            Temp = Temp.Substring(0, Temp.Length - 2);
            Temp = Temp.Substring(0, LOKEY + KEYLEN + 1) + PutVariable + "=" + PutValue + Environment.NewLine + Temp.Substring(LOKEY + KEYLEN + 1);
            goto TrimFinalString;
        RenewVariable:
            ;
            Temp = Temp.Substring(0, Temp.Length - 2);
            VARENDOFLINE = Temp.IndexOf("\r", VAR);
            Temp = Temp.Substring(0, VAR + 1) + PutVariable + "=" + PutValue + Temp.Substring(VARENDOFLINE);
            goto TrimFinalString;
        TrimFinalString:
            ;
            Temp = Temp.Substring(1);
            while (Temp.IndexOf(Environment.NewLine + Environment.NewLine + Environment.NewLine) != -1)
                Temp = Temp.Replace(Environment.NewLine + Environment.NewLine + Environment.NewLine, Environment.NewLine + Environment.NewLine);
            while (string.Compare(Temp.Substring(Temp.Length - 1), "\r") <= 0)
                Temp = Temp.Substring(0, Temp.Length - 1);
            while (string.Compare(Temp.Substring(0, 1), "\r") <= 0)
                Temp = Temp.Substring(1);
            FileSystem.FileOpen(NF, INIpath, OpenMode.Output);
            FileSystem.PrintLine(NF, Temp);
            FileSystem.FileClose(NF);
        }

        private static string TrimFile(string str_file, int N)
        {
            string TrimFileRet = default;
            int K1, K, K2;
            TrimFileRet = str_file;
            K = str_file.Length;
            if (K <= N)
                return TrimFileRet;
            K1 = str_file.IndexOf(@"\", 3);
            K2 = str_file.LastIndexOf(@"\");
            if (K1 + K - K2 > N)
            {
                TrimFileRet = str_file.Substring(0, 3) + ".." + str_file.Substring(K2);
                return TrimFileRet;
            }

            TrimFileRet = str_file.Substring(0, K1 + 1) + ".." + str_file.Substring(K2);
            return TrimFileRet;
        }

        public static string FileNameToOpen(string s_filter, string s_title, string s_dir)
        {
            string FileNameToOpenRet = default;
            string TheDir;

            TheDir = "";
            My.MyProject.Forms.FrmStart.OpenFileDialog1.Filter = s_filter + "|All Files|*.*";
            if (s_dir == "SBX")
                TheDir = SBXDir;
            if (s_dir == "SBP")
                TheDir = SBPDir;
            if (s_dir == "SHP")
                TheDir = SHPDir;
            if (s_dir == "SUR")
                TheDir = SURDir;
            if (s_dir == "TEX")
                TheDir = TEXDir;
            if (s_dir == "OBJ")
                TheDir = OBJDir;
            if (s_dir == "RAW")
                TheDir = RAWDir;
            if (s_dir == "LIB")
                TheDir = LIBDir;
            if (s_dir == "BMP")
                TheDir = BMPDir;
            if (s_dir == "MDL")
                TheDir = moduleMAIN.AppPath + @"\Mdls";

            // MsgBox A$ & "  " & B$ & "  " & TheDir

            My.MyProject.Forms.FrmStart.OpenFileDialog1.InitialDirectory = TheDir;
            My.MyProject.Forms.FrmStart.OpenFileDialog1.FileName = "";
            My.MyProject.Forms.FrmStart.OpenFileDialog1.Title = s_title;
            FileNameToOpenRet = "";
            string cDir = default;
            if (My.MyProject.Forms.FrmStart.OpenFileDialog1.ShowDialog() == DialogResult.OK) // user did not press cancel
            {
                FileNameToOpenRet = My.MyProject.Forms.FrmStart.OpenFileDialog1.FileName;
                My.MyProject.Forms.FrmStart.OpenFileDialog1.Filter = "";
                try
                {
                    cDir = Path.GetDirectoryName(FileNameToOpenRet);
                }
                catch (Exception)
                {
                }
                if (s_dir == "SBX")
                    SBXDir = cDir;
                if (s_dir == "SBP")
                    SBPDir = cDir;
                if (s_dir == "SHP")
                    SHPDir = cDir;
                if (s_dir == "SUR")
                    SURDir = cDir;
                if (s_dir == "TEX")
                    TEXDir = cDir;
                if (s_dir == "OBJ")
                    OBJDir = cDir;
                if (s_dir == "RAW")
                    RAWDir = cDir;
                if (s_dir == "LIB")
                    LIBDir = cDir;
                if (s_dir == "BMP")
                    BMPDir = cDir;
                try
                {
                    WriteSettings();
                }
                catch (Exception)
                {
                }
            }

            My.MyProject.Forms.FrmStart.OpenFileDialog1.Dispose();
            return FileNameToOpenRet;
        }

        public static string FileNameToSave(string s_filter, string s_title, string s_dir)
        {
            string FileNameToSaveRet = default;
            string TheDir, TheFile = default;
            try
            {
                TheFile = Path.GetFileNameWithoutExtension(moduleMAIN.WorkFile);
            }
            catch (Exception)
            {
            }
            TheDir = "";
            if (s_dir == "SBX")
                TheDir = SBXDir;
            if (s_dir == "SBP")
                TheDir = SBPDir;
            if (s_dir == "SHP")
                TheDir = SHPDir;
            if (s_dir == "SUR")
                TheDir = SURDir;
            if (s_dir == "TEX")
                TheDir = TEXDir;
            if (s_dir == "OBJ")
                TheDir = OBJDir;
            if (s_dir == "RAW")
                TheDir = RAWDir;
            if (s_dir == "LIB")
                TheDir = LIBDir;
            if (s_dir == "BMP")
                TheDir = BMPDir;
            My.MyProject.Forms.FrmStart.SaveFileDialog1.Filter = s_filter + "|All Files|*.*";
            My.MyProject.Forms.FrmStart.SaveFileDialog1.InitialDirectory = TheDir;
            My.MyProject.Forms.FrmStart.SaveFileDialog1.FileName = TheFile;  // or A$ ?
            My.MyProject.Forms.FrmStart.SaveFileDialog1.Title = s_title;
            FileNameToSaveRet = "";
            string cDir = default;
            if (My.MyProject.Forms.FrmStart.SaveFileDialog1.ShowDialog() == DialogResult.OK)      // User cancelled dialog
            {
                FileNameToSaveRet = My.MyProject.Forms.FrmStart.SaveFileDialog1.FileName;
                try
                {
                    cDir = Path.GetDirectoryName(FileNameToSaveRet);
                }
                catch (Exception)
                {
                }
                if (s_dir == "SBX")
                    SBXDir = cDir;
                if (s_dir == "SBP")
                    SBPDir = cDir;
                if (s_dir == "SHP")
                    SHPDir = cDir;
                if (s_dir == "SUR")
                    SURDir = cDir;
                if (s_dir == "TEX")
                    TEXDir = cDir;
                if (s_dir == "OBJ")
                    OBJDir = cDir;
                if (s_dir == "RAW")
                    RAWDir = cDir;
                if (s_dir == "LIB")
                    LIBDir = cDir;
                if (s_dir == "BMP")
                    BMPDir = cDir;
                try
                {
                    WriteSettings();
                }
                catch (Exception)
                {
                }
            }

            My.MyProject.Forms.FrmStart.SaveFileDialog1.Dispose();
            return FileNameToSaveRet;
        }

        private static void UpdateFileMenu(string FileName)
        {
            bool retval;

            // check if FileName is already on the list.
            retval = OnRecentFilesList(FileName);
            if (!retval)
            {
                WriteRecentFiles(FileName);
                SetRecentFiles();
            }
        }

        private static bool OnRecentFilesList(string FileName)
        {
            bool OnRecentFilesListRet = default;
            int I;
            OnRecentFilesListRet = false;
            for (I = 1; I <= 4; I++)
            {
                if ((RecentFiles[I] ?? "") == (FileName ?? ""))
                {
                    OnRecentFilesListRet = true;
                    return OnRecentFilesListRet;
                }
            }

            return OnRecentFilesListRet;
        }

        internal static void SetFileBackUp(string filename)
        {
            if (moduleEDIT.BackUpON == false)
                return;
            string ext = Path.GetExtension(filename).ToUpper();
            BackUpFileName = Path.GetDirectoryName(filename);
            BackUpFileName = BackUpFileName + @"\" + Path.GetFileNameWithoutExtension(filename) + "_BAK_";
            if (ext == ".SBP")
                File.Copy(filename, BackUpFileName + "00.SBP", true);
            My.MyProject.Forms.FrmStart.Timer3.Interval = BackUpSeconds * 1000;
            My.MyProject.Forms.FrmStart.Timer3.Enabled = true;
            BackUpFileCounter = 0;
        }

        internal static void OpenFile(string filename)
        {
            int Lixo;
            if (!My.MyProject.Computer.FileSystem.FileExists(filename))
            {
                MessageBox.Show("This file was not found!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            };

            FileStream oFile = default;
            try
            {
                oFile = new FileStream(filename, FileMode.Open);
                BinaryFormatter BFormatter = new BinaryFormatter() { Binder = new SbuilderBinder() };
                string Version;
                Version = Convert.ToString(BFormatter.Deserialize(oFile));
                SetFileBackUp(filename);
                moduleMAIN.ProjectName = Convert.ToString(BFormatter.Deserialize(oFile));
                moduleMAIN.BGLProjectFolder = Convert.ToString(BFormatter.Deserialize(oFile));
                moduleMAIN.CheckFolders();
                double readZoom = Convert.ToDouble(BFormatter.Deserialize(oFile));
                moduleMAIN.Zoom = Convert.ToInt32(readZoom);
                moduleMAIN.LatDispCenter = Convert.ToDouble(BFormatter.Deserialize(oFile));
                moduleMAIN.LonDispCenter = Convert.ToDouble(BFormatter.Deserialize(oFile));
                moduleMAIN.QMIDLevel = Convert.ToInt32(BFormatter.Deserialize(oFile));
                moduleMAPS.NoOfMaps = Convert.ToInt32(BFormatter.Deserialize(oFile));
                moduleCLASSES.NoOfLands = Convert.ToInt32(BFormatter.Deserialize(oFile));
                Lixo = Convert.ToInt32(BFormatter.Deserialize(oFile));
                moduleLINES.NoOfLines = Convert.ToInt32(BFormatter.Deserialize(oFile));
                modulePOLYS.NoOfPolys = Convert.ToInt32(BFormatter.Deserialize(oFile));
                moduleCLASSES.NoOfWaters = Convert.ToInt32(BFormatter.Deserialize(oFile));
                moduleOBJECTS.NoOfObjects = Convert.ToInt32(BFormatter.Deserialize(oFile));
                moduleEXCLUDES.NoOfExcludes = Convert.ToInt32(BFormatter.Deserialize(oFile));
                Lixo = Convert.ToInt32(BFormatter.Deserialize(oFile));
                moduleCLASSES.NoOfLWCIs = 0;
                if (!(Version == "SB301"))
                    moduleCLASSES.NoOfLWCIs = Convert.ToInt32(BFormatter.Deserialize(oFile));
                if (moduleMAPS.NoOfMaps > 0)
                    moduleMAPS.Maps = (moduleMAPS.Map[])BFormatter.Deserialize(oFile);
                if (moduleCLASSES.NoOfLands > 0)
                {
                    moduleCLASSES.NoOfLLXYs = Convert.ToInt32(BFormatter.Deserialize(oFile));
                    moduleCLASSES.LL_XY = (moduleCLASSES.LWXY[,])BFormatter.Deserialize(oFile);
                    moduleCLASSES.LLands = (byte[,,])BFormatter.Deserialize(oFile);
                }

                if (moduleLINES.NoOfLines > 0)
                    moduleLINES.Lines = (moduleLINES.GLine[])BFormatter.Deserialize(oFile);
                if (modulePOLYS.NoOfPolys > 0)
                    modulePOLYS.Polys = (modulePOLYS.GPoly[])BFormatter.Deserialize(oFile);
                if (moduleCLASSES.NoOfWaters > 0)
                {
                    moduleCLASSES.NoOfWWXYs = Convert.ToInt32(BFormatter.Deserialize(oFile));
                    moduleCLASSES.WW_XY = (moduleCLASSES.LWXY[,])BFormatter.Deserialize(oFile);
                    moduleCLASSES.WWaters = (byte[,,])BFormatter.Deserialize(oFile);
                }

                if (moduleOBJECTS.NoOfObjects > 0)
                    moduleOBJECTS.Objects = (moduleOBJECTS.Objecto[])BFormatter.Deserialize(oFile);
                if (moduleEXCLUDES.NoOfExcludes > 0)
                    moduleEXCLUDES.Excludes = (moduleEXCLUDES.Exclude[])BFormatter.Deserialize(oFile);
                if (moduleCLASSES.NoOfLWCIs > 0)
                    moduleCLASSES.LWCIs = (moduleCLASSES.LWCIndex[])BFormatter.Deserialize(oFile);
                oFile.Close();
            }
            catch (Exception)
            {
                oFile.Close();
                MessageBox.Show("This file is not a SBuilderXX 3.XX project!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                moduleMAPS.NoOfMaps = 0;
                moduleCLASSES.NoOfLands = 0;
                moduleLINES.NoOfLines = 0;
                modulePOLYS.NoOfPolys = 0;
                moduleCLASSES.NoOfWaters = 0;
                moduleOBJECTS.NoOfObjects = 0;
                moduleEXCLUDES.NoOfExcludes = 0;
                moduleCLASSES.NoOfLWCIs = 0;
                return;
            }
            UpdateFileMenu(filename);
            return;
        }

        internal static void SaveFile(string filename)
        {
            FileStream sFile = new FileStream(filename, FileMode.Create);
            BinaryFormatter BFormatter = new BinaryFormatter();
            BFormatter.Serialize(sFile, "SBXX316");
            BFormatter.Serialize(sFile, moduleMAIN.ProjectName);
            BFormatter.Serialize(sFile, moduleMAIN.BGLProjectFolder);
            double savedZoom = Convert.ToDouble(moduleMAIN.Zoom);
            BFormatter.Serialize(sFile, savedZoom);
            BFormatter.Serialize(sFile, moduleMAIN.LatDispCenter);
            BFormatter.Serialize(sFile, moduleMAIN.LonDispCenter);
            BFormatter.Serialize(sFile, moduleMAIN.QMIDLevel);
            BFormatter.Serialize(sFile, moduleMAPS.NoOfMaps);
            BFormatter.Serialize(sFile, moduleCLASSES.NoOfLands);
            BFormatter.Serialize(sFile, 0);
            BFormatter.Serialize(sFile, moduleLINES.NoOfLines);
            BFormatter.Serialize(sFile, modulePOLYS.NoOfPolys);
            BFormatter.Serialize(sFile, moduleCLASSES.NoOfWaters);
            BFormatter.Serialize(sFile, moduleOBJECTS.NoOfObjects);
            BFormatter.Serialize(sFile, moduleEXCLUDES.NoOfExcludes);
            BFormatter.Serialize(sFile, 0);
            BFormatter.Serialize(sFile, moduleCLASSES.NoOfLWCIs); // inserted in SB302
            if (moduleMAPS.NoOfMaps > 0)
                BFormatter.Serialize(sFile, moduleMAPS.Maps);
            if (moduleCLASSES.NoOfLands > 0)
            {
                BFormatter.Serialize(sFile, moduleCLASSES.NoOfLLXYs);
                BFormatter.Serialize(sFile, moduleCLASSES.LL_XY);
                BFormatter.Serialize(sFile, moduleCLASSES.LLands);
            }

            if (moduleLINES.NoOfLines > 0)
                BFormatter.Serialize(sFile, moduleLINES.Lines);
            if (modulePOLYS.NoOfPolys > 0)
                BFormatter.Serialize(sFile, modulePOLYS.Polys);
            if (moduleCLASSES.NoOfWaters > 0)
            {
                BFormatter.Serialize(sFile, moduleCLASSES.NoOfWWXYs);
                BFormatter.Serialize(sFile, moduleCLASSES.WW_XY);
                BFormatter.Serialize(sFile, moduleCLASSES.WWaters);
            }

            if (moduleOBJECTS.NoOfObjects > 0)
                BFormatter.Serialize(sFile, moduleOBJECTS.Objects);
            if (moduleEXCLUDES.NoOfExcludes > 0)
                BFormatter.Serialize(sFile, moduleEXCLUDES.Excludes);
            if (moduleCLASSES.NoOfLWCIs > 0)
                BFormatter.Serialize(sFile, moduleCLASSES.LWCIs); // in sb302
            sFile.Close();
        }

        internal static void ExportSBX(string FileName)
        {
            int M, N, FN;
            string KEY;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            FN = FileSystem.FreeFile();
            FileSystem.FileOpen(FN, FileName, OpenMode.Output);
            FileSystem.PrintLine(FN, "[Main]");
            FileSystem.PrintLine(FN, "CopyRight=" + "MRPRINT SBXX316");
            FileSystem.PrintLine(FN, "Name=" + moduleMAIN.ProjectName);
            FileSystem.PrintLine(FN, "NoOfMaps=" + moduleMAPS.NoOfMaps);
            FileSystem.PrintLine(FN, "NoOfLines=" + moduleLINES.NoOfLines);
            FileSystem.PrintLine(FN, "NoOfPolys=" + modulePOLYS.NoOfPolys);
            FileSystem.PrintLine(FN, "NoOfLC_LOD5s=" + moduleCLASSES.NoOfLLXYs);
            FileSystem.PrintLine(FN, "NoOfWC_LOD5s=" + moduleCLASSES.NoOfWWXYs);
            FileSystem.PrintLine(FN, "NoOfObjects=" + moduleOBJECTS.NoOfObjects);
            FileSystem.PrintLine(FN, "NoOfExcludes=" + moduleEXCLUDES.NoOfExcludes);
            FileSystem.PrintLine(FN, "NoOfLWCIs=" + moduleCLASSES.NoOfLWCIs);
            FileSystem.PrintLine(FN, "BGLProjectFolder=" + moduleMAIN.BGLProjectFolder);
            FileSystem.PrintLine(FN, "LatDispCenter=" + moduleMAIN.LatDispCenter.ToString());
            FileSystem.PrintLine(FN, "LonDispCenter=" + moduleMAIN.LonDispCenter.ToString());
            FileSystem.PrintLine(FN, "Zoom=" + moduleMAIN.Zoom);
            int loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Map." + N.ToString().Trim() + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Name=" + moduleMAPS.Maps[N].Name);
                FileSystem.PrintLine(FN, "BMPSu=" + moduleMAPS.Maps[N].BMPSu);
                FileSystem.PrintLine(FN, "BMPSp=" + moduleMAPS.Maps[N].BMPSp);
                FileSystem.PrintLine(FN, "BMPFa=" + moduleMAPS.Maps[N].BMPFa);
                FileSystem.PrintLine(FN, "BMPWi=" + moduleMAPS.Maps[N].BMPWi);
                FileSystem.PrintLine(FN, "BMPHw=" + moduleMAPS.Maps[N].BMPHw);
                FileSystem.PrintLine(FN, "BMPLm=" + moduleMAPS.Maps[N].BMPLm);
                FileSystem.PrintLine(FN, "Cols=" + moduleMAPS.Maps[N].COLS.ToString());
                FileSystem.PrintLine(FN, "Rows=" + moduleMAPS.Maps[N].ROWS.ToString());
                FileSystem.PrintLine(FN, "NLat=" + moduleMAPS.Maps[N].NLAT.ToString());
                FileSystem.PrintLine(FN, "SLat=" + moduleMAPS.Maps[N].SLAT.ToString());
                FileSystem.PrintLine(FN, "ELon=" + moduleMAPS.Maps[N].ELON.ToString());
                FileSystem.PrintLine(FN, "WLon=" + moduleMAPS.Maps[N].WLON.ToString());
            }

            int loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Line." + N.ToString().Trim() + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Name=" + moduleLINES.Lines[N].Name);
                FileSystem.PrintLine(FN, "Type=" + moduleLINES.Lines[N].Type);
                FileSystem.PrintLine(FN, "Guid=" + moduleLINES.Lines[N].Guid);
                FileSystem.PrintLine(FN, "Color=" + ArgbFromColor(moduleLINES.Lines[N].Color));
                FileSystem.PrintLine(FN, "NoOfPoints=" + moduleLINES.Lines[N].NoOfPoints.ToString());
                int loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                for (M = 1; M <= loopTo2; M++)
                {
                    FileSystem.PrintLine(FN, "Lat" + M.ToString().Trim() + "=" + moduleLINES.Lines[N].GLPoints[M].lat.ToString());
                    FileSystem.PrintLine(FN, "Lon" + M.ToString().Trim() + "=" + moduleLINES.Lines[N].GLPoints[M].lon.ToString());
                    FileSystem.PrintLine(FN, "Alt" + M + "=" + moduleLINES.Lines[N].GLPoints[M].alt.ToString());
                    FileSystem.PrintLine(FN, "Wid" + M + "=" + moduleLINES.Lines[N].GLPoints[M].wid.ToString());
                }
            }

            int loopTo3 = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo3; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Poly." + N.ToString().Trim() + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Name=" + modulePOLYS.Polys[N].Name);
                FileSystem.PrintLine(FN, "Type=" + modulePOLYS.Polys[N].Type);
                FileSystem.PrintLine(FN, "Guid=" + modulePOLYS.Polys[N].Guid);
                FileSystem.PrintLine(FN, "Color=" + ArgbFromColor(modulePOLYS.Polys[N].Color));
                FileSystem.PrintLine(FN, "NoOfChilds=" + modulePOLYS.Polys[N].NoOfChilds.ToString());
                int loopTo4 = modulePOLYS.Polys[N].NoOfChilds;
                for (M = 1; M <= loopTo4; M++)
                    FileSystem.PrintLine(FN, "Child" + M.ToString().Trim() + "=" + modulePOLYS.Polys[N].Childs[M].ToString());
                FileSystem.PrintLine(FN, "NoOfPoints=" + modulePOLYS.Polys[N].NoOfPoints.ToString());
                int loopTo5 = modulePOLYS.Polys[N].NoOfPoints;
                for (M = 1; M <= loopTo5; M++)
                {
                    FileSystem.PrintLine(FN, "Lat" + M.ToString().Trim() + "=" + modulePOLYS.Polys[N].GPoints[M].lat.ToString());
                    FileSystem.PrintLine(FN, "Lon" + M.ToString().Trim() + "=" + modulePOLYS.Polys[N].GPoints[M].lon.ToString());
                    FileSystem.PrintLine(FN, "Alt" + M.ToString().Trim() + "=" + modulePOLYS.Polys[N].GPoints[M].alt.ToString());
                }
            }

            int J, K, C, R, P;
            string A;
            N = 1;
            if (moduleCLASSES.NoOfLLXYs > 0)
            {
                for (K = 0; K <= 63; K++)
                {
                    for (J = 0; J <= 95; J++)
                    {
                        if (moduleCLASSES.LL_XY[J, K].NoOfLWs > 0)
                        {
                            FileSystem.PrintLine(FN);
                            A = "[LC_LOD5." + N + "]";
                            FileSystem.PrintLine(FN, A);
                            A = "U=" + J.ToString("00");
                            FileSystem.PrintLine(FN, A);
                            A = "V=" + K.ToString("00");
                            FileSystem.PrintLine(FN, A);
                            FileSystem.PrintLine(FN, "NoOfLands=" + moduleCLASSES.LL_XY[J, K].NoOfLWs);
                            P = moduleCLASSES.LL_XY[J, K].Pointer;
                            M = moduleCLASSES.LL_XY[J, K].NoOfLWs;
                            for (R = 0; R <= 256; R++)
                            {
                                for (C = 0; C <= 256; C++)
                                {
                                    if (moduleCLASSES.LLands[C, R, P] > 0)
                                    {
                                        if (!(moduleCLASSES.LLands[C, R, P] == 254))
                                        {
                                            FileSystem.PrintLine(FN, "C" + C.ToString("000") + "R" + R.ToString("000=") + moduleCLASSES.LC[moduleCLASSES.LLands[C, R, P]].Index);
                                        }
                                    }
                                }
                            }

                            N = N + 1;
                        }
                    }
                }
            }

            N = 1;
            if (moduleCLASSES.NoOfWWXYs > 0)
            {
                for (K = 0; K <= 63; K++)
                {
                    for (J = 0; J <= 95; J++)
                    {
                        if (moduleCLASSES.WW_XY[J, K].NoOfLWs > 0)
                        {
                            FileSystem.PrintLine(FN);
                            A = "[WC_LOD5." + N + "]";
                            FileSystem.PrintLine(FN, A);
                            A = "U=" + J.ToString("00");
                            FileSystem.PrintLine(FN, A);
                            A = "V=" + K.ToString("00");
                            FileSystem.PrintLine(FN, A);
                            FileSystem.PrintLine(FN, "NoOfWaters=" + moduleCLASSES.WW_XY[J, K].NoOfLWs);
                            P = moduleCLASSES.WW_XY[J, K].Pointer;
                            M = moduleCLASSES.WW_XY[J, K].NoOfLWs;
                            for (R = 0; R <= 256; R++)
                            {
                                for (C = 0; C <= 256; C++)
                                {
                                    if (moduleCLASSES.WWaters[C, R, P] > 0)
                                    {
                                        if (!(moduleCLASSES.WWaters[C, R, P] == 254))
                                        {
                                            FileSystem.PrintLine(FN, "C" + C.ToString("000") + "R" + R.ToString("000=") + moduleCLASSES.WC[moduleCLASSES.WWaters[C, R, P]].Index);
                                        }
                                    }
                                }
                            }

                            N = N + 1;
                        }
                    }
                }
            }

            int loopTo6 = moduleEXCLUDES.NoOfExcludes;
            for (N = 1; N <= loopTo6; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Exclude." + N.ToString().Trim() + "]";
                FileSystem.PrintLine(FN, KEY);
                // before November 2017 these were CStr()
                FileSystem.PrintLine(FN, "Flag=" + moduleEXCLUDES.Excludes[N].Flag.ToString());
                FileSystem.PrintLine(FN, "NLat=" + moduleEXCLUDES.Excludes[N].NLAT.ToString());
                FileSystem.PrintLine(FN, "SLat=" + moduleEXCLUDES.Excludes[N].SLAT.ToString());
                FileSystem.PrintLine(FN, "ELon=" + moduleEXCLUDES.Excludes[N].ELON.ToString());
                FileSystem.PrintLine(FN, "WLon=" + moduleEXCLUDES.Excludes[N].WLON.ToString());
            }

            int loopTo7 = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo7; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Object." + N.ToString().Trim() + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Type=" + moduleOBJECTS.Objects[N].Type.ToString());
                FileSystem.PrintLine(FN, "Description=" + moduleOBJECTS.Objects[N].Description);
                FileSystem.PrintLine(FN, "Width=" + moduleOBJECTS.Objects[N].Width.ToString());
                FileSystem.PrintLine(FN, "Length=" + moduleOBJECTS.Objects[N].Length.ToString());
                FileSystem.PrintLine(FN, "Heading=" + moduleOBJECTS.Objects[N].Heading.ToString());
                FileSystem.PrintLine(FN, "Pitch=" + moduleOBJECTS.Objects[N].Pitch.ToString());
                FileSystem.PrintLine(FN, "Bank=" + moduleOBJECTS.Objects[N].Bank.ToString());
                FileSystem.PrintLine(FN, "BiasX=" + moduleOBJECTS.Objects[N].BiasX.ToString());
                FileSystem.PrintLine(FN, "BiasY=" + moduleOBJECTS.Objects[N].BiasY.ToString());
                FileSystem.PrintLine(FN, "BiasZ=" + moduleOBJECTS.Objects[N].BiasZ.ToString());
                FileSystem.PrintLine(FN, "Lat=" + moduleOBJECTS.Objects[N].lat.ToString());
                FileSystem.PrintLine(FN, "Lon=" + moduleOBJECTS.Objects[N].lon.ToString());
                FileSystem.PrintLine(FN, "Altitude=" + moduleOBJECTS.Objects[N].Altitude.ToString());
                FileSystem.PrintLine(FN, "AGL=" + moduleOBJECTS.Objects[N].AGL.ToString());
                FileSystem.PrintLine(FN, "Complexity=" + moduleOBJECTS.Objects[N].Complexity.ToString());
            }

            int loopTo8 = moduleCLASSES.NoOfLWCIs;
            for (N = 1; N <= loopTo8; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[LWCI." + N.ToString().Trim() + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Text=" + moduleCLASSES.LWCIs[N].Text);
                FileSystem.PrintLine(FN, "Color=" + ArgbFromColor(moduleCLASSES.LWCIs[N].Color));
            }

            FileSystem.FileClose(FN);
            My.MyProject.Forms.FrmStart.SetMouseIcon();
        }

        internal static void ImportSBX(string Filename)
        {
            int M, N;
            int I, L;
            int J, K, C, R, P;
            string KEY;
            double EL, SL, NL, WL, X;
            string A, Version;
            string argVariable = "CopyRight";
            KEY = ReadIniValue(Filename, "Main", ref argVariable);
            KEY = (KEY.Length < 15) ? KEY : KEY.Substring(0, 15);
            if (KEY == "MRPRINT SBXX316")
            {
                Version = "SBXX316";
            }
            else
            {
                KEY = (KEY.Length < 11) ? KEY : KEY.Substring(0, 11);
                if (KEY == "PTSIM")
                {
                    ImportSBX205(Filename, "");
                    return;
                }

                if (KEY == "PTSIM SB205")
                {
                    ImportSBX205(Filename, "SB205");
                    return;
                }

                if (KEY == "PTSIM SB301")
                {
                    Version = "SB301";
                }
                else if (KEY == "PTSIM SB302")
                {
                    Version = "SB302";
                }
                else if (KEY == "PTSIM SB303")
                {
                    Version = "SB303";
                }
                else if (KEY == "PTSIM SB310")
                {
                    Version = "SB310";
                }
                else if (KEY == "PTSIM SB313")
                {
                    Version = "SB313";
                }
                else if (KEY == "PTSIM SB314")
                {
                    Version = "SB314";
                }
                else
                {
                    MessageBox.Show("Not a Valid SBX SBuilderXX File!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            SetFileBackUp(Filename);
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            string argVariable1 = "Name";
            moduleMAIN.ProjectName = ReadIniValue(Filename, "Main", ref argVariable1);
            moduleMAPS.NoOfMaps = ReadIniInteger(Filename, "Main", "NoOfMaps");
            moduleLINES.NoOfLines = ReadIniInteger(Filename, "Main", "NoOfLines");
            modulePOLYS.NoOfPolys = ReadIniInteger(Filename, "Main", "NoOfPolys");
            moduleCLASSES.NoOfLLXYs = 0;
            moduleCLASSES.NoOfWWXYs = 0;
            if (Version == "SB314" || Version == "SBXX316")
            {
                moduleCLASSES.NoOfLLXYs = ReadIniInteger(Filename, "Main", "NoOfLC_LOD5s");
                moduleCLASSES.NoOfWWXYs = ReadIniInteger(Filename, "Main", "NoOfWC_LOD5s");
            }

            moduleOBJECTS.NoOfObjects = ReadIniInteger(Filename, "Main", "NoOfObjects");
            moduleEXCLUDES.NoOfExcludes = ReadIniInteger(Filename, "Main", "NoOfExcludes");
            moduleCLASSES.NoOfLWCIs = 0;
            if (!(Version == "SB301"))
                moduleCLASSES.NoOfLWCIs = ReadIniInteger(Filename, "Main", "NoOfLWCIs");
            string argVariable2 = "BGLProjectFolder";
            moduleMAIN.BGLProjectFolder = ReadIniValue(Filename, "Main", ref argVariable2);
            moduleMAIN.CheckFolders();
            moduleMAIN.LatDispCenter = ReadIniDouble(Filename, "Main", "LatDispCenter");
            moduleMAIN.LonDispCenter = ReadIniDouble(Filename, "Main", "LonDispCenter");
            moduleMAIN.Zoom = (int)ReadIniDouble(Filename, "Main", "Zoom");
            if (moduleMAPS.NoOfMaps > 0)
                moduleMAPS.Maps = new moduleMAPS.Map[moduleMAPS.NoOfMaps + 1];
            if (moduleLINES.NoOfLines > 0)
                moduleLINES.Lines = new moduleLINES.GLine[moduleLINES.NoOfLines + 1];
            if (modulePOLYS.NoOfPolys > 0)
                modulePOLYS.Polys = new modulePOLYS.GPoly[modulePOLYS.NoOfPolys + 1];
            if (moduleOBJECTS.NoOfObjects > 0)
                moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[moduleOBJECTS.NoOfObjects + 1];
            if (moduleEXCLUDES.NoOfExcludes > 0)
                moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[moduleEXCLUDES.NoOfExcludes + 1];
            if (moduleCLASSES.NoOfLWCIs > 0)
                moduleCLASSES.LWCIs = new moduleCLASSES.LWCIndex[moduleCLASSES.NoOfLWCIs + 1];
            int loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                KEY = "Map." + N.ToString().Trim();
                string argVariable3 = "Name";
                moduleMAPS.Maps[N].Name = ReadIniValue(Filename, KEY, ref argVariable3);
                string argVariable4 = "BMPSu";
                moduleMAPS.Maps[N].BMPSu = ReadIniValue(Filename, KEY, ref argVariable4);
                string argVariable5 = "BMPSp";
                moduleMAPS.Maps[N].BMPSp = ReadIniValue(Filename, KEY, ref argVariable5);
                string argVariable6 = "BMPFa";
                moduleMAPS.Maps[N].BMPFa = ReadIniValue(Filename, KEY, ref argVariable6);
                string argVariable7 = "BMPWi";
                moduleMAPS.Maps[N].BMPWi = ReadIniValue(Filename, KEY, ref argVariable7);
                string argVariable8 = "BMPHw";
                moduleMAPS.Maps[N].BMPHw = ReadIniValue(Filename, KEY, ref argVariable8);
                string argVariable9 = "BMPLm";
                moduleMAPS.Maps[N].BMPLm = ReadIniValue(Filename, KEY, ref argVariable9);
                moduleMAPS.Maps[N].COLS = ReadIniInteger(Filename, KEY, "Cols");
                moduleMAPS.Maps[N].ROWS = ReadIniInteger(Filename, KEY, "Rows");
                moduleMAPS.Maps[N].NLAT = ReadIniDouble(Filename, KEY, "NLat");
                moduleMAPS.Maps[N].SLAT = ReadIniDouble(Filename, KEY, "SLat");
                moduleMAPS.Maps[N].ELON = ReadIniDouble(Filename, KEY, "ELon");
                moduleMAPS.Maps[N].WLON = ReadIniDouble(Filename, KEY, "WLon");
            }

            FileSystem.FileOpen(5, Filename, OpenMode.Input);
            int loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                KEY = "[Line." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleLINES.Lines[N].Name = FileSystem.LineInput(5).Substring(5);
                moduleLINES.Lines[N].Type = FileSystem.LineInput(5).Substring(5);
                moduleLINES.Lines[N].Guid = FileSystem.LineInput(5).Substring(5);
                if (Version == "SB301")
                {
                    moduleLINES.Lines[N].Color = Color.FromArgb(Convert.ToInt32(FileSystem.LineInput(5).Substring(6)));
                }
                else
                {
                    moduleLINES.Lines[N].Color = ColorFromArgb(FileSystem.LineInput(5).Substring(6));
                }

                moduleLINES.Lines[N].NoOfPoints = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                    moduleLINES.Lines[N].Name = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_Imported_Line";
                moduleLINES.Lines[N].GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                int loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                for (M = 1; M <= loopTo2; M++)
                {
                    if (M > 9)
                        J = 7;
                    if (M > 99)
                        J = 8;
                    if (M > 999)
                        J = 9;
                    if (M > 9999)
                        J = 10;
                    if (M > 99999)
                        J = 11;
                    if (M > 999999)
                        J = 12;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    moduleLINES.Lines[N].GLPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    moduleLINES.Lines[N].GLPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    moduleLINES.Lines[N].GLPoints[M].alt = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    moduleLINES.Lines[N].GLPoints[M].wid = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                }

                moduleLINES.Lines[N].ELON = EL;
                moduleLINES.Lines[N].WLON = WL;
                moduleLINES.Lines[N].NLAT = NL;
                moduleLINES.Lines[N].SLAT = SL;
            }

            int loopTo3 = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo3; N++)
            {
                KEY = "[Poly." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                modulePOLYS.Polys[N].Name = FileSystem.LineInput(5).Substring(5);
                modulePOLYS.Polys[N].Type = FileSystem.LineInput(5).Substring(5);
                modulePOLYS.Polys[N].Guid = FileSystem.LineInput(5).Substring(5);
                if (Version == "SB301")
                {
                    modulePOLYS.Polys[N].Color = Color.FromArgb(Convert.ToInt32(FileSystem.LineInput(5).Substring(6)));
                }
                else
                {
                    modulePOLYS.Polys[N].Color = ColorFromArgb(FileSystem.LineInput(5).Substring(6));
                }

                J = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                modulePOLYS.Polys[N].NoOfChilds = J;
                if (J > 0)
                {
                    modulePOLYS.Polys[N].Childs = new int[J + 1];
                }
                else
                {
                    modulePOLYS.Polys[N].Childs = new int[1];
                }

                J = 8;
                int loopTo4 = modulePOLYS.Polys[N].NoOfChilds;
                for (M = 1; M <= loopTo4; M++)
                {
                    if (M > 9)
                        J = 9;
                    if (M > 99)
                        J = 10;
                    if (M > 999)
                        J = 11;
                    if (M > 9999)
                        J = 12;
                    if (M > 99999)
                        J = 13;
                    if (M > 999999)
                        J = 14;
                    modulePOLYS.Polys[N].Childs[M] = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                }

                modulePOLYS.Polys[N].NoOfPoints = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                    modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].NoOfPoints.ToString() + "_Pts_Imported_Polygon";
                modulePOLYS.Polys[N].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                int loopTo5 = modulePOLYS.Polys[N].NoOfPoints;
                for (M = 1; M <= loopTo5; M++)
                {
                    if (M > 9)
                        J = 7;
                    if (M > 99)
                        J = 8;
                    if (M > 999)
                        J = 9;
                    if (M > 9999)
                        J = 10;
                    if (M > 99999)
                        J = 11;
                    if (M > 999999)
                        J = 12;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    modulePOLYS.Polys[N].GPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    modulePOLYS.Polys[N].GPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    modulePOLYS.Polys[N].GPoints[M].alt = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                }

                modulePOLYS.Polys[N].ELON = EL;
                modulePOLYS.Polys[N].WLON = WL;
                modulePOLYS.Polys[N].NLAT = NL;
                modulePOLYS.Polys[N].SLAT = SL;
            }

            if (moduleCLASSES.NoOfLLXYs > 0)
            {
                N = 0;
                moduleCLASSES.LLands = new byte[257, 257, moduleCLASSES.NoOfLLXYs];
                int loopTo6 = moduleCLASSES.NoOfLLXYs;
                for (P = 1; P <= loopTo6; P++)
                {
                    KEY = "[LC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(2));
                    K = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(2));
                    L = Convert.ToInt32(FileSystem.LineInput(5).Substring(10));
                    moduleCLASSES.LL_XY[J, K].Pointer = P - 1;
                    moduleCLASSES.LL_XY[J, K].NoOfLWs = L;
                    int loopTo7 = L;
                    for (M = 1; M <= loopTo7; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Convert.ToDouble(A.Substring(1, 3));
                        R = (int)Convert.ToDouble(A.Substring(5, 3));
                        I = (int)Convert.ToDouble(A.Substring(9));
                        moduleCLASSES.LLands[C, R, P - 1] = moduleCLASSES.ILC[I];
                        N = N + 1;
                    }
                }

                moduleCLASSES.NoOfLands = N;
            }

            if (moduleCLASSES.NoOfWWXYs > 0)
            {
                N = 0;
                moduleCLASSES.WWaters = new byte[257, 257, moduleCLASSES.NoOfWWXYs];
                int loopTo8 = moduleCLASSES.NoOfWWXYs;
                for (P = 1; P <= loopTo8; P++)
                {
                    KEY = "[WC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(2));
                    K = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(2));
                    L = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                    moduleCLASSES.WW_XY[J, K].Pointer = P - 1;
                    moduleCLASSES.WW_XY[J, K].NoOfLWs = L;
                    int loopTo9 = L;
                    for (M = 1; M <= loopTo9; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Convert.ToDouble(A.Substring(1, 3));
                        R = (int)Convert.ToDouble(A.Substring(5, 3));
                        I = (int)Convert.ToDouble(A.Substring(9));
                        moduleCLASSES.WWaters[C, R, P - 1] = moduleCLASSES.IWC[I];
                        N = N + 1;
                    }
                }

                moduleCLASSES.NoOfWaters = N;
            }

            int loopTo10 = moduleEXCLUDES.NoOfExcludes;
            for (N = 1; N <= loopTo10; N++)
            {
                KEY = "[Exclude." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleEXCLUDES.Excludes[N].Flag = Convert.ToInt32(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].NLAT = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].SLAT = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].ELON = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].WLON = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
            }

            int loopTo11 = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo11; N++)
            {
                KEY = "[Object." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleOBJECTS.Objects[N].Type = Convert.ToInt32(FileSystem.LineInput(5).Substring(5));
                moduleOBJECTS.Objects[N].Description = FileSystem.LineInput(5).Substring(12);
                moduleOBJECTS.Objects[N].Width = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].Length = Convert.ToSingle(FileSystem.LineInput(5).Substring(7));
                moduleOBJECTS.Objects[N].Heading = Convert.ToSingle(FileSystem.LineInput(5).Substring(8));
                moduleOBJECTS.Objects[N].Pitch = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].Bank = Convert.ToSingle(FileSystem.LineInput(5).Substring(5));
                moduleOBJECTS.Objects[N].BiasX = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].BiasY = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].BiasZ = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].lat = Convert.ToDouble(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].lon = Convert.ToDouble(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].Altitude = Convert.ToSingle(FileSystem.LineInput(5).Substring(9));
                moduleOBJECTS.Objects[N].AGL = Convert.ToInt32(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].Complexity = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                moduleOBJECTS.AddLatLonToObjects(N);
            }

            int loopTo12 = moduleCLASSES.NoOfLWCIs;
            for (N = 1; N <= loopTo12; N++)
            {
                KEY = "[LWCI." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleCLASSES.LWCIs[N].Text = FileSystem.LineInput(5).Substring(5);
                moduleCLASSES.LWCIs[N].Color = ColorFromArgb(FileSystem.LineInput(5).Substring(6));
            }

            SetLWCIs();
            FileSystem.FileClose(5);
        }

        private static void ImportSBX205(string Filename, string Version)
        {
            int M, N, J;
            string KEY;
            double EL, SL, NL, WL, X;
            Color C;
            int R, G, B;
            bool SB205 = false;
            if (Version == "SB205")
                SB205 = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            string argVariable = "Name";
            moduleMAIN.ProjectName = ReadIniValue(Filename, "Main", ref argVariable);
            moduleMAPS.NoOfMaps = ReadIniInteger(Filename, "Main", "NoOfMaps");
            moduleLINES.NoOfLines = ReadIniInteger(Filename, "Main", "NoOfLines");
            modulePOLYS.NoOfPolys = ReadIniInteger(Filename, "Main", "NoOfPolys");
            moduleOBJECTS.NoOfObjects = ReadIniInteger(Filename, "Main", "NoOfObjects");
            moduleEXCLUDES.NoOfExcludes = ReadIniInteger(Filename, "Main", "NoOfExcludes");
            string argVariable1 = "BGLProjectFolder";
            moduleMAIN.BGLProjectFolder = ReadIniValue(Filename, "Main", ref argVariable1);
            moduleMAIN.CheckFolders();
            moduleMAIN.LatDispCenter = ReadIniDouble(Filename, "Main", "LatDispCenter");
            moduleMAIN.LonDispCenter = ReadIniDouble(Filename, "Main", "LonDispCenter");
            double myZoom = ReadIniDouble(Filename, "Main", "Zoom");
            moduleMAIN.Zoom = (int)(Math.Log(myZoom, 2d) + 9d);
            if (moduleMAPS.NoOfMaps > 0)
                moduleMAPS.Maps = new moduleMAPS.Map[moduleMAPS.NoOfMaps + 1];
            if (moduleLINES.NoOfLines > 0)
            {
                SetLegacyLines();
                moduleLINES.Lines = new moduleLINES.GLine[moduleLINES.NoOfLines + 1];
            }

            if (modulePOLYS.NoOfPolys > 0)
            {
                SetLegacyPolys();
                modulePOLYS.Polys = new modulePOLYS.GPoly[modulePOLYS.NoOfPolys + 1];
            }

            if (moduleOBJECTS.NoOfObjects > 0)
                moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[moduleOBJECTS.NoOfObjects + 1];
            if (moduleEXCLUDES.NoOfExcludes > 0)
                moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[moduleEXCLUDES.NoOfExcludes + 1];
            int loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                KEY = "Map." + N.ToString().Trim();
                string argVariable2 = "Name";
                moduleMAPS.Maps[N].Name = ReadIniValue(Filename, KEY, ref argVariable2);
                string argVariable3 = "BMPSu";
                moduleMAPS.Maps[N].BMPSu = ReadIniValue(Filename, KEY, ref argVariable3);
                string argVariable4 = "BMPSp";
                moduleMAPS.Maps[N].BMPSp = ReadIniValue(Filename, KEY, ref argVariable4);
                string argVariable5 = "BMPFa";
                moduleMAPS.Maps[N].BMPFa = ReadIniValue(Filename, KEY, ref argVariable5);
                string argVariable6 = "BMPWi";
                moduleMAPS.Maps[N].BMPWi = ReadIniValue(Filename, KEY, ref argVariable6);
                string argVariable7 = "BMPHw";
                moduleMAPS.Maps[N].BMPHw = ReadIniValue(Filename, KEY, ref argVariable7);
                string argVariable8 = "BMPLm";
                moduleMAPS.Maps[N].BMPLm = ReadIniValue(Filename, KEY, ref argVariable8);
                moduleMAPS.Maps[N].COLS = ReadIniInteger(Filename, KEY, "COLS0");
                moduleMAPS.Maps[N].ROWS = ReadIniInteger(Filename, KEY, "ROWS0");
                moduleMAPS.Maps[N].NLAT = ReadIniDouble(Filename, KEY, "NLat0");
                moduleMAPS.Maps[N].SLAT = ReadIniDouble(Filename, KEY, "SLat0");
                moduleMAPS.Maps[N].ELON = ReadIniDouble(Filename, KEY, "ELon0");
                moduleMAPS.Maps[N].WLON = ReadIniDouble(Filename, KEY, "WLon0");
            }

            FileSystem.FileOpen(5, Filename, OpenMode.Input);
            int loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                KEY = "[Line." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleLINES.Lines[N].Name = FileSystem.LineInput(5).Substring(5);
                KEY = FileSystem.LineInput(5).Substring(5);
                // Lines(N).Type = Mid(LineInput(5), 6)
                // Lines(N).Guid = Mid(LineInput(5), 6)
                ConvertOldLineType(N, KEY);
                C = Color.FromArgb(Convert.ToInt32(FileSystem.LineInput(5).Substring(6)));
                R = C.R;
                G = C.G;
                B = C.B;
                moduleLINES.Lines[N].Color = Color.FromArgb(B, G, R);
                moduleLINES.Lines[N].NoOfPoints = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                    moduleLINES.Lines[N].Name = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_Imported_Line";
                moduleLINES.Lines[N].GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                int loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                for (M = 1; M <= loopTo2; M++)
                {
                    if (M > 9)
                        J = 7;
                    if (M > 99)
                        J = 8;
                    if (M > 999)
                        J = 9;
                    if (M > 9999)
                        J = 10;
                    if (M > 99999)
                        J = 11;
                    if (M > 999999)
                        J = 12;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));   // latitude
                    moduleLINES.Lines[N].GLPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));  // longitude
                    moduleLINES.Lines[N].GLPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    moduleLINES.Lines[N].GLPoints[M].alt = 0d;
                    moduleLINES.Lines[N].GLPoints[M].wid = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                }

                moduleLINES.Lines[N].ELON = EL;
                moduleLINES.Lines[N].WLON = WL;
                moduleLINES.Lines[N].NLAT = NL;
                moduleLINES.Lines[N].SLAT = SL;
            }

            int loopTo3 = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo3; N++)
            {
                KEY = "[Poly." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                modulePOLYS.Polys[N].Name = FileSystem.LineInput(5).Substring(5);
                KEY = FileSystem.LineInput(5).Substring(5);
                // Polys(N).Type = Mid(LineInput(5), 6)
                // Polys(N).Guid = Mid(LineInput(5), 6)
                ConvertOldPolyType(N, KEY);
                C = Color.FromArgb(Convert.ToInt32(FileSystem.LineInput(5).Substring(6)));
                R = C.R;
                G = C.G;
                B = C.B;
                modulePOLYS.Polys[N].Color = Color.FromArgb(B, G, R);
                modulePOLYS.Polys[N].NoOfChilds = 0;
                // ReDim Polys(N).Childs(Polys(N).NoOfChilds)
                modulePOLYS.Polys[N].NoOfPoints = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                    modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].NoOfPoints.ToString() + "_Pts_Imported_Polygon";
                modulePOLYS.Polys[N].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                int loopTo4 = modulePOLYS.Polys[N].NoOfPoints;
                for (M = 1; M <= loopTo4; M++)
                {
                    if (M > 9)
                        J = 7;
                    if (M > 99)
                        J = 8;
                    if (M > 999)
                        J = 9;
                    if (M > 9999)
                        J = 10;
                    if (M > 99999)
                        J = 11;
                    if (M > 999999)
                        J = 12;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    modulePOLYS.Polys[N].GPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    modulePOLYS.Polys[N].GPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    // *******!!!!
                    if (SB205)
                    {
                        modulePOLYS.Polys[N].GPoints[M].alt = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    }
                    else
                    {
                        modulePOLYS.Polys[N].GPoints[M].alt = 0d;
                    }
                }

                modulePOLYS.Polys[N].ELON = EL;
                modulePOLYS.Polys[N].WLON = WL;
                modulePOLYS.Polys[N].NLAT = NL;
                modulePOLYS.Polys[N].SLAT = SL;
            }

            int loopTo5 = moduleEXCLUDES.NoOfExcludes;
            for (N = 1; N <= loopTo5; N++)
            {
                KEY = "[Exclude." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleEXCLUDES.Excludes[N].Flag = Convert.ToInt32(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].NLAT = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].SLAT = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].ELON = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].WLON = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
            }

            int loopTo6 = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo6; N++)
            {
                KEY = "[Object." + N.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleOBJECTS.Objects[N].Type = Convert.ToInt32(FileSystem.LineInput(5).Substring(5));
                moduleOBJECTS.Objects[N].Description = FileSystem.LineInput(5).Substring(12);
                moduleOBJECTS.Objects[N].Width = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].Length = Convert.ToSingle(FileSystem.LineInput(5).Substring(7));
                moduleOBJECTS.Objects[N].Heading = Convert.ToSingle(FileSystem.LineInput(5).Substring(8));
                moduleOBJECTS.Objects[N].Pitch = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].Bank = Convert.ToSingle(FileSystem.LineInput(5).Substring(5));
                moduleOBJECTS.Objects[N].BiasX = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].BiasY = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].BiasZ = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].lat = Convert.ToDouble(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].lon = Convert.ToDouble(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].Altitude = Convert.ToSingle(FileSystem.LineInput(5).Substring(9));
                moduleOBJECTS.Objects[N].AGL = Convert.ToInt32(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].Complexity = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                moduleOBJECTS.AddLatLonToObjects(N);
            }

            LegacyPolys = new LegacyPoly[2];
            LegacyLines = new LegacyLine[2];
            FileSystem.FileClose(5);
        }

        internal static void AppendSBX(string Filename)
        {
            int K, N, M, J, L;
            string KEY;
            int NoOfMapsX, NoOfLinesX;
            int NoOfObjectsX, NoOfPolysX, NoOfExcludesX;
            int NoOfLWCIsX;
            int NoOfLLXYsX, NoOfWWXYsX;
            double EL, SL, NL, WL, X;
            string argVariable = "CopyRight";
            string Version;
            KEY = ReadIniValue(Filename, "Main", ref argVariable);
            if (KEY == "MRPRINT SBXX316")
            {
                Version = "SBXX316";
            }
            else
            {
                KEY = (KEY.Length < 11) ? KEY : KEY.Substring(0, 11);
                if (KEY == "PTSIM SB205" | KEY == "PTSIM")
                {
                    MessageBox.Show("You can not Append this file! Try to Import it!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (KEY == "PTSIM SB301")
                {
                    Version = "SB301";
                }
                else if (KEY == "PTSIM SB302")
                {
                    Version = "SB302";
                }
                else if (KEY == "PTSIM SB303")
                {
                    Version = "SB303";
                }
                else if (KEY == "PTSIM SB310")
                {
                    Version = "SB310";
                }
                else if (KEY == "PTSIM SB313")
                {
                    Version = "SB313";
                }
                else if (KEY == "PTSIM SB314")
                {
                    Version = "SB314";
                }
                else
                {
                    MessageBox.Show("Not a Valid SBX SBuilderXX File!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            moduleEDIT.BackUp();
            NoOfMapsX = ReadIniInteger(Filename, "Main", "NoOfMaps");
            NoOfLinesX = ReadIniInteger(Filename, "Main", "NoOfLines");
            NoOfPolysX = ReadIniInteger(Filename, "Main", "NoOfPolys");
            NoOfObjectsX = ReadIniInteger(Filename, "Main", "NoOfObjects");
            NoOfExcludesX = ReadIniInteger(Filename, "Main", "NoOfExcludes");
            NoOfLWCIsX = 0;
            if (!(Version == "SB301"))
                NoOfLWCIsX = ReadIniInteger(Filename, "Main", "NoOfLWCIs");
            NoOfLLXYsX = 0;
            NoOfWWXYsX = 0;
            if (Version == "SB314" || Version == "SBXX316")
            {
                NoOfLLXYsX = ReadIniInteger(Filename, "Main", "NoOfLC_LOD5s");
                NoOfWWXYsX = ReadIniInteger(Filename, "Main", "NoOfWC_LOD5s");
            }

            if (NoOfMapsX > 0)
                Array.Resize(ref moduleMAPS.Maps, moduleMAPS.NoOfMaps + NoOfMapsX + 1);
            if (NoOfLinesX > 0)
                Array.Resize(ref moduleLINES.Lines, moduleLINES.NoOfLines + NoOfLinesX + 1);
            if (NoOfPolysX > 0)
                Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + NoOfPolysX + 1);
            if (NoOfObjectsX > 0)
                Array.Resize(ref moduleOBJECTS.Objects, moduleOBJECTS.NoOfObjects + NoOfObjectsX + 1);
            if (NoOfExcludesX > 0)
                Array.Resize(ref moduleEXCLUDES.Excludes, moduleEXCLUDES.NoOfExcludes + NoOfExcludesX + 1);
            if (NoOfLWCIsX > 0)
                Array.Resize(ref moduleCLASSES.LWCIs, moduleCLASSES.NoOfLWCIs + NoOfLWCIsX + 1);
            int loopTo = NoOfMapsX;
            for (K = 1; K <= loopTo; K++)
            {
                N = moduleMAPS.NoOfMaps + K;
                KEY = "Map." + K.ToString().Trim();
                string argVariable1 = "Name";
                moduleMAPS.Maps[N].Name = ReadIniValue(Filename, KEY, ref argVariable1);
                string argVariable2 = "BMPSu";
                moduleMAPS.Maps[N].BMPSu = ReadIniValue(Filename, KEY, ref argVariable2);
                string argVariable3 = "BMPSp";
                moduleMAPS.Maps[N].BMPSp = ReadIniValue(Filename, KEY, ref argVariable3);
                string argVariable4 = "BMPFa";
                moduleMAPS.Maps[N].BMPFa = ReadIniValue(Filename, KEY, ref argVariable4);
                string argVariable5 = "BMPWi";
                moduleMAPS.Maps[N].BMPWi = ReadIniValue(Filename, KEY, ref argVariable5);
                string argVariable6 = "BMPHw";
                moduleMAPS.Maps[N].BMPHw = ReadIniValue(Filename, KEY, ref argVariable6);
                string argVariable7 = "BMPLm";
                moduleMAPS.Maps[N].BMPLm = ReadIniValue(Filename, KEY, ref argVariable7);
                moduleMAPS.Maps[N].COLS = ReadIniInteger(Filename, KEY, "Cols");
                moduleMAPS.Maps[N].ROWS = ReadIniInteger(Filename, KEY, "Rows");
                moduleMAPS.Maps[N].NLAT = ReadIniDouble(Filename, KEY, "NLat");
                moduleMAPS.Maps[N].SLAT = ReadIniDouble(Filename, KEY, "SLat");
                moduleMAPS.Maps[N].ELON = ReadIniDouble(Filename, KEY, "ELon");
                moduleMAPS.Maps[N].WLON = ReadIniDouble(Filename, KEY, "WLon");
            }

            FileSystem.FileOpen(5, Filename, OpenMode.Input);
            int loopTo1 = NoOfLinesX;
            for (K = 1; K <= loopTo1; K++)
            {
                N = K + moduleLINES.NoOfLines;
                KEY = "[Line." + K.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleLINES.Lines[N].Name = FileSystem.LineInput(5).Substring(5);
                moduleLINES.Lines[N].Type = FileSystem.LineInput(5).Substring(5);
                moduleLINES.Lines[N].Guid = FileSystem.LineInput(5).Substring(5);
                if (Version == "SB301")
                {
                    moduleLINES.Lines[N].Color = Color.FromArgb(Convert.ToInt32(FileSystem.LineInput(5).Substring(6)));
                }
                else
                {
                    moduleLINES.Lines[N].Color = ColorFromArgb(FileSystem.LineInput(5).Substring(6));
                }

                moduleLINES.Lines[N].NoOfPoints = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                    moduleLINES.Lines[N].Name = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_Imported_Line";
                moduleLINES.Lines[N].GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                int loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                for (M = 1; M <= loopTo2; M++)
                {
                    if (M > 9)
                        J = 7;
                    if (M > 99)
                        J = 8;
                    if (M > 999)
                        J = 9;
                    if (M > 9999)
                        J = 10;
                    if (M > 99999)
                        J = 11;
                    if (M > 999999)
                        J = 12;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    moduleLINES.Lines[N].GLPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    moduleLINES.Lines[N].GLPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    moduleLINES.Lines[N].GLPoints[M].alt = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    moduleLINES.Lines[N].GLPoints[M].wid = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                }

                moduleLINES.Lines[N].ELON = EL;
                moduleLINES.Lines[N].WLON = WL;
                moduleLINES.Lines[N].NLAT = NL;
                moduleLINES.Lines[N].SLAT = SL;
            }

            int loopTo3 = NoOfPolysX;
            for (K = 1; K <= loopTo3; K++)
            {
                N = K + modulePOLYS.NoOfPolys;
                KEY = "[Poly." + K.ToString().Trim() + "]";
                GoToThisKey(KEY);
                modulePOLYS.Polys[N].Name = FileSystem.LineInput(5).Substring(5);
                modulePOLYS.Polys[N].Type = FileSystem.LineInput(5).Substring(5);
                modulePOLYS.Polys[N].Guid = FileSystem.LineInput(5).Substring(5);
                if (Version == "SB301")
                {
                    modulePOLYS.Polys[N].Color = Color.FromArgb(Convert.ToInt32(FileSystem.LineInput(5).Substring(6)));
                }
                else
                {
                    modulePOLYS.Polys[N].Color = ColorFromArgb(FileSystem.LineInput(5).Substring(6));
                }

                L = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                if (L > 0)
                {
                    modulePOLYS.Polys[N].NoOfChilds = L;
                    modulePOLYS.Polys[N].Childs = new int[L + 1];
                }
                else if (L == 0)
                {
                    modulePOLYS.Polys[N].NoOfChilds = 0;
                    modulePOLYS.Polys[N].Childs = new int[1];
                }
                else
                {
                    modulePOLYS.Polys[N].NoOfChilds = L - modulePOLYS.NoOfPolys;
                    modulePOLYS.Polys[N].Childs = new int[1];
                }

                J = 8;
                int loopTo4 = modulePOLYS.Polys[N].NoOfChilds;
                for (M = 1; M <= loopTo4; M++)
                {
                    if (M > 9)
                        J = 9;
                    if (M > 99)
                        J = 10;
                    if (M > 999)
                        J = 11;
                    if (M > 9999)
                        J = 12;
                    if (M > 99999)
                        J = 13;
                    if (M > 999999)
                        J = 14;
                    L = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    modulePOLYS.Polys[N].Childs[M] = L + modulePOLYS.NoOfPolys;
                }

                modulePOLYS.Polys[N].NoOfPoints = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                    modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].NoOfPoints.ToString() + "_Pts_Imported_Polygon";
                modulePOLYS.Polys[N].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                int loopTo5 = modulePOLYS.Polys[N].NoOfPoints;
                for (M = 1; M <= loopTo5; M++)
                {
                    if (M > 9)
                        J = 7;
                    if (M > 99)
                        J = 8;
                    if (M > 999)
                        J = 9;
                    if (M > 9999)
                        J = 10;
                    if (M > 99999)
                        J = 11;
                    if (M > 999999)
                        J = 12;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    modulePOLYS.Polys[N].GPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                    modulePOLYS.Polys[N].GPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    modulePOLYS.Polys[N].GPoints[M].alt = Convert.ToDouble(FileSystem.LineInput(5).Substring(J - 1));
                }

                modulePOLYS.Polys[N].ELON = EL;
                modulePOLYS.Polys[N].WLON = WL;
                modulePOLYS.Polys[N].NLAT = NL;
                modulePOLYS.Polys[N].SLAT = SL;
            }

            int P, PP, C, R, I;
            string A;
            int D; // to count duplicates
            bool Flag;
            int NN, LL;
            NN = moduleCLASSES.NoOfLands;
            if (Convert.ToBoolean(NoOfLLXYsX))
            {
                D = 0;
                byte[,,] oldLLands = moduleCLASSES.LLands;
                moduleCLASSES.LLands = new byte[257, 257, (moduleCLASSES.NoOfLLXYs + NoOfLLXYsX)];
                if (oldLLands is object)
                    for (int i1 = 0; i1 <= oldLLands.Length / oldLLands.GetLength(2) - 1; ++i1)
                        Array.Copy(oldLLands, i1 * oldLLands.GetLength(2), moduleCLASSES.LLands, i1 * moduleCLASSES.LLands.GetLength(2), Math.Min(oldLLands.GetLength(2), moduleCLASSES.LLands.GetLength(2)));
                int loopTo6 = NoOfLLXYsX;
                for (P = 1; P <= loopTo6; P++)
                {
                    KEY = "[LC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(2));
                    K = (int)Convert.ToDouble(FileSystem.LineInput(5).Substring(2));
                    L = Convert.ToInt32(FileSystem.LineInput(5).Substring(10));
                    N = moduleCLASSES.LL_XY[J, K].NoOfLWs;
                    PP = moduleCLASSES.NoOfLLXYs + P - 1;
                    Flag = false;
                    if (N > 0)
                    {
                        D = D + 1;
                        Flag = true;
                        PP = moduleCLASSES.LL_XY[J, K].Pointer;
                    }
                    else
                    {
                        moduleCLASSES.LL_XY[J, K].Pointer = PP;
                    }

                    LL = 0;
                    int loopTo7 = L;
                    for (M = 1; M <= loopTo7; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Convert.ToSingle(A.Substring(1, 3));
                        R = (int)Convert.ToSingle(A.Substring(5, 3));
                        I = (int)Convert.ToSingle(A.Substring(9));
                        if (Flag)
                        {
                            if (moduleCLASSES.LLands[C, R, PP] > 0)
                            {
                                NN = NN - 1;
                                LL = LL + 1;
                            }
                        }

                        moduleCLASSES.LLands[C, R, PP] = moduleCLASSES.ILC[I];
                        NN = NN + 1;
                    }

                    moduleCLASSES.LL_XY[J, K].NoOfLWs = N + L - LL;
                }

                moduleCLASSES.NoOfLands = NN;
                moduleCLASSES.NoOfLLXYs = moduleCLASSES.NoOfLLXYs + NoOfLLXYsX - D;
                if (D > 0)
                {
                    byte[,,] oldLLands1 = moduleCLASSES.LLands;
                    moduleCLASSES.LLands = new byte[257, 257, moduleCLASSES.NoOfLLXYs + NoOfLLXYsX - 1 - D + 1];
                    if (oldLLands1 is object)
                        for (int i2 = 0; i2 <= oldLLands1.Length / oldLLands1.GetLength(2) - 1; ++i2)
                            Array.Copy(oldLLands1, i2 * oldLLands1.GetLength(2), moduleCLASSES.LLands, i2 * moduleCLASSES.LLands.GetLength(2), Math.Min(oldLLands1.GetLength(2), moduleCLASSES.LLands.GetLength(2)));
                }
            }

            NN = moduleCLASSES.NoOfWaters;
            if (Convert.ToBoolean(NoOfWWXYsX))
            {
                D = 0;
                byte[,,] oldWWaters = moduleCLASSES.WWaters;
                moduleCLASSES.WWaters = new byte[257, 257, (moduleCLASSES.NoOfWWXYs + NoOfWWXYsX)];
                if (oldWWaters is object)
                    for (int i3 = 0; i3 <= oldWWaters.Length / oldWWaters.GetLength(2) - 1; ++i3)
                        Array.Copy(oldWWaters, i3 * oldWWaters.GetLength(2), moduleCLASSES.WWaters, i3 * moduleCLASSES.WWaters.GetLength(2), Math.Min(oldWWaters.GetLength(2), moduleCLASSES.WWaters.GetLength(2)));
                int loopTo8 = NoOfWWXYsX;
                for (P = 1; P <= loopTo8; P++)
                {
                    KEY = "[WC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Convert.ToSingle(FileSystem.LineInput(5).Substring(2));
                    K = (int)Convert.ToSingle(FileSystem.LineInput(5).Substring(2));
                    L = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                    N = moduleCLASSES.WW_XY[J, K].NoOfLWs;
                    PP = moduleCLASSES.NoOfWWXYs + P - 1;
                    Flag = false;
                    if (N > 0)
                    {
                        D = D + 1;
                        Flag = true;
                        PP = moduleCLASSES.WW_XY[J, K].Pointer;
                    }
                    else
                    {
                        moduleCLASSES.WW_XY[J, K].Pointer = PP;
                    }

                    LL = 0;
                    int loopTo9 = L;
                    for (M = 1; M <= loopTo9; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Convert.ToSingle(A.Substring(1, 3));
                        R = (int)Convert.ToSingle(A.Substring(5, 3));
                        I = (int)Convert.ToSingle(A.Substring(9));
                        if (Flag)
                        {
                            if (moduleCLASSES.WWaters[C, R, PP] > 0)
                            {
                                NN = NN - 1;
                                LL = LL + 1;
                            }
                        }

                        moduleCLASSES.WWaters[C, R, PP] = moduleCLASSES.IWC[I];
                        NN = NN + 1;
                    }

                    moduleCLASSES.WW_XY[J, K].NoOfLWs = N + L - LL;
                }

                moduleCLASSES.NoOfWaters = NN;
                moduleCLASSES.NoOfWWXYs = moduleCLASSES.NoOfWWXYs + NoOfWWXYsX - D;
                if (D > 0)
                {
                    byte[,,] oldWWaters1 = moduleCLASSES.WWaters;
                    moduleCLASSES.WWaters = new byte[257, 257, moduleCLASSES.NoOfWWXYs + NoOfWWXYsX - 1 - D + 1];
                    if (oldWWaters1 is object)
                        for (int i4 = 0; i4 <= oldWWaters1.Length / oldWWaters1.GetLength(2) - 1; ++i4)
                            Array.Copy(oldWWaters1, i4 * oldWWaters1.GetLength(2), moduleCLASSES.WWaters, i4 * moduleCLASSES.WWaters.GetLength(2), Math.Min(oldWWaters1.GetLength(2), moduleCLASSES.WWaters.GetLength(2)));
                }
            }

            int loopTo10 = NoOfExcludesX;
            for (K = 1; K <= loopTo10; K++)
            {
                N = K + moduleEXCLUDES.NoOfExcludes;
                KEY = "[Exclude." + K.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleEXCLUDES.Excludes[N].Flag = Convert.ToInt32(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].NLAT = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].SLAT = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].ELON = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
                moduleEXCLUDES.Excludes[N].WLON = Convert.ToDouble(FileSystem.LineInput(5).Substring(5));
            }

            int loopTo11 = NoOfObjectsX;
            for (K = 1; K <= loopTo11; K++)
            {
                N = K + moduleOBJECTS.NoOfObjects;
                KEY = "[Object." + K.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleOBJECTS.Objects[N].Type = Convert.ToInt32(FileSystem.LineInput(5).Substring(5));
                moduleOBJECTS.Objects[N].Description = FileSystem.LineInput(5).Substring(12);
                moduleOBJECTS.Objects[N].Width = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].Length = Convert.ToSingle(FileSystem.LineInput(5).Substring(7));
                moduleOBJECTS.Objects[N].Heading = Convert.ToSingle(FileSystem.LineInput(5).Substring(8));
                moduleOBJECTS.Objects[N].Pitch = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].Bank = Convert.ToSingle(FileSystem.LineInput(5).Substring(5));
                moduleOBJECTS.Objects[N].BiasX = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].BiasY = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].BiasZ = Convert.ToSingle(FileSystem.LineInput(5).Substring(6));
                moduleOBJECTS.Objects[N].lat = Convert.ToDouble(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].lon = Convert.ToDouble(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].Altitude = Convert.ToSingle(FileSystem.LineInput(5).Substring(9));
                moduleOBJECTS.Objects[N].AGL = Convert.ToInt32(FileSystem.LineInput(5).Substring(4));
                moduleOBJECTS.Objects[N].Complexity = Convert.ToInt32(FileSystem.LineInput(5).Substring(11));
                moduleOBJECTS.AddLatLonToObjects(N);
            }

            int loopTo12 = NoOfLWCIsX;
            for (K = 1; K <= loopTo12; K++)
            {
                N = K + moduleCLASSES.NoOfLWCIs;
                KEY = "[LWCI." + K.ToString().Trim() + "]";
                GoToThisKey(KEY);
                moduleCLASSES.LWCIs[N].Text = FileSystem.LineInput(5).Substring(5);
                moduleCLASSES.LWCIs[N].Color = ColorFromArgb(FileSystem.LineInput(5).Substring(6));
            }

            FileSystem.FileClose(5);
            moduleMAPS.NoOfMaps = moduleMAPS.NoOfMaps + NoOfMapsX;
            moduleLINES.NoOfLines = moduleLINES.NoOfLines + NoOfLinesX;
            modulePOLYS.NoOfPolys = modulePOLYS.NoOfPolys + NoOfPolysX;
            moduleOBJECTS.NoOfObjects = moduleOBJECTS.NoOfObjects + NoOfObjectsX;
            moduleEXCLUDES.NoOfExcludes = moduleEXCLUDES.NoOfExcludes + NoOfExcludesX;
            moduleCLASSES.NoOfLWCIs = moduleCLASSES.NoOfLWCIs + NoOfLWCIsX;
            SetLWCIs();
            int loopTo13 = moduleCLASSES.NoOfLWCIs;
            for (K = 1; K <= loopTo13; K++)
                MessageBox.Show(moduleCLASSES.LWCIs[2].Color.ToString() + " " + moduleCLASSES.LWCIs[2].IsLand.ToString() + " Text= " + moduleCLASSES.LWCIs[2].Text);
            My.MyProject.Forms.FrmStart.SetMouseIcon();
        }

        private static void GoToThisKey(string KEY)
        {
            string A;
            int NK, NA;
            NK = KEY.Length;
            do
            {
                A = FileSystem.LineInput(5);
                NA = A.Length;
                if (NA == NK)
                {
                    if ((A ?? "") == (KEY ?? ""))
                        break;
                }
            }
            while (true);
        }

        private static int ReadIniInteger(string File, string KEY, string Value)
        {
            int ReadIniIntegerRet = default;
            try
            {
                ReadIniIntegerRet = Convert.ToInt32(ReadIniValue(File, KEY, ref Value));
            }
            catch (Exception)
            {
                ReadIniIntegerRet = 0;
            }
            return ReadIniIntegerRet;
        }

        private static double ReadIniDouble(string File, string KEY, string Value)
        {
            double ReadIniDoubleRet = default;
            try
            {
                ReadIniDoubleRet = Convert.ToDouble(ReadIniValue(File, KEY, ref Value));
            }
            catch (Exception)
            {
                ReadIniDoubleRet = 0d;
            }
            return ReadIniDoubleRet;
        }

        private static void SetLWCIs()
        {
            int J;
            string A, B;
            bool IsLand = default;
            int N2, N, N1;
            byte P0, P1, P2, P3;

            try
            {
                int loopTo = moduleCLASSES.NoOfLWCIs;
                for (J = 1; J <= loopTo; J++)
                {
                    A = moduleCLASSES.LWCIs[J].Text.Trim() + " ";
                    N1 = 0;
                    N2 = A.IndexOf(" ");
                    B = A.Substring(0, N2 - N1).ToUpper();
                    if (B == "LAND")
                    {
                        IsLand = true;
                    }
                    else if (B == "WATER")
                    {
                        IsLand = false;
                    }
                    else
                    {
                        throw new ArgumentException();
                    }

                    N1 = N2 + 1;
                    N2 = A.IndexOf(" ", N1);
                    P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                    if (IsLand)
                    {
                        int loopTo1 = moduleCLASSES.NoOfLCs;
                        for (N = 1; N <= loopTo1; N++)
                        {
                            if (P0 == moduleCLASSES.LC[N].Index)
                                break; // found N or the class
                        }

                        if (N > moduleCLASSES.NoOfLCs)
                            throw new ArgumentException();
                    }
                    else
                    {
                        int loopTo2 = moduleCLASSES.NoOfWCs;
                        for (N = 1; N <= loopTo2; N++)
                        {
                            if (P0 == moduleCLASSES.WC[N].Index)
                                break; // found N
                        }

                        if (N > moduleCLASSES.NoOfWCs)
                            throw new ArgumentException();
                    }

                    P1 = (byte)N; // N goes to P1
                    N1 = N2 + 1;
                    N2 = A.IndexOf(" ", N1);
                    P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                    if (IsLand)
                    {
                        int loopTo3 = moduleCLASSES.NoOfLCs;
                        for (N = 1; N <= loopTo3; N++)
                        {
                            if (P0 == moduleCLASSES.LC[N].Index)
                                break;
                        }

                        if (N > moduleCLASSES.NoOfLCs)
                            throw new ArgumentException();
                    }
                    else
                    {
                        int loopTo4 = moduleCLASSES.NoOfWCs;
                        for (N = 1; N <= loopTo4; N++)
                        {
                            if (P0 == moduleCLASSES.WC[N].Index)
                                break;
                        }

                        if (N > moduleCLASSES.NoOfWCs)
                            throw new ArgumentException();
                    }

                    P2 = (byte)N;
                    N1 = N2 + 1;
                    N2 = A.IndexOf(" ", N1);
                    P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                    if (IsLand)
                    {
                        int loopTo5 = moduleCLASSES.NoOfLCs;
                        for (N = 1; N <= loopTo5; N++)
                        {
                            if (P0 == moduleCLASSES.LC[N].Index)
                                break;
                        }

                        if (N > moduleCLASSES.NoOfLCs)
                            throw new ArgumentException();
                    }
                    else
                    {
                        int loopTo6 = moduleCLASSES.NoOfWCs;
                        for (N = 1; N <= loopTo6; N++)
                        {
                            if (P0 == moduleCLASSES.WC[N].Index)
                                break;
                        }

                        if (N > moduleCLASSES.NoOfWCs)
                            throw new ArgumentException();
                    }

                    P3 = (byte)N;
                    moduleCLASSES.LWCIs[J].IsLand = IsLand;
                    moduleCLASSES.LWCIs[J].Class1 = P1;
                    moduleCLASSES.LWCIs[J].Class2 = P2;
                    moduleCLASSES.LWCIs[J].Class3 = P3;
                }

                return;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Land/Water Class indexes could not be read!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static void SetLegacyPolys()
        {
            string A, B, C, File;
            int Marker, N, K, J;
            LegacyPolys = new LegacyPoly[201];
            File = My.MyProject.Application.Info.DirectoryPath + @"\tools\Polys.txt";
            FileSystem.FileOpen(2, File, OpenMode.Input);
            N = (int)FileSystem.LOF(2);
            Marker = 0;
            K = 1;
            while (Marker < N)
            {
                A = FileSystem.LineInput(2);
                Marker = Marker + A.Length + 2;
                B = (A.Length < 4) ? "" : A.Substring(0, 4).Trim().ToUpper();
                if (B == "GUID")
                {
                    C = A.Substring(5).Trim();
                    LegacyPolys[K].Guid = C;
                }

                if (B == "TYPE")
                {
                    C = (A.Length < 8) ? A : A.Substring(5, 3).Trim();
                    if (C == "LCP")
                    {
                        if (A.Length > 8)
                        {
                            try
                            {
                                J = Convert.ToInt32(A.Substring(8).Trim());
                            }
                            catch (Exception)
                            {
                                J = 0;
                            }

                            if (J > 0)
                            {
                                LegacyPolys[K].LClass = J;
                                K = K + 1;
                            }
                        }
                    }
                }
            }

            FileSystem.FileClose();
            NoOfLegacyPolys = K - 1;
            Array.Resize(ref LegacyPolys, NoOfLegacyPolys + 1);
        }

        private static void SetLegacyLines()
        {
            string A, B, C, File;
            int Marker, N, K, J;
            LegacyLines = new LegacyLine[251];
            File = My.MyProject.Application.Info.DirectoryPath + @"\tools\Lines.txt";
            FileSystem.FileOpen(2, File, OpenMode.Input);
            N = (int)FileSystem.LOF(2);
            Marker = 0;
            K = 1;
            while (Marker < N)
            {
                A = FileSystem.LineInput(2);
                Marker = Marker + A.Length + 2;
                B = (A.Length < 4) ? "" : A.Substring(0, 4).Trim().ToUpper();
                if (B == "GUID")
                {
                    C = A.Substring(5).Trim();
                    LegacyLines[K].Guid = C;
                }

                if (B == "TYPE")
                {
                    if (A.Length > 8)
                    {
                        try
                        {
                            J = Convert.ToInt32(A.Substring(8).Trim());
                        }
                        catch (Exception)
                        {
                            J = 0;
                        }

                        if (J > 0)
                        {
                            LegacyLines[K].Legacy = J;
                            LegacyLines[K].Type = A.Substring(5, 3).Trim();
                            K = K + 1;
                        }
                    }
                }
            }

            FileSystem.FileClose();
            NoOfLegacyLines = K - 1;
            Array.Resize(ref LegacyLines, NoOfLegacyLines + 1);
        }

        private static void ConvertOldPolyType(int N, string Key)
        {
            string A, B;
            A = Key.Trim();

            // set to none
            modulePOLYS.Polys[N].Type = "";
            modulePOLYS.Polys[N].Guid = "{00000000-0000-0000-0000-111111111111}";
            if (string.IsNullOrEmpty(A))
                return;

            // set to old
            modulePOLYS.Polys[N].Guid = "{00000000-0000-0000-0000-222222222222}";

            try
            {
                int J, K;
                bool Flag;
                B = (A.Length < 3) ? "" : A.Substring(0, 3);
                if (B == "VTP")
                {
                    J = A.IndexOf("//");
                    A = A.Substring(J + 2);
                    J = A.IndexOf("//");
                    A = A.Substring(J + 2);
                    J = A.IndexOf("//");
                    A = A.Substring(0, J);
                    J = Convert.ToInt32(A);
                    Flag = false;
                    int loopTo = NoOfLegacyPolys;
                    for (K = 1; K <= loopTo; K++)
                    {
                        if (J == LegacyPolys[K].LClass)
                        {
                            Flag = true;
                            break;
                        }
                    }

                    if (Flag)
                    {
                        modulePOLYS.Polys[N].Guid = LegacyPolys[K].Guid;
                        modulePOLYS.Polys[N].Type = "LCP";
                    }
                }

                if (B == "TEX")
                {
                    modulePOLYS.Polys[N].Type = A;
                    return;
                }

                if (B == "LWM")
                {
                    J = A.IndexOf("//");
                    A = A.Substring(J + 2);
                    // Water//455//455//1//1//
                    J = A.IndexOf("//");
                    B = A.Substring(0, J);
                    A = A.Substring(J + 2);
                    // 455//455//1//1//

                    if (B == "Water")
                    {
                        J = A.IndexOf("//");
                        B = A.Substring(0, J);
                        K = Convert.ToInt32(B);
                        if (K == -9999)
                        {
                            modulePOLYS.Polys[N].Guid = "{5835459A-4B8B-41F2-ADC1-DEE721573B28}";
                            modulePOLYS.Polys[N].Type = "HPX";
                        }
                        else
                        {
                            modulePOLYS.Polys[N].Guid = "{F4775962-DA14-4BF6-9C70-672420752870}";
                            modulePOLYS.Polys[N].Type = "HPX";
                        }
                    }

                    if (B == "Land")
                    {
                        J = A.IndexOf("//");
                        B = A.Substring(0, J);
                        K = Convert.ToInt32(B);
                        if (K == -9999)
                        {
                            modulePOLYS.Polys[N].Guid = "{3EC48E64-5522-449C-96C6-96F8CEBDBDE2}";
                            modulePOLYS.Polys[N].Type = "HPX";
                        }
                        else
                        {
                            modulePOLYS.Polys[N].Guid = "{D242B77F-7308-4685-9B6C-89AF1CD43D13}";
                            modulePOLYS.Polys[N].Type = "HPX";
                        }
                    }

                    if (B == "Flatten")
                    {
                        modulePOLYS.Polys[N].Guid = "{18580A63-FC8F-4A02-A622-8A1E073E627B}";
                        modulePOLYS.Polys[N].Type = "FLX";
                    }
                }

                return;
            }
            catch (Exception)
            {
                modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].Name + "_not converted from SB205";
            }
        }

        private static void ConvertOldLineType(int N, string Key)
        {

            // Type=VTP//7//1032//

            string A, B;
            A = Key.Trim();

            // set to none
            moduleLINES.Lines[N].Type = "";
            moduleLINES.Lines[N].Guid = "{00000000-0000-0000-0000-333333333333}";
            if (string.IsNullOrEmpty(A))
                return;

            try
            {
                // set to old
                moduleLINES.Lines[N].Guid = "{00000000-0000-0000-0000-444444444444}";
                int J, K;
                bool Flag;
                B = (A.Length < 3) ? "" : A.Substring(0, 3);
                if (B == "VTP")
                {
                    J = A.IndexOf("//");
                    A = A.Substring(J + 2);
                    J = A.IndexOf("//");
                    A = A.Substring(J + 2);
                    J = A.IndexOf("//");
                    A = A.Substring(0, J);
                    J = Convert.ToInt32(A);
                    Flag = false;
                    int loopTo = NoOfLegacyLines;
                    for (K = 1; K <= loopTo; K++)
                    {
                        if (J == LegacyLines[K].Legacy)
                        {
                            Flag = true;
                            break;
                        }
                    }

                    if (Flag)
                    {
                        moduleLINES.Lines[N].Guid = LegacyLines[K].Guid;
                        moduleLINES.Lines[N].Type = LegacyLines[K].Type;
                    }
                }

                return;
            }
            catch (Exception)
            {
                moduleLINES.Lines[N].Name = moduleLINES.Lines[N].Name + "_not converted from SB205";
            }
        }

        private static string ArgbFromColor(Color myColor)
        {
            string ArgbFromColorRet = default;
            string A, R, G, B;
            A = myColor.A.ToString("X2");
            R = myColor.R.ToString("X2");
            G = myColor.G.ToString("X2");
            B = myColor.B.ToString("X2");
            ArgbFromColorRet = A + R + G + B;
            return ArgbFromColorRet;
        }

        private static Color ColorFromArgb(string argb)
        {
            Color ColorFromArgbRet = default;
            ColorFromArgbRet = Color.FromArgb(Convert.ToInt32(argb, 16));
            return ColorFromArgbRet;
        }
    }

    sealed class SbuilderBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            Type typeToDeserialize = null;
            typeName = typeName.Replace("WindowsApplication1", "SBuilderXX");
            typeToDeserialize = Type.GetType(string.Format("{0}, {1}", typeName, assemblyName));
            return typeToDeserialize;
        }
    }
}