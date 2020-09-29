using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace SBuilderX
{
    static class moduleMAPS
    {
        [Serializable()]
        internal struct Map
        {
            public string Name;
            public bool Selected;
            public int COLS; // for the selected map can be one of 0 1 or 2 / not exported!
            public int ROWS;
            public double NLAT;
            public double SLAT;
            public double WLON;
            public double ELON;
            public string BMPSu;
            public string BMPWi;
            public string BMPFa;
            public string BMPSp;
            public string BMPHw;
            public string BMPLm;
        }

        internal static Image[] ImgMaps;
        internal static int NoOfMaps = 0;
        internal static int NoOfMapsSelected = 0;
        internal static Map[] Maps;

        // Friend NokiaZoom As Integer
        // Friend NokiaType As Integer
        // Friend Here_app_id As String
        // Friend Here_app_code As String

        internal static string GoogleMapsType;
        internal static string GoogleMapsAPI;
        internal static string ArcGisMapsType;
        internal static bool ShowSimpleMaps = false;
        internal static bool MapVIEW = false;
        internal static bool BorderON;
        internal static bool CalibratePT1;
        internal static bool CalibratePT2;
        internal static bool CalibratePixel = false;
        private const double two_pi = 2.0d * moduleMAIN.PI;
        private const double pi_360 = moduleMAIN.PI / 360.0d;
        private const double pi_180 = moduleMAIN.PI / 180.0d;
        private const double pi_4 = moduleMAIN.PI / 4.0d;
        private const double pi_2 = moduleMAIN.PI / 2.0d;
        private const double x256_180 = 256d / 180d;
        private const double x256_pi = 256d / moduleMAIN.PI;

        internal static void AddNewMap()
        {
            string DataFile;
            double East = default, North = default, South = default, West = default;
            bool Flag;
            string Name = "MAP" + NoOfMaps.ToString("00");
            string A;
            A = "Windows Bitmap Format (*.BMP)|*.bmp";
            A = A + "|Jpeg File Interchange Format (*.JPG)|*.jpg";
            A = A + "|Tag Image File Format (*.TIF)|*.tif";
            A = A + "|Graphics Interchange Format (*.GIF)|*.gif";
            A = A + "|Portable Network Graphics (*.PNG)|*.png";
            string B = "SBuilderX: Open Image File";
            string myFile = moduleFILE_IO.FileNameToOpen(A, B, "BMP");
            bool geoTiff = default(bool);
            int Cols = default, Rows = default;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.AppStarting;
            if (!string.IsNullOrEmpty(myFile))
            {
                if (moduleMAIN.Season != "Summer")
                {
                    moduleMAIN.Season = "Summer";
                    SetBitmapSeason();
                }

                NoOfMaps = NoOfMaps + 1;
                Array.Resize(ref ImgMaps, NoOfMaps + 1);
                Flag = GetImageParameters(myFile, ref Cols, ref Rows, ref North, ref South, ref West, ref East, ref geoTiff);
                if (Flag == false)
                {
                    NoOfMaps = NoOfMaps - 1;
                    MessageBox.Show("The image has a wrong file format!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                return;
            }

            Array.Resize(ref Maps, NoOfMaps + 1);
            Flag = false;
            if (geoTiff)
                Flag = true;

            // as per Dick
            // DataFile = Path.GetFileNameWithoutExtension(myFile) & ".TXT"
            DataFile = Path.ChangeExtension(myFile, "TXT");
            if (File.Exists(DataFile))
            {
                Flag = true;
                North = ReadIniDouble(DataFile, "GEOGRAPHIC", "North");
                South = ReadIniDouble(DataFile, "GEOGRAPHIC", "South");
                West = ReadIniDouble(DataFile, "GEOGRAPHIC", "West");
                East = ReadIniDouble(DataFile, "GEOGRAPHIC", "East");
                string argVariable = "Name";
                Name = moduleFILE_IO.ReadIniValue(DataFile, "GEOGRAPHIC", ref argVariable);
            }

            if (South >= North | West >= East)
                Flag = false;
            moduleEDIT.BackUp();
            if (Flag)
            {
                Maps[NoOfMaps].NLAT = North;
                Maps[NoOfMaps].SLAT = South;
                Maps[NoOfMaps].ELON = East;
                Maps[NoOfMaps].WLON = West;
            }
            else
            {
                Maps[NoOfMaps].NLAT = moduleMAIN.LatDispCenter + 0.1d;
                Maps[NoOfMaps].SLAT = moduleMAIN.LatDispCenter - 0.1d;
                Maps[NoOfMaps].ELON = moduleMAIN.LonDispCenter + 0.1d;
                Maps[NoOfMaps].WLON = moduleMAIN.LonDispCenter - 0.1d;
            }

            Maps[NoOfMaps].Name = Name;
            Maps[NoOfMaps].Selected = false;
            Maps[NoOfMaps].BMPSu = myFile;
            Maps[NoOfMaps].BMPSp = myFile;
            Maps[NoOfMaps].BMPFa = myFile;
            Maps[NoOfMaps].BMPWi = myFile;
            Maps[NoOfMaps].BMPHw = myFile;
            Maps[NoOfMaps].BMPLm = myFile;
            Maps[NoOfMaps].COLS = Cols;
            Maps[NoOfMaps].ROWS = Rows;
            moduleMAIN.LonDispCenter = (Maps[NoOfMaps].WLON + Maps[NoOfMaps].ELON) / 2d;
            moduleMAIN.LatDispCenter = (Maps[NoOfMaps].NLAT + Maps[NoOfMaps].SLAT) / 2d;
            My.MyProject.Forms.FrmStart.SummerMapMenuItem.Checked = true;
            My.MyProject.Forms.FrmStart.ViewMapsMenuItem.Enabled = true;
            moduleMAIN.ViewON = true;
            moduleMAIN.Zoom = 8;
            moduleMAIN.ResetZoom();
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
            moduleMAIN.Dirty = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            if (Flag == false)
            {
                MessageBox.Show("You may need to calibrate this bitmap!", "", MessageBoxButtons.OK);
                modulePOPUP.POPIndex = NoOfMaps;
                My.MyProject.Forms.FrmMapsP.ShowDialog();
            }
        }

        // Friend Sub AddHereNokiaMap()

        // Dim myfile As String

        // If My.Computer.Network.IsAvailable = False Then
        // MsgBox("There is no Internet connection!", MsgBoxStyle.Information)
        // Exit Sub
        // End If

        // If Here_app_id = "DemoAppId01082013GAL" Then
        // myfile = "You are using demo application Id and Code keys! In order to" & vbCrLf
        // myfile = myfile & "avoid this message, please go to the Here/Nokia web site:" & vbCrLf & vbCrLf
        // myfile = myfile & "http://developer.here.com/rest-apis" & vbCrLf & vbCrLf
        // myfile = myfile & "and apply for your own keys. Then, open the SBuilderX.ini" & vbCrLf
        // myfile = myfile & "file and replace the demo keys with your own keys!"
        // MsgBox(myfile, MsgBoxStyle.Information)
        // End If

        // If FrmGoogleMaps.ShowDialog = Windows.Forms.DialogResult.Cancel Then
        // Exit Sub
        // End If

        // frmStart.Cursor = Cursors.WaitCursor

        // Dim NokiaSize As Integer = 2048

        // Dim index As Integer
        // NoOfMaps = NoOfMaps + 1
        // ReDim Preserve ImgMaps(NoOfMaps)

        // Dim makeurl As String
        // makeurl = "http://image.maps.cit.api.here.com/mia/1.6/mapview?app_id=DemoAppId01082013GAL&app_code=AJKnXv84fjrb0KIHawS0Tg"
        // makeurl = makeurl & "&nocp=1&nodot=1&c=" & Trim(Str(LatDispCenter)) & "," & Trim(Str(LonDispCenter))
        // makeurl = makeurl & "&f=0&t=" & NokiaType & "&h=" & NokiaSize & "&w=" & NokiaSize & "&z=" & NokiaZoom
        // Debug.Print(makeurl)

        // Try
        // Dim req As Net.HttpWebRequest = DirectCast(Net.HttpWebRequest.Create(makeurl), Net.HttpWebRequest)
        // Dim res As Net.HttpWebResponse = DirectCast(req.GetResponse, Net.HttpWebResponse)
        // index = res.ContentType.IndexOf("image")
        // ImgMaps(NoOfMaps) = Image.FromStream(res.GetResponseStream)
        // res.Close()
        // Catch ex As Exception
        // MsgBox("Could not get a Here Nokia image!", MsgBoxStyle.Critical)
        // frmStart.Cursor = Cursors.Default
        // NoOfMaps = NoOfMaps - 1
        // Exit Sub
        // End Try

        // ReDim Preserve Maps(NoOfMaps)

        // Maps(NoOfMaps).Name = "MAP" & Format(NoOfMaps, "00")
        // Maps(NoOfMaps).Selected = False

        // Dim LA, LO As String

        // LA = Format(Val(LatDispCenter), "00.000000")
        // LO = Format(Val(LonDispCenter), "000.000000")

        // myfile = AppPath & "\Tools\Work\Nokia_" & LA & "_" & LO & "_" & Zoom & ".png"
        // Try
        // If Not (ImgMaps(NoOfMaps) Is Nothing) Then
        // ImgMaps(NoOfMaps).Save(myfile)
        // End If
        // Catch ex As Exception
        // MsgBox("There was a problem saving the image!", MsgBoxStyle.Exclamation)
        // End Try

        // Maps(NoOfMaps).BMPSu = myfile
        // Maps(NoOfMaps).BMPSp = myfile
        // Maps(NoOfMaps).BMPFa = myfile
        // Maps(NoOfMaps).BMPWi = myfile
        // Maps(NoOfMaps).BMPHw = myfile
        // Maps(NoOfMaps).BMPLm = myfile

        // Maps(NoOfMaps).COLS = NokiaSize
        // Maps(NoOfMaps).ROWS = NokiaSize

        // Dim CLat, CLon As Integer
        // CLon = XMPixFromLon(LonDispCenter, (NokiaZoom - 1))
        // CLat = YMPixFromLat(LatDispCenter, (NokiaZoom - 1))

        // Dim LN, LS, LW, LE As Double

        // LN = LatFromYMPix(CLat + NokiaSize / 2, (NokiaZoom - 1))
        // LS = LatFromYMPix(CLat - NokiaSize / 2, (NokiaZoom - 1))
        // LW = LonFromXMPix(CLon - NokiaSize / 2, (NokiaZoom - 1))
        // LE = LonFromXMPix(CLon + NokiaSize / 2, (NokiaZoom - 1))

        // If NokiaZoom < 8 Then
        // FileMercator2LatLon(LN, LS, myfile, myfile)
        // ImgMaps(NoOfMaps) = Image.FromFile(myfile)
        // End If

        // Maps(NoOfMaps).NLAT = LN
        // Maps(NoOfMaps).SLAT = LS
        // Maps(NoOfMaps).ELON = LE
        // Maps(NoOfMaps).WLON = LW

        // frmStart.SummerMapMenuItem.Checked = True
        // frmStart.ViewMapsMenuItem.Enabled = True

        // MapVIEW = True
        // ViewON = True
        // Zoom = NokiaZoom - 1
        // ResetZoom()
        // SetDispCenter(0, 0)
        // RebuildDisplay()
        // Dirty = True
        // frmStart.Cursor = Cursors.Default
        // frmStart.StatusZoom.Text = "Zoom = " & CStr(Zoom)

        // End Sub

        internal static void AddArcGisMap()
        {
            string myfile;
            if (My.MyProject.Computer.Network.IsAvailable == false)
            {
                MessageBox.Show("There is no Internet connection!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (My.MyProject.Forms.frmArcGisMap.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            int index;
            NoOfMaps = NoOfMaps + 1;
            Array.Resize(ref ImgMaps, NoOfMaps + 1);
            int CLat, CLon;
            CLon = XMPixFromLon(moduleMAIN.LonDispCenter, moduleMAIN.Zoom);
            CLat = YMPixFromLat(moduleMAIN.LatDispCenter, moduleMAIN.Zoom);
            int msize = 4096;
            double LN, LS, LW, LE;
            LN = LatFromYMPix((long)(CLat + msize / 2d), moduleMAIN.Zoom);
            LS = LatFromYMPix((long)(CLat - msize / 2d), moduleMAIN.Zoom);
            LW = LonFromXMPix((long)(CLon - msize / 2d), moduleMAIN.Zoom);
            LE = LonFromXMPix((long)(CLon + msize / 2d), moduleMAIN.Zoom);
            string makeurl;
            makeurl = "https://services.arcgisonline.com/arcgis/rest/services/World_" + ArcGisMapsType;
            makeurl = makeurl + "/MapServer/export?bbox=" + LW.ToString().Trim() + "," + LS.ToString().Trim();
            makeurl = makeurl + "," + LE.ToString().Trim() + "," + LN.ToString().Trim();
            makeurl = makeurl + "&bboxSR=4326&size=" + msize + "," + msize + "&f=image";

            // MsgBox(makeurl)

            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(makeurl);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                index = res.ContentType.IndexOf("image");
                ImgMaps[NoOfMaps] = Image.FromStream(res.GetResponseStream());
                res.Close();
            }
            catch (Exception)
            {
                // MsgBox("Could not get a Arc Gis Map image!", MsgBoxStyle.Critical)
                MessageBox.Show("Could not get an image at Zoom=" + moduleMAIN.Zoom + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
                NoOfMaps = NoOfMaps - 1;
                return;
            }

            Array.Resize(ref Maps, NoOfMaps + 1);
            Maps[NoOfMaps].Name = "MAP" + NoOfMaps.ToString("00");
            Maps[NoOfMaps].Selected = false;
            string LA, LO;
            LA = moduleMAIN.LatDispCenter.ToString("00.000000");
            LO = moduleMAIN.LonDispCenter.ToString("000.000000");
            myfile = moduleMAIN.AppPath + @"\Tools\Work\ARCG_" + LA + "_" + LO + "_" + moduleMAIN.Zoom + ".png";
            try
            {
                if (ImgMaps[NoOfMaps] is object)
                {
                    ImgMaps[NoOfMaps].Save(myfile);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem saving the image!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Maps[NoOfMaps].BMPSu = myfile;
            Maps[NoOfMaps].BMPSp = myfile;
            Maps[NoOfMaps].BMPFa = myfile;
            Maps[NoOfMaps].BMPWi = myfile;
            Maps[NoOfMaps].BMPHw = myfile;
            Maps[NoOfMaps].BMPLm = myfile;
            Maps[NoOfMaps].COLS = msize;
            Maps[NoOfMaps].ROWS = msize;
            Maps[NoOfMaps].NLAT = LN;
            Maps[NoOfMaps].SLAT = LS;
            Maps[NoOfMaps].ELON = LE;
            Maps[NoOfMaps].WLON = LW;
            My.MyProject.Forms.FrmStart.SummerMapMenuItem.Checked = true;
            My.MyProject.Forms.FrmStart.ViewMapsMenuItem.Enabled = true;
            MapVIEW = true;
            moduleMAIN.ViewON = true;
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
            moduleMAIN.Dirty = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            My.MyProject.Forms.FrmStart.StatusZoom.Text = "Zoom = " + moduleMAIN.Zoom.ToString();
        }

        internal static void AddGoogleMap()
        {
            string myfile;
            if (My.MyProject.Computer.Network.IsAvailable == false)
            {
                MessageBox.Show("There is no Internet connection!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (string.IsNullOrEmpty(GoogleMapsAPI))
            {
                myfile = "You need to have a valid and active Google Static Maps API Key! Once you" + Environment.NewLine;
                myfile = myfile + "get your_google_api_key, open SBuilderX.ini file and edit the following line" + Environment.NewLine;
                myfile = myfile + "GoogleMapsAPI=your_google_api_key!" + Environment.NewLine + Environment.NewLine;
                myfile = myfile + "Do you want to learn how to get a Google API key?";
                DialogResult A = MessageBox.Show(myfile, "Google Maps API is missing", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (A == DialogResult.Yes)
                {
                    myfile = "https://developers.google.com/maps/documentation/static-maps/get-api-key";
                    Process.Start(myfile);
                }

                return;
            }

            if (My.MyProject.Forms.frmGoogleMap.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            int index;
            NoOfMaps = NoOfMaps + 1;
            Array.Resize(ref ImgMaps, NoOfMaps + 1);
            string makeurl;
            makeurl = "https://maps.googleapis.com/maps/api/staticmap?center=";
            makeurl = makeurl + moduleMAIN.LatDispCenter.ToString().Trim() + "," + moduleMAIN.LonDispCenter.ToString().Trim();
            int msize = 640;
            makeurl = makeurl + "&size=" + msize + "x" + msize + "&zoom=" + moduleMAIN.Zoom + "&scale=2";
            makeurl = makeurl + "&format=png&maptype=" + GoogleMapsType;
            makeurl = makeurl + "&key=" + GoogleMapsAPI;
            Debug.Print(makeurl);
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(makeurl);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                index = res.ContentType.IndexOf("image");
                ImgMaps[NoOfMaps] = Image.FromStream(res.GetResponseStream());
                res.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not get an image at Zoom=" + moduleMAIN.Zoom + "!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
                NoOfMaps = NoOfMaps - 1;
                return;
            }

            Array.Resize(ref Maps, NoOfMaps + 1);
            Maps[NoOfMaps].Name = "MAP" + NoOfMaps.ToString("00");
            Maps[NoOfMaps].Selected = false;
            string LA, LO;
            LA = moduleMAIN.LatDispCenter.ToString("00.000000");
            LO = moduleMAIN.LonDispCenter.ToString("000.000000");
            myfile = moduleMAIN.AppPath + @"\Tools\Work\GMAP_" + LA + "_" + LO + "_" + moduleMAIN.Zoom + ".png";
            try
            {
                if (ImgMaps[NoOfMaps] is object)
                {
                    ImgMaps[NoOfMaps].Save(myfile);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem saving the image!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Maps[NoOfMaps].BMPSu = myfile;
            Maps[NoOfMaps].BMPSp = myfile;
            Maps[NoOfMaps].BMPFa = myfile;
            Maps[NoOfMaps].BMPWi = myfile;
            Maps[NoOfMaps].BMPHw = myfile;
            Maps[NoOfMaps].BMPLm = myfile;
            Maps[NoOfMaps].COLS = msize * 2;
            Maps[NoOfMaps].ROWS = msize * 2;
            int CLat, CLon;
            CLon = XMPixFromLon(moduleMAIN.LonDispCenter, moduleMAIN.Zoom);
            CLat = YMPixFromLat(moduleMAIN.LatDispCenter, moduleMAIN.Zoom);
            double LN, LS, LW, LE;
            LN = LatFromYMPix(CLat + msize, moduleMAIN.Zoom);
            LS = LatFromYMPix(CLat - msize, moduleMAIN.Zoom);
            LW = LonFromXMPix(CLon - msize, moduleMAIN.Zoom);
            LE = LonFromXMPix(CLon + msize, moduleMAIN.Zoom);
            if (moduleMAIN.Zoom < 8)          // I do not remember how it works - October 2017
            {
                FileMercator2LatLon(LN, LS, myfile, myfile);
                ImgMaps[NoOfMaps] = Image.FromFile(myfile);
            }

            Maps[NoOfMaps].NLAT = LN;
            Maps[NoOfMaps].SLAT = LS;
            Maps[NoOfMaps].ELON = LE;
            Maps[NoOfMaps].WLON = LW;
            My.MyProject.Forms.FrmStart.SummerMapMenuItem.Checked = true;
            My.MyProject.Forms.FrmStart.ViewMapsMenuItem.Enabled = true;
            MapVIEW = true;
            moduleMAIN.ViewON = true;
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
            moduleMAIN.Dirty = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            My.MyProject.Forms.FrmStart.StatusZoom.Text = "Zoom = " + moduleMAIN.Zoom.ToString();
        }

        private static void FileMercator2LatLon(double North, double South, string inputfile, string outfile)
        {
            int N, K;
            double lat, dlat;
            double merc, dmerc;
            double north_m, south_m;
            Image img = Image.FromFile(inputfile);
            ImageFormat imgformat = img.RawFormat;
            int rows = img.Height;
            int cols = img.Width;
            ImageFormat bmp = ImageFormat.Bmp;
            MemoryStream ms1 = new MemoryStream();
            img.Save(ms1, bmp);
            byte[] inp = ms1.GetBuffer();
            ms1.Close();
            img.Dispose();
            byte[] @out = (byte[])inp.Clone();
            int Base, LineWidth, pointN, pointK;
            int BytesPerPixel;
            Base = BitConverter.ToInt32(inp, 10);
            BytesPerPixel = (int)(BitConverter.ToInt16(inp, 28) / 8d);
            LineWidth = cols * BytesPerPixel;
            // make LineWidth a multiple of 4
            N = (int)((LineWidth - 1) / 4d);
            LineWidth = (N + 1) * 4;
            dlat = (North - South) / (rows - 1);
            north_m = YMercFromLat(North);
            south_m = YMercFromLat(South);
            dmerc = (north_m - south_m) / (rows - 1);
            lat = South + dlat;
            int loopTo = rows - 2;
            for (N = 1; N <= loopTo; N++)
            {
                merc = YMercFromLat(lat);
                merc = merc - south_m;
                merc = merc / dmerc;
                K = (int)merc;   // round
                if (N != K)
                {
                    pointN = Base + (rows - N - 1) * LineWidth;
                    pointK = Base + (rows - K - 1) * LineWidth;
                    Array.Copy(inp, pointK, @out, pointN, LineWidth);
                }

                lat = lat + dlat;
            }

            MemoryStream ms2 = new MemoryStream(@out);
            img = Image.FromStream(ms2);
            img.Save(outfile, imgformat);
            ms2.Close();
            img.Dispose();
        }

        private static double YMercFromLat(double lat)
        {
            double YMercFromLatRet = default;
            lat = lat * pi_360;
            lat = lat + pi_4;
            lat = Math.Tan(lat);
            YMercFromLatRet = Math.Log(lat);
            return YMercFromLatRet;
        }

        private static double XMercFromLon(double lon)
        {
            double XMercFromLonRet = default;
            XMercFromLonRet = moduleMAIN.PI + lon * pi_180;
            return XMercFromLonRet;
        }

        private static int XMPixFromLon(double lon, int Z)
        {
            int XMPixFromLonRet = default;
            XMPixFromLonRet = (int)(lon * x256_180 * Math.Pow(2d, Z));
            return XMPixFromLonRet;
        }

        private static int YMPixFromLat(double lat, int Z)
        {
            int YMPixFromLatRet = default;
            lat = lat * pi_360;  // lat=lat/2  <<< equivalent
            lat = lat + pi_4;
            lat = Math.Tan(lat);
            lat = Math.Log(lat);
            YMPixFromLatRet = (int)(lat * x256_pi * Math.Pow(2d, Z));
            return YMPixFromLatRet;
        }

        private static double LonFromXMPix(long X, int Z)
        {
            double LonFromXMPixRet = default;
            LonFromXMPixRet = X / (x256_180 * Math.Pow(2d, Z));
            return LonFromXMPixRet;
        }

        private static double LatFromYMPix(long Y, int Z)
        {
            double LatFromYMPixRet = default;
            double X;
            X = Y / (x256_pi * Math.Pow(2d, Z));
            X = Math.Exp(X);
            X = 2d * Math.Atan(X);
            LatFromYMPixRet = (X - pi_2) / pi_180;
            return LatFromYMPixRet;
        }

        private static double ReadIniDouble(string File, string KEY, string Value)
        {
            double ReadIniDoubleRet = default;
            try
            {
                // ReadIniDouble = CDbl(ReadIniValue(File, KEY, Value))
                ReadIniDoubleRet = Convert.ToDouble(moduleFILE_IO.ReadIniValue(File, KEY, ref Value));
            }
            catch (Exception)
            {
                ReadIniDoubleRet = 0d;
            }
            return ReadIniDoubleRet;
        }

        internal static void SetBitmapSeason()
        {
            int N;
            string A;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            My.MyProject.Forms.FrmStart.SummerMapMenuItem.Checked = false;
            My.MyProject.Forms.FrmStart.WinterMapMenuItem.Checked = false;
            My.MyProject.Forms.FrmStart.HardWinterMapMenuItem.Checked = false;
            My.MyProject.Forms.FrmStart.SpringMapMenuItem.Checked = false;
            My.MyProject.Forms.FrmStart.FallMapMenuItem.Checked = false;
            My.MyProject.Forms.FrmStart.NightMapMenuItem.Checked = false;
            if (NoOfMaps == 0)
                moduleMAIN.Season = "";
            if (string.IsNullOrEmpty(moduleMAIN.Season))
            {
                My.MyProject.Forms.FrmStart.ViewMapsMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.SetMouseIcon();
                return;
            }
            else
            {
                My.MyProject.Forms.FrmStart.ViewMapsMenuItem.Enabled = true;
            };

            try
            {
                switch (moduleMAIN.Season ?? "")
                {
                    case var @case when @case == "Summer":
                        {
                            My.MyProject.Forms.FrmStart.SummerMapMenuItem.Checked = true;
                            int loopTo = NoOfMaps;
                            for (N = 1; N <= loopTo; N++)
                            {
                                A = Maps[N].BMPSu;
                                ImgMaps[N] = Image.FromFile(A);
                            }

                            break;
                        }

                    case var case1 when case1 == "Winter":
                        {
                            My.MyProject.Forms.FrmStart.WinterMapMenuItem.Checked = true;
                            int loopTo1 = NoOfMaps;
                            for (N = 1; N <= loopTo1; N++)
                            {
                                A = Maps[N].BMPWi;
                                ImgMaps[N] = Image.FromFile(A);
                            }

                            break;
                        }

                    case var case2 when case2 == "HardWinter":
                        {
                            My.MyProject.Forms.FrmStart.HardWinterMapMenuItem.Checked = true;
                            int loopTo2 = NoOfMaps;
                            for (N = 1; N <= loopTo2; N++)
                            {
                                A = Maps[N].BMPHw;
                                ImgMaps[N] = Image.FromFile(A);
                            }

                            break;
                        }

                    case var case3 when case3 == "Spring":
                        {
                            My.MyProject.Forms.FrmStart.SpringMapMenuItem.Checked = true;
                            int loopTo3 = NoOfMaps;
                            for (N = 1; N <= loopTo3; N++)
                            {
                                A = Maps[N].BMPSp;
                                ImgMaps[N] = Image.FromFile(A);
                            }

                            break;
                        }

                    case var case4 when case4 == "Fall":
                        {
                            My.MyProject.Forms.FrmStart.FallMapMenuItem.Checked = true;
                            int loopTo4 = NoOfMaps;
                            for (N = 1; N <= loopTo4; N++)
                            {
                                A = Maps[N].BMPFa;
                                ImgMaps[N] = Image.FromFile(A);
                            }

                            break;
                        }

                    case var case5 when case5 == "Night":
                        {
                            My.MyProject.Forms.FrmStart.NightMapMenuItem.Checked = true;
                            int loopTo5 = NoOfMaps;
                            for (N = 1; N <= loopTo5; N++)
                            {
                                A = Maps[N].BMPLm;
                                ImgMaps[N] = Image.FromFile(A);
                            }

                            break;
                        }
                }

                My.MyProject.Forms.FrmStart.SetMouseIcon();
                return;
            }
            catch (Exception)
            {
                CheckMaps();
                My.MyProject.Forms.FrmStart.SetMouseIcon();
            }
        }

        internal static void CheckMaps()
        {
            int N;
            string A;
            N = 0;
            moduleEDIT.SkipBackUp = true;
            do
            {
                N = N + 1;
                if (N > NoOfMaps)
                    break;
                if (!File.Exists(Maps[N].BMPSu))
                {
                    A = "The the following map:" + Environment.NewLine + Environment.NewLine;
                    A = A + Maps[N].BMPSu + Environment.NewLine + Environment.NewLine;
                    A = A + "has a problem and will be deleted!";
                    MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    DeleteMap(N);
                    N = N - 1;
                }
                else
                {
                    if (!File.Exists(Maps[N].BMPSp))
                        Maps[N].BMPSp = Maps[N].BMPSu;
                    if (!File.Exists(Maps[N].BMPFa))
                        Maps[N].BMPFa = Maps[N].BMPSu;
                    if (!File.Exists(Maps[N].BMPWi))
                        Maps[N].BMPWi = Maps[N].BMPSu;
                    if (!File.Exists(Maps[N].BMPHw))
                        Maps[N].BMPHw = Maps[N].BMPSu;
                    if (!File.Exists(Maps[N].BMPLm))
                        Maps[N].BMPLm = Maps[N].BMPSu;
                }
            }
            while (true);
            moduleEDIT.SkipBackUp = false;
        }

        internal static void DisplayMaps(Graphics g)
        {
            try
            {
                int N;
                double MapPixelsPerDegree;
                Rectangle screen = new Rectangle();
                RectangleF source = new RectangleF();
                GraphicsUnit units = GraphicsUnit.Pixel;
                Pen mypen = new Pen(Color.Black);
                SolidBrush mybrush = new SolidBrush(modulePOINTS.UnselectedPointColor);
                int loopTo = NoOfMaps;
                for (N = 1; N <= loopTo; N++)
                {
                    if (Maps[N].NLAT < moduleMAIN.LatDispSouth)
                        goto JumpHere;
                    if (Maps[N].SLAT > moduleMAIN.LatDispNorth)
                        goto JumpHere;
                    if (Maps[N].WLON > moduleMAIN.LonDispEast)
                        goto JumpHere;
                    if (Maps[N].ELON < moduleMAIN.LonDispWest)
                        goto JumpHere;
                    if (Maps[N].WLON > moduleMAIN.LonDispWest)
                    {
                        if (Maps[N].ELON > moduleMAIN.LonDispEast)
                        {
                            MapPixelsPerDegree = Maps[N].COLS / (Maps[N].ELON - Maps[N].WLON);
                            source.X = 0f;
                            source.Width = (float)((moduleMAIN.LonDispEast - Maps[N].WLON) * MapPixelsPerDegree);
                            screen.X = (int)((Maps[N].WLON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                            screen.Width = moduleMAIN.DisplayWidth - screen.X;
                        }
                        else
                        {
                            source.X = 0f;
                            source.Width = Maps[N].COLS;
                            screen.X = (int)((Maps[N].WLON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                            screen.Width = (int)((Maps[N].ELON - Maps[N].WLON) * moduleMAIN.PixelsPerLonDeg);
                        }
                    }
                    else if (Maps[N].ELON > moduleMAIN.LonDispEast)
                    {
                        MapPixelsPerDegree = Maps[N].COLS / (Maps[N].ELON - Maps[N].WLON);
                        source.X = (float)((moduleMAIN.LonDispWest - Maps[N].WLON) * MapPixelsPerDegree);
                        source.Width = (float)((moduleMAIN.LonDispEast - moduleMAIN.LonDispWest) * MapPixelsPerDegree);
                        screen.X = 0;
                        screen.Width = moduleMAIN.DisplayWidth;
                    }
                    else
                    {
                        MapPixelsPerDegree = Maps[N].COLS / (Maps[N].ELON - Maps[N].WLON);
                        source.X = (float)((moduleMAIN.LonDispWest - Maps[N].WLON) * MapPixelsPerDegree);
                        source.Width = (float)((Maps[N].ELON - moduleMAIN.LonDispWest) * MapPixelsPerDegree);
                        screen.X = 0;
                        screen.Width = (int)((Maps[N].ELON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                    }

                    if (Maps[N].SLAT > moduleMAIN.LatDispSouth)
                    {
                        if (Maps[N].NLAT > moduleMAIN.LatDispNorth)
                        {
                            MapPixelsPerDegree = Maps[N].ROWS / (Maps[N].NLAT - Maps[N].SLAT);
                            source.Y = (float)((Maps[N].NLAT - moduleMAIN.LatDispNorth) * MapPixelsPerDegree);
                            source.Height = (float)((moduleMAIN.LatDispNorth - Maps[N].SLAT) * MapPixelsPerDegree);
                            screen.Y = 0;
                            screen.Height = (int)((moduleMAIN.LatDispNorth - Maps[N].SLAT) * moduleMAIN.PixelsPerLatDeg);
                        }
                        else
                        {
                            source.Y = 0f;
                            source.Height = Maps[N].ROWS;
                            screen.Y = (int)((moduleMAIN.LatDispNorth - Maps[N].NLAT) * moduleMAIN.PixelsPerLatDeg);
                            screen.Height = (int)((Maps[N].NLAT - Maps[N].SLAT) * moduleMAIN.PixelsPerLatDeg);
                        }
                    }
                    else if (Maps[N].NLAT > moduleMAIN.LatDispNorth)
                    {
                        MapPixelsPerDegree = Maps[N].ROWS / (Maps[N].NLAT - Maps[N].SLAT);
                        source.Y = (int)((Maps[N].NLAT - moduleMAIN.LatDispNorth) * MapPixelsPerDegree);
                        source.Height = (int)((moduleMAIN.LatDispNorth - moduleMAIN.LatDispSouth) * MapPixelsPerDegree);
                        screen.Y = 0;
                        screen.Height = moduleMAIN.DisplayHeight;
                    }
                    else
                    {
                        MapPixelsPerDegree = Maps[N].ROWS / (Maps[N].NLAT - Maps[N].SLAT);
                        source.Y = 0f;
                        source.Height = (int)((Maps[N].NLAT - moduleMAIN.LatDispSouth) * MapPixelsPerDegree);
                        screen.Y = (int)((moduleMAIN.LatDispNorth - Maps[N].NLAT) * moduleMAIN.PixelsPerLatDeg);
                        screen.Height = (int)((Maps[N].NLAT - moduleMAIN.LatDispSouth) * moduleMAIN.PixelsPerLatDeg);
                    }

                    if (ShowSimpleMaps)
                    {
                        g.FillRectangle(mybrush, screen.X, screen.Y, screen.Width, screen.Height);
                    }
                    else
                    {
                        g.DrawImage(ImgMaps[N], screen, source, units);
                    }

                    if (Maps[N].Selected)
                    {
                        mypen.Width = 2f;
                        mypen.Color = Color.Green;
                        g.DrawRectangle(mypen, new Rectangle(screen.X, screen.Y, screen.Width, screen.Height));
                        g.FillRectangle(mybrush, screen.X - 2, screen.Y - 2, 4, 4);
                        g.FillRectangle(mybrush, screen.X + screen.Width - 2, screen.Y - 2, 4, 4);
                        g.FillRectangle(mybrush, screen.X - 2, screen.Y + screen.Height - 2, 4, 4);
                        g.FillRectangle(mybrush, screen.X + screen.Width - 2, screen.Y + screen.Height - 2, 4, 4);
                    }
                    else if (BorderON)
                    {
                        mypen.Color = Color.Black;
                        mypen.Width = 1f;
                        g.DrawRectangle(mypen, new Rectangle(screen.X, screen.Y, screen.Width, screen.Height));
                    }

                JumpHere:
                    ;
                }

                mypen.Dispose();
                mybrush.Dispose();
            }
            catch (Exception)
            {
                CheckMaps();
                // MsgBox("Can not display maps! Map View was turned OFF!", MsgBoxStyle.Exclamation)
                // MapVIEW = False
                // frmStart.ViewAllMapsMenuItem.Checked = False
                MessageBox.Show("Can not display maps! Simple Map View turned ON!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                ShowSimpleMaps = true;
            }
        }

        internal static void DeleteMap(int N)
        {
            int K;
            if (!moduleEDIT.SkipBackUp)
                moduleEDIT.BackUp();
            if (Maps[N].Selected)
                NoOfMapsSelected = NoOfMapsSelected - 1;
            if (N < NoOfMaps)
            {
                int loopTo = NoOfMaps - 1;
                for (K = N; K <= loopTo; K++)
                {
                    Maps[K].Name = Maps[K + 1].Name;
                    Maps[K].Selected = Maps[K + 1].Selected;
                    Maps[K].BMPSu = Maps[K + 1].BMPSu;
                    Maps[K].BMPSp = Maps[K + 1].BMPSp;
                    Maps[K].BMPFa = Maps[K + 1].BMPFa;
                    Maps[K].BMPWi = Maps[K + 1].BMPWi;
                    Maps[K].BMPHw = Maps[K + 1].BMPHw;
                    Maps[K].BMPLm = Maps[K + 1].BMPLm;
                    Maps[K].COLS = Maps[K + 1].COLS;
                    Maps[K].ROWS = Maps[K + 1].ROWS;
                    Maps[K].NLAT = Maps[K + 1].NLAT;
                    Maps[K].SLAT = Maps[K + 1].SLAT;
                    Maps[K].ELON = Maps[K + 1].ELON;
                    Maps[K].WLON = Maps[K + 1].WLON;
                    ImgMaps[K] = ImgMaps[K + 1];
                }
            }

            if (ImgMaps[NoOfMaps] is object)
                ImgMaps[NoOfMaps].Dispose();
            NoOfMaps = NoOfMaps - 1;
            SetBitmapSeason();
            moduleMAIN.Dirty = true;
        }

        internal static bool IsMapSelected(double X, double Y)
        {
            bool IsMapSelectedRet = default;
            int N;
            bool retval;
            IsMapSelectedRet = false;
            if (!MapVIEW)
                return IsMapSelectedRet;
            int loopTo = NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                retval = IsPointInMap(N, X, Y);
                if (retval)
                {
                    if (Maps[N].Selected == false)
                        NoOfMapsSelected = NoOfMapsSelected + 1;
                    Maps[N].Selected = true;
                    moduleMAIN.SomeSelected = true;
                    IsMapSelectedRet = true;
                    return IsMapSelectedRet;
                }
            }

            return IsMapSelectedRet;
        }

        internal static void MoveSelectedMaps(double X, double Y)
        {
            int N;
            int loopTo = NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                if (Maps[N].Selected)
                {
                    Maps[N].NLAT = Maps[N].NLAT - Y;
                    Maps[N].SLAT = Maps[N].SLAT - Y;
                    Maps[N].WLON = Maps[N].WLON + X;
                    Maps[N].ELON = Maps[N].ELON + X;
                }
            }
        }

        internal static bool IsPointInMap(int N, double X, double Y)
        {
            bool IsPointInMapRet = default;
            double X2, X1, Y1, Y2;
            X1 = Maps[N].WLON * moduleMAIN.PixelsPerLonDeg;
            X2 = Maps[N].ELON * moduleMAIN.PixelsPerLonDeg;
            Y1 = Maps[N].NLAT * moduleMAIN.PixelsPerLatDeg;
            Y2 = Maps[N].SLAT * moduleMAIN.PixelsPerLatDeg;
            IsPointInMapRet = false;
            if (X > X2 + 3d)
                return IsPointInMapRet;
            if (X < X1 - 3d)
                return IsPointInMapRet;
            if (Y < Y2 - 3d)
                return IsPointInMapRet;
            if (Y > Y1 + 3d)
                return IsPointInMapRet;
            if (X < X2 - 3d)
            {
                if (X > X1 + 3d)
                {
                    if (Y > Y2 + 3d)
                    {
                        if (Y < Y1 - 3d)
                            return IsPointInMapRet;
                    }
                }
            }

            IsPointInMapRet = true;
            return IsPointInMapRet;
        }

        internal static bool IsPointInsideMap(int N, double X, double Y)
        {
            bool IsPointInsideMapRet = default;
            double X2, X1, Y1, Y2;
            X1 = Maps[N].WLON * moduleMAIN.PixelsPerLonDeg;
            X2 = Maps[N].ELON * moduleMAIN.PixelsPerLonDeg;
            Y1 = Maps[N].NLAT * moduleMAIN.PixelsPerLatDeg;
            Y2 = Maps[N].SLAT * moduleMAIN.PixelsPerLatDeg;
            IsPointInsideMapRet = false;
            if (X > X2)
                return IsPointInsideMapRet;
            if (X < X1)
                return IsPointInsideMapRet;
            if (Y < Y2)
                return IsPointInsideMapRet;
            if (Y > Y1)
                return IsPointInsideMapRet;
            IsPointInsideMapRet = true;
            return IsPointInsideMapRet;
        }

        internal static void SelectMapsInBox(double X0, double Y0, double X1, double Y1)
        {
            int N;
            if (!MapVIEW)
                return;
            int loopTo = NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                if (Maps[N].ELON < X1)
                {
                    if (Maps[N].WLON > X0)
                    {
                        if (Maps[N].SLAT > Y1)
                        {
                            if (Maps[N].NLAT < Y0)
                            {
                                if (!Maps[N].Selected)
                                    NoOfMapsSelected = NoOfMapsSelected + 1;
                                moduleMAIN.SomeSelected = true;
                                Maps[N].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        internal static void SelectAllMaps(ref bool Flag)
        {
            int N;
            if (!MapVIEW)
                return;
            if (Flag)
            {
                My.MyProject.Forms.FrmStart.SelectAllMapsMenuItem.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FrmStart.SelectAllMapsMenuItem.Checked = false;
            }

            int loopTo = NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                if (Flag)
                {
                    if (!Maps[N].Selected)
                        NoOfMapsSelected = NoOfMapsSelected + 1;
                    moduleMAIN.SomeSelected = true;
                }
                else if (Maps[N].Selected)
                    NoOfMapsSelected = NoOfMapsSelected - 1;
                Maps[N].Selected = Flag;
            }
        }

        private static bool GetImageParameters(string myFile, ref int Cols, ref int Rows, ref double North, ref double South, ref double West, ref double East, ref bool geoTiff)

        {
            bool GetImageParametersRet = false;
            bool IsTiff = false;
            bool Swap = false;
            bool Flag;
            ImageFormat tiff = ImageFormat.Tiff;
            ImageFormat jpeg = ImageFormat.Jpeg;
            ImageFormat bmp = ImageFormat.Bmp;
            ImageFormat png = ImageFormat.Png;
            ImageFormat gif = ImageFormat.Gif;

            try
            {
                byte[] BB = new byte[2];

                // FileOpen(3, myFile, OpenMode.Binary)
                // FileGet(3, BB)
                // FileClose(3)
                // adding a second map gave a crash so I replace with this

                BB = File.ReadAllBytes(myFile);
                if (BB[0] == 77 & BB[1] == 77)
                {
                    Swap = true;
                }

                ImgMaps[NoOfMaps] = new Bitmap(myFile);
            }
            catch (Exception)
            {
                return GetImageParametersRet;
            }
            try
            {
                Flag = true;
                if (ImgMaps[NoOfMaps].RawFormat.Equals(tiff))
                {
                    Flag = false;
                    IsTiff = true;
                }

                if (ImgMaps[NoOfMaps].RawFormat.Equals(jpeg))
                    Flag = false;
                if (ImgMaps[NoOfMaps].RawFormat.Equals(bmp))
                    Flag = false;
                if (ImgMaps[NoOfMaps].RawFormat.Equals(png))
                    Flag = false;
                if (ImgMaps[NoOfMaps].RawFormat.Equals(gif))
                    Flag = false;
                if (Flag)
                {
                    if (ImgMaps[NoOfMaps] is object)
                        ImgMaps[NoOfMaps].Dispose();
                    return GetImageParametersRet;
                }

                Rows = ImgMaps[NoOfMaps].Height;
                Cols = ImgMaps[NoOfMaps].Width;
                GetImageParametersRet = true;
                geoTiff = false;
                if (!IsTiff)
                    return GetImageParametersRet;
                ;

                // Get the GeoTiff PropertyItems property from image.
                int N;
                byte[] bytes;
                PropertyItem piScale = ImgMaps[NoOfMaps].GetPropertyItem(33550);
                PropertyItem piTiePoint = ImgMaps[NoOfMaps].GetPropertyItem(33922);
                PropertyItem piGeoDir = ImgMaps[NoOfMaps].GetPropertyItem(34735);

                // check the GeoKey for valid geographic projection and WGS84 datum
                N = piGeoDir.Value.Length;
                bytes = new byte[N + 1];
                bytes = piGeoDir.Value;

                // MsgBox(N)

                if (!IsGCS_WGS84(bytes))
                {
                    return GetImageParametersRet;
                }

                double X;     // tie point pixel column
                double Y;     // tie point pixel row
                double LX;    // tie point longitude
                double LY;    // tie point latitude
                N = piTiePoint.Value.Length;
                bytes = new byte[N + 1];
                bytes = piTiePoint.Value;
                if (Swap)
                    ByteReversal(ref bytes);
                X = BitConverter.ToDouble(bytes, 0);
                Y = BitConverter.ToDouble(bytes, 8);
                LX = BitConverter.ToDouble(bytes, 24);
                LY = BitConverter.ToDouble(bytes, 32);
                double SX;    // ScaleX
                double SY;    // scaleY
                double SX2, SY2;
                N = piScale.Value.Length;
                bytes = new byte[N + 1];
                bytes = piScale.Value;
                if (Swap)
                    ByteReversal(ref bytes);
                SX = BitConverter.ToDouble(bytes, 0);
                SY = BitConverter.ToDouble(bytes, 8);
                SX2 = SX / 2d;
                SY2 = SY / 2d;
                West = LX - X * SX - SX2;
                East = LX + (Cols - X - 1d) * SX + SX2;
                North = LY + Y * SY + SY2;
                South = LY - (Rows - Y - 1d) * SY - SY2;
                if (West < -180 | West > 180d)
                    return GetImageParametersRet;
                if (East < -180 | East > 180d)
                    return GetImageParametersRet;
                if (West > East)
                    return GetImageParametersRet;
                if (North > 90d | North < -90)
                    return GetImageParametersRet;
                if (South > 90d | South < -90)
                    return GetImageParametersRet;
                if (North < South)
                    return GetImageParametersRet;
                geoTiff = true;
            }
            catch (Exception)
            {
                if (ImgMaps[NoOfMaps] is object)
                    ImgMaps[NoOfMaps].Dispose();
            }
            return GetImageParametersRet;
        }

        private static bool IsGCS_WGS84(byte[] arr)
        {
            bool IsGCS_WGS84Ret = default;
            IsGCS_WGS84Ret = false;
            long N, J;
            bool F1, F2;
            short key, value;
            F1 = false;
            F2 = false;
            N = arr.Length;
            N = (long)(8d * (int)(N / 8d) - 1d);
            long loopTo = N;
            for (J = 8L; J <= loopTo; J += 8L)
            {
                key = (short)BitConverter.ToUInt16(arr, (int)J);
                if (key == 1024)
                {
                    value = (short)BitConverter.ToUInt16(arr, (int)(J + 6L));
                    if (value == 2)
                        F1 = true;
                }

                if (key == 2048)
                {
                    value = (short)BitConverter.ToUInt16(arr, (int)(J + 6L));
                    if (value == 4326)
                        F2 = true;
                }
            }

            if (F1 & F2)
                IsGCS_WGS84Ret = true;
            return IsGCS_WGS84Ret;
        }

        private static void ByteReversal(ref byte[] arr)
        {
            int N, J;
            byte B0;
            N = arr.Length;
            N = (int)(8d * (int)(N / 8d) - 1d);
            int loopTo = N;
            for (J = 0; J <= loopTo; J += 8)
            {
                B0 = arr[J];
                arr[J] = arr[J + 7];
                arr[J + 7] = B0;
                B0 = arr[J + 1];
                arr[J + 1] = arr[J + 6];
                arr[J + 6] = B0;
                B0 = arr[J + 2];
                arr[J + 2] = arr[J + 5];
                arr[J + 5] = B0;
                B0 = arr[J + 3];
                arr[J + 3] = arr[J + 4];
                arr[J + 4] = B0;
            }
        }

        internal static byte[] MakeGeoKeyDirTag()
        {
            byte[] MakeGeoKeyDirTagRet = default;

            // 1     1    0    4
            // 1024   0    1    2
            // 1025   0    1    1
            // 2048   0    1    4326   ' Geographic WGS84
            // 2054   0    1    9102   ' Angular_Degree

            MakeGeoKeyDirTagRet = new byte[40];
            byte[] X0, X1, X2, X4;
            byte[] X1024, X1025, X2048, X2054, X4326, X9102;
            X0 = BitConverter.GetBytes(Convert.ToUInt16(0));
            X1 = BitConverter.GetBytes(Convert.ToUInt16(1));
            X2 = BitConverter.GetBytes(Convert.ToUInt16(2));
            X4 = BitConverter.GetBytes(Convert.ToUInt16(4));
            X1024 = BitConverter.GetBytes(Convert.ToUInt16(1024));
            X1025 = BitConverter.GetBytes(Convert.ToUInt16(1025));
            X2048 = BitConverter.GetBytes(Convert.ToUInt16(2048));
            X4326 = BitConverter.GetBytes(Convert.ToUInt16(4326));
            X2054 = BitConverter.GetBytes(Convert.ToUInt16(2054));
            X9102 = BitConverter.GetBytes(Convert.ToUInt16(9102));

            // 1     1    0    4
            X1.CopyTo(MakeGeoKeyDirTagRet, 0);
            X1.CopyTo(MakeGeoKeyDirTagRet, 2);
            X0.CopyTo(MakeGeoKeyDirTagRet, 4);
            X4.CopyTo(MakeGeoKeyDirTagRet, 6);
            // 1024   0    1    2
            X1024.CopyTo(MakeGeoKeyDirTagRet, 8);
            X0.CopyTo(MakeGeoKeyDirTagRet, 10);
            X1.CopyTo(MakeGeoKeyDirTagRet, 12);
            X2.CopyTo(MakeGeoKeyDirTagRet, 14);
            // 1025   0    1    1
            X1025.CopyTo(MakeGeoKeyDirTagRet, 16);
            X0.CopyTo(MakeGeoKeyDirTagRet, 18);
            X1.CopyTo(MakeGeoKeyDirTagRet, 20);
            X1.CopyTo(MakeGeoKeyDirTagRet, 22);
            // 2048   0    1    4326
            X2048.CopyTo(MakeGeoKeyDirTagRet, 24);
            X0.CopyTo(MakeGeoKeyDirTagRet, 26);
            X1.CopyTo(MakeGeoKeyDirTagRet, 28);
            X4326.CopyTo(MakeGeoKeyDirTagRet, 30);
            // 2054   0    1    9102   ' Angular_Degree
            X2054.CopyTo(MakeGeoKeyDirTagRet, 32);
            X0.CopyTo(MakeGeoKeyDirTagRet, 34);
            X1.CopyTo(MakeGeoKeyDirTagRet, 36);
            X9102.CopyTo(MakeGeoKeyDirTagRet, 38);
            return MakeGeoKeyDirTagRet;
        }

        internal static byte[] MakeTiePointTag(double LX, double LY)
        {
            byte[] MakeTiePointTagRet = default;
            MakeTiePointTagRet = new byte[48];
            byte[] X0, XLX, XLY;
            X0 = BitConverter.GetBytes(Convert.ToDouble(0));
            XLX = BitConverter.GetBytes(Convert.ToDouble(LX));
            XLY = BitConverter.GetBytes(Convert.ToDouble(LY));

            // X Y Z LX LY LZ
            // 0 0 0 LX LY 0
            X0.CopyTo(MakeTiePointTagRet, 0);
            X0.CopyTo(MakeTiePointTagRet, 8);
            X0.CopyTo(MakeTiePointTagRet, 16);
            XLX.CopyTo(MakeTiePointTagRet, 24);
            XLY.CopyTo(MakeTiePointTagRet, 32);
            X0.CopyTo(MakeTiePointTagRet, 40);
            return MakeTiePointTagRet;
        }

        internal static byte[] MakePixelScaleTag(double SX, double SY)
        {
            byte[] MakePixelScaleTagRet = default;
            MakePixelScaleTagRet = new byte[24];
            byte[] X0, XSX, XSY;
            X0 = BitConverter.GetBytes(Convert.ToDouble(0));
            XSX = BitConverter.GetBytes(Convert.ToDouble(SX));
            XSY = BitConverter.GetBytes(Convert.ToDouble(SY));

            // SX SY SZ
            // SX SY 0
            XSX.CopyTo(MakePixelScaleTagRet, 0);
            XSY.CopyTo(MakePixelScaleTagRet, 8);
            X0.CopyTo(MakePixelScaleTagRet, 16);
            return MakePixelScaleTagRet;
        }
    }
}