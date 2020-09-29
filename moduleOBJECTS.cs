using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using VB = Microsoft.VisualBasic;

namespace SBuilderX
{
    static class moduleOBJECTS
    {
        [Serializable()]
        internal struct Objecto
        {
            public int Type; // 0=FSX 1=FS8 2=FS9 3=Rwy12 4=API 5=ASD 8=TaxiwaySign   128=FSX MDL 129=FS9 MDL
            public string Description; // code the type
            public bool Selected;
            public float Width;
            public float Length;
            public float Heading;
            public float Pitch;
            public float Bank;
            public float BiasX;
            public float BiasY;
            public float BiasZ;
            public double lat;
            public double lon;
            public double Altitude;
            public int AGL;
            public int Complexity;
            // the following are not exported
            public double NLAT;
            public double SLAT;
            public double WLON;
            public double ELON;
            public float HDX;
            public float HDY;
            public float P1Y;
            public float P1X;
            public float P2Y;
            public float P2X;
            public float P3Y;
            public float P3X;
            public float P4Y;
            public float P4X;
        }

        internal static Objecto[] Objects;
        internal static int NoOfObjects;
        internal static int NoOfObjectsSelected;

        internal struct LibObject : IComparable
        {
            public string ID;
            public string Name;
            public float Scaling;
            public float Width;
            public float Length;
            public int Type; // 0=FS8 1=FS9 2=FSX

            public int CompareTo(object obj)
            {
                LibObject tmp = (LibObject)obj;
                return Name.CompareTo(tmp.Name);
            }
        }

        public struct GenBObject
        {
            public int type;
            public float sizeX;
            public float sizeZ;
            public float scale;
            public string textures;
            public string indexes;
            public string name;
        }

        internal static GenBObject[] GenBObjects;
        internal static int NoOfGenBObjects;

        public struct LibCategory
        {
            public string Name;
            public List<LibObject> Objs;
        }

        internal static LibCategory[] LibCategories;
        internal static int NoOfLibCategories;
        internal static string LibObjectsPath;
        internal static bool LibObjectsIsOn;

        // Friend IncFiles() As String 'include files in objects.txt
        // Friend NoIncFiles As Integer

        // Rwy12 objects
        // *************************************************

        internal struct Rwy12Object
        {
            public string ID;
            public string Name;
            public string Texture;
        }

        internal struct Rwy12Category
        {
            public string Name;
            public int NOB;
            public Rwy12Object[] Rwy12Objects;
        }

        internal static Rwy12Category[] Rwy12Categories;
        internal static int NoOfRwy12Categories;
        internal static string Rwy12Path;
        internal static bool Rwy12IsOn;
        internal static string ObjComment;
        internal static bool ObjOrder;

        // start default = to last one used
        // Friend IniObjType As Integer


        internal static string ObjMDLFile;
        internal static string ObjMDLGuid;
        internal static string ObjMDLName;
        internal static float ObjMDLScale;
        internal static int ObjTaxSize;
        internal static string ObjTaxJust;
        internal static string ObjTaxLabel;
        internal static int ObjWinLight;
        internal static float ObjWinLength;
        internal static float ObjWinHeight;
        internal static int ObjWindPoleColor;
        internal static int ObjWindSockColor;
        internal static string ObjEffName;
        internal static string ObjEffParameters;
        internal static int ObjBeaCivil;
        internal static int ObjBeaMil;
        internal static int ObjBeaAirport;
        internal static int ObjBeaSeaBase;
        internal static int ObjBeaHeliport;
        internal static string ObjLibID;
        internal static float ObjLibScale;
        internal static int ObjLibType;   // 0=FS8 1=FS9 2=FSX ' not an error!!!!
        internal static float ObjLibV1;
        internal static float ObjLibV2;
        internal static bool ObjectTURN;
        internal static bool ObjectSIZE;
        internal static bool ObjectON;
        internal static bool ObjectVIEW;
        internal static bool ObjectDispON;
        internal static bool ObjMYes;  // used by Measure Tool ????
        internal static double ObjMHead;   // to give objects a prefixed heading
        private static int ObjectID;
        internal static double LatObj;
        internal static double LonObj;

        internal static void ObjectInsertMode(ref short Button, ref short Shift, int X, int Y)
        {
            if (Button == 1)
            {
                My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                if (Shift == 1) // pick the SHIFT DOWN
                {
                    moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsObjectSelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y);
                    moduleMAIN.RebuildDisplay();
                    if (moduleMAIN.SomeSelected)
                    {
                        moduleMAIN.SetDelay(200);
                        moduleMAIN.MoveON = true;
                        moduleMAIN.FirstMOVE = true;
                        My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = true;
                        My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = true;
                        moduleMAIN.AuxXInt = X;
                        moduleMAIN.AuxYInt = Y;
                    }

                    return;
                }

                if (IsObjectTurn(X, Y))
                {
                    // RebuildDisplay()
                    moduleMAIN.SetDelay(200);
                    ObjectTURN = true;
                    My.MyProject.Forms.FrmStart.SetMouseIcon();
                    return;
                }

                if (IsObjectSize(X, Y))
                {
                    // RebuildDisplay()
                    moduleMAIN.SetDelay(200);
                    ObjectSIZE = true;
                    My.MyProject.Forms.FrmStart.SetMouseIcon();
                    return;
                }

                bool argFlag = false;
                SelectAllObjects(ref argFlag);
                moduleMAIN.SomeSelected = IsObjectSelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y);
                moduleMAIN.RebuildDisplay();
                if (moduleMAIN.SomeSelected)
                {
                    moduleMAIN.SetDelay(200);
                    My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = true;
                    My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = true;
                    moduleMAIN.MoveON = true;
                    moduleMAIN.FirstMOVE = true;
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                    return;
                }
                else
                {
                    FormObject(X, Y);
                }
            }

