using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Xml;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    static class modulePOLYS
    {
        internal static int PtPolyCounter;
        internal static double AuxLatPoly; // also used in make bgl tex polys
        internal static double AuxLonPoly; // also used in make bgl tex polys
        private static double AuxZPoly; // used in make bgl tex polys

        // Private Const DJoinLon As Double = 360# / 768# / 32# / 256# / 10#
        // Private Const DJoinLat  As Double = 180# / 512# / 32# / 256# / 10#

        [Serializable()]
        internal struct GPoly
        {
            public string Name;
            public string Type;
            public string Guid;
            public Color Color;
            public bool Selected;
            public int NoOfChilds;
            public int[] Childs;
            public int NoOfPoints;
            public modulePOINTS.GPoint[] GPoints;
            public double NLAT; // not saved
            public double SLAT; // not saved
            public double WLON; // not saved
            public double ELON; // not saved
            public bool OnScreen;
        }

        internal static int NoOfPolys = 0;
        internal static int NoOfPolysSelected = 0;

        internal struct PolyType
        {
            public string Name;
            public string Type;
            public Color Color;
            public string Guid;
            public string Texture;
            public int TerrainIndex;
        }

        internal static PolyType[] PolyTypes;
        internal static int NoOfPolyTypes;
        internal static Point[] PTS;
        internal static GPoly[] Polys;
        internal static GPoly NewPoly;
        internal static double DefaultPolyAltitude;
        internal static string ParticularExcludeGUID;

        // these are read from Polys.TXT
        internal static string DefaultPolyNoneGuid;
        internal static string DefaultPolyFS9Guid;
        internal static string DefaultPolyGPSGuid;

        // Friend PolyTexPath As String
        internal static string PolyTex;
        internal static int PolyTexIndex;
        internal static string PolyTexString;

        // Private OtherN1 As Integer
        // Private OtherN2 As Integer
        // Private OtherN3 As Integer
        // Private OtherN4 As Integer

        // Friend HideOtherPolys As Boolean

        internal static bool MakeClosedLineFromPoly;
        internal static int CheckPoly;
        internal static int CheckPolyPt;
        internal static bool PolyON;
        internal static bool PolyVIEW;
        internal static bool PolyFILL;
        internal static Color DefaultPolyColor;
        internal static Color PolyColorBorder;
        internal static int PolyPenWidth;

        // Friend PolyTexPath As String


        // Friend PolyFlattenColor As Integer
        // Friend PolyWaterColor As Integer
        // Friend PolyLandColor As Integer
        // Friend PolyExcludeColor As Integer

        internal static void PolyInsertMode(ref short Button, ref short Shift, int X, int Y)
        {
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

                if (PtPolyCounter > 0)   // start Poly creation begun earlier
                {
                    BuildPoly(X, ref Y);
                }
                else     // the first click
                {
                    My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                    My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                    // SHIFT IS DOWN!
                    if (Shift == 1)
                    {
                        if (IsPointInPoly(X, Y))  // did we add a point to the selection
                        {
                            moduleMAIN.SomeSelected = true;
                            moduleMAIN.RebuildDisplay();    // start the movement of the point and the rest
                            moduleMAIN.SetDelay(200);
                            moduleMAIN.MoveON = true;
                            moduleMAIN.FirstMOVE = true;
                            moduleMAIN.AuxXInt = X;
                            moduleMAIN.AuxYInt = Y;
                            return;
                        }  // did we add a poly to the selection

                        if (IsPolySelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y))
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
                    moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsPointInPoly(X, Y);
                    if (moduleMAIN.SomeSelected)  // was a point selected?
                    {
                        if (moduleMAIN.DeleteON)
                        {
                            DeleteSelectedPointsInPolys();
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
                    else  // is InsertON true and we clicked on a segment of a Poly?
                    {
                        moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsInsertPointInPoly(X, Y);
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
                        else                    // did we selected a Poly?
                        {
                            moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsPolySelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y);
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
                            else   // no!!! so this is the start of the creation of a new Poly
                            {
                                moduleEDIT.BackUp();
                                moduleMAIN.RebuildDisplay();
                                BuildPoly(X, ref Y);
                            }
                        }
                    }
                }
            }

            if (Button == 2)
            {
                EndPoly(X, Y);
                moduleMAIN.RebuildDisplay();
            }
        }

        internal static void BuildPoly(int X, ref int Y)
        {

            // this looks to the number of clicks (in PtPolyCounter)
            // if PtPolyCounter = 0 it is the first click
            // if PtPolyCounter => 2 a new point is added to PTS()

            double Lat, Lon;
            Lat = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            Lon = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            if (PtPolyCounter == 0)
            {
                bool argFlag = false;
                SelectAllPolys(ref argFlag);
                NoOfPolysSelected = 0;
                AuxLatPoly = Lat;
                AuxLonPoly = Lon;
                PtPolyCounter = 2;
                return;
            }

            if (PtPolyCounter == 2)
            {
                PtPolyCounter = 3;
                NewPoly.GPoints = new modulePOINTS.GPoint[3];
                NewPoly.NoOfPoints = 2;
                NewPoly.Color = DefaultPolyColor;
                NewPoly.Selected = false;
                NewPoly.GPoints[1].lat = AuxLatPoly;
                NewPoly.GPoints[1].lon = AuxLonPoly;
                NewPoly.GPoints[1].alt = DefaultPolyAltitude;
                NewPoly.GPoints[1].Selected = false;
                NewPoly.GPoints[2].lat = Lat;
                NewPoly.GPoints[2].lon = Lon;
                NewPoly.GPoints[2].alt = DefaultPolyAltitude;
                NewPoly.GPoints[2].Selected = false;
                AuxLatPoly = Lat;
                AuxLonPoly = Lon;
                return;
            }

            // PtPolyCounter is > 2

            AuxLatPoly = Lat;
            AuxLonPoly = Lon;
            Array.Resize(ref NewPoly.GPoints, PtPolyCounter + 1);
            NewPoly.GPoints[PtPolyCounter].lat = Lat;
            NewPoly.GPoints[PtPolyCounter].lon = Lon;
            NewPoly.GPoints[PtPolyCounter].alt = DefaultPolyAltitude;
            NewPoly.GPoints[PtPolyCounter].Selected = false;
            NewPoly.NoOfPoints = PtPolyCounter;
            PtPolyCounter = PtPolyCounter + 1;
        }

        internal static void EndPoly(int X, int Y)
        {
            if (PtPolyCounter == 0)
            {
                modulePOPUP.ProcessPopUp(X, Y);
                return;
            }

            if (PtPolyCounter == 2)
            {
                PtPolyCounter = 0;
                return;
            }

            // ok, create the Poly!
            PtPolyCounter = 0;
            NoOfPolys = NoOfPolys + 1;
            Array.Resize(ref Polys, NoOfPolys + 1);
            Polys[NoOfPolys] = NewPoly;
            Polys[NoOfPolys].Name = Conversion.Str(Polys[NoOfPolys].NoOfPoints) + "_Pts_Polygon_of_Type_None";
            Polys[NoOfPolys].Guid = DefaultPolyNoneGuid;
            Polys[NoOfPolys].NoOfChilds = 0;
            moduleMAIN.Dirty = true;
            if (NoOfPolys > 1 & moduleLINES.AutoLinePolyJoin)
            {
                if (TryThisPolyJoin(NoOfPolys))
                {
                    Interaction.Beep();
                    AddLatLonToPoly(NoOfPolys);
                    return;
                }
            }

            AddLatLonToPoly(NoOfPolys);
            modulePOPUP.HidePopUPMenu();
        }

        internal static void AddLatLonToPoly(int N)
        {
            int K;
            double EL, SL, NL, WL, x;
            NL = -90;
            SL = 90d;
            EL = -180;
            WL = 180d;
            var loopTo = Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
            {
                x = Polys[N].GPoints[K].lat;
                if (x < SL)
                    SL = x;
                if (x > NL)
                    NL = x;
                x = Polys[N].GPoints[K].lon;
                if (x > EL)
                    EL = x;
                if (x < WL)
                    WL = x;
            }

            Polys[N].ELON = EL;
            Polys[N].WLON = WL;
            Polys[N].NLAT = NL;
            Polys[N].SLAT = SL;
        }

        internal static void TryParentPoly(int X1, int Y1)
        {

            // this is called upon mouse down when SelectParent is ON.
            // it uses POPIndex which points to the polygon that we want 
            // to make a child. In April 2014, if there are also selected polygons 
            // in Poly mode we will try to make childs of the chosed
            // parent polygon

            int N, K;
            double X, Y;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;   // longitude in pixels
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1;  // latitude in pixels
            N = modulePOPUP.IsPolyUP(X, Y);  // N parent
            if (N == 0)
            {
                Interaction.MsgBox("You need to click on the border of a polygon!", MsgBoxStyle.Exclamation);
                return;
            }

            if (Polys[N].NoOfChilds < 0)
            {
                Interaction.MsgBox("The selected polygon is a hole!", MsgBoxStyle.Exclamation);
                return;
            }

            // OK we clicked on a good parent polygon  pointed by N

            double NLat, SLat, WLon, ELon;
            NLat = Polys[N].NLAT;
            SLat = Polys[N].SLAT;
            ELon = Polys[N].ELON;
            WLon = Polys[N].WLON;
            bool Flag = false;
            if (moduleMAIN.PointerON) // we just make a single hole
            {
                K = modulePOPUP.POPIndex;  // K  child
                if (N == K)
                {
                    Interaction.MsgBox("A polygon can not be an hole of itself!", MsgBoxStyle.Exclamation);
                    return;
                }

                if (NLat < Polys[modulePOPUP.POPIndex].NLAT)
                    Flag = true;
                if (SLat > Polys[modulePOPUP.POPIndex].SLAT)
                    Flag = true;
                if (ELon < Polys[modulePOPUP.POPIndex].ELON)
                    Flag = true;
                if (WLon > Polys[modulePOPUP.POPIndex].WLON)
                    Flag = true;
                if (Flag)
                {
                    Interaction.MsgBox("The selected polygon can not contain the hole!", MsgBoxStyle.Exclamation);
                    return;
                }

                MakePolyClockWise(N);
                MakePolyAntiClockWise(K);
                Polys[K].Guid = Polys[N].Guid;
                Polys[K].Type = Polys[N].Type;
                Polys[K].Color = Polys[N].Color;
                Polys[K].NoOfChilds = -N;
                Array.Resize(ref Polys[N].Childs, Polys[N].NoOfChilds + 1 + 1);
                Polys[N].NoOfChilds = Polys[N].NoOfChilds + 1;
                Polys[N].Childs[Polys[N].NoOfChilds] = K;
                moduleMAIN.RebuildDisplay();
                return;
            }

            // OK we will do bulk
            // make sure POPIndex is selected and the parent N deselected
            if (Polys[modulePOPUP.POPIndex].Selected == false)
                Polys[modulePOPUP.POPIndex].Selected = true;
            if (Polys[N].Selected == true)
                Polys[N].Selected = false;
            var OK = new bool[NoOfPolys + 1]; // if OK then polygon can be a child
            int NoOfOKs = 0;
            var loopTo = NoOfPolys;
            for (K = 1; K <= loopTo; K++)
            {
                OK[K] = false;
                if (Polys[K].Selected) // it is selected then is a candidate
                {
                    if (Polys[K].NoOfChilds == 0)  // it is not a hole nor it has childs
                    {
                        Flag = true;
                        if (NLat < Polys[K].NLAT)
                            Flag = false;
                        if (SLat > Polys[K].SLAT)
                            Flag = false;
                        if (ELon < Polys[K].ELON)
                            Flag = false;
                        if (WLon > Polys[K].WLON)
                            Flag = false;
                        if (Flag)
                        {
                            MakePolyAntiClockWise(K);
                            Polys[K].Guid = Polys[N].Guid;
                            Polys[K].Type = Polys[N].Type;
                            Polys[K].Color = Polys[N].Color;
                            Polys[K].NoOfChilds = -N;
                            OK[K] = true;
                            NoOfOKs = NoOfOKs + 1;
                        }
                    }
                }
            }

            MakePolyClockWise(N);
            Array.Resize(ref Polys[N].Childs, Polys[N].NoOfChilds + NoOfOKs + 1);
            var loopTo1 = NoOfPolys;
            for (K = 1; K <= loopTo1; K++)
            {
                if (OK[K])
                {
                    Polys[N].NoOfChilds = Polys[N].NoOfChilds + 1;
                    Polys[N].Childs[Polys[N].NoOfChilds] = K;
                }
            }

            moduleMAIN.RebuildDisplay();
        }

        internal static void SelectAllPolys(ref bool Flag)
        {
            int N, K;
            if (!PolyVIEW)
                return;
            if (Flag)
            {
                My.MyProject.Forms.FrmStart.SelectAllPolysMenuItem.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FrmStart.SelectAllPolysMenuItem.Checked = false;
            }

            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Flag)
                {
                    if (!Polys[N].Selected)
                        NoOfPolysSelected = NoOfPolysSelected + 1;
                    moduleMAIN.SomeSelected = true;
                }
                else if (Polys[N].Selected)
                    NoOfPolysSelected = NoOfPolysSelected - 1;
                var loopTo1 = Polys[N].NoOfPoints;
                for (K = 1; K <= loopTo1; K++)
                    Polys[N].GPoints[K].Selected = false;
                Polys[N].Selected = Flag;
            }
        }

        internal static void SelectInvertPolys()
        {
            int N, K;
            bool Flag;
            if (!PolyVIEW)
                return;
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Polys[N].Selected)
                {
                    NoOfPolysSelected = NoOfPolysSelected - 1;
                    Polys[N].Selected = false;
                    // unselect points ?
                    goto Jump_Next;
                }
                else
                {
                    Flag = false;
                    var loopTo1 = Polys[N].NoOfPoints;
                    for (K = 1; K <= loopTo1; K++)
                    {
                        if (Polys[N].GPoints[K].Selected)
                        {
                            Flag = true;
                            break;
                        }
                    }

                    if (Flag)
                        goto Jump_Next;
                    NoOfPolysSelected = NoOfPolysSelected + 1;
                    moduleMAIN.SomeSelected = true;
                    Polys[N].Selected = true;
                }

            Jump_Next:
                ;
            }
        }

        internal static void SelectPolysInBox(double X0, double Y0, double X1, double Y1)
        {
            int N;
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Polys[N].ELON < X1)
                {
                    if (Polys[N].WLON > X0)
                    {
                        if (Polys[N].SLAT > Y1)
                        {
                            if (Polys[N].NLAT < Y0)
                            {
                                if (!Polys[N].Selected)
                                    NoOfPolysSelected = NoOfPolysSelected + 1;
                                moduleMAIN.SomeSelected = true;
                                Polys[N].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        // Friend Sub DisplayPolys(ByVal gr As Graphics)

        // Dim X, Y As Integer
        // Dim Flag As Boolean

        // Dim K, N, NP As Integer
        // Dim A As String

        // Dim myPen As New System.Drawing.Pen(PolyColorBorder)
        // Dim myBrush As New System.Drawing.SolidBrush(Color.Yellow)

        // For N = 1 To NoOfPolys

        // If Not MoveON Then Polys(N).OnScreen = False

        // If Polys(N).NLAT < LatDispSouth Then GoTo skip_this_one
        // If Polys(N).SLAT > LatDispNorth Then GoTo skip_this_one
        // If Polys(N).WLON > LonDispEast Then GoTo skip_this_one
        // If Polys(N).ELON < LonDispWest Then GoTo skip_this_one

        // Polys(N).OnScreen = True

        // If HideOtherPolys Then
        // a = Left(Polys(N).Type, 1)
        // If a = "O" Then GoTo skip_this_one
        // End If

        // NP = Polys(N).NoOfPoints

        // Flag = False
        // ReDim PTS(NP - 1)
        // For K = 1 To NP
        // PTS(K - 1).X = CInt((Polys(N).GPoints(K).lon - LonDispWest) * PixelsPerLonDeg)
        // PTS(K - 1).Y = CInt((LatDispNorth - Polys(N).GPoints(K).lat) * PixelsPerLatDeg)
        // Flag = Flag Or Polys(N).GPoints(K).Selected
        // Next K

        // If PolyFILL Then
        // myBrush.Color = Polys(N).Color
        // gr.FillPolygon(myBrush, PTS)
        // End If
        // gr.DrawPolygon(myPen, PTS)


        // If Polys(N).Selected Then
        // myBrush.Color = SelectedLineColor
        // For K = 1 To NP
        // X = CInt((Polys(N).GPoints(K).lon - LonDispWest) * PixelsPerLonDeg)
        // Y = CInt((LatDispNorth - Polys(N).GPoints(K).lat) * PixelsPerLatDeg)
        // gr.FillRectangle(myBrush, X - 2, Y - 2, 4, 4)
        // Next K

        // ElseIf PolyON Or Flag Then
        // For K = 1 To NP
        // myBrush.Color = UnselectedPointColor
        // If Polys(N).GPoints(K).Selected Then myBrush.Color = SelectedLineColor
        // X = CInt((Polys(N).GPoints(K).lon - LonDispWest) * PixelsPerLonDeg)
        // Y = CInt((LatDispNorth - Polys(N).GPoints(K).lat) * PixelsPerLatDeg)
        // gr.FillRectangle(myBrush, X - 2, Y - 2, 4, 4)
        // Next K

        // End If

        // skip_this_one:
        // Next N

        // myPen.Dispose()
        // myBrush.Dispose()



        // End Sub

        internal static void DisplayPolys(Graphics gr)
        {
            int X, Y;
            bool Flag;
            int J, K, N, M, NC, NP;
            var myPen = new Pen(PolyColorBorder, PolyPenWidth);
            var myBrush = new SolidBrush(Color.Yellow);
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            int P1, P2;  // to draw the points
            P1 = 2;
            if (PolyPenWidth == 2)
                P1 = 3;
            P2 = 2 * P1;
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (!moduleMAIN.MoveON)
                    Polys[N].OnScreen = false;
                if (Polys[N].NLAT < moduleMAIN.LatDispSouth)
                    goto skip_this_one;
                if (Polys[N].SLAT > moduleMAIN.LatDispNorth)
                    goto skip_this_one;
                if (Polys[N].WLON > moduleMAIN.LonDispEast)
                    goto skip_this_one;
                if (Polys[N].ELON < moduleMAIN.LonDispWest)
                    goto skip_this_one;
                Polys[N].OnScreen = true;
                if (Polys[N].NoOfChilds < 0)
                    goto skip_fill;

                // Dim A As String
                // If HideOtherPolys Then
                // a = Left(Polys(N).Type, 1)
                // If a = "O" Then GoTo skip_this_one
                // End If

                NP = Polys[N].NoOfPoints;
                PTS = new Point[NP];
                var loopTo1 = NP;
                for (K = 1; K <= loopTo1; K++)
                {
                    PTS[K - 1].X = (int)((Polys[N].GPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                    PTS[K - 1].Y = (int)((moduleMAIN.LatDispNorth - Polys[N].GPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
                }

                path.Reset();
                path.AddLines(PTS);
                path.CloseFigure();
                if (Polys[N].NoOfChilds > 0)
                {
                    var loopTo2 = Polys[N].NoOfChilds;
                    for (J = 1; J <= loopTo2; J++)
                    {
                        M = Polys[N].Childs[J];
                        Polys[M].OnScreen = true;
                        NC = Polys[M].NoOfPoints;
                        PTS = new Point[NC];
                        var loopTo3 = NC;
                        for (K = 1; K <= loopTo3; K++)
                        {
                            PTS[K - 1].X = (int)((Polys[M].GPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                            PTS[K - 1].Y = (int)((moduleMAIN.LatDispNorth - Polys[M].GPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
                        }

                        path.AddLines(PTS);
                        path.CloseFigure();
                    }
                }

                if (PolyFILL)
                {
                    myBrush.Color = Polys[N].Color;
                    gr.FillPath(myBrush, path);
                }

                gr.DrawPath(myPen, path);
            skip_fill:
                ;
                NP = Polys[N].NoOfPoints;
                if (Polys[N].Selected)
                {
                    myBrush.Color = moduleLINES.SelectedLineColor;
                    var loopTo4 = NP;
                    for (K = 1; K <= loopTo4; K++)
                    {
                        X = (int)((Polys[N].GPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                        Y = (int)((moduleMAIN.LatDispNorth - Polys[N].GPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
                        gr.FillRectangle(myBrush, X - P1, Y - P1, P2, P2);
                    }
                }
                else
                {
                    Flag = false;
                    var loopTo5 = NP;
                    for (K = 1; K <= loopTo5; K++)
                    {
                        if (Polys[N].GPoints[K].Selected)
                        {
                            Flag = true;
                            break;
                        }
                    }

                    if (PolyON | Flag)
                    {
                        var loopTo6 = NP;
                        for (K = 1; K <= loopTo6; K++)
                        {
                            myBrush.Color = modulePOINTS.UnselectedPointColor;
                            if (Polys[N].GPoints[K].Selected)
                                myBrush.Color = moduleLINES.SelectedLineColor;
                            X = (int)((Polys[N].GPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                            Y = (int)((moduleMAIN.LatDispNorth - Polys[N].GPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
                            gr.FillRectangle(myBrush, X - P1, Y - P1, P2, P2);
                        }
                    }
                }

            skip_this_one:
                ;
            }

            gr.DrawPath(myPen, path);
            myPen.Dispose();
            myBrush.Dispose();
            path.Dispose();
        }

        internal static void DeletePointInPoly(int PL, int PT)
        {
            int P; // when they come here they have at least 3 points
            if (!moduleEDIT.SkipBackUp)
                moduleEDIT.BackUp();
            if (PT < Polys[PL].NoOfPoints)
            {
                var loopTo = Polys[PL].NoOfPoints - 1;
                for (P = PT; P <= loopTo; P++)
                    Polys[PL].GPoints[P] = Polys[PL].GPoints[P + 1];
            }

            Array.Resize(ref Polys[PL].GPoints, Polys[PL].NoOfPoints);
            Polys[PL].NoOfPoints = Polys[PL].NoOfPoints - 1;
            moduleMAIN.Dirty = true;
        }

        internal static void DeletePoly(int N)
        {
            int K, J, P, C, D;
            if (Polys[N].Selected)
                NoOfPolysSelected = NoOfPolysSelected - 1;
            if (!moduleEDIT.SkipBackUp)
                moduleEDIT.BackUp();

            // check all that are childs and set the index of parent
            var loopTo = NoOfPolys;
            for (K = 1; K <= loopTo; K++)
            {
                if (Polys[K].NoOfChilds < 0)
                {
                    P = -Polys[K].NoOfChilds;
                    if (P == N)
                    {
                        Polys[K].NoOfChilds = 0;
                    }
                    else if (P > N)
                    {
                        Polys[K].NoOfChilds = Polys[K].NoOfChilds + 1;
                    }
                }
            }

            // check all that are parents and set the index of childs
            var loopTo1 = NoOfPolys;
            for (K = 1; K <= loopTo1; K++)
            {
                if (Polys[K].NoOfChilds > 0)
                {
                    D = 0;
                    var loopTo2 = Polys[K].NoOfChilds;
                    for (J = 1; J <= loopTo2; J++)
                    {
                        C = Polys[K].Childs[J];
                        if (C == N)
                        {
                            D = J;
                        }
                        else if (C > N)
                        {
                            Polys[K].Childs[J] = Polys[K].Childs[J] - 1;
                        }
                    }

                    if (D > 0)
                        DeleteThisChild(K, D);
                }
            }

            if (N < NoOfPolys)
            {
                var loopTo3 = NoOfPolys - 1;
                for (K = N; K <= loopTo3; K++)
                    Polys[K] = Polys[K + 1];
            }

            if (NoOfPolys > 1)
            {
                Array.Resize(ref Polys, NoOfPolys);
            }

            NoOfPolys = NoOfPolys - 1;
            moduleMAIN.Dirty = true;
        }

        internal static void DeleteThisChild(int P, int C)
        {
            int N;
            if (C < Polys[P].NoOfChilds)
            {
                var loopTo = Polys[P].NoOfChilds - 1;
                for (N = C; N <= loopTo; N++)
                    Polys[P].Childs[N] = Polys[P].Childs[N + 1];
            }

            if (Polys[P].NoOfChilds > 1)
            {
                Array.Resize(ref Polys[P].Childs, Polys[P].NoOfChilds);
            }

            Polys[P].NoOfChilds = Polys[P].NoOfChilds - 1;
        }

        internal static void DeleteParentAndChilds(int N)
        {
            int K;
            Polys[N].Guid = "Delete!";
            var loopTo = Polys[N].NoOfChilds;
            for (K = 1; K <= loopTo; K++)
                Polys[Polys[N].Childs[K]].Guid = "Delete!";
            for (K = NoOfPolys; K >= 1; K -= 1)
            {
                if (Polys[K].Guid == "Delete!")
                {
                    DeletePoly(K);
                }
            }
        }

        internal static void DeleteSelectedPolys()
        {
            int N;
            for (N = NoOfPolys; N >= 1; N -= 1)
            {
                if (Polys[N].Selected)
                {
                    DeletePoly(N);
                }
            }
        }

        internal static void DeleteSelectedPointsInPolys()
        {
            int N, K;
            for (N = NoOfPolys; N >= 1; N -= 1)
            {
                for (K = Polys[N].NoOfPoints; K >= 1; K -= 1)
                {
                    if (Polys[N].GPoints[K].Selected)
                    {
                        if (Polys[N].NoOfPoints < 3)
                        {
                            DeletePoly(N);
                            moduleMAIN.Dirty = true;
                        }
                        else
                        {
                            DeletePointInPoly(N, K);
                        }
                    }
                }
            }
        }

        internal static bool IsInsertPointInPoly(int X1, int Y1)
        {
            bool IsInsertPointInPolyRet = default;

            // returns true if point was inserted

            bool retval;
            int N, K;
            double X, Y;
            IsInsertPointInPolyRet = false;
            if (moduleMAIN.InsertON == false)
                return IsInsertPointInPolyRet;
            if (!PolyVIEW)
                return IsInsertPointInPolyRet;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1;

            // check if we are over a Line
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                K = Polys[N].NoOfPoints;
                retval = modulePOINTS.IsPointInSegment(Polys[N].GPoints[1].lon, Polys[N].GPoints[1].lat, Polys[N].GPoints[K].lon, Polys[N].GPoints[K].lat, X, Y);
                K = 2;
                while (!(retval == true | K == Polys[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPointInSegment(Polys[N].GPoints[K - 1].lon, Polys[N].GPoints[K - 1].lat, Polys[N].GPoints[K].lon, Polys[N].GPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    IsInsertPointInPolyRet = true;
                    InsertPointInPoly(X, Y, N, K - 1);
                    return IsInsertPointInPolyRet;
                }
            }

            return IsInsertPointInPolyRet;
        }

        internal static int InsertPointInPoly(double X, double Y, int Poly, int Point)
        {
            int InsertPointInPolyRet = default;

            // returns 0 if insert fails or 1 if it inserts

            int N, K;
            double X1, Y1;
            X1 = X / moduleMAIN.PixelsPerLonDeg;
            Y1 = Y / moduleMAIN.PixelsPerLatDeg;
            InsertPointInPolyRet = 0;
            N = Polys[Poly].NoOfPoints;
            var loopTo = N;
            for (K = 1; K <= loopTo; K++)
            {
                if (Math.Abs(Polys[Poly].GPoints[K].lat - Y1) < moduleMAIN.D22Lat)
                {
                    if (Math.Abs(Polys[Poly].GPoints[K].lon - X1) < moduleMAIN.D22Lon)
                    {
                        return InsertPointInPolyRet;
                    }
                }
            }

            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            N = Polys[Poly].NoOfPoints + 1;
            Polys[Poly].NoOfPoints = N;
            Array.Resize(ref Polys[Poly].GPoints, N + 1);
            if (Point == 1)
                Point = N;
            var loopTo1 = Point;
            for (K = N - 1; K >= loopTo1; K -= 1)
                Polys[Poly].GPoints[K + 1] = Polys[Poly].GPoints[K];
            Polys[Poly].GPoints[Point].lat = Y1;
            Polys[Poly].GPoints[Point].lon = X1;
            Polys[Poly].GPoints[Point].Selected = true;
            InsertPointInPolyRet = 1;
            int N0, N2;
            double Z0, Z2;
            double X0, X2;
            double Y0, Y2;
            double XX;
            if (Point == N)
            {
                N0 = Point - 1;
                N2 = 1;
            }
            else
            {
                N0 = Point - 1;
                N2 = Point + 1;
            }

            Z0 = Polys[Poly].GPoints[N0].alt;
            Z2 = Polys[Poly].GPoints[N2].alt;
            if (Z2 == Z0)
            {
                Polys[Poly].GPoints[Point].alt = Z0;
                return InsertPointInPolyRet;
            }

            X0 = Polys[Poly].GPoints[N0].lon;
            X2 = Polys[Poly].GPoints[N2].lon;
            if (X0 != X2)
            {
                Y0 = X1 - X0;
                Y2 = X2 - X1;
                XX = X2 - X0;
                Y0 = 1d - Y0 / XX;
                Y2 = 1d - Y2 / XX;
                Polys[Poly].GPoints[Point].alt = Z0 * Y0 + Z2 * Y2;
                return InsertPointInPolyRet;
            }

            Y0 = Polys[Poly].GPoints[N0].lat;
            Y2 = Polys[Poly].GPoints[N2].lat;
            if (Y0 == Y2) // just in case!
            {
                Polys[Poly].GPoints[Point].alt = Z0;
                return InsertPointInPolyRet;
            }

            // last try!
            X0 = Y1 - Y0;
            X2 = Y2 - Y1;
            XX = Y2 - Y0;
            X0 = 1d - X0 / XX;
            X2 = 1d - X2 / XX;
            Polys[Poly].GPoints[Point].alt = Z0 * X0 + Z2 * X2;
            return InsertPointInPolyRet;
        }

        internal static bool IsPointInPoly(int X1, int Y1)
        {
            bool IsPointInPolyRet = default;


            // THIS HAS CHANGED - on entry X Y contain distance from center display in pixels
            // NOW Sept2006 - on entry X Y contain distance from the origin of the display in pixels

            int N, K;
            bool retval;
            double WLON, NLAT, SLAT, ELON;
            double X, Y;
            IsPointInPolyRet = false;
            if (!PolyVIEW)
                return IsPointInPolyRet;
            WLON = moduleMAIN.LonDispWest + (X1 + 5) / moduleMAIN.PixelsPerLonDeg;
            ELON = moduleMAIN.LonDispWest + (X1 - 5) / moduleMAIN.PixelsPerLonDeg;
            NLAT = moduleMAIN.LatDispNorth - (Y1 + 5) / moduleMAIN.PixelsPerLatDeg;
            SLAT = moduleMAIN.LatDispNorth - (Y1 - 5) / moduleMAIN.PixelsPerLatDeg;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;  // longitude in pixels
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1; // latitude in pixels
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Polys[N].Selected)
                    goto Jump_Next;
                if (WLON < Polys[N].WLON)
                    goto Jump_Next;
                if (ELON > Polys[N].ELON)
                    goto Jump_Next;
                if (SLAT < Polys[N].SLAT)
                    goto Jump_Next;
                if (NLAT > Polys[N].NLAT)
                    goto Jump_Next;
                K = 1;
                retval = false;
                while (!(retval == true | K == Polys[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPoint(Polys[N].GPoints[K].lon, Polys[N].GPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    if (Polys[N].GPoints[K - 1].Selected == false)
                        moduleMAIN.NoOfPointsSelected = moduleMAIN.NoOfPointsSelected + 1;
                    Polys[N].GPoints[K - 1].Selected = true;
                    IsPointInPolyRet = true;
                    return IsPointInPolyRet;
                }

            Jump_Next:
                ;
            }

            return IsPointInPolyRet;
        }

        internal static int IsMouseOnPoly(int X1, int Y1, ref int Pt)
        {
            int IsMouseOnPolyRet = default;

            // returns the first Poly that has the mouse over it! if none returns 0
            // on entry X Y contains mouse distance from origin of display in pixels
            // if poly was found then Pt returns 0 if not over a vertex or the index of a vertex

            int N, K;
            bool retval;
            double X, Y;
            Pt = 0;
            IsMouseOnPolyRet = 0;
            if (PolyVIEW == false)
                return IsMouseOnPolyRet;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1;
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Polys[N].OnScreen == false)
                    goto Jump_Next;
                K = 2;
                retval = false;
                while (!(retval == true | K == Polys[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPointInSegment(Polys[N].GPoints[K - 1].lon, Polys[N].GPoints[K - 1].lat, Polys[N].GPoints[K].lon, Polys[N].GPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    IsMouseOnPolyRet = N;
                    if (modulePOINTS.IsPoint(Polys[N].GPoints[K - 2].lon, Polys[N].GPoints[K - 2].lat, X, Y))
                    {
                        Pt = K - 2;
                        return IsMouseOnPolyRet;
                    }

                    if (modulePOINTS.IsPoint(Polys[N].GPoints[K - 1].lon, Polys[N].GPoints[K - 1].lat, X, Y))
                    {
                        Pt = K - 1;
                        return IsMouseOnPolyRet;
                    }

                    return IsMouseOnPolyRet;
                }

            Jump_Next:
                ;
            }

            return IsMouseOnPolyRet;
        }

        internal static bool IsPolySelected(double X, double Y)
        {
            bool IsPolySelectedRet = default;

            // X and Y come with pixels from earth center

            int N, K;
            bool retval;
            double WLON, NLAT, SLAT, ELON;
            IsPolySelectedRet = false;
            if (!PolyVIEW)
                return IsPolySelectedRet;
            WLON = (X + 5d) / moduleMAIN.PixelsPerLonDeg;
            ELON = (X - 5d) / moduleMAIN.PixelsPerLonDeg;
            NLAT = (Y - 5d) / moduleMAIN.PixelsPerLatDeg;
            SLAT = (Y + 5d) / moduleMAIN.PixelsPerLatDeg;
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (WLON < Polys[N].WLON)
                    goto Jump_Next;
                if (ELON > Polys[N].ELON)
                    goto Jump_Next;
                if (SLAT < Polys[N].SLAT)
                    goto Jump_Next;
                if (NLAT > Polys[N].NLAT)
                    goto Jump_Next;
                K = Polys[N].NoOfPoints;
                retval = modulePOINTS.IsPointInSegment(Polys[N].GPoints[1].lon, Polys[N].GPoints[1].lat, Polys[N].GPoints[K].lon, Polys[N].GPoints[K].lat, X, Y);
                K = 2;
                while (!(retval == true | K == Polys[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPointInSegment(Polys[N].GPoints[K - 1].lon, Polys[N].GPoints[K - 1].lat, Polys[N].GPoints[K].lon, Polys[N].GPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    if (Polys[N].Selected == false)
                        NoOfPolysSelected = NoOfPolysSelected + 1;
                    Polys[N].Selected = true;
                    var loopTo1 = Polys[N].NoOfPoints;
                    for (K = 1; K <= loopTo1; K++)
                    {
                        if (Polys[N].GPoints[K].Selected)
                            moduleMAIN.NoOfPointsSelected = moduleMAIN.NoOfPointsSelected - 1;
                        Polys[N].GPoints[K].Selected = false;
                    }

                    IsPolySelectedRet = true;
                    return IsPolySelectedRet;
                }

            Jump_Next:
                ;
            }

            return IsPolySelectedRet;
        }

        internal static void MoveSelectedPolys(double X, double Y)
        {
            int N, K, J, L;
            bool Flag = false;
            double X1, Y1;
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Polys[N].OnScreen)
                {
                    if (Polys[N].Selected)
                    {
                        if (Polys[N].NoOfChilds >= 0) // has not children
                        {
                            var loopTo1 = Polys[N].NoOfPoints;
                            for (K = 1; K <= loopTo1; K++)
                            {
                                Polys[N].GPoints[K].lat = Polys[N].GPoints[K].lat - Y;
                                Polys[N].GPoints[K].lon = Polys[N].GPoints[K].lon + X;
                            }

                            AddLatLonToPolyXY(N, X, Y);
                            // childs move with parents except if parent is selected
                            if (Polys[N].NoOfChilds > 0)
                            {
                                var loopTo2 = Polys[N].NoOfChilds;
                                for (K = 1; K <= loopTo2; K++)
                                {
                                    J = Polys[N].Childs[K];
                                    var loopTo3 = Polys[J].NoOfPoints;
                                    for (L = 1; L <= loopTo3; L++)
                                    {
                                        Polys[J].GPoints[L].lat = Polys[J].GPoints[L].lat - Y;
                                        Polys[J].GPoints[L].lon = Polys[J].GPoints[L].lon + X;
                                    }

                                    AddLatLonToPolyXY(J, X, Y);
                                }
                            }
                        }
                        else // if selected and child - test if it remains inside parent
                        {
                            J = -Polys[N].NoOfChilds; // Jth is the parent of child N
                            if (!Polys[J].Selected)  // parent not selected then move child
                            {
                                if (Polys[J].NLAT > Polys[N].NLAT - Y)
                                {
                                    if (Polys[J].SLAT < Polys[N].SLAT - Y)
                                    {
                                        if (Polys[J].WLON < Polys[N].WLON + X)
                                        {
                                            if (Polys[J].ELON > Polys[N].ELON + X)
                                            {
                                                // ok it can be moved
                                                var loopTo4 = Polys[N].NoOfPoints;
                                                for (L = 1; L <= loopTo4; L++)
                                                {
                                                    Polys[N].GPoints[L].lat = Polys[N].GPoints[L].lat - Y;
                                                    Polys[N].GPoints[L].lon = Polys[N].GPoints[L].lon + X;
                                                }

                                                AddLatLonToPolyXY(N, X, Y);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    else if (Polys[N].NoOfChilds >= 0) // if not selected check points movement
                                                       // is not children so move freely
                    {
                        Flag = false;
                        var loopTo5 = Polys[N].NoOfPoints;
                        for (K = 1; K <= loopTo5; K++)
                        {
                            if (Polys[N].GPoints[K].Selected)
                            {
                                Polys[N].GPoints[K].lat = Polys[N].GPoints[K].lat - Y;
                                Polys[N].GPoints[K].lon = Polys[N].GPoints[K].lon + X;
                                Flag = true;
                            }
                        }

                        if (Flag)
                            AddLatLonToPoly(N);
                    }
                    else  // is child
                    {
                        J = -Polys[N].NoOfChilds; // Jth is the parent of child N
                        if (!Polys[J].Selected)
                        {
                            Flag = false;
                            var loopTo6 = Polys[N].NoOfPoints;
                            for (K = 1; K <= loopTo6; K++)
                            {
                                if (Polys[N].GPoints[K].Selected)
                                {
                                    Y1 = Polys[N].GPoints[K].lat - Y;
                                    X1 = Polys[N].GPoints[K].lon + X;
                                    if (Y1 < Polys[J].NLAT)
                                    {
                                        if (Y1 > Polys[J].SLAT)
                                        {
                                            Polys[N].GPoints[K].lat = Y1;
                                            Flag = true;
                                        }
                                    }

                                    if (X1 < Polys[J].ELON)
                                    {
                                        if (X1 > Polys[J].WLON)
                                        {
                                            Polys[N].GPoints[K].lon = X1;
                                            Flag = true;
                                        }
                                    }
                                }
                            }

                            if (Flag)
                                AddLatLonToPoly(N);
                        }
                    }
                }
            }

            moduleMAIN.Dirty = true;
        }

        private static void AddLatLonToPolyXY(int N, double X, double Y)
        {
            Polys[N].NLAT = Polys[N].NLAT - Y;
            Polys[N].SLAT = Polys[N].SLAT - Y;
            Polys[N].ELON = Polys[N].ELON + X;
            Polys[N].WLON = Polys[N].WLON + X;
        }

        internal static void CheckPolyJoins()
        {
            int N, N1;
            moduleEDIT.BackUp();
            moduleEDIT.SkipBackUp = true;
            N1 = 1;
        Return_back:
            ;
            N = N1;
            while (N <= NoOfPolys)
            {
                if (Polys[N].Selected)
                {
                    if (TryThisPolyJoin(N))
                        goto Return_back;
                }

                N = N + 1;
                N1 = N;
            }

            moduleEDIT.SkipBackUp = false;

            // comentei e descomentei pois nгo percebi pq!!!
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Polys[N].GPoints[1].Selected)
                {
                    if (TryThisPolyJoin(N))
                        return;
                }

                if (Polys[N].GPoints[Polys[N].NoOfPoints].Selected)
                {
                    if (TryThisPolyJoin(N))
                        return;
                }
            }
        }

        internal static void TryAllPolyJoin()
        {
            int N, K;
            var Done = new bool[NoOfPolys + 1];
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
                MakePolyClockWise(N);
            jump_here:
            ;
            var loopTo1 = NoOfPolys;
            for (N = 1; N <= loopTo1; N++)
            {
                if (Done[N])
                    goto next_n;
                if (N > NoOfPolys - 1)
                    goto end_here;
                if (Polys[N].Selected)
                {
                    var loopTo2 = NoOfPolys;
                    for (K = N + 1; K <= loopTo2; K++)
                    {
                        if (K > NoOfPolys)
                            break;
                        if (Polys[K].Selected)
                        {
                            if (Try2PolyJoin(N, K))
                            {
                                goto jump_here;
                            }

                            if (Try2PolyJoin(K, N))
                            {
                                goto jump_here;
                            }
                        }
                    }
                }

                Done[N] = true;
            next_n:
                ;
            }

            Done = new bool[1];
        end_here:
            ;
            var loopTo3 = NoOfPolys;
            for (N = 1; N <= loopTo3; N++)
            {
                if (Polys[N].Selected)
                {
                    CleanPoly(N);
                }
            }
        }

        private static bool Try2PolyJoin(int N1, int N2)
        {
            bool Try2PolyJoinRet = default;
            int M = default, N, NX;
            int K1, K, K2;
            int N1T, N2T;
            int N2B, N1B, N1A, N2A, NT;
            int Flag;
            bool Common;
            modulePOINTS.GPoint[] Pts;
            moduleMAIN.Double_XY X1;
            double DeltaLat, DeltaLon;
            Try2PolyJoinRet = false;
            if (moduleLINES.NameJoin)
            {
                if ((Polys[N1].Name ?? "") != (Polys[N2].Name ?? ""))
                    return Try2PolyJoinRet;
            }

            if (moduleLINES.DisplayJoin)
            {
                DeltaLon = 3d / moduleMAIN.PixelsPerLonDeg;
                DeltaLat = 3d / moduleMAIN.PixelsPerLatDeg;
            }
            else
            {
                DeltaLon = moduleMAIN.D255Lon;
                DeltaLat = moduleMAIN.D255Lat;
            }

            N1T = Polys[N1].NoOfPoints;
            N2T = Polys[N2].NoOfPoints;
            var loopTo = N1T;
            for (N = 1; N <= loopTo; N++)
            {
                Common = false;
                X1.Y = Polys[N1].GPoints[N].lat;
                X1.X = Polys[N1].GPoints[N].lon;
                var loopTo1 = N2T;
                for (M = 1; M <= loopTo1; M++)
                {
                    if (Math.Abs(X1.Y - Polys[N2].GPoints[M].lat) < DeltaLat)
                    {
                        if (Math.Abs(X1.X - Polys[N2].GPoints[M].lon) < DeltaLon)
                        {
                            Common = true;
                            break;
                        }
                    }
                }

                if (!Common)
                    break;
            }

            N1A = N;  // 1st point in N1 that is not commom to some point in N2
            if (N1A > N1T)
            {
                // MsgBox("Polygons can not be joined!", 16)
                return Try2PolyJoinRet;
            }

            if (N1A > 1)
                CyclePoly(N1, N1A);

            // now Point 1 is not on the common part!
            // ======================================

            Flag = 0;
        Return_Here:
            ;
            Flag = Flag + 1;
            var loopTo2 = N1T;
            for (N = 1; N <= loopTo2; N++)
            {
                var loopTo3 = N2T;
                for (M = 1; M <= loopTo3; M++)
                {
                    if (Math.Abs(Polys[N1].GPoints[N].lat - Polys[N2].GPoints[M].lat) < DeltaLat)
                    {
                        if (Math.Abs(Polys[N1].GPoints[N].lon - Polys[N2].GPoints[M].lon) < DeltaLon)
                            goto jump_here;
                    }
                }
            }

        jump_here:
            ;
            N1A = N;   // 1st point in N1 that is common
            N2A = M;   // M is common to N
            if (N1A >= N1T)
            {
                // MsgBox("Polygons can not be joined!", 16)
                return Try2PolyJoinRet;
            }

            if (N1A == 1)
            {
                // MsgBox("Fatal error in polygon " & N1 & "!", MsgBoxStyle.Critical)
                return Try2PolyJoinRet;
            }

            K1 = N1A;
            K2 = N2A;
            do
            {
                K1 = K1 + 1;
                K2 = K2 - 1;
                if (K1 > N1T)
                {
                    K1 = 1;
                }

                if (K2 < 1)
                {
                    K2 = N2T;
                }

                if (Math.Abs(Polys[N1].GPoints[K1].lat - Polys[N2].GPoints[K2].lat) > DeltaLat)
                {
                    N1B = K1 - 1;
                    N2B = K2 + 1;
                    break;
                }

                if (Math.Abs(Polys[N1].GPoints[K1].lon - Polys[N2].GPoints[K2].lon) > DeltaLon)
                {
                    N1B = K1 - 1;
                    N2B = K2 + 1;
                    break;
                }
            }
            while (true);
            if (N1B == 0)
                N1B = N1T;
            if (N2B == N2T + 1)
                N2B = 1;
            if (Flag == 1)
            {
                if (!(N2A == N2T))
                {
                    CyclePoly(N2, N2A + 1);
                    goto Return_Here;
                }
            }

            if (Flag == 2 & !(N2A == N2T))
                return Try2PolyJoinRet;
            NX = N1B - N1A;
            NX = 2 * NX;
            NT = N1T + N2T - NX;
            Pts = new modulePOINTS.GPoint[N1T + 1];
            var loopTo4 = N1T;
            for (K = 1; K <= loopTo4; K++)
            {
                Pts[K].lat = Polys[N1].GPoints[K].lat;
                Pts[K].lon = Polys[N1].GPoints[K].lon;
                Pts[K].alt = Polys[N1].GPoints[K].alt;
            }

            Polys[N1].NoOfPoints = NT;
            Polys[N1].GPoints = new modulePOINTS.GPoint[NT + 1];
            K = 1;
            var loopTo5 = N1A;
            for (M = 1; M <= loopTo5; M++)
            {
                Polys[N1].GPoints[K].lat = Pts[M].lat;
                Polys[N1].GPoints[K].lon = Pts[M].lon;
                Polys[N1].GPoints[K].alt = Pts[M].alt;
                K = K + 1;
            }

            var loopTo6 = N2B - 1;
            for (M = 1; M <= loopTo6; M++)
            {
                Polys[N1].GPoints[K].lat = Polys[N2].GPoints[M].lat;
                Polys[N1].GPoints[K].lon = Polys[N2].GPoints[M].lon;
                Polys[N1].GPoints[K].alt = Polys[N2].GPoints[M].alt;
                K = K + 1;
            }

            var loopTo7 = N1T;
            for (M = N1B; M <= loopTo7; M++)
            {
                Polys[N1].GPoints[K].lat = Pts[M].lat;
                Polys[N1].GPoints[K].lon = Pts[M].lon;
                Polys[N1].GPoints[K].alt = Pts[M].alt;
                K = K + 1;
            }

            AddLatLonToPoly(N1);
            DeletePoly(N2);
            Interaction.Beep();
            Try2PolyJoinRet = true;
            return Try2PolyJoinRet;
        }

        private static void CleanPoly(int N)
        {
            double PI_180 = moduleMAIN.PI / 180.0d;
            int K, NP;
            double D, UX, UY, VX, VY, X1, X2, X3, Y1, Y2, Y3;
        jump_here:
            ;
            NP = Polys[N].NoOfPoints - 1;
            var loopTo = NP;
            for (K = 2; K <= loopTo; K++)
            {
                X1 = Polys[N].GPoints[K - 1].lon;
                X2 = Polys[N].GPoints[K].lon;
                X3 = Polys[N].GPoints[K + 1].lon;
                Y1 = Polys[N].GPoints[K - 1].lat;
                Y2 = Polys[N].GPoints[K].lat;
                Y3 = Polys[N].GPoints[K + 1].lat;
                UX = X2 - X1;
                UY = Y2 - Y1;
                VX = X3 - X2;
                VY = Y3 - Y2;
                D = UX * VY - UY * VX;
                UX = UX * UX;
                UY = UY * UY;
                UX = UX + UY;
                UX = Math.Sqrt(UX);
                VX = VX * VX;
                VY = VY * VY;
                VX = VX + VY;
                VX = Math.Sqrt(VX);
                D = D / (UX * VX);
                D = Math.Abs(D);
                if (D < PI_180)
                {
                    if (Polys[N].NoOfPoints < 3)
                    {
                        DeletePoly(N);
                        moduleMAIN.Dirty = true;
                    }
                    else
                    {
                        DeletePointInPoly(N, K);
                    }

                    goto jump_here;
                }
            }
        }

        internal static bool TryThisPolyJoin(int N1)
        {
            bool TryThisPolyJoinRet = default;
            int N;
            TryThisPolyJoinRet = false;
            var loopTo = N1 - 1;
            for (N = 1; N <= loopTo; N++)
            {
                if (JoinPolys(N, N1))
                {
                    TryThisPolyJoinRet = true;
                    moduleMAIN.RebuildDisplay();
                    Interaction.Beep();
                    return TryThisPolyJoinRet;
                }
            }

            var loopTo1 = NoOfPolys;
            for (N = N1 + 1; N <= loopTo1; N++)
            {
                if (JoinPolys(N, N1))
                {
                    TryThisPolyJoinRet = true;
                    moduleMAIN.RebuildDisplay();
                    Interaction.Beep();
                    return TryThisPolyJoinRet;
                }
            }

            return TryThisPolyJoinRet;
        }

        private static bool JoinPolys(int N1, int N2)
        {
            bool JoinPolysRet = default;

            // ' different from JoinLines
            // ' JoinPolys returns True if the Polys are joined!

            int M = default, N, NX;
            int K1, K, K2;
            int N1T, N2T;
            int N2B, N1B, N1A, N2A, NT;
            int Flag;
            bool Common;
            double Lat, Lon;
            double DeltaLat, DeltaLon;
            GPoly myPoly;
            JoinPolysRet = false;
            if ((Polys[N1].Name ?? "") != (Polys[N2].Name ?? ""))
                return JoinPolysRet;
            if ((Polys[N1].Type ?? "") != (Polys[N2].Type ?? ""))
                return JoinPolysRet;
            if ((Polys[N1].Guid ?? "") != (Polys[N2].Guid ?? ""))
                return JoinPolysRet;

            try
            {
                if (moduleLINES.DisplayJoin)
                {
                    DeltaLon = 3d / moduleMAIN.PixelsPerLonDeg;
                    DeltaLat = 3d / moduleMAIN.PixelsPerLatDeg;
                }
                else
                {
                    DeltaLon = moduleMAIN.D255Lon;
                    DeltaLat = moduleMAIN.D255Lat;
                }

                N1T = Polys[N1].NoOfPoints;
                N2T = Polys[N2].NoOfPoints;
                MakePolyClockWise(N1);
                MakePolyClockWise(N2);


                // both polys are now clockwise!
                // ============================

                // this gets (in N) the index of the first point in poly N1
                // that does not coincide with any point in poly N2
                var loopTo = N1T;
                for (N = 1; N <= loopTo; N++)
                {
                    Common = false;
                    Lat = Polys[N1].GPoints[N].lat;
                    Lon = Polys[N1].GPoints[N].lon;
                    var loopTo1 = N2T;
                    for (M = 1; M <= loopTo1; M++)
                    {
                        if (Math.Abs(Lat - Polys[N2].GPoints[M].lat) < DeltaLat)
                        {
                            if (Math.Abs(Lon - Polys[N2].GPoints[M].lon) < DeltaLon)
                            {
                                Common = true;
                                break;
                            }
                        }
                    }

                    if (!Common)
                        break;
                }

                N1A = N;
                if (N1A > N1T)
                    return JoinPolysRet;
                if (N1A > 1)
                    CyclePoly(N1, N1A);

                // now Point 1 is not on the common part!
                // ======================================

                Flag = 0;
            Return_Here:
                ;
                Flag = Flag + 1;
                var loopTo2 = N1T;
                for (N = 1; N <= loopTo2; N++)
                {
                    var loopTo3 = N2T;
                    for (M = 1; M <= loopTo3; M++)
                    {
                        if (Math.Abs(Polys[N1].GPoints[N].lat - Polys[N2].GPoints[M].lat) < DeltaLat)
                        {
                            if (Math.Abs(Polys[N1].GPoints[N].lon - Polys[N2].GPoints[M].lon) < DeltaLon)
                                goto jump_here;
                        }
                    }
                }

            jump_here:
                ;
                N1A = N;
                N2A = M;
                if (N1A >= N1T)
                    return JoinPolysRet;
                if (N1A == 1)
                    return JoinPolysRet;
                K1 = N1A;
                K2 = N2A;
                do
                {
                    K1 = K1 + 1;
                    K2 = K2 - 1;
                    if (K1 > N1T)
                    {
                        K1 = 1;
                    }

                    if (K2 < 1)
                    {
                        K2 = N2T;
                    }

                    if (Math.Abs(Polys[N1].GPoints[K1].lat - Polys[N2].GPoints[K2].lat) > DeltaLat)
                    {
                        N1B = K1 - 1;
                        N2B = K2 + 1;
                        break;
                    }

                    if (Math.Abs(Polys[N1].GPoints[K1].lon - Polys[N2].GPoints[K2].lon) > DeltaLon)
                    {
                        N1B = K1 - 1;
                        N2B = K2 + 1;
                        break;
                    }
                }
                while (true);
                if (N1B == 0)
                    N1B = N1T;
                if (N2B >= N2A | N2B == 1)
                {
                    if (Flag > 2)
                        return JoinPolysRet;
                    CyclePoly(N2, N2A + 1);
                    goto Return_Here;
                }

                NX = N1B - N1A;
                NX = 2 * NX;
                NT = N1T + N2T - NX;

                // now copy poly N1 in myPoly
                myPoly.GPoints = new modulePOINTS.GPoint[N1T + 1];
                var loopTo4 = N1T;
                for (K = 1; K <= loopTo4; K++)
                {
                    myPoly.GPoints[K].lat = Polys[N1].GPoints[K].lat;
                    myPoly.GPoints[K].lon = Polys[N1].GPoints[K].lon;
                    myPoly.GPoints[K].alt = Polys[N1].GPoints[K].alt;
                }

                Polys[N1].NoOfPoints = NT;
                Polys[N1].GPoints = new modulePOINTS.GPoint[NT + 1];
                K = 1;
                var loopTo5 = N1A;
                for (M = 1; M <= loopTo5; M++)
                {
                    Polys[N1].GPoints[K].lat = myPoly.GPoints[M].lat;
                    Polys[N1].GPoints[K].lon = myPoly.GPoints[M].lon;
                    Polys[N1].GPoints[K].alt = myPoly.GPoints[M].alt;
                    K = K + 1;
                }

                var loopTo6 = N2T;
                for (M = N2A + 1; M <= loopTo6; M++)
                {
                    Polys[N1].GPoints[K].lat = Polys[N2].GPoints[M].lat;
                    Polys[N1].GPoints[K].lon = Polys[N2].GPoints[M].lon;
                    Polys[N1].GPoints[K].alt = Polys[N2].GPoints[M].alt;
                    K = K + 1;
                }

                var loopTo7 = N2B;
                for (M = 1; M <= loopTo7; M++)
                {
                    Polys[N1].GPoints[K].lat = Polys[N2].GPoints[M].lat;
                    Polys[N1].GPoints[K].lon = Polys[N2].GPoints[M].lon;
                    Polys[N1].GPoints[K].alt = Polys[N2].GPoints[M].alt;
                    K = K + 1;
                }

                var loopTo8 = N1T;
                for (M = N1B + 1; M <= loopTo8; M++)
                {
                    Polys[N1].GPoints[K].lat = myPoly.GPoints[M].lat;
                    Polys[N1].GPoints[K].lon = myPoly.GPoints[M].lon;
                    Polys[N1].GPoints[K].alt = myPoly.GPoints[M].alt;
                    K = K + 1;
                }

                Polys[N1].Selected = true;
                AddLatLonToPoly(N1);
                DeletePoly(N2);
                JoinPolysRet = true;
                moduleMAIN.Dirty = true;
            }
            catch (Exception exc)
            {
            }
            return JoinPolysRet;
        }

        private static void CyclePoly(int N, int N1)
        {
            int M, K, NP;
            GPoly myPoly;
            NP = Polys[N].NoOfPoints;
            myPoly.GPoints = new modulePOINTS.GPoint[NP + 1];
            var loopTo = NP;
            for (K = 1; K <= loopTo; K++)
            {
                myPoly.GPoints[K].lat = Polys[N].GPoints[K].lat;
                myPoly.GPoints[K].lon = Polys[N].GPoints[K].lon;
                myPoly.GPoints[K].alt = Polys[N].GPoints[K].alt;
            }

            M = 1;
            var loopTo1 = NP;
            for (K = N1; K <= loopTo1; K++)
            {
                Polys[N].GPoints[M].lat = myPoly.GPoints[K].lat;
                Polys[N].GPoints[M].lon = myPoly.GPoints[K].lon;
                Polys[N].GPoints[M].alt = myPoly.GPoints[K].alt;
                M = M + 1;
            }

            var loopTo2 = N1 - 1;
            for (K = 1; K <= loopTo2; K++)
            {
                Polys[N].GPoints[M].lat = myPoly.GPoints[K].lat;
                Polys[N].GPoints[M].lon = myPoly.GPoints[K].lon;
                Polys[N].GPoints[M].alt = myPoly.GPoints[K].alt;
                M = M + 1;
            }
        }

        internal static bool MakePolyClockWise(int P)
        {
            bool MakePolyClockWiseRet = default;

            // returns true if poly is modified

            int N, M, L, NP;
            double Lat, LatN;
            double DX1, X1, Y1, DY1;
            double DX2, X2, Y2, DY2;
            double Y3, X3, CP;
            int M1, M3;
            modulePOINTS.GPoint PT;
            MakePolyClockWiseRet = false;
            NP = Polys[P].NoOfPoints;

            // get southest point in M (if 2 then the right most)
            Lat = Polys[P].GPoints[1].lat;
            M = 1;
            var loopTo = NP;
            for (N = 2; N <= loopTo; N++)
            {
                LatN = Polys[P].GPoints[N].lat;
                if (LatN <= Lat)
                {
                    if (LatN < Lat)
                    {
                        M = N;
                        Lat = LatN;
                    }
                    else if (Polys[P].GPoints[N].lon > Polys[P].GPoints[M].lon)
                    {
                        M = N;
                        Lat = LatN;
                    }
                }
            }

            // form the vectors M-1>M  and M>M+1  (1>2 2>3)
            X2 = Polys[P].GPoints[M].lon;
            Y2 = Polys[P].GPoints[M].lat;
            if (M == 1)
            {
                M1 = NP;
            }
            else
            {
                M1 = M - 1;
            }

            X1 = Polys[P].GPoints[M1].lon;
            Y1 = Polys[P].GPoints[M1].lat;
            if (M == NP)
            {
                M3 = 1;
            }
            else
            {
                M3 = M + 1;
            }

            X3 = Polys[P].GPoints[M3].lon;
            Y3 = Polys[P].GPoints[M3].lat;

            // vector 1>2 in 1 and 2>3 in 2 then cross product in x3
            DX1 = X2 - X1;
            DY1 = Y2 - Y1;
            DX2 = X3 - X2;
            DY2 = Y3 - Y2;
            CP = DX1 * DY2 - DY1 * DX2;
            if (CP < 0d)
                return MakePolyClockWiseRet; // is already clock wise
            L = 0;
            // If CP = 0 Then      ' could be clockwise Horst email on 3 October
            while (CP == 0d & L < 4)
            {
                if (Y3 > Y1)
                {
                    X2 = X1;
                    Y2 = Y1;
                    M1 = M1 - 1;
                    if (M1 == 0)
                        M1 = NP;
                    X1 = Polys[P].GPoints[M1].lon;
                    Y1 = Polys[P].GPoints[M1].lat;
                }
                else if (Y1 > Y3)
                {
                    X2 = X3;
                    Y2 = Y3;
                    M3 = M3 + 1;
                    if (M3 > NP)
                        M3 = 1;
                    X3 = Polys[P].GPoints[M3].lon;
                    Y3 = Polys[P].GPoints[M3].lat;
                }
                else // =
                {
                    X2 = X1;
                    Y2 = Y1;
                    M1 = M1 - 1;
                    if (M1 == 0)
                        M1 = NP;
                    X1 = Polys[P].GPoints[M1].lon;
                    Y1 = Polys[P].GPoints[M1].lat;
                    M3 = M3 + 1;
                    if (M3 > NP)
                        M3 = 1;
                    X3 = Polys[P].GPoints[M3].lon;
                    Y3 = Polys[P].GPoints[M3].lat;
                }

                L = L + 1;    // this is a way to come out of the loop

                // recalculate CP cross product
                DX1 = X2 - X1;
                DY1 = Y2 - Y1;
                DX2 = X3 - X2;
                DY2 = Y3 - Y2;
                CP = DX1 * DY2 - DY1 * DX2;
                if (CP < 0d)
                    return MakePolyClockWiseRet; // is already clock wise
            }

            L = NP + 1;
            M = (int)Conversion.Int(L / 2d);
            var loopTo1 = M;
            for (N = 1; N <= loopTo1; N++)
            {
                PT = Polys[P].GPoints[N];
                Polys[P].GPoints[N] = Polys[P].GPoints[L - N];
                Polys[P].GPoints[L - N] = PT;
            }

            MakePolyClockWiseRet = true;
            return MakePolyClockWiseRet;
        }

        internal static void MakePolyAntiClockWise(int P)
        {
            int N, M, L, NP;
            double Lat, LatN;
            double DX1, X1, Y1, DY1;
            double DX2, X2, Y2, DY2;
            double Y3, X3, CP;
            int M1, M3;
            modulePOINTS.GPoint PT;
            NP = Polys[P].NoOfPoints;

            // get southest point in M (if 2 then the right most)
            Lat = Polys[P].GPoints[1].lat;
            M = 1;
            var loopTo = NP;
            for (N = 2; N <= loopTo; N++)
            {
                LatN = Polys[P].GPoints[N].lat;
                if (LatN <= Lat)
                {
                    if (LatN < Lat)
                    {
                        M = N;
                        Lat = LatN;
                    }
                    else if (Polys[P].GPoints[N].lon > Polys[P].GPoints[M].lon)
                    {
                        M = N;
                        Lat = LatN;
                    }
                }
            }

            // form the vectors M-1>M  and M>M+1  (1>2 2>3)
            X2 = Polys[P].GPoints[M].lon;
            Y2 = Polys[P].GPoints[M].lat;
            if (M == 1)
            {
                M1 = NP;
            }
            else
            {
                M1 = M - 1;
            }

            X1 = Polys[P].GPoints[M1].lon;
            Y1 = Polys[P].GPoints[M1].lat;
            if (M == NP)
            {
                M3 = 1;
            }
            else
            {
                M3 = M + 1;
            }

            X3 = Polys[P].GPoints[M3].lon;
            Y3 = Polys[P].GPoints[M3].lat;

            // vector 1>2 in 1 and 2>3 in 2 then cross product in x3
            DX1 = X2 - X1;
            DY1 = Y2 - Y1;
            DX2 = X3 - X2;
            DY2 = Y3 - Y2;
            CP = DX1 * DY2 - DY1 * DX2;
            if (CP > 0d)
                return; // is already anticlock wise
            L = 0;
            // If CP = 0 Then      ' could be clockwise Horst email on 3 October
            while (CP == 0d & L < 4)
            {
                if (Y3 > Y1)
                {
                    X2 = X1;
                    Y2 = Y1;
                    M1 = M1 - 1;
                    if (M1 == 0)
                        M1 = NP;
                    X1 = Polys[P].GPoints[M1].lon;
                    Y1 = Polys[P].GPoints[M1].lat;
                }
                else if (Y1 > Y3)
                {
                    X2 = X3;
                    Y2 = Y3;
                    M3 = M3 + 1;
                    if (M3 > NP)
                        M3 = 1;
                    X3 = Polys[P].GPoints[M3].lon;
                    Y3 = Polys[P].GPoints[M3].lat;
                }
                else // =
                {
                    X2 = X1;
                    Y2 = Y1;
                    M1 = M1 - 1;
                    if (M1 == 0)
                        M1 = NP;
                    X1 = Polys[P].GPoints[M1].lon;
                    Y1 = Polys[P].GPoints[M1].lat;
                    M3 = M3 + 1;
                    if (M3 > NP)
                        M3 = 1;
                    X3 = Polys[P].GPoints[M3].lon;
                    Y3 = Polys[P].GPoints[M3].lat;
                }

                L = L + 1; // this is a way to come out of the loop

                // recalculate CP cross product
                DX1 = X2 - X1;
                DY1 = Y2 - Y1;
                DX2 = X3 - X2;
                DY2 = Y3 - Y2;
                CP = DX1 * DY2 - DY1 * DX2;
                if (CP > 0d)
                    return; // is already anticlock wise
            }

            L = NP + 1;
            M = (int)Conversion.Int(L / 2d);
            var loopTo1 = M;
            for (N = 1; N <= loopTo1; N++)
            {
                PT = Polys[P].GPoints[N];
                Polys[P].GPoints[N] = Polys[P].GPoints[L - N];
                Polys[P].GPoints[L - N] = PT;
            }
        }

        internal static void CheckPolyMove(bool UP)
        {
            int L;
            Polys[CheckPoly].GPoints[CheckPolyPt].Selected = false;
            if (UP)
            {
                L = CheckPoly + 1;
                if (L == NoOfPolys + 1)
                    L = 1;
            }
            else
            {
                L = CheckPoly - 1;
                if (L == 0)
                    L = NoOfPolys;
            }

            CheckPoly = L;
            CheckPolyPt = 1;
            RefreshCheckPolyPt();
        }

        internal static void CheckPolyPtMove(bool UP)
        {
            int NP, P;
            NP = Polys[CheckPoly].NoOfPoints;
            Polys[CheckPoly].GPoints[CheckPolyPt].Selected = false;
            if (UP)
            {
                P = CheckPolyPt + 1;
                if (P > NP)
                    P = 1;
            }
            else
            {
                P = CheckPolyPt - 1;
                if (P == 0)
                    P = NP;
            }

            CheckPolyPt = P;
            RefreshCheckPolyPt();
        }

        internal static void DeleteCheckPolyPt()
        {
            if (Polys[CheckPoly].NoOfPoints < 4)
            {
                CheckPoly = 0;
                return;
            }

            DeletePointInPoly(CheckPoly, CheckPolyPt);
            if (CheckPolyPt > Polys[CheckPoly].NoOfPoints)
            {
                CheckPolyPt = Polys[CheckPoly].NoOfPoints;
            }

            RefreshCheckPolyPt();
        }

        private static void RefreshCheckPolyPt()
        {
            Polys[CheckPoly].GPoints[CheckPolyPt].Selected = true;
            moduleMAIN.LatDispCenter = Polys[CheckPoly].GPoints[CheckPolyPt].lat;
            moduleMAIN.LonDispCenter = Polys[CheckPoly].GPoints[CheckPolyPt].lon;
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
        }

        internal static void MakePolyTexString(int P, bool Reset_Renamed)
        {
            int N, NP;
            double x, y;
            int K, J;
            double LatMin, LonMin;
            double LatMax, LonMax;
            NP = Polys[P].NoOfPoints;

            // first checks if the number of points is less or equal than the ones
            // on the list in PolyTexString

            // but if Reset = True then forces Reset

            if (Reset_Renamed)
                goto reset_string;
            J = 1;
            var loopTo = NP;
            for (N = 1; N <= loopTo; N++)
            {
                K = Strings.InStr(J, PolyTexString, "//");
                if (K == 0)
                    goto reset_string;
                J = K + 2;
            }

            return;
        reset_string:
            ;
            PolyTexString = "";
            LatMin = 90d;
            LatMax = -90;
            LonMin = 180d;
            LonMax = -180;
            var loopTo1 = NP;
            for (N = 1; N <= loopTo1; N++)
            {
                x = Polys[P].GPoints[N].lat;
                if (x > LatMax)
                    LatMax = x;
                if (x < LatMin)
                    LatMin = x;
                x = Polys[P].GPoints[N].lon;
                if (x > LonMax)
                    LonMax = x;
                if (x < LonMin)
                    LonMin = x;
            }

            LatMax = LatMax - LatMin;
            LonMax = LonMax - LonMin;
            x = LonMax / LatMax;
            if (x >= 1d)
                x = 1d;
            x = x * 256.0d / LonMax;
            y = LatMax / LonMax;
            if (y >= 1d)
                y = 1d;
            y = y * 256.0d / LatMax;
            var loopTo2 = NP;
            for (N = 1; N <= loopTo2; N++)
            {
                K = (int)(x * (Polys[P].GPoints[N].lon - LonMin));
                PolyTexString = PolyTexString + K.ToString() + ",";
                K = (int)(y * (Polys[P].GPoints[N].lat - LatMin));
                PolyTexString = PolyTexString + K.ToString() + "//";
            }
        }

        internal static void MakeBGLTexLines(bool CopyBGLs)
        {
            int N;
            string A, B;
            bool IsStanding = false;
            bool IsLying = false;
            double H_NLat = -90;
            double H_SLat = 90d;
            double H_WLon = 180d;
            double H_ELon = -180;
            var loopTo = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (moduleLINES.Lines[N].Selected)
                {
                    A = moduleLINES.Lines[N].Type;
                    if (string.IsNullOrEmpty(A))
                        goto next_N0;
                    B = Strings.Mid(A, 1, 5);
                    if (B == "TEX|S")
                    {
                        IsStanding = true;
                    }
                    else if (B == "TEX|L")
                    {
                        IsLying = true;
                        if (moduleLINES.Lines[N].ELON > H_ELon)
                            H_ELon = moduleLINES.Lines[N].ELON;
                        if (moduleLINES.Lines[N].WLON < H_WLon)
                            H_WLon = moduleLINES.Lines[N].WLON;
                        if (moduleLINES.Lines[N].NLAT > H_NLat)
                            H_NLat = moduleLINES.Lines[N].NLAT;
                        if (moduleLINES.Lines[N].SLAT < H_SLat)
                            H_SLat = moduleLINES.Lines[N].SLAT;
                    }
                }

            next_N0:
                ;
            }

            if (IsLying)
                MakeBglLyingLines(CopyBGLs, H_NLat, H_SLat, H_WLon, H_ELon);
            if (IsStanding)
                MakeBglStandingLines(CopyBGLs);
        }

        private static double X_lat;
        private static double X_lon;

        private static void MakeBglStandingLines(bool CopyBGLs)
        {
            int N;
            string A, B, template, header, material, st;
            bool[] L;    // to indicate lines of this type
            L = new bool[moduleLINES.NoOfLines + 1];
            int Complex = 0;
            int Night = default, Tiled = default;
            string myFileBase = moduleMAIN.ProjectName + "_TESL";
            myFileBase = Strings.Replace(myFileBase, " ", "_");
            string myFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFileBase;
            string myFileXN;
            string myFileXLM = myFile + ".xml";
            var settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.GetEncoding(28591);
            settings.NewLineOnAttributes = true;
            var writer = XmlWriter.Create(myFileXLM, settings);
            writer.WriteStartDocument();
            writer.WriteComment("Created by SBuilderX on " + DateAndTime.Now);
            writer.WriteStartElement("FSData");
            writer.WriteAttributeString("version", "9.0");
            writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
            writer.WriteAttributeString("noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "bglcomp.xsd");
            writer.WriteComment("Standing Textured Lines FSX Models");
            header = "xof 0302txt 0032" + Constants.vbCrLf + Constants.vbCrLf + "// Direct3D X file created by SBuilderX on " + DateAndTime.Now.ToString() + Constants.vbCrLf + Constants.vbCrLf;
            template = My.MyProject.Computer.FileSystem.ReadAllText(My.MyProject.Application.Info.DirectoryPath + @"\tools\x_templates.txt");
            material = My.MyProject.Computer.FileSystem.ReadAllText(My.MyProject.Application.Info.DirectoryPath + @"\tools\x_material.txt");
            var loopTo = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                L[N] = false;
                if (moduleLINES.Lines[N].Selected)
                {
                    A = moduleLINES.Lines[N].Type;
                    if (string.IsNullOrEmpty(A))
                        goto next_N;
                    B = Strings.Mid(A, 1, 5);
                    if (B != "TEX|S")
                        goto next_N;
                    // Ok, go and get Tiled, Night Texture ....
                    L[N] = true;
                    Set_Tex_T_N_C(ref Tiled, ref Night, ref Complex, N);
                    var G = Guid.NewGuid();  // create a random Guid
                    string myGuid = G.ToString("B");
                    X_lat = (moduleLINES.Lines[N].NLAT + moduleLINES.Lines[N].SLAT) / 2d;
                    X_lon = (moduleLINES.Lines[N].ELON + moduleLINES.Lines[N].WLON) / 2d;
                    writer.WriteComment("Line # " + N.ToString());
                    writer.WriteStartElement("SceneryObject");
                    writer.WriteAttributeString("lat", Strings.Trim(Conversion.Str(X_lat)));
                    writer.WriteAttributeString("lon", Strings.Trim(Conversion.Str(X_lon)));
                    writer.WriteAttributeString("alt", "0");
                    writer.WriteAttributeString("altitudeIsAgl", Get_Is__AGL(N));
                    writer.WriteAttributeString("pitch", "0");
                    writer.WriteAttributeString("bank", "0");
                    writer.WriteAttributeString("heading", "0");
                    writer.WriteAttributeString("imageComplexity", GetComplex(Complex));
                    writer.WriteStartElement("LibraryObject");
                    writer.WriteAttributeString("name", myGuid);
                    writer.WriteAttributeString("scale", "1.0");
                    writer.WriteEndElement();
                    writer.WriteFullEndElement();
                    writer.WriteStartElement("ModelData");
                    writer.WriteAttributeString("sourceFile", myFileBase + N.ToString() + ".mdl");
                    writer.WriteEndElement();
                    myFileXN = myFile + N.ToString() + ".X";
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, header, false, Encoding.ASCII);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, template, true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, Make_X_Header(), true);
                    st = "GuidToName {" + Constants.vbCrLf;
                    st = st + "   \"" + myGuid + "\";" + Constants.vbCrLf;
                    st = st + "   \"StandingTexLine\";" + Constants.vbCrLf + "}" + Constants.vbCrLf + Constants.vbCrLf;
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, st, true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, Make_X_Frame(), true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, Make_X_Mesh(N), true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, Make_X_MaterialStart(N, Night), true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, material, true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, Make_X_MaterialEnd(Night), true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, Make_X_MeshNormals(N), true);
                    My.MyProject.Computer.FileSystem.WriteAllText(myFileXN, Make_X_MeshTextureCoords(N, Tiled), true);
                }

            next_N:
                ;
            }

            writer.WriteFullEndElement();
            writer.Close();
            FileSystem.ChDrive(My.MyProject.Application.Info.DirectoryPath);
            FileSystem.ChDir(My.MyProject.Application.Info.DirectoryPath + @"\tools\");

            // make the mdls from the X's
            var loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                if (L[N])
                {
                    A = @"XToMdl work\" + myFileBase + N.ToString() + ".X";
                    moduleMAIN.ExecCmd(A);
                }
            }

            // delete BGL File
            string BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFileBase + ".BGL";
            if (File.Exists(BGLFile))
                File.Delete(BGLFile);
            A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bglcomp.exe";
            B = @"work\" + myFileBase + ".xml";
            var myProcess = new Process();
            myProcess = Process.Start(A, B);
            myProcess.WaitForExit();
            myProcess.Dispose();
            if (!File.Exists(BGLFile))
            {
                A = "BGLComp could not produce the file" + Constants.vbCrLf + BGLFile + Constants.vbCrLf;
                A = A + @"Try to compile the file ..\tools\" + B + " in a MSDOS window" + Constants.vbCrLf;
                A = A + "to read the error report!";
                Interaction.MsgBox(A, MsgBoxStyle.Critical);
            }

            if (!CopyBGLs)
                return;
            try
            {
                A = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFileBase + ".BGL";
                if (File.Exists(A))
                {
                    File.Copy(A, moduleMAIN.BGLProjectFolder + @"\" + myFileBase + ".BGL", true);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Copying BGL files failed! Try to close FSX.", MsgBoxStyle.Exclamation);
            }
        }

        private static string Get_Is__AGL(int N)
        {
            string Get_Is__AGLRet = default;
            Get_Is__AGLRet = "TRUE";
            int K;
            var loopTo = moduleLINES.Lines[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
            {
                if (moduleLINES.Lines[N].GLPoints[K].alt != 0d)
                {
                    Get_Is__AGLRet = "FALSE";
                    return Get_Is__AGLRet;
                }
            }

            return Get_Is__AGLRet;
        }

        private static string Make_X_Header()
        {
            var A = new StringBuilder();
            A.AppendLine("Header {");
            A.AppendLine("   1;");
            A.AppendLine("   0;");
            A.AppendLine("   1;");
            A.AppendLine("}").AppendLine();
            return A.ToString();
        }

        private static string Make_X_Frame()
        {
            var A = new StringBuilder(200);
            A.AppendLine("Frame masterfrm {");
            A.AppendLine("FrameTransformMatrix {");
            A.AppendLine("   1.0, 0.0, 0.0, 0.0,");
            A.AppendLine("   0.0, 0.0, 1.0, 0.0,");
            A.AppendLine("   0.0, 1.0, 0.0, 0.0,");
            A.AppendLine("   0.0, 0.0, 0.0, 1.0;");
            A.AppendLine("}").AppendLine();
            return A.ToString();
        }

        private static string Make_X_MaterialStart(int L, int Night)
        {
            int P = 4 * (moduleLINES.Lines[L].NoOfPoints - 1);
            int N = Strings.InStr(PolyTex, ".");
            string @base = Strings.Mid(PolyTex, 1, N - 1);
            string ext = Strings.Mid(PolyTex, N);
            var A = new StringBuilder(500);
            A.AppendLine("MeshMaterialList {");
            A.AppendLine("1;");
            A.AppendLine("" + P.ToString() + ";");
            var loopTo = P;
            for (N = 2; N <= loopTo; N++)
                A.AppendLine("0,");
            A.AppendLine("0;");
            A.AppendLine("Material mat2 {");
            A.AppendLine("  1.000; 1.000; 1.000; 1.000;;");
            A.AppendLine("  0.000000;");
            A.AppendLine("  0.000; 0.000; 0.000;;");
            A.AppendLine("  0.000; 0.000; 0.000;;");
            A.AppendLine("  TextureFileName {");
            A.AppendLine("    \"" + @base + ext + "\";" + Constants.vbCrLf + "  }");
            A.AppendLine("  DiffuseTextureFileName  {");
            A.AppendLine("    \"" + @base + ext + "\";" + Constants.vbCrLf + "  }");
            if (Night == 1)
            {
                A.AppendLine("  EmissiveTextureFileName  {");
                A.AppendLine("    \"" + @base + "_lm" + ext + "\";" + Constants.vbCrLf + "  }");
            }

            return A.ToString();
        }

        private static string Make_X_MaterialEnd(int Night)
        {
            int N = Strings.InStr(PolyTex, ".");
            string @base = Strings.Mid(PolyTex, 1, N - 1);
            string ext = Strings.Mid(PolyTex, N);
            var A = new StringBuilder(200);
            A.AppendLine("    DiffuseTextureFileName  {");
            A.AppendLine("      \"" + @base + ext + "\";" + Constants.vbCrLf + "    }");
            if (Night == 1)
            {
                A.AppendLine("    EmissiveTextureFileName  {");
                A.AppendLine("      \"" + @base + "_lm" + ext + "\";" + Constants.vbCrLf + "    }");
            }

            A.AppendLine("  }" + Constants.vbCrLf + "}" + Constants.vbCrLf + "}" + Constants.vbCrLf);
            return A.ToString();
        }

        private static double X_MetPerDegLon;
        private static double X_MetPerDegLat;

        private static string Make_X_Mesh(int N)
        {
            int K, P;
            X_MetPerDegLon = moduleMAIN.MetersPerDegLon(X_lat);
            X_MetPerDegLat = moduleMAIN.MetersPerDegLat;
            string X = "";
            string Y = "";
            string ZL = "";
            string ZH = "";
            var A = new StringBuilder(32000);
            string B = "Mesh Part2 {" + Constants.vbCrLf;
            B = B + (8 * (moduleLINES.Lines[N].NoOfPoints - 1)).ToString() + ";" + Constants.vbCrLf;
            Make_X_XYZ(ref X, ref Y, ref ZL, ref ZH, N, 1);
            A.AppendLine(X + "; " + Y + "; " + ZH + ";,");
            A.AppendLine(X + "; " + Y + "; " + ZL + ";,");
            var loopTo = moduleLINES.Lines[N].NoOfPoints - 1;
            for (K = 2; K <= loopTo; K++)
            {
                Make_X_XYZ(ref X, ref Y, ref ZL, ref ZH, N, K);
                A.AppendLine(X + "; " + Y + "; " + ZL + ";,");
                A.AppendLine(X + "; " + Y + "; " + ZH + ";,");
                A.AppendLine(X + "; " + Y + "; " + ZH + ";,");
                A.AppendLine(X + "; " + Y + "; " + ZL + ";,");
            }

            Make_X_XYZ(ref X, ref Y, ref ZL, ref ZH, N, moduleLINES.Lines[N].NoOfPoints);
            A.AppendLine(X + "; " + Y + "; " + ZL + ";,");
            A.Append(X + "; " + Y + "; " + ZH);
            A.AppendLine(";," + Constants.vbCrLf + A.ToString() + ";;" + Constants.vbCrLf);
            A.Insert(0, B);
            P = 0;
            A.AppendLine((4 * (moduleLINES.Lines[N].NoOfPoints - 1)).ToString() + ";");
            var loopTo1 = moduleLINES.Lines[N].NoOfPoints - 1;
            for (K = 1; K <= loopTo1; K++)
            {
                A.AppendLine("3; " + P.ToString() + ", " + (P + 2).ToString() + ", " + (P + 1).ToString() + ";,");
                A.AppendLine("3; " + P.ToString() + ", " + (P + 3).ToString() + ", " + (P + 2).ToString() + ";,");
                P = P + 4;
            }

            var loopTo2 = moduleLINES.Lines[N].NoOfPoints - 2;
            for (K = 1; K <= loopTo2; K++)
            {
                A.AppendLine("3; " + P.ToString() + ", " + (P + 1).ToString() + ", " + (P + 2).ToString() + ";,");
                A.AppendLine("3; " + P.ToString() + ", " + (P + 2).ToString() + ", " + (P + 3).ToString() + ";,");
                P = P + 4;
            }

            A.AppendLine("3; " + P.ToString() + ", " + (P + 1).ToString() + ", " + (P + 2).ToString() + ";,");
            A.AppendLine("3; " + P.ToString() + ", " + (P + 2).ToString() + ", " + (P + 3).ToString() + ";;" + Constants.vbCrLf);
            return A.ToString();
        }

        private static string Make_X_MeshNormals(int N)
        {
            string X1 = "";
            string Z1 = "";
            string X2 = "";
            string Z2 = "";
            int K, P;
            string B = "";
            var A1 = new StringBuilder(48000);
            A1.AppendLine("MeshNormals {");
            A1.AppendLine((8 * (moduleLINES.Lines[N].NoOfPoints - 1)).ToString() + ";");
            var A2 = new StringBuilder(16000);
            var loopTo = moduleLINES.Lines[N].NoOfPoints - 2;
            for (K = 1; K <= loopTo; K++)
            {
                Make_X_XZN(ref X1, ref Z1, ref X2, ref Z2, N, K);
                B = X1 + "; " + Z1 + "; " + "0.000;,";
                A1.AppendLine(B).AppendLine(B).AppendLine(B).AppendLine(B);
                B = X2 + "; " + Z2 + "; " + "0.000;,";
                A2.AppendLine(B).AppendLine(B).AppendLine(B).AppendLine(B);
            }

            Make_X_XZN(ref X1, ref Z1, ref X2, ref Z2, N, moduleLINES.Lines[N].NoOfPoints - 1);
            B = X1 + "; " + Z1 + "; " + "0.000;,";
            A1.AppendLine(B).AppendLine(B).AppendLine(B).AppendLine(B);
            B = X2 + "; " + Z2 + "; " + "0.000;,";
            A2.AppendLine(B).AppendLine(B).AppendLine(B);
            A2.AppendLine(X2 + "; " + Z2 + "; " + "0.000;;");
            A1.AppendLine(A2.ToString());
            P = 0;
            A1.AppendLine((4 * (moduleLINES.Lines[N].NoOfPoints - 1)).ToString() + ";");
            var loopTo1 = moduleLINES.Lines[N].NoOfPoints - 1;
            for (K = 1; K <= loopTo1; K++)
            {
                A1.AppendLine("3; " + P.ToString() + ", " + (P + 2).ToString() + ", " + (P + 1).ToString() + ";,");
                A1.AppendLine("3; " + P.ToString() + ", " + (P + 3).ToString() + ", " + (P + 2).ToString() + ";,");
                P = P + 4;
            }

            var loopTo2 = moduleLINES.Lines[N].NoOfPoints - 2;
            for (K = 1; K <= loopTo2; K++)
            {
                A1.AppendLine("3; " + P.ToString() + ", " + (P + 1).ToString() + ", " + (P + 2).ToString() + ";,");
                A1.AppendLine("3; " + P.ToString() + ", " + (P + 2).ToString() + ", " + (P + 3).ToString() + ";,");
                P = P + 4;
            }

            A1.AppendLine("3; " + P.ToString() + ", " + (P + 1).ToString() + ", " + (P + 2).ToString() + ";,");
            A1.AppendLine("3; " + P.ToString() + ", " + (P + 2).ToString() + ", " + (P + 3).ToString() + ";;" + Constants.vbCrLf + "}" + Constants.vbCrLf);
            return A1.ToString();
        }

        private static string Make_X_MeshTextureCoords(int N, int Tiled)
        {
            int K;
            int NP = moduleLINES.Lines[N].NoOfPoints;
            float[] TU;
            TU = Make_TU_Tiling(N, Tiled);
            var A1 = new StringBuilder(48000);
            A1.AppendLine("MeshTextureCoords {");
            A1.AppendLine((8 * (moduleLINES.Lines[N].NoOfPoints - 1)).ToString() + ";");
            var A2 = new StringBuilder(16000);
            var loopTo = moduleLINES.Lines[N].NoOfPoints - 2;
            for (K = 1; K <= loopTo; K++)
            {
                A1.AppendLine(Format_TU(TU[K]) + "; 0.000;,");
                A1.AppendLine(Format_TU(TU[K]) + "; 1.000;,");
                A1.AppendLine(Format_TU(TU[K + 1]) + "; 1.000;,");
                A1.AppendLine(Format_TU(TU[K + 1]) + "; 0.000;,");
                A2.AppendLine(Format_TU(TU[K]) + "; 0.000;,");
                A2.AppendLine(Format_TU(TU[K]) + "; 1.000;,");
                A2.AppendLine(Format_TU(TU[K + 1]) + "; 1.000;,");
                A2.AppendLine(Format_TU(TU[K + 1]) + "; 0.000;,");
            }

            A1.AppendLine(Format_TU(TU[K]) + "; 0.000;,");
            A1.AppendLine(Format_TU(TU[K]) + "; 1.000;,");
            A1.AppendLine(Format_TU(TU[K + 1]) + "; 1.000;,");
            A1.AppendLine(Format_TU(TU[K + 1]) + "; 0.000;,");
            A2.AppendLine(Format_TU(TU[K]) + "; 0.000;,");
            A2.AppendLine(Format_TU(TU[K]) + "; 1.000;,");
            A2.AppendLine(Format_TU(TU[K + 1]) + "; 1.000;,");
            A2.AppendLine(Format_TU(TU[K + 1]) + "; 0.000;;");  // ;;
            A2.AppendLine("}").AppendLine("}").AppendLine("}");
            A1.AppendLine(A2.ToString());
            return A1.ToString();
        }

        private static string Format_TU(float X)
        {
            string Format_TURet = default;
            Format_TURet = Strings.Format(X, "0.000");
            Format_TURet = Strings.Replace(Format_TURet, ",", ".");
            return Format_TURet;
        }

        private static void Make_X_XYZ(ref string X, ref string Y, ref string H0, ref string H1, int N, int K)
        {
            double V = (moduleLINES.Lines[N].GLPoints[K].lon - X_lon) * X_MetPerDegLon;
            X = Strings.Format(V, "0.000");
            X = Strings.Replace(X, ",", ".");
            V = (moduleLINES.Lines[N].GLPoints[K].lat - X_lat) * X_MetPerDegLat;
            Y = Strings.Format(V, "0.000");
            Y = Strings.Replace(Y, ",", ".");
            V = moduleLINES.Lines[N].GLPoints[K].alt;
            H0 = Strings.Format(V, "0.000");
            H0 = Strings.Replace(H0, ",", ".");
            V = V + moduleLINES.Lines[N].GLPoints[K].wid;
            H1 = Strings.Format(V, "0.000");
            H1 = Strings.Replace(H1, ",", ".");
        }

        private static void Make_X_XZN(ref string X1, ref string Z1, ref string X2, ref string Z2, int N, int K)
        {
            double U = moduleLINES.Lines[N].GLPoints[K + 1].lon - moduleLINES.Lines[N].GLPoints[K].lon;
            double V = moduleLINES.Lines[N].GLPoints[K + 1].lat - moduleLINES.Lines[N].GLPoints[K].lat;
            double X = U * U + V * V;
            X = Math.Sqrt(X);
            U = U / X;   // normalize rotate clockwise
            V = V / X;
            X = U;
            U = V;   // rotate clockwise
            V = -X;
            X1 = Strings.Format(U, "0.000");
            X1 = Strings.Replace(X1, ",", ".");
            Z1 = Strings.Format(V, "0.000");
            Z1 = Strings.Replace(Z1, ",", ".");
            X2 = Strings.Format(-U, "0.000");
            X2 = Strings.Replace(X2, ",", ".");
            Z2 = Strings.Format(-V, "0.000");
            Z2 = Strings.Replace(Z2, ",", ".");
        }

        private static void Set_Tex_T_N_C(ref int Tiled, ref int Night, ref int Complex, int Line)
        {
            string A, B;
            int M;

            // sets global variable PolyTex

            A = Strings.Mid(moduleLINES.Lines[Line].Type, 14);   // TEX|Standing|   is removed
            M = Strings.InStr(1, A, "|");
            PolyTex = Strings.Mid(A, 1, M - 1);
            A = Strings.Mid(A, M + 1);
            M = Strings.InStr(1, A, "|");
            A = Strings.Mid(A, M + 1);
            M = Strings.InStr(1, A, "|");
            A = Strings.Mid(A, M + 1);
            M = Strings.InStr(1, A, "|");
            B = Strings.Mid(A, 1, M - 1);
            Complex = Conversions.ToInteger(B);
            A = Strings.Mid(A, M + 1);
            M = Strings.InStr(1, A, "|");
            B = Strings.Mid(A, 1, M - 1);
            Night = 0;
            if (Conversions.ToBoolean(B))
                Night = 1;
            A = Strings.Mid(A, M + 1, 1);
            Tiled = 0;
            if (A == "T")
                Tiled = 1;
            if (A == "F")
                Tiled = 2;
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

        private static void MakeBglLyingLines(bool CopyBGLs, double H_NLat, double H_SLat, double H_WLon, double H_ELon)
        {
            string myFile;
            string A, B;
            int M;
            int N;
            string Priority, Visibility, Complex;
            int Night, Tiled;
            moduleMAIN.Double_XYZ LZL;
            string Longitude, Latitude, Altitude;
            myFile = moduleMAIN.ProjectName + "_TELL";
            myFile = Strings.Replace(myFile, " ", "_");
            FileSystem.FileOpen(3, My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".scm", OpenMode.Output);
            A = "Header( 1 ";
            A = A + Conversion.Str(Conversion.Int(H_NLat + 1.5d)) + " ";
            A = A + Conversion.Str(Conversion.Int(H_SLat - 0.5d)) + " ";
            A = A + Conversion.Str(Conversion.Int(H_ELon + 1.5d)) + " ";
            A = A + Conversion.Str(Conversion.Int(H_WLon - 0.5d)) + " )";
            FileSystem.PrintLine(3, A);
            A = "LatRange( ";
            A = A + Conversion.Str(Conversion.Int(H_SLat - 0.5d)) + " ";
            A = A + Conversion.Str(Conversion.Int(H_NLat + 1.5d)) + " )";
            FileSystem.PrintLine(3, A);
            FileSystem.PrintLine(3);
            var loopTo = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                if (moduleLINES.Lines[N].Selected)
                {
                    A = moduleLINES.Lines[N].Type;
                    if (string.IsNullOrEmpty(A))
                        goto next_N;
                    B = Strings.Mid(A, 1, 5);
                    if (B != "TEX|L")
                        goto next_N;
                    A = Strings.Mid(A, 11);   // TEX|Lying|   is removed
                    M = Strings.InStr(1, A, "|");
                    PolyTex = Strings.Mid(A, 1, M - 1);
                    A = Strings.Mid(A, M + 1);
                    M = Strings.InStr(1, A, "|");
                    B = Strings.Mid(A, 1, M - 1);
                    Priority = Conversions.ToInteger(B).ToString();
                    A = Strings.Mid(A, M + 1);
                    M = Strings.InStr(1, A, "|");
                    B = Strings.Mid(A, 1, M - 1);
                    Visibility = Conversions.ToInteger(B).ToString();
                    A = Strings.Mid(A, M + 1);
                    M = Strings.InStr(1, A, "|");
                    B = Strings.Mid(A, 1, M - 1);
                    Complex = Conversions.ToInteger(B).ToString();
                    A = Strings.Mid(A, M + 1);
                    M = Strings.InStr(1, A, "|");
                    B = Strings.Mid(A, 1, M - 1);
                    Night = 0;
                    if (Conversions.ToBoolean(B))
                        Night = 1;
                    A = Strings.Mid(A, M + 1, 1);
                    Tiled = 0;
                    if (A == "T")
                        Tiled = 1;
                    MakePoly_0_FromLine(N);
                    LZL = GetLatZLonTexPoly(0);
                    AuxLatPoly = LZL.Y;
                    Latitude = Strings.Format(AuxLatPoly, "0.00000000");
                    AuxLonPoly = LZL.X;
                    Longitude = Strings.Format(AuxLonPoly, "0.00000000");
                    AuxZPoly = LZL.Z;
                    Altitude = Strings.Format(AuxZPoly, "0.00000000");
                    Latitude = Strings.Replace(Latitude, ",", ".");
                    Longitude = Strings.Replace(Longitude, ",", ".");
                    Altitude = Strings.Replace(Altitude, ",", ".");
                    Visibility = Strings.Replace(Visibility, ",", ".");
                    A = "; Textured Line #" + Conversion.Str(N) + Constants.vbCrLf + Constants.vbCrLf;
                    A = A + "Area( 5 ";
                    A = A + Latitude + " " + Longitude + " 50 )";
                    FileSystem.PrintLine(3, A);
                    A = "IfVarRange( : 346 " + Complex + " 5 )";
                    FileSystem.PrintLine(3, A);
                    A = "LayerCall( :lcall " + Priority + " )";
                    FileSystem.PrintLine(3, A);
                    A = "Jump( : )" + Constants.vbCrLf + ":lcall";
                    FileSystem.PrintLine(3, A);
                    A = "RefPoint( 2 :return 1 " + Latitude + " " + Longitude;
                    A = A + " E= " + Altitude + " v1= " + Visibility + " v2= " + GetV2(0) + " )";
                    FileSystem.PrintLine(3, A);
                    A = "BGLVersion( 0800 )";
                    FileSystem.PrintLine(3, A);
                    if (!string.IsNullOrEmpty(PolyTex))
                    {
                        A = FillTextureList(Night);
                        FileSystem.PrintLine(3, A);
                    }

                    A = FillMaterialList(0);
                    FileSystem.PrintLine(3, A);
                    A = FillVextexList_0(N, Tiled);
                    FileSystem.PrintLine(3, A);
                    if (!string.IsNullOrEmpty(PolyTex))
                    {
                        A = "SetMaterial( 0 0 )";
                    }
                    else
                    {
                        A = "SetMaterial( 0 -1 )";
                    }

                    FileSystem.PrintLine(3, A);
                    A = FillDrawTriList_0(N);
                    FileSystem.PrintLine(3, A);
                    A = "EndVersion";
                    FileSystem.PrintLine(3, A);
                    A = ":return" + Constants.vbCrLf + "Return" + Constants.vbCrLf + "EndA" + Constants.vbCrLf;
                    FileSystem.PrintLine(3, A);
                }

            next_N:
                ;
            }

            FileSystem.FileClose(3);

            // delete BGL file
            A = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".BGL";
            if (File.Exists(A))
                File.Delete(A);
            FileSystem.ChDrive(My.MyProject.Application.Info.DirectoryPath);
            FileSystem.ChDir(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            A = @"scasm work\" + myFile + ".scm -s -l";
            N = moduleMAIN.ExecCmd(A);
            if (N > 0)
            {
                A = "There was a compilation error in the textured" + Constants.vbCrLf;
                A = A + " lines! Do you want to read a SCASM report?";
                N = (int)Interaction.MsgBox(A, MsgBoxStyle.OkCancel);
                if (N == 1)
                {
                    A = "notepad SCAERROR.LOG";
                    N = moduleMAIN.ExecCmd(A);
                }

                return;
            }

            if (!CopyBGLs)
                return;
            try
            {
                A = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".BGL";
                if (File.Exists(A))
                {
                    File.Copy(A, moduleMAIN.BGLProjectFolder + @"\" + myFile + ".BGL", true);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Copying BGL files failed! Try to close FSX.", MsgBoxStyle.Exclamation);
            }
        }

        private static void MakePoly_0_FromLine(int N)
        {
            int P, M;
            double UX, UY, U, K;
            int NP = moduleLINES.Lines[N].NoOfPoints;
            var Line = new moduleMAIN.Double_XY[NP + 1];  // line in meter coordinates
            var loopTo = NP;
            for (P = 1; P <= loopTo; P++)
            {
                Line[P].X = moduleLINES.Lines[N].GLPoints[P].lon * moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                Line[P].Y = moduleLINES.Lines[N].GLPoints[P].lat * moduleMAIN.MetersPerDegLat;
            }

            var D1 = new moduleMAIN.Double_XY[NP + 1];
            var D2 = new moduleMAIN.Double_XY[NP + 1];
            double W;
            var loopTo1 = NP - 1;
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
                W = moduleLINES.Lines[N].GLPoints[P].wid / 2d;
                D2[P].X = UX * W;
                D2[P].Y = UY * W;
                W = moduleLINES.Lines[N].GLPoints[P + 1].wid / 2d;
                D1[P + 1].X = UX * W;
                D1[P + 1].Y = UY * W;
            }

            var PR1 = new moduleMAIN.Double_XY[NP + 1];   // right side
            var PR2 = new moduleMAIN.Double_XY[NP + 1];
            var PR = new moduleMAIN.Double_XY[NP + 1];
            var PL1 = new moduleMAIN.Double_XY[NP + 1];   // left side
            var PL2 = new moduleMAIN.Double_XY[NP + 1];
            var PL = new moduleMAIN.Double_XY[NP + 1];
            PL[1].X = Line[1].X - D2[1].Y;
            PL[1].Y = Line[1].Y + D2[1].X;
            PR[1].X = Line[1].X + D2[1].Y;
            PR[1].Y = Line[1].Y - D2[1].X;
            PL[NP].X = Line[NP].X - D1[NP].Y;
            PL[NP].Y = Line[NP].Y + D1[NP].X;
            PR[NP].X = Line[NP].X + D1[NP].Y;
            PR[NP].Y = Line[NP].Y - D1[NP].X;
            var loopTo2 = NP - 1;
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

            Polys[0].NoOfPoints = 2 * NP;
            Polys[0].Name = "0";
            Polys[0].Guid = "0";
            Polys[0].NoOfChilds = 0;
            Polys[0].Color = DefaultPolyColor;
            Polys[0].GPoints = new modulePOINTS.GPoint[2 * NP + 1];
            M = 1;
            var loopTo3 = NP;
            for (P = 1; P <= loopTo3; P++)
            {
                Polys[0].GPoints[M].lat = PL[P].Y / moduleMAIN.MetersPerDegLat;
                Polys[0].GPoints[M].lon = PL[P].X / moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                Polys[0].GPoints[M].alt = moduleLINES.Lines[N].GLPoints[P].alt;
                M = M + 1;
            }

            for (P = NP; P >= 1; P -= 1)
            {
                Polys[0].GPoints[M].lat = PR[P].Y / moduleMAIN.MetersPerDegLat;
                Polys[0].GPoints[M].lon = PR[P].X / moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                Polys[0].GPoints[M].alt = moduleLINES.Lines[N].GLPoints[P].alt;
                M = M + 1;
            }
        }

        private static string FillVextexList_0(int N, int Tiled)
        {
            string FillVextexList_0Ret = default;

            // Dim K, J As Integer
            // Dim NP As Integer = Lines(N).NoOfPoints
            // Dim TU(NP) As Single
            // Dim X, Y, Z As Double

            // If Tiled = 0 Then

            // For K = 1 To NP
            // TU(K) = CSng(K - 1)
            // Next

            // End If

            // If Tiled = 1 Then

            // Dim L(NP) As Double
            // L(1) = 0
            // Dim W As Double = Lines(N).GLPoints(1).wid
            // For K = 2 To NP
            // L(K) = L(K - 1) + GetDistanceP1P2(N, K - 1, K)
            // W = W + Lines(N).GLPoints(K).wid
            // Next
            // W = W / NP

            // Dim R As Double = GetImageRatio()

            // TU(1) = 0
            // For K = 2 To NP
            // X = L(K) - L(K - 1)
            // X = X / W
            // X = X / R
            // TU(K) = CSng(X) + TU(K - 1)
            // Next

            // End If


            int K, J;
            int NP = moduleLINES.Lines[N].NoOfPoints;
            double X, Y, Z;
            float[] TU;
            TU = Make_TU_Tiling(N, Tiled);
            string A;
            FillVextexList_0Ret = "VertexList( 0 " + Constants.vbCrLf;
            var loopTo = NP;
            for (K = 1; K <= loopTo; K++)
            {
                // the left side point
                A = "";
                X = (Polys[0].GPoints[K].lon - AuxLonPoly) * moduleMAIN.MetersPerDegLon(AuxLatPoly);
                if (X < 0d)
                    A = Strings.Format(X, "0000.0000") + " ";
                if (X >= 0d)
                    A = Strings.Format(X, " 0000.0000") + " ";
                Z = Polys[0].GPoints[K].alt - AuxZPoly;
                A = A + Strings.Format(Z, "0000.0000000") + " ";
                Y = (Polys[0].GPoints[K].lat - AuxLatPoly) * moduleMAIN.MetersPerDegLat;
                if (Y < 0d)
                    A = A + Strings.Format(Y, "0000.0000") + " 0.0 1.0 0.0 ";
                if (Y >= 0d)
                    A = A + Strings.Format(Y, " 0000.0000") + " 0.0 1.0 0.0 ";
                A = A + Strings.Format(TU[K], "00.000") + " " + Strings.Format(1, "00.000");
                A = Strings.Replace(A, ",", ".");
                A = A + " ; vertex #" + Strings.Format(2 * K - 2, "000");
                FillVextexList_0Ret = FillVextexList_0Ret + "      " + A + Constants.vbCrLf;
                // the right side point
                A = "";
                J = 2 * NP + 1 - K;
                X = (Polys[0].GPoints[J].lon - AuxLonPoly) * moduleMAIN.MetersPerDegLon(AuxLatPoly);
                if (X < 0d)
                    A = Strings.Format(X, "0000.0000") + " ";
                if (X >= 0d)
                    A = Strings.Format(X, " 0000.0000") + " ";
                Z = Polys[0].GPoints[J].alt - AuxZPoly;
                A = A + Strings.Format(Z, "0000.0000000") + " ";
                Y = (Polys[0].GPoints[J].lat - AuxLatPoly) * moduleMAIN.MetersPerDegLat;
                if (Y < 0d)
                    A = A + Strings.Format(Y, "0000.0000") + " 0.0 1.0 0.0 ";
                if (Y >= 0d)
                    A = A + Strings.Format(Y, " 0000.0000") + " 0.0 1.0 0.0 ";
                A = A + Strings.Format(TU[K], "00.000") + " " + Strings.Format(0, "00.000");
                A = Strings.Replace(A, ",", ".");
                A = A + " ; vertex #" + Strings.Format(2 * K - 1, "000");
                FillVextexList_0Ret = FillVextexList_0Ret + "      " + A + Constants.vbCrLf;
            }

            FillVextexList_0Ret = FillVextexList_0Ret + "       )";
            return FillVextexList_0Ret;
        }

        private static float[] Make_TU_Tiling(int N, int Tiled)
        {
            int K;
            int NP = moduleLINES.Lines[N].NoOfPoints;
            var TU = new float[NP + 1];
            double X;
            if (Tiled == 0)
            {
                var loopTo = NP;
                for (K = 1; K <= loopTo; K++)
                    TU[K] = K - 1;
            }

            if (Tiled > 0)
            {
                var L = new double[NP + 1];
                L[1] = 0d;
                double W = moduleLINES.Lines[N].GLPoints[1].wid;
                var loopTo1 = NP;
                for (K = 2; K <= loopTo1; K++)
                {
                    L[K] = L[K - 1] + GetDistanceP1P2(N, K - 1, K);
                    W = W + moduleLINES.Lines[N].GLPoints[K].wid;
                }

                W = W / NP;
                double R = GetImageRatio();
                TU[1] = 0f;
                var loopTo2 = NP;
                for (K = 2; K <= loopTo2; K++)
                {
                    X = L[K] - L[K - 1];
                    X = X / W;
                    X = X / R;
                    TU[K] = (float)X + TU[K - 1];
                }
            }

            if (Tiled == 2)
            {
                var loopTo3 = NP;
                for (K = 2; K <= loopTo3; K++)
                {
                    TU[K] = Conversion.Int(TU[K] + 0.5f);
                    if (TU[K] == TU[K - 1])
                        TU[K] = TU[K] + 1f;
                }
            }

            return TU;
        }

        private static double GetImageRatio()
        {
            double GetImageRatioRet = default;
            try
            {
                FileSystem.ChDrive(My.MyProject.Application.Info.DirectoryPath);
                FileSystem.ChDir(My.MyProject.Application.Info.DirectoryPath + @"\Tools\");
                string BmpPath = moduleMAIN.AppPath + @"\Tools\Work\temp.bmp";
                string TexPath = moduleMAIN.AppPath + @"\Texture\" + PolyTex;
                string ImageTool = @"imagetool -nowarning -nogui -nomip -8 Work\temp.bmp";
                File.Copy(TexPath, BmpPath, true);
                moduleMAIN.ExecCmd(ImageTool);
                var bmp = Image.FromFile(BmpPath);
                GetImageRatioRet = bmp.Width / (double)bmp.Height;
                bmp.Dispose();
            }
            catch (Exception ex)
            {
                GetImageRatioRet = 1d;
                Interaction.MsgBox("There is a problem with " + PolyTex, MsgBoxStyle.Critical);
            }

            return GetImageRatioRet;
        }

        private static string FillDrawTriList_0(int N)
        {
            string FillDrawTriList_0Ret = default;
            int NP = moduleLINES.Lines[N].NoOfPoints;
            int K, J;
            FillDrawTriList_0Ret = "DrawTriList( 0 " + Constants.vbCrLf + "       ";
            var loopTo = NP;
            for (K = 2; K <= loopTo; K++)
            {
                J = 2 * K;
                FillDrawTriList_0Ret = FillDrawTriList_0Ret + Strings.Format(J - 2, "000") + " ";
                FillDrawTriList_0Ret = FillDrawTriList_0Ret + Strings.Format(J - 4, "000") + " ";
                FillDrawTriList_0Ret = FillDrawTriList_0Ret + Strings.Format(J - 3, "000") + Constants.vbCrLf + "       ";
                FillDrawTriList_0Ret = FillDrawTriList_0Ret + Strings.Format(J - 3, "000") + " ";
                FillDrawTriList_0Ret = FillDrawTriList_0Ret + Strings.Format(J - 1, "000") + " ";
                FillDrawTriList_0Ret = FillDrawTriList_0Ret + Strings.Format(J - 2, "000") + Constants.vbCrLf + "       ";
            }

            FillDrawTriList_0Ret = FillDrawTriList_0Ret + ")";
            return FillDrawTriList_0Ret;
        }

        private static double GetDistanceP1P2(int line, int p1, int p2)
        {
            double GetDistanceP1P2Ret = default;
            double lat1 = moduleLINES.Lines[line].GLPoints[p1].lat;
            double lat2 = moduleLINES.Lines[line].GLPoints[p2].lat;
            double lon1 = moduleLINES.Lines[line].GLPoints[p1].lon;
            double lon2 = moduleLINES.Lines[line].GLPoints[p2].lon;
            double lat = (lat1 + lat2) / 2d;
            double DX = (lon1 - lon2) * moduleMAIN.MetersPerDegLon(lat);   // in meters pos or neg
            double DY = (lat1 - lat2) * moduleMAIN.MetersPerDegLat;
            DX = DX * DX + DY * DY;
            GetDistanceP1P2Ret = Math.Sqrt(DX);
            return GetDistanceP1P2Ret;
        }

        internal static void MakeBGLTexPolys(bool CopyBGLs)
        {
            string myFile;
            string b;
            int M;
            string a;
            int N;
            string Priority, Visibility;
            int TileY, TileX, Night;
            moduleMAIN.Double_XYZ LZL;
            string Longitude, Latitude, Altitude;
            double H_NLat = -90;
            double H_SLat = 90d;
            double H_WLon = 180d;
            double H_ELon = -180;
            var loopTo = NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (Polys[N].Selected)
                {
                    a = Polys[N].Type;
                    if (string.IsNullOrEmpty(a))
                        goto next_N0;
                    b = Strings.Mid(a, 1, 3);
                    if (b == "TEX")
                    {
                        if (Polys[N].ELON > H_ELon)
                            H_ELon = Polys[N].ELON;
                        if (Polys[N].WLON < H_WLon)
                            H_WLon = Polys[N].WLON;
                        if (Polys[N].NLAT > H_NLat)
                            H_NLat = Polys[N].NLAT;
                        if (Polys[N].SLAT < H_SLat)
                            H_SLat = Polys[N].SLAT;
                    }
                }

            next_N0:
                ;
            }

            myFile = moduleMAIN.ProjectName + "_TEXP";
            myFile = Strings.Replace(myFile, " ", "_");
            FileSystem.FileOpen(3, My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".scm", OpenMode.Output);
            a = "Header( 1 ";
            a = a + Conversion.Str(Conversion.Int(H_NLat + 1.5d)) + " ";
            a = a + Conversion.Str(Conversion.Int(H_SLat - 0.5d)) + " ";
            a = a + Conversion.Str(Conversion.Int(H_ELon + 1.5d)) + " ";
            a = a + Conversion.Str(Conversion.Int(H_WLon - 0.5d)) + " )";
            FileSystem.PrintLine(3, a);
            a = "LatRange( ";
            a = a + Conversion.Str(Conversion.Int(H_SLat - 0.5d)) + " ";
            a = a + Conversion.Str(Conversion.Int(H_NLat + 1.5d)) + " )";
            FileSystem.PrintLine(3, a);
            FileSystem.PrintLine(3);
            var loopTo1 = NoOfPolys;
            for (N = 1; N <= loopTo1; N++)
            {
                if (Polys[N].Selected)
                {
                    a = Polys[N].Type;
                    if (string.IsNullOrEmpty(a))
                        goto next_N;
                    b = Strings.Mid(a, 1, 3);
                    if (b != "TEX")
                        goto next_N;
                    M = Strings.InStr(1, a, "//");
                    b = Strings.Mid(a, 1, M - 1);
                    // b = "TEX"

                    a = Strings.Mid(a, M + 2);
                    M = Strings.InStr(1, a, "//");
                    PolyTex = Strings.Mid(a, 1, M - 1);
                    a = Strings.Mid(a, M + 2);
                    M = Strings.InStr(1, a, "//");
                    Priority = Strings.Mid(a, 1, M - 1);
                    a = Strings.Mid(a, M + 2);
                    M = Strings.InStr(1, a, "//");
                    TileX = Conversions.ToInteger(Strings.Mid(a, 1, M - 1));
                    a = Strings.Mid(a, M + 2);
                    M = Strings.InStr(1, a, "//");
                    TileY = Conversions.ToInteger(Strings.Mid(a, 1, M - 1));
                    a = Strings.Mid(a, M + 2);
                    M = Strings.InStr(1, a, "//");
                    Visibility = Strings.Mid(a, 1, M - 1);
                    a = Strings.Mid(a, M + 2);
                    M = Strings.InStr(1, a, "//");
                    Night = Conversions.ToInteger(Strings.Mid(a, 1, M - 1));
                    PolyTexString = Strings.Mid(a, M + 2);
                    MakePolyTexString(N, false);
                    LZL = GetLatZLonTexPoly(N);
                    AuxLatPoly = LZL.Y;
                    Latitude = Strings.Format(AuxLatPoly, "0.00000000");
                    AuxLonPoly = LZL.X;
                    Longitude = Strings.Format(AuxLonPoly, "0.00000000");
                    AuxZPoly = LZL.Z;
                    Altitude = Strings.Format(AuxZPoly, "0.00000000");
                    Latitude = Strings.Replace(Latitude, ",", ".");
                    Longitude = Strings.Replace(Longitude, ",", ".");
                    Altitude = Strings.Replace(Altitude, ",", ".");
                    Visibility = Strings.Replace(Visibility, ",", ".");
                    a = "; Textured Poly #" + Conversion.Str(N) + Constants.vbCrLf + Constants.vbCrLf;
                    a = a + "Area( 5 ";
                    a = a + Latitude + " " + Longitude + " 50 )";
                    FileSystem.PrintLine(3, a);
                    a = "LayerCall( :lcall " + Priority + " )";
                    FileSystem.PrintLine(3, a);
                    a = "Jump( : )" + Constants.vbCrLf + ":lcall";
                    FileSystem.PrintLine(3, a);
                    a = "RefPoint( 2 :return 1 " + Latitude + " " + Longitude;
                    a = a + " E= " + Altitude + " v1= " + Visibility + " v2= " + GetV2(N) + " )";
                    FileSystem.PrintLine(3, a);
                    a = "BGLVersion( 0800 )";
                    FileSystem.PrintLine(3, a);
                    if (!string.IsNullOrEmpty(PolyTex))
                    {
                        a = FillTextureList(Night);
                        FileSystem.PrintLine(3, a);
                    }

                    a = FillMaterialList(N);
                    FileSystem.PrintLine(3, a);
                    a = FillVextexList(N, TileX, TileY);
                    FileSystem.PrintLine(3, a);
                    if (!string.IsNullOrEmpty(PolyTex))
                    {
                        a = "SetMaterial( 0 0 )";
                    }
                    else
                    {
                        a = "SetMaterial( 0 -1 )";
                    }

                    FileSystem.PrintLine(3, a);
                    a = FillDrawTriList(N);
                    FileSystem.PrintLine(3, a);
                    a = "EndVersion";
                    FileSystem.PrintLine(3, a);
                    a = ":return" + Constants.vbCrLf + "Return" + Constants.vbCrLf + "EndA" + Constants.vbCrLf;
                    FileSystem.PrintLine(3, a);
                }

            next_N:
                ;
            }

            FileSystem.FileClose(3);

            // delete BGL file
            a = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".BGL";
            if (File.Exists(a))
                File.Delete(a);
            FileSystem.ChDrive(My.MyProject.Application.Info.DirectoryPath);
            FileSystem.ChDir(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            a = @"scasm work\" + myFile + ".scm -s -l";
            N = moduleMAIN.ExecCmd(a);
            if (N > 0)
            {
                a = "There was a compilation error in the textured" + Constants.vbCrLf;
                a = a + " polygons! Do you want to read a SCASM report?";
                N = (int)Interaction.MsgBox(a, MsgBoxStyle.OkCancel);
                if (N == 1)
                {
                    a = "notepad SCAERROR.LOG";
                    N = moduleMAIN.ExecCmd(a);
                }

                return;
            }

            if (!CopyBGLs)
                return;
            try
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".BGL";
                if (File.Exists(a))
                {
                    File.Copy(a, moduleMAIN.BGLProjectFolder + @"\" + myFile + ".BGL", true);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Copying BGL files failed!", MsgBoxStyle.Exclamation);
            }
        }

        private static moduleMAIN.Double_XYZ GetLatZLonTexPoly(int P)
        {
            moduleMAIN.Double_XYZ GetLatZLonTexPolyRet = default;
            int N, NP;
            double Z, X, Y;
            X = 0d;
            Y = 0d;
            Z = 0d;
            NP = Polys[P].NoOfPoints;
            var loopTo = NP;
            for (N = 1; N <= loopTo; N++)
            {
                X = X + Polys[P].GPoints[N].lon;
                Y = Y + Polys[P].GPoints[N].lat;
                Z = Z + Polys[P].GPoints[N].alt;
            }

            GetLatZLonTexPolyRet.X = X / NP;
            GetLatZLonTexPolyRet.Y = Y / NP;
            GetLatZLonTexPolyRet.Z = Z / NP;
            return GetLatZLonTexPolyRet;
        }

        private static string GetV2(int P)
        {
            string GetV2Ret = default;
            var lat = default(double);
            int N, NP;
            double DZ, DX, X, DY;
            DX = 0d;
            DY = 0d;
            DZ = 0d;
            NP = Polys[P].NoOfPoints;
            var loopTo = NP;
            for (N = 1; N <= loopTo; N++)
            {
                X = Math.Abs(AuxLonPoly - Polys[P].GPoints[N].lon) * moduleMAIN.MetersPerDegLon(lat);
                if (X > DX)
                    DX = X;
                X = Math.Abs(AuxLatPoly - Polys[P].GPoints[N].lat) * moduleMAIN.MetersPerDegLat;
                if (X > DY)
                    DY = X;
                X = Math.Abs(AuxZPoly - Polys[P].GPoints[N].alt);
                if (X > DZ)
                    DZ = X;
            }

            X = DX * DX + DY * DY + DZ * DZ;
            X = Math.Sqrt(X);
            X = Conversion.Int(X + 20d);
            GetV2Ret = X.ToString();
            return GetV2Ret;
        }

        private static string FillTextureList(int Nite)
        {
            string FillTextureListRet = default;
            string a, File;
            int K;
            a = "TextureList( 0 " + Constants.vbCrLf;
            K = Strings.Len(PolyTex);
            K = K - 4;
            File = Strings.Mid(PolyTex, 1, K);
            a = a + "       6 FF 255 255 255 0 50.000000 " + File + ".bmp" + Constants.vbCrLf;
            if (Nite == 1)
            {
                a = a + "     256 FF 255 255 255 0 50.000000 " + File + "_lm.bmp" + Constants.vbCrLf;
            }

            FillTextureListRet = a + "       )";
            return FillTextureListRet;
        }

        private static string FillMaterialList(int P)
        {
            string FillMaterialListRet = default;
            Color C;
            string a;
            C = Polys[P].Color;
            FillMaterialListRet = "MaterialList( 0   ";
            a = Strings.Format(C.R / 255d, "0.000") + " ";
            a = a + Strings.Format(C.G / 255d, "0.000") + " ";
            a = a + Strings.Format(C.B / 255d, "0.000") + " 1.00   ";
            a = Strings.Replace(a, ",", ".");
            FillMaterialListRet = FillMaterialListRet + a + a + "0.00 0.00 0.00 1.00   0.00 0.00 0.00 1.00   0.00 )";
            return FillMaterialListRet;
        }

        private static string FillVextexList(int P, int TileX, int TileY)
        {
            string FillVextexListRet = default;
            int N, K, M, L, NP;
            string a, b;
            Point PT;
            double Z, X, Y;
            float TX, TY;
            Point[] LP;

            // copy TexPoints to LP
            a = PolyTexString;
            NP = Polys[P].NoOfPoints;
            LP = new Point[NP + 1];
            var loopTo = NP;
            for (M = 1; M <= loopTo; M++)
            {
                K = Strings.InStr(1, a, "//");
                b = Strings.Mid(a, 1, K - 1);
                a = Strings.Mid(a, K + 2);
                K = Strings.InStr(1, b, ",");
                LP[M].X = Conversions.ToInteger(Strings.Mid(b, 1, K - 1));
                LP[M].Y = Conversions.ToInteger(Strings.Mid(b, K + 1));
            }

            if (MakePolyClockWise(P))
            {
                L = NP + 1;
                M = (int)Conversion.Int(L / 2d);
                var loopTo1 = M;
                for (N = 1; N <= loopTo1; N++)
                {
                    PT = LP[N];
                    LP[N] = LP[L - N];
                    LP[L - N] = PT;
                }
            }

            FillVextexListRet = "VertexList( 0 " + Constants.vbCrLf;
            var loopTo2 = NP;
            for (N = 1; N <= loopTo2; N++)
            {
                X = (Polys[P].GPoints[N].lon - AuxLonPoly) * moduleMAIN.MetersPerDegLon(AuxLatPoly);
                if (X < 0d)
                    a = Strings.Format(X, "0000.0000") + " ";
                if (X >= 0d)
                    a = Strings.Format(X, " 0000.0000") + " ";
                Z = Polys[P].GPoints[N].alt - AuxZPoly;
                a = a + Strings.Format(Z, "0000.0000000") + " ";
                Y = (Polys[P].GPoints[N].lat - AuxLatPoly) * moduleMAIN.MetersPerDegLat;
                if (Y < 0d)
                    a = a + Strings.Format(Y, "0000.0000") + " 0.0 1.0 0.0 ";
                if (Y >= 0d)
                    a = a + Strings.Format(Y, " 0000.0000") + " 0.0 1.0 0.0 ";
                TX = (float)(LP[N].X * TileX / 256d);
                TY = (float)(LP[N].Y * TileY / 256d);
                a = a + Strings.Format(TX, "00.000") + " " + Strings.Format(TY, "00.000");
                a = Strings.Replace(a, ",", ".");
                a = a + " ; vertex #" + Strings.Format(N - 1, "000");
                FillVextexListRet = FillVextexListRet + "      " + a + Constants.vbCrLf;
            }

            FillVextexListRet = FillVextexListRet + "       )";
            return FillVextexListRet;
        }

        private static string FillDrawTriList(int P)
        {
            string FillDrawTriListRet = default;
            int N, S, K;
            S = Polys[P].NoOfPoints;
            moduleTRIANGLES.NoOfPts2Tris = S;
            moduleTRIANGLES.Pts2Tris = new moduleTRIANGLES.Pts2Tri[S + 1 + 1];
            var loopTo = S;
            for (N = 1; N <= loopTo; N++)
            {
                moduleTRIANGLES.Pts2Tris[N].X = Polys[P].GPoints[N].lon;
                moduleTRIANGLES.Pts2Tris[N].Y = Polys[P].GPoints[N].lat;
                moduleTRIANGLES.Pts2Tris[N].N = N - 1;
            }

            moduleTRIANGLES.Pts2Tris[0] = moduleTRIANGLES.Pts2Tris[S];
            moduleTRIANGLES.Pts2Tris[S + 1] = moduleTRIANGLES.Pts2Tris[1];
            moduleTRIANGLES.MakeTris(); // make the triangles!
            FillDrawTriListRet = "DrawTriList( 0 " + Constants.vbCrLf + "       ";
            var loopTo1 = moduleTRIANGLES.NoOfTris;
            for (N = 1; N <= loopTo1; N++)
            {
                K = moduleTRIANGLES.Tris[N].N3;
                FillDrawTriListRet = FillDrawTriListRet + Strings.Format(K, "000") + " ";
                K = moduleTRIANGLES.Tris[N].N2;
                FillDrawTriListRet = FillDrawTriListRet + Strings.Format(K, "000") + " ";
                K = moduleTRIANGLES.Tris[N].N1;
                FillDrawTriListRet = FillDrawTriListRet + Strings.Format(K, "000") + Constants.vbCrLf + "       ";
            }

            FillDrawTriListRet = FillDrawTriListRet + ")";
            return FillDrawTriListRet;
        }

        internal static void Get3Points(int N, ref int N1, ref int N2, ref int N3, ref double lat)
        {
            int NP, J, K;
            double X1, X2, DX, DY, D;
            NP = Polys[N].NoOfPoints;
            N1 = 1;
            N2 = 1;
            X1 = Polys[N].GPoints[1].lon;
            X2 = Polys[N].GPoints[1].lon;
            lat = 0d;
            var loopTo = NP;
            for (J = 1; J <= loopTo; J++)
            {
                lat = lat + Polys[N].GPoints[J].lat;
                if (Polys[N].GPoints[J].lon < X1)
                {
                    N1 = J;
                    X1 = Polys[N].GPoints[J].lon;
                }

                if (Polys[N].GPoints[J].lon > X2)
                {
                    N2 = J;
                    X2 = Polys[N].GPoints[J].lon;
                }
            }

            lat = lat / NP;
            X1 = Polys[N].GPoints[N1].lon - Polys[N].GPoints[N2].lon;
            X1 = X1 * X1;
            X2 = Polys[N].GPoints[N1].lat - Polys[N].GPoints[N2].lat;
            X2 = X2 * X2;
            D = Math.Sqrt(X1 + X2);
            var loopTo1 = NP;
            for (K = 1; K <= loopTo1; K++)
            {
                if (K != N1 & K != N2)
                {
                    X1 = Polys[N].GPoints[N1].lon - Polys[N].GPoints[K].lon;
                    X1 = X1 * X1;
                    X2 = Polys[N].GPoints[N1].lat - Polys[N].GPoints[K].lat;
                    X2 = X2 * X2;
                    DX = Math.Sqrt(X1 + X2);
                    X1 = Polys[N].GPoints[N2].lon - Polys[N].GPoints[K].lon;
                    X1 = X1 * X1;
                    X2 = Polys[N].GPoints[N2].lat - Polys[N].GPoints[K].lat;
                    X2 = X2 * X2;
                    DY = Math.Sqrt(X1 + X2);
                    DX = DX + DY;
                    if (DX > D)
                    {
                        D = DX;
                        N3 = K;
                    }
                }
            }
        }

        internal static void GetSlopes(int N, int N0, int N1, int N2, ref double K1, ref double K2, ref double K3)
        {
            double z00, z01, z02;
            double x00, x01, x02;
            double y00, y01, y02;
            double a1, a2;
            x01 = Polys[N].GPoints[N0].lon - Polys[N].GPoints[N1].lon;
            x02 = Polys[N].GPoints[N0].lon - Polys[N].GPoints[N2].lon;
            y01 = Polys[N].GPoints[N0].lat - Polys[N].GPoints[N1].lat;
            y02 = Polys[N].GPoints[N0].lat - Polys[N].GPoints[N2].lat;
            z01 = Polys[N].GPoints[N0].alt - Polys[N].GPoints[N1].alt;
            z02 = Polys[N].GPoints[N0].alt - Polys[N].GPoints[N2].alt;
            if (y01 == 0d)
            {
                if (x01 == 0d)
                {
                    K1 = 0d;
                }
                else
                {
                    K1 = z01 / x01;
                }
            }
            else
            {
                a1 = y02 / y01;
                z00 = z01 * a1 - z02;
                x00 = x01 * a1 - x02;
                K1 = z00 / x00;
            }

            if (x01 == 0d)
            {
                if (y01 == 0d)
                {
                    K2 = 0d;
                }
                else
                {
                    K2 = z01 / y01;
                }
            }
            else
            {
                a2 = x02 / x01;
                z00 = z01 * a2 - z02;
                y00 = y01 * a2 - y02;
                K2 = z00 / y00;
            }

            K3 = Polys[N].GPoints[N0].alt - K1 * Polys[N].GPoints[N0].lon - K2 * Polys[N].GPoints[N0].lat;
        }

        private static double DeltaLat;
        private static double DeltaLon;

        public static void SetDeltaLatLon()
        {
            DeltaLat = 360d / Math.Pow(2d, moduleMAIN.QMIDLevel);
            DeltaLon = 480d / Math.Pow(2d, moduleMAIN.QMIDLevel);
        }

        public static void SnapPolys()
        {
            SetDeltaLatLon();
            int N;
            N = 1;
            while (N <= NoOfPolys)
            {
                if (Polys[N].Selected)
                {
                    SnapThisPoly(N);
                }

                N = N + 1;
            }
        }

        public static void SnapThisPoly(int P)
        {
            int NP, N, J, @int;
            double Lat, Lon;
            NP = Polys[P].NoOfPoints;
            N = 1;
            while (N <= NP)
            {
                Lat = 90d - Polys[P].GPoints[N].lat;
                Lon = 180d + Polys[P].GPoints[N].lon;
                @int = Convert.ToInt32(Lat / DeltaLat);
                Lat = 90d - @int * DeltaLat;
                @int = Convert.ToInt32(Lon / DeltaLon);
                Lon = @int * DeltaLon - 180d;
                Polys[P].GPoints[N].lat = Lat;
                Polys[P].GPoints[N].lon = Lon;
                var loopTo = N - 1;
                for (J = 1; J <= loopTo; J++)
                {
                    if (Polys[P].GPoints[J].lat == Lat)
                    {
                        if (Polys[P].GPoints[J].lon == Lon)
                        {
                            if (Polys[P].NoOfPoints < 3)
                            {
                                DeletePoly(P);
                                moduleMAIN.Dirty = true;
                                return;
                            }
                            else
                            {
                                DeletePointInPoly(P, N);
                            }

                            NP = NP - 1;
                            N = N - 1;
                        }
                    }
                }

                N = N + 1;
            }
        }
    }
}