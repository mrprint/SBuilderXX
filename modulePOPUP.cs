using System.Drawing;

namespace SBuilderXX
{
    static class modulePOPUP
    {

        // Friend IsPopUP As Boolean  ' goes false when mouse goes down


        internal static int POPIndex;
        internal static string POPType;
        internal static int POPIndexPT;
        internal static string POPMode;
        internal static int XPOP;
        internal static int YPOP;

        internal static void ProcessPopUp(int X1, int Y1)
        {
            double X, Y;
            int N, J, K = default, C, R;
            Point PT;
            byte B;
            string A;
            XPOP = X1;
            YPOP = Y1;
            X = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X1;   // longitude in pixels
            Y = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y1;  // latitude in pixels
            POPType = "";
            POPIndex = 0;
            POPIndexPT = 0;
            POPMode = "One";
            HidePopUPMenu();
            if (moduleLINES.LineON & moduleLINES.NoOfLinesSelected > 1)
            {
                int loopTo = moduleLINES.NoOfLines;
                for (N = 1; N <= loopTo; N++)
                {
                    POPIndex = N;
                    if (moduleLINES.Lines[N].Selected)
                        break;
                }

                My.MyProject.Forms.FrmLinesP.Close();
                POPMode = "Many";
                POPType = "Line";
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "ON MANY LINES";
                ShowPopUPMenu();
                moduleMAIN.MakeOnMany = moduleLINES.NoOfLinesSelected;
                My.MyProject.Forms.FrmStart.JoinAllPopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SmoothPopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SamplePopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SetWidthPopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SetAltitudePopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.DeletePopUPMenu.Visible = false;
                if (moduleMAIN.QMIDLevel > 3)
                {
                    My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Text = "Slice to QMID " + moduleMAIN.QMIDLevel.ToString();
                    My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Visible = true;
                }

                return;
            }

            bool OuterFlag = false;
            bool HoleFlag = false;
            if (modulePOLYS.PolyON & modulePOLYS.NoOfPolysSelected > 1)
            {

                // check if there are possible outers and possible holes
                int loopTo1 = modulePOLYS.NoOfPolys;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (modulePOLYS.Polys[N].Selected)
                    {
                        POPIndex = N;
                        if (modulePOLYS.Polys[N].NoOfChilds < 0)
                            OuterFlag = true;
                        if (modulePOLYS.Polys[N].NoOfChilds == 0)
                            HoleFlag = true;
                    }
                }

                My.MyProject.Forms.FrmPolysP.Close();
                POPMode = "Many";
                POPType = "Poly";
                moduleMAIN.MakeOnMany = K;
                My.MyProject.Forms.FrmStart.SmoothPopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SamplePopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "ON MANY POLYS";
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.JoinAllPopUPMenu.Visible = true;
                // frmStart.SetWidthPopUpMenu.Visible = True

                if (HoleFlag)
                    My.MyProject.Forms.FrmStart.HolePopUpMenu.Visible = true;
                if (OuterFlag)
                    My.MyProject.Forms.FrmStart.OuterPopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SetAltitudePopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.DeletePopUPMenu.Visible = false;
                if (moduleMAIN.QMIDLevel > 3)
                {
                    My.MyProject.Forms.FrmStart.SnapQMIDPopUPMenu.Text = "Snap to QMID " + moduleMAIN.QMIDLevel.ToString();
                    My.MyProject.Forms.FrmStart.SnapQMIDPopUPMenu.Visible = true;
                    if (modulePOLYS.Polys[POPIndex].NoOfChilds >= 0)
                    {
                        My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Text = "Slice to QMID " + moduleMAIN.QMIDLevel.ToString();
                        My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Visible = true;
                        My.MyProject.Forms.FrmStart.FillQMIDPopUpMenu.Text = "Fill to QMID " + moduleMAIN.QMIDLevel.ToString();
                        My.MyProject.Forms.FrmStart.FillQMIDPopUpMenu.Visible = true;
                    }
                }

                return;
            }

            if (moduleOBJECTS.ObjectON & moduleOBJECTS.NoOfObjectsSelected > 1)
            {
                My.MyProject.Forms.FrmObjectsP.Close();
                My.MyProject.Forms.FrmObjectsP.ShowForAllSelected();
                My.MyProject.Forms.FrmObjectsP.ShowDialog();
                return;
            }

