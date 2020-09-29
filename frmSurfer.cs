using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmSurfer
    {
        public FrmSurfer()
        {
            InitializeComponent();
            _ckAutoLine.Name = "ckAutoLine";
            _ckLineAltitude.Name = "ckLineAltitude";
            _cmdCancel.Name = "cmdCancel";
            _cmdContinue.Name = "cmdContinue";
            _lbLineColor.Name = "lbLineColor";
            _txtLineGuid.Name = "txtLineGuid";
            _lbPolyColor.Name = "lbPolyColor";
            _ckPolyAltitude.Name = "ckPolyAltitude";
            _txtPolyGuid.Name = "txtPolyGuid";
        }

        private void FrmSurfer_Load(object sender, EventArgs e)
        {
            txtStartW.Text = moduleSURFER.BLNStartWidth.ToString();
            txtEndW.Text = moduleSURFER.BLNEndWidth.ToString();
            txtLineGuid.Text = moduleSURFER.BLNLineGuid;
            txtPolyGuid.Text = moduleSURFER.BLNPolyGuid;
            lbLineColor.BackColor = moduleSURFER.BLNLineColor;
            lbPolyColor.BackColor = moduleSURFER.BLNPolyColor;
            ckAutoLine.Checked = moduleSURFER.BLNLineFromPoly;
            ckLineAltitude.Checked = moduleSURFER.BLNIsLineAlt;
            ckPolyAltitude.Checked = moduleSURFER.BLNIsPolyAlt;
        }

        private void CmdContinue_Click(object sender, EventArgs e)
        {
            string A, B;
            double W1, W2;
            try
            {
                W1 = Convert.ToDouble(txtStartW.Text);
                W2 = Convert.ToDouble(txtEndW.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Check width values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            moduleSURFER.BLNStartWidth = W1;
            moduleSURFER.BLNEndWidth = W2;
            moduleSURFER.BLNLineGuid = txtLineGuid.Text;
            moduleSURFER.BLNPolyGuid = txtPolyGuid.Text;
            moduleSURFER.BLNLineType = GetLineTypeFromGuid(moduleSURFER.BLNLineGuid);
            moduleSURFER.BLNPolyType = GetPolyTypeFromGuid(moduleSURFER.BLNPolyGuid);
            moduleSURFER.BLNLineColor = lbLineColor.BackColor;
            moduleSURFER.BLNPolyColor = lbPolyColor.BackColor;
            moduleSURFER.BLNLineFromPoly = ckAutoLine.Checked;
            moduleSURFER.BLNIsLineAlt = ckLineAltitude.Checked;
            moduleSURFER.BLNIsPolyAlt = ckPolyAltitude.Checked;
            Hide();

            // WriteBLNSettings()
            moduleFILE_IO.WriteSettings();
            A = "Surfer File (*.BLN)|*.BLN";
            B = "SBuilderX: Append Surfer File";
            A = moduleFILE_IO.FileNameToOpen(A, B, "SUR");
            if (string.IsNullOrEmpty(A))
            {
                Dispose();
                return;
            }

            moduleSURFER.AppendSurfer(ref A);
            moduleMAIN.Dirty = false;
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CkAutoLine_CheckStateChanged(object eventSender, EventArgs eventArgs)
        {
            if ((int)ckAutoLine.CheckState == 1)
            {
                moduleSURFER.BLNLineFromPoly = true;
            }
            else
            {
                moduleSURFER.BLNLineFromPoly = false;
            }
        }

        private void CkPolyAltitude_CheckStateChanged(object sender, EventArgs e)
        {
            if ((int)ckPolyAltitude.CheckState == 1)
            {
                moduleSURFER.BLNIsPolyAlt = true;
            }
            else
            {
                moduleSURFER.BLNIsPolyAlt = false;
            }
        }

        private void CkLineAltitude_CheckStateChanged(object sender, EventArgs e)
        {
            if ((int)ckLineAltitude.CheckState == 1)
            {
                moduleSURFER.BLNIsLineAlt = true;
            }
            else
            {
                moduleSURFER.BLNIsLineAlt = false;
            }
        }

        private string GetLineTypeFromGuid(string guid)
        {
            string GetLineTypeFromGuidRet = default;
            GetLineTypeFromGuidRet = "";
            int K;
            var loopTo = moduleLINES.NoOfLineTypes;
            for (K = 1; K <= loopTo; K++)
            {
                if ((moduleLINES.LineTypes[K].Guid ?? "") == (guid ?? ""))
                {
                    GetLineTypeFromGuidRet = moduleLINES.LineTypes[K].Type;
                    break;
                }
            }

            return GetLineTypeFromGuidRet;
        }

        private string GetPolyTypeFromGuid(string guid)
        {
            string GetPolyTypeFromGuidRet = default;
            GetPolyTypeFromGuidRet = "";
            int K;
            var loopTo = modulePOLYS.NoOfPolyTypes;
            for (K = 1; K <= loopTo; K++)
            {
                if ((modulePOLYS.PolyTypes[K].Guid ?? "") == (guid ?? ""))
                {
                    GetPolyTypeFromGuidRet = modulePOLYS.PolyTypes[K].Type;
                    break;
                }
            }

            return GetPolyTypeFromGuidRet;
        }

        private void TxtLineGuid_Click(object sender, EventArgs e)
        {
            modulePOPUP.POPMode = "SUR";
            My.MyProject.Forms.FrmLinesP.ShowDialog();
            txtLineGuid.Text = moduleSURFER.BLNLineGuid;
        }

        private void TxtPolyGuid_Click(object sender, EventArgs e)
        {
            modulePOPUP.POPMode = "SUR";
            My.MyProject.Forms.FrmPolysP.ShowDialog();
            txtPolyGuid.Text = moduleSURFER.BLNPolyGuid;
        }

        private void LbLineColor_Click(object sender, EventArgs e)
        {

            // frmStart.ColorDialog1.Color = lbLineColor.BackColor
            // ' Update the color if the user clicks OK 
            // If frmStart.ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            // lbLineColor.BackColor = frmStart.ColorDialog1.Color
            // End If

            moduleMAIN.ARGBColor = lbLineColor.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                lbLineColor.BackColor = moduleMAIN.ARGBColor;
            }
        }

        private void LbPolyColor_Click(object sender, EventArgs e)
        {

            // frmStart.ColorDialog1.Color = lbPolyColor.BackColor
            // ' Update the color if the user clicks OK 
            // If frmStart.ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            // lbPolyColor.BackColor = frmStart.ColorDialog1.Color
            // End If

            moduleMAIN.ARGBColor = lbPolyColor.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                lbPolyColor.BackColor = moduleMAIN.ARGBColor;
            }
        }
    }
}