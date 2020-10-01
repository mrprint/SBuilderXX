using System;
using System.Diagnostics;

namespace SBuilderXX
{
    internal partial class FrmAbout
    {
        public FrmAbout()
        {
            InitializeComponent();
            _cmdOK.Name = "cmdOK";
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmStart.lbDonation.Visible = false;
            Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string HTMLFile;
            My.MyProject.Forms.FrmStart.lbDonation.Visible = false;
            HTMLFile = "";
            //Process.Start(HTMLFile);
        }
    }
}