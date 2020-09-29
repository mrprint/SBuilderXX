using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmLPSample
    {
        public FrmLPSample()
        {
            InitializeComponent();
            _cmdSample.Name = "cmdSample";
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _txtDistance.Name = "txtDistance";
        }

        private moduleLINES.GLine[] backupLine;
        private modulePOLYS.GPoly[] backupPoly;
        private double SquareSampleDistance;

        private void FrmLPSample_Load(object sender, EventArgs e)
        {
            int N, K = default;
            txtDistance.Text = moduleMAIN.SampleDistance.ToString();
            if (modulePOPUP.POPType == "Line")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    backupLine = new moduleLINES.GLine[1];
                    StoreLine(modulePOPUP.POPIndex, K);
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
                            StoreLine(N, K);
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
                    StorePoly(modulePOPUP.POPIndex, 0);
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
                            StorePoly(N, K);
                            K = K + 1;
                        }
                    }
                }
            }

            SquareSampleDistance = moduleMAIN.SampleDistance * moduleMAIN.SampleDistance;
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
            moduleMAIN.SampleDistance = Convert.ToDouble(txtDistance.Text);
            string argPutKey = "Main";
            string argPutVariable = "SampleDistance";
            string argPutValue = moduleMAIN.SampleDistance.ToString();
            moduleFILE_IO.WriteIniValue(ref moduleMAIN.AppIni, ref argPutKey, ref argPutVariable, ref argPutValue);
            Dispose();
        }

        private void TxtDistance_Click(object sender, EventArgs e)
        {
            moduleMAIN.SampleDistance = Convert.ToDouble(txtDistance.Text);
            SquareSampleDistance = moduleMAIN.SampleDistance * moduleMAIN.SampleDistance;
        }

        private void CmdSample_Click(object sender, EventArgs e)
        {
            int N;
            if (modulePOPUP.POPType == "Line")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    SampleMyLine(modulePOPUP.POPIndex);
                }
                else
                {
                    var loopTo = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            SampleMyLine(N);
                        }
                    }
                }
            }

            if (modulePOPUP.POPType == "Poly")
            {
                if (moduleMAIN.MakeOnMany == 1)
                {
                    SampleMyPoly(modulePOPUP.POPIndex);
                }
                else
                {
                    var loopTo1 = modulePOLYS.NoOfPolys;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected)
                        {
                            SampleMyPoly(N);
                        }
                    }
                }
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SampleMyLine(int Ln)
        {
            int K, N, M;
            var Near = default(bool);
            moduleLINES.GLine auxLine;
            if (moduleLINES.Lines[Ln].NoOfPoints == 2)
                return;
            auxLine = moduleLINES.Lines[Ln];
            K = 1;
            N = 2;
            M = 1;
            do
            {
                GetDistanceLine(N, M, ref Near, Ln);
                if (Near)
                {
                    N = N + 1;
                }
                else
                {
                    K = K + 1;
                    auxLine.GLPoints[K] = moduleLINES.Lines[Ln].GLPoints[N];
                    M = N;
                    N = N + 1;
                }
            }
            while (N < moduleLINES.Lines[Ln].NoOfPoints);
            K = K + 1;
            auxLine.GLPoints[K] = moduleLINES.Lines[Ln].GLPoints[N];
            auxLine.NoOfPoints = K;
            Array.Resize(ref auxLine.GLPoints, K + 1);
            moduleLINES.Lines[Ln] = auxLine;
        }

        private double GetDistanceLine(int N, int M, ref bool Near, int Ln)
        {
            double GetDistanceLineRet = default;
            double X, X1, Y1, Y;

            // N is the point to check
            // based on the the distance between N+1 (the next) and the previous M (N-1 could have been deleted!)
            // returns the distance in degrees
            // if distance is less then specified then returns Near=true

            X1 = moduleLINES.Lines[Ln].GLPoints[N + 1].lon - moduleLINES.Lines[Ln].GLPoints[M].lon;
            X = X1 * moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
            X1 = X1 * X1;
            X = X * X;
            Y1 = moduleLINES.Lines[Ln].GLPoints[N + 1].lat - moduleLINES.Lines[Ln].GLPoints[M].lat;
            Y = Y1 * moduleMAIN.MetersPerDegLat;
            Y1 = Y1 * Y1;
            Y = Y * Y;
            X = X + Y;
            Y = X1 + Y1;
            GetDistanceLineRet = Math.Sqrt(Y);
            Near = true;
            if (X > SquareSampleDistance)
                Near = false;
            return GetDistanceLineRet;
        }

        private void SampleMyPoly(int Pl)
        {
            int K, N, M;
            var Near = default(bool);
            modulePOLYS.GPoly auxPoly;
            auxPoly = modulePOLYS.Polys[Pl];
            K = 1;
            N = 2;
            M = 1;
            do
            {
                GetDistancePoly(N, M, ref Near, Pl);
                if (Near)
                {
                    N = N + 1;
                }
                else
                {
                    K = K + 1;
                    auxPoly.GPoints[K] = modulePOLYS.Polys[Pl].GPoints[N];
                    M = N;
                    N = N + 1;
                }
            }
            while (N < modulePOLYS.Polys[Pl].NoOfPoints);
            K = K + 1;
            auxPoly.GPoints[K] = modulePOLYS.Polys[Pl].GPoints[N];
            auxPoly.NoOfPoints = K;
            Array.Resize(ref auxPoly.GPoints, K + 1);
            if (K < 3)
            {
                MessageBox.Show("Poly # " + Pl + " has 2 points!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Exit Sub
            }

            modulePOLYS.Polys[Pl] = auxPoly;
        }

        private double GetDistancePoly(int N, int M, ref bool Near, int Pl)
        {
            double GetDistancePolyRet = default;
            double X, X1, Y1, y;

            // N is the point to check
            // based on the the distance between N+1 (the next) and the previous M (N-1 could have been deleted!)
            // returns the distance in degrees
            // if distance is less then specified then returns Near=true

            if (N == modulePOLYS.Polys[Pl].NoOfPoints)
                N = 0;
            if (M == 0)
                M = modulePOLYS.Polys[Pl].NoOfPoints;
            X1 = modulePOLYS.Polys[Pl].GPoints[N + 1].lon - modulePOLYS.Polys[Pl].GPoints[M].lon;
            Y1 = modulePOLYS.Polys[Pl].GPoints[N + 1].lat - modulePOLYS.Polys[Pl].GPoints[M].lat;
            X = X1 * moduleMAIN.MetersPerDegLon(moduleMAIN.LatDispCenter);
            X1 = X1 * X1;
            X = X * X;
            y = Y1 * moduleMAIN.MetersPerDegLat;
            Y1 = Y1 * Y1;
            y = y * y;
            X = X + y;
            y = X1 + Y1;
            GetDistancePolyRet = Math.Sqrt(y);
            Near = true;
            if (X > SquareSampleDistance)
                Near = false;
            return GetDistancePolyRet;
        }

        private void StorePoly(int N, int K)
        {
            int J, L;
            backupPoly[K] = modulePOLYS.Polys[N];
            J = modulePOLYS.Polys[N].NoOfPoints;
            backupPoly[K].GPoints = new modulePOINTS.GPoint[J + 1];
            backupPoly[K].NoOfPoints = J;
            var loopTo = J;
            for (L = 1; L <= loopTo; L++)
                backupPoly[K].GPoints[L] = modulePOLYS.Polys[N].GPoints[L];
        }

        private void StoreLine(int N, int K)
        {
            int J, L;
            backupLine[K] = moduleLINES.Lines[N];
            J = moduleLINES.Lines[N].NoOfPoints;
            backupLine[K].GLPoints = new modulePOINTS.GLPoint[J + 1];
            backupLine[K].NoOfPoints = J;
            var loopTo = J;
            for (L = 1; L <= loopTo; L++)
                backupLine[K].GLPoints[L] = moduleLINES.Lines[N].GLPoints[L];
        }
    }
}