            if (moduleCLASSES.LandON)
            {
                POPIndex = IsLandUP(X, Y);
                if (POPIndex > -1)
                {
                    POPType = "Land";
                    N = POPIndex;
                    R = N % 512;
                    N = N >> 9;
                    C = N % 512;
                    N = N >> 9;
                    K = N % 64;
                    N = N >> 6;
                    J = N % 128;
                    B = moduleCLASSES.LLands[C, R, moduleCLASSES.LL_XY[J, K].Pointer];
                    B = moduleCLASSES.LC[B].Index;
                    My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "LAND CLASS = " + B.ToString();
                    ShowPopUPMenu();
                    My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = false;
                    My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = false;
                    return;
                }
            }

            if (moduleCLASSES.WaterON)
            {
                POPIndex = IsWaterUP(X, Y);
                if (POPIndex > -1)
                {
                    POPType = "Water";
                    N = POPIndex;
                    R = N % 512;
                    N = N >> 9;
                    C = N % 512;
                    N = N >> 9;
                    K = N % 64;
                    N = N >> 6;
                    J = N % 128;
                    B = moduleCLASSES.WWaters[C, R, moduleCLASSES.WW_XY[J, K].Pointer];
                    B = moduleCLASSES.WC[B].Index;
                    My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "WATER CLASS = " + B.ToString();
                    ShowPopUPMenu();
                    My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = false;
                    My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = false;
                    return;
                }
            }

            if (moduleOBJECTS.ObjectON)
            {
                POPIndex = IsObjectUP(X, Y);
                if (POPIndex > 0)
                {
                    POPType = "Object";
                    My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "OBJECT # " + POPIndex.ToString();
                    ShowPopUPMenu();
                    return;
                }
            }


            // now we are 

            PT = IsPointInLineUP(X, Y);
            if (PT.X > 0)
            {
                POPType = "PtInLine";
                POPIndex = PT.Y;
                POPIndexPT = PT.X;
                A = moduleLINES.Lines[PT.Y].Name;
                if (string.IsNullOrEmpty(A))
                    A = "LINE # " + PT.Y.ToString();
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "POINT # " + PT.X.ToString() + " from " + A;
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.PointFromAircraftPopUpMenu.Visible = true;
                return;
            }

            PT = IsPointInPolyUP(X, Y);
            if (PT.X > 0)
            {
                POPType = "PtInPoly";
                POPIndex = PT.Y;
                POPIndexPT = PT.X;
                A = modulePOLYS.Polys[PT.Y].Name;
                if (string.IsNullOrEmpty(A))
                    A = "POLY # " + PT.Y.ToString();
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "POINT # " + PT.X.ToString() + " from " + A;
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.PointFromAircraftPopUpMenu.Visible = true;
                return;
            }

            N = IsLineUP(X, Y);
            if (N > 0)
            {
                POPType = "Line";
                POPIndex = N;
                A = moduleLINES.Lines[N].Name;
                if (!string.IsNullOrEmpty(A))
                    A = A + " ";
                A = A + "LINE # " + N.ToString();
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = A;
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.SetTransparencyPopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SetWidthPopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SetAltitudePopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.MakePolyPopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.ConvertToPolyPopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SmoothPopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SamplePopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.ManualCheckPopUPMenu.Visible = true;
                if (moduleMAIN.QMIDLevel > 3 & moduleLINES.LineON)
                {
                    My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Text = "Slice to QMID " + moduleMAIN.QMIDLevel.ToString();
                    My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Visible = true;
                }

                return;
            }

            N = IsPolyUP(X, Y);
            if (N > 0)
            {
                POPType = "Poly";
                POPIndex = N;
                A = modulePOLYS.Polys[N].Name;
                if (!string.IsNullOrEmpty(A))
                    A = A + " ";
                A = A + "POLY # " + N.ToString();
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = A;
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.SetAltitudePopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SetTransparencyPopUpMenu.Visible = true;
                My.MyProject.Forms.FrmStart.MakeLinePopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SmoothPopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.SamplePopUPMenu.Visible = true;
                My.MyProject.Forms.FrmStart.ManualCheckPopUPMenu.Visible = true;
                if (moduleMAIN.QMIDLevel > 3 & modulePOLYS.PolyON)
                {
                    My.MyProject.Forms.FrmStart.SnapQMIDPopUPMenu.Text = "Snap to QMID " + moduleMAIN.QMIDLevel.ToString();
                    My.MyProject.Forms.FrmStart.SnapQMIDPopUPMenu.Visible = true;
                }

                if (modulePOLYS.Polys[POPIndex].NoOfChilds >= 0)
                {
                    if (modulePOLYS.NoOfPolys > 1)
                        My.MyProject.Forms.FrmStart.HolePopUpMenu.Visible = true;
                    if (moduleMAIN.QMIDLevel > 3 & modulePOLYS.PolyON)
                    {
                        My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Text = "Slice to QMID " + moduleMAIN.QMIDLevel.ToString();
                        My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Visible = true;
                        My.MyProject.Forms.FrmStart.FillQMIDPopUpMenu.Text = "Fill to QMID " + moduleMAIN.QMIDLevel.ToString();
                        My.MyProject.Forms.FrmStart.FillQMIDPopUpMenu.Visible = true;
                    }
                }
                else
                {
                    if (modulePOLYS.NoOfPolys > 1)
                        My.MyProject.Forms.FrmStart.OuterPopUpMenu.Visible = true;
                    My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = false;
                    My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = false;
                    My.MyProject.Forms.FrmStart.SetAltitudePopUpMenu.Visible = false;
                }

                return;
            }

