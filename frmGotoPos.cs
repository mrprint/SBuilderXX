using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmGotoPos
    {
        public FrmGotoPos()
        {
            InitializeComponent();
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
            _txtLat.Name = "txtLat";
            _txtLon.Name = "txtLon";
            _txtU.Name = "txtU";
            _txtV.Name = "txtV";
            _txtL.Name = "txtL";
            _cmdCheck.Name = "cmdCheck";
        }

        internal bool CheckGeo;
        internal double X0, Y0;
        internal int L0, U0, V0;

        private void FrmGotoPos_Load(object sender, EventArgs e)
        {
            Text = "SBuilderX - Goto this position";
            X0 = moduleMAIN.LonDispCenter;
            Y0 = moduleMAIN.LatDispCenter;
            L0 = moduleMAIN.Zoom;
            FillValues(X0, Y0, L0, U0, V0);
        }

        private void FillValues(double X, double Y, int L, int U, int V)
        {
            X0 = X;
            Y0 = Y;
            L0 = L;
            U0 = U;
            V0 = V;
            txtLon.Text = moduleMAIN.Lon2Str(X);
            txtLat.Text = moduleMAIN.Lat2Str(Y);
            txtU.Text = U.ToString();
            txtV.Text = V.ToString();
            txtL.Text = L.ToString();
        }

        private void ValidateGeo()
        {
            double X, Y;
            bool Good = true;
            int U, V, L;
            int PU, PV;

            try
            {
                L = (int)Convert.ToSingle(txtL.Text);
                if (L < 0)
                    Good = false;
                if (L > 25)
                    Good = false;
                Y = moduleMAIN.Str2Lat(txtLat.Text);
                if (Y > 90d)
                    Good = false;
                if (Y < -90)
                    Good = false;
                X = moduleMAIN.Str2Lon(txtLon.Text);
                if (X > 180d)
                    Good = false;
                if (X < -180)
                    Good = false;
                if (Good)
                {
                    PU = (int)(3d * Math.Pow(2d, L));
                    PV = (int)(2d * Math.Pow(2d, L));
                    U = (int)(PU * (X + 180d) / 360d);
                    V = (int)(PV * (90d - Y) / 180d);
                    FillValues(X, Y, L, U, V);
                }
                else
                {
                    FillValues(X0, Y0, L0, U0, V0);
                    MessageBox.Show("Check your entry!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return;
            }
            catch (Exception)
            {
                FillValues(X0, Y0, L0, U0, V0);
                MessageBox.Show("Check your entry!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ValidateUV()
        {
            double X, Y;
            bool Good = true;
            int PU, PV;
            int L, U, V;

            try
            {
                L = (int)Convert.ToSingle(txtL.Text);
                U = (int)Convert.ToSingle(txtU.Text);
                V = (int)Convert.ToSingle(txtV.Text);
                if (L < 0)
                    Good = false;
                if (L > 27)
                    Good = false;
                PU = (int)(3d * Math.Pow(2d, L));
                PV = (int)(2d * Math.Pow(2d, L));
                if (U > PU - 1)
                    Good = false;
                if (U < 0)
                    Good = false;
                if (V > PV - 1)
                    Good = false;
                if (V < 0)
                    Good = false;
                if (Good)
                {
                    X = 360d * (U + 0.5d) / PU - 180d;
                    Y = 90d - 180d * (V + 0.5d) / PV;
                    FillValues(X, Y, L, U, V);
                }
                else
                {
                    FillValues(X0, Y0, L0, U0, V0);
                    MessageBox.Show("Check your entry!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                return;
            }
            catch (Exception)
            {
                FillValues(X0, Y0, L0, U0, V0);
                MessageBox.Show("Check your entry!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdCheck_Click(object sender, EventArgs e)
        {
            if (CheckGeo)
            {
                ValidateGeo();
            }
            else
            {
                ValidateUV();
            }
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            moduleMAIN.LonDispCenter = moduleMAIN.Str2Lon(txtLon.Text);
            moduleMAIN.LatDispCenter = moduleMAIN.Str2Lat(txtLat.Text);
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
            Dispose();
        }

        private void TxtLat_LostFocus(object sender, EventArgs e)
        {
            CheckGeo = true;
        }

        private void TxtLon_LostFocus(object sender, EventArgs e)
        {
            CheckGeo = true;
        }

        private void TxtU_LostFocus(object sender, EventArgs e)
        {
            CheckGeo = false;
        }

        private void TxtV_LostFocus(object sender, EventArgs e)
        {
            CheckGeo = false;
        }

        private void TxtL_LostFocus(object sender, EventArgs e)
        {
            CheckGeo = false;
        }
    }
}