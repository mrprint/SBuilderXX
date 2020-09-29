using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmSHPLine
    {
        public FrmSHPLine()
        {
            InitializeComponent();
            _cmbName.Name = "cmbName";
            _lbColor.Name = "lbColor";
            _cmbAltitude.Name = "cmbAltitude";
            _cmbColor.Name = "cmbColor";
            _cmbWidth.Name = "cmbWidth";
            _txtGUID.Name = "txtGUID";
            _cmbGUID.Name = "cmbGUID";
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
        }

        private void FrmSHPLine_FormClosing(object sender, FormClosingEventArgs e)
        {
            int N;
            if (moduleSHAPE.IsZ)
            {
                cmbAltitude.Items.Remove("From Shape file");
            }

            var loopTo = moduleSHAPE.NoOfFields;
            for (N = 1; N <= loopTo; N++)
            {
                cmbName.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
                cmbGUID.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
                cmbWidth.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
                cmbColor.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
                cmbAltitude.Items.Remove(moduleSHAPE.FieldNames[N - 1]);
            }
        }

        private void FrmSHPLine_Load(object sender, EventArgs e)
        {
            int N;
            if (moduleSHAPE.IsZ)
            {
                cmbAltitude.Items.Add("From Shape file");
            }

            var loopTo = moduleSHAPE.NoOfFields;
            for (N = 1; N <= loopTo; N++)
            {
                cmbName.Items.Add(moduleSHAPE.FieldNames[N - 1]);
                cmbGUID.Items.Add(moduleSHAPE.FieldNames[N - 1]);
                cmbWidth.Items.Add(moduleSHAPE.FieldNames[N - 1]);
                cmbColor.Items.Add(moduleSHAPE.FieldNames[N - 1]);
                cmbAltitude.Items.Add(moduleSHAPE.FieldNames[N - 1]);
            }

            cmbName.SelectedIndex = 0;
            var loopTo1 = moduleSHAPE.NoOfFields - 1;
            for (N = 0; N <= loopTo1; N++)
            {
                if (moduleSHAPE.FieldNames[N].ToUpper() == "NAME")
                {
                    cmbName.SelectedIndex = N + 1;
                    break;
                }
            }

            cmbGUID.SelectedIndex = 0;
            var loopTo2 = moduleSHAPE.NoOfFields - 1;
            for (N = 0; N <= loopTo2; N++)
            {
                if (moduleSHAPE.FieldNames[N].ToUpper() == "GUID")
                {
                    cmbGUID.SelectedIndex = N + 1;
                    break;
                }
            }

            cmbWidth.SelectedIndex = 0;
            var loopTo3 = moduleSHAPE.NoOfFields - 1;
            for (N = 0; N <= loopTo3; N++)
            {
                if (moduleSHAPE.FieldNames[N].ToUpper() == "WIDTH")
                {
                    cmbWidth.SelectedIndex = N + 1;
                    break;
                }
            }

            cmbColor.SelectedIndex = 0;
            var loopTo4 = moduleSHAPE.NoOfFields - 1;
            for (N = 0; N <= loopTo4; N++)
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
                var loopTo5 = moduleSHAPE.NoOfFields - 1;
                for (N = 0; N <= loopTo5; N++)
                {
                    if (moduleSHAPE.FieldNames[N].ToUpper() == "ALTITUDE")
                    {
                        cmbAltitude.SelectedIndex = N + 2;
                        break;
                    }
                }
            }

            txtGUID.Text = moduleSHAPE.ShapeLineGuid;
            txtAltitude.Text = moduleSHAPE.ShapeLineAltitude.ToString();
            txtWidth.Text = moduleSHAPE.ShapeLineWidth.ToString();
            lbColor.BackColor = moduleSHAPE.ShapeLineColor;
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

        private void CmbStartWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbWidth.SelectedIndex == 0)
            {
                txtWidth.Enabled = true;
            }
            else
            {
                txtWidth.Enabled = false;
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
            My.MyProject.Forms.FrmLinesP.ShowDialog();
            txtGUID.Text = moduleSHAPE.ShapeLineGuid;
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            moduleSHAPE.ShapeLineGuid = txtGUID.Text;
            moduleSHAPE.ShapeLineName = txtName.Text;
            moduleSHAPE.ShapeLineAltitude = Convert.ToDouble(txtAltitude.Text);
            moduleSHAPE.ShapeLineWidth = Convert.ToDouble(txtWidth.Text);
            moduleSHAPE.ShapeLineColor = lbColor.BackColor;
            moduleSHAPE.ShapeLineGuidField = cmbGUID.SelectedIndex;
            moduleSHAPE.ShapeLineNameField = cmbName.SelectedIndex;
            moduleSHAPE.ShapeLineAltitudeField = cmbAltitude.SelectedIndex;
            moduleSHAPE.ShapeLineWidthField = cmbWidth.SelectedIndex;
            moduleSHAPE.ShapeLineColorField = cmbColor.SelectedIndex;
            moduleSHAPE.ShapeLineCancel = false;

            // WriteShapesSettings()
            moduleFILE_IO.WriteSettings();
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            moduleSHAPE.ShapeLineCancel = true;
            Dispose();
        }
    }
}