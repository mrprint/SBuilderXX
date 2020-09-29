using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SBuilderX
{
    static class moduleMAIN
    {
        internal static int PolyInit = 15;   // see these! exclude excludes?
        internal static int LineInit = 4;   // see these! exclude excludes?

        // Friend Structure Lod5
        // Dim Lod5X As Integer
        // Dim Lod5Y As Integer
        // Dim X As Integer
        // Dim Y As Integer
        // End Structure

        internal struct Double_XY
        {
            public double X;
            public double Y;
        }

        internal struct Double_XYZ
        {
            public double X;
            public double Y;
            public double Z;
        }

        internal struct Double_XYZW   // used to fragment lines
        {
            public double X;
            public double Y;
            public double Z;
            public double W;
        }

        internal struct Slice   // for polys
        {
            public int N;     // do not remember why used Long, so changed to Integer may Dick can test with his data
            public int NC;
            public int[] C;
            public Double_XY[] P;
        }

        internal static Slice[] Slices;
        internal static int NoOfSlices;

        internal struct Fragment  // for lines
        {
            public int N;       // do not remember why used Long, so changed to Integer may Dick can test with his data
            public int NC;
            public int[] C;
            public Double_XYZW[] P;
        }

        internal static Fragment[] Fragments;
        internal static int NoOfFragments;
        internal static string AppTitle = "SBuilderX";
        internal static string ProjectName = "";
        internal static string AppPath = My.MyProject.Application.Info.DirectoryPath; // INI File App constant.
        internal static string AppIni = My.MyProject.Application.Info.DirectoryPath + @"\SBuilderX.ini"; // INI File App constant.

        // for Registration
        internal static bool ShowDonation;
        internal static bool IsFSX;   // if terrain.cfg detected
        internal static string SDKPath;
        internal static string SDKTerrain;
        internal static string SDKBglComp;
        internal static bool OriginalTerrainCFG;
        internal static bool IsFSXTerrain;
        internal static bool IsFSXBGLComp;
        internal static bool MakeSlopeXY; // if False SlopeX and SlopeY will be set to 0 before passing SHP to shp2vec
        internal static bool IsFSXPlugins;
        internal static string SDKPlugins;
        internal static string FSPath;
        internal static string FSTextureFolder;

        // added October 2017
        internal static string NameOfSim;    // exists in the INI
        internal static string SimExe;       // deduced from NameOfSim
        internal static string SimPath;      // exists in the INI
        internal static bool IgnoreFSX;   // deduced from the NameOfSim
        internal static bool ShowLabels;
        internal static string ImageFileName;
        // used by frmImage
        internal static string ImageFileNameTrue; // used by the screen capture
        internal static string Season;

        // indicate mode ON/OFF

        internal static bool PointerON = false;
        internal static bool ZoomON = false;

        // used in the Select menu bar
        internal static bool AllSELECT;
        internal static bool SomeSelected;
        internal static int NoOfPointsSelected = 0;

        // used by Lines and Polys
        internal static bool NoEndsSmooth;
        internal static bool CornerSmooth;
        internal static double SampleDistance;
        internal static double SmoothDistance;
        internal static int MakeOnMany = 1;

        // used in View menu bar
        internal static bool AllVIEW;
        internal static bool ViewON = false;
        internal static bool AircraftVIEW;
        internal static int ShowAircraftPeriod;  // FSUIPC
        internal static bool DELAY = false;
        internal static bool WAIT;

        // used by the display routines

        internal static bool PanON = false; // a PAN movement is under way
        internal static bool SelectON = false; // the mouse is drawing a selection box
        internal static bool MoveON = false;  // an element (point, line, ...) is moving
        internal static bool FirstMOVE = false;
        internal static double LatDispNorth; // latitude of display north border
        internal static double LatDispSouth; // latitude of display south border
        internal static double LonDispWest;  // longitude of display west border
        internal static double LonDispEast;  // longitude of display east border
        internal static double LatDispCenter; // latitude of display center point
        internal static double LonDispCenter; // longitude of display center point
        internal static bool CenterOnMouseWheel;  // to be set through INI used in the mouse wheel Zoom
        internal static double LatIniCenter = 40d;
        internal static double LonIniCenter = -10;
        internal static double PixelsPerLatDeg; // latitude resolution of display window
        internal static double PixelsPerLonDeg; // longitude resolution of display window
        internal static double PixelsPerMeter;  // longitude resolution of display window
        internal static bool DecimalDegrees;

        // ON when inserting points in Lines or Polys
        internal static bool InsertON;
        internal static int AuxXInt;
        internal static int AuxYInt;
        internal static int QMIDLevel;
        internal static Color GridColor;
        internal static Color GridLODColor;
        internal static int GridWidth;
        internal static bool ZoomOnQMID;
        internal static int LODLevel;
        internal static string BGLProjectFolder;
        internal static double AircraftAltitudeOffset;
        internal static string BGLFolder; // from the INI
        internal static int Zoom = 1;   // changed from Double to Integer in October 2017
        internal static Color ARGBColor;   // for the return of the transparency form
        internal static bool DeleteON;
        internal static bool AskDelete;
        internal static bool Dirty;
        internal static string WorkFile;
        internal static int DisplayWidth; // value in pixels
        internal static int DisplayHeight; // value in pixels
        internal static int DisplayCenterX; // value in pixels
        internal static int DisplayCenterY; // value in pixels
        internal static Bitmap BitmapBuffer;

        internal static void RebuildDisplay()
        {

            // builds the buffer
            // copies the buffer to the display

            if (WAIT)
                return;
            WAIT = true;
            My.MyProject.Forms.FrmStart.BuildBitmapBuffer();
            My.MyProject.Forms.FrmStart.UpdateDisplay();
            WAIT = false;
        }

        internal static void SetDispCenter(int X, int Y)
        {

            // sets center and limits of the display
            // call SetDispCenter(0,0) to set display limits only
            // it resets the zoom (to adjust Pixels per Long Degree)
            // X and Y bring the desired shift in pixels

            double LatSouthLimit;
            double LatNorthLimit;
            double NewLatDispCenter;
            double NewLonDispEast;
            double NewLonDispWest;
            double DX, DY;  // shift 
            DY = 90.0d / Math.Pow(2.0d, Zoom);
            LatNorthLimit = 90.0d - DY;
            LatSouthLimit = -90.0d + DY;
            DY = -(Y / PixelsPerLatDeg);
            NewLatDispCenter = LatDispCenter + DY;
            if (NewLatDispCenter > LatNorthLimit)
            {
                LatDispCenter = LatNorthLimit;
            }
            else if (NewLatDispCenter < LatSouthLimit)
            {
                LatDispCenter = LatSouthLimit;
            }
            else
            {
                LatDispCenter = NewLatDispCenter;
            }

            ResetZoom();
            DX = X / PixelsPerLonDeg;
            NewLonDispEast = LonDispEast + DX;
            NewLonDispWest = LonDispWest + DX;
            if (NewLonDispEast > 180d)
            {
                DX = DX - (NewLonDispEast - 180d);
            }

            if (NewLonDispWest < -180)
            {
                DX = DX - (NewLonDispWest + 180d);
            }

            LonDispCenter = LonDispCenter + DX;
            LatDispNorth = LatDispCenter + DisplayCenterY / PixelsPerLatDeg;
            LatDispSouth = LatDispCenter - DisplayCenterY / PixelsPerLatDeg;
            LonDispWest = LonDispCenter - DisplayCenterX / PixelsPerLonDeg;
            LonDispEast = LonDispCenter + DisplayCenterX / PixelsPerLonDeg;
            if (LonDispWest < -180)
            {
                DX = 180d + LonDispWest;
                LonDispWest = LonDispWest - DX;
                LonDispEast = LonDispEast - DX;
                LonDispCenter = LonDispCenter - DX;
            }

            if (LonDispEast > 180d)
            {
                DX = LonDispEast - 180d;
                LonDispEast = LonDispEast - DX;
                LonDispEast = LonDispEast - DX;
                LonDispCenter = LonDispCenter - DX;
            }
        }

        internal static bool IsCenterDisplay(int X, int Y)
        {
            bool IsCenterDisplayRet = default;
            int X1, X2, Y1, Y2, YY;
            IsCenterDisplayRet = true;
            X1 = (int)(DisplayWidth * 0.05d);
            if (X < X1)
                return IsCenterDisplayRet;
            X2 = (int)(DisplayWidth * 0.95d);
            if (X > X2)
                return IsCenterDisplayRet;
            YY = DisplayHeight - My.MyProject.Forms.FrmStart.MenuStrip.Height - My.MyProject.Forms.FrmStart.StatusStrip.Height - My.MyProject.Forms.FrmStart.ToolStrip.Height;
            YY = (int)(0.05d * YY);
            Y1 = YY + My.MyProject.Forms.FrmStart.MenuStrip.Height + My.MyProject.Forms.FrmStart.ToolStrip.Height;
            if (Y < Y1)
                return IsCenterDisplayRet;
            Y2 = DisplayHeight - YY - My.MyProject.Forms.FrmStart.StatusStrip.Height;
            if (Y > Y2)
                return IsCenterDisplayRet;
            IsCenterDisplayRet = false;
            return IsCenterDisplayRet;
        }

        internal static void SetDelay(int N)
        {
            if (My.MyProject.Forms.FrmStart.Timer1.Enabled)
                return; // if delay is on then ignore
            if (N > 0)
            {
                My.MyProject.Forms.FrmStart.Timer1.Interval = N;
                DELAY = true;
                My.MyProject.Forms.FrmStart.Timer1.Enabled = true;
                return;
            }

            if (N == 0)
            {
                My.MyProject.Forms.FrmStart.Timer1.Enabled = false;
                DELAY = false;
            }
        }

        internal static bool MeasuringMeters;
        internal const double MetersPerDegLat = 111330.0d;
        internal const double D0Lon = 360.0d / 3.0d;
        internal const double D1Lon = D0Lon / 2.0d;
        internal const double D2Lon = D1Lon / 2.0d;
        internal const double D3Lon = D2Lon / 2.0d;
        internal const double D4Lon = D3Lon / 2.0d;
        internal const double D5Lon = D4Lon / 2.0d;
        internal const double D6Lon = D5Lon / 2.0d;
        internal const double D7Lon = D6Lon / 2.0d;
        internal const double D8Lon = D7Lon / 2.0d;
        internal const double D9Lon = D8Lon / 2.0d;
        internal const double D10Lon = D9Lon / 2.0d;
        internal const double D11Lon = D10Lon / 2.0d;
        internal const double D12Lon = D11Lon / 2.0d;
        internal const double D13Lon = D12Lon / 2.0d;
        internal const double D14Lon = D13Lon / 2.0d;
        internal const double D16Lon = D13Lon / 8.0d;
        internal const double D0Lat = 180.0d / 2.0d;
        internal const double D1Lat = D0Lat / 2.0d;
        internal const double D2Lat = D1Lat / 2.0d;
        internal const double D3Lat = D2Lat / 2.0d;
        internal const double D4Lat = D3Lat / 2.0d;
        internal const double D5Lat = D4Lat / 2.0d;
        internal const double D6Lat = D5Lat / 2.0d;
        internal const double D7Lat = D6Lat / 2.0d;
        internal const double D8Lat = D7Lat / 2.0d;
        internal const double D9Lat = D8Lat / 2.0d;
        internal const double D10Lat = D9Lat / 2.0d;
        internal const double D11Lat = D10Lat / 2.0d;
        internal const double D12Lat = D11Lat / 2.0d;
        internal const double D13Lat = D12Lat / 2.0d;
        internal const double D14Lat = D13Lat / 2.0d;
        internal const double D16Lat = D13Lat / 8.0d;
        internal const double D255Lon = D13Lon / 255.0d;
        internal const double D255Lat = D13Lat / 255.0d;
        internal const double D510Lon = D255Lon / 2.0d;
        internal const double D510Lat = D255Lat / 2.0d;


        // this is a minimum (not zero though!)
        internal const double MinValue = 0.0000000000000005d;

        // the following are used in photo scenery
        internal const double D21Lon = 360.0d / 768.0d / 32.0d / 256.0d;
        internal const double D21Lat = 180.0d / 512.0d / 32.0d / 256.0d;
        internal const double D22Lon = D21Lon / 2.0d;
        internal const double D22Lat = D21Lat / 2.0d;



        // Friend Const D5Lon  As Double = 360 / 96
        // Friend Const D5Lat As Double = 180 / 64
        internal const double PI = 3.14159265358979d;

        // to go to other modules

        internal static void UnSelectAll()
        {
            if (SomeSelected == false)
            {
                NoOfPointsSelected = 0;
                moduleLINES.NoOfLinesSelected = 0;
                modulePOLYS.NoOfPolysSelected = 0;
                moduleOBJECTS.NoOfObjectsSelected = 0;
                moduleCLASSES.NoOfLandsSelected = 0;
                moduleCLASSES.NoOfWatersSelected = 0;
                moduleMAPS.NoOfMapsSelected = 0;
                moduleEXCLUDES.NoOfExcludesSelected = 0;
                My.MyProject.Forms.FrmStart.SelectAllMenuItem.Checked = false;
                AllSELECT = false;
                return;
            }

            bool argFlag = false;
            moduleMAPS.SelectAllMaps(ref argFlag);
            bool argFlag1 = false;
            moduleCLASSES.SelectAllLands(ref argFlag1);
            bool argFlag2 = false;
            moduleLINES.SelectAllLines(ref argFlag2);
            bool argFlag3 = false;
            modulePOLYS.SelectAllPolys(ref argFlag3);
            bool argFlag4 = false;
            moduleCLASSES.SelectAllWaters(ref argFlag4);
            bool argFlag5 = false;
            moduleOBJECTS.SelectAllObjects(ref argFlag5);
            bool argFlag6 = false;
            moduleEXCLUDES.SelectAllExcludes(ref argFlag6);
            AllSELECT = false;
            SomeSelected = false;
            NoOfPointsSelected = 0;
            moduleLINES.NoOfLinesSelected = 0;
            modulePOLYS.NoOfPolysSelected = 0;
            moduleOBJECTS.NoOfObjectsSelected = 0;
            moduleCLASSES.NoOfLandsSelected = 0;
            moduleCLASSES.NoOfWatersSelected = 0;
            moduleMAPS.NoOfMapsSelected = 0;
            moduleEXCLUDES.NoOfExcludesSelected = 0;
            My.MyProject.Forms.FrmStart.SelectAllMenuItem.Checked = false;
        }

        internal static void SelectAll()
        {
            NoOfPointsSelected = 0;
            moduleLINES.NoOfLinesSelected = 0;
            modulePOLYS.NoOfPolysSelected = 0;
            moduleOBJECTS.NoOfObjectsSelected = 0;
            moduleCLASSES.NoOfLandsSelected = 0;
            moduleCLASSES.NoOfWatersSelected = 0;
            moduleMAPS.NoOfMapsSelected = 0;
            moduleEXCLUDES.NoOfExcludesSelected = 0;
            bool argFlag = true;
            moduleMAPS.SelectAllMaps(ref argFlag);
            bool argFlag1 = true;
            moduleLINES.SelectAllLines(ref argFlag1);
            bool argFlag2 = true;
            modulePOLYS.SelectAllPolys(ref argFlag2);
            bool argFlag3 = true;
            moduleCLASSES.SelectAllWaters(ref argFlag3);
            bool argFlag4 = true;
            moduleCLASSES.SelectAllLands(ref argFlag4);
            bool argFlag5 = true;
            moduleOBJECTS.SelectAllObjects(ref argFlag5);
            bool argFlag6 = true;
            moduleEXCLUDES.SelectAllExcludes(ref argFlag6);
            SomeSelected = true;
        }

        internal static void SelectBoxed(int X, int Y)
        {
            double X0, Y0;
            double X1, Y1;
            X0 = LonDispWest + AuxXInt / PixelsPerLonDeg;
            Y0 = LatDispNorth - AuxYInt / PixelsPerLatDeg;
            X1 = LonDispWest + X / PixelsPerLonDeg;
            Y1 = LatDispNorth - Y / PixelsPerLatDeg;

            // point 0 will be NW and point 1 SE
            if (X0 > X1)
            {
                X1 = X0 + X1;
                X0 = X1 - X0;
                X1 = X1 - X0;
            }

            if (Y1 > Y0)
            {
                Y1 = Y0 + Y1;
                Y0 = Y1 - Y0;
                Y1 = Y1 - Y0;
            }

            if (moduleLINES.LineON)
            {
                moduleLINES.SelectLinesInBox(X0, Y0, X1, Y1);
                return;
            }

            if (modulePOLYS.PolyON)
            {
                modulePOLYS.SelectPolysInBox(X0, Y0, X1, Y1);
                return;
            }

            if (moduleOBJECTS.ObjectON)
            {
                moduleOBJECTS.SelectObjectsInBox(X0, Y0, X1, Y1);
                return;
            }

            if (moduleMAPS.MapVIEW)
                moduleMAPS.SelectMapsInBox(X0, Y0, X1, Y1);
            if (moduleLINES.LineVIEW)
                moduleLINES.SelectLinesInBox(X0, Y0, X1, Y1);
            if (modulePOLYS.PolyVIEW)
                modulePOLYS.SelectPolysInBox(X0, Y0, X1, Y1);
            if (moduleEXCLUDES.ExcludeVIEW)
                moduleEXCLUDES.SelectExcludesInBox(X0, Y0, X1, Y1);
            // If PhotoVIEW Then SelectPhotosInBox(X0, Y0, X1, Y1)
            if (moduleCLASSES.LandVIEW)
                moduleCLASSES.SelectLandsInBox(X0, Y0, X1, Y1);
            if (moduleCLASSES.WaterVIEW)
                moduleCLASSES.SelectWatersInBox(X0, Y0, X1, Y1);
            // If MeshVIEW Then SelectMeshesInBox(X0, Y0, X1, Y1)
            if (moduleOBJECTS.ObjectVIEW)
                moduleOBJECTS.SelectObjectsInBox(X0, Y0, X1, Y1);
        }

        internal static Color InvertColor(Color Col)
        {
            Color InvertColorRet = default;
            int A;
            int R = 0;
            int G = 0;
            int B = 0;
            int I;
            A = Col.A;
            R = Col.R;
            G = Col.G;
            B = Col.B;
            I = R + G + B;
            if (I < 384)
            {
                R = 255;
                G = 255;
                B = 255;
            }
            else
            {
                R = 0;
                G = 0;
                B = 0;
            }

            InvertColorRet = Color.FromArgb(A, R, G, B);
            return InvertColorRet;
        }

        // Friend Function LL2Lod5(ByVal X As Double, ByVal Y As Double) As Lod5

        // X = X + 180
        // Y = 90 - Y

        // X = X / D5Lon
        // LL2Lod5.Lod5X = CInt(Fix(X))

        // Y = Y / D5Lat
        // LL2Lod5.Lod5Y = CInt(Fix(Y))

        // LL2Lod5.X = CInt(Fix((X - LL2Lod5.Lod5X) * D5Lon / D13Lon))
        // LL2Lod5.Y = CInt(Fix((Y - LL2Lod5.Lod5Y) * D5Lat / D13Lat))


        // End Function

        internal static void ResetZoom()
        {
            if (Zoom > moduleTILES.GlobeOrTiles)
            {
                PixelsPerLatDeg = Math.Pow(2d, Zoom) * 256d / 180.0d;
            }
            else
            {
                PixelsPerLatDeg = Math.Pow(2d, Zoom) * DisplayHeight / 180.0d;
            }

            PixelsPerMeter = PixelsPerLatDeg / 111330.0d;
            PixelsPerLonDeg = Math.Cos(LatDispCenter * PI / 180.0d) * PixelsPerLatDeg;
        }

        internal static double MetersPerDegLon(double lat)
        {
            double MetersPerDegLonRet = default;
            MetersPerDegLonRet = Math.Cos(lat * PI / 180.0d) * 111330.0d;
            return MetersPerDegLonRet;
        }

        internal static double Str2Lat(string lat)
        {
            double Str2LatRet = default;
            string a;
            int N, M;
            bool Neg;

            try
            {
                if (DecimalDegrees)
                {
                    Str2LatRet = Convert.ToDouble(lat);
                }
                else
                {
                    lat = lat.Replace("s", "S");
                    lat = lat.Replace("n", "N");
                    Neg = false;
                    N = lat.IndexOf("S");
                    if (N != -1)
                    {
                        Neg = true;
                        lat = lat.Replace("S", "");
                    }

                    N = lat.IndexOf("-");
                    if (N != -1)
                    {
                        Neg = true;
                        lat = lat.Replace("-", "");
                    }

                    N = lat.IndexOf("N");
                    if (N != -1)
                        lat = lat.Replace("N", "");
                    lat = lat.Replace(":", " ");
                    lat = lat.Replace("°", " ");
                    lat = lat.Replace("'", " ");
                    // lat = Replace(lat, "''", " ")
                    lat = lat.Replace("''", "");
                    lat = lat.Replace("   ", " ");
                    lat = lat.Replace("  ", " ");
                    lat = lat.Trim();
                    N = lat.IndexOf(" ");
                    if (N == -1)
                    {
                        Str2LatRet = Convert.ToDouble(lat);
                        if (Neg)
                            Str2LatRet = -1 * Str2LatRet;
                        return Str2LatRet;
                    }

                    a = lat.Substring(0, N);
                    Str2LatRet = Convert.ToDouble(a);
                    M = lat.IndexOf(" ", N + 1);
                    if (M == -1)
                    {
                        a = lat.Substring(N + 1);
                        Str2LatRet = Str2LatRet + Convert.ToDouble(a) / 60d;
                        if (Neg)
                            Str2LatRet = -1 * Str2LatRet;
                        return Str2LatRet;
                    }

                    a = lat.Substring(N + 1, M - N - 1);
                    Str2LatRet = Str2LatRet + Convert.ToDouble(a) / 60d;
                    a = lat.Substring(M + 1);
                    Str2LatRet = Str2LatRet + Convert.ToDouble(a) / 3600d;
                    if (Neg)
                        Str2LatRet = -1 * Str2LatRet;
                }
            }
            catch (Exception)
            {
                Str2LatRet = 100d;
            }
            return Str2LatRet;
        }

        internal static double Str2Lon(string lon)
        {
            double Str2LonRet = default;
            string a;
            int N, M;
            bool Neg;

            try
            {
                if (DecimalDegrees)
                {
                    Str2LonRet = Convert.ToDouble(lon);
                }
                else
                {
                    lon = lon.Replace("e", "E");
                    lon = lon.Replace("w", "W");
                    Neg = false;
                    N = lon.IndexOf("W");
                    if (N != -1)
                    {
                        Neg = true;
                        lon = lon.Replace("W", "");
                    }

                    N = lon.IndexOf("-");
                    if (N != -1)
                    {
                        Neg = true;
                        lon = lon.Replace("-", "");
                    }

                    N = lon.IndexOf("E");
                    if (N != -1)
                        lon = lon.Replace("E", "");
                    lon = lon.Replace(":", " ");
                    lon = lon.Replace("°", " ");
                    lon = lon.Replace("'", " ");
                    // lon = Replace(lon, "''", " ")
                    lon = lon.Replace("''", "'");
                    lon = lon.Replace("   ", " ");
                    lon = lon.Replace("  ", " ");
                    lon = lon.Trim();
                    N = lon.IndexOf(" ");
                    if (N == -1)
                    {
                        Str2LonRet = Convert.ToDouble(lon);
                        if (Neg)
                            Str2LonRet = -1 * Str2LonRet;
                        return Str2LonRet;
                    }

                    a = lon.Substring(0, N);
                    Str2LonRet = Convert.ToDouble(a);
                    M = lon.IndexOf(" ", N + 1);
                    if (M == -1)
                    {
                        a = lon.Substring(N + 1);
                        Str2LonRet = Str2LonRet + Convert.ToDouble(a) / 60d;
                        if (Neg)
                            Str2LonRet = -1 * Str2LonRet;
                        return Str2LonRet;
                    }

                    a = lon.Substring(N + 1, M - N - 1);
                    Str2LonRet = Str2LonRet + Convert.ToDouble(a) / 60d;
                    a = lon.Substring(M + 1);
                    Str2LonRet = Str2LonRet + Convert.ToDouble(a) / 3600d;
                    if (Neg)
                        Str2LonRet = -1 * Str2LonRet;
                }
            }
            catch (Exception)
            {
                Str2LonRet = 200d;
            }
            return Str2LonRet;
        }

        internal static string Lon2Str(double lon)
        {
            string Lon2StrRet = default;
            string a;
            double X;
            int N;
            if (DecimalDegrees)
            {
                Lon2StrRet = lon.ToString("00.0000000");
            }
            else
            {
                if (lon < 0d)
                {
                    a = "W";
                    lon = -1 * lon;
                }
                else
                {
                    a = "E";
                }

                N = (int)lon;
                Lon2StrRet = N.ToString();
                X = (lon - N) * 60d;
                N = (int)X;
                Lon2StrRet = Lon2StrRet + '°' + " " + N.ToString("00");
                X = (X - N) * 60d;
                X = Math.Round(X, 4);
                Lon2StrRet = Lon2StrRet + "' " + X.ToString("00.0000") + "'' " + a;
            }

            return Lon2StrRet;
        }

        internal static string Lat2Str(double lat)
        {
            string Lat2StrRet = default;
            string b;
            double X;
            int N;
            if (DecimalDegrees)
            {
                Lat2StrRet = lat.ToString("00.0000000");
            }
            else
            {
                if (lat < 0d)
                {
                    b = "S";
                    lat = -1 * lat;
                }
                else
                {
                    b = "N";
                }

                N = (int)lat;
                Lat2StrRet = N.ToString();
                X = (lat - N) * 60d;
                N = (int)X;
                Lat2StrRet = Lat2StrRet + '°' + " " + N.ToString("00");
                X = (X - N) * 60d;
                X = Math.Round(X, 4);
                Lat2StrRet = Lat2StrRet + "' " + X.ToString("00.0000") + "'' " + b;
            }

            return Lat2StrRet;
        }

        internal static bool IsSelection(int X, int Y)
        {
            bool IsSelectionRet = default;

            // on entry X Y contain distance from origin of display in pixels

            double XD, YD;
            IsSelectionRet = true;
            if (moduleLINES.IsPointInLine(X, Y))
                return IsSelectionRet;
            if (modulePOLYS.IsPointInPoly(X, Y))
                return IsSelectionRet; // changed from double to integer
            XD = LonDispWest * PixelsPerLonDeg + X;
            YD = LatDispNorth * PixelsPerLatDeg - Y;
            if (moduleOBJECTS.IsObjectSelected(XD, YD))
                return IsSelectionRet;
            if (moduleLINES.IsLineSelected(XD, YD))
                return IsSelectionRet;
            if (modulePOLYS.IsPolySelected(XD, YD))
                return IsSelectionRet;
            if (moduleMAPS.IsMapSelected(XD, YD))
                return IsSelectionRet;
            if (moduleEXCLUDES.IsExcludeSelected(XD, YD))
                return IsSelectionRet;
            IsSelectionRet = false;
            return IsSelectionRet;
        }

        internal static bool IsPtInDisplay(double x, double y)
        {
            bool IsPtInDisplayRet = default;
            IsPtInDisplayRet = false;
            if (x < LonDispWest)
                return IsPtInDisplayRet;
            if (x > LonDispEast)
                return IsPtInDisplayRet;
            if (y > LatDispNorth)
                return IsPtInDisplayRet;
            if (y < LatDispSouth)
                return IsPtInDisplayRet;
            IsPtInDisplayRet = true;
            return IsPtInDisplayRet;
        }

        internal static bool IsSegInDisplay(double X1, double Y1, double X2, double Y2)
        {
            bool IsSegInDisplayRet = default;
            double M, DX, DY, B;
            IsSegInDisplayRet = false;
            if (Y1 > LatDispNorth)
            {
                if (Y2 > LatDispNorth)
                    return IsSegInDisplayRet;
            }

            if (Y1 < LatDispSouth)
            {
                if (Y2 < LatDispSouth)
                    return IsSegInDisplayRet;
            }

            if (X1 < LonDispWest)
            {
                if (X2 < LonDispWest)
                    return IsSegInDisplayRet;
            }

            if (X1 > LonDispEast)
            {
                if (X2 > LonDispEast)
                    return IsSegInDisplayRet;
            }

            DX = X2 - X1;
            DY = Y2 - Y1;
            if (Math.Abs(DX) > Math.Abs(DY))
            {
                M = DY / DX;
                B = Y1 - M * X1;
                Y1 = M * LonDispWest + B;
                Y2 = M * LonDispEast + B;
                if (Y1 > LatDispNorth)
                {
                    if (Y2 > LatDispNorth)
                        return IsSegInDisplayRet;
                }

                if (Y1 < LatDispSouth)
                {
                    if (Y2 < LatDispSouth)
                        return IsSegInDisplayRet;
                }

                IsSegInDisplayRet = true;
                return IsSegInDisplayRet;
            }
            else
            {
                M = DX / DY;
                B = X1 - M * Y1;
                X1 = M * LatDispSouth + B;
                X2 = M * LatDispNorth + B;
                if (X1 < LonDispWest)
                {
                    if (X2 < LonDispWest)
                        return IsSegInDisplayRet;
                }

                if (X1 > LonDispEast)
                {
                    if (X2 > LonDispEast)
                        return IsSegInDisplayRet;
                }

                IsSegInDisplayRet = true;
                return IsSegInDisplayRet;
            }
        }

        internal static void MoveSelected(int X1, int Y1)
        {
            double X, Y;
            X = X1 / PixelsPerLonDeg;
            Y = Y1 / PixelsPerLatDeg;
            if (moduleLINES.LineON)
            {
                moduleLINES.MoveSelectedLines(X, Y);
                return;
            }

            if (modulePOLYS.PolyON)
            {
                modulePOLYS.MoveSelectedPolys(X, Y);
                return;
            }

            if (moduleOBJECTS.ObjectON)
            {
                moduleOBJECTS.MoveSelectedObjects(X, Y);
                return;
            }

            moduleMAPS.MoveSelectedMaps(X, Y);
            moduleEXCLUDES.MoveSelectedExcludes(X, Y);
            moduleLINES.MoveSelectedLines(X, Y);
            modulePOLYS.MoveSelectedPolys(X, Y);
            moduleOBJECTS.MoveSelectedObjects(X, Y);
        }

        internal static void DeleteSelected()
        {
            int N;
            moduleLINES.DeleteSelectedLines();
            moduleLINES.DeleteSelectedPointsInLines();
            modulePOLYS.DeleteSelectedPolys();
            modulePOLYS.DeleteSelectedPointsInPolys();
            for (N = moduleMAPS.NoOfMaps; N >= 1; N -= 1)
            {
                if (moduleMAPS.Maps[N].Selected)
                    moduleMAPS.DeleteMap(N);
            }

            for (N = moduleOBJECTS.NoOfObjects; N >= 1; N -= 1)
            {
                if (moduleOBJECTS.Objects[N].Selected)
                    moduleOBJECTS.DeleteThisObject(N);
            }

            for (N = moduleEXCLUDES.NoOfExcludes; N >= 1; N -= 1)
            {
                if (moduleEXCLUDES.Excludes[N].Selected)
                    moduleEXCLUDES.DeleteExclude(N);
            }

            moduleCLASSES.DeleteSelectedLands();
            moduleCLASSES.DeleteSelectedWaters();
            SomeSelected = false;
            NoOfPointsSelected = 0;
            moduleLINES.NoOfLinesSelected = 0;
            modulePOLYS.NoOfPolysSelected = 0;
            moduleCLASSES.NoOfLandsSelected = 0;
            moduleCLASSES.NoOfWatersSelected = 0;
            moduleOBJECTS.NoOfObjectsSelected = 0;
            moduleMAPS.NoOfMapsSelected = 0;
            Dirty = true;
        }

        internal static void CheckFolders()
        {
            if (string.IsNullOrEmpty(BGLProjectFolder))
            {
                BGLProjectFolder = BGLFolder;
            }

            string A;
            try
            {
                if (Directory.Exists(BGLProjectFolder) == false)
                    Directory.CreateDirectory(BGLProjectFolder);
            }
            catch (Exception)
            {
                A = "Could not create " + Environment.NewLine + BGLProjectFolder;
                MessageBox.Show(A, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BGLProjectFolder = BGLFolder;
            }
        }

        internal static Double_XY LLFromJKCR(int J, int K, int C, int R)
        {
            Double_XY LLFromJKCRRet = default;
            LLFromJKCRRet.X = J * D5Lon + C * D13Lon - 180d;
            LLFromJKCRRet.Y = 90d - K * D5Lat - R * D13Lat;
            return LLFromJKCRRet;
        }

        internal static moduleCLASSES.JKCR JKCRFromLL(double X, double Y, bool NW)
        {
            moduleCLASSES.JKCR JKCRFromLLRet = default;
            int J, K;
            if (NW)
            {
                Y = Y - D14Lat;
                X = X + D14Lon;
            }
            else
            {
                Y = Y + D14Lat;
                X = X - D14Lon;
            }

            X = X + 180d;
            X = X / D5Lon;
            J = (int)X;
            JKCRFromLLRet.J = J;
            Y = 90d - Y;
            Y = Y / D5Lat;
            K = (int)Y;
            JKCRFromLLRet.K = K;
            JKCRFromLLRet.C = (int)Math.Round((X - J) * D5Lon / D13Lon);
            JKCRFromLLRet.R = (int)Math.Round((Y - K) * D5Lat / D13Lat);
            return JKCRFromLLRet;
        }

        internal static int ExecCmd(string str)
        {
            int ExecCmdRet = default;
            string myCommand;
            string myArgs;
            int N = str.IndexOf(" ");
            ExecCmdRet = 0;
            try
            {
                if (N == -1)
                {
                    Process myProcess = new Process();
                    myProcess = Process.Start(str);
                    myProcess.WaitForExit();
                    ExecCmdRet = myProcess.ExitCode;
                    myProcess.Dispose();
                }
                else
                {
                    myCommand = str.Substring(0, N);
                    myArgs = str.Substring(N + 1);
                    Process myProcess = new Process();
                    myProcess = Process.Start(myCommand, myArgs);
                    myProcess.WaitForExit();
                    ExecCmdRet = myProcess.ExitCode;
                    myProcess.Dispose();
                }
            }
            catch (Exception)
            {
                myCommand = "Error in processing the following command:" + Environment.NewLine;
                myCommand = myCommand + str;
                MessageBox.Show(str, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return ExecCmdRet;
        }
    }
}