            POPIndex = IsObjectUP(X, Y);
            if (POPIndex > 0)
            {
                POPType = "Object";
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "OBJECT # " + POPIndex.ToString();
                ShowPopUPMenu();
                return;
            }

            POPIndex = IsExcludeUP(X, Y);
            if (POPIndex > 0)
            {
                POPType = "Exclude";
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "EXCLUDE # " + POPIndex.ToString();
                ShowPopUPMenu();
                return;
            }

            POPIndex = IsLandUP(X, Y);
            if (POPIndex > -1)
            {
                POPType = "Land";
                N = POPIndex;
                R = N % 512;
                N = N >> 9;
                C = N % 512;
                N = N >> 9;
                K = N % 64;
                N = N >> 6;
                J = N % 128;
                B = moduleCLASSES.LLands[C, R, moduleCLASSES.LL_XY[J, K].Pointer];
                B = moduleCLASSES.LC[B].Index;
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "LAND CLASS = " + B.ToString();
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = false;
                My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = false;
                return;
            }

            POPIndex = IsWaterUP(X, Y);
            if (POPIndex > -1)
            {
                POPType = "Water";
                N = POPIndex;
                R = N % 512;
                N = N >> 9;
                C = N % 512;
                N = N >> 9;
                K = N % 64;
                N = N >> 6;
                J = N % 128;
                B = moduleCLASSES.WWaters[C, R, moduleCLASSES.WW_XY[J, K].Pointer];
                B = moduleCLASSES.WC[B].Index;
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = "WATER CLASS = " + B.ToString();
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = false;
                My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = false;
                return;
            }

            N = IsMapUP(X, Y);
            if (N > 0)
            {
                POPType = "Map";
                POPIndex = N;
                A = moduleMAPS.Maps[N].Name;
                if (!string.IsNullOrEmpty(A))
                    A = A + " ";
                A = A + "MAP # " + N.ToString();
                My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = A;
                ShowPopUPMenu();
                My.MyProject.Forms.FrmStart.CalibratePopUPMenu.Visible = true;
                return;
            }

            My.MyProject.Forms.FrmStart.NamePopUPMenu.Text = moduleMAIN.ProjectName;
            My.MyProject.Forms.FrmStart.NamePopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.Sep1PopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.CenterPopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.FlyToPopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.ZoomInPopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.ZoomOutPopUPMenu.Visible = true;
            if (My.MyProject.Forms.FrmStart.ShowBackgroundMenuItem.Enabled)
            {
                if (My.MyProject.Forms.FrmStart.ShowBackgroundMenuItem.Checked)
                {
                    My.MyProject.Forms.FrmStart.SaveBackGroundPopUpMenu.Visible = true;
                    My.MyProject.Forms.FrmStart.TilePathToClipboardPopUpMenu.Visible = true;
                }
            }

            My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = true;
            POPType = "Project";
        }

