using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    internal partial class FrmTiles
    {
        public FrmTiles()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _RadioButton5.Name = "RadioButton5";
            _RadioButton4.Name = "RadioButton4";
            _RadioButton3.Name = "RadioButton3";
            _RadioButton2.Name = "RadioButton2";
            _RadioButton1.Name = "RadioButton1";
        }

        private bool MouseIsDown = false;
        private const int XS = 15;
        private const int YS = 15;


        // Private Const XW As Integer = 616  ' the size of the map in the form
        // Private Const YH As Integer = 440

        // Private X_1 As Integer = 630
        // Private Y_1 As Integer = 454

        private const int XW = 770;  // the size of the map in the form
        private const int YH = 490;  // each quad = 70 x 70
        private int X_1 = 784;
        private int Y_1 = 504;
        private int X_0 = 15;
        private int Y_0 = 15;
        private int[] X0 = new int[5];
        private int[] Y0 = new int[5];
        private int[] X1 = new int[5];
        private int[] Y1 = new int[5];
        private int X00;
        private int Y00;
        private int X11;
        private int Y11;
        private int ZZZ = moduleMAIN.Zoom;
        private int[] H;
        // Private blankjpg As Bitmap = Image.FromFile(AppPath & "\Tiles\blank.jpg")  ' was like this in October 2017
        private Bitmap blankjpg = (Bitmap)Image.FromFile(moduleMAIN.AppPath + @"\Tiles\blank.jpg");
        private Bitmap ImgBuffer = new Bitmap(XW, YH);

        private void FrmTiles_Load(object sender, EventArgs e)
        {
            BuildImageBuffer();
            moduleTILES.TimeToUpdate = false;
            labelCount.Visible = false;
        }

        private void FrmTiles_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
            int Button = (int)e.Button / 0x100000;
            if (Button == 1)
            {
                X_0 = e.X;
                Y_0 = e.Y;
                if (XYIsOK(X_0, Y_0))
                    MouseIsDown = true;
            }
        }

        private void FrmTiles_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MouseIsDown)
                return;
            int X = e.X;
            int Y = e.Y;
            CheckXY(ref X, ref Y);
            DrawSelectBox(X, Y);
        }

        private void FrmTiles_MouseUp(object sender, MouseEventArgs e)
        {
            if (!MouseIsDown)
                return;
            // Debug.Print("mouse up")
            X_1 = e.X;
            Y_1 = e.Y;
            CheckXY(ref X_1, ref Y_1);
            ComputeExtents();
            DrawSelectBox(X_1, Y_1);
            MouseIsDown = false;
        }

        private bool XYIsOK(int X, int Y)
        {
            bool XYIsOKRet = default;
            XYIsOKRet = false;
            if (X >= XS & X < XW + XS)
            {
                if (Y >= YS & Y < YH + YS)
                {
                    XYIsOKRet = true;
                }
            }

            return XYIsOKRet;
        }

        private void CheckXY(ref int X, ref int Y)
        {
            if (X < XS)
                X = XS;
            if (X > XW + XS - 1)
                X = XW + XS - 1;
            if (Y < YS)
                Y = YS;
            if (Y > YH + YS - 1)
                Y = YH + YS - 1;
        }

        private void DrawSelectBox(int X, int Y)
        {
            int DX, DY;
            int PX, PY;
            UpDateDisplay();
            var p = new Pen(Color.Red);
            Graphics g;
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g = CreateGraphics();
            DX = X - X_0;
            DY = Y - Y_0;
            PX = X_0;
            PY = Y_0;
            if (X < X_0)
            {
                DX = X_0 - X;
                PX = X;
            }

            if (Y < Y_0)
            {
                DY = Y_0 - Y;
                PY = Y;
            }

            g.DrawRectangle(p, new Rectangle(PX, PY, DX, DY));
            p.Dispose();
            g.Dispose();
        }

        private void BuildImageBuffer()
        {
            var g = Graphics.FromImage(ImgBuffer);
            g.DrawImage(moduleTILES.ImageBackground, 0, 0, XW, YH);
            int Z = ZZZ - moduleMAIN.Zoom;
            Z = (int)Math.Pow(2d, Z);
            // Dim NY As Integer = Z * 5
            int NY = Z * 7;
            int Y;
            Y = moduleTILES.YTilesFromLat(moduleMAIN.LatDispCenter, ZZZ);
            Y = Y - (int)Conversion.Int(NY / 2d);
            H = new int[NY + 1];
            // PixelHeight240FromY(Y, H, NY, ZZZ)
            PixelHeight440FromY(Y, ref H, NY, ZZZ);
            DisplayGrids(g);
            g.Dispose();
        }

        private void DisplayGrids(Graphics g)
        {
            var p = new Pen(moduleMAIN.GridColor) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            int R, C;
            int NX, NY;
            int DX, PX;
            int PY;
            int Z = ZZZ - moduleMAIN.Zoom;
            Z = (int)Math.Pow(2d, Z);
            // NX = Z * 7
            // NY = Z * 5
            NX = Z * 11;
            NY = Z * 7;
            DX = (int)(XW / (double)NX);
            PX = DX;
            var loopTo = NX - 1;
            for (C = 1; C <= loopTo; C++)
            {
                g.DrawLine(p, PX, 0, PX, YH);
                PX = PX + DX;
            }

            PY = H[0];
            var loopTo1 = NY - 1;
            for (R = 1; R <= loopTo1; R++)
            {
                g.DrawLine(p, 0, PY, XW, PY);
                PY = PY + H[R];
            }

            p.Dispose();
        }

        private void UpDateDisplay()
        {
            var gr = CreateGraphics();
            gr.DrawImageUnscaled(ImgBuffer, XS, YS);   // copy buffer to display
            gr.Dispose();
        }

        private void FrmTiles_Paint(object sender, PaintEventArgs e)
        {
            UpDateDisplay();
            CheckXY(ref X_1, ref Y_1);
            DrawSelectBox(X_1, Y_1);
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            if (MakeImageFromTiles())
            {
                Dispose();
            }
            else
            {
                labelCount.Visible = false;
            }
        }

        private void ComputeExtents()
        {
            int N;
            double S;
            int X;
            if (X_0 > X_1)
            {
                X = X_0;
                X_0 = X_1;
                X_1 = X;
            }

            if (Y_0 > Y_1)
            {
                X = Y_0;
                Y_0 = Y_1;
                Y_1 = X;
            }

            string atzoom = " at Zoom = ";
            double DLat = moduleTILES.MapBackground.NLAT - moduleTILES.MapBackground.SLAT;
            double DLon = moduleTILES.MapBackground.ELON - moduleTILES.MapBackground.WLON;
            double Lon0, Lon1;
            double Lat0, Lat1;
            Lon0 = (X_0 - XS + 1) / (double)XW * DLon + moduleTILES.MapBackground.WLON;
            Lon1 = (X_1 - XS) / (double)XW * DLon + moduleTILES.MapBackground.WLON;
            Lat0 = moduleTILES.MapBackground.NLAT - (Y_0 - YS + 1) / (double)YH * DLat;
            Lat1 = moduleTILES.MapBackground.NLAT - (Y_1 - YS) / (double)YH * DLat;
            for (N = 0; N <= 4; N++)
            {
                X0[N] = moduleTILES.XTilesFromLon(Lon0, moduleMAIN.Zoom + N);
                Y0[N] = moduleTILES.YTilesFromLat(Lat0, moduleMAIN.Zoom + N);
                X1[N] = moduleTILES.XTilesFromLon(Lon1, moduleMAIN.Zoom + N);
                Y1[N] = moduleTILES.YTilesFromLat(Lat1, moduleMAIN.Zoom + N);
            }

            RadioButton1.Text = (X1[4] - X0[4] + 1).ToString() + " x " + (Y1[4] - Y0[4] + 1).ToString() + atzoom + (moduleMAIN.Zoom + 4).ToString();
            RadioButton2.Text = (X1[3] - X0[3] + 1).ToString() + " x " + (Y1[3] - Y0[3] + 1).ToString() + atzoom + (moduleMAIN.Zoom + 3).ToString();
            RadioButton3.Text = (X1[2] - X0[2] + 1).ToString() + " x " + (Y1[2] - Y0[2] + 1).ToString() + atzoom + (moduleMAIN.Zoom + 2).ToString();
            RadioButton4.Text = (X1[1] - X0[1] + 1).ToString() + " x " + (Y1[1] - Y0[1] + 1).ToString() + atzoom + (moduleMAIN.Zoom + 1).ToString();
            RadioButton5.Text = (X1[0] - X0[0] + 1).ToString() + " x " + (Y1[0] - Y0[0] + 1).ToString() + atzoom + moduleMAIN.Zoom.ToString();
            if (RadioButton1.Checked)
            {
                X00 = X0[4];
                Y00 = Y0[4];
                X11 = X1[4];
                Y11 = Y1[4];
                ZZZ = moduleMAIN.Zoom + 4;
            }
            else if (RadioButton2.Checked)
            {
                X00 = X0[3];
                Y00 = Y0[3];
                X11 = X1[3];
                Y11 = Y1[3];
                ZZZ = moduleMAIN.Zoom + 3;
            }
            else if (RadioButton3.Checked)
            {
                X00 = X0[2];
                Y00 = Y0[2];
                X11 = X1[2];
                Y11 = Y1[2];
                ZZZ = moduleMAIN.Zoom + 2;
            }
            else if (RadioButton4.Checked)
            {
                X00 = X0[1];
                Y00 = Y0[1];
                X11 = X1[1];
                Y11 = Y1[1];
                ZZZ = moduleMAIN.Zoom + 1;
            }
            else
            {
                X00 = X0[0];
                Y00 = Y0[0];
                X11 = X1[0];
                Y11 = Y1[0];
                ZZZ = moduleMAIN.Zoom;
            }

            S = (X11 - X00 + 1) * (Y11 - Y00 + 1);
            GroupBox1.Text = "Number of Tiles = " + S;
            S = S * 262.144d;
            labelSize.Text = "Size = " + Strings.Format(S, "###,000") + " KB";
            BuildImageBuffer();
            UpDateDisplay();
            DrawSelectBox(X_1, Y_1);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton1.Checked == false)
                return;
            ComputeExtents();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton2.Checked == false)
                return;
            ComputeExtents();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton3.Checked == false)
                return;
            ComputeExtents();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton4.Checked == false)
                return;
            ComputeExtents();
        }

        private void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (RadioButton5.Checked == false)
                return;
            ComputeExtents();
        }

        private void PixelHeight440FromY(int Y, ref int[] H, int N, int Z)
        {
            int R;
            double NS;
            var X = new double[N + 1];
            var loopTo = N;
            for (R = 0; R <= loopTo; R++)
                X[R] = moduleTILES.LatFromYMerc(Y + R, Z);

            // NS = 441 / (X(0) - X(N))
            NS = 491d / (X[0] - X[N]);
            var loopTo1 = N - 1;
            for (R = 0; R <= loopTo1; R++)
                H[R] = (int)((X[R] - X[R + 1]) * NS);
        }

        private bool MakeImageFromTiles()
        {
            bool MakeImageFromTilesRet = default;
            MakeImageFromTilesRet = false;
            string A;
            if (string.IsNullOrEmpty(moduleTILES.ActiveTileFolder) | moduleTILES.TilesToCome > 0)
            {
                A = "Could not start the acquisition of the image." + Constants.vbCrLf;
                A = A + "Hide and Show the Background, and try again!";
                Interaction.MsgBox(A, MsgBoxStyle.Critical);
                return MakeImageFromTilesRet;
            }

            Cursor = Cursors.WaitCursor;
            try
            {
                int R, C;
                int NX, NY, K, KT;
                NX = X11 - X00;
                NY = Y11 - Y00;
                string TileExtension = moduleTILES.TileServer.ImageType;
                string TilePrefix = @"\L" + Strings.Trim(ZZZ.ToString()) + "X";
                moduleTILES.TileFolder = moduleMAIN.AppPath + @"\Tiles\" + moduleTILES.TileServer.ServerName;
                string TileName, TileFull, TileDir, TileTemp;
                IAsyncResult AR;
                moduleTILES.DownloadTileHandler myDownloadTileHandler = moduleTILES.TileServer.DownloadTile;
                moduleTILES.TileHandlerState myTileHandlerState;
                var box = default(Rectangle);
                box.Width = 256;
                int HH;
                var H = new int[NY + 1];
                HH = 0;
                moduleTILES.PixelHeightFromY(Y00, ref H, NY + 1, ZZZ);
                var loopTo = NY;
                for (R = 0; R <= loopTo; R++)
                    HH = HH + H[R];
                var ImgTile = new Bitmap(256, 256);
                moduleMAPS.NoOfMaps = moduleMAPS.NoOfMaps + 1;
                Array.Resize(ref moduleMAPS.ImgMaps, moduleMAPS.NoOfMaps + 1);
                Array.Resize(ref moduleMAPS.Maps, moduleMAPS.NoOfMaps + 1);
                moduleMAPS.ImgMaps[moduleMAPS.NoOfMaps] = new Bitmap(256 * (NX + 1), HH);
                var g = Graphics.FromImage(moduleMAPS.ImgMaps[moduleMAPS.NoOfMaps]);
                box.Y = 0;
                KT = (NY + 1) * (NX + 1);
                K = 0;
                labelCount.Visible = true;
                var loopTo1 = NY;
                for (R = 0; R <= loopTo1; R++)
                {
                    box.Height = H[R];
                    box.X = 0;
                    var loopTo2 = NX;
                    for (C = 0; C <= loopTo2; C++)
                    {
                        K = K + 1;
                        labelCount.Text = "Processing Tile " + K + " out of " + KT;
                        labelCount.Refresh();
                        TileName = TilePrefix + Strings.Trim((X00 + C).ToString()) + "Y" + Strings.Trim((Y00 + R).ToString()) + TileExtension;
                        TileDir = moduleTILES.TileDirFromXYZ(X00 + C, Y00 + R, ZZZ);
                        try
                        {
                            TileFull = moduleTILES.TileFolder + TileDir + TileName;
                            // ImgTile = Image.FromFile(TileFull)      'was like this in October 2017
                            ImgTile = (Bitmap)Image.FromFile(TileFull);
                        }
                        catch (Exception ex)
                        {
                            ImgTile = blankjpg;
                            if (!moduleTILES.TilesFailed.Contains(TileName))
                            {
                                if (!moduleTILES.TilesDownloading.Contains(TileName))
                                {
                                    TileTemp = moduleMAIN.AppPath + @"\Tiles" + TileName;
                                    moduleTILES.TilesDownloading.Add(TileName);
                                    moduleTILES.TilesToCome = moduleTILES.TilesToCome + 1;
                                    moduleTILES.TileHasArrived(moduleTILES.TilesToCome);
                                    myTileHandlerState.handler = myDownloadTileHandler;
                                    myTileHandlerState.tile = TileName;
                                    myTileHandlerState.dir = TileDir;
                                    AR = myDownloadTileHandler.BeginInvoke(X00 + C, Y00 + R, ZZZ, TileTemp, moduleTILES.myDownloadTileCallback, myTileHandlerState);
                                }
                            }
                        }

                        g.DrawImage(ImgTile, box);
                        box.X = box.X + 256;
                    }

                    box.Y = box.Y + H[R];
                }

                ImgTile.Dispose();
                g.Dispose();
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Could not make an image!", MsgBoxStyle.Critical);
                Cursor = Cursors.Default;
                moduleMAPS.NoOfMaps = moduleMAPS.NoOfMaps - 1;
                Array.Resize(ref moduleMAPS.ImgMaps, moduleMAPS.NoOfMaps + 1);
                return default;
            }

            if (moduleTILES.TilesToCome > 0)
            {
                A = moduleTILES.TilesToCome.ToString() + " tiles are being downloaded" + Constants.vbCrLf;
                A = A + "at this moment. Please repeat this" + Constants.vbCrLf;
                A = A + "operation when downloading is complete!";
                Interaction.MsgBox(A, MsgBoxStyle.Information);
                Cursor = Cursors.Default;
                moduleMAPS.NoOfMaps = moduleMAPS.NoOfMaps - 1;
                Array.Resize(ref moduleMAPS.ImgMaps, moduleMAPS.NoOfMaps + 1);
                return MakeImageFromTilesRet;
            }

            moduleMAPS.Maps[moduleMAPS.NoOfMaps].Name = "Photo" + Strings.Format(moduleMAPS.NoOfMaps, "00");
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].Selected = false;
            string myfile = moduleMAIN.AppPath + @"\Tools\Work\L";
            myfile = myfile + ZZZ.ToString() + "X" + X00.ToString() + "X" + X11.ToString();
            myfile = myfile + "Y" + Y00.ToString() + "Y" + Y11.ToString() + ".BMP";
            try
            {
                if (moduleMAPS.ImgMaps[moduleMAPS.NoOfMaps] is object)
                {
                    moduleMAPS.ImgMaps[moduleMAPS.NoOfMaps].Save(myfile, ImageFormat.Bmp);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("There was a problem saving the image!", MsgBoxStyle.Exclamation);
            }

            MakeImageFromTilesRet = true;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].BMPSu = myfile;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].BMPSp = myfile;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].BMPFa = myfile;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].BMPWi = myfile;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].BMPHw = myfile;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].BMPLm = myfile;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].COLS = moduleMAPS.ImgMaps[moduleMAPS.NoOfMaps].Width;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].ROWS = moduleMAPS.ImgMaps[moduleMAPS.NoOfMaps].Height;
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].WLON = moduleTILES.LonFromXMerc(X00, ZZZ);
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].ELON = moduleTILES.LonFromXMerc(X11 + 1, ZZZ);
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].NLAT = moduleTILES.LatFromYMerc(Y00, ZZZ);
            moduleMAPS.Maps[moduleMAPS.NoOfMaps].SLAT = moduleTILES.LatFromYMerc(Y11 + 1, ZZZ);
            moduleTILES.SaveDataFile(myfile, moduleMAPS.Maps[moduleMAPS.NoOfMaps].NLAT, moduleMAPS.Maps[moduleMAPS.NoOfMaps].SLAT, moduleMAPS.Maps[moduleMAPS.NoOfMaps].WLON, moduleMAPS.Maps[moduleMAPS.NoOfMaps].ELON, moduleMAPS.Maps[moduleMAPS.NoOfMaps].Name);
            My.MyProject.Forms.FrmStart.ViewAllMapsMenuItem.Checked = true;
            moduleMAPS.MapVIEW = true;
            My.MyProject.Forms.FrmStart.SummerMapMenuItem.Checked = true;
            My.MyProject.Forms.FrmStart.ShowBackgroundMenuItem.Checked = false;
            moduleTILES.TileVIEW = false;
            My.MyProject.Forms.FrmStart.FromBackgroundMapMenuItem.Enabled = false;
            moduleMAIN.LonDispCenter = (moduleMAPS.Maps[moduleMAPS.NoOfMaps].WLON + moduleMAPS.Maps[moduleMAPS.NoOfMaps].ELON) / 2d;
            moduleMAIN.LatDispCenter = (moduleMAPS.Maps[moduleMAPS.NoOfMaps].NLAT + moduleMAPS.Maps[moduleMAPS.NoOfMaps].SLAT) / 2d;
            moduleMAIN.ViewON = true;
            moduleMAIN.Zoom = ZZZ;
            moduleMAIN.ResetZoom();
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
            moduleMAIN.Dirty = true;
            Cursor = Cursors.Default;
            return MakeImageFromTilesRet;
        }
    }
}