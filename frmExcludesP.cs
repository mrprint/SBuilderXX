using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmExcludesP : Form
    {
        private int ThisExc;
        private int FlagExc;

        internal void AddNewExclude(int X, int Y)
        {
            double X0, Y0, X1, Y1;
            X0 = moduleMAIN.LonDispWest + moduleMAIN.AuxXInt / moduleMAIN.PixelsPerLonDeg;
            Y0 = moduleMAIN.LatDispNorth - moduleMAIN.AuxYInt / moduleMAIN.PixelsPerLatDeg;
            X1 = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            Y1 = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            if (X0 > X1)
            {
                X1 = X0 + X1;
                X0 = X1 - X0;
                X1 = X1 - X0;
            }

            if (Y1 > Y0)
            {
                Y1 = Y0 + Y1;
                Y0 = Y1 - Y0;
                Y1 = Y1 - Y0;
            }

            txtNorth.Text = moduleMAIN.Lat2Str(Y0);
            txtSouth.Text = moduleMAIN.Lat2Str(Y1);
            txtWest.Text = moduleMAIN.Lon2Str(X0);
            txtEast.Text = moduleMAIN.Lon2Str(X1);
            ShowDialog();
        }

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            if (modulePOPUP.POPIndex > moduleEXCLUDES.NoOfExcludes)
            {
                moduleEDIT.BackUp();
                moduleEXCLUDES.NoOfExcludes = moduleEXCLUDES.NoOfExcludes + 1;
                Array.Resize(ref moduleEXCLUDES.Excludes, moduleEXCLUDES.NoOfExcludes + 1);
                ThisExc = moduleEXCLUDES.NoOfExcludes;
            }
            else
            {
                ThisExc = modulePOPUP.POPIndex;
            }

            moduleEXCLUDES.Excludes[ThisExc].NLAT = moduleMAIN.Str2Lat(txtNorth.Text);
            moduleEXCLUDES.Excludes[ThisExc].SLAT = moduleMAIN.Str2Lat(txtSouth.Text);
            moduleEXCLUDES.Excludes[ThisExc].WLON = moduleMAIN.Str2Lon(txtWest.Text);
            moduleEXCLUDES.Excludes[ThisExc].ELON = moduleMAIN.Str2Lon(txtEast.Text);
            FlagExc = 1 * (int)ckAll.CheckState + 2 * (int)ckBeacons.CheckState + 4 * (int)ckEffects.CheckState + 8 * (int)ckGenBuilds.CheckState;
            FlagExc = FlagExc + 16 * (int)ckLibrary.CheckState + 32 * (int)ckTaxi.CheckState + 64 * (int)ckTrigger.CheckState + 128 * (int)ckWind.CheckState;
            // added in FSX
            FlagExc = FlagExc + 256 * (int)ckBridges.CheckState;
            moduleEXCLUDES.Excludes[ThisExc].Flag = FlagExc;
            moduleMAIN.RebuildDisplay();
            Dispose();
        }

        private void FrmExcludesP_Load(object eventSender, EventArgs eventArgs)
        {
            int N, ThisExc;
            if (modulePOPUP.POPIndex > moduleEXCLUDES.NoOfExcludes)
                return;
            ThisExc = modulePOPUP.POPIndex;
            txtNorth.Text = moduleMAIN.Lat2Str(moduleEXCLUDES.Excludes[ThisExc].NLAT);
            txtSouth.Text = moduleMAIN.Lat2Str(moduleEXCLUDES.Excludes[ThisExc].SLAT);
            txtWest.Text = moduleMAIN.Lon2Str(moduleEXCLUDES.Excludes[ThisExc].WLON);
            txtEast.Text = moduleMAIN.Lon2Str(moduleEXCLUDES.Excludes[ThisExc].ELON);
            ckAll.CheckState = CheckState.Unchecked;
            ckBeacons.CheckState = CheckState.Unchecked;
            ckEffects.CheckState = CheckState.Unchecked;
            ckGenBuilds.CheckState = CheckState.Unchecked;
            ckLibrary.CheckState = CheckState.Unchecked;
            ckTaxi.CheckState = CheckState.Unchecked;
            ckTrigger.CheckState = CheckState.Unchecked;
            ckWind.CheckState = CheckState.Unchecked;
            ckBridges.CheckState = CheckState.Unchecked;
            N = moduleEXCLUDES.Excludes[ThisExc].Flag;
            if (Convert.ToBoolean(N & 1))
                ckAll.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 2))
                ckBeacons.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 4))
                ckEffects.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 8))
                ckGenBuilds.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 16))
                ckLibrary.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 32))
                ckTaxi.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 64))
                ckTrigger.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 128))
                ckWind.CheckState = CheckState.Checked;
            if (Convert.ToBoolean(N & 256))
                ckBridges.CheckState = CheckState.Checked;
        }
    }
}