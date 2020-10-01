using System;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmSHPPoly
    {
        public FrmSHPPoly()
        {
            InitializeComponent();
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
            _txtGUID.Name = "txtGUID";
            _cmbGUID.Name = "cmbGUID";
            _lbColor.Name = "lbColor";
            _cmbAltitude.Name = "cmbAltitude";
            _cmbColor.Name = "cmbColor";
            _cmbName.Name = "cmbName";
        }

        private void FrmSHPPoly_FormClosing(object sender, FormClosingEventArgs e)
        {
            int N;
            if (moduleSHAPE.IsZ)
            {
                cmbAltitude.Items.Remove("From Shape file");
            }

            int loopTo = moduleSHAPE.NoOfFields;
            for (N = 1; N <= loopTo; N++)
            {
                cmbName.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
                cmbGUID.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
                cmbColor.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
                cmbAltitude.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
            }
        }

        private void FrmSHPPoly_Load(object sender, EventArgs e)
        {
            int N;
            if (moduleSHAPE.IsZ)
            {
                cmbAltitude.Items.Add("From Shape file");
            }

            int loopTo = moduleSHAPE.NoOfFields;
            for (N = 1; N <= loopTo; N++)
            {
                cmbName.Items.Add(moduleSHAPE.FieldNames[N - 1]);
                cmbGUID.Items.Add(moduleSHAPE.FieldNames[N - 1]);
                cmbColor.Items.Add(moduleSHAPE.FieldNames[N - 1]);
                cmbAltitude.Items.Add(moduleSHAPE.FieldNames[N - 1]);
            }

            cmbName.SelectedIndex = 0;
            int loopTo1 = moduleSHAPE.NoOfFields - 1;
            for (N = 0; N <= loopTo1; N++)
            {
                if (moduleSHAPE.FieldNames[N].ToUpper() == "NAME")
                {
                    cmbName.SelectedIndex = N + 1;
                    break;
                }
            }

            cmbGUID.SelectedIndex = 0;
            int loopTo2 = moduleSHAPE.NoOfFields - 1;
            for (N = 0; N <= loopTo2; N++)
            {
                if (moduleSHAPE.FieldNames[N].ToUpper() == "GUID")
                {
                    cmbGUID.SelectedIndex = N + 1;
                    break;
                }
            }

            cmbColor.SelectedIndex = 0;
            int loopTo3 = moduleSHAPE.NoOfFields - 1;
            for (N = 0; N <= loopTo3; N++)
            {
                if (moduleSHAPE.FieldNames[N].ToUpper() == "COLOR")
                {
                    cmbColor.SelectedIndex = N + 1;
                    break;
                }
            }

            if (moduleSHAPE.IsZ)
            {
                cmbAltitude.SelectedIndex = 1;
                txtAltitude.Enabled = false;
            }
            else
            {
                cmbAltitude.SelectedIndex = 0;
                int loopTo4 = moduleSHAPE.NoOfFields - 1;
                for (N = 0; N <= loopTo4; N++)
                {
                    if (moduleSHAPE.FieldNames[N].ToUpper() == "ALTITUDE")
                    {
                        cmbAltitude.SelectedIndex = N + 1;  // was + 2 before scott
                        break;
                    }
                }
            }

            txtGUID.Text = moduleSHAPE.ShapePolyGuid;
            txtAltitude.Text = moduleSHAPE.ShapePolyAltitude.ToString();
            lbColor.BackColor = moduleSHAPE.ShapePolyColor;
        }

        private void CmbAltitude_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAltitude.SelectedIndex == 0)
            {
                txtAltitude.Enabled = true;
            }
            else
            {
                txtAltitude.Enabled = false;
            }
        }

        private void CmbGUID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGUID.SelectedIndex == 0)
            {
                txtGUID.Enabled = true;
            }
            else
            {
                txtGUID.Enabled = false;
            }
        }

        private void CmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbColor.SelectedIndex == 0)
            {
                lbColor.Visible = true;
            }
            else
            {
                lbColor.Visible = false;
            }
        }

        private void CmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedIndex == 0)
            {
                txtName.Enabled = true;
            }
            else
            {
                txtName.Enabled = false;
            }
        }

        private void LbColor_Click(object sender, EventArgs e)
        {

            // frmStart.ColorDialog1.Color = lbColor.BackColor
            // ' Update the color if the user clicks OK 
            // If frmStart.ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            // lbColor.BackColor = frmStart.ColorDialog1.Color
            // End If

            moduleMAIN.ARGBColor = lbColor.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                lbColor.BackColor = moduleMAIN.ARGBColor;
            }
        }

        private void TxtGUID_Click(object sender, EventArgs e)
        {
            modulePOPUP.POPMode = "SHP";
            My.MyProject.Forms.FrmPolysP.ShowDialog();
            txtGUID.Text = moduleSHAPE.ShapePolyGuid;
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            moduleSHAPE.ShapePolyGuid = txtGUID.Text;
            moduleSHAPE.ShapePolyName = txtName.Text;
            moduleSHAPE.ShapePolyAltitude = Convert.ToDouble(txtAltitude.Text);
            moduleSHAPE.ShapePolyColor = lbColor.BackColor;
            moduleSHAPE.ShapePolyGuidField = cmbGUID.SelectedIndex;
            moduleSHAPE.ShapePolyNameField = cmbName.SelectedIndex;
            moduleSHAPE.ShapePolyAltitudeField = cmbAltitude.SelectedIndex;
            moduleSHAPE.ShapePolyColorField = cmbColor.SelectedIndex;
            moduleSHAPE.ShapePolyCancel = false;

            // WriteShapesSettings()
            moduleFILE_IO.WriteSettings();
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            moduleSHAPE.ShapePolyCancel = true;
            Dispose();
        }
    }
}