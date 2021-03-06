﻿using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using TileServer;

namespace SBuilderXX
{
    static class moduleTILES
    {
        internal static string SummerVariations;
        internal static string SpringVariations;
        internal static string FallVariations;
        internal static string WinterVariations;
        internal static string HardWinterVariations;
        internal static int CompressionQuality;
        internal static bool ReprojectMercatorTiles;
        internal static int TilesToCome = 0;
        internal static IServer TileServer;
        internal static Type[] ServerTypes;
        internal static int NoOfServerTypes;
        internal static int MaximumZoom;
        internal static bool TileVIEW;
        internal static string ActiveTileFolder;
        internal static string TileFolder;
        internal static bool TimeToUpdate = false; // when to make the background goes true when last tile comes

        internal struct MapTile
        {
            public int COLS;
            public int ROWS;
            public double NLAT;
            public double SLAT;
            public double WLON;
            public double ELON;
        }

        internal static MapTile MapBackground;  // final
        internal static MapTile MapBackground0; // temp
        internal static ConcurrentDictionary<string, bool> TilesDownloading = new ConcurrentDictionary<string, bool>();
        internal static ConcurrentDictionary<string, bool> TilesFailed = new ConcurrentDictionary<string, bool>();
        internal static readonly object ttcLock = new object();

        internal struct TileHandlerState
        {
            public object handler;
            public string tile;
            public string dir;
        }

        private const double pi_360 = moduleMAIN.PI / 360.0d;
        private const double pi_180 = moduleMAIN.PI / 180.0d;
        private const double pi_4 = moduleMAIN.PI / 4.0d;
        private const double pi_2 = moduleMAIN.PI / 2.0d;
        internal static int GlobeOrTiles = 2;
        internal static Bitmap ImageBackground = new Bitmap(2, 2);    // final
        internal static Bitmap ImageBackground0 = new Bitmap(2, 2);   // temporary
        internal static Bitmap ImageGlobe = (Bitmap)Image.FromFile(moduleMAIN.AppPath + @"\Tiles\globe.jpg");
        internal static Bitmap najpg = (Bitmap)Image.FromFile(moduleMAIN.AppPath + @"\Tiles\na.jpg");
        // Friend blankjpg As Bitmap = Image.FromFile(AppPath & "\Tiles\blank.jpg")      ' was like this in October 2017
        internal static Bitmap blankjpg = (Bitmap)Image.FromFile(moduleMAIN.AppPath + @"\Tiles\blank.jpg");

        internal delegate bool DownloadTileHandler(int X, int Y, int S, string file);

        internal static AsyncCallback myDownloadTileCallback = My.MyProject.Forms.FrmStart.DownloadTileCallback;

        internal static void SetServerTypes()
        {

            // this only runs when SB starts

            Assembly myAssembly;
            string myFolder = My.MyProject.Application.Info.DirectoryPath;
            string[] myFiles;
            Type[] myTypes;
            ServerTypes = new Type[31];
            int K;
            myFiles = Directory.GetFiles(myFolder + @"\Tiles", "*.dll");
            foreach (string foundFile in My.MyProject.Computer.FileSystem.GetFiles(moduleMAIN.AppPath + @"\Tiles", Microsoft.VisualBasic.FileIO.SearchOption.SearchTopLevelOnly, "L*"))
            {
                MessageBox.Show(foundFile);
                My.MyProject.Computer.FileSystem.DeleteFile(foundFile);
            }

            string DllBase;

            // changed the app.config as per Dick and remove the following line
            // AppDomain.CurrentDomain.AppendPrivatePath("Tiles")

            K = 0;
            foreach (string Dll in myFiles)
            {
                DllBase = Path.GetFileNameWithoutExtension(Dll);
                myAssembly = Assembly.Load(DllBase);
                myTypes = myAssembly.GetTypes();
                foreach (Type myType in myTypes)
                {
                    if (myType.GetInterface("TileServer.IServer") is object)
                    {
                        if (!myType.IsAbstract)
                        {
                            K = K + 1;
                            ServerTypes[K] = myType;
                        }
                    }
                }
            }

            NoOfServerTypes = K;
            Array.Resize(ref ServerTypes, NoOfServerTypes + 1);
            if (string.IsNullOrEmpty(ActiveTileFolder))
                return;
            bool Flag = true;
            int loopTo = NoOfServerTypes;
            for (K = 1; K <= loopTo; K++)
            {
                if ((ActiveTileFolder ?? "") == (ServerTypes[K].Name ?? ""))
                {
                    TileServer = (IServer)Activator.CreateInstance(ServerTypes[K]);
                    MaximumZoom = TileServer.MaximumZoom;
                    Flag = false;
                    break;
                }
            }

            if (Flag)
            {
                ActiveTileFolder = "";
                moduleFILE_IO.WriteSettings();
            }
        }

        internal static void TileHasArrived(int N)
        {
            if (N > 0)
            {
                Point XY = default(Point);
                XY.X = 0;
                XY.Y = moduleMAIN.DisplayHeight - 35;
                My.MyProject.Forms.FrmStart.lbTilesRemaining.Location = XY;
                My.MyProject.Forms.FrmStart.lbTilesRemaining.Text = "(" + N + " tiles remainning) downloading from " + TileServer.ServerName;
                My.MyProject.Forms.FrmStart.lbTilesRemaining.Visible = true;
                My.MyProject.Forms.FrmStart.lbTilesRemaining.Refresh();
            }
            else
            {
                My.MyProject.Forms.FrmStart.lbTilesRemaining.Visible = false;
                My.MyProject.Forms.FrmStart.lbTilesRemaining.Refresh();
                if (TimeToUpdate)
                {
                    My.MyProject.Forms.FrmStart.MakeBackground();
                    // ImageBackground = ImageBackground0
                    // MapBackground = MapBackground0
                    moduleMAIN.RebuildDisplay();
                }
            }
        }

