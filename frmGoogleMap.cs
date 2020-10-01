using System;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class frmGoogleMap
    {
        public frmGoogleMap()
        {
            InitializeComponent();
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            moduleMAPS.GoogleMapsType = "satellite";
            if (buttonMap.Checked)
                moduleMAPS.GoogleMapsType = "roadmap";
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}