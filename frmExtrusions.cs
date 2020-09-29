using System;

namespace SBuilderX
{
    public partial class FrmExtrusions
    {
        public FrmExtrusions()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _cmdSetHeight.Name = "cmdSetHeight";
        }

        private void FrmExtrusions_Load(object sender, EventArgs e)
        {
            cmbComplexity.SelectedIndex = My.MyProject.Forms.FrmLinesP.Complexity;
            txtProfileGuid.Text = My.MyProject.Forms.FrmLinesP.ProfileGuid;
            txtMaterialGuid.Text = My.MyProject.Forms.FrmLinesP.MaterialGuid;
            txtPylonGuid.Text = My.MyProject.Forms.FrmLinesP.PylonGuid;
            txtWidth.Text = My.MyProject.Forms.FrmLinesP.ExtrusionWidth.ToString();
            txtProbability.Text = My.MyProject.Forms.FrmLinesP.ExtrusionProbability.ToString();
            ckSuppress.Checked = false;
            if (My.MyProject.Forms.FrmLinesP.SuppressPlatform)
                ckSuppress.Checked = true;
            if (moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints < 4)
            {
                boxHeight.Enabled = false;
                return;
            }

            txtHeight.Text = GetHeight().ToString();
        }

        private double GetHeight()
        {
            double GetHeightRet = default;
            int NP = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
            double[] L = new double[NP + 1];
            L[1] = 0d;
            for (int K = 2, loopTo = NP; K <= loopTo; K++)
                L[K] = L[K - 1] + GetDistanceP1P2(modulePOPUP.POPIndex, K - 1, K);
            double W = L[NP] / 2d;
            if (L[2] > W)
                L[2] = 2d * W - L[2];
            if (L[3] > W)
                L[3] = 2d * W - L[3];
            double a, b, c, d, x, gh;  // now invert a square 2 x 2 matrix
            x = L[2];
            a = x * x;
            b = a * x;
            x = L[3];
            c = x * x;
            d = c * x;
            a = a * d - b * c;
            b = -b / a;
            a = d / a;
            c = a * moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[2].alt + b * moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[3].alt;
            gh = Math.Round(W * W * c / 3d, 2);

            // now the other exterme
            if (L[NP - 1] > W)
                L[NP - 1] = 2d * W - L[NP - 1];
            if (L[NP - 2] > W)
                L[NP - 2] = 2d * W - L[NP - 2];
            x = L[NP - 1];
            a = x * x;
            b = a * x;
            x = L[NP - 2];
            c = x * x;
            d = c * x;
            a = a * d - b * c;
            b = -b / a;
            a = d / a;
            c = a * moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[NP - 1].alt + b * moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[NP - 2].alt;
            GetHeightRet = Math.Round(W * W * c / 3d, 2);
            if (GetHeightRet != gh)
                GetHeightRet = 0d;
            if (GetHeightRet < 0d)
                GetHeightRet = 0d;
            return GetHeightRet;
        }

        private double GetDistanceP1P2(int line, int p1, int p2)
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

        private void CmdSetHeight_Click(object sender, EventArgs e)
        {
            int K, NP;
            NP = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
            double[] L = new double[NP + 1];
            L[1] = 0d;
            int loopTo = NP;
            for (K = 2; K <= loopTo; K++)
                L[K] = L[K - 1] + GetDistanceP1P2(modulePOPUP.POPIndex, K - 1, K);
            double W = L[NP] / 2d;
            double H = Convert.ToDouble(txtHeight.Text);
            double W3 = W * W * W;
            double K1 = 6d * H / W3;
            double K2 = -K1 / 3d;
            K1 = K1 * W / 2d;
            double X2, X3;
            moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[1].alt = 0d;
            int loopTo1 = NP;
            for (K = 2; K <= loopTo1; K++)
            {
                if (L[K] > W)
                    L[K] = 2d * W - L[K];
                X2 = L[K];
                X3 = X2 * X2 * X2;
                X2 = X2 * X2;
                moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[K].alt = K1 * X2 + K2 * X3;
            }
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLinesP.Complexity = cmbComplexity.SelectedIndex;
            My.MyProject.Forms.FrmLinesP.ProfileGuid = txtProfileGuid.Text;
            My.MyProject.Forms.FrmLinesP.MaterialGuid = txtMaterialGuid.Text;
            My.MyProject.Forms.FrmLinesP.PylonGuid = txtPylonGuid.Text;
            My.MyProject.Forms.FrmLinesP.ExtrusionWidth = Convert.ToDouble(txtWidth.Text);
            My.MyProject.Forms.FrmLinesP.ExtrusionProbability = Convert.ToDouble(txtProbability.Text);
            My.MyProject.Forms.FrmLinesP.SuppressPlatform = false;
            if (ckSuppress.Checked)
                My.MyProject.Forms.FrmLinesP.SuppressPlatform = true;
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}