        internal static Point IsPointInLineUP(double X, double Y)
        {
            Point IsPointInLineUPRet = default;

            // If the right mouse is not over a Point returns Zero in X property.
            // Otherwise return the index of Point and the index of the Line
            // in the Y property

            double X1, Y1;
            int N, K;
            bool retval;
            IsPointInLineUPRet.X = 0;
            double DX = 3d / moduleMAIN.PixelsPerLonDeg;
            double DY = 3d / moduleMAIN.PixelsPerLatDeg;
            X1 = X / moduleMAIN.PixelsPerLonDeg;
            Y1 = Y / moduleMAIN.PixelsPerLatDeg;
            if ((moduleMAIN.PointerON | moduleLINES.LineON) & moduleLINES.LineVIEW)
            {
                int loopTo = moduleLINES.NoOfLines;
                for (N = 1; N <= loopTo; N++)
                {
                    if (X1 < moduleLINES.Lines[N].WLON - DX)
                        goto Jump_NextLN;
                    if (X1 > moduleLINES.Lines[N].ELON + DX)
                        goto Jump_NextLN;
                    if (Y1 < moduleLINES.Lines[N].SLAT - DY)
                        goto Jump_NextLN;
                    if (Y1 > moduleLINES.Lines[N].NLAT + DY)
                        goto Jump_NextLN;
                    K = 1;
                    retval = false;
                    while (!(retval == true | K == moduleLINES.Lines[N].NoOfPoints + 1))
                    {
                        retval = retval | modulePOINTS.IsPoint(moduleLINES.Lines[N].GLPoints[K].lon, moduleLINES.Lines[N].GLPoints[K].lat, X, Y);
                        K = K + 1;
                    }

                    if (retval)
                    {
                        IsPointInLineUPRet.X = K - 1;
                        IsPointInLineUPRet.Y = N;
                        return IsPointInLineUPRet;
                    }

                Jump_NextLN:
                    ;
                }
            }

            return IsPointInLineUPRet;
        }

        internal static Point IsPointInPolyUP(double X, double Y)
        {
            Point IsPointInPolyUPRet = default;

            // If the right mouse is not over a Point returns Zero in X property.
            // Otherwise return the index of Point and the index of the Poly
            // in the Y property

            double X1, Y1;
            int N, K;
            bool retval;
            IsPointInPolyUPRet.X = 0;
            X1 = X / moduleMAIN.PixelsPerLonDeg;
            Y1 = Y / moduleMAIN.PixelsPerLatDeg;
            if ((moduleMAIN.PointerON | modulePOLYS.PolyON) & modulePOLYS.PolyVIEW)
            {
                int loopTo = modulePOLYS.NoOfPolys;
                for (N = 1; N <= loopTo; N++)
                {
                    K = 1;
                    retval = false;
                    while (!(retval == true | K == modulePOLYS.Polys[N].NoOfPoints + 1))
                    {
                        retval = retval | modulePOINTS.IsPoint(modulePOLYS.Polys[N].GPoints[K].lon, modulePOLYS.Polys[N].GPoints[K].lat, X, Y);
                        K = K + 1;
                    }

                    if (retval)
                    {
                        IsPointInPolyUPRet.X = K - 1;
                        IsPointInPolyUPRet.Y = N;
                        return IsPointInPolyUPRet;
                    }
                }
            }

            return IsPointInPolyUPRet;
        }

        internal static int IsLineUP(double X, double Y)
        {
            int IsLineUPRet = default;

            // If the right mouse is not over a Line returns Zero.
            // Otherwise return the index of Line

            int N, K;
            bool retval;
            double WLON, NLAT, SLAT, ELON;
            IsLineUPRet = 0;
            if (!((moduleMAIN.PointerON | moduleLINES.LineON) & moduleLINES.LineVIEW))
                return IsLineUPRet;
            WLON = (X + 5d) / moduleMAIN.PixelsPerLonDeg;
            ELON = (X - 5d) / moduleMAIN.PixelsPerLonDeg;
            NLAT = (Y - 5d) / moduleMAIN.PixelsPerLatDeg;
            SLAT = (Y + 5d) / moduleMAIN.PixelsPerLatDeg;
            int loopTo = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo; N++)
            {
                retval = false;
                if (WLON < moduleLINES.Lines[N].WLON)
                    goto Jump_NextLN;
                if (ELON > moduleLINES.Lines[N].ELON)
                    goto Jump_NextLN;
                if (SLAT < moduleLINES.Lines[N].SLAT)
                    goto Jump_NextLN;
                if (NLAT > moduleLINES.Lines[N].NLAT)
                    goto Jump_NextLN;
                K = 2;
                retval = false;
                while (!(retval == true | K == moduleLINES.Lines[N].NoOfPoints + 1))
                {
                    retval = retval | modulePOINTS.IsPointInSegment(moduleLINES.Lines[N].GLPoints[K - 1].lon, moduleLINES.Lines[N].GLPoints[K - 1].lat, moduleLINES.Lines[N].GLPoints[K].lon, moduleLINES.Lines[N].GLPoints[K].lat, X, Y);
                    K = K + 1;
                }

                if (retval)
                {
                    IsLineUPRet = N;
                    return IsLineUPRet;
                }

            Jump_NextLN:
                ;
            }

