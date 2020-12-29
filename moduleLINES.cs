using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SBuilderXX
{
    // Imports VB = Microsoft.VisualBasic
    static class moduleLINES
    {
        [Serializable()]
        internal struct GLine
        {
            public string Name;
            public string Type;
            public string Guid;
            public Color Color;
            public bool Selected;
            public int NoOfPoints;
            public modulePOINTS.GLPoint[] GLPoints;
            public double NLAT; // not saved
            public double SLAT; // not saved
            public double WLON; // not saved
            public double ELON; // not saved
            public bool OnScreen;
        }

        internal struct LineType
        {
            public string Name;
            public string Type;
            public Color Color;
            public string Guid;
            public string Texture;
            public int TerrainIndex;
        }

        internal static LineType[] LineTypes;
        internal static int NoOfLineTypes;

        internal struct ExtrusionType
        {
            public string Name;
            public Color Color;
            public double Width;
            public string Profile;
            public string Material;
            public string Pylon;
        }

        internal static int NoOfExtrusionTypes;
        internal static ExtrusionType[] ExtrusionTypes;
        internal static GLine[] Lines;
        internal static int NoOfLines = 0;
        internal static int NoOfLinesSelected = 0;
        internal static GLine NewLine;
        internal static double DefaultLineAltitude;
        internal static double DefaultLineWidth;
        internal static string ExtraExtrusionAltitude;

        // these are read from Lines.TXT
        internal static string DefaultLineNoneGuid;
        internal static string DefaultLineFS9Guid;
        private static double H_NLat; // header borders
        private static double H_SLat; // header borders
        private static double H_WLon; // header borders
        private static double H_ELon; // header borders
        internal static bool BreakLineON;
        internal static bool DecreaseWithdON;
        internal static bool IncreaseWithdON;
        internal static bool LineON;
        internal static bool LineVIEW;
        internal static bool LineTURN;
        private static int LineToTurn;
        private static int PointToTurn;
        internal static int CheckLine;
        internal static int CheckLinePt;
        internal static bool AutoLinePolyJoin;
        internal static bool DisplayJoin; // If true 3 pixels if false D21
        internal static bool DirJoin; // if true ignore direction
        internal static bool NameJoin; // if true ignore names in joining

        // Friend JoinCellLines As Boolean ' if true join lines that cross cells on VTP appending

        internal static Color SelectedLineColor;
        internal static Color DefaultLineColor;
        internal static int LinePenWidth;

        // Friend DefaultWidth As Double

        internal static int PtLineCounter;
        internal static double AuxLatLine;
        internal static double AuxLonLine;
        private static Point[] PTS = new Point[4];    // used to draw the polygons that define a line

        internal static void LineInsertMode(short Button, short Shift, int X, int Y)
        {

            // enters here when the mouse goes down in line mode

            if (Button == 1)
            {
                if (moduleMAIN.IsCenterDisplay(X, Y))
                {
                    X = X - moduleMAIN.DisplayCenterX;
                    Y = Y - moduleMAIN.DisplayCenterY;
                    moduleMAIN.SetDispCenter(X, Y);
                    X = moduleMAIN.DisplayCenterX;
                    Y = moduleMAIN.DisplayCenterY;
                    moduleMAIN.RebuildDisplay();
                }

                if (PtLineCounter > 0)   // start line creation begun earlier
                {
                    BuildLine(X, ref Y);
                }
                else     // the first click
                {
                    My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                    My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                    // SHIFT IS DOWN!
                    if (Shift == 1) // was a point selected?
                    {
                        // SomeSelected = SomeSelected Or IsPointInLine(X, Y)
                        if (IsPointInLine(X, Y))  // was a point selected?
                        {
                            moduleMAIN.SomeSelected = true;
                            moduleMAIN.RebuildDisplay();    // start the movement of the point and the rest
                            moduleMAIN.SetDelay(200);
                            moduleMAIN.MoveON = true;
                            moduleMAIN.FirstMOVE = true;
                            moduleMAIN.AuxXInt = X;
                            moduleMAIN.AuxYInt = Y;
                            return;
                        }   // is a line selected?
                            // SomeSelected = SomeSelected Or IsLineSelected(LonDispWest * PixelsPerLonDeg + X, LatDispNorth * PixelsPerLatDeg - Y)
                        if (IsLineSelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y))
                        {
                            moduleMAIN.SomeSelected = true;
                            moduleMAIN.RebuildDisplay();
                            moduleMAIN.SetDelay(200);
                            My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = true;
                            My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = true;
                            moduleMAIN.MoveON = true;
                            moduleMAIN.FirstMOVE = true;
                            moduleMAIN.AuxXInt = X;
                            moduleMAIN.AuxYInt = Y;
                        }

                        return;
                    }
                    // SHIFT IS NOT DOWN!
                    moduleMAIN.UnSelectAll();
                    moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsPointInLine(X, Y);
                    if (moduleMAIN.SomeSelected)  // was a point selected?
                    {
                        if (moduleMAIN.DeleteON)
                        {
                            DeleteSelectedPointsInLines();
                            moduleMAIN.RebuildDisplay();
                            return;
                        }

                        if (BreakLineON)
                        {
                            BreakLines();
                            moduleMAIN.RebuildDisplay();
                            return;
                        }

                        if (DecreaseWithdON)
                        {
                            DecreaseWidth();
                            moduleMAIN.RebuildDisplay();
                            return;
                        }

                        if (IncreaseWithdON)
                        {
                            IncreaseWidth();
                            moduleMAIN.RebuildDisplay();
                            return;
                        }

                        moduleMAIN.RebuildDisplay();    // start the movement of the point and the rest
                        moduleMAIN.SetDelay(200);
                        moduleMAIN.MoveON = true;
                        moduleMAIN.FirstMOVE = true;
                        moduleMAIN.AuxXInt = X;
                        moduleMAIN.AuxYInt = Y;
                        return;
                    }
                    else  // is InsertON true and we clicked on a segment of a line?
                    {
                        moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsInsertPointInLine(X, Y);
                        if (moduleMAIN.SomeSelected)
                        {
                            moduleMAIN.RebuildDisplay();
                            moduleMAIN.SetDelay(200);
                            moduleMAIN.MoveON = true;
                            moduleMAIN.FirstMOVE = true;
                            moduleMAIN.AuxXInt = X;
                            moduleMAIN.AuxYInt = Y;
                            return; // new
                        }
                        else if (moduleMAIN.InsertON)    // InsertON is true and we did not click a segment, so do nothing
                        {
                            return;
                        }
                        else                    // did we selected a line?
                        {
                            moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsLineSelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y);
                            if (moduleMAIN.SomeSelected)
                            {
                                moduleMAIN.RebuildDisplay();
                                moduleMAIN.SetDelay(200);
                                My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = true;
                                My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = true;
                                moduleMAIN.MoveON = true;
                                moduleMAIN.FirstMOVE = true;
                                moduleMAIN.AuxXInt = X;
                                moduleMAIN.AuxYInt = Y;
                                return; // new
                            }
                            else if (IsLineObjectTurn(X, Y))   // is turnobject
                            {
                                // RebuildDisplay()
                                moduleMAIN.SetDelay(200);
                                LineTURN = true;
                                My.MyProject.Forms.FrmStart.SetMouseIcon();
                                return;
                            }
                            else   // no!!! so this is the start of the creation of a new line
                            {
                                if (moduleEDIT.BackUpON)
                                    moduleEDIT.BackUp();
                                moduleMAIN.RebuildDisplay();
                                BuildLine(X, ref Y);
                            }
                        }
                    }
                }
            }

            if (Button == 2)
            {
                EndLine(X, Y);
                moduleMAIN.RebuildDisplay();
            }
        }

        internal static void BuildLine(int X, ref int Y)
        {

            // this looks to the number of clicks (in PtLineCounter)
            // if PtLineCounter = 0 it is the first click
            // if PtLineCounter = 2 it is the second click and
            // a new line is created
            // if PtLineCounter > 2 a new point is added to the new line

            double Lat, Lon;
            Lat = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            Lon = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            if (PtLineCounter == 0)
            {
                bool argFlag = false;
                SelectAllLines(ref argFlag);
                NoOfLinesSelected = 0;
                AuxLatLine = Lat;
                AuxLonLine = Lon;
                PtLineCounter = 2;
                return;
            }

            if (PtLineCounter == 2)
            {
                PtLineCounter = 3;
                NewLine.GLPoints = new modulePOINTS.GLPoint[3];
                NewLine.NoOfPoints = 2;
                NewLine.Color = DefaultLineColor;
                NewLine.Selected = false;
                NewLine.GLPoints[1].lat = AuxLatLine;
                NewLine.GLPoints[1].lon = AuxLonLine;
                NewLine.GLPoints[1].alt = DefaultLineAltitude;
                NewLine.GLPoints[1].wid = DefaultLineWidth;
                NewLine.GLPoints[1].Selected = false;
                AuxLatLine = Lat;
                AuxLonLine = Lon;
                NewLine.GLPoints[2].lat = Lat;
                NewLine.GLPoints[2].lon = Lon;
                NewLine.GLPoints[2].alt = DefaultLineAltitude;
                NewLine.GLPoints[2].wid = DefaultLineWidth;
                NewLine.GLPoints[2].Selected = false;
                return;
            }

            // PtLineCounter is > 2

            AuxLatLine = Lat;
            AuxLonLine = Lon;
            Array.Resize(ref NewLine.GLPoints, PtLineCounter + 1);
            NewLine.GLPoints[PtLineCounter].lat = Lat;
            NewLine.GLPoints[PtLineCounter].lon = Lon;
            NewLine.GLPoints[PtLineCounter].alt = DefaultLineAltitude;
            NewLine.GLPoints[PtLineCounter].wid = DefaultLineWidth;
            NewLine.GLPoints[PtLineCounter].Selected = false;
            NewLine.NoOfPoints = PtLineCounter;
            PtLineCounter = PtLineCounter + 1;
        }

        internal static void EndLine(int X, int Y)
        {
            if (PtLineCounter == 0)
            {
                modulePOPUP.ProcessPopUp(X, Y);
                return;
            }

            if (PtLineCounter == 2)
            {
                PtLineCounter = 0;
                return;
            }

            // ok, create the line!
            PtLineCounter = 0;
            NoOfLines = NoOfLines + 1;
            Array.Resize(ref Lines, NoOfLines + 1);
            Lines[NoOfLines] = NewLine;
            moduleMAIN.Dirty = true;
            if (NoOfLines > 1 & AutoLinePolyJoin)
            {
                if (TryThisLineJoin(NoOfLines))
                {
                    SystemSounds.Beep.Play();
                    AddLatLonToLine(NoOfLines);
                    return;
                }
            }

            Lines[NoOfLines].Name = Lines[NoOfLines].NoOfPoints.ToString() + "_Pts_Line_of_Type_None";
            Lines[NoOfLines].Guid = DefaultLineNoneGuid;
            Lines[NoOfLines].Type = "NONE";
            AddLatLonToLine(NoOfLines);
            modulePOPUP.HidePopUPMenu();
        }

        private static bool IsLineObjectTurn(int X, int Y)
        {
            bool IsLineObjectTurnRet = default;

            // on entry X Y contain distance from NW corner display in pixels

            int N, K;
            IsLineObjectTurnRet = false;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Type.Length >= 3 && Lines[N].Type.Substring(0, 3) == "OBJ")
                {
                    SetLenWidFromObject(N);
                    int loopTo1 = Lines[N].NoOfPoints;
                    for (K = 1; K <= loopTo1; K++)
                    {
                        SetHeadingsFromObject(N, K);
                        if (HDX > X + 5)
                            continue;
                        if (HDX < X - 5)
                            continue;
                        if (HDY < Y - 5)
                            continue;
                        if (HDY > Y + 5)
                            continue;
                        LineToTurn = N;
                        PointToTurn = K;
                        Lines[N].GLPoints[K].Selected = true;
                        IsLineObjectTurnRet = true;
                        return IsLineObjectTurnRet;
                    }
                }
            }

            return IsLineObjectTurnRet;
        }

        internal static void TurnLine(int X, int Y)
        {
            SetLenWidFromObject(LineToTurn);
            SetHeadingsFromObject(LineToTurn, PointToTurn);
            float Y0, X0, Head;
            // X0 = (Objects(ObjectID).lon - LonDispWest) * PixelsPerLonDeg
            // Y0 = (LatDispNorth - Objects(ObjectID).lat) * PixelsPerLatDeg

            X0 = X - P0X;
            Y0 = P0Y - Y;
            Head = 0f;
            if (Y0 > 0f)
            {
                Head = (float)(Math.Atan(X0 / Y0) * 180d / moduleMAIN.PI);
            }
            else if (Y0 < 0f)
            {
                Head = (float)(180d + Math.Atan(X0 / Y0) * 180d / moduleMAIN.PI);
            }
            else if (X0 > 0f)
            {
                Head = 90f;
            }
            else
            {
                Head = 270f;
            }

            if (Head < 0f)
                Head = Head + 360f;
            Lines[LineToTurn].GLPoints[PointToTurn].wid = Head;
            moduleMAIN.RebuildDisplay();
        }

        internal static bool TryThisLineJoin(int LJ)
        {
            bool TryThisLineJoinRet = default;
            int K, N, NP;
            double X1J, Y1J;
            double XNJ, YNJ;
            double X1, Y1;
            double XN, YN;
            double DX, DY;
            double DeltaLat, DeltaLon;
            if (DisplayJoin)
            {
                DeltaLon = 3d / moduleMAIN.PixelsPerLonDeg;
                DeltaLat = 3d / moduleMAIN.PixelsPerLatDeg;
            }
            else
            {
                DeltaLon = moduleMAIN.D255Lon;
                DeltaLat = moduleMAIN.D255Lat;
            }

            TryThisLineJoinRet = false;
            K = Lines[LJ].NoOfPoints;
            X1J = Lines[LJ].GLPoints[1].lon;
            Y1J = Lines[LJ].GLPoints[1].lat;
            XNJ = Lines[LJ].GLPoints[K].lon;
            YNJ = Lines[LJ].GLPoints[K].lat;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (N == LJ)
                    goto NextN;
                if (NameJoin)
                {
                    if ((Lines[N].Name ?? "") != (Lines[LJ].Name ?? ""))
                        goto NextN;
                }

                if ((Lines[N].Type ?? "") != (Lines[LJ].Type ?? ""))
                    goto NextN;
                NP = Lines[N].NoOfPoints;
                X1 = Lines[N].GLPoints[1].lon;
                Y1 = Lines[N].GLPoints[1].lat;
                XN = Lines[N].GLPoints[NP].lon;
                YN = Lines[N].GLPoints[NP].lat;
                //Nextx0:
                //    ;
                DX = Math.Abs(X1 - XNJ);
                if (DX > DeltaLon)
                    goto Next1;
                DY = Math.Abs(Y1 - YNJ);
                if (DY > DeltaLat)
                    goto Next1;
                JoinLines(LJ, N, 1, 1);
                TryThisLineJoinRet = true;
                return TryThisLineJoinRet;
            Next1:
                ;
                DX = Math.Abs(XN - X1J);
                if (DX > DeltaLon)
                    goto Next2;
                DY = Math.Abs(YN - Y1J);
                if (DY > DeltaLat)
                    goto Next2;
                JoinLines(N, LJ, 1, 1);
                TryThisLineJoinRet = true;
                return TryThisLineJoinRet;
            Next2:
                ;
                if (DirJoin)
                    goto NextN;
                DX = Math.Abs(XN - XNJ);
                if (DX > DeltaLon)
                    goto Next3;
                DY = Math.Abs(YN - YNJ);
                if (DY > DeltaLat)
                    goto Next3;
                JoinLines(LJ, N, 1, -1);
                TryThisLineJoinRet = true;
                return TryThisLineJoinRet;
            Next3:
                ;
                DX = Math.Abs(X1 - X1J);
                if (DX > DeltaLon)
                    goto NextN;
                DY = Math.Abs(Y1 - Y1J);
                if (DY > DeltaLat)
                    goto NextN;
                JoinLines(LJ, N, -1, 1);
                TryThisLineJoinRet = true;
                return TryThisLineJoinRet;
            NextN:
                ;
            }

            return TryThisLineJoinRet;
        }

        internal static void JoinLines(int N1, int N2, int F1, int F2)
        {
            int P2, P1, N;
            P1 = Lines[N1].NoOfPoints;
            P2 = Lines[N2].NoOfPoints;
            if (F1 == -1)
                ReverseLine(N1);
            if (F2 == -1)
                ReverseLine(N2);
            Lines[N1].NoOfPoints = P1 + P2 - 1;
            Array.Resize(ref Lines[N1].GLPoints, Lines[N1].NoOfPoints + 1);
            int loopTo = P2;
            for (N = 2; N <= loopTo; N++)
            {
                Lines[N1].GLPoints[N + P1 - 1].wid = Lines[N2].GLPoints[N].wid;
                Lines[N1].GLPoints[N + P1 - 1].alt = Lines[N2].GLPoints[N].alt;
                Lines[N1].GLPoints[N + P1 - 1].lat = Lines[N2].GLPoints[N].lat;
                Lines[N1].GLPoints[N + P1 - 1].lon = Lines[N2].GLPoints[N].lon;
            }

            Lines[N1].Selected = true;
            AddLatLonToLine(N1);
            DeleteLine(N2);
        }

        internal static void TryAllLineJoin()
        {
            int N, K;
            bool[] Done = new bool[NoOfLines + 1];
        jump_here:
            ;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Done[N])
                    continue;
                if (N > NoOfLines - 1)
                    return;
                if (Lines[N].Selected)
                {
                    int loopTo1 = NoOfLines;
                    for (K = N + 1; K <= loopTo1; K++)
                    {
                        if (K > NoOfLines)
                            break;
                        if (Lines[K].Selected)
                        {
                            if (Try2LineJoin(N, K))
                                goto jump_here;
                        }
                    }
                }

                Done[N] = true;
            }
        }

        private static bool Try2LineJoin(int N1, int N2)
        {
            bool Try2LineJoinRet = default;

            // N1 and N2 are the lines to join!

            int N;
            double X1, XN, YN, Y1;
            double D1, X, D, DN;
            double DNN, D11;
            Try2LineJoinRet = false;
            if (NameJoin)
            {
                if ((Lines[N1].Name ?? "") != (Lines[N2].Name ?? ""))
                    return Try2LineJoinRet;
            }

            N = Lines[N1].NoOfPoints;
            XN = Lines[N1].GLPoints[N].lon;
            YN = Lines[N1].GLPoints[N].lat;
            X1 = Lines[N1].GLPoints[N - 1].lon;
            Y1 = Lines[N1].GLPoints[N - 1].lat;
            DN = XN - X1;
            DN = DN * DN;
            X = YN - Y1;
            X = X * X;
            DN = DN + X;
            DN = Math.Sqrt(DN);
            XN = Lines[N2].GLPoints[1].lon;
            YN = Lines[N2].GLPoints[1].lat;
            X1 = Lines[N2].GLPoints[2].lon;
            Y1 = Lines[N2].GLPoints[2].lat;
            D1 = XN - X1;
            D1 = D1 * D1;
            X = YN - Y1;
            X = X * X;
            D1 = D1 + X;
            D1 = Math.Sqrt(D1);
            XN = Lines[N1].GLPoints[N].lon;
            YN = Lines[N1].GLPoints[N].lat;
            X1 = Lines[N2].GLPoints[1].lon;
            Y1 = Lines[N2].GLPoints[1].lat;
            D = XN - X1;
            D = D * D;
            X = YN - Y1;
            X = X * X;
            D = D + X;
            D = Math.Sqrt(D);
            if (D < D1 | D < DN)
            {
                JoinLines(N1, N2, 1, 1);
                Try2LineJoinRet = true;
                SystemSounds.Beep.Play();
                return Try2LineJoinRet;
            }

            N = Lines[N2].NoOfPoints;
            XN = Lines[N2].GLPoints[N].lon;
            YN = Lines[N2].GLPoints[N].lat;
            X1 = Lines[N2].GLPoints[N - 1].lon;
            Y1 = Lines[N2].GLPoints[N - 1].lat;
            DN = XN - X1;
            DN = DN * DN;
            X = YN - Y1;
            X = X * X;
            DN = DN + X;
            DN = Math.Sqrt(DN);
            XN = Lines[N1].GLPoints[1].lon;
            YN = Lines[N1].GLPoints[1].lat;
            X1 = Lines[N1].GLPoints[2].lon;
            Y1 = Lines[N1].GLPoints[2].lat;
            D1 = XN - X1;
            D1 = D1 * D1;
            X = YN - Y1;
            X = X * X;
            D1 = D1 + X;
            D1 = Math.Sqrt(D1);
            XN = Lines[N2].GLPoints[N].lon;
            YN = Lines[N2].GLPoints[N].lat;
            X1 = Lines[N1].GLPoints[1].lon;
            Y1 = Lines[N1].GLPoints[1].lat;
            D = XN - X1;
            D = D * D;
            X = YN - Y1;
            X = X * X;
            D = D + X;
            D = Math.Sqrt(D);
            if (D < D1 | D < DN)
            {
                JoinLines(N2, N1, 1, 1);
                Try2LineJoinRet = true;
                SystemSounds.Beep.Play();
                return Try2LineJoinRet;
            }

            if (DirJoin)
                return Try2LineJoinRet;
            int NP1 = Lines[N1].NoOfPoints;
            int NP2 = Lines[N2].NoOfPoints;

            // NP1 & NP2
            XN = Lines[N1].GLPoints[NP1].lon;
            YN = Lines[N1].GLPoints[NP1].lat;
            X1 = Lines[N2].GLPoints[NP2].lon;
            Y1 = Lines[N2].GLPoints[NP2].lat;
            D = XN - X1;
            D = D * D;
            X = YN - Y1;
            X = X * X;
            D = D + X;
            DNN = Math.Sqrt(D);

            // 1 & 1
            XN = Lines[N1].GLPoints[1].lon;
            YN = Lines[N1].GLPoints[1].lat;
            X1 = Lines[N2].GLPoints[1].lon;
            Y1 = Lines[N2].GLPoints[1].lat;
            D = XN - X1;
            D = D * D;
            X = YN - Y1;
            X = X * X;
            D = D + X;
            D11 = Math.Sqrt(D);
            if (DNN < D11)
            {
                XN = Lines[N1].GLPoints[NP1].lon;
                YN = Lines[N1].GLPoints[NP1].lat;
                X1 = Lines[N1].GLPoints[NP1 - 1].lon;
                Y1 = Lines[N1].GLPoints[NP1 - 1].lat;
                DN = XN - X1;
                DN = DN * DN;
                X = YN - Y1;
                X = X * X;
                DN = DN + X;
                DN = Math.Sqrt(DN);
                XN = Lines[N2].GLPoints[NP2].lon;
                YN = Lines[N2].GLPoints[NP2].lat;
                X1 = Lines[N2].GLPoints[NP2 - 1].lon;
                Y1 = Lines[N2].GLPoints[NP2 - 1].lat;
                D1 = XN - X1;
                D1 = D1 * D1;
                X = YN - Y1;
                X = X * X;
                D1 = D1 + X;
                D1 = Math.Sqrt(D1);
                if (DNN < D1 | D < DN)
                {
                    JoinLines(N1, N2, 1, -1);
                    Try2LineJoinRet = true;
                    SystemSounds.Beep.Play();
                    return Try2LineJoinRet;
                }
            }
            else
            {
                // 1 and 1
                N = Lines[N1].NoOfPoints;
                XN = Lines[N1].GLPoints[1].lon;
                YN = Lines[N1].GLPoints[1].lat;
                X1 = Lines[N1].GLPoints[2].lon;
                Y1 = Lines[N1].GLPoints[2].lat;
                DN = XN - X1;
                DN = DN * DN;
                X = YN - Y1;
                X = X * X;
                DN = DN + X;
                DN = Math.Sqrt(DN);
                XN = Lines[N2].GLPoints[1].lon;
                YN = Lines[N2].GLPoints[1].lat;
                X1 = Lines[N2].GLPoints[2].lon;
                Y1 = Lines[N2].GLPoints[2].lat;
                D1 = XN - X1;
                D1 = D1 * D1;
                X = YN - Y1;
                X = X * X;
                D1 = D1 + X;
                D1 = Math.Sqrt(D1);
                if (D11 < D1 | D < DN)
                {
                    JoinLines(N1, N2, -1, 1);
                    Try2LineJoinRet = true;
                    SystemSounds.Beep.Play();
                    return Try2LineJoinRet;
                }
            }

            return Try2LineJoinRet;
        }

        internal static void CheckLineJoins()
        {
            int N, N1;
            bool Flag;
            moduleEDIT.BackUp();
            moduleEDIT.SkipBackUp = true;
            N1 = 1;
            Flag = false;
        Return_back:
            ;
            N = N1;
            while (N <= NoOfLines)
            {
                if (Lines[N].Selected)
                {
                    if (TryThisLineJoin(N))
                    {
                        SystemSounds.Beep.Play();
                        Flag = true;
                        goto Return_back;
                    }
                }

                N = N + 1;
                N1 = N;
            }

            moduleEDIT.SkipBackUp = false;
            if (Flag)
                moduleMAIN.RebuildDisplay();
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].GLPoints[1].Selected)
                {
                    if (TryThisLineJoin(N))
                        return;
                }

                if (Lines[N].GLPoints[Lines[N].NoOfPoints].Selected)
                {
                    if (TryThisLineJoin(N))
                        return;
                }
            }
        }

        private static void BreakLines()
        {
            int L, N, K, p;

            // BackUp

            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Selected)
                    goto NextN;
                p = Lines[N].NoOfPoints;
                int loopTo1 = p - 1;
                for (K = 2; K <= loopTo1; K++)
                {
                    if (Lines[N].GLPoints[K].Selected)
                    {
                        NoOfLines = NoOfLines + 1;
                        Array.Resize(ref Lines, NoOfLines + 1);
                        // Lines(NoOfLines).NoOfPoints = p - K
                        Lines[NoOfLines].NoOfPoints = p - K + 1;
                        Lines[NoOfLines].GLPoints = new modulePOINTS.GLPoint[Lines[NoOfLines].NoOfPoints + 1];
                        // For L = K + 1 To p
                        int loopTo2 = p;
                        for (L = K; L <= loopTo2; L++)
                        {
                            // Lines(NoOfLines).GLPoints(L - K).alt = Lines(N).GLPoints(L).alt
                            // Lines(NoOfLines).GLPoints(L - K).lat = Lines(N).GLPoints(L).lat
                            // Lines(NoOfLines).GLPoints(L - K).lon = Lines(N).GLPoints(L).lon
                            Lines[NoOfLines].GLPoints[L - K + 1].wid = Lines[N].GLPoints[L].wid;
                            Lines[NoOfLines].GLPoints[L - K + 1].alt = Lines[N].GLPoints[L].alt;
                            Lines[NoOfLines].GLPoints[L - K + 1].lat = Lines[N].GLPoints[L].lat;
                            Lines[NoOfLines].GLPoints[L - K + 1].lon = Lines[N].GLPoints[L].lon;
                        }

                        Lines[NoOfLines].Color = Lines[N].Color;
                        Lines[NoOfLines].Name = Lines[N].Name;
                        Lines[NoOfLines].Type = Lines[N].Type;
                        Lines[NoOfLines].Guid = Lines[N].Guid;
                        // Lines(NoOfLines).Selected = Lines(N).Selected
                        Lines[NoOfLines].Selected = true;
                        // Lines(N).NoOfPoints = K - 1
                        Lines[N].NoOfPoints = K;
                        Array.Resize(ref Lines[N].GLPoints, Lines[N].NoOfPoints + 1);
                        AddLatLonToLine(NoOfLines);
                        AddLatLonToLine(N);
                        SystemSounds.Beep.Play();
                        return;
                    }
                }

            NextN:
                ;
            }
        }

        private static void IncreaseWidth()
        {
            int N, K;
            double w;

            // BackUp

            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Selected)
                    goto NextN;
                int loopTo1 = Lines[N].NoOfPoints;
                for (K = 1; K <= loopTo1; K++)
                {
                    if (Lines[N].GLPoints[K].Selected)
                    {
                        w = 1.5d * Lines[N].GLPoints[K].wid;
                        if (w > 255d)
                            w = 255d;
                        Lines[N].GLPoints[K].wid = w;
                        return;
                    }
                }

            NextN:
                ;
            }
        }

        private static void DecreaseWidth()
        {
            int N, K;
            double w;

            // BackUp

            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Selected)
                    goto NextN;
                int loopTo1 = Lines[N].NoOfPoints;
                for (K = 1; K <= loopTo1; K++)
                {
                    if (Lines[N].GLPoints[K].Selected)
                    {
                        w = Lines[N].GLPoints[K].wid / 1.5d;
                        if (w < 1d)
                            w = 1d;
                        Lines[N].GLPoints[K].wid = w;
                        return;
                    }
                }

            NextN:
                ;
            }
        }

        internal static void SelectAllLines(ref bool Flag)
        {
            int N, K;
            if (!LineVIEW)
                return;
            if (Flag)
            {
                My.MyProject.Forms.FrmStart.SelectAllLinesMenuItem.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FrmStart.SelectAllLinesMenuItem.Checked = false;
            }

            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Flag)
                {
                    if (!Lines[N].Selected)
                        NoOfLinesSelected = NoOfLinesSelected + 1;
                    moduleMAIN.SomeSelected = true;
                }
                else if (Lines[N].Selected)
                    NoOfLinesSelected = NoOfLinesSelected - 1;
                int loopTo1 = Lines[N].NoOfPoints;
                for (K = 1; K <= loopTo1; K++)
                    Lines[N].GLPoints[K].Selected = false;
                Lines[N].Selected = Flag;
            }
        }

        internal static void SelectInvertLines()
        {
            int N, K;
            bool Flag;
            if (!LineVIEW)
                return;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Selected)
                {
                    NoOfLinesSelected = NoOfLinesSelected - 1;
                    Lines[N].Selected = false;
                    // unselect points ?
                    goto Jump_Next;
                }
                else
                {
                    Flag = false;
                    int loopTo1 = Lines[N].NoOfPoints;
                    for (K = 1; K <= loopTo1; K++)
                    {
                        if (Lines[N].GLPoints[K].Selected)
                        {
                            Flag = true;
                            break;
                        }
                    }

                    if (Flag)
                        goto Jump_Next;
                    NoOfLinesSelected = NoOfLinesSelected + 1;
                    moduleMAIN.SomeSelected = true;
                    Lines[N].Selected = true;
                }

            Jump_Next:
                ;
            }
        }

        internal static void SelectLinesInBox(double X0, double Y0, double X1, double Y1)
        {
            int N;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].ELON < X1)
                {
                    if (Lines[N].WLON > X0)
                    {
                        if (Lines[N].SLAT > Y1)
                        {
                            if (Lines[N].NLAT < Y0)
                            {
                                if (!Lines[N].Selected)
                                    NoOfLinesSelected = NoOfLinesSelected + 1;
                                moduleMAIN.SomeSelected = true;
                                Lines[N].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        internal static void DisplayLines(Graphics gr)
        {
            double X1, X0, Y0, Y1;
            int N, K, NP;
            bool Flag;
            float[] BR;
            BR = new float[4];
            BR[0] = 0.0f;
            BR[1] = 0.2f;
            BR[2] = 0.8f;
            BR[3] = 1.0f;
            int PX0, PY0, PX1, PY1, L0, L1;
            bool[] PointOnDisplay;
            bool SkipSegment;
            double UY, UX, U;
            int DX, DY;
            Pen myPen = new Pen(Color.Red);
            SolidBrush myBrush = new SolidBrush(Color.Red);
            int P1, P2;  // to draw the points
            P1 = 2;
            if (LinePenWidth == 2)
                P1 = 3;
            P2 = 2 * P1;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (!moduleMAIN.MoveON)
                    Lines[N].OnScreen = false;
                if (Lines[N].NLAT < moduleMAIN.LatDispSouth)
                    goto skip_this_one;
                if (Lines[N].SLAT > moduleMAIN.LatDispNorth)
                    goto skip_this_one;
                if (Lines[N].WLON > moduleMAIN.LonDispEast)
                    goto skip_this_one;
                if (Lines[N].ELON < moduleMAIN.LonDispWest)
                    goto skip_this_one;
                NP = Lines[N].NoOfPoints;
                bool IsExtrusion = false;
                bool IsObjects = false;
                myPen.Width = LinePenWidth;
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                if (Lines[N].Type != default)
                {
                    if (Lines[N].Type.Length >= 3 && Lines[N].Type.Substring(0, 3) == "EXT")
                        IsExtrusion = true;
                    if (Lines[N].Type.Length >= 3 && Lines[N].Type.Substring(0, 3) == "OBJ")
                    {
                        IsObjects = true;
                        // myPen.DashStyle = Drawing2D.DashStyle.Dash
                        SetLenWidFromObject(N);
                    }
                }

                Flag = false;
                if (Lines[N].GLPoints[1].Selected)
                    Flag = true; // only the first the others below
                if (Lines[N].Selected)
                {
                    myPen.Color = SelectedLineColor;
                    myBrush.Color = SelectedLineColor;
                    Flag = true;
                }
                else
                {
                    myPen.Color = Lines[N].Color;
                    myBrush.Color = Lines[N].Color;
                }

                PointOnDisplay = new bool[NP + 1];
                X1 = Lines[N].GLPoints[1].lon;
                Y1 = Lines[N].GLPoints[1].lat;
                PX1 = (int)((X1 - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                PY1 = (int)((moduleMAIN.LatDispNorth - Y1) * moduleMAIN.PixelsPerLatDeg);
                L1 = (int)(Lines[N].GLPoints[1].wid * moduleMAIN.PixelsPerMeter / 2d);
                if (L1 < LinePenWidth)
                    L1 = LinePenWidth;
                int loopTo1 = NP;
                for (K = 2; K <= loopTo1; K++)
                {
                    Flag = Flag | Lines[N].GLPoints[K].Selected; // was before on another for next
                    PointOnDisplay[K - 1] = false;
                    SkipSegment = false;
                    X0 = X1;
                    Y0 = Y1;
                    X1 = Lines[N].GLPoints[K].lon;
                    Y1 = Lines[N].GLPoints[K].lat;
                    if (moduleMAIN.IsPtInDisplay(X0, Y0))
                    {
                        PointOnDisplay[K - 1] = true;
                    }
                    else if (!moduleMAIN.IsPtInDisplay(X1, Y1))
                    {
                        if (!moduleMAIN.IsSegInDisplay(X0, Y0, X1, Y1))
                        {
                            SkipSegment = true;
                        }
                    }

                    PX0 = PX1;
                    PY0 = PY1;
                    L0 = L1;
                    PX1 = (int)((X1 - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                    PY1 = (int)((moduleMAIN.LatDispNorth - Y1) * moduleMAIN.PixelsPerLatDeg);
                    L1 = (int)(Lines[N].GLPoints[K].wid * moduleMAIN.PixelsPerMeter / 2d);
                    if (L1 < LinePenWidth)
                        L1 = LinePenWidth;
                    if (SkipSegment)
                        goto jump_next_segment;
                    if (L0 == LinePenWidth & L1 == LinePenWidth | IsObjects)
                    {
                        gr.DrawLine(myPen, PX0, PY0, PX1, PY1);
                    }
                    else if (IsExtrusion)
                    {
                        myPen.CompoundArray = BR;
                        myPen.Width = L0 + L1;
                        gr.DrawLine(myPen, PX0, PY0, PX1, PY1);
                    }
                    else
                    {
                        UX = PX1 - PX0;
                        UY = PY1 - PY0;
                        U = UX * UX + UY * UY;
                        U = Math.Sqrt(U);
                        if (U < moduleMAIN.MinValue)
                            U = moduleMAIN.MinValue;
                        UX = UX / U;
                        UY = UY / U;
                        DX = (int)(L0 * UX);
                        DY = (int)(L0 * UY);
                        PTS[0].X = PX0 - DY;
                        PTS[0].Y = PY0 + DX;
                        PTS[1].X = PX0 + DY;
                        PTS[1].Y = PY0 - DX;
                        if (PointOnDisplay[K - 1])
                        {
                            if (K > 2)
                            {
                                gr.FillPolygon(myBrush, PTS);   // the junction
                            }
                        }

                        DX = (int)(L1 * UX);
                        DY = (int)(L1 * UY);
                        PTS[2].X = PX1 + DY;
                        PTS[2].Y = PY1 - DX;
                        PTS[3].X = PX1 - DY;
                        PTS[3].Y = PY1 + DX;
                        gr.FillPolygon(myBrush, PTS);
                    }

                    Lines[N].OnScreen = true;
                jump_next_segment:
                    ;
                }
                // check if last point is outside the display
                if (moduleMAIN.IsPtInDisplay(Lines[N].GLPoints[NP].lon, Lines[N].GLPoints[NP].lat))
                    PointOnDisplay[NP] = true;

                // now draw selected points
                if (IsExtrusion)
                    myPen.Width = LinePenWidth;
                int loopTo2 = NP;
                for (K = 1; K <= loopTo2; K++)
                {
                    if (PointOnDisplay[K])
                    {
                        if (Flag | LineON)
                        {
                            if (IsObjects)
                            {
                                SetCornersFromObject(N, K);
                                if (Lines[N].GLPoints[K].Selected)
                                {
                                    myBrush.Color = Color.SpringGreen;
                                    myPen.Color = Color.Green;
                                }
                                else
                                {
                                    myBrush.Color = Color.SkyBlue;
                                    myPen.Color = Color.Black;
                                }

                                gr.FillRectangle(myBrush, P0X - 3f, P0Y - 3f, 6f, 6f);
                                gr.DrawRectangle(myPen, P0X - 3f, P0Y - 3f, 6f, 6f);
                                if ((WID + LEN) * moduleMAIN.PixelsPerMeter > 10d)
                                {
                                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                                    gr.DrawLine(myPen, P1X, P1Y, P2X, P2Y);
                                    gr.DrawLine(myPen, P2X, P2Y, P3X, P3Y);
                                    gr.DrawLine(myPen, P3X, P3Y, P4X, P4Y);
                                    gr.DrawLine(myPen, P4X, P4Y, P1X, P1Y);
                                    gr.DrawLine(myPen, P0X, P0Y, HDX, HDY);
                                    if (LineON)
                                    {
                                        myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                                        gr.DrawRectangle(myPen, P1X - 2f, P1Y - 2f, 4f, 4f);
                                        gr.DrawRectangle(myPen, P2X - 2f, P2Y - 2f, 4f, 4f);
                                        gr.DrawRectangle(myPen, P3X - 2f, P3Y - 3f, 4f, 4f);
                                        gr.DrawRectangle(myPen, P4X - 2f, P4Y - 2f, 4f, 4f);
                                        gr.DrawRectangle(myPen, HDX - 2f, HDY - 2f, 4f, 4f);
                                    }
                                }
                            }
                            else
                            {
                                PX0 = (int)((Lines[N].GLPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                                PY0 = (int)((moduleMAIN.LatDispNorth - Lines[N].GLPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
                                myPen.Color = modulePOINTS.UnselectedPointColor;
                                myBrush.Color = modulePOINTS.UnselectedPointColor;
                                if (Lines[N].GLPoints[K].Selected)
                                {
                                    myPen.Color = modulePOINTS.SelectedPointColor;
                                    myBrush.Color = modulePOINTS.SelectedPointColor;
                                }

                                if (K == NP)
                                {
                                    gr.DrawRectangle(myPen, PX0 - 3, PY0 - 3, 6, 6);
                                }
                                else
                                {
                                    gr.FillRectangle(myBrush, PX0 - P1, PY0 - P1, P2, P2);
                                }
                            }
                        }
                    }
                }

            skip_this_one:
                ;
            }

            myBrush.Dispose();
            myPen.Dispose();
        }

        private static float HDX;   // these are for the object of a line that is being processed
        private static float HDY;
        private static float P0Y;
        private static float P0X;
        private static float P1Y;
        private static float P1X;
        private static float P2Y;
        private static float P2X;
        private static float P3Y;
        private static float P3X;
        private static float P4Y;
        private static float P4X;
        private static float WID;
        private static float LEN;

        private static void SetLenWidFromObject(int N)
        {

            // N is the line which is already knnow to be of the OBJ type
            string A;
            A = Lines[N].Type.Substring(4);
            N = A.IndexOf("|");
            WID = Convert.ToSingle(A.Substring(0, N)) / 2f;
            A = A.Substring(N);
            N = A.IndexOf("|");
            LEN = Convert.ToSingle(A.Substring(0, N)) / 2f;
        }

        private static void SetCornersFromObject(int N, int K)
        {

            // N is line and K is the point
            float C, teta, S;
            teta = (float)(Lines[N].GLPoints[K].wid * moduleMAIN.PI / 180d);
            C = (float)(Math.Cos(teta) * moduleMAIN.PixelsPerMeter);
            S = (float)(Math.Sin(teta) * moduleMAIN.PixelsPerMeter);
            P1X = -WID;
            P1Y = LEN;
            RotateXY(ref P1X, ref P1Y, C, S);
            P2X = WID;
            P2Y = LEN;
            RotateXY(ref P2X, ref P2Y, C, S);
            P3X = WID;
            P3Y = -LEN;
            RotateXY(ref P3X, ref P3Y, C, S);
            P4X = -WID;
            P4Y = -LEN;
            RotateXY(ref P4X, ref P4Y, C, S);
            HDX = 0f;
            HDY = LEN;
            RotateXY(ref HDX, ref HDY, C, S);
            P0X = (float)((Lines[N].GLPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            P0Y = (float)((moduleMAIN.LatDispNorth - Lines[N].GLPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
            P1X = P1X + P0X;
            P2X = P2X + P0X;
            P3X = P3X + P0X;
            P4X = P4X + P0X;
            HDX = HDX + P0X;
            P1Y = -P1Y + P0Y;
            P2Y = -P2Y + P0Y;
            P3Y = -P3Y + P0Y;
            P4Y = -P4Y + P0Y;
            HDY = -HDY + P0Y;
        }

        private static void SetHeadingsFromObject(int N, int K)
        {

            // N is line and K is the point
            float C, teta, S;
            teta = (float)(Lines[N].GLPoints[K].wid * moduleMAIN.PI / 180d);
            C = (float)(Math.Cos(teta) * moduleMAIN.PixelsPerMeter);
            S = (float)(Math.Sin(teta) * moduleMAIN.PixelsPerMeter);
            HDX = 0f;
            HDY = LEN;
            RotateXY(ref HDX, ref HDY, C, S);
            P0X = (float)((Lines[N].GLPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            P0Y = (float)((moduleMAIN.LatDispNorth - Lines[N].GLPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
            HDX = HDX + P0X;
            HDY = -HDY + P0Y;
        }

        private static void RotateXY(ref float X, ref float Y, float Cos, float Sin)
        {
            float a;
            a = X;
            X = Cos * X + Sin * Y;
            Y = Cos * Y - Sin * a;
        }

        internal static void MakeBGLObjLines(bool CopyBGLs)
        {
            bool FSNew, FSXml;
            int N, K, J;
            string BGLFile1 = "";
            string BGLFile2 = "";
            string File1 = "";
            string File2 = "";
            string A, B;
            FSNew = false;
            FSXml = false;
            int Complexity;
            string Latitude, Longitude, Heading, Altitude; // used for FS9 - SCASM
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Selected)
                {
                    if (Lines[N].Type.Length >= 3 && Lines[N].Type.Substring(0, 3) == "OBJ")
                    {
                        if (Lines[N].Guid.Substring(0, 1) == "{")
                        {
                            FSXml = true;
                        }
                        else
                        {
                            FSNew = true;
                        }
                    }
                }
            }

            if (FSXml)
            {
                File2 = moduleMAIN.ProjectName + "_LOBX";
                File2 = File2.Replace(" ", "_");
                A = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File2 + ".xml";
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Indent = true,
                    Encoding = Encoding.GetEncoding(28591),
                    NewLineOnAttributes = true
                };
                XmlWriter writer = XmlWriter.Create(A, settings);
                writer.WriteStartDocument();
                writer.WriteComment("Created by SBuilderXX on " + DateTime.Now);
                writer.WriteStartElement("FSData");
                writer.WriteAttributeString("version", "9.0");
                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "bglcomp.xsd");
                writer.WriteComment("FSX Line(s) of Library Objects");
                int loopTo1 = NoOfLines;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (Lines[N].Selected)
                    {
                        if (Lines[N].Type.Length >= 3 && Lines[N].Type.Substring(0, 3) == "OBJ")
                        {
                            if (Lines[N].Guid.Substring(0, 1) == "{")
                            {
                                writer.WriteComment("Line_of_Objects_#" + N.ToString());
                                A = Lines[N].Type.Substring(4);
                                J = A.IndexOf("|");
                                A = A.Substring(J + 1);
                                J = A.IndexOf("|");
                                A = A.Substring(J + 1);
                                Complexity = Convert.ToInt32(A);
                                int loopTo2 = Lines[N].NoOfPoints;
                                for (K = 1; K <= loopTo2; K++)
                                {
                                    writer.WriteStartElement("SceneryObject");
                                    writer.WriteAttributeString("lat", Lines[N].GLPoints[K].lat.ToString().Trim());
                                    writer.WriteAttributeString("lon", Lines[N].GLPoints[K].lon.ToString().Trim());
                                    writer.WriteAttributeString("alt", Lines[N].GLPoints[K].alt.ToString().Trim());
                                    writer.WriteAttributeString("altitudeIsAgl", "TRUE");
                                    writer.WriteAttributeString("pitch", "0");
                                    writer.WriteAttributeString("bank", "0");
                                    writer.WriteAttributeString("heading", Lines[N].GLPoints[K].wid.ToString().Trim());
                                    writer.WriteAttributeString("imageComplexity", GetComplex(Complexity));
                                    writer.WriteStartElement("LibraryObject");
                                    writer.WriteAttributeString("name", Lines[N].Guid);
                                    writer.WriteAttributeString("scale", "1.0");
                                    writer.WriteEndElement();
                                    writer.WriteFullEndElement();
                                }
                            }
                        }
                    }
                }

                writer.WriteFullEndElement();
                writer.Close();

                // delete BGL File2
                BGLFile2 = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File2 + ".BGL";
                if (File.Exists(BGLFile2))
                    File.Delete(BGLFile2);
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
                A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bglcomp.exe";
                B = @"work\" + File2 + ".xml";
                Process myProcess = new Process();
                myProcess = Process.Start(A, B);
                myProcess.WaitForExit();
                myProcess.Dispose();
                if (!File.Exists(BGLFile2))
                {
                    A = "BGLComp could not produce the file" + Environment.NewLine + BGLFile2 + Environment.NewLine;
                    A = A + @"Try to compile the file ..\tools\" + B + " in a MSDOS window" + Environment.NewLine;
                    A = A + "to read the error report!";
                    MessageBox.Show(A, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (FSNew)
            {
                File1 = moduleMAIN.ProjectName + "_LOB1";
                File1 = File1.Replace(" ", "_");
                using (StreamWriter file = new StreamWriter(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File1 + ".scm"))
                {
                    A = "Header( 0x201 )";
                    file.WriteLine(A);
                    file.WriteLine();
                    A = "; FS9 Line(s) of Library Objects";
                    int loopTo3 = NoOfLines;
                    for (N = 1; N <= loopTo3; N++)
                    {
                        if (Lines[N].Selected)
                        {
                            if (Lines[N].Type.Length >= 3 && Lines[N].Type.Substring(0, 3) == "OBJ")
                            {
                                if (Lines[N].Guid.Substring(0, 1) != "{")
                                {
                                    moduleOBJECTS.ObjLibID = Lines[N].Guid;
                                    A = Lines[N].Type.Substring(4);
                                    J = A.IndexOf("|");
                                    A = A.Substring(J + 1);
                                    J = A.IndexOf("|");
                                    A = A.Substring(J + 1);
                                    Complexity = Convert.ToInt32(A);
                                    int loopTo4 = Lines[N].NoOfPoints;
                                    for (K = 1; K <= loopTo4; K++)
                                    {
                                        Latitude = Lines[N].GLPoints[K].lat.ToString("0.00000000");
                                        Longitude = Lines[N].GLPoints[K].lon.ToString("0.00000000");
                                        Altitude = Lines[N].GLPoints[K].alt.ToString("0.000");
                                        Heading = Lines[N].GLPoints[K].wid.ToString("0.000");
                                        Latitude = Latitude.Replace(",", ".");
                                        Longitude = Longitude.Replace(",", ".");
                                        Altitude = Altitude.Replace(",", ".");
                                        Heading = Heading.Replace(",", ".");
                                        A = "; Line_of_Objects_#" + N.ToString() + Environment.NewLine;
                                        A = A + "LibraryObject( " + Latitude + " " + Longitude + " " + Altitude + " 1";
                                        file.WriteLine(A);
                                        A = "               0 0 " + Heading + " " + Complexity.ToString() + " " + FixLibID(moduleOBJECTS.ObjLibID) + " 1 )";
                                        file.WriteLine(A);
                                    }
                                }
                            }
                        }
                    }
                    file.WriteLine();
                }

                // delete BGL File1
                BGLFile1 = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File1 + ".BGL";
                if (File.Exists(BGLFile1))
                    File.Delete(BGLFile1);
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
                A = @"scasm work\" + File1 + ".scm -s -l";
                N = moduleMAIN.ExecCmd(A);
                if (N > 0)
                {
                    A = "There was a compilation error in this project!" + Environment.NewLine;
                    A = A + "Do you want to read a SCASM report?";
                    DialogResult dr = MessageBox.Show(A, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        A = "notepad SCAERROR.LOG";
                        N = moduleMAIN.ExecCmd(A);
                    }

                    return;
                }
            }

            if (!CopyBGLs)
                return;
            string BGLFileTarget;
            // copy BGL files
            try
            {
                if (FSNew)
                {
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + File1 + ".BGL";
                    if (File.Exists(BGLFile1))
                        File.Copy(BGLFile1, BGLFileTarget, true);
                }

                if (FSXml)
                {
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + File2 + ".BGL";
                    if (File.Exists(BGLFile2))
                        File.Copy(BGLFile2, BGLFileTarget, true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static string FixLibID(string ID)
        {
            string FixLibIDRet = default;
            FixLibIDRet = ID.Substring(0, 8).ToUpper() + " ";
            FixLibIDRet = FixLibIDRet + ID.Substring(8, 8).ToUpper() + " ";
            FixLibIDRet = FixLibIDRet + ID.Substring(16, 8).ToUpper() + " ";
            FixLibIDRet = FixLibIDRet + ID.Substring(24, 8).ToUpper();
            return FixLibIDRet;
        }

        internal static void MakeBGLExtrusions(bool CopyBGLs)
        {
            int N, K;
            Guid g;
            string lat0 = "";
            string lon0 = "";
            string latN = "";
            string lonN = "";
            string myFile = moduleMAIN.ProjectName + "_EXT";
            myFile = myFile.Replace(" ", "_");
            string a = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".xml";
            XmlWriterSettings settings = new XmlWriterSettings()
            {
                Indent = true,
                Encoding = Encoding.GetEncoding(28591),
                NewLineOnAttributes = true
            };
            XmlWriter writer = XmlWriter.Create(a, settings);
            writer.WriteStartDocument();
            writer.WriteComment("Created by SBuilderXX on " + DateTime.Now);
            writer.WriteStartElement("FSData");
            writer.WriteAttributeString("version", "9.0");
            writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
            writer.WriteAttributeString("noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "bglcomp.xsd");
            writer.WriteComment("FSX Extrusion Bridges");
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Selected)
                {
                    if (Lines[N].Type.Length >= 3 && Lines[N].Type.Substring(0, 3) == "EXT")
                    {
                        GetExtrusionLineParameters(N);
                        writer.WriteComment("Extrusion Line " + N.ToString());
                        writer.WriteStartElement("ExtrusionBridge");
                        g = Guid.NewGuid();
                        writer.WriteAttributeString("instanceId", g.ToString("B"));
                        writer.WriteAttributeString("imageComplexity", GetComplex(ExtrusionComplexity));
                        writer.WriteAttributeString("probability", ExtrusionProbability.ToString().Trim());
                        writer.WriteAttributeString("suppressPlatform", SuppressPlatform.ToString().ToUpper().Trim());
                        writer.WriteAttributeString("roadWidth", ExtrusionWidth.ToString().Trim());
                        writer.WriteAttributeString("extrusionProfile", Lines[N].Guid);
                        writer.WriteAttributeString("materialSet", MaterialGuid);
                        writer.WriteStartElement("AltitudeSampleLocationList");
                        writer.WriteStartElement("AltitudeSampleLocation");
                        writer.WriteAttributeString("lat", Lines[N].GLPoints[1].lat.ToString().Trim());
                        writer.WriteAttributeString("lon", Lines[N].GLPoints[1].lon.ToString().Trim());
                        writer.WriteEndElement();
                        writer.WriteStartElement("AltitudeSampleLocation");
                        writer.WriteAttributeString("lat", Lines[N].GLPoints[Lines[N].NoOfPoints].lat.ToString().Trim());
                        writer.WriteAttributeString("lon", Lines[N].GLPoints[Lines[N].NoOfPoints].lon.ToString().Trim());
                        writer.WriteEndElement();
                        writer.WriteFullEndElement();
                        writer.WriteStartElement("PolylinePointList");
                        SetExtrusionExtremes(N, ref lat0, ref lon0, ref latN, ref lonN);
                        writer.WriteStartElement("PolylinePoint");
                        writer.WriteAttributeString("latitude", lat0);
                        writer.WriteAttributeString("longitude", lon0);
                        writer.WriteAttributeString("altitude", ExtraExtrusionAltitude);
                        writer.WriteEndElement();
                        int loopTo1 = Lines[N].NoOfPoints;
                        for (K = 1; K <= loopTo1; K++)
                        {
                            writer.WriteStartElement("PolylinePoint");
                            writer.WriteAttributeString("latitude", Lines[N].GLPoints[K].lat.ToString().Trim());
                            writer.WriteAttributeString("longitude", Lines[N].GLPoints[K].lon.ToString().Trim());
                            writer.WriteAttributeString("altitude", Lines[N].GLPoints[K].alt.ToString().Trim() + "M");
                            writer.WriteEndElement();
                        }

                        writer.WriteStartElement("PolylinePoint");
                        writer.WriteAttributeString("latitude", latN);
                        writer.WriteAttributeString("longitude", lonN);
                        writer.WriteAttributeString("altitude", ExtraExtrusionAltitude);
                        writer.WriteEndElement();
                        writer.WriteFullEndElement();
                        writer.WriteStartElement("PolylineObjectPlacementList");
                        writer.WriteStartElement("PolylineObjectPlacement");
                        writer.WriteAttributeString("id", PylonGuid);
                        writer.WriteEndElement();
                        writer.WriteFullEndElement();
                        writer.WriteFullEndElement();  // ExtrusionBridge
                    }
                }
            }

            writer.WriteFullEndElement(); // FSData
            writer.Close();

            // delete BGL File
            string BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".BGL";
            if (File.Exists(BGLFile))
                File.Delete(BGLFile);
            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bglcomp.exe";
            string b = @"work\" + myFile + ".xml";
            Process myProcess = new Process();
            myProcess = Process.Start(a, b);
            myProcess.WaitForExit();
            myProcess.Dispose();
            if (!File.Exists(BGLFile))
            {
                a = "BGLComp could not produce the file" + Environment.NewLine + BGLFile + Environment.NewLine;
                a = a + @"Try to compile the file ..\tools\" + b + " in a MSDOS window" + Environment.NewLine;
                a = a + "to read the error report!";
                MessageBox.Show(a, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (!CopyBGLs)
                return;
            string BGLFileTarget;
            // copy BGL files
            try
            {
                BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + myFile + ".BGL";
                if (File.Exists(BGLFile))
                    File.Copy(BGLFile, BGLFileTarget, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static void SetExtrusionExtremes(int N, ref string lat0, ref string lon0, ref string latN, ref string lonN)

        {
            double D;
            int NP = Lines[N].NoOfPoints;
            D = Lines[N].GLPoints[2].lat - Lines[N].GLPoints[1].lat;
            lat0 = (Lines[N].GLPoints[1].lat - D / 2d).ToString();
            D = Lines[N].GLPoints[2].lon - Lines[N].GLPoints[1].lon;
            lon0 = (Lines[N].GLPoints[1].lon - D / 2d).ToString();
            D = Lines[N].GLPoints[NP - 1].lat - Lines[N].GLPoints[NP].lat;
            latN = (Lines[N].GLPoints[NP].lat - D / 2d).ToString();
            D = Lines[N].GLPoints[NP - 1].lon - Lines[N].GLPoints[NP].lon;
            lonN = (Lines[N].GLPoints[NP].lon - D / 2d).ToString();
        }

        private static string MaterialGuid;
        private static string PylonGuid;
        private static int ExtrusionComplexity;
        private static double ExtrusionWidth;
        private static double ExtrusionProbability;
        private static bool SuppressPlatform;

        private static void GetExtrusionLineParameters(int N)
        {
            string A;
            int J;
            A = Lines[N].Type.Substring(4);
            J = A.IndexOf("|");
            MaterialGuid = A.Substring(0, J);
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            PylonGuid = A.Substring(0, J);
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            ExtrusionComplexity = Convert.ToInt32(A.Substring(0, J));
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            ExtrusionWidth = Convert.ToDouble(A.Substring(0, J));
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            ExtrusionProbability = Convert.ToDouble(A.Substring(0, J));
            A = A.Substring(J + 1);
            SuppressPlatform = Convert.ToBoolean(A);
        }

        private static string GetComplex(int X)
        {
            string GetComplexRet = default;
            GetComplexRet = "";
            if (X == 0)
                GetComplexRet = "VERY_SPARSE";
            if (X == 1)
                GetComplexRet = "SPARSE";
            if (X == 2)
                GetComplexRet = "NORMAL";
            if (X == 3)
                GetComplexRet = "DENSE";
            if (X == 4)
                GetComplexRet = "VERY_DENSE";
            if (X == 5)
                GetComplexRet = "EXTREMELY_DENSE";
            return GetComplexRet;
        }

        internal static void MakePolyFromLine(int N)
        {
            int P, M;
            double UX, UY, U, K;
            int NP = Lines[N].NoOfPoints;
            moduleMAIN.Double_XY[] Line = new moduleMAIN.Double_XY[NP + 1];  // line in meter coordinates
            int loopTo = NP;
            for (P = 1; P <= loopTo; P++)
            {
                Line[P].X = Lines[N].GLPoints[P].lon * moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                Line[P].Y = Lines[N].GLPoints[P].lat * moduleMAIN.MetersPerDegLat;
            }

            moduleMAIN.Double_XY[] D1 = new moduleMAIN.Double_XY[NP + 1];
            moduleMAIN.Double_XY[] D2 = new moduleMAIN.Double_XY[NP + 1];
            double W;
            int loopTo1 = NP - 1;
            for (P = 1; P <= loopTo1; P++)
            {
                UX = Line[P + 1].X - Line[P].X;
                UY = Line[P + 1].Y - Line[P].Y;
                U = UX * UX + UY * UY;
                U = Math.Sqrt(U);
                if (U < moduleMAIN.MinValue)
                    U = moduleMAIN.MinValue;
                UX = UX / U;
                UY = UY / U;
                W = Lines[N].GLPoints[P].wid / 2d;
                D2[P].X = UX * W;
                D2[P].Y = UY * W;
                W = Lines[N].GLPoints[P + 1].wid / 2d;
                D1[P + 1].X = UX * W;
                D1[P + 1].Y = UY * W;
            }

            moduleMAIN.Double_XY[] PR1 = new moduleMAIN.Double_XY[NP + 1];   // right side
            moduleMAIN.Double_XY[] PR2 = new moduleMAIN.Double_XY[NP + 1];
            moduleMAIN.Double_XY[] PR = new moduleMAIN.Double_XY[NP + 1];
            moduleMAIN.Double_XY[] PL1 = new moduleMAIN.Double_XY[NP + 1];   // left side
            moduleMAIN.Double_XY[] PL2 = new moduleMAIN.Double_XY[NP + 1];
            moduleMAIN.Double_XY[] PL = new moduleMAIN.Double_XY[NP + 1];
            PL[1].X = Line[1].X - D2[1].Y;
            PL[1].Y = Line[1].Y + D2[1].X;
            PR[1].X = Line[1].X + D2[1].Y;
            PR[1].Y = Line[1].Y - D2[1].X;
            PL[NP].X = Line[NP].X - D1[NP].Y;
            PL[NP].Y = Line[NP].Y + D1[NP].X;
            PR[NP].X = Line[NP].X + D1[NP].Y;
            PR[NP].Y = Line[NP].Y - D1[NP].X;
            int loopTo2 = NP - 1;
            for (P = 2; P <= loopTo2; P++)
            {
                PL1[P].X = Line[P].X - D1[P].Y;
                PL1[P].Y = Line[P].Y + D1[P].X;
                PR1[P].X = Line[P].X + D1[P].Y;
                PR1[P].Y = Line[P].Y - D1[P].X;
                PL2[P].X = Line[P].X - D2[P].Y;
                PL2[P].Y = Line[P].Y + D2[P].X;
                PR2[P].X = Line[P].X + D2[P].Y;
                PR2[P].Y = Line[P].Y - D2[P].X;
                K = PL2[P].X * D1[P].Y;
                K = K - PL1[P].X * D1[P].Y;
                K = K + PL1[P].Y * D1[P].X;
                K = K - PL2[P].Y * D1[P].X;
                U = D2[P].Y * D1[P].X - D2[P].X * D1[P].Y;
                if (!(K == 0d))
                    K = K / U;
                PL[P].X = PL2[P].X + K * D2[P].X;
                PL[P].Y = PL2[P].Y + K * D2[P].Y;
                K = PR2[P].X * D1[P].Y;
                K = K - PR1[P].X * D1[P].Y;
                K = K + PR1[P].Y * D1[P].X;
                K = K - PR2[P].Y * D1[P].X;
                U = D2[P].Y * D1[P].X - D2[P].X * D1[P].Y;
                if (!(K == 0d))
                    K = K / U;
                PR[P].X = PR2[P].X + K * D2[P].X;
                PR[P].Y = PR2[P].Y + K * D2[P].Y;
            }

            modulePOLYS.NoOfPolys = modulePOLYS.NoOfPolys + 1;
            Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + 1);
            modulePOLYS.Polys[modulePOLYS.NoOfPolys].NoOfPoints = 2 * NP;
            modulePOLYS.Polys[modulePOLYS.NoOfPolys].Name = modulePOLYS.Polys[modulePOLYS.NoOfPolys].NoOfPoints.ToString() + "_Pts_Polygon_of_Type_None";
            modulePOLYS.Polys[modulePOLYS.NoOfPolys].Guid = modulePOLYS.DefaultPolyNoneGuid;
            modulePOLYS.Polys[modulePOLYS.NoOfPolys].NoOfChilds = 0;
            modulePOLYS.Polys[modulePOLYS.NoOfPolys].Color = modulePOLYS.DefaultPolyColor;
            modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints = new modulePOINTS.GPoint[2 * NP + 1];
            M = 1;
            int loopTo3 = NP;
            for (P = 1; P <= loopTo3; P++)
            {
                modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[M].lat = PL[P].Y / moduleMAIN.MetersPerDegLat;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[M].lon = PL[P].X / moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[M].alt = Lines[N].GLPoints[P].alt;
                M = M + 1;
            }

            for (P = NP; P >= 1; P -= 1)
            {
                modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[M].lat = PR[P].Y / moduleMAIN.MetersPerDegLat;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[M].lon = PR[P].X / moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                modulePOLYS.Polys[modulePOLYS.NoOfPolys].GPoints[M].alt = Lines[N].GLPoints[P].alt;
                M = M + 1;
            }

            modulePOLYS.AddLatLonToPoly(modulePOLYS.NoOfPolys);
            moduleMAIN.Dirty = true;
        }

        internal static void DeleteSelectedLines()
        {
            int N, L;
            if (NoOfLinesSelected < 5)
            {
                for (N = NoOfLines; N >= 1; N -= 1)
                {
                    if (Lines[N].Selected)
                        DeleteLine(N);
                }
            }
            else
            {
                N = 0;
                L = 0;
                do
                {
                    N = N + 1;
                    if (N > NoOfLines)
                        break;
                    if (!Lines[N].Selected)
                    {
                        L = L + 1;
                        Lines[L] = Lines[N];
                    }
                }
                while (true);
                if (L > 0)
                {
                    Array.Resize(ref Lines, L + 1);
                }
                else
                {
                    Array.Resize(ref Lines, 2);
                }

                NoOfLines = L;
            }
        }

        internal static void DeleteSelectedPointsInLines()
        {
            int N, K;
            for (N = NoOfLines; N >= 1; N -= 1)
            {
                for (K = Lines[N].NoOfPoints; K >= 1; K -= 1)
                {
                    if (Lines[N].GLPoints[K].Selected)
                        DeletePointInLine(N, K);
                }
            }
        }

        internal static void DeletePointInLine(int Ln, int PT)
        {
            int p;
            if (Lines[Ln].NoOfPoints < 3)
            {
                DeleteLine(Ln);
                moduleMAIN.Dirty = true;
                return;
            }

            if (!moduleEDIT.SkipBackUp)
                moduleEDIT.BackUp();
            if (PT < Lines[Ln].NoOfPoints)
            {
                int loopTo = Lines[Ln].NoOfPoints - 1;
                for (p = PT; p <= loopTo; p++)
                {
                    Lines[Ln].GLPoints[p].lat = Lines[Ln].GLPoints[p + 1].lat;
                    Lines[Ln].GLPoints[p].lon = Lines[Ln].GLPoints[p + 1].lon;
                    Lines[Ln].GLPoints[p].alt = Lines[Ln].GLPoints[p + 1].alt;
                    Lines[Ln].GLPoints[p].wid = Lines[Ln].GLPoints[p + 1].wid;
                    Lines[Ln].GLPoints[p].Selected = Lines[Ln].GLPoints[p + 1].Selected;
                }
            }

            Array.Resize(ref Lines[Ln].GLPoints, Lines[Ln].NoOfPoints);
            Lines[Ln].NoOfPoints = Lines[Ln].NoOfPoints - 1;
            moduleMAIN.Dirty = true;
        }

        internal static void DeleteLine(int N)
        {
            int K;
            if (Lines[N].Selected)
                NoOfLinesSelected = NoOfLinesSelected - 1;
            if (!moduleEDIT.SkipBackUp)
                moduleEDIT.BackUp();
            if (N < NoOfLines)
            {
                int loopTo = NoOfLines - 1;
                for (K = N; K <= loopTo; K++)
                    Lines[K] = Lines[K + 1];
            }

            if (NoOfLines > 1)
            {
                Array.Resize(ref Lines, NoOfLines);
            }

            NoOfLines = NoOfLines - 1;
            moduleMAIN.Dirty = true;
        }

        internal static bool IsInsertPointInLine(int X1, int Y1)
        {
            bool IsInsertPointInLineRet = default;

            // returns true if point was inserted
            // on entry X1 Y1 contain distance from the origin of display in pixels

            bool retval = default(bool);
            int N, K;
            double X, Y;
            IsInsertPointInLineRet = false;
            if (moduleMAIN.InsertON == false)
                return IsInsertPointInLineRet;
            if (!LineVIEW)
                return IsInsertPointInLineRet;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1;

            // check if we are over a Line
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                K = 2;
                while (!(retval == true | K == Lines[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPointInSegment(Lines[N].GLPoints[K - 1].lon, Lines[N].GLPoints[K - 1].lat, Lines[N].GLPoints[K].lon, Lines[N].GLPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    IsInsertPointInLineRet = true;
                    InsertPointInLine(X, Y, N, K - 1);
                    return IsInsertPointInLineRet;
                }
            }

            return IsInsertPointInLineRet;
        }

        internal static int InsertPointInLine(double X, double Y, int Line, int Point)
        {
            int InsertPointInLineRet = default;

            // returns 0 if insert fails or 1 if it inserts

            int N, K;
            double X1, Y1;
            X1 = X / moduleMAIN.PixelsPerLonDeg;
            Y1 = Y / moduleMAIN.PixelsPerLatDeg;
            InsertPointInLineRet = 0;
            N = Lines[Line].NoOfPoints;
            int loopTo = N;
            for (K = 1; K <= loopTo; K++)
            {
                if (Math.Abs(Lines[Line].GLPoints[K].lat - Y1) < moduleMAIN.D22Lat)
                {
                    if (Math.Abs(Lines[Line].GLPoints[K].lon - X1) < moduleMAIN.D22Lon)
                    {
                        return InsertPointInLineRet;
                    }
                }
            }

            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            N = Lines[Line].NoOfPoints + 1;
            Lines[Line].NoOfPoints = N;
            Array.Resize(ref Lines[Line].GLPoints, N + 1);
            int loopTo1 = Point;
            for (K = N - 1; K >= loopTo1; K -= 1)
            {
                Lines[Line].GLPoints[K + 1].lat = Lines[Line].GLPoints[K].lat;
                Lines[Line].GLPoints[K + 1].lon = Lines[Line].GLPoints[K].lon;
                Lines[Line].GLPoints[K + 1].alt = Lines[Line].GLPoints[K].alt;
                Lines[Line].GLPoints[K + 1].wid = Lines[Line].GLPoints[K].wid;
            }

            Lines[Line].GLPoints[Point].lat = Y1;
            Lines[Line].GLPoints[Point].lon = X1;
            // Lines(Line).GLPoints(Point).alt = 0.5 * (Lines(Line).GLPoints(Point - 1).alt + Lines(Line).GLPoints(Point + 1).alt)
            // Lines(Line).GLPoints(Point).wid = 0.5 * (Lines(Line).GLPoints(Point - 1).wid + Lines(Line).GLPoints(Point + 1).wid)

            double Z = default, W = default;
            ZWFromXYZ(ref Z, ref W, X1, Y1, Line, Point - 1, Point + 1);
            Lines[Line].GLPoints[Point].alt = Z;
            Lines[Line].GLPoints[Point].wid = W;
            Lines[Line].GLPoints[Point].Selected = true;
            InsertPointInLineRet = 1;
            return InsertPointInLineRet;
        }

        internal static bool IsPointInLine(int X1, int Y1)
        {
            bool IsPointInLineRet = default;

            // THIS HAS CHANGED - on entry X Y contain distance from center display in pixels
            // NOW Sept2006 - on entry X Y contain distance from the origin of the display in pixels

            int N, K;
            bool retval;
            double WLON, NLAT, SLAT, ELON;
            double X, Y;
            IsPointInLineRet = false;
            if (!LineVIEW)
                return IsPointInLineRet;
            WLON = moduleMAIN.LonDispWest + (X1 + 5) / moduleMAIN.PixelsPerLonDeg;
            ELON = moduleMAIN.LonDispWest + (X1 - 5) / moduleMAIN.PixelsPerLonDeg;
            NLAT = moduleMAIN.LatDispNorth - (Y1 + 5) / moduleMAIN.PixelsPerLatDeg;
            SLAT = moduleMAIN.LatDispNorth - (Y1 - 5) / moduleMAIN.PixelsPerLatDeg;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;  // longitude in pixels
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1; // latitude in pixels
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].Selected)
                    goto Jump_Next; // mantain??? if line is selected the points aare not selected
                if (WLON < Lines[N].WLON)
                    goto Jump_Next;
                if (ELON > Lines[N].ELON)
                    goto Jump_Next;
                if (SLAT < Lines[N].SLAT)
                    goto Jump_Next;
                if (NLAT > Lines[N].NLAT)
                    goto Jump_Next;
                K = 1;
                retval = false;
                while (!(retval == true | K == Lines[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPoint(Lines[N].GLPoints[K].lon, Lines[N].GLPoints[K].lat, X, Y);
                    K = K + 1;
                }
                // If retval Then
                // If Lines(N).Selected = False Then NoOfLinesSelected = NoOfLinesSelected + 1
                // Lines(N).GLPoints(K - 1).Selected = True
                // Lines(N).Selected = False
                // IsPointInLine = True
                // Exit Function
                // End If
                // mudado em 28 de setembro1006

                if (retval)
                {
                    if (Lines[N].GLPoints[K - 1].Selected == false)
                        moduleMAIN.NoOfPointsSelected = moduleMAIN.NoOfPointsSelected + 1;
                    Lines[N].GLPoints[K - 1].Selected = true;
                    IsPointInLineRet = true;
                    return IsPointInLineRet;
                }

            Jump_Next:
                ;
            }

            return IsPointInLineRet;
        }

        internal static bool IsLineSelected(double X, double Y)
        {
            bool IsLineSelectedRet = default;

            // on entry X Y contain distance from center of earth in pixels

            int N, K;
            bool retval;
            double WLON, NLAT, SLAT, ELON;
            IsLineSelectedRet = false;
            if (!LineVIEW)
                return IsLineSelectedRet;
            WLON = (X + 5d) / moduleMAIN.PixelsPerLonDeg;
            ELON = (X - 5d) / moduleMAIN.PixelsPerLonDeg;
            NLAT = (Y - 5d) / moduleMAIN.PixelsPerLatDeg;
            SLAT = (Y + 5d) / moduleMAIN.PixelsPerLatDeg;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                retval = false;
                if (Lines[N].Selected)
                    goto Jump_Next;
                if (WLON < Lines[N].WLON)
                    goto Jump_Next;
                if (ELON > Lines[N].ELON)
                    goto Jump_Next;
                if (SLAT < Lines[N].SLAT)
                    goto Jump_Next;
                if (NLAT > Lines[N].NLAT)
                    goto Jump_Next;
                K = 2;
                while (!(retval == true | K == Lines[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPointInSegment(Lines[N].GLPoints[K - 1].lon, Lines[N].GLPoints[K - 1].lat, Lines[N].GLPoints[K].lon, Lines[N].GLPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    if (Lines[N].Selected == false)
                        NoOfLinesSelected = NoOfLinesSelected + 1;
                    Lines[N].Selected = true;
                    int loopTo1 = Lines[N].NoOfPoints;
                    for (K = 1; K <= loopTo1; K++)
                    {
                        if (Lines[N].GLPoints[K].Selected)
                            moduleMAIN.NoOfPointsSelected = moduleMAIN.NoOfPointsSelected - 1;
                        Lines[N].GLPoints[K].Selected = false;
                    }

                    IsLineSelectedRet = true;
                    moduleMAIN.SomeSelected = true;
                    return IsLineSelectedRet;
                }

            Jump_Next:
                ;
            }

            return IsLineSelectedRet;
        }

        internal static void AddLatLonToLine(int N)
        {
            int K;
            double EL, SL, NL, WL, x;
            NL = -90;
            SL = 90d;
            EL = -180;
            WL = 180d;
            int loopTo = Lines[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
            {
                x = Lines[N].GLPoints[K].lat;
                if (x < SL)
                    SL = x;
                if (x > NL)
                    NL = x;
                x = Lines[N].GLPoints[K].lon;
                if (x > EL)
                    EL = x;
                if (x < WL)
                    WL = x;
            }

            Lines[N].ELON = EL;
            Lines[N].WLON = WL;
            Lines[N].NLAT = NL;
            Lines[N].SLAT = SL;
        }

        internal static void MoveSelectedLines(double X, double Y)
        {
            int N, K;
            bool Flag;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].OnScreen)
                {
                    if (Lines[N].Selected)
                    {
                        int loopTo1 = Lines[N].NoOfPoints;
                        for (K = 1; K <= loopTo1; K++)
                        {
                            Lines[N].GLPoints[K].lat = Lines[N].GLPoints[K].lat - Y;
                            Lines[N].GLPoints[K].lon = Lines[N].GLPoints[K].lon + X;
                        }

                        AddLatLonToLine(N);
                    }
                    else // If Not LineON Then ' ??? that was not permitting point movements in Line Mode
                    {
                        Flag = false;
                        int loopTo2 = Lines[N].NoOfPoints;
                        for (K = 1; K <= loopTo2; K++)
                        {
                            if (Lines[N].GLPoints[K].Selected)
                            {
                                Lines[N].GLPoints[K].lat = Lines[N].GLPoints[K].lat - Y;
                                Lines[N].GLPoints[K].lon = Lines[N].GLPoints[K].lon + X;
                                Flag = true;
                            }
                        }

                        if (Flag)
                            AddLatLonToLine(N);
                    }
                }
            }

            moduleMAIN.Dirty = true;
        }

        internal static void CheckLineMove(bool UP)
        {
            int L;
            Lines[CheckLine].GLPoints[CheckLinePt].Selected = false;
            if (UP)
            {
                L = CheckLine + 1;
                if (L == NoOfLines + 1)
                    L = 1;
            }
            else
            {
                L = CheckLine - 1;
                if (L == 0)
                    L = NoOfLines;
            }

            CheckLine = L;
            CheckLinePt = 1;
            RefreshCheckLinePt();
        }

        internal static void CheckLinePtMove(bool UP)
        {
            int NP, p;
            NP = Lines[CheckLine].NoOfPoints;
            Lines[CheckLine].GLPoints[CheckLinePt].Selected = false;
            if (UP)
            {
                p = CheckLinePt + 1;
                if (p > NP)
                    p = 1;
            }
            else
            {
                p = CheckLinePt - 1;
                if (p == 0)
                    p = NP;
            }

            CheckLinePt = p;
            RefreshCheckLinePt();
        }

        internal static void DeleteCheckLinePt()
        {
            if (Lines[CheckLine].NoOfPoints < 3)
            {
                CheckLine = 0;
                return;
            }

            DeletePointInLine(CheckLine, CheckLinePt);
            if (CheckLinePt > Lines[CheckLine].NoOfPoints)
            {
                CheckLinePt = Lines[CheckLine].NoOfPoints;
            }

            RefreshCheckLinePt();
        }

        private static void RefreshCheckLinePt()
        {
            Lines[CheckLine].GLPoints[CheckLinePt].Selected = true;
            moduleMAIN.LatDispCenter = Lines[CheckLine].GLPoints[CheckLinePt].lat;
            moduleMAIN.LonDispCenter = Lines[CheckLine].GLPoints[CheckLinePt].lon;
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
        }

        internal static int IsMouseOnLine(int X1, int Y1)
        {
            int IsMouseOnLineRet = default;

            // returns the first line that has the mouse over it! if none returns 0
            // on entry X Y contains mouse distance from origin of display in pixels

            int N, K;
            bool retval;
            double X, Y;
            IsMouseOnLineRet = 0;
            if (LineVIEW == false)
                return IsMouseOnLineRet;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1;
            int loopTo = NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (Lines[N].OnScreen == false)
                    goto Jump_Next;
                K = 2;
                retval = false;
                while (!(retval == true | K == Lines[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPointInSegment(Lines[N].GLPoints[K - 1].lon, Lines[N].GLPoints[K - 1].lat, Lines[N].GLPoints[K].lon, Lines[N].GLPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    IsMouseOnLineRet = N;
                    return IsMouseOnLineRet;
                }

            Jump_Next:
                ;
            }

            return IsMouseOnLineRet;
        }

        private static void ReverseLine(int N)
        {
            modulePOINTS.GLPoint x;
            int M, NP, K;
            NP = Lines[N].NoOfPoints;
            M = (int)(NP / 2d);
            NP = NP + 1;
            int loopTo = M;
            for (K = 1; K <= loopTo; K++)
            {
                x = Lines[N].GLPoints[NP - K];
                Lines[N].GLPoints[NP - K] = Lines[N].GLPoints[K];
                Lines[N].GLPoints[K] = x;
            }
        }

        private static void ZWFromXYZ(ref double Z, ref double W, double x, double y, int L, int P0, int P1)

        {
            double x0, y0, z0, w0, x1, y1, z1, w1, dx, dy;
            x0 = Lines[L].GLPoints[P0].lon;
            y0 = Lines[L].GLPoints[P0].lat;
            z0 = Lines[L].GLPoints[P0].alt;
            w0 = Lines[L].GLPoints[P0].wid;
            x1 = Lines[L].GLPoints[P1].lon;
            y1 = Lines[L].GLPoints[P1].lat;
            z1 = Lines[L].GLPoints[P1].alt;
            w1 = Lines[L].GLPoints[P1].wid;
            dx = x1 - x0;
            dy = y1 - y0;
            if (dy > dx)
            {
                y = (y1 - y) / dy;
                x = 1d - y;
                Z = y * z0 + x * z1;
                W = y * w0 + x * w1;
            }
            else
            {
                x = (x1 - x) / dx;
                y = 1d - x;
                Z = x * z0 + y * z1;
                W = x * w0 + y * w1;
            }
        }
    }
}