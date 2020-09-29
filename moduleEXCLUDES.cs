using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SBuilderX
{
    static class moduleEXCLUDES
    {
        [Serializable()]
        internal struct Exclude
        {
            public int Flag;
            public bool Selected;
            public double NLAT;
            public double SLAT;
            public double WLON;
            public double ELON;
            // Dim CornerSel As Integer ' not saved 1=NW 2=SE 0=none
        }

        internal static double AuxX;
        internal static double AuxY;
        internal static Exclude[] Excludes;
        internal static int NoOfExcludes;
        internal static bool ExcludeON;
        internal static bool ExcludeVIEW;
        internal static int NoOfExcludesSelected = 0;
        internal static int ExcludeSizeIndex = 0;
        internal static bool DrawExclude = false;
        private static string excludeAllObjects;
        private static string excludeBeaconObjects;
        private static string excludeEffectObjects;
        private static string excludeExtrusionBridgeObjects;
        private static string excludeGenericBuildingObjects;
        private static string excludeLibraryObjects;
        private static string excludeTaxiwaySignObjects;
        private static string excludeTriggerObjects;
        private static string excludeWindsockObjects;

        internal static void ExcludeInsertMode(ref short Button, ref short Shift, int X, int Y)
        {
            if (Button == 1)
            {
                if (Shift == 1) // pick the SHIFT DOWN
                {
                    moduleMAIN.SomeSelected = moduleMAIN.SomeSelected | IsExcludeSelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y);
                    moduleMAIN.RebuildDisplay();
                    if (moduleMAIN.SomeSelected)
                    {
                        moduleMAIN.SetDelay(200);
                        My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                        My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                        moduleMAIN.MoveON = true;
                        moduleMAIN.FirstMOVE = true;
                        moduleMAIN.AuxXInt = X;
                        moduleMAIN.AuxYInt = Y;
                    }

                    return;
                }

                ExcludeSizeIndex = IsExcludeSizeIndex(X, Y);
                if (ExcludeSizeIndex > 0)
                {
                    My.MyProject.Forms.FrmStart.SetMouseIcon();
                    return;
                }

                bool argFlag = false;
                SelectAllExcludes(ref argFlag);
                moduleMAIN.SomeSelected = IsExcludeSelected(moduleMAIN.LonDispWest * moduleMAIN.PixelsPerLonDeg + X, moduleMAIN.LatDispNorth * moduleMAIN.PixelsPerLatDeg - Y);
                moduleMAIN.RebuildDisplay();
                if (moduleMAIN.SomeSelected)
                {
                    moduleMAIN.SetDelay(200);
                    My.MyProject.Forms.FrmStart.CopyMenuItem.Enabled = false;
                    My.MyProject.Forms.FrmStart.DeleteMenuItem.Enabled = false;
                    moduleMAIN.MoveON = true;
                    moduleMAIN.FirstMOVE = true;
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                    return;
                }
                else
                {
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                    DrawExclude = true;
                }
            }

            if (Button == 2)
            {
                modulePOPUP.XPOP = X;
                modulePOPUP.YPOP = Y;
                modulePOPUP.ProcessPopUp(X, Y);
            }
        }

        internal static void FormExclude(int X, double Y)
        {
            modulePOPUP.POPIndex = NoOfExcludes + 1;
            My.MyProject.Forms.FrmExcludesP.AddNewExclude(X, (int)Y);
        }

        internal static int IsExcludeSizeIndex(int X, int Y)
        {
            int IsExcludeSizeIndexRet = default;

            // on entry X Y contain distance from NW corner display in pixels

            int N;
            PointF P1 = default, P2 = default, P3 = default, P4 = default;
            double dlat, dlon;
            bool Flag;
            IsExcludeSizeIndexRet = 0;
            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                dlat = Excludes[N].NLAT - Excludes[N].SLAT;
                dlon = Excludes[N].ELON - Excludes[N].WLON;
                Flag = dlat * moduleMAIN.PixelsPerLatDeg + dlon * moduleMAIN.PixelsPerLonDeg < 20d;
                if (Flag)
                    goto next_N;
                P1.X = (float)((Excludes[N].WLON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                P1.Y = (float)((moduleMAIN.LatDispNorth - Excludes[N].NLAT) * moduleMAIN.PixelsPerLatDeg);
                if (P1.X > X + 5)
                    goto next_2;
                if (P1.X < X - 5)
                    goto next_2;
                if (P1.Y < Y - 5)
                    goto next_2;
                if (P1.Y > Y + 5)
                    goto next_2;
                IsExcludeSizeIndexRet = N;
                if (!Excludes[N].Selected)
                    NoOfExcludesSelected = NoOfExcludesSelected + 1;
                Excludes[N].Selected = true;
                return IsExcludeSizeIndexRet;
            next_2:
                ;
                P2.X = (float)((Excludes[N].ELON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                P2.Y = P1.Y;
                if (P2.X > X + 5)
                    goto next_3;
                if (P2.X < X - 5)
                    goto next_3;
                if (P2.Y < Y - 5)
                    goto next_3;
                if (P2.Y > Y + 5)
                    goto next_3;
                IsExcludeSizeIndexRet = N;
                if (!Excludes[N].Selected)
                    NoOfExcludesSelected = NoOfExcludesSelected + 1;
                Excludes[N].Selected = true;
                return IsExcludeSizeIndexRet;
            next_3:
                ;
                P3.X = P2.X;
                P3.Y = (float)((moduleMAIN.LatDispNorth - Excludes[N].SLAT) * moduleMAIN.PixelsPerLatDeg);
                if (P3.X > X + 5)
                    goto next_4;
                if (P3.X < X - 5)
                    goto next_4;
                if (P3.Y < Y - 5)
                    goto next_4;
                if (P3.Y > Y + 5)
                    goto next_4;
                IsExcludeSizeIndexRet = N;
                if (!Excludes[N].Selected)
                    NoOfExcludesSelected = NoOfExcludesSelected + 1;
                Excludes[N].Selected = true;
                return IsExcludeSizeIndexRet;
            next_4:
                ;
                P4.X = P1.X;
                P4.Y = P3.Y;
                if (P4.X > X + 5)
                    goto next_N;
                if (P4.X < X - 5)
                    goto next_N;
                if (P4.Y < Y - 5)
                    goto next_N;
                if (P4.Y > Y + 5)
                    goto next_N;
                IsExcludeSizeIndexRet = N;
                if (!Excludes[N].Selected)
                    NoOfExcludesSelected = NoOfExcludesSelected + 1;
                Excludes[N].Selected = true;
                return IsExcludeSizeIndexRet;
            next_N:
                ;
            }

            return IsExcludeSizeIndexRet;
        }

        internal static void SizeExclude(int X, int Y, int N)
        {
            double lat, lon;
            double latY, lonX;
            double dlat, dlon;
            lat = (Excludes[N].NLAT + Excludes[N].SLAT) / 2d;
            lon = (Excludes[N].WLON + Excludes[N].ELON) / 2d;
            lonX = moduleMAIN.LonDispWest + X / moduleMAIN.PixelsPerLonDeg;
            latY = moduleMAIN.LatDispNorth - Y / moduleMAIN.PixelsPerLatDeg;
            dlat = Math.Abs(latY - lat);
            dlon = Math.Abs(lonX - lon);
            Excludes[N].NLAT = lat + dlat;
            Excludes[N].SLAT = lat - dlat;
            Excludes[N].WLON = lon - dlon;
            Excludes[N].ELON = lon + dlon;
            moduleMAIN.RebuildDisplay();
        }

        internal static bool IsPtInExclude(int N, double X, double Y)
        {
            bool IsPtInExcludeRet = default;
            double X2, X1, Y1, Y2;
            X1 = Excludes[N].WLON * moduleMAIN.PixelsPerLonDeg;
            X2 = Excludes[N].ELON * moduleMAIN.PixelsPerLonDeg;
            Y1 = Excludes[N].NLAT * moduleMAIN.PixelsPerLatDeg;
            Y2 = Excludes[N].SLAT * moduleMAIN.PixelsPerLatDeg;
            IsPtInExcludeRet = false;
            if (X > X2 + 3d)
                return IsPtInExcludeRet;
            if (X < X1 - 3d)
                return IsPtInExcludeRet;
            if (Y < Y2 - 3d)
                return IsPtInExcludeRet;
            if (Y > Y1 + 3d)
                return IsPtInExcludeRet;
            if (X < X2 - 3d)
            {
                if (X > X1 + 3d)
                {
                    if (Y > Y2 + 3d)
                    {
                        if (Y < Y1 - 3d)
                            return IsPtInExcludeRet;
                    }
                }
            }

            IsPtInExcludeRet = true;
            return IsPtInExcludeRet;
        }

        internal static void SelectExcludesInBox(double X0, double Y0, double X1, double Y1)
        {
            int N;
            if (!ExcludeVIEW)
                return;
            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                if (Excludes[N].ELON < X1)
                {
                    if (Excludes[N].WLON > X0)
                    {
                        if (Excludes[N].SLAT > Y1)
                        {
                            if (Excludes[N].NLAT < Y0)
                            {
                                if (!Excludes[N].Selected)
                                    NoOfExcludesSelected = NoOfExcludesSelected + 1;
                                moduleMAIN.SomeSelected = true;
                                Excludes[N].Selected = true;
                            }
                        }
                    }
                }
            }
        }

        internal static void SelectAllExcludes(ref bool Flag)
        {
            int N;
            if (!ExcludeVIEW)
                return;
            if (Flag)
            {
                My.MyProject.Forms.FrmStart.SelectAllExcludesMenuItem.Checked = true;
            }
            else
            {
                My.MyProject.Forms.FrmStart.SelectAllExcludesMenuItem.Checked = false;
            }

            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                if (Flag)
                {
                    if (!Excludes[N].Selected)
                        NoOfExcludesSelected = NoOfExcludesSelected + 1;
                    moduleMAIN.SomeSelected = true;
                }
                else if (Excludes[N].Selected)
                    NoOfExcludesSelected = NoOfExcludesSelected - 1;
                Excludes[N].Selected = Flag;
            }
        }

        internal static void DisplayExcludes(Graphics g)
        {
            float X, Y;
            PointF P1 = default, P2 = default, P3 = default, P4 = default;
            int N;
            bool Flag;
            Pen myPen = new Pen(Color.Black);
            SolidBrush myBrush = new SolidBrush(Color.SpringGreen);
            double lat, lon, dlat, dlon;
            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                if (Excludes[N].NLAT < moduleMAIN.LatDispSouth)
                    goto JumpHere;
                if (Excludes[N].SLAT > moduleMAIN.LatDispNorth)
                    goto JumpHere;
                if (Excludes[N].WLON > moduleMAIN.LonDispEast)
                    goto JumpHere;
                if (Excludes[N].ELON < moduleMAIN.LonDispWest)
                    goto JumpHere;
                if (Excludes[N].Selected)
                {
                    // myBrush.Color = Color.SpringGreen
                    myPen.Color = Color.SpringGreen;
                }
                else
                {
                    // myBrush.Color = Color.Yellow
                    myPen.Color = Color.Black;
                }

                dlat = Excludes[N].NLAT - Excludes[N].SLAT;
                dlon = Excludes[N].ELON - Excludes[N].WLON;
                Flag = dlat * moduleMAIN.PixelsPerLatDeg + dlon * moduleMAIN.PixelsPerLonDeg < 20d;
                if (Flag)
                {
                    lat = (Excludes[N].NLAT + Excludes[N].SLAT) / 2d;
                    lon = (Excludes[N].WLON + Excludes[N].ELON) / 2d;
                    X = (float)((lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                    Y = (float)((moduleMAIN.LatDispNorth - lat) * moduleMAIN.PixelsPerLatDeg);
                    if (Excludes[N].Selected)
                    {
                        g.FillRectangle(myBrush, X - 3f, Y - 3f, 6f, 6f);
                    }
                    else
                    {
                        myPen.Width = 1f;
                        g.DrawRectangle(myPen, X - 3f, Y - 3f, 6f, 6f);
                    }

                    goto JumpHere;
                }

                P1.X = (float)((Excludes[N].WLON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                P2.X = (float)((Excludes[N].ELON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                P3.X = P2.X;
                P4.X = P1.X;
                P1.Y = (float)((moduleMAIN.LatDispNorth - Excludes[N].NLAT) * moduleMAIN.PixelsPerLatDeg);
                P2.Y = P1.Y;
                P3.Y = (float)((moduleMAIN.LatDispNorth - Excludes[N].SLAT) * moduleMAIN.PixelsPerLatDeg);
                P4.Y = P3.Y;
                if (ExcludeON)
                {
                    myPen.Width = 1f;
                    g.DrawRectangle(myPen, P1.X - 3f, P1.Y - 3f, 6f, 6f);
                    g.DrawRectangle(myPen, P2.X - 3f, P2.Y - 3f, 6f, 6f);
                    g.DrawRectangle(myPen, P3.X - 3f, P3.Y - 3f, 6f, 6f);
                    g.DrawRectangle(myPen, P4.X - 3f, P4.Y - 3f, 6f, 6f);
                }

                myPen.Width = 2f;
                g.DrawLine(myPen, P1, P2);
                g.DrawLine(myPen, P2, P3);
                g.DrawLine(myPen, P3, P4);
                g.DrawLine(myPen, P4, P1);
            JumpHere:
                ;
            }

            myBrush.Dispose();
            myPen.Dispose();
        }

        internal static void DeleteExclude(int N)
        {
            int K;
            moduleMAIN.Dirty = true;
            if (!moduleEDIT.SkipBackUp)
                moduleEDIT.BackUp();
            if (Excludes[N].Selected)
                NoOfExcludesSelected = NoOfExcludesSelected - 1;
            if (N < NoOfExcludes)
            {
                int loopTo = NoOfExcludes - 1;
                for (K = N; K <= loopTo; K++)
                {
                    Excludes[K].Flag = Excludes[K + 1].Flag;
                    Excludes[K].Selected = Excludes[K + 1].Selected;
                    Excludes[K].NLAT = Excludes[K + 1].NLAT;
                    Excludes[K].SLAT = Excludes[K + 1].SLAT;
                    Excludes[K].ELON = Excludes[K + 1].ELON;
                    Excludes[K].WLON = Excludes[K + 1].WLON;
                }
            }

            if (NoOfExcludes > 1)
            {
                Array.Resize(ref Excludes, NoOfExcludes);
            }

            NoOfExcludes = NoOfExcludes - 1;
        }

        internal static bool IsExcludeSelected(double X, double Y)
        {
            bool IsExcludeSelectedRet = default;
            int N;
            bool retval;
            IsExcludeSelectedRet = false;
            if (!ExcludeVIEW)
                return IsExcludeSelectedRet;
            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                retval = IsPtInExclude(N, X, Y);
                if (retval)
                {
                    if (Excludes[N].Selected == false)
                        NoOfExcludesSelected = NoOfExcludesSelected + 1;
                    Excludes[N].Selected = true;
                    IsExcludeSelectedRet = true;
                }
            }

            return IsExcludeSelectedRet;
        }

        internal static int IsPointInExclude(double X, double Y)
        {
            int IsPointInExcludeRet = default;
            double X2, X1, Y1, Y2;
            int N;
            X = moduleMAIN.LonDispCenter * moduleMAIN.PixelsPerLonDeg + X;
            Y = moduleMAIN.LatDispCenter * moduleMAIN.PixelsPerLatDeg - Y;
            IsPointInExcludeRet = 0;
            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                X1 = Excludes[N].WLON * moduleMAIN.PixelsPerLonDeg;
                Y1 = Excludes[N].NLAT * moduleMAIN.PixelsPerLatDeg;
                if (X < X1 + 3d)
                {
                    if (X > X1 - 3d)
                    {
                        if (Y > Y1 - 3d)
                        {
                            if (Y < Y1 + 3d)
                            {
                                AuxX = (Excludes[N].ELON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg;
                                AuxY = (moduleMAIN.LatDispNorth - Excludes[N].SLAT) * moduleMAIN.PixelsPerLatDeg;
                                IsPointInExcludeRet = N;
                                return IsPointInExcludeRet;
                            }
                        }
                    }
                }

                X2 = Excludes[N].ELON * moduleMAIN.PixelsPerLonDeg;
                Y2 = Excludes[N].SLAT * moduleMAIN.PixelsPerLatDeg;
                if (X < X2 + 3d)
                {
                    if (X > X2 - 3d)
                    {
                        if (Y > Y2 - 3d)
                        {
                            if (Y < Y2 + 3d)
                            {
                                AuxX = (Excludes[N].WLON - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg;
                                AuxY = (moduleMAIN.LatDispNorth - Excludes[N].NLAT) * moduleMAIN.PixelsPerLatDeg;
                                IsPointInExcludeRet = N;
                                return IsPointInExcludeRet;
                            }
                        }
                    }
                }
            }

            return IsPointInExcludeRet;
        }

        internal static void MoveSelectedExcludes(double x, double y)
        {
            int N;
            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                if (Excludes[N].Selected)
                {
                    Excludes[N].NLAT = Excludes[N].NLAT - y;
                    Excludes[N].SLAT = Excludes[N].SLAT - y;
                    Excludes[N].WLON = Excludes[N].WLON + x;
                    Excludes[N].ELON = Excludes[N].ELON + x;
                }
            }
        }

        internal static void MakeBGLExcludes(bool CopyBGLs)
        {
            int N;
            string a, b;
            string myFile = "000_" + moduleMAIN.ProjectName;
            myFile = myFile.Replace(" ", "_");
            a = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".xml";
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
            int loopTo = NoOfExcludes;
            for (N = 1; N <= loopTo; N++)
            {
                if (Excludes[N].Selected)
                {
                    GetFlag(N);
                    writer.WriteStartElement("ExclusionRectangle");
                    writer.WriteAttributeString("latitudeMinimum", Excludes[N].SLAT.ToString());
                    writer.WriteAttributeString("latitudeMaximum", Excludes[N].NLAT.ToString());
                    writer.WriteAttributeString("longitudeMinimum", Excludes[N].WLON.ToString());
                    writer.WriteAttributeString("longitudeMaximum", Excludes[N].ELON.ToString());
                    writer.WriteAttributeString("excludeAllObjects", excludeAllObjects);
                    writer.WriteAttributeString("excludeBeaconObjects", excludeBeaconObjects);
                    writer.WriteAttributeString("excludeEffectObjects", excludeEffectObjects);
                    writer.WriteAttributeString("excludeExtrusionBridgeObjects", excludeExtrusionBridgeObjects);
                    writer.WriteAttributeString("excludeGenericBuildingObjects", excludeGenericBuildingObjects);
                    writer.WriteAttributeString("excludeLibraryObjects", excludeLibraryObjects);
                    writer.WriteAttributeString("excludeTaxiwaySignObjects", excludeTaxiwaySignObjects);
                    writer.WriteAttributeString("excludeTriggerObjects", excludeTriggerObjects);
                    writer.WriteAttributeString("excludeWindsockObjects", excludeWindsockObjects);
                    writer.WriteEndElement();
                }
            }

            writer.WriteFullEndElement();
            writer.Close();

            // delete BGL File
            string BGLFile = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".BGL";
            if (File.Exists(BGLFile))
                File.Delete(BGLFile);
            Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\tools\");
            a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bglcomp.exe";
            b = @"work\" + myFile + ".xml";
            Process myProcess = new Process();
            myProcess = Process.Start(a, b);
            myProcess.WaitForExit();
            myProcess.Dispose();

            // added this to catch errors June 30 2009
            if (!File.Exists(BGLFile))
            {
                a = "BGLComp could not produce the file" + Environment.NewLine + BGLFile + Environment.NewLine;
                a = a + @"Try to compile the file ..\tools\" + b + " in a MSDOS window" + Environment.NewLine;
                a = a + "to read the error report!";
                MessageBox.Show(a, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (!CopyBGLs)
                return;
            try
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\work\" + myFile + ".BGL";
                if (File.Exists(a))
                {
                    File.Copy(a, moduleMAIN.BGLProjectFolder + @"\" + myFile + ".BGL", true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Copying BGL files failed! Try to close FSX.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private static void GetFlag(int N)
        {
            N = Excludes[N].Flag;
            excludeAllObjects = "FALSE";
            excludeBeaconObjects = "FALSE";
            excludeEffectObjects = "FALSE";
            excludeExtrusionBridgeObjects = "FALSE";
            excludeGenericBuildingObjects = "FALSE";
            excludeLibraryObjects = "FALSE";
            excludeTaxiwaySignObjects = "FALSE";
            excludeTriggerObjects = "FALSE";
            excludeWindsockObjects = "FALSE";
            if (Convert.ToBoolean(N & 1))
                excludeAllObjects = "TRUE";
            if (Convert.ToBoolean(N & 2))
                excludeBeaconObjects = "TRUE";
            if (Convert.ToBoolean(N & 4))
                excludeEffectObjects = "TRUE";
            if (Convert.ToBoolean(N & 8))
                excludeGenericBuildingObjects = "TRUE";
            if (Convert.ToBoolean(N & 16))
                excludeLibraryObjects = "TRUE";
            if (Convert.ToBoolean(N & 32))
                excludeTaxiwaySignObjects = "TRUE";
            if (Convert.ToBoolean(N & 64))
                excludeTriggerObjects = "TRUE";
            if (Convert.ToBoolean(N & 128))
                excludeWindsockObjects = "TRUE";
            if (Convert.ToBoolean(N & 256))
                excludeExtrusionBridgeObjects = "TRUE";
        }
    }
}