            return IsLineUPRet;
        }

        internal static int IsPolyUP(double X, double Y)
        {
            int IsPolyUPRet = default;

            // If the right mouse is not over a Poly returns Zero.
            // Otherwise return the index of Poly

            int N, K;
            bool retval;
            IsPolyUPRet = 0;
            if ((moduleMAIN.PointerON | modulePOLYS.PolyON) & modulePOLYS.PolyVIEW)
            {
                int loopTo = modulePOLYS.NoOfPolys;
                for (N = 1; N <= loopTo; N++)
                {
                    K = 2;
                    retval = false;
                    while (!(retval == true | K == modulePOLYS.Polys[N].NoOfPoints + 1))
                    {
                        retval = retval | modulePOINTS.IsPointInSegment(modulePOLYS.Polys[N].GPoints[K - 1].lon, modulePOLYS.Polys[N].GPoints[K - 1].lat, modulePOLYS.Polys[N].GPoints[K].lon, modulePOLYS.Polys[N].GPoints[K].lat, X, Y);
                        K = K + 1;
                    }

                    if (retval)
                    {
                        IsPolyUPRet = N;
                        return IsPolyUPRet;
                    }

                    retval = modulePOINTS.IsPointInSegment(modulePOLYS.Polys[N].GPoints[K - 1].lon, modulePOLYS.Polys[N].GPoints[K - 1].lat, modulePOLYS.Polys[N].GPoints[1].lon, modulePOLYS.Polys[N].GPoints[1].lat, X, Y);
                    if (retval)
                    {
                        IsPolyUPRet = N;
                        return IsPolyUPRet;
                    }
                }
            }

            return IsPolyUPRet;
        }

        internal static int IsExcludeUP(double X, double Y)
        {
            int IsExcludeUPRet = default;
            int N;
            bool retval;
            IsExcludeUPRet = 0;
            if ((moduleMAIN.PointerON | moduleEXCLUDES.ExcludeON) & moduleEXCLUDES.ExcludeVIEW)
            {
                int loopTo = moduleEXCLUDES.NoOfExcludes;
                for (N = 1; N <= loopTo; N++)
                {
                    retval = moduleEXCLUDES.IsPtInExclude(N, X, Y);
                    if (retval)
                    {
                        IsExcludeUPRet = N;
                        return IsExcludeUPRet;
                    }
                }
            }

            return IsExcludeUPRet;
        }

        internal static int IsObjectUP(double X, double Y)
        {
            int IsObjectUPRet = default;
            int N;
            double X1, Y1;
            IsObjectUPRet = 0;
            if ((moduleMAIN.PointerON | moduleOBJECTS.ObjectON) & moduleOBJECTS.ObjectVIEW)
            {
                int loopTo = moduleOBJECTS.NoOfObjects;
                for (N = 1; N <= loopTo; N++)
                {
                    X1 = moduleOBJECTS.Objects[N].lon * moduleMAIN.PixelsPerLonDeg;
                    Y1 = moduleOBJECTS.Objects[N].lat * moduleMAIN.PixelsPerLatDeg;
                    if (X1 > X + 4d)
                        continue;
                    if (X1 < X - 4d)
                        continue;
                    if (Y1 < Y - 4d)
                        continue;
                    if (Y1 > Y + 4d)
                        continue;
                    IsObjectUPRet = N;
                    return IsObjectUPRet;
                }
            }

            return IsObjectUPRet;
        }


        // Friend Function IsPhotoUP(ByVal X As Double, ByVal Y As Double) As Integer

        // Dim N As Integer
        // Dim retval As Boolean

        // IsPhotoUP = 0
        // If (PointerON Or PhotoON) And PhotoVIEW Then
        // For N = 1 To NoOfPhotos
        // retval = IsPointInsidePhoto(N, X, Y)
        // If retval Then
        // IsPhotoUP = N
        // Exit Function
        // End If
        // Next N
        // End If

        // End Function

        // Friend Function IsMeshUP(ByVal X As Double, ByVal Y As Double) As Integer

        // Dim N As Integer
        // Dim retval As Boolean

        // IsMeshUP = 0
        // If (PointerON Or MeshON) And MeshVIEW Then
        // For N = 1 To NoOfMeshes
        // retval = IsPointInsideMesh(N, X, Y)
        // If retval Then
        // IsMeshUP = N
        // Exit Function
        // End If
        // Next N
        // End If

        // End Function

        internal static int IsLandUP(double X, double Y)
        {
            int IsLandUPRet = default;
            int J, K, C, R, P;
            moduleCLASSES.JKCR PT;
            X = X / moduleMAIN.PixelsPerLonDeg;
            Y = Y / moduleMAIN.PixelsPerLatDeg;
            IsLandUPRet = -1;
            if ((moduleMAIN.PointerON | moduleCLASSES.LandON) & moduleCLASSES.LandVIEW)
            {
                PT = moduleMAIN.JKCRFromLL(X - moduleMAIN.D14Lon, Y + moduleMAIN.D14Lat, true);
                J = PT.J;
                K = PT.K;
                C = PT.C;
                R = PT.R;
                if (moduleCLASSES.LL_XY[J, K].NoOfLWs == 0)
                    return IsLandUPRet;
                P = moduleCLASSES.LL_XY[J, K].Pointer;
                if (moduleCLASSES.LLands[C, R, P] == 0)
                    return IsLandUPRet;
                C = C << 9;
                K = K << 18;
                J = J << 24;
                IsLandUPRet = R + C + J + K;
            }

            return IsLandUPRet;
        }

        internal static int IsWaterUP(double X, double Y)
        {
            int IsWaterUPRet = default;
            int J, K, C, R, P;
            moduleCLASSES.JKCR PT;
            X = X / moduleMAIN.PixelsPerLonDeg;
            Y = Y / moduleMAIN.PixelsPerLatDeg;
            IsWaterUPRet = -1;
            if ((moduleMAIN.PointerON | moduleCLASSES.WaterON) & moduleCLASSES.WaterVIEW)
            {
                PT = moduleMAIN.JKCRFromLL(X - moduleMAIN.D14Lon, Y + moduleMAIN.D14Lat, true);
                J = PT.J;
                K = PT.K;
                C = PT.C;
                R = PT.R;
                if (moduleCLASSES.WW_XY[J, K].NoOfLWs == 0)
                    return IsWaterUPRet;
                P = moduleCLASSES.WW_XY[J, K].Pointer;
                if (moduleCLASSES.WWaters[C, R, P] == 0)
                    return IsWaterUPRet;
                C = C << 9;
                K = K << 18;
                J = J << 24;
                IsWaterUPRet = R + C + J + K;
            }

            return IsWaterUPRet;
        }

        internal static int IsMapUP(double X, double Y)
        {
            int IsMapUPRet = default;
            int N;
            bool retval;
            IsMapUPRet = 0;
            if (moduleMAIN.PointerON & moduleMAPS.MapVIEW)
            {
                int loopTo = moduleMAPS.NoOfMaps;
                for (N = 1; N <= loopTo; N++)
                {
                    retval = moduleMAPS.IsPointInMap(N, X, Y);
                    if (retval)
                    {
                        IsMapUPRet = N;
                        return IsMapUPRet;
                    }
                }
            }

            return IsMapUPRet;
        }

        private static void ShowPopUPMenu()
        {
            My.MyProject.Forms.FrmStart.NamePopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.Sep1PopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.CenterPopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.FlyToPopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.ZoomInPopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.ZoomOutPopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.Sep2PopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.DeletePopUPMenu.Visible = true;

            // If frmStart.ShowBackgroundMenuItem.Enabled Then
            // If frmStart.ShowBackgroundMenuItem.Checked Then
            // frmStart.SaveBackGroundPopUpMenu.Visible = True
            // End If
            // End If

            My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = true;
            My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = true;
        }

        internal static void HidePopUPMenu()
        {
            My.MyProject.Forms.FrmStart.NamePopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.Sep1PopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.CenterPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.FlyToPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.PointFromAircraftPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.ZoomInPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.ZoomOutPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.Sep2PopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.DeletePopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SaveBackGroundPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.TilePathToClipboardPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.JoinAllPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SetWidthPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SetAltitudePopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SetTransparencyPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.MakeLinePopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.MakePolyPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.ConvertToPolyPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SmoothPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SamplePopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.ManualCheckPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.HolePopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.OuterPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.CalibratePopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.Sep3PopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.PropertiesPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SnapQMIDPopUPMenu.Visible = false;
            My.MyProject.Forms.FrmStart.FillQMIDPopUpMenu.Visible = false;
            My.MyProject.Forms.FrmStart.SliceQMIDPopUpMenu.Visible = false;
        }
    }
}