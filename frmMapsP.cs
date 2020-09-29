using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmMapsP
    {
        public FrmMapsP()
        {
            InitializeComponent();
            _cmdCalibrateMain.Name = "cmdCalibrateMain";
            _cmdData.Name = "cmdData";
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _cmdSummer.Name = "cmdSummer";
            _cmdSpring.Name = "cmdSpring";
            _cmdFall.Name = "cmdFall";
            _cmdWinter.Name = "cmdWinter";
            _cmdHard.Name = "cmdHard";
            _cmdNight.Name = "cmdNight";
            _cmdGeoTiff.Name = "cmdGeoTiff";
        }

        private bool DoBackUp;

        private void CmdData_Click(object eventSender, EventArgs eventArgs)
        {
            string A, DataFile, DataPath, FullFile;
            DataFile = Path.GetFileNameWithoutExtension(txtBMPSummer.Text) + ".TXT";
            DataPath = Path.GetDirectoryName(txtBMPSummer.Text);
            FullFile = DataPath + @"\" + DataFile;
            if (File.Exists(FullFile))
            {
                A = "The file:" + Environment.NewLine + Environment.NewLine + DataFile + Environment.NewLine + Environment.NewLine;
                A = A + "already exists! Overwrite?";
                if ((int)Interaction.MsgBox(A, (MsgBoxStyle)(32 + 4)) == 7)
                    return;
            }

            FileSystem.FileOpen(3, FullFile, OpenMode.Output);
            A = "[GEOGRAPHIC]";
            FileSystem.PrintLine(3, A);
            A = "Name=" + txtName.Text;
            FileSystem.PrintLine(3, A);
            A = "North=" + moduleMAIN.Str2Lat(txtNLat.Text).ToString();
            FileSystem.PrintLine(3, A);
            A = "South=" + moduleMAIN.Str2Lat(txtSLat.Text).ToString();
            FileSystem.PrintLine(3, A);
            A = "West=" + moduleMAIN.Str2Lon(txtWLon.Text).ToString();
            FileSystem.PrintLine(3, A);
            A = "East=" + moduleMAIN.Str2Lon(txtELon.Text).ToString();
            FileSystem.PrintLine(3, A);
            FileSystem.PrintLine(3);
            FileSystem.FileClose(3);
        }

        private void CmdFall_Click(object eventSender, EventArgs eventArgs)
        {
            string A;

            // A = FileBMPToOpen("")
            A = moduleFILE_IO.FileNameToOpen(ImageFilter, ImageTitle, "BMP");
            if (string.IsNullOrEmpty(A))
                return;
            txtBMPFall.Text = A;
            moduleMAIN.Season = "Fall";
            moduleMAIN.ViewON = true;
            moduleMAIN.Dirty = true;
            DoBackUp = true;
        }

        private void CmdHard_Click(object eventSender, EventArgs eventArgs)
        {
            string A;

            // A = FileBMPToOpen("")
            A = moduleFILE_IO.FileNameToOpen(ImageFilter, ImageTitle, "BMP");
            if (string.IsNullOrEmpty(A))
                return;
            txtBMPHard.Text = A;
            moduleMAIN.Season = "HardWinter";
            moduleMAIN.ViewON = true;
            moduleMAIN.Dirty = true;
            DoBackUp = true;
        }

        private void CmdNight_Click(object eventSender, EventArgs eventArgs)
        {
            string A;

            // A = FileBMPToOpen("")
            A = moduleFILE_IO.FileNameToOpen(ImageFilter, ImageTitle, "BMP");
            if (string.IsNullOrEmpty(A))
                return;
            txtBMPNight.Text = A;
            moduleMAIN.Season = "Night";
            moduleMAIN.ViewON = true;
            moduleMAIN.Dirty = true;
            DoBackUp = true;
        }

        private void CmdSpring_Click(object eventSender, EventArgs eventArgs)
        {
            string A;

            // A = FileBMPToOpen("")
            A = moduleFILE_IO.FileNameToOpen(ImageFilter, ImageTitle, "BMP");
            if (string.IsNullOrEmpty(A))
                return;
            txtBMPSpring.Text = A;
            moduleMAIN.ViewON = true;
            moduleMAIN.Dirty = true;
            DoBackUp = true;
            moduleMAIN.Season = "Spring";
        }

        private void CmdSummer_Click(object sender, EventArgs e)
        {
            string A;

            // A = FileBMPToOpen("")
            A = moduleFILE_IO.FileNameToOpen(ImageFilter, ImageTitle, "BMP");
            if (string.IsNullOrEmpty(A))
                return;
            txtBMPSummer.Text = A;
            moduleMAIN.ViewON = true;
            moduleMAIN.Dirty = true;
            DoBackUp = true;
            moduleMAIN.Season = "Summer";
        }

        private void CmdWinter_Click(object eventSender, EventArgs eventArgs)
        {
            string A;

            // A = FileBMPToOpen("")
            A = moduleFILE_IO.FileNameToOpen(ImageFilter, ImageTitle, "BMP");
            if (string.IsNullOrEmpty(A))
                return;
            txtBMPWinter.Text = A;
            moduleMAIN.Season = "Winter";
            moduleMAIN.ViewON = true;
            moduleMAIN.Dirty = true;
            DoBackUp = true;
        }

        private void FrmMapsP_Load(object eventSender, EventArgs eventArgs)
        {
            int N;
            string A;
            DoBackUp = false;
            N = modulePOPUP.POPIndex;
            txtName.Text = moduleMAPS.Maps[N].Name;
            txtBMPSummer.Text = moduleMAPS.Maps[N].BMPSu;
            txtBMPSpring.Text = moduleMAPS.Maps[N].BMPSp;
            txtBMPFall.Text = moduleMAPS.Maps[N].BMPFa;
            txtBMPWinter.Text = moduleMAPS.Maps[N].BMPWi;
            txtBMPHard.Text = moduleMAPS.Maps[N].BMPHw;
            txtBMPNight.Text = moduleMAPS.Maps[N].BMPLm;
            lbCols.Text = moduleMAPS.Maps[N].COLS.ToString();
            lbRows.Text = moduleMAPS.Maps[N].ROWS.ToString();
            txtNLat.Text = moduleMAIN.Lat2Str(moduleMAPS.Maps[N].NLAT);
            txtSLat.Text = moduleMAIN.Lat2Str(moduleMAPS.Maps[N].SLAT);
            txtELon.Text = moduleMAIN.Lon2Str(moduleMAPS.Maps[N].ELON);
            txtWLon.Text = moduleMAIN.Lon2Str(moduleMAPS.Maps[N].WLON);
            txtCellX.Text = ((moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS).ToString();
            txtCellY.Text = ((moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS).ToString();
            A = "Possible formats:";
            A = A + "  N40 30 30,33";
            A = A + "  40:30:30,3333";
            A = A + "  40:30 30,33 N";
            A = "Possible formats:";
            A = A + "  E40 30 30,33";
            A = A + "  40:30:30,3333";
            A = A + "  40:30 30,33 E";
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            int N;
            N = modulePOPUP.POPIndex;
            if (DoBackUp)
                moduleEDIT.BackUp();
            moduleMAPS.Maps[N].Name = txtName.Text;
            moduleMAPS.Maps[N].Selected = false;
            moduleMAPS.Maps[N].BMPSu = txtBMPSummer.Text;
            moduleMAPS.Maps[N].BMPSp = txtBMPSpring.Text;
            moduleMAPS.Maps[N].BMPFa = txtBMPFall.Text;
            moduleMAPS.Maps[N].BMPWi = txtBMPWinter.Text;
            moduleMAPS.Maps[N].BMPHw = txtBMPHard.Text;
            moduleMAPS.Maps[N].BMPLm = txtBMPNight.Text;
            moduleMAPS.Maps[N].COLS = Convert.ToInt32(lbCols.Text);
            moduleMAPS.Maps[N].ROWS = Convert.ToInt32(lbRows.Text);
            moduleMAPS.Maps[N].NLAT = moduleMAIN.Str2Lat(txtNLat.Text);
            moduleMAPS.Maps[N].SLAT = moduleMAIN.Str2Lat(txtSLat.Text);
            moduleMAPS.Maps[N].ELON = moduleMAIN.Str2Lon(txtELon.Text);
            moduleMAPS.Maps[N].WLON = moduleMAIN.Str2Lon(txtWLon.Text);
            My.MyProject.Forms.FrmStart.SaveAsMenuItem.Enabled = true;
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.RebuildDisplay();
            moduleMAIN.Dirty = true;
            Dispose();
        }

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdCalibrateMain_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Summer";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();

            // Me.Hide()
            // frmStart.Show()
            // frmCalibrate.ShowDialog()
            // Me.Dispose()

            My.MyProject.Forms.FrmCalibrate.ShowDialog();
            // frmStart.CalibratePopUPMenu_Click(sender, e)


        }

        private void CmdGeoTiff_Click(object sender, EventArgs e)
        {
            Image GeoTiff;
            MemoryStream Stream = new MemoryStream();
            moduleMAPS.ImgMaps[modulePOPUP.POPIndex].Save(Stream, ImageFormat.Tiff);
            GeoTiff = Image.FromStream(Stream);
            PropertyItem propItem;
            propItem = GeoTiff.GetPropertyItem(256);
            propItem.Len = 32;
            propItem.Type = 1;
            propItem.Value = moduleMAPS.MakeGeoKeyDirTag();
            propItem.Id = 34735;
            GeoTiff.SetPropertyItem(propItem);
            double North = moduleMAIN.Str2Lat(txtNLat.Text);
            double South = moduleMAIN.Str2Lat(txtSLat.Text);
            double East = moduleMAIN.Str2Lon(txtELon.Text);
            double West = moduleMAIN.Str2Lon(txtWLon.Text);
            int Cols = Convert.ToInt32(lbCols.Text);
            int Rows = Convert.ToInt32(lbRows.Text);
            double LX, SX;
            double LY, SY;
            SX = (East - West) / Cols;
            SY = (North - South) / Rows;
            LX = West + SX / 2d;
            LY = North + SY / 2d;
            propItem.Id = 33922;
            propItem.Len = 48;
            propItem.Value = moduleMAPS.MakeTiePointTag(LX, LY);
            GeoTiff.SetPropertyItem(propItem);
            propItem.Len = 24;
            propItem.Id = 33550;
            propItem.Value = moduleMAPS.MakePixelScaleTag(SX, SY);
            GeoTiff.SetPropertyItem(propItem);
            string FileName;
            int K;
            FileName = moduleMAPS.Maps[modulePOPUP.POPIndex].BMPSu;
            K = FileName.Length - 4;
            FileName = FileName.Substring(0, K) + ".tif";
            GeoTiff.Save(FileName);
            Stream.Dispose();
            byte[] buffer;
            buffer = File.ReadAllBytes(FileName);

            // Dim buffer() As Byte = Stream.GetBuffer
            // Stream.Close()
            // GeoTiff.Dispose()

            int N = buffer.GetUpperBound(0);
            bool Problem = false;
            if (buffer[N - 25] == 10)
            {
                buffer[N - 25] = 12;
            }
            else
            {
                Problem = true;
            }

            if (buffer[N - 37] == 10)
            {
                buffer[N - 37] = 12;
            }
            else
            {
                Problem = true;
            }

            if (Problem == true)
                MessageBox.Show("Geotiff file may have some problems!");
            File.WriteAllBytes(FileName, buffer);
            buffer = new byte[1];
        }

        // Private Function Imag3eFilter() As String

        // Dim A As String
        // A = "Windows Bitmap Format (*.BMP)|*.bmp"
        // A = A & "|Jpeg File Interchange Format (*.JPG)|*.jpg"
        // A = A & "|Tag Image File Format (*.TIF)|*.tif"
        // A = A & "|Graphics Interchange Format (*.GIF)|*.gif"
        // A = A & "|Portable Network Graphics (*.PNG)|*.png"
        // Return A

        // End Function

        private const string ImageFilter = "Windows Bitmap Format (*.BMP)|*.bmp _" + "|Jpeg File Interchange Format (*.JPG)|*.jpg" + "|Tag Image File Format (*.TIF)|*.tif" + "|Graphics Interchange Format (*.GIF)|*.gif" + "|Portable Network Graphics (*.PNG)|*.png";
        private const string ImageTitle = "SBuilderX: Open Image File";
    }
}