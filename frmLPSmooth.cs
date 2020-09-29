using System;

namespace SBuilderX
{
    internal partial class FrmLPSmooth
    {
        public FrmLPSmooth()
        {
            InitializeComponent();
            _chNoEnds.Name = "chNoEnds";
            _chCorner.Name = "chCorner";
            _txtDistance.Name = "txtDistance";
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
            _cmdSmooth.Name = "cmdSmooth";
        }

        private moduleLINES.GLine[] backupLine;
        private modulePOLYS.GPoly[] backupPoly;
        private double SquareSmoothDistance;

        private void FrmLPSmooth_Load(object sender, EventArgs e)
        {
            int N, K;
            chNoEnds.Checked = false;
            if (moduleMAIN.NoEndsSmooth)
                chNoEnds.Checked = true;
            chCorner.Checked = false;
            if (moduleMAIN.CornerSmooth)
                chCorner.Checked = true;
            txtDistance.Text = moduleMAIN.SmoothDistance.ToString();
            if (modulePOPUP.POPType == "Line")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    backupLine = new moduleLINES.GLine[1];
                    backupLine[0] = moduleLINES.Lines[modulePOPUP.POPIndex];
                }
                else
                {
                    backupLine = new moduleLINES.GLine[moduleMAIN.MakeOnMany];
                    K = 0;
                    var loopTo = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            backupLine[K] = moduleLINES.Lines[N];
                            K = K + 1;
                        }
                    }
                }
            }

            if (modulePOPUP.POPType == "Poly")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    backupPoly = new modulePOLYS.GPoly[1];
                    backupPoly[0] = modulePOLYS.Polys[modulePOPUP.POPIndex];
                }
                else
                {
                    backupPoly = new modulePOLYS.GPoly[moduleMAIN.MakeOnMany];
                    K = 0;
                    var loopTo1 = modulePOLYS.NoOfPolys;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected)
                        {
                            backupPoly[K] = modulePOLYS.Polys[N];
                            K = K + 1;
                        }
                    }
                }
            }

            SquareSmoothDistance = moduleMAIN.SmoothDistance * moduleMAIN.SmoothDistance;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            int N, K;
            if (modulePOPUP.POPType == "Line")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    moduleLINES.Lines[modulePOPUP.POPIndex] = backupLine[0];
                }
                else
                {
                    K = 0;
                    var loopTo = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            moduleLINES.Lines[N] = backupLine[K];
                            K = K + 1;
                        }
                    }
                }
            }

            if (modulePOPUP.POPType == "Poly")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    modulePOLYS.Polys[modulePOPUP.POPIndex] = backupPoly[0];
                }
                else
                {
                    K = 0;
                    var loopTo1 = modulePOLYS.NoOfPolys;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected)
                        {
                            modulePOLYS.Polys[N] = backupPoly[K];
                            K = K + 1;
                        }
                    }
                }
            }

            moduleMAIN.RebuildDisplay();
            Dispose();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            moduleMAIN.NoEndsSmooth = chNoEnds.Checked;
            moduleMAIN.CornerSmooth = chCorner.Checked;
            moduleMAIN.SmoothDistance = Convert.ToDouble(txtDistance.Text);
            string argPutKey = "Main";
            string argPutVariable = "NoEndsSmooth";
            string argPutValue = moduleMAIN.NoEndsSmooth.ToString();
            moduleFILE_IO.WriteIniValue(ref moduleMAIN.AppIni, ref argPutKey, ref argPutVariable, ref argPutValue);
            string argPutKey1 = "Main";
            string argPutVariable1 = "CornerSmooth";
            string argPutValue1 = moduleMAIN.CornerSmooth.ToString();
            moduleFILE_IO.WriteIniValue(ref moduleMAIN.AppIni, ref argPutKey1, ref argPutVariable1, ref argPutValue1);
            string argPutKey2 = "Main";
            string argPutVariable2 = "SmoothDistance";
            string argPutValue2 = moduleMAIN.SmoothDistance.ToString();
            moduleFILE_IO.WriteIniValue(ref moduleMAIN.AppIni, ref argPutKey2, ref argPutVariable2, ref argPutValue2);

            // WriteSettings()
            Dispose();
        }

        private void CmdSmooth_Click(object sender, EventArgs e)
        {
            int N;
            if (modulePOPUP.POPType == "Line")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    SmoothMyLine(modulePOPUP.POPIndex);
                }
                else
                {
                    var loopTo = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            SmoothMyLine(N);
                        }
                    }
                }
            }

            if (modulePOPUP.POPType == "Poly")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    SmoothMyPoly(modulePOPUP.POPIndex);
                }
                else
                {
                    var loopTo1 = modulePOLYS.NoOfPolys;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected)
                        {
                            SmoothMyPoly(N);
                        }
                    }
                }
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SmoothMyLine(int L)
        {
            int K, N, M, NP;
            moduleLINES.GLine myLine;
            NP = moduleLINES.Lines[L].NoOfPoints;
            if (NP < 3)
                return;
            myLine = moduleLINES.Lines[L];
            myLine.NoOfPoints = 3 * NP;
            myLine.GLPoints = new modulePOINTS.GLPoint[3 * NP + 1];
            myLine.GLPoints[1] = moduleLINES.Lines[L].GLPoints[1];
            N = 2;
            M = 2;
            do
            {
                K = SmoothThisLine(ref myLine, N, M, L);
                M = M + K;
                N = N + 1;
            }
            while (N < NP);
            myLine.GLPoints[M] = moduleLINES.Lines[L].GLPoints[N];
            myLine.NoOfPoints = M;
            Array.Resize(ref myLine.GLPoints, M + 1);
            moduleLINES.Lines[L] = myLine;
            moduleLINES.AddLatLonToLine(L);
        }

        private void SmoothMyPoly(int L)
        {
            int K, N, M, NP;
            modulePOLYS.GPoly myPoly;
            NP = modulePOLYS.Polys[L].NoOfPoints;
            if (NP < 3)
                return;
            myPoly = modulePOLYS.Polys[L];
            myPoly.NoOfPoints = 3 * NP;
            myPoly.GPoints = new modulePOINTS.GPoint[3 * NP + 1];

            // myPoly.GPoints(1) = Polys(L).GPoints(1)

            N = 1;
            M = 1;
            do
            {
                K = SmoothThisPoly(ref myPoly, N, M, L);
                M = M + K;
                N = N + 1;
            }
            while (N <= NP);

            // myPoly.GPoints(M) = Polys(L).GPoints(N)

            myPoly.NoOfPoints = M - 1;
            Array.Resize(ref myPoly.GPoints, M);
            modulePOLYS.Polys[L] = myPoly;
            modulePOLYS.AddLatLonToPoly(L);
        }

        private void TxtDistance_TextChanged(object sender, EventArgs e)
        {
            moduleMAIN.SmoothDistance = Convert.ToDouble(txtDistance.Text);
            SquareSmoothDistance = moduleMAIN.SmoothDistance * moduleMAIN.SmoothDistance;
        }

        private void ChCorner_CheckedChanged(object sender, EventArgs e)
        {
            moduleMAIN.CornerSmooth = chCorner.Checked;
        }

        private void ChNoEnds_CheckedChanged(object sender, EventArgs e)
        {
            moduleMAIN.NoEndsSmooth = chNoEnds.Checked;
        }

        private int SmoothThisLine(ref moduleLINES.GLine AuxLine, int N, int M, int Ln)
        {
            int SmoothThisLineRet = default;

            // N is the point in Ln
            // M is the point in AuxLine
            // returns 1 2 or 3

            double X1, X2, X, Y, Y2;
            double XN, YN;
            double V1X, V1Y;
            double V2X, V2Y;
            double VX, VY;
            bool Near1 = default, Near2 = default;
            moduleMAIN.Double_XY XY;
            try
            {
                // at leat one point will be added
                SmoothThisLineRet = 1;

                // X1 = GetDistance(N - 1, N - 1, Near1, Ln)
                // X2 = GetDistance(N, N, Near2, Ln)

                XY = Get2DistancesLine(N, ref Near1, ref Near2, Ln);
                if (moduleMAIN.NoEndsSmooth)
                {
                    if (N == 2)
                        Near1 = true;
                    if (N == moduleLINES.Lines[Ln].NoOfPoints - 1)
                        Near2 = true;
                }

                X1 = XY.X;
                X2 = XY.Y;
                if (Near1 & Near2)
                {
                    AuxLine.GLPoints[M] = moduleLINES.Lines[Ln].GLPoints[N];
                    return SmoothThisLineRet;
                }

                XN = moduleLINES.Lines[Ln].GLPoints[N].lon;
                YN = moduleLINES.Lines[Ln].GLPoints[N].lat;
                V1X = XN - moduleLINES.Lines[Ln].GLPoints[N - 1].lon;
                V1Y = YN - moduleLINES.Lines[Ln].GLPoints[N - 1].lat;
                V1X = V1X / X1;
                V1Y = V1Y / X1;
                V2X = moduleLINES.Lines[Ln].GLPoints[N + 1].lon - XN;
                V2Y = moduleLINES.Lines[Ln].GLPoints[N + 1].lat - YN;
                V2X = V2X / X2;
                V2Y = V2Y / X2;
                if (!Near1)
                {
                    VX = 3d * V1X + V2X;
                    VY = 3d * V1Y + V2Y;
                    X = VX * VX;
                    X = X + VY * VY;
                    X = Math.Sqrt(X) * 3d / X1;
                    VX = VX / X;
                    VY = VY / X;
                    AuxLine.GLPoints[M].lon = XN - VX;
                    AuxLine.GLPoints[M].lat = YN - VY;
                    AuxLine.GLPoints[M].alt = (2d * moduleLINES.Lines[Ln].GLPoints[N].alt + moduleLINES.Lines[Ln].GLPoints[N - 1].alt) / 3d;
                    AuxLine.GLPoints[M].wid = (2d * moduleLINES.Lines[Ln].GLPoints[N].wid + moduleLINES.Lines[Ln].GLPoints[N - 1].wid) / 3d;
                    M = M + 1;
                    SmoothThisLineRet = 2;
                }

                AuxLine.GLPoints[M] = moduleLINES.Lines[Ln].GLPoints[N];
                if (!Near2)
                {
                    M = M + 1;
                    VX = 3d * V2X + V1X;
                    VY = 3d * V2Y + V1Y;
                    X = VX * VX;
                    X = X + VY * VY;
                    X = Math.Sqrt(X) * 3d / X2;
                    VX = VX / X;
                    VY = VY / X;
                    AuxLine.GLPoints[M].lon = XN + VX;
                    AuxLine.GLPoints[M].lat = YN + VY;
                    AuxLine.GLPoints[M].alt = (2d * moduleLINES.Lines[Ln].GLPoints[N].alt + moduleLINES.Lines[Ln].GLPoints[N + 1].alt) / 3d;
                    AuxLine.GLPoints[M].wid = (2d * moduleLINES.Lines[Ln].GLPoints[N].wid + moduleLINES.Lines[Ln].GLPoints[N + 1].wid) / 3d;
                    SmoothThisLineRet = SmoothThisLineRet + 1;
                }
            }
            catch(Exception e)
            {
            }
            return SmoothThisLineRet;
        }

        private moduleMAIN.Double_XY Get2DistancesLine(int N, ref bool Near1, ref bool Near2, int Ln)
        {
            moduleMAIN.Double_XY Get2DistancesLineRet = default;
            double X, X1, Y1, Y;
            double MPD;
            double VX1, VY1;
            double VX2, VY2;

            // N is the point to check and Ln is the line to check

            // computes on .X the distance between N and N-1
            // if distance is less then specified then returns Near1=true

            // computes on .Y the distance between N and N+1
            // if distance is less then specified then returns Near2=true

            Near1 = true;
            Near2 = true;

            try
            {
                MPD = moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                VX1 = moduleLINES.Lines[Ln].GLPoints[N].lon - moduleLINES.Lines[Ln].GLPoints[N - 1].lon;
                X = VX1 * MPD;
                X1 = VX1 * VX1;
                X = X * X;
                VY1 = moduleLINES.Lines[Ln].GLPoints[N].lat - moduleLINES.Lines[Ln].GLPoints[N - 1].lat;
                Y = VY1 * moduleMAIN.MetersPerDegLat;
                Y1 = VY1 * VY1;
                Y = Y * Y;
                X = X + Y;
                Y = X1 + Y1;
                Y = Math.Sqrt(Y);
                Get2DistancesLineRet.X = Y;
                VX1 = VX1 / Y;
                VY1 = VY1 / Y;
                if (X > SquareSmoothDistance)
                    Near1 = false;
                VX2 = moduleLINES.Lines[Ln].GLPoints[N + 1].lon - moduleLINES.Lines[Ln].GLPoints[N].lon;
                X = VX2 * MPD;
                X1 = VX2 * VX2;
                X = X * X;
                VY2 = moduleLINES.Lines[Ln].GLPoints[N + 1].lat - moduleLINES.Lines[Ln].GLPoints[N].lat;
                Y = VY2 * moduleMAIN.MetersPerDegLat;
                Y1 = VY2 * VY2;
                Y = Y * Y;
                X = X + Y;
                Y = X1 + Y1;
                Y = Math.Sqrt(Y);
                Get2DistancesLineRet.Y = Y;
                VX2 = VX2 / Y;
                VY2 = VY2 / Y;
                if (X > SquareSmoothDistance)
                    Near2 = false;

                // now get cos(v1 v2) in X

                X = VX1 * VX2 + VY1 * VY2;
                if (X > 0.995d)
                {
                    Near1 = true;
                    Near2 = true;
                }

                if (moduleMAIN.CornerSmooth)
                {
                    if (X < -0.25d)
                    {
                        Near1 = true;
                        Near2 = true;
                    }
                }
            }
            catch(Exception e)
            {
            }
            return Get2DistancesLineRet;
        }

        private int SmoothThisPoly(ref modulePOLYS.GPoly AuxPoly, int N, int M, int Pl)
        {
            int SmoothThisPolyRet = default;

            // N is the point in Pl
            // M is the point in AuxPoly
            // returns 1 2 or 3

            double X1, X2, X, Y, Y2;
            double XN, YN;
            double V1X, V1Y;
            double V2X, V2Y;
            double VX, VY;
            bool Near1 = default, Near2 = default;
            moduleMAIN.Double_XY XY;
            int NP;

            try
            {
                SmoothThisPolyRet = 1;
                XY = Get2DistancesPoly(N, ref Near1, ref Near2, Pl);
                X1 = XY.X;
                X2 = XY.Y;
                if (Near1 & Near2)
                {
                    AuxPoly.GPoints[M] = modulePOLYS.Polys[Pl].GPoints[N];
                    return SmoothThisPolyRet;
                }

                XN = modulePOLYS.Polys[Pl].GPoints[N].lon;
                YN = modulePOLYS.Polys[Pl].GPoints[N].lat;
                NP = modulePOLYS.Polys[Pl].NoOfPoints;
                if (N == 1)
                {
                    V1X = XN - modulePOLYS.Polys[Pl].GPoints[NP].lon;
                    V1Y = YN - modulePOLYS.Polys[Pl].GPoints[NP].lat;
                }
                else
                {
                    V1X = XN - modulePOLYS.Polys[Pl].GPoints[N - 1].lon;
                    V1Y = YN - modulePOLYS.Polys[Pl].GPoints[N - 1].lat;
                }

                V1X = V1X / X1;
                V1Y = V1Y / X1;
                if (N == NP)
                {
                    V2X = modulePOLYS.Polys[Pl].GPoints[1].lon - XN;
                    V2Y = modulePOLYS.Polys[Pl].GPoints[1].lat - YN;
                }
                else
                {
                    V2X = modulePOLYS.Polys[Pl].GPoints[N + 1].lon - XN;
                    V2Y = modulePOLYS.Polys[Pl].GPoints[N + 1].lat - YN;
                }

                V2X = V2X / X2;
                V2Y = V2Y / X2;
                if (!Near1)
                {
                    VX = 3d * V1X + V2X;
                    VY = 3d * V1Y + V2Y;
                    X = VX * VX;
                    X = X + VY * VY;
                    X = Math.Sqrt(X) * 3d / X1;
                    VX = VX / X;
                    VY = VY / X;
                    AuxPoly.GPoints[M].lon = XN - VX;
                    AuxPoly.GPoints[M].lat = YN - VY;
                    M = M + 1;
                    SmoothThisPolyRet = 2;
                }

                AuxPoly.GPoints[M] = modulePOLYS.Polys[Pl].GPoints[N];
                if (!Near2)
                {
                    M = M + 1;
                    VX = 3d * V2X + V1X;
                    VY = 3d * V2Y + V1Y;
                    X = VX * VX;
                    X = X + VY * VY;
                    X = Math.Sqrt(X) * 3d / X2;
                    VX = VX / X;
                    VY = VY / X;
                    AuxPoly.GPoints[M].lon = XN + VX;
                    AuxPoly.GPoints[M].lat = YN + VY;
                    SmoothThisPolyRet = SmoothThisPolyRet + 1;
                }
            }
            catch(Exception e)
            {
            }

            return SmoothThisPolyRet;
        }

        private moduleMAIN.Double_XY Get2DistancesPoly(int N, ref bool Near1, ref bool Near2, int Pl)
        {
            moduleMAIN.Double_XY Get2DistancesPolyRet = default;
            double X, X1, Y1, Y;
            double MPD;
            double VX1, VY1;
            double VX2, VY2;
            int K, M;

            // N is the point to check and Pl is the poly to check

            // computes on .X the distance between N and N-1
            // if distance is less then specified then returns Near1=true

            // computes on .Y the distance between N and N+1
            // if distance is less then specified then returns Near2=true

            Near1 = true;
            Near2 = true;
            M = N - 1;
            K = N + 1;
            if (N == modulePOLYS.Polys[Pl].NoOfPoints)
                K = 1;
            if (N == 1)
                M = modulePOLYS.Polys[Pl].NoOfPoints;

            try
            {
                MPD = moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
                VX1 = modulePOLYS.Polys[Pl].GPoints[N].lon - modulePOLYS.Polys[Pl].GPoints[M].lon;
                X = VX1 * MPD;
                X1 = VX1 * VX1;
                X = X * X;
                VY1 = modulePOLYS.Polys[Pl].GPoints[N].lat - modulePOLYS.Polys[Pl].GPoints[M].lat;
                Y = VY1 * moduleMAIN.MetersPerDegLat;
                Y1 = VY1 * VY1;
                Y = Y * Y;
                X = X + Y;
                Y = X1 + Y1;
                Y = Math.Sqrt(Y);
                Get2DistancesPolyRet.X = Y;
                VX1 = VX1 / Y;
                VY1 = VY1 / Y;
                if (X > SquareSmoothDistance)
                    Near1 = false;
                VX2 = modulePOLYS.Polys[Pl].GPoints[K].lon - modulePOLYS.Polys[Pl].GPoints[N].lon;
                X = VX2 * MPD;
                X1 = VX2 * VX2;
                X = X * X;
                VY2 = modulePOLYS.Polys[Pl].GPoints[K].lat - modulePOLYS.Polys[Pl].GPoints[N].lat;
                Y = VY2 * moduleMAIN.MetersPerDegLat;
                Y1 = VY2 * VY2;
                Y = Y * Y;
                X = X + Y;
                Y = X1 + Y1;
                Y = Math.Sqrt(Y);
                Get2DistancesPolyRet.Y = Y;
                VX2 = VX2 / Y;
                VY2 = VY2 / Y;
                if (X > SquareSmoothDistance)
                    Near2 = false;

                // now get cos(v1 v2) in X

                X = VX1 * VX2 + VY1 * VY2;
                if (X > 0.995d)
                {
                    Near1 = true;
                    Near2 = true;
                }

                if (moduleMAIN.CornerSmooth)
                {
                    if (X < -0.25d)
                    {
                        Near1 = true;
                        Near2 = true;
                    }
                }
            }
            catch(Exception e)
            {
            }
            return Get2DistancesPolyRet;
        }
    }
}