            if (Button == 2)
            {
                modulePOPUP.XPOP = X;
                modulePOPUP.YPOP = Y;
                modulePOPUP.ProcessPopUp(X, Y);
            }
        }

        private static void FormObject(int X, int Y)
        {
            LonObj = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            LatObj = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            modulePOPUP.POPIndex = NoOfObjects + 1;
            My.MyProject.Forms.FrmObjectsP.ShowObjectProperties(modulePOPUP.POPIndex);
            My.MyProject.Forms.FrmObjectsP.ShowDialog();
        }

        internal static void SelectAllObjects(ref bool Flag)
        {
            int N;
            if (!ObjectVIEW)
                return;
            if (Flag)
            {
                My.MyProject.Forms.FrmStart.SelectAllObjectsMenuItem.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FrmStart.SelectAllObjectsMenuItem.Checked = false;
            }

            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if (Flag)
                {
                    if (!Objects[N].Selected)
                        NoOfObjectsSelected = NoOfObjectsSelected + 1;
                    moduleMAIN.SomeSelected = true;
                }
                else if (Objects[N].Selected)
                    NoOfObjectsSelected = NoOfObjectsSelected - 1;
                Objects[N].Selected = Flag;
            }
        }

        internal static void DisplayObjects(Graphics g)
        {
            string a;
            float X, Y;
            PointF P0 = default, P4 = default, P2 = default, P1 = default, P3 = default, P5 = default;
            int N;
            bool Flag;
            int type;
            Pen myPen = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(Color.Green);
            Image myImage;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if (Objects[N].NLAT < moduleMAIN.LatDispSouth)
                    goto JumpHere;
                if (Objects[N].SLAT > moduleMAIN.LatDispNorth)
                    goto JumpHere;
                if (Objects[N].WLON > moduleMAIN.LonDispEast)
                    goto JumpHere;
                if (Objects[N].ELON < moduleMAIN.LonDispWest)
                    goto JumpHere;
                type = Objects[N].Type;
                if (Objects[N].Selected)
                {
                    myBrush.Color = Color.SpringGreen;
                    myPen.Color = Color.Green;
                }
                else if (type < 3)
                {
                    myBrush.Color = Color.SkyBlue;
                    myPen.Color = Color.Black;
                }
                else if (type > 255)
                {
                    myBrush.Color = Color.Chocolate;
                    myPen.Color = Color.Black;
                }
                else
                {
                    myBrush.Color = Color.Yellow;
                    myPen.Color = Color.Black;
                }

                X = (float)((Objects[N].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                Y = (float)((moduleMAIN.LatDispNorth - Objects[N].lat) * moduleMAIN.PixelsPerLatDeg);
                Flag = (Objects[N].Width + Objects[N].Length) * moduleMAIN.PixelsPerMeter < 20d;
                if (Flag)
                {
                    g.FillRectangle(myBrush, X - 3f, Y - 3f, 6f, 6f);
                    g.DrawRectangle(myPen, X - 3f, Y - 3f, 6f, 6f);
                    goto JumpHere;
                }

                if (type == 8) // taxi sign
                {
                    a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\taxisign.bmp";
                    myImage = Image.FromFile(a);
                    g.DrawImage(myImage, X - 40f, Y - 20f, 80f, 40f);
                }

                if (type == 32) // beacon
                {
                    a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\beacon.gif";
                    myImage = Image.FromFile(a);
                    g.DrawImage(myImage, X - 20f, Y - 20f, 40f, 40f);
                }

                if (type == 64) // windsock
                {
                    a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\windsock.gif";
                    myImage = Image.FromFile(a);
                    g.DrawImage(myImage, X - 20f, Y - 20f, 40f, 40f);
                }

                if (type == 16) // effect
                {
                    a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\effect.gif";
                    myImage = Image.FromFile(a);
                    g.DrawImage(myImage, X - 20f, Y - 20f, 40f, 40f);
                }

                g.FillRectangle(myBrush, X - 3f, Y - 3f, 6f, 6f);
                g.DrawRectangle(myPen, X - 3f, Y - 3f, 6f, 6f);
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                P0.X = X;
                P0.Y = Y;
                P1.X = (float)(Objects[N].P1X * moduleMAIN.PixelsPerMeter + X);
                P2.X = (float)(Objects[N].P2X * moduleMAIN.PixelsPerMeter + X);
                P3.X = (float)(Objects[N].P3X * moduleMAIN.PixelsPerMeter + X);
                P4.X = (float)(Objects[N].P4X * moduleMAIN.PixelsPerMeter + X);
                P5.X = (float)(Objects[N].HDX * moduleMAIN.PixelsPerMeter + X);
                P1.Y = (float)(-Objects[N].P1Y * moduleMAIN.PixelsPerMeter + Y);
                P2.Y = (float)(-Objects[N].P2Y * moduleMAIN.PixelsPerMeter + Y);
                P3.Y = (float)(-Objects[N].P3Y * moduleMAIN.PixelsPerMeter + Y);
                P4.Y = (float)(-Objects[N].P4Y * moduleMAIN.PixelsPerMeter + Y);
                P5.Y = (float)(-Objects[N].HDY * moduleMAIN.PixelsPerMeter + Y);
                g.DrawLine(myPen, P1, P2);
                g.DrawLine(myPen, P2, P3);
                g.DrawLine(myPen, P3, P4);
                g.DrawLine(myPen, P4, P1);
                g.DrawLine(myPen, P0, P5);
                if (ObjectON)
                {
                    myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    g.DrawRectangle(myPen, P1.X - 2f, P1.Y - 2f, 4f, 4f);
                    g.DrawRectangle(myPen, P2.X - 2f, P2.Y - 2f, 4f, 4f);
                    g.DrawRectangle(myPen, P3.X - 2f, P3.Y - 3f, 4f, 4f);
                    g.DrawRectangle(myPen, P4.X - 2f, P4.Y - 2f, 4f, 4f);
                    g.DrawRectangle(myPen, P5.X - 2f, P5.Y - 2f, 4f, 4f);
                }

            JumpHere:
                ;
            }

            myBrush.Dispose();
            myPen.Dispose();
        }

        internal static void AddLatLonToObjects(int N)
        {
            float W2, L2;
            PointF P = default(PointF);
            float C, teta, S;
            if (Objects[N].Type < 8 | Objects[N].Type > 127)
            {
                W2 = Objects[N].Width / 2.0f;
                L2 = Objects[N].Length / 2.0f;
            }
            else if (Objects[N].Type == 8)
            {
                L2 = 3f;
                W2 = 1.5f;
            }
            else
            {
                W2 = 3f;
                L2 = 3f;
            }

            teta = (float)(Objects[N].Heading * moduleMAIN.PI / 180d);
            C = (float)Math.Cos(teta);
            S = (float)Math.Sin(teta);
            P.X = -W2;
            P.Y = L2;
            RotateXY(ref P, C, S);
            Objects[N].P1X = P.X;
            Objects[N].P1Y = P.Y;
            P.X = W2;
            P.Y = L2;
            RotateXY(ref P, C, S);
            Objects[N].P2X = P.X;
            Objects[N].P2Y = P.Y;
            P.X = W2;
            P.Y = -L2;
            RotateXY(ref P, C, S);
            Objects[N].P3X = P.X;
            Objects[N].P3Y = P.Y;
            P.X = -W2;
            P.Y = -L2;
            RotateXY(ref P, C, S);
            Objects[N].P4X = P.X;
            Objects[N].P4Y = P.Y;
            P.X = 0f;
            P.Y = L2;
            RotateXY(ref P, C, S);
            Objects[N].HDX = P.X;
            Objects[N].HDY = P.Y;
            AddObjectLimits(N);
        }

        private static void AddObjectLimits(int N)
        {
            double EL, NL, SL, WL;
            double X;
            double Y;
            NL = -90;
            SL = 90d;
            EL = -180;
            WL = 180d;
            X = Objects[N].lon + Objects[N].P1X * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLonDeg;
            Y = Objects[N].lat + Objects[N].P1Y * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLatDeg;
            if (NL < Y)
                NL = Y;
            if (SL > Y)
                SL = Y;
            if (EL < X)
                EL = X;
            if (WL > X)
                WL = X;
            X = Objects[N].lon + Objects[N].P2X * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLonDeg;
            Y = Objects[N].lat + Objects[N].P2Y * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLatDeg;
            if (NL < Y)
                NL = Y;
            if (SL > Y)
                SL = Y;
            if (EL < X)
                EL = X;
            if (WL > X)
                WL = X;
            X = Objects[N].lon + Objects[N].P3X * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLonDeg;
            Y = Objects[N].lat + Objects[N].P3Y * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLatDeg;
            if (NL < Y)
                NL = Y;
            if (SL > Y)
                SL = Y;
            if (EL < X)
                EL = X;
            if (WL > X)
                WL = X;
            X = Objects[N].lon + Objects[N].P4X * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLonDeg;
            Y = Objects[N].lat + Objects[N].P4Y * moduleMAIN.PixelsPerMeter / moduleMAIN.PixelsPerLatDeg;
            if (NL < Y)
                NL = Y;
            if (SL > Y)
                SL = Y;
            if (EL < X)
                EL = X;
            if (WL > X)
                WL = X;
            Objects[N].ELON = EL;
            Objects[N].WLON = WL;
            Objects[N].NLAT = NL;
            Objects[N].SLAT = SL;
        }

        internal static void AppendOBJFile(string filename)
        {
            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            moduleEDIT.BackUp();
            int NoOfObjectsIni = NoOfObjects;

            try
            {
                string A;
                string FN;
                int R, G, B;
                bool HasBias = false;
                bool AppendNewObject = false;
                double alt = default(double);
                FN = Path.GetFileNameWithoutExtension(filename);
                int K = 1;
                int N = NoOfObjects + 1;
                NoOfObjects = NoOfObjects + 10;
                Array.Resize(ref Objects, NoOfObjects + 1);
                XmlReader reader = XmlReader.Create(filename);
                reader.MoveToContent();

                // Parse the file and display each of the nodes.
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        AppendNewObject = false;
                        if (reader.Name == "SceneryObject")
                        {
                            Objects[N].lat = BGLStr2Lat(reader.GetAttribute("lat"));
                            Objects[N].lon = BGLStr2Lon(reader.GetAttribute("lon"));
                            Objects[N].Altitude = BGLStr2Alt(reader.GetAttribute("alt"));
                            Objects[N].AGL = BGLStr2AGL(reader.GetAttribute("altitudeIsAgl"));
                            Objects[N].Pitch = Convert.ToSingle(reader.GetAttribute("pitch"));
                            Objects[N].Bank = Convert.ToSingle(reader.GetAttribute("bank"));
                            Objects[N].Heading = Convert.ToSingle(reader.GetAttribute("heading"));
                            Objects[N].Complexity = BGLStr2Comp(reader.GetAttribute("imageComplexity"));
                            Objects[N].Width = 10f;
                            Objects[N].Length = 10f;
                            do
                                reader.Read();
                            while (reader.NodeType != XmlNodeType.Element);
                            if (reader.Name == "BiasXYZ")
                            {
                                Objects[N].BiasX = Convert.ToSingle(reader.GetAttribute("biasX"));
                                Objects[N].BiasY = Convert.ToSingle(reader.GetAttribute("biasY"));
                                Objects[N].BiasZ = Convert.ToSingle(reader.GetAttribute("biasZ"));
                                HasBias = true;
                            }
                            else
                            {
                                Objects[N].BiasX = 0f;
                                Objects[N].BiasY = 0f;
                                Objects[N].BiasZ = 0f;
                                HasBias = false;
                            }

                            if (HasBias)
                            {
                                do
                                    reader.Read();
                                while (reader.NodeType != XmlNodeType.Element);
                            }

                            if (reader.Name == "Beacon")
                            {
                                AppendNewObject = true;
                                Objects[N].Type = 32;
                                ObjComment = "Beacon_from_" + FN + "_#" + K;
                                ObjBeaCivil = 0;
                                ObjBeaMil = 0;
                                A = reader.GetAttribute("type").Substring(0, 1);
                                if (A == "C")
                                    ObjBeaCivil = 1;
                                if (A == "M")
                                    ObjBeaMil = 1;
                                ObjBeaAirport = 0;
                                ObjBeaSeaBase = 0;
                                ObjBeaHeliport = 0;
                                A = reader.GetAttribute("baseType").Substring(0, 1);
                                if (A == "A")
                                    ObjBeaAirport = 1;
                                if (A == "S")
                                    ObjBeaSeaBase = 1;
                                if (A == "H")
                                    ObjBeaHeliport = 1;
                                Objects[N].Description = MakeDescription(N);
                            }

                            if (reader.Name == "Windsock")
                            {
                                AppendNewObject = true;
                                Objects[N].Type = 64;
                                ObjComment = "Windsock_from_" + FN + "_#" + K;
                                ObjWinHeight = Convert.ToSingle(reader.GetAttribute("poleHeight"));
                                ObjWinLength = Convert.ToSingle(reader.GetAttribute("sockLength"));
                                ObjWinLight = 0;
                                if (reader.GetAttribute("lighted").Substring(0, 1) == "T")
                                    ObjWinLight = 1;
                                ObjWindPoleColor = ColorTranslator.ToOle(Color.Gray);
                                ObjWindSockColor = ColorTranslator.ToOle(Color.Orange);
                                do
                                {
                                    reader.Read();
                                    if (reader.NodeType == XmlNodeType.EndElement)
                                        break;
                                    if (reader.Name == "PoleColor")
                                    {
                                        R = Convert.ToInt32(reader.GetAttribute("red"));
                                        B = Convert.ToInt32(reader.GetAttribute("blue"));
                                        G = Convert.ToInt32(reader.GetAttribute("green"));
                                        ObjWindPoleColor = ColorTranslator.ToOle(Color.FromArgb(255, R, G, B));
                                    }

                                    if (reader.Name == "SockColor")
                                    {
                                        R = Convert.ToInt32(reader.GetAttribute("red"));
                                        B = Convert.ToInt32(reader.GetAttribute("blue"));
                                        G = Convert.ToInt32(reader.GetAttribute("green"));
                                        ObjWindSockColor = ColorTranslator.ToOle(Color.FromArgb(255, R, G, B));
                                    }
                                }
                                while (true);
                                Objects[N].Description = MakeDescription(N);
                            }

                            if (reader.Name == "Effect")
                            {
                                AppendNewObject = true;
                                Objects[N].Type = 16;
                                ObjComment = "Effect_from_" + FN + "_#" + K;
                                ObjEffName = reader.GetAttribute("effectName");
                                ObjEffParameters = reader.GetAttribute("effectParams");
                                Objects[N].Description = MakeDescription(N);
                            }

                            if (reader.Name == "LibraryObject")
                            {
                                AppendNewObject = true;
                                Objects[N].Type = 0;
                                ObjComment = "LibObject_from_" + FN + "_#" + K;
                                ObjLibID = reader.GetAttribute("name");
                                ObjLibScale = Convert.ToSingle(reader.GetAttribute("scale"));
                                Objects[N].Description = MakeDescription(N);
                            }

                            if (reader.Name == "GenericBuilding")
                            {
                                AppendNewObject = true;
                                ObjComment = "GenBuilding_from_" + FN + "_#" + K;
                                scale_gb = Convert.ToSingle(reader.GetAttribute("scale"));
                                bottomTexture = Convert.ToInt32(reader.GetAttribute("bottomTexture"));
                                roofTexture = Convert.ToInt32(reader.GetAttribute("roofTexture"));
                                topTexture = Convert.ToInt32(reader.GetAttribute("topTexture"));
                                windowTexture = Convert.ToInt32(reader.GetAttribute("windowTexture"));
                                do
                                    reader.Read();
                                while (reader.NodeType != XmlNodeType.Element);
                                if (reader.Name == "RectangularBuilding")
                                {
                                    if (reader.GetAttribute("roofType") == "FLAT")
                                    {
                                        Objects[N].Type = 256;
                                    }

                                    if (reader.GetAttribute("roofType") == "PEAKED")
                                    {
                                        Objects[N].Type = 257;
                                    }

                                    if (reader.GetAttribute("roofType") == "RIDGE")
                                    {
                                        Objects[N].Type = 258;
                                    }

                                    if (reader.GetAttribute("roofType") == "SLANT")
                                    {
                                        Objects[N].Type = 259;
                                    }
                                }

                                if (reader.Name == "PyramidalBuilding")
                                {
                                    Objects[N].Type = 260;
                                }

                                if (reader.Name == "MultiSidedBuilding")
                                {
                                    Objects[N].Type = 261;
                                }

                                if (Objects[N].Type == 256 | Objects[N].Type == 257 | Objects[N].Type == 258 | Objects[N].Type == 259)
                                // Rect flat
                                {
                                    sizeX = Convert.ToSingle(reader.GetAttribute("sizeX"));
                                    sizeZ = Convert.ToSingle(reader.GetAttribute("sizeZ"));
                                    sizeBottomY = Convert.ToSingle(reader.GetAttribute("sizeBottomY"));
                                    textureIndexBottomX = Convert.ToInt32(reader.GetAttribute("textureIndexBottomX"));
                                    textureIndexBottomZ = Convert.ToInt32(reader.GetAttribute("textureIndexBottomZ"));
                                    sizeWindowY = Convert.ToSingle(reader.GetAttribute("sizeWindowY"));
                                    textureIndexWindowX = Convert.ToInt32(reader.GetAttribute("textureIndexWindowX"));
                                    textureIndexWindowY = Convert.ToInt32(reader.GetAttribute("textureIndexWindowY"));
                                    textureIndexWindowZ = Convert.ToInt32(reader.GetAttribute("textureIndexWindowZ"));
                                    sizeTopY = Convert.ToSingle(reader.GetAttribute("sizeTopY"));
                                    textureIndexTopX = Convert.ToInt32(reader.GetAttribute("textureIndexTopX"));
                                    textureIndexTopZ = Convert.ToInt32(reader.GetAttribute("textureIndexTopZ"));
                                    textureIndexRoofX = Convert.ToInt32(reader.GetAttribute("textureIndexRoofX"));
                                    textureIndexRoofZ = Convert.ToInt32(reader.GetAttribute("textureIndexRoofZ"));
                                }

                                if (Objects[N].Type == 257)  // Rect peaked
                                {
                                    sizeRoofY = Convert.ToSingle(reader.GetAttribute("sizeRoofY"));
                                    textureIndexRoofY = Convert.ToInt32(reader.GetAttribute("textureIndexRoofY"));
                                }

                                if (Objects[N].Type == 258)  // Rect Ridge
                                {
                                    sizeRoofY = Convert.ToSingle(reader.GetAttribute("sizeRoofY"));
                                    gableTexture = Convert.ToInt32(reader.GetAttribute("gableTexture"));
                                    textureIndexGableY = Convert.ToInt32(reader.GetAttribute("textureIndexGableY"));
                                    textureIndexGableZ = Convert.ToInt32(reader.GetAttribute("textureIndexGableZ"));
                                }

                                if (Objects[N].Type == 259)  // Rect slant
                                {
                                    sizeRoofY = Convert.ToSingle(reader.GetAttribute("sizeRoofY"));
                                    gableTexture = Convert.ToInt32(reader.GetAttribute("gableTexture"));
                                    textureIndexGableY = Convert.ToInt32(reader.GetAttribute("textureIndexGableY"));
                                    textureIndexGableZ = Convert.ToInt32(reader.GetAttribute("textureIndexGableZ"));
                                    faceTexture = Convert.ToInt32(reader.GetAttribute("faceTexture"));
                                    textureIndexFaceX = Convert.ToInt32(reader.GetAttribute("textureIndexFaceX"));
                                    textureIndexFaceY = Convert.ToInt32(reader.GetAttribute("textureIndexFaceY"));
                                }

                                if (Objects[N].Type == 260)  // pyramidal
                                {
                                    sizeX = Convert.ToSingle(reader.GetAttribute("sizeX"));
                                    sizeZ = Convert.ToSingle(reader.GetAttribute("sizeZ"));
                                    sizeTopX = Convert.ToSingle(reader.GetAttribute("sizeTopX"));
                                    sizeTopZ = Convert.ToSingle(reader.GetAttribute("sizeTopZ"));
                                    sizeBottomY = Convert.ToSingle(reader.GetAttribute("sizeBottomY"));
                                    textureIndexBottomX = Convert.ToInt32(reader.GetAttribute("textureIndexBottomX"));
                                    textureIndexBottomZ = Convert.ToInt32(reader.GetAttribute("textureIndexBottomZ"));
                                    sizeWindowY = Convert.ToSingle(reader.GetAttribute("sizeWindowY"));
                                    textureIndexWindowX = Convert.ToInt32(reader.GetAttribute("textureIndexWindowX"));
                                    textureIndexWindowY = Convert.ToInt32(reader.GetAttribute("textureIndexWindowY"));
                                    textureIndexWindowZ = Convert.ToInt32(reader.GetAttribute("textureIndexWindowZ"));
                                    sizeTopY = Convert.ToSingle(reader.GetAttribute("sizeTopY"));
                                    textureIndexTopX = Convert.ToInt32(reader.GetAttribute("textureIndexTopX"));
                                    textureIndexTopZ = Convert.ToInt32(reader.GetAttribute("textureIndexTopZ"));
                                    textureIndexRoofX = Convert.ToInt32(reader.GetAttribute("textureIndexRoofX"));
                                    textureIndexRoofZ = Convert.ToInt32(reader.GetAttribute("textureIndexRoofZ"));
                                }

                                if (Objects[N].Type == 261) // multi sided
                                {
                                    buildingSides = Convert.ToInt32(reader.GetAttribute("buildingSides"));
                                    smoothing = Convert.ToBoolean(reader.GetAttribute("smoothing"));
                                    sizeX = Convert.ToSingle(reader.GetAttribute("sizeX"));
                                    sizeZ = Convert.ToSingle(reader.GetAttribute("sizeZ"));
                                    sizeBottomY = Convert.ToSingle(reader.GetAttribute("sizeBottomY"));
                                    textureIndexBottomX = Convert.ToInt32(reader.GetAttribute("textureIndexBottomX"));
                                    sizeWindowY = Convert.ToSingle(reader.GetAttribute("sizeWindowY"));
                                    textureIndexWindowX = Convert.ToInt32(reader.GetAttribute("textureIndexWindowX"));
                                    textureIndexWindowY = Convert.ToInt32(reader.GetAttribute("textureIndexWindowY"));
                                    sizeTopY = Convert.ToSingle(reader.GetAttribute("sizeTopY"));
                                    textureIndexTopX = Convert.ToInt32(reader.GetAttribute("textureIndexTopX"));
                                    sizeRoofY = Convert.ToSingle(reader.GetAttribute("sizeRoofY"));
                                    textureIndexRoofX = Convert.ToInt32(reader.GetAttribute("textureIndexRoofX"));
                                    textureIndexRoofY = Convert.ToInt32(reader.GetAttribute("textureIndexRoofY"));
                                    textureIndexRoofZ = Convert.ToInt32(reader.GetAttribute("textureIndexRoofZ"));
                                }

                                Objects[N].Width = sizeX;
                                Objects[N].Length = sizeZ;
                                Objects[N].Description = MakeDescription(N);
                            }
                        }

                        if (reader.Name == "Airport")
                        {
                            // taxiwaysigns
                            alt = BGLStr2Alt(reader.GetAttribute("alt"));
                        }

                        if (reader.Name == "TaxiwaySign")
                        {
                            AppendNewObject = true;
                            Objects[N].Type = 8;
                            ObjComment = "TaxiwaySign_from_" + FN + "_#" + K;
                            Objects[N].lat = BGLStr2Lat(reader.GetAttribute("lat"));
                            Objects[N].lon = BGLStr2Lon(reader.GetAttribute("lon"));
                            Objects[N].Altitude = alt;
                            Objects[N].AGL = 0;
                            Objects[N].Pitch = 0f;
                            Objects[N].Bank = 0f;
                            Objects[N].Heading = Convert.ToSingle(reader.GetAttribute("heading"));
                            Objects[N].Complexity = 0;
                            Objects[N].Width = 10f;
                            Objects[N].Length = 10f;
                            ObjTaxLabel = reader.GetAttribute("label");
                            ObjTaxSize = Convert.ToInt32(reader.GetAttribute("size").Substring(4, 1));
                            ObjTaxJust = reader.GetAttribute("justification");
                            Objects[N].Description = MakeDescription(N);
                        }

                        if (AppendNewObject == true)
                        {
                            AddLatLonToObjects(N);
                            if (N == NoOfObjects)
                            {
                                NoOfObjects = NoOfObjects + 10;
                                Array.Resize(ref Objects, NoOfObjects + 1);
                            }

                            N = N + 1;
                            K = K + 1;
                        }
                    }
                }

                reader.Close();
                NoOfObjects = NoOfObjectsIni + K - 1;
                Array.Resize(ref Objects, NoOfObjects + 1);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
                return;
            }
            catch (Exception)
            {
                Array.Resize(ref Objects, NoOfObjectsIni + 1);
                MessageBox.Show("SBuilderX could not import objects", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                My.MyProject.Forms.FrmStart.Cursor = Cursors.Default;
            }
        }

        private static double BGLStr2Lat(string S)
        {
            double BGLStr2LatRet = default;
            string A;
            int N;
            try
            {
                BGLStr2LatRet = Convert.ToDouble(S);
            }
            catch (FormatException)
            {
                A = S.Substring(0, 1);
                if (A == "N")
                {
                    N = S.IndexOf(" ");
                    // Debug.Print(S.Substring(1, N - 2))
                    // Debug.Print(S.Substring(N))
                    BGLStr2LatRet = Convert.ToDouble(S.Substring(1, N - 1));
                    BGLStr2LatRet = BGLStr2LatRet + Convert.ToDouble(S.Substring(N)) / 60d;
                }
                else if (A == "S")
                {
                    N = S.IndexOf(" ");
                    BGLStr2LatRet = Convert.ToDouble(S.Substring(1, N - 1));
                    BGLStr2LatRet = -BGLStr2LatRet - Convert.ToDouble(S.Substring(N)) / 60d;
                }
            }

            return BGLStr2LatRet;
        }

        private static double BGLStr2Lon(string S)
        {
            double BGLStr2LonRet = default;
            string A;
            int N;
            try
            {
                BGLStr2LonRet = Convert.ToDouble(S);
            }
            catch (FormatException)
            {
                A = S.Substring(0, 1);
                if (A == "E")
                {
                    N = S.IndexOf(" ");
                    // Debug.Print(S.Substring(1, N - 2))
                    // Debug.Print(S.Substring(N))
                    BGLStr2LonRet = Convert.ToDouble(S.Substring(1, N - 1));
                    BGLStr2LonRet = BGLStr2LonRet + Convert.ToDouble(S.Substring(N)) / 60d;
                }
                else if (A == "W")
                {
                    N = S.IndexOf(" ");
                    BGLStr2LonRet = Convert.ToDouble(S.Substring(1, N - 2));
                    BGLStr2LonRet = -BGLStr2LonRet - Convert.ToDouble(S.Substring(N)) / 60d;
                }
            }

            return BGLStr2LonRet;
        }

        private static double BGLStr2Alt(string S)
        {
            double BGLStr2AltRet = default;
            int N = S.Length;
            S = S.Substring(0, N - 1);
            BGLStr2AltRet = Convert.ToDouble(S);
            return BGLStr2AltRet;
        }

        private static int BGLStr2Comp(string S)
        {
            int BGLStr2CompRet = default;
            string N = S.Length.ToString();
            if (Convert.ToDouble(N) == 6d)
            {
                // SPARSE or 'NORMAL
                string A = S.Substring(0, 1);
                if (A == "N")
                {
                    BGLStr2CompRet = 2;
                }
                else
                {
                    BGLStr2CompRet = 1;
                }

                return BGLStr2CompRet;
            }

            if (Convert.ToDouble(N) == 11d)
            {
                // VERY_SPARSE
                BGLStr2CompRet = 0;
                return BGLStr2CompRet;
            }

            if (Convert.ToDouble(N) == 5d)
            {
                // DENSE
                BGLStr2CompRet = 3;
                return BGLStr2CompRet;
            }

            if (Convert.ToDouble(N) == 15d)
            {
                // EXTREMELY_DENSE
                BGLStr2CompRet = 5;
                return BGLStr2CompRet;
            }

            BGLStr2CompRet = 4; // it is very_dense
            return BGLStr2CompRet;
        }

        private static int BGLStr2AGL(string S)
        {
            int BGLStr2AGLRet = default;
            string A = S.Substring(0, 1);
            if (A == "T")
            {
                BGLStr2AGLRet = 1;
            }
            else
            {
                BGLStr2AGLRet = 0;
            }

            return BGLStr2AGLRet;
        }

        private static void RotateXY(ref PointF P, float Cos, float Sin)
        {
            float a;
            a = P.X;
            P.X = Cos * P.X + Sin * P.Y;
            P.Y = Cos * P.Y - Sin * a;
        }

        internal static bool IsObjectTurn(int X, int Y)
        {
            bool IsObjectTurnRet = default;
            // on entry X Y contain distance from NW corner display in pixels

            int N;
            PointF PC = default, P = default;
            IsObjectTurnRet = false;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if ((Objects[N].Width + Objects[N].Length) * moduleMAIN.PixelsPerMeter < 20d)
                    continue;
                PC.X = (float)((Objects[N].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                PC.Y = (float)((moduleMAIN.LatDispNorth - Objects[N].lat) * moduleMAIN.PixelsPerLatDeg);
                P.X = (float)(PC.X + Objects[N].HDX * moduleMAIN.PixelsPerMeter);
                P.Y = (float)(PC.Y - Objects[N].HDY * moduleMAIN.PixelsPerMeter);
                if (P.X > X + 5)
                    continue;
                if (P.X < X - 5)
                    continue;
                if (P.Y < Y - 5)
                    continue;
                if (P.Y > Y + 5)
                    continue;
                ObjectID = N;
                Objects[N].Selected = true;
                IsObjectTurnRet = true;
                return IsObjectTurnRet;
            }

            return IsObjectTurnRet;
        }

        internal static bool IsObjectSize(int X, int Y)
        {
            bool IsObjectSizeRet = default;
            // on entry X Y contain distance from NW corner display in pixels

            int N;
            moduleMAIN.Double_XY PC, P;
            IsObjectSizeRet = false;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if ((Objects[N].Width + Objects[N].Length) * moduleMAIN.PixelsPerMeter < 20d)
                    goto next_N;
                PC.X = (float)((Objects[N].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                PC.Y = (float)((moduleMAIN.LatDispNorth - Objects[N].lat) * moduleMAIN.PixelsPerLatDeg);
                P.X = PC.X + Objects[N].P1X * moduleMAIN.PixelsPerMeter;
                P.Y = PC.Y - Objects[N].P1Y * moduleMAIN.PixelsPerMeter;
                if (P.X > X + 5)
                    goto next_2;
                if (P.X < X - 5)
                    goto next_2;
                if (P.Y < Y - 5)
                    goto next_2;
                if (P.Y > Y + 5)
                    goto next_2;
                ObjectID = N;
                Objects[N].Selected = true;
                IsObjectSizeRet = true;
                return IsObjectSizeRet;
            next_2:
                ;
                P.X = PC.X + Objects[N].P2X * moduleMAIN.PixelsPerMeter;
                P.Y = PC.Y - Objects[N].P2Y * moduleMAIN.PixelsPerMeter;
                if (P.X > X + 5)
                    goto next_3;
                if (P.X < X - 5)
                    goto next_3;
                if (P.Y < Y - 5)
                    goto next_3;
                if (P.Y > Y + 5)
                    goto next_3;
                ObjectID = N;
                Objects[N].Selected = true;
                IsObjectSizeRet = true;
                return IsObjectSizeRet;
            next_3:
                ;
                P.X = PC.X + Objects[N].P3X * moduleMAIN.PixelsPerMeter;
                P.Y = PC.Y - Objects[N].P3Y * moduleMAIN.PixelsPerMeter;
                if (P.X > X + 5)
                    goto next_4;
                if (P.X < X - 5)
                    goto next_4;
                if (P.Y < Y - 5)
                    goto next_4;
                if (P.Y > Y + 5)
                    goto next_4;
                ObjectID = N;
                Objects[N].Selected = true;
                IsObjectSizeRet = true;
                return IsObjectSizeRet;
            next_4:
                ;
                P.X = PC.X + Objects[N].P4X * moduleMAIN.PixelsPerMeter;
                P.Y = PC.Y - Objects[N].P4Y * moduleMAIN.PixelsPerMeter;
                if (P.X > X + 5)
                    goto next_N;
                if (P.X < X - 5)
                    goto next_N;
                if (P.Y < Y - 5)
                    goto next_N;
                if (P.Y > Y + 5)
                    goto next_N;
                ObjectID = N;
                Objects[N].Selected = true;
                IsObjectSizeRet = true;
                return IsObjectSizeRet;
            next_N:
                ;
            }

            return IsObjectSizeRet;
        }

        internal static void MoveSelectedObjects(double X, double Y)
        {
            int N;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if (Objects[N].Selected == false)
                    goto next_N;
                Objects[N].lat = Objects[N].lat - Y;
                Objects[N].lon = Objects[N].lon + X;
                AddObjectLimits(N);
            next_N:
                ;
            }
        }

        internal static void DeleteThisObject(int N)
        {
            int K;
            moduleMAIN.Dirty = true;
            if (!moduleEDIT.SkipBackUp)
                moduleEDIT.BackUp();
            if (N < NoOfObjects)
            {
                int loopTo = NoOfObjects - 1;
                for (K = N; K <= loopTo; K++)
                    Objects[K] = Objects[K + 1];
            }

            if (NoOfObjects > 1)
            {
                Array.Resize(ref Objects, NoOfObjects);
            }

            NoOfObjects = NoOfObjects - 1;
        }

        internal static bool IsObjectSelected(double X, double Y)
        {
            bool IsObjectSelectedRet = default;
            int N;
            moduleMAIN.Double_XY PC;
            double XS, YS;
            bool retval;
            double WLON, NLAT, SLAT, ELON;

            // X and Y enter with pixels from the Earth center

            IsObjectSelectedRet = false;
            if (!ObjectVIEW)
                return IsObjectSelectedRet;
            WLON = (X + 5d) / moduleMAIN.PixelsPerLonDeg;
            ELON = (X - 5d) / moduleMAIN.PixelsPerLonDeg;
            NLAT = (Y - 5d) / moduleMAIN.PixelsPerLatDeg;
            SLAT = (Y + 5d) / moduleMAIN.PixelsPerLatDeg;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if (WLON < Objects[N].WLON)
                    goto next_N;
                if (ELON > Objects[N].ELON)
                    goto next_N;
                if (SLAT < Objects[N].SLAT)
                    goto next_N;
                if (NLAT > Objects[N].NLAT)
                    goto next_N;
                PC.X = Objects[N].lon * moduleMAIN.PixelsPerLonDeg;
                PC.Y = Objects[N].lat * moduleMAIN.PixelsPerLatDeg;
                if (PC.X > X + 5d)
                    goto check_sides;
                if (PC.X < X - 5d)
                    goto check_sides;
                if (PC.Y < Y - 5d)
                    goto check_sides;
                if (PC.Y > Y + 5d)
                    goto check_sides;
                if (Objects[N].Selected == false)
                    NoOfObjectsSelected = NoOfObjectsSelected + 1;
                Objects[N].Selected = true;
                IsObjectSelectedRet = true;
                return IsObjectSelectedRet;
            check_sides:
                ;
                XS = X - PC.X;
                YS = Y - PC.Y;
                retval = IsPointInObject(Objects[N].P1X, Objects[N].P1Y, Objects[N].P2X, Objects[N].P2Y, XS, YS);
                if (!retval)
                {
                    retval = IsPointInObject(Objects[N].P2X, Objects[N].P2Y, Objects[N].P3X, Objects[N].P3Y, XS, YS);
                }

                if (!retval)
                {
                    retval = IsPointInObject(Objects[N].P3X, Objects[N].P3Y, Objects[N].P4X, Objects[N].P4Y, XS, YS);
                }

                if (!retval)
                {
                    retval = IsPointInObject(Objects[N].P4X, Objects[N].P4Y, Objects[N].P1X, Objects[N].P1Y, XS, YS);
                }

                if (retval)
                {
                    if (Objects[N].Selected == false)
                        NoOfObjectsSelected = NoOfObjectsSelected + 1;
                    Objects[N].Selected = true;
                    IsObjectSelectedRet = true;
                    return IsObjectSelectedRet;
                }

            next_N:
                ;
            }

            return IsObjectSelectedRet;
        }

        private static bool IsPointInObject(double X0, double Y0, double X1, double Y1, double x, double y)
        {
            bool IsPointInObjectRet = default;

            // on entry X Y contain distance in pixels from object center
            // other parameters are distances in meters of line extremes in relation to object center

            IsPointInObjectRet = false;
            X0 = X0 * moduleMAIN.PixelsPerMeter;
            X1 = X1 * moduleMAIN.PixelsPerMeter;
            Y0 = Y0 * moduleMAIN.PixelsPerMeter;
            Y1 = Y1 * moduleMAIN.PixelsPerMeter;
            if (x > X0 + 5d & x > X1 + 5d)
                return IsPointInObjectRet;
            if (x < X0 - 5d & x < X1 - 5d)
                return IsPointInObjectRet;
            if (y > Y0 + 5d & y > Y1 + 5d)
                return IsPointInObjectRet;
            if (y < Y0 - 5d & y < Y1 - 5d)
                return IsPointInObjectRet;
            X1 = X1 - X0;
            Y1 = Y1 - Y0;
            if (Math.Abs(X1) > Math.Abs(Y1))
            {
                x = Y0 + Y1 * (x - X0) / X1;
                if (x > y + 5d)
                    return IsPointInObjectRet;
                if (x < y - 5d)
                    return IsPointInObjectRet;
            }
            else
            {
                y = X0 + X1 * (y - Y0) / Y1;
                if (y > x + 5d)
                    return IsPointInObjectRet;
                if (y < x - 5d)
                    return IsPointInObjectRet;
            }

            IsPointInObjectRet = true;
            return IsPointInObjectRet;
        }

        internal static void SelectObjectsInBox(double X0, double Y0, double X1, double Y1)
        {
            int N;
            if (!ObjectVIEW)
                return;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if (Objects[N].ELON < X1)
                {
                    if (Objects[N].WLON > X0)
                    {
                        if (Objects[N].SLAT > Y1)
                        {
                            if (Objects[N].NLAT < Y0)
                            {
                                if (!Objects[N].Selected)
                                    NoOfObjectsSelected = NoOfObjectsSelected + 1;
                                moduleMAIN.SomeSelected = true;
                                Objects[N].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        internal static void TurnObject(int X, int Y)
        {
            float Y0, X0, Head;
            X0 = (float)((Objects[ObjectID].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            Y0 = (float)((moduleMAIN.LatDispNorth - Objects[ObjectID].lat) * moduleMAIN.PixelsPerLatDeg);
            X0 = X - X0;
            Y0 = Y0 - Y;
            Head = 0f;
            if (Y0 > 0f)
            {
                Head = (float)(Math.Atan(X0 / Y0) * 180d / moduleMAIN.PI);
            }
            else if (Y0 < 0f)
            {
                Head = (float)(180d + Math.Atan(X0 / Y0) * 180d / moduleMAIN.PI);
            }
            else if (X0 > 0f)
            {
                Head = 90f;
            }
            else
            {
                Head = 270f;
            }

            if (Head < 0f)
                Head = Head + 360f;
            Objects[ObjectID].Heading = Head;
            AddLatLonToObjects(ObjectID);
            moduleMAIN.RebuildDisplay();
        }

        internal static void SizeObject(int X, int Y)
        {
            float Y0, X0, teta;
            float YD, XD, Head;
            X0 = (float)((Objects[ObjectID].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            Y0 = (float)((moduleMAIN.LatDispNorth - Objects[ObjectID].lat) * moduleMAIN.PixelsPerLatDeg);
            XD = X - X0;
            YD = Y - Y0;
            if (XD > 0f)
            {
                teta = (float)(90d + Math.Atan(YD / XD) * 180d / moduleMAIN.PI);
            }
            else if (XD < 0f)
            {
                teta = (float)(270d + Math.Atan(YD / XD) * 180d / moduleMAIN.PI);
            }
            else if (YD > 0f)
            {
                teta = 180f;
            }
            else
            {
                teta = 0f;
            }

            Head = Objects[ObjectID].Heading;
            if (Head < 0f)
                Head = Head + 360f;
            teta = teta - Head;
            teta = (float)(teta * moduleMAIN.PI / 180d);
            XD = XD * XD;
            YD = YD * YD;
            XD = XD + YD;
            XD = (float)Math.Sqrt(XD);
            YD = (float)Math.Cos(teta);
            YD = Math.Abs(YD);
            YD = YD * XD;
            XD = XD * XD - YD * YD;
            XD = (float)Math.Sqrt(XD);
            Objects[ObjectID].Width = (float)(2f * XD / moduleMAIN.PixelsPerMeter);
            Objects[ObjectID].Length = (float)(2f * YD / moduleMAIN.PixelsPerMeter);
            AddLatLonToObjects(ObjectID);
            moduleMAIN.RebuildDisplay();
        }

        internal static void SetGenBObjects()
        {
            int K, N1, N2;
            GenBObjects = new GenBObject[1001];
            FileStream stream;
            StreamReader fileReader;
            string line = "";
            string myFile = moduleMAIN.AppPath + @"\GenBuildings\GenBuildings.txt";
            if (!File.Exists(myFile))
            {
                File.Create(myFile);
            }

            K = 1;
            try
            {
                stream = new FileStream(myFile, FileMode.Open);
                fileReader = new StreamReader(stream);
                while (!fileReader.EndOfStream)
                {
                    line = fileReader.ReadLine();
                    if (line.Length > 0)
                    {
                        if (line.Substring(0, 1) == "2")
                        {
                            GenBObjects[K].type = Convert.ToInt32(line.Substring(0, 3));
                            N1 = 3;
                            N2 = line.IndexOf(" ", N1 + 1);
                            GenBObjects[K].sizeX = Convert.ToSingle(line.Substring(N1 + 1, N2 - N1 - 1));
                            N1 = N2;
                            N2 = line.IndexOf(" ", N1 + 1);
                            GenBObjects[K].sizeZ = Convert.ToSingle(line.Substring(N1 + 1, N2 - N1 - 1));
                            N1 = N2;
                            N2 = line.IndexOf(" ", N1 + 1);
                            GenBObjects[K].scale = Convert.ToSingle(line.Substring(N1 + 1, N2 - N1 - 1));
                            N1 = N2;
                            N2 = line.IndexOf(" ", N1 + 1);
                            GenBObjects[K].textures = line.Substring(N1 + 1, N2 - N1 - 1);
                            N1 = N2;
                            N2 = line.IndexOf(" ", N1 + 1);
                            GenBObjects[K].indexes = line.Substring(N1 + 1, N2 - N1 - 1);
                            GenBObjects[K].name = line.Substring(N2 + 1);
                            K = K + 1;
                        }
                    }
                }

                // should I reaaly comment the following? October 2017
                // fileReader.Close()
                stream.Close();
                NoOfGenBObjects = K - 1;
                Array.Resize(ref GenBObjects, NoOfGenBObjects + 1);
            }
            catch (Exception)
            {
                NoOfGenBObjects = 0;
                GenBObjects = new GenBObject[1];
                MessageBox.Show("There was an error reading GenBuildings.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static int NoOfJpegs;

        internal static void SetLibObjects()
        {
            try
            {
                string a, b, File;
                CheckLibObjects();
                if (LibObjectsIsOn == false)
                    return;
                int Marker, N;
                LibCategories = new LibCategory[501];
                string[] IncFiles = new string[501];
                NoOfLibCategories = 0;
                int NoIncFiles = 0;
                File = LibObjectsPath + @"\objects.txt";
                FileSystem.FileOpen(2, File, OpenMode.Input);
                N = (int)FileSystem.LOF(2);
                Marker = 0;
                while (Marker < N)
                {
                    a = FileSystem.LineInput(2);
                    Marker = Marker + a.Length + 2;
                    a = a.Trim();
                    if (string.IsNullOrEmpty(a))
                        continue;
                    b = (a.Length < 8) ? "" : a.Substring(0, 8);
                    if (b == "include=")
                    {
                        NoIncFiles = NoIncFiles + 1;
                        IncFiles[NoIncFiles] = a.Substring(8);
                    }
                }

                FileSystem.FileClose();
                System.Collections.ObjectModel.ReadOnlyCollection<string> counter;
                counter = My.MyProject.Computer.FileSystem.GetFiles(LibObjectsPath + @"\NewJpegs");
                NoOfJpegs = counter.Count;
                int loopTo = NoIncFiles;
                for (N = 1; N <= loopTo; N++)
                    SetLibObjectFile(IncFiles[N]);
                if (NoOfLibCategories > 0)
                {
                    Array.Resize(ref LibCategories, NoOfLibCategories + 1);
                }

                // copy New to Old jpegs
                a = LibObjectsPath + @"\NewJpegs";
                b = LibObjectsPath + @"\BackUps\";
                foreach (string foundFile in My.MyProject.Computer.FileSystem.GetFiles(a, VB.FileIO.SearchOption.SearchAllSubDirectories, "*.*"))
                {
                    FileInfo foundFileInfo = new FileInfo(foundFile);
                    My.MyProject.Computer.FileSystem.MoveFile(foundFile, b + foundFileInfo.Name, true);
                }
            }
            catch (Exception)
            {
                FileSystem.FileClose();
                string s = "There was an error related to <objects.txt>. Library Objects were turned off.";
                MessageBox.Show(s, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LibObjectsIsOn = false;
            }
        }

        private static void SetLibObjectFile(string ThisFile)
        {
            string a, b, c, File;
            int Marker, N;
            int J;
            int M1, M2;
            string LibCatFolder = "";
            LibObject myLibObj = new LibObject();
            int NoC = NoOfLibCategories;

            try
            {
                File = LibObjectsPath + @"\" + ThisFile;
                FileSystem.FileOpen(2, File, OpenMode.Input);
                N = (int)FileSystem.LOF(2);
                Marker = 0;
                J = NoOfLibCategories;  // for the categories
                while (Marker < N)
                {
                    a = FileSystem.LineInput(2);
                    Marker = Marker + a.Length + 2;
                    a = a.Trim();
                    if (string.IsNullOrEmpty(a))
                        goto next_1;
                    b = a.Substring(0, 1);
                    if (b == "[")
                    {
                        M2 = a.Length - 2;
                        J = J + 1;
                        LibCategories[J].Name = a.Substring(1, M2);
                        LibCategories[J].Objs = new List<LibObject>();
                        LibCatFolder = Path.GetFileNameWithoutExtension(LibCategories[J].Name);
                        LibCatFolder = LibObjectsPath + @"\" + LibCatFolder;
                    }
                    else if (b != ";" & b != "i")
                    {
                        M1 = 0;
                        M2 = a.IndexOf(" ", M1);
                        myLibObj.ID = a.Substring(M1, M2 - M1);
                        M1 = M2 + 1;
                        M2 = a.IndexOf(" ", M1);
                        myLibObj.Type = Convert.ToInt32(a.Substring(M1, M2 - M1));
                        M1 = M2 + 1;
                        M2 = a.IndexOf(" ", M1);
                        myLibObj.Width = Convert.ToSingle(a.Substring(M1, M2 - M1));
                        M1 = M2 + 1;
                        M2 = a.IndexOf(" ", M1);
                        myLibObj.Length = Convert.ToSingle(a.Substring(M1, M2 - M1));
                        M1 = M2 + 1;
                        M2 = a.IndexOf(" ", M1);
                        myLibObj.Scaling = Convert.ToSingle(a.Substring(M1, M2 - M1));
                        M1 = M2 + 1;
                        myLibObj.Name = a.Substring(M1);
                        LibCategories[J].Objs.Add(myLibObj);
                        if (NoOfJpegs > 0)
                        {
                            b = LibCatFolder + @"\" + myLibObj.ID + ".jpg";
                            if (!My.MyProject.Computer.FileSystem.FileExists(b))
                            {
                                c = myLibObj.ID + "*.jpg";
                                System.Collections.ObjectModel.ReadOnlyCollection<string> myfiles = My.MyProject.Computer.FileSystem.GetFiles(LibObjectsPath + @"\NewJpegs", VB.FileIO.SearchOption.SearchAllSubDirectories, c);

                                foreach (string myfile in myfiles)
                                {
                                    My.MyProject.Computer.FileSystem.MoveFile(myfile, b, true);
                                    NoOfJpegs = NoOfJpegs - 1;
                                }
                            }
                        }
                    }

                next_1:
                    ;
                }

                FileSystem.FileClose();
                NoOfLibCategories = J;
                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose();
                NoOfLibCategories = NoC;
                a = "Could not find/process the file:" + Environment.NewLine + ThisFile;
                MessageBox.Show(a, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        internal static void SetRwy12Objects()
        {
            string a, File;
            CheckRwy12();
            if (Rwy12IsOn == false)
                return;
            NoOfRwy12Categories = 0;
            Rwy12Categories = new Rwy12Category[2];
            File = Rwy12Path + @"\add_*.xml";
            a = FileSystem.Dir(File);
            do
            {
                if (string.IsNullOrEmpty(a))
                    break;
                AddRwy12File(a);
                a = FileSystem.Dir();
            }
            while (true);
        }

        private static void AddRwy12File(string File)
        {
            string a, b;
            int M, N, Marker, K = default, L;
            FileSystem.FileOpen(2, Rwy12Path + @"\" + File, OpenMode.Input);
            N = (int)FileSystem.LOF(2);
            Marker = 0;
            while (Marker < N)
            {
                a = FileSystem.LineInput(2);
                Marker = Marker + a.Length + 2;
                a = a.Replace("\t", "");
                a = a.Trim();
                M = a.Length;
                b = (M < 15) ? "" : a.Substring(0, 15);
                if (b == "<category name=")
                {
                    NoOfRwy12Categories = NoOfRwy12Categories + 1;
                    Array.Resize(ref Rwy12Categories, NoOfRwy12Categories + 1);
                    L = a.IndexOf("\"", 16);
                    Rwy12Categories[NoOfRwy12Categories].Name = a.Substring(16, L - 16);
                    K = 1;
                }

                b = (M < 10) ? "" : a.Substring(0, 10);
                if (b == "<obj name=")
                {
                    Rwy12Categories[NoOfRwy12Categories].NOB = K;
                    Array.Resize(ref Rwy12Categories[NoOfRwy12Categories].Rwy12Objects, K + 1);
                    L = a.IndexOf("\"", 11);
                    Rwy12Categories[NoOfRwy12Categories].Rwy12Objects[K].Name = a.Substring(11, L - 11);
                    K = K + 1;
                }

                b = (M < 5) ? "" : a.Substring(0, 5);
                if (b == "guid=")
                {
                    Rwy12Categories[NoOfRwy12Categories].Rwy12Objects[K - 1].ID = a.Substring(6, 32);
                }

                b = (M < 6) ? "" : a.Substring(0, 6);
                if (b == "image=")
                {
                    L = a.IndexOf("\"", 7);
                    Rwy12Categories[NoOfRwy12Categories].Rwy12Objects[K - 1].Texture = a.Substring(7, L - 7);
                }
            }

            FileSystem.FileClose();
        }

        internal static void AnalyseLibObject(int N)
        {
            string a = "";
            int M1, M2;

            // If N = 0 Then a = RGNPointType1
            if (N > 0)
                a = Objects[N].Description;
            M1 = 0;
            M2 = a.IndexOf("|", M1);
            ObjLibID = a.Substring(M1, M2 - M1);
            if (ObjLibType == 0)
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                ObjLibScale = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                ObjLibV1 = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                if (M2 == 0)
                {
                    ObjLibV2 = Convert.ToSingle(a.Substring(M1));
                }
                else
                {
                    ObjLibV2 = Convert.ToSingle(a.Substring(M1, M2 - M1));
                    ObjComment = a.Substring(M2 + 1);
                }
            }
            else
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                if (M2 == -1)
                {
                    ObjLibScale = Convert.ToSingle(a.Substring(M1));
                }
                else
                {
                    ObjLibScale = Convert.ToSingle(a.Substring(M1, M2 - M1));
                    ObjComment = a.Substring(M2 + 1);
                }
            }
        }

        internal static void AnalyseTaxiwayObject(int N)
        {
            string a = "";
            int M1, M2;

            // If N = 0 Then a = RGNPointType1
            if (N > 0)
                a = Objects[N].Description;
            M1 = 0;
            M2 = a.IndexOf("|", M1);
            ObjTaxSize = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjTaxJust = a.Substring(M1, M2 - M1);
            M1 = M2 + 1;
            M2 = a.LastIndexOf("|");
            if (M2 == -1)
            {
                ObjTaxLabel = a.Substring(M1);
            }
            else
            {
                ObjTaxLabel = a.Substring(M1, M2 - M1);
                ObjComment = a.Substring(M2 + 1);
            }
        }

        internal static void AnalyseEffectObject(int N)
        {
            string a = "";
            int M1, M2;

            // If N = 0 Then a = RGNPointType1
            if (N > 0)
                a = Objects[N].Description;
            M1 = 0;
            M2 = a.IndexOf("|", M1);
            ObjEffName = a.Substring(M1, M2 - M1);
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            if (M2 == -1)
            {
                ObjEffParameters = a.Substring(M1);
            }
            else
            {
                ObjEffParameters = a.Substring(M1, M2 - M1);
                ObjComment = a.Substring(M2 + 1);
            }
        }

        internal static void AnalyseBeaconObject(int N)
        {
            string a = "";
            int M1, M2;

            // If N = 0 Then a = RGNPointType1
            if (N > 0)
                a = Objects[N].Description;
            M1 = 0;
            M2 = a.IndexOf("|", M1);
            ObjBeaCivil = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjBeaMil = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjBeaAirport = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjBeaSeaBase = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            if (M2 == -1)
            {
                ObjBeaHeliport = Convert.ToInt32(a.Substring(M1));
            }
            else
            {
                ObjBeaHeliport = Convert.ToInt32(a.Substring(M1, M2 - M1));
                ObjComment = a.Substring(M2 + 1);
            }
        }

        internal static void AnalyseWindsockObject(int N)
        {
            string a = "";
            int M1, M2;

            // If N = 0 Then a = RGNPointType1
            if (N > 0)
                a = Objects[N].Description;
            M1 = 0;
            M2 = a.IndexOf("|", M1);
            ObjWinLight = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjWinLength = Convert.ToSingle(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjWinHeight = Convert.ToSingle(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjWindPoleColor = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            if (M2 == -1)
            {
                ObjWindSockColor = Convert.ToInt32(a.Substring(M1));
            }
            else
            {
                ObjWindSockColor = Convert.ToInt32(a.Substring(M1, M2 - M1));
                ObjComment = a.Substring(M2 + 1);
            }
        }

        internal static void AnalyseMDLObject(int N)
        {
            string a = "";
            int M1, M2;

            // If N = 0 Then a = RGNPointType1
            if (N > 0)
                a = Objects[N].Description;
            M1 = 0;
            M2 = a.IndexOf("|", M1);
            ObjMDLFile = a.Substring(M1, M2 - M1);
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjMDLName = a.Substring(M1, M2 - M1);
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            ObjMDLScale = Convert.ToSingle(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            if (M2 == -1)
            {
                ObjMDLGuid = a.Substring(M1);
            }
            else
            {
                ObjMDLGuid = a.Substring(M1, M2 - M1);
                ObjComment = a.Substring(M2 + 1);
            }
        }

        internal static string MakeDescription(int N)
        {
            string MakeDescriptionRet = default;
            string a = "";
            if (Objects[N].Type == 1)
            {
                a = ObjLibID + "|";
                a = a + ObjLibScale.ToString().Trim() + "|";
                a = a + ObjLibV1.ToString().Trim() + "|";
                a = a + ObjLibV2.ToString().Trim() + "|" + ObjComment;
            }

            // new in FSX
            if (Objects[N].Type == 0 | Objects[N].Type == 2 | Objects[N].Type == 3)
            {
                a = ObjLibID + "|";
                a = a + ObjLibScale.ToString().Trim() + "|" + ObjComment;
            }

            if (Objects[N].Type == 4)
            {
                a = moduleMACROS.MacroID + "|Range=";
                a = a + moduleMACROS.MacroRange.ToString() + ",Scale=";
                a = a + moduleMACROS.MacroScale.ToString().Trim() + ",P6=";
                a = a + moduleMACROS.MacroP6Value + ",P7=";
                a = a + moduleMACROS.MacroP7Value + ",P8=";
                a = a + moduleMACROS.MacroP8Value + ",P9=";
                a = a + moduleMACROS.MacroP9Value + ",V1=";
                a = a + moduleMACROS.MacroVisibility.ToString().Trim() + ",V2=";
                a = a + moduleMACROS.MacroV2Value.ToString().Trim() + ",|";
                a = a + ObjComment;
            }

            if (Objects[N].Type == 5)
            {
                a = moduleMACROS.MacroID + "|";
                a = a + "Range=" + moduleMACROS.MacroRange.ToString();
                a = a + ",Scale=" + moduleMACROS.MacroScale.ToString().Trim();
                a = a + ",V1=" + moduleMACROS.MacroVisibility.ToString().Trim() + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroP6Name))
                    a = a + moduleMACROS.MacroP6Name + "=" + moduleMACROS.MacroP6Value + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroP7Name))
                    a = a + moduleMACROS.MacroP7Name + "=" + moduleMACROS.MacroP7Value + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroP8Name))
                    a = a + moduleMACROS.MacroP8Name + "=" + moduleMACROS.MacroP8Value + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroP9Name))
                    a = a + moduleMACROS.MacroP9Name + "=" + moduleMACROS.MacroP9Value + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroPAName))
                    a = a + moduleMACROS.MacroPAName + "=" + moduleMACROS.MacroPAValue + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroPBName))
                    a = a + moduleMACROS.MacroPBName + "=" + moduleMACROS.MacroPBValue + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroPCName))
                    a = a + moduleMACROS.MacroPCName + "=" + moduleMACROS.MacroPCValue + ",";
                if (!string.IsNullOrEmpty(moduleMACROS.MacroPDName))
                    a = a + moduleMACROS.MacroPDName + "=" + moduleMACROS.MacroPDValue + ",";
                a = a + "|" + ObjComment;
            }

            if (Objects[N].Type == 8)
            {
                a = ObjTaxSize.ToString() + "|";
                a = a + ObjTaxJust + "|";
                a = a + ObjTaxLabel + "|" + ObjComment;
            }

            if (Objects[N].Type == 16)
            {
                a = ObjEffName + "|";
                a = a + ObjEffParameters + "|" + ObjComment;
            }

            if (Objects[N].Type == 32)
            {
                a = ObjBeaCivil.ToString() + "|";
                a = a + ObjBeaMil.ToString() + "|";
                a = a + ObjBeaAirport.ToString() + "|";
                a = a + ObjBeaSeaBase.ToString() + "|";
                a = a + ObjBeaHeliport.ToString() + "|" + ObjComment;
            }

            if (Objects[N].Type == 64)
            {
                a = ObjWinLight.ToString() + "|";
                a = a + ObjWinLength.ToString().Trim() + "|";
                a = a + ObjWinHeight.ToString().Trim() + "|";
                a = a + ObjWindPoleColor.ToString() + "|";
                a = a + ObjWindSockColor.ToString() + "|" + ObjComment;
            }

            if (Objects[N].Type == 128 | Objects[N].Type == 129)
            {
                a = ObjMDLFile + "|";
                a = a + ObjMDLName + "|";
                a = a + ObjMDLScale.ToString() + "|";
                a = a + ObjMDLGuid + "|" + ObjComment;
            }

            if (Objects[N].Type > 255)
            {
                a = scale_gb.ToString().Trim() + "|" + MakeGBTextures() + "|" + MakeGBIndexes(Objects[N].Type) + "|" + ObjComment;
            }

            MakeDescriptionRet = a;
            return MakeDescriptionRet;
        }

        internal static void MakeBGLObjects(bool CopyBGLs)
        {
            double H_NLat; // header borders
            double H_SLat; // header borders
            double H_WLon; // header borders
            double H_ELon; // header borders
            int N, TaxCount;
            double lat, lon, alt;
            double TaxLat, TaxLon, TaxAlt;
            string Latitude, Longitude;
            string Altitude, AGL;
            string Pitch, Heading, Bank;
            double BiasY, BiasX, BiasZ;
            string Complex;
            string V1, V2;
            string a, b;
            bool FS8, FS9, FSX, FS9xml;
            string BGLFile0 = "";
            string BGLFile1 = "";
            string BGLFile2 = "";
            string BGLFile3 = "";
            string lbNext;
            string lbRet;
            string lbPcall;
            string lbStart;
            string File3 = "";
            string File2 = "";
            string File1 = "";
            string File0 = "";
            H_NLat = -90;
            H_SLat = 90d;
            H_WLon = 180d;
            H_ELon = -180;
            TaxCount = 0;
            TaxLat = 0d;
            TaxLon = 0d;
            TaxAlt = 0d;
            FS8 = false;
            FS9 = false;
            FS9xml = false;
            FSX = false;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if (Objects[N].Selected)
                {
                    if (Objects[N].Type == 1 | Objects[N].Type == 4 | Objects[N].Type == 5)
                    {
                        lat = Objects[N].lat;
                        lon = Objects[N].lon;
                        if (lon > H_ELon)
                            H_ELon = lon;
                        if (lon < H_WLon)
                            H_WLon = lon;
                        if (lat > H_NLat)
                            H_NLat = lat;
                        if (lat < H_SLat)
                            H_SLat = lat;
                        FS8 = true;
                    }
                    else if (Objects[N].Type == 0 | Objects[N].Type == 16 | Objects[N].Type == 32 | Objects[N].Type == 64 | Objects[N].Type == 128 | Objects[N].Type > 255)
                    {
                        FSX = true;
                    }
                    else if (Objects[N].Type == 2 | Objects[N].Type == 3)
                    {
                        FS9 = true;
                    }
                    else if (Objects[N].Type == 129)
                    {
                        FS9xml = true;
                    }
                    else if (Objects[N].Type == 8)
                    {
                        lat = Objects[N].lat;
                        lon = Objects[N].lon;
                        alt = Objects[N].Altitude;
                        TaxCount = TaxCount + 1;
                        TaxLat = TaxLat + lat;
                        TaxLon = TaxLon + lon;
                        TaxAlt = TaxAlt + alt;
                        FSX = true;
                    }
                }
            }

            if (TaxCount > 0)
            {
                TaxLat = TaxLat / TaxCount;
                TaxLon = TaxLon / TaxCount;
                TaxAlt = TaxAlt / TaxCount;
            }

            if (FSX)
            {
                File2 = moduleMAIN.ProjectName + "_OBX";
                File2 = File2.Replace(" ", "_");
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File2 + ".xml";
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Indent = true,
                    Encoding = Encoding.GetEncoding(28591),
                    NewLineOnAttributes = true
                };
                XmlWriter writer = XmlWriter.Create(a, settings);
                writer.WriteStartDocument();
                writer.WriteComment("Created by SBuilderX on " + DateTime.Now);
                writer.WriteStartElement("FSData");
                writer.WriteAttributeString("version", "9.0");
                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "bglcomp.xsd");
                writer.WriteComment("FSX library objects");
                int loopTo1 = NoOfObjects;
                for (N = 1; N <= loopTo1; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 0)
                        {
                            ObjLibType = 2;
                            AnalyseLibObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            writer.WriteComment(ObjComment);
                            writer.WriteStartElement("SceneryObject");
                            writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                            writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                            writer.WriteAttributeString("alt", Objects[N].Altitude.ToString().Trim());
                            writer.WriteAttributeString("altitudeIsAgl", GetTR(Objects[N].AGL));
                            writer.WriteAttributeString("pitch", Objects[N].Pitch.ToString().Trim());
                            writer.WriteAttributeString("bank", Objects[N].Bank.ToString().Trim());
                            writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                            writer.WriteAttributeString("imageComplexity", GetComplex(Objects[N].Complexity));
                            BiasX = Objects[N].BiasX;
                            BiasY = Objects[N].BiasY;
                            BiasZ = Objects[N].BiasZ;
                            if (BiasX != 0d | BiasY != 0d | BiasZ != 0d)
                            {
                                writer.WriteStartElement("BiasXYZ");
                                writer.WriteAttributeString("biasX", BiasX.ToString().Trim());
                                writer.WriteAttributeString("biasY", BiasY.ToString().Trim());
                                writer.WriteAttributeString("biasZ", BiasZ.ToString().Trim());
                                writer.WriteEndElement();
                            }

                            writer.WriteStartElement("LibraryObject");
                            writer.WriteAttributeString("name", ObjLibID);
                            writer.WriteAttributeString("scale", ObjLibScale.ToString().Trim());
                            writer.WriteEndElement();
                            writer.WriteFullEndElement();
                        }
                    }
                }

                writer.WriteComment("FSX Windsock objects");
                int loopTo2 = NoOfObjects;
                for (N = 1; N <= loopTo2; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 64)
                        {
                            AnalyseWindsockObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            writer.WriteComment(ObjComment);
                            writer.WriteStartElement("SceneryObject");
                            writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                            writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                            writer.WriteAttributeString("alt", Objects[N].Altitude.ToString().Trim());
                            writer.WriteAttributeString("altitudeIsAgl", GetTR(Objects[N].AGL));
                            writer.WriteAttributeString("pitch", Objects[N].Pitch.ToString().Trim());
                            writer.WriteAttributeString("bank", Objects[N].Bank.ToString().Trim());
                            writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                            writer.WriteAttributeString("imageComplexity", GetComplex(Objects[N].Complexity));
                            BiasX = Objects[N].BiasX;
                            BiasY = Objects[N].BiasY;
                            BiasZ = Objects[N].BiasZ;
                            if (BiasX != 0d | BiasY != 0d | BiasZ != 0d)
                            {
                                writer.WriteStartElement("BiasXYZ");
                                writer.WriteAttributeString("biasX", BiasX.ToString().Trim());
                                writer.WriteAttributeString("biasY", BiasY.ToString().Trim());
                                writer.WriteAttributeString("biasZ", BiasZ.ToString().Trim());
                                writer.WriteEndElement();
                            }

                            writer.WriteStartElement("Windsock");
                            writer.WriteAttributeString("poleHeight", ObjWinHeight.ToString().Trim());
                            writer.WriteAttributeString("sockLength", ObjWinLength.ToString().Trim());
                            writer.WriteAttributeString("lighted", GetTR(ObjWinLight));
                            writer.WriteStartElement("PoleColor");
                            writer.WriteAttributeString("red", RedFromInteger(ObjWindPoleColor).ToString().Trim());
                            writer.WriteAttributeString("blue", BlueFromInteger(ObjWindPoleColor).ToString().Trim());
                            writer.WriteAttributeString("green", GreenFromInteger(ObjWindPoleColor).ToString().Trim());
                            writer.WriteEndElement();
                            writer.WriteStartElement("SockColor");
                            writer.WriteAttributeString("red", RedFromInteger(ObjWindSockColor).ToString().Trim());
                            writer.WriteAttributeString("blue", BlueFromInteger(ObjWindSockColor).ToString().Trim());
                            writer.WriteAttributeString("green", GreenFromInteger(ObjWindSockColor).ToString().Trim());
                            writer.WriteEndElement();
                            writer.WriteFullEndElement();
                            writer.WriteFullEndElement();
                        }
                    }
                }

                writer.WriteComment("FSX Effect objects");
                int loopTo3 = NoOfObjects;
                for (N = 1; N <= loopTo3; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 16)
                        {
                            AnalyseEffectObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            writer.WriteComment(ObjComment);
                            writer.WriteStartElement("SceneryObject");
                            writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                            writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                            writer.WriteAttributeString("alt", Objects[N].Altitude.ToString().Trim());
                            writer.WriteAttributeString("altitudeIsAgl", GetTR(Objects[N].AGL));
                            writer.WriteAttributeString("pitch", Objects[N].Pitch.ToString().Trim());
                            writer.WriteAttributeString("bank", Objects[N].Bank.ToString().Trim());
                            writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                            writer.WriteAttributeString("imageComplexity", GetComplex(Objects[N].Complexity));
                            BiasX = Objects[N].BiasX;
                            BiasY = Objects[N].BiasY;
                            BiasZ = Objects[N].BiasZ;
                            if (BiasX != 0d | BiasY != 0d | BiasZ != 0d)
                            {
                                writer.WriteStartElement("BiasXYZ");
                                writer.WriteAttributeString("biasX", BiasX.ToString().Trim());
                                writer.WriteAttributeString("biasY", BiasY.ToString().Trim());
                                writer.WriteAttributeString("biasZ", BiasZ.ToString().Trim());
                                writer.WriteEndElement();
                            }

                            writer.WriteStartElement("Effect");
                            writer.WriteAttributeString("effectName", ObjEffName.Trim());
                            writer.WriteAttributeString("effectParams", ObjEffParameters.Trim());
                            writer.WriteEndElement();
                            writer.WriteFullEndElement();
                        }
                    }
                }

                if (TaxCount > 0)
                {
                    writer.WriteComment("FSX TaxiwaySign objects");
                    writer.WriteStartElement("Airport");
                    writer.WriteAttributeString("lat", TaxLat.ToString().Trim());
                    writer.WriteAttributeString("lon", TaxLon.ToString().Trim());
                    writer.WriteAttributeString("alt", TaxAlt.ToString().Trim());
                    writer.WriteAttributeString("ident", "AAAA");
                    int loopTo4 = NoOfObjects;
                    for (N = 1; N <= loopTo4; N++)
                    {
                        if (Objects[N].Selected)
                        {
                            if (Objects[N].Type == 8)
                            {
                                AnalyseTaxiwayObject(N);
                                ObjComment = ObjComment + "_Obj_" + N.ToString();
                                writer.WriteComment(ObjComment);
                                writer.WriteStartElement("TaxiwaySign");
                                writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                                writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                                writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                                writer.WriteAttributeString("label", ObjTaxLabel.Trim());
                                writer.WriteAttributeString("size", "SIZE" + ObjTaxSize.ToString().Trim());
                                writer.WriteAttributeString("justification", ObjTaxJust.Trim().ToUpper());
                                writer.WriteEndElement();
                            }
                        }
                    }

                    writer.WriteFullEndElement();
                }

                writer.WriteComment("FSX Model objects");
                int loopTo5 = NoOfObjects;
                for (N = 1; N <= loopTo5; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 128)
                        {
                            AnalyseMDLObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            writer.WriteComment(ObjComment);
                            writer.WriteStartElement("SceneryObject");
                            writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                            writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                            writer.WriteAttributeString("alt", Objects[N].Altitude.ToString().Trim());
                            writer.WriteAttributeString("altitudeIsAgl", GetTR(Objects[N].AGL));
                            writer.WriteAttributeString("pitch", Objects[N].Pitch.ToString().Trim());
                            writer.WriteAttributeString("bank", Objects[N].Bank.ToString().Trim());
                            writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                            writer.WriteAttributeString("imageComplexity", GetComplex(Objects[N].Complexity));
                            writer.WriteStartElement("LibraryObject");
                            writer.WriteAttributeString("name", ObjMDLGuid);
                            writer.WriteAttributeString("scale", ObjMDLScale.ToString().Trim());
                            writer.WriteEndElement();
                            writer.WriteFullEndElement();
                            writer.WriteStartElement("ModelData");
                            writer.WriteAttributeString("sourceFile", @"..\..\Mdls\" + ObjMDLFile);
                            writer.WriteEndElement();
                        }
                    }
                }

                writer.WriteComment("FSX Beacon objects");
                int loopTo6 = NoOfObjects;
                for (N = 1; N <= loopTo6; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 32)
                        {
                            AnalyseBeaconObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            writer.WriteComment(ObjComment);
                            writer.WriteStartElement("SceneryObject");
                            writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                            writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                            writer.WriteAttributeString("alt", Objects[N].Altitude.ToString().Trim());
                            writer.WriteAttributeString("altitudeIsAgl", GetTR(Objects[N].AGL));
                            writer.WriteAttributeString("pitch", Objects[N].Pitch.ToString().Trim());
                            writer.WriteAttributeString("bank", Objects[N].Bank.ToString().Trim());
                            writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                            writer.WriteAttributeString("imageComplexity", GetComplex(Objects[N].Complexity));
                            writer.WriteStartElement("Beacon");
                            writer.WriteAttributeString("type", GetBeaconType());
                            writer.WriteAttributeString("baseType", GetBeaconBaseType());
                            writer.WriteEndElement();
                            writer.WriteFullEndElement();
                        }
                    }
                }

                writer.WriteComment("FSX General Buildings");
                int loopTo7 = NoOfObjects;
                for (N = 1; N <= loopTo7; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type > 255)
                        {
                            AnalyseGenBObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            writer.WriteComment(ObjComment);
                            writer.WriteStartElement("SceneryObject");
                            writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                            writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                            writer.WriteAttributeString("alt", Objects[N].Altitude.ToString().Trim());
                            writer.WriteAttributeString("altitudeIsAgl", GetTR(Objects[N].AGL));
                            writer.WriteAttributeString("pitch", Objects[N].Pitch.ToString().Trim());
                            writer.WriteAttributeString("bank", Objects[N].Bank.ToString().Trim());
                            writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                            writer.WriteAttributeString("imageComplexity", GetComplex(Objects[N].Complexity));
                            BiasX = Objects[N].BiasX;
                            BiasY = Objects[N].BiasY;
                            BiasZ = Objects[N].BiasZ;
                            if (BiasX != 0d | BiasY != 0d | BiasZ != 0d)
                            {
                                writer.WriteStartElement("BiasXYZ");
                                writer.WriteAttributeString("biasX", BiasX.ToString().Trim());
                                writer.WriteAttributeString("biasY", BiasY.ToString().Trim());
                                writer.WriteAttributeString("biasZ", BiasZ.ToString().Trim());
                                writer.WriteEndElement();
                            }

                            writer.WriteStartElement("GenericBuilding");
                            writer.WriteAttributeString("scale", scale_gb.ToString().Trim());
                            writer.WriteAttributeString("bottomTexture", bottomTexture.ToString().Trim());
                            writer.WriteAttributeString("roofTexture", roofTexture.ToString().Trim());
                            writer.WriteAttributeString("topTexture", topTexture.ToString().Trim());
                            writer.WriteAttributeString("windowTexture", windowTexture.ToString().Trim());
                            if (Objects[N].Type == 256)
                            {
                                writer.WriteStartElement("RectangularBuilding");
                                writer.WriteAttributeString("roofType", "FLAT");
                            }

                            if (Objects[N].Type == 257)
                            {
                                writer.WriteStartElement("RectangularBuilding");
                                writer.WriteAttributeString("roofType", "PEAKED");
                            }

                            if (Objects[N].Type == 258)
                            {
                                writer.WriteStartElement("RectangularBuilding");
                                writer.WriteAttributeString("roofType", "RIDGE");
                            }

                            if (Objects[N].Type == 259)
                            {
                                writer.WriteStartElement("RectangularBuilding");
                                writer.WriteAttributeString("roofType", "SLANT");
                            }

                            if (Objects[N].Type == 260)
                            {
                                writer.WriteStartElement("PyramidalBuilding");
                            }

                            if (Objects[N].Type == 261)
                            {
                                writer.WriteStartElement("MultiSidedBuilding");
                            }

                            if (Objects[N].Type == 256 | Objects[N].Type == 257 | Objects[N].Type == 258 | Objects[N].Type == 259)
                            // Rect flat
                            {
                                writer.WriteAttributeString("sizeX", Objects[N].Width.ToString().Trim());
                                writer.WriteAttributeString("sizeZ", Objects[N].Length.ToString().Trim());
                                writer.WriteAttributeString("sizeBottomY", sizeBottomY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexBottomX", textureIndexBottomX.ToString());
                                writer.WriteAttributeString("textureIndexBottomZ", textureIndexBottomZ.ToString());
                                writer.WriteAttributeString("sizeWindowY", sizeWindowY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexWindowX", textureIndexWindowX.ToString());
                                writer.WriteAttributeString("textureIndexWindowY", textureIndexWindowY.ToString());
                                writer.WriteAttributeString("textureIndexWindowZ", textureIndexWindowZ.ToString());
                                writer.WriteAttributeString("sizeTopY", sizeTopY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexTopX", textureIndexTopX.ToString());
                                writer.WriteAttributeString("textureIndexTopZ", textureIndexTopZ.ToString());
                                writer.WriteAttributeString("textureIndexRoofX", textureIndexRoofX.ToString());
                                writer.WriteAttributeString("textureIndexRoofZ", textureIndexRoofZ.ToString());
                            }

                            if (Objects[N].Type == 257)  // Rect peaked
                            {
                                writer.WriteAttributeString("sizeRoofY", sizeRoofY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexRoofY", textureIndexRoofY.ToString());
                            }

                            if (Objects[N].Type == 258)  // Rect Ridge
                            {
                                writer.WriteAttributeString("sizeRoofY", sizeRoofY.ToString().Trim());
                                writer.WriteAttributeString("gableTexture", gableTexture.ToString());
                                writer.WriteAttributeString("textureIndexGableY", textureIndexGableY.ToString());
                                writer.WriteAttributeString("textureIndexGableZ", textureIndexGableZ.ToString());
                            }

                            if (Objects[N].Type == 259)  // Rect slant
                            {
                                writer.WriteAttributeString("sizeRoofY", sizeRoofY.ToString().Trim());
                                writer.WriteAttributeString("gableTexture", gableTexture.ToString());
                                writer.WriteAttributeString("textureIndexGableY", textureIndexGableY.ToString());
                                writer.WriteAttributeString("textureIndexGableZ", textureIndexGableZ.ToString());
                                writer.WriteAttributeString("faceTexture", faceTexture.ToString());
                                writer.WriteAttributeString("textureIndexFaceX", textureIndexFaceX.ToString());
                                writer.WriteAttributeString("textureIndexFaceY", textureIndexFaceY.ToString());
                            }

                            if (Objects[N].Type == 260)  // pyramidal
                            {
                                writer.WriteAttributeString("sizeX", Objects[N].Width.ToString().Trim());
                                writer.WriteAttributeString("sizeZ", Objects[N].Length.ToString().Trim());
                                writer.WriteAttributeString("sizeTopX", sizeTopX.ToString().Trim());
                                writer.WriteAttributeString("sizeTopZ", sizeTopZ.ToString().Trim());
                                writer.WriteAttributeString("sizeBottomY", sizeBottomY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexBottomX", textureIndexBottomX.ToString());
                                writer.WriteAttributeString("textureIndexBottomZ", textureIndexBottomZ.ToString());
                                writer.WriteAttributeString("sizeWindowY", sizeWindowY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexWindowX", textureIndexWindowX.ToString());
                                writer.WriteAttributeString("textureIndexWindowY", textureIndexWindowY.ToString());
                                writer.WriteAttributeString("textureIndexWindowZ", textureIndexWindowZ.ToString());
                                writer.WriteAttributeString("sizeTopY", sizeTopY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexTopX", textureIndexTopX.ToString());
                                writer.WriteAttributeString("textureIndexTopZ", textureIndexTopZ.ToString());
                                writer.WriteAttributeString("textureIndexRoofX", textureIndexRoofX.ToString());
                                writer.WriteAttributeString("textureIndexRoofZ", textureIndexRoofZ.ToString());
                            }

                            if (Objects[N].Type == 261) // multi sided
                            {
                                writer.WriteAttributeString("buildingSides", buildingSides.ToString());
                                writer.WriteAttributeString("smoothing", smoothing.ToString().ToUpper());
                                writer.WriteAttributeString("sizeX", Objects[N].Width.ToString().Trim());
                                writer.WriteAttributeString("sizeZ", Objects[N].Length.ToString().Trim());
                                writer.WriteAttributeString("sizeBottomY", sizeBottomY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexBottomX", textureIndexBottomX.ToString());
                                writer.WriteAttributeString("sizeWindowY", sizeWindowY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexWindowX", textureIndexWindowX.ToString());
                                writer.WriteAttributeString("textureIndexWindowY", textureIndexWindowY.ToString());
                                writer.WriteAttributeString("sizeTopY", sizeTopY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexTopX", textureIndexTopX.ToString());
                                writer.WriteAttributeString("sizeRoofY", sizeRoofY.ToString().Trim());
                                writer.WriteAttributeString("textureIndexRoofX", textureIndexRoofX.ToString());
                                writer.WriteAttributeString("textureIndexRoofY", textureIndexRoofY.ToString());
                                writer.WriteAttributeString("textureIndexRoofZ", textureIndexRoofZ.ToString());
                            }

                            writer.WriteEndElement();
                            writer.WriteFullEndElement();
                            writer.WriteFullEndElement();
                        }
                    }
                }

                writer.WriteFullEndElement();
                writer.Close();

                // delete BGL File2
                BGLFile2 = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File2 + ".BGL";
                if (File.Exists(BGLFile2))
                    File.Delete(BGLFile2);
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bglcomp.exe";
                b = @"work\" + File2 + ".xml";
                Process myProcess = new Process();
                myProcess = Process.Start(a, b);
                myProcess.WaitForExit();
                myProcess.Dispose();
                if (!File.Exists(BGLFile2))
                {
                    a = "BGLComp could not produce the file" + Environment.NewLine + BGLFile2 + Environment.NewLine;
                    a = a + @"Try to compile the file ..\tools\" + b + " in a MSDOS window" + Environment.NewLine;
                    a = a + "to read the error report!";
                    MessageBox.Show(a, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if (FS9xml)
            {
                File3 = moduleMAIN.ProjectName + "_OB1X";
                File3 = File3.Replace(" ", "_");
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File3 + ".xml";
                XmlWriterSettings settings = new XmlWriterSettings()
                {
                    Indent = true,
                    Encoding = Encoding.GetEncoding(28591),
                    NewLineOnAttributes = true
                };
                XmlWriter writer = XmlWriter.Create(a, settings);
                writer.WriteStartDocument();
                writer.WriteComment("Created by SBuilderX on " + DateTime.Now);
                writer.WriteStartElement("FSData");
                writer.WriteAttributeString("version", "9.0");
                writer.WriteAttributeString("xmlns", "xsi", null, "http://www.w3.org/2001/XMLSchema-instance");
                writer.WriteAttributeString("noNamespaceSchemaLocation", "http://www.w3.org/2001/XMLSchema-instance", "bglcomp.xsd");
                writer.WriteComment("FS9 Model objects - to be compiled by FS9 BGLComp");
                int loopTo8 = NoOfObjects;
                for (N = 1; N <= loopTo8; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 129)
                        {
                            AnalyseMDLObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            writer.WriteComment(ObjComment);
                            writer.WriteStartElement("SceneryObject");
                            writer.WriteAttributeString("lat", Objects[N].lat.ToString().Trim());
                            writer.WriteAttributeString("lon", Objects[N].lon.ToString().Trim());
                            writer.WriteAttributeString("alt", Objects[N].Altitude.ToString().Trim());
                            writer.WriteAttributeString("altitudeIsAgl", GetTR(Objects[N].AGL));
                            writer.WriteAttributeString("pitch", Objects[N].Pitch.ToString().Trim());
                            writer.WriteAttributeString("bank", Objects[N].Bank.ToString().Trim());
                            writer.WriteAttributeString("heading", Objects[N].Heading.ToString().Trim());
                            writer.WriteAttributeString("imageComplexity", GetComplex(Objects[N].Complexity));
                            writer.WriteStartElement("LibraryObject");
                            writer.WriteAttributeString("name", ObjMDLGuid);
                            writer.WriteAttributeString("scale", ObjMDLScale.ToString().Trim());
                            writer.WriteEndElement();
                            writer.WriteFullEndElement();
                            writer.WriteStartElement("ModelData");
                            writer.WriteAttributeString("name", ObjMDLGuid);
                            writer.WriteAttributeString("sourceFile", @"..\..\Mdls\" + ObjMDLFile);
                            writer.WriteEndElement();
                        }
                    }
                }

                writer.WriteFullEndElement();
                writer.Close();

                // delete BGL File3
                BGLFile3 = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File3 + ".BGL";
                if (File.Exists(BGLFile3))
                    File.Delete(BGLFile3);
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bglcom9.exe"; // NOTE THE NAME!
                b = @"work\" + File3 + ".xml";
                Process myProcess = new Process();
                myProcess = Process.Start(a, b);
                myProcess.WaitForExit();
                myProcess.Dispose();
            }

            if (FS9)
            {
                File1 = moduleMAIN.ProjectName + "_OB1";
                File1 = File1.Replace(" ", "_");
                FileSystem.FileOpen(3, My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File1 + ".scm", OpenMode.Output);
                a = "Header( 0x201 )";
                FileSystem.PrintLine(3, a);
                FileSystem.PrintLine(3);
                a = "; FS9 objects";
                int loopTo9 = NoOfObjects;
                for (N = 1; N <= loopTo9; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 2 | Objects[N].Type == 3)
                        {
                            lat = Objects[N].lat;
                            lon = Objects[N].lon;
                            alt = Objects[N].Altitude;
                            BiasX = Objects[N].BiasX;
                            BiasY = Objects[N].BiasY;
                            BiasZ = Objects[N].BiasZ;
                            alt = alt + BiasZ;
                            if (BiasX != 0d | BiasY != 0d)
                            {
                                lon = lon + BiasX / moduleMAIN.MetersPerDegLon(lat);
                                lat = lat + BiasY / moduleMAIN.MetersPerDegLat;
                            }

                            Latitude = lat.ToString("0.00000000");
                            Longitude = lon.ToString("0.00000000");
                            Altitude = alt.ToString("0.000");
                            AGL = Objects[N].AGL.ToString().Trim();
                            Heading = Objects[N].Heading.ToString("0.000");
                            Pitch = Objects[N].Pitch.ToString("0.000");
                            Bank = Objects[N].Bank.ToString("0.000");
                            Complex = Objects[N].Complexity.ToString().Trim();
                            Latitude = Latitude.Replace(",", ".");
                            Longitude = Longitude.Replace(",", ".");
                            Altitude = Altitude.Replace(",", ".");
                            Heading = Heading.Replace(",", ".");
                            Pitch = Pitch.Replace(",", ".");
                            Bank = Bank.Replace(",", ".");
                            ObjLibType = 1;
                            AnalyseLibObject(N);
                            ObjComment = ObjComment + "_Obj_" + N.ToString();
                            a = "; Library_Object_" + ObjComment + Environment.NewLine;
                            a = a + "LibraryObject( " + Latitude + " " + Longitude + " " + Altitude + " " + AGL;
                            FileSystem.PrintLine(3, a);
                            a = "               " + Pitch + " " + Bank + " " + Heading + " " + Complex + "  " + FixLibID(ObjLibID) + " " + ObjLibScale.ToString() + " )";
                            FileSystem.PrintLine(3, a);
                        }
                    }
                }

                FileSystem.PrintLine(3);
                FileSystem.FileClose(3);

                // delete BGL File1
                BGLFile1 = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File1 + ".BGL";
                if (File.Exists(BGLFile1))
                    File.Delete(BGLFile1);
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
                a = @"scasm work\" + File1 + ".scm -s -l";
                N = moduleMAIN.ExecCmd(a);
                if (N > 0)
                {
                    a = "There was a compilation error in this project!" + Environment.NewLine;
                    a = a + "Do you want to read a SCASM report?";
                    DialogResult dr = MessageBox.Show(a, "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (dr == DialogResult.OK)
                    {
                        a = "notepad SCAERROR.LOG";
                        N = moduleMAIN.ExecCmd(a);
                    }

                    return;
                }
            } // FS9!!!

            if (FS8)
            {
                File0 = moduleMAIN.ProjectName + "_OB0";
                File0 = File0.Replace(" ", "_");
                FileSystem.FileOpen(3, My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File0 + ".scm", OpenMode.Output);
                a = "Header( 1 ";
                a = a + (int)(H_NLat + 1.5d) + " ";
                a = a + (int)(H_SLat - 0.5d) + " ";
                a = a + (int)(H_ELon + 1.5d) + " ";
                a = a + (int)(H_WLon - 0.5d) + " )";
                FileSystem.PrintLine(3, a);
                a = "LatRange( ";
                a = a + (int)(H_SLat - 0.5d) + " ";
                a = a + (int)(H_NLat + 1.5d) + " )";
                FileSystem.PrintLine(3, a);
                FileSystem.PrintLine(3);
                int loopTo10 = NoOfObjects;
                for (N = 1; N <= loopTo10; N++)
                {
                    if (Objects[N].Selected)
                    {
                        if (Objects[N].Type == 1)
                        {
                            lbNext = ":next_" + N.ToString().Trim();
                            lbRet = ":return_" + N.ToString().Trim();
                            lbPcall = ":pcall_" + N.ToString().Trim();
                            lbStart = ":start_" + N.ToString().Trim();
                            lat = Objects[N].lat;
                            lon = Objects[N].lon;
                            alt = Objects[N].Altitude;
                            BiasX = Objects[N].BiasX;
                            BiasY = Objects[N].BiasY;
                            BiasZ = Objects[N].BiasZ;
                            alt = alt + BiasZ;
                            if (BiasX != 0d | BiasY != 0d)
                            {
                                lon = lon + BiasX / moduleMAIN.MetersPerDegLon(lat);
                                lat = lat + BiasY / moduleMAIN.MetersPerDegLat;
                            }

                            Latitude = lat.ToString("0.00000000");
                            Longitude = lon.ToString("0.00000000");
                            Altitude = alt.ToString("0.000");
                            AGL = Objects[N].AGL.ToString().Trim();
                            Heading = Objects[N].Heading.ToString("0.000");
                            Pitch = Objects[N].Pitch.ToString("0.000");
                            Bank = Objects[N].Bank.ToString("0.000");
                            Latitude = Latitude.Replace(",", ".");
                            Longitude = Longitude.Replace(",", ".");
                            Altitude = Altitude.Replace(",", ".");
                            Heading = Heading.Replace(",", ".");
                            Pitch = Pitch.Replace(",", ".");
                            Bank = Bank.Replace(",", ".");
                            Complex = Objects[N].Complexity.ToString().Trim();
                            ObjLibType = 0;
                            AnalyseLibObject(N);
                            V1 = ObjLibV1.ToString().Trim();
                            V2 = ObjLibV2.ToString().Trim();
                            if (string.IsNullOrEmpty(ObjComment))
                                ObjComment = "Object # " + N.ToString();
                            a = "; " + ObjComment + Environment.NewLine;
                            a = a + "Area( 5 ";
                            a = a + Latitude + " " + Longitude + " 50 )";
                            FileSystem.PrintLine(3, a);
                            a = "IfVarRange( " + lbNext + " 346 " + Complex + " 5 )";
                            FileSystem.PrintLine(3, a);
                            a = "PerspectiveCall( " + lbPcall + " )";
                            FileSystem.PrintLine(3, a);
                            a = "Jump( " + lbNext + " )";
                            FileSystem.PrintLine(3, a);
                            a = lbPcall;
                            FileSystem.PrintLine(3, a);
                            a = "Perspective";
                            FileSystem.PrintLine(3, a);
                            if (AGL == "1")
                            {
                                a = "RefPoint( 7 " + lbRet + " 1 " + Latitude + " " + Longitude;
                                a = a + " v1= " + V1 + " v2= " + V2 + " )";
                                FileSystem.PrintLine(3, a);
                            }
                            else
                            {
                                a = "RefPoint( 2 " + lbRet + " 1 " + Latitude + " " + Longitude;
                                a = a + " E= " + Altitude + " v1= " + V1 + " v2= " + V2 + " )";
                                FileSystem.PrintLine(3, a);
                            }

                            if (ObjLibScale != 1f)
                            {
                                a = "SetScale( " + lbRet + " 0 0 " + ObjLibScale + " )";
                                FileSystem.PrintLine(3, a);
                            }

                            a = "RotatedCall( " + lbStart + " 0 0 " + Heading + " )";
                            FileSystem.PrintLine(3, a);
                            a = lbRet;
                            FileSystem.PrintLine(3, a);
                            a = "Return";
                            FileSystem.PrintLine(3, a);
                            a = lbStart;
                            FileSystem.PrintLine(3, a);
                            a = "CallLibObj( 0 " + FixLibID(ObjLibID) + " )";
                            FileSystem.PrintLine(3, a);
                            a = "Return";
                            FileSystem.PrintLine(3, a);
                            a = lbNext;
                            FileSystem.PrintLine(3, a);
                            a = "EndA";
                            FileSystem.PrintLine(3, a);
                            FileSystem.PrintLine(3);
                        }

                        if (Objects[N].Type == 4) // API macros"
                        {
                            moduleMACROS.AnalyseAPIMacro(N);
                            if (string.IsNullOrEmpty(ObjComment))
                                ObjComment = "Object # " + N.ToString();
                            a = "; " + ObjComment;
                            FileSystem.PrintLine(3, a);
                            if (moduleMACROS.MacroID == "AREAEND.API")
                            {
                                a = "EndA";
                            }
                            else
                            {
                                a = PackAPIMacro(N);
                            }

                            FileSystem.PrintLine(3, a);
                            FileSystem.PrintLine(3);
                        }

                        if (Objects[N].Type == 5) // ASD macros"
                        {
                            moduleMACROS.AnalyseASDMacro(N);
                            if (string.IsNullOrEmpty(ObjComment))
                                ObjComment = "Object # " + N.ToString();
                            a = "; " + ObjComment;
                            FileSystem.PrintLine(3, a);
                            if (moduleMACROS.MacroID == "AREAEND.SCM")
                            {
                                a = "EndA";
                            }
                            else
                            {
                                a = PackASDMacro(N);
                            }

                            FileSystem.PrintLine(3, a);
                            FileSystem.PrintLine(3);
                        }
                    }
                }

                FileSystem.FileClose(3);

                // delete BGL File0
                BGLFile0 = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + File0 + ".BGL";
                if (File.Exists(BGLFile0))
                    File.Delete(BGLFile0);
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
                a = @"scasm work\" + File0 + ".scm -s -l";
                N = moduleMAIN.ExecCmd(a);
                if (N > 0)
                {
                    a = "There was a compilation error in this project!" + Environment.NewLine;
                    a = a + "Do you want to read a SCASM report?";
                    DialogResult dr = MessageBox.Show(a, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question); ;
                    if (dr == DialogResult.OK)
                    {
                        a = "notepad SCAERROR.LOG";
                        N = moduleMAIN.ExecCmd(a);
                    }

                    return;
                }
            }

            if (!CopyBGLs)
                return;
            string BGLFileTarget;
            // copy BGL files
            try
            {
                if (FS9)
                {
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + File1 + ".BGL";
                    if (File.Exists(BGLFile1))
                        File.Copy(BGLFile1, BGLFileTarget, true);
                }

                if (FS8)
                {
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + File0 + ".BGL";
                    if (File.Exists(BGLFile0))
                        File.Copy(BGLFile0, BGLFileTarget, true);
                }

                if (FSX)
                {
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + File2 + ".BGL";
                    if (File.Exists(BGLFile2))
                        File.Copy(BGLFile2, BGLFileTarget, true);
                }

                if (FS9xml)
                {
                    BGLFileTarget = moduleMAIN.BGLProjectFolder + @"\" + File3 + ".BGL";
                    if (File.Exists(BGLFile3))
                        File.Copy(BGLFile3, BGLFileTarget, true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static string FixLibID(string ID)
        {
            string FixLibIDRet = default;
            FixLibIDRet = ID.Substring(0, 8).ToUpper() + " ";
            FixLibIDRet = FixLibIDRet + ID.Substring(8, 8).ToUpper() + " ";
            FixLibIDRet = FixLibIDRet + ID.Substring(16, 8).ToUpper() + " ";
            FixLibIDRet = FixLibIDRet + ID.Substring(25, 8).ToUpper();
            return FixLibIDRet;
        }

        private static string Color2HexStr(int Col)
        {
            string Color2HexStrRet = default;
            int X;
            Color C;

            // this changed when making FSX version!!! hope it works!
            C = Color.FromArgb(Col);
            X = ColorTranslator.ToOle(C);
            Color2HexStrRet = X.ToString("X");
            return Color2HexStrRet;
        }

        private static int RedFromInteger(int Col)
        {
            int RedFromIntegerRet = default;
            Color C;
            C = Color.FromArgb(Col);
            RedFromIntegerRet = C.B;    // troca com Blue
            return RedFromIntegerRet;
        }

        private static int GreenFromInteger(int Col)
        {
            int GreenFromIntegerRet = default;
            Color C;
            C = Color.FromArgb(Col);
            GreenFromIntegerRet = C.G;
            return GreenFromIntegerRet;
        }

        private static int BlueFromInteger(int Col)
        {
            int BlueFromIntegerRet = default;
            Color C;
            C = Color.FromArgb(Col);
            BlueFromIntegerRet = C.R;            // troca com red
            return BlueFromIntegerRet;
        }

        private static void CheckLibObjects()
        {
            LibObjectsIsOn = false;
            if (!string.IsNullOrEmpty(FileSystem.Dir(LibObjectsPath + @"\objects.txt")))
                LibObjectsIsOn = true;
        }

        private static void CheckRwy12()
        {
            Rwy12IsOn = false;
            if (!string.IsNullOrEmpty(FileSystem.Dir(Rwy12Path + @"\add_*.xml")))
                Rwy12IsOn = true;
        }

        internal static int IsMouseOnObject(double x, double y)
        {
            int IsMouseOnObjectRet = default;

            // returns the first Object that has the mouse over it! if none returns 0
            // on entry X Y contains mouse distance from center display in pixels

            int N;
            moduleMAIN.Double_XY PC;
            IsMouseOnObjectRet = 0;
            if (ObjectVIEW == false)
                return IsMouseOnObjectRet;
            x = moduleMAIN.LonDispCenter * moduleMAIN.PixelsPerLonDeg + x;
            y = moduleMAIN.LatDispCenter * moduleMAIN.PixelsPerLatDeg - y;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                PC.X = Objects[N].lon * moduleMAIN.PixelsPerLonDeg;
                PC.Y = Objects[N].lat * moduleMAIN.PixelsPerLatDeg;
                if (PC.X > x + 5d)
                    goto Jump_Next;
                if (PC.X < x - 5d)
                    goto Jump_Next;
                if (PC.Y < y - 5d)
                    goto Jump_Next;
                if (PC.Y > y + 5d)
                    goto Jump_Next;
                IsMouseOnObjectRet = N;
                return IsMouseOnObjectRet;
            Jump_Next:
                ;
            }

            return IsMouseOnObjectRet;
        }

        private static string PackAPIMacro(int N)
        {
            string PackAPIMacroRet = default;
            string a;
            double lat, lon;
            double Alt;
            string Latitude, Longitude;
            string Altitude, AGL;
            string Heading;
            double BiasY, BiasX, BiasZ;
            string Complex;
            string V1, V2;
            string Range, Scaling;
            lat = Objects[N].lat;
            lon = Objects[N].lon;
            Alt = Objects[N].Altitude;
            BiasX = Objects[N].BiasX;
            BiasY = Objects[N].BiasY;
            BiasZ = Objects[N].BiasZ;
            Alt = Alt + BiasZ;
            if (BiasX != 0d | BiasY != 0d)
            {
                lon = lon + BiasX / moduleMAIN.MetersPerDegLon(lat);
                lat = lat + BiasY / moduleMAIN.MetersPerDegLat;
            }

            Latitude = lat.ToString("0.00000000");
            Longitude = lon.ToString("0.00000000");
            Altitude = Alt.ToString("0.000");
            AGL = Objects[N].AGL.ToString().Trim();
            Heading = Objects[N].Heading.ToString("0.000");
            Latitude = Latitude.Replace(",", ".");
            Longitude = Longitude.Replace(",", ".");
            Altitude = Altitude.Replace(",", ".");
            Heading = Heading.Replace(",", ".");
            Complex = Objects[N].Complexity.ToString().Trim();
            V1 = moduleMACROS.MacroVisibility.ToString().Trim();
            V2 = moduleMACROS.MacroV2Value.ToString().Trim();
            Range = moduleMACROS.MacroRange.ToString().Trim();
            Scaling = moduleMACROS.MacroScale.ToString().Trim();
            a = "macro( \"" + moduleMACROS.MacroAPIPath + @"\" + moduleMACROS.MacroID + "\"";
            a = a + " " + Latitude + " " + Longitude + " " + Range + " " + Scaling + " " + Heading + " ";
            a = a + moduleMACROS.MacroP6Value + " " + moduleMACROS.MacroP7Value + " " + moduleMACROS.MacroP8Value + " " + moduleMACROS.MacroP9Value + " ";
            PackAPIMacroRet = a + V1 + " " + Altitude + " " + Complex + " v2= " + V2 + " )";
            return PackAPIMacroRet;
        }

        private static string PackASDMacro(int N)
        {
            string PackASDMacroRet = default;
            string b, a, FileName;
            int J, K;
            string[] PN;
            string[] PV;
            int NP;
            double lat, lon;
            double Alt;
            string Latitude, Longitude;
            string Altitude, AGL;
            string Heading;
            double BiasY, BiasX, BiasZ;
            string Length, Complex, Width;
            string V1;
            string Range, Scaling;
            FileName = moduleMACROS.MacroASDPath + @"\" + moduleMACROS.MacroID;
            FileSystem.FileOpen(2, FileName, OpenMode.Input);
            a = FileSystem.LineInput(2);
            b = "";
            do
            {
                a = FileSystem.LineInput(2);
                K = a.IndexOf(@"\");
                if (K != -1)
                {
                    b = b + a.Substring(1, K - 1) + ",";
                }
                else
                {
                    b = b + a.Substring(1) + ",";
                    break;
                }
            }
            while (true);
            FileSystem.FileClose(2);
            b = b.Replace(", ", ",");
            b = b.Replace(" ,", ",");
            b = b.Replace(",,", ",");
            b = b.Replace(",,", ",");
            moduleMACROS.MacroString = b.Replace("= ", "=");
            a = moduleMACROS.GetMacroValue("Name");
            a = moduleMACROS.GetMacroValue("Type");
            a = moduleMACROS.GetMacroValue("Autoscale");
            a = moduleMACROS.GetMacroValue("FixedLength");
            a = moduleMACROS.GetMacroValue("FixedWidth");
            a = moduleMACROS.GetMacroValue("Bitmap");
            NP = GetNoOfMacroParameters();
            if (NP == 0)
            {
                PackASDMacroRet = "macro( " + moduleMACROS.MacroASDPath + @"\" + moduleMACROS.MacroID + " )";
                return PackASDMacroRet;
            }

            PN = new string[NP + 1]; // parameter names
            PV = new string[NP + 1]; // parameter values
            int loopTo = NP;
            for (J = 1; J <= loopTo; J++)
                PN[J] = GetNextMacroParameterName();
            lat = Objects[N].lat;
            lon = Objects[N].lon;
            Alt = Objects[N].Altitude;
            BiasX = Objects[N].BiasX;
            BiasY = Objects[N].BiasY;
            BiasZ = Objects[N].BiasZ;
            Alt = Alt + BiasZ;
            if (BiasX != 0d | BiasY != 0d)
            {
                lon = lon + BiasX / moduleMAIN.MetersPerDegLon(lat);
                lat = lat + BiasY / moduleMAIN.MetersPerDegLat;
            }

            Latitude = lat.ToString("0.00000000");
            Longitude = lon.ToString("0.00000000");
            Altitude = Alt.ToString("0.000");
            AGL = Objects[N].AGL.ToString().Trim();
            Heading = Objects[N].Heading.ToString("0.000");
            Complex = Objects[N].Complexity.ToString().Trim();
            V1 = moduleMACROS.MacroVisibility.ToString().Trim();
            Range = moduleMACROS.MacroRange.ToString().Trim();
            Scaling = moduleMACROS.MacroScale.ToString().Trim();
            Length = Objects[N].Length.ToString().Trim();
            Width = Objects[N].Width.ToString().Trim();
            int loopTo1 = NP;
            for (J = 1; J <= loopTo1; J++)
            {
                if (PN[J] == "Latitude")
                {
                    PV[J] = Latitude;
                    goto next_j;
                }

                if (PN[J] == "Longitude")
                {
                    PV[J] = Longitude;
                    goto next_j;
                }

                if (PN[J] == "Elevation")
                {
                    PV[J] = Altitude;
                    goto next_j;
                }

                if (PN[J] == "Rotation")
                {
                    PV[J] = Heading;
                    goto next_j;
                }

                if (PN[J] == "Visibility")
                {
                    PV[J] = V1;
                    goto next_j;
                }

                if (PN[J] == "Range")
                {
                    PV[J] = Range;
                    goto next_j;
                }

                if (PN[J] == "Density")
                {
                    PV[J] = Complex;
                    goto next_j;
                }

                if (PN[J] == "Scale")
                {
                    PV[J] = Scaling;
                    goto next_j;
                }

                if (PN[J] == "Length")
                {
                    PV[J] = Length;
                    goto next_j;
                }

                if (PN[J] == "Width")
                {
                    PV[J] = Width;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroP6Name ?? ""))
                {
                    PV[J] = moduleMACROS.MacroP6Value;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroP7Name ?? ""))
                {
                    PV[J] = moduleMACROS.MacroP7Value;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroP8Name ?? ""))
                {
                    PV[J] = moduleMACROS.MacroP8Value;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroP9Name ?? ""))
                {
                    PV[J] = moduleMACROS.MacroP9Value;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroPAName ?? ""))
                {
                    PV[J] = moduleMACROS.MacroPAValue;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroPBName ?? ""))
                {
                    PV[J] = moduleMACROS.MacroPBValue;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroPCName ?? ""))
                {
                    PV[J] = moduleMACROS.MacroPCValue;
                    goto next_j;
                }

                if ((PN[J] ?? "") == (moduleMACROS.MacroPDName ?? ""))
                    PV[J] = moduleMACROS.MacroPDValue;
                next_j:
                ;
            }

            a = "macro( \"" + moduleMACROS.MacroASDPath + @"\" + moduleMACROS.MacroID + "\"" + " ";
            int loopTo2 = NP;
            for (J = 1; J <= loopTo2; J++)
                a = a + PV[J].Replace(",", ".") + " ";
            PackASDMacroRet = a + ")";
            return PackASDMacroRet;
        }

        private static string GetNextMacroParameterName()
        {
            string GetNextMacroParameterNameRet = default;
            int N;
            string a;
            N = moduleMACROS.MacroString.IndexOf(",");
            a = moduleMACROS.MacroString.Substring(0, N + 1);
            moduleMACROS.MacroString = moduleMACROS.MacroString.Replace(a, "");
            a = a.Substring(0, N);
            N = a.IndexOf("=");
            if (N == -1)
            {
                GetNextMacroParameterNameRet = a;
            }
            else
            {
                GetNextMacroParameterNameRet = a.Substring(0, N);
            }

            return GetNextMacroParameterNameRet;
        }

        private static int GetNoOfMacroParameters()
        {
            int GetNoOfMacroParametersRet = default;
            int N, K;
            N = 0;
            K = -1;
            do
            {
                K = moduleMACROS.MacroString.IndexOf(",", K + 1);
                if (K == -1)
                    break;
                N = N + 1;
            }
            while (true);
            GetNoOfMacroParametersRet = N;
            return GetNoOfMacroParametersRet;
        }

        internal static string GetObjectName(int N)
        {
            string GetObjectNameRet = default;
            int K;
            K = Objects[N].Description.LastIndexOf("|");
            GetObjectNameRet = Objects[N].Description.Substring(K + 1);
            return GetObjectNameRet;
        }

        internal static void SelectInvertObjects()
        {
            int N;
            if (!ObjectVIEW)
                return;
            int loopTo = NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                if (Objects[N].Selected)
                {
                    NoOfObjectsSelected = NoOfObjectsSelected - 1;
                    Objects[N].Selected = false;
                    goto Jump_Next;
                }
                else
                {
                    NoOfObjectsSelected = NoOfObjectsSelected + 1;
                    moduleMAIN.SomeSelected = true;
                    Objects[N].Selected = true;
                }

            Jump_Next:
                ;
            }
        }

        private static string GetTR(int X)
        {
            string GetTRRet = default;
            GetTRRet = "FALSE";
            if (X == 1)
                GetTRRet = "TRUE";
            return GetTRRet;
        }

        private static string GetComplex(int X)
        {
            string GetComplexRet = default;
            GetComplexRet = "";
            if (X == 0)
                GetComplexRet = "VERY_SPARSE";
            if (X == 1)
                GetComplexRet = "SPARSE";
            if (X == 2)
                GetComplexRet = "NORMAL";
            if (X == 3)
                GetComplexRet = "DENSE";
            if (X == 4)
                GetComplexRet = "VERY_DENSE";
            if (X == 5)
                GetComplexRet = "EXTREMELY_DENSE";
            return GetComplexRet;
        }

        private static string GetBeaconType()
        {
            string GetBeaconTypeRet = default;
            GetBeaconTypeRet = "";
            if (ObjBeaCivil == 1)
                GetBeaconTypeRet = "CIVILIAN";
            if (ObjBeaMil == 1)
                GetBeaconTypeRet = "MILITARY";
            return GetBeaconTypeRet;
        }

        private static string GetBeaconBaseType()
        {
            string GetBeaconBaseTypeRet = default;
            GetBeaconBaseTypeRet = "";
            if (ObjBeaAirport == 1)
                GetBeaconBaseTypeRet = "AIRPORT";
            if (ObjBeaSeaBase == 1)
                GetBeaconBaseTypeRet = "SEA_BASE";
            if (ObjBeaHeliport == 1)
                GetBeaconBaseTypeRet = "HELIPORT";
            return GetBeaconBaseTypeRet;
        }

        internal static int BuildingType;
        internal static float sizeX = 40f;
        internal static float sizeZ = 30f;
        internal static float scale_gb = 1f;
        internal static int bottomTexture = 43;
        internal static int windowTexture = 43;
        internal static int topTexture = 43;
        internal static int roofTexture = 25;
        internal static float sizeBottomY = 4f;
        internal static float sizeWindowY = 12f;
        internal static float sizeTopY = 4f;
        internal static float sizeRoofY = 4f;
        internal static float sizeTopX = 35f;
        internal static float sizeTopZ = 25f;
        internal static int textureIndexBottomX = 256;
        internal static int textureIndexBottomZ = 256;
        internal static int textureIndexWindowX = 256;
        internal static int textureIndexWindowY = 768;
        internal static int textureIndexWindowZ = 256;
        internal static int textureIndexTopX = 256;
        internal static int textureIndexTopZ = 256;
        internal static int textureIndexRoofX = 256;
        internal static int textureIndexRoofY = 256;
        internal static int textureIndexRoofZ = 256;
        internal static int gableTexture = 1043;
        internal static int textureIndexGableY = 256;
        internal static int textureIndexGableZ = 256;
        internal static int faceTexture = 1043;
        internal static int textureIndexFaceX = 256;
        internal static int textureIndexFaceY = 256;
        internal static int buildingSides = 6;
        internal static bool smoothing = false;

        internal static void AnalyseGenBObject(int N)
        {
            string a = "";
            int M1, M2;
            a = Objects[N].Description;
            M1 = 0;
            M2 = a.IndexOf("|", M1);
            scale_gb = Convert.ToSingle(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            bottomTexture = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            roofTexture = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            topTexture = Convert.ToInt32(a.Substring(M1, M2 - M1));
            M1 = M2 + 1;
            M2 = a.IndexOf("|", M1);
            windowTexture = Convert.ToInt32(a.Substring(M1, M2 - M1));
            if (Objects[N].Type == 256 | Objects[N].Type == 257 | Objects[N].Type == 258 | Objects[N].Type == 259)
            // Rect flat
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeBottomY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexBottomX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexBottomZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeWindowY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeTopY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexTopX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexTopZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
            }

            if (Objects[N].Type == 256)  // Rect flat
            {
                ObjComment = a.Substring(M2 + 1);
            }

            if (Objects[N].Type == 257)  // Rect peaked
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeRoofY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                ObjComment = a.Substring(M2 + 1);
            }

            if (Objects[N].Type == 258)  // Rect Ridge
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeRoofY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                gableTexture = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexGableY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexGableZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                ObjComment = a.Substring(M2 + 1);
            }

            if (Objects[N].Type == 259)  // Rect slant
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeRoofY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                gableTexture = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexGableY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexGableZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                faceTexture = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexFaceX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexFaceY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                ObjComment = a.Substring(M2 + 1);
            }

            if (Objects[N].Type == 260)  // pyramidal
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeTopX = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeTopZ = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeBottomY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexBottomX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexBottomZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeWindowY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeTopY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexTopX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexTopZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                ObjComment = a.Substring(M2 + 1);
            }

            if (Objects[N].Type == 261) // multi sided
            {
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                buildingSides = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                smoothing = Convert.ToBoolean(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeBottomY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1); ;
                textureIndexBottomX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeWindowY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexWindowY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeTopY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexTopX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                sizeRoofY = Convert.ToSingle(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofX = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofY = Convert.ToInt32(a.Substring(M1, M2 - M1));
                M1 = M2 + 1;
                M2 = a.IndexOf("|", M1);
                textureIndexRoofZ = Convert.ToInt32(a.Substring(M1, M2 - M1));
                ObjComment = a.Substring(M2 + 1);
            }
        }

        internal static string MakeGBTextures()
        {
            string MakeGBTexturesRet = default;
            string a = bottomTexture.ToString() + "|";
            a = a + roofTexture.ToString() + "|";
            a = a + topTexture.ToString() + "|";
            a = a + windowTexture.ToString();
            MakeGBTexturesRet = a;
            return MakeGBTexturesRet;
        }

        internal static string MakeGBIndexes(int type)
        {
            string MakeGBIndexesRet = default;
            string a = "";
            if (type == 256 | type == 257 | type == 258 | type == 259)
            // Rect flat
            {
                a = a + sizeBottomY.ToString().Trim() + "|";
                a = a + textureIndexBottomX.ToString() + "|";
                a = a + textureIndexBottomZ.ToString() + "|";
                a = a + sizeWindowY.ToString().Trim() + "|";
                a = a + textureIndexWindowX.ToString() + "|";
                a = a + textureIndexWindowY.ToString() + "|";
                a = a + textureIndexWindowZ.ToString() + "|";
                a = a + sizeTopY.ToString().Trim() + "|";
                a = a + textureIndexTopX.ToString() + "|";
                a = a + textureIndexTopZ.ToString() + "|";
                a = a + textureIndexRoofX.ToString() + "|";
                a = a + textureIndexRoofZ.ToString();
            }

            if (type == 257)  // Rect peaked
            {
                a = a + "|" + sizeRoofY.ToString().Trim() + "|";
                a = a + textureIndexRoofY.ToString();
            }

            if (type == 258)  // Rect Ridge
            {
                a = a + "|" + sizeRoofY.ToString().Trim() + "|";
                a = a + gableTexture.ToString() + "|";
                a = a + textureIndexGableY.ToString() + "|";
                a = a + textureIndexGableZ.ToString();
            }

            if (type == 259)  // Rect slant
            {
                a = a + "|" + sizeRoofY.ToString().Trim() + "|";
                a = a + gableTexture.ToString() + "|";
                a = a + textureIndexGableY.ToString() + "|";
                a = a + textureIndexGableZ.ToString() + "|";
                a = a + faceTexture.ToString() + "|";
                a = a + textureIndexFaceX.ToString() + "|";
                a = a + textureIndexFaceY.ToString();
            }

            if (type == 260)  // pyramidal
            {
                a = a + sizeTopX.ToString().Trim() + "|";
                a = a + sizeTopZ.ToString().Trim() + "|";
                a = a + sizeBottomY.ToString().Trim() + "|";
                a = a + textureIndexBottomX.ToString() + "|";
                a = a + textureIndexBottomZ.ToString() + "|";
                a = a + sizeWindowY.ToString().Trim() + "|";
                a = a + textureIndexWindowX.ToString() + "|";
                a = a + textureIndexWindowY.ToString() + "|";
                a = a + textureIndexWindowZ.ToString() + "|";
                a = a + sizeTopY.ToString().Trim() + "|";
                a = a + textureIndexTopX.ToString() + "|";
                a = a + textureIndexTopZ.ToString() + "|";
                a = a + textureIndexRoofX.ToString() + "|";
                a = a + textureIndexRoofZ.ToString();
            }

            if (type == 261) // multi sided
            {
                a = a + buildingSides.ToString() + "|";
                a = a + smoothing.ToString() + "|";
                a = a + sizeBottomY.ToString().Trim() + "|";
                a = a + textureIndexBottomX.ToString() + "|";
                a = a + sizeWindowY.ToString().Trim() + "|";
                a = a + textureIndexWindowX.ToString() + "|";
                a = a + textureIndexWindowY.ToString() + "|";
                a = a + sizeTopY.ToString().Trim() + "|";
                a = a + textureIndexTopX.ToString() + "|";
                a = a + sizeRoofY.ToString().Trim() + "|";
                a = a + textureIndexRoofX.ToString() + "|";
                a = a + textureIndexRoofY.ToString() + "|";
                a = a + textureIndexRoofZ.ToString();
            }

            MakeGBIndexesRet = a;
            return MakeGBIndexesRet;
        }
    }
}