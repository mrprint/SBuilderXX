using System;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmCalibrate
    {
        public FrmCalibrate()
        {
            InitializeComponent();
            _cmdLL2.Name = "cmdLL2";
            _cmdPP2.Name = "cmdPP2";
            _cmdCalibrate.Name = "cmdCalibrate";
            _cmdCancel.Name = "cmdCancel";
            _cmdHelp.Name = "cmdHelp";
            _cmdPP1.Name = "cmdPP1";
            _cmdLL1.Name = "cmdLL1";
        }

        private int ThisMap;
        private double Pt1Lat;
        private double Pt2Lat;
        private double Pt1Lon;
        private double Pt2Lon;
        private double NLAT;
        private double SLAT;
        private double WLON;
        private double ELON;
        private int ROWS;
        private int COLS;
        private bool FlagNW;
        private bool FlagSE;
        private double ROW1;
        private double ROW2;
        private double COL1;
        private double COL2;
        private bool DoBackUp;

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdCalibrate_Click(object eventSender, EventArgs eventArgs)
        {
            double WL, NL, SL, EL;
            double LatDegPerPx, LonDegPerPx;
            double CnLat, CnLon;
            double PxLat, PxLon;
            if (!ValidateLatLon())
            {
                MessageBox.Show("Check Latitude & Longitude Values");
                return;
            }

            if (Math.Abs(ROW2 - ROW1) < 2d)
            {
                if (!optLon.Checked)
                {
                    MessageBox.Show("Check Y Pixel Values");
                    return;
                }
            }

            if (Math.Abs(COL2 - COL1) < 2d)
            {
                if (!optLat.Checked)
                {
                    MessageBox.Show("Check X Pixel Values");
                    return;
                }
            }

            LatDegPerPx = (Pt1Lat - Pt2Lat) / (ROW2 - ROW1);
            LonDegPerPx = (Pt2Lon - Pt1Lon) / (COL2 - COL1);
            CnLat = (Pt1Lat + Pt2Lat) / 2d;
            CnLon = (Pt1Lon + Pt2Lon) / 2d;
            PxLat = (ROW1 + ROW2) / 2d;
            PxLon = (COL2 + COL1) / 2d;
            moduleMAIN.ResetZoom();
            if (optLat.Checked)
            {
                LonDegPerPx = LatDegPerPx * moduleMAIN.PixelsPerLatDeg / moduleMAIN.PixelsPerLonDeg;
            }

            if (optLon.Checked)
            {
                LatDegPerPx = LonDegPerPx * moduleMAIN.PixelsPerLonDeg / moduleMAIN.PixelsPerLatDeg;
            }

            NL = CnLat + PxLat * LatDegPerPx;
            SL = CnLat - (ROWS - PxLat) * LatDegPerPx;
            WL = CnLon - PxLon * LonDegPerPx;
            EL = CnLon + (COLS - PxLon) * LonDegPerPx;
            moduleEDIT.BackUp();
            moduleMAPS.Maps[ThisMap].NLAT = NL;
            moduleMAPS.Maps[ThisMap].SLAT = SL;
            moduleMAPS.Maps[ThisMap].ELON = EL;
            moduleMAPS.Maps[ThisMap].WLON = WL;
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.RebuildDisplay();
            Dispose();
        }

        private void CmdHelp_Click(object eventSender, EventArgs eventArgs)
        {
            string A;
            string nl = Environment.NewLine;
            A = "In order to calibrate a map, the geographic and the bitmap locations";
            A = A + nl + "of 2 points are needed. In particular you need to know:";
            A = A + nl;
            A = A + nl + "- lat/lon and X/Y of point P1";
            A = A + nl + "- lat/lon and X/Y of point P2.";
            A = A + nl;
            A = A + nl + "You can manually enter the lat/lon values of a known";
            A = A + nl + "point in the lat/lon boxes or you can press the \"Change\"";
            A = A + nl + "command button on the left side of each frame. In this";
            A = A + nl + "case the lat/lon values of the clicked point will be";
            A = A + nl + "copied into the lat/lon boxes.";
            A = A + nl;
            A = A + nl + "You also need to enter the X/Y bitmap pixel locations of";
            A = A + nl + "the 2 calibrating points. You can either enter these";
            A = A + nl + "values directly into the corresponding boxes or you can";
            A = A + nl + "press the \"Change\" command button on the right side of the";
            A = A + nl + "frames. In this case the clicked the pixel will be used in";
            A = A + nl + "the setting of the X/Y values.";
            MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CmdLL1_Click(object eventSender, EventArgs eventArgs)
        {
            moduleMAPS.CalibratePT1 = true;
            moduleMAPS.CalibratePT2 = false;
            moduleMAPS.CalibratePixel = false;
            Hide();
        }

        private void CmdLL2_Click(object eventSender, EventArgs eventArgs)
        {
            moduleMAPS.CalibratePT1 = false;
            moduleMAPS.CalibratePT2 = true;
            moduleMAPS.CalibratePixel = false;
            Hide();
        }

        private void CmdPP1_Click(object eventSender, EventArgs eventArgs)
        {
            moduleMAPS.CalibratePT1 = true;
            moduleMAPS.CalibratePT2 = false;
            moduleMAPS.CalibratePixel = true;
            Hide();
        }

        private void CmdPP2_Click(object eventSender, EventArgs eventArgs)
        {
            moduleMAPS.CalibratePT1 = false;
            moduleMAPS.CalibratePT2 = true;
            moduleMAPS.CalibratePixel = true;
            Hide();
        }

        private bool ValidateLatLon()
        {
            bool ValidateLatLonRet = default;
            ValidateLatLonRet = false;
            Pt1Lat = moduleMAIN.Str2Lat(txtLat1.Text);
            Pt2Lat = moduleMAIN.Str2Lat(txtLat2.Text);
            Pt2Lon = moduleMAIN.Str2Lon(txtLon2.Text);
            Pt1Lon = moduleMAIN.Str2Lon(txtLon1.Text);
            if (Pt1Lat > 90d)
                return ValidateLatLonRet;
            if (Pt1Lat < -90)
                return ValidateLatLonRet;
            if (Pt2Lat > 90d)
                return ValidateLatLonRet;
            if (Pt2Lat < -90)
                return ValidateLatLonRet;
            if (Pt1Lon > 180d)
                return ValidateLatLonRet;
            if (Pt1Lon < -180)
                return ValidateLatLonRet;
            if (Pt2Lon > 180d)
                return ValidateLatLonRet;
            if (Pt2Lon < -180)
                return ValidateLatLonRet;
            ValidateLatLonRet = true;
            return ValidateLatLonRet;
        }

        public void ReturnCalPT1(short Button, int X, int Y)
        {
            double X1, Y1;
            double X0, Y0;
            My.MyProject.Forms.FrmStart.SetMouseIcon();
            moduleMAPS.CalibratePT2 = false;
            moduleMAPS.CalibratePT1 = false;
            X0 = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            Y0 = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            if (Button == 2)
                return;
            if (!moduleMAPS.CalibratePixel)
            {
                txtLat1.Text = moduleMAIN.Lat2Str(Y0);
                txtLon1.Text = moduleMAIN.Lon2Str(X0);
                return;
            }

            X1 = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X;
            Y1 = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y;
            if (!moduleMAPS.IsPointInsideMap(ThisMap, X1, Y1))
            {
                MessageBox.Show("Point is not on the map!");
                return;
            }

            Y1 = NLAT - SLAT;
            X1 = ELON - WLON;
            Y0 = NLAT - Y0;
            X0 = X0 - WLON;
            Y0 = Y0 / Y1;
            X0 = X0 / X1;
            ROW1 = Y0 * ROWS;
            COL1 = X0 * COLS;
            txtPX1.Text = Math.Round(COL1).ToString();
            txtPY1.Text = Math.Round(ROW1).ToString();
        }

        public void ReturnCalPT2(short Button, int X, int Y)
        {
            double X1, Y1;
            double X0, Y0;
            My.MyProject.Forms.FrmStart.SetMouseIcon();
            moduleMAPS.CalibratePT2 = false;
            moduleMAPS.CalibratePT1 = false;
            X0 = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            Y0 = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            if (Button == 2)
                return;
            if (!moduleMAPS.CalibratePixel)
            {
                txtLat2.Text = moduleMAIN.Lat2Str(Y0);
                txtLon2.Text = moduleMAIN.Lon2Str(X0);
                return;
            }

            X1 = moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X;
            Y1 = moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y;
            if (!moduleMAPS.IsPointInsideMap(ThisMap, X1, Y1))
            {
                MessageBox.Show("Point is not on the map!");
                return;
            }

            Y1 = NLAT - SLAT;
            X1 = ELON - WLON;
            Y0 = NLAT - Y0;
            X0 = X0 - WLON;
            Y0 = Y0 / Y1;
            X0 = X0 / X1;
            ROW2 = Y0 * ROWS;
            COL2 = X0 * COLS;
            txtPX2.Text = Math.Round(COL2).ToString();
            txtPY2.Text = Math.Round(ROW2).ToString();
        }

        private void FrmCalibrate_Load(object eventSender, EventArgs eventArgs)
        {
            My.MyProject.Forms.FrmMapsP.Hide();
            DoBackUp = false;
            ThisMap = modulePOPUP.POPIndex;
            NLAT = moduleMAPS.Maps[ThisMap].NLAT;
            SLAT = moduleMAPS.Maps[ThisMap].SLAT;
            ELON = moduleMAPS.Maps[ThisMap].ELON;
            WLON = moduleMAPS.Maps[ThisMap].WLON;
            ROWS = moduleMAPS.Maps[ThisMap].ROWS;
            COLS = moduleMAPS.Maps[ThisMap].COLS;
            ROW1 = 0d;
            COL1 = 0d;
            ROW2 = ROWS;
            COL2 = COLS;
            txtLat1.Text = moduleMAIN.Lat2Str(NLAT);
            txtLat2.Text = moduleMAIN.Lat2Str(SLAT);
            txtLon2.Text = moduleMAIN.Lon2Str(ELON);
            txtLon1.Text = moduleMAIN.Lon2Str(WLON);
            txtPX1.Text = COL1.ToString();
            txtPY1.Text = ROW1.ToString();
            txtPX2.Text = COL2.ToString();
            txtPY2.Text = ROW2.ToString();
        }
    }
}