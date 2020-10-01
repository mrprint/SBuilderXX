using System;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class frmExtraMacro : Form
    {
        private void CmdClose_Click(object eventSender, EventArgs eventArgs)
        {
            if (lbP9.Visible)
                moduleMACROS.MacroP9Value = txtP9.Text;
            if (lbPA.Visible)
                moduleMACROS.MacroPAValue = txtPA.Text;
            if (lbPB.Visible)
                moduleMACROS.MacroPBValue = txtPB.Text;
            if (lbPC.Visible)
                moduleMACROS.MacroPCValue = txtPC.Text;
            if (lbPD.Visible)
                moduleMACROS.MacroPDValue = txtPD.Text;
            Dispose();
        }

        private void FrmExtraMacro_Load(object eventSender, EventArgs eventArgs)
        {
            if (!string.IsNullOrEmpty(moduleMACROS.MacroP9Name))
            {
                lbP9.Visible = true;
                txtP9.Visible = true;
                lbP9.Text = moduleMACROS.MacroP9Name;
                txtP9.Text = moduleMACROS.MacroP9Value;
            }
            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(moduleMACROS.MacroPAName))
            {
                lbPA.Visible = true;
                txtPA.Visible = true;
                lbPA.Text = moduleMACROS.MacroPAName;
                txtPA.Text = moduleMACROS.MacroPAValue;
            }
            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(moduleMACROS.MacroPBName))
            {
                lbPB.Visible = true;
                txtPB.Visible = true;
                lbPB.Text = moduleMACROS.MacroPBName;
                txtPB.Text = moduleMACROS.MacroPBValue;
            }
            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(moduleMACROS.MacroPCName))
            {
                lbPC.Visible = true;
                txtPC.Visible = true;
                lbPC.Text = moduleMACROS.MacroPCName;
                txtPC.Text = moduleMACROS.MacroPCValue;
            }
            else
            {
                return;
            }

            if (!string.IsNullOrEmpty(moduleMACROS.MacroPDName))
            {
                lbPD.Visible = true;
                txtPD.Visible = true;
                lbPD.Text = moduleMACROS.MacroPDName;
                txtPD.Text = moduleMACROS.MacroPDValue;
            }
            else
            {
                return;
            }
        }
    }
}