        internal static int XTilesFromLon(double lon, double Z)
        {
            int XTilesFromLonRet = default;
            double dXY;
            dXY = moduleMAIN.PI / Math.Pow(2d, Z);
            lon = moduleMAIN.PI + lon * pi_180;
            XTilesFromLonRet = (int)(lon / dXY);
            return XTilesFromLonRet;
        }

        internal static int YTilesFromLat(double lat, double Z)
        {
            int YTilesFromLatRet = default;
            double dXY;
            dXY = moduleMAIN.PI / Math.Pow(2d, Z);
            lat = lat * pi_360;  // lat=lat/2  <<< equivalent
            lat = lat + pi_4;
            lat = Math.Tan(lat);
            lat = Math.Log(lat);
            lat = moduleMAIN.PI - lat;
            YTilesFromLatRet = (int)(lat / dXY);
            return YTilesFromLatRet;
        }

        // Private Function YMercFromLat(ByVal lat As Double) As Double

        // lat = lat * pi_360
        // lat = lat + pi_4
        // lat = Math.Tan(lat)
        // YMercFromLat = Math.Log(lat)

        // End Function

        // Private Function XMercFromLon(ByVal lon As Double) As Double

        // XMercFromLon = PI + lon * pi_180

        // End Function


        // Friend Sub ImageMercator2LatLon(ByRef out As Bitmap, ByVal North As Double, ByVal South As Double, ByVal outfile As String)


        // Dim N, K, X, rows, cols As Integer
        // Dim lat, dlat As Double
        // Dim merc, dmerc As Double
        // Dim myformat As ImageFormat

        // Dim north_m, south_m As Double

        // Dim imgst1 As New MemoryStream
        // Dim imgst2 As New MemoryStream

        // Dim bmp As ImageFormat = ImageFormat.Bmp

        // rows = out.Height
        // cols = out.Width
        // myformat = out.RawFormat

        // Dim base, pointN, pointK As Integer


        // ' make cols multiple of 4
        // N = Int((cols - 1) / 4)
        // cols = (N + 1) * 4

        // Dim bufferline(cols - 1) As Byte

        // out.Save(imgst1, bmp)
        // imgst2 = imgst1

        // imgst1.Position = 10
        // X = imgst1.Read(bufferline, 0, 4)

        // base = BitConverter.ToInt32(bufferline, 0)

        // dlat = (North - South) / (rows - 1)
        // north_m = YMercFromLat(North)
        // south_m = YMercFromLat(South)
        // dmerc = (north_m - south_m) / (rows - 1)

        // lat = South + dlat
        // For N = 1 To rows - 2
        // merc = YMercFromLat(lat)
        // merc = merc - south_m
        // merc = merc / dmerc
        // K = CInt(merc)   ' round
        // If N <> K Then
        // '    For K = 0 To cols - 1
        // '        out.SetPixel(K, N, inp.GetPixel(K, N1))
        // '    Next
        // pointN = base + (rows - N - 1) * cols
        // pointK = base + (rows - K - 1) * cols
        // imgst1.Position = pointN
        // imgst2.Position = pointK
        // X = imgst1.Read(bufferline, 0, cols)
        // imgst2.Write(bufferline, 0, cols)
        // End If
        // lat = lat + dlat
        // Next

        // out = Image.FromStream(imgst2)
        // out.Save(outfile, myformat)
        // imgst1.Close()
        // imgst2.Close()

        // End Sub

        // Private Sub FileMercator2LatLon(ByVal North As Double, ByVal South As Double, ByVal inputfile As String, ByVal outfile As String)


        // Dim N, K As Integer
        // Dim lat, dlat As Double
        // Dim merc, dmerc As Double
        // Dim north_m, south_m As Double

        // Dim img As Image = Image.FromFile(inputfile)
        // Dim imgformat As ImageFormat = img.RawFormat
        // Dim rows As Integer = img.Height
        // Dim cols As Integer = img.Width

        // Dim bmp As ImageFormat = ImageFormat.Bmp
        // Dim ms1 As New MemoryStream
        // img.Save(ms1, bmp)

        // Dim inp() As Byte = ms1.GetBuffer
        // ms1.Close()
        // img.Dispose()

        // Dim out() As Byte = inp.Clone

        // Dim Base, LineWidth, pointN, pointK As Integer
        // Dim BytesPerPixel As Integer

        // Base = BitConverter.ToInt32(inp, 10)
        // BytesPerPixel = CInt(BitConverter.ToInt16(inp, 28) / 8)
        // LineWidth = cols * BytesPerPixel
        // ' make LineWidth a multiple of 4
        // N = Int((LineWidth - 1) / 4)
        // LineWidth = (N + 1) * 4


        // dlat = (North - South) / (rows - 1)
        // north_m = YMercFromLat(North)
        // south_m = YMercFromLat(South)
        // dmerc = (north_m - south_m) / (rows - 1)
        // lat = South + dlat

        // For N = 1 To rows - 2
        // merc = YMercFromLat(lat)
        // merc = merc - south_m
        // merc = merc / dmerc
        // K = CInt(merc)   ' round
        // If N <> K Then
        // pointN = Base + (rows - N - 1) * LineWidth
        // pointK = Base + (rows - K - 1) * LineWidth
        // Array.Copy(inp, pointK, out, pointN, LineWidth)
        // End If
        // lat = lat + dlat
        // Next

