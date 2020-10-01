using System;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmAltitudePoly
    {
        public FrmAltitudePoly()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdAlt.Name = "cmdAlt";
            _cmdHelpSlope.Name = "cmdHelpSlope";
            _cmdSlope.Name = "cmdSlope";
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmLPAltitude_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void LoadForm()
        {
            int N;
            double X, Y;
            bool Flag = false;
            int n0 = default, n1 = default, n2 = default;
            double k1 = default, k2 = default, k3 = default;
            double lat = default(double);
            double sxy = default, head = default;
            X = 0d;
            Y = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[1].alt;
            int loopTo = modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfPoints;
            for (N = 1; N <= loopTo; N++)
            {
                X = X + modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[N].alt;
                if (Y != modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[N].alt)
                    Flag = true;
            }

            txtAlt.Text = (X / modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfPoints).ToString();
            if (Flag == false)
            {
                txtHead.Text = 0.ToString();
                txtSlope.Text = 0.ToString();
                txtAlt0.Text = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[1].alt.ToString();
                txtPt0.Text = 1.ToString();
                return;
            }

            Get3Points(modulePOPUP.POPIndex, ref n0, ref n1, ref n2, ref lat);
            GetSlopes(modulePOPUP.POPIndex, n0, n1, n2, ref k1, ref k2, ref k3);
            GetMaximumSlope(k1, k2, lat, ref sxy, ref head);
            txtHead.Text = head.ToString();
            txtSlope.Text = (sxy * 1000d).ToString();
            txtAlt0.Text = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[n1].alt.ToString();
            txtPt0.Text = n1.ToString();
            string k1s = k1.ToString();
            string k2s = k2.ToString();
            lbSX.Text = "SlopeX = " + ((k1s.Length < 13) ? k1s : k1s.Substring(0, 13));
            lbSY.Text = "SlopeY = " + ((k2s.Length < 13) ? k2s : k2s.Substring(0, 13));
        }

        private void CmdSlope_Click(object sender, EventArgs e)
        {
            int N;
            if (modulePOPUP.POPMode == "One")
            {
                SetPolyAltitudes(modulePOPUP.POPIndex);
            }
            else
            {
                int loopTo = modulePOLYS.NoOfPolys;
                for (N = 1; N <= loopTo; N++)
                {
                    if (modulePOLYS.Polys[N].Selected & modulePOLYS.Polys[N].NoOfChilds >= 0)
                    {
                        SetPolyAltitudes(N);
                    }
                }
            }

            LoadForm();
        }

        private void SetPolyAltitudes(int N)
        {
            double Head, lat, lon, sxy;
            double k1, k2, k3;
            double x0, y0, z0;
            int P;
            int K, J;
            Head = Convert.ToDouble(txtHead.Text);
            sxy = Convert.ToDouble(txtSlope.Text);
            lat = 0d;
            int loopTo = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                lat = lat + modulePOLYS.Polys[N].GPoints[K].lat;
            lat = lat / modulePOLYS.Polys[N].NoOfPoints;
            Head = Head * moduleMAIN.PI / 180.0d;
            sxy = sxy / 1000.0d;
            k1 = sxy * Math.Sin(Head);
            k2 = sxy * Math.Cos(Head);
            k1 = k1 * moduleMAIN.MetersPerDegLon(lat);
            k2 = k2 * moduleMAIN.MetersPerDegLat;
            P = Convert.ToInt32(txtPt0.Text);
            x0 = modulePOLYS.Polys[N].GPoints[P].lon;
            y0 = modulePOLYS.Polys[N].GPoints[P].lat;
            z0 = Convert.ToDouble(txtAlt0.Text);
            k3 = z0 - k1 * x0 - k2 * y0;
            int loopTo1 = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo1; K++)
            {
                lat = modulePOLYS.Polys[N].GPoints[K].lat;
                lon = modulePOLYS.Polys[N].GPoints[K].lon;
                modulePOLYS.Polys[N].GPoints[K].alt = k1 * lon + k2 * lat + k3;
            }

            int loopTo2 = modulePOLYS.Polys[N].NoOfChilds;
            for (P = 1; P <= loopTo2; P++)
            {
                J = modulePOLYS.Polys[N].Childs[P];
                int loopTo3 = modulePOLYS.Polys[J].NoOfPoints;
                for (K = 1; K <= loopTo3; K++)
                {
                    lat = modulePOLYS.Polys[J].GPoints[K].lat;
                    lon = modulePOLYS.Polys[J].GPoints[K].lon;
                    modulePOLYS.Polys[J].GPoints[K].alt = k1 * lon + k2 * lat + k3;
                }
            }
        }

        private void CmdAlt_Click(object sender, EventArgs e)
        {
            int N;
            double X;

            try
            {
                X = Convert.ToDouble(txtAlt.Text);
                if (modulePOPUP.POPMode == "One")
                {
                    SetConstantAltitude(modulePOPUP.POPIndex, X);
                }
                else
                {
                    int loopTo = modulePOLYS.NoOfPolys;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected & modulePOLYS.Polys[N].NoOfChilds >= 0)
                        {
                            SetConstantAltitude(N, X);
                        }
                    }
                }

                LoadForm();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check altitude value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetConstantAltitude(int N, double H)
        {
            int K, P, J;
            int loopTo = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                modulePOLYS.Polys[N].GPoints[K].alt = H;
            int loopTo1 = modulePOLYS.Polys[N].NoOfChilds;
            for (P = 1; P <= loopTo1; P++)
            {
                J = modulePOLYS.Polys[N].Childs[P];
                int loopTo2 = modulePOLYS.Polys[J].NoOfPoints;
                for (K = 1; K <= loopTo2; K++)
                    modulePOLYS.Polys[J].GPoints[K].alt = H;
            }
        }

        private void CmdHelpSlope_Click(object sender, EventArgs e)
        {
            string A;
            A = "In this mode you specify: (i) the altitude and index of one" + Environment.NewLine;
            A = A + "point (ii) the heading of maximum slope and (iii) the maximum" + Environment.NewLine;
            A = A + "slope expressed as the altitude increase in meters per one" + Environment.NewLine;
            A = A + "thousand meters of horizontal shift.";
            MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Get3Points(int N, ref int N1, ref int N2, ref int N3, ref double lat)
        {
            int NP, J, K;
            double X1, X2, DX, DY, D;
            NP = modulePOLYS.Polys[N].NoOfPoints;
            N1 = 1;
            N2 = 1;
            X1 = modulePOLYS.Polys[N].GPoints[1].lon;
            X2 = modulePOLYS.Polys[N].GPoints[1].lon;
            lat = 0d;
            int loopTo = NP;
            for (J = 1; J <= loopTo; J++)
            {
                lat = lat + modulePOLYS.Polys[N].GPoints[J].lat;
                if (modulePOLYS.Polys[N].GPoints[J].lon < X1)
                {
                    N1 = J;
                    X1 = modulePOLYS.Polys[N].GPoints[J].lon;
                }

                if (modulePOLYS.Polys[N].GPoints[J].lon > X2)
                {
                    N2 = J;
                    X2 = modulePOLYS.Polys[N].GPoints[J].lon;
                }
            }

            lat = lat / NP;
            X1 = modulePOLYS.Polys[N].GPoints[N1].lon - modulePOLYS.Polys[N].GPoints[N2].lon;
            X1 = X1 * X1;
            X2 = modulePOLYS.Polys[N].GPoints[N1].lat - modulePOLYS.Polys[N].GPoints[N2].lat;
            X2 = X2 * X2;
            D = Math.Sqrt(X1 + X2);
            int loopTo1 = NP;
            for (K = 1; K <= loopTo1; K++)
            {
                if (K != N1 & K != N2)
                {
                    X1 = modulePOLYS.Polys[N].GPoints[N1].lon - modulePOLYS.Polys[N].GPoints[K].lon;
                    X1 = X1 * X1;
                    X2 = modulePOLYS.Polys[N].GPoints[N1].lat - modulePOLYS.Polys[N].GPoints[K].lat;
                    X2 = X2 * X2;
                    DX = Math.Sqrt(X1 + X2);
                    X1 = modulePOLYS.Polys[N].GPoints[N2].lon - modulePOLYS.Polys[N].GPoints[K].lon;
                    X1 = X1 * X1;
                    X2 = modulePOLYS.Polys[N].GPoints[N2].lat - modulePOLYS.Polys[N].GPoints[K].lat;
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

        private void GetSlopes(int N, int N0, int N1, int N2, ref double K1, ref double K2, ref double K3)
        {
            double z00, z01, z02;
            double x00, x01, x02;
            double y00, y01, y02;
            double a1, a2;
            x01 = modulePOLYS.Polys[N].GPoints[N0].lon - modulePOLYS.Polys[N].GPoints[N1].lon;
            x02 = modulePOLYS.Polys[N].GPoints[N0].lon - modulePOLYS.Polys[N].GPoints[N2].lon;
            y01 = modulePOLYS.Polys[N].GPoints[N0].lat - modulePOLYS.Polys[N].GPoints[N1].lat;
            y02 = modulePOLYS.Polys[N].GPoints[N0].lat - modulePOLYS.Polys[N].GPoints[N2].lat;
            z01 = modulePOLYS.Polys[N].GPoints[N0].alt - modulePOLYS.Polys[N].GPoints[N1].alt;
            z02 = modulePOLYS.Polys[N].GPoints[N0].alt - modulePOLYS.Polys[N].GPoints[N2].alt;
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

            K3 = modulePOLYS.Polys[N].GPoints[N0].alt - K1 * modulePOLYS.Polys[N].GPoints[N0].lon - K2 * modulePOLYS.Polys[N].GPoints[N0].lat;
        }

        private void GetMaximumSlope(double k1, double k2, double lat, ref double sxy, ref double head)
        {
            double sx, sy;
            sxy = 0d;
            head = 0d;
            if (k1 == 0d & k2 == 0d)
                return;
            sx = k1 / moduleMAIN.MetersPerDegLon(lat);
            sy = k2 / moduleMAIN.MetersPerDegLat;
            sxy = Math.Sqrt(sx * sx + sy * sy);
            head = 0d;
            if (sx == 0d)
            {
                if (sy > 0d)
                {
                    head = 0d;
                    return;
                }
                else
                {
                    head = 180d;
                    return;
                }
            }

            if (sy == 0d)
            {
                if (sx > 0d)
                {
                    head = 90d;
                    return;
                }
                else
                {
                    head = 270d;
                    return;
                }
            }

            if (sx > 0d)
            {
                head = 90d - Math.Atan(sy / sx) * 180d / moduleMAIN.PI;
                return;
            }
            else
            {
                head = 270d - Math.Atan(sy / sx) * 180d / moduleMAIN.PI;
                return;
            }
        }
    }
}