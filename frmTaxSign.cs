using System;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    internal partial class FrmTaxSign : Form
    {
        private int EntState = 0;

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdDIR_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            EntState = 1;
            A = txtMessage.Text;
            A = A + "d[]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdINFO_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            EntState = 1;
            A = txtMessage.Text;
            A = A + "i[]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdDL_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "/]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdDR_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + @"\]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdLL_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "<]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdLOC_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            EntState = 1;
            A = txtMessage.Text;
            A = A + "l[]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FrmObjectsP.txtTaxiwayText.Text = txtMessage.Text;
            Dispose();
        }

        private void CmdRR_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + ">]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdRUN_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            EntState = 1;
            A = txtMessage.Text;
            A = A + "m[]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdUL_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "`]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdUp_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "^]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdUR_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "']";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdDD_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "v]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdILS_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "=]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdHOLD_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "#]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdXX_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "x]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void CmdDIV_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            int N;
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            N = Strings.Len(txtMessage.Text);
            if (N < 3)
            {
                Interaction.MsgBox("Check your typing!", (MsgBoxStyle)16);
                txtMessage.Text = "";
                return;
            }

            A = Strings.Mid(txtMessage.Text, 1, N - 1);
            A = A + "|]";
            txtMessage.Text = A;
            txtMessage.Focus();
            SendKeys.Send("{RIGHT}{LEFT}");
        }

        private void TxtMessage_KeyDown(object eventSender, KeyEventArgs eventArgs)
        {
            if (EntState == 0)
            {
                Interaction.MsgBox("Select a type!", (MsgBoxStyle)16);
                txtMessage.Text = "";
            }
        }
    }
}