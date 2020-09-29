using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmStart : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;

        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.  
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            MenuStrip = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            _NewMenuItem = new ToolStripMenuItem();
            _NewMenuItem.Click += new EventHandler(NewMenuItem_Click);
            _OpenMenuItem = new ToolStripMenuItem();
            _OpenMenuItem.Click += new EventHandler(OpenMenuItem_Click);
            toolStripSeparator = new ToolStripSeparator();
            _SaveMenuItem = new ToolStripMenuItem();
            _SaveMenuItem.Click += new EventHandler(SaveMenuItem_Click);
            _SaveAsMenuItem = new ToolStripMenuItem();
            _SaveAsMenuItem.Click += new EventHandler(SaveAsMenuItem_Click);
            toolStripSeparator1 = new ToolStripSeparator();
            _BGLMenuItem = new ToolStripMenuItem();
            _BGLMenuItem.Click += new EventHandler(BGLMenuItem_Click);
            _PropertiesMenuItem = new ToolStripMenuItem();
            _PropertiesMenuItem.Click += new EventHandler(PropertiesMenuItem_Click);
            ToolStripSeparator8 = new ToolStripSeparator();
            _ImportSBXMenuItem = new ToolStripMenuItem();
            _ImportSBXMenuItem.Click += new EventHandler(ImportSBXMenuItem_Click);
            AppendMenuItem = new ToolStripMenuItem();
            _AppendSBXMenuItem = new ToolStripMenuItem();
            _AppendSBXMenuItem.Click += new EventHandler(AppendSBXMenuItem_Click);
            _AppendBLNMenuItem = new ToolStripMenuItem();
            _AppendBLNMenuItem.Click += new EventHandler(AppendBLNMenuItem_Click);
            _AppendObjMenuItem = new ToolStripMenuItem();
            _AppendObjMenuItem.Click += new EventHandler(AppendObjMenuItem_Click);
            _AppendSHPMenuItem = new ToolStripMenuItem();
            _AppendSHPMenuItem.Click += new EventHandler(AppendSHPMenuItem_Click);
            _AppendRAWMenuItem = new ToolStripMenuItem();
            _AppendRAWMenuItem.Click += new EventHandler(AppendRAWMenuItem_Click);
            AppendVTPMenuItem = new ToolStripMenuItem();
            ExportMenuItem = new ToolStripMenuItem();
            _ExportSBXMenuItem = new ToolStripMenuItem();
            _ExportSBXMenuItem.Click += new EventHandler(ExportSBXMenuItem_Click);
            _ExportBLNMenuItem = new ToolStripMenuItem();
            _ExportBLNMenuItem.Click += new EventHandler(ExportBLNMenuItem_Click);
            _ExportSHPMenuItem = new ToolStripMenuItem();
            _ExportSHPMenuItem.Click += new EventHandler(ExportSHPMenuItem_Click);
            _ExportKMLMenuItem = new ToolStripMenuItem();
            _ExportKMLMenuItem.Click += new EventHandler(ExportKMLMenuItem_Click);
            AddMapMenuItem = new ToolStripMenuItem();
            _FromDiskMenuItem = new ToolStripMenuItem();
            _FromDiskMenuItem.Click += new EventHandler(FromDiskMenuItem_Click);
            _FromBackgroundMapMenuItem = new ToolStripMenuItem();
            _FromBackgroundMapMenuItem.Click += new EventHandler(FromBackgroundMapMenuItem_Click);
            _FromGoogleMapsToolStripMenuItem = new ToolStripMenuItem();
            _FromGoogleMapsToolStripMenuItem.Click += new EventHandler(FromGoogleMapsToolStripMenuItem_Click);
            _FromArcGisToolStripMenuItem = new ToolStripMenuItem();
            _FromArcGisToolStripMenuItem.Click += new EventHandler(FromArcGisToolStripMenuItem_Click);
            ToolStripSeparator9 = new ToolStripSeparator();
            DEMToolsMenuItem = new ToolStripMenuItem();
            CoordinatesToolMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            _ExitMenuItem = new ToolStripMenuItem();
            _ExitMenuItem.Click += new EventHandler(ExitMenuItem_Click);
            RecentFileSeparatorMenuItem = new ToolStripSeparator();
            _RecentFile1MenuItem = new ToolStripMenuItem();
            _RecentFile1MenuItem.Click += new EventHandler(RecentFile1MenuItem_Click);
            _RecentFile2MenuItem = new ToolStripMenuItem();
            _RecentFile2MenuItem.Click += new EventHandler(RecentFile2MenuItem_Click);
            _RecentFile3MenuItem = new ToolStripMenuItem();
            _RecentFile3MenuItem.Click += new EventHandler(RecentFile3MenuItem_Click);
            _RecentFile4MenuItem = new ToolStripMenuItem();
            _RecentFile4MenuItem.Click += new EventHandler(RecentFile4MenuItem_Click);
            _EditMenuItem = new ToolStripMenuItem();
            _EditMenuItem.Click += new EventHandler(EditMenuItem_Click);
            _EnableUndoRedoMenuItem = new ToolStripMenuItem();
            _EnableUndoRedoMenuItem.Click += new EventHandler(EnableUndoRedoMenuItem_Click);
            _UndoMenuItem = new ToolStripMenuItem();
            _UndoMenuItem.Click += new EventHandler(UndoMenuItem_Click);
            _RedoMenuItem = new ToolStripMenuItem();
            _RedoMenuItem.Click += new EventHandler(RedoMenuItem_Click);
            toolStripSeparator3 = new ToolStripSeparator();
            _SnapToQMIDMenuItem = new ToolStripMenuItem();
            _SnapToQMIDMenuItem.Click += new EventHandler(SnapToQMIDMenuItem_Click);
            _MeasureToolMenuItem = new ToolStripMenuItem();
            _MeasureToolMenuItem.Click += new EventHandler(MeasureToolMenuItem_Click);
            _ObjLibManagerMenuItem = new ToolStripMenuItem();
            _ObjLibManagerMenuItem.Click += new EventHandler(ObjLibManagerMenuItem_Click);
            ToolStripSeparator10 = new ToolStripSeparator();
            _CopyMenuItem = new ToolStripMenuItem();
            _CopyMenuItem.Click += new EventHandler(CopyMenuItem_Click);
            _PasteMenuItem = new ToolStripMenuItem();
            _PasteMenuItem.Click += new EventHandler(PasteMenuItem_Click);
            _DeleteMenuItem = new ToolStripMenuItem();
            _DeleteMenuItem.Click += new EventHandler(DeleteMenuItem_Click);
            toolStripSeparator4 = new ToolStripSeparator();
            _FindMenuItem = new ToolStripMenuItem();
            _FindMenuItem.Click += new EventHandler(FindMenuItem_Click);
            ToolStripSeparator11 = new ToolStripSeparator();
            _TileServerMenuItem = new ToolStripMenuItem();
            _TileServerMenuItem.Click += new EventHandler(TileServerMenuItem_Click);
            _FSXSettingsMenuItem = new ToolStripMenuItem();
            _FSXSettingsMenuItem.Click += new EventHandler(FSXSettingsMenuItem_Click);
            _ObjectFoldersMenuItem = new ToolStripMenuItem();
            _ObjectFoldersMenuItem.Click += new EventHandler(ObjectFoldersMenuItem_Click);
            _EditINIFileMenuItem = new ToolStripMenuItem();
            _EditINIFileMenuItem.Click += new EventHandler(EditINIFileMenuItem_Click);
            ViewMenuItem = new ToolStripMenuItem();
            _ShowToolbarMenuItem = new ToolStripMenuItem();
            _ShowToolbarMenuItem.Click += new EventHandler(ShowToolbarMenuItem_Click);
            ToolStripSeparator12 = new ToolStripSeparator();
            _ShowBackgroundMenuItem = new ToolStripMenuItem();
            _ShowBackgroundMenuItem.Click += new EventHandler(ShowBackgroundMenuItem_Click);
            LODGridMenuItem = new ToolStripMenuItem();
            _NoLODMenuItem = new ToolStripMenuItem();
            _NoLODMenuItem.Click += new EventHandler(NoLODMenuItem_Click);
            _LOD0MenuItem = new ToolStripMenuItem();
            _LOD0MenuItem.Click += new EventHandler(LOD0MenuItem_Click);
            _LOD1MenuItem = new ToolStripMenuItem();
            _LOD1MenuItem.Click += new EventHandler(LOD1MenuItem_Click);
            _LOD2MenuItem = new ToolStripMenuItem();
            _LOD2MenuItem.Click += new EventHandler(LOD2MenuItem_Click);
            _LOD3MenuItem = new ToolStripMenuItem();
            _LOD3MenuItem.Click += new EventHandler(LOD3MenuItem_Click);
            _LOD4MenuItem = new ToolStripMenuItem();
            _LOD4MenuItem.Click += new EventHandler(LOD4MenuItem_Click);
            _LOD5MenuItem = new ToolStripMenuItem();
            _LOD5MenuItem.Click += new EventHandler(LOD5MenuItem_Click);
            _LOD6MenuItem = new ToolStripMenuItem();
            _LOD6MenuItem.Click += new EventHandler(LOD6MenuItem_Click);
            _LOD7MenuItem = new ToolStripMenuItem();
            _LOD7MenuItem.Click += new EventHandler(LOD7MenuItem_Click);
            _LOD8MenuItem = new ToolStripMenuItem();
            _LOD8MenuItem.Click += new EventHandler(LOD8MenuItem_Click);
            _LOD9MenuItem = new ToolStripMenuItem();
            _LOD9MenuItem.Click += new EventHandler(LOD9MenuItem_Click);
            _LOD10MenuItem = new ToolStripMenuItem();
            _LOD10MenuItem.Click += new EventHandler(LOD10MenuItem_Click);
            _LOD11MenuItem = new ToolStripMenuItem();
            _LOD11MenuItem.Click += new EventHandler(LOD11MenuItem_Click);
            _LOD12MenuItem = new ToolStripMenuItem();
            _LOD12MenuItem.Click += new EventHandler(LOD12MenuItem_Click);
            _LOD13MenuItem = new ToolStripMenuItem();
            _LOD13MenuItem.Click += new EventHandler(LOD13MenuItem_Click);
            _LOD14MenuItem = new ToolStripMenuItem();
            _LOD14MenuItem.Click += new EventHandler(LOD14MenuItem_Click);
            _LOD15MenuItem = new ToolStripMenuItem();
            _LOD15MenuItem.Click += new EventHandler(LOD15MenuItem_Click);
            _LOD16MenuItem = new ToolStripMenuItem();
            _LOD16MenuItem.Click += new EventHandler(LOD16MenuItem_Click);
            _LOD17MenuItem = new ToolStripMenuItem();
            _LOD17MenuItem.Click += new EventHandler(LOD17MenuItem_Click);
            _LOD18MenuItem = new ToolStripMenuItem();
            _LOD18MenuItem.Click += new EventHandler(LOD18MenuItem_Click);
            _LOD19MenuItem = new ToolStripMenuItem();
            _LOD19MenuItem.Click += new EventHandler(LOD19MenuItem_Click);
            _LOD20MenuItem = new ToolStripMenuItem();
            _LOD20MenuItem.Click += new EventHandler(LOD20MenuItem_Click);
            _LOD21MenuItem = new ToolStripMenuItem();
            _LOD21MenuItem.Click += new EventHandler(LOD21MenuItem_Click);
            _LOD22MenuItem = new ToolStripMenuItem();
            _LOD22MenuItem.Click += new EventHandler(LOD22MenuItem_Click);
            _LOD23MenuItem = new ToolStripMenuItem();
            _LOD23MenuItem.Click += new EventHandler(LOD23MenuItem_Click);
            _LOD24MenuItem = new ToolStripMenuItem();
            _LOD24MenuItem.Click += new EventHandler(LOD24MenuItem_Click);
            _LOD25MenuItem = new ToolStripMenuItem();
            _LOD25MenuItem.Click += new EventHandler(LOD25MenuItem_Click);
            _LOD26MenuItem = new ToolStripMenuItem();
            _LOD26MenuItem.Click += new EventHandler(LOD26MenuItem_Click);
            _LOD27MenuItem = new ToolStripMenuItem();
            _LOD27MenuItem.Click += new EventHandler(LOD27MenuItem_Click);
            QMIDGridMenuItem = new ToolStripMenuItem();
            _NoGridMenuItem = new ToolStripMenuItem();
            _NoGridMenuItem.Click += new EventHandler(NoGridMenuItem_Click);
            _Level2MenuItem = new ToolStripMenuItem();
            _Level2MenuItem.Click += new EventHandler(Level2MenuItem_Click);
            _Level3MenuItem = new ToolStripMenuItem();
            _Level3MenuItem.Click += new EventHandler(Level3MenuItem_Click);
            _Level4MenuItem = new ToolStripMenuItem();
            _Level4MenuItem.Click += new EventHandler(Level4MenuItem_Click);
            _Level5MenuItem = new ToolStripMenuItem();
            _Level5MenuItem.Click += new EventHandler(Level5MenuItem_Click);
            _Level6MenuItem = new ToolStripMenuItem();
            _Level6MenuItem.Click += new EventHandler(Level6MenuItem_Click);
            _Level7MenuItem = new ToolStripMenuItem();
            _Level7MenuItem.Click += new EventHandler(Level7MenuItem_Click);
            _Level8MenuItem = new ToolStripMenuItem();
            _Level8MenuItem.Click += new EventHandler(Level8MenuItem_Click);
            _Level9MenuItem = new ToolStripMenuItem();
            _Level9MenuItem.Click += new EventHandler(Level9MenuItem_Click);
            _Level10MenuItem = new ToolStripMenuItem();
            _Level10MenuItem.Click += new EventHandler(Level10MenuItem_Click);
            _Level11MenuItem = new ToolStripMenuItem();
            _Level11MenuItem.Click += new EventHandler(Level11MenuItem_Click);
            _Level12MenuItem = new ToolStripMenuItem();
            _Level12MenuItem.Click += new EventHandler(Level12MenuItem_Click);
            _Level13MenuItem = new ToolStripMenuItem();
            _Level13MenuItem.Click += new EventHandler(Level13MenuItem_Click);
            _Level14MenuItem = new ToolStripMenuItem();
            _Level14MenuItem.Click += new EventHandler(Level14MenuItem_Click);
            _Level15MenuItem = new ToolStripMenuItem();
            _Level15MenuItem.Click += new EventHandler(Level15MenuItem_Click);
            _Level16MenuItem = new ToolStripMenuItem();
            _Level16MenuItem.Click += new EventHandler(Level16MenuItem_Click);
            _Level17MenuItem = new ToolStripMenuItem();
            _Level17MenuItem.Click += new EventHandler(Level17MenuItem_Click);
            _Level18MenuItem = new ToolStripMenuItem();
            _Level18MenuItem.Click += new EventHandler(Level18MenuItem_Click);
            _Level19MenuItem = new ToolStripMenuItem();
            _Level19MenuItem.Click += new EventHandler(Level19MenuItem_Click);
            _Level20MenuItem = new ToolStripMenuItem();
            _Level20MenuItem.Click += new EventHandler(Level20MenuItem_Click);
            _Level21MenuItem = new ToolStripMenuItem();
            _Level21MenuItem.Click += new EventHandler(Level21MenuItem_Click);
            _Level22MenuItem = new ToolStripMenuItem();
            _Level22MenuItem.Click += new EventHandler(Level22MenuItem_Click);
            _Level23MenuItem = new ToolStripMenuItem();
            _Level23MenuItem.Click += new EventHandler(Level23MenuItem_Click);
            _Level24MenuItem = new ToolStripMenuItem();
            _Level24MenuItem.Click += new EventHandler(Level24MenuItem_Click);
            _Level25MenuItem = new ToolStripMenuItem();
            _Level25MenuItem.Click += new EventHandler(Level25MenuItem_Click);
            _Level26MenuItem = new ToolStripMenuItem();
            _Level26MenuItem.Click += new EventHandler(Level26MenuItem_Click);
            _Level27MenuItem = new ToolStripMenuItem();
            _Level27MenuItem.Click += new EventHandler(Level27MenuItem_Click);
            _Level28MenuItem = new ToolStripMenuItem();
            _Level28MenuItem.Click += new EventHandler(Level28MenuItem_Click);
            _Level29MenuItem = new ToolStripMenuItem();
            _Level29MenuItem.Click += new EventHandler(Level29MenuItem_Click);
            ToolStripSeparator14 = new ToolStripSeparator();
            _GoToPositionMenuItem = new ToolStripMenuItem();
            _GoToPositionMenuItem.Click += new EventHandler(GoToPositionMenuItem_Click);
            _ShowAircraftMenuItem = new ToolStripMenuItem();
            _ShowAircraftMenuItem.Click += new EventHandler(ShowAircraftMenuItem_Click);
            _FlyAircraftToMenuItem = new ToolStripMenuItem();
            _FlyAircraftToMenuItem.Click += new EventHandler(FlyAircraftToMenuItem_Click);
            ToolStripSeparator13 = new ToolStripSeparator();
            ViewMapsMenuItem = new ToolStripMenuItem();
            _SummerMapMenuItem = new ToolStripMenuItem();
            _SummerMapMenuItem.Click += new EventHandler(SummerMapMenuItem_Click);
            _SpringMapMenuItem = new ToolStripMenuItem();
            _SpringMapMenuItem.Click += new EventHandler(SpringMapMenuItem_Click);
            _FallMapMenuItem = new ToolStripMenuItem();
            _FallMapMenuItem.Click += new EventHandler(FallMapMenuItem_Click);
            _WinterMapMenuItem = new ToolStripMenuItem();
            _WinterMapMenuItem.Click += new EventHandler(WinterMapMenuItem_Click);
            _HardWinterMapMenuItem = new ToolStripMenuItem();
            _HardWinterMapMenuItem.Click += new EventHandler(HardWinterMapMenuItem_Click);
            _NightMapMenuItem = new ToolStripMenuItem();
            _NightMapMenuItem.Click += new EventHandler(NightMapMenuItem_Click);
            ToolStripSeparator15 = new ToolStripSeparator();
            _ViewAllMapsMenuItem = new ToolStripMenuItem();
            _ViewAllMapsMenuItem.Click += new EventHandler(ViewAllMapsMenuItem_Click);
            _ViewAllLandsMenuItem = new ToolStripMenuItem();
            _ViewAllLandsMenuItem.Click += new EventHandler(ViewAllLandsMenuItem_Click);
            _ViewAllWatersMenuItem = new ToolStripMenuItem();
            _ViewAllWatersMenuItem.Click += new EventHandler(ViewAllWatersMenuItem_Click);
            _ViewAllLinesMenuItem = new ToolStripMenuItem();
            _ViewAllLinesMenuItem.Click += new EventHandler(ViewAllLinesMenuItem_Click);
            _ViewAllPolysMenuItem = new ToolStripMenuItem();
            _ViewAllPolysMenuItem.Click += new EventHandler(ViewAllPolysMenuItem_Click);
            _ViewAllObjectsMenuItem = new ToolStripMenuItem();
            _ViewAllObjectsMenuItem.Click += new EventHandler(ViewAllObjectsMenuItem_Click);
            _ViewAllExcludesMenuItem = new ToolStripMenuItem();
            _ViewAllExcludesMenuItem.Click += new EventHandler(ViewAllExcludesMenuItem_Click);
            ToolStripSeparator17 = new ToolStripSeparator();
            _ViewAllMenuItem = new ToolStripMenuItem();
            _ViewAllMenuItem.Click += new EventHandler(ViewAllMenuItem_Click);
            SelectMenuItem = new ToolStripMenuItem();
            _SelectAllMapsMenuItem = new ToolStripMenuItem();
            _SelectAllMapsMenuItem.Click += new EventHandler(SelectAllMapsMenuItem_Click);
            ToolStripSeparator24 = new ToolStripSeparator();
            _SelectAllLandsMenuItem = new ToolStripMenuItem();
            _SelectAllLandsMenuItem.Click += new EventHandler(SelectAllLandsMenuItem_Click);
            _SelectAllWatersMenuItem = new ToolStripMenuItem();
            _SelectAllWatersMenuItem.Click += new EventHandler(SelectAllWatersMenuItem_Click);
            _SelectAllLinesMenuItem = new ToolStripMenuItem();
            _SelectAllLinesMenuItem.Click += new EventHandler(SelectAllLinesMenuItem_Click);
            _SelectAllPolysMenuItem = new ToolStripMenuItem();
            _SelectAllPolysMenuItem.Click += new EventHandler(SelectAllPolysMenuItem_Click);
            _SelectAllObjectsMenuItem = new ToolStripMenuItem();
            _SelectAllObjectsMenuItem.Click += new EventHandler(SelectAllObjectsMenuItem_Click);
            _SelectAllExcludesMenuItem = new ToolStripMenuItem();
            _SelectAllExcludesMenuItem.Click += new EventHandler(SelectAllExcludesMenuItem_Click);
            ToolStripSeparator16 = new ToolStripSeparator();
            _InvertSelectionMenuItem = new ToolStripMenuItem();
            _InvertSelectionMenuItem.Click += new EventHandler(InvertSelectionMenuItem_Click);
            _SelectAllMenuItem = new ToolStripMenuItem();
            _SelectAllMenuItem.Click += new EventHandler(SelectAllMenuItem_Click);
            ToolsMenuItem = new ToolStripMenuItem();
            _PointerMenuItem = new ToolStripMenuItem();
            _PointerMenuItem.Click += new EventHandler(PointerMenuItem_Click);
            _ZoomMenuItem = new ToolStripMenuItem();
            _ZoomMenuItem.Click += new EventHandler(ZoomMenuItem_Click);
            ToolStripSeparator20 = new ToolStripSeparator();
            _LandMenuItem = new ToolStripMenuItem();
            _LandMenuItem.Click += new EventHandler(LandMenuItem_Click);
            _WaterMenuItem = new ToolStripMenuItem();
            _WaterMenuItem.Click += new EventHandler(WaterMenuItem_Click);
            _LineMenuItem = new ToolStripMenuItem();
            _LineMenuItem.Click += new EventHandler(LineMenuItem_Click);
            _PolyMenuItem = new ToolStripMenuItem();
            _PolyMenuItem.Click += new EventHandler(PolyMenuItem_Click);
            _ObjectMenuItem = new ToolStripMenuItem();
            _ObjectMenuItem.Click += new EventHandler(ObjectMenuItem_Click);
            _ExcludeMenuItem = new ToolStripMenuItem();
            _ExcludeMenuItem.Click += new EventHandler(ExcludeMenuItem_Click);
            HelpMenuItem = new ToolStripMenuItem();
            _SbuilderHelpMenuItem = new ToolStripMenuItem();
            _SbuilderHelpMenuItem.Click += new EventHandler(SbuilderHelpMenuItem_Click);
            _WhatIsNewMenuItem = new ToolStripMenuItem();
            _WhatIsNewMenuItem.Click += new EventHandler(WhatIsNewMenuItem_Click);
            _ForumMenuItem = new ToolStripMenuItem();
            _ForumMenuItem.Click += new EventHandler(ForumMenuItem_Click);
            _GetMapMenuItem = new ToolStripMenuItem();
            _GetMapMenuItem.Click += new EventHandler(GetMapMenuItem_Click);
            _AboutMenuItem = new ToolStripMenuItem();
            _AboutMenuItem.Click += new EventHandler(AboutMenuItem_Click);
            FlyAircraftToToolStripMenuItem = new ToolStripMenuItem();
            StatusZoom = new ToolStripStatusLabel();
            StatusLat = new ToolStripStatusLabel();
            StatusLon = new ToolStripStatusLabel();
            ToolStripStatusLabel1 = new ToolStripStatusLabel();
            StatusDir = new ToolStripStatusLabel();
            ToolStripStatusLabel2 = new ToolStripStatusLabel();
            StatusQMID = new ToolStripStatusLabel();
            StatusStrip = new StatusStrip();
            ToolStripStatusLabel3 = new ToolStripStatusLabel();
            StatusTile = new ToolStripStatusLabel();
            _Timer1 = new System.Timers.Timer();
            _Timer1.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);
            SaveFileDialog1 = new SaveFileDialog();
            OpenFileDialog1 = new OpenFileDialog();
            TextBoxMeasure = new TextBox();
            PopUpMenu = new ContextMenuStrip(components);
            NamePopUPMenu = new ToolStripMenuItem();
            Sep1PopUPMenu = new ToolStripSeparator();
            _CenterPopUPMenu = new ToolStripMenuItem();
            _CenterPopUPMenu.Click += new EventHandler(CenterPopUPMenu_Click);
            _FlyToPopUPMenu = new ToolStripMenuItem();
            _FlyToPopUPMenu.Click += new EventHandler(FlyToPopUPMenu_Click);
            _PointFromAircraftPopUpMenu = new ToolStripMenuItem();
            _PointFromAircraftPopUpMenu.Click += new EventHandler(PointFromAircraftPopUpMenu_Click);
            _ZoomInPopUPMenu = new ToolStripMenuItem();
            _ZoomInPopUPMenu.Click += new EventHandler(ZoomInPopUPMenu_Click);
            _ZoomOutPopUPMenu = new ToolStripMenuItem();
            _ZoomOutPopUPMenu.Click += new EventHandler(ZoomOutPopUPMenu_Click);
            _SaveBackGroundPopUpMenu = new ToolStripMenuItem();
            _SaveBackGroundPopUpMenu.Click += new EventHandler(SaveBackGroundPopUpMenu_Click);
            _TilePathToClipboardPopUpMenu = new ToolStripMenuItem();
            _TilePathToClipboardPopUpMenu.Click += new EventHandler(TilePathToClipboardPopUpMenu_Click);
            Sep2PopUPMenu = new ToolStripSeparator();
            _DeletePopUPMenu = new ToolStripMenuItem();
            _DeletePopUPMenu.Click += new EventHandler(DeletePopUPMenu_Click);
            _JoinAllPopUPMenu = new ToolStripMenuItem();
            _JoinAllPopUPMenu.Click += new EventHandler(JoinAllPopUPMenu_Click);
            _SetWidthPopUpMenu = new ToolStripMenuItem();
            _SetWidthPopUpMenu.Click += new EventHandler(SetWidthPopUpMenu_Click);
            _SetAltitudePopUpMenu = new ToolStripMenuItem();
            _SetAltitudePopUpMenu.Click += new EventHandler(SetAltitudePopUpMenu_Click);
            _SetTransparencyPopUpMenu = new ToolStripMenuItem();
            _SetTransparencyPopUpMenu.Click += new EventHandler(SetTransparencyPopUpMenu_Click);
            _MakeLinePopUPMenu = new ToolStripMenuItem();
            _MakeLinePopUPMenu.Click += new EventHandler(MakeLinePopUPMenu_Click);
            _SnapQMIDPopUPMenu = new ToolStripMenuItem();
            _SnapQMIDPopUPMenu.Click += new EventHandler(SnapQMIDPopUPMenu_Click);
            _FillQMIDPopUpMenu = new ToolStripMenuItem();
            _FillQMIDPopUpMenu.Click += new EventHandler(FillQMIDPopUpMenu_Click);
            _SliceQMIDPopUpMenu = new ToolStripMenuItem();
            _SliceQMIDPopUpMenu.Click += new EventHandler(SliceQMIDPopUpMenu_Click);
            _MakePolyPopUPMenu = new ToolStripMenuItem();
            _MakePolyPopUPMenu.Click += new EventHandler(MakePolyPopUPMenu_Click);
            _ConvertToPolyPopUpMenu = new ToolStripMenuItem();
            _ConvertToPolyPopUpMenu.Click += new EventHandler(ConvertToPolyPopUpMenu_Click);
            _SmoothPopUPMenu = new ToolStripMenuItem();
            _SmoothPopUPMenu.Click += new EventHandler(SmoothPopUPMenu_Click);
            _OuterPopUpMenu = new ToolStripMenuItem();
            _OuterPopUpMenu.Click += new EventHandler(OuterPopUpMenu_Click);
            _HolePopUpMenu = new ToolStripMenuItem();
            _HolePopUpMenu.Click += new EventHandler(HolePopUpMenu_Click);
            _SamplePopUPMenu = new ToolStripMenuItem();
            _SamplePopUPMenu.Click += new EventHandler(SamplePopUPMenu_Click);
            _ManualCheckPopUPMenu = new ToolStripMenuItem();
            _ManualCheckPopUPMenu.Click += new EventHandler(ManualCheckPopUPMenu_Click);
            _CalibratePopUPMenu = new ToolStripMenuItem();
            _CalibratePopUPMenu.Click += new EventHandler(CalibratePopUPMenu_Click);
            Sep3PopUPMenu = new ToolStripSeparator();
            _PropertiesPopUPMenu = new ToolStripMenuItem();
            _PropertiesPopUPMenu.Click += new EventHandler(PropertiesPopUPMenu_Click);
            FolderBrowserDialog1 = new FolderBrowserDialog();
            _Timer2 = new System.Timers.Timer();
            _Timer2.Elapsed += new System.Timers.ElapsedEventHandler(Timer2_Elapsed);
            lbTilesRemaining = new Label();
            _Timer3 = new System.Timers.Timer();
            _Timer3.Elapsed += new System.Timers.ElapsedEventHandler(Timer3_Elapsed);
            lbDonation = new Label();
            BottomToolStripPanel = new ToolStripPanel();
            TopToolStripPanel = new ToolStripPanel();
            ToolStrip = new ToolStrip();
            _NewToolStripButton = new ToolStripButton();
            _NewToolStripButton.Click += new EventHandler(NewToolStripButton_Click);
            _OpenToolStripButton = new ToolStripButton();
            _OpenToolStripButton.Click += new EventHandler(OpenToolStripButton_Click);
            _SaveToolStripButton = new ToolStripButton();
            _SaveToolStripButton.Click += new EventHandler(SaveToolStripButton_Click);
            toolStripSeparator6 = new ToolStripSeparator();
            _UndoToolStripButton = new ToolStripButton();
            _UndoToolStripButton.Click += new EventHandler(UndoToolStripButton_Click);
            _RedoToolStripButton = new ToolStripButton();
            _RedoToolStripButton.Click += new EventHandler(RedoToolStripButton_Click);
            toolStripSeparator7 = new ToolStripSeparator();
            _PointerToolStripButton = new ToolStripButton();
            _PointerToolStripButton.Click += new EventHandler(PointerToolStripButton_Click);
            _ZoomToolStripButton = new ToolStripButton();
            _ZoomToolStripButton.Click += new EventHandler(ZoomToolStripButton_Click);
            ToolStripSeparator22 = new ToolStripSeparator();
            _MeshToolStripButton = new ToolStripButton();
            _MeshToolStripButton.Click += new EventHandler(MeshToolStripButton_Click);
            _LandToolStripButton = new ToolStripButton();
            _LandToolStripButton.Click += new EventHandler(LandToolStripButton_Click);
            _WaterToolStripButton = new ToolStripButton();
            _WaterToolStripButton.Click += new EventHandler(WaterToolStripButton_Click);
            PhotoToolStripButton = new ToolStripButton();
            _LineToolStripButton = new ToolStripButton();
            _LineToolStripButton.Click += new EventHandler(LineToolStripButton_Click);
            _PolyToolStripButton = new ToolStripButton();
            _PolyToolStripButton.Click += new EventHandler(PolyToolStripButton_Click);
            _ObjectToolStripButton = new ToolStripButton();
            _ObjectToolStripButton.Click += new EventHandler(ObjectToolStripButton_Click);
            _ExcludeToolStripButton = new ToolStripButton();
            _ExcludeToolStripButton.Click += new EventHandler(ExcludeToolStripButton_Click);
            ToolStripSeparator23 = new ToolStripSeparator();
            _BGLToolStripButton = new ToolStripButton();
            _BGLToolStripButton.Click += new EventHandler(BGLToolStripButton_Click);
            RightToolStripPanel = new ToolStripPanel();
            LeftToolStripPanel = new ToolStripPanel();
            ContentPanel = new ToolStripContentPanel();
            lbScale = new Label();
            lbScaleBar = new Label();
            MenuStrip.SuspendLayout();
            StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Timer1).BeginInit();
            PopUpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_Timer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Timer3).BeginInit();
            ToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.AllowMerge = false;
            MenuStrip.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(234)), Conversions.ToInteger(Conversions.ToByte(234)), Conversions.ToInteger(Conversions.ToByte(234)));
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileMenuItem, _EditMenuItem, ViewMenuItem, SelectMenuItem, ToolsMenuItem, HelpMenuItem });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(692, 24);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "MenuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _NewMenuItem, _OpenMenuItem, toolStripSeparator, _SaveMenuItem, _SaveAsMenuItem, toolStripSeparator1, _BGLMenuItem, _PropertiesMenuItem, ToolStripSeparator8, _ImportSBXMenuItem, AppendMenuItem, ExportMenuItem, AddMapMenuItem, ToolStripSeparator9, DEMToolsMenuItem, CoordinatesToolMenuItem, toolStripSeparator2, _ExitMenuItem, RecentFileSeparatorMenuItem, _RecentFile1MenuItem, _RecentFile2MenuItem, _RecentFile3MenuItem, _RecentFile4MenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(37, 20);
            FileMenuItem.Text = "&File";
            // 
            // NewMenuItem
            // 
            _NewMenuItem.Image = (Image)resources.GetObject("NewMenuItem.Image");
            _NewMenuItem.ImageTransparentColor = Color.Magenta;
            _NewMenuItem.Name = "_NewMenuItem";
            _NewMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            _NewMenuItem.Size = new Size(198, 22);
            _NewMenuItem.Text = "&New Project";
            // 
            // OpenMenuItem
            // 
            _OpenMenuItem.Image = (Image)resources.GetObject("OpenMenuItem.Image");
            _OpenMenuItem.ImageTransparentColor = Color.Magenta;
            _OpenMenuItem.Name = "_OpenMenuItem";
            _OpenMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            _OpenMenuItem.Size = new Size(198, 22);
            _OpenMenuItem.Text = "&Open Project ...";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(195, 6);
            // 
            // SaveMenuItem
            // 
            _SaveMenuItem.Image = (Image)resources.GetObject("SaveMenuItem.Image");
            _SaveMenuItem.ImageTransparentColor = Color.Magenta;
            _SaveMenuItem.Name = "_SaveMenuItem";
            _SaveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            _SaveMenuItem.Size = new Size(198, 22);
            _SaveMenuItem.Text = "&Save Project";
            // 
            // SaveAsMenuItem
            // 
            _SaveAsMenuItem.Name = "_SaveAsMenuItem";
            _SaveAsMenuItem.Size = new Size(198, 22);
            _SaveAsMenuItem.Text = "Save Project &As ...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(195, 6);
            // 
            // BGLMenuItem
            // 
            _BGLMenuItem.Image = (Image)resources.GetObject("BGLMenuItem.Image");
            _BGLMenuItem.ImageTransparentColor = Color.Magenta;
            _BGLMenuItem.Name = "_BGLMenuItem";
            _BGLMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            _BGLMenuItem.Size = new Size(198, 22);
            _BGLMenuItem.Text = "&BGL Compile ...";
            // 
            // PropertiesMenuItem
            // 
            _PropertiesMenuItem.Image = (Image)resources.GetObject("PropertiesMenuItem.Image");
            _PropertiesMenuItem.ImageTransparentColor = Color.Magenta;
            _PropertiesMenuItem.Name = "_PropertiesMenuItem";
            _PropertiesMenuItem.Size = new Size(198, 22);
            _PropertiesMenuItem.Text = "&Properties";
            // 
            // ToolStripSeparator8
            // 
            ToolStripSeparator8.Name = "ToolStripSeparator8";
            ToolStripSeparator8.Size = new Size(195, 6);
            // 
            // ImportSBXMenuItem
            // 
            _ImportSBXMenuItem.Name = "_ImportSBXMenuItem";
            _ImportSBXMenuItem.Size = new Size(198, 22);
            _ImportSBXMenuItem.Text = "Import SBuilderX SBX ...";
            // 
            // AppendMenuItem
            // 
            AppendMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _AppendSBXMenuItem, _AppendBLNMenuItem, _AppendObjMenuItem, _AppendSHPMenuItem, _AppendRAWMenuItem, AppendVTPMenuItem });
            AppendMenuItem.Name = "AppendMenuItem";
            AppendMenuItem.Size = new Size(198, 22);
            AppendMenuItem.Text = "Append";
            // 
            // AppendSBXMenuItem
            // 
            _AppendSBXMenuItem.Name = "_AppendSBXMenuItem";
            _AppendSBXMenuItem.Size = new Size(174, 22);
            _AppendSBXMenuItem.Text = "SBuilderX SBX ...";
            // 
            // AppendBLNMenuItem
            // 
            _AppendBLNMenuItem.Name = "_AppendBLNMenuItem";
            _AppendBLNMenuItem.Size = new Size(174, 22);
            _AppendBLNMenuItem.Text = "Surfer BLN ...";
            // 
            // AppendObjMenuItem
            // 
            _AppendObjMenuItem.Image = My.Resources.Resources.XML;
            _AppendObjMenuItem.Name = "_AppendObjMenuItem";
            _AppendObjMenuItem.Size = new Size(174, 22);
            _AppendObjMenuItem.Text = "Object BGL/XML ...";
            // 
            // AppendSHPMenuItem
            // 
            _AppendSHPMenuItem.Name = "_AppendSHPMenuItem";
            _AppendSHPMenuItem.Size = new Size(174, 22);
            _AppendSHPMenuItem.Text = "ESRI SHP ...";
            // 
            // AppendRAWMenuItem
            // 
            _AppendRAWMenuItem.Name = "_AppendRAWMenuItem";
            _AppendRAWMenuItem.Size = new Size(174, 22);
            _AppendRAWMenuItem.Text = "Class RAW ...";
            // 
            // AppendVTPMenuItem
            // 
            AppendVTPMenuItem.Name = "AppendVTPMenuItem";
            AppendVTPMenuItem.Size = new Size(174, 22);
            AppendVTPMenuItem.Text = "FS9 VTP BGL ...";
            AppendVTPMenuItem.Visible = false;
            // 
            // ExportMenuItem
            // 
            ExportMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _ExportSBXMenuItem, _ExportBLNMenuItem, _ExportSHPMenuItem, _ExportKMLMenuItem });
            ExportMenuItem.Name = "ExportMenuItem";
            ExportMenuItem.Size = new Size(198, 22);
            ExportMenuItem.Text = "Export";
            // 
            // ExportSBXMenuItem
            // 
            _ExportSBXMenuItem.Name = "_ExportSBXMenuItem";
            _ExportSBXMenuItem.Size = new Size(159, 22);
            _ExportSBXMenuItem.Text = "SBuilderX SBX ...";
            // 
            // ExportBLNMenuItem
            // 
            _ExportBLNMenuItem.Name = "_ExportBLNMenuItem";
            _ExportBLNMenuItem.Size = new Size(159, 22);
            _ExportBLNMenuItem.Text = "Surfer BLN ...";
            // 
            // ExportSHPMenuItem
            // 
            _ExportSHPMenuItem.Enabled = false;
            _ExportSHPMenuItem.Name = "_ExportSHPMenuItem";
            _ExportSHPMenuItem.Size = new Size(159, 22);
            _ExportSHPMenuItem.Text = "Esri SHP ...";
            // 
            // ExportKMLMenuItem
            // 
            _ExportKMLMenuItem.Name = "_ExportKMLMenuItem";
            _ExportKMLMenuItem.Size = new Size(159, 22);
            _ExportKMLMenuItem.Text = "Google KML ...";
            _ExportKMLMenuItem.Visible = false;
            // 
            // AddMapMenuItem
            // 
            AddMapMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _FromDiskMenuItem, _FromBackgroundMapMenuItem, _FromGoogleMapsToolStripMenuItem, _FromArcGisToolStripMenuItem });
            AddMapMenuItem.Image = (Image)resources.GetObject("AddMapMenuItem.Image");
            AddMapMenuItem.Name = "AddMapMenuItem";
            AddMapMenuItem.Size = new Size(198, 22);
            AddMapMenuItem.Text = "Add Map";
            // 
            // FromDiskMenuItem
            // 
            _FromDiskMenuItem.Name = "_FromDiskMenuItem";
            _FromDiskMenuItem.Size = new Size(187, 22);
            _FromDiskMenuItem.Text = "From disk ...";
            // 
            // FromBackgroundMapMenuItem
            // 
            _FromBackgroundMapMenuItem.Enabled = false;
            _FromBackgroundMapMenuItem.Name = "_FromBackgroundMapMenuItem";
            _FromBackgroundMapMenuItem.Size = new Size(187, 22);
            _FromBackgroundMapMenuItem.Text = "From background ...";
            // 
            // FromGoogleMapsToolStripMenuItem
            // 
            _FromGoogleMapsToolStripMenuItem.Name = "_FromGoogleMapsToolStripMenuItem";
            _FromGoogleMapsToolStripMenuItem.Size = new Size(187, 22);
            _FromGoogleMapsToolStripMenuItem.Text = "From Google Maps ...";
            // 
            // FromArcGisToolStripMenuItem
            // 
            _FromArcGisToolStripMenuItem.Name = "_FromArcGisToolStripMenuItem";
            _FromArcGisToolStripMenuItem.Size = new Size(187, 22);
            _FromArcGisToolStripMenuItem.Text = "From ArcGis ...";
            // 
            // ToolStripSeparator9
            // 
            ToolStripSeparator9.Name = "ToolStripSeparator9";
            ToolStripSeparator9.Size = new Size(195, 6);
            // 
            // DEMToolsMenuItem
            // 
            DEMToolsMenuItem.Enabled = false;
            DEMToolsMenuItem.Name = "DEMToolsMenuItem";
            DEMToolsMenuItem.Size = new Size(198, 22);
            DEMToolsMenuItem.Text = "DEM Tools ...";
            DEMToolsMenuItem.Visible = false;
            // 
            // CoordinatesToolMenuItem
            // 
            CoordinatesToolMenuItem.Enabled = false;
            CoordinatesToolMenuItem.Name = "CoordinatesToolMenuItem";
            CoordinatesToolMenuItem.Size = new Size(198, 22);
            CoordinatesToolMenuItem.Text = "Coordinates Tool ...";
            CoordinatesToolMenuItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(195, 6);
            toolStripSeparator2.Visible = false;
            // 
            // ExitMenuItem
            // 
            _ExitMenuItem.Name = "_ExitMenuItem";
            _ExitMenuItem.Size = new Size(198, 22);
            _ExitMenuItem.Text = "E&xit";
            // 
            // RecentFileSeparatorMenuItem
            // 
            RecentFileSeparatorMenuItem.Name = "RecentFileSeparatorMenuItem";
            RecentFileSeparatorMenuItem.Size = new Size(195, 6);
            RecentFileSeparatorMenuItem.Visible = false;
            // 
            // RecentFile1MenuItem
            // 
            _RecentFile1MenuItem.Name = "_RecentFile1MenuItem";
            _RecentFile1MenuItem.Size = new Size(198, 22);
            _RecentFile1MenuItem.Text = "f1";
            _RecentFile1MenuItem.Visible = false;
            // 
            // RecentFile2MenuItem
            // 
            _RecentFile2MenuItem.Name = "_RecentFile2MenuItem";
            _RecentFile2MenuItem.Size = new Size(198, 22);
            _RecentFile2MenuItem.Text = "f2";
            _RecentFile2MenuItem.Visible = false;
            // 
            // RecentFile3MenuItem
            // 
            _RecentFile3MenuItem.Name = "_RecentFile3MenuItem";
            _RecentFile3MenuItem.Size = new Size(198, 22);
            _RecentFile3MenuItem.Text = "f3";
            _RecentFile3MenuItem.Visible = false;
            // 
            // RecentFile4MenuItem
            // 
            _RecentFile4MenuItem.Name = "_RecentFile4MenuItem";
            _RecentFile4MenuItem.Size = new Size(198, 22);
            _RecentFile4MenuItem.Text = "f4";
            _RecentFile4MenuItem.Visible = false;
            // 
            // EditMenuItem
            // 
            _EditMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _EnableUndoRedoMenuItem, _UndoMenuItem, _RedoMenuItem, toolStripSeparator3, _SnapToQMIDMenuItem, _MeasureToolMenuItem, _ObjLibManagerMenuItem, ToolStripSeparator10, _CopyMenuItem, _PasteMenuItem, _DeleteMenuItem, toolStripSeparator4, _FindMenuItem, ToolStripSeparator11, _TileServerMenuItem, _FSXSettingsMenuItem, _ObjectFoldersMenuItem, _EditINIFileMenuItem });
            _EditMenuItem.Name = "_EditMenuItem";
            _EditMenuItem.Size = new Size(39, 20);
            _EditMenuItem.Text = "&Edit";
            // 
            // EnableUndoRedoMenuItem
            // 
            _EnableUndoRedoMenuItem.Checked = true;
            _EnableUndoRedoMenuItem.CheckState = CheckState.Checked;
            _EnableUndoRedoMenuItem.Name = "_EnableUndoRedoMenuItem";
            _EnableUndoRedoMenuItem.Size = new Size(190, 22);
            _EnableUndoRedoMenuItem.Text = "Enable Undo Redo";
            // 
            // UndoMenuItem
            // 
            _UndoMenuItem.Image = (Image)resources.GetObject("UndoMenuItem.Image");
            _UndoMenuItem.ImageTransparentColor = Color.Fuchsia;
            _UndoMenuItem.Name = "_UndoMenuItem";
            _UndoMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            _UndoMenuItem.Size = new Size(190, 22);
            _UndoMenuItem.Text = "&Undo";
            // 
            // RedoMenuItem
            // 
            _RedoMenuItem.Image = (Image)resources.GetObject("RedoMenuItem.Image");
            _RedoMenuItem.ImageTransparentColor = Color.Fuchsia;
            _RedoMenuItem.Name = "_RedoMenuItem";
            _RedoMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            _RedoMenuItem.Size = new Size(190, 22);
            _RedoMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(187, 6);
            // 
            // SnapToQMIDMenuItem
            // 
            _SnapToQMIDMenuItem.Image = My.Resources.Resources.AlignToGridHS;
            _SnapToQMIDMenuItem.Name = "_SnapToQMIDMenuItem";
            _SnapToQMIDMenuItem.Size = new Size(190, 22);
            _SnapToQMIDMenuItem.Text = "Snap to QMID ...";
            // 
            // MeasureToolMenuItem
            // 
            _MeasureToolMenuItem.Image = My.Resources.Resources.measure;
            _MeasureToolMenuItem.Name = "_MeasureToolMenuItem";
            _MeasureToolMenuItem.Size = new Size(190, 22);
            _MeasureToolMenuItem.Text = "Measure Tool";
            // 
            // ObjLibManagerMenuItem
            // 
            _ObjLibManagerMenuItem.Name = "_ObjLibManagerMenuItem";
            _ObjLibManagerMenuItem.Size = new Size(190, 22);
            _ObjLibManagerMenuItem.Text = "Object Lib Manager ...";
            // 
            // ToolStripSeparator10
            // 
            ToolStripSeparator10.Name = "ToolStripSeparator10";
            ToolStripSeparator10.Size = new Size(187, 6);
            // 
            // CopyMenuItem
            // 
            _CopyMenuItem.Image = (Image)resources.GetObject("CopyMenuItem.Image");
            _CopyMenuItem.ImageTransparentColor = Color.Magenta;
            _CopyMenuItem.Name = "_CopyMenuItem";
            _CopyMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            _CopyMenuItem.Size = new Size(190, 22);
            _CopyMenuItem.Text = "&Copy";
            // 
            // PasteMenuItem
            // 
            _PasteMenuItem.ImageTransparentColor = Color.Magenta;
            _PasteMenuItem.Name = "_PasteMenuItem";
            _PasteMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            _PasteMenuItem.Size = new Size(190, 22);
            _PasteMenuItem.Text = "&Place";
            // 
            // DeleteMenuItem
            // 
            _DeleteMenuItem.Image = (Image)resources.GetObject("DeleteMenuItem.Image");
            _DeleteMenuItem.ImageTransparentColor = Color.Fuchsia;
            _DeleteMenuItem.Name = "_DeleteMenuItem";
            _DeleteMenuItem.ShortcutKeys = Keys.Delete;
            _DeleteMenuItem.Size = new Size(190, 22);
            _DeleteMenuItem.Text = "Delete";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(187, 6);
            // 
            // FindMenuItem
            // 
            _FindMenuItem.Image = (Image)resources.GetObject("FindMenuItem.Image");
            _FindMenuItem.ImageTransparentColor = Color.Fuchsia;
            _FindMenuItem.Name = "_FindMenuItem";
            _FindMenuItem.Size = new Size(190, 22);
            _FindMenuItem.Text = "Find ...";
            // 
            // ToolStripSeparator11
            // 
            ToolStripSeparator11.Name = "ToolStripSeparator11";
            ToolStripSeparator11.Size = new Size(187, 6);
            // 
            // TileServerMenuItem
            // 
            _TileServerMenuItem.Name = "_TileServerMenuItem";
            _TileServerMenuItem.Size = new Size(190, 22);
            _TileServerMenuItem.Text = "Tile Servers ...";
            // 
            // FSXSettingsMenuItem
            // 
            _FSXSettingsMenuItem.Name = "_FSXSettingsMenuItem";
            _FSXSettingsMenuItem.Size = new Size(190, 22);
            _FSXSettingsMenuItem.Text = "FSX Settings ...";
            // 
            // ObjectFoldersMenuItem
            // 
            _ObjectFoldersMenuItem.Image = My.Resources.Resources.objects;
            _ObjectFoldersMenuItem.Name = "_ObjectFoldersMenuItem";
            _ObjectFoldersMenuItem.Size = new Size(190, 22);
            _ObjectFoldersMenuItem.Text = "Object Folders ...";
            // 
            // EditINIFileMenuItem
            // 
            _EditINIFileMenuItem.Image = My.Resources.Resources.waters2;
            _EditINIFileMenuItem.Name = "_EditINIFileMenuItem";
            _EditINIFileMenuItem.Size = new Size(190, 22);
            _EditINIFileMenuItem.Text = "Edit INI file ...";
            // 
            // ViewMenuItem
            // 
            ViewMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _ShowToolbarMenuItem, ToolStripSeparator12, _ShowBackgroundMenuItem, LODGridMenuItem, QMIDGridMenuItem, ToolStripSeparator14, _GoToPositionMenuItem, _ShowAircraftMenuItem, _FlyAircraftToMenuItem, ToolStripSeparator13, ViewMapsMenuItem, ToolStripSeparator15, _ViewAllMapsMenuItem, _ViewAllLandsMenuItem, _ViewAllWatersMenuItem, _ViewAllLinesMenuItem, _ViewAllPolysMenuItem, _ViewAllObjectsMenuItem, _ViewAllExcludesMenuItem, ToolStripSeparator17, _ViewAllMenuItem });
            ViewMenuItem.Name = "ViewMenuItem";
            ViewMenuItem.Size = new Size(44, 20);
            ViewMenuItem.Text = "&View";
            // 
            // ShowToolbarMenuItem
            // 
            _ShowToolbarMenuItem.Checked = true;
            _ShowToolbarMenuItem.CheckState = CheckState.Checked;
            _ShowToolbarMenuItem.Name = "_ShowToolbarMenuItem";
            _ShowToolbarMenuItem.Size = new Size(189, 22);
            _ShowToolbarMenuItem.Text = "Show Toolbar";
            // 
            // ToolStripSeparator12
            // 
            ToolStripSeparator12.Name = "ToolStripSeparator12";
            ToolStripSeparator12.Size = new Size(186, 6);
            // 
            // ShowBackgroundMenuItem
            // 
            _ShowBackgroundMenuItem.Enabled = false;
            _ShowBackgroundMenuItem.Name = "_ShowBackgroundMenuItem";
            _ShowBackgroundMenuItem.ShortcutKeys = Keys.F1;
            _ShowBackgroundMenuItem.Size = new Size(189, 22);
            _ShowBackgroundMenuItem.Text = "Show Background";
            // 
            // LODGridMenuItem
            // 
            LODGridMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _NoLODMenuItem, _LOD0MenuItem, _LOD1MenuItem, _LOD2MenuItem, _LOD3MenuItem, _LOD4MenuItem, _LOD5MenuItem, _LOD6MenuItem, _LOD7MenuItem, _LOD8MenuItem, _LOD9MenuItem, _LOD10MenuItem, _LOD11MenuItem, _LOD12MenuItem, _LOD13MenuItem, _LOD14MenuItem, _LOD15MenuItem, _LOD16MenuItem, _LOD17MenuItem, _LOD18MenuItem, _LOD19MenuItem, _LOD20MenuItem, _LOD21MenuItem, _LOD22MenuItem, _LOD23MenuItem, _LOD24MenuItem, _LOD25MenuItem, _LOD26MenuItem, _LOD27MenuItem });
            LODGridMenuItem.Image = My.Resources.Resources.Red_grid;
            LODGridMenuItem.Name = "LODGridMenuItem";
            LODGridMenuItem.Size = new Size(189, 22);
            LODGridMenuItem.Text = "LOD Grid";
            // 
            // NoLODMenuItem
            // 
            _NoLODMenuItem.Name = "_NoLODMenuItem";
            _NoLODMenuItem.Size = new Size(115, 22);
            _NoLODMenuItem.Text = "No Grid";
            // 
            // LOD0MenuItem
            // 
            _LOD0MenuItem.Name = "_LOD0MenuItem";
            _LOD0MenuItem.Size = new Size(115, 22);
            _LOD0MenuItem.Text = "LOD 0";
            // 
            // LOD1MenuItem
            // 
            _LOD1MenuItem.Name = "_LOD1MenuItem";
            _LOD1MenuItem.Size = new Size(115, 22);
            _LOD1MenuItem.Text = "LOD 1";
            // 
            // LOD2MenuItem
            // 
            _LOD2MenuItem.Name = "_LOD2MenuItem";
            _LOD2MenuItem.Size = new Size(115, 22);
            _LOD2MenuItem.Text = "LOD 2";
            // 
            // LOD3MenuItem
            // 
            _LOD3MenuItem.Name = "_LOD3MenuItem";
            _LOD3MenuItem.Size = new Size(115, 22);
            _LOD3MenuItem.Text = "LOD 3";
            // 
            // LOD4MenuItem
            // 
            _LOD4MenuItem.Name = "_LOD4MenuItem";
            _LOD4MenuItem.Size = new Size(115, 22);
            _LOD4MenuItem.Text = "LOD 4";
            // 
            // LOD5MenuItem
            // 
            _LOD5MenuItem.Name = "_LOD5MenuItem";
            _LOD5MenuItem.Size = new Size(115, 22);
            _LOD5MenuItem.Text = "LOD 5";
            // 
            // LOD6MenuItem
            // 
            _LOD6MenuItem.Name = "_LOD6MenuItem";
            _LOD6MenuItem.Size = new Size(115, 22);
            _LOD6MenuItem.Text = "LOD 6";
            // 
            // LOD7MenuItem
            // 
            _LOD7MenuItem.Name = "_LOD7MenuItem";
            _LOD7MenuItem.Size = new Size(115, 22);
            _LOD7MenuItem.Text = "LOD 7";
            // 
            // LOD8MenuItem
            // 
            _LOD8MenuItem.Name = "_LOD8MenuItem";
            _LOD8MenuItem.Size = new Size(115, 22);
            _LOD8MenuItem.Text = "LOD 8";
            // 
            // LOD9MenuItem
            // 
            _LOD9MenuItem.Name = "_LOD9MenuItem";
            _LOD9MenuItem.Size = new Size(115, 22);
            _LOD9MenuItem.Text = "LOD 9";
            // 
            // LOD10MenuItem
            // 
            _LOD10MenuItem.Name = "_LOD10MenuItem";
            _LOD10MenuItem.Size = new Size(115, 22);
            _LOD10MenuItem.Text = "LOD 10";
            // 
            // LOD11MenuItem
            // 
            _LOD11MenuItem.Name = "_LOD11MenuItem";
            _LOD11MenuItem.Size = new Size(115, 22);
            _LOD11MenuItem.Text = "LOD 11";
            // 
            // LOD12MenuItem
            // 
            _LOD12MenuItem.Name = "_LOD12MenuItem";
            _LOD12MenuItem.Size = new Size(115, 22);
            _LOD12MenuItem.Text = "LOD 12";
            // 
            // LOD13MenuItem
            // 
            _LOD13MenuItem.Name = "_LOD13MenuItem";
            _LOD13MenuItem.Size = new Size(115, 22);
            _LOD13MenuItem.Text = "LOD 13";
            // 
            // LOD14MenuItem
            // 
            _LOD14MenuItem.Name = "_LOD14MenuItem";
            _LOD14MenuItem.Size = new Size(115, 22);
            _LOD14MenuItem.Text = "LOD 14";
            // 
            // LOD15MenuItem
            // 
            _LOD15MenuItem.Name = "_LOD15MenuItem";
            _LOD15MenuItem.Size = new Size(115, 22);
            _LOD15MenuItem.Text = "LOD 15";
            // 
            // LOD16MenuItem
            // 
            _LOD16MenuItem.Name = "_LOD16MenuItem";
            _LOD16MenuItem.Size = new Size(115, 22);
            _LOD16MenuItem.Text = "LOD 16";
            // 
            // LOD17MenuItem
            // 
            _LOD17MenuItem.Name = "_LOD17MenuItem";
            _LOD17MenuItem.Size = new Size(115, 22);
            _LOD17MenuItem.Text = "LOD 17";
            // 
            // LOD18MenuItem
            // 
            _LOD18MenuItem.Name = "_LOD18MenuItem";
            _LOD18MenuItem.Size = new Size(115, 22);
            _LOD18MenuItem.Text = "LOD 18";
            // 
            // LOD19MenuItem
            // 
            _LOD19MenuItem.Name = "_LOD19MenuItem";
            _LOD19MenuItem.Size = new Size(115, 22);
            _LOD19MenuItem.Text = "LOD 19";
            // 
            // LOD20MenuItem
            // 
            _LOD20MenuItem.Name = "_LOD20MenuItem";
            _LOD20MenuItem.Size = new Size(115, 22);
            _LOD20MenuItem.Text = "LOD 20";
            // 
            // LOD21MenuItem
            // 
            _LOD21MenuItem.Name = "_LOD21MenuItem";
            _LOD21MenuItem.Size = new Size(115, 22);
            _LOD21MenuItem.Text = "LOD21";
            // 
            // LOD22MenuItem
            // 
            _LOD22MenuItem.Name = "_LOD22MenuItem";
            _LOD22MenuItem.Size = new Size(115, 22);
            _LOD22MenuItem.Text = "LOD 22";
            // 
            // LOD23MenuItem
            // 
            _LOD23MenuItem.Name = "_LOD23MenuItem";
            _LOD23MenuItem.Size = new Size(115, 22);
            _LOD23MenuItem.Text = "LOD 23";
            // 
            // LOD24MenuItem
            // 
            _LOD24MenuItem.Name = "_LOD24MenuItem";
            _LOD24MenuItem.Size = new Size(115, 22);
            _LOD24MenuItem.Text = "LOD 24";
            // 
            // LOD25MenuItem
            // 
            _LOD25MenuItem.Name = "_LOD25MenuItem";
            _LOD25MenuItem.Size = new Size(115, 22);
            _LOD25MenuItem.Text = "LOD 25";
            // 
            // LOD26MenuItem
            // 
            _LOD26MenuItem.Name = "_LOD26MenuItem";
            _LOD26MenuItem.Size = new Size(115, 22);
            _LOD26MenuItem.Text = "LOD 26";
            // 
            // LOD27MenuItem
            // 
            _LOD27MenuItem.Name = "_LOD27MenuItem";
            _LOD27MenuItem.Size = new Size(115, 22);
            _LOD27MenuItem.Text = "LOD 27";
            // 
            // QMIDGridMenuItem
            // 
            QMIDGridMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _NoGridMenuItem, _Level2MenuItem, _Level3MenuItem, _Level4MenuItem, _Level5MenuItem, _Level6MenuItem, _Level7MenuItem, _Level8MenuItem, _Level9MenuItem, _Level10MenuItem, _Level11MenuItem, _Level12MenuItem, _Level13MenuItem, _Level14MenuItem, _Level15MenuItem, _Level16MenuItem, _Level17MenuItem, _Level18MenuItem, _Level19MenuItem, _Level20MenuItem, _Level21MenuItem, _Level22MenuItem, _Level23MenuItem, _Level24MenuItem, _Level25MenuItem, _Level26MenuItem, _Level27MenuItem, _Level28MenuItem, _Level29MenuItem });
            QMIDGridMenuItem.Image = (Image)resources.GetObject("QMIDGridMenuItem.Image");
            QMIDGridMenuItem.ImageTransparentColor = Color.Fuchsia;
            QMIDGridMenuItem.Name = "QMIDGridMenuItem";
            QMIDGridMenuItem.Size = new Size(189, 22);
            QMIDGridMenuItem.Text = "QMID Grid";
            // 
            // NoGridMenuItem
            // 
            _NoGridMenuItem.Checked = true;
            _NoGridMenuItem.CheckState = CheckState.Checked;
            _NoGridMenuItem.Name = "_NoGridMenuItem";
            _NoGridMenuItem.Size = new Size(116, 22);
            _NoGridMenuItem.Text = "No Grid";
            // 
            // Level2MenuItem
            // 
            _Level2MenuItem.Name = "_Level2MenuItem";
            _Level2MenuItem.Size = new Size(116, 22);
            _Level2MenuItem.Text = "Level 2";
            // 
            // Level3MenuItem
            // 
            _Level3MenuItem.Name = "_Level3MenuItem";
            _Level3MenuItem.Size = new Size(116, 22);
            _Level3MenuItem.Text = "Level 3";
            // 
            // Level4MenuItem
            // 
            _Level4MenuItem.Name = "_Level4MenuItem";
            _Level4MenuItem.Size = new Size(116, 22);
            _Level4MenuItem.Text = "Level 4";
            // 
            // Level5MenuItem
            // 
            _Level5MenuItem.Name = "_Level5MenuItem";
            _Level5MenuItem.Size = new Size(116, 22);
            _Level5MenuItem.Text = "Level 5";
            // 
            // Level6MenuItem
            // 
            _Level6MenuItem.Name = "_Level6MenuItem";
            _Level6MenuItem.Size = new Size(116, 22);
            _Level6MenuItem.Text = "Level 6";
            // 
            // Level7MenuItem
            // 
            _Level7MenuItem.Name = "_Level7MenuItem";
            _Level7MenuItem.Size = new Size(116, 22);
            _Level7MenuItem.Text = "Level 7";
            // 
            // Level8MenuItem
            // 
            _Level8MenuItem.Name = "_Level8MenuItem";
            _Level8MenuItem.Size = new Size(116, 22);
            _Level8MenuItem.Text = "Level 8";
            // 
            // Level9MenuItem
            // 
            _Level9MenuItem.Name = "_Level9MenuItem";
            _Level9MenuItem.Size = new Size(116, 22);
            _Level9MenuItem.Text = "Level 9";
            // 
            // Level10MenuItem
            // 
            _Level10MenuItem.Name = "_Level10MenuItem";
            _Level10MenuItem.Size = new Size(116, 22);
            _Level10MenuItem.Text = "Level 10";
            // 
            // Level11MenuItem
            // 
            _Level11MenuItem.Name = "_Level11MenuItem";
            _Level11MenuItem.Size = new Size(116, 22);
            _Level11MenuItem.Text = "Level 11";
            // 
            // Level12MenuItem
            // 
            _Level12MenuItem.Name = "_Level12MenuItem";
            _Level12MenuItem.Size = new Size(116, 22);
            _Level12MenuItem.Text = "Level 12";
            // 
            // Level13MenuItem
            // 
            _Level13MenuItem.Name = "_Level13MenuItem";
            _Level13MenuItem.Size = new Size(116, 22);
            _Level13MenuItem.Text = "Level 13";
            // 
            // Level14MenuItem
            // 
            _Level14MenuItem.Name = "_Level14MenuItem";
            _Level14MenuItem.Size = new Size(116, 22);
            _Level14MenuItem.Text = "Level 14";
            // 
            // Level15MenuItem
            // 
            _Level15MenuItem.Name = "_Level15MenuItem";
            _Level15MenuItem.Size = new Size(116, 22);
            _Level15MenuItem.Text = "Level 15";
            // 
            // Level16MenuItem
            // 
            _Level16MenuItem.Name = "_Level16MenuItem";
            _Level16MenuItem.Size = new Size(116, 22);
            _Level16MenuItem.Text = "Level 16";
            // 
            // Level17MenuItem
            // 
            _Level17MenuItem.Name = "_Level17MenuItem";
            _Level17MenuItem.Size = new Size(116, 22);
            _Level17MenuItem.Text = "Level 17";
            // 
            // Level18MenuItem
            // 
            _Level18MenuItem.Name = "_Level18MenuItem";
            _Level18MenuItem.Size = new Size(116, 22);
            _Level18MenuItem.Text = "Level 18";
            // 
            // Level19MenuItem
            // 
            _Level19MenuItem.Name = "_Level19MenuItem";
            _Level19MenuItem.Size = new Size(116, 22);
            _Level19MenuItem.Text = "Level 19";
            // 
            // Level20MenuItem
            // 
            _Level20MenuItem.Name = "_Level20MenuItem";
            _Level20MenuItem.Size = new Size(116, 22);
            _Level20MenuItem.Text = "Level 20";
            // 
            // Level21MenuItem
            // 
            _Level21MenuItem.Name = "_Level21MenuItem";
            _Level21MenuItem.Size = new Size(116, 22);
            _Level21MenuItem.Text = "Level 21";
            // 
            // Level22MenuItem
            // 
            _Level22MenuItem.Name = "_Level22MenuItem";
            _Level22MenuItem.Size = new Size(116, 22);
            _Level22MenuItem.Text = "Level 22";
            // 
            // Level23MenuItem
            // 
            _Level23MenuItem.Name = "_Level23MenuItem";
            _Level23MenuItem.Size = new Size(116, 22);
            _Level23MenuItem.Text = "Level 23";
            // 
            // Level24MenuItem
            // 
            _Level24MenuItem.Name = "_Level24MenuItem";
            _Level24MenuItem.Size = new Size(116, 22);
            _Level24MenuItem.Text = "Level 24";
            // 
            // Level25MenuItem
            // 
            _Level25MenuItem.Name = "_Level25MenuItem";
            _Level25MenuItem.Size = new Size(116, 22);
            _Level25MenuItem.Text = "Level 25";
            // 
            // Level26MenuItem
            // 
            _Level26MenuItem.Name = "_Level26MenuItem";
            _Level26MenuItem.Size = new Size(116, 22);
            _Level26MenuItem.Text = "Level 26";
            // 
            // Level27MenuItem
            // 
            _Level27MenuItem.Name = "_Level27MenuItem";
            _Level27MenuItem.Size = new Size(116, 22);
            _Level27MenuItem.Text = "Level 27";
            // 
            // Level28MenuItem
            // 
            _Level28MenuItem.Name = "_Level28MenuItem";
            _Level28MenuItem.Size = new Size(116, 22);
            _Level28MenuItem.Text = "Level 28";
            // 
            // Level29MenuItem
            // 
            _Level29MenuItem.Name = "_Level29MenuItem";
            _Level29MenuItem.Size = new Size(116, 22);
            _Level29MenuItem.Text = "Level 29";
            // 
            // ToolStripSeparator14
            // 
            ToolStripSeparator14.Name = "ToolStripSeparator14";
            ToolStripSeparator14.Size = new Size(186, 6);
            // 
            // GoToPositionMenuItem
            // 
            _GoToPositionMenuItem.Name = "_GoToPositionMenuItem";
            _GoToPositionMenuItem.Size = new Size(189, 22);
            _GoToPositionMenuItem.Text = "Go to Position ...";
            // 
            // ShowAircraftMenuItem
            // 
            _ShowAircraftMenuItem.Image = (Image)resources.GetObject("ShowAircraftMenuItem.Image");
            _ShowAircraftMenuItem.Name = "_ShowAircraftMenuItem";
            _ShowAircraftMenuItem.Size = new Size(189, 22);
            _ShowAircraftMenuItem.Text = "Show Aircraft";
            // 
            // FlyAircraftToMenuItem
            // 
            _FlyAircraftToMenuItem.Name = "_FlyAircraftToMenuItem";
            _FlyAircraftToMenuItem.Size = new Size(189, 22);
            _FlyAircraftToMenuItem.Text = "Fly Aircraft to ...";
            // 
            // ToolStripSeparator13
            // 
            ToolStripSeparator13.Name = "ToolStripSeparator13";
            ToolStripSeparator13.Size = new Size(186, 6);
            // 
            // ViewMapsMenuItem
            // 
            ViewMapsMenuItem.AccessibleRole = AccessibleRole.None;
            ViewMapsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _SummerMapMenuItem, _SpringMapMenuItem, _FallMapMenuItem, _WinterMapMenuItem, _HardWinterMapMenuItem, _NightMapMenuItem });
            ViewMapsMenuItem.Image = My.Resources.Resources.maps;
            ViewMapsMenuItem.Name = "ViewMapsMenuItem";
            ViewMapsMenuItem.Size = new Size(189, 22);
            ViewMapsMenuItem.Text = "Maps";
            // 
            // SummerMapMenuItem
            // 
            _SummerMapMenuItem.Name = "_SummerMapMenuItem";
            _SummerMapMenuItem.Size = new Size(138, 22);
            _SummerMapMenuItem.Text = "Summer";
            // 
            // SpringMapMenuItem
            // 
            _SpringMapMenuItem.Name = "_SpringMapMenuItem";
            _SpringMapMenuItem.Size = new Size(138, 22);
            _SpringMapMenuItem.Text = "Spring";
            // 
            // FallMapMenuItem
            // 
            _FallMapMenuItem.Name = "_FallMapMenuItem";
            _FallMapMenuItem.Size = new Size(138, 22);
            _FallMapMenuItem.Text = "Fall";
            // 
            // WinterMapMenuItem
            // 
            _WinterMapMenuItem.Name = "_WinterMapMenuItem";
            _WinterMapMenuItem.Size = new Size(138, 22);
            _WinterMapMenuItem.Text = "Winter";
            // 
            // HardWinterMapMenuItem
            // 
            _HardWinterMapMenuItem.Name = "_HardWinterMapMenuItem";
            _HardWinterMapMenuItem.Size = new Size(138, 22);
            _HardWinterMapMenuItem.Text = "Hard Winter";
            // 
            // NightMapMenuItem
            // 
            _NightMapMenuItem.Name = "_NightMapMenuItem";
            _NightMapMenuItem.Size = new Size(138, 22);
            _NightMapMenuItem.Text = "Night";
            // 
            // ToolStripSeparator15
            // 
            ToolStripSeparator15.Name = "ToolStripSeparator15";
            ToolStripSeparator15.Size = new Size(186, 6);
            // 
            // ViewAllMapsMenuItem
            // 
            _ViewAllMapsMenuItem.Image = My.Resources.Resources.insertmap;
            _ViewAllMapsMenuItem.Name = "_ViewAllMapsMenuItem";
            _ViewAllMapsMenuItem.Size = new Size(189, 22);
            _ViewAllMapsMenuItem.Text = "All Maps";
            // 
            // ViewAllLandsMenuItem
            // 
            _ViewAllLandsMenuItem.Image = My.Resources.Resources.lands;
            _ViewAllLandsMenuItem.Name = "_ViewAllLandsMenuItem";
            _ViewAllLandsMenuItem.Size = new Size(189, 22);
            _ViewAllLandsMenuItem.Text = "All Land Tiles";
            // 
            // ViewAllWatersMenuItem
            // 
            _ViewAllWatersMenuItem.Image = My.Resources.Resources.waters;
            _ViewAllWatersMenuItem.Name = "_ViewAllWatersMenuItem";
            _ViewAllWatersMenuItem.Size = new Size(189, 22);
            _ViewAllWatersMenuItem.Text = "All Water Tiles";
            // 
            // ViewAllLinesMenuItem
            // 
            _ViewAllLinesMenuItem.Image = My.Resources.Resources.lines4;
            _ViewAllLinesMenuItem.Name = "_ViewAllLinesMenuItem";
            _ViewAllLinesMenuItem.Size = new Size(189, 22);
            _ViewAllLinesMenuItem.Text = "All Lines";
            // 
            // ViewAllPolysMenuItem
            // 
            _ViewAllPolysMenuItem.Image = My.Resources.Resources.polys;
            _ViewAllPolysMenuItem.Name = "_ViewAllPolysMenuItem";
            _ViewAllPolysMenuItem.Size = new Size(189, 22);
            _ViewAllPolysMenuItem.Text = "All Polygons";
            // 
            // ViewAllObjectsMenuItem
            // 
            _ViewAllObjectsMenuItem.Image = My.Resources.Resources.objects;
            _ViewAllObjectsMenuItem.Name = "_ViewAllObjectsMenuItem";
            _ViewAllObjectsMenuItem.Size = new Size(189, 22);
            _ViewAllObjectsMenuItem.Text = "All Objects";
            // 
            // ViewAllExcludesMenuItem
            // 
            _ViewAllExcludesMenuItem.Image = My.Resources.Resources.delete;
            _ViewAllExcludesMenuItem.Name = "_ViewAllExcludesMenuItem";
            _ViewAllExcludesMenuItem.Size = new Size(189, 22);
            _ViewAllExcludesMenuItem.Text = "All Excludes";
            // 
            // ToolStripSeparator17
            // 
            ToolStripSeparator17.Name = "ToolStripSeparator17";
            ToolStripSeparator17.Size = new Size(186, 6);
            // 
            // ViewAllMenuItem
            // 
            _ViewAllMenuItem.Name = "_ViewAllMenuItem";
            _ViewAllMenuItem.Size = new Size(189, 22);
            _ViewAllMenuItem.Text = "View All";
            // 
            // SelectMenuItem
            // 
            SelectMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _SelectAllMapsMenuItem, ToolStripSeparator24, _SelectAllLandsMenuItem, _SelectAllWatersMenuItem, _SelectAllLinesMenuItem, _SelectAllPolysMenuItem, _SelectAllObjectsMenuItem, _SelectAllExcludesMenuItem, ToolStripSeparator16, _InvertSelectionMenuItem, _SelectAllMenuItem });
            SelectMenuItem.Name = "SelectMenuItem";
            SelectMenuItem.Size = new Size(50, 20);
            SelectMenuItem.Text = "&Select";
            // 
            // SelectAllMapsMenuItem
            // 
            _SelectAllMapsMenuItem.Image = My.Resources.Resources.insertmap1;
            _SelectAllMapsMenuItem.Name = "_SelectAllMapsMenuItem";
            _SelectAllMapsMenuItem.Size = new Size(164, 22);
            _SelectAllMapsMenuItem.Text = "All Maps";
            // 
            // ToolStripSeparator24
            // 
            ToolStripSeparator24.Name = "ToolStripSeparator24";
            ToolStripSeparator24.Size = new Size(161, 6);
            // 
            // SelectAllLandsMenuItem
            // 
            _SelectAllLandsMenuItem.Image = My.Resources.Resources.lands1;
            _SelectAllLandsMenuItem.Name = "_SelectAllLandsMenuItem";
            _SelectAllLandsMenuItem.Size = new Size(164, 22);
            _SelectAllLandsMenuItem.Text = "All Land Tiles";
            // 
            // SelectAllWatersMenuItem
            // 
            _SelectAllWatersMenuItem.Image = My.Resources.Resources.waters1;
            _SelectAllWatersMenuItem.Name = "_SelectAllWatersMenuItem";
            _SelectAllWatersMenuItem.Size = new Size(164, 22);
            _SelectAllWatersMenuItem.Text = "All Water Tiles";
            // 
            // SelectAllLinesMenuItem
            // 
            _SelectAllLinesMenuItem.Image = My.Resources.Resources.lines5;
            _SelectAllLinesMenuItem.Name = "_SelectAllLinesMenuItem";
            _SelectAllLinesMenuItem.Size = new Size(164, 22);
            _SelectAllLinesMenuItem.Text = "All Lines";
            // 
            // SelectAllPolysMenuItem
            // 
            _SelectAllPolysMenuItem.AccessibleRole = AccessibleRole.None;
            _SelectAllPolysMenuItem.Image = My.Resources.Resources.polys1;
            _SelectAllPolysMenuItem.Name = "_SelectAllPolysMenuItem";
            _SelectAllPolysMenuItem.Size = new Size(164, 22);
            _SelectAllPolysMenuItem.Text = "All Polygons";
            // 
            // SelectAllObjectsMenuItem
            // 
            _SelectAllObjectsMenuItem.Image = My.Resources.Resources.objects1;
            _SelectAllObjectsMenuItem.Name = "_SelectAllObjectsMenuItem";
            _SelectAllObjectsMenuItem.Size = new Size(164, 22);
            _SelectAllObjectsMenuItem.Text = "All Objects";
            // 
            // SelectAllExcludesMenuItem
            // 
            _SelectAllExcludesMenuItem.Image = My.Resources.Resources.delete1;
            _SelectAllExcludesMenuItem.Name = "_SelectAllExcludesMenuItem";
            _SelectAllExcludesMenuItem.Size = new Size(164, 22);
            _SelectAllExcludesMenuItem.Text = "All Excludes";
            // 
            // ToolStripSeparator16
            // 
            ToolStripSeparator16.Name = "ToolStripSeparator16";
            ToolStripSeparator16.Size = new Size(161, 6);
            // 
            // InvertSelectionMenuItem
            // 
            _InvertSelectionMenuItem.Name = "_InvertSelectionMenuItem";
            _InvertSelectionMenuItem.Size = new Size(164, 22);
            _InvertSelectionMenuItem.Text = "Invert Selection";
            // 
            // SelectAllMenuItem
            // 
            _SelectAllMenuItem.Alignment = ToolStripItemAlignment.Right;
            _SelectAllMenuItem.Name = "_SelectAllMenuItem";
            _SelectAllMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            _SelectAllMenuItem.Size = new Size(164, 22);
            _SelectAllMenuItem.Text = "Select &All";
            // 
            // ToolsMenuItem
            // 
            ToolsMenuItem.AccessibleRole = AccessibleRole.None;
            ToolsMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _PointerMenuItem, _ZoomMenuItem, ToolStripSeparator20, _LandMenuItem, _WaterMenuItem, _LineMenuItem, _PolyMenuItem, _ObjectMenuItem, _ExcludeMenuItem });
            ToolsMenuItem.Name = "ToolsMenuItem";
            ToolsMenuItem.Size = new Size(48, 20);
            ToolsMenuItem.Text = "&Tools";
            // 
            // PointerMenuItem
            // 
            _PointerMenuItem.Image = (Image)resources.GetObject("PointerMenuItem.Image");
            _PointerMenuItem.ImageTransparentColor = Color.Fuchsia;
            _PointerMenuItem.Name = "_PointerMenuItem";
            _PointerMenuItem.Size = new Size(118, 22);
            _PointerMenuItem.Text = "Pointer";
            // 
            // ZoomMenuItem
            // 
            _ZoomMenuItem.Image = (Image)resources.GetObject("ZoomMenuItem.Image");
            _ZoomMenuItem.ImageTransparentColor = Color.Fuchsia;
            _ZoomMenuItem.Name = "_ZoomMenuItem";
            _ZoomMenuItem.Size = new Size(118, 22);
            _ZoomMenuItem.Text = "Zoom";
            // 
            // ToolStripSeparator20
            // 
            ToolStripSeparator20.Name = "ToolStripSeparator20";
            ToolStripSeparator20.Size = new Size(115, 6);
            // 
            // LandMenuItem
            // 
            _LandMenuItem.Image = My.Resources.Resources.lands2;
            _LandMenuItem.Name = "_LandMenuItem";
            _LandMenuItem.Size = new Size(118, 22);
            _LandMenuItem.Text = "Land";
            // 
            // WaterMenuItem
            // 
            _WaterMenuItem.Image = My.Resources.Resources.waters2;
            _WaterMenuItem.Name = "_WaterMenuItem";
            _WaterMenuItem.Size = new Size(118, 22);
            _WaterMenuItem.Text = "Water";
            // 
            // LineMenuItem
            // 
            _LineMenuItem.Image = My.Resources.Resources.lines6;
            _LineMenuItem.Name = "_LineMenuItem";
            _LineMenuItem.Size = new Size(118, 22);
            _LineMenuItem.Text = "Line";
            // 
            // PolyMenuItem
            // 
            _PolyMenuItem.Image = My.Resources.Resources.polys2;
            _PolyMenuItem.Name = "_PolyMenuItem";
            _PolyMenuItem.Size = new Size(118, 22);
            _PolyMenuItem.Text = "Polygon";
            // 
            // ObjectMenuItem
            // 
            _ObjectMenuItem.Image = My.Resources.Resources.objects2;
            _ObjectMenuItem.Name = "_ObjectMenuItem";
            _ObjectMenuItem.Size = new Size(118, 22);
            _ObjectMenuItem.Text = "Object";
            // 
            // ExcludeMenuItem
            // 
            _ExcludeMenuItem.Image = My.Resources.Resources.delete2;
            _ExcludeMenuItem.Name = "_ExcludeMenuItem";
            _ExcludeMenuItem.Size = new Size(118, 22);
            _ExcludeMenuItem.Text = "Exclude";
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _SbuilderHelpMenuItem, _WhatIsNewMenuItem, _ForumMenuItem, _GetMapMenuItem, _AboutMenuItem });
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(44, 20);
            HelpMenuItem.Text = "&Help";
            // 
            // SbuilderHelpMenuItem
            // 
            _SbuilderHelpMenuItem.Name = "_SbuilderHelpMenuItem";
            _SbuilderHelpMenuItem.Size = new Size(195, 22);
            _SbuilderHelpMenuItem.Text = "SBuilderX Help";
            // 
            // WhatIsNewMenuItem
            // 
            _WhatIsNewMenuItem.Name = "_WhatIsNewMenuItem";
            _WhatIsNewMenuItem.Size = new Size(195, 22);
            _WhatIsNewMenuItem.Text = "What is New";
            // 
            // ForumMenuItem
            // 
            _ForumMenuItem.Name = "_ForumMenuItem";
            _ForumMenuItem.Size = new Size(195, 22);
            _ForumMenuItem.Text = "SBuilderX Forum";
            // 
            // GetMapMenuItem
            // 
            _GetMapMenuItem.Name = "_GetMapMenuItem";
            _GetMapMenuItem.Size = new Size(195, 22);
            _GetMapMenuItem.Text = "Get Map from the WEB";
            // 
            // AboutMenuItem
            // 
            _AboutMenuItem.Name = "_AboutMenuItem";
            _AboutMenuItem.Size = new Size(195, 22);
            _AboutMenuItem.Text = "&About";
            // 
            // FlyAircraftToToolStripMenuItem
            // 
            FlyAircraftToToolStripMenuItem.Name = "FlyAircraftToToolStripMenuItem";
            FlyAircraftToToolStripMenuItem.Size = new Size(168, 22);
            FlyAircraftToToolStripMenuItem.Text = "Fly Aircraft to ...";
            // 
            // StatusZoom
            // 
            StatusZoom.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)));
            StatusZoom.DisplayStyle = ToolStripItemDisplayStyle.Text;
            StatusZoom.Name = "StatusZoom";
            StatusZoom.Size = new Size(50, 17);
            StatusZoom.Text = "Zoom =";
            // 
            // StatusLat
            // 
            StatusLat.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)));
            StatusLat.Name = "StatusLat";
            StatusLat.Size = new Size(46, 17);
            StatusLat.Text = "   Lat = ";
            // 
            // StatusLon
            // 
            StatusLon.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)));
            StatusLon.Name = "StatusLon";
            StatusLon.Size = new Size(47, 17);
            StatusLon.Text = "  Lon = ";
            // 
            // ToolStripStatusLabel1
            // 
            ToolStripStatusLabel1.IsLink = true;
            ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            ToolStripStatusLabel1.Size = new Size(147, 17);
            ToolStripStatusLabel1.Spring = true;
            // 
            // StatusDir
            // 
            StatusDir.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)));
            StatusDir.Name = "StatusDir";
            StatusDir.Size = new Size(42, 17);
            StatusDir.Text = "   Dir =";
            // 
            // ToolStripStatusLabel2
            // 
            ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            ToolStripStatusLabel2.Size = new Size(147, 17);
            ToolStripStatusLabel2.Spring = true;
            // 
            // StatusQMID
            // 
            StatusQMID.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)));
            StatusQMID.Name = "StatusQMID";
            StatusQMID.Size = new Size(49, 17);
            StatusQMID.Text = "QMID =";
            // 
            // StatusStrip
            // 
            StatusStrip.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)));
            StatusStrip.Items.AddRange(new ToolStripItem[] { StatusZoom, StatusLat, StatusLon, ToolStripStatusLabel3, StatusTile, ToolStripStatusLabel1, StatusDir, ToolStripStatusLabel2, StatusQMID });
            StatusStrip.Location = new Point(0, 444);
            StatusStrip.Margin = new Padding(0, 1, 0, 0);
            StatusStrip.Name = "StatusStrip";
            StatusStrip.Size = new Size(692, 22);
            StatusStrip.TabIndex = 2;
            // 
            // ToolStripStatusLabel3
            // 
            ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            ToolStripStatusLabel3.Size = new Size(147, 17);
            ToolStripStatusLabel3.Spring = true;
            // 
            // StatusTile
            // 
            StatusTile.Name = "StatusTile";
            StatusTile.Size = new Size(0, 17);
            // 
            // Timer1
            // 
            _Timer1.Enabled = true;
            _Timer1.SynchronizingObject = this;
            // 
            // OpenFileDialog1
            // 
            OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // TextBoxMeasure
            // 
            TextBoxMeasure.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TextBoxMeasure.Location = new Point(551, 0);
            TextBoxMeasure.Multiline = true;
            TextBoxMeasure.Name = "TextBoxMeasure";
            TextBoxMeasure.Size = new Size(150, 90);
            TextBoxMeasure.TabIndex = 3;
            TextBoxMeasure.TextAlign = HorizontalAlignment.Center;
            TextBoxMeasure.Visible = false;
            // 
            // PopUpMenu
            // 
            PopUpMenu.Items.AddRange(new ToolStripItem[] { NamePopUPMenu, Sep1PopUPMenu, _CenterPopUPMenu, _FlyToPopUPMenu, _PointFromAircraftPopUpMenu, _ZoomInPopUPMenu, _ZoomOutPopUPMenu, _SaveBackGroundPopUpMenu, _TilePathToClipboardPopUpMenu, Sep2PopUPMenu, _DeletePopUPMenu, _JoinAllPopUPMenu, _SetWidthPopUpMenu, _SetAltitudePopUpMenu, _SetTransparencyPopUpMenu, _MakeLinePopUPMenu, _SnapQMIDPopUPMenu, _FillQMIDPopUpMenu, _SliceQMIDPopUpMenu, _MakePolyPopUPMenu, _ConvertToPolyPopUpMenu, _SmoothPopUPMenu, _OuterPopUpMenu, _HolePopUpMenu, _SamplePopUPMenu, _ManualCheckPopUPMenu, _CalibratePopUPMenu, Sep3PopUPMenu, _PropertiesPopUPMenu });
            PopUpMenu.Name = "MapPopUp";
            PopUpMenu.Size = new Size(190, 594);
            // 
            // NamePopUPMenu
            // 
            NamePopUPMenu.Name = "NamePopUPMenu";
            NamePopUPMenu.Size = new Size(189, 22);
            NamePopUPMenu.Text = "Name";
            // 
            // Sep1PopUPMenu
            // 
            Sep1PopUPMenu.Name = "Sep1PopUPMenu";
            Sep1PopUPMenu.Size = new Size(186, 6);
            // 
            // CenterPopUPMenu
            // 
            _CenterPopUPMenu.Name = "_CenterPopUPMenu";
            _CenterPopUPMenu.Size = new Size(189, 22);
            _CenterPopUPMenu.Text = "Center";
            // 
            // FlyToPopUPMenu
            // 
            _FlyToPopUPMenu.Name = "_FlyToPopUPMenu";
            _FlyToPopUPMenu.Size = new Size(189, 22);
            _FlyToPopUPMenu.Text = "Fly Aircraft Here";
            // 
            // PointFromAircraftPopUpMenu
            // 
            _PointFromAircraftPopUpMenu.Name = "_PointFromAircraftPopUpMenu";
            _PointFromAircraftPopUpMenu.Size = new Size(189, 22);
            _PointFromAircraftPopUpMenu.Text = "Point from Aircraft";
            // 
            // ZoomInPopUPMenu
            // 
            _ZoomInPopUPMenu.Image = My.Resources.Resources.ZoomIn;
            _ZoomInPopUPMenu.Name = "_ZoomInPopUPMenu";
            _ZoomInPopUPMenu.Size = new Size(189, 22);
            _ZoomInPopUPMenu.Text = "Zoom In";
            // 
            // ZoomOutPopUPMenu
            // 
            _ZoomOutPopUPMenu.Image = My.Resources.Resources.ZoomOut;
            _ZoomOutPopUPMenu.Name = "_ZoomOutPopUPMenu";
            _ZoomOutPopUPMenu.Size = new Size(189, 22);
            _ZoomOutPopUPMenu.Text = "Zoom Out";
            // 
            // SaveBackGroundPopUpMenu
            // 
            _SaveBackGroundPopUpMenu.Name = "_SaveBackGroundPopUpMenu";
            _SaveBackGroundPopUpMenu.Size = new Size(189, 22);
            _SaveBackGroundPopUpMenu.Text = "Background ...";
            // 
            // TilePathToClipboardPopUpMenu
            // 
            _TilePathToClipboardPopUpMenu.Name = "_TilePathToClipboardPopUpMenu";
            _TilePathToClipboardPopUpMenu.Size = new Size(189, 22);
            _TilePathToClipboardPopUpMenu.Text = "Tile Path to ClipBoard";
            // 
            // Sep2PopUPMenu
            // 
            Sep2PopUPMenu.Name = "Sep2PopUPMenu";
            Sep2PopUPMenu.Size = new Size(186, 6);
            // 
            // DeletePopUPMenu
            // 
            _DeletePopUPMenu.Image = (Image)resources.GetObject("DeletePopUPMenu.Image");
            _DeletePopUPMenu.Name = "_DeletePopUPMenu";
            _DeletePopUPMenu.Size = new Size(189, 22);
            _DeletePopUPMenu.Text = "Delete";
            // 
            // JoinAllPopUPMenu
            // 
            _JoinAllPopUPMenu.Name = "_JoinAllPopUPMenu";
            _JoinAllPopUPMenu.Size = new Size(189, 22);
            _JoinAllPopUPMenu.Text = "Join All ...";
            // 
            // SetWidthPopUpMenu
            // 
            _SetWidthPopUpMenu.Name = "_SetWidthPopUpMenu";
            _SetWidthPopUpMenu.Size = new Size(189, 22);
            _SetWidthPopUpMenu.Text = "Set Width ...";
            // 
            // SetAltitudePopUpMenu
            // 
            _SetAltitudePopUpMenu.Name = "_SetAltitudePopUpMenu";
            _SetAltitudePopUpMenu.Size = new Size(189, 22);
            _SetAltitudePopUpMenu.Text = "Set Altitude ...";
            // 
            // SetTransparencyPopUpMenu
            // 
            _SetTransparencyPopUpMenu.Image = (Image)resources.GetObject("SetTransparencyPopUpMenu.Image");
            _SetTransparencyPopUpMenu.Name = "_SetTransparencyPopUpMenu";
            _SetTransparencyPopUpMenu.Size = new Size(189, 22);
            _SetTransparencyPopUpMenu.Text = "Set Transparency ...";
            // 
            // MakeLinePopUPMenu
            // 
            _MakeLinePopUPMenu.Name = "_MakeLinePopUPMenu";
            _MakeLinePopUPMenu.Size = new Size(189, 22);
            _MakeLinePopUPMenu.Text = "Make Line";
            // 
            // SnapQMIDPopUPMenu
            // 
            _SnapQMIDPopUPMenu.Name = "_SnapQMIDPopUPMenu";
            _SnapQMIDPopUPMenu.Size = new Size(189, 22);
            _SnapQMIDPopUPMenu.Text = "Snap QMID";
            // 
            // FillQMIDPopUpMenu
            // 
            _FillQMIDPopUpMenu.Name = "_FillQMIDPopUpMenu";
            _FillQMIDPopUpMenu.Size = new Size(189, 22);
            _FillQMIDPopUpMenu.Text = "Fill QMID";
            // 
            // SliceQMIDPopUpMenu
            // 
            _SliceQMIDPopUpMenu.Name = "_SliceQMIDPopUpMenu";
            _SliceQMIDPopUpMenu.Size = new Size(189, 22);
            _SliceQMIDPopUpMenu.Text = "Slice QMID";
            // 
            // MakePolyPopUPMenu
            // 
            _MakePolyPopUPMenu.Name = "_MakePolyPopUPMenu";
            _MakePolyPopUPMenu.Size = new Size(189, 22);
            _MakePolyPopUPMenu.Text = "Make Poly";
            // 
            // ConvertToPolyPopUpMenu
            // 
            _ConvertToPolyPopUpMenu.Name = "_ConvertToPolyPopUpMenu";
            _ConvertToPolyPopUpMenu.Size = new Size(189, 22);
            _ConvertToPolyPopUpMenu.Text = "Convert to Poly ";
            // 
            // SmoothPopUPMenu
            // 
            _SmoothPopUPMenu.AccessibleRole = AccessibleRole.None;
            _SmoothPopUPMenu.Name = "_SmoothPopUPMenu";
            _SmoothPopUPMenu.Size = new Size(189, 22);
            _SmoothPopUPMenu.Text = "Smooth...";
            // 
            // OuterPopUpMenu
            // 
            _OuterPopUpMenu.Name = "_OuterPopUpMenu";
            _OuterPopUpMenu.Size = new Size(189, 22);
            _OuterPopUpMenu.Text = "Set as outer";
            // 
            // HolePopUpMenu
            // 
            _HolePopUpMenu.Name = "_HolePopUpMenu";
            _HolePopUpMenu.Size = new Size(189, 22);
            _HolePopUpMenu.Text = "Set as hole ...";
            // 
            // SamplePopUPMenu
            // 
            _SamplePopUPMenu.Name = "_SamplePopUPMenu";
            _SamplePopUPMenu.Size = new Size(189, 22);
            _SamplePopUPMenu.Text = "Sample ...";
            // 
            // ManualCheckPopUPMenu
            // 
            _ManualCheckPopUPMenu.Name = "_ManualCheckPopUPMenu";
            _ManualCheckPopUPMenu.Size = new Size(189, 22);
            _ManualCheckPopUPMenu.Text = "Manual Check ...";
            // 
            // CalibratePopUPMenu
            // 
            _CalibratePopUPMenu.Name = "_CalibratePopUPMenu";
            _CalibratePopUPMenu.Size = new Size(189, 22);
            _CalibratePopUPMenu.Text = "Calibrate ...";
            // 
            // Sep3PopUPMenu
            // 
            Sep3PopUPMenu.Name = "Sep3PopUPMenu";
            Sep3PopUPMenu.Size = new Size(186, 6);
            // 
            // PropertiesPopUPMenu
            // 
            _PropertiesPopUPMenu.Name = "_PropertiesPopUPMenu";
            _PropertiesPopUPMenu.Size = new Size(189, 22);
            _PropertiesPopUPMenu.Text = "Properties";
            // 
            // Timer2
            // 
            _Timer2.SynchronizingObject = this;
            // 
            // lbTilesRemaining
            // 
            lbTilesRemaining.AutoSize = true;
            lbTilesRemaining.BackColor = Color.White;
            lbTilesRemaining.Location = new Point(-3, 430);
            lbTilesRemaining.Name = "lbTilesRemaining";
            lbTilesRemaining.Size = new Size(39, 13);
            lbTilesRemaining.TabIndex = 4;
            lbTilesRemaining.Text = "Label1";
            lbTilesRemaining.Visible = false;
            // 
            // Timer3
            // 
            _Timer3.SynchronizingObject = this;
            // 
            // lbDonation
            // 
            lbDonation.AutoSize = true;
            lbDonation.BackColor = Color.White;
            lbDonation.BorderStyle = BorderStyle.FixedSingle;
            lbDonation.Location = new Point(0, 49);
            lbDonation.Name = "lbDonation";
            lbDonation.Size = new Size(387, 15);
            lbDonation.TabIndex = 6;
            lbDonation.Text = "To remove this initial window, open SBuilder.ini and set \"ShowDonation=False\" .";
            lbDonation.TextAlign = ContentAlignment.MiddleLeft;
            lbDonation.Visible = false;
            // 
            // BottomToolStripPanel
            // 
            BottomToolStripPanel.Location = new Point(0, 0);
            BottomToolStripPanel.Name = "BottomToolStripPanel";
            BottomToolStripPanel.Orientation = Orientation.Horizontal;
            BottomToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            BottomToolStripPanel.Size = new Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            TopToolStripPanel.Location = new Point(0, 0);
            TopToolStripPanel.Name = "TopToolStripPanel";
            TopToolStripPanel.Orientation = Orientation.Horizontal;
            TopToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            TopToolStripPanel.Size = new Size(0, 0);
            // 
            // ToolStrip
            // 
            ToolStrip.BackColor = Color.FromArgb(Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)), Conversions.ToInteger(Conversions.ToByte(244)));
            ToolStrip.GripStyle = ToolStripGripStyle.Hidden;
            ToolStrip.Items.AddRange(new ToolStripItem[] { _NewToolStripButton, _OpenToolStripButton, _SaveToolStripButton, toolStripSeparator6, _UndoToolStripButton, _RedoToolStripButton, toolStripSeparator7, _PointerToolStripButton, _ZoomToolStripButton, ToolStripSeparator22, _MeshToolStripButton, _LandToolStripButton, _WaterToolStripButton, PhotoToolStripButton, _LineToolStripButton, _PolyToolStripButton, _ObjectToolStripButton, _ExcludeToolStripButton, ToolStripSeparator23, _BGLToolStripButton });
            ToolStrip.Location = new Point(0, 24);
            ToolStrip.Name = "ToolStrip";
            ToolStrip.Size = new Size(692, 25);
            ToolStrip.TabIndex = 1;
            ToolStrip.Text = "ToolBar";
            // 
            // NewToolStripButton
            // 
            _NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _NewToolStripButton.Image = (Image)resources.GetObject("NewToolStripButton.Image");
            _NewToolStripButton.ImageTransparentColor = Color.Magenta;
            _NewToolStripButton.Name = "_NewToolStripButton";
            _NewToolStripButton.Size = new Size(23, 22);
            _NewToolStripButton.Text = "&New";
            _NewToolStripButton.ToolTipText = "New Project";
            // 
            // OpenToolStripButton
            // 
            _OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _OpenToolStripButton.Image = (Image)resources.GetObject("OpenToolStripButton.Image");
            _OpenToolStripButton.ImageTransparentColor = Color.Magenta;
            _OpenToolStripButton.Name = "_OpenToolStripButton";
            _OpenToolStripButton.Size = new Size(23, 22);
            _OpenToolStripButton.Text = "&Open";
            _OpenToolStripButton.ToolTipText = "Open Project";
            // 
            // SaveToolStripButton
            // 
            _SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _SaveToolStripButton.Image = (Image)resources.GetObject("SaveToolStripButton.Image");
            _SaveToolStripButton.ImageTransparentColor = Color.Magenta;
            _SaveToolStripButton.Name = "_SaveToolStripButton";
            _SaveToolStripButton.Size = new Size(23, 22);
            _SaveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 25);
            // 
            // UndoToolStripButton
            // 
            _UndoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _UndoToolStripButton.Image = (Image)resources.GetObject("UndoToolStripButton.Image");
            _UndoToolStripButton.ImageTransparentColor = Color.Magenta;
            _UndoToolStripButton.Name = "_UndoToolStripButton";
            _UndoToolStripButton.Size = new Size(23, 22);
            _UndoToolStripButton.Text = "ToolStripButton1";
            _UndoToolStripButton.ToolTipText = "Undo";
            // 
            // RedoToolStripButton
            // 
            _RedoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _RedoToolStripButton.Image = (Image)resources.GetObject("RedoToolStripButton.Image");
            _RedoToolStripButton.ImageTransparentColor = Color.Magenta;
            _RedoToolStripButton.Name = "_RedoToolStripButton";
            _RedoToolStripButton.Size = new Size(23, 22);
            _RedoToolStripButton.Text = "ToolStripButton1";
            _RedoToolStripButton.ToolTipText = "Redo";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 25);
            // 
            // PointerToolStripButton
            // 
            _PointerToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _PointerToolStripButton.Image = (Image)resources.GetObject("PointerToolStripButton.Image");
            _PointerToolStripButton.ImageTransparentColor = Color.Magenta;
            _PointerToolStripButton.Name = "_PointerToolStripButton";
            _PointerToolStripButton.Size = new Size(23, 22);
            _PointerToolStripButton.Text = "ToolStripButton8";
            _PointerToolStripButton.ToolTipText = "Pointer Mode";
            // 
            // ZoomToolStripButton
            // 
            _ZoomToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _ZoomToolStripButton.Image = (Image)resources.GetObject("ZoomToolStripButton.Image");
            _ZoomToolStripButton.ImageTransparentColor = Color.Magenta;
            _ZoomToolStripButton.Name = "_ZoomToolStripButton";
            _ZoomToolStripButton.Size = new Size(23, 22);
            _ZoomToolStripButton.Text = "ToolStripButton3";
            _ZoomToolStripButton.ToolTipText = "Zoom";
            // 
            // ToolStripSeparator22
            // 
            ToolStripSeparator22.Name = "ToolStripSeparator22";
            ToolStripSeparator22.Size = new Size(6, 25);
            // 
            // MeshToolStripButton
            // 
            _MeshToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _MeshToolStripButton.Image = (Image)resources.GetObject("MeshToolStripButton.Image");
            _MeshToolStripButton.ImageTransparentColor = Color.Magenta;
            _MeshToolStripButton.Name = "_MeshToolStripButton";
            _MeshToolStripButton.Size = new Size(23, 22);
            _MeshToolStripButton.Text = "ToolStripButton5";
            _MeshToolStripButton.ToolTipText = "Mesh Tool";
            _MeshToolStripButton.Visible = false;
            // 
            // LandToolStripButton
            // 
            _LandToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _LandToolStripButton.Image = (Image)resources.GetObject("LandToolStripButton.Image");
            _LandToolStripButton.ImageTransparentColor = Color.Silver;
            _LandToolStripButton.Name = "_LandToolStripButton";
            _LandToolStripButton.Size = new Size(23, 22);
            _LandToolStripButton.Text = "ToolStripButton6";
            _LandToolStripButton.ToolTipText = "Land Class Tool";
            // 
            // WaterToolStripButton
            // 
            _WaterToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _WaterToolStripButton.Image = (Image)resources.GetObject("WaterToolStripButton.Image");
            _WaterToolStripButton.ImageTransparentColor = Color.Silver;
            _WaterToolStripButton.Name = "_WaterToolStripButton";
            _WaterToolStripButton.Size = new Size(23, 22);
            _WaterToolStripButton.Text = "ToolStripButton7";
            _WaterToolStripButton.ToolTipText = "Water Class Tool";
            // 
            // PhotoToolStripButton
            // 
            PhotoToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            PhotoToolStripButton.Image = (Image)resources.GetObject("PhotoToolStripButton.Image");
            PhotoToolStripButton.ImageTransparentColor = Color.Silver;
            PhotoToolStripButton.Name = "PhotoToolStripButton";
            PhotoToolStripButton.Size = new Size(23, 22);
            PhotoToolStripButton.Text = "ToolStripButton10";
            PhotoToolStripButton.ToolTipText = "Photo Tool";
            PhotoToolStripButton.Visible = false;
            // 
            // LineToolStripButton
            // 
            _LineToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _LineToolStripButton.Image = My.Resources.Resources.lines7;
            _LineToolStripButton.ImageTransparentColor = Color.Silver;
            _LineToolStripButton.Name = "_LineToolStripButton";
            _LineToolStripButton.Size = new Size(23, 22);
            _LineToolStripButton.Text = "ToolStripButton12";
            _LineToolStripButton.ToolTipText = "Line Tool";
            // 
            // PolyToolStripButton
            // 
            _PolyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _PolyToolStripButton.Image = My.Resources.Resources.polys3;
            _PolyToolStripButton.ImageTransparentColor = Color.Silver;
            _PolyToolStripButton.Name = "_PolyToolStripButton";
            _PolyToolStripButton.Size = new Size(23, 22);
            _PolyToolStripButton.Text = "ToolStripButton11";
            _PolyToolStripButton.ToolTipText = "Polygon Tool";
            // 
            // ObjectToolStripButton
            // 
            _ObjectToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _ObjectToolStripButton.Image = (Image)resources.GetObject("ObjectToolStripButton.Image");
            _ObjectToolStripButton.ImageTransparentColor = Color.Magenta;
            _ObjectToolStripButton.Name = "_ObjectToolStripButton";
            _ObjectToolStripButton.Size = new Size(23, 22);
            _ObjectToolStripButton.Text = "ToolStripButton9";
            _ObjectToolStripButton.ToolTipText = "Object Tool";
            // 
            // ExcludeToolStripButton
            // 
            _ExcludeToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _ExcludeToolStripButton.Image = (Image)resources.GetObject("ExcludeToolStripButton.Image");
            _ExcludeToolStripButton.ImageTransparentColor = Color.Magenta;
            _ExcludeToolStripButton.Name = "_ExcludeToolStripButton";
            _ExcludeToolStripButton.Size = new Size(23, 22);
            _ExcludeToolStripButton.Text = "ToolStripButton2";
            _ExcludeToolStripButton.ToolTipText = "Exclude Tool";
            // 
            // ToolStripSeparator23
            // 
            ToolStripSeparator23.Name = "ToolStripSeparator23";
            ToolStripSeparator23.Size = new Size(6, 25);
            // 
            // BGLToolStripButton
            // 
            _BGLToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _BGLToolStripButton.Image = (Image)resources.GetObject("BGLToolStripButton.Image");
            _BGLToolStripButton.ImageTransparentColor = Color.Magenta;
            _BGLToolStripButton.Name = "_BGLToolStripButton";
            _BGLToolStripButton.Size = new Size(23, 22);
            _BGLToolStripButton.Text = "He&lp";
            _BGLToolStripButton.ToolTipText = "BGL Compile";
            // 
            // RightToolStripPanel
            // 
            RightToolStripPanel.Location = new Point(0, 0);
            RightToolStripPanel.Name = "RightToolStripPanel";
            RightToolStripPanel.Orientation = Orientation.Horizontal;
            RightToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            RightToolStripPanel.Size = new Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            LeftToolStripPanel.Location = new Point(0, 0);
            LeftToolStripPanel.Name = "LeftToolStripPanel";
            LeftToolStripPanel.Orientation = Orientation.Horizontal;
            LeftToolStripPanel.RowMargin = new Padding(3, 0, 0, 0);
            LeftToolStripPanel.Size = new Size(0, 0);
            // 
            // ContentPanel
            // 
            ContentPanel.Size = new Size(150, 100);
            // 
            // lbScale
            // 
            lbScale.AutoSize = true;
            lbScale.BackColor = Color.Transparent;
            lbScale.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lbScale.Location = new Point(641, 404);
            lbScale.Name = "lbScale";
            lbScale.Size = new Size(39, 13);
            lbScale.TabIndex = 7;
            lbScale.Text = "Scale";
            lbScale.Visible = false;
            // 
            // lbScaleBar
            // 
            lbScaleBar.BackColor = SystemColors.GradientInactiveCaption;
            lbScaleBar.BorderStyle = BorderStyle.FixedSingle;
            lbScaleBar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, Conversions.ToByte(0));
            lbScaleBar.Location = new Point(580, 417);
            lbScaleBar.Name = "lbScaleBar";
            lbScaleBar.Size = new Size(100, 5);
            lbScaleBar.TabIndex = 7;
            lbScaleBar.Visible = false;
            // 
            // FrmStart
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(692, 466);
            ContextMenuStrip = PopUpMenu;
            Controls.Add(lbDonation);
            Controls.Add(TextBoxMeasure);
            Controls.Add(StatusStrip);
            Controls.Add(lbScale);
            Controls.Add(lbTilesRemaining);
            Controls.Add(ToolStrip);
            Controls.Add(MenuStrip);
            Controls.Add(lbScaleBar);
            Cursor = Cursors.Default;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = MenuStrip;
            MinimumSize = new Size(200, 140);
            Name = "FrmStart";
            Text = "SBuilderX";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            StatusStrip.ResumeLayout(false);
            StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_Timer1).EndInit();
            PopUpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_Timer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Timer3).EndInit();
            ToolStrip.ResumeLayout(false);
            ToolStrip.PerformLayout();
            FormClosed += new FormClosedEventHandler(FrmStart_FormClosed);
            FormClosing += new FormClosingEventHandler(FrmStart_FormClosing);
            KeyDown += new KeyEventHandler(FrmStart_KeyDown);
            KeyUp += new KeyEventHandler(FrmStart_KeyUp);
            Load += new EventHandler(FrmStart_Load);
            MouseDown += new MouseEventHandler(FrmStart_MouseDown);
            MouseMove += new MouseEventHandler(FrmStart_MouseMove);
            MouseUp += new MouseEventHandler(FrmStart_MouseUp);
            MouseWheel += new MouseEventHandler(FrmStart_MouseWheel);
            Shown += new EventHandler(FrmStart_Shown);
            ResumeLayout(false);
            PerformLayout();
        }

        internal MenuStrip MenuStrip;
        internal ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem _NewMenuItem;

        internal ToolStripMenuItem NewMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NewMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NewMenuItem != null)
                {
                    _NewMenuItem.Click -= NewMenuItem_Click;
                }

                _NewMenuItem = value;
                if (_NewMenuItem != null)
                {
                    _NewMenuItem.Click += NewMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _OpenMenuItem;

        internal ToolStripMenuItem OpenMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OpenMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OpenMenuItem != null)
                {
                    _OpenMenuItem.Click -= OpenMenuItem_Click;
                }

                _OpenMenuItem = value;
                if (_OpenMenuItem != null)
                {
                    _OpenMenuItem.Click += OpenMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem _SaveMenuItem;

        internal ToolStripMenuItem SaveMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SaveMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SaveMenuItem != null)
                {
                    _SaveMenuItem.Click -= SaveMenuItem_Click;
                }

                _SaveMenuItem = value;
                if (_SaveMenuItem != null)
                {
                    _SaveMenuItem.Click += SaveMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SaveAsMenuItem;

        internal ToolStripMenuItem SaveAsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SaveAsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SaveAsMenuItem != null)
                {
                    _SaveAsMenuItem.Click -= SaveAsMenuItem_Click;
                }

                _SaveAsMenuItem = value;
                if (_SaveAsMenuItem != null)
                {
                    _SaveAsMenuItem.Click += SaveAsMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem _BGLMenuItem;

        internal ToolStripMenuItem BGLMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BGLMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BGLMenuItem != null)
                {
                    _BGLMenuItem.Click -= BGLMenuItem_Click;
                }

                _BGLMenuItem = value;
                if (_BGLMenuItem != null)
                {
                    _BGLMenuItem.Click += BGLMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _PropertiesMenuItem;

        internal ToolStripMenuItem PropertiesMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PropertiesMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PropertiesMenuItem != null)
                {
                    _PropertiesMenuItem.Click -= PropertiesMenuItem_Click;
                }

                _PropertiesMenuItem = value;
                if (_PropertiesMenuItem != null)
                {
                    _PropertiesMenuItem.Click += PropertiesMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem _ExitMenuItem;

        internal ToolStripMenuItem ExitMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExitMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExitMenuItem != null)
                {
                    _ExitMenuItem.Click -= ExitMenuItem_Click;
                }

                _ExitMenuItem = value;
                if (_ExitMenuItem != null)
                {
                    _ExitMenuItem.Click += ExitMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _EditMenuItem;

        internal ToolStripMenuItem EditMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EditMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EditMenuItem != null)
                {
                    _EditMenuItem.Click -= EditMenuItem_Click;
                }

                _EditMenuItem = value;
                if (_EditMenuItem != null)
                {
                    _EditMenuItem.Click += EditMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _UndoMenuItem;

        internal ToolStripMenuItem UndoMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UndoMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UndoMenuItem != null)
                {
                    _UndoMenuItem.Click -= UndoMenuItem_Click;
                }

                _UndoMenuItem = value;
                if (_UndoMenuItem != null)
                {
                    _UndoMenuItem.Click += UndoMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _RedoMenuItem;

        internal ToolStripMenuItem RedoMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RedoMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RedoMenuItem != null)
                {
                    _RedoMenuItem.Click -= RedoMenuItem_Click;
                }

                _RedoMenuItem = value;
                if (_RedoMenuItem != null)
                {
                    _RedoMenuItem.Click += RedoMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem _CopyMenuItem;

        internal ToolStripMenuItem CopyMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CopyMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CopyMenuItem != null)
                {
                    _CopyMenuItem.Click -= CopyMenuItem_Click;
                }

                _CopyMenuItem = value;
                if (_CopyMenuItem != null)
                {
                    _CopyMenuItem.Click += CopyMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _PasteMenuItem;

        internal ToolStripMenuItem PasteMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PasteMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PasteMenuItem != null)
                {
                    _PasteMenuItem.Click -= PasteMenuItem_Click;
                }

                _PasteMenuItem = value;
                if (_PasteMenuItem != null)
                {
                    _PasteMenuItem.Click += PasteMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator toolStripSeparator4;
        internal ToolStripMenuItem ToolsMenuItem;
        private ToolStripMenuItem _PointerMenuItem;

        internal ToolStripMenuItem PointerMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PointerMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PointerMenuItem != null)
                {
                    _PointerMenuItem.Click -= PointerMenuItem_Click;
                }

                _PointerMenuItem = value;
                if (_PointerMenuItem != null)
                {
                    _PointerMenuItem.Click += PointerMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ZoomMenuItem;

        internal ToolStripMenuItem ZoomMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ZoomMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ZoomMenuItem != null)
                {
                    _ZoomMenuItem.Click -= ZoomMenuItem_Click;
                }

                _ZoomMenuItem = value;
                if (_ZoomMenuItem != null)
                {
                    _ZoomMenuItem.Click += ZoomMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem HelpMenuItem;
        private ToolStripMenuItem _SbuilderHelpMenuItem;

        internal ToolStripMenuItem SbuilderHelpMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SbuilderHelpMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SbuilderHelpMenuItem != null)
                {
                    _SbuilderHelpMenuItem.Click -= SbuilderHelpMenuItem_Click;
                }

                _SbuilderHelpMenuItem = value;
                if (_SbuilderHelpMenuItem != null)
                {
                    _SbuilderHelpMenuItem.Click += SbuilderHelpMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ForumMenuItem;

        internal ToolStripMenuItem ForumMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ForumMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ForumMenuItem != null)
                {
                    _ForumMenuItem.Click -= ForumMenuItem_Click;
                }

                _ForumMenuItem = value;
                if (_ForumMenuItem != null)
                {
                    _ForumMenuItem.Click += ForumMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _AboutMenuItem;

        internal ToolStripMenuItem AboutMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AboutMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AboutMenuItem != null)
                {
                    _AboutMenuItem.Click -= AboutMenuItem_Click;
                }

                _AboutMenuItem = value;
                if (_AboutMenuItem != null)
                {
                    _AboutMenuItem.Click += AboutMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem ViewMenuItem;
        internal ToolStripMenuItem SelectMenuItem;
        internal ToolStripSeparator ToolStripSeparator8;
        private ToolStripMenuItem _ImportSBXMenuItem;

        internal ToolStripMenuItem ImportSBXMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ImportSBXMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ImportSBXMenuItem != null)
                {
                    _ImportSBXMenuItem.Click -= ImportSBXMenuItem_Click;
                }

                _ImportSBXMenuItem = value;
                if (_ImportSBXMenuItem != null)
                {
                    _ImportSBXMenuItem.Click += ImportSBXMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem AppendMenuItem;
        internal ToolStripMenuItem ExportMenuItem;
        internal ToolStripSeparator ToolStripSeparator9;
        internal ToolStripMenuItem CoordinatesToolMenuItem;
        private ToolStripMenuItem _AppendSBXMenuItem;

        internal ToolStripMenuItem AppendSBXMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AppendSBXMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AppendSBXMenuItem != null)
                {
                    _AppendSBXMenuItem.Click -= AppendSBXMenuItem_Click;
                }

                _AppendSBXMenuItem = value;
                if (_AppendSBXMenuItem != null)
                {
                    _AppendSBXMenuItem.Click += AppendSBXMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _AppendBLNMenuItem;

        internal ToolStripMenuItem AppendBLNMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AppendBLNMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AppendBLNMenuItem != null)
                {
                    _AppendBLNMenuItem.Click -= AppendBLNMenuItem_Click;
                }

                _AppendBLNMenuItem = value;
                if (_AppendBLNMenuItem != null)
                {
                    _AppendBLNMenuItem.Click += AppendBLNMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _AppendObjMenuItem;

        internal ToolStripMenuItem AppendObjMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AppendObjMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AppendObjMenuItem != null)
                {
                    _AppendObjMenuItem.Click -= AppendObjMenuItem_Click;
                }

                _AppendObjMenuItem = value;
                if (_AppendObjMenuItem != null)
                {
                    _AppendObjMenuItem.Click += AppendObjMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _AppendSHPMenuItem;

        internal ToolStripMenuItem AppendSHPMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AppendSHPMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AppendSHPMenuItem != null)
                {
                    _AppendSHPMenuItem.Click -= AppendSHPMenuItem_Click;
                }

                _AppendSHPMenuItem = value;
                if (_AppendSHPMenuItem != null)
                {
                    _AppendSHPMenuItem.Click += AppendSHPMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _AppendRAWMenuItem;

        internal ToolStripMenuItem AppendRAWMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _AppendRAWMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_AppendRAWMenuItem != null)
                {
                    _AppendRAWMenuItem.Click -= AppendRAWMenuItem_Click;
                }

                _AppendRAWMenuItem = value;
                if (_AppendRAWMenuItem != null)
                {
                    _AppendRAWMenuItem.Click += AppendRAWMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem AppendVTPMenuItem;
        private ToolStripMenuItem _ExportSBXMenuItem;

        internal ToolStripMenuItem ExportSBXMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExportSBXMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExportSBXMenuItem != null)
                {
                    _ExportSBXMenuItem.Click -= ExportSBXMenuItem_Click;
                }

                _ExportSBXMenuItem = value;
                if (_ExportSBXMenuItem != null)
                {
                    _ExportSBXMenuItem.Click += ExportSBXMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ExportBLNMenuItem;

        internal ToolStripMenuItem ExportBLNMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExportBLNMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExportBLNMenuItem != null)
                {
                    _ExportBLNMenuItem.Click -= ExportBLNMenuItem_Click;
                }

                _ExportBLNMenuItem = value;
                if (_ExportBLNMenuItem != null)
                {
                    _ExportBLNMenuItem.Click += ExportBLNMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ExportSHPMenuItem;

        internal ToolStripMenuItem ExportSHPMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExportSHPMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExportSHPMenuItem != null)
                {
                    _ExportSHPMenuItem.Click -= ExportSHPMenuItem_Click;
                }

                _ExportSHPMenuItem = value;
                if (_ExportSHPMenuItem != null)
                {
                    _ExportSHPMenuItem.Click += ExportSHPMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem DEMToolsMenuItem;
        private ToolStripMenuItem _DeleteMenuItem;

        internal ToolStripMenuItem DeleteMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DeleteMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DeleteMenuItem != null)
                {
                    _DeleteMenuItem.Click -= DeleteMenuItem_Click;
                }

                _DeleteMenuItem = value;
                if (_DeleteMenuItem != null)
                {
                    _DeleteMenuItem.Click += DeleteMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _MeasureToolMenuItem;

        internal ToolStripMenuItem MeasureToolMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MeasureToolMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MeasureToolMenuItem != null)
                {
                    _MeasureToolMenuItem.Click -= MeasureToolMenuItem_Click;
                }

                _MeasureToolMenuItem = value;
                if (_MeasureToolMenuItem != null)
                {
                    _MeasureToolMenuItem.Click += MeasureToolMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ObjLibManagerMenuItem;

        internal ToolStripMenuItem ObjLibManagerMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ObjLibManagerMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ObjLibManagerMenuItem != null)
                {
                    _ObjLibManagerMenuItem.Click -= ObjLibManagerMenuItem_Click;
                }

                _ObjLibManagerMenuItem = value;
                if (_ObjLibManagerMenuItem != null)
                {
                    _ObjLibManagerMenuItem.Click += ObjLibManagerMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator10;
        private ToolStripMenuItem _FindMenuItem;

        internal ToolStripMenuItem FindMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FindMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FindMenuItem != null)
                {
                    _FindMenuItem.Click -= FindMenuItem_Click;
                }

                _FindMenuItem = value;
                if (_FindMenuItem != null)
                {
                    _FindMenuItem.Click += FindMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator11;
        private ToolStripMenuItem _ShowToolbarMenuItem;

        internal ToolStripMenuItem ShowToolbarMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ShowToolbarMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ShowToolbarMenuItem != null)
                {
                    _ShowToolbarMenuItem.Click -= ShowToolbarMenuItem_Click;
                }

                _ShowToolbarMenuItem = value;
                if (_ShowToolbarMenuItem != null)
                {
                    _ShowToolbarMenuItem.Click += ShowToolbarMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator12;
        private ToolStripMenuItem _GoToPositionMenuItem;

        internal ToolStripMenuItem GoToPositionMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GoToPositionMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GoToPositionMenuItem != null)
                {
                    _GoToPositionMenuItem.Click -= GoToPositionMenuItem_Click;
                }

                _GoToPositionMenuItem = value;
                if (_GoToPositionMenuItem != null)
                {
                    _GoToPositionMenuItem.Click += GoToPositionMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ShowAircraftMenuItem;

        internal ToolStripMenuItem ShowAircraftMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ShowAircraftMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ShowAircraftMenuItem != null)
                {
                    _ShowAircraftMenuItem.Click -= ShowAircraftMenuItem_Click;
                }

                _ShowAircraftMenuItem = value;
                if (_ShowAircraftMenuItem != null)
                {
                    _ShowAircraftMenuItem.Click += ShowAircraftMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _FlyAircraftToMenuItem;

        internal ToolStripMenuItem FlyAircraftToMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FlyAircraftToMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FlyAircraftToMenuItem != null)
                {
                    _FlyAircraftToMenuItem.Click -= FlyAircraftToMenuItem_Click;
                }

                _FlyAircraftToMenuItem = value;
                if (_FlyAircraftToMenuItem != null)
                {
                    _FlyAircraftToMenuItem.Click += FlyAircraftToMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator13;
        internal ToolStripMenuItem ViewMapsMenuItem;
        internal ToolStripSeparator ToolStripSeparator14;
        internal ToolStripMenuItem QMIDGridMenuItem;
        internal ToolStripSeparator ToolStripSeparator15;
        private ToolStripMenuItem _ViewAllMapsMenuItem;

        internal ToolStripMenuItem ViewAllMapsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllMapsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllMapsMenuItem != null)
                {
                    _ViewAllMapsMenuItem.Click -= ViewAllMapsMenuItem_Click;
                }

                _ViewAllMapsMenuItem = value;
                if (_ViewAllMapsMenuItem != null)
                {
                    _ViewAllMapsMenuItem.Click += ViewAllMapsMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ViewAllLandsMenuItem;

        internal ToolStripMenuItem ViewAllLandsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllLandsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllLandsMenuItem != null)
                {
                    _ViewAllLandsMenuItem.Click -= ViewAllLandsMenuItem_Click;
                }

                _ViewAllLandsMenuItem = value;
                if (_ViewAllLandsMenuItem != null)
                {
                    _ViewAllLandsMenuItem.Click += ViewAllLandsMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ViewAllWatersMenuItem;

        internal ToolStripMenuItem ViewAllWatersMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllWatersMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllWatersMenuItem != null)
                {
                    _ViewAllWatersMenuItem.Click -= ViewAllWatersMenuItem_Click;
                }

                _ViewAllWatersMenuItem = value;
                if (_ViewAllWatersMenuItem != null)
                {
                    _ViewAllWatersMenuItem.Click += ViewAllWatersMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ViewAllLinesMenuItem;

        internal ToolStripMenuItem ViewAllLinesMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllLinesMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllLinesMenuItem != null)
                {
                    _ViewAllLinesMenuItem.Click -= ViewAllLinesMenuItem_Click;
                }

                _ViewAllLinesMenuItem = value;
                if (_ViewAllLinesMenuItem != null)
                {
                    _ViewAllLinesMenuItem.Click += ViewAllLinesMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ViewAllPolysMenuItem;

        internal ToolStripMenuItem ViewAllPolysMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllPolysMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllPolysMenuItem != null)
                {
                    _ViewAllPolysMenuItem.Click -= ViewAllPolysMenuItem_Click;
                }

                _ViewAllPolysMenuItem = value;
                if (_ViewAllPolysMenuItem != null)
                {
                    _ViewAllPolysMenuItem.Click += ViewAllPolysMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ViewAllObjectsMenuItem;

        internal ToolStripMenuItem ViewAllObjectsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllObjectsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllObjectsMenuItem != null)
                {
                    _ViewAllObjectsMenuItem.Click -= ViewAllObjectsMenuItem_Click;
                }

                _ViewAllObjectsMenuItem = value;
                if (_ViewAllObjectsMenuItem != null)
                {
                    _ViewAllObjectsMenuItem.Click += ViewAllObjectsMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ViewAllExcludesMenuItem;

        internal ToolStripMenuItem ViewAllExcludesMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllExcludesMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllExcludesMenuItem != null)
                {
                    _ViewAllExcludesMenuItem.Click -= ViewAllExcludesMenuItem_Click;
                }

                _ViewAllExcludesMenuItem = value;
                if (_ViewAllExcludesMenuItem != null)
                {
                    _ViewAllExcludesMenuItem.Click += ViewAllExcludesMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ViewAllMenuItem;

        internal ToolStripMenuItem ViewAllMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ViewAllMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ViewAllMenuItem != null)
                {
                    _ViewAllMenuItem.Click -= ViewAllMenuItem_Click;
                }

                _ViewAllMenuItem = value;
                if (_ViewAllMenuItem != null)
                {
                    _ViewAllMenuItem.Click += ViewAllMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SummerMapMenuItem;

        internal ToolStripMenuItem SummerMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SummerMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SummerMapMenuItem != null)
                {
                    _SummerMapMenuItem.Click -= SummerMapMenuItem_Click;
                }

                _SummerMapMenuItem = value;
                if (_SummerMapMenuItem != null)
                {
                    _SummerMapMenuItem.Click += SummerMapMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SpringMapMenuItem;

        internal ToolStripMenuItem SpringMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SpringMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SpringMapMenuItem != null)
                {
                    _SpringMapMenuItem.Click -= SpringMapMenuItem_Click;
                }

                _SpringMapMenuItem = value;
                if (_SpringMapMenuItem != null)
                {
                    _SpringMapMenuItem.Click += SpringMapMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _FallMapMenuItem;

        internal ToolStripMenuItem FallMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FallMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FallMapMenuItem != null)
                {
                    _FallMapMenuItem.Click -= FallMapMenuItem_Click;
                }

                _FallMapMenuItem = value;
                if (_FallMapMenuItem != null)
                {
                    _FallMapMenuItem.Click += FallMapMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _WinterMapMenuItem;

        internal ToolStripMenuItem WinterMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _WinterMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_WinterMapMenuItem != null)
                {
                    _WinterMapMenuItem.Click -= WinterMapMenuItem_Click;
                }

                _WinterMapMenuItem = value;
                if (_WinterMapMenuItem != null)
                {
                    _WinterMapMenuItem.Click += WinterMapMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _HardWinterMapMenuItem;

        internal ToolStripMenuItem HardWinterMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HardWinterMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_HardWinterMapMenuItem != null)
                {
                    _HardWinterMapMenuItem.Click -= HardWinterMapMenuItem_Click;
                }

                _HardWinterMapMenuItem = value;
                if (_HardWinterMapMenuItem != null)
                {
                    _HardWinterMapMenuItem.Click += HardWinterMapMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _NightMapMenuItem;

        internal ToolStripMenuItem NightMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NightMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NightMapMenuItem != null)
                {
                    _NightMapMenuItem.Click -= NightMapMenuItem_Click;
                }

                _NightMapMenuItem = value;
                if (_NightMapMenuItem != null)
                {
                    _NightMapMenuItem.Click += NightMapMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator17;
        internal ToolStripMenuItem FlyAircraftToToolStripMenuItem;
        private ToolStripMenuItem _NoGridMenuItem;

        internal ToolStripMenuItem NoGridMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NoGridMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NoGridMenuItem != null)
                {
                    _NoGridMenuItem.Click -= NoGridMenuItem_Click;
                }

                _NoGridMenuItem = value;
                if (_NoGridMenuItem != null)
                {
                    _NoGridMenuItem.Click += NoGridMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level2MenuItem;

        internal ToolStripMenuItem Level2MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level2MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level2MenuItem != null)
                {
                    _Level2MenuItem.Click -= Level2MenuItem_Click;
                }

                _Level2MenuItem = value;
                if (_Level2MenuItem != null)
                {
                    _Level2MenuItem.Click += Level2MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level3MenuItem;

        internal ToolStripMenuItem Level3MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level3MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level3MenuItem != null)
                {
                    _Level3MenuItem.Click -= Level3MenuItem_Click;
                }

                _Level3MenuItem = value;
                if (_Level3MenuItem != null)
                {
                    _Level3MenuItem.Click += Level3MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level4MenuItem;

        internal ToolStripMenuItem Level4MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level4MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level4MenuItem != null)
                {
                    _Level4MenuItem.Click -= Level4MenuItem_Click;
                }

                _Level4MenuItem = value;
                if (_Level4MenuItem != null)
                {
                    _Level4MenuItem.Click += Level4MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level5MenuItem;

        internal ToolStripMenuItem Level5MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level5MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level5MenuItem != null)
                {
                    _Level5MenuItem.Click -= Level5MenuItem_Click;
                }

                _Level5MenuItem = value;
                if (_Level5MenuItem != null)
                {
                    _Level5MenuItem.Click += Level5MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level6MenuItem;

        internal ToolStripMenuItem Level6MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level6MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level6MenuItem != null)
                {
                    _Level6MenuItem.Click -= Level6MenuItem_Click;
                }

                _Level6MenuItem = value;
                if (_Level6MenuItem != null)
                {
                    _Level6MenuItem.Click += Level6MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level7MenuItem;

        internal ToolStripMenuItem Level7MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level7MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level7MenuItem != null)
                {
                    _Level7MenuItem.Click -= Level7MenuItem_Click;
                }

                _Level7MenuItem = value;
                if (_Level7MenuItem != null)
                {
                    _Level7MenuItem.Click += Level7MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level8MenuItem;

        internal ToolStripMenuItem Level8MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level8MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level8MenuItem != null)
                {
                    _Level8MenuItem.Click -= Level8MenuItem_Click;
                }

                _Level8MenuItem = value;
                if (_Level8MenuItem != null)
                {
                    _Level8MenuItem.Click += Level8MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level9MenuItem;

        internal ToolStripMenuItem Level9MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level9MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level9MenuItem != null)
                {
                    _Level9MenuItem.Click -= Level9MenuItem_Click;
                }

                _Level9MenuItem = value;
                if (_Level9MenuItem != null)
                {
                    _Level9MenuItem.Click += Level9MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level10MenuItem;

        internal ToolStripMenuItem Level10MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level10MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level10MenuItem != null)
                {
                    _Level10MenuItem.Click -= Level10MenuItem_Click;
                }

                _Level10MenuItem = value;
                if (_Level10MenuItem != null)
                {
                    _Level10MenuItem.Click += Level10MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level11MenuItem;

        internal ToolStripMenuItem Level11MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level11MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level11MenuItem != null)
                {
                    _Level11MenuItem.Click -= Level11MenuItem_Click;
                }

                _Level11MenuItem = value;
                if (_Level11MenuItem != null)
                {
                    _Level11MenuItem.Click += Level11MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level12MenuItem;

        internal ToolStripMenuItem Level12MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level12MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level12MenuItem != null)
                {
                    _Level12MenuItem.Click -= Level12MenuItem_Click;
                }

                _Level12MenuItem = value;
                if (_Level12MenuItem != null)
                {
                    _Level12MenuItem.Click += Level12MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level13MenuItem;

        internal ToolStripMenuItem Level13MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level13MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level13MenuItem != null)
                {
                    _Level13MenuItem.Click -= Level13MenuItem_Click;
                }

                _Level13MenuItem = value;
                if (_Level13MenuItem != null)
                {
                    _Level13MenuItem.Click += Level13MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level14MenuItem;

        internal ToolStripMenuItem Level14MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level14MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level14MenuItem != null)
                {
                    _Level14MenuItem.Click -= Level14MenuItem_Click;
                }

                _Level14MenuItem = value;
                if (_Level14MenuItem != null)
                {
                    _Level14MenuItem.Click += Level14MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level15MenuItem;

        internal ToolStripMenuItem Level15MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level15MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level15MenuItem != null)
                {
                    _Level15MenuItem.Click -= Level15MenuItem_Click;
                }

                _Level15MenuItem = value;
                if (_Level15MenuItem != null)
                {
                    _Level15MenuItem.Click += Level15MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level16MenuItem;

        internal ToolStripMenuItem Level16MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level16MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level16MenuItem != null)
                {
                    _Level16MenuItem.Click -= Level16MenuItem_Click;
                }

                _Level16MenuItem = value;
                if (_Level16MenuItem != null)
                {
                    _Level16MenuItem.Click += Level16MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level17MenuItem;

        internal ToolStripMenuItem Level17MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level17MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level17MenuItem != null)
                {
                    _Level17MenuItem.Click -= Level17MenuItem_Click;
                }

                _Level17MenuItem = value;
                if (_Level17MenuItem != null)
                {
                    _Level17MenuItem.Click += Level17MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level18MenuItem;

        internal ToolStripMenuItem Level18MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level18MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level18MenuItem != null)
                {
                    _Level18MenuItem.Click -= Level18MenuItem_Click;
                }

                _Level18MenuItem = value;
                if (_Level18MenuItem != null)
                {
                    _Level18MenuItem.Click += Level18MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level19MenuItem;

        internal ToolStripMenuItem Level19MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level19MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level19MenuItem != null)
                {
                    _Level19MenuItem.Click -= Level19MenuItem_Click;
                }

                _Level19MenuItem = value;
                if (_Level19MenuItem != null)
                {
                    _Level19MenuItem.Click += Level19MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level20MenuItem;

        internal ToolStripMenuItem Level20MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level20MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level20MenuItem != null)
                {
                    _Level20MenuItem.Click -= Level20MenuItem_Click;
                }

                _Level20MenuItem = value;
                if (_Level20MenuItem != null)
                {
                    _Level20MenuItem.Click += Level20MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level21MenuItem;

        internal ToolStripMenuItem Level21MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level21MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level21MenuItem != null)
                {
                    _Level21MenuItem.Click -= Level21MenuItem_Click;
                }

                _Level21MenuItem = value;
                if (_Level21MenuItem != null)
                {
                    _Level21MenuItem.Click += Level21MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level22MenuItem;

        internal ToolStripMenuItem Level22MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level22MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level22MenuItem != null)
                {
                    _Level22MenuItem.Click -= Level22MenuItem_Click;
                }

                _Level22MenuItem = value;
                if (_Level22MenuItem != null)
                {
                    _Level22MenuItem.Click += Level22MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level23MenuItem;

        internal ToolStripMenuItem Level23MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level23MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level23MenuItem != null)
                {
                    _Level23MenuItem.Click -= Level23MenuItem_Click;
                }

                _Level23MenuItem = value;
                if (_Level23MenuItem != null)
                {
                    _Level23MenuItem.Click += Level23MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level24MenuItem;

        internal ToolStripMenuItem Level24MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level24MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level24MenuItem != null)
                {
                    _Level24MenuItem.Click -= Level24MenuItem_Click;
                }

                _Level24MenuItem = value;
                if (_Level24MenuItem != null)
                {
                    _Level24MenuItem.Click += Level24MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level25MenuItem;

        internal ToolStripMenuItem Level25MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level25MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level25MenuItem != null)
                {
                    _Level25MenuItem.Click -= Level25MenuItem_Click;
                }

                _Level25MenuItem = value;
                if (_Level25MenuItem != null)
                {
                    _Level25MenuItem.Click += Level25MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level26MenuItem;

        internal ToolStripMenuItem Level26MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level26MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level26MenuItem != null)
                {
                    _Level26MenuItem.Click -= Level26MenuItem_Click;
                }

                _Level26MenuItem = value;
                if (_Level26MenuItem != null)
                {
                    _Level26MenuItem.Click += Level26MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level27MenuItem;

        internal ToolStripMenuItem Level27MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level27MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level27MenuItem != null)
                {
                    _Level27MenuItem.Click -= Level27MenuItem_Click;
                }

                _Level27MenuItem = value;
                if (_Level27MenuItem != null)
                {
                    _Level27MenuItem.Click += Level27MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level28MenuItem;

        internal ToolStripMenuItem Level28MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level28MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level28MenuItem != null)
                {
                    _Level28MenuItem.Click -= Level28MenuItem_Click;
                }

                _Level28MenuItem = value;
                if (_Level28MenuItem != null)
                {
                    _Level28MenuItem.Click += Level28MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _Level29MenuItem;

        internal ToolStripMenuItem Level29MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Level29MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Level29MenuItem != null)
                {
                    _Level29MenuItem.Click -= Level29MenuItem_Click;
                }

                _Level29MenuItem = value;
                if (_Level29MenuItem != null)
                {
                    _Level29MenuItem.Click += Level29MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllMapsMenuItem;

        internal ToolStripMenuItem SelectAllMapsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllMapsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllMapsMenuItem != null)
                {
                    _SelectAllMapsMenuItem.Click -= SelectAllMapsMenuItem_Click;
                }

                _SelectAllMapsMenuItem = value;
                if (_SelectAllMapsMenuItem != null)
                {
                    _SelectAllMapsMenuItem.Click += SelectAllMapsMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllLandsMenuItem;

        internal ToolStripMenuItem SelectAllLandsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllLandsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllLandsMenuItem != null)
                {
                    _SelectAllLandsMenuItem.Click -= SelectAllLandsMenuItem_Click;
                }

                _SelectAllLandsMenuItem = value;
                if (_SelectAllLandsMenuItem != null)
                {
                    _SelectAllLandsMenuItem.Click += SelectAllLandsMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllWatersMenuItem;

        internal ToolStripMenuItem SelectAllWatersMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllWatersMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllWatersMenuItem != null)
                {
                    _SelectAllWatersMenuItem.Click -= SelectAllWatersMenuItem_Click;
                }

                _SelectAllWatersMenuItem = value;
                if (_SelectAllWatersMenuItem != null)
                {
                    _SelectAllWatersMenuItem.Click += SelectAllWatersMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllLinesMenuItem;

        internal ToolStripMenuItem SelectAllLinesMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllLinesMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllLinesMenuItem != null)
                {
                    _SelectAllLinesMenuItem.Click -= SelectAllLinesMenuItem_Click;
                }

                _SelectAllLinesMenuItem = value;
                if (_SelectAllLinesMenuItem != null)
                {
                    _SelectAllLinesMenuItem.Click += SelectAllLinesMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllPolysMenuItem;

        internal ToolStripMenuItem SelectAllPolysMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllPolysMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllPolysMenuItem != null)
                {
                    _SelectAllPolysMenuItem.Click -= SelectAllPolysMenuItem_Click;
                }

                _SelectAllPolysMenuItem = value;
                if (_SelectAllPolysMenuItem != null)
                {
                    _SelectAllPolysMenuItem.Click += SelectAllPolysMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllObjectsMenuItem;

        internal ToolStripMenuItem SelectAllObjectsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllObjectsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllObjectsMenuItem != null)
                {
                    _SelectAllObjectsMenuItem.Click -= SelectAllObjectsMenuItem_Click;
                }

                _SelectAllObjectsMenuItem = value;
                if (_SelectAllObjectsMenuItem != null)
                {
                    _SelectAllObjectsMenuItem.Click += SelectAllObjectsMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllExcludesMenuItem;

        internal ToolStripMenuItem SelectAllExcludesMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllExcludesMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllExcludesMenuItem != null)
                {
                    _SelectAllExcludesMenuItem.Click -= SelectAllExcludesMenuItem_Click;
                }

                _SelectAllExcludesMenuItem = value;
                if (_SelectAllExcludesMenuItem != null)
                {
                    _SelectAllExcludesMenuItem.Click += SelectAllExcludesMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SelectAllMenuItem;

        internal ToolStripMenuItem SelectAllMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SelectAllMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SelectAllMenuItem != null)
                {
                    _SelectAllMenuItem.Click -= SelectAllMenuItem_Click;
                }

                _SelectAllMenuItem = value;
                if (_SelectAllMenuItem != null)
                {
                    _SelectAllMenuItem.Click += SelectAllMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LandMenuItem;

        internal ToolStripMenuItem LandMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LandMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LandMenuItem != null)
                {
                    _LandMenuItem.Click -= LandMenuItem_Click;
                }

                _LandMenuItem = value;
                if (_LandMenuItem != null)
                {
                    _LandMenuItem.Click += LandMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _WaterMenuItem;

        internal ToolStripMenuItem WaterMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _WaterMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_WaterMenuItem != null)
                {
                    _WaterMenuItem.Click -= WaterMenuItem_Click;
                }

                _WaterMenuItem = value;
                if (_WaterMenuItem != null)
                {
                    _WaterMenuItem.Click += WaterMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LineMenuItem;

        internal ToolStripMenuItem LineMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LineMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LineMenuItem != null)
                {
                    _LineMenuItem.Click -= LineMenuItem_Click;
                }

                _LineMenuItem = value;
                if (_LineMenuItem != null)
                {
                    _LineMenuItem.Click += LineMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _PolyMenuItem;

        internal ToolStripMenuItem PolyMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PolyMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PolyMenuItem != null)
                {
                    _PolyMenuItem.Click -= PolyMenuItem_Click;
                }

                _PolyMenuItem = value;
                if (_PolyMenuItem != null)
                {
                    _PolyMenuItem.Click += PolyMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ObjectMenuItem;

        internal ToolStripMenuItem ObjectMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ObjectMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ObjectMenuItem != null)
                {
                    _ObjectMenuItem.Click -= ObjectMenuItem_Click;
                }

                _ObjectMenuItem = value;
                if (_ObjectMenuItem != null)
                {
                    _ObjectMenuItem.Click += ObjectMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ExcludeMenuItem;

        internal ToolStripMenuItem ExcludeMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExcludeMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExcludeMenuItem != null)
                {
                    _ExcludeMenuItem.Click -= ExcludeMenuItem_Click;
                }

                _ExcludeMenuItem = value;
                if (_ExcludeMenuItem != null)
                {
                    _ExcludeMenuItem.Click += ExcludeMenuItem_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator20;
        internal ToolStripSeparator ToolStripSeparator16;
        private ToolStripMenuItem _InvertSelectionMenuItem;

        internal ToolStripMenuItem InvertSelectionMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _InvertSelectionMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_InvertSelectionMenuItem != null)
                {
                    _InvertSelectionMenuItem.Click -= InvertSelectionMenuItem_Click;
                }

                _InvertSelectionMenuItem = value;
                if (_InvertSelectionMenuItem != null)
                {
                    _InvertSelectionMenuItem.Click += InvertSelectionMenuItem_Click;
                }
            }
        }

        // Protected Overrides Sub Finalize()
        // MyBase.Finalize()
        // End Sub

        internal ToolStripSeparator ToolStripSeparator24;
        internal ToolStripStatusLabel StatusZoom;
        internal ToolStripStatusLabel StatusLat;
        internal ToolStripStatusLabel StatusLon;
        internal ToolStripStatusLabel ToolStripStatusLabel1;
        internal ToolStripStatusLabel StatusDir;
        internal ToolStripStatusLabel ToolStripStatusLabel2;
        internal ToolStripStatusLabel StatusQMID;
        internal StatusStrip StatusStrip;
        private System.Timers.Timer _Timer1;

        internal System.Timers.Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Elapsed -= Timer1_Elapsed;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Elapsed += Timer1_Elapsed;
                }
            }
        }

        internal ToolStripSeparator RecentFileSeparatorMenuItem;
        private ToolStripMenuItem _RecentFile1MenuItem;

        internal ToolStripMenuItem RecentFile1MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RecentFile1MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RecentFile1MenuItem != null)
                {
                    _RecentFile1MenuItem.Click -= RecentFile1MenuItem_Click;
                }

                _RecentFile1MenuItem = value;
                if (_RecentFile1MenuItem != null)
                {
                    _RecentFile1MenuItem.Click += RecentFile1MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _RecentFile2MenuItem;

        internal ToolStripMenuItem RecentFile2MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RecentFile2MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RecentFile2MenuItem != null)
                {
                    _RecentFile2MenuItem.Click -= RecentFile2MenuItem_Click;
                }

                _RecentFile2MenuItem = value;
                if (_RecentFile2MenuItem != null)
                {
                    _RecentFile2MenuItem.Click += RecentFile2MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _RecentFile3MenuItem;

        internal ToolStripMenuItem RecentFile3MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RecentFile3MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RecentFile3MenuItem != null)
                {
                    _RecentFile3MenuItem.Click -= RecentFile3MenuItem_Click;
                }

                _RecentFile3MenuItem = value;
                if (_RecentFile3MenuItem != null)
                {
                    _RecentFile3MenuItem.Click += RecentFile3MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _RecentFile4MenuItem;

        internal ToolStripMenuItem RecentFile4MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RecentFile4MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RecentFile4MenuItem != null)
                {
                    _RecentFile4MenuItem.Click -= RecentFile4MenuItem_Click;
                }

                _RecentFile4MenuItem = value;
                if (_RecentFile4MenuItem != null)
                {
                    _RecentFile4MenuItem.Click += RecentFile4MenuItem_Click;
                }
            }
        }

        internal SaveFileDialog SaveFileDialog1;
        internal OpenFileDialog OpenFileDialog1;
        internal TextBox TextBoxMeasure;
        internal ContextMenuStrip PopUpMenu;
        internal ToolStripMenuItem NamePopUPMenu;
        private ToolStripMenuItem _CenterPopUPMenu;

        internal ToolStripMenuItem CenterPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CenterPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CenterPopUPMenu != null)
                {
                    _CenterPopUPMenu.Click -= CenterPopUPMenu_Click;
                }

                _CenterPopUPMenu = value;
                if (_CenterPopUPMenu != null)
                {
                    _CenterPopUPMenu.Click += CenterPopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _ZoomInPopUPMenu;

        internal ToolStripMenuItem ZoomInPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ZoomInPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ZoomInPopUPMenu != null)
                {
                    _ZoomInPopUPMenu.Click -= ZoomInPopUPMenu_Click;
                }

                _ZoomInPopUPMenu = value;
                if (_ZoomInPopUPMenu != null)
                {
                    _ZoomInPopUPMenu.Click += ZoomInPopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _ZoomOutPopUPMenu;

        internal ToolStripMenuItem ZoomOutPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ZoomOutPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ZoomOutPopUPMenu != null)
                {
                    _ZoomOutPopUPMenu.Click -= ZoomOutPopUPMenu_Click;
                }

                _ZoomOutPopUPMenu = value;
                if (_ZoomOutPopUPMenu != null)
                {
                    _ZoomOutPopUPMenu.Click += ZoomOutPopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _DeletePopUPMenu;

        internal ToolStripMenuItem DeletePopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DeletePopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DeletePopUPMenu != null)
                {
                    _DeletePopUPMenu.Click -= DeletePopUPMenu_Click;
                }

                _DeletePopUPMenu = value;
                if (_DeletePopUPMenu != null)
                {
                    _DeletePopUPMenu.Click += DeletePopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _CalibratePopUPMenu;

        internal ToolStripMenuItem CalibratePopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CalibratePopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CalibratePopUPMenu != null)
                {
                    _CalibratePopUPMenu.Click -= CalibratePopUPMenu_Click;
                }

                _CalibratePopUPMenu = value;
                if (_CalibratePopUPMenu != null)
                {
                    _CalibratePopUPMenu.Click += CalibratePopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _PropertiesPopUPMenu;

        internal ToolStripMenuItem PropertiesPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PropertiesPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PropertiesPopUPMenu != null)
                {
                    _PropertiesPopUPMenu.Click -= PropertiesPopUPMenu_Click;
                }

                _PropertiesPopUPMenu = value;
                if (_PropertiesPopUPMenu != null)
                {
                    _PropertiesPopUPMenu.Click += PropertiesPopUPMenu_Click;
                }
            }
        }

        internal ToolStripSeparator Sep1PopUPMenu;
        internal ToolStripSeparator Sep2PopUPMenu;
        internal ToolStripSeparator Sep3PopUPMenu;
        private ToolStripMenuItem _MakeLinePopUPMenu;

        internal ToolStripMenuItem MakeLinePopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MakeLinePopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MakeLinePopUPMenu != null)
                {
                    _MakeLinePopUPMenu.Click -= MakeLinePopUPMenu_Click;
                }

                _MakeLinePopUPMenu = value;
                if (_MakeLinePopUPMenu != null)
                {
                    _MakeLinePopUPMenu.Click += MakeLinePopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _MakePolyPopUPMenu;

        internal ToolStripMenuItem MakePolyPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MakePolyPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MakePolyPopUPMenu != null)
                {
                    _MakePolyPopUPMenu.Click -= MakePolyPopUPMenu_Click;
                }

                _MakePolyPopUPMenu = value;
                if (_MakePolyPopUPMenu != null)
                {
                    _MakePolyPopUPMenu.Click += MakePolyPopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _SmoothPopUPMenu;

        internal ToolStripMenuItem SmoothPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SmoothPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SmoothPopUPMenu != null)
                {
                    _SmoothPopUPMenu.Click -= SmoothPopUPMenu_Click;
                }

                _SmoothPopUPMenu = value;
                if (_SmoothPopUPMenu != null)
                {
                    _SmoothPopUPMenu.Click += SmoothPopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _SamplePopUPMenu;

        internal ToolStripMenuItem SamplePopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SamplePopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SamplePopUPMenu != null)
                {
                    _SamplePopUPMenu.Click -= SamplePopUPMenu_Click;
                }

                _SamplePopUPMenu = value;
                if (_SamplePopUPMenu != null)
                {
                    _SamplePopUPMenu.Click += SamplePopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _ManualCheckPopUPMenu;

        internal ToolStripMenuItem ManualCheckPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ManualCheckPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ManualCheckPopUPMenu != null)
                {
                    _ManualCheckPopUPMenu.Click -= ManualCheckPopUPMenu_Click;
                }

                _ManualCheckPopUPMenu = value;
                if (_ManualCheckPopUPMenu != null)
                {
                    _ManualCheckPopUPMenu.Click += ManualCheckPopUPMenu_Click;
                }
            }
        }

        internal ToolStripMenuItem AddMapMenuItem;
        private ToolStripMenuItem _FromDiskMenuItem;

        internal ToolStripMenuItem FromDiskMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FromDiskMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FromDiskMenuItem != null)
                {
                    _FromDiskMenuItem.Click -= FromDiskMenuItem_Click;
                }

                _FromDiskMenuItem = value;
                if (_FromDiskMenuItem != null)
                {
                    _FromDiskMenuItem.Click += FromDiskMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _FromBackgroundMapMenuItem;

        internal ToolStripMenuItem FromBackgroundMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FromBackgroundMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FromBackgroundMapMenuItem != null)
                {
                    _FromBackgroundMapMenuItem.Click -= FromBackgroundMapMenuItem_Click;
                }

                _FromBackgroundMapMenuItem = value;
                if (_FromBackgroundMapMenuItem != null)
                {
                    _FromBackgroundMapMenuItem.Click += FromBackgroundMapMenuItem_Click;
                }
            }
        }

        internal FolderBrowserDialog FolderBrowserDialog1;
        private ToolStripMenuItem _SetWidthPopUpMenu;

        internal ToolStripMenuItem SetWidthPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SetWidthPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SetWidthPopUpMenu != null)
                {
                    _SetWidthPopUpMenu.Click -= SetWidthPopUpMenu_Click;
                }

                _SetWidthPopUpMenu = value;
                if (_SetWidthPopUpMenu != null)
                {
                    _SetWidthPopUpMenu.Click += SetWidthPopUpMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _SetAltitudePopUpMenu;

        internal ToolStripMenuItem SetAltitudePopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SetAltitudePopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SetAltitudePopUpMenu != null)
                {
                    _SetAltitudePopUpMenu.Click -= SetAltitudePopUpMenu_Click;
                }

                _SetAltitudePopUpMenu = value;
                if (_SetAltitudePopUpMenu != null)
                {
                    _SetAltitudePopUpMenu.Click += SetAltitudePopUpMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _HolePopUpMenu;

        internal ToolStripMenuItem HolePopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _HolePopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_HolePopUpMenu != null)
                {
                    _HolePopUpMenu.Click -= HolePopUpMenu_Click;
                }

                _HolePopUpMenu = value;
                if (_HolePopUpMenu != null)
                {
                    _HolePopUpMenu.Click += HolePopUpMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _SetTransparencyPopUpMenu;

        internal ToolStripMenuItem SetTransparencyPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SetTransparencyPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SetTransparencyPopUpMenu != null)
                {
                    _SetTransparencyPopUpMenu.Click -= SetTransparencyPopUpMenu_Click;
                }

                _SetTransparencyPopUpMenu = value;
                if (_SetTransparencyPopUpMenu != null)
                {
                    _SetTransparencyPopUpMenu.Click += SetTransparencyPopUpMenu_Click;
                }
            }
        }

        private System.Timers.Timer _Timer2;

        internal System.Timers.Timer Timer2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer2 != null)
                {
                    _Timer2.Elapsed -= Timer2_Elapsed;
                }

                _Timer2 = value;
                if (_Timer2 != null)
                {
                    _Timer2.Elapsed += Timer2_Elapsed;
                }
            }
        }

        private ToolStripMenuItem _FlyToPopUPMenu;

        internal ToolStripMenuItem FlyToPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FlyToPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FlyToPopUPMenu != null)
                {
                    _FlyToPopUPMenu.Click -= FlyToPopUPMenu_Click;
                }

                _FlyToPopUPMenu = value;
                if (_FlyToPopUPMenu != null)
                {
                    _FlyToPopUPMenu.Click += FlyToPopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _ShowBackgroundMenuItem;

        internal ToolStripMenuItem ShowBackgroundMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ShowBackgroundMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ShowBackgroundMenuItem != null)
                {
                    _ShowBackgroundMenuItem.Click -= ShowBackgroundMenuItem_Click;
                }

                _ShowBackgroundMenuItem = value;
                if (_ShowBackgroundMenuItem != null)
                {
                    _ShowBackgroundMenuItem.Click += ShowBackgroundMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SaveBackGroundPopUpMenu;

        internal ToolStripMenuItem SaveBackGroundPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SaveBackGroundPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SaveBackGroundPopUpMenu != null)
                {
                    _SaveBackGroundPopUpMenu.Click -= SaveBackGroundPopUpMenu_Click;
                }

                _SaveBackGroundPopUpMenu = value;
                if (_SaveBackGroundPopUpMenu != null)
                {
                    _SaveBackGroundPopUpMenu.Click += SaveBackGroundPopUpMenu_Click;
                }
            }
        }

        internal Label lbTilesRemaining;
        private ToolStripMenuItem _JoinAllPopUPMenu;

        internal ToolStripMenuItem JoinAllPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _JoinAllPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_JoinAllPopUPMenu != null)
                {
                    _JoinAllPopUPMenu.Click -= JoinAllPopUPMenu_Click;
                }

                _JoinAllPopUPMenu = value;
                if (_JoinAllPopUPMenu != null)
                {
                    _JoinAllPopUPMenu.Click += JoinAllPopUPMenu_Click;
                }
            }
        }

        private System.Timers.Timer _Timer3;

        internal System.Timers.Timer Timer3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer3 != null)
                {
                    _Timer3.Elapsed -= Timer3_Elapsed;
                }

                _Timer3 = value;
                if (_Timer3 != null)
                {
                    _Timer3.Elapsed += Timer3_Elapsed;
                }
            }
        }

        private ToolStripMenuItem _ConvertToPolyPopUpMenu;

        internal ToolStripMenuItem ConvertToPolyPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ConvertToPolyPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ConvertToPolyPopUpMenu != null)
                {
                    _ConvertToPolyPopUpMenu.Click -= ConvertToPolyPopUpMenu_Click;
                }

                _ConvertToPolyPopUpMenu = value;
                if (_ConvertToPolyPopUpMenu != null)
                {
                    _ConvertToPolyPopUpMenu.Click += ConvertToPolyPopUpMenu_Click;
                }
            }
        }

        internal Label lbDonation;
        internal ToolStripStatusLabel StatusTile;
        internal ToolStripStatusLabel ToolStripStatusLabel3;
        private ToolStripMenuItem _GetMapMenuItem;

        internal ToolStripMenuItem GetMapMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _GetMapMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_GetMapMenuItem != null)
                {
                    _GetMapMenuItem.Click -= GetMapMenuItem_Click;
                }

                _GetMapMenuItem = value;
                if (_GetMapMenuItem != null)
                {
                    _GetMapMenuItem.Click += GetMapMenuItem_Click;
                }
            }
        }

        internal ToolStrip ToolStrip;
        private ToolStripButton _NewToolStripButton;

        internal ToolStripButton NewToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NewToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NewToolStripButton != null)
                {
                    _NewToolStripButton.Click -= NewToolStripButton_Click;
                }

                _NewToolStripButton = value;
                if (_NewToolStripButton != null)
                {
                    _NewToolStripButton.Click += NewToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _OpenToolStripButton;

        internal ToolStripButton OpenToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OpenToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OpenToolStripButton != null)
                {
                    _OpenToolStripButton.Click -= OpenToolStripButton_Click;
                }

                _OpenToolStripButton = value;
                if (_OpenToolStripButton != null)
                {
                    _OpenToolStripButton.Click += OpenToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _SaveToolStripButton;

        internal ToolStripButton SaveToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SaveToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SaveToolStripButton != null)
                {
                    _SaveToolStripButton.Click -= SaveToolStripButton_Click;
                }

                _SaveToolStripButton = value;
                if (_SaveToolStripButton != null)
                {
                    _SaveToolStripButton.Click += SaveToolStripButton_Click;
                }
            }
        }

        internal ToolStripSeparator toolStripSeparator6;
        private ToolStripButton _UndoToolStripButton;

        internal ToolStripButton UndoToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _UndoToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_UndoToolStripButton != null)
                {
                    _UndoToolStripButton.Click -= UndoToolStripButton_Click;
                }

                _UndoToolStripButton = value;
                if (_UndoToolStripButton != null)
                {
                    _UndoToolStripButton.Click += UndoToolStripButton_Click;
                }
            }
        }

        internal ToolStripSeparator toolStripSeparator7;
        private ToolStripButton _PointerToolStripButton;

        internal ToolStripButton PointerToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PointerToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PointerToolStripButton != null)
                {
                    _PointerToolStripButton.Click -= PointerToolStripButton_Click;
                }

                _PointerToolStripButton = value;
                if (_PointerToolStripButton != null)
                {
                    _PointerToolStripButton.Click += PointerToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _ZoomToolStripButton;

        internal ToolStripButton ZoomToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ZoomToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ZoomToolStripButton != null)
                {
                    _ZoomToolStripButton.Click -= ZoomToolStripButton_Click;
                }

                _ZoomToolStripButton = value;
                if (_ZoomToolStripButton != null)
                {
                    _ZoomToolStripButton.Click += ZoomToolStripButton_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator22;
        private ToolStripButton _MeshToolStripButton;

        internal ToolStripButton MeshToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _MeshToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_MeshToolStripButton != null)
                {
                    _MeshToolStripButton.Click -= MeshToolStripButton_Click;
                }

                _MeshToolStripButton = value;
                if (_MeshToolStripButton != null)
                {
                    _MeshToolStripButton.Click += MeshToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _LandToolStripButton;

        internal ToolStripButton LandToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LandToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LandToolStripButton != null)
                {
                    _LandToolStripButton.Click -= LandToolStripButton_Click;
                }

                _LandToolStripButton = value;
                if (_LandToolStripButton != null)
                {
                    _LandToolStripButton.Click += LandToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _WaterToolStripButton;

        internal ToolStripButton WaterToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _WaterToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_WaterToolStripButton != null)
                {
                    _WaterToolStripButton.Click -= WaterToolStripButton_Click;
                }

                _WaterToolStripButton = value;
                if (_WaterToolStripButton != null)
                {
                    _WaterToolStripButton.Click += WaterToolStripButton_Click;
                }
            }
        }

        internal ToolStripButton PhotoToolStripButton;
        private ToolStripButton _LineToolStripButton;

        internal ToolStripButton LineToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LineToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LineToolStripButton != null)
                {
                    _LineToolStripButton.Click -= LineToolStripButton_Click;
                }

                _LineToolStripButton = value;
                if (_LineToolStripButton != null)
                {
                    _LineToolStripButton.Click += LineToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _PolyToolStripButton;

        internal ToolStripButton PolyToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PolyToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PolyToolStripButton != null)
                {
                    _PolyToolStripButton.Click -= PolyToolStripButton_Click;
                }

                _PolyToolStripButton = value;
                if (_PolyToolStripButton != null)
                {
                    _PolyToolStripButton.Click += PolyToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _ObjectToolStripButton;

        internal ToolStripButton ObjectToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ObjectToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ObjectToolStripButton != null)
                {
                    _ObjectToolStripButton.Click -= ObjectToolStripButton_Click;
                }

                _ObjectToolStripButton = value;
                if (_ObjectToolStripButton != null)
                {
                    _ObjectToolStripButton.Click += ObjectToolStripButton_Click;
                }
            }
        }

        private ToolStripButton _ExcludeToolStripButton;

        internal ToolStripButton ExcludeToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExcludeToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExcludeToolStripButton != null)
                {
                    _ExcludeToolStripButton.Click -= ExcludeToolStripButton_Click;
                }

                _ExcludeToolStripButton = value;
                if (_ExcludeToolStripButton != null)
                {
                    _ExcludeToolStripButton.Click += ExcludeToolStripButton_Click;
                }
            }
        }

        internal ToolStripSeparator ToolStripSeparator23;
        private ToolStripButton _BGLToolStripButton;

        internal ToolStripButton BGLToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _BGLToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_BGLToolStripButton != null)
                {
                    _BGLToolStripButton.Click -= BGLToolStripButton_Click;
                }

                _BGLToolStripButton = value;
                if (_BGLToolStripButton != null)
                {
                    _BGLToolStripButton.Click += BGLToolStripButton_Click;
                }
            }
        }

        private ToolStripMenuItem _FillQMIDPopUpMenu;

        internal ToolStripMenuItem FillQMIDPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FillQMIDPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FillQMIDPopUpMenu != null)
                {
                    _FillQMIDPopUpMenu.Click -= FillQMIDPopUpMenu_Click;
                }

                _FillQMIDPopUpMenu = value;
                if (_FillQMIDPopUpMenu != null)
                {
                    _FillQMIDPopUpMenu.Click += FillQMIDPopUpMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _SliceQMIDPopUpMenu;

        internal ToolStripMenuItem SliceQMIDPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SliceQMIDPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SliceQMIDPopUpMenu != null)
                {
                    _SliceQMIDPopUpMenu.Click -= SliceQMIDPopUpMenu_Click;
                }

                _SliceQMIDPopUpMenu = value;
                if (_SliceQMIDPopUpMenu != null)
                {
                    _SliceQMIDPopUpMenu.Click += SliceQMIDPopUpMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _PointFromAircraftPopUpMenu;

        internal ToolStripMenuItem PointFromAircraftPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PointFromAircraftPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PointFromAircraftPopUpMenu != null)
                {
                    _PointFromAircraftPopUpMenu.Click -= PointFromAircraftPopUpMenu_Click;
                }

                _PointFromAircraftPopUpMenu = value;
                if (_PointFromAircraftPopUpMenu != null)
                {
                    _PointFromAircraftPopUpMenu.Click += PointFromAircraftPopUpMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _TilePathToClipboardPopUpMenu;

        internal ToolStripMenuItem TilePathToClipboardPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TilePathToClipboardPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TilePathToClipboardPopUpMenu != null)
                {
                    _TilePathToClipboardPopUpMenu.Click -= TilePathToClipboardPopUpMenu_Click;
                }

                _TilePathToClipboardPopUpMenu = value;
                if (_TilePathToClipboardPopUpMenu != null)
                {
                    _TilePathToClipboardPopUpMenu.Click += TilePathToClipboardPopUpMenu_Click;
                }
            }
        }

        internal ToolStripPanel BottomToolStripPanel;
        internal ToolStripPanel TopToolStripPanel;
        internal ToolStripPanel RightToolStripPanel;
        internal ToolStripPanel LeftToolStripPanel;
        internal ToolStripContentPanel ContentPanel;
        private ToolStripButton _RedoToolStripButton;

        internal ToolStripButton RedoToolStripButton
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _RedoToolStripButton;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_RedoToolStripButton != null)
                {
                    _RedoToolStripButton.Click -= RedoToolStripButton_Click;
                }

                _RedoToolStripButton = value;
                if (_RedoToolStripButton != null)
                {
                    _RedoToolStripButton.Click += RedoToolStripButton_Click;
                }
            }
        }

        private ToolStripMenuItem _FSXSettingsMenuItem;

        internal ToolStripMenuItem FSXSettingsMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FSXSettingsMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FSXSettingsMenuItem != null)
                {
                    _FSXSettingsMenuItem.Click -= FSXSettingsMenuItem_Click;
                }

                _FSXSettingsMenuItem = value;
                if (_FSXSettingsMenuItem != null)
                {
                    _FSXSettingsMenuItem.Click += FSXSettingsMenuItem_Click;
                }
            }
        }

        internal Label lbScale;
        internal Label lbScaleBar;
        private ToolStripMenuItem _OuterPopUpMenu;

        internal ToolStripMenuItem OuterPopUpMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _OuterPopUpMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_OuterPopUpMenu != null)
                {
                    _OuterPopUpMenu.Click -= OuterPopUpMenu_Click;
                }

                _OuterPopUpMenu = value;
                if (_OuterPopUpMenu != null)
                {
                    _OuterPopUpMenu.Click += OuterPopUpMenu_Click;
                }
            }
        }

        internal ToolStripMenuItem LODGridMenuItem;
        private ToolStripMenuItem _NoLODMenuItem;

        internal ToolStripMenuItem NoLODMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _NoLODMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_NoLODMenuItem != null)
                {
                    _NoLODMenuItem.Click -= NoLODMenuItem_Click;
                }

                _NoLODMenuItem = value;
                if (_NoLODMenuItem != null)
                {
                    _NoLODMenuItem.Click += NoLODMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD0MenuItem;

        internal ToolStripMenuItem LOD0MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD0MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD0MenuItem != null)
                {
                    _LOD0MenuItem.Click -= LOD0MenuItem_Click;
                }

                _LOD0MenuItem = value;
                if (_LOD0MenuItem != null)
                {
                    _LOD0MenuItem.Click += LOD0MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD1MenuItem;

        internal ToolStripMenuItem LOD1MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD1MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD1MenuItem != null)
                {
                    _LOD1MenuItem.Click -= LOD1MenuItem_Click;
                }

                _LOD1MenuItem = value;
                if (_LOD1MenuItem != null)
                {
                    _LOD1MenuItem.Click += LOD1MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD2MenuItem;

        internal ToolStripMenuItem LOD2MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD2MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD2MenuItem != null)
                {
                    _LOD2MenuItem.Click -= LOD2MenuItem_Click;
                }

                _LOD2MenuItem = value;
                if (_LOD2MenuItem != null)
                {
                    _LOD2MenuItem.Click += LOD2MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD3MenuItem;

        internal ToolStripMenuItem LOD3MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD3MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD3MenuItem != null)
                {
                    _LOD3MenuItem.Click -= LOD3MenuItem_Click;
                }

                _LOD3MenuItem = value;
                if (_LOD3MenuItem != null)
                {
                    _LOD3MenuItem.Click += LOD3MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD4MenuItem;

        internal ToolStripMenuItem LOD4MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD4MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD4MenuItem != null)
                {
                    _LOD4MenuItem.Click -= LOD4MenuItem_Click;
                }

                _LOD4MenuItem = value;
                if (_LOD4MenuItem != null)
                {
                    _LOD4MenuItem.Click += LOD4MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD5MenuItem;

        internal ToolStripMenuItem LOD5MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD5MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD5MenuItem != null)
                {
                    _LOD5MenuItem.Click -= LOD5MenuItem_Click;
                }

                _LOD5MenuItem = value;
                if (_LOD5MenuItem != null)
                {
                    _LOD5MenuItem.Click += LOD5MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD6MenuItem;

        internal ToolStripMenuItem LOD6MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD6MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD6MenuItem != null)
                {
                    _LOD6MenuItem.Click -= LOD6MenuItem_Click;
                }

                _LOD6MenuItem = value;
                if (_LOD6MenuItem != null)
                {
                    _LOD6MenuItem.Click += LOD6MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD7MenuItem;

        internal ToolStripMenuItem LOD7MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD7MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD7MenuItem != null)
                {
                    _LOD7MenuItem.Click -= LOD7MenuItem_Click;
                }

                _LOD7MenuItem = value;
                if (_LOD7MenuItem != null)
                {
                    _LOD7MenuItem.Click += LOD7MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD8MenuItem;

        internal ToolStripMenuItem LOD8MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD8MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD8MenuItem != null)
                {
                    _LOD8MenuItem.Click -= LOD8MenuItem_Click;
                }

                _LOD8MenuItem = value;
                if (_LOD8MenuItem != null)
                {
                    _LOD8MenuItem.Click += LOD8MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD9MenuItem;

        internal ToolStripMenuItem LOD9MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD9MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD9MenuItem != null)
                {
                    _LOD9MenuItem.Click -= LOD9MenuItem_Click;
                }

                _LOD9MenuItem = value;
                if (_LOD9MenuItem != null)
                {
                    _LOD9MenuItem.Click += LOD9MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD10MenuItem;

        internal ToolStripMenuItem LOD10MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD10MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD10MenuItem != null)
                {
                    _LOD10MenuItem.Click -= LOD10MenuItem_Click;
                }

                _LOD10MenuItem = value;
                if (_LOD10MenuItem != null)
                {
                    _LOD10MenuItem.Click += LOD10MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD11MenuItem;

        internal ToolStripMenuItem LOD11MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD11MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD11MenuItem != null)
                {
                    _LOD11MenuItem.Click -= LOD11MenuItem_Click;
                }

                _LOD11MenuItem = value;
                if (_LOD11MenuItem != null)
                {
                    _LOD11MenuItem.Click += LOD11MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD12MenuItem;

        internal ToolStripMenuItem LOD12MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD12MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD12MenuItem != null)
                {
                    _LOD12MenuItem.Click -= LOD12MenuItem_Click;
                }

                _LOD12MenuItem = value;
                if (_LOD12MenuItem != null)
                {
                    _LOD12MenuItem.Click += LOD12MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD13MenuItem;

        internal ToolStripMenuItem LOD13MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD13MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD13MenuItem != null)
                {
                    _LOD13MenuItem.Click -= LOD13MenuItem_Click;
                }

                _LOD13MenuItem = value;
                if (_LOD13MenuItem != null)
                {
                    _LOD13MenuItem.Click += LOD13MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SnapToQMIDMenuItem;

        internal ToolStripMenuItem SnapToQMIDMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SnapToQMIDMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SnapToQMIDMenuItem != null)
                {
                    _SnapToQMIDMenuItem.Click -= SnapToQMIDMenuItem_Click;
                }

                _SnapToQMIDMenuItem = value;
                if (_SnapToQMIDMenuItem != null)
                {
                    _SnapToQMIDMenuItem.Click += SnapToQMIDMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD14MenuItem;

        internal ToolStripMenuItem LOD14MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD14MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD14MenuItem != null)
                {
                    _LOD14MenuItem.Click -= LOD14MenuItem_Click;
                }

                _LOD14MenuItem = value;
                if (_LOD14MenuItem != null)
                {
                    _LOD14MenuItem.Click += LOD14MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD15MenuItem;

        internal ToolStripMenuItem LOD15MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD15MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD15MenuItem != null)
                {
                    _LOD15MenuItem.Click -= LOD15MenuItem_Click;
                }

                _LOD15MenuItem = value;
                if (_LOD15MenuItem != null)
                {
                    _LOD15MenuItem.Click += LOD15MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD16MenuItem;

        internal ToolStripMenuItem LOD16MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD16MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD16MenuItem != null)
                {
                    _LOD16MenuItem.Click -= LOD16MenuItem_Click;
                }

                _LOD16MenuItem = value;
                if (_LOD16MenuItem != null)
                {
                    _LOD16MenuItem.Click += LOD16MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD17MenuItem;

        internal ToolStripMenuItem LOD17MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD17MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD17MenuItem != null)
                {
                    _LOD17MenuItem.Click -= LOD17MenuItem_Click;
                }

                _LOD17MenuItem = value;
                if (_LOD17MenuItem != null)
                {
                    _LOD17MenuItem.Click += LOD17MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD18MenuItem;

        internal ToolStripMenuItem LOD18MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD18MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD18MenuItem != null)
                {
                    _LOD18MenuItem.Click -= LOD18MenuItem_Click;
                }

                _LOD18MenuItem = value;
                if (_LOD18MenuItem != null)
                {
                    _LOD18MenuItem.Click += LOD18MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD19MenuItem;

        internal ToolStripMenuItem LOD19MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD19MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD19MenuItem != null)
                {
                    _LOD19MenuItem.Click -= LOD19MenuItem_Click;
                }

                _LOD19MenuItem = value;
                if (_LOD19MenuItem != null)
                {
                    _LOD19MenuItem.Click += LOD19MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD20MenuItem;

        internal ToolStripMenuItem LOD20MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD20MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD20MenuItem != null)
                {
                    _LOD20MenuItem.Click -= LOD20MenuItem_Click;
                }

                _LOD20MenuItem = value;
                if (_LOD20MenuItem != null)
                {
                    _LOD20MenuItem.Click += LOD20MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD21MenuItem;

        internal ToolStripMenuItem LOD21MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD21MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD21MenuItem != null)
                {
                    _LOD21MenuItem.Click -= LOD21MenuItem_Click;
                }

                _LOD21MenuItem = value;
                if (_LOD21MenuItem != null)
                {
                    _LOD21MenuItem.Click += LOD21MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD22MenuItem;

        internal ToolStripMenuItem LOD22MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD22MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD22MenuItem != null)
                {
                    _LOD22MenuItem.Click -= LOD22MenuItem_Click;
                }

                _LOD22MenuItem = value;
                if (_LOD22MenuItem != null)
                {
                    _LOD22MenuItem.Click += LOD22MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD23MenuItem;

        internal ToolStripMenuItem LOD23MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD23MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD23MenuItem != null)
                {
                    _LOD23MenuItem.Click -= LOD23MenuItem_Click;
                }

                _LOD23MenuItem = value;
                if (_LOD23MenuItem != null)
                {
                    _LOD23MenuItem.Click += LOD23MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD24MenuItem;

        internal ToolStripMenuItem LOD24MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD24MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD24MenuItem != null)
                {
                    _LOD24MenuItem.Click -= LOD24MenuItem_Click;
                }

                _LOD24MenuItem = value;
                if (_LOD24MenuItem != null)
                {
                    _LOD24MenuItem.Click += LOD24MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD25MenuItem;

        internal ToolStripMenuItem LOD25MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD25MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD25MenuItem != null)
                {
                    _LOD25MenuItem.Click -= LOD25MenuItem_Click;
                }

                _LOD25MenuItem = value;
                if (_LOD25MenuItem != null)
                {
                    _LOD25MenuItem.Click += LOD25MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD26MenuItem;

        internal ToolStripMenuItem LOD26MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD26MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD26MenuItem != null)
                {
                    _LOD26MenuItem.Click -= LOD26MenuItem_Click;
                }

                _LOD26MenuItem = value;
                if (_LOD26MenuItem != null)
                {
                    _LOD26MenuItem.Click += LOD26MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _LOD27MenuItem;

        internal ToolStripMenuItem LOD27MenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _LOD27MenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_LOD27MenuItem != null)
                {
                    _LOD27MenuItem.Click -= LOD27MenuItem_Click;
                }

                _LOD27MenuItem = value;
                if (_LOD27MenuItem != null)
                {
                    _LOD27MenuItem.Click += LOD27MenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _SnapQMIDPopUPMenu;

        internal ToolStripMenuItem SnapQMIDPopUPMenu
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SnapQMIDPopUPMenu;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SnapQMIDPopUPMenu != null)
                {
                    _SnapQMIDPopUPMenu.Click -= SnapQMIDPopUPMenu_Click;
                }

                _SnapQMIDPopUPMenu = value;
                if (_SnapQMIDPopUPMenu != null)
                {
                    _SnapQMIDPopUPMenu.Click += SnapQMIDPopUPMenu_Click;
                }
            }
        }

        private ToolStripMenuItem _ExportKMLMenuItem;

        internal ToolStripMenuItem ExportKMLMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ExportKMLMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ExportKMLMenuItem != null)
                {
                    _ExportKMLMenuItem.Click -= ExportKMLMenuItem_Click;
                }

                _ExportKMLMenuItem = value;
                if (_ExportKMLMenuItem != null)
                {
                    _ExportKMLMenuItem.Click += ExportKMLMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _FromGoogleMapsToolStripMenuItem;

        internal ToolStripMenuItem FromGoogleMapsToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FromGoogleMapsToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FromGoogleMapsToolStripMenuItem != null)
                {
                    _FromGoogleMapsToolStripMenuItem.Click -= FromGoogleMapsToolStripMenuItem_Click;
                }

                _FromGoogleMapsToolStripMenuItem = value;
                if (_FromGoogleMapsToolStripMenuItem != null)
                {
                    _FromGoogleMapsToolStripMenuItem.Click += FromGoogleMapsToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _EditINIFileMenuItem;

        internal ToolStripMenuItem EditINIFileMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EditINIFileMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EditINIFileMenuItem != null)
                {
                    _EditINIFileMenuItem.Click -= EditINIFileMenuItem_Click;
                }

                _EditINIFileMenuItem = value;
                if (_EditINIFileMenuItem != null)
                {
                    _EditINIFileMenuItem.Click += EditINIFileMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _EnableUndoRedoMenuItem;

        internal ToolStripMenuItem EnableUndoRedoMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EnableUndoRedoMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EnableUndoRedoMenuItem != null)
                {
                    _EnableUndoRedoMenuItem.Click -= EnableUndoRedoMenuItem_Click;
                }

                _EnableUndoRedoMenuItem = value;
                if (_EnableUndoRedoMenuItem != null)
                {
                    _EnableUndoRedoMenuItem.Click += EnableUndoRedoMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _TileServerMenuItem;

        internal ToolStripMenuItem TileServerMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TileServerMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TileServerMenuItem != null)
                {
                    _TileServerMenuItem.Click -= TileServerMenuItem_Click;
                }

                _TileServerMenuItem = value;
                if (_TileServerMenuItem != null)
                {
                    _TileServerMenuItem.Click += TileServerMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _ObjectFoldersMenuItem;

        internal ToolStripMenuItem ObjectFoldersMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ObjectFoldersMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ObjectFoldersMenuItem != null)
                {
                    _ObjectFoldersMenuItem.Click -= ObjectFoldersMenuItem_Click;
                }

                _ObjectFoldersMenuItem = value;
                if (_ObjectFoldersMenuItem != null)
                {
                    _ObjectFoldersMenuItem.Click += ObjectFoldersMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _FromArcGisToolStripMenuItem;

        internal ToolStripMenuItem FromArcGisToolStripMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FromArcGisToolStripMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FromArcGisToolStripMenuItem != null)
                {
                    _FromArcGisToolStripMenuItem.Click -= FromArcGisToolStripMenuItem_Click;
                }

                _FromArcGisToolStripMenuItem = value;
                if (_FromArcGisToolStripMenuItem != null)
                {
                    _FromArcGisToolStripMenuItem.Click += FromArcGisToolStripMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _WhatIsNewMenuItem;

        internal ToolStripMenuItem WhatIsNewMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _WhatIsNewMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_WhatIsNewMenuItem != null)
                {
                    _WhatIsNewMenuItem.Click -= WhatIsNewMenuItem_Click;
                }

                _WhatIsNewMenuItem = value;
                if (_WhatIsNewMenuItem != null)
                {
                    _WhatIsNewMenuItem.Click += WhatIsNewMenuItem_Click;
                }
            }
        }
    }
}