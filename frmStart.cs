using FSUIPC;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using ScruffyDuck.Flightsim.Scenery.SceneryFile;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmStart
    {
        public FrmStart()
        {

            // This call is required by the Windows Form Designer.
            InitializeComponent();
            _NewMenuItem.Name = "NewMenuItem";
            _OpenMenuItem.Name = "OpenMenuItem";
            _SaveMenuItem.Name = "SaveMenuItem";
            _SaveAsMenuItem.Name = "SaveAsMenuItem";
            _BGLMenuItem.Name = "BGLMenuItem";
            _PropertiesMenuItem.Name = "PropertiesMenuItem";
            _ImportSBXMenuItem.Name = "ImportSBXMenuItem";
            _AppendSBXMenuItem.Name = "AppendSBXMenuItem";
            _AppendBLNMenuItem.Name = "AppendBLNMenuItem";
            _AppendObjMenuItem.Name = "AppendObjMenuItem";
            _AppendSHPMenuItem.Name = "AppendSHPMenuItem";
            _AppendRAWMenuItem.Name = "AppendRAWMenuItem";
            _ExportSBXMenuItem.Name = "ExportSBXMenuItem";
            _ExportBLNMenuItem.Name = "ExportBLNMenuItem";
            _ExportSHPMenuItem.Name = "ExportSHPMenuItem";
            _ExportKMLMenuItem.Name = "ExportKMLMenuItem";
            _FromDiskMenuItem.Name = "FromDiskMenuItem";
            _FromBackgroundMapMenuItem.Name = "FromBackgroundMapMenuItem";
            _FromGoogleMapsToolStripMenuItem.Name = "FromGoogleMapsToolStripMenuItem";
            _FromArcGisToolStripMenuItem.Name = "FromArcGisToolStripMenuItem";
            _ExitMenuItem.Name = "ExitMenuItem";
            _RecentFile1MenuItem.Name = "RecentFile1MenuItem";
            _RecentFile2MenuItem.Name = "RecentFile2MenuItem";
            _RecentFile3MenuItem.Name = "RecentFile3MenuItem";
            _RecentFile4MenuItem.Name = "RecentFile4MenuItem";
            _EditMenuItem.Name = "EditMenuItem";
            _EnableUndoRedoMenuItem.Name = "EnableUndoRedoMenuItem";
            _UndoMenuItem.Name = "UndoMenuItem";
            _RedoMenuItem.Name = "RedoMenuItem";
            _SnapToQMIDMenuItem.Name = "SnapToQMIDMenuItem";
            _MeasureToolMenuItem.Name = "MeasureToolMenuItem";
            _ObjLibManagerMenuItem.Name = "ObjLibManagerMenuItem";
            _CopyMenuItem.Name = "CopyMenuItem";
            _PasteMenuItem.Name = "PasteMenuItem";
            _DeleteMenuItem.Name = "DeleteMenuItem";
            _FindMenuItem.Name = "FindMenuItem";
            _TileServerMenuItem.Name = "TileServerMenuItem";
            _FSXSettingsMenuItem.Name = "FSXSettingsMenuItem";
            _ObjectFoldersMenuItem.Name = "ObjectFoldersMenuItem";
            _EditINIFileMenuItem.Name = "EditINIFileMenuItem";
            _ShowToolbarMenuItem.Name = "ShowToolbarMenuItem";
            _ShowBackgroundMenuItem.Name = "ShowBackgroundMenuItem";
            _NoLODMenuItem.Name = "NoLODMenuItem";
            _LOD0MenuItem.Name = "LOD0MenuItem";
            _LOD1MenuItem.Name = "LOD1MenuItem";
            _LOD2MenuItem.Name = "LOD2MenuItem";
            _LOD3MenuItem.Name = "LOD3MenuItem";
            _LOD4MenuItem.Name = "LOD4MenuItem";
            _LOD5MenuItem.Name = "LOD5MenuItem";
            _LOD6MenuItem.Name = "LOD6MenuItem";
            _LOD7MenuItem.Name = "LOD7MenuItem";
            _LOD8MenuItem.Name = "LOD8MenuItem";
            _LOD9MenuItem.Name = "LOD9MenuItem";
            _LOD10MenuItem.Name = "LOD10MenuItem";
            _LOD11MenuItem.Name = "LOD11MenuItem";
            _LOD12MenuItem.Name = "LOD12MenuItem";
            _LOD13MenuItem.Name = "LOD13MenuItem";
            _LOD14MenuItem.Name = "LOD14MenuItem";
            _LOD15MenuItem.Name = "LOD15MenuItem";
            _LOD16MenuItem.Name = "LOD16MenuItem";
            _LOD17MenuItem.Name = "LOD17MenuItem";
            _LOD18MenuItem.Name = "LOD18MenuItem";
            _LOD19MenuItem.Name = "LOD19MenuItem";
            _LOD20MenuItem.Name = "LOD20MenuItem";
            _LOD21MenuItem.Name = "LOD21MenuItem";
            _LOD22MenuItem.Name = "LOD22MenuItem";
            _LOD23MenuItem.Name = "LOD23MenuItem";
            _LOD24MenuItem.Name = "LOD24MenuItem";
            _LOD25MenuItem.Name = "LOD25MenuItem";
            _LOD26MenuItem.Name = "LOD26MenuItem";
            _LOD27MenuItem.Name = "LOD27MenuItem";
            _NoGridMenuItem.Name = "NoGridMenuItem";
            _Level2MenuItem.Name = "Level2MenuItem";
            _Level3MenuItem.Name = "Level3MenuItem";
            _Level4MenuItem.Name = "Level4MenuItem";
            _Level5MenuItem.Name = "Level5MenuItem";
            _Level6MenuItem.Name = "Level6MenuItem";
            _Level7MenuItem.Name = "Level7MenuItem";
            _Level8MenuItem.Name = "Level8MenuItem";
            _Level9MenuItem.Name = "Level9MenuItem";
            _Level10MenuItem.Name = "Level10MenuItem";
            _Level11MenuItem.Name = "Level11MenuItem";
            _Level12MenuItem.Name = "Level12MenuItem";
            _Level13MenuItem.Name = "Level13MenuItem";
            _Level14MenuItem.Name = "Level14MenuItem";
            _Level15MenuItem.Name = "Level15MenuItem";
            _Level16MenuItem.Name = "Level16MenuItem";
            _Level17MenuItem.Name = "Level17MenuItem";
            _Level18MenuItem.Name = "Level18MenuItem";
            _Level19MenuItem.Name = "Level19MenuItem";
            _Level20MenuItem.Name = "Level20MenuItem";
            _Level21MenuItem.Name = "Level21MenuItem";
            _Level22MenuItem.Name = "Level22MenuItem";
            _Level23MenuItem.Name = "Level23MenuItem";
            _Level24MenuItem.Name = "Level24MenuItem";
            _Level25MenuItem.Name = "Level25MenuItem";
            _Level26MenuItem.Name = "Level26MenuItem";
            _Level27MenuItem.Name = "Level27MenuItem";
            _Level28MenuItem.Name = "Level28MenuItem";
            _Level29MenuItem.Name = "Level29MenuItem";
            _GoToPositionMenuItem.Name = "GoToPositionMenuItem";
            _ShowAircraftMenuItem.Name = "ShowAircraftMenuItem";
            _FlyAircraftToMenuItem.Name = "FlyAircraftToMenuItem";
            _SummerMapMenuItem.Name = "SummerMapMenuItem";
            _SpringMapMenuItem.Name = "SpringMapMenuItem";
            _FallMapMenuItem.Name = "FallMapMenuItem";
            _WinterMapMenuItem.Name = "WinterMapMenuItem";
            _HardWinterMapMenuItem.Name = "HardWinterMapMenuItem";
            _NightMapMenuItem.Name = "NightMapMenuItem";
            _ViewAllMapsMenuItem.Name = "ViewAllMapsMenuItem";
            _ViewAllLandsMenuItem.Name = "ViewAllLandsMenuItem";
            _ViewAllWatersMenuItem.Name = "ViewAllWatersMenuItem";
            _ViewAllLinesMenuItem.Name = "ViewAllLinesMenuItem";
            _ViewAllPolysMenuItem.Name = "ViewAllPolysMenuItem";
            _ViewAllObjectsMenuItem.Name = "ViewAllObjectsMenuItem";
            _ViewAllExcludesMenuItem.Name = "ViewAllExcludesMenuItem";
            _ViewAllMenuItem.Name = "ViewAllMenuItem";
            _SelectAllMapsMenuItem.Name = "SelectAllMapsMenuItem";
            _SelectAllLandsMenuItem.Name = "SelectAllLandsMenuItem";
            _SelectAllWatersMenuItem.Name = "SelectAllWatersMenuItem";
            _SelectAllLinesMenuItem.Name = "SelectAllLinesMenuItem";
            _SelectAllPolysMenuItem.Name = "SelectAllPolysMenuItem";
            _SelectAllObjectsMenuItem.Name = "SelectAllObjectsMenuItem";
            _SelectAllExcludesMenuItem.Name = "SelectAllExcludesMenuItem";
            _InvertSelectionMenuItem.Name = "InvertSelectionMenuItem";
            _SelectAllMenuItem.Name = "SelectAllMenuItem";
            _PointerMenuItem.Name = "PointerMenuItem";
            _ZoomMenuItem.Name = "ZoomMenuItem";
            _LandMenuItem.Name = "LandMenuItem";
            _WaterMenuItem.Name = "WaterMenuItem";
            _LineMenuItem.Name = "LineMenuItem";
            _PolyMenuItem.Name = "PolyMenuItem";
            _ObjectMenuItem.Name = "ObjectMenuItem";
            _ExcludeMenuItem.Name = "ExcludeMenuItem";
            _SbuilderHelpMenuItem.Name = "SbuilderHelpMenuItem";
            _WhatIsNewMenuItem.Name = "WhatIsNewMenuItem";
            _ForumMenuItem.Name = "ForumMenuItem";
            _GetMapMenuItem.Name = "GetMapMenuItem";
            _AboutMenuItem.Name = "AboutMenuItem";
            _CenterPopUPMenu.Name = "CenterPopUPMenu";
            _FlyToPopUPMenu.Name = "FlyToPopUPMenu";
            _PointFromAircraftPopUpMenu.Name = "PointFromAircraftPopUpMenu";
            _ZoomInPopUPMenu.Name = "ZoomInPopUPMenu";
            _ZoomOutPopUPMenu.Name = "ZoomOutPopUPMenu";
            _SaveBackGroundPopUpMenu.Name = "SaveBackGroundPopUpMenu";
            _TilePathToClipboardPopUpMenu.Name = "TilePathToClipboardPopUpMenu";
            _DeletePopUPMenu.Name = "DeletePopUPMenu";
            _JoinAllPopUPMenu.Name = "JoinAllPopUPMenu";
            _SetWidthPopUpMenu.Name = "SetWidthPopUpMenu";
            _SetAltitudePopUpMenu.Name = "SetAltitudePopUpMenu";
            _SetTransparencyPopUpMenu.Name = "SetTransparencyPopUpMenu";
            _MakeLinePopUPMenu.Name = "MakeLinePopUPMenu";
            _SnapQMIDPopUPMenu.Name = "SnapQMIDPopUPMenu";
            _FillQMIDPopUpMenu.Name = "FillQMIDPopUpMenu";
            _SliceQMIDPopUpMenu.Name = "SliceQMIDPopUpMenu";
            _MakePolyPopUPMenu.Name = "MakePolyPopUPMenu";
            _ConvertToPolyPopUpMenu.Name = "ConvertToPolyPopUpMenu";
            _SmoothPopUPMenu.Name = "SmoothPopUPMenu";
            _OuterPopUpMenu.Name = "OuterPopUpMenu";
            _HolePopUpMenu.Name = "HolePopUpMenu";
            _SamplePopUPMenu.Name = "SamplePopUPMenu";
            _ManualCheckPopUPMenu.Name = "ManualCheckPopUPMenu";
            _CalibratePopUPMenu.Name = "CalibratePopUPMenu";
            _PropertiesPopUPMenu.Name = "PropertiesPopUPMenu";
            _NewToolStripButton.Name = "NewToolStripButton";
            _OpenToolStripButton.Name = "OpenToolStripButton";
            _SaveToolStripButton.Name = "SaveToolStripButton";
            _UndoToolStripButton.Name = "UndoToolStripButton";
            _RedoToolStripButton.Name = "RedoToolStripButton";
            _PointerToolStripButton.Name = "PointerToolStripButton";
            _ZoomToolStripButton.Name = "ZoomToolStripButton";
            _MeshToolStripButton.Name = "MeshToolStripButton";
            _LandToolStripButton.Name = "LandToolStripButton";
            _WaterToolStripButton.Name = "WaterToolStripButton";
            _LineToolStripButton.Name = "LineToolStripButton";
            _PolyToolStripButton.Name = "PolyToolStripButton";
            _ObjectToolStripButton.Name = "ObjectToolStripButton";
            _ExcludeToolStripButton.Name = "ExcludeToolStripButton";
            _BGLToolStripButton.Name = "BGLToolStripButton";

            // Add any initialization after the InitializeComponent() call.

        }

        internal Offset<long> LatAircraft = new Offset<long>(0x560);
        internal Offset<long> LonAircraft = new Offset<long>(0x568);
        internal Offset<int> Alt1Aircraft = new Offset<int>(0x574);   // units
        internal Offset<int> Alt2Aircraft = new Offset<int>(0x570);   // fraction
        internal Offset<int> PitchAircraft = new Offset<int>(0x578);
        internal Offset<int> BankAircraft = new Offset<int>(0x57C);
        internal Offset<int> HeadingAircraft = new Offset<int>(0x580);
        private double AircraftLatitude;
        private double AircraftLongitude;
        private bool SelectParent = false;
        private bool KeyPanON; // used for Pen
        private bool KeyZoomRollON;
        private bool ZoomRollON;
        private bool KeyRightMouse;
        private bool SelectWindow;
        private bool MeasureTool;
        private bool MeasureON;
        private string CursorPath = My.MyProject.Application.Info.DirectoryPath + @"\Tools\Cursors\";
        private double LatitudeDelta;
        private double LongitudeDelta;
        private bool BackColorGray = false;

        protected override void OnPaint(PaintEventArgs e)
        {

            // If InitON Then Exit Sub

            if (moduleMAIN.BitmapBuffer is null)
            {
                moduleMAIN.DisplayWidth = ClientSize.Width;
                moduleMAIN.DisplayHeight = ClientSize.Height;

                // put this because when minimized there were crashes
                if (moduleMAIN.DisplayWidth == 0)
                    moduleMAIN.DisplayWidth = 10;
                if (moduleMAIN.DisplayHeight == 0)
                    moduleMAIN.DisplayHeight = 10;
                if (moduleMAIN.DisplayWidth > 2 * moduleMAIN.DisplayHeight)
                {
                    Width = 2 * moduleMAIN.DisplayHeight + 8;
                    moduleMAIN.DisplayWidth = 2 * moduleMAIN.DisplayHeight;
                }

                moduleMAIN.DisplayCenterX = (int)(moduleMAIN.DisplayWidth / 2d);
                moduleMAIN.DisplayCenterY = (int)(moduleMAIN.DisplayHeight / 2d);
                moduleMAIN.BitmapBuffer = new Bitmap(moduleMAIN.DisplayWidth, moduleMAIN.DisplayHeight);
                moduleMAIN.SetDispCenter(0, 0);
                BuildBitmapBuffer();
                e.Graphics.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            }
            else
            {
                e.Graphics.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            if (moduleMAIN.BitmapBuffer is object)
            {
                moduleMAIN.BitmapBuffer.Dispose();
                moduleMAIN.BitmapBuffer = null;
                Invalidate();
            }

            base.OnSizeChanged(e);
        }

        public void BuildBitmapBuffer()
        {
            if (moduleMAIN.BitmapBuffer is object)
            {
                Graphics g = Graphics.FromImage(moduleMAIN.BitmapBuffer);
                if (BackColorGray)
                {
                    g.Clear(Color.Gray);
                }
                else
                {
                    g.Clear(Color.White);
                }

                if (moduleTILES.TileVIEW)
                    moduleTILES.DisplayTiles(g);
                if (moduleMAPS.MapVIEW)
                    moduleMAPS.DisplayMaps(g);
                if (moduleCLASSES.WaterVIEW)
                    moduleCLASSES.DisplayWaters(g);
                if (moduleCLASSES.LandVIEW)
                    moduleCLASSES.DisplayLands(g);
                if (modulePOLYS.PolyVIEW)
                    modulePOLYS.DisplayPolys(g);
                if (moduleLINES.LineVIEW)
                    moduleLINES.DisplayLines(g);
                if (moduleOBJECTS.ObjectVIEW)
                    moduleOBJECTS.DisplayObjects(g);
                if (moduleEXCLUDES.ExcludeVIEW)
                    moduleEXCLUDES.DisplayExcludes(g);
                DisplayGrids(g);
                DisplayScale();
                g.Dispose();
            }
        }

        public void UpdateDisplay()
        {

            // copies the buffer to the display
            // draws grids if necessary

            if (moduleMAIN.BitmapBuffer is object)
            {
                Graphics gr = CreateGraphics();
                gr.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);   // copy buffer to display
                if (moduleLINES.CheckLine > 0)
                    DisplayCheckLine(gr);
                if (modulePOLYS.CheckPoly > 0)
                    DisplayCheckPoly(gr);
                if (moduleMAIN.AircraftVIEW)
                    DisplayAircraft(gr);
                gr.Dispose();
            }
        }

        private void DisplayScale()
        {
            int X = 0;
            string A = "";
            GetScaleValues(ref X, ref A);
            lbScale.ForeColor = Color.Black;
            if (moduleTILES.TileVIEW)
                lbScale.ForeColor = Color.White;
            Point XY = default(Point);
            XY.X = moduleMAIN.DisplayWidth - X - 10;
            XY.Y = moduleMAIN.DisplayHeight - 35;
            lbScaleBar.Location = XY;
            lbScaleBar.Width = X;
            XY.Y = moduleMAIN.DisplayHeight - 50;
            X = A.Length;
            // XY.X = DisplayWidth - 65
            XY.X = moduleMAIN.DisplayWidth - X * 8 - 10;
            lbScale.Location = XY;
            lbScale.Text = A;
        }

        private void GetScaleValues(ref int X, ref string A)
        {
            switch (moduleMAIN.Zoom)
            {
                case 25:
                    {
                        X = 83;
                        A = "20 cm";
                        break;
                    }

                case 24:
                    {
                        X = 106;
                        A = "50 cm";
                        break;
                    }

                case 23:
                    {
                        X = 106;
                        A = "1 m";
                        break;
                    }

                case 22:
                    {
                        X = 107;
                        A = "2 m";
                        break;
                    }

                case 21:
                    {
                        X = 107;
                        A = "4 m";
                        break;
                    }

                case 20:
                    {
                        X = 107;
                        A = "8 m";
                        break;
                    }

                case 19:
                    {
                        X = 134;
                        A = "20 m";
                        break;
                    }

                case 18:
                    {
                        X = 100;
                        A = "30 m";
                        break;
                    }

                case 17:
                    {
                        X = 100;
                        A = "60 m";
                        break;
                    }

                case 16:
                    {
                        X = 84;
                        A = "100 m";
                        break;
                    }

                case 15:
                    {
                        X = 84;
                        A = "200 m";
                        break;
                    }

                case 14:
                    {
                        X = 105;
                        A = "500 m";
                        break;
                    }

                case 13:
                    {
                        X = 105;
                        A = "1 km";
                        break;
                    }

                case 12:
                    {
                        X = 105;
                        A = "2 km";
                        break;
                    }

                case 11:
                    {
                        X = 105;
                        A = "4 km";
                        break;
                    }

                case 10:
                    {
                        X = 105;
                        A = "8 km";
                        break;
                    }

                case 9:
                    {
                        X = 131;
                        A = "20 km";
                        break;
                    }

                case 8:
                    {
                        X = 98;
                        A = "30 km";
                        break;
                    }

                case 7:
                    {
                        X = 98;
                        A = "60 km";
                        break;
                    }

                case 6:
                    {
                        X = 82;
                        A = "100 km";
                        break;
                    }

                case 5:
                    {
                        X = 82;
                        A = "200 km";
                        break;
                    }

                case 4:
                    {
                        X = 102;
                        A = "500 km";
                        break;
                    }

                case 3:
                    {
                        X = 102;
                        A = "1000 km";
                        break;
                    }

                case 2:
                    {
                        A = "1000 km";
                        X = (int)(1000000d * moduleMAIN.PixelsPerMeter);
                        break;
                    }

                case 1:
                    {
                        A = "2000 km";
                        X = (int)(2000000d * moduleMAIN.PixelsPerMeter);
                        break;
                    }

                case 0:
                    {
                        A = "4000 km";
                        X = (int)(4000000d * moduleMAIN.PixelsPerMeter);
                        break;
                    }
            }
        }

        public void DisplayGrids(Graphics gr)
        {
            if (moduleMAIN.QMIDLevel > 0)
            {
                DrawThisGrid(moduleMAIN.QMIDLevel, gr);
            }

            if (moduleMAIN.LODLevel == -1)
                return;
            DrawThisGrid(-moduleMAIN.LODLevel, gr);   // negative grid means it is a LOG grid!
        }

        private void DrawThisGrid(int G, Graphics gr)
        {
            Color myColor = moduleMAIN.GridColor;
            if (G < 1)
            {
                myColor = moduleMAIN.GridLODColor;
                G = 2 - G;
            }

            Pen p = new Pen(myColor)
            {
                Width = moduleMAIN.GridWidth,
                DashStyle = System.Drawing.Drawing2D.DashStyle.Dash
            };
            G = G - 2; // QMID=LOD+2
            int LA1, LA, LA2;
            int LO1, LO, LO2;
            int PX, PY;
            double LatNorth, LatSouth, LonWest, LonEast;
            LatNorth = moduleMAIN.LatDispNorth;
            LatSouth = moduleMAIN.LatDispSouth;
            LonWest = moduleMAIN.LonDispWest;
            LonEast = moduleMAIN.LonDispEast;
            double LatDelta, LonDelta;
            double LatDeltaPix, LonDeltaPix;
            LatDelta = 90d / Math.Pow(2d, G);
            LatDeltaPix = LatDelta * moduleMAIN.PixelsPerLatDeg;
            if (LatDeltaPix < 8d)
            {
                p.Dispose();
                return;
            }

            LonDelta = 120d / Math.Pow(2d, G);
            LonDeltaPix = LonDelta * moduleMAIN.PixelsPerLonDeg;
            if (LonDeltaPix < 8d)
            {
                p.Dispose();
                return;
            }

            LA1 = (int)(Convert.ToInt32(LatSouth / LatDelta) + 1d);
            LA2 = Convert.ToInt32(LatNorth / LatDelta);
            LO1 = (int)(Convert.ToInt32(LonWest / LonDelta) + 1d);
            LO2 = Convert.ToInt32(LonEast / LonDelta);
            LatDelta = (LA1 * LatDelta - moduleMAIN.LatDispSouth) * moduleMAIN.PixelsPerLatDeg;
            if (G == 0)
            {
                LonDelta = (LO1 * LonDelta - moduleMAIN.LonDispWest - 60d) * moduleMAIN.PixelsPerLonDeg;
                LO2 = LO2 + 1;
            }
            else
            {
                LonDelta = (LO1 * LonDelta - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg;
            }

            int X1, X2, Y1, Y2;
            X1 = 0;
            X2 = moduleMAIN.DisplayWidth;
            Y1 = 0;
            Y2 = moduleMAIN.DisplayHeight;
            int loopTo = LA2;
            for (LA = LA1; LA <= loopTo; LA++)
            {
                PY = moduleMAIN.DisplayHeight - (int)LatDelta;
                gr.DrawLine(p, X1, PY, X2, PY);
                LatDelta = LatDelta + LatDeltaPix;
            }

            int loopTo1 = LO2;
            for (LO = LO1; LO <= loopTo1; LO++)
            {
                PX = (int)LonDelta;
                gr.DrawLine(p, PX, Y1, PX, Y2);
                LonDelta = LonDelta + LonDeltaPix;
            }

            p.Dispose();
        }

        private void DisplayCheckLine(Graphics g)
        {
            string A;
            A = "Line #" + moduleLINES.CheckLine.ToString().Trim() + Environment.NewLine + "Point #" + moduleLINES.CheckLinePt.ToString().Trim();
            Font drawFont = new Font("MS Reference Sans Serif", 8f);
            g.DrawString(A, drawFont, Brushes.Black, moduleMAIN.DisplayCenterX + 6, moduleMAIN.DisplayCenterY - 12);
            drawFont.Dispose();
        }

        private void DisplayCheckPoly(Graphics g)
        {
            string A;
            A = "Poly #" + modulePOLYS.CheckPoly.ToString().Trim() + Environment.NewLine + "Point #" + modulePOLYS.CheckPolyPt.ToString().Trim();
            Font drawFont = new Font("MS Reference Sans Serif", 8f);
            g.DrawString(A, drawFont, Brushes.Black, moduleMAIN.DisplayCenterX + 6, moduleMAIN.DisplayCenterY - 12);
            drawFont.Dispose();
        }

        private void ZoomInOut(short Button)
        {
            if (Button == 1)
            {
                if (moduleMAIN.Zoom > 24)
                    return;
                moduleMAIN.Zoom = moduleMAIN.Zoom + 1;
            }

            if (Button == 2)
            {
                if (moduleMAIN.Zoom < 1)
                    return;
                moduleMAIN.Zoom = moduleMAIN.Zoom - 1;
            }

            moduleMAIN.ResetZoom();
            MakeBackground();
            StatusZoom.Text = "Zoom = " + moduleMAIN.Zoom.ToString();
        }

        private void ResetLevelGrid(bool LOD)
        {
            NoGridMenuItem.Checked = moduleMAIN.QMIDLevel == 0;
            Level2MenuItem.Checked = moduleMAIN.QMIDLevel == 2;
            Level3MenuItem.Checked = moduleMAIN.QMIDLevel == 3;
            Level4MenuItem.Checked = moduleMAIN.QMIDLevel == 4;
            Level5MenuItem.Checked = moduleMAIN.QMIDLevel == 5;
            Level6MenuItem.Checked = moduleMAIN.QMIDLevel == 6;
            Level7MenuItem.Checked = moduleMAIN.QMIDLevel == 7;
            Level8MenuItem.Checked = moduleMAIN.QMIDLevel == 8;
            Level9MenuItem.Checked = moduleMAIN.QMIDLevel == 9;
            Level10MenuItem.Checked = moduleMAIN.QMIDLevel == 10;
            Level11MenuItem.Checked = moduleMAIN.QMIDLevel == 11;
            Level12MenuItem.Checked = moduleMAIN.QMIDLevel == 12;
            Level13MenuItem.Checked = moduleMAIN.QMIDLevel == 13;
            Level14MenuItem.Checked = moduleMAIN.QMIDLevel == 14;
            Level15MenuItem.Checked = moduleMAIN.QMIDLevel == 15;
            Level16MenuItem.Checked = moduleMAIN.QMIDLevel == 16;
            Level17MenuItem.Checked = moduleMAIN.QMIDLevel == 17;
            Level18MenuItem.Checked = moduleMAIN.QMIDLevel == 18;
            Level19MenuItem.Checked = moduleMAIN.QMIDLevel == 19;
            Level20MenuItem.Checked = moduleMAIN.QMIDLevel == 20;
            Level21MenuItem.Checked = moduleMAIN.QMIDLevel == 21;
            Level22MenuItem.Checked = moduleMAIN.QMIDLevel == 22;
            Level23MenuItem.Checked = moduleMAIN.QMIDLevel == 23;
            Level24MenuItem.Checked = moduleMAIN.QMIDLevel == 24;
            Level25MenuItem.Checked = moduleMAIN.QMIDLevel == 25;
            Level26MenuItem.Checked = moduleMAIN.QMIDLevel == 26;
            Level27MenuItem.Checked = moduleMAIN.QMIDLevel == 27;
            Level28MenuItem.Checked = moduleMAIN.QMIDLevel == 28;
            Level29MenuItem.Checked = moduleMAIN.QMIDLevel == 29;
            NoLODMenuItem.Checked = moduleMAIN.LODLevel == -1;
            LOD0MenuItem.Checked = moduleMAIN.LODLevel == 0;
            LOD1MenuItem.Checked = moduleMAIN.LODLevel == 1;
            LOD2MenuItem.Checked = moduleMAIN.LODLevel == 2;
            LOD3MenuItem.Checked = moduleMAIN.LODLevel == 3;
            LOD4MenuItem.Checked = moduleMAIN.LODLevel == 4;
            LOD5MenuItem.Checked = moduleMAIN.LODLevel == 5;
            LOD6MenuItem.Checked = moduleMAIN.LODLevel == 6;
            LOD7MenuItem.Checked = moduleMAIN.LODLevel == 7;
            LOD8MenuItem.Checked = moduleMAIN.LODLevel == 8;
            LOD9MenuItem.Checked = moduleMAIN.LODLevel == 9;
            LOD10MenuItem.Checked = moduleMAIN.LODLevel == 10;
            LOD11MenuItem.Checked = moduleMAIN.LODLevel == 11;
            LOD12MenuItem.Checked = moduleMAIN.LODLevel == 12;
            LOD13MenuItem.Checked = moduleMAIN.LODLevel == 13;
            LOD14MenuItem.Checked = moduleMAIN.LODLevel == 14;
            LOD15MenuItem.Checked = moduleMAIN.LODLevel == 15;
            LOD16MenuItem.Checked = moduleMAIN.LODLevel == 16;
            LOD17MenuItem.Checked = moduleMAIN.LODLevel == 17;
            LOD18MenuItem.Checked = moduleMAIN.LODLevel == 18;
            LOD19MenuItem.Checked = moduleMAIN.LODLevel == 19;
            LOD20MenuItem.Checked = moduleMAIN.LODLevel == 20;
            LOD21MenuItem.Checked = moduleMAIN.LODLevel == 21;
            LOD22MenuItem.Checked = moduleMAIN.LODLevel == 22;
            LOD23MenuItem.Checked = moduleMAIN.LODLevel == 23;
            LOD24MenuItem.Checked = moduleMAIN.LODLevel == 24;
            LOD25MenuItem.Checked = moduleMAIN.LODLevel == 25;
            LOD26MenuItem.Checked = moduleMAIN.LODLevel == 26;
            LOD27MenuItem.Checked = moduleMAIN.LODLevel == 27;
            SnapToQMIDMenuItem.Enabled = false;
            if (moduleMAIN.QMIDLevel > 0)
                SnapToQMIDMenuItem.Enabled = true;
            if (LOD)
                return;
            if (moduleMAIN.ZoomOnQMID)
            {
                if (moduleMAIN.QMIDLevel == 0)
                {
                    return;
                }
                else if (moduleMAIN.QMIDLevel < 3)
                {
                    moduleMAIN.Zoom = 0;
                }
                else
                {
                    moduleMAIN.Zoom = moduleMAIN.QMIDLevel - 2;
                }

                if (moduleCLASSES.LandON | moduleCLASSES.WaterON)
                    moduleMAIN.Zoom = moduleMAIN.Zoom - 3;
                moduleMAIN.SetDispCenter(0, 0);
                StatusZoom.Text = "Zoom = " + moduleMAIN.Zoom.ToString();
            }
        }

        private void MakeAllOff()
        {
            if (moduleCLASSES.LandON)
                My.MyProject.Forms.FrmLandsP.Dispose();
            if (moduleCLASSES.WaterON)
                My.MyProject.Forms.FrmWatersP.Dispose();
            modulePOLYS.CheckPoly = 0;
            moduleLINES.CheckLine = 0;
            moduleEDIT.PasteON = false;
            moduleMAIN.MoveON = false;
            moduleMAIN.InsertON = false;
            moduleMAIN.SelectON = false;
            moduleMAIN.PointerON = false;
            moduleMAIN.ZoomON = false;
            moduleCLASSES.LandON = false;
            moduleLINES.LineON = false;
            modulePOLYS.PolyON = false;
            moduleCLASSES.WaterON = false;
            moduleOBJECTS.ObjectON = false;
            moduleEXCLUDES.ExcludeON = false;
            moduleEXCLUDES.DrawExclude = false;
            moduleOBJECTS.ObjMYes = false;
            MeasureTool = false;
            MeasureToolMenuItem.Checked = false;
            moduleEDIT.PasteON = false;
            modulePOLYS.PtPolyCounter = 0;
            moduleLINES.PtLineCounter = 0;
            MeasureToolMenuItem.Enabled = false;
            CopyMenuItem.Enabled = false;
            PasteMenuItem.Enabled = false;
            DeleteMenuItem.Enabled = false;
        }

        private void DisableSeveralMenuItems(bool Flag)
        {
            SaveAsMenuItem.Enabled = !Flag;
            ExportMenuItem.Enabled = !Flag;
            ExportSBXMenuItem.Enabled = !Flag;
            ExportBLNMenuItem.Enabled = !Flag;
            ExportSHPMenuItem.Enabled = !Flag;
            AppendMenuItem.Enabled = !Flag;
            AppendSHPMenuItem.Enabled = !Flag;
            AppendBLNMenuItem.Enabled = !Flag;
            AppendObjMenuItem.Enabled = !Flag;
            AppendRAWMenuItem.Enabled = !Flag;
            AppendVTPMenuItem.Enabled = !Flag;
            PropertiesMenuItem.Enabled = !Flag;
            BGLMenuItem.Enabled = !Flag;
            ShowBackgroundMenuItem.Enabled = !Flag;
            // PreferencesMenuItem.Enabled = Not Flag
            TileServerMenuItem.Enabled = !Flag;
            EditINIFileMenuItem.Enabled = !Flag;
            ObjectFoldersMenuItem.Enabled = !Flag;
            FSXSettingsMenuItem.Enabled = !Flag;


            // inserted in May 21 2007
            InvertSelectionMenuItem.Enabled = !Flag;
            SelectAllMenuItem.Enabled = !Flag;
            LODGridMenuItem.Enabled = !Flag;
            QMIDGridMenuItem.Enabled = !Flag;
            SnapToQMIDMenuItem.Enabled = !Flag;
            MeasureToolMenuItem.Enabled = !Flag;
            ObjLibManagerMenuItem.Enabled = !Flag;
            ShowAircraftMenuItem.Enabled = !Flag;
            FlyAircraftToMenuItem.Enabled = !Flag;
            GoToPositionMenuItem.Enabled = !Flag;
            BGLToolStripButton.Enabled = !Flag;
            FindMenuItem.Enabled = !Flag;
        }

        private void DisableOtherItems()
        {
            ShowAircraftMenuItem.Checked = false;
            SaveMenuItem.Enabled = false;
            UndoMenuItem.Enabled = false;
            RedoMenuItem.Enabled = false;
            CopyMenuItem.Enabled = false;
            PasteMenuItem.Enabled = false;
            DeleteMenuItem.Enabled = false;
            ViewMapsMenuItem.Enabled = false;
            UndoToolStripButton.Enabled = false;
            RedoToolStripButton.Enabled = false;
            SaveToolStripButton.Enabled = false;
        }

        private void UncheckToolButtons()
        {
            PointerMenuItem.Checked = false;
            ZoomMenuItem.Checked = false;
            AddMapMenuItem.Checked = false;
            LandMenuItem.Checked = false;
            WaterMenuItem.Checked = false;
            LineMenuItem.Checked = false;
            PolyMenuItem.Checked = false;
            ObjectMenuItem.Checked = false;
            ExcludeMenuItem.Checked = false;
            MeasureToolMenuItem.Enabled = false;
            PointerToolStripButton.Checked = false;
            ZoomToolStripButton.Checked = false;
            MeshToolStripButton.Checked = false;
            LandToolStripButton.Checked = false;
            WaterToolStripButton.Checked = false;
            PhotoToolStripButton.Checked = false;
            LineToolStripButton.Checked = false;
            PolyToolStripButton.Checked = false;
            ObjectToolStripButton.Checked = false;
            ExcludeToolStripButton.Checked = false;
        }

        private void DisableToolButtons(bool Flag)
        {
            PointerMenuItem.Enabled = !Flag;
            ZoomMenuItem.Enabled = !Flag;
            AddMapMenuItem.Enabled = !Flag;
            LandMenuItem.Enabled = !Flag;
            WaterMenuItem.Enabled = !Flag;
            LineMenuItem.Enabled = !Flag;
            PolyMenuItem.Enabled = !Flag;
            ObjectMenuItem.Enabled = !Flag;
            ExcludeMenuItem.Enabled = !Flag;
            MeasureToolMenuItem.Enabled = !Flag;
            PointerToolStripButton.Enabled = !Flag;
            ZoomToolStripButton.Enabled = !Flag;
            MeshToolStripButton.Enabled = !Flag;
            LandToolStripButton.Enabled = !Flag;
            WaterToolStripButton.Enabled = !Flag;
            PhotoToolStripButton.Enabled = !Flag;
            LineToolStripButton.Enabled = !Flag;
            PolyToolStripButton.Enabled = !Flag;
            ObjectToolStripButton.Enabled = !Flag;
            ExcludeToolStripButton.Enabled = !Flag;
        }

        private void UncheckViews()
        {
            MeasureToolMenuItem.Checked = false;
            ViewAllMapsMenuItem.Checked = false;
            ViewAllLandsMenuItem.Checked = false;
            ViewAllWatersMenuItem.Checked = false;
            ViewAllLinesMenuItem.Checked = false;
            ViewAllPolysMenuItem.Checked = false;
            ViewAllObjectsMenuItem.Checked = false;
            ViewAllExcludesMenuItem.Checked = false;
            ViewAllMenuItem.Checked = false;
            ViewMapsMenuItem.Checked = false;
        }

        private void DisableViews(bool Flag)
        {
            MeasureToolMenuItem.Enabled = !Flag;
            ViewAllMapsMenuItem.Enabled = !Flag;
            ViewAllLandsMenuItem.Enabled = !Flag;
            ViewAllWatersMenuItem.Enabled = !Flag;
            ViewAllLinesMenuItem.Enabled = !Flag;
            ViewAllPolysMenuItem.Enabled = !Flag;
            ViewAllObjectsMenuItem.Enabled = !Flag;
            ViewAllExcludesMenuItem.Enabled = !Flag;
            ViewAllMenuItem.Enabled = !Flag;
        }

        private void UncheckSelections()
        {
            SelectAllMapsMenuItem.Checked = false;
            SelectAllLandsMenuItem.Checked = false;
            SelectAllWatersMenuItem.Checked = false;
            SelectAllLinesMenuItem.Checked = false;
            SelectAllPolysMenuItem.Checked = false;
            SelectAllObjectsMenuItem.Checked = false;
            SelectAllExcludesMenuItem.Checked = false;
            SelectAllMenuItem.Checked = false;
        }

        private void DisableSelections(bool Flag)
        {
            if (Flag)
            {
                moduleMAIN.SomeSelected = true;
                UnSelectAll();
            }

            SelectAllMapsMenuItem.Enabled = !Flag;
            SelectAllLandsMenuItem.Enabled = !Flag;
            SelectAllLinesMenuItem.Enabled = !Flag;
            SelectAllPolysMenuItem.Enabled = !Flag;
            SelectAllWatersMenuItem.Enabled = !Flag;
            SelectAllObjectsMenuItem.Enabled = !Flag;
            SelectAllExcludesMenuItem.Enabled = !Flag;
            SelectAllMenuItem.Enabled = !Flag;
            InvertSelectionMenuItem.Enabled = !Flag;
        }

        private void DeleteAll()
        {
            moduleMAPS.NoOfMaps = 0;
            moduleCLASSES.NoOfLands = 0;
            moduleLINES.NoOfLines = 0;
            modulePOLYS.NoOfPolys = 0;
            moduleCLASSES.NoOfWaters = 0;
            moduleOBJECTS.NoOfObjects = 0;
            moduleEXCLUDES.NoOfExcludes = 0;
            moduleCLASSES.NoOfLWCIs = 0;
            moduleMAPS.Maps = new moduleMAPS.Map[2];
            moduleCLASSES.LLands = new byte[257, 257, 1];
            moduleCLASSES.LL_XY = new moduleCLASSES.LWXY[96, 64];
            moduleCLASSES.WWaters = new byte[257, 257, 1];
            moduleCLASSES.WW_XY = new moduleCLASSES.LWXY[96, 64];
            moduleLINES.Lines = new moduleLINES.GLine[2];
            modulePOLYS.Polys = new modulePOLYS.GPoly[2];
            moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[2];
            moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[2];
            moduleCLASSES.LWCIs = new moduleCLASSES.LWCIndex[2];
        }

        private void UnSelectAll()
        {
            if (moduleMAIN.SomeSelected == false)
            {
                moduleMAIN.NoOfPointsSelected = 0;
                moduleLINES.NoOfLinesSelected = 0;
                modulePOLYS.NoOfPolysSelected = 0;
                moduleCLASSES.NoOfLandsSelected = 0;
                moduleCLASSES.NoOfWatersSelected = 0;
                moduleMAPS.NoOfMapsSelected = 0;
                moduleOBJECTS.NoOfObjectsSelected = 0;
                SelectAllMenuItem.Checked = false;
                moduleMAIN.AllSELECT = false;
                return;
            }

            bool argFlag = false;
            moduleMAPS.SelectAllMaps(ref argFlag);
            bool argFlag1 = false;
            moduleCLASSES.SelectAllLands(ref argFlag1);
            bool argFlag2 = false;
            moduleLINES.SelectAllLines(ref argFlag2);
            bool argFlag3 = false;
            modulePOLYS.SelectAllPolys(ref argFlag3);
            bool argFlag4 = false;
            moduleCLASSES.SelectAllWaters(ref argFlag4);
            bool argFlag5 = false;
            moduleOBJECTS.SelectAllObjects(ref argFlag5);
            bool argFlag6 = false;
            moduleEXCLUDES.SelectAllExcludes(ref argFlag6);
            moduleMAIN.AllSELECT = false;
            moduleMAIN.SomeSelected = false;
            moduleMAIN.NoOfPointsSelected = 0;
            moduleLINES.NoOfLinesSelected = 0;
            modulePOLYS.NoOfPolysSelected = 0;
            moduleCLASSES.NoOfLandsSelected = 0;
            moduleCLASSES.NoOfWatersSelected = 0;
            moduleMAPS.NoOfMapsSelected = 0;
            moduleOBJECTS.NoOfObjectsSelected = 0;
            moduleEXCLUDES.NoOfExcludesSelected = 0;
            SelectAllMenuItem.Checked = false;
        }

        private void FrmStart_FormClosed(object sender, FormClosedEventArgs e)
        {
            My.MyProject.Forms.FrmLandsP.Dispose();
            My.MyProject.Forms.FrmWatersP.Dispose();
            FSUIPCConnection.Close();
        }

        private void FrmStart_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool Cancel = e.Cancel;
            CloseReason UnloadMode = e.CloseReason;
            if (!moduleMAIN.Dirty)
            {
                Cancel = false;
                return;
            }

            if ((int)UnloadMode > 1)
            {
                Cancel = false;
                return;
            }

            string A = "You did not save your data! Do you really want to exit ?";
            if (MessageBox.Show(A, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Cancel = true;
            }
            else
            {
                Cancel = false;
            }

            e.Cancel = Cancel;
        }

        public void FrmStart_KeyDown(object sender, KeyEventArgs e)
        {
            short KeyCode = (short)e.KeyCode;
            short Shift = (short)((int)e.KeyData / 0x10000);
            int X, N;
            moduleMAIN.InsertON = false;
            N = moduleMAIN.NoOfPointsSelected;
            N = N + moduleLINES.NoOfLinesSelected;
            N = N + modulePOLYS.NoOfPolysSelected;
            N = N + moduleCLASSES.NoOfLandsSelected;
            N = N + moduleCLASSES.NoOfWatersSelected;
            N = N + moduleMAPS.NoOfMapsSelected;
            N = N + moduleOBJECTS.NoOfObjectsSelected;
            N = N + moduleEXCLUDES.NoOfExcludesSelected;
            if (KeyCode == (int)Keys.Delete & moduleLINES.CheckLine > 0)
                moduleLINES.DeleteCheckLinePt();
            if (KeyCode == (int)Keys.Delete & modulePOLYS.CheckPoly > 0)
                modulePOLYS.DeleteCheckPolyPt();
            if (KeyCode == (int)Keys.Delete & N > 0)
            {
                if (moduleMAIN.AskDelete)
                {
                    X = (int)MessageBox.Show("Delete " + N.ToString() + " item(s) ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    X = (int)DialogResult.Yes;
                }

                if (X == (int)DialogResult.Yes)
                {
                    moduleEDIT.BackUp();
                    moduleEDIT.SkipBackUp = true;
                    moduleMAIN.DeleteSelected();
                    moduleEDIT.SkipBackUp = false;
                    moduleMAIN.RebuildDisplay();
                    return;
                }
                else
                {
                    return;
                }
            }

            if (KeyCode == (int)Keys.Escape)
            {
                if (SelectParent == true)
                {
                    SelectParent = false;
                }

                if (moduleEDIT.PasteON)
                {
                    moduleEDIT.PasteON = false;
                    PasteMenuItem.Checked = false;
                }

                MeasureTool = false;
                MeasureON = false;
                MeasureToolMenuItem.Checked = false;
                TextBoxMeasure.Visible = false;
                SetMouseIcon();
                moduleLINES.CheckLine = 0;
                modulePOLYS.CheckPoly = 0;
                if (moduleLINES.LineON)
                {
                    if (moduleLINES.PtLineCounter > 0)
                    {
                        moduleLINES.LineInsertMode(2, 0, 0, 0);
                    }
                }

                if (modulePOLYS.PolyON)
                {
                    if (modulePOLYS.PtPolyCounter > 0)
                    {
                        short argButton = 2;
                        short argShift = 0;
                        modulePOLYS.PolyInsertMode(ref argButton, ref argShift, 0, 0);
                    }
                }

                return;
            }

            if (KeyCode == (int)Keys.M)
            {
                MeasureToolMenuItem_Click(MeasureToolMenuItem, new EventArgs());
                return;
            }

            if (KeyCode == (int)Keys.I)
            {
                moduleMAIN.InsertON = true;
                return;
            }

            if (KeyCode == (int)Keys.D)
            {
                moduleMAIN.DeleteON = true;
                return;
            }

            if (KeyCode == (int)Keys.B)
            {
                moduleLINES.BreakLineON = true;
                return;
            }

            if (KeyCode == (int)Keys.P)
            {
                if (Shift == 4) // ALT P
                {
                    modulePOLYS.PolyFILL = !modulePOLYS.PolyFILL;
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    KeyPanON = true;
                    return;
                }
            }

            if (KeyCode == (int)Keys.Z)
            {
                KeyZoomRollON = true;
                return;
            }

            if (KeyCode == (int)Keys.ControlKey)
            {
                SelectWindow = true;
                return;
            }

            if (KeyCode == (int)Keys.Subtract)
            {
                moduleLINES.DecreaseWithdON = true;
                return;
            }

            if (KeyCode == (int)Keys.Add)
            {
                moduleLINES.IncreaseWithdON = true;
                return;
            }

            if (moduleLINES.CheckLine > 0)
            {
                if (KeyCode == (int)Keys.Right)
                    moduleLINES.CheckLineMove(true);
                if (KeyCode == (int)Keys.Left)
                    moduleLINES.CheckLineMove(false);
                if (KeyCode == (int)Keys.Up)
                    moduleLINES.CheckLinePtMove(true);
                if (KeyCode == (int)Keys.Down)
                    moduleLINES.CheckLinePtMove(false);
                return;
            }

            if (modulePOLYS.CheckPoly > 0)
            {
                if (KeyCode == (int)Keys.Right)
                    modulePOLYS.CheckPolyMove(true);
                if (KeyCode == (int)Keys.Left)
                    modulePOLYS.CheckPolyMove(false);
                if (KeyCode == (int)Keys.Up)
                    modulePOLYS.CheckPolyPtMove(true);
                if (KeyCode == (int)Keys.Down)
                    modulePOLYS.CheckPolyPtMove(false);
                return;
            }

            if (moduleLINES.LineON & KeyCode == (int)Keys.Space)
            {
                if (!SelectWindow)
                {
                    moduleLINES.LineInsertMode(1, Shift, moduleMAIN.AuxXInt, moduleMAIN.AuxYInt);
                }

                return;
            }
        }

        private void FrmStart_KeyUp(object sender, KeyEventArgs e)
        {
            short KeyCode = (short)e.KeyCode;
            short Shift = (short)((int)e.KeyData / 0x10000);
            if (KeyCode == (int)Keys.I)
                moduleMAIN.InsertON = false;
            if (KeyCode == (int)Keys.Insert)
                moduleMAIN.InsertON = true;
            if (KeyCode == (int)Keys.D)
                moduleMAIN.DeleteON = false;
            if (KeyCode == (int)Keys.B)
                moduleLINES.BreakLineON = false;
            if (KeyCode == (int)Keys.P)
                KeyPanON = false;
            if (KeyCode == (int)Keys.Z)
                KeyZoomRollON = false;
            if (KeyCode == (int)Keys.ControlKey)
                SelectWindow = false;
            if (KeyCode == (int)Keys.R)
                KeyRightMouse = true;
            if (KeyCode == (int)Keys.Subtract)
                moduleLINES.DecreaseWithdON = false;
            if (KeyCode == (int)Keys.Add)
                moduleLINES.IncreaseWithdON = false;
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        public void SetMouseIcon()
        {
            try
            {
                if (moduleMAIN.PanON)
                {
                    Cursor = Cursors.Hand;
                    return;
                }

                if (MeasureTool)
                {
                    Cursor = new Cursor(CursorPath + "measure.cur");
                    return;
                }

                if (moduleMAIN.MoveON)
                {
                    Cursor = new Cursor(CursorPath + "move.cur");
                    return;
                }

                if (moduleMAIN.SelectON)
                {
                    Cursor = Cursors.Cross;
                    return;
                }

                if (moduleMAIN.PointerON)
                {
                    Cursor = Cursors.Arrow;
                    return;
                }

                if (moduleMAIN.ZoomON)
                {
                    Cursor = new Cursor(CursorPath + "zoom.cur");
                    return;
                }

                if (moduleLINES.LineON)
                {
                    if (moduleEDIT.PasteON)
                    {
                        Cursor = new Cursor(CursorPath + "paste.cur");
                        return;
                    }
                    else if (moduleLINES.LineTURN)
                    {
                        Cursor = new Cursor(CursorPath + "turn.cur");
                        return;
                    }
                    else
                    {
                        Cursor = new Cursor(CursorPath + "line.cur");
                        return;
                    }
                }

                if (modulePOLYS.PolyON)
                {
                    if (moduleEDIT.PasteON)
                    {
                        Cursor = new Cursor(CursorPath + "paste.cur");
                        return;
                    }
                    else
                    {
                        Cursor = new Cursor(CursorPath + "poly.cur");
                        return;
                    }
                }

                if (moduleCLASSES.WaterON)
                {
                    Cursor = new Cursor(CursorPath + "water.cur");
                    return;
                }

                if (moduleOBJECTS.ObjectON)
                {
                    if (moduleOBJECTS.ObjectSIZE)
                    {
                        Cursor = new Cursor(CursorPath + "size.cur");
                        return;
                    }
                    else if (moduleOBJECTS.ObjectTURN)
                    {
                        Cursor = new Cursor(CursorPath + "turn.cur");
                        return;
                    }
                    else if (moduleEDIT.PasteON)
                    {
                        Cursor = new Cursor(CursorPath + "paste.cur");
                        return;
                    }
                    else
                    {
                        Cursor = new Cursor(CursorPath + "object.cur");
                        return;
                    }
                }

                if (moduleEXCLUDES.ExcludeON)
                {
                    if (moduleEXCLUDES.ExcludeSizeIndex > 0)
                    {
                        Cursor = new Cursor(CursorPath + "size.cur");
                    }
                    else
                    {
                        Cursor = new Cursor(CursorPath + "exclude.cur");
                    }

                    return;
                }

                if (moduleCLASSES.LandON)
                {
                    Cursor = new Cursor(CursorPath + "land.cur");
                    return;
                }

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Error - display cursor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void FormLoad()
        {
            CultureInfo culture;
            // The following have to be precise
            culture = CultureInfo.CreateSpecificCulture("en-US");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;

            ToolStrip.Cursor = Cursors.Arrow;
            MenuStrip.Cursor = Cursors.Arrow;
            if (moduleMAIN.BitmapBuffer is null)
            {
                moduleMAIN.DisplayWidth = ClientSize.Width;
                moduleMAIN.DisplayHeight = ClientSize.Height;
                moduleMAIN.DisplayCenterX = (int)(moduleMAIN.DisplayWidth / 2d);
                moduleMAIN.DisplayCenterY = (int)(moduleMAIN.DisplayHeight / 2d);
            }

            UncheckToolButtons();
            UncheckViews();
            UncheckSelections();
            DisableToolButtons(true);
            DisableViews(true);
            DisableSelections(true);
            DisableSeveralMenuItems(true);
            DisableOtherItems();
            modulePOPUP.HidePopUPMenu();

            // read INI file
            moduleFILE_IO.RecentFiles = new string[5];
            moduleFILE_IO.GetSettings();
            moduleFILE_IO.SetRecentFiles();


            // This is the local to make choices for different sims! At this moment only
            // FSX is implemented. NameOftheSim is read from the INI file and it is only
            // used here. IgnoreFSX is also used on FSXSettings and this should be looked
            // uponr when additional sims are added. Also look a bit further down for the
            // SetBMPTextures()


            // in October 2017
            moduleMAIN.IgnoreFSX = true;
            if (moduleMAIN.NameOfSim.ToUpper() == "FSX")
            {
                moduleMAIN.SimExe = "fsx.exe";
                moduleMAIN.IgnoreFSX = false;
            }
            else
            {
                moduleMAIN.SimExe = moduleMAIN.NameOfSim;
            }  // while there is no implementation you can use NameOfSim as the EXE

            if (moduleMAIN.IgnoreFSX)
            {
                moduleMAIN.IsFSX = false;
                moduleMAIN.FSPath = moduleMAIN.SimPath + @"\";
                CheckFSXTools();         // should be looked at when different sims implemented
                if (!moduleMAIN.IsFSXTerrain | !moduleMAIN.IsFSXBGLComp | !moduleMAIN.IsFSXPlugins)
                {
                    My.MyProject.Forms.FrmFSXSettings.ShowDialog();
                }
            }
            else
            {
                // before October 2017
                CheckFS10();     // will set IsFSX true if found on register
                CheckFSXTools();
                if (!moduleMAIN.IsFSX | !moduleMAIN.IsFSXTerrain | !moduleMAIN.IsFSXBGLComp | !moduleMAIN.IsFSXPlugins)
                {
                    My.MyProject.Forms.FrmFSXSettings.ShowDialog();
                }
            }

            CheckTerrainCFG();
            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.BGLFolder))
            {
                Directory.CreateDirectory(moduleMAIN.BGLFolder);
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Scenery"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Scenery");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Texture"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Texture");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Tiles"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Tiles");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\LibObjects"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\LibObjects");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\LibObjects\NewJpegs"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\LibObjects\NewJpegs");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\LibObjects\BackUps"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\LibObjects\BackUps");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\GenBuildings"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\GenBuildings");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Mdls"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Mdls");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\ASD"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\ASD");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\API"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\API");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Rwy12"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Rwy12");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Rwy12\img"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Rwy12\img");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Tools\Work"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Tools\Work");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Tools\Shapes"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Tools\Shapes");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Tools\Bmps"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Tools\Bmps");
            }

            if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleMAIN.AppPath + @"\Help"))
            {
                Directory.CreateDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Help");
            }

            SetPolyTypes();
            SetLineTypes();
            SetLandTypes();
            SetWaterTypes();
            moduleTILES.SetServerTypes();
            SetExtrusionsTypes();
            if (moduleMAIN.IsFSX)  // added October 2017
            {
                SetBmpTextures();
            }

            moduleOBJECTS.SetGenBObjects();
            moduleOBJECTS.SetLibObjects();
            moduleOBJECTS.SetRwy12Objects();
            moduleMACROS.SetMacroObjects();
            moduleMAIN.ProjectName = "PROJECT";
            moduleMAIN.BGLProjectFolder = moduleMAIN.BGLFolder;
            DeleteAll();  // this avoids the error on Loading of Generic Buildings (June, 7, 2014)
            Text = moduleMAIN.AppTitle + "  " + moduleMAIN.ProjectName.ToUpper();
            StatusStrip.Visible = true;
            lbScale.Visible = true;
            lbScaleBar.Visible = true;
            Cursor = Cursors.Arrow;
            moduleMAIN.Zoom = 8;
            moduleMAIN.LatDispCenter = moduleMAIN.LatIniCenter;
            moduleMAIN.LonDispCenter = moduleMAIN.LonIniCenter;
            moduleMAIN.ResetZoom();
            moduleMAIN.AircraftVIEW = false;
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUpInit();
            UncheckToolButtons();
            UncheckViews();
            UncheckSelections();
            DisableSelections(true);
            DisableToolButtons(false);
            DisableViews(false);
            DisableSeveralMenuItems(false);
            DisableOtherItems();
            ResetLevelGrid(true);
            StatusZoom.Text = "Zoom = " + moduleMAIN.Zoom.ToString();
            PointerMenuItem.Checked = true;
            PointerToolStripButton.Checked = true;
            MeasureToolMenuItem.Enabled = true;
            moduleMAIN.PointerON = true;
            Cursor = Cursors.Arrow;
            moduleTILES.TileVIEW = false;
            ShowBackgroundMenuItem.Checked = false;
            FromBackgroundMapMenuItem.Enabled = false;
            if (!string.IsNullOrEmpty(moduleTILES.ActiveTileFolder))
            {
                ShowBackgroundMenuItem.Enabled = true;
            }
            else
            {
                ShowBackgroundMenuItem.Enabled = false;
            }

            moduleMAIN.Dirty = false;
            moduleMAIN.QMIDLevel = 0;
            moduleMAIN.LODLevel = -1;
            moduleMAIN.ViewON = true;
            BackColorGray = false;
            moduleMAIN.SetDispCenter(0, 0);
            BuildBitmapBuffer();
        }

        private void NewProject()
        {
            int N;
            if (moduleMAIN.Dirty)
            {
                string A = "You did not save your data! Continue ?";
                if (MessageBox.Show(A, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            moduleMAPS.ShowSimpleMaps = false;
            int loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                if (moduleMAPS.ImgMaps[N] is object)
                    moduleMAPS.ImgMaps[N].Dispose();
            }

            StatusStrip.Visible = false;
            lbScale.Visible = false;
            lbScaleBar.Visible = false;
            DeleteAll();
            moduleMAIN.ViewON = true;
            MakeAllOff();
            moduleMAIN.QMIDLevel = 0;
            moduleMAIN.LODLevel = -1;
            BackColorGray = true;
            moduleMAIN.RebuildDisplay();
            moduleMAIN.WorkFile = "";
            moduleMAIN.ProjectName = "PROJECT";
            moduleMAIN.BGLProjectFolder = moduleMAIN.BGLFolder;
            lbDonation.Visible = false;
            My.MyProject.Forms.FrmProjectP.ShowDialog();
            Text = moduleMAIN.AppTitle + "  " + moduleMAIN.ProjectName.ToUpper();
            BackColorGray = false;
            StatusStrip.Visible = true;
            lbScale.Visible = true;
            lbScaleBar.Visible = true;
            moduleMAIN.Dirty = false;

            // GetSettings()  is it necessary? suppose no!
            Cursor = Cursors.Arrow;
            moduleMAIN.Zoom = 8;
            moduleMAIN.LatDispCenter = moduleMAIN.LatIniCenter;
            moduleMAIN.LonDispCenter = moduleMAIN.LonIniCenter;
            moduleMAIN.ResetZoom();
            moduleMAIN.AircraftVIEW = false;
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUpInit();
            UncheckToolButtons();
            UncheckViews();
            UncheckSelections();
            DisableSelections(true);
            DisableToolButtons(false);
            DisableViews(false);
            DisableSeveralMenuItems(false);
            DisableOtherItems();
            ResetLevelGrid(true);
            StatusZoom.Text = "Zoom = " + moduleMAIN.Zoom.ToString();
            PointerMenuItem.Checked = true;
            PointerToolStripButton.Checked = true;
            MeasureToolMenuItem.Enabled = true;
            moduleMAIN.PointerON = true;
            Cursor = Cursors.Arrow;
            moduleTILES.TileVIEW = false;
            ShowBackgroundMenuItem.Checked = false;
            FromBackgroundMapMenuItem.Enabled = false;
            if (!string.IsNullOrEmpty(moduleTILES.ActiveTileFolder))
            {
                ShowBackgroundMenuItem.Enabled = true;
            }
            else
            {
                ShowBackgroundMenuItem.Enabled = false;
            }

            moduleMAIN.SetDispCenter(0, 0);
            BuildBitmapBuffer();
        }

        private void CheckFS10()
        {
            string C;
            moduleMAIN.IsFSX = false;
            // FSPath = ""
            // FSPath = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Microsoft Games\Flight Simulator\10.0", "SetupPath", Nothing)
            moduleMAIN.FSPath = Get_FS_Path("FSX");
            if (string.IsNullOrEmpty(moduleMAIN.FSPath))
            {
                MessageBox.Show("FSX could not be found in this computer!", moduleMAIN.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                moduleMAIN.FSTextureFolder = moduleMAIN.FSPath + @"Scenery\World\Texture\";
                if (!My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.FSPath + "terrain.cfg"))
                {
                    C = "The Windows Registry indicates that FSX is in the folder:" + Environment.NewLine + Environment.NewLine;
                    C = C + moduleMAIN.FSPath + Environment.NewLine + Environment.NewLine;
                    C = C + "but SBuilderX could not find it there!";
                    MessageBox.Show(C, moduleMAIN.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    moduleMAIN.IsFSX = true;
                }
            }
        }

        private void CheckFSXTools()
        {
            string B, C;
            string ToolsFolder = moduleMAIN.AppPath + @"\Tools\";
            moduleMAIN.IsFSXTerrain = false;
            moduleMAIN.IsFSXBGLComp = false;
            moduleMAIN.IsFSXPlugins = false;

            // SDKPath = ""
            // SDKPath = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Microsoft Games\Flight Simulator X SDK", "SetupPath", Nothing)
            moduleMAIN.SDKPath = Get_FS_Path("SDK");
            if (!string.IsNullOrEmpty(moduleMAIN.SDKPath))
            {
                moduleMAIN.SDKTerrain = moduleMAIN.SDKPath + @"SDK\Environment Kit\Terrain SDK\";
                moduleMAIN.SDKBglComp = moduleMAIN.SDKPath + @"SDK\Environment Kit\BGL Compiler SDK\";
                // SDKPlugins = SDKPath & "SDK\Environment Kit\Modeling SDK\FSX_GmaxGamePack\Plugins\"
                moduleMAIN.SDKPlugins = moduleMAIN.SDKPath + @"SDK\Environment Kit\Modeling SDK\";
            }

            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "shp2vec.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "resample.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "imagetool.exe"))

            {
                moduleMAIN.IsFSXTerrain = true;
            }

            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.xsd"))
            {
                moduleMAIN.IsFSXBGLComp = true;
            }

            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "XToMdl.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_CrashTree.dll") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_Lookup_Keyword.dll"))

            {
                moduleMAIN.IsFSXPlugins = true;
            }

            if (moduleMAIN.IsFSXTerrain & moduleMAIN.IsFSXBGLComp & moduleMAIN.IsFSXPlugins)
                return;

            // if it got here something is wrong
            if (!string.IsNullOrEmpty(moduleMAIN.SDKPath))
            {
                if (moduleMAIN.IsFSXTerrain == false)
                {
                    // SDKTerrain = SDKPath & "SDK\Environment Kit\Terrain SDK\"
                    if (My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKTerrain + "shp2vec.exe") & My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKTerrain + "resample.exe") & My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKTerrain + "imagetool.exe"))

                    {
                        B = moduleMAIN.SDKTerrain + "shp2vec.exe";
                        C = ToolsFolder + "shp2vec.exe";
                        File.Copy(B, C, true);
                        B = moduleMAIN.SDKTerrain + "resample.exe";
                        C = ToolsFolder + "resample.exe";
                        File.Copy(B, C, true);
                        B = moduleMAIN.SDKTerrain + "imagetool.exe";
                        C = ToolsFolder + "imagetool.exe";
                        File.Copy(B, C, true);
                        moduleMAIN.IsFSXTerrain = true;
                    }
                    else
                    {
                        C = @"Shp2Vec, ImageTool & Resample do not exist in the ..\SBuilder\Tools";
                        C = C + Environment.NewLine + " folder nor in the Terrain SDK folder! Some BGL files can not be generated!";
                        MessageBox.Show(C, moduleMAIN.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (moduleMAIN.IsFSXBGLComp == false)
                {
                    // SDKBglComp = SDKPath & "SDK\Environment Kit\BGL Compiler SDK\"
                    if (My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKBglComp + "bglcomp.exe") & My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKBglComp + "bglcomp.xsd"))
                    {
                        B = moduleMAIN.SDKBglComp + "bglcomp.exe";
                        C = ToolsFolder + "bglcomp.exe";
                        File.Copy(B, C, true);
                        B = moduleMAIN.SDKBglComp + "bglcomp.xsd";
                        C = ToolsFolder + "bglcomp.xsd";
                        File.Copy(B, C, true);
                        moduleMAIN.IsFSXBGLComp = true;
                    }
                    else
                    {
                        C = @"BGLComp does not exist in the ..\SBuilder\Tools folder nor in";
                        C = C + Environment.NewLine + "the BGL Compiler SDK folder! Some BGL files can not be generated!";
                        MessageBox.Show(C, moduleMAIN.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                if (moduleMAIN.IsFSXPlugins == false)
                {
                    // SDKPlugins = SDKPath & "SDK\Environment Kit\Modeling SDK\FSX_GmaxGamePack\Plugins\"
                    if (My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKPlugins + "XToMdl.exe") & My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKPlugins + "Managed_CrashTree.dll") & My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.SDKPlugins + "Managed_Lookup_Keyword.dll"))

                    {
                        B = moduleMAIN.SDKPlugins + "XToMdl.exe";
                        C = ToolsFolder + "XToMdl.exe";
                        File.Copy(B, C, true);
                        B = moduleMAIN.SDKPlugins + "Managed_CrashTree.dll";
                        C = ToolsFolder + "Managed_CrashTree.dll";
                        File.Copy(B, C, true);
                        B = moduleMAIN.SDKPlugins + "Managed_Lookup_Keyword.dll";
                        C = ToolsFolder + "Managed_Lookup_Keyword.dll";
                        File.Copy(B, C, true);
                        moduleMAIN.IsFSXPlugins = true;
                    }
                    else
                    {
                        C = @"XToMdl, Managed_CrashTree & Managed_Lookup_Keyword do not exist in the ..\SBuilder\Tools";
                        C = C + Environment.NewLine + @" folder nor in the FSX_GmaxGamePack\Plugins SDK folder! Some BGL files can not be generated!";
                        MessageBox.Show(C, moduleMAIN.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                C = @"Some SDK tools are missing in the ..\SBuilder\Tools folder and the FSX SDK";
                C = C + Environment.NewLine + "could not be found in this computer! Some BGL files can not be generated!";
                MessageBox.Show(C, moduleMAIN.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string Get_FS_Path(string sKey)
        {

            // Get_FS_Path("FSX") returns the full path to FSX if found,
            // Get_FS_Path("SDK") returns the full path to the FSX SDK if found,
            // otherwise returns an empty string

            RegistryKey regKey;
            string GetPath = null;
            string s = "";
            string sVista = "";
            if (sKey == "FSX")
            {
                sKey = @"flight simulator\10.0";
            }
            else if (sKey == "SDK")
            {
                sKey = "Flight Simulator X SDK";
            }
            else
            {
                return "";
            }

            try
            {
                do
                {
                    s = @"Software\" + sVista + @"Microsoft\microsoft games\" + sKey;
                    regKey = My.MyProject.Computer.Registry.LocalMachine.OpenSubKey(s);
                    if (regKey is null)
                        regKey = My.MyProject.Computer.Registry.CurrentUser.OpenSubKey(s);
                    if (regKey is null)
                        regKey = My.MyProject.Computer.Registry.Users.OpenSubKey(s);
                    if (regKey is object)
                    {
                        GetPath = regKey.GetValue("SetupPath")?.ToString();
                        if (GetPath is object && !GetPath.EndsWith(@"\"))
                        {
                            GetPath = GetPath + @"\";
                        }

                        regKey.Close();
                    }

                    if (GetPath is object | !string.IsNullOrEmpty(sVista))
                        break;
                    sVista = @"Wow6432Node\";
                }
                while (true);
                if (GetPath is null)
                    GetPath = "";
                return GetPath;
            }
            catch (System.Security.SecurityException)
            {
                MessageBox.Show("You do not have sufficient privileges to run SBuilderX.  Please log on as administrator.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return "";
            }
        }

        private void CheckTerrainCFG()
        {
            if (!moduleMAIN.IsFSX)
                return;
            if (moduleMAIN.OriginalTerrainCFG)
                return;
            string TerrainFile = moduleMAIN.FSPath + "terrain.cfg";
            string A;
            bool IsOK = true;
            FileSystem.FileOpen(2, TerrainFile, OpenMode.Input);
            A = FileSystem.LineInput(2);
            FileSystem.FileClose();
            if (A != "//------------------------------------------------------------------------")
                IsOK = false;
            if (IsOK)
                return;
            A = "The modified FSX terrain.cfg file authored by Richard Ludowise" + Environment.NewLine;
            A = A + "and Luis Fйliz-Tirado was not detected in your system! For better" + Environment.NewLine;
            A = A + "results you should install this file. SBuilderX can make a backup" + Environment.NewLine;
            A = A + "of the original terrain.cfg and install the modified file for you." + Environment.NewLine + Environment.NewLine;
            A = A + "Do you want to install the modified terrain.cfg?" + Environment.NewLine;
            if (MessageBox.Show(A, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                A = "Enter a filename to store the original terrain.cfg.";
                string BackUpFile = Interaction.InputBox(A, DefaultResponse: "terrain_original.cfg");
                if (string.IsNullOrEmpty(BackUpFile))
                    return;
                BackUpFile = moduleMAIN.FSPath + BackUpFile;
                File.Copy(TerrainFile, BackUpFile, true);
                string ModTerrainFile = moduleMAIN.AppPath + @"\Tools\terrain.cfg";
                File.Copy(ModTerrainFile, TerrainFile, true);
            }
            else
            {
                A = "If you want to keep your present terrain.cfg and" + Environment.NewLine;
                A = A + "force SBuilderX to ignore this test, answer YES!";
                if (MessageBox.Show(A, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    moduleMAIN.OriginalTerrainCFG = true;
                    moduleFILE_IO.WriteSettings();
                }
            }
        }

        private void NewMenuItem_Click(object sender, EventArgs e)
        {
            NewProject();
        }

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            string b;
            string a, FileName;
            lbDonation.Visible = false;
            if (moduleMAIN.Dirty)
            {
                // MsgBox("You did not save your data! Continue ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2)
                // If MsgBoxResult.Yes Then ' User chose Yes.
                // Else ' User chose No.
                // Exit Sub
                // End If

                a = "You did not save your data! Continue ?";
                if (MessageBox.Show(a, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            a = "SBuilderX (*.SBP)|*.SBP";
            b = "SBuilderX - Open Project";
            FileName = moduleFILE_IO.FileNameToOpen(a, b, "SBP");
            if (string.IsNullOrEmpty(FileName))
                return;
            FileOpenHeader();
            moduleFILE_IO.OpenFile(FileName);
            moduleMAIN.WorkFile = FileName;
            FileOpenTrailer();
        }

        private void FileOpenHeader()
        {
            int N;
            DisableSelections(true);
            int loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
                moduleMAPS.ImgMaps[N].Dispose();
            moduleMAPS.Maps = new moduleMAPS.Map[1];
            moduleMAPS.ImgMaps = new Image[1];
            moduleCLASSES.LLands = new byte[257, 257, 1];
            moduleCLASSES.LL_XY = new moduleCLASSES.LWXY[96, 64];
            moduleLINES.Lines = new moduleLINES.GLine[1];
            modulePOLYS.Polys = new modulePOLYS.GPoly[1];
            moduleCLASSES.WWaters = new byte[257, 257, 1];
            moduleCLASSES.WW_XY = new moduleCLASSES.LWXY[96, 64];
            moduleCLASSES.LWCIs = new moduleCLASSES.LWCIndex[1];
            moduleOBJECTS.Objects = new moduleOBJECTS.Objecto[1];
            moduleEXCLUDES.Excludes = new moduleEXCLUDES.Exclude[1];
        }

        private void FileOpenTrailer()
        {
            MakeAllOff();
            moduleMAIN.ResetZoom();
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAPS.ShowSimpleMaps = false;
            if (moduleMAPS.NoOfMaps > 0)
            {
                moduleMAPS.ImgMaps = new Image[moduleMAPS.NoOfMaps + 1];
                moduleMAPS.CheckMaps();
            }

            Text = moduleMAIN.AppTitle + "  " + moduleMAIN.ProjectName.ToUpper();
            StatusStrip.Visible = true;
            moduleMAIN.Dirty = false;
            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUpInit();
            moduleMAIN.AircraftVIEW = false;
            UncheckToolButtons();
            UncheckViews();
            UncheckSelections();
            DisableToolButtons(false);
            DisableViews(false);
            DisableSeveralMenuItems(false);
            DisableOtherItems();
            moduleMAIN.LODLevel = -1;
            moduleMAIN.QMIDLevel = 0;
            ResetLevelGrid(true);
            StatusZoom.Text = "Zoom = " + moduleMAIN.Zoom.ToString();
            PointerMenuItem.Checked = true;
            PointerToolStripButton.Checked = true;
            MeasureToolMenuItem.Enabled = true;
            moduleMAIN.PointerON = true;
            Cursor = Cursors.Arrow;
            if (!string.IsNullOrEmpty(moduleMAIN.WorkFile))
            {
                SaveMenuItem.Enabled = true;
                SaveToolStripButton.Enabled = true;
            }

            moduleMAIN.DisplayWidth = ClientSize.Width;
            moduleMAIN.DisplayHeight = ClientSize.Height;
            moduleMAIN.BitmapBuffer = new Bitmap(moduleMAIN.DisplayWidth, moduleMAIN.DisplayHeight);
            BackColor = Color.White;
            moduleMAIN.Season = "Summer";
            moduleMAPS.SetBitmapSeason();
            moduleTILES.TileVIEW = false;
            ShowBackgroundMenuItem.Checked = false;
            if (!string.IsNullOrEmpty(moduleTILES.ActiveTileFolder))
            {
                ShowBackgroundMenuItem.Enabled = true;
            }
            else
            {
                ShowBackgroundMenuItem.Enabled = false;
            }

            moduleMAIN.ViewON = true;
            moduleMAIN.AllVIEW = false;
            ViewAllMenuItem_Click(null, null);
            moduleMAIN.SomeSelected = true;
            moduleMAIN.Dirty = false;
            lbDonation.Visible = false;
        }

        private void BGLMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmBGL.ShowDialog();
        }

        private void CopyMenuItem_Click(object sender, EventArgs e)
        {
            moduleEDIT.EditCopy();
        }

        private void SaveAsMenuItem_Click(object sender, EventArgs e)
        {
            int N;
            string a, b;
            a = "SBuilderX (*.SBP)|*.SBP";
            b = "SBuilderX - Save Project As";
            a = moduleFILE_IO.FileNameToSave(a, b, "SBP");
            if (string.IsNullOrEmpty(a))
                return;
            moduleMAIN.WorkFile = a;
            moduleFILE_IO.SaveFile(a);
            moduleFILE_IO.SetFileBackUp(a);
            moduleMAIN.Dirty = false;
            N = a.LastIndexOf(@"\") + 1;
            a = a.Substring(0, N);
            Text = moduleMAIN.AppTitle + "  " + moduleMAIN.ProjectName.ToUpper();
            SaveMenuItem.Enabled = true;
            SaveToolStripButton.Enabled = true;
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            moduleFILE_IO.SaveFile(moduleMAIN.WorkFile);
            moduleMAIN.Dirty = false;
        }

        private void RedoMenuItem_Click(object sender, EventArgs e)
        {
            moduleEDIT.Redo();
            moduleMAIN.RebuildDisplay();
        }

        private void UndoMenuItem_Click(object sender, EventArgs e)
        {
            moduleEDIT.Undo();
            moduleMAIN.RebuildDisplay();
        }

        private void LineMenuItem_Click(object sender, EventArgs e)
        {
            LineToolStripButton_Click(LineToolStripButton, new EventArgs());
        }

        private void ObjectMenuItem_Click(object sender, EventArgs e)
        {
            ObjectToolStripButton_Click(ObjectToolStripButton, new EventArgs());
        }

        private void PolyMenuItem_Click(object sender, EventArgs e)
        {
            PolyToolStripButton_Click(PolyToolStripButton, new EventArgs());
        }

        private void WaterMenuItem_Click(object sender, EventArgs e)
        {
            WaterToolStripButton_Click(WaterToolStripButton, new EventArgs());
        }

        private void ZoomMenuItem_Click(object sender, EventArgs e)
        {
            ZoomToolStripButton_Click(ZoomToolStripButton, new EventArgs());
        }

        private void CutMenuItem_Click(object sender, EventArgs e)
        {
            moduleEDIT.EditCut();
        }

        private void PasteMenuItem_Click(object sender, EventArgs e)
        {
            if (PasteMenuItem.Checked)
            {
                PasteMenuItem.Checked = false;
                moduleEDIT.PasteON = false;
            }
            else
            {
                PasteMenuItem.Checked = true;
                moduleEDIT.PasteON = true;
            }

            SetMouseIcon();
        }

        private void MeshMenuItem_Click(object sender, EventArgs e)
        {
            MeshToolStripButton_Click(MeshToolStripButton, new EventArgs());
        }

        private void ViewAllMapsMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleMAPS.MapVIEW)
            {
                ViewAllMapsMenuItem.Checked = false;
                bool argFlag = false;
                moduleMAPS.SelectAllMaps(ref argFlag);
                SelectAllMapsMenuItem.Enabled = false;
            }
            else
            {
                ViewAllMapsMenuItem.Checked = true;
                SelectAllMapsMenuItem.Enabled = true;
            }

            moduleMAPS.MapVIEW = !moduleMAPS.MapVIEW;
            if (moduleMAPS.NoOfMaps > 0)
                moduleMAIN.RebuildDisplay();
        }

        private void ViewAllWatersMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleCLASSES.WaterON)
            {
                SelectAllWatersMenuItem.Enabled = true;
                ViewAllWatersMenuItem.Checked = true;
                moduleCLASSES.WaterVIEW = true;
                return;
            }

            if (moduleCLASSES.WaterVIEW)
            {
                ViewAllWatersMenuItem.Checked = false;
                bool argFlag = false;
                moduleCLASSES.SelectAllWaters(ref argFlag);
                SelectAllWatersMenuItem.Enabled = false;
            }
            else
            {
                ViewAllWatersMenuItem.Checked = true;
                SelectAllWatersMenuItem.Enabled = true;
            }

            moduleCLASSES.WaterVIEW = !moduleCLASSES.WaterVIEW;
            if (moduleCLASSES.NoOfWaters > 0)
                moduleMAIN.RebuildDisplay();
        }

        private void ViewAllLinesMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleLINES.LineON)
            {
                SelectAllLinesMenuItem.Enabled = true;
                ViewAllLinesMenuItem.Checked = true;
                moduleLINES.LineVIEW = true;
                return;
            }

            if (moduleLINES.LineVIEW)
            {
                ViewAllLinesMenuItem.Checked = false;
                bool argFlag = false;
                moduleLINES.SelectAllLines(ref argFlag);
                SelectAllLinesMenuItem.Enabled = false;
            }
            else
            {
                ViewAllLinesMenuItem.Checked = true;
                SelectAllLinesMenuItem.Enabled = true;
            }

            moduleLINES.LineVIEW = !moduleLINES.LineVIEW;
            if (moduleLINES.NoOfLines > 0)
                moduleMAIN.RebuildDisplay();
        }

        private void ViewAllPolysMenuItem_Click(object sender, EventArgs e)
        {
            if (modulePOLYS.PolyON)
            {
                SelectAllPolysMenuItem.Enabled = true;
                ViewAllPolysMenuItem.Checked = true;
                modulePOLYS.PolyVIEW = true;
                return;
            }

            if (modulePOLYS.PolyVIEW)
            {
                ViewAllPolysMenuItem.Checked = false;
                bool argFlag = false;
                modulePOLYS.SelectAllPolys(ref argFlag);
                SelectAllPolysMenuItem.Enabled = false;
            }
            else
            {
                ViewAllPolysMenuItem.Checked = true;
                SelectAllPolysMenuItem.Enabled = true;
            }

            modulePOLYS.PolyVIEW = !modulePOLYS.PolyVIEW;
            if (modulePOLYS.NoOfPolys > 0)
                moduleMAIN.RebuildDisplay();
        }

        private void ViewAllExcludesMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleEXCLUDES.ExcludeON)
            {
                SelectAllExcludesMenuItem.Enabled = true;
                ViewAllExcludesMenuItem.Checked = true;
                moduleEXCLUDES.ExcludeVIEW = true;
                return;
            }

            if (moduleEXCLUDES.ExcludeVIEW)
            {
                ViewAllExcludesMenuItem.Checked = false;
                bool argFlag = false;
                moduleEXCLUDES.SelectAllExcludes(ref argFlag);
                SelectAllExcludesMenuItem.Enabled = false;
            }
            else
            {
                ViewAllExcludesMenuItem.Checked = true;
                SelectAllExcludesMenuItem.Enabled = true;
            }

            moduleEXCLUDES.ExcludeVIEW = !moduleEXCLUDES.ExcludeVIEW;
            if (moduleEXCLUDES.NoOfExcludes > 0)
                moduleMAIN.RebuildDisplay();
        }

        private void ViewAllLandsMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleCLASSES.LandON)
            {
                SelectAllLandsMenuItem.Enabled = true;
                ViewAllLandsMenuItem.Checked = true;
                moduleCLASSES.LandVIEW = true;
                return;
            }

            if (moduleCLASSES.LandVIEW)
            {
                ViewAllLandsMenuItem.Checked = false;
                bool argFlag = false;
                moduleCLASSES.SelectAllLands(ref argFlag);
                SelectAllLandsMenuItem.Enabled = false;
            }
            else
            {
                ViewAllLandsMenuItem.Checked = true;
                SelectAllLandsMenuItem.Enabled = true;
            }

            moduleCLASSES.LandVIEW = !moduleCLASSES.LandVIEW;
            if (moduleCLASSES.NoOfLands > 0)
                moduleMAIN.RebuildDisplay();
        }

        private void ViewAllObjectsMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleOBJECTS.ObjectON)
            {
                SelectAllObjectsMenuItem.Enabled = true;
                ViewAllObjectsMenuItem.Checked = true;
                moduleOBJECTS.ObjectVIEW = true;
                return;
            }

            if (moduleOBJECTS.ObjectVIEW)
            {
                ViewAllObjectsMenuItem.Checked = false;
                bool argFlag = false;
                moduleOBJECTS.SelectAllObjects(ref argFlag);
                SelectAllObjectsMenuItem.Enabled = false;
            }
            else
            {
                ViewAllObjectsMenuItem.Checked = true;
                SelectAllObjectsMenuItem.Enabled = true;
            }

            moduleOBJECTS.ObjectVIEW = !moduleOBJECTS.ObjectVIEW;
            if (moduleOBJECTS.NoOfObjects > 0)
                moduleMAIN.RebuildDisplay();
        }

        private void WaterToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            WaterMenuItem.Checked = true;
            WaterToolStripButton.Checked = true;
            moduleCLASSES.WaterON = true;
            SetMouseIcon();
            ViewAllWatersMenuItem_Click(ViewAllWatersMenuItem, new EventArgs());
            UncheckSelections();
            DisableSelections(true);
            SelectAllWatersMenuItem.Enabled = true;

            // Level15MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 15;
            ResetLevelGrid(true);
            modulePOPUP.POPIndex = -1;
            My.MyProject.Forms.FrmWatersP.Show();
            // Zoom = 10
            // SetDispCenter(0, 0)
            // Me.StatusZoom.Text = "Zoom = " & CStr(Zoom)
            moduleMAIN.RebuildDisplay();
        }

        private void BGLToolStripButton_Click(object sender, EventArgs e)
        {
            BGLMenuItem_Click(BGLMenuItem, new EventArgs());
        }

        private void CopyToolStripButton_Click(object sender, EventArgs e)
        {
            CopyMenuItem_Click(CopyMenuItem, new EventArgs());
        }

        private void ExcludeToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            ExcludeMenuItem.Checked = true;
            ExcludeToolStripButton.Checked = true;
            moduleEXCLUDES.ExcludeON = true;
            SetMouseIcon();
            ViewAllExcludesMenuItem_Click(ViewAllExcludesMenuItem, new EventArgs());
            UncheckSelections();
            DisableSelections(true);
            SelectAllExcludesMenuItem.Enabled = true;
            moduleMAIN.RebuildDisplay();
        }

        private void LandToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            LandMenuItem.Checked = true;
            LandToolStripButton.Checked = true;
            moduleCLASSES.LandON = true;
            SetMouseIcon();
            ViewAllLandsMenuItem_Click(ViewAllLandsMenuItem, new EventArgs());
            UncheckSelections();
            DisableSelections(true);
            SelectAllLandsMenuItem.Enabled = true;

            // Level15MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 15;
            ResetLevelGrid(true);
            modulePOPUP.POPIndex = -1;
            My.MyProject.Forms.FrmLandsP.Show();
            // Zoom = 10
            // SetDispCenter(0, 0)
            // Me.StatusZoom.Text = "Zoom = " & CStr(Zoom)
            moduleMAIN.RebuildDisplay();
        }

        private void LineToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            LineMenuItem.Checked = true;
            LineToolStripButton.Checked = true;
            MeasureToolMenuItem.Enabled = true;
            moduleLINES.LineON = true;
            SetMouseIcon();
            ViewAllLinesMenuItem_Click(ViewAllLinesMenuItem, new EventArgs());
            UncheckSelections();
            DisableSelections(true);
            SelectAllLinesMenuItem.Enabled = true;
            moduleMAIN.RebuildDisplay();
        }

        private void MeshToolStripButton_Click(object sender, EventArgs e)
        {

            // Dim A As String

            // MakeAllOff()
            // UncheckToolButtons()
            // MeshMenuItem.Checked = True
            // MeshToolStripButton.Checked = True
            // MeshON = True
            // SetMouseIcon()
            // ViewAllMeshesMenuItem_Click(ViewAllMeshesMenuItem, New System.EventArgs())
            // UncheckSelections()
            // DisableSelections(True)
            // SelectAllMeshesMenuItem.Enabled = True
            // ResetLevelGrid()
            // Level15MenuItem.Checked = True
            // QMIDLevel = 15
            // 'frmMeshesP.Show()
            // Zoom = 8
            // SetDispCenter(0, 0)
            // Me.StatusZoom.Text = "Zoom = " & CStr(Zoom)
            // If Not ViewAllMeshesMenuItem.Checked Then ViewAllMeshesMenuItem_Click(ViewAllMeshesMenuItem, New System.EventArgs())
            // RebuildDisplay()
            // A = "You should unset the 8-bit/meter option" & vbCrLf
            // A = A & "in the Preferences menu!"
            // If Mesh8 Then MsgBox(A, MsgBoxStyle.Information)

        }

        private void NewToolStripButton_Click(object sender, EventArgs e)
        {
            NewMenuItem_Click(NewMenuItem, new EventArgs());
        }

        private void ObjectToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            ObjectMenuItem.Checked = true;
            ObjectToolStripButton.Checked = true;
            MeasureToolMenuItem.Enabled = true;
            moduleOBJECTS.ObjectON = true;
            SetMouseIcon();
            ViewAllObjectsMenuItem_Click(ViewAllObjectsMenuItem, new EventArgs());
            UncheckSelections();
            DisableSelections(true);
            SelectAllObjectsMenuItem.Enabled = true;
            moduleMAIN.RebuildDisplay();
        }

        private void OpenToolStripButton_Click(object sender, EventArgs e)
        {
            OpenMenuItem_Click(OpenMenuItem, new EventArgs());
        }

        private void PasteToolStripButton_Click(object sender, EventArgs e)
        {
            PasteMenuItem_Click(PasteMenuItem, new EventArgs());
        }

        private void PointerToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            PointerMenuItem.Checked = true;
            PointerToolStripButton.Checked = true;
            MeasureToolMenuItem.Enabled = true;
            moduleMAIN.PointerON = true;
            SetMouseIcon();
            UncheckSelections();
            DisableSelections(false);
            moduleMAIN.RebuildDisplay();
        }

        private void PointerMenuItem_Click(object sender, EventArgs e)
        {
            PointerToolStripButton_Click(PointerToolStripButton, new EventArgs());
        }

        private void PolyToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            PolyMenuItem.Checked = true;
            PolyToolStripButton.Checked = true;
            MeasureToolMenuItem.Enabled = true;
            modulePOLYS.PolyON = true;
            SetMouseIcon();
            ViewAllPolysMenuItem_Click(ViewAllPolysMenuItem, new EventArgs());
            UncheckSelections();
            DisableSelections(true);
            SelectAllPolysMenuItem.Enabled = true;
            moduleMAIN.RebuildDisplay();
        }

        private void SaveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveMenuItem_Click(SaveMenuItem, new EventArgs());
        }

        private void UndoToolStripButton_Click(object sender, EventArgs e)
        {
            UndoMenuItem_Click(UndoMenuItem, new EventArgs());
        }

        private void RedoToolStripButton_Click(object sender, EventArgs e)
        {
            RedoMenuItem_Click(RedoMenuItem, new EventArgs());
        }

        private void ZoomToolStripButton_Click(object sender, EventArgs e)
        {
            MakeAllOff();
            UncheckToolButtons();
            ZoomMenuItem.Checked = true;
            ZoomToolStripButton.Checked = true;
            moduleMAIN.ZoomON = true;
            SetMouseIcon();
            UncheckSelections();
            DisableSelections(false);
            moduleMAIN.RebuildDisplay();
        }

        private void ExcludeMenuItem_Click(object sender, EventArgs e)
        {
            ExcludeToolStripButton_Click(ExcludeToolStripButton, new EventArgs());
        }

        private void LandMenuItem_Click(object sender, EventArgs e)
        {
            LandToolStripButton_Click(LandToolStripButton, new EventArgs());
        }

        private void ViewAllMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleMAIN.AllVIEW)
            {
                // hide all and unselect all

                UnSelectAll();
                moduleMAIN.AllSELECT = false;
                moduleMAPS.MapVIEW = false;
                if (!moduleCLASSES.LandON)
                    moduleCLASSES.LandVIEW = false;
                if (!moduleLINES.LineON)
                    moduleLINES.LineVIEW = false;
                if (!modulePOLYS.PolyON)
                    modulePOLYS.PolyVIEW = false;
                if (!moduleCLASSES.WaterON)
                    moduleCLASSES.WaterVIEW = false;
                if (!moduleOBJECTS.ObjectON)
                    moduleOBJECTS.ObjectVIEW = false;
                if (!moduleEXCLUDES.ExcludeON)
                    moduleEXCLUDES.ExcludeVIEW = false;
                ViewAllMapsMenuItem.Checked = false;
                if (!moduleCLASSES.LandON)
                    ViewAllLandsMenuItem.Checked = false;
                if (!moduleLINES.LineON)
                    ViewAllLinesMenuItem.Checked = false;
                if (!modulePOLYS.PolyON)
                    ViewAllPolysMenuItem.Checked = false;
                if (!moduleCLASSES.WaterON)
                    ViewAllWatersMenuItem.Checked = false;
                if (!moduleOBJECTS.ObjectON)
                    ViewAllObjectsMenuItem.Checked = false;
                if (!moduleEXCLUDES.ExcludeON)
                    ViewAllExcludesMenuItem.Checked = false;
                ViewAllMenuItem.Checked = false;
                SelectAllMapsMenuItem.Enabled = false;
                if (!moduleCLASSES.LandON)
                    SelectAllLandsMenuItem.Enabled = false;
                if (!moduleLINES.LineON)
                    SelectAllLinesMenuItem.Enabled = false;
                if (!modulePOLYS.PolyON)
                    SelectAllPolysMenuItem.Enabled = false;
                if (!moduleCLASSES.WaterON)
                    SelectAllWatersMenuItem.Enabled = false;
                if (!moduleOBJECTS.ObjectON)
                    SelectAllObjectsMenuItem.Enabled = false;
                if (!moduleEXCLUDES.ExcludeON)
                    SelectAllExcludesMenuItem.Enabled = false;
                SelectAllMenuItem.Enabled = false;
                SelectAllMapsMenuItem.Checked = false;
                if (!moduleCLASSES.LandON)
                    SelectAllLandsMenuItem.Checked = false;
                if (!moduleLINES.LineON)
                    SelectAllLinesMenuItem.Checked = false;
                if (!modulePOLYS.PolyON)
                    SelectAllPolysMenuItem.Checked = false;
                if (!moduleCLASSES.WaterON)
                    SelectAllWatersMenuItem.Checked = false;
                if (!moduleOBJECTS.ObjectON)
                    SelectAllObjectsMenuItem.Checked = false;
                if (!moduleEXCLUDES.ExcludeON)
                    SelectAllExcludesMenuItem.Checked = false;
                SelectAllMenuItem.Checked = false;
            }
            else
            {
                // show all
                moduleMAPS.MapVIEW = true;
                moduleCLASSES.LandVIEW = true;
                moduleLINES.LineVIEW = true;
                modulePOLYS.PolyVIEW = true;
                moduleCLASSES.WaterVIEW = true;
                moduleOBJECTS.ObjectVIEW = true;
                moduleEXCLUDES.ExcludeVIEW = true;
                ViewAllMapsMenuItem.Checked = true;
                ViewAllLandsMenuItem.Checked = true;
                ViewAllLinesMenuItem.Checked = true;
                ViewAllPolysMenuItem.Checked = true;
                ViewAllWatersMenuItem.Checked = true;
                ViewAllObjectsMenuItem.Checked = true;
                ViewAllExcludesMenuItem.Checked = true;
                ViewAllMenuItem.Checked = true;
                if (moduleMAIN.ZoomON | moduleMAIN.PointerON)
                {
                    SelectAllMapsMenuItem.Enabled = true;
                    SelectAllLandsMenuItem.Enabled = true;
                    SelectAllLinesMenuItem.Enabled = true;
                    SelectAllPolysMenuItem.Enabled = true;
                    SelectAllWatersMenuItem.Enabled = true;
                    SelectAllObjectsMenuItem.Enabled = true;
                    SelectAllExcludesMenuItem.Enabled = true;
                    SelectAllMenuItem.Enabled = true;
                }
            }

            moduleMAIN.RebuildDisplay();
            moduleMAIN.AllVIEW = !moduleMAIN.AllVIEW;
        }

        private void SelectAllExcludesMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllExcludesMenuItem.Checked)
            {
                bool argFlag = false;
                moduleEXCLUDES.SelectAllExcludes(ref argFlag);
            }
            else
            {
                bool argFlag1 = true;
                moduleEXCLUDES.SelectAllExcludes(ref argFlag1);
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SelectAllLandsMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllLandsMenuItem.Checked)
            {
                bool argFlag = false;
                moduleCLASSES.SelectAllLands(ref argFlag);
            }
            else
            {
                bool argFlag1 = true;
                moduleCLASSES.SelectAllLands(ref argFlag1);
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SelectAllLinesMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllLinesMenuItem.Checked)
            {
                bool argFlag = false;
                moduleLINES.SelectAllLines(ref argFlag);
            }
            else
            {
                bool argFlag1 = true;
                moduleLINES.SelectAllLines(ref argFlag1);
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SelectAllMapsMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllMapsMenuItem.Checked)
            {
                bool argFlag = false;
                moduleMAPS.SelectAllMaps(ref argFlag);
            }
            else
            {
                bool argFlag1 = true;
                moduleMAPS.SelectAllMaps(ref argFlag1);
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SelectAllObjectsMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllObjectsMenuItem.Checked)
            {
                bool argFlag = false;
                moduleOBJECTS.SelectAllObjects(ref argFlag);
            }
            else
            {
                bool argFlag1 = true;
                moduleOBJECTS.SelectAllObjects(ref argFlag1);
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SelectAllPolysMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllPolysMenuItem.Checked)
            {
                bool argFlag = false;
                modulePOLYS.SelectAllPolys(ref argFlag);
            }
            else
            {
                bool argFlag1 = true;
                modulePOLYS.SelectAllPolys(ref argFlag1);
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SelectAllWatersMenuItem_Click(object sender, EventArgs e)
        {
            if (SelectAllWatersMenuItem.Checked)
            {
                bool argFlag = false;
                moduleCLASSES.SelectAllWaters(ref argFlag);
            }
            else
            {
                bool argFlag1 = true;
                moduleCLASSES.SelectAllWaters(ref argFlag1);
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SelectAllMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleMAIN.AllSELECT)
            {
                // unselect all

                bool argFlag = false;
                moduleCLASSES.SelectAllLands(ref argFlag);
                bool argFlag1 = false;
                moduleLINES.SelectAllLines(ref argFlag1);
                bool argFlag2 = false;
                modulePOLYS.SelectAllPolys(ref argFlag2);
                bool argFlag3 = false;
                moduleCLASSES.SelectAllWaters(ref argFlag3);
                bool argFlag4 = false;
                moduleOBJECTS.SelectAllObjects(ref argFlag4);
                bool argFlag5 = false;
                moduleEXCLUDES.SelectAllExcludes(ref argFlag5);
                bool argFlag6 = false;
                moduleMAPS.SelectAllMaps(ref argFlag6);
                SelectAllMenuItem.Checked = false;
            }
            else
            {
                // select all
                bool argFlag7 = true;
                moduleCLASSES.SelectAllLands(ref argFlag7);
                bool argFlag8 = true;
                moduleLINES.SelectAllLines(ref argFlag8);
                bool argFlag9 = true;
                modulePOLYS.SelectAllPolys(ref argFlag9);
                bool argFlag10 = true;
                moduleCLASSES.SelectAllWaters(ref argFlag10);
                bool argFlag11 = true;
                moduleOBJECTS.SelectAllObjects(ref argFlag11);
                bool argFlag12 = true;
                moduleEXCLUDES.SelectAllExcludes(ref argFlag12);
                bool argFlag13 = true;
                moduleMAPS.SelectAllMaps(ref argFlag13);
                SelectAllMenuItem.Checked = true;
            }

            moduleMAIN.RebuildDisplay();
            moduleMAIN.AllSELECT = !moduleMAIN.AllSELECT;
        }

        private void ShowToolbarMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowToolbarMenuItem.Checked)
            {
                ShowToolbarMenuItem.Checked = false;
                ToolStrip.Visible = false;
            }
            else
            {
                ShowToolbarMenuItem.Checked = true;
                ToolStrip.Visible = true;
            }

            ViewMenuItem.ShowDropDown();
        }

        private void FrmStart_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            short Shift = (short)((int)ModifierKeys / 0x10000);
            int X = e.X;
            int Y = e.Y;
            if (!moduleMAIN.ViewON)
                return;
            if (moduleMAIN.WAIT)
                return;
            if (KeyRightMouse & Button == 1)
            {
                Button = 2;
                KeyRightMouse = false;
            }

            if (Button == 2 & moduleMAIN.InsertON)
            {
                moduleMAIN.InsertON = false;
                return;
            }

            if (Button == 2 & moduleEDIT.PasteON)
            {
                moduleEDIT.PasteON = false;
                PasteMenuItem.Checked = false;
                SetMouseIcon();
                return;
            }

            if (Button == 2 & MeasureTool)
            {
                MeasureTool = false;
                MeasureON = false;
                MeasureToolMenuItem.Checked = false;
                TextBoxMeasure.Visible = false;
                SetMouseIcon();
                return;
            }

            // we are in zoom mode
            if (moduleMAIN.ZoomON)
            {
                if (!(Button == 1 | Button == 2))
                    return;
                moduleMAIN.SetDispCenter(X - moduleMAIN.DisplayCenterX, Y - moduleMAIN.DisplayCenterY);
                ZoomInOut(Button);
                moduleMAIN.SetDispCenter(0, 0);
                moduleMAIN.RebuildDisplay();
                modulePOPUP.HidePopUPMenu();
                return;
            }

            if (KeyZoomRollON)
            {
                moduleMAIN.AuxXInt = X;
                moduleMAIN.AuxYInt = Y;
                ZoomRollON = true;
                return;
            }

            // starting of a pan movement
            if (Button == 4 | KeyPanON)
            {
                Cursor = new Cursor(CursorPath + "pan.cur");
                moduleMAIN.AuxXInt = X;
                moduleMAIN.AuxYInt = Y;
                moduleMAIN.PanON = true;
                return;
            }

            moduleLINES.CheckLine = 0;
            modulePOLYS.CheckPoly = 0;
            if (Button == 1 & moduleEDIT.PasteON)
            {
                moduleEDIT.EditPasteXY(X, ref Y);
                return;
            }

            if (moduleMAPS.CalibratePT1)
            {
                My.MyProject.Forms.FrmCalibrate.ReturnCalPT1(Button, X, Y);
                My.MyProject.Forms.FrmCalibrate.Show();
                return;
            }

            if (moduleMAPS.CalibratePT2)
            {
                My.MyProject.Forms.FrmCalibrate.ReturnCalPT2(Button, X, Y);
                My.MyProject.Forms.FrmCalibrate.Show();
                return;
            }

            if (moduleCLASSES.LColPickON)
            {
                ColorFromMap(X, Y);
                moduleCLASSES.LColPickON = false;
                return;
            }

            // start of a selection or a movement or a measurement in Pointer mode
            if (Button == 1 & moduleMAIN.PointerON)
            {
                if (SelectParent)
                {
                    modulePOLYS.TryParentPoly(X, Y);
                    SelectParent = false;
                    return;
                }

                if (Shift == 0)
                    UnSelectAll();
                if (moduleMAIN.IsSelection(X, Y)) // movement
                {
                    moduleMAIN.SomeSelected = true;
                    moduleMAIN.RebuildDisplay();
                    moduleMAIN.SetDelay(200);
                    moduleMAIN.MoveON = true;
                    moduleMAIN.FirstMOVE = true;
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                }
                else if (MeasureTool)
                {
                    if (MeasureON)
                    {
                        MeasureON = false;
                    }
                    else
                    {
                        moduleMAIN.AuxXInt = X;
                        moduleMAIN.AuxYInt = Y;
                        MeasureON = true;
                        return;
                    }
                }
                else // selection
                {
                    moduleMAIN.SelectON = true;
                    SetMouseIcon();
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                }

                return;
            }

            if (Button == 2 & moduleMAIN.PointerON)
            {
                SelectParent = false;
                modulePOPUP.ProcessPopUp(X, Y);
                return;
            }


            // we are in line insert mode
            if (moduleLINES.LineON)
            {
                if (!(SelectWindow | MeasureTool))  // is the start of new line
                {
                    moduleLINES.LineInsertMode(Button, Shift, X, Y);
                    return;
                }
                else if (SelectWindow)  // is a selection
                {
                    if (Shift == 2)
                        UnSelectAll();
                    moduleMAIN.SelectON = true;
                    SetMouseIcon();
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                    return;
                }
                else if (Button == 1)  // =2 then the routine goes on to exit on a commom point
                {
                    if (MeasureON)
                    {
                        MeasureON = false;
                    }
                    else
                    {
                        moduleMAIN.AuxXInt = X;
                        moduleMAIN.AuxYInt = Y;
                        MeasureON = true;
                        return;
                    }
                }
            }

            // we are in poly insert mode
            if (modulePOLYS.PolyON)
            {
                if (SelectParent)
                {
                    if (Button == 1)
                    {
                        modulePOLYS.TryParentPoly(X, Y);
                        SelectParent = false;
                    }
                    else if (Button == 2)
                    {
                        SelectParent = false;
                        modulePOPUP.ProcessPopUp(X, Y);
                    }

                    return;
                }

                if (!(SelectWindow | MeasureTool))  // is the start of new poly
                {
                    modulePOLYS.PolyInsertMode(ref Button, ref Shift, X, Y);
                    return;
                }
                else if (SelectWindow)  // is a selection
                {
                    if (Shift == 2)
                        UnSelectAll();
                    moduleMAIN.SelectON = true;
                    SetMouseIcon();
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                    return;
                }
                else if (Button == 1)  // =2 then the routine goes on to exit on a commom point
                {
                    if (MeasureON)
                    {
                        MeasureON = false;
                    }
                    else
                    {
                        moduleMAIN.AuxXInt = X;
                        moduleMAIN.AuxYInt = Y;
                        MeasureON = true;
                        return;
                    }
                }
            }

            // we are in object insert mode
            if (moduleOBJECTS.ObjectON)
            {
                if (!(SelectWindow | MeasureTool))  // is the start of new object
                {
                    moduleOBJECTS.ObjectInsertMode(ref Button, ref Shift, X, Y);
                    return;
                }
                else if (SelectWindow)  // is a selection
                {
                    if (Shift == 2)
                        UnSelectAll();
                    moduleMAIN.SelectON = true;
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                    return;
                }
                else if (Button == 1)  // =2 then the routine goes on to exit on a commom point
                {
                    if (MeasureON)
                    {
                        MeasureON = false;
                    }
                    else
                    {
                        moduleMAIN.AuxXInt = X;
                        moduleMAIN.AuxYInt = Y;
                        MeasureON = true;
                        return;
                    }
                }
            }


            // we are in exclude insert mode
            if (moduleEXCLUDES.ExcludeON)
            {
                moduleEXCLUDES.ExcludeInsertMode(ref Button, ref Shift, X, Y);
                return;
            }

            // If PhotoON Then
            // 'PhotoInsertMode(Button, XD, YD)
            // Exit Sub
            // End If

            // If MeshON Then
            // 'MeshInsertMode(Button, XD, YD)
            // Exit Sub
            // End If

            if (moduleCLASSES.LandON)
            {
                if (moduleCLASSES.LandWaterDELETE & Button == 1)
                {
                    moduleCLASSES.DeleteLand(X, Y);
                    moduleMAIN.Dirty = true;
                    moduleMAIN.RebuildDisplay();
                    return;
                }

                if (moduleCLASSES.LandWaterRASTER & Button == 1)
                    moduleCLASSES.LandWaterRasON = true;
                moduleCLASSES.LandInsertMode(ref Button, X, Y);
                return;
            }

            if (moduleCLASSES.WaterON)
            {
                if (moduleCLASSES.LandWaterDELETE & Button == 1)
                {
                    moduleCLASSES.DeleteWater(X, Y);
                    moduleMAIN.Dirty = true;
                    moduleMAIN.RebuildDisplay();
                    return;
                }

                if (moduleCLASSES.LandWaterRASTER & Button == 1)
                    moduleCLASSES.LandWaterRasON = true;
                moduleCLASSES.WaterInsertMode(ref Button, X, Y);
                return;
            }
        }

        private void FrmStart_MouseMove(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            short Shift = (short)((int)ModifierKeys / 0x10000);
            int X = e.X;
            int Y = e.Y;
            int N, M = default;
            if (moduleMAIN.WAIT)
                return;
            ShowLatLon(X, Y);
            if (KeyRightMouse & Button == 1)
                Button = 2;

            // doing the actual pan
            if (moduleMAIN.PanON)
            {
                moduleMAIN.SetDispCenter(moduleMAIN.AuxXInt - X, moduleMAIN.AuxYInt - Y);
                moduleMAIN.AuxXInt = X;
                moduleMAIN.AuxYInt = Y;
                moduleMAIN.RebuildDisplay();
                if (moduleLINES.PtLineCounter > 0)
                    DrawLineSegment(moduleMAIN.AuxXInt - X, moduleMAIN.AuxYInt - Y);
                if (modulePOLYS.PtPolyCounter > 0)
                    DrawPolySegment(moduleMAIN.AuxXInt - X, moduleMAIN.AuxYInt - Y);
                return;
            }

            if (KeyPanON)
                return;

            // doing a rolled zoom = pressed Z and using a non-wheel mouse!
            if (ZoomRollON)
            {
                if (Y - moduleMAIN.AuxYInt > 50)
                {
                    ZoomInOut(1);
                    moduleMAIN.AuxYInt = Y;
                }

                if (moduleMAIN.AuxYInt - Y > 50)
                {
                    ZoomInOut(2);
                    moduleMAIN.AuxYInt = Y;
                }

                moduleMAIN.SetDispCenter(0, 0);
                moduleMAIN.RebuildDisplay();
                return;
            }

            if (KeyZoomRollON)
                return;
            if (SelectParent)
            {
                DrawParentSelectLabel(X, Y);
                return;
            }

            // doing the actual selecting moving box
            if (moduleMAIN.SelectON)
            {
                DrawSelectBox(X, Y);
                return;
            }

            if (MeasureTool)
            {
                if (MeasureON)
                {
                    ShowMeasure(X, Y);
                }

                return;
            }

            // doing the actual MOVE 60 ms after the mouse click
            if (moduleMAIN.MoveON)
            {
                if (moduleMAIN.FirstMOVE)
                {
                    moduleEDIT.BackUp();
                    moduleMAIN.FirstMOVE = false;
                    SetMouseIcon();
                }

                if (moduleMAIN.DELAY)
                    return;
                X = X - moduleMAIN.AuxXInt;
                Y = Y - moduleMAIN.AuxYInt;
                moduleMAIN.AuxXInt = moduleMAIN.AuxXInt + X;
                moduleMAIN.AuxYInt = moduleMAIN.AuxYInt + Y;
                moduleMAIN.MoveSelected(X, Y);
                moduleMAIN.RebuildDisplay();
                return;
            }

            if (moduleMAPS.CalibratePT1 | moduleMAPS.CalibratePT2)
            {
                // Me.Cursor = System.Windows.Forms.Cursors.Cross
                Cursor = new Cursor(CursorPath + "calib.cur");
                return;
            }

            if (moduleMAIN.PointerON)
            {
                if (moduleMAIN.ShowLabels)
                {
                    N = moduleLINES.IsMouseOnLine(X, Y);
                    if (N > 0)
                    {
                        DrawLineLabel(X, Y, N);
                        return;
                    }

                    N = modulePOLYS.IsMouseOnPoly(X, Y, ref M);
                    if (N > 0)
                    {
                        DrawPolyLabel(X, Y, N, 0);
                        return;
                    }

                    N = moduleOBJECTS.IsMouseOnObject(X, Y);
                    if (N > 0)
                    {
                        DrawObjectLabel(X, Y, N);
                        return;
                    }

                    UpdateDisplay();
                }

                return;
            }

            if (moduleLINES.LineON)
            {
                if (moduleLINES.LineTURN)
                {
                    moduleLINES.TurnLine(X, Y);
                    return;
                }

                if (moduleLINES.PtLineCounter > 0)
                {
                    moduleMAIN.AuxXInt = X;
                    moduleMAIN.AuxYInt = Y;
                    DrawLineSegment(X, Y);
                }
                else if (moduleMAIN.ShowLabels)
                {
                    N = moduleLINES.IsMouseOnLine(X, Y);
                    if (N > 0)
                    {
                        DrawLineLabel(X, Y, N);
                    }
                    else
                    {
                        UpdateDisplay();
                    }
                }

                return;
            }

            if (modulePOLYS.PolyON)
            {
                if (modulePOLYS.PtPolyCounter > 0)
                {
                    DrawPolySegment(X, Y);
                }
                else if (moduleMAIN.ShowLabels)
                {
                    N = modulePOLYS.IsMouseOnPoly(X, Y, ref M);
                    if (N > 0)
                    {
                        DrawPolyLabel(X, Y, N, M);
                    }
                    else
                    {
                        UpdateDisplay();
                    }
                }

                return;
            }

            if (moduleOBJECTS.ObjectTURN)
            {
                moduleOBJECTS.TurnObject(X, Y);
                return;
            }

            if (moduleOBJECTS.ObjectSIZE)
            {
                moduleOBJECTS.SizeObject(X, Y);
                return;
            }

            if (moduleEXCLUDES.ExcludeSizeIndex > 0)
            {
                moduleEXCLUDES.SizeExclude(X, Y, moduleEXCLUDES.ExcludeSizeIndex);
                return;
            }

            if (moduleEXCLUDES.DrawExclude)
            {
                DrawExcludeBox(X, Y);
                return;
            }

            if (moduleCLASSES.LandON & moduleCLASSES.LandWaterRasON)
            {
                moduleCLASSES.LandRasterMode(X, Y);
                return;
            }

            if (moduleCLASSES.WaterON & moduleCLASSES.LandWaterRasON)
            {
                moduleCLASSES.WaterRasterMode(X, Y);
                return;
            }
        }

        private void DrawSelectBox(int X, int Y)
        {
            int DX, DY;
            int PX, PY;
            Pen p = new Pen(Color.Red);
            Graphics g;
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g = CreateGraphics();
            if (moduleMAIN.BitmapBuffer is object)
                g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            DX = X - moduleMAIN.AuxXInt;
            DY = Y - moduleMAIN.AuxYInt;
            PX = moduleMAIN.AuxXInt;
            PY = moduleMAIN.AuxYInt;
            if (X < moduleMAIN.AuxXInt)
            {
                DX = moduleMAIN.AuxXInt - X;
                PX = X;
            }

            if (Y < moduleMAIN.AuxYInt)
            {
                DY = moduleMAIN.AuxYInt - Y;
                PY = Y;
            }

            g.DrawRectangle(p, new Rectangle(PX, PY, DX, DY));
            p.Dispose();
            g.Dispose();
        }

        private void DrawExcludeBox(int X, int Y)
        {
            int DX, DY;
            int PX, PY;
            Pen p = new Pen(Color.Black);
            Graphics g;
            p.Width = 2f;
            g = CreateGraphics();
            if (moduleMAIN.BitmapBuffer is object)
                g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            DX = X - moduleMAIN.AuxXInt;
            DY = Y - moduleMAIN.AuxYInt;
            PX = moduleMAIN.AuxXInt;
            PY = moduleMAIN.AuxYInt;
            if (X < moduleMAIN.AuxXInt)
            {
                DX = moduleMAIN.AuxXInt - X;
                PX = X;
            }

            if (Y < moduleMAIN.AuxYInt)
            {
                DY = moduleMAIN.AuxYInt - Y;
                PY = Y;
            }

            g.DrawRectangle(p, new Rectangle(PX, PY, DX, DY));
            p.Dispose();
            g.Dispose();
        }

        private void ShowLatLon(int X1, int Y1)
        {
            double Lon, Lat;
            double X, Y;
            int J, K;
            string A;
            Lon = moduleMAIN.LonDispWest + X1 / moduleMAIN.PixelsPerLonDeg;
            Lat = moduleMAIN.LatDispNorth - Y1 / moduleMAIN.PixelsPerLatDeg;
            StatusLat.Text = "   Latitude = " + moduleMAIN.Lat2Str(Lat);
            StatusLon.Text = "   Longitude = " + moduleMAIN.Lon2Str(Lon);
            if (moduleTILES.TileVIEW)
            {
                string BaseName = "L" + moduleMAIN.Zoom.ToString();
                J = moduleTILES.XTilesFromLon(Lon, moduleMAIN.Zoom);
                BaseName = BaseName + "X" + J.ToString();
                J = moduleTILES.YTilesFromLat(Lat, moduleMAIN.Zoom);
                BaseName = BaseName + "Y" + J.ToString();
                StatusTile.Text = "Tile = " + BaseName;
            }
            else
            {
                StatusTile.Text = "";
            }

            X = Lon + 180d;
            Y = 90d - Lat;
            J = (int)(X / 30d);
            K = (int)(Y / 22.5d);
            A = "Dir = " + J.ToString("00") + K.ToString("00") + "   File = ";
            J = (int)(X / 3.75d);
            K = (int)(Y / 2.825d);
            A = A + J.ToString("00") + K.ToString("00");
            StatusDir.Text = A;
            StatusQMID.Text = "";
            if (moduleMAIN.QMIDLevel > 1)
            {
                SetLatLonDeltas();
                J = (int)(X / LongitudeDelta);
                K = (int)(Y / LatitudeDelta);
                A = J.ToString("00") + K.ToString("00");
                StatusQMID.Text = "QMID (L = " + moduleMAIN.QMIDLevel + "  U = " + J.ToString("00") + "  V = " + K.ToString("00") + ") ";
            }

            StatusStrip.Refresh();
        }

        private void FrmStart_MouseUp(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            short Shift = (short)((int)ModifierKeys / 0x10000);
            int X = e.X;
            int Y = e.Y;
            moduleMAIN.SetDelay(0);
            if (Button == 2)
                moduleMAIN.InsertON = false;
            if (moduleMAIN.PanON)
            {
                moduleMAIN.SetDispCenter(moduleMAIN.AuxXInt - X, moduleMAIN.AuxYInt - Y);
                moduleMAIN.AuxXInt = X;
                moduleMAIN.AuxYInt = Y;
                MakeBackground();
                moduleMAIN.RebuildDisplay();
                moduleMAIN.PanON = false;
                SetMouseIcon();
                return;
            }

            if (ZoomRollON)
            {
                ZoomRollON = false;
                return;
            }

            if (moduleMAIN.SelectON)
            {
                moduleMAIN.SelectBoxed(X, Y);
                moduleMAIN.RebuildDisplay();
                moduleMAIN.SelectON = false;
                SetMouseIcon();
                return;
            }

            if (moduleEXCLUDES.DrawExclude)
            {
                DrawExcludeBox(X, Y);
                moduleEXCLUDES.DrawExclude = false;
                moduleEXCLUDES.FormExclude(X, Y);
                return;
            }

            if (moduleMAIN.MoveON)
            {
                moduleMAIN.MoveON = false;
                moduleMAIN.FirstMOVE = false;
                if (moduleLINES.LineON & moduleLINES.AutoLinePolyJoin)
                    moduleLINES.CheckLineJoins();
                if (modulePOLYS.PolyON & moduleLINES.AutoLinePolyJoin)
                    modulePOLYS.CheckPolyJoins();
                SetMouseIcon();
                return;
            }

            if (moduleOBJECTS.ObjectTURN)
            {
                moduleOBJECTS.ObjectTURN = false;
                SetMouseIcon();
                return;
            }

            if (moduleOBJECTS.ObjectSIZE)
            {
                moduleOBJECTS.ObjectSIZE = false;
                SetMouseIcon();
                return;
            }

            if (moduleLINES.LineTURN)
            {
                moduleLINES.LineTURN = false;
                SetMouseIcon();
                return;
            }

            if (moduleCLASSES.LandWaterRasON)
            {
                moduleCLASSES.LandWaterRasON = false;
                SetMouseIcon();
                return;
            }

            if (moduleEXCLUDES.ExcludeSizeIndex > 0)
            {
                moduleEXCLUDES.ExcludeSizeIndex = 0;
                SetMouseIcon();
                return;
            }

            SetMouseIcon();
        }

        private void FrmStart_MouseWheel(object sender, MouseEventArgs e)
        {
            int X = e.X;
            int Y = e.Y;
            if (moduleMAIN.WAIT)
                return;
            if (!moduleMAIN.ViewON)
                return;
            if (moduleMAIN.CenterOnMouseWheel)
            {
                moduleMAIN.SetDispCenter(X - moduleMAIN.DisplayCenterX, Y - moduleMAIN.DisplayCenterY);
            }

            if (e.Delta > 0)
                ZoomInOut(1);
            if (e.Delta < 0)
                ZoomInOut(2);
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
            if (moduleLINES.PtLineCounter > 0)
                DrawLineSegment(X, Y);
            if (modulePOLYS.PtPolyCounter > 0)
                DrawPolySegment(X, Y);
        }

        private void MeasureToolMenuItem_Click(object sender, EventArgs e)
        {
            if (MeasureTool)
            {
                MeasureTool = false;
                MeasureON = false;
                MeasureToolMenuItem.Checked = false;
            }
            else if (moduleMAIN.ViewON & !moduleMAIN.MoveON & !moduleMAIN.PanON)
            {
                if (moduleMAIN.PointerON)
                    MeasureTool = true;
                if (moduleLINES.LineON & moduleLINES.PtLineCounter == 0)
                    MeasureTool = true;
                if (modulePOLYS.PolyON & modulePOLYS.PtPolyCounter == 0)
                    MeasureTool = true;
                if (moduleOBJECTS.ObjectON)
                    MeasureTool = true;
                if (MeasureTool)
                    MeasureToolMenuItem.Checked = true;
            }

            SetMouseIcon();
        }

        private void InvertSelectionMenuItem_Click(object sender, EventArgs e)
        {
            moduleLINES.SelectInvertLines();
            modulePOLYS.SelectInvertPolys();
            moduleOBJECTS.SelectInvertObjects();
            moduleMAIN.RebuildDisplay();
        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Level2MenuItem_Click(object sender, EventArgs e)
        {

            // Level2MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 2;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level3MenuItem_Click(object sender, EventArgs e)
        {

            // Level3MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 3;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level4MenuItem_Click(object sender, EventArgs e)
        {

            // Level4MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 4;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level5MenuItem_Click(object sender, EventArgs e)
        {

            // Level5MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 5;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level6MenuItem_Click(object sender, EventArgs e)
        {

            // Level6MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 6;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level7MenuItem_Click(object sender, EventArgs e)
        {

            // Level7MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 7;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level8MenuItem_Click(object sender, EventArgs e)
        {

            // Level8MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 8;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level9MenuItem_Click(object sender, EventArgs e)
        {

            // Level9MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 9;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level10MenuItem_Click(object sender, EventArgs e)
        {

            // Level10MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 10;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level11MenuItem_Click(object sender, EventArgs e)
        {

            // Level11MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 11;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level12MenuItem_Click(object sender, EventArgs e)
        {

            // Level12MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 12;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level13MenuItem_Click(object sender, EventArgs e)
        {

            // Level13MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 13;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level14MenuItem_Click(object sender, EventArgs e)
        {

            // Level14MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 14;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level15MenuItem_Click(object sender, EventArgs e)
        {

            // Level15MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 15;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level16MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.QMIDLevel = 16;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level17MenuItem_Click(object sender, EventArgs e)
        {

            // Level17MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 17;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level18MenuItem_Click(object sender, EventArgs e)
        {

            // Level18MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 18;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level19MenuItem_Click(object sender, EventArgs e)
        {

            // Level19MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 19;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level20MenuItem_Click(object sender, EventArgs e)
        {

            // Level20MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 20;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level21MenuItem_Click(object sender, EventArgs e)
        {

            // Level21MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 21;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level22MenuItem_Click(object sender, EventArgs e)
        {

            // Level22MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 22;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level23MenuItem_Click(object sender, EventArgs e)
        {

            // Level23MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 23;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level24MenuItem_Click(object sender, EventArgs e)
        {

            // Level24MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 24;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level25MenuItem_Click(object sender, EventArgs e)
        {

            // Level25MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 25;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level26MenuItem_Click(object sender, EventArgs e)
        {

            // Level26MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 26;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level27MenuItem_Click(object sender, EventArgs e)
        {

            // Level27MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 27;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level28MenuItem_Click(object sender, EventArgs e)
        {

            // Level28MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 28;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void Level29MenuItem_Click(object sender, EventArgs e)
        {

            // Level29MenuItem.Checked = True
            moduleMAIN.QMIDLevel = 29;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void NoGridMenuItem_Click(object sender, EventArgs e)
        {

            // NoGridMenuItem.Checked = True
            moduleMAIN.QMIDLevel = 0;
            ResetLevelGrid(false);
            SetLatLonDeltas();
            moduleMAIN.RebuildDisplay();
        }

        private void SetLatLonDeltas()
        {
            LatitudeDelta = 90d / Math.Pow(2d, moduleMAIN.QMIDLevel - 2);
            LongitudeDelta = 120d / Math.Pow(2d, moduleMAIN.QMIDLevel - 2);
        }

        private void ShowMeasure(int X1, int Y1)
        {
            double DX, DY;
            string A;
            double CLat, CLon;
            CLat = moduleMAIN.LatDispNorth - (moduleMAIN.AuxYInt + Y1) / 2d / moduleMAIN.PixelsPerLatDeg;
            CLon = (moduleMAIN.AuxXInt + X1) / 2d / moduleMAIN.PixelsPerLonDeg + moduleMAIN.LonDispWest;
            DX = (X1 - moduleMAIN.AuxXInt) / moduleMAIN.PixelsPerLonDeg;     // delta X in degrees of longitude
            DX = DX * moduleMAIN.MetersPerDegLon(CLat);                 // in meters
            DY = (moduleMAIN.AuxYInt - Y1) / moduleMAIN.PixelsPerLatDeg;
            DY = DY * moduleMAIN.MetersPerDegLat;
            if (DX > -0.0001d & DX < 0.0001d)
            {
                if (DY >= 0d)
                    moduleOBJECTS.ObjMHead = 0d;
                if (DY < 0d)
                    moduleOBJECTS.ObjMHead = 180d;
            }
            else
            {
                moduleOBJECTS.ObjMHead = Math.Atan(DY / DX) * (180.0d / moduleMAIN.PI);
                if (DX > 0d)
                {
                    moduleOBJECTS.ObjMHead = 90d - moduleOBJECTS.ObjMHead;
                }
                else
                {
                    moduleOBJECTS.ObjMHead = 270d - moduleOBJECTS.ObjMHead;
                }
            }

            DX = DX * DX + DY * DY;
            DX = Math.Sqrt(DX);
            if (moduleMAIN.MeasuringMeters)
            {
                A = "Lenght= " + DX.ToString("0.000") + " m";
            }
            else
            {
                DX = DX * 3.2808d;
                A = "Lenght= " + DX.ToString("0.000") + " ft";
            }

            A = A + Environment.NewLine + "Heading = " + moduleOBJECTS.ObjMHead.ToString("0.000") + " deg";
            A = A + Environment.NewLine + Environment.NewLine + "Lat. = " + moduleMAIN.Lat2Str(CLat) + Environment.NewLine + "Lon. = " + moduleMAIN.Lon2Str(CLon);
            Graphics g;
            Pen p = new Pen(moduleLINES.DefaultLineColor);
            g = CreateGraphics();
            if (moduleMAIN.BitmapBuffer is object)
                g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            g.DrawLine(p, moduleMAIN.AuxXInt, moduleMAIN.AuxYInt, X1, Y1);
            p.Color = modulePOINTS.UnselectedPointColor;
            g.DrawEllipse(p, moduleMAIN.AuxXInt - 3, moduleMAIN.AuxYInt - 3, 6, 6);
            g.DrawEllipse(p, X1 - 3, Y1 - 3, 6, 6);
            X1 = (int)((X1 + moduleMAIN.AuxXInt) / 2d);
            Y1 = (int)((Y1 + moduleMAIN.AuxYInt) / 2d);
            g.DrawEllipse(p, X1 - 3, Y1 - 3, 6, 6);
            TextBoxMeasure.Text = A;
            TextBoxMeasure.Visible = true;
            TextBoxMeasure.Refresh();
            if (moduleOBJECTS.ObjectON)
                moduleOBJECTS.ObjMYes = true;
            g.Dispose();
            p.Dispose();
        }

        private void DrawLineLabel(int X, int Y, int N)
        {
            string A;
            if (N > 0)
            {
                if (string.IsNullOrEmpty(moduleLINES.Lines[N].Name))
                {
                    A = "Line #" + N;
                }
                else
                {
                    A = moduleLINES.Lines[N].Name;
                }

                Graphics g;
                g = CreateGraphics();
                if (moduleMAIN.BitmapBuffer is object)
                    g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
                Font drawFont = new Font("Arial", 10f);
                g.FillRectangle(Brushes.Beige, new Rectangle(X - 3, Y - 20, A.Length * 7, 18));
                g.DrawString(A, drawFont, Brushes.Black, X, Y - 20);
                drawFont.Dispose();
                g.Dispose();
            }
        }

        private void DrawPolyLabel(int X, int Y, int N, int M)
        {
            string A;
            if (N > 0)
            {
                if (string.IsNullOrEmpty(modulePOLYS.Polys[N].Name))
                {
                    A = "Poly #" + N;
                }
                else
                {
                    A = modulePOLYS.Polys[N].Name;
                }

                if (M > 0)
                {
                    A = "Pt#" + M + " Alt = " + modulePOLYS.Polys[N].GPoints[M].alt.ToString("0.00");
                }

                Graphics g;
                g = CreateGraphics();
                if (moduleMAIN.BitmapBuffer is object)
                    g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
                Font drawFont = new Font("Arial", 10f);
                g.FillRectangle(Brushes.Beige, new Rectangle(X - 3, Y - 20, A.Length * 7, 18));
                g.DrawString(A, drawFont, Brushes.Black, X, Y - 20);
                drawFont.Dispose();
                g.Dispose();
            }
        }

        private void DrawParentSelectLabel(int X, int Y)
        {
            string A = "Click to Select Parent Poly";
            Graphics g;
            g = CreateGraphics();
            if (moduleMAIN.BitmapBuffer is object)
                g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            Font drawFont = new Font("Arial", 10f);
            g.FillRectangle(Brushes.Beige, new Rectangle(X - 3, Y - 20, A.Length * 6 + 3, 18));
            g.DrawString(A, drawFont, Brushes.Black, X, Y - 20);
            drawFont.Dispose();
            g.Dispose();
        }

        private void DrawObjectLabel(int X, int Y, int N)
        {
            string A;
            if (N > 0)
            {
                A = "Object #" + N;
                Graphics g;
                g = CreateGraphics();
                if (moduleMAIN.BitmapBuffer is object)
                    g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
                Font drawFont = new Font("Arial", 10f);
                g.FillRectangle(Brushes.Beige, new Rectangle(X - 3, Y - 20, A.Length * 7, 18));
                g.DrawString(A, drawFont, Brushes.Black, X, Y - 20);
                drawFont.Dispose();
                g.Dispose();
            }
        }

        private void DrawLineSegment(int X, int Y)
        {
            int X0, Y0;
            X0 = (int)((moduleLINES.AuxLonLine - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            Y0 = (int)((moduleMAIN.LatDispNorth - moduleLINES.AuxLatLine) * moduleMAIN.PixelsPerLatDeg);
            Graphics g;
            Pen p = new Pen(moduleLINES.DefaultLineColor) { Width = moduleLINES.LinePenWidth };
            g = CreateGraphics();
            if (moduleMAIN.BitmapBuffer is object)
                g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            if (moduleLINES.PtLineCounter > 2)
                DrawNewLine(g);
            g.DrawLine(p, X0, Y0, X, Y);
            p.Color = modulePOINTS.UnselectedPointColor;
            g.DrawRectangle(p, X0 - 3, Y0 - 3, 6, 6);
            p.Dispose();
            g.Dispose();
        }

        private void DrawNewLine(Graphics gr)
        {
            int K;
            int PX0, PY0, PX1, PY1;
            int P1, P2;  // to draw the points
            P1 = 2;
            if (moduleLINES.LinePenWidth == 2)
                P1 = 3;
            P2 = 2 * P1;
            Pen myPen = new Pen(moduleLINES.DefaultLineColor, moduleLINES.LinePenWidth);
            SolidBrush myBrush = new SolidBrush(modulePOINTS.UnselectedPointColor);
            PX1 = (int)((moduleLINES.NewLine.GLPoints[1].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            PY1 = (int)((moduleMAIN.LatDispNorth - moduleLINES.NewLine.GLPoints[1].lat) * moduleMAIN.PixelsPerLatDeg);
            int loopTo = moduleLINES.NewLine.NoOfPoints;
            for (K = 2; K <= loopTo; K++)
            {
                PX0 = PX1;
                PY0 = PY1;
                PX1 = (int)((moduleLINES.NewLine.GLPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                PY1 = (int)((moduleMAIN.LatDispNorth - moduleLINES.NewLine.GLPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
                gr.DrawLine(myPen, PX0, PY0, PX1, PY1);
            }

            // now draw point
            int loopTo1 = moduleLINES.NewLine.NoOfPoints - 1;
            for (K = 1; K <= loopTo1; K++)
            {
                PX0 = (int)((moduleLINES.NewLine.GLPoints[K].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                PY0 = (int)((moduleMAIN.LatDispNorth - moduleLINES.NewLine.GLPoints[K].lat) * moduleMAIN.PixelsPerLatDeg);
                gr.FillRectangle(myBrush, PX0 - P1, PY0 - P1, P2, P2);
            }

            myPen.Dispose();
            myBrush.Dispose();
        }

        private void DrawPolySegment(int X, int Y)
        {

            // AddGridsToBitmapBuffer()

            int K, X0, Y0;
            int P1, P2;  // to draw the points
            P1 = 2;
            if (modulePOLYS.PolyPenWidth == 2)
                P1 = 3;
            P2 = 2 * P1;
            X0 = (int)((modulePOLYS.AuxLonPoly - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            Y0 = (int)((moduleMAIN.LatDispNorth - modulePOLYS.AuxLatPoly) * moduleMAIN.PixelsPerLatDeg);
            Graphics g;
            Pen myPen = new Pen(modulePOLYS.PolyColorBorder, modulePOLYS.PolyPenWidth);
            SolidBrush myBrush = new SolidBrush(modulePOLYS.DefaultPolyColor);
            g = CreateGraphics();
            if (moduleMAIN.BitmapBuffer is object)
                g.DrawImageUnscaled(moduleMAIN.BitmapBuffer, 0, 0);
            if (modulePOLYS.PtPolyCounter > 2)
            {
                modulePOLYS.PTS = new Point[modulePOLYS.NewPoly.NoOfPoints + 1];
                int loopTo = modulePOLYS.NewPoly.NoOfPoints - 1;
                for (K = 0; K <= loopTo; K++)
                {
                    modulePOLYS.PTS[K].X = (int)((modulePOLYS.NewPoly.GPoints[K + 1].lon - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
                    modulePOLYS.PTS[K].Y = (int)((moduleMAIN.LatDispNorth - modulePOLYS.NewPoly.GPoints[K + 1].lat) * moduleMAIN.PixelsPerLatDeg);
                }

                modulePOLYS.PTS[modulePOLYS.NewPoly.NoOfPoints].X = X;
                modulePOLYS.PTS[modulePOLYS.NewPoly.NoOfPoints].Y = Y;
                g.FillPolygon(myBrush, modulePOLYS.PTS);
                g.DrawPolygon(myPen, modulePOLYS.PTS);

                // now draw points
                myBrush.Color = modulePOINTS.UnselectedPointColor;
                int loopTo1 = modulePOLYS.NewPoly.NoOfPoints - 1;
                for (K = 0; K <= loopTo1; K++)
                    g.FillRectangle(myBrush, modulePOLYS.PTS[K].X - P1, modulePOLYS.PTS[K].Y - P1, P2, P2);
            }
            else
            {
                myBrush.Color = modulePOINTS.UnselectedPointColor;
                g.DrawLine(myPen, X0, Y0, X, Y);
                g.FillRectangle(myBrush, X - P1, Y - P1, P2, P2);
                g.FillRectangle(myBrush, X0 - P1, Y0 - P1, P2, P2);
            }

            myPen.Dispose();
            myBrush.Dispose();
            g.Dispose();
        }

        private void DeleteMenuItem_Click(object sender, EventArgs e)
        {
            int X, N;
            N = moduleMAIN.NoOfPointsSelected + moduleLINES.NoOfLinesSelected + modulePOLYS.NoOfPolysSelected;
            if (N > 0)
            {
                if (moduleMAIN.AskDelete)
                {
                    X = (int)MessageBox.Show("Delete " + N + " item(s) ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else
                {
                    X = (int)DialogResult.Yes;
                }

                if (X == (int)DialogResult.Yes)
                {
                    moduleEDIT.BackUp();
                    moduleEDIT.SkipBackUp = true;
                    moduleMAIN.DeleteSelected();
                    moduleEDIT.SkipBackUp = false;
                    moduleMAIN.RebuildDisplay();
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            moduleMAIN.DELAY = false;
            Timer1.Enabled = false;
        }

        private void RecentFile1MenuItem_Click(object sender, EventArgs e)
        {
            string FileName;
            if (moduleMAIN.Dirty)
            {
                if (MessageBox.Show("You did not save your data! Continue ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // User chose Yes.
                {
                }
                else // User chose No.
                {
                    return;
                }
            }

            FileName = moduleFILE_IO.RecentFiles[1];
            if (string.IsNullOrEmpty(FileName))
                return;
            FileOpenHeader();
            moduleFILE_IO.OpenFile(FileName);
            moduleMAIN.WorkFile = FileName;
            FileOpenTrailer();
        }

        private void RecentFile2MenuItem_Click(object sender, EventArgs e)
        {
            string FileName;
            if (moduleMAIN.Dirty)
            {
                if (MessageBox.Show("You did not save your data! Continue ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // User chose Yes.
                {
                }
                else // User chose No.
                {
                    return;
                }
            }

            FileName = moduleFILE_IO.RecentFiles[2];
            FileOpenHeader();
            moduleFILE_IO.OpenFile(FileName);
            if (string.IsNullOrEmpty(FileName))
                return;
            moduleMAIN.WorkFile = FileName;
            FileOpenTrailer();
        }

        private void RecentFile3MenuItem_Click(object sender, EventArgs e)
        {
            string FileName;
            if (moduleMAIN.Dirty)
            {
                if (MessageBox.Show("You did not save your data! Continue ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // User chose Yes.
                {
                }
                else // User chose No.
                {
                    return;
                }
            }

            FileName = moduleFILE_IO.RecentFiles[3];
            if (string.IsNullOrEmpty(FileName))
                return;
            FileOpenHeader();
            moduleFILE_IO.OpenFile(FileName);
            moduleMAIN.WorkFile = FileName;
            FileOpenTrailer();
        }

        private void RecentFile4MenuItem_Click(object sender, EventArgs e)
        {
            string FileName;
            if (moduleMAIN.Dirty)
            {
                if (MessageBox.Show("You did not save your data! Continue ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) // User chose Yes.
                {
                }
                else // User chose No.
                {
                    return;
                }
            }

            FileName = moduleFILE_IO.RecentFiles[4];
            if (string.IsNullOrEmpty(FileName))
                return;
            FileOpenHeader();
            moduleFILE_IO.OpenFile(FileName);
            moduleMAIN.WorkFile = FileName;
            FileOpenTrailer();
        }

        private void FallMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Fall";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void HardWinterMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Hard";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void MeshMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Mesh";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void SpringMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Spring";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void AlphaMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Alpha";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void SummerMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Summer";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void WinterMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Winter";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void NightMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Night";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void ClassMapMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.Season = "Class";
            moduleMAPS.SetBitmapSeason();
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
        }

        private void CenterPopUPMenu_Click(object sender, EventArgs e)
        {
            moduleMAIN.SetDispCenter(modulePOPUP.XPOP - moduleMAIN.DisplayCenterX, modulePOPUP.YPOP - moduleMAIN.DisplayCenterY);
            moduleMAIN.RebuildDisplay();
        }

        private void ZoomInPopUPMenu_Click(object sender, EventArgs e)
        {
            moduleMAIN.SetDispCenter(modulePOPUP.XPOP - moduleMAIN.DisplayCenterX, modulePOPUP.YPOP - moduleMAIN.DisplayCenterY);
            ZoomInOut(1);
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
        }

        private void ZoomOutPopUPMenu_Click(object sender, EventArgs e)
        {
            moduleMAIN.SetDispCenter(modulePOPUP.XPOP - moduleMAIN.DisplayCenterX, modulePOPUP.YPOP - moduleMAIN.DisplayCenterY);
            ZoomInOut(2);
            moduleMAIN.SetDispCenter(0, 0);
            moduleMAIN.RebuildDisplay();
        }

        private void DeletePopUPMenu_Click(object sender, EventArgs e)
        {
            DialogResult X;
            if (modulePOPUP.POPType == "PtInLine")
            {
                X = MessageBox.Show("Delete this Point from this Line ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)
                {
                    moduleLINES.DeletePointInLine(modulePOPUP.POPIndex, modulePOPUP.POPIndexPT);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "PtInPoly")
            {
                X = MessageBox.Show("Delete this Point from this Poly ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)
                {
                    if (modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfPoints < 3)
                    {
                        modulePOLYS.DeletePoly(modulePOPUP.POPIndex);
                        moduleMAIN.Dirty = true;
                    }
                    else
                    {
                        modulePOLYS.DeletePointInPoly(modulePOPUP.POPIndex, modulePOPUP.POPIndexPT);
                    }

                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "Line")
            {
                X = MessageBox.Show("Delete this Line ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (X == DialogResult.Yes)
                {
                    moduleLINES.DeleteLine(modulePOPUP.POPIndex);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "Poly")
            {
                X = MessageBox.Show("Delete this Poly ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (X == DialogResult.Yes)
                {
                    modulePOLYS.DeletePoly(modulePOPUP.POPIndex);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "Exclude")
            {
                X = MessageBox.Show("Delete this Exclude ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (X == DialogResult.Yes)
                {
                    moduleEXCLUDES.DeleteExclude(modulePOPUP.POPIndex);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "Land")
            {
                X = MessageBox.Show("Delete this Land Class ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)
                {
                    moduleCLASSES.DeleteLandPopUp(modulePOPUP.POPIndex);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "Water")
            {
                X = MessageBox.Show("Delete this Water Class ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)
                {
                    moduleCLASSES.DeleteWaterPopUp(modulePOPUP.POPIndex);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "Object")
            {
                X = MessageBox.Show("Delete this Object ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)
                {
                    moduleOBJECTS.DeleteThisObject(modulePOPUP.POPIndex);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }

            if (modulePOPUP.POPType == "Map")
            {
                X = MessageBox.Show("Delete this Map ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (X == DialogResult.Yes)
                {
                    moduleMAPS.DeleteMap(modulePOPUP.POPIndex);
                    moduleMAIN.RebuildDisplay();
                }
                else
                {
                    return;
                }
            }
        }

        private void MakeLinePopUPMenu_Click(object sender, EventArgs e)
        {
            int L, N, K, P;
            moduleEDIT.BackUp();
            P = modulePOPUP.POPIndex;
            L = moduleLINES.NoOfLines + 1;
            moduleLINES.NoOfLines = L;
            Array.Resize(ref moduleLINES.Lines, L + 1);
            N = modulePOLYS.Polys[P].NoOfPoints;
            moduleLINES.Lines[L].NoOfPoints = N;
            if (modulePOLYS.MakeClosedLineFromPoly)
                moduleLINES.Lines[L].NoOfPoints = N + 1;
            moduleLINES.Lines[L].GLPoints = new modulePOINTS.GLPoint[moduleLINES.Lines[L].NoOfPoints + 1];
            moduleLINES.Lines[L].Color = moduleLINES.DefaultLineColor;
            int loopTo = N;
            for (K = 1; K <= loopTo; K++)
            {
                moduleLINES.Lines[L].GLPoints[K].lat = modulePOLYS.Polys[P].GPoints[N - K + 1].lat;
                moduleLINES.Lines[L].GLPoints[K].lon = modulePOLYS.Polys[P].GPoints[N - K + 1].lon;
            }

            if (modulePOLYS.MakeClosedLineFromPoly)
                moduleLINES.Lines[L].GLPoints[N + 1] = moduleLINES.Lines[L].GLPoints[1];
            moduleLINES.AddLatLonToLine(L);
            if (moduleLINES.LineVIEW == false)
                ViewAllLinesMenuItem_Click(ViewAllLinesMenuItem, new EventArgs());
            moduleMAIN.RebuildDisplay();
        }

        private void MakePolyPopUPMenu_Click(object sender, EventArgs e)
        {
            int L, N, K, P;
            moduleEDIT.BackUp();
            P = modulePOPUP.POPIndex;
            L = modulePOLYS.NoOfPolys + 1;
            modulePOLYS.NoOfPolys = L;
            Array.Resize(ref modulePOLYS.Polys, L + 1);
            N = moduleLINES.Lines[P].NoOfPoints;
            modulePOLYS.Polys[L].NoOfPoints = N;
            modulePOLYS.Polys[L].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[L].NoOfPoints + 1];
            modulePOLYS.Polys[L].Color = modulePOLYS.DefaultPolyColor;
            int loopTo = N;
            for (K = 1; K <= loopTo; K++)
            {
                modulePOLYS.Polys[L].GPoints[K].lat = moduleLINES.Lines[P].GLPoints[K].lat;
                modulePOLYS.Polys[L].GPoints[K].lon = moduleLINES.Lines[P].GLPoints[K].lon;
            }

            modulePOLYS.AddLatLonToPoly(L);
            if (modulePOLYS.PolyVIEW == false)
                ViewAllPolysMenuItem_Click(ViewAllPolysMenuItem, new EventArgs());
            moduleMAIN.RebuildDisplay();
        }

        private void ConvertToPolyPopUpMenu_Click(object sender, EventArgs e)
        {
            moduleEDIT.BackUp();
            moduleEDIT.SkipBackUp = true;
            moduleLINES.MakePolyFromLine(modulePOPUP.POPIndex);
            moduleLINES.DeleteLine(modulePOPUP.POPIndex);
            moduleEDIT.SkipBackUp = false;
            PolyToolStripButton_Click(PolyToolStripButton, new EventArgs());
        }

        private void SmoothPopUPMenu_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLPSmooth.ShowDialog();
        }

        private void SamplePopUPMenu_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLPSample.ShowDialog();
        }

        private void SetAltitudePopUpMenu_Click(object sender, EventArgs e)
        {
            if (modulePOPUP.POPType == "Line")
            {
                My.MyProject.Forms.FrmAltitudeLine.ShowDialog();
            }

            if (modulePOPUP.POPType == "Poly")
            {
                My.MyProject.Forms.FrmAltitudePoly.ShowDialog();
            }
        }

        private void SetWidthPopUpMenu_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLWidth.ShowDialog();
        }

        private void ManualCheckPopUPMenu_Click(object sender, EventArgs e)
        {
            string A;
            A = "Use Up and Down Arrows to scroll" + Environment.NewLine;
            A = A + "through Points. Press Delete as" + Environment.NewLine;
            A = A + "required. Scroll through Lines" + Environment.NewLine;
            A = A + "or Polys with Right and Left Arrows." + Environment.NewLine;
            A = A + "Press <Esc> to exit.";
            MessageBox.Show(A, "SBuilderX - Checking Lines or Polys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (modulePOPUP.POPType == "Line")
            {
                UnSelectAll();
                modulePOLYS.CheckPoly = 0;
                moduleLINES.CheckLine = modulePOPUP.POPIndex;
                moduleLINES.CheckLinePt = 1;
                moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[1].Selected = true;
                moduleMAIN.LatDispCenter = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[1].lat;
                moduleMAIN.LonDispCenter = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[1].lon;
                moduleMAIN.SetDispCenter(0, 0);
                moduleMAIN.RebuildDisplay();
            }

            if (modulePOPUP.POPType == "Poly")
            {
                UnSelectAll();
                moduleLINES.CheckLine = 0;
                modulePOLYS.CheckPoly = modulePOPUP.POPIndex;
                modulePOLYS.CheckPolyPt = 1;
                modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[1].Selected = true;
                moduleMAIN.LatDispCenter = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[1].lat;
                moduleMAIN.LonDispCenter = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[1].lon;
                moduleMAIN.SetDispCenter(0, 0);
                moduleMAIN.RebuildDisplay();
            }
        }

        internal void CalibratePopUPMenu_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmCalibrate.ShowDialog();
        }

        private void PropertiesPopUPMenu_Click(object sender, EventArgs e)
        {
            if (modulePOPUP.POPType == "Map")
            {
                My.MyProject.Forms.FrmMapsP.ShowDialog();
                return;
            }

            if (modulePOPUP.POPType == "Project")
            {
                My.MyProject.Forms.FrmProjectP.ShowDialog();
                return;
            }

            if (modulePOPUP.POPType == "Line")
            {
                My.MyProject.Forms.FrmLinesP.ShowDialog();
                return;
            }

            if (modulePOPUP.POPType == "Poly")
            {
                My.MyProject.Forms.FrmPolysP.ShowDialog();
                return;
            }

            if (modulePOPUP.POPType == "PtInLine")
            {
                My.MyProject.Forms.FrmLPPointsP.ShowDialog();
                return;
            }

            if (modulePOPUP.POPType == "PtInPoly")
            {
                My.MyProject.Forms.FrmLPPointsP.ShowDialog();
                return;
            }

            if (modulePOPUP.POPType == "Exclude")
            {
                My.MyProject.Forms.FrmExcludesP.ShowDialog();
                return;
            }

            if (modulePOPUP.POPType == "Object")
            {
                My.MyProject.Forms.FrmObjectsP.ShowObjectProperties(modulePOPUP.POPIndex);
                My.MyProject.Forms.FrmObjectsP.ShowDialog();
                return;
            }

            // If POPType = "Land" Then
            // frmLandsP.Show()
            // 'frmLandsP.ShowLandProperty(POPIndex)
            // Exit Sub
            // End If

            // If POPType = "Water" Then
            // frmWatersP.Show()
            // 'frmWatersP.ShowWaterProperty(POPIndex)
            // Exit Sub
            // End If


        }

        private void FromDiskMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAPS.MapVIEW = false;
            ViewAllMapsMenuItem_Click(ViewAllMapsMenuItem, new EventArgs());
            moduleMAPS.AddNewMap();
            Cursor = Cursors.Default;
        }

        private void ExportSBXMenuItem_Click(object sender, EventArgs e)
        {
            string a, b;
            if (moduleLINES.NoOfLines == 0 & modulePOLYS.NoOfPolys == 0)
            {
                if (Convert.ToBoolean(moduleEXCLUDES.NoOfExcludes & Convert.ToInt32(moduleOBJECTS.NoOfObjects == 0)))
                {
                    if (moduleCLASSES.NoOfLLXYs == 0 & moduleCLASSES.NoOfWWXYs == 0)
                    {
                        if (moduleMAPS.NoOfMaps == 0 & moduleCLASSES.NoOfLWCIs == 0)
                        {
                            MessageBox.Show("There are no items to export!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                }
            }

            a = "SBuilderX Imp/Exp (*.SBX)|*.SBX";
            b = "SBuilderX - Export Project As";
            a = moduleFILE_IO.FileNameToSave(a, b, "SBX");
            if (string.IsNullOrEmpty(a))
            {
                return;
            }

            // WorkFile = a$
            moduleFILE_IO.ExportSBX(a);
            moduleMAIN.Dirty = false;
        }

        private void ImportSBXMenuItem_Click(object sender, EventArgs e)
        {
            string b, a, FileName;
            DialogResult x;
            lbDonation.Visible = false;
            if (moduleMAIN.Dirty)
            {
                x = MessageBox.Show("You did not save your data! Continue ?", moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (x == DialogResult.Yes) // User chose Yes.
                {
                }
                else // User chose No.
                {
                    return;
                }
            }

            a = "SBuilderX Imp/Exp (*.SBX)|*.SBX";
            b = "SBuilderX - Import Project";
            FileName = moduleFILE_IO.FileNameToOpen(a, b, "SBX");
            if (string.IsNullOrEmpty(FileName))
                return;
            FileOpenHeader();
            moduleFILE_IO.ImportSBX(FileName);
            moduleMAIN.WorkFile = Path.GetFileNameWithoutExtension(FileName) + ".SBP";
            FileOpenTrailer();
            // MsgBox("Save file will be = " & WorkFile)
            moduleMAIN.Dirty = false;
        }

        private void AppendSBXMenuItem_Click(object sender, EventArgs e)
        {
            string a, b;
            a = "SBuilderX Imp/Exp (*.SBX)|*.SBX";
            b = "SBuilderX - Append Project";
            a = moduleFILE_IO.FileNameToOpen(a, b, "SBX");
            if (string.IsNullOrEmpty(a))
            {
                return;
            }

            moduleFILE_IO.AppendSBX(a);
            FileOpenTrailer();
            moduleMAIN.Dirty = true;
        }

        private void ExportSHPMenuItem_Click(object sender, EventArgs e)
        {
            string a, b;
            if (moduleLINES.NoOfLines == 0 & modulePOLYS.NoOfPolys == 0)
            {
                MessageBox.Show("There is no line or polygon to export!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (moduleLINES.NoOfLines > 0 & modulePOLYS.NoOfPolys > 0)
            {
                MessageBox.Show("Lines and Polys will be saved in 2 separated files!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (moduleLINES.NoOfLines > 0)
            {
                a = "Esri Shape file (*.SHP)|*.SHP";
                b = "SBuilderX: Export LINES As";
                a = moduleFILE_IO.FileNameToSave(a, b, "SHP");
                if (!string.IsNullOrEmpty(a))
                {
                    moduleSHAPE.ExportSHPLines(a);
                }
            }

            if (modulePOLYS.NoOfPolys > 0)
            {
                a = "Esri Shape file (*.SHP)|*.SHP";
                b = "SBuilderX: Export POLYGONS As";
                a = moduleFILE_IO.FileNameToSave(a, b, "SHP");
                if (!string.IsNullOrEmpty(a))
                {
                    moduleSHAPE.ExportSHPPolys(a);
                }
            }
        }

        private void AppendSHPMenuItem_Click(object sender, EventArgs e)
        {
            string A, B;
            A = "Esri Shape file (*.SHP)|*.SHP";
            B = "SBuilderX: Append ShapeFile";
            A = moduleFILE_IO.FileNameToOpen(A, B, "SHP");
            if (string.IsNullOrEmpty(A))
            {
                return;
            }

            moduleSHAPE.AppendSHPFile(A);
            FileOpenTrailer();
            moduleMAIN.Dirty = true;
        }

        private void AppendObjMenuItem_Click(object sender, EventArgs e)
        {
            string A, B, C;
            A = "Object BGL file (*.BGL)|*.bgl";
            A = A + "|Object XML file (*.XML)|*.xml";
            B = "SBuilderX: Append Object file";
            A = moduleFILE_IO.FileNameToOpen(A, B, "OBJ");
            if (string.IsNullOrEmpty(A))
            {
                return;
            }

            B = Path.GetExtension(A).Substring(1).ToUpper();
            try
            {
                if (B == "BGL")
                {
                    C = A + ".XML";
                    SceneryFile SceneryFile = new SceneryFile(A, FileType.BGL);   // was = then I placed As
                    SceneryFile.Bgl2Xml(C);
                    SceneryFile.Dispose();
                    moduleOBJECTS.AppendOBJFile(C);
                }
                else if (B == "XML")
                {
                    moduleOBJECTS.AppendOBJFile(A);
                }
                else
                {
                    MessageBox.Show("Wrong File Extension", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                FileOpenTrailer();
                moduleMAIN.Dirty = true;
            }
            catch (Exception)
            {
                MessageBox.Show("SBuilderX can not decompile file " + A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetLineTypes()
        {
            string A, B, C, File;
            int Marker, N, K;
            moduleLINES.LineTypes = new moduleLINES.LineType[2001];

            try
            {
                File = My.MyProject.Application.Info.DirectoryPath + @"\Tools\Lines.txt";
                FileSystem.FileOpen(2, File, OpenMode.Input);
                N = (int)FileSystem.LOF(2);
                Marker = 0;
                K = 0;
                while (Marker < N)
                {
                    A = FileSystem.LineInput(2);
                    Marker = Marker + A.Length + 2;
                    if (A.Length < 4)
                        continue;
                    B = A.Substring(0, 4).Trim();
                    if (B == "[Tex")
                    {
                        K = K + 1;
                        C = A.Substring(9).Trim();
                        C = C.Replace("]", "");
                        moduleLINES.LineTypes[K].TerrainIndex = Convert.ToInt32(C);
                    }

                    if (B == "Name")
                    {
                        C = A.Substring(5).Trim();
                        moduleLINES.LineTypes[K].Name = C;
                    }

                    if (B == "Colo")
                    {
                        C = A.Substring(6).Trim();
                        moduleLINES.LineTypes[K].Color = Color.FromArgb(Convert.ToInt32(C, 16));
                    }

                    if (B == "Text")
                    {
                        C = A.Substring(9).Trim();
                        moduleLINES.LineTypes[K].Texture = C;
                    }

                    if (B == "Guid")
                    {
                        C = A.Substring(5).Trim();
                        moduleLINES.LineTypes[K].Guid = C;
                    }

                    if (B == "Type")
                    {
                        C = (A.Length < 8) ? "" : A.Substring(5, 3).Trim(); // ''' skip legacy
                        moduleLINES.LineTypes[K].Type = C;
                    }
                }

                FileSystem.FileClose();
                moduleLINES.DefaultLineNoneGuid = moduleLINES.LineTypes[1].Guid;
                moduleLINES.DefaultLineFS9Guid = moduleLINES.LineTypes[2].Guid;
                moduleLINES.NoOfLineTypes = K;
                Array.Resize(ref moduleLINES.LineTypes, K + 1);
                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose();
                MessageBox.Show("Check your Lines.txt file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetPolyTypes()
        {
            string A, B, C, File;
            int Marker, N, K;

            try
            {
                modulePOLYS.PolyTypes = new modulePOLYS.PolyType[2001];
                File = My.MyProject.Application.Info.DirectoryPath + @"\tools\Polys.txt";
                FileSystem.FileOpen(2, File, OpenMode.Input);
                N = (int)FileSystem.LOF(2);
                Marker = 0;
                K = 0;
                while (Marker < N)
                {
                    A = FileSystem.LineInput(2);
                    Marker = Marker + A.Length + 2;
                    if (A.Length < 4)
                        continue;
                    B = A.Substring(0, 4).Trim().ToUpper();
                    if (B == "[TEX")
                    {
                        K = K + 1;
                        C = A.Substring(9).Trim();
                        C = C.Replace("]", "");
                        modulePOLYS.PolyTypes[K].TerrainIndex = Convert.ToInt32(C);
                    }

                    if (B == "NAME")
                    {
                        C = A.Substring(5).Trim();
                        modulePOLYS.PolyTypes[K].Name = C;
                    }

                    if (B == "COLO")
                    {
                        C = A.Substring(6).Trim();
                        modulePOLYS.PolyTypes[K].Color = Color.FromArgb(Convert.ToInt32(C, 16));
                    }

                    if (B == "TEXT")
                    {
                        C = A.Substring(9).Trim();
                        modulePOLYS.PolyTypes[K].Texture = C;
                    }

                    if (B == "GUID")
                    {
                        C = A.Substring(5).Trim();
                        modulePOLYS.PolyTypes[K].Guid = C;
                    }

                    if (B == "TYPE")
                    {
                        C = (A.Length < 8) ? "" : A.Substring(5, 3).Trim(); // ''' landclasses
                                                                            // C = Mid(C, 1, 3)
                        modulePOLYS.PolyTypes[K].Type = C;
                    }
                }

                FileSystem.FileClose();
                modulePOLYS.DefaultPolyNoneGuid = modulePOLYS.PolyTypes[1].Guid;
                modulePOLYS.DefaultPolyFS9Guid = modulePOLYS.PolyTypes[2].Guid;
                modulePOLYS.DefaultPolyGPSGuid = modulePOLYS.PolyTypes[3].Guid;
                modulePOLYS.NoOfPolyTypes = K;
                Array.Resize(ref modulePOLYS.PolyTypes, K + 1);
                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose();
                MessageBox.Show("Check your Polys.txt file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetLandTypes()
        {
            string A, B, C, File;
            int N, Marker, K;

            try
            {
                // ReDim LC(255) we do that in the declaration

                File = My.MyProject.Application.Info.DirectoryPath + @"\tools\lands.txt";
                FileSystem.FileOpen(2, File, OpenMode.Input);
                N = (int)FileSystem.LOF(2);
                Marker = 0;
                K = 0;
                while (Marker < N)
                {
                    A = FileSystem.LineInput(2);
                    Marker = Marker + A.Length + 2;
                    if (A.Length < 4)
                        continue;
                    B = A.Substring(0, 4).Trim().ToUpper();
                    if (B == "NAME")
                    {
                        K = K + 1;
                        C = A.Substring(5).Trim();
                        moduleCLASSES.LC[K].Index = Convert.ToByte(C.Substring(0, 3));
                        moduleCLASSES.LC[K].Caption = C;
                    }

                    if (B == "TEXT")
                    {
                        C = A.Substring(9).Trim();
                        moduleCLASSES.LC[K].Texture = C;
                    }

                    if (B == "COLO")
                    {
                        C = A.Substring(6).Trim();
                        moduleCLASSES.LC[K].Color = Color.FromArgb(Convert.ToInt32(C, 16));
                    }
                }

                FileSystem.FileClose();
                moduleCLASSES.NoOfLCs = K;
                B = "sel";
                int loopTo = moduleCLASSES.NoOfLCs;
                for (K = 1; K <= loopTo; K++)
                {
                    moduleCLASSES.LC[K + 128].Color = Color.FromArgb(255, 0, 255, 0);
                    moduleCLASSES.LC[K + 128].Index = moduleCLASSES.LC[K].Index;
                    moduleCLASSES.ILC[moduleCLASSES.LC[K].Index] = (byte)K;   // added in March 2009
                    moduleCLASSES.LC[K + 128].Texture = B;
                }

                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose();
                MessageBox.Show("Check your Lands.txt file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetWaterTypes()
        {
            string A, B, C, File;
            int N, Marker, K;

            try
            {
                moduleCLASSES.WC = new moduleCLASSES.LWClass[256];
                File = My.MyProject.Application.Info.DirectoryPath + @"\tools\Waters.txt";
                FileSystem.FileOpen(2, File, OpenMode.Input);
                N = (int)FileSystem.LOF(2);
                Marker = 0;
                K = 0;
                while (Marker < N)
                {
                    A = FileSystem.LineInput(2);
                    Marker = Marker + A.Length + 2;
                    if (A.Length < 4)
                        continue;
                    B = A.Substring(0, 4).Trim().ToUpper();
                    if (B == "NAME")
                    {
                        K = K + 1;
                        C = A.Substring(5).Trim();
                        moduleCLASSES.WC[K].Index = Convert.ToByte(C.Substring(0, 3));
                        moduleCLASSES.WC[K].Caption = C;
                    }

                    if (B == "TEXT")
                    {
                        C = A.Substring(9).Trim();
                        moduleCLASSES.WC[K].Texture = C;
                    }

                    if (B == "COLO")
                    {
                        C = A.Substring(6).Trim();
                        moduleCLASSES.WC[K].Color = Color.FromArgb(Convert.ToInt32(C, 16));
                    }
                }

                FileSystem.FileClose();
                moduleCLASSES.NoOfWCs = K;
                B = "sel";
                int loopTo = moduleCLASSES.NoOfLCs;
                for (K = 1; K <= loopTo; K++)
                {
                    moduleCLASSES.WC[K + 128].Color = Color.FromArgb(255, 0, 255, 0);
                    moduleCLASSES.WC[K + 128].Index = moduleCLASSES.WC[K].Index;
                    moduleCLASSES.IWC[moduleCLASSES.WC[K].Index] = (byte)K;   // added in March 2009
                    moduleCLASSES.WC[K + 128].Texture = B;
                }

                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose();
                MessageBox.Show("Check your Waters.txt file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetExtrusionsTypes()
        {
            string A, B, File;
            int N, Marker, K;

            try
            {
                moduleLINES.ExtrusionTypes = new moduleLINES.ExtrusionType[256];
                File = My.MyProject.Application.Info.DirectoryPath + @"\Tools\Bridges.txt";
                FileSystem.FileOpen(2, File, OpenMode.Input);
                N = (int)FileSystem.LOF(2);
                Marker = 0;
                K = 0;
                while (Marker < N)
                {
                    A = FileSystem.LineInput(2);
                    Marker = Marker + A.Length + 2;
                    if (A.Length < 3)
                        continue;
                    B = A.Substring(0, 3).Trim().ToUpper();
                    if (B == "NAM")
                    {
                        K = K + 1;
                        moduleLINES.ExtrusionTypes[K].Name = A.Substring(5).Trim();
                    }

                    if (B == "COL")
                    {
                        moduleLINES.ExtrusionTypes[K].Color = ColorFromArgb(A.Substring(6).Trim());
                    }

                    if (B == "WID")
                    {
                        moduleLINES.ExtrusionTypes[K].Width = Convert.ToDouble(A.Substring(6).Trim());
                    }

                    if (B == "PRO")
                    {
                        moduleLINES.ExtrusionTypes[K].Profile = A.Substring(8).Trim();
                    }

                    if (B == "MAT")
                    {
                        moduleLINES.ExtrusionTypes[K].Material = A.Substring(9).Trim();
                    }

                    if (B == "PYL")
                    {
                        moduleLINES.ExtrusionTypes[K].Pylon = A.Substring(6).Trim();
                    }
                }

                FileSystem.FileClose();
                moduleLINES.NoOfExtrusionTypes = K;
                Array.Resize(ref moduleLINES.ExtrusionTypes, K + 1);
                return;
            }
            catch (Exception)
            {
                FileSystem.FileClose();
                MessageBox.Show("Check your Bridges.txt file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private Color ColorFromArgb(string argb)
        {
            Color ColorFromArgbRet = default;
            ColorFromArgbRet = Color.FromArgb(Convert.ToInt32(argb, 16));
            return ColorFromArgbRet;
        }

        private void SetBmpTextures()
        {
            string Command, FileSource, FileTarget, FileJPG;
            string BmpFolder = moduleMAIN.AppPath + @"\Tools\Bmps\";
            string ImageTool = "imagetool -nogui -nomip ";
            string Flags1 = @"-32 Bmps\";
            string Flags2 = @"-fallback Bmps\";
            string bmp = ".bmp";
            string jpg = ".jpg";
            Image myImage;
            int K;
            bool ShowWait = false;
            try
            {
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Tools\");
                if (!My.MyProject.Computer.FileSystem.FileExists(BmpFolder + "000b2su1.jpg"))
                {
                    ShowWait = true;
                    My.MyProject.Forms.frmWaiting.Show();
                    My.MyProject.Forms.frmWaiting.bar.Maximum = moduleCLASSES.NoOfWCs + moduleCLASSES.NoOfLCs + moduleLINES.NoOfLineTypes + modulePOLYS.NoOfPolyTypes;
                    My.MyProject.Forms.frmWaiting.bar.Value = 0;
                }

                int loopTo = moduleCLASSES.NoOfWCs;
                for (K = 1; K <= loopTo; K++)
                {
                    FileJPG = BmpFolder + moduleCLASSES.WC[K].Texture + jpg;
                    if (!My.MyProject.Computer.FileSystem.FileExists(FileJPG))
                    {
                        if (ShowWait)
                        {
                            My.MyProject.Forms.frmWaiting.bar.Value += 1;
                            My.MyProject.Forms.frmWaiting.labelFile.Text = moduleCLASSES.WC[K].Texture + jpg;
                            My.MyProject.Forms.frmWaiting.Refresh();
                        }

                        FileTarget = BmpFolder + moduleCLASSES.WC[K].Texture + bmp;
                        FileSource = moduleMAIN.FSTextureFolder + moduleCLASSES.WC[K].Texture + bmp;
                        FileSystem.FileCopy(FileSource, FileTarget);
                        Command = ImageTool + Flags1 + moduleCLASSES.WC[K].Texture + bmp;
                        moduleMAIN.ExecCmd(Command);
                        if (ShowWait)
                            My.MyProject.Forms.frmWaiting.Refresh();
                        myImage = Image.FromFile(FileTarget);
                        myImage.Save(FileJPG, ImageFormat.Jpeg);
                        myImage.Dispose();
                        if (ShowWait)
                            My.MyProject.Forms.frmWaiting.Refresh();
                        Command = ImageTool + Flags2 + moduleCLASSES.WC[K].Texture + bmp;
                        moduleMAIN.ExecCmd(Command);
                    }
                }

                if (ShowWait)
                    My.MyProject.Forms.frmWaiting.Refresh();
                int loopTo1 = moduleCLASSES.NoOfLCs;
                for (K = 1; K <= loopTo1; K++)
                {
                    FileJPG = BmpFolder + moduleCLASSES.LC[K].Texture + jpg;
                    if (!My.MyProject.Computer.FileSystem.FileExists(FileJPG))
                    {
                        if (ShowWait)
                        {
                            My.MyProject.Forms.frmWaiting.bar.Value += 1;
                            My.MyProject.Forms.frmWaiting.labelFile.Text = moduleCLASSES.LC[K].Texture + jpg;
                            My.MyProject.Forms.frmWaiting.Refresh();
                        }

                        FileTarget = BmpFolder + moduleCLASSES.LC[K].Texture + bmp;
                        FileSource = moduleMAIN.FSTextureFolder + moduleCLASSES.LC[K].Texture + bmp;
                        FileSystem.FileCopy(FileSource, FileTarget);
                        Command = ImageTool + Flags1 + moduleCLASSES.LC[K].Texture + bmp;
                        moduleMAIN.ExecCmd(Command);
                        if (ShowWait)
                            My.MyProject.Forms.frmWaiting.Refresh();
                        myImage = Image.FromFile(FileTarget);
                        myImage.Save(FileJPG, ImageFormat.Jpeg);
                        myImage.Dispose();
                        if (ShowWait)
                            My.MyProject.Forms.frmWaiting.Refresh();
                        Command = ImageTool + Flags2 + moduleCLASSES.LC[K].Texture + bmp;
                        moduleMAIN.ExecCmd(Command);
                    }
                }

                int loopTo2 = moduleLINES.NoOfLineTypes;
                for (K = 1; K <= loopTo2; K++)
                {
                    FileJPG = BmpFolder + moduleLINES.LineTypes[K].Texture + jpg;
                    if (!My.MyProject.Computer.FileSystem.FileExists(FileJPG))
                    {
                        if (ShowWait)
                        {
                            My.MyProject.Forms.frmWaiting.bar.Value += 1;
                            My.MyProject.Forms.frmWaiting.labelFile.Text = moduleLINES.LineTypes[K].Texture + jpg;
                            My.MyProject.Forms.frmWaiting.Refresh();
                        }

                        FileTarget = BmpFolder + moduleLINES.LineTypes[K].Texture + bmp;
                        FileSource = moduleMAIN.FSTextureFolder + moduleLINES.LineTypes[K].Texture + bmp;
                        FileSystem.FileCopy(FileSource, FileTarget);
                        Command = ImageTool + Flags1 + moduleLINES.LineTypes[K].Texture + bmp;
                        moduleMAIN.ExecCmd(Command);
                        if (ShowWait)
                            My.MyProject.Forms.frmWaiting.Refresh();
                        myImage = Image.FromFile(FileTarget);
                        myImage.Save(FileJPG, ImageFormat.Jpeg);
                        myImage.Dispose();
                        File.Delete(FileTarget);
                    }
                }

                int loopTo3 = modulePOLYS.NoOfPolyTypes;
                for (K = 1; K <= loopTo3; K++)
                {
                    FileJPG = BmpFolder + modulePOLYS.PolyTypes[K].Texture + jpg;
                    if (!My.MyProject.Computer.FileSystem.FileExists(FileJPG))
                    {
                        if (ShowWait)
                        {
                            My.MyProject.Forms.frmWaiting.bar.Value += 1;
                            My.MyProject.Forms.frmWaiting.labelFile.Text = modulePOLYS.PolyTypes[K].Texture + jpg;
                            My.MyProject.Forms.frmWaiting.Refresh();
                        }

                        FileTarget = BmpFolder + modulePOLYS.PolyTypes[K].Texture + bmp;
                        FileSource = moduleMAIN.FSTextureFolder + modulePOLYS.PolyTypes[K].Texture + bmp;
                        FileSystem.FileCopy(FileSource, FileTarget);
                        Command = ImageTool + Flags1 + modulePOLYS.PolyTypes[K].Texture + bmp;
                        moduleMAIN.ExecCmd(Command);
                        if (ShowWait)
                            My.MyProject.Forms.frmWaiting.Refresh();
                        myImage = Image.FromFile(FileTarget);
                        myImage.Save(FileJPG, ImageFormat.Jpeg);
                        myImage.Dispose();
                        File.Delete(FileTarget);
                    }
                }

                My.MyProject.Forms.frmWaiting.Close();
                My.MyProject.Forms.frmWaiting.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show(@"Some textures referred to in polys.txt, lines.txt, lands.txt, or waters.txt could not be copied into the \Tools\Bmps\ folder!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void OuterPopUpMenu_Click(object sender, EventArgs e)
        {
            int K;
            bool Flag = default(bool);
            if (moduleMAIN.PointerON)  // make just one outer
            {
                Flag = false;
                Flag = MakeThisOuter(modulePOPUP.POPIndex);
            }

            // make bulk
            if (modulePOLYS.PolyON)
            {
                modulePOLYS.Polys[modulePOPUP.POPIndex].Selected = true; // make sure POPIndex is selected 
                Flag = true;
                int loopTo = modulePOLYS.NoOfPolys;
                for (K = 1; K <= loopTo; K++)
                {
                    if (modulePOLYS.Polys[K].Selected) // it is selected then is a candidate
                    {
                        if (modulePOLYS.Polys[K].NoOfChilds < 0)  // it is a hole
                        {
                            if (!MakeThisOuter(K))
                                Flag = false;
                        }
                    }
                }
            }

            if (Flag == false)
                MessageBox.Show("Error in setting an outer polygon");
            moduleMAIN.RebuildDisplay();
        }

        private bool MakeThisOuter(int N)
        {
            bool MakeThisOuterRet = default;

            // returns true if Polys(N) is made an outer; returns false if it fails

            MakeThisOuterRet = false;
            int J, K, C;
            K = modulePOLYS.Polys[N].NoOfChilds;
            if (K >= 0)
                return MakeThisOuterRet;
            K = -K;
            modulePOLYS.Polys[N].NoOfChilds = 0;
            C = 0;
            int loopTo = modulePOLYS.Polys[K].NoOfChilds;
            for (J = 1; J <= loopTo; J++)
            {
                if (modulePOLYS.Polys[K].Childs[J] == N)
                {
                    C = J;
                    break;
                }
            }

            if (C > 0)
            {
                modulePOLYS.DeleteThisChild(K, J);
            }
            else
            {
                return MakeThisOuterRet;
            }

            MakeThisOuterRet = true;
            return MakeThisOuterRet;
        }

        private void HolePopUpMenu_Click(object sender, EventArgs e)
        {
            SelectParent = true;
        }

        private void SetTransparencyPopUpMenu_Click(object sender, EventArgs e)
        {
            if (modulePOPUP.POPType == "Line")
                moduleMAIN.ARGBColor = moduleLINES.Lines[modulePOPUP.POPIndex].Color;
            if (modulePOPUP.POPType == "Poly")
                moduleMAIN.ARGBColor = modulePOLYS.Polys[modulePOPUP.POPIndex].Color;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                if (modulePOPUP.POPType == "Line")
                    moduleLINES.Lines[modulePOPUP.POPIndex].Color = moduleMAIN.ARGBColor;
                if (modulePOPUP.POPType == "Poly")
                    modulePOLYS.Polys[modulePOPUP.POPIndex].Color = moduleMAIN.ARGBColor;
            }

            moduleMAIN.RebuildDisplay();
        }

        private void GoToPositionMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmGotoPos.ShowDialog();
        }

        private void ShowAircraftMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleMAIN.AircraftVIEW == false)
            {
                try
                {
                    FSUIPCConnection.Open();
                    FSUIPCConnection.Process();
                    AircraftLatitude = LatAircraft.Value;
                    AircraftLatitude = AircraftLatitude * 90.0d / (10001750.0d * 65536.0d * 65536.0d);
                    AircraftLongitude = LonAircraft.Value;
                    AircraftLongitude = AircraftLongitude * 360.0d / (65536.0d * 65536.0d * 65536.0d * 65536.0d);
                }
                catch (Exception)
                {
                    FSUIPCConnection.Close();
                    MessageBox.Show("Error communicating with FSUIPC!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                moduleMAIN.LonDispCenter = AircraftLongitude;
                moduleMAIN.LatDispCenter = AircraftLatitude;
                moduleMAIN.SetDispCenter(0, 0);
                ShowAircraftMenuItem.Checked = true;
                UpdateAircraft(moduleMAIN.ShowAircraftPeriod);
                moduleMAIN.AircraftVIEW = true;
            }
            else
            {
                FSUIPCConnection.Close();
                UpdateAircraft(0);
                ShowAircraftMenuItem.Checked = false;
                moduleMAIN.AircraftVIEW = false;
            }

            moduleMAIN.RebuildDisplay();
        }

        internal void UpdateAircraft(int N)
        {
            if (N > 0)
            {
                Timer2.Interval = N;
                Timer2.Enabled = true;
                return;
            }

            if (N == 0)
            {
                Timer2.Enabled = false;
            }
        }

        private void Timer2_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                FSUIPCConnection.Process();
                AircraftLatitude = LatAircraft.Value;
                AircraftLatitude = AircraftLatitude * 90.0d / (10001750.0d * 65536.0d * 65536.0d);
                AircraftLongitude = LonAircraft.Value;
                AircraftLongitude = AircraftLongitude * 360.0d / (65536.0d * 65536.0d * 65536.0d * 65536.0d);
            }
            catch (Exception)
            {
                MessageBox.Show("Error communicating with FSUIPC!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowAircraftMenuItem.Checked = false;
                Timer2.Enabled = false;
                moduleMAIN.AircraftVIEW = false;
                FSUIPCConnection.Close();
                return;
            }

            UpdateDisplay();
        }

        private void FlyAircraftToMenuItem_Click(object sender, EventArgs e)
        {
            string A;
            double Lat, Lon;
            try
            {
                if (moduleMAIN.AircraftVIEW)   // this on May 25 2009
                {
                    FSUIPCConnection.Close();
                    UpdateAircraft(0);
                    ShowAircraftMenuItem.Checked = false;
                    moduleMAIN.AircraftVIEW = false;
                }

                FSUIPCConnection.Open();
                A = "Fly your Aircraft to this position:" + Environment.NewLine;
                A = A + moduleMAIN.Lat2Str(moduleMAIN.LatDispCenter) + "   " + moduleMAIN.Lon2Str(moduleMAIN.LonDispCenter) + " ?";
                if (MessageBox.Show(A, "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    return;
                Lat = moduleMAIN.LatDispCenter;
                Lat = Lat * (10001750.0d * 65536.0d * 65536.0d) / 90.0d;
                Lon = moduleMAIN.LonDispCenter;
                Lon = Lon * (65536.0d * 65536.0d * 65536.0d * 65536.0d) / 360.0d;
                LatAircraft.Value = (long)Lat;
                LonAircraft.Value = (long)Lon;
                FSUIPCConnection.Process();
                FSUIPCConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error communicating with FSUIPC!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FlyToPopUPMenu_Click(object sender, EventArgs e)
        {
            double Lat, Lon;
            try
            {
                if (moduleMAIN.AircraftVIEW)   // this on May 25 2009
                {
                    FSUIPCConnection.Close();
                    UpdateAircraft(0);
                    ShowAircraftMenuItem.Checked = false;
                    moduleMAIN.AircraftVIEW = false;
                }

                FSUIPCConnection.Open();
                Lat = moduleMAIN.LatDispNorth - modulePOPUP.YPOP / moduleMAIN.PixelsPerLatDeg;
                Lat = Lat * (10001750.0d * 65536.0d * 65536.0d) / 90.0d;
                Lon = moduleMAIN.LonDispWest + modulePOPUP.XPOP / moduleMAIN.PixelsPerLonDeg;
                Lon = Lon * (65536.0d * 65536.0d * 65536.0d * 65536.0d) / 360.0d;
                LatAircraft.Value = (long)Lat;
                LonAircraft.Value = (long)Lon;
                FSUIPCConnection.Process();
                FSUIPCConnection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error communicating with FSUIPC!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DisplayAircraft(Graphics g)
        {
            Pen myPen = new Pen(Color.Red);
            int X1, Y1, X2, Y2;
            int CenterX, CenterY;
            CenterX = (int)((AircraftLongitude - moduleMAIN.LonDispWest) * moduleMAIN.PixelsPerLonDeg);
            CenterY = (int)((moduleMAIN.LatDispNorth - AircraftLatitude) * moduleMAIN.PixelsPerLatDeg);
            X1 = CenterX;
            X2 = CenterX;
            Y1 = CenterY - 10;
            Y2 = CenterY + 10;
            g.DrawLine(myPen, X1, Y1, X2, Y2);
            X1 = CenterX - 10;
            X2 = CenterX + 10;
            Y1 = CenterY;
            Y2 = CenterY;
            g.DrawLine(myPen, X1, Y1, X2, Y2);
            myPen.Dispose();
        }

        private void PropertiesMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmProjectP.ShowDialog();
        }

        private void ExportBLNMenuItem_Click(object sender, EventArgs e)
        {
            string a, b;
            if (moduleLINES.NoOfLines == 0 & modulePOLYS.NoOfPolys == 0)
            {
                MessageBox.Show("There is no line or polygon to export!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            a = "Surfer File (*.BLN)|*.BLN";
            b = "SBuilderX: Export As Surfer File";
            a = moduleFILE_IO.FileNameToSave(a, b, "SUR");
            if (string.IsNullOrEmpty(a))
                return;

            // WorkFile = A$
            moduleSURFER.ExportSurfer(ref a);
            moduleMAIN.Dirty = false;
        }

        private void AppendBLNMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmSurfer.ShowDialog();
            FileOpenTrailer();
            moduleMAIN.Dirty = true;
        }

        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            lbDonation.Visible = false;
            My.MyProject.Forms.FrmAbout.ShowDialog();
        }

        // Private Sub PreferencesMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferencesMenuItem.Click

        // frmPreferences.ShowDialog()

        // End Sub

        private void FindMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmFind.ShowDialog();
        }

        private void ShowBackgroundMenuItem_Click(object sender, EventArgs e)
        {
            moduleTILES.TilesDownloading.Clear();
            moduleTILES.TilesFailed.Clear();
            moduleTILES.TilesToCome = 0;
            if (moduleTILES.TileVIEW == false)
            {
                ShowBackgroundMenuItem.Checked = true;
                FromBackgroundMapMenuItem.Enabled = true;
                moduleTILES.TileVIEW = true;
                MakeBackground();
            }
            else
            {
                ShowBackgroundMenuItem.Checked = false;
                FromBackgroundMapMenuItem.Enabled = false;
                moduleTILES.TileVIEW = false;
                lbTilesRemaining.Visible = false;
            }

            moduleMAIN.RebuildDisplay();
        }

        private void SaveBackGroundPopUpMenu_Click(object sender, EventArgs e)
        {
            if (My.MyProject.Forms.FrmBackground.ShowDialog() == DialogResult.OK)
            {
                string a, b;
                a = "Geotiff image (*.TIF)|*.TIF";
                b = "SBuilderX: Save Background as a Geotiff image";
                a = moduleFILE_IO.FileNameToSave(a, b, "BMP");
                if (string.IsNullOrEmpty(a))
                {
                    return;
                }

                // WorkFile = a$
                moduleTILES.SaveBackground(a);
                moduleMAIN.Dirty = false;
            }
        }

        private void ColorFromMap(int X, int y)
        {
            Color myColor = moduleMAIN.BitmapBuffer.GetPixel(X, y);
            int N = My.MyProject.Forms.FrmProjectP.lstClassItems.SelectedIndex + 1;
            moduleCLASSES.LWCIs[N].Color = myColor;
            My.MyProject.Forms.FrmProjectP.lbClassItem.BackColor = myColor;
            My.MyProject.Forms.FrmProjectP.lbClassItem.ForeColor = moduleMAIN.InvertColor(myColor);
            My.MyProject.Forms.FrmProjectP.Show();
        }

        public void MakeBackground()
        {
            if (moduleTILES.TileVIEW == false)
                return;
            bool Download = false;
            if (moduleMAIN.Zoom > moduleTILES.GlobeOrTiles)
            {
                if (string.IsNullOrEmpty(moduleTILES.ActiveTileFolder))
                    return;
                if (moduleTILES.TilesToCome > 0)
                    return;
                moduleTILES.TimeToUpdate = false;
                int X, Y, X0, X1, Y0, Y1;
                int HH;
                int[] H = new int[7];
                Bitmap img_tile;
                string TileExtension = moduleTILES.TileServer.ImageType;
                string TilePrefix = @"\L" + moduleMAIN.Zoom.ToString().Trim() + "X";
                moduleTILES.TileFolder = moduleMAIN.AppPath + @"\Tiles\" + moduleTILES.TileServer.ServerName;
                string TileName, TileFull, TileTemp;
                if (!My.MyProject.Computer.FileSystem.DirectoryExists(moduleTILES.TileFolder))
                {
                    Directory.CreateDirectory(moduleTILES.TileFolder);
                }

                moduleTILES.DownloadTileHandler myDownloadTileHandler = moduleTILES.TileServer.DownloadTile;
                moduleTILES.TileHandlerState myTileHandlerState;
                IAsyncResult AR;
                string TileDir;
                Rectangle box = default(Rectangle);
                box.Width = 256;
                X = moduleTILES.XTilesFromLon(moduleMAIN.LonDispCenter, moduleMAIN.Zoom);
                Y = moduleTILES.YTilesFromLat(moduleMAIN.LatDispCenter, moduleMAIN.Zoom);
                X0 = X - 5;
                Y0 = Y - 3;
                X1 = X + 5;
                Y1 = Y + 3;
                HH = 0;
                moduleTILES.PixelHeightFromY(Y0, ref H, 7, moduleMAIN.Zoom);
                for (Y = 0; Y <= 6; Y++)
                    HH = HH + H[Y];

                // ImageBackground = ImageBackground0
                moduleTILES.ImageBackground0 = null;
                moduleTILES.ImageBackground0 = new Bitmap(2816, HH);
                Graphics g = Graphics.FromImage(moduleTILES.ImageBackground0);
                box.Y = 0;
                int loopTo = Y1;
                for (Y = Y0; Y <= loopTo; Y++)
                {
                    box.Height = H[Y - Y0];
                    box.X = 0;
                    int loopTo1 = X1;
                    for (X = X0; X <= loopTo1; X++)
                    {
                        TileDir = moduleTILES.TileDirFromXYZ(X, Y, moduleMAIN.Zoom);
                        TileName = TilePrefix + X.ToString().Trim() + "Y" + Y.ToString().Trim() + TileExtension;
                        if (moduleMAIN.Zoom > moduleTILES.MaximumZoom)
                        {
                            img_tile = moduleTILES.najpg;
                        }
                        else
                        {
                            try
                            {
                                TileFull = moduleTILES.TileFolder + TileDir + TileName;
                                img_tile = (Bitmap)Image.FromFile(TileFull);
                            }
                            catch (Exception)
                            {
                                img_tile = moduleTILES.blankjpg;
                                if (!moduleTILES.TilesFailed.Contains(TileName))
                                {
                                    if (!moduleTILES.TilesDownloading.Contains(TileName))
                                    {
                                        Download = true;
                                        TileTemp = moduleMAIN.AppPath + @"\Tiles" + TileName;
                                        moduleTILES.TilesDownloading.Add(TileName);
                                        moduleTILES.TilesToCome = moduleTILES.TilesToCome + 1;
                                        moduleTILES.TileHasArrived(moduleTILES.TilesToCome);
                                        myTileHandlerState.handler = myDownloadTileHandler;
                                        myTileHandlerState.tile = TileName;
                                        myTileHandlerState.dir = TileDir;
                                        AR = myDownloadTileHandler.BeginInvoke(X, Y, moduleMAIN.Zoom, TileTemp, moduleTILES.myDownloadTileCallback, myTileHandlerState);
                                    }
                                }
                            }
                        }

                        g.DrawImage(img_tile, box);
                        box.X = box.X + 256;
                    }

                    box.Y = box.Y + H[Y - Y0];
                }

                g.Dispose();
                moduleTILES.MapBackground0.WLON = moduleTILES.LonFromXMerc(X0, moduleMAIN.Zoom);
                moduleTILES.MapBackground0.ELON = moduleTILES.LonFromXMerc(X1 + 1, moduleMAIN.Zoom);
                moduleTILES.MapBackground0.NLAT = moduleTILES.LatFromYMerc(Y0, moduleMAIN.Zoom);
                moduleTILES.MapBackground0.SLAT = moduleTILES.LatFromYMerc(Y1 + 1, moduleMAIN.Zoom);
                moduleTILES.MapBackground0.COLS = moduleTILES.ImageBackground0.Width;
                moduleTILES.MapBackground0.ROWS = moduleTILES.ImageBackground0.Height;
                moduleTILES.TimeToUpdate = true;
            }
            else
            {
                moduleTILES.MapBackground0.NLAT = 90d;
                moduleTILES.MapBackground0.SLAT = -90;
                moduleTILES.MapBackground0.ELON = 180d;
                moduleTILES.MapBackground0.WLON = -180;
                moduleTILES.MapBackground0.COLS = moduleTILES.ImageGlobe.Width;
                moduleTILES.MapBackground0.ROWS = moduleTILES.ImageGlobe.Height;
            }

            if (Download == false)
            {
                moduleTILES.MapBackground = moduleTILES.MapBackground0;
                moduleTILES.ImageBackground = moduleTILES.ImageBackground0;
            }
        }

        internal void DownloadTileCallback(IAsyncResult ar)
        {

            // *** this code fires at completion of each asynchronous method call
            moduleTILES.TileHandlerState myTileHandlerState;
            myTileHandlerState = (moduleTILES.TileHandlerState)ar.AsyncState;
            moduleTILES.DownloadTileHandler caller = (moduleTILES.DownloadTileHandler)myTileHandlerState.handler;
            string Tilename = myTileHandlerState.tile;
            string TileDir = myTileHandlerState.dir;
            string TileFull = moduleTILES.TileFolder + TileDir + Tilename;
            string TileTemp = moduleMAIN.AppPath + @"\Tiles" + Tilename;
            bool retval = false;
            try
            {
                retval = caller.EndInvoke(ar);
            }
            catch (Exception)
            {
            }

            moduleTILES.TilesDownloading.Remove(Tilename);
            moduleTILES.TilesToCome = moduleTILES.TilesToCome - 1;
            if (retval) // not failed
            {
                if (My.MyProject.Computer.FileSystem.FileExists(TileTemp))
                {
                    My.MyProject.Computer.FileSystem.CopyFile(TileTemp, TileFull);
                    My.MyProject.Computer.FileSystem.DeleteFile(TileTemp);
                }
                // Debug.Print("Success = " & Tilename)
                else // as if failed
                {
                    moduleTILES.TilesFailed.Add(Tilename);
                    // Debug.Print("Failed = " & Tilename)
                }
            }
            else // 
            {
                if (My.MyProject.Computer.FileSystem.FileExists(TileTemp))
                {
                    My.MyProject.Computer.FileSystem.DeleteFile(TileTemp);
                }

                moduleTILES.TilesFailed.Add(Tilename);
                // Debug.Print("Failed = " & Tilename)
            }

            if (moduleTILES.TilesToCome < 0)
                moduleTILES.TilesToCome = 0;
            UpdateUI(moduleTILES.TilesToCome);
        }

        private delegate void UpdateUIHandler(int remain);

        internal void UpdateUI(int remain)
        {

            // *** check to see if thread switch is required
            if (InvokeRequired)
            {
                UpdateUIHandler handler = new UpdateUIHandler(moduleTILES.TileHasArrived);
                BeginInvoke(handler, (object)remain);
            }
            else
            {
                moduleTILES.TileHasArrived(remain);
            }
        }

        private void JoinAllPopUPMenu_Click(object sender, EventArgs e)
        {
            if (moduleLINES.LineON)
            {
                moduleLINES.TryAllLineJoin();
            }

            if (modulePOLYS.PolyON)
            {
                modulePOLYS.TryAllPolyJoin();
            }

            moduleMAIN.RebuildDisplay();
        }

        private void FromBackgroundMapMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleMAIN.Zoom > moduleTILES.GlobeOrTiles)
            {
                PointerToolStripButton_Click(PointerToolStripButton, new EventArgs());
                My.MyProject.Forms.FrmTiles.ShowDialog();
            }
        }

        private void Timer3_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            moduleFILE_IO.BackUpFileCounter = moduleFILE_IO.BackUpFileCounter + 1;
            if (moduleFILE_IO.BackUpFileCounter == 100)
                moduleFILE_IO.BackUpFileCounter = 0;
            string A = moduleFILE_IO.BackUpFileCounter.ToString("00") + ".SBP";
            moduleFILE_IO.SaveFile(moduleFILE_IO.BackUpFileName + A);
        }

        private void CmdLink_Click(object sender, EventArgs e)
        {
            string HTMLFile;
            HTMLFile = "https://www.paypal.com/cgi-bin/webscr?cmd=_xclick&business=ptsim%40ptsim%2ecom&item_name=Donation%20for%20SBuilderX&page_style=SBuilderX&no_shipping=1&return=http%3a%2f%2fwww%2eptsim%2ecom%2fsbuilderx%2fthankyou%2easp&cancel_return=http%3a%2f%2fwww%2eptsim%2ecom%2fsbuilderx%2fthankyou%2easp&cn=Optional%20Note&tax=0&currency_code=EUR&lc=GB&bn=PP%2dDonationsBF&charset=UTF%2d8";
            Process.Start(HTMLFile);
            lbDonation.Visible = false;
        }

        private void SbuilderHelpMenuItem_Click(object sender, EventArgs e)
        {
            lbDonation.Visible = false;
            string HelpFile;
            HelpFile = My.MyProject.Application.Info.DirectoryPath + @"\Help\SbuilderX313.chm";
            if (File.Exists(HelpFile))
            {
                Process.Start(HelpFile);
                return;
            }

            // HelpFile = My.Application.Info.DirectoryPath & "\Help\Sbuilder.htm"
            // If File.Exists(HelpFile) Then
            // Process.Start(HelpFile)
            // Exit Sub
            // End If

            // HelpFile = "http://www.ptsim.com/forum/viewtopic.php?f=22&t=1056"
            // Process.Start(HelpFile)

        }

        private void ForumMenuItem_Click(object sender, EventArgs e)
        {
            lbDonation.Visible = false;
            string HTMLFile;
            HTMLFile = "http://www.ptsim.com/forum/viewforum.php?f=22";
            Process.Start(HTMLFile);
        }

        private void GetMapMenuItem_Click(object sender, EventArgs e)
        {
            lbDonation.Visible = false;
            string HTMLFile;
            HTMLFile = "http://www.ptsim.com/sbuilder/gmaps.asp?Lat=" + moduleMAIN.LatIniCenter + "&Lon=" + moduleMAIN.LonIniCenter + "&Zoom=" + moduleMAIN.Zoom;
            Process.Start(HTMLFile);
        }

        private void FrmStart_Shown(object sender, EventArgs e)
        {
            if (moduleMAIN.ShowDonation)
            {
                BackColorGray = true;
                StatusStrip.Visible = false;
                lbScale.Visible = false;
                lbScaleBar.Visible = false;
                lbDonation.Visible = true;
                My.MyProject.Forms.FrmAbout.ShowDialog();
                BackColorGray = false;
                StatusStrip.Visible = true;
                lbScale.Visible = true;
                lbScaleBar.Visible = true;
                moduleMAIN.RebuildDisplay();
            }
        }

        private void AppendRAWMenuItem_Click(object sender, EventArgs e)
        {
            string A, B, C;
            bool Good = false;
            int J = default, K = default;
            A = "Land or Water class Raw file (*.RAW)|*.RAW";
            B = "SBuilderX: Append Raw File";
            C = moduleFILE_IO.FileNameToOpen(A, B, "RAW");
            if (string.IsNullOrEmpty(C))
            {
                return;
            }

            A = Path.GetFileNameWithoutExtension(C).ToUpper();
            B = (A.Length < 3) ? "" : A.Substring(0, 3);
            if (B == "LC_" | B == "WC_")
                Good = true;
            if (Good)
            {
                try
                {
                    J = Convert.ToInt32(A.Substring(3, 2));
                    K = Convert.ToInt32(A.Substring(5, 2));
                }
                catch (Exception)
                {
                    Good = false;
                }
            }

            if (Good)
            {
                if (J < 0 | J > 95 | K < 0 | K > 63)
                {
                    Good = false;
                }
            }

            if (Good == false)
            {
                My.MyProject.Forms.FrmRAW.ShowDialog();
                if (My.MyProject.Forms.FrmRAW.DialogResult == DialogResult.OK)
                {
                    J = My.MyProject.Forms.FrmRAW.J;
                    K = My.MyProject.Forms.FrmRAW.K;
                    Good = true;
                    if (J < 0 | J > 95 | K < 0 | K > 63)
                    {
                        Good = false;
                    }

                    B = My.MyProject.Forms.FrmRAW.C;
                    My.MyProject.Forms.frmSCREEN.Dispose();
                }
                else
                {
                    My.MyProject.Forms.frmSCREEN.Dispose();
                    return;
                }
            }

            if (!Good)
            {
                MessageBox.Show("Wrong File Specification!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // is good!
            if (B == "LC_")
            {
                if (moduleCLASSES.AppendRawLand(C, J, K))
                {
                    FileOpenTrailer();
                    moduleMAIN.Dirty = true;
                }
                else
                {
                    MessageBox.Show("Error in reading land class file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else if (B == "WC_")
            {
                if (moduleCLASSES.AppendRawWater(C, J, K))
                {
                    FileOpenTrailer();
                    moduleMAIN.Dirty = true;
                }
                else
                {
                    MessageBox.Show("Error in reading waster class file!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void ObjLibManagerMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLibrary.Show();
        }

        private string SliceGuid;  // to put a copy and then use it for deleting

        private void SliceQMIDPopUpMenu_Click(object sender, EventArgs e)
        {
            int NP = modulePOLYS.NoOfPolys;
            int K;
            if (moduleLINES.AutoLinePolyJoin)
            {
                string A = "It is recommended to edit the INI file " + Environment.NewLine;
                A = A + "and set AutoLinePolyJoin=False. Do you want to continue?";
                if (MessageBox.Show(A, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            int N;
            if (modulePOPUP.POPType == "Poly")
            {
                if (modulePOPUP.POPMode == "Many") // many to set
                {
                    int loopTo = NP;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected)
                        {
                            if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                            {
                                SliceGuid = modulePOLYS.Polys[N].Guid;
                                SliceThisQMIDPoly(N);
                                modulePOLYS.Polys[N].Guid = "Delete!";
                                int loopTo1 = modulePOLYS.Polys[N].NoOfChilds;
                                for (K = 1; K <= loopTo1; K++)
                                    modulePOLYS.Polys[modulePOLYS.Polys[N].Childs[K]].Guid = "Delete!";
                            }
                        }
                    }
                }
                else if (modulePOPUP.POPMode == "One")
                {
                    if (modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfChilds >= 0)
                    {
                        SliceGuid = modulePOLYS.Polys[modulePOPUP.POPIndex].Guid;
                        SliceThisQMIDPoly(modulePOPUP.POPIndex);
                        modulePOLYS.Polys[modulePOPUP.POPIndex].Guid = "Delete!";
                        int loopTo2 = modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfChilds;
                        for (K = 1; K <= loopTo2; K++)
                            modulePOLYS.Polys[modulePOLYS.Polys[modulePOPUP.POPIndex].Childs[K]].Guid = "Delete!";
                    }
                }

                moduleEDIT.SkipBackUp = true;
                for (N = NP; N >= 1; N -= 1)
                {
                    if (modulePOLYS.Polys[N].Guid == "Delete!")
                    {
                        modulePOLYS.DeletePoly(N);
                    }
                }

                moduleEDIT.SkipBackUp = false;
            }

            if (modulePOPUP.POPType == "Line")
            {
                if (modulePOPUP.POPMode == "Many") // many to set
                {
                    int loopTo3 = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo3; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            SliceThisQMIDLine(N);
                        }
                    }
                }
                else if (modulePOPUP.POPMode == "One")
                {
                    SliceThisQMIDLine(modulePOPUP.POPIndex);
                }
            }

            moduleMAIN.Dirty = true;
            moduleMAIN.RebuildDisplay();
        }

        private void SliceThisQMIDPoly(int Pl)
        {
            if (modulePOLYS.Polys[Pl].NoOfChilds < 0)
                return;
            if (modulePOLYS.Polys[Pl].NoOfChilds == 0)
                modulePOLYS.MakePolyClockWise(Pl);
            int N;
            double LA, LAS, LAN;
            double LO, LOW, LOE;
            LAN = modulePOLYS.Polys[Pl].NLAT;
            LAS = modulePOLYS.Polys[Pl].SLAT;
            LOW = modulePOLYS.Polys[Pl].WLON;
            LOE = modulePOLYS.Polys[Pl].ELON;
            N = (int)(LAS / LatitudeDelta);
            LAS = (N + 1) * LatitudeDelta;
            N = (int)(LAN / LatitudeDelta);
            LA = LAN % LatitudeDelta;
            if (LA == 0d)
                N = N - 1;
            LAN = N * LatitudeDelta;
            N = (int)(LOW / LongitudeDelta);
            LOW = (N + 1) * LongitudeDelta;
            N = (int)(LOE / LongitudeDelta);
            LO = LOE % LongitudeDelta;
            if (LO == 0d)
                N = N - 1;
            LOE = N * LongitudeDelta;
            ClipPoly P = new ClipPoly();
            moduleMAIN.NoOfSlices = 0;
            P.SetPoly(Pl);
            double loopTo = LAN;
            for (LA = LAS; LatitudeDelta >= 0 ? LA <= loopTo : LA >= loopTo; LA += LatitudeDelta)
                P.InsertLatCrossing(LA);
            double loopTo1 = LOE;
            for (LO = LOW; LongitudeDelta >= 0 ? LO <= loopTo1 : LO >= loopTo1; LO += LongitudeDelta)
                P.InsertLonCrossing(LO);
            LAS = LAS - LatitudeDelta / 2d;
            LAN = LAN + LatitudeDelta / 2d;
            LOW = LOW - LongitudeDelta / 2d;
            LOE = LOE + LongitudeDelta / 2d;

            // going trought the center of quads
            double loopTo2 = LAN;
            for (LA = LAS; LatitudeDelta >= 0 ? LA <= loopTo2 : LA >= loopTo2; LA += LatitudeDelta)
            {
                double loopTo3 = LOE;
                for (LO = LOW; LongitudeDelta >= 0 ? LO <= loopTo3 : LO >= loopTo3; LO += LongitudeDelta)
                {
                    P.SetQuad(moduleMAIN.QMIDLevel, LA, LO);
                    P.Clip2Quad();
                    Slices2Polys(Pl);
                }
            }

            // Level11MenuItem.Checked = True
            // QMIDLevel = 11
            // ResetLevelGrid()
            // SetLatLonDeltas()
            // RebuildDisplay()

        }

        private void SliceThisQMIDLine(int Ln)
        {
            int N;
            double LA, LAS, LAN;
            double LO, LOW, LOE;
            LAN = moduleLINES.Lines[Ln].NLAT;
            LAS = moduleLINES.Lines[Ln].SLAT;
            LOW = moduleLINES.Lines[Ln].WLON;
            LOE = moduleLINES.Lines[Ln].ELON;
            N = (int)(LAS / LatitudeDelta);
            LAS = (N + 1) * LatitudeDelta;
            N = (int)(LAN / LatitudeDelta);
            LA = LAN % LatitudeDelta;
            if (LA == 0d)
                N = N - 1;
            LAN = N * LatitudeDelta;
            N = (int)(LOW / LongitudeDelta);
            LOW = (N + 1) * LongitudeDelta;
            N = (int)(LOE / LongitudeDelta);
            LO = LOE % LongitudeDelta;
            if (LO == 0d)
                N = N - 1;
            LOE = N * LongitudeDelta;
            ClipLine L = new ClipLine();
            moduleMAIN.NoOfSlices = 0;
            L.SetLine(Ln);
            double loopTo = LAN;
            for (LA = LAS; LatitudeDelta >= 0 ? LA <= loopTo : LA >= loopTo; LA += LatitudeDelta)
                L.InsertLatCrossing(LA);
            double loopTo1 = LOE;
            for (LO = LOW; LongitudeDelta >= 0 ? LO <= loopTo1 : LO >= loopTo1; LO += LongitudeDelta)
                L.InsertLonCrossing(LO);
            LAS = LAS - LatitudeDelta / 2d;
            LAN = LAN + LatitudeDelta / 2d;
            LOW = LOW - LongitudeDelta / 2d;
            LOE = LOE + LongitudeDelta / 2d;

            // going trought the center of quads
            double loopTo2 = LAN;
            for (LA = LAS; LatitudeDelta >= 0 ? LA <= loopTo2 : LA >= loopTo2; LA += LatitudeDelta)
            {
                double loopTo3 = LOE;
                for (LO = LOW; LongitudeDelta >= 0 ? LO <= loopTo3 : LO >= loopTo3; LO += LongitudeDelta)
                {
                    L.SetQuad(moduleMAIN.QMIDLevel, LA, LO);
                    L.Fragment2Quad();
                }
            }

            Fragments2Lines(Ln);

            // Level11MenuItem.Checked = True
            // QMIDLevel = 11
            // ResetLevelGrid()
            // SetLatLonDeltas()
            // RebuildDisplay()

        }

        private void FillQMIDPopUpMenu_Click(object sender, EventArgs e)
        {
            int NP = modulePOLYS.NoOfPolys;
            int K;
            if (moduleLINES.AutoLinePolyJoin)
            {
                string A = "It is recommended to edit the INI file " + Environment.NewLine;
                A = A + "and set AutoLinePolyJoin=False. Do you want to continue?";
                if (MessageBox.Show(A, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;
            }

            if (moduleEDIT.BackUpON)
                moduleEDIT.BackUp();
            int N;
            if (modulePOPUP.POPType == "Poly")
            {
                if (modulePOPUP.POPMode == "Many") // many to set
                {
                    int loopTo = NP;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected)
                        {
                            if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                            {
                                SliceGuid = modulePOLYS.Polys[N].Guid;
                                FillThisQMIDPoly(N);
                                modulePOLYS.Polys[N].Guid = "Delete!";
                                int loopTo1 = modulePOLYS.Polys[N].NoOfChilds;
                                for (K = 1; K <= loopTo1; K++)
                                    modulePOLYS.Polys[modulePOLYS.Polys[N].Childs[K]].Guid = "Delete!";
                            }
                        }
                    }
                }
                else if (modulePOPUP.POPMode == "One")
                {
                    if (modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfChilds >= 0)
                    {
                        SliceGuid = modulePOLYS.Polys[modulePOPUP.POPIndex].Guid;
                        FillThisQMIDPoly(modulePOPUP.POPIndex);
                        modulePOLYS.Polys[modulePOPUP.POPIndex].Guid = "Delete!";
                        int loopTo2 = modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfChilds;
                        for (K = 1; K <= loopTo2; K++)
                            modulePOLYS.Polys[modulePOLYS.Polys[modulePOPUP.POPIndex].Childs[K]].Guid = "Delete!";
                    }
                }

                moduleEDIT.SkipBackUp = true;
                for (N = NP; N >= 1; N -= 1)
                {
                    if (modulePOLYS.Polys[N].Guid == "Delete!")
                    {
                        modulePOLYS.DeletePoly(N);
                    }
                }

                moduleEDIT.SkipBackUp = false;
            }

            moduleMAIN.Dirty = true;
            moduleMAIN.RebuildDisplay();
        }

        private void FillThisQMIDPoly(int Pl)
        {
            if (modulePOLYS.Polys[Pl].NoOfChilds < 0)
                return;
            if (modulePOLYS.Polys[Pl].NoOfChilds == 0)
                modulePOLYS.MakePolyClockWise(Pl);
            int N;
            double LA, LAS, LAN;
            double LO, LOW, LOE;
            LAN = modulePOLYS.Polys[Pl].NLAT;
            LAS = modulePOLYS.Polys[Pl].SLAT;
            LOW = modulePOLYS.Polys[Pl].WLON;
            LOE = modulePOLYS.Polys[Pl].ELON;
            N = (int)(LAS / LatitudeDelta);
            LAS = (N + 1) * LatitudeDelta;
            N = (int)(LAN / LatitudeDelta);
            LA = LAN % LatitudeDelta;
            if (LA == 0d)
                N = N - 1;
            LAN = N * LatitudeDelta;
            N = (int)(LOW / LongitudeDelta);
            LOW = (N + 1) * LongitudeDelta;
            N = (int)(LOE / LongitudeDelta);
            LO = LOE % LongitudeDelta;
            if (LO == 0d)
                N = N - 1;
            LOE = N * LongitudeDelta;
            ClipPoly P = new ClipPoly();
            moduleMAIN.NoOfSlices = 0;
            P.SetPoly(Pl);
            double loopTo = LAN;
            for (LA = LAS; LatitudeDelta >= 0 ? LA <= loopTo : LA >= loopTo; LA += LatitudeDelta)
                P.InsertLatCrossing(LA);
            double loopTo1 = LOE;
            for (LO = LOW; LongitudeDelta >= 0 ? LO <= loopTo1 : LO >= loopTo1; LO += LongitudeDelta)
                P.InsertLonCrossing(LO);
            LAS = LAS - LatitudeDelta / 2d;
            LAN = LAN + LatitudeDelta / 2d;
            LOW = LOW - LongitudeDelta / 2d;
            LOE = LOE + LongitudeDelta / 2d;

            // going trought the center of quads
            double loopTo2 = LAN;
            for (LA = LAS; LatitudeDelta >= 0 ? LA <= loopTo2 : LA >= loopTo2; LA += LatitudeDelta)
            {
                double loopTo3 = LOE;
                for (LO = LOW; LongitudeDelta >= 0 ? LO <= loopTo3 : LO >= loopTo3; LO += LongitudeDelta)
                {
                    P.SetQuad(moduleMAIN.QMIDLevel, LA, LO);
                    P.Fill2Quad();
                    Slices2Polys(Pl);
                }
            }

            // Level11MenuItem.Checked = True
            // QMIDLevel = 11
            // ResetLevelGrid()
            // SetLatLonDeltas()
            // RebuildDisplay()


        }

        private void Slices2Polys(int P)
        {
            if (moduleMAIN.NoOfSlices == 0)
                return;
            int N, K, J;
            string Name = modulePOLYS.Polys[P].Name;
            string Type = modulePOLYS.Polys[P].Type;
            Color Color = modulePOLYS.Polys[P].Color;
            bool Selected = modulePOLYS.Polys[P].Selected;
            int n0 = default, n1 = default, n2 = default;
            double k1 = default, k2 = default, k3 = default, lat = default, lon;
            modulePOLYS.Get3Points(P, ref n0, ref n1, ref n2, ref lat);
            modulePOLYS.GetSlopes(P, n0, n1, n2, ref k1, ref k2, ref k3);
            Array.Resize(ref modulePOLYS.Polys, modulePOLYS.NoOfPolys + moduleMAIN.NoOfSlices + 1);
            int loopTo = moduleMAIN.NoOfSlices;
            for (N = 1; N <= loopTo; N++)
            {
                modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].Name = Name;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].Type = Type;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].Guid = SliceGuid;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].Color = Color;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].Selected = Selected;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].NoOfPoints = moduleMAIN.Slices[N].N;
                modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].GPoints = new modulePOINTS.GPoint[moduleMAIN.Slices[N].N + 1];
                int loopTo1 = moduleMAIN.Slices[N].N;
                for (K = 1; K <= loopTo1; K++)
                {
                    lat = moduleMAIN.Slices[N].P[K].Y;
                    lon = moduleMAIN.Slices[N].P[K].X;
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].GPoints[K].lat = lat;
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].GPoints[K].lon = lon;
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].GPoints[K].alt = k1 * lon + k2 * lat + k3;
                }
                // now the parents and childs problem!!!
                if (moduleMAIN.Slices[N].NC == 0)    // is single
                {
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].NoOfChilds = 0;
                }
                else if (moduleMAIN.Slices[N].NC < 0)    // is child
                {
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].NoOfChilds = moduleMAIN.Slices[N].NC - modulePOLYS.NoOfPolys;
                }
                else       // is parent
                {
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].NoOfChilds = moduleMAIN.Slices[N].NC;
                    modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].Childs = new int[moduleMAIN.Slices[N].NC + 1];
                    int loopTo2 = moduleMAIN.Slices[N].NC;
                    for (J = 1; J <= loopTo2; J++)
                        modulePOLYS.Polys[modulePOLYS.NoOfPolys + N].Childs[J] = modulePOLYS.NoOfPolys + moduleMAIN.Slices[N].C[J];
                }

                modulePOLYS.AddLatLonToPoly(modulePOLYS.NoOfPolys + N);
            }

            modulePOLYS.NoOfPolys = modulePOLYS.NoOfPolys + moduleMAIN.NoOfSlices;
            moduleMAIN.NoOfSlices = 0;
            moduleMAIN.Slices = new moduleMAIN.Slice[2];
        }

        private void Fragments2Lines(int L)
        {
            int N, K;
            string Name = moduleLINES.Lines[L].Name;
            string Type = moduleLINES.Lines[L].Type;
            string Guid = moduleLINES.Lines[L].Guid;
            Color Color = moduleLINES.Lines[L].Color;
            bool Selected = moduleLINES.Lines[L].Selected;
            moduleLINES.Lines[L].Name = Name;
            moduleLINES.Lines[L].Type = Type;
            moduleLINES.Lines[L].Guid = Guid;
            moduleLINES.Lines[L].Color = Color;
            moduleLINES.Lines[L].Selected = Selected;
            moduleLINES.Lines[L].NoOfPoints = moduleMAIN.Fragments[1].N;
            moduleLINES.Lines[L].GLPoints = new modulePOINTS.GLPoint[moduleMAIN.Fragments[1].N + 1];
            int loopTo = moduleMAIN.Fragments[1].N;
            for (K = 1; K <= loopTo; K++)
            {
                moduleLINES.Lines[L].GLPoints[K].lat = moduleMAIN.Fragments[1].P[K].Y;
                moduleLINES.Lines[L].GLPoints[K].lon = moduleMAIN.Fragments[1].P[K].X;
                moduleLINES.Lines[L].GLPoints[K].alt = moduleMAIN.Fragments[1].P[K].Z;
                moduleLINES.Lines[L].GLPoints[K].wid = moduleMAIN.Fragments[1].P[K].W;
            }

            moduleLINES.AddLatLonToLine(L);
            Array.Resize(ref moduleLINES.Lines, moduleLINES.NoOfLines + moduleMAIN.NoOfFragments);
            int M;
            int loopTo1 = moduleMAIN.NoOfFragments;
            for (N = 2; N <= loopTo1; N++)
            {
                M = moduleLINES.NoOfLines + N - 1;
                moduleLINES.Lines[M].Name = Name;
                moduleLINES.Lines[M].Type = Type;
                moduleLINES.Lines[M].Guid = Guid;
                moduleLINES.Lines[M].Color = Color;
                moduleLINES.Lines[M].Selected = Selected;
                moduleLINES.Lines[M].NoOfPoints = moduleMAIN.Fragments[N].N;
                moduleLINES.Lines[M].GLPoints = new modulePOINTS.GLPoint[moduleMAIN.Fragments[N].N + 1];
                int loopTo2 = moduleMAIN.Fragments[N].N;
                for (K = 1; K <= loopTo2; K++)
                {
                    moduleLINES.Lines[M].GLPoints[K].lat = moduleMAIN.Fragments[N].P[K].Y;
                    moduleLINES.Lines[M].GLPoints[K].lon = moduleMAIN.Fragments[N].P[K].X;
                    moduleLINES.Lines[M].GLPoints[K].alt = moduleMAIN.Fragments[N].P[K].Z;
                    moduleLINES.Lines[M].GLPoints[K].wid = moduleMAIN.Fragments[N].P[K].W;
                }

                moduleLINES.AddLatLonToLine(M);
            }

            moduleLINES.NoOfLines = moduleLINES.NoOfLines + moduleMAIN.NoOfFragments - 1;
            moduleMAIN.NoOfFragments = 0;
            moduleMAIN.Fragments = new moduleMAIN.Fragment[2];
        }

        private void PointFromAircraftPopUpMenu_Click(object sender, EventArgs e)
        {
            double Altitude;
            double Latitude;
            double Longitude;
            try
            {
                if (moduleMAIN.AircraftVIEW)
                {
                    FSUIPCConnection.Close();
                    UpdateAircraft(0);
                    ShowAircraftMenuItem.Checked = false;
                    moduleMAIN.AircraftVIEW = false;
                }

                FSUIPCConnection.Open();
                FSUIPCConnection.Process();
                Latitude = LatAircraft.Value;
                Latitude = Latitude * 90.0d / (10001750.0d * 65536.0d * 65536.0d);
                Longitude = LonAircraft.Value;
                Longitude = Longitude * 360.0d / (65536.0d * 65536.0d * 65536.0d * 65536.0d);
                Altitude = Alt1Aircraft.Value;
                Altitude = Altitude + Alt2Aircraft.Value / (double)(65536.0f * 65536.0f);
                Altitude = Altitude - moduleMAIN.AircraftAltitudeOffset;
                FSUIPCConnection.Close();
                modulePOPUP.POPType = modulePOPUP.POPType + "X";
                My.MyProject.Forms.FrmLPPointsP.Altitude = Altitude;
                My.MyProject.Forms.FrmLPPointsP.Latitude = Latitude;
                My.MyProject.Forms.FrmLPPointsP.Longitude = Longitude;
                My.MyProject.Forms.FrmLPPointsP.ShowDialog();
            }
            catch (Exception)
            {
                FSUIPCConnection.Close();
                MessageBox.Show("Error communicating with FSUIPC!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
        }

        private void TilePathToClipboardPopUpMenu_Click(object sender, EventArgs e)
        {
            if (moduleMAIN.Zoom <= moduleTILES.GlobeOrTiles | string.IsNullOrEmpty(moduleTILES.ActiveTileFolder))
            {
                MessageBox.Show("Can not get Tile Path", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string TileExtension = moduleTILES.TileServer.ImageType;
            string TilePrefix = @"\L" + moduleMAIN.Zoom.ToString().Trim() + "X";
            moduleTILES.TileFolder = moduleMAIN.AppPath + @"\Tiles\" + moduleTILES.TileServer.ServerName;
            int X = moduleTILES.XTilesFromLon(moduleMAIN.LonDispCenter, moduleMAIN.Zoom);
            int Y = moduleTILES.YTilesFromLat(moduleMAIN.LatDispCenter, moduleMAIN.Zoom);
            string TileDir = moduleTILES.TileDirFromXYZ(X, Y, moduleMAIN.Zoom);
            string TileName = TilePrefix + X.ToString().Trim() + "Y" + Y.ToString().Trim() + TileExtension;
            string TileFull = moduleTILES.TileFolder + TileDir + TileName;
            My.MyProject.Computer.Clipboard.SetText(TileFull);
        }

        private void FSXSettingsMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmFSXSettings.ShowDialog();
        }


        // Private Sub FromHereNokiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FromHereNokiaMenuItem.Click
        // AddHereNokiaMap()
        // End Sub

        private void FromGoogleMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAPS.AddGoogleMap();
        }

        private void FromArcGisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAPS.AddArcGisMap();
        }

        private void NoLODMenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = -1;
            LODGridMenuItem.Text = "LOD Grid";
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD0MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 0;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD1MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 1;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD2MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 2;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD3MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 3;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD4MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 4;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD5MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 5;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD6MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 6;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD7MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 7;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD8MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 8;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD9MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 9;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD10MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 10;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD11MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 11;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD12MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 12;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD13MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 13;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD14MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 14;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD15MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 15;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD16MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 16;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD17MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 17;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD18MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 18;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD19MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 19;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD20MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 20;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD21MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 21;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD22MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 22;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD23MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 23;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD24MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 24;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD25MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 25;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD26MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 26;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void LOD27MenuItem_Click(object sender, EventArgs e)
        {
            moduleMAIN.LODLevel = 27;
            ResetLevelGrid(true);
            moduleMAIN.RebuildDisplay();
        }

        private void SnapToQMIDMenuItem_Click(object sender, EventArgs e)
        {
            if (moduleMAIN.QMIDLevel < 4)
                return;
            if (modulePOLYS.NoOfPolysSelected == 0)
            {
                MessageBox.Show("No polygons are selected!", moduleMAIN.AppTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string A = "Snap Points in Selected Polys to";
            A = A + Environment.NewLine + "a QMID Level " + moduleMAIN.QMIDLevel + " grid ?";
            DialogResult x;
            x = MessageBox.Show(A, moduleMAIN.AppTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (x != DialogResult.Yes)
                return;
            if (modulePOLYS.NoOfPolysSelected > 0)
                modulePOLYS.SnapPolys();


            // BackUp()
            // SkipBackUp = True


            moduleMAIN.RebuildDisplay();
            SystemSounds.Beep.Play();
            // SkipBackUp = False


        }

        private void SnapQMIDPopUPMenu_Click(object sender, EventArgs e)
        {
            if (modulePOPUP.POPType == "Poly")
            {
                modulePOLYS.SetDeltaLatLon();
                modulePOLYS.SnapThisPoly(modulePOPUP.POPIndex);
                moduleMAIN.RebuildDisplay();
            }
        }

        private void ExportKMLMenuItem_Click(object sender, EventArgs e)
        {
            string a, b;
            if (moduleLINES.NoOfLines == 0 & modulePOLYS.NoOfPolys == 0)
            {
                MessageBox.Show("There is no line or polygon to export!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (moduleLINES.NoOfLines > 0)
            {
                a = "Google KML file (*.KML)|*.KML";
                b = "SBuilderX: Export As a KML file";
                a = moduleFILE_IO.FileNameToSave(a, b, "KML");
                if (!string.IsNullOrEmpty(a))
                {
                    moduleKML.ExportKML(a);
                }
            }
        }

        private void EditINIFileMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Process myProcess = new Process();
            myProcess = Process.Start("notepad.exe", moduleMAIN.AppIni);
            myProcess.WaitForExit();
            myProcess.Dispose();
            Show();
            moduleFILE_IO.GetSettings();
        }

        private void ObjectFoldersMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmObjectFolders.ShowDialog();
        }

        private void TileServerMenuItem_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.frmTilesServers.ShowDialog();
        }

        private void EnableUndoRedoMenuItem_Click(object sender, EventArgs e)
        {
            if (EnableUndoRedoMenuItem.Checked)
            {
                EnableUndoRedoMenuItem.Checked = false;
            }
            else
            {
                EnableUndoRedoMenuItem.Checked = true;
            }

            moduleEDIT.BackUpON = false;
            if ((int)EnableUndoRedoMenuItem.CheckState == 1)
                moduleEDIT.BackUpON = true;
            moduleFILE_IO.WriteSettings();
            if (moduleEDIT.BackUpON)
            {
                moduleEDIT.BackUpInit();
            }
            else
            {
                moduleEDIT.BackUpFinit();
            }

            EditMenuItem.ShowDropDown();
        }

        private void EditMenuItem_Click(object sender, EventArgs e)
        {

            // added this in October 2017 because of the cosmetic change on Enable Undo Redo! 
            EnableUndoRedoMenuItem.CheckState = CheckState.Unchecked;
            if (moduleEDIT.BackUpON)
            {
                EnableUndoRedoMenuItem.CheckState = CheckState.Checked;
            }
        }

        private void WhatIsNewMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(moduleMAIN.AppPath + @"\Help\whatisnewin315.pdf");
                return;
            }
            catch (Exception)
            {
                string A = "SBuilderX could not find the file: whatisnewin315.pdf which should" + Environment.NewLine;
                A = A + @"exist in the SBuilderX\Help folder! You can download the most recent" + Environment.NewLine;
                A = A + "version of this file from here:" + Environment.NewLine;
                A = A + "http://www.ptsim.com/sbuilderx/whatisnewin315.pdf";
                MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}