        // Dim ms2 As New MemoryStream(out)
        // img = Image.FromStream(ms2)
        // img.Save(outfile, imgformat)
        // ms2.Close()
        // img.Dispose()


        // End Sub


        internal static void PixelHeightFromY(int Y, ref int[] H, int N, int Z)
        {
            int R;
            double NS;
            double[] X = new double[N + 1];
            int loopTo = N;
            for (R = 0; R <= loopTo; R++)
                X[R] = LatFromYMerc(Y + R, Z);
            // Debug.Print(vbCrLf)

            NS = 256 * N / (X[0] - X[N]);
            int loopTo1 = N - 1;
            for (R = 0; R <= loopTo1; R++)
                // Debug.Print(H(R))
                H[R] = (int)((X[R] - X[R + 1]) * NS);
        }

        internal static double LatFromYMerc(int Y, int Z)
        {
            double LatFromYMercRet = default;
            double dXY, lat;
            dXY = moduleMAIN.PI / Math.Pow(2d, Z);
            lat = Y * dXY;
            lat = moduleMAIN.PI - lat;
            lat = Math.Exp(lat);
            lat = 2d * Math.Atan(lat);
            LatFromYMercRet = (lat - pi_2) / pi_180;
            return LatFromYMercRet;
        }

        internal static double LonFromXMerc(int X, int Z)
        {
            double LonFromXMercRet = default;
            double dXY;
            dXY = moduleMAIN.PI / Math.Pow(2d, Z);
            LonFromXMercRet = (X * dXY - moduleMAIN.PI) / pi_180;
            return LonFromXMercRet;
        }

        internal static string TileDirFromXYZ(int X, int Y, int Z)
        {
            string TileDirFromXYZRet = default;
            TileDirFromXYZRet = "";
            if (Z < 4)
                return TileDirFromXYZRet;
            int N;
            int Limit;
            for (N = Z; N >= 4; N -= 1)
            {
                Limit = (int)Math.Pow(2d, N);
                if (X < Limit)
                {
                    if (Y < Limit)
                    {
                        TileDirFromXYZRet = TileDirFromXYZRet + @"\0";
                    }
                    else
                    {
                        TileDirFromXYZRet = TileDirFromXYZRet + @"\2";
                        Y = Y - Limit;
                    }
                }
                else
                {
                    if (Y < Limit)
                    {
                        TileDirFromXYZRet = TileDirFromXYZRet + @"\1";
                    }
                    else
                    {
                        TileDirFromXYZRet = TileDirFromXYZRet + @"\3";
                        Y = Y - Limit;
                    }

                    X = X - Limit;
                }
            }

            return TileDirFromXYZRet;
        }

