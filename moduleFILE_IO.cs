using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            var IniSettings = new Collection();

            try
            {
                // [Main]
                IniSettings.Add("-9.136076", "LonIniCenter");
                IniSettings.Add("38.7813203", "LatIniCenter");
                IniSettings.Add("False", "DecimalDegrees");
                IniSettings.Add("True", "MeasuringMeters");
                IniSettings.Add(My.MyProject.Application.Info.DirectoryPath + @"\Scenery", "BGLFolder");
                IniSettings.Add("False", "OriginalTerrainCFG");
                IniSettings.Add("FSX", "NameOfSim");
                IniSettings.Add(My.MyProject.Application.Info.DirectoryPath + @"\Tools", "SimPath");

                // [Edit]
                IniSettings.Add("False", "BackUpON");
                IniSettings.Add("60", "BackUpSeconds");
                IniSettings.Add("True", "AskDelete");
                IniSettings.Add("True", "ShowDonation");
                IniSettings.Add("True", "BorderON");
                IniSettings.Add("True", "ShowLabels");
                IniSettings.Add(ArgbFromColor(Color.Green), "SelectedPointColor");
                IniSettings.Add(ArgbFromColor(Color.Red), "UnselectedPointColor");

                // [Misc]
                IniSettings.Add("False", "AutoLinePolyJoin");
                IniSettings.Add("True", "DisplayJoin");
                IniSettings.Add("True", "DirJoin");
                IniSettings.Add("True", "NameJoin");
                IniSettings.Add("True", "NoEndsSmooth");
                IniSettings.Add("True", "CornerSmooth");
                IniSettings.Add("10", "SampleDistance");
                IniSettings.Add("50", "SmoothDistance");
                IniSettings.Add("11", "DefaultLC");
                IniSettings.Add("12", "DefaultWC");
                // IniSettings.Add("DemoAppId01082013GAL", "Here_app_id")
                // IniSettings.Add("AJKnXv84fjrb0KIHawS0Tg", "Here_app_code")
                IniSettings.Add("", "GoogleMapsAPI");
                IniSettings.Add("False", "MakeSlopeXY");

                // [Grid]
                IniSettings.Add(ArgbFromColor(Color.Green), "GridColor");
                IniSettings.Add(ArgbFromColor(Color.Red), "GridLODColor");
                IniSettings.Add("1", "GridWidth");
                IniSettings.Add("True", "ZoomOnQMID");
                IniSettings.Add("False", "CenterOnMouseWheel");

                // [Aircraft]
                IniSettings.Add("5000", "ShowAircraftPeriod");
                IniSettings.Add("0.5", "AircraftAltitudeOffset");
                IniSettings.Add("-20M", "ExtraExtrusionAltitude");

                // [Objects]
                IniSettings.Add(My.MyProject.Application.Info.DirectoryPath + @"\Rwy12", "Rwy12Path");
                IniSettings.Add(My.MyProject.Application.Info.DirectoryPath + @"\API", "MacroAPIPath");
                IniSettings.Add(My.MyProject.Application.Info.DirectoryPath + @"\ASD", "MacroASDPath");
                IniSettings.Add(My.MyProject.Application.Info.DirectoryPath + @"\LibObjects", "LibObjectsPath");

                // [Lines]
                IniSettings.Add("0", "DefaultLineAltitude");
                IniSettings.Add("50", "DefaultLineWidth");
                IniSettings.Add("1", "LinePenWidth");
                IniSettings.Add(ArgbFromColor(Color.Green), "SelectedLineColor");
                IniSettings.Add(ArgbFromColor(Color.Blue), "DefaultLineColor");
                IniSettings.Add("False", "MakeClosedLineFromPoly");

                // [Polys]
                IniSettings.Add("0", "DefaultPolyAltitude");
                IniSettings.Add("1", "PolyPenWidth");
                IniSettings.Add("True", "PolyFILL");
                IniSettings.Add("80FFFF00", "DefaultPolyColor");
                IniSettings.Add(ArgbFromColor(Color.Black), "PolyColorBorder");

                // [Shapes]
                IniSettings.Add("{89ABCDEF-EDCB-A987-6543-210FEDCBA000}", "ShapeLineGuid");
                IniSettings.Add("0", "ShapeLineAltitude");
                IniSettings.Add("50", "ShapeLineWidth");
                IniSettings.Add(ArgbFromColor(Color.Blue), "ShapeLineColor");
                IniSettings.Add("{9ABCDEF0-FEDC-BA98-7654-3210FEDCB000}", "ShapePolyGuid");
                IniSettings.Add("0", "ShapePolyAltitude");
                IniSettings.Add(ArgbFromColor(Color.Pink), "ShapePolyColor");
                IniSettings.Add("True", "AddToCells");

                // [Tiles]
                IniSettings.Add("", "ActiveTileFolder");
                IniSettings.Add("True", "ReprojectMercatorTiles");
                IniSettings.Add("July,August,September", "SummerVariations");
                IniSettings.Add("April,May,June", "SpringVariations");
                IniSettings.Add("October,November", "FallVariations");
                IniSettings.Add("December,February,March", "WinterVariations");
                IniSettings.Add("January", "HardWinterVariations");
                IniSettings.Add("85", "CompressionQuality");

                // [BLN]
                IniSettings.Add(",", "BLNSeparator");
                if (moduleSURFER.BLNSeparator == "tab")
                    moduleSURFER.BLNSeparator = Conversions.ToString('\t');
                IniSettings.Add("{9ABCDEF0-FEDC-BA98-7654-3210FEDCB000}", "BLNPolyGuid");
                IniSettings.Add(ArgbFromColor(Color.Red), "BLNPolyColor");
                IniSettings.Add("{89ABCDEF-EDCB-A987-6543-210FEDCBA000}", "BLNLineGuid");
                IniSettings.Add(ArgbFromColor(Color.Red), "BLNLineColor");
                IniSettings.Add("True", "BLNIsPolyAlt");
                IniSettings.Add("True", "BLNIsLineAlt");
                IniSettings.Add("35", "BLNStartWidth");
                IniSettings.Add("35", "BLNEndWidth");
                IniSettings.Add("True", "BLNLineFromPoly");
                IniSettings.Add("True", "BLNExportAltitudes");

                // [RecentDirs]
                IniSettings.Add("", "SBPDir");
                IniSettings.Add("", "SBXDir");
                IniSettings.Add("", "SHPDir");
                IniSettings.Add("", "SURDir");
                IniSettings.Add("", "TEXDir");
                IniSettings.Add("", "BMPDir");
                IniSettings.Add("", "OBJDir");
                IniSettings.Add("", "RAWDir");
                IniSettings.Add("", "LIBDir");
                IniSettings.Add("", "KMLDir");
                IniSettings.Add("", "RecentFile1");
                IniSettings.Add("", "RecentFile2");
                IniSettings.Add("", "RecentFile3");
                IniSettings.Add("", "RecentFile4");
                int NF = FileSystem.FreeFile();
                string myLine, A, B;
                int N;
                if (File.Exists(moduleMAIN.AppIni))
                {

                    // added this October 2017
                    File.Copy(moduleMAIN.AppIni, moduleMAIN.AppPath + @"\SBuilderX_backup.ini", true);
                    FileSystem.FileOpen(NF, moduleMAIN.AppIni, OpenMode.Input);
                    while (!FileSystem.EOF(NF))
                    {
                        myLine = FileSystem.LineInput(NF);
                        N = Strings.InStr(myLine, "=");
                        if (N > 0)
                        {
                            A = myLine.Substring(0, N - 1);
                            if (IniSettings.Contains(A))
                            {
                                B = myLine.Substring(N);
                                IniSettings.Remove(A);
                                IniSettings.Add(B, A);
                            }
                        }
                    }

                    FileSystem.FileClose(NF);
                }

                // [Main]
                moduleMAIN.LonIniCenter = Conversion.Val(IniSettings["LonIniCenter"]);
                moduleMAIN.LatIniCenter = Conversion.Val(IniSettings["LatIniCenter"]);
                moduleMAIN.DecimalDegrees = Conversions.ToBoolean(IniSettings["DecimalDegrees"]);
                moduleMAIN.MeasuringMeters = Conversions.ToBoolean(IniSettings["MeasuringMeters"]);
                moduleMAIN.BGLFolder = Conversions.ToString(IniSettings["BGLFolder"]);
                moduleMAIN.OriginalTerrainCFG = Conversions.ToBoolean(IniSettings["OriginalTerrainCFG"]);
                moduleMAIN.NameOfSim = Conversions.ToString(IniSettings["NameOfSim"]);
                moduleMAIN.SimPath = Conversions.ToString(IniSettings["SimPath"]);

                // [Edit]
                moduleEDIT.BackUpON = Conversions.ToBoolean(IniSettings["BackUpON"]);
                BackUpSeconds = (int)Conversion.Val(IniSettings["BackUpSeconds"]);
                moduleMAPS.BorderON = Conversions.ToBoolean(IniSettings["BorderON"]);
                moduleMAIN.AskDelete = Conversions.ToBoolean(IniSettings["AskDelete"]);
                moduleMAIN.ShowDonation = Conversions.ToBoolean(IniSettings["ShowDonation"]);
                moduleMAIN.ShowLabels = Conversions.ToBoolean(IniSettings["ShowLabels"]);
                modulePOINTS.SelectedPointColor = ColorFromArgb(Conversions.ToString(IniSettings["SelectedPointColor"]));
                modulePOINTS.UnselectedPointColor = ColorFromArgb(Conversions.ToString(IniSettings["UnselectedPointColor"]));

                // [Misc]
                moduleLINES.AutoLinePolyJoin = Conversions.ToBoolean(IniSettings["AutoLinePolyJoin"]);
                moduleLINES.DisplayJoin = Conversions.ToBoolean(IniSettings["DisplayJoin"]);
                moduleLINES.DirJoin = Conversions.ToBoolean(IniSettings["DirJoin"]);
                moduleLINES.NameJoin = Conversions.ToBoolean(IniSettings["NameJoin"]);
                moduleMAIN.NoEndsSmooth = Conversions.ToBoolean(IniSettings["NoEndsSmooth"]);
                moduleMAIN.CornerSmooth = Conversions.ToBoolean(IniSettings["CornerSmooth"]);
                moduleMAIN.SampleDistance = Conversion.Val(IniSettings["SampleDistance"]);
                moduleMAIN.SmoothDistance = Conversion.Val(IniSettings["SmoothDistance"]);
                moduleCLASSES.DefaultLC = Conversions.ToByte(IniSettings["DefaultLC"]);
                moduleCLASSES.DefaultWC = Conversions.ToByte(IniSettings["DefaultWC"]);
                // Here_app_id = CStr(IniSettings.Item("Here_app_id"))
                // Here_app_code = CStr(IniSettings.Item("Here_app_code"))
                moduleMAPS.GoogleMapsAPI = Conversions.ToString(IniSettings["GoogleMapsAPI"]);
                moduleMAIN.MakeSlopeXY = Conversions.ToBoolean(IniSettings["MakeSlopeXY"]);

                // [Grid]
                moduleMAIN.GridColor = ColorFromArgb(Conversions.ToString(IniSettings["GridColor"]));
                moduleMAIN.GridLODColor = ColorFromArgb(Conversions.ToString(IniSettings["GridLODColor"]));
                moduleMAIN.GridWidth = (int)Conversion.Val(IniSettings["GridWidth"]);
                moduleMAIN.ZoomOnQMID = Conversions.ToBoolean(IniSettings["ZoomOnQMID"]);
                if (moduleMAIN.GridWidth > 2)
                    moduleMAIN.GridWidth = 2;
                moduleMAIN.CenterOnMouseWheel = Conversions.ToBoolean(IniSettings["CenterOnMouseWheel"]);

                // [Aircraft]
                moduleMAIN.ShowAircraftPeriod = (int)Conversion.Val(IniSettings["ShowAircraftPeriod"]);
                moduleMAIN.AircraftAltitudeOffset = Conversion.Val(IniSettings["AircraftAltitudeOffset"]);
                moduleLINES.ExtraExtrusionAltitude = Conversions.ToString(IniSettings["ExtraExtrusionAltitude"]);

                // [Objects]
                moduleOBJECTS.Rwy12Path = Conversions.ToString(IniSettings["Rwy12Path"]);
                moduleMACROS.MacroAPIPath = Conversions.ToString(IniSettings["MacroAPIPath"]);
                moduleMACROS.MacroASDPath = Conversions.ToString(IniSettings["MacroASDPath"]);
                moduleOBJECTS.LibObjectsPath = Conversions.ToString(IniSettings["LibObjectsPath"]);

                // [Lines]
                moduleLINES.DefaultLineAltitude = Conversion.Val(IniSettings["DefaultLineAltitude"]);
                moduleLINES.DefaultLineWidth = Conversion.Val(IniSettings["DefaultLineWidth"]);
                moduleLINES.LinePenWidth = (int)Conversion.Val(IniSettings["LinePenWidth"]);
                if (moduleLINES.LinePenWidth > 2)
                    moduleLINES.LinePenWidth = 2;
                moduleLINES.SelectedLineColor = ColorFromArgb(Conversions.ToString(IniSettings["SelectedLineColor"]));
                moduleLINES.DefaultLineColor = ColorFromArgb(Conversions.ToString(IniSettings["DefaultLineColor"]));
                modulePOLYS.MakeClosedLineFromPoly = Conversions.ToBoolean(IniSettings["MakeClosedLineFromPoly"]);

                // [Polys]
                modulePOLYS.DefaultPolyAltitude = Conversion.Val(IniSettings["DefaultPolyAltitude"]);
                modulePOLYS.PolyPenWidth = (int)Conversion.Val(IniSettings["PolyPenWidth"]);
                if (modulePOLYS.PolyPenWidth > 2)
                    modulePOLYS.PolyPenWidth = 2;
                modulePOLYS.PolyFILL = Conversions.ToBoolean(IniSettings["PolyFILL"]);
                modulePOLYS.DefaultPolyColor = ColorFromArgb(Conversions.ToString(IniSettings["DefaultPolyColor"]));
                modulePOLYS.PolyColorBorder = ColorFromArgb(Conversions.ToString(IniSettings["PolyColorBorder"]));

                // [Shapes]
                moduleSHAPE.ShapeLineGuid = Conversions.ToString(IniSettings["ShapeLineGuid"]);
                moduleSHAPE.ShapeLineAltitude = Conversion.Val(IniSettings["ShapeLineAltitude"]);
                moduleSHAPE.ShapeLineWidth = Conversion.Val(IniSettings["ShapeLineWidth"]);
                moduleSHAPE.ShapeLineColor = ColorFromArgb(Conversions.ToString(IniSettings["ShapeLineColor"]));
                moduleSHAPE.ShapePolyGuid = Conversions.ToString(IniSettings["ShapePolyGuid"]);
                moduleSHAPE.ShapePolyAltitude = Conversion.Val(IniSettings["ShapePolyAltitude"]);
                moduleSHAPE.ShapePolyColor = ColorFromArgb(Conversions.ToString(IniSettings["ShapePolyColor"]));
                moduleSHAPE.AddToCells = Conversions.ToBoolean(IniSettings["AddToCells"]);

                // [Tiles]
                moduleTILES.ActiveTileFolder = Conversions.ToString(IniSettings["ActiveTileFolder"]);
                moduleTILES.ReprojectMercatorTiles = Conversions.ToBoolean(IniSettings["ReprojectMercatorTiles"]);
                moduleTILES.SummerVariations = Conversions.ToString(IniSettings["SummerVariations"]);
                moduleTILES.SpringVariations = Conversions.ToString(IniSettings["SpringVariations"]);
                moduleTILES.FallVariations = Conversions.ToString(IniSettings["FallVariations"]);
                moduleTILES.WinterVariations = Conversions.ToString(IniSettings["WinterVariations"]);
                moduleTILES.HardWinterVariations = Conversions.ToString(IniSettings["HardWinterVariations"]);
                moduleTILES.CompressionQuality = Conversions.ToInteger(IniSettings["CompressionQuality"]);

                // [BLN]
                moduleSURFER.BLNSeparator = Conversions.ToString(IniSettings["BLNSeparator"]);
                if (moduleSURFER.BLNSeparator == "tab")
                    moduleSURFER.BLNSeparator = Conversions.ToString('\t');
                moduleSURFER.BLNPolyGuid = Conversions.ToString(IniSettings["BLNPolyGuid"]);
                moduleSURFER.BLNPolyColor = ColorFromArgb(Conversions.ToString(IniSettings["BLNPolyColor"]));
                moduleSURFER.BLNLineGuid = Conversions.ToString(IniSettings["BLNLineGuid"]);
                moduleSURFER.BLNLineColor = ColorFromArgb(Conversions.ToString(IniSettings["BLNLineColor"]));
                moduleSURFER.BLNIsPolyAlt = Conversions.ToBoolean(IniSettings["BLNIsPolyAlt"]);
                moduleSURFER.BLNIsLineAlt = Conversions.ToBoolean(IniSettings["BLNIsLineAlt"]);
                moduleSURFER.BLNStartWidth = Conversion.Val(IniSettings["BLNStartWidth"]);
                moduleSURFER.BLNEndWidth = Conversion.Val(IniSettings["BLNEndWidth"]);
                moduleSURFER.BLNLineFromPoly = Conversions.ToBoolean(IniSettings["BLNLineFromPoly"]);
                moduleSURFER.BLNExportAltitudes = Conversions.ToBoolean(IniSettings["BLNExportAltitudes"]);

                // [RecentDirs]
                SHPDir = Conversions.ToString(IniSettings["SHPDir"]);
                SBPDir = Conversions.ToString(IniSettings["SBPDir"]);
                SBXDir = Conversions.ToString(IniSettings["SBXDir"]);
                SURDir = Conversions.ToString(IniSettings["SURDir"]);
                TEXDir = Conversions.ToString(IniSettings["TEXDir"]);
                BMPDir = Conversions.ToString(IniSettings["BMPDir"]);
                OBJDir = Conversions.ToString(IniSettings["OBJDir"]);
                RAWDir = Conversions.ToString(IniSettings["RAWDir"]);
                LIBDir = Conversions.ToString(IniSettings["LIBDir"]);
                KMLDir = Conversions.ToString(IniSettings["KMLDir"]);

                // [RecentFiles]
                RecentFiles[1] = Conversions.ToString(IniSettings["RecentFile1"]);
                RecentFiles[2] = Conversions.ToString(IniSettings["RecentFile2"]);
                RecentFiles[3] = Conversions.ToString(IniSettings["RecentFile3"]);
                RecentFiles[4] = Conversions.ToString(IniSettings["RecentFile4"]);

                // PRINT INI FILE
                // **************
                WriteSettings();
                return;
            }
            catch (Exception exc)
            {
                string A = "Error in reading/writing the INI file! If you can not" + Constants.vbCrLf;
                A = A + "determine the cause of this error, delete the INI file" + Constants.vbCrLf;
                A = A + "and SBuilderX will recreate it! SBuilderX will stop now!";
                Interaction.MsgBox(A, MsgBoxStyle.Critical);
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
            FileSystem.PrintLine(NF, "LonIniCenter=" + Conversion.Str(moduleMAIN.LonIniCenter));
            FileSystem.PrintLine(NF, "LatIniCenter=" + Conversion.Str(moduleMAIN.LatIniCenter));
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
            FileSystem.PrintLine(NF, "ShowDonation=" + moduleMAIN.ShowDonation.ToString());
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
            FileSystem.PrintLine(NF, "SampleDistance=" + Conversion.Str(moduleMAIN.SampleDistance));
            FileSystem.PrintLine(NF, "SmoothDistance=" + Conversion.Str(moduleMAIN.SmoothDistance));
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
            FileSystem.PrintLine(NF, "GridWidth=" + Conversion.Str(moduleMAIN.GridWidth));
            FileSystem.PrintLine(NF, "ZoomOnQMID=" + moduleMAIN.ZoomOnQMID.ToString());
            FileSystem.PrintLine(NF, "CenterOnMouseWheel=" + moduleMAIN.CenterOnMouseWheel.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Aircraft]");
            FileSystem.PrintLine(NF, "ShowAircraftPeriod=" + moduleMAIN.ShowAircraftPeriod.ToString());
            FileSystem.PrintLine(NF, "AircraftAltitudeOffset=" + Conversion.Str(moduleMAIN.AircraftAltitudeOffset));
            FileSystem.PrintLine(NF, "ExtraExtrusionAltitude=" + moduleLINES.ExtraExtrusionAltitude);
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Objects]");
            FileSystem.PrintLine(NF, "Rwy12Path=" + moduleOBJECTS.Rwy12Path);
            FileSystem.PrintLine(NF, "MacroAPIPath=" + moduleMACROS.MacroAPIPath);
            FileSystem.PrintLine(NF, "MacroASDPath=" + moduleMACROS.MacroASDPath);
            FileSystem.PrintLine(NF, "LibObjectsPath=" + moduleOBJECTS.LibObjectsPath);
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Lines]");
            FileSystem.PrintLine(NF, "DefaultLineAltitude=" + Conversion.Str(moduleLINES.DefaultLineAltitude));
            FileSystem.PrintLine(NF, "DefaultLineWidth=" + Conversion.Str(moduleLINES.DefaultLineWidth));
            FileSystem.PrintLine(NF, "LinePenWidth=" + Conversion.Str(moduleLINES.LinePenWidth));
            FileSystem.PrintLine(NF, "SelectedLineColor=" + ArgbFromColor(moduleLINES.SelectedLineColor));
            FileSystem.PrintLine(NF, "DefaultLineColor=" + ArgbFromColor(moduleLINES.DefaultLineColor));
            FileSystem.PrintLine(NF, "MakeClosedLineFromPoly=" + modulePOLYS.MakeClosedLineFromPoly.ToString());
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Polys]");
            FileSystem.PrintLine(NF, "DefaultPolyAltitude=" + Conversion.Str(modulePOLYS.DefaultPolyAltitude));
            FileSystem.PrintLine(NF, "PolyPenWidth=" + Conversion.Str(modulePOLYS.PolyPenWidth));
            FileSystem.PrintLine(NF, "PolyFILL=" + modulePOLYS.PolyFILL.ToString());
            FileSystem.PrintLine(NF, "DefaultPolyColor=" + ArgbFromColor(modulePOLYS.DefaultPolyColor));
            FileSystem.PrintLine(NF, "PolyColorBorder=" + ArgbFromColor(modulePOLYS.PolyColorBorder));
            FileSystem.PrintLine(NF);
            FileSystem.PrintLine(NF, "[Shapes]");
            FileSystem.PrintLine(NF, "ShapeLineGuid=" + moduleSHAPE.ShapeLineGuid);
            FileSystem.PrintLine(NF, "ShapeLineAltitude=" + Conversion.Str(moduleSHAPE.ShapeLineAltitude));
            FileSystem.PrintLine(NF, "ShapeLineWidth=" + Conversion.Str(moduleSHAPE.ShapeLineWidth));
            FileSystem.PrintLine(NF, "ShapeLineColor=" + ArgbFromColor(moduleSHAPE.ShapeLineColor));
            FileSystem.PrintLine(NF, "ShapePolyGuid=" + moduleSHAPE.ShapePolyGuid);
            FileSystem.PrintLine(NF, "ShapePolyAltitude=" + Conversion.Str(moduleSHAPE.ShapePolyAltitude));
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
            if (moduleSURFER.BLNSeparator == Conversions.ToString('\t'))
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
            FileSystem.PrintLine(NF, "BLNStartWidth=" + Conversion.Str(moduleSURFER.BLNStartWidth));
            FileSystem.PrintLine(NF, "BLNEndWidth=" + Conversion.Str(moduleSURFER.BLNEndWidth));
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
            D = Strings.Trim(ReadIniValue(moduleMAIN.AppIni, A, ref B1));
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
            var ReadyToRead = default(bool);
            NF = FileSystem.FreeFile();
            ReadIniValueRet = "";
            KEY = "[" + Strings.LCase(KEY) + "]";
            Variable = Strings.LCase(Variable);
            FileSystem.FileOpen(NF, INIpath, OpenMode.Binary);
            FileSystem.FileClose(NF);
            FileSystem.SetAttr(INIpath, FileAttribute.Archive);
            FileSystem.FileOpen(NF, INIpath, OpenMode.Input);
            while (!FileSystem.EOF(NF))
            {
                Temp = FileSystem.LineInput(NF);
                LcaseTemp = Strings.LCase(Temp);
                if (Strings.InStr(LcaseTemp, "[") != 0)
                    ReadyToRead = false;
                if ((LcaseTemp ?? "") == (KEY ?? ""))
                    ReadyToRead = true;
                if (Strings.InStr(LcaseTemp, "[") == 0 & ReadyToRead)
                {
                    if (Strings.InStr(LcaseTemp, Variable + "=") == 1)
                    {
                        ReadIniValueRet = Strings.Mid(Temp, 1 + Strings.Len(Variable + "="));
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
            ReadKey = Constants.vbCrLf + "[" + Strings.LCase(PutKey) + "]" + '\r';
            KEYLEN = Strings.Len(ReadKey);
            ReadVariable = '\n' + Strings.LCase(PutVariable) + "=";
            FileSystem.FileOpen(NF, INIpath, OpenMode.Binary);
            FileSystem.FileClose(NF);
            FileSystem.SetAttr(INIpath, FileAttribute.Archive);
            FileSystem.FileOpen(NF, INIpath, OpenMode.Input);
            Temp = FileSystem.InputString(NF, (int)FileSystem.LOF(NF));
            Temp = Constants.vbCrLf + Temp + "[]";
            FileSystem.FileClose(NF);
            LcaseTemp = Strings.LCase(Temp);
            LOKEY = Strings.InStr(LcaseTemp, ReadKey);
            if (LOKEY == 0)
                goto AddKey;
            HIKEY = Strings.InStr(LOKEY + KEYLEN, LcaseTemp, "[");
            VAR = Strings.InStr(LOKEY, LcaseTemp, ReadVariable);
            if (VAR > HIKEY | VAR < LOKEY)
                goto AddVariable;
            goto RenewVariable;
        AddKey:
            ;
            Temp = Strings.Left(Temp, Strings.Len(Temp) - 2);
            Temp = Temp + Constants.vbCrLf + Constants.vbCrLf + "[" + PutKey + "]" + Constants.vbCrLf + PutVariable + "=" + PutValue;
            goto TrimFinalString;
        AddVariable:
            ;
            Temp = Strings.Left(Temp, Strings.Len(Temp) - 2);
            Temp = Strings.Left(Temp, LOKEY + KEYLEN) + PutVariable + "=" + PutValue + Constants.vbCrLf + Strings.Mid(Temp, LOKEY + KEYLEN + 1);
            goto TrimFinalString;
        RenewVariable:
            ;
            Temp = Strings.Left(Temp, Strings.Len(Temp) - 2);
            VARENDOFLINE = Strings.InStr(VAR, Temp, Conversions.ToString('\r'));
            Temp = Strings.Left(Temp, VAR) + PutVariable + "=" + PutValue + Strings.Mid(Temp, VARENDOFLINE);
            goto TrimFinalString;
        TrimFinalString:
            ;
            Temp = Strings.Mid(Temp, 2);
            while (Strings.InStr(Temp, Constants.vbCrLf + Constants.vbCrLf + Constants.vbCrLf) != 0)
                Temp = Strings.Replace(Temp, Constants.vbCrLf + Constants.vbCrLf + Constants.vbCrLf, Constants.vbCrLf + Constants.vbCrLf);
            while (Operators.CompareString(Strings.Right(Temp, 1), '\r'.ToString(), false) <= 0)
                Temp = Strings.Left(Temp, Strings.Len(Temp) - 1);
            while (Operators.CompareString(Strings.Left(Temp, 1), '\r'.ToString(), false) <= 0)
                Temp = Strings.Mid(Temp, 2);
            FileSystem.FileOpen(NF, INIpath, OpenMode.Output);
            FileSystem.PrintLine(NF, Temp);
            FileSystem.FileClose(NF);
        }

        private static string TrimFile(string str_file, int N)
        {
            string TrimFileRet = default;
            int K1, K, K2;
            TrimFileRet = str_file;
            K = Strings.Len(str_file);
            if (K <= N)
                return TrimFileRet;
            K1 = Strings.InStr(4, str_file, @"\");
            K2 = Strings.InStrRev(str_file, @"\");
            if (K1 + K - K2 > N)
            {
                TrimFileRet = Strings.Mid(str_file, 1, 3) + ".." + Strings.Mid(str_file, K2);
                return TrimFileRet;
            }

            TrimFileRet = Strings.Mid(str_file, 1, K1) + ".." + Strings.Mid(str_file, K2);
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
                catch(Exception exc)
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
                catch (Exception exc)
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
            int N;
            string A;
            try
            {
                TheFile = Path.GetFileNameWithoutExtension(moduleMAIN.WorkFile);
            }
            catch (Exception exc)
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
                catch (Exception exc)
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
                catch (Exception exc)
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
            string ext = Strings.UCase(Path.GetExtension(filename));
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
                Interaction.MsgBox("This file was not found!", MsgBoxStyle.Exclamation);
                return;
            };

            FileStream oFile = default;
            try
            {
                oFile = new FileStream(filename, FileMode.Open);
                var BFormatter = new BinaryFormatter() { Binder = new SbuilderBinder() };
                string Version;
                Version = Conversions.ToString(BFormatter.Deserialize(oFile));
                SetFileBackUp(filename);
                moduleMAIN.ProjectName = Conversions.ToString(BFormatter.Deserialize(oFile));
                moduleMAIN.BGLProjectFolder = Conversions.ToString(BFormatter.Deserialize(oFile));
                moduleMAIN.CheckFolders();
                double readZoom = Conversions.ToDouble(BFormatter.Deserialize(oFile));
                moduleMAIN.Zoom = Conversions.ToInteger(readZoom);
                moduleMAIN.LatDispCenter = Conversions.ToDouble(BFormatter.Deserialize(oFile));
                moduleMAIN.LonDispCenter = Conversions.ToDouble(BFormatter.Deserialize(oFile));
                moduleMAIN.QMIDLevel = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                moduleMAPS.NoOfMaps = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                moduleCLASSES.NoOfLands = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                Lixo = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                moduleLINES.NoOfLines = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                modulePOLYS.NoOfPolys = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                moduleCLASSES.NoOfWaters = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                moduleOBJECTS.NoOfObjects = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                moduleEXCLUDES.NoOfExcludes = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                Lixo = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                moduleCLASSES.NoOfLWCIs = 0;
                if (!(Version == "SB301"))
                    moduleCLASSES.NoOfLWCIs = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                if (moduleMAPS.NoOfMaps > 0)
                    moduleMAPS.Maps = (moduleMAPS.Map[])BFormatter.Deserialize(oFile);
                if (moduleCLASSES.NoOfLands > 0)
                {
                    moduleCLASSES.NoOfLLXYs = Conversions.ToInteger(BFormatter.Deserialize(oFile));
                    moduleCLASSES.LL_XY = (moduleCLASSES.LWXY[,])BFormatter.Deserialize(oFile);
                    moduleCLASSES.LLands = (byte[,,])BFormatter.Deserialize(oFile);
                }

                if (moduleLINES.NoOfLines > 0)
                    moduleLINES.Lines = (moduleLINES.GLine[])BFormatter.Deserialize(oFile);
                if (modulePOLYS.NoOfPolys > 0)
                    modulePOLYS.Polys = (modulePOLYS.GPoly[])BFormatter.Deserialize(oFile);
                if (moduleCLASSES.NoOfWaters > 0)
                {
                    moduleCLASSES.NoOfWWXYs = Conversions.ToInteger(BFormatter.Deserialize(oFile));
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
                UpdateFileMenu(filename);
                return;
            }
            catch (Exception exc)
            {
                oFile.Close();
                Interaction.MsgBox("This file is not a SBuilderX 3.XX project!", MsgBoxStyle.Exclamation);
                moduleMAPS.NoOfMaps = 0;
                moduleCLASSES.NoOfLands = 0;
                moduleLINES.NoOfLines = 0;
                modulePOLYS.NoOfPolys = 0;
                moduleCLASSES.NoOfWaters = 0;
                moduleOBJECTS.NoOfObjects = 0;
                moduleEXCLUDES.NoOfExcludes = 0;
                moduleCLASSES.NoOfLWCIs = 0;
            }
        }

        internal static void SaveFile(string filename)
        {
            var sFile = new FileStream(filename, FileMode.Create);
            var BFormatter = new BinaryFormatter();
            BFormatter.Serialize(sFile, "SB314");
            BFormatter.Serialize(sFile, moduleMAIN.ProjectName);
            BFormatter.Serialize(sFile, moduleMAIN.BGLProjectFolder);
            double savedZoom = Conversions.ToDouble(moduleMAIN.Zoom);
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
            FileSystem.PrintLine(FN, "CopyRight=" + "PTSIM SB314");
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
            FileSystem.PrintLine(FN, "LatDispCenter=" + Conversion.Str(moduleMAIN.LatDispCenter));
            FileSystem.PrintLine(FN, "LonDispCenter=" + Conversion.Str(moduleMAIN.LonDispCenter));
            FileSystem.PrintLine(FN, "Zoom=" + moduleMAIN.Zoom);
            var loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Map." + Strings.Trim(Conversion.Str(N)) + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Name=" + moduleMAPS.Maps[N].Name);
                FileSystem.PrintLine(FN, "BMPSu=" + moduleMAPS.Maps[N].BMPSu);
                FileSystem.PrintLine(FN, "BMPSp=" + moduleMAPS.Maps[N].BMPSp);
                FileSystem.PrintLine(FN, "BMPFa=" + moduleMAPS.Maps[N].BMPFa);
                FileSystem.PrintLine(FN, "BMPWi=" + moduleMAPS.Maps[N].BMPWi);
                FileSystem.PrintLine(FN, "BMPHw=" + moduleMAPS.Maps[N].BMPHw);
                FileSystem.PrintLine(FN, "BMPLm=" + moduleMAPS.Maps[N].BMPLm);
                FileSystem.PrintLine(FN, "Cols=" + Conversion.Str(moduleMAPS.Maps[N].COLS));
                FileSystem.PrintLine(FN, "Rows=" + Conversion.Str(moduleMAPS.Maps[N].ROWS));
                FileSystem.PrintLine(FN, "NLat=" + Conversion.Str(moduleMAPS.Maps[N].NLAT));
                FileSystem.PrintLine(FN, "SLat=" + Conversion.Str(moduleMAPS.Maps[N].SLAT));
                FileSystem.PrintLine(FN, "ELon=" + Conversion.Str(moduleMAPS.Maps[N].ELON));
                FileSystem.PrintLine(FN, "WLon=" + Conversion.Str(moduleMAPS.Maps[N].WLON));
            }

            var loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Line." + Strings.Trim(Conversion.Str(N)) + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Name=" + moduleLINES.Lines[N].Name);
                FileSystem.PrintLine(FN, "Type=" + moduleLINES.Lines[N].Type);
                FileSystem.PrintLine(FN, "Guid=" + moduleLINES.Lines[N].Guid);
                FileSystem.PrintLine(FN, "Color=" + ArgbFromColor(moduleLINES.Lines[N].Color));
                FileSystem.PrintLine(FN, "NoOfPoints=" + moduleLINES.Lines[N].NoOfPoints.ToString());
                var loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                for (M = 1; M <= loopTo2; M++)
                {
                    FileSystem.PrintLine(FN, "Lat" + Strings.Trim(Conversion.Str(M)) + "=" + Conversion.Str(moduleLINES.Lines[N].GLPoints[M].lat));
                    FileSystem.PrintLine(FN, "Lon" + Strings.Trim(Conversion.Str(M)) + "=" + Conversion.Str(moduleLINES.Lines[N].GLPoints[M].lon));
                    FileSystem.PrintLine(FN, "Alt" + M + "=" + Conversion.Str(moduleLINES.Lines[N].GLPoints[M].alt));
                    FileSystem.PrintLine(FN, "Wid" + M + "=" + Conversion.Str(moduleLINES.Lines[N].GLPoints[M].wid));
                }
            }

            var loopTo3 = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo3; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Poly." + Strings.Trim(Conversion.Str(N)) + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Name=" + modulePOLYS.Polys[N].Name);
                FileSystem.PrintLine(FN, "Type=" + modulePOLYS.Polys[N].Type);
                FileSystem.PrintLine(FN, "Guid=" + modulePOLYS.Polys[N].Guid);
                FileSystem.PrintLine(FN, "Color=" + ArgbFromColor(modulePOLYS.Polys[N].Color));
                FileSystem.PrintLine(FN, "NoOfChilds=" + modulePOLYS.Polys[N].NoOfChilds.ToString());
                var loopTo4 = modulePOLYS.Polys[N].NoOfChilds;
                for (M = 1; M <= loopTo4; M++)
                    FileSystem.PrintLine(FN, "Child" + Strings.Trim(Conversion.Str(M)) + "=" + Conversion.Str(modulePOLYS.Polys[N].Childs[M]));
                FileSystem.PrintLine(FN, "NoOfPoints=" + modulePOLYS.Polys[N].NoOfPoints.ToString());
                var loopTo5 = modulePOLYS.Polys[N].NoOfPoints;
                for (M = 1; M <= loopTo5; M++)
                {
                    FileSystem.PrintLine(FN, "Lat" + Strings.Trim(Conversion.Str(M)) + "=" + Conversion.Str(modulePOLYS.Polys[N].GPoints[M].lat));
                    FileSystem.PrintLine(FN, "Lon" + Strings.Trim(Conversion.Str(M)) + "=" + Conversion.Str(modulePOLYS.Polys[N].GPoints[M].lon));
                    FileSystem.PrintLine(FN, "Alt" + Strings.Trim(Conversion.Str(M)) + "=" + Conversion.Str(modulePOLYS.Polys[N].GPoints[M].alt));
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
                            A = "U=" + Strings.Format(J, "00");
                            FileSystem.PrintLine(FN, A);
                            A = "V=" + Strings.Format(K, "00");
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
                                            FileSystem.PrintLine(FN, "C" + Strings.Format(C, "000") + "R" + Strings.Format(R, "000=") + moduleCLASSES.LC[moduleCLASSES.LLands[C, R, P]].Index);
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
                            A = "U=" + Strings.Format(J, "00");
                            FileSystem.PrintLine(FN, A);
                            A = "V=" + Strings.Format(K, "00");
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
                                            FileSystem.PrintLine(FN, "C" + Strings.Format(C, "000") + "R" + Strings.Format(R, "000=") + moduleCLASSES.WC[moduleCLASSES.WWaters[C, R, P]].Index);
                                        }
                                    }
                                }
                            }

                            N = N + 1;
                        }
                    }
                }
            }

            var loopTo6 = moduleEXCLUDES.NoOfExcludes;
            for (N = 1; N <= loopTo6; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Exclude." + Strings.Trim(Conversion.Str(N)) + "]";
                FileSystem.PrintLine(FN, KEY);
                // before November 2017 these were CStr()
                FileSystem.PrintLine(FN, "Flag=" + Conversion.Str(moduleEXCLUDES.Excludes[N].Flag));
                FileSystem.PrintLine(FN, "NLat=" + Conversion.Str(moduleEXCLUDES.Excludes[N].NLAT));
                FileSystem.PrintLine(FN, "SLat=" + Conversion.Str(moduleEXCLUDES.Excludes[N].SLAT));
                FileSystem.PrintLine(FN, "ELon=" + Conversion.Str(moduleEXCLUDES.Excludes[N].ELON));
                FileSystem.PrintLine(FN, "WLon=" + Conversion.Str(moduleEXCLUDES.Excludes[N].WLON));
            }

            var loopTo7 = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo7; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[Object." + Strings.Trim(Conversion.Str(N)) + "]";
                FileSystem.PrintLine(FN, KEY);
                FileSystem.PrintLine(FN, "Type=" + moduleOBJECTS.Objects[N].Type.ToString());
                FileSystem.PrintLine(FN, "Description=" + moduleOBJECTS.Objects[N].Description);
                FileSystem.PrintLine(FN, "Width=" + Conversion.Str(moduleOBJECTS.Objects[N].Width));
                FileSystem.PrintLine(FN, "Length=" + Conversion.Str(moduleOBJECTS.Objects[N].Length));
                FileSystem.PrintLine(FN, "Heading=" + Conversion.Str(moduleOBJECTS.Objects[N].Heading));
                FileSystem.PrintLine(FN, "Pitch=" + Conversion.Str(moduleOBJECTS.Objects[N].Pitch));
                FileSystem.PrintLine(FN, "Bank=" + Conversion.Str(moduleOBJECTS.Objects[N].Bank));
                FileSystem.PrintLine(FN, "BiasX=" + Conversion.Str(moduleOBJECTS.Objects[N].BiasX));
                FileSystem.PrintLine(FN, "BiasY=" + Conversion.Str(moduleOBJECTS.Objects[N].BiasY));
                FileSystem.PrintLine(FN, "BiasZ=" + Conversion.Str(moduleOBJECTS.Objects[N].BiasZ));
                FileSystem.PrintLine(FN, "Lat=" + Conversion.Str(moduleOBJECTS.Objects[N].lat));
                FileSystem.PrintLine(FN, "Lon=" + Conversion.Str(moduleOBJECTS.Objects[N].lon));
                FileSystem.PrintLine(FN, "Altitude=" + Conversion.Str(moduleOBJECTS.Objects[N].Altitude));
                FileSystem.PrintLine(FN, "AGL=" + Conversion.Str(moduleOBJECTS.Objects[N].AGL));
                FileSystem.PrintLine(FN, "Complexity=" + Conversion.Str(moduleOBJECTS.Objects[N].Complexity));
            }

            var loopTo8 = moduleCLASSES.NoOfLWCIs;
            for (N = 1; N <= loopTo8; N++)
            {
                FileSystem.PrintLine(FN);
                KEY = "[LWCI." + Strings.Trim(Conversion.Str(N)) + "]";
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
            KEY = Strings.Left(KEY, 11);
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
                Interaction.MsgBox("Not a Valid SBX SBuilderX File!", MsgBoxStyle.Exclamation);
                return;
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
            if (Version == "SB314")
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
            var loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                KEY = "Map." + Strings.Trim(Conversion.Str(N));
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
            var loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                KEY = "[Line." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                moduleLINES.Lines[N].Name = Strings.Mid(FileSystem.LineInput(5), 6);
                moduleLINES.Lines[N].Type = Strings.Mid(FileSystem.LineInput(5), 6);
                moduleLINES.Lines[N].Guid = Strings.Mid(FileSystem.LineInput(5), 6);
                if (Version == "SB301")
                {
                    moduleLINES.Lines[N].Color = Color.FromArgb(Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 7)));
                }
                else
                {
                    moduleLINES.Lines[N].Color = ColorFromArgb(Strings.Mid(FileSystem.LineInput(5), 7));
                }

                moduleLINES.Lines[N].NoOfPoints = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                    moduleLINES.Lines[N].Name = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_Imported_Line";
                moduleLINES.Lines[N].GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                var loopTo2 = moduleLINES.Lines[N].NoOfPoints;
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
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    moduleLINES.Lines[N].GLPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    moduleLINES.Lines[N].GLPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    moduleLINES.Lines[N].GLPoints[M].alt = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    moduleLINES.Lines[N].GLPoints[M].wid = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                }

                moduleLINES.Lines[N].ELON = EL;
                moduleLINES.Lines[N].WLON = WL;
                moduleLINES.Lines[N].NLAT = NL;
                moduleLINES.Lines[N].SLAT = SL;
            }

            var loopTo3 = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo3; N++)
            {
                KEY = "[Poly." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                modulePOLYS.Polys[N].Name = Strings.Mid(FileSystem.LineInput(5), 6);
                modulePOLYS.Polys[N].Type = Strings.Mid(FileSystem.LineInput(5), 6);
                modulePOLYS.Polys[N].Guid = Strings.Mid(FileSystem.LineInput(5), 6);
                if (Version == "SB301")
                {
                    modulePOLYS.Polys[N].Color = Color.FromArgb(Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 7)));
                }
                else
                {
                    modulePOLYS.Polys[N].Color = ColorFromArgb(Strings.Mid(FileSystem.LineInput(5), 7));
                }

                J = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
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
                var loopTo4 = modulePOLYS.Polys[N].NoOfChilds;
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
                    modulePOLYS.Polys[N].Childs[M] = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                }

                modulePOLYS.Polys[N].NoOfPoints = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                    modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].NoOfPoints.ToString() + "_Pts_Imported_Polygon";
                modulePOLYS.Polys[N].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                var loopTo5 = modulePOLYS.Polys[N].NoOfPoints;
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
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    modulePOLYS.Polys[N].GPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    modulePOLYS.Polys[N].GPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    modulePOLYS.Polys[N].GPoints[M].alt = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
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
                var loopTo6 = moduleCLASSES.NoOfLLXYs;
                for (P = 1; P <= loopTo6; P++)
                {
                    KEY = "[LC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    K = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    L = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 11));
                    moduleCLASSES.LL_XY[J, K].Pointer = P - 1;
                    moduleCLASSES.LL_XY[J, K].NoOfLWs = L;
                    var loopTo7 = L;
                    for (M = 1; M <= loopTo7; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Conversion.Val(Strings.Mid(A, 2, 3));
                        R = (int)Conversion.Val(Strings.Mid(A, 6, 3));
                        I = (int)Conversion.Val(Strings.Mid(A, 10));
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
                var loopTo8 = moduleCLASSES.NoOfWWXYs;
                for (P = 1; P <= loopTo8; P++)
                {
                    KEY = "[WC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    K = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    L = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                    moduleCLASSES.WW_XY[J, K].Pointer = P - 1;
                    moduleCLASSES.WW_XY[J, K].NoOfLWs = L;
                    var loopTo9 = L;
                    for (M = 1; M <= loopTo9; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Conversion.Val(Strings.Mid(A, 2, 3));
                        R = (int)Conversion.Val(Strings.Mid(A, 6, 3));
                        I = (int)Conversion.Val(Strings.Mid(A, 10));
                        moduleCLASSES.WWaters[C, R, P - 1] = moduleCLASSES.IWC[I];
                        N = N + 1;
                    }
                }

                moduleCLASSES.NoOfWaters = N;
            }

            var loopTo10 = moduleEXCLUDES.NoOfExcludes;
            for (N = 1; N <= loopTo10; N++)
            {
                KEY = "[Exclude." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                moduleEXCLUDES.Excludes[N].Flag = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].NLAT = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].SLAT = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].ELON = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].WLON = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
            }

            var loopTo11 = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo11; N++)
            {
                KEY = "[Object." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                moduleOBJECTS.Objects[N].Type = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleOBJECTS.Objects[N].Description = Strings.Mid(FileSystem.LineInput(5), 13);
                moduleOBJECTS.Objects[N].Width = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].Length = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 8));
                moduleOBJECTS.Objects[N].Heading = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 9));
                moduleOBJECTS.Objects[N].Pitch = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].Bank = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleOBJECTS.Objects[N].BiasX = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].BiasY = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].BiasZ = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].lat = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].lon = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].Altitude = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 10));
                moduleOBJECTS.Objects[N].AGL = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].Complexity = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                moduleOBJECTS.AddLatLonToObjects(N);
            }

            var loopTo12 = moduleCLASSES.NoOfLWCIs;
            for (N = 1; N <= loopTo12; N++)
            {
                KEY = "[LWCI." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                moduleCLASSES.LWCIs[N].Text = Strings.Mid(FileSystem.LineInput(5), 6);
                moduleCLASSES.LWCIs[N].Color = ColorFromArgb(Strings.Mid(FileSystem.LineInput(5), 7));
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
            var loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                KEY = "Map." + Strings.Trim(Conversion.Str(N));
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
            var loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                KEY = "[Line." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                moduleLINES.Lines[N].Name = Strings.Mid(FileSystem.LineInput(5), 6);
                KEY = Strings.Mid(FileSystem.LineInput(5), 6);
                // Lines(N).Type = Mid(LineInput(5), 6)
                // Lines(N).Guid = Mid(LineInput(5), 6)
                ConvertOldLineType(N, KEY);
                C = Color.FromArgb(Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 7)));
                R = C.R;
                G = C.G;
                B = C.B;
                moduleLINES.Lines[N].Color = Color.FromArgb(B, G, R);
                moduleLINES.Lines[N].NoOfPoints = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                    moduleLINES.Lines[N].Name = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_Imported_Line";
                moduleLINES.Lines[N].GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                var loopTo2 = moduleLINES.Lines[N].NoOfPoints;
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
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));   // latitude
                    moduleLINES.Lines[N].GLPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));  // longitude
                    moduleLINES.Lines[N].GLPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    moduleLINES.Lines[N].GLPoints[M].alt = 0d;
                    moduleLINES.Lines[N].GLPoints[M].wid = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                }

                moduleLINES.Lines[N].ELON = EL;
                moduleLINES.Lines[N].WLON = WL;
                moduleLINES.Lines[N].NLAT = NL;
                moduleLINES.Lines[N].SLAT = SL;
            }

            var loopTo3 = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo3; N++)
            {
                KEY = "[Poly." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                modulePOLYS.Polys[N].Name = Strings.Mid(FileSystem.LineInput(5), 6);
                KEY = Strings.Mid(FileSystem.LineInput(5), 6);
                // Polys(N).Type = Mid(LineInput(5), 6)
                // Polys(N).Guid = Mid(LineInput(5), 6)
                ConvertOldPolyType(N, KEY);
                C = Color.FromArgb(Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 7)));
                R = C.R;
                G = C.G;
                B = C.B;
                modulePOLYS.Polys[N].Color = Color.FromArgb(B, G, R);
                modulePOLYS.Polys[N].NoOfChilds = 0;
                // ReDim Polys(N).Childs(Polys(N).NoOfChilds)
                modulePOLYS.Polys[N].NoOfPoints = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                    modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].NoOfPoints.ToString() + "_Pts_Imported_Polygon";
                modulePOLYS.Polys[N].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                var loopTo4 = modulePOLYS.Polys[N].NoOfPoints;
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
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    modulePOLYS.Polys[N].GPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    modulePOLYS.Polys[N].GPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    // *******!!!!
                    if (SB205)
                    {
                        modulePOLYS.Polys[N].GPoints[M].alt = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
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

            var loopTo5 = moduleEXCLUDES.NoOfExcludes;
            for (N = 1; N <= loopTo5; N++)
            {
                KEY = "[Exclude." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                moduleEXCLUDES.Excludes[N].Flag = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].NLAT = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].SLAT = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].ELON = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].WLON = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
            }

            var loopTo6 = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo6; N++)
            {
                KEY = "[Object." + Strings.Trim(Conversion.Str(N)) + "]";
                GoToThisKey(KEY);
                moduleOBJECTS.Objects[N].Type = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleOBJECTS.Objects[N].Description = Strings.Mid(FileSystem.LineInput(5), 13);
                moduleOBJECTS.Objects[N].Width = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].Length = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 8));
                moduleOBJECTS.Objects[N].Heading = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 9));
                moduleOBJECTS.Objects[N].Pitch = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].Bank = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleOBJECTS.Objects[N].BiasX = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].BiasY = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].BiasZ = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].lat = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].lon = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].Altitude = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 10));
                moduleOBJECTS.Objects[N].AGL = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].Complexity = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
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
            KEY = ReadIniValue(Filename, "Main", ref argVariable);
            KEY = Strings.Left(KEY, 11);
            if (KEY == "PTSIM SB205" | KEY == "PTSIM")
            {
                Interaction.MsgBox("You can not Append this file! Try to Import it!", MsgBoxStyle.Information);
                return;
            }

            string Version;
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
                Interaction.MsgBox("Not a Valid SBX SBuilderX File!", MsgBoxStyle.Exclamation);
                return;
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
            if (Version == "SB314")
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
            var loopTo = NoOfMapsX;
            for (K = 1; K <= loopTo; K++)
            {
                N = moduleMAPS.NoOfMaps + K;
                KEY = "Map." + Strings.Trim(Conversion.Str(K));
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
            var loopTo1 = NoOfLinesX;
            for (K = 1; K <= loopTo1; K++)
            {
                N = K + moduleLINES.NoOfLines;
                KEY = "[Line." + Strings.Trim(Conversion.Str(K)) + "]";
                GoToThisKey(KEY);
                moduleLINES.Lines[N].Name = Strings.Mid(FileSystem.LineInput(5), 6);
                moduleLINES.Lines[N].Type = Strings.Mid(FileSystem.LineInput(5), 6);
                moduleLINES.Lines[N].Guid = Strings.Mid(FileSystem.LineInput(5), 6);
                if (Version == "SB301")
                {
                    moduleLINES.Lines[N].Color = Color.FromArgb(Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 7)));
                }
                else
                {
                    moduleLINES.Lines[N].Color = ColorFromArgb(Strings.Mid(FileSystem.LineInput(5), 7));
                }

                moduleLINES.Lines[N].NoOfPoints = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                    moduleLINES.Lines[N].Name = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_Imported_Line";
                moduleLINES.Lines[N].GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                var loopTo2 = moduleLINES.Lines[N].NoOfPoints;
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
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    moduleLINES.Lines[N].GLPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    moduleLINES.Lines[N].GLPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    moduleLINES.Lines[N].GLPoints[M].alt = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    moduleLINES.Lines[N].GLPoints[M].wid = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                }

                moduleLINES.Lines[N].ELON = EL;
                moduleLINES.Lines[N].WLON = WL;
                moduleLINES.Lines[N].NLAT = NL;
                moduleLINES.Lines[N].SLAT = SL;
            }

            var loopTo3 = NoOfPolysX;
            for (K = 1; K <= loopTo3; K++)
            {
                N = K + modulePOLYS.NoOfPolys;
                KEY = "[Poly." + Strings.Trim(Conversion.Str(K)) + "]";
                GoToThisKey(KEY);
                modulePOLYS.Polys[N].Name = Strings.Mid(FileSystem.LineInput(5), 6);
                modulePOLYS.Polys[N].Type = Strings.Mid(FileSystem.LineInput(5), 6);
                modulePOLYS.Polys[N].Guid = Strings.Mid(FileSystem.LineInput(5), 6);
                if (Version == "SB301")
                {
                    modulePOLYS.Polys[N].Color = Color.FromArgb(Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 7)));
                }
                else
                {
                    modulePOLYS.Polys[N].Color = ColorFromArgb(Strings.Mid(FileSystem.LineInput(5), 7));
                }

                L = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
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
                var loopTo4 = modulePOLYS.Polys[N].NoOfChilds;
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
                    L = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    modulePOLYS.Polys[N].Childs[M] = L + modulePOLYS.NoOfPolys;
                }

                modulePOLYS.Polys[N].NoOfPoints = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                    modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].NoOfPoints.ToString() + "_Pts_Imported_Polygon";
                modulePOLYS.Polys[N].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[N].NoOfPoints + 1];
                J = 6;
                NL = -90;
                SL = 90d;
                EL = -180;
                WL = 180d;
                var loopTo5 = modulePOLYS.Polys[N].NoOfPoints;
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
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    modulePOLYS.Polys[N].GPoints[M].lat = X;
                    if (X < SL)
                        SL = X;
                    if (X > NL)
                        NL = X;
                    X = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
                    modulePOLYS.Polys[N].GPoints[M].lon = X;
                    if (X > EL)
                        EL = X;
                    if (X < WL)
                        WL = X;
                    modulePOLYS.Polys[N].GPoints[M].alt = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), J));
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
            if (Conversions.ToBoolean(NoOfLLXYsX))
            {
                D = 0;
                var oldLLands = moduleCLASSES.LLands;
                moduleCLASSES.LLands = new byte[257, 257, (moduleCLASSES.NoOfLLXYs + NoOfLLXYsX)];
                if (oldLLands is object)
                    for (var i1 = 0; i1 <= oldLLands.Length / oldLLands.GetLength(2) - 1; ++i1)
                        Array.Copy(oldLLands, i1 * oldLLands.GetLength(2), moduleCLASSES.LLands, i1 * moduleCLASSES.LLands.GetLength(2), Math.Min(oldLLands.GetLength(2), moduleCLASSES.LLands.GetLength(2)));
                var loopTo6 = NoOfLLXYsX;
                for (P = 1; P <= loopTo6; P++)
                {
                    KEY = "[LC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    K = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    L = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 11));
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
                    var loopTo7 = L;
                    for (M = 1; M <= loopTo7; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Conversion.Val(Strings.Mid(A, 2, 3));
                        R = (int)Conversion.Val(Strings.Mid(A, 6, 3));
                        I = (int)Conversion.Val(Strings.Mid(A, 10));
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
                    var oldLLands1 = moduleCLASSES.LLands;
                    moduleCLASSES.LLands = new byte[257, 257, moduleCLASSES.NoOfLLXYs + NoOfLLXYsX - 1 - D + 1];
                    if (oldLLands1 is object)
                        for (var i2 = 0; i2 <= oldLLands1.Length / oldLLands1.GetLength(2) - 1; ++i2)
                            Array.Copy(oldLLands1, i2 * oldLLands1.GetLength(2), moduleCLASSES.LLands, i2 * moduleCLASSES.LLands.GetLength(2), Math.Min(oldLLands1.GetLength(2), moduleCLASSES.LLands.GetLength(2)));
                }
            }

            NN = moduleCLASSES.NoOfWaters;
            if (Conversions.ToBoolean(NoOfWWXYsX))
            {
                D = 0;
                var oldWWaters = moduleCLASSES.WWaters;
                moduleCLASSES.WWaters = new byte[257, 257, (moduleCLASSES.NoOfWWXYs + NoOfWWXYsX)];
                if (oldWWaters is object)
                    for (var i3 = 0; i3 <= oldWWaters.Length / oldWWaters.GetLength(2) - 1; ++i3)
                        Array.Copy(oldWWaters, i3 * oldWWaters.GetLength(2), moduleCLASSES.WWaters, i3 * moduleCLASSES.WWaters.GetLength(2), Math.Min(oldWWaters.GetLength(2), moduleCLASSES.WWaters.GetLength(2)));
                var loopTo8 = NoOfWWXYsX;
                for (P = 1; P <= loopTo8; P++)
                {
                    KEY = "[WC_LOD5." + P + "]";
                    GoToThisKey(KEY);
                    J = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    K = (int)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 3));
                    L = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
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
                    var loopTo9 = L;
                    for (M = 1; M <= loopTo9; M++)
                    {
                        A = FileSystem.LineInput(5);
                        C = (int)Conversion.Val(Strings.Mid(A, 2, 3));
                        R = (int)Conversion.Val(Strings.Mid(A, 6, 3));
                        I = (int)Conversion.Val(Strings.Mid(A, 10));
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
                    var oldWWaters1 = moduleCLASSES.WWaters;
                    moduleCLASSES.WWaters = new byte[257, 257, moduleCLASSES.NoOfWWXYs + NoOfWWXYsX - 1 - D + 1];
                    if (oldWWaters1 is object)
                        for (var i4 = 0; i4 <= oldWWaters1.Length / oldWWaters1.GetLength(2) - 1; ++i4)
                            Array.Copy(oldWWaters1, i4 * oldWWaters1.GetLength(2), moduleCLASSES.WWaters, i4 * moduleCLASSES.WWaters.GetLength(2), Math.Min(oldWWaters1.GetLength(2), moduleCLASSES.WWaters.GetLength(2)));
                }
            }

            var loopTo10 = NoOfExcludesX;
            for (K = 1; K <= loopTo10; K++)
            {
                N = K + moduleEXCLUDES.NoOfExcludes;
                KEY = "[Exclude." + Strings.Trim(Conversion.Str(K)) + "]";
                GoToThisKey(KEY);
                moduleEXCLUDES.Excludes[N].Flag = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].NLAT = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].SLAT = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].ELON = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleEXCLUDES.Excludes[N].WLON = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
            }

            var loopTo11 = NoOfObjectsX;
            for (K = 1; K <= loopTo11; K++)
            {
                N = K + moduleOBJECTS.NoOfObjects;
                KEY = "[Object." + Strings.Trim(Conversion.Str(K)) + "]";
                GoToThisKey(KEY);
                moduleOBJECTS.Objects[N].Type = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleOBJECTS.Objects[N].Description = Strings.Mid(FileSystem.LineInput(5), 13);
                moduleOBJECTS.Objects[N].Width = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].Length = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 8));
                moduleOBJECTS.Objects[N].Heading = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 9));
                moduleOBJECTS.Objects[N].Pitch = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].Bank = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 6));
                moduleOBJECTS.Objects[N].BiasX = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].BiasY = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].BiasZ = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 7));
                moduleOBJECTS.Objects[N].lat = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].lon = Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].Altitude = (float)Conversion.Val(Strings.Mid(FileSystem.LineInput(5), 10));
                moduleOBJECTS.Objects[N].AGL = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 5));
                moduleOBJECTS.Objects[N].Complexity = Conversions.ToInteger(Strings.Mid(FileSystem.LineInput(5), 12));
                moduleOBJECTS.AddLatLonToObjects(N);
            }

            var loopTo12 = NoOfLWCIsX;
            for (K = 1; K <= loopTo12; K++)
            {
                N = K + moduleCLASSES.NoOfLWCIs;
                KEY = "[LWCI." + Strings.Trim(Conversion.Str(K)) + "]";
                GoToThisKey(KEY);
                moduleCLASSES.LWCIs[N].Text = Strings.Mid(FileSystem.LineInput(5), 6);
                moduleCLASSES.LWCIs[N].Color = ColorFromArgb(Strings.Mid(FileSystem.LineInput(5), 7));
            }

            FileSystem.FileClose(5);
            moduleMAPS.NoOfMaps = moduleMAPS.NoOfMaps + NoOfMapsX;
            moduleLINES.NoOfLines = moduleLINES.NoOfLines + NoOfLinesX;
            modulePOLYS.NoOfPolys = modulePOLYS.NoOfPolys + NoOfPolysX;
            moduleOBJECTS.NoOfObjects = moduleOBJECTS.NoOfObjects + NoOfObjectsX;
            moduleEXCLUDES.NoOfExcludes = moduleEXCLUDES.NoOfExcludes + NoOfExcludesX;
            moduleCLASSES.NoOfLWCIs = moduleCLASSES.NoOfLWCIs + NoOfLWCIsX;
            SetLWCIs();
            var loopTo13 = moduleCLASSES.NoOfLWCIs;
            for (K = 1; K <= loopTo13; K++)
                Interaction.MsgBox(moduleCLASSES.LWCIs[2].Color.ToString() + " " + moduleCLASSES.LWCIs[2].IsLand.ToString() + " Text= " + moduleCLASSES.LWCIs[2].Text);
            My.MyProject.Forms.FrmStart.SetMouseIcon();
        }

        private static void GoToThisKey(string KEY)
        {
            string A;
            int NK, NA;
            NK = Strings.Len(KEY);
            do
            {
                A = FileSystem.LineInput(5);
                NA = Strings.Len(A);
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
                ReadIniIntegerRet = Conversions.ToInteger(ReadIniValue(File, KEY, ref Value));
            }
            catch (Exception exc)
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
                ReadIniDoubleRet = Conversion.Val(ReadIniValue(File, KEY, ref Value));
            }
            catch (Exception exc)
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
                var loopTo = moduleCLASSES.NoOfLWCIs;
                for (J = 1; J <= loopTo; J++)
                {
                    A = Strings.Trim(moduleCLASSES.LWCIs[J].Text) + " ";
                    N1 = 1;
                    N2 = Strings.InStr(1, A, " ");
                    B = Strings.UCase(Strings.Mid(A, 1, N2 - N1));
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
                    N2 = Strings.InStr(N1, A, " ");
                    P0 = Conversions.ToByte(Strings.Mid(A, N1, N2 - N1));
                    if (IsLand)
                    {
                        var loopTo1 = moduleCLASSES.NoOfLCs;
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
                        var loopTo2 = moduleCLASSES.NoOfWCs;
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
                    N2 = Strings.InStr(N1, A, " ");
                    P0 = Conversions.ToByte(Strings.Mid(A, N1, N2 - N1));
                    if (IsLand)
                    {
                        var loopTo3 = moduleCLASSES.NoOfLCs;
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
                        var loopTo4 = moduleCLASSES.NoOfWCs;
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
                    N2 = Strings.InStr(N1, A, " ");
                    P0 = Conversions.ToByte(Strings.Mid(A, N1, N2 - N1));
                    if (IsLand)
                    {
                        var loopTo5 = moduleCLASSES.NoOfLCs;
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
                        var loopTo6 = moduleCLASSES.NoOfWCs;
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
            catch (ArgumentException exc)
            {
                Interaction.MsgBox("Land/Water Class indexes could not be read!", MsgBoxStyle.Exclamation);
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
                Marker = Marker + Strings.Len(A) + 2;
                B = Strings.UCase(Strings.Trim(Strings.Mid(A, 1, 4)));
                if (B == "GUID")
                {
                    C = Strings.Trim(Strings.Mid(A, 6));
                    LegacyPolys[K].Guid = C;
                }

                if (B == "TYPE")
                {
                    C = Strings.Trim(Strings.Mid(A, 6, 3));
                    if (C == "LCP")
                    {
                        if (Strings.Len(A) > 8)
                        {
                            try
                            {
                                J = Conversions.ToInteger(Strings.Trim(Strings.Mid(A, 9)));
                            }
                            catch (Exception ex)
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
                Marker = Marker + Strings.Len(A) + 2;
                B = Strings.UCase(Strings.Trim(Strings.Mid(A, 1, 4)));
                if (B == "GUID")
                {
                    C = Strings.Trim(Strings.Mid(A, 6));
                    LegacyLines[K].Guid = C;
                }

                if (B == "TYPE")
                {
                    if (Strings.Len(A) > 8)
                    {
                        try
                        {
                            J = Conversions.ToInteger(Strings.Trim(Strings.Mid(A, 9)));
                        }
                        catch (Exception ex)
                        {
                            J = 0;
                        }

                        if (J > 0)
                        {
                            LegacyLines[K].Legacy = J;
                            LegacyLines[K].Type = Strings.Trim(Strings.Mid(A, 6, 3));
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
            A = Strings.Trim(Key);

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
                B = Strings.Mid(A, 1, 3);
                if (B == "VTP")
                {
                    J = Strings.InStr(A, "//");
                    A = Strings.Mid(A, J + 2);
                    J = Strings.InStr(A, "//");
                    A = Strings.Mid(A, J + 2);
                    J = Strings.InStr(A, "//");
                    A = Strings.Mid(A, 1, J - 1);
                    J = Conversions.ToInteger(A);
                    Flag = false;
                    var loopTo = NoOfLegacyPolys;
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
                    J = Strings.InStr(A, "//");
                    A = Strings.Mid(A, J + 2);
                    // Water//455//455//1//1//
                    J = Strings.InStr(A, "//");
                    B = Strings.Mid(A, 1, J - 1);
                    A = Strings.Mid(A, J + 2);
                    // 455//455//1//1//

                    if (B == "Water")
                    {
                        J = Strings.InStr(A, "//");
                        B = Strings.Mid(A, 1, J - 1);
                        K = Conversions.ToInteger(B);
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
                        J = Strings.InStr(A, "//");
                        B = Strings.Mid(A, 1, J - 1);
                        K = Conversions.ToInteger(B);
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
            catch (Exception exc)
            {
                modulePOLYS.Polys[N].Name = modulePOLYS.Polys[N].Name + "_not converted from SB205";
            }
        }

        private static void ConvertOldLineType(int N, string Key)
        {

            // Type=VTP//7//1032//

            string A, B;
            A = Strings.Trim(Key);

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
                B = Strings.Mid(A, 1, 3);
                if (B == "VTP")
                {
                    J = Strings.InStr(A, "//");
                    A = Strings.Mid(A, J + 2);
                    J = Strings.InStr(A, "//");
                    A = Strings.Mid(A, J + 2);
                    J = Strings.InStr(A, "//");
                    A = Strings.Mid(A, 1, J - 1);
                    J = Conversions.ToInteger(A);
                    Flag = false;
                    var loopTo = NoOfLegacyLines;
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
            catch (Exception exc)
            {
                moduleLINES.Lines[N].Name = moduleLINES.Lines[N].Name + "_not converted from SB205";
            }
        }

        private static string ArgbFromColor(Color myColor)
        {
            string ArgbFromColorRet = default;
            string A, R, G, B;
            A = Conversion.Hex(myColor.A);
            if (Strings.Len(A) == 1)
                A = "0" + A;
            R = Conversion.Hex(myColor.R);
            if (Strings.Len(R) == 1)
                R = "0" + R;
            G = Conversion.Hex(myColor.G);
            if (Strings.Len(G) == 1)
                G = "0" + G;
            B = Conversion.Hex(myColor.B);
            if (Strings.Len(B) == 1)
                B = "0" + B;
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
            typeName = typeName.Replace("WindowsApplication1", "SBuilderX");
            typeToDeserialize = Type.GetType(string.Format("{0}, {1}", typeName, assemblyName));
            return typeToDeserialize;
        }
    }
}