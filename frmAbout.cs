using System;
using System.Diagnostics;

namespace SBuilderX
{
    internal partial class FrmAbout
    {
        public FrmAbout()
        {
            InitializeComponent();
            _cmdOK.Name = "cmdOK";
            _Button1.Name = "Button1";
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
            HTMLFile = "https://www.paypal.com/cgi-bin/webscr?cmd=_xclick&business=ptsim%40ptsim%2ecom&item_name=Donation%20for%20SBuilderX&page_style=SBuilderX&no_shipping=1&return=http%3a%2f%2fwww%2eptsim%2ecom%2fsbuilderx%2fthankyou%2easp&cancel_return=http%3a%2f%2fwww%2eptsim%2ecom%2fsbuilderx%2fthankyou%2easp&cn=Optional%20Note&tax=0&currency_code=EUR&lc=GB&bn=PP%2dDonationsBF&charset=UTF%2d8";
            Process.Start(HTMLFile);
        }
    }
}