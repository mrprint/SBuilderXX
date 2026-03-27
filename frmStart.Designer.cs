using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStart));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this._SaveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SaveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._BGLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._PropertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this._ImportSBXMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppendMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AppendSBXMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AppendBLNMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AppendObjMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AppendSHPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AppendRAWMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AppendVTPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ExportSBXMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ExportBLNMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ExportSHPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ExportKMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FromDiskMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FromBackgroundMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FromGoogleMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FromArcGisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.DEMToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CoordinatesToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecentFileSeparatorMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this._RecentFile1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._RecentFile2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._RecentFile3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._RecentFile4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._EnableUndoRedoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._UndoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._RedoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this._SnapToQMIDMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MeasureToolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ObjLibManagerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this._CopyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._PasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this._FindMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this._TileServerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FSXSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ObjectFoldersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._EditINIFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ShowToolbarMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this._ShowBackgroundMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LODGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._NoLODMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD0MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD1MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD6MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD7MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD8MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD9MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD11MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD12MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD13MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD14MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD15MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD16MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD17MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD18MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD19MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD20MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD21MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD22MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD23MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD24MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD25MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD26MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LOD27MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QMIDGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._NoGridMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level2MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level3MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level4MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level5MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level6MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level7MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level8MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level9MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level10MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level11MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level12MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level13MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level14MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level15MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level16MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level17MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level18MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level19MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level20MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level21MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level22MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level23MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level24MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level25MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level26MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level27MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level28MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._Level29MenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this._GoToPositionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ShowAircraftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FlyAircraftToMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewMapsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SummerMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SpringMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FallMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._WinterMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._HardWinterMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._NightMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this._ViewAllMapsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ViewAllLandsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ViewAllWatersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ViewAllLinesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ViewAllPolysMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ViewAllObjectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ViewAllExcludesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this._ViewAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SelectAllMapsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this._SelectAllLandsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SelectAllWatersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SelectAllLinesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SelectAllPolysMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SelectAllObjectsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SelectAllExcludesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this._InvertSelectionMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SelectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._PointerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ZoomMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this._LandMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._WaterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._LineMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._PolyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ObjectMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ExcludeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._SbuilderHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._WhatIsNewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._ForumMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._GetMapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FlyAircraftToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLat = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLon = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusDir = new System.Windows.Forms.ToolStripStatusLabel();
            this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusQMID = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTile = new System.Windows.Forms.ToolStripStatusLabel();
            this._Timer1 = new System.Timers.Timer();
            this.SaveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.OpenFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TextBoxMeasure = new System.Windows.Forms.TextBox();
            this.PopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NamePopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Sep1PopUPMenu = new System.Windows.Forms.ToolStripSeparator();
            this._CenterPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._FlyToPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._PointFromAircraftPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._ZoomInPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._ZoomOutPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SaveBackGroundPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._TilePathToClipboardPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Sep2PopUPMenu = new System.Windows.Forms.ToolStripSeparator();
            this._DeletePopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._JoinAllPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SetWidthPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SetAltitudePopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SetTransparencyPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._MakeLinePopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SnapQMIDPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._FillQMIDPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SliceQMIDPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._MakePolyPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._ConvertToPolyPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SmoothPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._OuterPopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._HolePopUpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._SamplePopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._ManualCheckPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this._CalibratePopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Sep3PopUPMenu = new System.Windows.Forms.ToolStripSeparator();
            this._PropertiesPopUPMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this._Timer2 = new System.Timers.Timer();
            this.lbTilesRemaining = new System.Windows.Forms.Label();
            this._Timer3 = new System.Timers.Timer();
            this.lbDonation = new System.Windows.Forms.Label();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this._NewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._OpenToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._SaveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this._UndoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._RedoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this._PointerToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._ZoomToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this._MeshToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._LandToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._WaterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.PhotoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._LineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._PolyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._ObjectToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._ExcludeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this._BGLToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.lbScale = new System.Windows.Forms.Label();
            this.lbScaleBar = new System.Windows.Forms.Label();
            this.MenuStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Timer1)).BeginInit();
            this.PopUpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Timer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Timer3)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.AllowMerge = false;
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem,
            this._EditMenuItem,
            this.ViewMenuItem,
            this.SelectMenuItem,
            this.ToolsMenuItem,
            this.HelpMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(692, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NewMenuItem,
            this._OpenMenuItem,
            this.toolStripSeparator,
            this._SaveMenuItem,
            this._SaveAsMenuItem,
            this.toolStripSeparator1,
            this._BGLMenuItem,
            this._PropertiesMenuItem,
            this.ToolStripSeparator8,
            this._ImportSBXMenuItem,
            this.AppendMenuItem,
            this.ExportMenuItem,
            this.AddMapMenuItem,
            this.ToolStripSeparator9,
            this.DEMToolsMenuItem,
            this.CoordinatesToolMenuItem,
            this.toolStripSeparator2,
            this._ExitMenuItem,
            this.RecentFileSeparatorMenuItem,
            this._RecentFile1MenuItem,
            this._RecentFile2MenuItem,
            this._RecentFile3MenuItem,
            this._RecentFile4MenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileMenuItem.Text = "&File";
            // 
            // _NewMenuItem
            // 
            this._NewMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_NewMenuItem.Image")));
            this._NewMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._NewMenuItem.Name = "_NewMenuItem";
            this._NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this._NewMenuItem.Size = new System.Drawing.Size(205, 22);
            this._NewMenuItem.Text = "&New Project";
            this._NewMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // _OpenMenuItem
            // 
            this._OpenMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_OpenMenuItem.Image")));
            this._OpenMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._OpenMenuItem.Name = "_OpenMenuItem";
            this._OpenMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this._OpenMenuItem.Size = new System.Drawing.Size(205, 22);
            this._OpenMenuItem.Text = "&Open Project ...";
            this._OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(202, 6);
            // 
            // _SaveMenuItem
            // 
            this._SaveMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_SaveMenuItem.Image")));
            this._SaveMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._SaveMenuItem.Name = "_SaveMenuItem";
            this._SaveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this._SaveMenuItem.Size = new System.Drawing.Size(205, 22);
            this._SaveMenuItem.Text = "&Save Project";
            this._SaveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // _SaveAsMenuItem
            // 
            this._SaveAsMenuItem.Name = "_SaveAsMenuItem";
            this._SaveAsMenuItem.Size = new System.Drawing.Size(205, 22);
            this._SaveAsMenuItem.Text = "Save Project &As ...";
            this._SaveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // _BGLMenuItem
            // 
            this._BGLMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_BGLMenuItem.Image")));
            this._BGLMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._BGLMenuItem.Name = "_BGLMenuItem";
            this._BGLMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this._BGLMenuItem.Size = new System.Drawing.Size(205, 22);
            this._BGLMenuItem.Text = "&BGL Compile ...";
            this._BGLMenuItem.Click += new System.EventHandler(this.BGLMenuItem_Click);
            // 
            // _PropertiesMenuItem
            // 
            this._PropertiesMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_PropertiesMenuItem.Image")));
            this._PropertiesMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._PropertiesMenuItem.Name = "_PropertiesMenuItem";
            this._PropertiesMenuItem.Size = new System.Drawing.Size(205, 22);
            this._PropertiesMenuItem.Text = "&Properties";
            this._PropertiesMenuItem.Click += new System.EventHandler(this.PropertiesMenuItem_Click);
            // 
            // ToolStripSeparator8
            // 
            this.ToolStripSeparator8.Name = "ToolStripSeparator8";
            this.ToolStripSeparator8.Size = new System.Drawing.Size(202, 6);
            // 
            // _ImportSBXMenuItem
            // 
            this._ImportSBXMenuItem.Name = "_ImportSBXMenuItem";
            this._ImportSBXMenuItem.Size = new System.Drawing.Size(205, 22);
            this._ImportSBXMenuItem.Text = "Import SBuilderXX SBX ...";
            this._ImportSBXMenuItem.Click += new System.EventHandler(this.ImportSBXMenuItem_Click);
            // 
            // AppendMenuItem
            // 
            this.AppendMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._AppendSBXMenuItem,
            this._AppendBLNMenuItem,
            this._AppendObjMenuItem,
            this._AppendSHPMenuItem,
            this._AppendRAWMenuItem,
            this.AppendVTPMenuItem});
            this.AppendMenuItem.Name = "AppendMenuItem";
            this.AppendMenuItem.Size = new System.Drawing.Size(205, 22);
            this.AppendMenuItem.Text = "Append";
            // 
            // _AppendSBXMenuItem
            // 
            this._AppendSBXMenuItem.Name = "_AppendSBXMenuItem";
            this._AppendSBXMenuItem.Size = new System.Drawing.Size(174, 22);
            this._AppendSBXMenuItem.Text = "SBuilderXX SBX ...";
            this._AppendSBXMenuItem.Click += new System.EventHandler(this.AppendSBXMenuItem_Click);
            // 
            // _AppendBLNMenuItem
            // 
            this._AppendBLNMenuItem.Name = "_AppendBLNMenuItem";
            this._AppendBLNMenuItem.Size = new System.Drawing.Size(174, 22);
            this._AppendBLNMenuItem.Text = "Surfer BLN ...";
            this._AppendBLNMenuItem.Click += new System.EventHandler(this.AppendBLNMenuItem_Click);
            // 
            // _AppendObjMenuItem
            // 
            this._AppendObjMenuItem.Image = global::SBuilderXX.My.Resources.Resources.XML;
            this._AppendObjMenuItem.Name = "_AppendObjMenuItem";
            this._AppendObjMenuItem.Size = new System.Drawing.Size(174, 22);
            this._AppendObjMenuItem.Text = "Object BGL/XML ...";
            this._AppendObjMenuItem.Click += new System.EventHandler(this.AppendObjMenuItem_Click);
            // 
            // _AppendSHPMenuItem
            // 
            this._AppendSHPMenuItem.Name = "_AppendSHPMenuItem";
            this._AppendSHPMenuItem.Size = new System.Drawing.Size(174, 22);
            this._AppendSHPMenuItem.Text = "ESRI SHP ...";
            this._AppendSHPMenuItem.Click += new System.EventHandler(this.AppendSHPMenuItem_Click);
            // 
            // _AppendRAWMenuItem
            // 
            this._AppendRAWMenuItem.Name = "_AppendRAWMenuItem";
            this._AppendRAWMenuItem.Size = new System.Drawing.Size(174, 22);
            this._AppendRAWMenuItem.Text = "Class RAW ...";
            this._AppendRAWMenuItem.Click += new System.EventHandler(this.AppendRAWMenuItem_Click);
            // 
            // AppendVTPMenuItem
            // 
            this.AppendVTPMenuItem.Name = "AppendVTPMenuItem";
            this.AppendVTPMenuItem.Size = new System.Drawing.Size(174, 22);
            this.AppendVTPMenuItem.Text = "FS9 VTP BGL ...";
            this.AppendVTPMenuItem.Visible = false;
            // 
            // ExportMenuItem
            // 
            this.ExportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ExportSBXMenuItem,
            this._ExportBLNMenuItem,
            this._ExportSHPMenuItem,
            this._ExportKMLMenuItem});
            this.ExportMenuItem.Name = "ExportMenuItem";
            this.ExportMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ExportMenuItem.Text = "Export";
            // 
            // _ExportSBXMenuItem
            // 
            this._ExportSBXMenuItem.Name = "_ExportSBXMenuItem";
            this._ExportSBXMenuItem.Size = new System.Drawing.Size(166, 22);
            this._ExportSBXMenuItem.Text = "SBuilderXX SBX ...";
            this._ExportSBXMenuItem.Click += new System.EventHandler(this.ExportSBXMenuItem_Click);
            // 
            // _ExportBLNMenuItem
            // 
            this._ExportBLNMenuItem.Name = "_ExportBLNMenuItem";
            this._ExportBLNMenuItem.Size = new System.Drawing.Size(166, 22);
            this._ExportBLNMenuItem.Text = "Surfer BLN ...";
            this._ExportBLNMenuItem.Click += new System.EventHandler(this.ExportBLNMenuItem_Click);
            // 
            // _ExportSHPMenuItem
            // 
            this._ExportSHPMenuItem.Enabled = false;
            this._ExportSHPMenuItem.Name = "_ExportSHPMenuItem";
            this._ExportSHPMenuItem.Size = new System.Drawing.Size(166, 22);
            this._ExportSHPMenuItem.Text = "Esri SHP ...";
            this._ExportSHPMenuItem.Click += new System.EventHandler(this.ExportSHPMenuItem_Click);
            // 
            // _ExportKMLMenuItem
            // 
            this._ExportKMLMenuItem.Name = "_ExportKMLMenuItem";
            this._ExportKMLMenuItem.Size = new System.Drawing.Size(166, 22);
            this._ExportKMLMenuItem.Text = "Google KML ...";
            this._ExportKMLMenuItem.Visible = false;
            this._ExportKMLMenuItem.Click += new System.EventHandler(this.ExportKMLMenuItem_Click);
            // 
            // AddMapMenuItem
            // 
            this.AddMapMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._FromDiskMenuItem,
            this._FromBackgroundMapMenuItem,
            this._FromGoogleMapsToolStripMenuItem,
            this._FromArcGisToolStripMenuItem});
            this.AddMapMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("AddMapMenuItem.Image")));
            this.AddMapMenuItem.Name = "AddMapMenuItem";
            this.AddMapMenuItem.Size = new System.Drawing.Size(205, 22);
            this.AddMapMenuItem.Text = "Add Map";
            // 
            // _FromDiskMenuItem
            // 
            this._FromDiskMenuItem.Name = "_FromDiskMenuItem";
            this._FromDiskMenuItem.Size = new System.Drawing.Size(187, 22);
            this._FromDiskMenuItem.Text = "From disk ...";
            this._FromDiskMenuItem.Click += new System.EventHandler(this.FromDiskMenuItem_Click);
            // 
            // _FromBackgroundMapMenuItem
            // 
            this._FromBackgroundMapMenuItem.Enabled = false;
            this._FromBackgroundMapMenuItem.Name = "_FromBackgroundMapMenuItem";
            this._FromBackgroundMapMenuItem.Size = new System.Drawing.Size(187, 22);
            this._FromBackgroundMapMenuItem.Text = "From background ...";
            this._FromBackgroundMapMenuItem.Click += new System.EventHandler(this.FromBackgroundMapMenuItem_Click);
            // 
            // _FromGoogleMapsToolStripMenuItem
            // 
            this._FromGoogleMapsToolStripMenuItem.Name = "_FromGoogleMapsToolStripMenuItem";
            this._FromGoogleMapsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this._FromGoogleMapsToolStripMenuItem.Text = "From Google Maps ...";
            this._FromGoogleMapsToolStripMenuItem.Click += new System.EventHandler(this.FromGoogleMapsToolStripMenuItem_Click);
            // 
            // _FromArcGisToolStripMenuItem
            // 
            this._FromArcGisToolStripMenuItem.Name = "_FromArcGisToolStripMenuItem";
            this._FromArcGisToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this._FromArcGisToolStripMenuItem.Text = "From ArcGis ...";
            this._FromArcGisToolStripMenuItem.Click += new System.EventHandler(this.FromArcGisToolStripMenuItem_Click);
            // 
            // ToolStripSeparator9
            // 
            this.ToolStripSeparator9.Name = "ToolStripSeparator9";
            this.ToolStripSeparator9.Size = new System.Drawing.Size(202, 6);
            // 
            // DEMToolsMenuItem
            // 
            this.DEMToolsMenuItem.Enabled = false;
            this.DEMToolsMenuItem.Name = "DEMToolsMenuItem";
            this.DEMToolsMenuItem.Size = new System.Drawing.Size(205, 22);
            this.DEMToolsMenuItem.Text = "DEM Tools ...";
            this.DEMToolsMenuItem.Visible = false;
            // 
            // CoordinatesToolMenuItem
            // 
            this.CoordinatesToolMenuItem.Enabled = false;
            this.CoordinatesToolMenuItem.Name = "CoordinatesToolMenuItem";
            this.CoordinatesToolMenuItem.Size = new System.Drawing.Size(205, 22);
            this.CoordinatesToolMenuItem.Text = "Coordinates Tool ...";
            this.CoordinatesToolMenuItem.Visible = false;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(202, 6);
            this.toolStripSeparator2.Visible = false;
            // 
            // _ExitMenuItem
            // 
            this._ExitMenuItem.Name = "_ExitMenuItem";
            this._ExitMenuItem.Size = new System.Drawing.Size(205, 22);
            this._ExitMenuItem.Text = "E&xit";
            this._ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // RecentFileSeparatorMenuItem
            // 
            this.RecentFileSeparatorMenuItem.Name = "RecentFileSeparatorMenuItem";
            this.RecentFileSeparatorMenuItem.Size = new System.Drawing.Size(202, 6);
            this.RecentFileSeparatorMenuItem.Visible = false;
            // 
            // _RecentFile1MenuItem
            // 
            this._RecentFile1MenuItem.Name = "_RecentFile1MenuItem";
            this._RecentFile1MenuItem.Size = new System.Drawing.Size(205, 22);
            this._RecentFile1MenuItem.Text = "f1";
            this._RecentFile1MenuItem.Visible = false;
            this._RecentFile1MenuItem.Click += new System.EventHandler(this.RecentFile1MenuItem_Click);
            // 
            // _RecentFile2MenuItem
            // 
            this._RecentFile2MenuItem.Name = "_RecentFile2MenuItem";
            this._RecentFile2MenuItem.Size = new System.Drawing.Size(205, 22);
            this._RecentFile2MenuItem.Text = "f2";
            this._RecentFile2MenuItem.Visible = false;
            this._RecentFile2MenuItem.Click += new System.EventHandler(this.RecentFile2MenuItem_Click);
            // 
            // _RecentFile3MenuItem
            // 
            this._RecentFile3MenuItem.Name = "_RecentFile3MenuItem";
            this._RecentFile3MenuItem.Size = new System.Drawing.Size(205, 22);
            this._RecentFile3MenuItem.Text = "f3";
            this._RecentFile3MenuItem.Visible = false;
            this._RecentFile3MenuItem.Click += new System.EventHandler(this.RecentFile3MenuItem_Click);
            // 
            // _RecentFile4MenuItem
            // 
            this._RecentFile4MenuItem.Name = "_RecentFile4MenuItem";
            this._RecentFile4MenuItem.Size = new System.Drawing.Size(205, 22);
            this._RecentFile4MenuItem.Text = "f4";
            this._RecentFile4MenuItem.Visible = false;
            this._RecentFile4MenuItem.Click += new System.EventHandler(this.RecentFile4MenuItem_Click);
            // 
            // _EditMenuItem
            // 
            this._EditMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._EnableUndoRedoMenuItem,
            this._UndoMenuItem,
            this._RedoMenuItem,
            this.toolStripSeparator3,
            this._SnapToQMIDMenuItem,
            this._MeasureToolMenuItem,
            this._ObjLibManagerMenuItem,
            this.ToolStripSeparator10,
            this._CopyMenuItem,
            this._PasteMenuItem,
            this._DeleteMenuItem,
            this.toolStripSeparator4,
            this._FindMenuItem,
            this.ToolStripSeparator11,
            this._TileServerMenuItem,
            this._FSXSettingsMenuItem,
            this._ObjectFoldersMenuItem,
            this._EditINIFileMenuItem});
            this._EditMenuItem.Name = "_EditMenuItem";
            this._EditMenuItem.Size = new System.Drawing.Size(39, 20);
            this._EditMenuItem.Text = "&Edit";
            this._EditMenuItem.Click += new System.EventHandler(this.EditMenuItem_Click);
            // 
            // _EnableUndoRedoMenuItem
            // 
            this._EnableUndoRedoMenuItem.Checked = true;
            this._EnableUndoRedoMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._EnableUndoRedoMenuItem.Name = "_EnableUndoRedoMenuItem";
            this._EnableUndoRedoMenuItem.Size = new System.Drawing.Size(190, 22);
            this._EnableUndoRedoMenuItem.Text = "Enable Undo Redo";
            this._EnableUndoRedoMenuItem.Click += new System.EventHandler(this.EnableUndoRedoMenuItem_Click);
            // 
            // _UndoMenuItem
            // 
            this._UndoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_UndoMenuItem.Image")));
            this._UndoMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this._UndoMenuItem.Name = "_UndoMenuItem";
            this._UndoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this._UndoMenuItem.Size = new System.Drawing.Size(190, 22);
            this._UndoMenuItem.Text = "&Undo";
            this._UndoMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
            // 
            // _RedoMenuItem
            // 
            this._RedoMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_RedoMenuItem.Image")));
            this._RedoMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this._RedoMenuItem.Name = "_RedoMenuItem";
            this._RedoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this._RedoMenuItem.Size = new System.Drawing.Size(190, 22);
            this._RedoMenuItem.Text = "&Redo";
            this._RedoMenuItem.Click += new System.EventHandler(this.RedoMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(187, 6);
            // 
            // _SnapToQMIDMenuItem
            // 
            this._SnapToQMIDMenuItem.Image = global::SBuilderXX.My.Resources.Resources.AlignToGridHS;
            this._SnapToQMIDMenuItem.Name = "_SnapToQMIDMenuItem";
            this._SnapToQMIDMenuItem.Size = new System.Drawing.Size(190, 22);
            this._SnapToQMIDMenuItem.Text = "Snap to QMID ...";
            this._SnapToQMIDMenuItem.Click += new System.EventHandler(this.SnapToQMIDMenuItem_Click);
            // 
            // _MeasureToolMenuItem
            // 
            this._MeasureToolMenuItem.Image = global::SBuilderXX.My.Resources.Resources.measure;
            this._MeasureToolMenuItem.Name = "_MeasureToolMenuItem";
            this._MeasureToolMenuItem.Size = new System.Drawing.Size(190, 22);
            this._MeasureToolMenuItem.Text = "Measure Tool";
            this._MeasureToolMenuItem.Click += new System.EventHandler(this.MeasureToolMenuItem_Click);
            // 
            // _ObjLibManagerMenuItem
            // 
            this._ObjLibManagerMenuItem.Name = "_ObjLibManagerMenuItem";
            this._ObjLibManagerMenuItem.Size = new System.Drawing.Size(190, 22);
            this._ObjLibManagerMenuItem.Text = "Object Lib Manager ...";
            this._ObjLibManagerMenuItem.Click += new System.EventHandler(this.ObjLibManagerMenuItem_Click);
            // 
            // ToolStripSeparator10
            // 
            this.ToolStripSeparator10.Name = "ToolStripSeparator10";
            this.ToolStripSeparator10.Size = new System.Drawing.Size(187, 6);
            // 
            // _CopyMenuItem
            // 
            this._CopyMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_CopyMenuItem.Image")));
            this._CopyMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._CopyMenuItem.Name = "_CopyMenuItem";
            this._CopyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this._CopyMenuItem.Size = new System.Drawing.Size(190, 22);
            this._CopyMenuItem.Text = "&Copy";
            this._CopyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // _PasteMenuItem
            // 
            this._PasteMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._PasteMenuItem.Name = "_PasteMenuItem";
            this._PasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this._PasteMenuItem.Size = new System.Drawing.Size(190, 22);
            this._PasteMenuItem.Text = "&Place";
            this._PasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // _DeleteMenuItem
            // 
            this._DeleteMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_DeleteMenuItem.Image")));
            this._DeleteMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this._DeleteMenuItem.Name = "_DeleteMenuItem";
            this._DeleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._DeleteMenuItem.Size = new System.Drawing.Size(190, 22);
            this._DeleteMenuItem.Text = "Delete";
            this._DeleteMenuItem.Click += new System.EventHandler(this.DeleteMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(187, 6);
            // 
            // _FindMenuItem
            // 
            this._FindMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_FindMenuItem.Image")));
            this._FindMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this._FindMenuItem.Name = "_FindMenuItem";
            this._FindMenuItem.Size = new System.Drawing.Size(190, 22);
            this._FindMenuItem.Text = "Find ...";
            this._FindMenuItem.Click += new System.EventHandler(this.FindMenuItem_Click);
            // 
            // ToolStripSeparator11
            // 
            this.ToolStripSeparator11.Name = "ToolStripSeparator11";
            this.ToolStripSeparator11.Size = new System.Drawing.Size(187, 6);
            // 
            // _TileServerMenuItem
            // 
            this._TileServerMenuItem.Name = "_TileServerMenuItem";
            this._TileServerMenuItem.Size = new System.Drawing.Size(190, 22);
            this._TileServerMenuItem.Text = "Tile Servers ...";
            this._TileServerMenuItem.Click += new System.EventHandler(this.TileServerMenuItem_Click);
            // 
            // _FSXSettingsMenuItem
            // 
            this._FSXSettingsMenuItem.Name = "_FSXSettingsMenuItem";
            this._FSXSettingsMenuItem.Size = new System.Drawing.Size(190, 22);
            this._FSXSettingsMenuItem.Text = "FSX Settings ...";
            this._FSXSettingsMenuItem.Click += new System.EventHandler(this.FSXSettingsMenuItem_Click);
            // 
            // _ObjectFoldersMenuItem
            // 
            this._ObjectFoldersMenuItem.Image = global::SBuilderXX.My.Resources.Resources.objects;
            this._ObjectFoldersMenuItem.Name = "_ObjectFoldersMenuItem";
            this._ObjectFoldersMenuItem.Size = new System.Drawing.Size(190, 22);
            this._ObjectFoldersMenuItem.Text = "Object Folders ...";
            this._ObjectFoldersMenuItem.Click += new System.EventHandler(this.ObjectFoldersMenuItem_Click);
            // 
            // _EditINIFileMenuItem
            // 
            this._EditINIFileMenuItem.Image = global::SBuilderXX.My.Resources.Resources.waters2;
            this._EditINIFileMenuItem.Name = "_EditINIFileMenuItem";
            this._EditINIFileMenuItem.Size = new System.Drawing.Size(190, 22);
            this._EditINIFileMenuItem.Text = "Edit INI file ...";
            this._EditINIFileMenuItem.Click += new System.EventHandler(this.EditINIFileMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._ShowToolbarMenuItem,
            this.ToolStripSeparator12,
            this._ShowBackgroundMenuItem,
            this.LODGridMenuItem,
            this.QMIDGridMenuItem,
            this.ToolStripSeparator14,
            this._GoToPositionMenuItem,
            this._ShowAircraftMenuItem,
            this._FlyAircraftToMenuItem,
            this.ToolStripSeparator13,
            this.ViewMapsMenuItem,
            this.ToolStripSeparator15,
            this._ViewAllMapsMenuItem,
            this._ViewAllLandsMenuItem,
            this._ViewAllWatersMenuItem,
            this._ViewAllLinesMenuItem,
            this._ViewAllPolysMenuItem,
            this._ViewAllObjectsMenuItem,
            this._ViewAllExcludesMenuItem,
            this.ToolStripSeparator17,
            this._ViewAllMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(44, 20);
            this.ViewMenuItem.Text = "&View";
            // 
            // _ShowToolbarMenuItem
            // 
            this._ShowToolbarMenuItem.Checked = true;
            this._ShowToolbarMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._ShowToolbarMenuItem.Name = "_ShowToolbarMenuItem";
            this._ShowToolbarMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ShowToolbarMenuItem.Text = "Show Toolbar";
            this._ShowToolbarMenuItem.Click += new System.EventHandler(this.ShowToolbarMenuItem_Click);
            // 
            // ToolStripSeparator12
            // 
            this.ToolStripSeparator12.Name = "ToolStripSeparator12";
            this.ToolStripSeparator12.Size = new System.Drawing.Size(186, 6);
            // 
            // _ShowBackgroundMenuItem
            // 
            this._ShowBackgroundMenuItem.Enabled = false;
            this._ShowBackgroundMenuItem.Name = "_ShowBackgroundMenuItem";
            this._ShowBackgroundMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._ShowBackgroundMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ShowBackgroundMenuItem.Text = "Show Background";
            this._ShowBackgroundMenuItem.Click += new System.EventHandler(this.ShowBackgroundMenuItem_Click);
            // 
            // LODGridMenuItem
            // 
            this.LODGridMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NoLODMenuItem,
            this._LOD0MenuItem,
            this._LOD1MenuItem,
            this._LOD2MenuItem,
            this._LOD3MenuItem,
            this._LOD4MenuItem,
            this._LOD5MenuItem,
            this._LOD6MenuItem,
            this._LOD7MenuItem,
            this._LOD8MenuItem,
            this._LOD9MenuItem,
            this._LOD10MenuItem,
            this._LOD11MenuItem,
            this._LOD12MenuItem,
            this._LOD13MenuItem,
            this._LOD14MenuItem,
            this._LOD15MenuItem,
            this._LOD16MenuItem,
            this._LOD17MenuItem,
            this._LOD18MenuItem,
            this._LOD19MenuItem,
            this._LOD20MenuItem,
            this._LOD21MenuItem,
            this._LOD22MenuItem,
            this._LOD23MenuItem,
            this._LOD24MenuItem,
            this._LOD25MenuItem,
            this._LOD26MenuItem,
            this._LOD27MenuItem});
            this.LODGridMenuItem.Image = global::SBuilderXX.My.Resources.Resources.Red_grid;
            this.LODGridMenuItem.Name = "LODGridMenuItem";
            this.LODGridMenuItem.Size = new System.Drawing.Size(189, 22);
            this.LODGridMenuItem.Text = "LOD Grid";
            // 
            // _NoLODMenuItem
            // 
            this._NoLODMenuItem.Name = "_NoLODMenuItem";
            this._NoLODMenuItem.Size = new System.Drawing.Size(115, 22);
            this._NoLODMenuItem.Text = "No Grid";
            this._NoLODMenuItem.Click += new System.EventHandler(this.NoLODMenuItem_Click);
            // 
            // _LOD0MenuItem
            // 
            this._LOD0MenuItem.Name = "_LOD0MenuItem";
            this._LOD0MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD0MenuItem.Text = "LOD 0";
            this._LOD0MenuItem.Click += new System.EventHandler(this.LOD0MenuItem_Click);
            // 
            // _LOD1MenuItem
            // 
            this._LOD1MenuItem.Name = "_LOD1MenuItem";
            this._LOD1MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD1MenuItem.Text = "LOD 1";
            this._LOD1MenuItem.Click += new System.EventHandler(this.LOD1MenuItem_Click);
            // 
            // _LOD2MenuItem
            // 
            this._LOD2MenuItem.Name = "_LOD2MenuItem";
            this._LOD2MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD2MenuItem.Text = "LOD 2";
            this._LOD2MenuItem.Click += new System.EventHandler(this.LOD2MenuItem_Click);
            // 
            // _LOD3MenuItem
            // 
            this._LOD3MenuItem.Name = "_LOD3MenuItem";
            this._LOD3MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD3MenuItem.Text = "LOD 3";
            this._LOD3MenuItem.Click += new System.EventHandler(this.LOD3MenuItem_Click);
            // 
            // _LOD4MenuItem
            // 
            this._LOD4MenuItem.Name = "_LOD4MenuItem";
            this._LOD4MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD4MenuItem.Text = "LOD 4";
            this._LOD4MenuItem.Click += new System.EventHandler(this.LOD4MenuItem_Click);
            // 
            // _LOD5MenuItem
            // 
            this._LOD5MenuItem.Name = "_LOD5MenuItem";
            this._LOD5MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD5MenuItem.Text = "LOD 5";
            this._LOD5MenuItem.Click += new System.EventHandler(this.LOD5MenuItem_Click);
            // 
            // _LOD6MenuItem
            // 
            this._LOD6MenuItem.Name = "_LOD6MenuItem";
            this._LOD6MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD6MenuItem.Text = "LOD 6";
            this._LOD6MenuItem.Click += new System.EventHandler(this.LOD6MenuItem_Click);
            // 
            // _LOD7MenuItem
            // 
            this._LOD7MenuItem.Name = "_LOD7MenuItem";
            this._LOD7MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD7MenuItem.Text = "LOD 7";
            this._LOD7MenuItem.Click += new System.EventHandler(this.LOD7MenuItem_Click);
            // 
            // _LOD8MenuItem
            // 
            this._LOD8MenuItem.Name = "_LOD8MenuItem";
            this._LOD8MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD8MenuItem.Text = "LOD 8";
            this._LOD8MenuItem.Click += new System.EventHandler(this.LOD8MenuItem_Click);
            // 
            // _LOD9MenuItem
            // 
            this._LOD9MenuItem.Name = "_LOD9MenuItem";
            this._LOD9MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD9MenuItem.Text = "LOD 9";
            this._LOD9MenuItem.Click += new System.EventHandler(this.LOD9MenuItem_Click);
            // 
            // _LOD10MenuItem
            // 
            this._LOD10MenuItem.Name = "_LOD10MenuItem";
            this._LOD10MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD10MenuItem.Text = "LOD 10";
            this._LOD10MenuItem.Click += new System.EventHandler(this.LOD10MenuItem_Click);
            // 
            // _LOD11MenuItem
            // 
            this._LOD11MenuItem.Name = "_LOD11MenuItem";
            this._LOD11MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD11MenuItem.Text = "LOD 11";
            this._LOD11MenuItem.Click += new System.EventHandler(this.LOD11MenuItem_Click);
            // 
            // _LOD12MenuItem
            // 
            this._LOD12MenuItem.Name = "_LOD12MenuItem";
            this._LOD12MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD12MenuItem.Text = "LOD 12";
            this._LOD12MenuItem.Click += new System.EventHandler(this.LOD12MenuItem_Click);
            // 
            // _LOD13MenuItem
            // 
            this._LOD13MenuItem.Name = "_LOD13MenuItem";
            this._LOD13MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD13MenuItem.Text = "LOD 13";
            this._LOD13MenuItem.Click += new System.EventHandler(this.LOD13MenuItem_Click);
            // 
            // _LOD14MenuItem
            // 
            this._LOD14MenuItem.Name = "_LOD14MenuItem";
            this._LOD14MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD14MenuItem.Text = "LOD 14";
            this._LOD14MenuItem.Click += new System.EventHandler(this.LOD14MenuItem_Click);
            // 
            // _LOD15MenuItem
            // 
            this._LOD15MenuItem.Name = "_LOD15MenuItem";
            this._LOD15MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD15MenuItem.Text = "LOD 15";
            this._LOD15MenuItem.Click += new System.EventHandler(this.LOD15MenuItem_Click);
            // 
            // _LOD16MenuItem
            // 
            this._LOD16MenuItem.Name = "_LOD16MenuItem";
            this._LOD16MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD16MenuItem.Text = "LOD 16";
            this._LOD16MenuItem.Click += new System.EventHandler(this.LOD16MenuItem_Click);
            // 
            // _LOD17MenuItem
            // 
            this._LOD17MenuItem.Name = "_LOD17MenuItem";
            this._LOD17MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD17MenuItem.Text = "LOD 17";
            this._LOD17MenuItem.Click += new System.EventHandler(this.LOD17MenuItem_Click);
            // 
            // _LOD18MenuItem
            // 
            this._LOD18MenuItem.Name = "_LOD18MenuItem";
            this._LOD18MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD18MenuItem.Text = "LOD 18";
            this._LOD18MenuItem.Click += new System.EventHandler(this.LOD18MenuItem_Click);
            // 
            // _LOD19MenuItem
            // 
            this._LOD19MenuItem.Name = "_LOD19MenuItem";
            this._LOD19MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD19MenuItem.Text = "LOD 19";
            this._LOD19MenuItem.Click += new System.EventHandler(this.LOD19MenuItem_Click);
            // 
            // _LOD20MenuItem
            // 
            this._LOD20MenuItem.Name = "_LOD20MenuItem";
            this._LOD20MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD20MenuItem.Text = "LOD 20";
            this._LOD20MenuItem.Click += new System.EventHandler(this.LOD20MenuItem_Click);
            // 
            // _LOD21MenuItem
            // 
            this._LOD21MenuItem.Name = "_LOD21MenuItem";
            this._LOD21MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD21MenuItem.Text = "LOD21";
            this._LOD21MenuItem.Click += new System.EventHandler(this.LOD21MenuItem_Click);
            // 
            // _LOD22MenuItem
            // 
            this._LOD22MenuItem.Name = "_LOD22MenuItem";
            this._LOD22MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD22MenuItem.Text = "LOD 22";
            this._LOD22MenuItem.Click += new System.EventHandler(this.LOD22MenuItem_Click);
            // 
            // _LOD23MenuItem
            // 
            this._LOD23MenuItem.Name = "_LOD23MenuItem";
            this._LOD23MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD23MenuItem.Text = "LOD 23";
            this._LOD23MenuItem.Click += new System.EventHandler(this.LOD23MenuItem_Click);
            // 
            // _LOD24MenuItem
            // 
            this._LOD24MenuItem.Name = "_LOD24MenuItem";
            this._LOD24MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD24MenuItem.Text = "LOD 24";
            this._LOD24MenuItem.Click += new System.EventHandler(this.LOD24MenuItem_Click);
            // 
            // _LOD25MenuItem
            // 
            this._LOD25MenuItem.Name = "_LOD25MenuItem";
            this._LOD25MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD25MenuItem.Text = "LOD 25";
            this._LOD25MenuItem.Click += new System.EventHandler(this.LOD25MenuItem_Click);
            // 
            // _LOD26MenuItem
            // 
            this._LOD26MenuItem.Name = "_LOD26MenuItem";
            this._LOD26MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD26MenuItem.Text = "LOD 26";
            this._LOD26MenuItem.Click += new System.EventHandler(this.LOD26MenuItem_Click);
            // 
            // _LOD27MenuItem
            // 
            this._LOD27MenuItem.Name = "_LOD27MenuItem";
            this._LOD27MenuItem.Size = new System.Drawing.Size(115, 22);
            this._LOD27MenuItem.Text = "LOD 27";
            this._LOD27MenuItem.Click += new System.EventHandler(this.LOD27MenuItem_Click);
            // 
            // QMIDGridMenuItem
            // 
            this.QMIDGridMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NoGridMenuItem,
            this._Level2MenuItem,
            this._Level3MenuItem,
            this._Level4MenuItem,
            this._Level5MenuItem,
            this._Level6MenuItem,
            this._Level7MenuItem,
            this._Level8MenuItem,
            this._Level9MenuItem,
            this._Level10MenuItem,
            this._Level11MenuItem,
            this._Level12MenuItem,
            this._Level13MenuItem,
            this._Level14MenuItem,
            this._Level15MenuItem,
            this._Level16MenuItem,
            this._Level17MenuItem,
            this._Level18MenuItem,
            this._Level19MenuItem,
            this._Level20MenuItem,
            this._Level21MenuItem,
            this._Level22MenuItem,
            this._Level23MenuItem,
            this._Level24MenuItem,
            this._Level25MenuItem,
            this._Level26MenuItem,
            this._Level27MenuItem,
            this._Level28MenuItem,
            this._Level29MenuItem});
            this.QMIDGridMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("QMIDGridMenuItem.Image")));
            this.QMIDGridMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.QMIDGridMenuItem.Name = "QMIDGridMenuItem";
            this.QMIDGridMenuItem.Size = new System.Drawing.Size(189, 22);
            this.QMIDGridMenuItem.Text = "QMID Grid";
            // 
            // _NoGridMenuItem
            // 
            this._NoGridMenuItem.Checked = true;
            this._NoGridMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this._NoGridMenuItem.Name = "_NoGridMenuItem";
            this._NoGridMenuItem.Size = new System.Drawing.Size(116, 22);
            this._NoGridMenuItem.Text = "No Grid";
            this._NoGridMenuItem.Click += new System.EventHandler(this.NoGridMenuItem_Click);
            // 
            // _Level2MenuItem
            // 
            this._Level2MenuItem.Name = "_Level2MenuItem";
            this._Level2MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level2MenuItem.Text = "Level 2";
            this._Level2MenuItem.Click += new System.EventHandler(this.Level2MenuItem_Click);
            // 
            // _Level3MenuItem
            // 
            this._Level3MenuItem.Name = "_Level3MenuItem";
            this._Level3MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level3MenuItem.Text = "Level 3";
            this._Level3MenuItem.Click += new System.EventHandler(this.Level3MenuItem_Click);
            // 
            // _Level4MenuItem
            // 
            this._Level4MenuItem.Name = "_Level4MenuItem";
            this._Level4MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level4MenuItem.Text = "Level 4";
            this._Level4MenuItem.Click += new System.EventHandler(this.Level4MenuItem_Click);
            // 
            // _Level5MenuItem
            // 
            this._Level5MenuItem.Name = "_Level5MenuItem";
            this._Level5MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level5MenuItem.Text = "Level 5";
            this._Level5MenuItem.Click += new System.EventHandler(this.Level5MenuItem_Click);
            // 
            // _Level6MenuItem
            // 
            this._Level6MenuItem.Name = "_Level6MenuItem";
            this._Level6MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level6MenuItem.Text = "Level 6";
            this._Level6MenuItem.Click += new System.EventHandler(this.Level6MenuItem_Click);
            // 
            // _Level7MenuItem
            // 
            this._Level7MenuItem.Name = "_Level7MenuItem";
            this._Level7MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level7MenuItem.Text = "Level 7";
            this._Level7MenuItem.Click += new System.EventHandler(this.Level7MenuItem_Click);
            // 
            // _Level8MenuItem
            // 
            this._Level8MenuItem.Name = "_Level8MenuItem";
            this._Level8MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level8MenuItem.Text = "Level 8";
            this._Level8MenuItem.Click += new System.EventHandler(this.Level8MenuItem_Click);
            // 
            // _Level9MenuItem
            // 
            this._Level9MenuItem.Name = "_Level9MenuItem";
            this._Level9MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level9MenuItem.Text = "Level 9";
            this._Level9MenuItem.Click += new System.EventHandler(this.Level9MenuItem_Click);
            // 
            // _Level10MenuItem
            // 
            this._Level10MenuItem.Name = "_Level10MenuItem";
            this._Level10MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level10MenuItem.Text = "Level 10";
            this._Level10MenuItem.Click += new System.EventHandler(this.Level10MenuItem_Click);
            // 
            // _Level11MenuItem
            // 
            this._Level11MenuItem.Name = "_Level11MenuItem";
            this._Level11MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level11MenuItem.Text = "Level 11";
            this._Level11MenuItem.Click += new System.EventHandler(this.Level11MenuItem_Click);
            // 
            // _Level12MenuItem
            // 
            this._Level12MenuItem.Name = "_Level12MenuItem";
            this._Level12MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level12MenuItem.Text = "Level 12";
            this._Level12MenuItem.Click += new System.EventHandler(this.Level12MenuItem_Click);
            // 
            // _Level13MenuItem
            // 
            this._Level13MenuItem.Name = "_Level13MenuItem";
            this._Level13MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level13MenuItem.Text = "Level 13";
            this._Level13MenuItem.Click += new System.EventHandler(this.Level13MenuItem_Click);
            // 
            // _Level14MenuItem
            // 
            this._Level14MenuItem.Name = "_Level14MenuItem";
            this._Level14MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level14MenuItem.Text = "Level 14";
            this._Level14MenuItem.Click += new System.EventHandler(this.Level14MenuItem_Click);
            // 
            // _Level15MenuItem
            // 
            this._Level15MenuItem.Name = "_Level15MenuItem";
            this._Level15MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level15MenuItem.Text = "Level 15";
            this._Level15MenuItem.Click += new System.EventHandler(this.Level15MenuItem_Click);
            // 
            // _Level16MenuItem
            // 
            this._Level16MenuItem.Name = "_Level16MenuItem";
            this._Level16MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level16MenuItem.Text = "Level 16";
            this._Level16MenuItem.Click += new System.EventHandler(this.Level16MenuItem_Click);
            // 
            // _Level17MenuItem
            // 
            this._Level17MenuItem.Name = "_Level17MenuItem";
            this._Level17MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level17MenuItem.Text = "Level 17";
            this._Level17MenuItem.Click += new System.EventHandler(this.Level17MenuItem_Click);
            // 
            // _Level18MenuItem
            // 
            this._Level18MenuItem.Name = "_Level18MenuItem";
            this._Level18MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level18MenuItem.Text = "Level 18";
            this._Level18MenuItem.Click += new System.EventHandler(this.Level18MenuItem_Click);
            // 
            // _Level19MenuItem
            // 
            this._Level19MenuItem.Name = "_Level19MenuItem";
            this._Level19MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level19MenuItem.Text = "Level 19";
            this._Level19MenuItem.Click += new System.EventHandler(this.Level19MenuItem_Click);
            // 
            // _Level20MenuItem
            // 
            this._Level20MenuItem.Name = "_Level20MenuItem";
            this._Level20MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level20MenuItem.Text = "Level 20";
            this._Level20MenuItem.Click += new System.EventHandler(this.Level20MenuItem_Click);
            // 
            // _Level21MenuItem
            // 
            this._Level21MenuItem.Name = "_Level21MenuItem";
            this._Level21MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level21MenuItem.Text = "Level 21";
            this._Level21MenuItem.Click += new System.EventHandler(this.Level21MenuItem_Click);
            // 
            // _Level22MenuItem
            // 
            this._Level22MenuItem.Name = "_Level22MenuItem";
            this._Level22MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level22MenuItem.Text = "Level 22";
            this._Level22MenuItem.Click += new System.EventHandler(this.Level22MenuItem_Click);
            // 
            // _Level23MenuItem
            // 
            this._Level23MenuItem.Name = "_Level23MenuItem";
            this._Level23MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level23MenuItem.Text = "Level 23";
            this._Level23MenuItem.Click += new System.EventHandler(this.Level23MenuItem_Click);
            // 
            // _Level24MenuItem
            // 
            this._Level24MenuItem.Name = "_Level24MenuItem";
            this._Level24MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level24MenuItem.Text = "Level 24";
            this._Level24MenuItem.Click += new System.EventHandler(this.Level24MenuItem_Click);
            // 
            // _Level25MenuItem
            // 
            this._Level25MenuItem.Name = "_Level25MenuItem";
            this._Level25MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level25MenuItem.Text = "Level 25";
            this._Level25MenuItem.Click += new System.EventHandler(this.Level25MenuItem_Click);
            // 
            // _Level26MenuItem
            // 
            this._Level26MenuItem.Name = "_Level26MenuItem";
            this._Level26MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level26MenuItem.Text = "Level 26";
            this._Level26MenuItem.Click += new System.EventHandler(this.Level26MenuItem_Click);
            // 
            // _Level27MenuItem
            // 
            this._Level27MenuItem.Name = "_Level27MenuItem";
            this._Level27MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level27MenuItem.Text = "Level 27";
            this._Level27MenuItem.Click += new System.EventHandler(this.Level27MenuItem_Click);
            // 
            // _Level28MenuItem
            // 
            this._Level28MenuItem.Name = "_Level28MenuItem";
            this._Level28MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level28MenuItem.Text = "Level 28";
            this._Level28MenuItem.Click += new System.EventHandler(this.Level28MenuItem_Click);
            // 
            // _Level29MenuItem
            // 
            this._Level29MenuItem.Name = "_Level29MenuItem";
            this._Level29MenuItem.Size = new System.Drawing.Size(116, 22);
            this._Level29MenuItem.Text = "Level 29";
            this._Level29MenuItem.Click += new System.EventHandler(this.Level29MenuItem_Click);
            // 
            // ToolStripSeparator14
            // 
            this.ToolStripSeparator14.Name = "ToolStripSeparator14";
            this.ToolStripSeparator14.Size = new System.Drawing.Size(186, 6);
            // 
            // _GoToPositionMenuItem
            // 
            this._GoToPositionMenuItem.Name = "_GoToPositionMenuItem";
            this._GoToPositionMenuItem.Size = new System.Drawing.Size(189, 22);
            this._GoToPositionMenuItem.Text = "Go to Position ...";
            this._GoToPositionMenuItem.Click += new System.EventHandler(this.GoToPositionMenuItem_Click);
            // 
            // _ShowAircraftMenuItem
            // 
            this._ShowAircraftMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_ShowAircraftMenuItem.Image")));
            this._ShowAircraftMenuItem.Name = "_ShowAircraftMenuItem";
            this._ShowAircraftMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ShowAircraftMenuItem.Text = "Show Aircraft";
            this._ShowAircraftMenuItem.Click += new System.EventHandler(this.ShowAircraftMenuItem_Click);
            // 
            // _FlyAircraftToMenuItem
            // 
            this._FlyAircraftToMenuItem.Name = "_FlyAircraftToMenuItem";
            this._FlyAircraftToMenuItem.Size = new System.Drawing.Size(189, 22);
            this._FlyAircraftToMenuItem.Text = "Fly Aircraft to ...";
            this._FlyAircraftToMenuItem.Click += new System.EventHandler(this.FlyAircraftToMenuItem_Click);
            // 
            // ToolStripSeparator13
            // 
            this.ToolStripSeparator13.Name = "ToolStripSeparator13";
            this.ToolStripSeparator13.Size = new System.Drawing.Size(186, 6);
            // 
            // ViewMapsMenuItem
            // 
            this.ViewMapsMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ViewMapsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._SummerMapMenuItem,
            this._SpringMapMenuItem,
            this._FallMapMenuItem,
            this._WinterMapMenuItem,
            this._HardWinterMapMenuItem,
            this._NightMapMenuItem});
            this.ViewMapsMenuItem.Image = global::SBuilderXX.My.Resources.Resources.maps;
            this.ViewMapsMenuItem.Name = "ViewMapsMenuItem";
            this.ViewMapsMenuItem.Size = new System.Drawing.Size(189, 22);
            this.ViewMapsMenuItem.Text = "Maps";
            // 
            // _SummerMapMenuItem
            // 
            this._SummerMapMenuItem.Name = "_SummerMapMenuItem";
            this._SummerMapMenuItem.Size = new System.Drawing.Size(138, 22);
            this._SummerMapMenuItem.Text = "Summer";
            this._SummerMapMenuItem.Click += new System.EventHandler(this.SummerMapMenuItem_Click);
            // 
            // _SpringMapMenuItem
            // 
            this._SpringMapMenuItem.Name = "_SpringMapMenuItem";
            this._SpringMapMenuItem.Size = new System.Drawing.Size(138, 22);
            this._SpringMapMenuItem.Text = "Spring";
            this._SpringMapMenuItem.Click += new System.EventHandler(this.SpringMapMenuItem_Click);
            // 
            // _FallMapMenuItem
            // 
            this._FallMapMenuItem.Name = "_FallMapMenuItem";
            this._FallMapMenuItem.Size = new System.Drawing.Size(138, 22);
            this._FallMapMenuItem.Text = "Fall";
            this._FallMapMenuItem.Click += new System.EventHandler(this.FallMapMenuItem_Click);
            // 
            // _WinterMapMenuItem
            // 
            this._WinterMapMenuItem.Name = "_WinterMapMenuItem";
            this._WinterMapMenuItem.Size = new System.Drawing.Size(138, 22);
            this._WinterMapMenuItem.Text = "Winter";
            this._WinterMapMenuItem.Click += new System.EventHandler(this.WinterMapMenuItem_Click);
            // 
            // _HardWinterMapMenuItem
            // 
            this._HardWinterMapMenuItem.Name = "_HardWinterMapMenuItem";
            this._HardWinterMapMenuItem.Size = new System.Drawing.Size(138, 22);
            this._HardWinterMapMenuItem.Text = "Hard Winter";
            this._HardWinterMapMenuItem.Click += new System.EventHandler(this.HardWinterMapMenuItem_Click);
            // 
            // _NightMapMenuItem
            // 
            this._NightMapMenuItem.Name = "_NightMapMenuItem";
            this._NightMapMenuItem.Size = new System.Drawing.Size(138, 22);
            this._NightMapMenuItem.Text = "Night";
            this._NightMapMenuItem.Click += new System.EventHandler(this.NightMapMenuItem_Click);
            // 
            // ToolStripSeparator15
            // 
            this.ToolStripSeparator15.Name = "ToolStripSeparator15";
            this.ToolStripSeparator15.Size = new System.Drawing.Size(186, 6);
            // 
            // _ViewAllMapsMenuItem
            // 
            this._ViewAllMapsMenuItem.Image = global::SBuilderXX.My.Resources.Resources.insertmap;
            this._ViewAllMapsMenuItem.Name = "_ViewAllMapsMenuItem";
            this._ViewAllMapsMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllMapsMenuItem.Text = "All Maps";
            this._ViewAllMapsMenuItem.Click += new System.EventHandler(this.ViewAllMapsMenuItem_Click);
            // 
            // _ViewAllLandsMenuItem
            // 
            this._ViewAllLandsMenuItem.Image = global::SBuilderXX.My.Resources.Resources.lands;
            this._ViewAllLandsMenuItem.Name = "_ViewAllLandsMenuItem";
            this._ViewAllLandsMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllLandsMenuItem.Text = "All Land Tiles";
            this._ViewAllLandsMenuItem.Click += new System.EventHandler(this.ViewAllLandsMenuItem_Click);
            // 
            // _ViewAllWatersMenuItem
            // 
            this._ViewAllWatersMenuItem.Image = global::SBuilderXX.My.Resources.Resources.waters;
            this._ViewAllWatersMenuItem.Name = "_ViewAllWatersMenuItem";
            this._ViewAllWatersMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllWatersMenuItem.Text = "All Water Tiles";
            this._ViewAllWatersMenuItem.Click += new System.EventHandler(this.ViewAllWatersMenuItem_Click);
            // 
            // _ViewAllLinesMenuItem
            // 
            this._ViewAllLinesMenuItem.Image = global::SBuilderXX.My.Resources.Resources.lines4;
            this._ViewAllLinesMenuItem.Name = "_ViewAllLinesMenuItem";
            this._ViewAllLinesMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllLinesMenuItem.Text = "All Lines";
            this._ViewAllLinesMenuItem.Click += new System.EventHandler(this.ViewAllLinesMenuItem_Click);
            // 
            // _ViewAllPolysMenuItem
            // 
            this._ViewAllPolysMenuItem.Image = global::SBuilderXX.My.Resources.Resources.polys;
            this._ViewAllPolysMenuItem.Name = "_ViewAllPolysMenuItem";
            this._ViewAllPolysMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllPolysMenuItem.Text = "All Polygons";
            this._ViewAllPolysMenuItem.Click += new System.EventHandler(this.ViewAllPolysMenuItem_Click);
            // 
            // _ViewAllObjectsMenuItem
            // 
            this._ViewAllObjectsMenuItem.Image = global::SBuilderXX.My.Resources.Resources.objects;
            this._ViewAllObjectsMenuItem.Name = "_ViewAllObjectsMenuItem";
            this._ViewAllObjectsMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllObjectsMenuItem.Text = "All Objects";
            this._ViewAllObjectsMenuItem.Click += new System.EventHandler(this.ViewAllObjectsMenuItem_Click);
            // 
            // _ViewAllExcludesMenuItem
            // 
            this._ViewAllExcludesMenuItem.Image = global::SBuilderXX.My.Resources.Resources.delete;
            this._ViewAllExcludesMenuItem.Name = "_ViewAllExcludesMenuItem";
            this._ViewAllExcludesMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllExcludesMenuItem.Text = "All Excludes";
            this._ViewAllExcludesMenuItem.Click += new System.EventHandler(this.ViewAllExcludesMenuItem_Click);
            // 
            // ToolStripSeparator17
            // 
            this.ToolStripSeparator17.Name = "ToolStripSeparator17";
            this.ToolStripSeparator17.Size = new System.Drawing.Size(186, 6);
            // 
            // _ViewAllMenuItem
            // 
            this._ViewAllMenuItem.Name = "_ViewAllMenuItem";
            this._ViewAllMenuItem.Size = new System.Drawing.Size(189, 22);
            this._ViewAllMenuItem.Text = "View All";
            this._ViewAllMenuItem.Click += new System.EventHandler(this.ViewAllMenuItem_Click);
            // 
            // SelectMenuItem
            // 
            this.SelectMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._SelectAllMapsMenuItem,
            this.ToolStripSeparator24,
            this._SelectAllLandsMenuItem,
            this._SelectAllWatersMenuItem,
            this._SelectAllLinesMenuItem,
            this._SelectAllPolysMenuItem,
            this._SelectAllObjectsMenuItem,
            this._SelectAllExcludesMenuItem,
            this.ToolStripSeparator16,
            this._InvertSelectionMenuItem,
            this._SelectAllMenuItem});
            this.SelectMenuItem.Name = "SelectMenuItem";
            this.SelectMenuItem.Size = new System.Drawing.Size(50, 20);
            this.SelectMenuItem.Text = "&Select";
            // 
            // _SelectAllMapsMenuItem
            // 
            this._SelectAllMapsMenuItem.Image = global::SBuilderXX.My.Resources.Resources.insertmap1;
            this._SelectAllMapsMenuItem.Name = "_SelectAllMapsMenuItem";
            this._SelectAllMapsMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllMapsMenuItem.Text = "All Maps";
            this._SelectAllMapsMenuItem.Click += new System.EventHandler(this.SelectAllMapsMenuItem_Click);
            // 
            // ToolStripSeparator24
            // 
            this.ToolStripSeparator24.Name = "ToolStripSeparator24";
            this.ToolStripSeparator24.Size = new System.Drawing.Size(161, 6);
            // 
            // _SelectAllLandsMenuItem
            // 
            this._SelectAllLandsMenuItem.Image = global::SBuilderXX.My.Resources.Resources.lands1;
            this._SelectAllLandsMenuItem.Name = "_SelectAllLandsMenuItem";
            this._SelectAllLandsMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllLandsMenuItem.Text = "All Land Tiles";
            this._SelectAllLandsMenuItem.Click += new System.EventHandler(this.SelectAllLandsMenuItem_Click);
            // 
            // _SelectAllWatersMenuItem
            // 
            this._SelectAllWatersMenuItem.Image = global::SBuilderXX.My.Resources.Resources.waters1;
            this._SelectAllWatersMenuItem.Name = "_SelectAllWatersMenuItem";
            this._SelectAllWatersMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllWatersMenuItem.Text = "All Water Tiles";
            this._SelectAllWatersMenuItem.Click += new System.EventHandler(this.SelectAllWatersMenuItem_Click);
            // 
            // _SelectAllLinesMenuItem
            // 
            this._SelectAllLinesMenuItem.Image = global::SBuilderXX.My.Resources.Resources.lines5;
            this._SelectAllLinesMenuItem.Name = "_SelectAllLinesMenuItem";
            this._SelectAllLinesMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllLinesMenuItem.Text = "All Lines";
            this._SelectAllLinesMenuItem.Click += new System.EventHandler(this.SelectAllLinesMenuItem_Click);
            // 
            // _SelectAllPolysMenuItem
            // 
            this._SelectAllPolysMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._SelectAllPolysMenuItem.Image = global::SBuilderXX.My.Resources.Resources.polys1;
            this._SelectAllPolysMenuItem.Name = "_SelectAllPolysMenuItem";
            this._SelectAllPolysMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllPolysMenuItem.Text = "All Polygons";
            this._SelectAllPolysMenuItem.Click += new System.EventHandler(this.SelectAllPolysMenuItem_Click);
            // 
            // _SelectAllObjectsMenuItem
            // 
            this._SelectAllObjectsMenuItem.Image = global::SBuilderXX.My.Resources.Resources.objects1;
            this._SelectAllObjectsMenuItem.Name = "_SelectAllObjectsMenuItem";
            this._SelectAllObjectsMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllObjectsMenuItem.Text = "All Objects";
            this._SelectAllObjectsMenuItem.Click += new System.EventHandler(this.SelectAllObjectsMenuItem_Click);
            // 
            // _SelectAllExcludesMenuItem
            // 
            this._SelectAllExcludesMenuItem.Image = global::SBuilderXX.My.Resources.Resources.delete1;
            this._SelectAllExcludesMenuItem.Name = "_SelectAllExcludesMenuItem";
            this._SelectAllExcludesMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllExcludesMenuItem.Text = "All Excludes";
            this._SelectAllExcludesMenuItem.Click += new System.EventHandler(this.SelectAllExcludesMenuItem_Click);
            // 
            // ToolStripSeparator16
            // 
            this.ToolStripSeparator16.Name = "ToolStripSeparator16";
            this.ToolStripSeparator16.Size = new System.Drawing.Size(161, 6);
            // 
            // _InvertSelectionMenuItem
            // 
            this._InvertSelectionMenuItem.Name = "_InvertSelectionMenuItem";
            this._InvertSelectionMenuItem.Size = new System.Drawing.Size(164, 22);
            this._InvertSelectionMenuItem.Text = "Invert Selection";
            this._InvertSelectionMenuItem.Click += new System.EventHandler(this.InvertSelectionMenuItem_Click);
            // 
            // _SelectAllMenuItem
            // 
            this._SelectAllMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._SelectAllMenuItem.Name = "_SelectAllMenuItem";
            this._SelectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this._SelectAllMenuItem.Size = new System.Drawing.Size(164, 22);
            this._SelectAllMenuItem.Text = "Select &All";
            this._SelectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
            // 
            // ToolsMenuItem
            // 
            this.ToolsMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.ToolsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._PointerMenuItem,
            this._ZoomMenuItem,
            this.ToolStripSeparator20,
            this._LandMenuItem,
            this._WaterMenuItem,
            this._LineMenuItem,
            this._PolyMenuItem,
            this._ObjectMenuItem,
            this._ExcludeMenuItem});
            this.ToolsMenuItem.Name = "ToolsMenuItem";
            this.ToolsMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ToolsMenuItem.Text = "&Tools";
            // 
            // _PointerMenuItem
            // 
            this._PointerMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_PointerMenuItem.Image")));
            this._PointerMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this._PointerMenuItem.Name = "_PointerMenuItem";
            this._PointerMenuItem.Size = new System.Drawing.Size(118, 22);
            this._PointerMenuItem.Text = "Pointer";
            this._PointerMenuItem.Click += new System.EventHandler(this.PointerMenuItem_Click);
            // 
            // _ZoomMenuItem
            // 
            this._ZoomMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("_ZoomMenuItem.Image")));
            this._ZoomMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this._ZoomMenuItem.Name = "_ZoomMenuItem";
            this._ZoomMenuItem.Size = new System.Drawing.Size(118, 22);
            this._ZoomMenuItem.Text = "Zoom";
            this._ZoomMenuItem.Click += new System.EventHandler(this.ZoomMenuItem_Click);
            // 
            // ToolStripSeparator20
            // 
            this.ToolStripSeparator20.Name = "ToolStripSeparator20";
            this.ToolStripSeparator20.Size = new System.Drawing.Size(115, 6);
            // 
            // _LandMenuItem
            // 
            this._LandMenuItem.Image = global::SBuilderXX.My.Resources.Resources.lands2;
            this._LandMenuItem.Name = "_LandMenuItem";
            this._LandMenuItem.Size = new System.Drawing.Size(118, 22);
            this._LandMenuItem.Text = "Land";
            this._LandMenuItem.Click += new System.EventHandler(this.LandMenuItem_Click);
            // 
            // _WaterMenuItem
            // 
            this._WaterMenuItem.Image = global::SBuilderXX.My.Resources.Resources.waters2;
            this._WaterMenuItem.Name = "_WaterMenuItem";
            this._WaterMenuItem.Size = new System.Drawing.Size(118, 22);
            this._WaterMenuItem.Text = "Water";
            this._WaterMenuItem.Click += new System.EventHandler(this.WaterMenuItem_Click);
            // 
            // _LineMenuItem
            // 
            this._LineMenuItem.Image = global::SBuilderXX.My.Resources.Resources.lines6;
            this._LineMenuItem.Name = "_LineMenuItem";
            this._LineMenuItem.Size = new System.Drawing.Size(118, 22);
            this._LineMenuItem.Text = "Line";
            this._LineMenuItem.Click += new System.EventHandler(this.LineMenuItem_Click);
            // 
            // _PolyMenuItem
            // 
            this._PolyMenuItem.Image = global::SBuilderXX.My.Resources.Resources.polys2;
            this._PolyMenuItem.Name = "_PolyMenuItem";
            this._PolyMenuItem.Size = new System.Drawing.Size(118, 22);
            this._PolyMenuItem.Text = "Polygon";
            this._PolyMenuItem.Click += new System.EventHandler(this.PolyMenuItem_Click);
            // 
            // _ObjectMenuItem
            // 
            this._ObjectMenuItem.Image = global::SBuilderXX.My.Resources.Resources.objects2;
            this._ObjectMenuItem.Name = "_ObjectMenuItem";
            this._ObjectMenuItem.Size = new System.Drawing.Size(118, 22);
            this._ObjectMenuItem.Text = "Object";
            this._ObjectMenuItem.Click += new System.EventHandler(this.ObjectMenuItem_Click);
            // 
            // _ExcludeMenuItem
            // 
            this._ExcludeMenuItem.Image = global::SBuilderXX.My.Resources.Resources.delete2;
            this._ExcludeMenuItem.Name = "_ExcludeMenuItem";
            this._ExcludeMenuItem.Size = new System.Drawing.Size(118, 22);
            this._ExcludeMenuItem.Text = "Exclude";
            this._ExcludeMenuItem.Click += new System.EventHandler(this.ExcludeMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._SbuilderHelpMenuItem,
            this._WhatIsNewMenuItem,
            this._ForumMenuItem,
            this._GetMapMenuItem,
            this._AboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "&Help";
            // 
            // _SbuilderHelpMenuItem
            // 
            this._SbuilderHelpMenuItem.Name = "_SbuilderHelpMenuItem";
            this._SbuilderHelpMenuItem.Size = new System.Drawing.Size(195, 22);
            this._SbuilderHelpMenuItem.Text = "SBuilderXX Help";
            this._SbuilderHelpMenuItem.Click += new System.EventHandler(this.SbuilderHelpMenuItem_Click);
            // 
            // _WhatIsNewMenuItem
            // 
            this._WhatIsNewMenuItem.Name = "_WhatIsNewMenuItem";
            this._WhatIsNewMenuItem.Size = new System.Drawing.Size(195, 22);
            this._WhatIsNewMenuItem.Text = "What is New";
            this._WhatIsNewMenuItem.Click += new System.EventHandler(this.WhatIsNewMenuItem_Click);
            // 
            // _ForumMenuItem
            // 
            this._ForumMenuItem.Name = "_ForumMenuItem";
            this._ForumMenuItem.Size = new System.Drawing.Size(195, 22);
            this._ForumMenuItem.Text = "SBuilderXX Forum";
            this._ForumMenuItem.Click += new System.EventHandler(this.ForumMenuItem_Click);
            // 
            // _GetMapMenuItem
            // 
            this._GetMapMenuItem.Name = "_GetMapMenuItem";
            this._GetMapMenuItem.Size = new System.Drawing.Size(195, 22);
            this._GetMapMenuItem.Text = "Get Map from the WEB";
            this._GetMapMenuItem.Click += new System.EventHandler(this.GetMapMenuItem_Click);
            // 
            // _AboutMenuItem
            // 
            this._AboutMenuItem.Name = "_AboutMenuItem";
            this._AboutMenuItem.Size = new System.Drawing.Size(195, 22);
            this._AboutMenuItem.Text = "&About";
            this._AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // FlyAircraftToToolStripMenuItem
            // 
            this.FlyAircraftToToolStripMenuItem.Name = "FlyAircraftToToolStripMenuItem";
            this.FlyAircraftToToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.FlyAircraftToToolStripMenuItem.Text = "Fly Aircraft to ...";
            // 
            // StatusZoom
            // 
            this.StatusZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.StatusZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StatusZoom.Name = "StatusZoom";
            this.StatusZoom.Size = new System.Drawing.Size(50, 17);
            this.StatusZoom.Text = "Zoom =";
            // 
            // StatusLat
            // 
            this.StatusLat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.StatusLat.Name = "StatusLat";
            this.StatusLat.Size = new System.Drawing.Size(46, 17);
            this.StatusLat.Text = "   Lat = ";
            // 
            // StatusLon
            // 
            this.StatusLon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.StatusLon.Name = "StatusLon";
            this.StatusLon.Size = new System.Drawing.Size(47, 17);
            this.StatusLon.Text = "  Lon = ";
            // 
            // ToolStripStatusLabel1
            // 
            this.ToolStripStatusLabel1.IsLink = true;
            this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
            this.ToolStripStatusLabel1.Size = new System.Drawing.Size(147, 17);
            this.ToolStripStatusLabel1.Spring = true;
            // 
            // StatusDir
            // 
            this.StatusDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.StatusDir.Name = "StatusDir";
            this.StatusDir.Size = new System.Drawing.Size(42, 17);
            this.StatusDir.Text = "   Dir =";
            // 
            // ToolStripStatusLabel2
            // 
            this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
            this.ToolStripStatusLabel2.Size = new System.Drawing.Size(147, 17);
            this.ToolStripStatusLabel2.Spring = true;
            // 
            // StatusQMID
            // 
            this.StatusQMID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.StatusQMID.Name = "StatusQMID";
            this.StatusQMID.Size = new System.Drawing.Size(49, 17);
            this.StatusQMID.Text = "QMID =";
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusZoom,
            this.StatusLat,
            this.StatusLon,
            this.ToolStripStatusLabel3,
            this.StatusTile,
            this.ToolStripStatusLabel1,
            this.StatusDir,
            this.ToolStripStatusLabel2,
            this.StatusQMID});
            this.StatusStrip.Location = new System.Drawing.Point(0, 444);
            this.StatusStrip.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(692, 22);
            this.StatusStrip.TabIndex = 2;
            // 
            // ToolStripStatusLabel3
            // 
            this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
            this.ToolStripStatusLabel3.Size = new System.Drawing.Size(147, 17);
            this.ToolStripStatusLabel3.Spring = true;
            // 
            // StatusTile
            // 
            this.StatusTile.Name = "StatusTile";
            this.StatusTile.Size = new System.Drawing.Size(0, 17);
            // 
            // _Timer1
            // 
            this._Timer1.Enabled = true;
            this._Timer1.SynchronizingObject = this;
            this._Timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1_Elapsed);
            // 
            // OpenFileDialog1
            // 
            this.OpenFileDialog1.FileName = "OpenFileDialog1";
            // 
            // TextBoxMeasure
            // 
            this.TextBoxMeasure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMeasure.Location = new System.Drawing.Point(551, 0);
            this.TextBoxMeasure.Multiline = true;
            this.TextBoxMeasure.Name = "TextBoxMeasure";
            this.TextBoxMeasure.Size = new System.Drawing.Size(150, 90);
            this.TextBoxMeasure.TabIndex = 3;
            this.TextBoxMeasure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxMeasure.Visible = false;
            // 
            // PopUpMenu
            // 
            this.PopUpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NamePopUPMenu,
            this.Sep1PopUPMenu,
            this._CenterPopUPMenu,
            this._FlyToPopUPMenu,
            this._PointFromAircraftPopUpMenu,
            this._ZoomInPopUPMenu,
            this._ZoomOutPopUPMenu,
            this._SaveBackGroundPopUpMenu,
            this._TilePathToClipboardPopUpMenu,
            this.Sep2PopUPMenu,
            this._DeletePopUPMenu,
            this._JoinAllPopUPMenu,
            this._SetWidthPopUpMenu,
            this._SetAltitudePopUpMenu,
            this._SetTransparencyPopUpMenu,
            this._MakeLinePopUPMenu,
            this._SnapQMIDPopUPMenu,
            this._FillQMIDPopUpMenu,
            this._SliceQMIDPopUpMenu,
            this._MakePolyPopUPMenu,
            this._ConvertToPolyPopUpMenu,
            this._SmoothPopUPMenu,
            this._OuterPopUpMenu,
            this._HolePopUpMenu,
            this._SamplePopUPMenu,
            this._ManualCheckPopUPMenu,
            this._CalibratePopUPMenu,
            this.Sep3PopUPMenu,
            this._PropertiesPopUPMenu});
            this.PopUpMenu.Name = "MapPopUp";
            this.PopUpMenu.Size = new System.Drawing.Size(189, 594);
            // 
            // NamePopUPMenu
            // 
            this.NamePopUPMenu.Name = "NamePopUPMenu";
            this.NamePopUPMenu.Size = new System.Drawing.Size(188, 22);
            this.NamePopUPMenu.Text = "Name";
            // 
            // Sep1PopUPMenu
            // 
            this.Sep1PopUPMenu.Name = "Sep1PopUPMenu";
            this.Sep1PopUPMenu.Size = new System.Drawing.Size(185, 6);
            // 
            // _CenterPopUPMenu
            // 
            this._CenterPopUPMenu.Name = "_CenterPopUPMenu";
            this._CenterPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._CenterPopUPMenu.Text = "Center";
            this._CenterPopUPMenu.Click += new System.EventHandler(this.CenterPopUPMenu_Click);
            // 
            // _FlyToPopUPMenu
            // 
            this._FlyToPopUPMenu.Name = "_FlyToPopUPMenu";
            this._FlyToPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._FlyToPopUPMenu.Text = "Fly Aircraft Here";
            this._FlyToPopUPMenu.Click += new System.EventHandler(this.FlyToPopUPMenu_Click);
            // 
            // _PointFromAircraftPopUpMenu
            // 
            this._PointFromAircraftPopUpMenu.Name = "_PointFromAircraftPopUpMenu";
            this._PointFromAircraftPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._PointFromAircraftPopUpMenu.Text = "Point from Aircraft";
            this._PointFromAircraftPopUpMenu.Click += new System.EventHandler(this.PointFromAircraftPopUpMenu_Click);
            // 
            // _ZoomInPopUPMenu
            // 
            this._ZoomInPopUPMenu.Image = global::SBuilderXX.My.Resources.Resources.ZoomIn;
            this._ZoomInPopUPMenu.Name = "_ZoomInPopUPMenu";
            this._ZoomInPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._ZoomInPopUPMenu.Text = "Zoom In";
            this._ZoomInPopUPMenu.Click += new System.EventHandler(this.ZoomInPopUPMenu_Click);
            // 
            // _ZoomOutPopUPMenu
            // 
            this._ZoomOutPopUPMenu.Image = global::SBuilderXX.My.Resources.Resources.ZoomOut;
            this._ZoomOutPopUPMenu.Name = "_ZoomOutPopUPMenu";
            this._ZoomOutPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._ZoomOutPopUPMenu.Text = "Zoom Out";
            this._ZoomOutPopUPMenu.Click += new System.EventHandler(this.ZoomOutPopUPMenu_Click);
            // 
            // _SaveBackGroundPopUpMenu
            // 
            this._SaveBackGroundPopUpMenu.Name = "_SaveBackGroundPopUpMenu";
            this._SaveBackGroundPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._SaveBackGroundPopUpMenu.Text = "Background ...";
            this._SaveBackGroundPopUpMenu.Click += new System.EventHandler(this.SaveBackGroundPopUpMenu_Click);
            // 
            // _TilePathToClipboardPopUpMenu
            // 
            this._TilePathToClipboardPopUpMenu.Name = "_TilePathToClipboardPopUpMenu";
            this._TilePathToClipboardPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._TilePathToClipboardPopUpMenu.Text = "Tile Path to ClipBoard";
            this._TilePathToClipboardPopUpMenu.Click += new System.EventHandler(this.TilePathToClipboardPopUpMenu_Click);
            // 
            // Sep2PopUPMenu
            // 
            this.Sep2PopUPMenu.Name = "Sep2PopUPMenu";
            this.Sep2PopUPMenu.Size = new System.Drawing.Size(185, 6);
            // 
            // _DeletePopUPMenu
            // 
            this._DeletePopUPMenu.Image = ((System.Drawing.Image)(resources.GetObject("_DeletePopUPMenu.Image")));
            this._DeletePopUPMenu.Name = "_DeletePopUPMenu";
            this._DeletePopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._DeletePopUPMenu.Text = "Delete";
            this._DeletePopUPMenu.Click += new System.EventHandler(this.DeletePopUPMenu_Click);
            // 
            // _JoinAllPopUPMenu
            // 
            this._JoinAllPopUPMenu.Name = "_JoinAllPopUPMenu";
            this._JoinAllPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._JoinAllPopUPMenu.Text = "Join All ...";
            this._JoinAllPopUPMenu.Click += new System.EventHandler(this.JoinAllPopUPMenu_Click);
            // 
            // _SetWidthPopUpMenu
            // 
            this._SetWidthPopUpMenu.Name = "_SetWidthPopUpMenu";
            this._SetWidthPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._SetWidthPopUpMenu.Text = "Set Width ...";
            this._SetWidthPopUpMenu.Click += new System.EventHandler(this.SetWidthPopUpMenu_Click);
            // 
            // _SetAltitudePopUpMenu
            // 
            this._SetAltitudePopUpMenu.Name = "_SetAltitudePopUpMenu";
            this._SetAltitudePopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._SetAltitudePopUpMenu.Text = "Set Altitude ...";
            this._SetAltitudePopUpMenu.Click += new System.EventHandler(this.SetAltitudePopUpMenu_Click);
            // 
            // _SetTransparencyPopUpMenu
            // 
            this._SetTransparencyPopUpMenu.Image = ((System.Drawing.Image)(resources.GetObject("_SetTransparencyPopUpMenu.Image")));
            this._SetTransparencyPopUpMenu.Name = "_SetTransparencyPopUpMenu";
            this._SetTransparencyPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._SetTransparencyPopUpMenu.Text = "Set Transparency ...";
            this._SetTransparencyPopUpMenu.Click += new System.EventHandler(this.SetTransparencyPopUpMenu_Click);
            // 
            // _MakeLinePopUPMenu
            // 
            this._MakeLinePopUPMenu.Name = "_MakeLinePopUPMenu";
            this._MakeLinePopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._MakeLinePopUPMenu.Text = "Make Line";
            this._MakeLinePopUPMenu.Click += new System.EventHandler(this.MakeLinePopUPMenu_Click);
            // 
            // _SnapQMIDPopUPMenu
            // 
            this._SnapQMIDPopUPMenu.Name = "_SnapQMIDPopUPMenu";
            this._SnapQMIDPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._SnapQMIDPopUPMenu.Text = "Snap QMID";
            this._SnapQMIDPopUPMenu.Click += new System.EventHandler(this.SnapQMIDPopUPMenu_Click);
            // 
            // _FillQMIDPopUpMenu
            // 
            this._FillQMIDPopUpMenu.Name = "_FillQMIDPopUpMenu";
            this._FillQMIDPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._FillQMIDPopUpMenu.Text = "Fill QMID";
            this._FillQMIDPopUpMenu.Click += new System.EventHandler(this.FillQMIDPopUpMenu_Click);
            // 
            // _SliceQMIDPopUpMenu
            // 
            this._SliceQMIDPopUpMenu.Name = "_SliceQMIDPopUpMenu";
            this._SliceQMIDPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._SliceQMIDPopUpMenu.Text = "Slice QMID";
            this._SliceQMIDPopUpMenu.Click += new System.EventHandler(this.SliceQMIDPopUpMenu_Click);
            // 
            // _MakePolyPopUPMenu
            // 
            this._MakePolyPopUPMenu.Name = "_MakePolyPopUPMenu";
            this._MakePolyPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._MakePolyPopUPMenu.Text = "Make Poly";
            this._MakePolyPopUPMenu.Click += new System.EventHandler(this.MakePolyPopUPMenu_Click);
            // 
            // _ConvertToPolyPopUpMenu
            // 
            this._ConvertToPolyPopUpMenu.Name = "_ConvertToPolyPopUpMenu";
            this._ConvertToPolyPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._ConvertToPolyPopUpMenu.Text = "Convert to Poly ";
            this._ConvertToPolyPopUpMenu.Click += new System.EventHandler(this.ConvertToPolyPopUpMenu_Click);
            // 
            // _SmoothPopUPMenu
            // 
            this._SmoothPopUPMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this._SmoothPopUPMenu.Name = "_SmoothPopUPMenu";
            this._SmoothPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._SmoothPopUPMenu.Text = "Smooth...";
            this._SmoothPopUPMenu.Click += new System.EventHandler(this.SmoothPopUPMenu_Click);
            // 
            // _OuterPopUpMenu
            // 
            this._OuterPopUpMenu.Name = "_OuterPopUpMenu";
            this._OuterPopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._OuterPopUpMenu.Text = "Set as outer";
            this._OuterPopUpMenu.Click += new System.EventHandler(this.OuterPopUpMenu_Click);
            // 
            // _HolePopUpMenu
            // 
            this._HolePopUpMenu.Name = "_HolePopUpMenu";
            this._HolePopUpMenu.Size = new System.Drawing.Size(188, 22);
            this._HolePopUpMenu.Text = "Set as hole ...";
            this._HolePopUpMenu.Click += new System.EventHandler(this.HolePopUpMenu_Click);
            // 
            // _SamplePopUPMenu
            // 
            this._SamplePopUPMenu.Name = "_SamplePopUPMenu";
            this._SamplePopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._SamplePopUPMenu.Text = "Sample ...";
            this._SamplePopUPMenu.Click += new System.EventHandler(this.SamplePopUPMenu_Click);
            // 
            // _ManualCheckPopUPMenu
            // 
            this._ManualCheckPopUPMenu.Name = "_ManualCheckPopUPMenu";
            this._ManualCheckPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._ManualCheckPopUPMenu.Text = "Manual Check ...";
            this._ManualCheckPopUPMenu.Click += new System.EventHandler(this.ManualCheckPopUPMenu_Click);
            // 
            // _CalibratePopUPMenu
            // 
            this._CalibratePopUPMenu.Name = "_CalibratePopUPMenu";
            this._CalibratePopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._CalibratePopUPMenu.Text = "Calibrate ...";
            this._CalibratePopUPMenu.Click += new System.EventHandler(this.CalibratePopUPMenu_Click);
            // 
            // Sep3PopUPMenu
            // 
            this.Sep3PopUPMenu.Name = "Sep3PopUPMenu";
            this.Sep3PopUPMenu.Size = new System.Drawing.Size(185, 6);
            // 
            // _PropertiesPopUPMenu
            // 
            this._PropertiesPopUPMenu.Name = "_PropertiesPopUPMenu";
            this._PropertiesPopUPMenu.Size = new System.Drawing.Size(188, 22);
            this._PropertiesPopUPMenu.Text = "Properties";
            this._PropertiesPopUPMenu.Click += new System.EventHandler(this.PropertiesPopUPMenu_Click);
            // 
            // _Timer2
            // 
            this._Timer2.SynchronizingObject = this;
            this._Timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer2_Elapsed);
            // 
            // lbTilesRemaining
            // 
            this.lbTilesRemaining.AutoSize = true;
            this.lbTilesRemaining.BackColor = System.Drawing.Color.White;
            this.lbTilesRemaining.Location = new System.Drawing.Point(-3, 430);
            this.lbTilesRemaining.Name = "lbTilesRemaining";
            this.lbTilesRemaining.Size = new System.Drawing.Size(39, 13);
            this.lbTilesRemaining.TabIndex = 4;
            this.lbTilesRemaining.Text = "Label1";
            this.lbTilesRemaining.Visible = false;
            // 
            // _Timer3
            // 
            this._Timer3.SynchronizingObject = this;
            this._Timer3.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer3_Elapsed);
            // 
            // lbDonation
            // 
            this.lbDonation.AutoSize = true;
            this.lbDonation.BackColor = System.Drawing.Color.White;
            this.lbDonation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDonation.Location = new System.Drawing.Point(0, 49);
            this.lbDonation.Name = "lbDonation";
            this.lbDonation.Size = new System.Drawing.Size(386, 15);
            this.lbDonation.TabIndex = 6;
            this.lbDonation.Text = "To remove this initial window, open SBuilderXX.ini and set \"ShowAbout=False\" .";
            this.lbDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDonation.Visible = false;
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._NewToolStripButton,
            this._OpenToolStripButton,
            this._SaveToolStripButton,
            this.toolStripSeparator6,
            this._UndoToolStripButton,
            this._RedoToolStripButton,
            this.toolStripSeparator7,
            this._PointerToolStripButton,
            this._ZoomToolStripButton,
            this.ToolStripSeparator22,
            this._MeshToolStripButton,
            this._LandToolStripButton,
            this._WaterToolStripButton,
            this.PhotoToolStripButton,
            this._LineToolStripButton,
            this._PolyToolStripButton,
            this._ObjectToolStripButton,
            this._ExcludeToolStripButton,
            this.ToolStripSeparator23,
            this._BGLToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(692, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "ToolBar";
            // 
            // _NewToolStripButton
            // 
            this._NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._NewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_NewToolStripButton.Image")));
            this._NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._NewToolStripButton.Name = "_NewToolStripButton";
            this._NewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._NewToolStripButton.Text = "&New";
            this._NewToolStripButton.ToolTipText = "New Project";
            this._NewToolStripButton.Click += new System.EventHandler(this.NewToolStripButton_Click);
            // 
            // _OpenToolStripButton
            // 
            this._OpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._OpenToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_OpenToolStripButton.Image")));
            this._OpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._OpenToolStripButton.Name = "_OpenToolStripButton";
            this._OpenToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._OpenToolStripButton.Text = "&Open";
            this._OpenToolStripButton.ToolTipText = "Open Project";
            this._OpenToolStripButton.Click += new System.EventHandler(this.OpenToolStripButton_Click);
            // 
            // _SaveToolStripButton
            // 
            this._SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._SaveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_SaveToolStripButton.Image")));
            this._SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._SaveToolStripButton.Name = "_SaveToolStripButton";
            this._SaveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._SaveToolStripButton.Text = "&Save";
            this._SaveToolStripButton.Click += new System.EventHandler(this.SaveToolStripButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // _UndoToolStripButton
            // 
            this._UndoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._UndoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_UndoToolStripButton.Image")));
            this._UndoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._UndoToolStripButton.Name = "_UndoToolStripButton";
            this._UndoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._UndoToolStripButton.Text = "ToolStripButton1";
            this._UndoToolStripButton.ToolTipText = "Undo";
            this._UndoToolStripButton.Click += new System.EventHandler(this.UndoToolStripButton_Click);
            // 
            // _RedoToolStripButton
            // 
            this._RedoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._RedoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_RedoToolStripButton.Image")));
            this._RedoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._RedoToolStripButton.Name = "_RedoToolStripButton";
            this._RedoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._RedoToolStripButton.Text = "ToolStripButton1";
            this._RedoToolStripButton.ToolTipText = "Redo";
            this._RedoToolStripButton.Click += new System.EventHandler(this.RedoToolStripButton_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // _PointerToolStripButton
            // 
            this._PointerToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._PointerToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_PointerToolStripButton.Image")));
            this._PointerToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._PointerToolStripButton.Name = "_PointerToolStripButton";
            this._PointerToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._PointerToolStripButton.Text = "ToolStripButton8";
            this._PointerToolStripButton.ToolTipText = "Pointer Mode";
            this._PointerToolStripButton.Click += new System.EventHandler(this.PointerToolStripButton_Click);
            // 
            // _ZoomToolStripButton
            // 
            this._ZoomToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._ZoomToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_ZoomToolStripButton.Image")));
            this._ZoomToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ZoomToolStripButton.Name = "_ZoomToolStripButton";
            this._ZoomToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._ZoomToolStripButton.Text = "ToolStripButton3";
            this._ZoomToolStripButton.ToolTipText = "Zoom";
            this._ZoomToolStripButton.Click += new System.EventHandler(this.ZoomToolStripButton_Click);
            // 
            // ToolStripSeparator22
            // 
            this.ToolStripSeparator22.Name = "ToolStripSeparator22";
            this.ToolStripSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // _MeshToolStripButton
            // 
            this._MeshToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._MeshToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_MeshToolStripButton.Image")));
            this._MeshToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._MeshToolStripButton.Name = "_MeshToolStripButton";
            this._MeshToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._MeshToolStripButton.Text = "ToolStripButton5";
            this._MeshToolStripButton.ToolTipText = "Mesh Tool";
            this._MeshToolStripButton.Visible = false;
            this._MeshToolStripButton.Click += new System.EventHandler(this.MeshToolStripButton_Click);
            // 
            // _LandToolStripButton
            // 
            this._LandToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._LandToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_LandToolStripButton.Image")));
            this._LandToolStripButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this._LandToolStripButton.Name = "_LandToolStripButton";
            this._LandToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._LandToolStripButton.Text = "ToolStripButton6";
            this._LandToolStripButton.ToolTipText = "Land Class Tool";
            this._LandToolStripButton.Click += new System.EventHandler(this.LandToolStripButton_Click);
            // 
            // _WaterToolStripButton
            // 
            this._WaterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._WaterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_WaterToolStripButton.Image")));
            this._WaterToolStripButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this._WaterToolStripButton.Name = "_WaterToolStripButton";
            this._WaterToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._WaterToolStripButton.Text = "ToolStripButton7";
            this._WaterToolStripButton.ToolTipText = "Water Class Tool";
            this._WaterToolStripButton.Click += new System.EventHandler(this.WaterToolStripButton_Click);
            // 
            // PhotoToolStripButton
            // 
            this.PhotoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PhotoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("PhotoToolStripButton.Image")));
            this.PhotoToolStripButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this.PhotoToolStripButton.Name = "PhotoToolStripButton";
            this.PhotoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.PhotoToolStripButton.Text = "ToolStripButton10";
            this.PhotoToolStripButton.ToolTipText = "Photo Tool";
            this.PhotoToolStripButton.Visible = false;
            // 
            // _LineToolStripButton
            // 
            this._LineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._LineToolStripButton.Image = global::SBuilderXX.My.Resources.Resources.lines7;
            this._LineToolStripButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this._LineToolStripButton.Name = "_LineToolStripButton";
            this._LineToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._LineToolStripButton.Text = "ToolStripButton12";
            this._LineToolStripButton.ToolTipText = "Line Tool";
            this._LineToolStripButton.Click += new System.EventHandler(this.LineToolStripButton_Click);
            // 
            // _PolyToolStripButton
            // 
            this._PolyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._PolyToolStripButton.Image = global::SBuilderXX.My.Resources.Resources.polys3;
            this._PolyToolStripButton.ImageTransparentColor = System.Drawing.Color.Silver;
            this._PolyToolStripButton.Name = "_PolyToolStripButton";
            this._PolyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._PolyToolStripButton.Text = "ToolStripButton11";
            this._PolyToolStripButton.ToolTipText = "Polygon Tool";
            this._PolyToolStripButton.Click += new System.EventHandler(this.PolyToolStripButton_Click);
            // 
            // _ObjectToolStripButton
            // 
            this._ObjectToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._ObjectToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_ObjectToolStripButton.Image")));
            this._ObjectToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ObjectToolStripButton.Name = "_ObjectToolStripButton";
            this._ObjectToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._ObjectToolStripButton.Text = "ToolStripButton9";
            this._ObjectToolStripButton.ToolTipText = "Object Tool";
            this._ObjectToolStripButton.Click += new System.EventHandler(this.ObjectToolStripButton_Click);
            // 
            // _ExcludeToolStripButton
            // 
            this._ExcludeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._ExcludeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_ExcludeToolStripButton.Image")));
            this._ExcludeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ExcludeToolStripButton.Name = "_ExcludeToolStripButton";
            this._ExcludeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._ExcludeToolStripButton.Text = "ToolStripButton2";
            this._ExcludeToolStripButton.ToolTipText = "Exclude Tool";
            this._ExcludeToolStripButton.Click += new System.EventHandler(this.ExcludeToolStripButton_Click);
            // 
            // ToolStripSeparator23
            // 
            this.ToolStripSeparator23.Name = "ToolStripSeparator23";
            this.ToolStripSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // _BGLToolStripButton
            // 
            this._BGLToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._BGLToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_BGLToolStripButton.Image")));
            this._BGLToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._BGLToolStripButton.Name = "_BGLToolStripButton";
            this._BGLToolStripButton.Size = new System.Drawing.Size(23, 22);
            this._BGLToolStripButton.Text = "He&lp";
            this._BGLToolStripButton.ToolTipText = "BGL Compile";
            this._BGLToolStripButton.Click += new System.EventHandler(this.BGLToolStripButton_Click);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 100);
            // 
            // lbScale
            // 
            this.lbScale.AutoSize = true;
            this.lbScale.BackColor = System.Drawing.Color.Transparent;
            this.lbScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScale.Location = new System.Drawing.Point(641, 404);
            this.lbScale.Name = "lbScale";
            this.lbScale.Size = new System.Drawing.Size(39, 13);
            this.lbScale.TabIndex = 7;
            this.lbScale.Text = "Scale";
            this.lbScale.Visible = false;
            // 
            // lbScaleBar
            // 
            this.lbScaleBar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lbScaleBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbScaleBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScaleBar.Location = new System.Drawing.Point(580, 417);
            this.lbScaleBar.Name = "lbScaleBar";
            this.lbScaleBar.Size = new System.Drawing.Size(100, 5);
            this.lbScaleBar.TabIndex = 7;
            this.lbScaleBar.Visible = false;
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(692, 466);
            this.ContextMenuStrip = this.PopUpMenu;
            this.Controls.Add(this.lbDonation);
            this.Controls.Add(this.TextBoxMeasure);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.lbScale);
            this.Controls.Add(this.lbTilesRemaining);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.lbScaleBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(200, 140);
            this.Name = "FrmStart";
            this.Text = "SBuilderXX";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStart_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStart_FormClosed);
            this.Load += new System.EventHandler(this.FrmStart_Load);
            this.Shown += new System.EventHandler(this.FrmStart_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStart_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmStart_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmStart_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmStart_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FrmStart_MouseUp);
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.FrmStart_MouseWheel);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._Timer1)).EndInit();
            this.PopUpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._Timer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Timer3)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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