        internal static void DisplayTiles(Graphics g)
        {
            double MapPixelsPerDegree;
            Rectangle screen = new Rectangle();
            RectangleF source = new RectangleF();
            GraphicsUnit units = GraphicsUnit.Pixel;
            if (MapBackground.NLAT < moduleMAIN.LatDispSouth)
                return;
            if (MapBackground.SLAT > moduleMAIN.LatDispNorth)
                return;
            if (MapBackground.WLON > moduleMAIN.LonDispEast)
                return;
            if (MapBackground.ELON < moduleMAIN.LonDispWest)
                return;
            if (MapBackground.WLON > moduleMAIN.LonDispWest)
            {
                if (MapBackground.ELON > moduleMAIN.LonDispEast)
                {
                    MapPixelsPerDegree = MapBackground.COLS / (MapBackground.ELON - MapBackground.WLON);
                    source.X = 0f;
                    source.Width = (float)((moduleMAIN.LonDispEast - MapBackground.WLON) * MapPixelsPerDegree);
                    screen.X = (int)((MapBackground.WLON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                    screen.Width = moduleMAIN.DisplayWidth - screen.X;
                }
                else
                {
                    source.X = 0f;
                    source.Width = MapBackground.COLS;
                    screen.X = (int)((MapBackground.WLON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                    screen.Width = (int)((MapBackground.ELON - MapBackground.WLON) * moduleMAIN.PixelsPerLonDeg);
                }
            }
            else if (MapBackground.ELON > moduleMAIN.LonDispEast)
            {
                MapPixelsPerDegree = MapBackground.COLS / (MapBackground.ELON - MapBackground.WLON);
                source.X = (float)((moduleMAIN.LonDispWest - MapBackground.WLON) * MapPixelsPerDegree);
                source.Width = (float)((moduleMAIN.LonDispEast - moduleMAIN.LonDispWest) * MapPixelsPerDegree);
                screen.X = 0;
                screen.Width = moduleMAIN.DisplayWidth;
            }
            else
            {
                MapPixelsPerDegree = MapBackground.COLS / (MapBackground.ELON - MapBackground.WLON);
                source.X = (float)((moduleMAIN.LonDispWest - MapBackground.WLON) * MapPixelsPerDegree);
                source.Width = (float)((MapBackground.ELON - moduleMAIN.LonDispWest) * MapPixelsPerDegree);
                screen.X = 0;
                screen.Width = (int)((MapBackground.ELON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            }

            if (MapBackground.SLAT > moduleMAIN.LatDispSouth)
            {
                if (MapBackground.NLAT > moduleMAIN.LatDispNorth)
                {
                    MapPixelsPerDegree = MapBackground.ROWS / (MapBackground.NLAT - MapBackground.SLAT);
                    source.Y = (float)((MapBackground.NLAT - moduleMAIN.LatDispNorth) * MapPixelsPerDegree);
                    source.Height = (float)((moduleMAIN.LatDispNorth - MapBackground.SLAT) * MapPixelsPerDegree);
                    screen.Y = 0;
                    screen.Height = (int)((moduleMAIN.LatDispNorth - MapBackground.SLAT) * moduleMAIN.PixelsPerLatDeg);
                }
                else
                {
                    source.Y = 0f;
                    source.Height = MapBackground.ROWS;
                    screen.Y = (int)((moduleMAIN.LatDispNorth - MapBackground.NLAT) * moduleMAIN.PixelsPerLatDeg);
                    screen.Height = (int)((MapBackground.NLAT - MapBackground.SLAT) * moduleMAIN.PixelsPerLatDeg);
                }
            }
            else if (MapBackground.NLAT > moduleMAIN.LatDispNorth)
            {
                MapPixelsPerDegree = MapBackground.ROWS / (MapBackground.NLAT - MapBackground.SLAT);
                source.Y = (int)((MapBackground.NLAT - moduleMAIN.LatDispNorth) * MapPixelsPerDegree);
                source.Height = (int)((moduleMAIN.LatDispNorth - moduleMAIN.LatDispSouth) * MapPixelsPerDegree);
                screen.Y = 0;
                screen.Height = moduleMAIN.DisplayHeight;
            }
            else
            {
                MapPixelsPerDegree = MapBackground.ROWS / (MapBackground.NLAT - MapBackground.SLAT);
                source.Y = 0f;
                source.Height = (int)((MapBackground.NLAT - moduleMAIN.LatDispSouth) * MapPixelsPerDegree);
                screen.Y = (int)((moduleMAIN.LatDispNorth - MapBackground.NLAT) * moduleMAIN.PixelsPerLatDeg);
                screen.Height = (int)((MapBackground.NLAT - moduleMAIN.LatDispSouth) * moduleMAIN.PixelsPerLatDeg);
            }

            if (moduleMAIN.Zoom > GlobeOrTiles)
            {
                if (ImageBackground is object)
                    g.DrawImage(ImageBackground, screen, source, units);
            }
            else
            {
                g.DrawImage(ImageGlobe, screen, source, units);
            }

            // If TilesToCome > 0 Then
            // Dim XY As Point
            // XY.X = 0
            // XY.Y = DisplayHeight - 35
            // frmStart.lbTilesRemaining.Location = XY
            // frmStart.lbTilesRemaining.Text = "(" & TilesToCome & " tiles remainning) downloading from " & TileServer.ServerName
            // frmStart.lbTilesRemaining.Visible = True
            // Else
            // frmStart.lbTilesRemaining.Visible = False
            // End If

        }

        internal static void SaveBackground(string Filename)
        {
            Image GeoTiff;
            MemoryStream Stream = new MemoryStream();
            ImageBackground.Save(Stream, ImageFormat.Tiff);
            GeoTiff = Image.FromStream(Stream);
            PropertyItem propItem;
            propItem = GeoTiff.GetPropertyItem(256);
            propItem.Len = 40;
            propItem.Type = 3;
            propItem.Value = moduleMAPS.MakeGeoKeyDirTag();
            propItem.Id = 34735;
            GeoTiff.SetPropertyItem(propItem);
            double North = MapBackground.NLAT;
            double South = MapBackground.SLAT;
            double East = MapBackground.ELON;
            double West = MapBackground.WLON;
            int Cols = MapBackground.COLS;
            int Rows = MapBackground.ROWS;
            double LX, SX;
            double LY, SY;
            SX = (East - West) / Cols;
            SY = (North - South) / Rows;
            LX = West + SX / 2d;
            LY = North + SY / 2d;
            propItem.Id = 33922;
            propItem.Len = 48;
            propItem.Type = 10;
            propItem.Value = moduleMAPS.MakeTiePointTag(LX, LY);
            GeoTiff.SetPropertyItem(propItem);
            propItem.Len = 24;
            propItem.Id = 33550;
            propItem.Value = moduleMAPS.MakePixelScaleTag(SX, SY);
            GeoTiff.SetPropertyItem(propItem);
            GeoTiff.Save(Filename, ImageFormat.Tiff);
            Stream.Dispose();
            byte[] buffer;
            buffer = File.ReadAllBytes(Filename);
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
            File.WriteAllBytes(Filename, buffer);
            buffer = new byte[1];
            string Name = "Photo_L" + moduleMAIN.Zoom.ToString();
            int X = XTilesFromLon(moduleMAIN.LonDispCenter, moduleMAIN.Zoom);
            Name = Name + "X" + (X - 3).ToString() + "X" + (X + 3).ToString();
            X = YTilesFromLat(moduleMAIN.LatDispCenter, moduleMAIN.Zoom);
            Name = Name + "Y" + (X - 2).ToString() + "Y" + (X + 2).ToString();
            SaveDataFile(Filename, North, South, West, East, Name);
        }

        internal static void SaveDataFile(string myfile, double NLat, double SLat, double WLon, double ELon, string str)
        {
            string A, DataFile, DataPath, FullFile;
            DataFile = Path.GetFileNameWithoutExtension(myfile) + ".TXT";
            DataPath = Path.GetDirectoryName(myfile);
            FullFile = DataPath + @"\" + DataFile;
            if (File.Exists(FullFile))
            {
                A = "The data file:" + Environment.NewLine + Environment.NewLine + DataFile + Environment.NewLine + Environment.NewLine;
                A = A + "already exists! Overwrite?";
                if (DialogResult.No == MessageBox.Show(A, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    return;
            }

            using (StreamWriter file = new StreamWriter(FullFile))
            {
                A = "[GEOGRAPHIC]";
                file.WriteLine(A);
                A = "Name=" + str;
                file.WriteLine(A);
                A = "North=" + NLat.ToString();
                file.WriteLine(A);
                A = "South=" + SLat.ToString();
                file.WriteLine(A);
                A = "West=" + WLon.ToString();
                file.WriteLine(A);
                A = "East=" + ELon.ToString();
                file.WriteLine(A);
                file.WriteLine();
            }
        }

        internal static void MakeBglPhoto(bool CopyBGLs)
        {
            int N;
            string A;
            int loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                if (moduleMAPS.Maps[N].Selected)
                {
                    A = (moduleMAPS.Maps[N].Name.Length < 5) ? "" : moduleMAPS.Maps[N].Name.Substring(0, 5).ToUpper();
                    if (A == "PHOTO")
                    {
                        A = Path.GetExtension(moduleMAPS.Maps[N].BMPSu).ToUpper();
                        if (A == ".BMP")
                        {
                            MakeThisBglPhoto(N, CopyBGLs);
                        }
                    }
                }
            }
        }

        private static void MakeThisBglPhoto(int N, bool CopyBGLs)
        {
            int K;
            int NoOfSources;
            string[] SourceFiles = new string[7];
            string[] Variations = new string[7];
            bool All;
            bool Day;
            SourceFiles[1] = moduleMAPS.Maps[N].BMPSu;
            SourceFiles[2] = moduleMAPS.Maps[N].BMPSp;
            SourceFiles[3] = moduleMAPS.Maps[N].BMPFa;
            SourceFiles[4] = moduleMAPS.Maps[N].BMPWi;
            SourceFiles[5] = moduleMAPS.Maps[N].BMPHw;
            SourceFiles[6] = moduleMAPS.Maps[N].BMPLm;
            Variations[1] = SummerVariations;
            Variations[2] = SpringVariations;
            Variations[3] = FallVariations;
            Variations[4] = WinterVariations;
            Variations[5] = HardWinterVariations;
            Variations[6] = "Night";
            All = true;
            for (K = 2; K <= 6; K++)
            {
                if ((SourceFiles[K] ?? "") != (SourceFiles[1] ?? ""))
                {
                    All = false;
                    break;
                }
            }

            if (All)
            {
                MakeThisBglPhotoAll(N, CopyBGLs);
                return;
            }

            Day = true;
            for (K = 2; K <= 5; K++)
            {
                if ((SourceFiles[K] ?? "") != (SourceFiles[1] ?? ""))
                {
                    Day = false;
                    break;
                }
            }

            if (Day)
            {
                MakeThisBglPhotoDay(N, CopyBGLs);
                return;
            }

            for (K = 2; K <= 5; K++)
            {
                if ((SourceFiles[K] ?? "") == (SourceFiles[1] ?? ""))
                {
                    Variations[1] = Variations[1] + "," + Variations[K];
                    SourceFiles[K] = "";
                }
            }

            if (!string.IsNullOrEmpty(SourceFiles[2]))
            {
                for (K = 3; K <= 5; K++)
                {
                    if ((SourceFiles[K] ?? "") == (SourceFiles[2] ?? ""))
                    {
                        Variations[2] = Variations[2] + "," + Variations[K];
                        SourceFiles[K] = "";
                    }
                }
            }

            if (!string.IsNullOrEmpty(SourceFiles[3]))
            {
                for (K = 4; K <= 5; K++)
                {
                    if ((SourceFiles[K] ?? "") == (SourceFiles[3] ?? ""))
                    {
                        Variations[3] = Variations[3] + "," + Variations[K];
                        SourceFiles[K] = "";
                    }
                }
            }

            if (!string.IsNullOrEmpty(SourceFiles[4]))
            {
                if ((SourceFiles[5] ?? "") == (SourceFiles[4] ?? ""))
                {
                    Variations[4] = Variations[4] + "," + Variations[5];
                    SourceFiles[5] = "";
                }
            }

            NoOfSources = 1;
            for (K = 2; K <= 5; K++)
            {
                if (!string.IsNullOrEmpty(SourceFiles[K]))
                {
                    NoOfSources = NoOfSources + 1;
                    SourceFiles[NoOfSources] = SourceFiles[K];
                    Variations[NoOfSources] = Variations[K];
                }
            }

            if ((SourceFiles[1] ?? "") != (SourceFiles[6] ?? ""))
            {
                NoOfSources = NoOfSources + 1;
                SourceFiles[NoOfSources] = SourceFiles[6];
                Variations[NoOfSources] = Variations[6];
            }

            // now make INF

            string InfFile, BGLFile, BGLFileTarget;
            string BaseName = moduleMAPS.Maps[N].Name;
            string SourceFile;
            InfFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".INF";
            BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".BGL";
            bool IsBlend = false;
            bool IsWater = false;
            string BlendName = Path.GetFileNameWithoutExtension(moduleMAPS.Maps[N].BMPSu) + "_B.TIF";
            string WaterName = Path.GetFileNameWithoutExtension(moduleMAPS.Maps[N].BMPSu) + "_W.TIF";
            if (File.Exists(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BlendName))
            {
                IsBlend = true;
            }

            if (File.Exists(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + WaterName))
            {
                IsWater = true;
            }

            int ExtraNoOfSources = 0;
            if (IsBlend)
                ExtraNoOfSources = 1;
            if (IsWater)
                ExtraNoOfSources = ExtraNoOfSources + 1;
            if (File.Exists(BGLFile))
                File.Delete(BGLFile);
            string Command = "resample" + @" work\" + BaseName + ".INF";
            using (StreamWriter file = new StreamWriter(InfFile))
            {
                file.WriteLine("[Source]");
                file.WriteLine("   Type = MultiSource");
                file.WriteLine("   NumberOfSources = " + (NoOfSources + ExtraNoOfSources).ToString());
                int loopTo = NoOfSources;
                for (K = 1; K <= loopTo; K++)
                {
                    SourceFile = Path.GetFileName(SourceFiles[K]);
                    file.WriteLine();
                    file.WriteLine("[Source" + K.ToString() + "]");
                    file.WriteLine("   Type = BMP");
                    file.WriteLine("   Layer = Imagery");
                    file.WriteLine("   SourceDir = " + '"' + "." + '"');
                    file.WriteLine("   SourceFile = " + '"' + SourceFile + '"');
                    file.WriteLine("   Variation = " + Variations[K]);
                    if (IsBlend)
                        file.WriteLine("   Channel_BlendMask = " + (NoOfSources + 1).ToString() + ".0");
                    if (IsWater & ExtraNoOfSources == 1)
                        file.WriteLine("   Channel_LandWaterMask = " + (NoOfSources + 1).ToString() + ".0");
                    if (IsWater & ExtraNoOfSources == 2)
                        file.WriteLine("   Channel_LandWaterMask = " + (NoOfSources + 2).ToString() + ".0");
                    file.WriteLine("   NullValue = 255,255,255");
                    file.WriteLine("   SamplingMethod = Gaussian");
                    file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                    file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                    file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                    file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                }

                if (IsBlend)
                {
                    file.WriteLine();
                    file.WriteLine("[Source" + (NoOfSources + 1).ToString() + "]");
                    file.WriteLine("   Type = TIFF");
                    file.WriteLine("   Layer = None");
                    file.WriteLine("   SourceDir = " + '"' + "." + '"');
                    file.WriteLine("   SourceFile = " + '"' + BlendName + '"');
                    file.WriteLine("   SamplingMethod = Gaussian");
                    file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                    file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                    file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                    file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                }

                if (IsWater)
                {
                    file.WriteLine();
                    if (ExtraNoOfSources == 1)
                        file.WriteLine("[Source" + (NoOfSources + 1).ToString() + "]");
                    if (ExtraNoOfSources == 2)
                        file.WriteLine("[Source" + (NoOfSources + 2).ToString() + "]");
                    file.WriteLine("   Type = TIFF");
                    file.WriteLine("   Layer = None");
                    file.WriteLine("   SourceDir = " + '"' + "." + '"');
                    file.WriteLine("   SourceFile = " + '"' + WaterName + '"');
                    file.WriteLine("   SamplingMethod = Gaussian");
                    file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                    file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                    file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                    file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                }

                file.WriteLine();
                file.WriteLine("[Destination]");
                file.WriteLine("   DestDir = " + '"' + "." + '"');
                file.WriteLine("   DestBaseFileName = " + '"' + BaseName + '"');
                file.WriteLine("   DestFileType = BGL");
                file.WriteLine("   LOD = Auto");
                file.WriteLine("   UseSourceDimensions = 1");
                file.WriteLine("   CompressionQuality = " + CompressionQuality.ToString());
            }
            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            moduleMAIN.ExecCmd(Command);
            if (!CopyBGLs)
                return;

            // copy BGL files
            try
            {
                BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + BaseName + ".BGL";
                if (File.Exists(BGLFile))
                    File.Copy(BGLFile, BGLFileTarget, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static void MakeThisBglPhotoAll(int N, bool CopyBGLs)
        {
            string InfFile, BGLFile, BGLFileTarget;
            string BaseName = moduleMAPS.Maps[N].Name;
            string SourceName = Path.GetFileName(moduleMAPS.Maps[N].BMPSu);
            InfFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".INF";
            BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".BGL";
            bool IsBlend = false;
            bool IsWater = false;
            string BlendName = Path.GetFileNameWithoutExtension(moduleMAPS.Maps[N].BMPSu) + "_B.TIF";
            string WaterName = Path.GetFileNameWithoutExtension(moduleMAPS.Maps[N].BMPSu) + "_W.TIF";
            if (File.Exists(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BlendName))
            {
                IsBlend = true;
            }

            if (File.Exists(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + WaterName))
            {
                IsWater = true;
            }

            int NoOfSources = 1;
            if (IsBlend)
                NoOfSources = NoOfSources + 1;
            if (IsWater)
                NoOfSources = NoOfSources + 1;
            if (File.Exists(BGLFile))
                File.Delete(BGLFile);
            string Command = "resample" + @" work\" + BaseName + ".INF";
            using (StreamWriter file = new StreamWriter(InfFile))
            {
                file.WriteLine("[Source]");
                if (NoOfSources == 2)
                {
                    file.WriteLine("   Type = MultiSource");
                    file.WriteLine("   NumberOfSources = 2");
                    file.WriteLine("[Source1]");
                }

                if (NoOfSources == 3)
                {
                    file.WriteLine("   Type = MultiSource");
                    file.WriteLine("   NumberOfSources = 3");
                    file.WriteLine("[Source1]");
                }

                file.WriteLine("   Type = BMP");
                file.WriteLine("   Layer = Imagery");
                file.WriteLine("   SourceDir = " + '"' + "." + '"');
                file.WriteLine("   SourceFile = " + '"' + SourceName + '"');
                file.WriteLine("   Variation = All");
                if (IsBlend)
                    file.WriteLine("   Channel_BlendMask = 2.0");
                if (IsWater & NoOfSources == 2)
                    file.WriteLine("   Channel_LandWaterMask = 2.0");
                if (IsWater & NoOfSources == 3)
                    file.WriteLine("   Channel_LandWaterMask = 3.0");
                file.WriteLine("   NullValue = 255,255,255");
                file.WriteLine("   SamplingMethod = Gaussian");
                file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                if (IsBlend)
                {
                    file.WriteLine();
                    file.WriteLine("[Source2]");
                    file.WriteLine("   Type = TIFF");
                    file.WriteLine("   Layer = None");
                    file.WriteLine("   SourceDir = " + '"' + "." + '"');
                    file.WriteLine("   SourceFile = " + '"' + BlendName + '"');
                    file.WriteLine("   SamplingMethod = Gaussian");
                    file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                    file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                    file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                    file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                }

                if (IsWater)
                {
                    file.WriteLine();
                    if (NoOfSources == 2)
                        file.WriteLine("[Source2]");
                    if (NoOfSources == 3)
                        file.WriteLine("[Source3]");
                    file.WriteLine("   Type = TIFF");
                    file.WriteLine("   Layer = None");
                    file.WriteLine("   SourceDir = " + '"' + "." + '"');
                    file.WriteLine("   SourceFile = " + '"' + WaterName + '"');
                    file.WriteLine("   SamplingMethod = Gaussian");
                    file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                    file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                    file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                    file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                }

                file.WriteLine();
                file.WriteLine("[Destination]");
                file.WriteLine("   DestDir = " + '"' + "." + '"');
                file.WriteLine("   DestBaseFileName = " + '"' + BaseName + '"');
                file.WriteLine("   DestFileType = BGL");
                file.WriteLine("   LOD = Auto");
                file.WriteLine("   UseSourceDimensions = 1");
                file.WriteLine("   CompressionQuality = " + CompressionQuality.ToString());
            }
            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            moduleMAIN.ExecCmd(Command);
            if (!CopyBGLs)
                return;

            // copy BGL files
            try
            {
                BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + BaseName + ".BGL";
                if (File.Exists(BGLFile))
                    File.Copy(BGLFile, BGLFileTarget, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        internal static void MakeBglPhotoBackground(bool CopyBGLs)
        {
            string BaseName = "L" + moduleMAIN.Zoom.ToString();
            int X = XTilesFromLon(moduleMAIN.LonDispCenter, moduleMAIN.Zoom);
            BaseName = BaseName + "X" + (X - 3).ToString() + "X" + (X + 3).ToString();
            X = YTilesFromLat(moduleMAIN.LatDispCenter, moduleMAIN.Zoom);
            BaseName = BaseName + "Y" + (X - 2).ToString() + "Y" + (X + 2).ToString();
            string BMPSourceName = BaseName + ".BMP";

            // save the background as bitmap file
            string BMPFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".BMP";
            ImageBackground.Save(BMPFile, ImageFormat.Bmp);
            string InfFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".INF";
            string BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".BGL";
            if (File.Exists(BGLFile))
                File.Delete(BGLFile);
            string BlendFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\blendmask.tif";
            if (!File.Exists(BlendFile))
            {
                File.Copy(My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\blendmask.tif", BlendFile);
            }

            string Command = "resample" + @" work\" + BaseName + ".INF";
            using (StreamWriter file = new StreamWriter(InfFile))
            {
                file.WriteLine("[Source]");
                file.WriteLine("   Type = MultiSource");
                file.WriteLine("   NumberOfSources = 2");
                file.WriteLine("[Source1]");
                file.WriteLine("   Type = BMP");
                file.WriteLine("   Layer = Imagery");
                file.WriteLine("   SourceDir = " + '"' + "." + '"');
                file.WriteLine("   SourceFile = " + '"' + BMPSourceName + '"');
                file.WriteLine("   Variation = All");
                file.WriteLine("   Channel_BlendMask = 2.0");
                file.WriteLine("   NullValue = 255,255,255");
                file.WriteLine("   SamplingMethod = Gaussian");
                file.WriteLine("   ulyMap = " + MapBackground.NLAT);
                file.WriteLine("   ulxMap = " + MapBackground.WLON);
                file.WriteLine("   xDim = " + (MapBackground.ELON - MapBackground.WLON) / MapBackground.COLS);
                file.WriteLine("   yDim = " + (MapBackground.NLAT - MapBackground.SLAT) / MapBackground.ROWS);
                file.WriteLine();
                file.WriteLine("[Source2]");
                file.WriteLine("   Type = TIFF");
                file.WriteLine("   Layer = None");
                file.WriteLine("   SourceDir = " + '"' + "." + '"');
                file.WriteLine("   SourceFile = " + '"' + "blendmask.tif" + '"');
                file.WriteLine("   SamplingMethod = Gaussian");
                file.WriteLine("   ulyMap = " + MapBackground.NLAT);
                file.WriteLine("   ulxMap = " + MapBackground.WLON);
                file.WriteLine("   xDim = " + (MapBackground.ELON - MapBackground.WLON) / MapBackground.COLS);
                file.WriteLine("   yDim = " + (MapBackground.NLAT - MapBackground.SLAT) / MapBackground.ROWS);
                file.WriteLine();
                file.WriteLine("[Destination]");
                file.WriteLine("   DestDir = " + '"' + "." + '"');
                file.WriteLine("   DestBaseFileName = " + '"' + BaseName + '"');
                file.WriteLine("   DestFileType = BGL");
                file.WriteLine("   LOD = Auto");
                file.WriteLine("   UseSourceDimensions = 1");
                file.WriteLine("   CompressionQuality = " + CompressionQuality.ToString());
            }
            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            moduleMAIN.ExecCmd(Command);
            if (!CopyBGLs)
                return;
            string BGLFileTarget;
            // copy BGL files
            try
            {
                BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + BaseName + ".BGL";
                if (File.Exists(BGLFile))
                    File.Copy(BGLFile, BGLFileTarget, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private static void MakeThisBglPhotoDay(int N, bool CopyBGLs)
        {
            string InfFile, BGLFile, BGLFileTarget;
            string BaseName = moduleMAPS.Maps[N].Name;
            string SourceDay = Path.GetFileName(moduleMAPS.Maps[N].BMPSu);
            string SourceNight = Path.GetFileName(moduleMAPS.Maps[N].BMPLm);
            InfFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".INF";
            BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BaseName + ".BGL";
            bool IsBlend = false;
            bool IsWater = false;
            string BlendName = Path.GetFileNameWithoutExtension(moduleMAPS.Maps[N].BMPSu) + "_B.TIF";
            string WaterName = Path.GetFileNameWithoutExtension(moduleMAPS.Maps[N].BMPSu) + "_W.TIF";
            if (File.Exists(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BlendName))
            {
                IsBlend = true;
            }

            if (File.Exists(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + WaterName))
            {
                IsWater = true;
            }

            int NoOfSources = 2;
            if (IsBlend)
                NoOfSources = NoOfSources + 1;
            if (IsWater)
                NoOfSources = NoOfSources + 1;
            if (File.Exists(BGLFile))
                File.Delete(BGLFile);
            string Command = "resample" + @" work\" + BaseName + ".INF";
            using (StreamWriter file = new StreamWriter(InfFile))
            {
                file.WriteLine("[Source]");
                file.WriteLine("   Type = MultiSource");
                if (NoOfSources == 2)
                    file.WriteLine("   NumberOfSources = 2");
                if (NoOfSources == 3)
                    file.WriteLine("   NumberOfSources = 3");
                if (NoOfSources == 4)
                    file.WriteLine("   NumberOfSources = 4");
                file.WriteLine();
                file.WriteLine("[Source1]");
                file.WriteLine("   Type = BMP");
                file.WriteLine("   Layer = Imagery");
                file.WriteLine("   SourceDir = " + '"' + "." + '"');
                file.WriteLine("   SourceFile = " + '"' + SourceDay + '"');
                file.WriteLine("   Variation = Day");
                if (IsBlend)
                    file.WriteLine("   Channel_BlendMask = 3.0");
                if (IsWater & NoOfSources == 3)
                    file.WriteLine("   Channel_LandWaterMask = 3.0");
                if (IsWater & NoOfSources == 4)
                    file.WriteLine("   Channel_LandWaterMask = 4.0");
                file.WriteLine("   NullValue = 255,255,255");
                file.WriteLine("   SamplingMethod = Gaussian");
                file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                file.WriteLine();
                file.WriteLine("[Source2]");
                file.WriteLine("   Type = BMP");
                file.WriteLine("   Layer = Imagery");
                file.WriteLine("   SourceDir = " + '"' + "." + '"');
                file.WriteLine("   SourceFile = " + '"' + SourceNight + '"');
                file.WriteLine("   Variation = Night");
                if (IsBlend)
                    file.WriteLine("   Channel_BlendMask = 3.0");
                if (IsWater & NoOfSources == 3)
                    file.WriteLine("   Channel_LandWaterMask = 3.0");
                if (IsWater & NoOfSources == 4)
                    file.WriteLine("   Channel_LandWaterMask = 4.0");
                file.WriteLine("   NullValue = 255,255,255");
                file.WriteLine("   SamplingMethod = Gaussian");
                file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                if (IsBlend)
                {
                    file.WriteLine(3);
                    file.WriteLine("[Source3]");
                    file.WriteLine("   Type = TIFF");
                    file.WriteLine("   Layer = None");
                    file.WriteLine("   SourceDir = " + '"' + "." + '"');
                    file.WriteLine("   SourceFile = " + '"' + BlendName + '"');
                    file.WriteLine("   SamplingMethod = Gaussian");
                    file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                    file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                    file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                    file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                }

                if (IsWater)
                {
                    file.WriteLine();
                    if (NoOfSources == 3)
                        file.WriteLine("[Source3]");
                    if (NoOfSources == 4)
                        file.WriteLine("[Source4]");
                    file.WriteLine("   Type = TIFF");
                    file.WriteLine("   Layer = None");
                    file.WriteLine("   SourceDir = " + '"' + "." + '"');
                    file.WriteLine("   SourceFile = " + '"' + WaterName + '"');
                    file.WriteLine("   SamplingMethod = Gaussian");
                    file.WriteLine("   ulyMap = " + moduleMAPS.Maps[N].NLAT);
                    file.WriteLine("   ulxMap = " + moduleMAPS.Maps[N].WLON);
                    file.WriteLine("   xDim = " + (moduleMAPS.Maps[N].ELON - moduleMAPS.Maps[N].WLON) / moduleMAPS.Maps[N].COLS);
                    file.WriteLine("   yDim = " + (moduleMAPS.Maps[N].NLAT - moduleMAPS.Maps[N].SLAT) / moduleMAPS.Maps[N].ROWS);
                }

                file.WriteLine();
                file.WriteLine("[Destination]");
                file.WriteLine("   DestDir = " + '"' + "." + '"');
                file.WriteLine("   DestBaseFileName = " + '"' + BaseName + '"');
                file.WriteLine("   DestFileType = BGL");
                file.WriteLine("   LOD = Auto");
                file.WriteLine("   UseSourceDimensions = 1");
                file.WriteLine("   CompressionQuality = " + CompressionQuality.ToString());
            }
            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            moduleMAIN.ExecCmd(Command);
            if (!CopyBGLs)
                return;

            // copy BGL files
            try
            {
                BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + BaseName + ".BGL";
                if (File.Exists(BGLFile))
                    File.Copy(BGLFile, BGLFileTarget, true);
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}