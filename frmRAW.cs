using System;
using System.Windows.Forms;

namespace SBuilderX
{
    public partial class FrmRAW
    {
        public FrmRAW()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _optWater.Name = "optWater";
            _optLand.Name = "optLand";
            _txtJ.Name = "txtJ";
            _txtK.Name = "txtK";
        }

        private int _K;

        internal int K => _K;

        private int _J;

        internal int J => _J;

        private string _C;  // LC_ is land WC_ is water

        internal string C => _C;

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            if (optWater.Checked)
            {
                _C = "WC_";
            }
            else
            {
                _C = "LC_";
            }

            try
            {
                _J = Convert.ToInt32(txtJ.Text);
            }
            catch (Exception)
            {
                _J = -1;
                // txtJ.Text = "-1"
            }

            try
            {
                _K = Convert.ToInt32(txtK.Text);
            }
            catch (Exception)
            {
                _K = -1;
                // txtK.Text = "-1"
            }

            DialogResult = DialogResult.OK;
        }

        private void OptLand_CheckedChanged(object sender, EventArgs e)
        {

            // If optLand.Checked Then
            // _C = "LC_"
            // Else
            // _C = "WC_"
            // End If

        }

        private void OptWater_CheckedChanged(object sender, EventArgs e)
        {

            // If optWater.Checked Then
            // _C = "WC_"
            // Else
            // _C = "LC_"
            // End If

        }

        private void TxtJ_TextChanged(object sender, EventArgs e)
        {

            // Try
            // _J = CInt(txtJ.Text)
            // Catch ex As Exception
            // _J = -1
            // txtJ.Text = "-1"
            // End Try

        }

        private void TxtK_TextChanged(object sender, EventArgs e)
        {

            // Try
            // _K = CInt(txtK.Text)
            // Catch ex As Exception
            // _K = -1
            // txtK.Text = "-1"
            // End Try

        }
    }
}