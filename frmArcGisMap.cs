using System;
using System.Windows.Forms;

namespace SBuilderX
{
    public partial class frmArcGisMap
    {
        public frmArcGisMap()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            moduleMAPS.ArcGisMapsType = "Imagery";
            if (buttonMap.Checked)
                moduleMAPS.ArcGisMapsType = "Street_Map";
            if (buttonTopo.Checked)
                moduleMAPS.ArcGisMapsType = "Topo_Map";
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }
    }
}