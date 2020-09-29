using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    static class moduleSURFER
    {
        internal static string BLNSeparator;
        internal static bool BLNExportAltitudes;
        internal static bool BLNLineFromPoly;
        internal static string BLNPolyType;
        internal static string BLNPolyGuid;
        internal static Color BLNPolyColor;
        internal static string BLNLineType;
        internal static string BLNLineGuid;
        internal static Color BLNLineColor;
        internal static bool BLNIsPolyAlt; // true means use altitudes from file
        internal static bool BLNIsLineAlt; // true means use altitudes from file
        internal static double BLNStartWidth;
        internal static double BLNEndWidth;

        internal static void ExportSurfer(ref string FileName)
        {
            int M, N, FN;
            string A;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            FN = FileSystem.FreeFile();
            FileSystem.FileOpen(FN, FileName, OpenMode.Output);
            var loopTo = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                FileSystem.PrintLine(FN, moduleLINES.Lines[N].NoOfPoints.ToString() + BLNSeparator + moduleLINES.Lines[N].Name.Trim());
                var loopTo1 = moduleLINES.Lines[N].NoOfPoints;
                for (M = 1; M <= loopTo1; M++)
                {
                    A = moduleLINES.Lines[N].GLPoints[M].lon.ToString().Trim() + BLNSeparator;
                    A = A + moduleLINES.Lines[N].GLPoints[M].lat.ToString().Trim();
                    if (BLNExportAltitudes)
                        A = A + BLNSeparator + moduleLINES.Lines[N].GLPoints[M].alt.ToString().Trim();
                    FileSystem.PrintLine(FN, A);
                }
            }

            var loopTo2 = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo2; N++)
            {
                FileSystem.PrintLine(FN, (modulePOLYS.Polys[N].NoOfPoints + 1).ToString() + BLNSeparator + modulePOLYS.Polys[N].Name.Trim());
                var loopTo3 = modulePOLYS.Polys[N].NoOfPoints;
                for (M = 1; M <= loopTo3; M++)
                {
                    A = modulePOLYS.Polys[N].GPoints[M].lon.ToString().Trim() + BLNSeparator;
                    A = A + modulePOLYS.Polys[N].GPoints[M].lat.ToString().Trim();
                    if (BLNExportAltitudes)
                        A = A + BLNSeparator + modulePOLYS.Polys[N].GPoints[M].alt.ToString().Trim();
                    FileSystem.PrintLine(FN, A);
                }

                A = modulePOLYS.Polys[N].GPoints[1].lon.ToString().Trim() + BLNSeparator;
                A = A + modulePOLYS.Polys[N].GPoints[1].lat.ToString().Trim();
                if (BLNExportAltitudes)
                    A = A + BLNSeparator + modulePOLYS.Polys[N].GPoints[1].alt.ToString().Trim();
                FileSystem.PrintLine(FN, A);
            }

            FileSystem.FileClose(FN);
            My.MyProject.Forms.FrmStart.SetMouseIcon();
        }

        internal static void AppendSurfer(ref string FileName)
        {
            int K1, N, M, K2;
            int NoL;  // to count Lines (November 2017)
            int NoP;  // to count Polys (November 2017)
            string A, B;
            moduleLINES.GLine myLine;
            int Marker;
            bool PolyFlag, Has3Par = default;
            long LenOfFile;
            double d, X0;
            double EL, SL, NL, WL, X;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            try
            {
                FileSystem.FileOpen(2, FileName, OpenMode.Input);
                LenOfFile = FileSystem.LOF(2);
                Marker = 0;
                myLine.Name = "";
                NoP = modulePOLYS.NoOfPolys;                   // added November 2017 
                Array.Resize(ref modulePOLYS.Polys, NoP + 100 + 1);   // create space for more 100 polys
                NoL = moduleLINES.NoOfLines;                   // added November 2017 
                Array.Resize(ref moduleLINES.Lines, NoL + 100 + 1);   // create space for more 100 lines
                while (Marker < LenOfFile)
                {
                    A = FileSystem.LineInput(2);
                    Marker = Marker + A.Length + 2;
                    K1 = A.IndexOf(BLNSeparator);
                    if (K1 != -1)
                    {
                        N = Convert.ToInt32(A.Substring(0, K1));
                        B = (A.Length >= K1 + 3) ? A.Substring(K1 + 1, 2) : "";
                        if (B == ("0" + BLNSeparator ?? "") || B == ("1" + BLNSeparator ?? ""))
                        {
                            myLine.Name = A.Substring(K1 + 3);
                        }
                        else
                        {
                            myLine.Name = A.Substring(K1 + 1);
                        }
                    }
                    else
                    {
                        N = Convert.ToInt32(A);
                    }

                    myLine.GLPoints = new modulePOINTS.GLPoint[N + 1];
                    var loopTo = N;
                    for (M = 1; M <= loopTo; M++)
                    {
                        A = FileSystem.LineInput(2);
                        Marker = Marker + A.Length + 2;
                        K1 = A.IndexOf(BLNSeparator);
                        myLine.GLPoints[M].lon = Convert.ToDouble(A.Substring(0, K1));

                        // commented on November 2017
                        // K2 = InStr(K1 + 1, A, BLNSeparator)
                        // If K2 = 0 Then
                        // Has3Par = False
                        // myLine.GLPoints(M).lat = Val(Mid(A, K1 + 1))
                        // Else
                        // Has3Par = True
                        // myLine.GLPoints(M).lat = Val(Mid(A, K1 + 1, K2 - K1 - 1))
                        // myLine.GLPoints(M).alt = Val(Mid(A, K2 + 1))
                        // End If

                        // replaced with the following
                        if (M == 1)
                        {
                            K2 = A.IndexOf(BLNSeparator, K1 + 1);
                            if (K2 == -1)
                            {
                                Has3Par = false;
                                myLine.GLPoints[M].lat = Convert.ToDouble(A.Substring(K1 + 1));
                            }
                            else
                            {
                                Has3Par = true;
                                myLine.GLPoints[M].lat = Convert.ToDouble(A.Substring(K1 + 1, K2 - K1 - 1));
                                myLine.GLPoints[M].alt = Convert.ToDouble(A.Substring(K2 + 1));
                            }
                        }
                        else if (Has3Par)
                        {
                            K2 = A.IndexOf(BLNSeparator, K1 + 1);
                            myLine.GLPoints[M].lat = Convert.ToDouble(A.Substring(K1 + 1, K2 - K1 - 1));
                            myLine.GLPoints[M].alt = Convert.ToDouble(A.Substring(K2 + 1));
                        }
                        else
                        {
                            myLine.GLPoints[M].lat = Convert.ToDouble(A.Substring(K1 + 1));
                        }
                        // end of replacement
                    }

                    PolyFlag = false;
                    if (myLine.GLPoints[1].lat == myLine.GLPoints[N].lat)
                    {
                        if (myLine.GLPoints[1].lon == myLine.GLPoints[N].lon)
                        {
                            PolyFlag = true;
                        }
                    }

                    if (PolyFlag)
                    {
                        NoP = NoP + 1;
                        // ReDim Preserve Polys(NoOfPolys)
                        if (string.IsNullOrEmpty(myLine.Name))
                        {
                            modulePOLYS.Polys[NoP].Name = (N - 1).ToString() + "_Pts_BLN_Imported_Polygon";
                        }
                        else
                        {
                            modulePOLYS.Polys[NoP].Name = myLine.Name;
                        }

                        modulePOLYS.Polys[NoP].Color = BLNPolyColor;
                        modulePOLYS.Polys[NoP].Type = BLNPolyType;
                        modulePOLYS.Polys[NoP].Guid = BLNPolyGuid;
                        modulePOLYS.Polys[NoP].NoOfPoints = N - 1;
                        modulePOLYS.Polys[NoP].GPoints = new modulePOINTS.GPoint[N];
                        NL = -90;
                        SL = 90d;
                        EL = -180;
                        WL = 180d;
                        var loopTo1 = N - 1;
                        for (M = 1; M <= loopTo1; M++)
                        {
                            // X = myLine.GLPoints(M).lat
                            // Polys(NoP).GPoints(M).lat = X
                            // If X < SL Then SL = X
                            // If X > NL Then NL = X
                            // replace with the following in November 2017
                            modulePOLYS.Polys[NoP].GPoints[M].lat = myLine.GLPoints[M].lat;
                            if (myLine.GLPoints[M].lat < SL)
                                SL = myLine.GLPoints[M].lat;
                            if (myLine.GLPoints[M].lat > NL)
                                NL = myLine.GLPoints[M].lat;
                            // X = myLine.GLPoints(M).lon
                            // Polys(NoP).GPoints(M).lon = X
                            // If X > EL Then EL = X
                            // If X < WL Then WL = X
                            // replace with the following in November 2017
                            modulePOLYS.Polys[NoP].GPoints[M].lon = myLine.GLPoints[M].lon;
                            if (myLine.GLPoints[M].lon > EL)
                                EL = myLine.GLPoints[M].lon;
                            if (myLine.GLPoints[M].lon < WL)
                                WL = myLine.GLPoints[M].lon;
                            if (Has3Par)
                            {
                                if (BLNIsPolyAlt)
                                {
                                    modulePOLYS.Polys[NoP].GPoints[M].alt = myLine.GLPoints[M].alt;
                                }
                                else
                                {
                                    modulePOLYS.Polys[NoP].GPoints[M].alt = modulePOLYS.DefaultPolyAltitude;
                                }
                            }
                            else
                            {
                                modulePOLYS.Polys[NoP].GPoints[M].alt = modulePOLYS.DefaultPolyAltitude;
                            }
                        }

                        modulePOLYS.Polys[NoP].ELON = EL;
                        modulePOLYS.Polys[NoP].WLON = WL;
                        modulePOLYS.Polys[NoP].NLAT = NL;
                        modulePOLYS.Polys[NoP].SLAT = SL;
                        if (NoP == modulePOLYS.NoOfPolys + 100)
                        {
                            modulePOLYS.NoOfPolys = NoP;
                            Array.Resize(ref modulePOLYS.Polys, NoP + 100 + 1);
                        }

                        if (BLNLineFromPoly)
                        {
                            NoL = NoL + 1;
                            // ReDim Preserve Lines(NoOfLines)
                            if (string.IsNullOrEmpty(myLine.Name))
                            {
                                moduleLINES.Lines[NoL].Name = N.ToString() + "_Pts_BLN_Imported_Line";
                            }
                            else
                            {
                                moduleLINES.Lines[NoL].Name = myLine.Name;
                            }

                            moduleLINES.Lines[NoL].Color = BLNLineColor;
                            moduleLINES.Lines[NoL].Type = BLNLineType;
                            moduleLINES.Lines[NoL].Guid = BLNLineGuid;
                            moduleLINES.Lines[NoL].NoOfPoints = N;
                            moduleLINES.Lines[NoL].GLPoints = new modulePOINTS.GLPoint[N + 1];
                            d = (BLNEndWidth - BLNStartWidth) / (N - 1);
                            X0 = BLNStartWidth;
                            var loopTo2 = N;
                            for (M = 1; M <= loopTo2; M++)
                            {
                                moduleLINES.Lines[NoL].GLPoints[M].lat = myLine.GLPoints[M].lat;
                                moduleLINES.Lines[NoL].GLPoints[M].lon = myLine.GLPoints[M].lon;
                                moduleLINES.Lines[NoL].GLPoints[M].wid = X0;
                                X0 = X0 + d;
                                if (Has3Par)
                                {
                                    if (BLNIsLineAlt)
                                    {
                                        moduleLINES.Lines[NoL].GLPoints[M].alt = myLine.GLPoints[M].alt;
                                    }
                                    else
                                    {
                                        moduleLINES.Lines[NoL].GLPoints[M].alt = moduleLINES.DefaultLineAltitude;
                                    }
                                }
                                else
                                {
                                    moduleLINES.Lines[NoL].GLPoints[M].alt = moduleLINES.DefaultLineAltitude;
                                }
                            }

                            moduleLINES.Lines[NoL].ELON = EL;
                            moduleLINES.Lines[NoL].WLON = WL;
                            moduleLINES.Lines[NoL].NLAT = NL;
                            moduleLINES.Lines[NoL].SLAT = SL;
                            if (NoL == moduleLINES.NoOfLines + 100)
                            {
                                moduleLINES.NoOfLines = NoL;
                                Array.Resize(ref moduleLINES.Lines, NoL + 100 + 1);
                            }
                        }
                    }
                    else
                    {
                        NoL = NoL + 1;
                        // ReDim Preserve Lines(NoOfLines)
                        if (string.IsNullOrEmpty(myLine.Name))
                        {
                            moduleLINES.Lines[NoL].Name = N.ToString() + "_Pts_BLN_Imported_Line";
                        }
                        else
                        {
                            moduleLINES.Lines[NoL].Name = myLine.Name;
                        }

                        moduleLINES.Lines[NoL].Color = BLNLineColor;
                        moduleLINES.Lines[NoL].Type = BLNLineType;
                        moduleLINES.Lines[NoL].Guid = BLNLineGuid;
                        moduleLINES.Lines[NoL].NoOfPoints = N;
                        moduleLINES.Lines[NoL].GLPoints = new modulePOINTS.GLPoint[N + 1];
                        NL = -90;
                        SL = 90d;
                        EL = -180;
                        WL = 180d;
                        d = (BLNEndWidth - BLNStartWidth) / (N - 1);
                        X0 = BLNStartWidth;
                        var loopTo3 = N;
                        for (M = 1; M <= loopTo3; M++)
                        {
                            // X = myLine.GLPoints(M).lat
                            // Lines(NoOfLines).GLPoints(M).lat = X
                            // If X < SL Then SL = X
                            // If X > NL Then NL = X
                            // X = myLine.GLPoints(M).lon
                            // Lines(NoOfLines).GLPoints(M).lon = X
                            // If X > EL Then EL = X
                            // If X < WL Then WL = X
                            // replaced by the following in November 2017
                            X = myLine.GLPoints[M].lat;
                            moduleLINES.Lines[NoL].GLPoints[M].lat = myLine.GLPoints[M].lat;
                            if (myLine.GLPoints[M].lat < SL)
                                SL = myLine.GLPoints[M].lat;
                            if (myLine.GLPoints[M].lat > NL)
                                NL = myLine.GLPoints[M].lat;
                            moduleLINES.Lines[NoL].GLPoints[M].lon = myLine.GLPoints[M].lon;
                            if (myLine.GLPoints[M].lon > EL)
                                EL = myLine.GLPoints[M].lon;
                            if (myLine.GLPoints[M].lon < WL)
                                WL = myLine.GLPoints[M].lon;
                            moduleLINES.Lines[NoL].GLPoints[M].wid = X0;
                            X0 = X0 + d;
                            if (Has3Par)
                            {
                                if (BLNIsLineAlt)
                                {
                                    moduleLINES.Lines[NoL].GLPoints[M].alt = myLine.GLPoints[M].alt;
                                }
                                else
                                {
                                    moduleLINES.Lines[NoL].GLPoints[M].alt = moduleLINES.DefaultLineAltitude;
                                }
                            }
                            else
                            {
                                moduleLINES.Lines[NoL].GLPoints[M].alt = moduleLINES.DefaultLineAltitude;
                            }
                        }

                        moduleLINES.Lines[NoL].ELON = EL;
                        moduleLINES.Lines[NoL].WLON = WL;
                        moduleLINES.Lines[NoL].NLAT = NL;
                        moduleLINES.Lines[NoL].SLAT = SL;
                        if (NoL == moduleLINES.NoOfLines + 100)
                        {
                            moduleLINES.NoOfLines = NoL;
                            Array.Resize(ref moduleLINES.Lines, NoL + 100 + 1);
                        }
                    }
                }

                // NoL and NoP are the final number of lines and polys
                moduleLINES.NoOfLines = NoL;
                modulePOLYS.NoOfPolys = NoP;
                Array.Resize(ref moduleLINES.Lines, NoL + 1);
                Array.Resize(ref modulePOLYS.Polys, NoP + 1);
                FileSystem.FileClose(2);
                My.MyProject.Forms.FrmStart.SetMouseIcon();
                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose(2);
                A = "There has been a fatal error! Please" + Environment.NewLine;
                A = A + "verify the BLN separator in INI file!";
                MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.SetMouseIcon();
            }
        }
    }
}