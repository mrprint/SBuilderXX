using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SBuilderXX
{
    static class moduleCLASSES
    {

        // This structure is used for the classes of land and water.
        internal struct LWClass
        {
            public byte Index;
            public string Texture;
            public string Caption;
            public Color Color;
        }

        // File Lands.txt holds 120 classes of land. When SBuilderXX starts it
        // fills the array LC() which has 256 elements (0 to 255) by reading
        // that file. For example the 3rd entry in Lands.txt is:
        // Name=135_Y_Golf_Course
        // Color=FF646946
        // Textures=135b2su1
        // This data will be used to fill element LC(3) (we do not use index 0)
        // as follows:
        // LC(3).Index = 135
        // LC(3).Texture = 135b2su1
        // LC(3).Caption = Y_Golf_Course
        // LC(3).Color = FF646946
        // Since elements from 121 to 255 are not used, we use the free space
        // to handle the selection state of class tiles (shown in green in SBuilderXX). So:
        // LC(3 + 128).Index = 135
        // LC(3 + 128).Texture = sel        sel.bmp is a green texture
        // LC(3 + 128).Caption =            leave blank as we do not use it
        // LC(3 + 128).Color = FF00FF00     which is green

        internal static LWClass[] LC = new LWClass[256];
        internal static int NoOfLCs; // taken from Lands.txt =120 at present
        internal static byte[] ILC = new byte[256];  // we set this array at the start. 
                                                     // For the example above when we read the 3rd element in Lands.txt
                                                     // ILC(135) = 3
                                                     // this is useful to get the index of LC() given the FSX landclass
        internal static byte DefaultLC = 12; // we need one > INI file

        internal struct JKCR
        {
            public int J;
            public int K;
            public int C;
            public int R;
        }

        // Land (or Water) Class Tiles mean quads (of LOD13 size) with a
        // position defined by values J K C R. Both Land and Water Class Tiles
        // use the following structure. J and K refer to the LOD5 quad position
        // to which the Tile belongs. J varies from 0 to 95 (west to east) and
        // K varies from 0 to 63 (north to south). C and R (Column and Row) refer
        // to the position of the Tile inside the LOD5 quad. They vary from 0 to
        // 256 (C from west to east and R from north to south). Note that each
        // LOD5 quad has 257 x 257 tiles and they overlap. Two adjacent LOD5 quads
        // share a common border. For example when we change the value of tile
        // (J=12 K=23 C=256 R=154) we need to change also the value of the adjacent
        // tile (J=13 K=23 C=0 R=154).

        // There are 96 X 64 = 6,144 LOD5 quads in the world and each LOD5 quad contains
        // 256 x 256 = 65,536 LOD13 quads (we do not count twice the replicated quads
        // at the LOD5 borders. So the total number of LOD13 quads is 402,653,184. In
        // order to store the values (bytes) that define the classes of land for all
        // 402,653,184 tiles, we would need an array of bytes of that dimension. And another
        // array of the same dimension to represent all the tiles of water.

        // In order to minimize the size of the arrays that represent the land and water
        // tiles, we use the following structure:
        [Serializable()]
        internal struct LWXY
        {
            public int Pointer;     // points to the 3d dimension of LLands(,,)
            public int NoOfLWs;     // number of "live" tiles in the LOD13
        }

        // the following 2 dimensional array:
        internal static LWXY[,] LL_XY = new LWXY[96, 64];
        internal static int NoOfLLXYs;

        // and the following 3-D array of bytes
        internal static byte[,,] LLands;
        internal static int NoOfLands = 0; // number of land tiles 

        // To understand this, suppose we have no land tile defined. In that situation
        // all the elements of LL_XY() will have their Field NoOfLWs = 0. This means
        // that no "live" LOD13 exist in all the LOD5s. Now suppose we add the class
        // definition of Y_Golf_Course to the tile (J=13 K=23 C=55 R=154). We need to make:
        // LL_XY(13,23).NoOfLWs=1
        // meaning that this LOD5 has now an "active" LOD13. Also NoOfLLXYs is incremented
        // (in this case from 0 to 1). Now an array of size LLands(256,256,1) is created and
        // the value of 3 (see above) is place into element (55,154,1). We only need to set 
        // LL_XY(13,23).Pointer = 1 (see below). We also need to increment NoOfLands by one.
        // Say you add the same class to tile (J=13 K=23 C=55 R=164). As it is on the same
        // LOD13 you only increment LL_XY(13,23).NoOfLWs and NoOfLands and set
        // LLands(55,154,1) = 3. Finaly say you add the same class (index 3) to tile
        // (J=88 K=89 C=50 R=100). Now we need to create a new array LLands(256,256,2)
        // and increment LL_XY(88,89).NoOfLWs and set LL_XY(88,89).Pointer = 2 to point
        // to the LLands(256,256,2) array ....

        // some parameters that control display
        internal static int NoOfLandsSelected = 0;
        internal static bool LandVIEW = false;
        internal static bool LandON;
        internal static bool LandsSelected;

        // NOW ALL THE EQUIVALENT FOR WATER WITHOUT COMMENTS

        internal static LWClass[] WC;
        internal static int NoOfWCs;
        internal static byte[] IWC = new byte[256];  // added 2009 March
        internal static byte DefaultWC = 1;
        internal static LWXY[,] WW_XY = new LWXY[96, 64];
        internal static int NoOfWWXYs;
        internal static byte[,,] WWaters;
        internal static int NoOfWaters = 0;
        internal static int NoOfWatersSelected = 0;
        internal static bool WaterVIEW = false;
        internal static bool WaterON;
        internal static bool WatersSelected;
        internal static bool LColPickON;

        // common to land and  water
        internal static int BrushSize;
        internal static bool LandWaterDELETE;
        internal static bool LandWaterRASTER;
        internal static bool LandWaterRasON;

        // the following are used with Class Maps
        [Serializable()]
        internal struct LWCIndex
        {
            public string Text;
            public bool IsLand; // not exported 
            public byte Class1; // not exported 
            public byte Class2; // not exported 
            public byte Class3; // not exported 
            public Color Color;
        }

        internal static LWCIndex[] LWCIs = new LWCIndex[2];
        internal static int NoOfLWCIs;

        internal static void LandInsertMode(ref short Button, int X, int Y)
        {
            // here is what happens when we insert a land tile

            double X1, Y1;
            if (Button == 1)
            {
                X1 = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
                Y1 = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
                FormLand(X1, Y1);
                moduleMAIN.RebuildDisplay();
            }

            if (Button == 2)
            {
                moduleMAIN.RebuildDisplay();
                modulePOPUP.ProcessPopUp(X, Y);
            }
        }

        internal static void WaterInsertMode(ref short Button, int X, int Y)
        {
            double X1, Y1;
            if (Button == 1)
            {
                X1 = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
                Y1 = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
                FormWater(X1, Y1);
                moduleMAIN.RebuildDisplay();
            }

            if (Button == 2)
            {
                moduleMAIN.RebuildDisplay();
                modulePOPUP.ProcessPopUp(X, Y);
            }
        }

        internal static void LandRasterMode(int X, int Y)
        {
            double X1, Y1;
            X1 = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            Y1 = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            FormLand(X1, Y1);
            moduleMAIN.RebuildDisplay();
        }

        internal static void WaterRasterMode(int X, int Y)
        {
            double X1, Y1;
            X1 = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            Y1 = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            FormWater(X1, Y1);
            moduleMAIN.RebuildDisplay();
        }

        private static void FormLand(double X, double Y)
        {
            int J, K, C, R;
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            X = X + 180d;
            X = X / moduleMAIN.D5Lon;
            J = (int)X;
            Y = 90d - Y;
            Y = Y / moduleMAIN.D5Lat;
            K = (int)Y;
            C = (int)Math.Round((X - J) * moduleMAIN.D5Lon / moduleMAIN.D13Lon);
            R = (int)Math.Round((Y - K) * moduleMAIN.D5Lat / moduleMAIN.D13Lat);
            int N1, N2, L, M, CC, RR;
            N1 = 1 - BrushSize;
            N2 = BrushSize - 1;
            int loopTo = N2;
            for (L = N1; L <= loopTo; L++)
            {
                int loopTo1 = N2;
                for (M = N1; M <= loopTo1; M++)
                {
                    CC = C + L;
                    RR = R + M;
                    if (CC < 0)
                        CC = 0;
                    if (CC > 256)
                        CC = 256;
                    if (RR < 0)
                        RR = 0;
                    if (RR > 256)
                        RR = 256;
                    FormOneLand(J, K, CC, RR, DefaultLC);
                }
            }
        }

        internal static void FormWater(double X, double Y)
        {
            int J, K, C, R;
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            X = X + 180d;
            X = X / moduleMAIN.D5Lon;
            J = (int)X;
            Y = 90d - Y;
            Y = Y / moduleMAIN.D5Lat;
            K = (int)Y;
            C = (int)Math.Round((X - J) * moduleMAIN.D5Lon / moduleMAIN.D13Lon);
            R = (int)Math.Round((Y - K) * moduleMAIN.D5Lat / moduleMAIN.D13Lat);
            int N1, N2, L, M, CC, RR;
            N1 = 1 - BrushSize;
            N2 = BrushSize - 1;
            int loopTo = N2;
            for (L = N1; L <= loopTo; L++)
            {
                int loopTo1 = N2;
                for (M = N1; M <= loopTo1; M++)
                {
                    CC = C + L;
                    RR = R + M;
                    if (CC < 0)
                        CC = 0;
                    if (CC > 256)
                        CC = 256;
                    if (RR < 0)
                        RR = 0;
                    if (RR > 256)
                        RR = 256;
                    FormOneWater(J, K, CC, RR, DefaultWC);
                }
            }
        }

        private static void FormOneLand(int J, int K, int C, int R, byte LC)
        {

            // check if the tiles should be replicated in adjacent LOD5 quads
            FormLandJKCR(J, K, C, R, LC);
            if (C == 0)
            {
                FormLandJKCR(J - 1, K, 256, R, LC);
                if (R == 0)
                    FormLandJKCR(J - 1, K - 1, 256, 256, LC);
                if (R == 256)
                    FormLandJKCR(J - 1, K + 1, 256, 0, LC);
            }

            if (C == 256)
            {
                FormLandJKCR(J + 1, K, 0, R, LC);
                if (R == 0)
                    FormLandJKCR(J + 1, K - 1, 0, 256, LC);
                if (R == 256)
                    FormLandJKCR(J + 1, K + 1, 0, 0, LC);
            }

            if (R == 0)
                FormLandJKCR(J, K - 1, C, 256, LC);
            if (R == 256)
                FormLandJKCR(J, K + 1, C, 0, LC);
        }

        private static void FormOneWater(int J, int K, int C, int R, byte WC)
        {
            FormWaterJKCR(J, K, C, R, WC);
            if (C == 0)
            {
                FormWaterJKCR(J - 1, K, 256, R, WC);
                if (R == 0)
                    FormWaterJKCR(J - 1, K - 1, 256, 256, WC);
                if (R == 256)
                    FormWaterJKCR(J - 1, K + 1, 256, 0, WC);
            }

            if (C == 256)
            {
                FormWaterJKCR(J + 1, K, 0, R, WC);
                if (R == 0)
                    FormWaterJKCR(J + 1, K - 1, 0, 256, WC);
                if (R == 256)
                    FormWaterJKCR(J + 1, K + 1, 0, 0, WC);
            }

            if (R == 0)
                FormWaterJKCR(J, K - 1, C, 256, WC);
            if (R == 256)
                FormWaterJKCR(J, K + 1, C, 0, WC);
        }

        private static void FormLandJKCR(int J, int K, int C, int R, byte LC)
        {
            int N, P;
            N = LL_XY[J, K].NoOfLWs;
            P = LL_XY[J, K].Pointer;
            if (N == 0)
            {
                if (P == 0)
                {
                    LL_XY[J, K].Pointer = NoOfLLXYs;
                    byte[,,] oldLLands = LLands;
                    LLands = new byte[257, 257, NoOfLLXYs + 1];
                    if (oldLLands is object)
                        for (int i = 0; i <= oldLLands.Length / oldLLands.GetLength(2) - 1; ++i)
                            Array.Copy(oldLLands, i * oldLLands.GetLength(2), LLands, i * LLands.GetLength(2), Math.Min(oldLLands.GetLength(2), LLands.GetLength(2)));
                    LLands[C, R, NoOfLLXYs] = LC;
                    LL_XY[J, K].NoOfLWs = 1;
                    NoOfLands = NoOfLands + 1;
                    NoOfLLXYs = NoOfLLXYs + 1;
                }
                else
                {
                    LLands[C, R, P] = LC;
                    LL_XY[J, K].NoOfLWs = 1;
                    NoOfLands = NoOfLands + 1;
                }
            }
            else
            {
                if (LLands[C, R, P] == 0) // means this is an add! not a edit!
                {
                    NoOfLands = NoOfLands + 1;
                    LL_XY[J, K].NoOfLWs = N + 1;
                }

                LLands[C, R, P] = LC;
            }
        }

        private static void FormWaterJKCR(int J, int K, int C, int R, byte WC)
        {
            int N, P;
            N = WW_XY[J, K].NoOfLWs;
            P = WW_XY[J, K].Pointer;
            if (N == 0)
            {
                if (P == 0)
                {
                    WW_XY[J, K].Pointer = NoOfWWXYs;
                    byte[,,] oldWWaters = WWaters;
                    WWaters = new byte[257, 257, NoOfWWXYs + 1];
                    if (oldWWaters is object)
                        for (int i = 0; i <= oldWWaters.Length / oldWWaters.GetLength(2) - 1; ++i)
                            Array.Copy(oldWWaters, i * oldWWaters.GetLength(2), WWaters, i * WWaters.GetLength(2), Math.Min(oldWWaters.GetLength(2), WWaters.GetLength(2)));
                    WWaters[C, R, NoOfWWXYs] = WC;
                    WW_XY[J, K].NoOfLWs = 1;
                    NoOfWaters = NoOfWaters + 1;
                    NoOfWWXYs = NoOfWWXYs + 1;
                }
                else
                {
                    WWaters[C, R, P] = WC;
                    WW_XY[J, K].NoOfLWs = 1;
                    NoOfWaters = NoOfWaters + 1;
                }
            }
            else
            {
                if (WWaters[C, R, P] == 0)
                {
                    NoOfWaters = NoOfWaters + 1;
                    WW_XY[J, K].NoOfLWs = N + 1;
                }

                WWaters[C, R, P] = WC;
            }
        }

        internal static bool AppendRawLand(string fname, int J, int K)
        {
            bool AppendRawLandRet = default;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            AppendRawLandRet = false;
            string A = Path.GetFileNameWithoutExtension(fname);
            byte[] LL;
            try
            {
                LL = File.ReadAllBytes(fname);
                if (LL.Length < 257 * 257)
                    return default;
            }
            catch (Exception)
            {
                return default;
            }

            int C, R;
            int p = 0;
            for (C = 0; C <= 256; C++)
            {
                for (R = 0; R <= 256; R++)
                {
                    if (LL[p] != 254)
                    {
                        FormOneLand(J, K, C, R, ILC[LL[p]]);
                    }
                    p++;
                }
            }

            moduleMAIN.LonDispCenter = (J + 0.5d) * moduleMAIN.D5Lon - 180d;
            moduleMAIN.LatDispCenter = 90d - (K + 0.5d) * moduleMAIN.D5Lat;
            moduleMAIN.Zoom = 7;
            AppendRawLandRet = true;
            return AppendRawLandRet;
        }

        internal static bool AppendRawWater(string fname, int J, int K)
        {
            bool AppendRawWaterRet = default;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            AppendRawWaterRet = false;
            string A = Path.GetFileNameWithoutExtension(fname);
            byte[] WW;
            try
            {
                WW = File.ReadAllBytes(fname);
                if (WW.Length < 257 * 257)
                    return default;
            }
            catch (Exception)
            {
                return default;
            }

            int C, R;
            int p = 0;
            for (C = 0; C <= 256; C++)
            {
                for (R = 0; R <= 256; R++)
                {
                    if (WW[p] != 254)
                    {
                        FormOneWater(J, K, C, R, IWC[WW[p]]);
                    }
                    p++;
                }
            }

            moduleMAIN.LonDispCenter = (J + 0.5d) * moduleMAIN.D5Lon - 180d;
            moduleMAIN.LatDispCenter = 90d - (K + 0.5d) * moduleMAIN.D5Lat;
            moduleMAIN.Zoom = 7;
            AppendRawWaterRet = true;
            return AppendRawWaterRet;
        }

        internal static void SelectAllLands(ref bool Flag)
        {
            int C, R, P, N, K, LA, LO;
            byte BT0;
            byte BY127 = 127;    // October 2017
            byte BY128 = 128;
            My.MyProject.Forms.FrmStart.SelectAllLandsMenuItem.Checked = Flag;
            if (!LandVIEW)
                return;
            if (Flag == false & LandsSelected == false)
                return;
            moduleMAIN.WAIT = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            if (Flag)
            {
                NoOfLands = 0;
                for (LO = 0; LO <= 95; LO++)
                {
                    for (LA = 0; LA <= 63; LA++)
                    {
                        if (LL_XY[LO, LA].NoOfLWs > 0)
                        {
                            P = LL_XY[LO, LA].Pointer;
                            N = LL_XY[LO, LA].NoOfLWs;
                            K = 0;
                            for (C = 0; C <= 256; C++)
                            {
                                for (R = 0; R <= 256; R++)
                                {
                                    BT0 = LLands[C, R, P];
                                    if (BT0 > 0)
                                    {
                                        NoOfLands = NoOfLands + 1;
                                        if (BT0 < 128)
                                            NoOfLandsSelected = NoOfLandsSelected + 1;
                                        LLands[C, R, P] = (byte)(BY128 | BT0);
                                        K = K + 1;
                                        if (K == N)
                                            goto next_LL_XY1;
                                    }
                                }
                            }
                        }

                    next_LL_XY1:
                        ;
                    }
                }

                moduleMAIN.SomeSelected = true;
                LandsSelected = true;
            }
            else
            {
                for (LO = 0; LO <= 95; LO++)
                {
                    for (LA = 0; LA <= 63; LA++)
                    {
                        if (LL_XY[LO, LA].NoOfLWs > 0)
                        {
                            P = LL_XY[LO, LA].Pointer;
                            N = LL_XY[LO, LA].NoOfLWs;
                            K = 0;
                            for (C = 0; C <= 256; C++)
                            {
                                for (R = 0; R <= 256; R++)
                                {
                                    BT0 = LLands[C, R, P];
                                    if (BT0 > 0)
                                    {
                                        if (BT0 > 127)
                                            NoOfLandsSelected = NoOfLandsSelected - 1;
                                        LLands[C, R, P] = (byte)(BY127 & BT0);
                                        K = K + 1;
                                        if (K == N)
                                            goto next_LL_XY2;
                                    }
                                }
                            }
                        }

                    next_LL_XY2:
                        ;
                    }
                }

                LandsSelected = false;
            }

            My.MyProject.Forms.FrmStart.SetMouseIcon();
            moduleMAIN.WAIT = false;
        }

        internal static void SelectAllWaters(ref bool Flag)
        {
            int C, R, P, N, K, LA, LO;
            byte BT0;
            byte BY127 = 127;    // October 2017
            byte BY128 = 128;
            My.MyProject.Forms.FrmStart.SelectAllWatersMenuItem.Checked = Flag;
            if (!WaterVIEW)
                return;
            if (Flag == false & WatersSelected == false)
                return;
            moduleMAIN.WAIT = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            if (Flag)
            {
                NoOfWaters = 0;
                for (LO = 0; LO <= 95; LO++)
                {
                    for (LA = 0; LA <= 63; LA++)
                    {
                        if (WW_XY[LO, LA].NoOfLWs > 0)
                        {
                            P = WW_XY[LO, LA].Pointer;
                            N = WW_XY[LO, LA].NoOfLWs;
                            K = 0;
                            for (C = 0; C <= 256; C++)
                            {
                                for (R = 0; R <= 256; R++)
                                {
                                    BT0 = WWaters[C, R, P];
                                    if (BT0 > 0)
                                    {
                                        NoOfWaters = NoOfWaters + 1;
                                        if (BT0 < 128)
                                            NoOfWatersSelected = NoOfWatersSelected + 1;
                                        WWaters[C, R, P] = (byte)(BY128 | BT0);
                                        K = K + 1;
                                        if (K == N)
                                            goto next_WW_XY1;
                                    }
                                }
                            }
                        }

                    next_WW_XY1:
                        ;
                    }
                }

                moduleMAIN.SomeSelected = true;
                WatersSelected = true;
            }
            else
            {
                for (LO = 0; LO <= 95; LO++)
                {
                    for (LA = 0; LA <= 63; LA++)
                    {
                        if (WW_XY[LO, LA].NoOfLWs > 0)
                        {
                            P = WW_XY[LO, LA].Pointer;
                            N = WW_XY[LO, LA].NoOfLWs;
                            K = 0;
                            for (C = 0; C <= 256; C++)
                            {
                                for (R = 0; R <= 256; R++)
                                {
                                    BT0 = WWaters[C, R, P];
                                    if (BT0 > 0)
                                    {
                                        if (BT0 > 127)
                                            NoOfWatersSelected = NoOfWatersSelected - 1;
                                        WWaters[C, R, P] = (byte)(BY127 & BT0);
                                        K = K + 1;
                                        if (K == N)
                                            goto next_WW_XY2;
                                    }
                                }
                            }
                        }

                    next_WW_XY2:
                        ;
                    }
                }

                WatersSelected = false;
            }

            My.MyProject.Forms.FrmStart.SetMouseIcon();
            moduleMAIN.WAIT = false;
        }

        internal static void DisplayLands(Graphics gr)
        {
            if (NoOfLands == 0 | moduleMAIN.Zoom < 6)
                return;
            string A;
            float X11, X1, X2, Y1, Y2;
            byte MyL;
            int LA1, LA, LA2;
            int LO1, LO, LO2;
            string jpg = ".jpg";
            string bmp = ".bmp";
            Image myImage;
            SolidBrush myBrush = new SolidBrush(Color.Yellow);
            double LatNorth;
            double LonWest;
            X1 = (float)(moduleMAIN.LonDispWest + 180d);
            X1 = (float)(X1 / moduleMAIN.D5Lon);
            LO1 = (int)X1;
            Y1 = (float)(90d - moduleMAIN.LatDispNorth);
            Y1 = (float)(Y1 / moduleMAIN.D5Lat);
            LA1 = (int)Y1;
            X1 = (float)(moduleMAIN.LonDispEast + 180d);
            X1 = (float)(X1 / moduleMAIN.D5Lon);
            LO2 = (int)X1;
            Y1 = (float)(90d - moduleMAIN.LatDispSouth);
            Y1 = (float)(Y1 / moduleMAIN.D5Lat);
            LA2 = (int)Y1;
            int C, C0, R, R0, N;
            int loopTo = LA2;
            for (LA = LA1; LA <= loopTo; LA++)
            {
                LatNorth = 90d - LA * moduleMAIN.D5Lat;
                int loopTo1 = LO2;
                for (LO = LO1; LO <= loopTo1; LO++)
                {
                    LonWest = LO * moduleMAIN.D5Lon - 180d;
                    if (LL_XY[LO, LA].NoOfLWs > 0)
                    {
                        N = LL_XY[LO, LA].Pointer;
                        X11 = (float)((LonWest - moduleMAIN.LonDispWest - moduleMAIN.D14Lon) * moduleMAIN.PixelsPerLonDeg);
                        X2 = (float)(moduleMAIN.D13Lon * moduleMAIN.PixelsPerLonDeg);
                        Y1 = (float)((moduleMAIN.LatDispNorth - LatNorth - moduleMAIN.D14Lat) * moduleMAIN.PixelsPerLatDeg);
                        Y2 = (float)(moduleMAIN.D13Lat * moduleMAIN.PixelsPerLatDeg);
                        X2 = (float)(moduleMAIN.D13Lon * moduleMAIN.PixelsPerLonDeg);
                        R0 = (int)(-Y1 / Y2);
                        if (R0 > 256)
                            R0 = 256;
                        if (R0 < 0)
                            R0 = 0;
                        Y1 = Y1 + R0 * Y2;
                        C0 = (int)(-X11 / X2);
                        if (C0 > 256)
                            C0 = 256;
                        if (C0 < 0)
                            C0 = 0;
                        X11 = X11 + C0 * X2;
                        for (R = R0; R <= 256; R++)
                        {
                            X1 = X11;
                            for (C = C0; C <= 256; C++)
                            {
                                MyL = LLands[C, R, N];
                                if (MyL > 0)
                                {
                                    if (moduleMAIN.Zoom < 10)
                                    {
                                        myBrush.Color = LC[MyL].Color;
                                        gr.FillRectangle(myBrush, new Rectangle((int)X1, (int)Y1, (int)(X2 + 1f), (int)(Y2 + 1f)));
                                    }
                                    else if (moduleMAIN.Zoom < 15 & moduleMAIN.Zoom > 9)
                                    {
                                        A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + LC[MyL].Texture + bmp;
                                        myImage = Image.FromFile(A);
                                        gr.DrawImage(myImage, X1, Y1, X2 + 1f, Y2 + 1f);
                                    }
                                    else if (moduleMAIN.Zoom > 14)
                                    {
                                        A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + LC[MyL].Texture + jpg;
                                        myImage = Image.FromFile(A);
                                        gr.DrawImage(myImage, X1, Y1, X2 + 1f, Y2 + 1f);
                                    }
                                }

                                X1 = X1 + X2;
                                if (X1 > moduleMAIN.DisplayWidth)
                                    break;
                            }

                            Y1 = Y1 + Y2;
                            if (Y1 > moduleMAIN.DisplayHeight)
                                break;
                        }
                    }
                }
            }

            myBrush.Dispose();
        }

        internal static void DisplayWaters(Graphics gr)
        {
            if (NoOfWaters == 0 | moduleMAIN.Zoom < 6)
                return;
            string A;
            float X11, X1, X2, Y1, Y2;
            byte MyL;
            int LA1, LA, LA2;
            int LO1, LO, LO2;
            string jpg = ".jpg";
            string bmp = ".bmp";
            Image myImage;
            SolidBrush myBrush = new SolidBrush(Color.Yellow);
            double LatNorth;
            double LonWest;
            X1 = (float)(moduleMAIN.LonDispWest + 180d);
            X1 = (float)(X1 / moduleMAIN.D5Lon);
            LO1 = (int)X1;
            Y1 = (float)(90d - moduleMAIN.LatDispNorth);
            Y1 = (float)(Y1 / moduleMAIN.D5Lat);
            LA1 = (int)Y1;
            X1 = (float)(moduleMAIN.LonDispEast + 180d);
            X1 = (float)(X1 / moduleMAIN.D5Lon);
            LO2 = (int)X1;
            Y1 = (float)(90d - moduleMAIN.LatDispSouth);
            Y1 = (float)(Y1 / moduleMAIN.D5Lat);
            LA2 = (int)Y1;
            int C, C0, R, R0, N;
            int loopTo = LA2;
            for (LA = LA1; LA <= loopTo; LA++)
            {
                LatNorth = 90d - LA * moduleMAIN.D5Lat;
                int loopTo1 = LO2;
                for (LO = LO1; LO <= loopTo1; LO++)
                {
                    LonWest = LO * moduleMAIN.D5Lon - 180d;
                    if (WW_XY[LO, LA].NoOfLWs > 0)
                    {
                        N = WW_XY[LO, LA].Pointer;
                        X11 = (float)((LonWest - moduleMAIN.LonDispWest - moduleMAIN.D14Lon) * moduleMAIN.PixelsPerLonDeg);
                        X2 = (float)(moduleMAIN.D13Lon * moduleMAIN.PixelsPerLonDeg);
                        Y1 = (float)((moduleMAIN.LatDispNorth - LatNorth - moduleMAIN.D14Lat) * moduleMAIN.PixelsPerLatDeg);
                        Y2 = (float)(moduleMAIN.D13Lat * moduleMAIN.PixelsPerLatDeg);
                        X2 = (float)(moduleMAIN.D13Lon * moduleMAIN.PixelsPerLonDeg);
                        R0 = (int)(-Y1 / Y2);
                        if (R0 > 256)
                            R0 = 256;
                        if (R0 < 0)
                            R0 = 0;
                        Y1 = Y1 + R0 * Y2;
                        C0 = (int)(-X11 / X2);
                        if (C0 > 256)
                            C0 = 256;
                        if (C0 < 0)
                            C0 = 0;
                        X11 = X11 + C0 * X2;
                        for (R = R0; R <= 256; R++)
                        {
                            X1 = X11;
                            for (C = C0; C <= 256; C++)
                            {
                                MyL = WWaters[C, R, N];
                                if (MyL > 0)
                                {
                                    if (moduleMAIN.Zoom < 10)
                                    {
                                        myBrush.Color = WC[MyL].Color;
                                        gr.FillRectangle(myBrush, new Rectangle((int)X1, (int)Y1, (int)(X2 + 1f), (int)(Y2 + 1f)));
                                    }
                                    else if (moduleMAIN.Zoom < 15 & moduleMAIN.Zoom > 9)
                                    {
                                        A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + WC[MyL].Texture + bmp;
                                        myImage = Image.FromFile(A);
                                        gr.DrawImage(myImage, X1, Y1, X2 + 1f, Y2 + 1f);
                                    }
                                    else if (moduleMAIN.Zoom > 14)
                                    {
                                        A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + WC[MyL].Texture + jpg;
                                        myImage = Image.FromFile(A);
                                        gr.DrawImage(myImage, X1, Y1, X2 + 1f, Y2 + 1f);
                                    }
                                }

                                X1 = X1 + X2;
                                if (X1 > moduleMAIN.DisplayWidth)
                                    break;
                            }

                            Y1 = Y1 + Y2;
                            if (Y1 > moduleMAIN.DisplayHeight)
                                break;
                        }
                    }
                }
            }

            myBrush.Dispose();
        }

        internal static void DeleteSelectedLands()
        {
            int C, R, P, LA, LO;
            byte BT0;
            moduleMAIN.WAIT = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;

            // If BackUpON Then BackUp()

            for (LO = 0; LO <= 95; LO++)
            {
                for (LA = 0; LA <= 63; LA++)
                {
                    if (LL_XY[LO, LA].NoOfLWs > 0)
                    {
                        P = LL_XY[LO, LA].Pointer;
                        for (C = 0; C <= 256; C++)
                        {
                            for (R = 0; R <= 256; R++)
                            {
                                BT0 = LLands[C, R, P];
                                if (BT0 > 0)
                                {
                                    if (BT0 > 127)
                                    {
                                        LLands[C, R, P] = 0;
                                        NoOfLands = NoOfLands - 1;
                                        LL_XY[LO, LA].NoOfLWs = LL_XY[LO, LA].NoOfLWs - 1;
                                    }

                                    if (LL_XY[LO, LA].NoOfLWs == 0)
                                        goto next_LL_XY1;
                                }
                            }
                        }
                    }

                next_LL_XY1:
                    ;
                }
            }

            NoOfLandsSelected = 0;
            LandsSelected = false;
            moduleMAIN.Dirty = true;
            My.MyProject.Forms.FrmStart.SetMouseIcon();
            moduleMAIN.WAIT = false;
        }

        internal static void DeleteSelectedWaters()
        {
            int C, R, P, LA, LO;
            byte BT0;
            moduleMAIN.WAIT = true;
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            for (LO = 0; LO <= 95; LO++)
            {
                for (LA = 0; LA <= 63; LA++)
                {
                    if (WW_XY[LO, LA].NoOfLWs > 0)
                    {
                        P = WW_XY[LO, LA].Pointer;
                        for (C = 0; C <= 256; C++)
                        {
                            for (R = 0; R <= 256; R++)
                            {
                                BT0 = WWaters[C, R, P];
                                if (BT0 > 0)
                                {
                                    if (BT0 > 127)
                                    {
                                        WWaters[C, R, P] = 0;
                                        NoOfWaters = NoOfWaters - 1;
                                        WW_XY[LO, LA].NoOfLWs = WW_XY[LO, LA].NoOfLWs - 1;
                                    }

                                    if (WW_XY[LO, LA].NoOfLWs == 0)
                                        goto next_WW_XY1;
                                }
                            }
                        }
                    }

                next_WW_XY1:
                    ;
                }
            }

            NoOfWatersSelected = 0;
            WatersSelected = false;
            moduleMAIN.Dirty = true;
            My.MyProject.Forms.FrmStart.SetMouseIcon();
            moduleMAIN.WAIT = false;
        }

        internal static void DeleteLand(int X1, int Y1)
        {
            double X, Y;
            if (NoOfLands == 0)
                return;
            X = moduleMAIN.LonDispWest + X1 / moduleMAIN.PixelsPerLonDeg;
            Y = moduleMAIN.LatDispNorth - Y1 / moduleMAIN.PixelsPerLatDeg;
            int J, K, C, R;
            X = X + 180d;
            X = X / moduleMAIN.D5Lon;
            J = (int)X;
            Y = 90d - Y;
            Y = Y / moduleMAIN.D5Lat;
            K = (int)Y;
            if (LL_XY[J, K].NoOfLWs == 0)
                return;
            C = (int)Math.Round((X - J) * moduleMAIN.D5Lon / moduleMAIN.D13Lon);
            R = (int)Math.Round((Y - K) * moduleMAIN.D5Lat / moduleMAIN.D13Lat);
            if (LLands[C, R, LL_XY[J, K].Pointer] == 0)
                return;
            moduleEDIT.BackUp();
            DeleteOneLand(J, K, C, R);
        }

        internal static void DeleteWater(int X1, int Y1)
        {
            double X, Y;
            if (NoOfWaters == 0)
                return;
            X = moduleMAIN.LonDispWest + X1 / moduleMAIN.PixelsPerLonDeg;
            Y = moduleMAIN.LatDispNorth - Y1 / moduleMAIN.PixelsPerLatDeg;
            int J, K, C, R;
            X = X + 180d;
            X = X / moduleMAIN.D5Lon;
            J = (int)X;
            Y = 90d - Y;
            Y = Y / moduleMAIN.D5Lat;
            K = (int)Y;
            if (WW_XY[J, K].NoOfLWs == 0)
                return;
            C = (int)Math.Round((X - J) * moduleMAIN.D5Lon / moduleMAIN.D13Lon);
            R = (int)Math.Round((Y - K) * moduleMAIN.D5Lat / moduleMAIN.D13Lat);
            if (WWaters[C, R, WW_XY[J, K].Pointer] == 0)
                return;
            moduleEDIT.BackUp();
            DeleteOneWater(J, K, C, R);
        }

        private static void DeleteOneLand(int J, int K, int C, int R)
        {
            DeleteLandJKCR(J, K, C, R);
            if (C == 0)
            {
                DeleteLandJKCR(J - 1, K, 256, R);
                if (R == 0)
                    DeleteLandJKCR(J - 1, K - 1, 256, 256);
                if (R == 256)
                    DeleteLandJKCR(J - 1, K + 1, 256, 0);
            }

            if (C == 256)
            {
                DeleteLandJKCR(J + 1, K, 0, R);
                if (R == 0)
                    DeleteLandJKCR(J + 1, K - 1, 0, 256);
                if (R == 256)
                    DeleteLandJKCR(J + 1, K + 1, 0, 0);
            }

            if (R == 0)
                DeleteLandJKCR(J, K - 1, C, 256);
            if (R == 256)
                DeleteLandJKCR(J, K + 1, C, 0);
            moduleMAIN.Dirty = true;
        }

        private static void DeleteOneWater(int J, int K, int C, int R)
        {
            DeleteWaterJKCR(J, K, C, R);
            if (C == 0)
            {
                DeleteWaterJKCR(J - 1, K, 256, R);
                if (R == 0)
                    DeleteWaterJKCR(J - 1, K - 1, 256, 256);
                if (R == 256)
                    DeleteWaterJKCR(J - 1, K + 1, 256, 0);
            }

            if (C == 256)
            {
                DeleteWaterJKCR(J + 1, K, 0, R);
                if (R == 0)
                    DeleteWaterJKCR(J + 1, K - 1, 0, 256);
                if (R == 256)
                    DeleteWaterJKCR(J + 1, K + 1, 0, 0);
            }

            if (R == 0)
                DeleteWaterJKCR(J, K - 1, C, 256);
            if (R == 256)
                DeleteWaterJKCR(J, K + 1, C, 0);
        }

        private static void DeleteLandJKCR(int J, int K, int C, int R)
        {
            LLands[C, R, LL_XY[J, K].Pointer] = 0;
            LL_XY[J, K].NoOfLWs = LL_XY[J, K].NoOfLWs - 1;
            NoOfLands = NoOfLands - 1;
            if (NoOfLands == 0)
            {
                LLands = new byte[257, 257, 1];
            }
        }

        private static void DeleteWaterJKCR(int J, int K, int C, int R)
        {
            WWaters[C, R, WW_XY[J, K].Pointer] = 0;
            WW_XY[J, K].NoOfLWs = WW_XY[J, K].NoOfLWs - 1;
            NoOfWaters = NoOfWaters - 1;
            if (NoOfWaters == 0)
            {
                WWaters = new byte[257, 257, 1];
            }
        }

        internal static void DeleteLandPopUp(int N)
        {
            int J, K, C, R;
            R = N % 512;
            N = N >> 9;
            C = N % 512;
            N = N >> 9;
            K = N % 64;
            N = N >> 6;
            J = N % 128;
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            DeleteOneLand(J, K, C, R);
        }

        internal static void DeleteWaterPopUp(int N)
        {
            int J, K, C, R;
            R = N % 512;
            N = N >> 9;
            C = N % 512;
            N = N >> 9;
            K = N % 64;
            N = N >> 6;
            J = N % 128;
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            DeleteOneWater(J, K, C, R);
        }

        internal static void SelectLandsInBox(double X0, double Y0, double X1, double Y1)
        {
            if (!LandVIEW | NoOfLands == 0)
                return;
            byte BT0;
            byte BT128 = 128;
            int J, J0, J1, K, K0, K1, P;
            int C, C0, C1, C00, C11, R, R0, R1, R00, R11;
            JKCR PT;
            PT = moduleMAIN.JKCRFromLL(X0, Y0, true);
            J0 = PT.J;
            K0 = PT.K;
            C0 = PT.C;
            R0 = PT.R;
            PT = moduleMAIN.JKCRFromLL(X1, Y1, false);
            J1 = PT.J;
            K1 = PT.K;
            C1 = PT.C;
            R1 = PT.R;
            int loopTo = J1;
            for (J = J0; J <= loopTo; J++)
            {
                C00 = 0;
                if (J == J0)
                    C00 = C0;
                C11 = 256;
                if (J == J1)
                    C11 = C1;
                int loopTo1 = K1;
                for (K = K0; K <= loopTo1; K++)
                {
                    if (LL_XY[J, K].NoOfLWs > 0)
                    {
                        R00 = 0;
                        if (K == K0)
                            R00 = R0;
                        R11 = 256;
                        if (K == K1)
                            R11 = R1;
                        P = LL_XY[J, K].Pointer;
                        int loopTo2 = R11;
                        for (R = R00; R <= loopTo2; R++)
                        {
                            int loopTo3 = C11;
                            for (C = C00; C <= loopTo3; C++)
                            {
                                BT0 = LLands[C, R, P];
                                if (BT0 > 0)
                                {
                                    if (BT0 < 128)
                                    {
                                        NoOfLandsSelected = NoOfLandsSelected + 1;
                                        moduleMAIN.SomeSelected = true;
                                        LandsSelected = true;
                                    }

                                    LLands[C, R, P] = (byte)(BT0 | BT128);
                                }
                            }
                        }
                    }
                }
            }
        }

        internal static void SelectWatersInBox(double X0, double Y0, double X1, double Y1)
        {
            if (!WaterVIEW | NoOfWaters == 0)
                return;
            byte BT0;
            byte BT128 = 128;
            int J, J0, J1, K, K0, K1, P;
            int C, C0, C1, C00, C11, R, R0, R1, R00, R11;
            JKCR PT;
            PT = moduleMAIN.JKCRFromLL(X0, Y0, true);
            J0 = PT.J;
            K0 = PT.K;
            C0 = PT.C;
            R0 = PT.R;
            PT = moduleMAIN.JKCRFromLL(X1, Y1, false);
            J1 = PT.J;
            K1 = PT.K;
            C1 = PT.C;
            R1 = PT.R;
            int loopTo = J1;
            for (J = J0; J <= loopTo; J++)
            {
                C00 = 0;
                if (J == J0)
                    C00 = C0;
                C11 = 256;
                if (J == J1)
                    C11 = C1;
                int loopTo1 = K1;
                for (K = K0; K <= loopTo1; K++)
                {
                    if (WW_XY[J, K].NoOfLWs > 0)
                    {
                        R00 = 0;
                        if (K == K0)
                            R00 = R0;
                        R11 = 256;
                        if (K == K1)
                            R11 = R1;
                        P = WW_XY[J, K].Pointer;
                        int loopTo2 = R11;
                        for (R = R00; R <= loopTo2; R++)
                        {
                            int loopTo3 = C11;
                            for (C = C00; C <= loopTo3; C++)
                            {
                                BT0 = WWaters[C, R, P];
                                if (BT0 > 0)
                                {
                                    if (BT0 < 128)
                                    {
                                        NoOfWatersSelected = NoOfWatersSelected + 1;
                                        moduleMAIN.SomeSelected = true;
                                        WatersSelected = true;
                                    }

                                    WWaters[C, R, P] = (byte)(BT0 | BT128);
                                }
                            }
                        }
                    }
                }
            }
        }

        internal static void MakeBglLand(ref bool CopyBGLs)
        {
            int J, K, C, R, P;
            bool[,] Flag = new bool[96, 64];
            int NoOfQuads = 0;
            int Counter = 0;
            for (J = 0; J <= 95; J++)
            {
                for (K = 0; K <= 63; K++)
                {
                    if (LL_XY[J, K].NoOfLWs == 0)
                    {
                        Flag[J, K] = false;
                    }
                    else
                    {
                        P = LL_XY[J, K].Pointer;
                        NoOfQuads = NoOfQuads + 1;
                        for (R = 0; R <= 256; R++)
                        {
                            for (C = 0; C <= 256; C++)
                            {
                                if (LLands[C, R, P] > 127)
                                {
                                    Flag[J, K] = true;
                                }
                            }
                        }
                    }
                }
            }

            string InfFile, RawFile, BGLFile, BGLFileTarget;
            string[] BGL = new string[NoOfQuads + 1];
            string[] Command = new string[NoOfQuads + 1];
            byte[] Quad = new byte[257 * 257];

            // create RAW files
            for (J = 0; J <= 95; J++)
            {
                for (K = 0; K <= 63; K++)
                {
                    if (Flag[J, K])
                    {
                        Counter = Counter + 1;
                        P = LL_XY[J, K].Pointer;
                        for (C = 0; C <= 256; C++)
                        {
                            for (R = 0; R <= 256; R++)
                            {
                                if (LLands[C, R, P] == 0)
                                {
                                    Quad[C * 257 + R] = 254;
                                }
                                else
                                {
                                    Quad[C * 257 + R] = LC[LLands[C, R, P]].Index;
                                }
                            }
                        }

                        RawFile = "LC_" + J.ToString("00");
                        RawFile = RawFile + K.ToString("00");
                        BGL[Counter] = RawFile + ".bgl";
                        RawFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + RawFile + ".raw";
                        File.WriteAllBytes(RawFile, Quad);
                    }
                }
            }

            // delete BGL files
            int loopTo = NoOfQuads;
            for (J = 1; J <= loopTo; J++)
            {
                BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BGL[J];
                if (File.Exists(BGLFile))
                    File.Delete(BGLFile);
            }

            Counter = 0;
            for (J = 0; J <= 95; J++)
            {
                for (K = 0; K <= 63; K++)
                {
                    if (Flag[J, K])
                    {
                        Counter = Counter + 1;
                        InfFile = "LC_" + J.ToString("00");
                        InfFile = InfFile + K.ToString("00");
                        Command[Counter] = "resample " + @" work\" + InfFile + ".inf";
                        using (StreamWriter file = new StreamWriter(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + InfFile + ".inf"))
                        {
                            file.WriteLine("[Source]");
                            file.WriteLine("   Type = Raw");
                            file.WriteLine("   SourceDir = " + '"' + "." + '"');
                            file.WriteLine("   SourceFile = " + '"' + InfFile + ".raw" + '"');
                            file.WriteLine("   Layer = LandClass");
                            file.WriteLine("   SamplingMethod = Point");
                            file.WriteLine("   SampleType = UINT8");
                            file.WriteLine("   NullValue = 254");
                            file.WriteLine("   ulyMap = " + (90.0d - K * moduleMAIN.D5Lat));
                            file.WriteLine("   ulxMap = " + (J * moduleMAIN.D5Lon - 180.0d));
                            file.WriteLine("   nCols = " + 257);
                            file.WriteLine("   nRows = " + 257);
                            file.WriteLine("   xDim = " + moduleMAIN.D13Lon);
                            file.WriteLine("   yDim = " + moduleMAIN.D13Lat);
                            file.WriteLine();
                            file.WriteLine("[Destination]");
                            file.WriteLine("   DestDir = " + '"' + "." + '"');
                            file.WriteLine("   DestBaseFileName = " + '"' + InfFile + '"');
                            file.WriteLine("   DestFileType = BGL");
                            file.WriteLine("   UseSourceDimensions = 1");
                        }
                    }
                }
            }

            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            int loopTo1 = NoOfQuads;
            for (J = 1; J <= loopTo1; J++)
                moduleMAIN.ExecCmd(Command[J]);
            if (!CopyBGLs)
                return;

            try
            {
                // copy BGL files
                int loopTo2 = NoOfQuads;
                for (J = 1; J <= loopTo2; J++)
                {
                    BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BGL[J];
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + BGL[J];
                    if (File.Exists(BGLFile))
                    {
                        File.Copy(BGLFile, BGLFileTarget, true);
                        // MsgBox(BGLFile & vbCrLf & BGLFileTarget)
                    }
                }

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        internal static void MakeBglWater(ref bool CopyBGLs)
        {
            int J, K, C, R, P;
            bool[,] Flag = new bool[96, 64];
            int NoOfQuads = 0;
            int Counter = 0;
            for (J = 0; J <= 95; J++)
            {
                for (K = 0; K <= 63; K++)
                {
                    if (WW_XY[J, K].NoOfLWs == 0)
                    {
                        Flag[J, K] = false;
                    }
                    else
                    {
                        P = WW_XY[J, K].Pointer;
                        NoOfQuads = NoOfQuads + 1;
                        for (R = 0; R <= 256; R++)
                        {
                            for (C = 0; C <= 256; C++)
                            {
                                if (WWaters[C, R, P] > 127)
                                {
                                    Flag[J, K] = true;
                                }
                            }
                        }
                    }
                }
            }

            string InfFile, RawFile, BGLFile, BGLFileTarget;
            string[] BGL = new string[NoOfQuads + 1];
            string[] Command = new string[NoOfQuads + 1];
            byte[] Quad = new byte[257 * 257];

            // create RAW files
            for (J = 0; J <= 95; J++)
            {
                for (K = 0; K <= 63; K++)
                {
                    if (Flag[J, K])
                    {
                        Counter = Counter + 1;
                        P = WW_XY[J, K].Pointer;
                        for (C = 0; C <= 256; C++)
                        {
                            for (R = 0; R <= 256; R++)
                            {
                                if (WWaters[C, R, P] == 0)
                                {
                                    Quad[C * 257 + R] = 254;
                                }
                                else
                                {
                                    Quad[C * 257 + R] = WC[WWaters[C, R, P]].Index;
                                }
                            }
                        }

                        RawFile = "WC_" + J.ToString("00");
                        RawFile = RawFile + K.ToString("00");
                        BGL[Counter] = RawFile + ".bgl";
                        RawFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + RawFile + ".raw";
                        File.WriteAllBytes(RawFile, Quad);
                    }
                }
            }

            // delete BGL files
            int loopTo = NoOfQuads;
            for (J = 1; J <= loopTo; J++)
            {
                BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BGL[J];
                if (File.Exists(BGLFile))
                    File.Delete(BGLFile);
            }

            Counter = 0;
            for (J = 0; J <= 95; J++)
            {
                for (K = 0; K <= 63; K++)
                {
                    if (Flag[J, K])
                    {
                        Counter = Counter + 1;
                        InfFile = "WC_" + J.ToString("00");
                        InfFile = InfFile + K.ToString("00");
                        Command[Counter] = "resample " + @" work\" + InfFile + ".inf";
                        using (StreamWriter file = new StreamWriter(My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + InfFile + ".inf"))
                        {
                            file.WriteLine("[Source]");
                            file.WriteLine("   Type = Raw");
                            file.WriteLine("   SourceDir = " + '"' + "." + '"');
                            file.WriteLine("   SourceFile = " + '"' + InfFile + ".raw" + '"');
                            file.WriteLine("   Layer = WaterClass");
                            file.WriteLine("   SamplingMethod = Point");
                            file.WriteLine("   SampleType = UINT8");
                            file.WriteLine("   NullValue = 254");
                            file.WriteLine("   ulyMap = " + (90.0d - K * moduleMAIN.D5Lat));
                            file.WriteLine("   ulxMap = " + (J * moduleMAIN.D5Lon - 180.0d));
                            file.WriteLine("   nCols = " + 257);
                            file.WriteLine("   nRows = " + 257);
                            file.WriteLine("   xDim = " + moduleMAIN.D13Lon);
                            file.WriteLine("   yDim = " + moduleMAIN.D13Lat);
                            file.WriteLine();
                            file.WriteLine("[Destination]");
                            file.WriteLine("   DestDir = " + '"' + "." + '"');
                            file.WriteLine("   DestBaseFileName = " + '"' + InfFile + '"');
                            file.WriteLine("   DestFileType = BGL");
                            file.WriteLine("   UseSourceDimensions = 1");
                        }
                    }
                }
            }

            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            int loopTo1 = NoOfQuads;
            for (J = 1; J <= loopTo1; J++)
                moduleMAIN.ExecCmd(Command[J]);
            if (!CopyBGLs)
                return;
            try
            {
                // copy BGL files
                int loopTo2 = NoOfQuads;
                for (J = 1; J <= loopTo2; J++)
                {
                    BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + BGL[J];
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + BGL[J];
                    if (File.Exists(BGLFile))
                    {
                        File.Copy(BGLFile, BGLFileTarget, true);
                        // MsgBox(BGLFile & vbCrLf & BGLFileTarget)
                    }
                }

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        internal static void FillLand(int Map)
        {
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();

            try
            {
                int J, J0, J1, K, K0, K1;
                int C, C0, C1, C00, C11, R, R0, R1, R00, R11;
                double X0 = moduleMAPS.Maps[Map].WLON;
                double Y0 = moduleMAPS.Maps[Map].NLAT;
                double X1 = moduleMAPS.Maps[Map].ELON;
                double Y1 = moduleMAPS.Maps[Map].SLAT;
                int Cols = moduleMAPS.Maps[Map].COLS;
                int Rows = moduleMAPS.Maps[Map].ROWS;
                Random rand = new Random(0);

                // Dim image As Bitmap = Bitmap.FromFile(Maps(Map).BMPSu)     ' was like this in October 2017
                Bitmap image = (Bitmap)Image.FromFile(moduleMAPS.Maps[Map].BMPSu);
                Color myColor;
                double Lon, Lat, Lat0, Lon0, DX, DY;
                int N;
                DX = (X1 - X0) / Cols;
                DY = (Y0 - Y1) / Rows;
                float msg;
                JKCR PT;
                moduleMAIN.Double_XY LL;
                int PX, PY;

                // March, 25, 2014 Lorenzo error
                // shrink the generation area so that
                // we do not look after pixels outside the bitmap
                // PT = JKCRFromLL(X0, Y0, True)
                PT = moduleMAIN.JKCRFromLL(X0 + moduleMAIN.D14Lon, Y0 - moduleMAIN.D14Lat, true);
                J0 = PT.J;
                K0 = PT.K;
                C0 = PT.C;
                R0 = PT.R;

                // PT = JKCRFromLL(X1, Y1, False)
                PT = moduleMAIN.JKCRFromLL(X1 - moduleMAIN.D14Lon, Y1 + moduleMAIN.D14Lat, false);
                J1 = PT.J;
                K1 = PT.K;
                C1 = PT.C;
                R1 = PT.R;
                int loopTo = J1;
                for (J = J0; J <= loopTo; J++)
                {
                    C00 = 0;
                    if (J == J0)
                        C00 = C0;
                    C11 = 256;
                    if (J == J1)
                        C11 = C1;
                    int loopTo1 = K1;
                    for (K = K0; K <= loopTo1; K++)
                    {
                        R00 = 0;
                        if (K == K0)
                            R00 = R0;
                        R11 = 256;
                        if (K == K1)
                            R11 = R1;
                        LL = moduleMAIN.LLFromJKCR(J, K, 0, 0);
                        Lat0 = LL.Y;
                        Lon0 = LL.X;
                        int loopTo2 = R11;
                        for (R = R00; R <= loopTo2; R++)
                        {
                            Lat = Lat0 - R * moduleMAIN.D13Lat;
                            PY = (int)Math.Round((Y0 - Lat) / DY);
                            int loopTo3 = C11;
                            for (C = C00; C <= loopTo3; C++)
                            {
                                Lon = Lon0 + C * moduleMAIN.D13Lon;
                                PX = (int)Math.Round((Lon - X0) / DX);
                                myColor = image.GetPixel(PX, PY);
                                int loopTo4 = NoOfLWCIs;
                                for (N = 1; N <= loopTo4; N++)
                                {
                                    if (LWCIs[N].IsLand)
                                    {
                                        if (LWCIs[N].Color == myColor)
                                        {
                                            msg = (float)rand.NextDouble() * 100f;
                                            if (msg < 58f)
                                            {
                                                FormOneLand(J, K, C, R, LWCIs[N].Class1);
                                                break;
                                            }

                                            if (msg < 86f)
                                            {
                                                FormOneLand(J, K, C, R, LWCIs[N].Class2);
                                                break;
                                            }

                                            FormOneLand(J, K, C, R, LWCIs[N].Class3);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                moduleMAIN.Dirty = true;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("There has been a problem! Check the generated indexes!");
            }
        }

        internal static void FillWater(int Map)
        {
            try
            {
                if (moduleEDIT.BackUpON)
                    moduleEDIT.BackUp();
                int J, J0, J1, K, K0, K1;
                int C, C0, C1, C00, C11, R, R0, R1, R00, R11;
                double X0 = moduleMAPS.Maps[Map].WLON;
                double Y0 = moduleMAPS.Maps[Map].NLAT;
                double X1 = moduleMAPS.Maps[Map].ELON;
                double Y1 = moduleMAPS.Maps[Map].SLAT;
                int Cols = moduleMAPS.Maps[Map].COLS;
                int Rows = moduleMAPS.Maps[Map].ROWS;
                Random rand = new Random(0);

                // Dim image As Bitmap = Bitmap.FromFile(Maps(Map).BMPSu)    ' was like this in October 2017
                Bitmap image = (Bitmap)Image.FromFile(moduleMAPS.Maps[Map].BMPSu);
                Color myColor;
                double Lon, Lat, Lat0, Lon0, DX, DY;
                int N;
                DX = (X1 - X0) / Cols;
                DY = (Y0 - Y1) / Rows;
                float msg;
                JKCR PT;
                moduleMAIN.Double_XY LL;
                int PX, PY;

                // PT = JKCRFromLL(X0, Y0, True)
                PT = moduleMAIN.JKCRFromLL(X0 + moduleMAIN.D14Lon, Y0 - moduleMAIN.D14Lat, true);
                J0 = PT.J;
                K0 = PT.K;
                C0 = PT.C;
                R0 = PT.R;

                // PT = JKCRFromLL(X1, Y1, False)
                PT = moduleMAIN.JKCRFromLL(X1 - moduleMAIN.D14Lon, Y1 + moduleMAIN.D14Lat, false);
                J1 = PT.J;
                K1 = PT.K;
                C1 = PT.C;
                R1 = PT.R;
                int loopTo = J1;
                for (J = J0; J <= loopTo; J++)
                {
                    C00 = 0;
                    if (J == J0)
                        C00 = C0;
                    C11 = 256;
                    if (J == J1)
                        C11 = C1;
                    int loopTo1 = K1;
                    for (K = K0; K <= loopTo1; K++)
                    {
                        R00 = 0;
                        if (K == K0)
                            R00 = R0;
                        R11 = 256;
                        if (K == K1)
                            R11 = R1;
                        LL = moduleMAIN.LLFromJKCR(J, K, 0, 0);
                        Lat0 = LL.Y;
                        Lon0 = LL.X;
                        int loopTo2 = R11;
                        for (R = R00; R <= loopTo2; R++)
                        {
                            Lat = Lat0 - R * moduleMAIN.D13Lat;
                            PY = (int)Math.Round((Y0 - Lat) / DY);
                            int loopTo3 = C11;
                            for (C = C00; C <= loopTo3; C++)
                            {
                                Lon = Lon0 + C * moduleMAIN.D13Lon;
                                PX = (int)Math.Round((Lon - X0) / DX);
                                myColor = image.GetPixel(PX, PY);
                                int loopTo4 = NoOfLWCIs;
                                for (N = 1; N <= loopTo4; N++)
                                {
                                    if (!LWCIs[N].IsLand)
                                    {
                                        if (LWCIs[N].Color == myColor)
                                        {
                                            msg = (float)rand.NextDouble() * 100f;
                                            if (msg < 58f)
                                            {
                                                FormOneWater(J, K, C, R, LWCIs[N].Class1);
                                                break;
                                            }

                                            if (msg < 86f)
                                            {
                                                FormOneWater(J, K, C, R, LWCIs[N].Class2);
                                                break;
                                            }

                                            FormOneWater(J, K, C, R, LWCIs[N].Class3);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("There has been a problem! Check the generated indexes!");
            }
        }
    }
}