using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmLPPointsP
    {
        public FrmLPPointsP()
        {
            InitializeComponent();
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
        }

        private double _Altitude;

        public double Altitude
        {
            get
            {
                return _Altitude;
            }

            set
            {
                _Altitude = value;
            }
        }

        private double _Latitude;

        public double Latitude
        {
            get
            {
                return _Latitude;
            }

            set
            {
                _Latitude = value;
            }
        }

        private double _Longitude;

        public double Longitude
        {
            get
            {
                return _Longitude;
            }

            set
            {
                _Longitude = value;
            }
        }

        private void FrmPointsP_Load(object sender, EventArgs e)
        {
            lbWidth.Text = "Width";
            if (modulePOPUP.POPType == "PtInLineX")
            {
                Text = "SBuilderX - Point from Aircraft";
                txtWidth.Visible = true;
                lbWidth.Visible = true;
                lbPt.Visible = true;
                lbAltitude.Visible = true;
                txtAltitude.Visible = true;
                txtLon.Text = moduleMAIN.Lon2Str(_Longitude);
                txtLat.Text = moduleMAIN.Lat2Str(_Latitude);
                txtAltitude.Text = _Altitude.ToString();
                txtWidth.Text = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].wid.ToString();
                lbPt.Text = "PT # " + modulePOPUP.POPIndexPT.ToString();
            }

            if (modulePOPUP.POPType == "PtInPolyX")
            {
                Text = "SBuilderX - Point from Aircraft";
                txtWidth.Visible = false;
                lbWidth.Visible = false;
                lbPt.Visible = true;
                lbAltitude.Visible = true;
                txtAltitude.Visible = true;
                txtLon.Text = moduleMAIN.Lon2Str(_Longitude);
                txtLat.Text = moduleMAIN.Lat2Str(_Latitude);
                txtAltitude.Text = _Altitude.ToString();
                lbPt.Text = "PT # " + modulePOPUP.POPIndexPT.ToString();
            }

            if (modulePOPUP.POPType == "PtInLine")
            {
                Text = "SBuilderX - Point Properties";
                txtWidth.Visible = true;
                if (moduleLINES.Lines[modulePOPUP.POPIndex].Type.Length >= 3 && moduleLINES.Lines[modulePOPUP.POPIndex].Type.Substring(0, 3) == "OBJ")
                {
                    lbWidth.Text = "Heading";
                }

                lbWidth.Visible = true;
                lbPt.Visible = true;
                lbAltitude.Visible = true;
                txtAltitude.Visible = true;
                txtLon.Text = moduleMAIN.Lon2Str(moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].lon);
                txtLat.Text = moduleMAIN.Lat2Str(moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].lat);
                txtAltitude.Text = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].alt.ToString();
                txtWidth.Text = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].wid.ToString();
                lbPt.Text = "PT # " + modulePOPUP.POPIndexPT.ToString();
            }

            if (modulePOPUP.POPType == "PtInPoly")
            {
                Text = "SBuilderX - Point Properties";
                txtWidth.Visible = false;
                lbWidth.Visible = false;
                lbPt.Visible = true;
                lbAltitude.Visible = true;
                txtAltitude.Visible = true;
                txtLon.Text = moduleMAIN.Lon2Str(modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[modulePOPUP.POPIndexPT].lon);
                txtLat.Text = moduleMAIN.Lat2Str(modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[modulePOPUP.POPIndexPT].lat);
                txtAltitude.Text = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[modulePOPUP.POPIndexPT].alt.ToString();
                lbPt.Text = "PT # " + modulePOPUP.POPIndexPT.ToString();
            }

            if (modulePOPUP.POPType == "Goto")
            {
                Text = "SBuilderX - Goto this position";
                txtWidth.Visible = false;
                lbWidth.Visible = false;
                lbPt.Visible = false;
                txtLon.Text = moduleMAIN.Lon2Str(moduleMAIN.LonDispCenter);
                txtLat.Text = moduleMAIN.Lat2Str(moduleMAIN.LatDispCenter);
                lbAltitude.Visible = false;
                txtAltitude.Visible = false;
            }
        }

        private bool ValidateEntries()
        {
            bool ValidateEntriesRet = default;
            double X;

            ValidateEntriesRet = false;
            X = moduleMAIN.Str2Lat(txtLat.Text);
            if (X > 90d)
                return ValidateEntriesRet;
            if (X < -90)
                return ValidateEntriesRet;
            X = moduleMAIN.Str2Lon(txtLon.Text);
            if (X > 180d)
                return ValidateEntriesRet;
            if (X < -180)
                return ValidateEntriesRet;
            if (!(modulePOPUP.POPType == "Goto"))
                X = Convert.ToDouble(txtAltitude.Text);
            if (modulePOPUP.POPType == "PtInLine")
                X = Convert.ToDouble(txtWidth.Text);
            ValidateEntriesRet = true;
            return ValidateEntriesRet;
        }

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            if (ValidateEntries())
            {
                if (modulePOPUP.POPType == "PtInLine" | modulePOPUP.POPType == "PtInLineX")
                {
                    moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].alt = Convert.ToDouble(txtAltitude.Text);
                    moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].wid = Convert.ToDouble(txtWidth.Text);
                    moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].lon = moduleMAIN.Str2Lon(txtLon.Text);
                    moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[modulePOPUP.POPIndexPT].lat = moduleMAIN.Str2Lat(txtLat.Text);
                    moduleLINES.AddLatLonToLine(modulePOPUP.POPIndex);
                }

                if (modulePOPUP.POPType == "PtInPoly" | modulePOPUP.POPType == "PtInPolyX")
                {
                    modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[modulePOPUP.POPIndexPT].alt = Convert.ToDouble(txtAltitude.Text);
                    modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[modulePOPUP.POPIndexPT].lon = moduleMAIN.Str2Lon(txtLon.Text);
                    modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[modulePOPUP.POPIndexPT].lat = moduleMAIN.Str2Lat(txtLat.Text);
                    modulePOLYS.AddLatLonToPoly(modulePOPUP.POPIndex);
                }

                if (modulePOPUP.POPType == "Goto")
                {
                    moduleMAIN.LatDispCenter = moduleMAIN.Str2Lat(txtLat.Text);
                    moduleMAIN.LonDispCenter = moduleMAIN.Str2Lon(txtLon.Text);
                    moduleMAIN.SetDispCenter(0, 0);
                    moduleMAIN.RebuildDisplay();
                }

                moduleMAIN.RebuildDisplay();
                Dispose();
            }
            else
            {
                MessageBox.Show("Check your entries!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}