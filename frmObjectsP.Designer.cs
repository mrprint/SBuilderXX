using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmObjectsP : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmObjectsP));
            this._cmdOrder = new System.Windows.Forms.Button();
            this.txtComment = new System.Windows.Forms.TextBox();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._SSTab1 = new System.Windows.Forms.TabControl();
            this._SSTab1_TabPage0 = new System.Windows.Forms.TabPage();
            this.Frame4 = new System.Windows.Forms.GroupBox();
            this._optGenB = new System.Windows.Forms.RadioButton();
            this._optMDL = new System.Windows.Forms.RadioButton();
            this._cmdOption = new System.Windows.Forms.Button();
            this._optRwy12 = new System.Windows.Forms.RadioButton();
            this._optMacro = new System.Windows.Forms.RadioButton();
            this._optBeacon = new System.Windows.Forms.RadioButton();
            this._optWindsock = new System.Windows.Forms.RadioButton();
            this._optEffect = new System.Windows.Forms.RadioButton();
            this._optTaxiwaySign = new System.Windows.Forms.RadioButton();
            this._optLib = new System.Windows.Forms.RadioButton();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.ckAGL = new System.Windows.Forms.CheckBox();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtPitch = new System.Windows.Forms.TextBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.opEDense = new System.Windows.Forms.RadioButton();
            this.opVDense = new System.Windows.Forms.RadioButton();
            this.opDense = new System.Windows.Forms.RadioButton();
            this.opNormal = new System.Windows.Forms.RadioButton();
            this.opSparse = new System.Windows.Forms.RadioButton();
            this.opVSparse = new System.Windows.Forms.RadioButton();
            this.Frame5 = new System.Windows.Forms.GroupBox();
            this.txtBiasX = new System.Windows.Forms.TextBox();
            this.txtBiasY = new System.Windows.Forms.TextBox();
            this.txtBiasZ = new System.Windows.Forms.TextBox();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this._cmdPosFs = new System.Windows.Forms.Button();
            this.Frame6 = new System.Windows.Forms.GroupBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this._SSTab1_TabPage1 = new System.Windows.Forms.TabPage();
            this.frLib = new System.Windows.Forms.GroupBox();
            this._txtLibName = new System.Windows.Forms.TextBox();
            this._txtLibWidth = new System.Windows.Forms.TextBox();
            this._txtLibLength = new System.Windows.Forms.TextBox();
            this._cmdUpDefault = new System.Windows.Forms.Button();
            this._txtLibScale = new System.Windows.Forms.TextBox();
            this.LabelLibName = new System.Windows.Forms.Label();
            this.labelLib2 = new System.Windows.Forms.Label();
            this.LabelLib1 = new System.Windows.Forms.Label();
            this.LabelLib3 = new System.Windows.Forms.Label();
            this.labelLibMouse = new System.Windows.Forms.Label();
            this._imgLib = new System.Windows.Forms.PictureBox();
            this.PopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TitlePopUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._EnlargePopUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._DeletePopUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._FromFilePopUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._CapturePopUpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._PurgePopUPMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LabelCat = new System.Windows.Forms.Label();
            this.labelFS = new System.Windows.Forms.Label();
            this._lstLib = new System.Windows.Forms.ListBox();
            this.txtLibID = new System.Windows.Forms.TextBox();
            this._cmbLibCat = new System.Windows.Forms.ComboBox();
            this._SSTab1_TabPage2 = new System.Windows.Forms.TabPage();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this._cmdGBDelete = new System.Windows.Forms.Button();
            this._cmdGbStore = new System.Windows.Forms.Button();
            this._cmdGbLoad = new System.Windows.Forms.Button();
            this._lstGenB = new System.Windows.Forms.ListBox();
            this.nUPscale = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeZ = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeX = new System.Windows.Forms.NumericUpDown();
            this._cmdGbDetail = new System.Windows.Forms.Button();
            this.lbgb2 = new System.Windows.Forms.Label();
            this.lbgb1 = new System.Windows.Forms.Label();
            this._imgGenB = new System.Windows.Forms.PictureBox();
            this.frGenB = new System.Windows.Forms.GroupBox();
            this.optGbMultiSided = new System.Windows.Forms.RadioButton();
            this.optGbPyramidal = new System.Windows.Forms.RadioButton();
            this.optGbSlant = new System.Windows.Forms.RadioButton();
            this.optGbRidge = new System.Windows.Forms.RadioButton();
            this.optGbPeaked = new System.Windows.Forms.RadioButton();
            this.optGbFlat = new System.Windows.Forms.RadioButton();
            this.lbgb3 = new System.Windows.Forms.Label();
            this._SSTab1_TabPage3 = new System.Windows.Forms.TabPage();
            this.labelMacroMouse = new System.Windows.Forms.Label();
            this.LabelMacro1 = new System.Windows.Forms.Label();
            this.LabelMacroCat = new System.Windows.Forms.Label();
            this._imgMacro = new System.Windows.Forms.PictureBox();
            this._frMacro = new System.Windows.Forms.GroupBox();
            this.txtMacroRange = new System.Windows.Forms.TextBox();
            this.txtMacroScale = new System.Windows.Forms.TextBox();
            this.txtMacroLength = new System.Windows.Forms.TextBox();
            this.txtMacroWidth = new System.Windows.Forms.TextBox();
            this.LabelMacroRange = new System.Windows.Forms.Label();
            this.LabelMacroScale = new System.Windows.Forms.Label();
            this.LabelMacroWidth = new System.Windows.Forms.Label();
            this.LabelMacroLength = new System.Windows.Forms.Label();
            this._cmbMacroCat = new System.Windows.Forms.ComboBox();
            this._lstMacro = new System.Windows.Forms.ListBox();
            this._frMacro1 = new System.Windows.Forms.GroupBox();
            this._cmdExpand = new System.Windows.Forms.Button();
            this.txtP7 = new System.Windows.Forms.TextBox();
            this.txtP9 = new System.Windows.Forms.TextBox();
            this.txtP8 = new System.Windows.Forms.TextBox();
            this.txtP6 = new System.Windows.Forms.TextBox();
            this.lbP9 = new System.Windows.Forms.Label();
            this.lbP7 = new System.Windows.Forms.Label();
            this.lbP8 = new System.Windows.Forms.Label();
            this.lbP6 = new System.Windows.Forms.Label();
            this._cmdMacroEdit = new System.Windows.Forms.Button();
            this._SSTab1_TabPage4 = new System.Windows.Forms.TabPage();
            this.labelRwy12Mouse = new System.Windows.Forms.Label();
            this._lstRwy12 = new System.Windows.Forms.ListBox();
            this.txtRwy12ID = new System.Windows.Forms.TextBox();
            this._frRwy12 = new System.Windows.Forms.GroupBox();
            this.txtRwy12Scale = new System.Windows.Forms.TextBox();
            this.txtRwy12Length = new System.Windows.Forms.TextBox();
            this.txtRwy12Width = new System.Windows.Forms.TextBox();
            this.LabelRwy12Scale = new System.Windows.Forms.Label();
            this.LabelRwy12Width = new System.Windows.Forms.Label();
            this.LabelRwy12Length = new System.Windows.Forms.Label();
            this._cmbRwy12Cat = new System.Windows.Forms.ComboBox();
            this.LabelRwy121 = new System.Windows.Forms.Label();
            this._imgRwy12 = new System.Windows.Forms.PictureBox();
            this.LabelRwy12Cat = new System.Windows.Forms.Label();
            this._SSTab1_TabPage5 = new System.Windows.Forms.TabPage();
            this._frMDL = new System.Windows.Forms.GroupBox();
            this.txtMDLscale = new System.Windows.Forms.TextBox();
            this.labelMDLguid = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.labelMDLName = new System.Windows.Forms.Label();
            this.txtMDLWidth = new System.Windows.Forms.TextBox();
            this.txtMDLLength = new System.Windows.Forms.TextBox();
            this.LabelMDL2 = new System.Windows.Forms.Label();
            this.LabelMDL3 = new System.Windows.Forms.Label();
            this.txtMDLFile = new System.Windows.Forms.TextBox();
            this.LabelMDL1 = new System.Windows.Forms.Label();
            this._cmdMDL = new System.Windows.Forms.Button();
            this._frBeaconType = new System.Windows.Forms.GroupBox();
            this.optBeaconCivilian = new System.Windows.Forms.RadioButton();
            this.optBeaconMil = new System.Windows.Forms.RadioButton();
            this._frBeaconBase = new System.Windows.Forms.GroupBox();
            this.optBeaconAirport = new System.Windows.Forms.RadioButton();
            this.optBeaconHeliport = new System.Windows.Forms.RadioButton();
            this.optBeaconSeaBase = new System.Windows.Forms.RadioButton();
            this._frWindsock = new System.Windows.Forms.GroupBox();
            this.RadioButton3 = new System.Windows.Forms.RadioButton();
            this.RadioButton2 = new System.Windows.Forms.RadioButton();
            this._txtWindsockLength = new System.Windows.Forms.TextBox();
            this.RadioButton1 = new System.Windows.Forms.RadioButton();
            this._txtWindsockHeight = new System.Windows.Forms.TextBox();
            this.ckWindsockLight = new System.Windows.Forms.CheckBox();
            this.LabelWin3 = new System.Windows.Forms.Label();
            this.LabelWin2 = new System.Windows.Forms.Label();
            this.LabelWin1 = new System.Windows.Forms.Label();
            this._frEffect = new System.Windows.Forms.GroupBox();
            this.txtEffectName = new System.Windows.Forms.TextBox();
            this.txtEffectParameters = new System.Windows.Forms.TextBox();
            this.LabelEffect1 = new System.Windows.Forms.Label();
            this.LabelEffect2 = new System.Windows.Forms.Label();
            this._frTaxiway = new System.Windows.Forms.GroupBox();
            this.txtTaxiwayText = new System.Windows.Forms.TextBox();
            this.combTaxiwaySize = new System.Windows.Forms.ComboBox();
            this.combTaxiwayJustification = new System.Windows.Forms.ComboBox();
            this._cmdTaxiwayHelp = new System.Windows.Forms.Button();
            this.LabelTax1 = new System.Windows.Forms.Label();
            this.LabelTax2 = new System.Windows.Forms.Label();
            this.LabelTax3 = new System.Windows.Forms.Label();
            this.lbComment = new System.Windows.Forms.Label();
            this._SSTab1.SuspendLayout();
            this._SSTab1_TabPage0.SuspendLayout();
            this.Frame4.SuspendLayout();
            this.Frame1.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame3.SuspendLayout();
            this.Frame5.SuspendLayout();
            this.Frame6.SuspendLayout();
            this._SSTab1_TabPage1.SuspendLayout();
            this.frLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgLib)).BeginInit();
            this.PopUpMenu.SuspendLayout();
            this._SSTab1_TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._imgGenB)).BeginInit();
            this.frGenB.SuspendLayout();
            this._SSTab1_TabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgMacro)).BeginInit();
            this._frMacro.SuspendLayout();
            this._frMacro1.SuspendLayout();
            this._SSTab1_TabPage4.SuspendLayout();
            this._frRwy12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgRwy12)).BeginInit();
            this._SSTab1_TabPage5.SuspendLayout();
            this._frMDL.SuspendLayout();
            this._frBeaconType.SuspendLayout();
            this._frBeaconBase.SuspendLayout();
            this._frWindsock.SuspendLayout();
            this._frEffect.SuspendLayout();
            this._frTaxiway.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdOrder
            // 
            this._cmdOrder.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOrder.Location = new System.Drawing.Point(308, 375);
            this._cmdOrder.Name = "_cmdOrder";
            this._cmdOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOrder.Size = new System.Drawing.Size(54, 26);
            this._cmdOrder.TabIndex = 60;
            this._cmdOrder.Text = "Order";
            this._cmdOrder.UseVisualStyleBackColor = false;
            this._cmdOrder.Click += new System.EventHandler(this.CmdOrder_Click);
            // 
            // txtComment
            // 
            this.txtComment.AcceptsReturn = true;
            this.txtComment.BackColor = System.Drawing.SystemColors.Window;
            this.txtComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComment.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtComment.Location = new System.Drawing.Point(96, 378);
            this.txtComment.MaxLength = 0;
            this.txtComment.Name = "txtComment";
            this.txtComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtComment.Size = new System.Drawing.Size(193, 20);
            this.txtComment.TabIndex = 59;
            this.txtComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(448, 375);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(54, 25);
            this._cmdOK.TabIndex = 58;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(378, 375);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(54, 26);
            this._cmdCancel.TabIndex = 57;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _SSTab1
            // 
            this._SSTab1.Controls.Add(this._SSTab1_TabPage0);
            this._SSTab1.Controls.Add(this._SSTab1_TabPage1);
            this._SSTab1.Controls.Add(this._SSTab1_TabPage2);
            this._SSTab1.Controls.Add(this._SSTab1_TabPage3);
            this._SSTab1.Controls.Add(this._SSTab1_TabPage4);
            this._SSTab1.Controls.Add(this._SSTab1_TabPage5);
            this._SSTab1.ItemSize = new System.Drawing.Size(42, 18);
            this._SSTab1.Location = new System.Drawing.Point(12, 12);
            this._SSTab1.Name = "_SSTab1";
            this._SSTab1.SelectedIndex = 1;
            this._SSTab1.Size = new System.Drawing.Size(494, 348);
            this._SSTab1.TabIndex = 56;
            this._SSTab1.SelectedIndexChanged += new System.EventHandler(this.SSTab1_SelectedIndexChanged);
            // 
            // _SSTab1_TabPage0
            // 
            this._SSTab1_TabPage0.BackColor = System.Drawing.Color.Transparent;
            this._SSTab1_TabPage0.Controls.Add(this.Frame4);
            this._SSTab1_TabPage0.Controls.Add(this.Frame1);
            this._SSTab1_TabPage0.Controls.Add(this.Frame2);
            this._SSTab1_TabPage0.Controls.Add(this.Frame3);
            this._SSTab1_TabPage0.Controls.Add(this.Frame5);
            this._SSTab1_TabPage0.Controls.Add(this._cmdPosFs);
            this._SSTab1_TabPage0.Controls.Add(this.Frame6);
            this._SSTab1_TabPage0.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage0.Name = "_SSTab1_TabPage0";
            this._SSTab1_TabPage0.Size = new System.Drawing.Size(486, 322);
            this._SSTab1_TabPage0.TabIndex = 0;
            this._SSTab1_TabPage0.Text = "General";
            this._SSTab1_TabPage0.UseVisualStyleBackColor = true;
            // 
            // Frame4
            // 
            this.Frame4.BackColor = System.Drawing.Color.Transparent;
            this.Frame4.Controls.Add(this._optGenB);
            this.Frame4.Controls.Add(this._optMDL);
            this.Frame4.Controls.Add(this._cmdOption);
            this.Frame4.Controls.Add(this._optRwy12);
            this.Frame4.Controls.Add(this._optMacro);
            this.Frame4.Controls.Add(this._optBeacon);
            this.Frame4.Controls.Add(this._optWindsock);
            this.Frame4.Controls.Add(this._optEffect);
            this.Frame4.Controls.Add(this._optTaxiwaySign);
            this.Frame4.Controls.Add(this._optLib);
            this.Frame4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Frame4.Location = new System.Drawing.Point(21, 164);
            this.Frame4.Name = "Frame4";
            this.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame4.Size = new System.Drawing.Size(201, 147);
            this.Frame4.TabIndex = 62;
            this.Frame4.TabStop = false;
            this.Frame4.Text = "Object Type";
            // 
            // _optGenB
            // 
            this._optGenB.BackColor = System.Drawing.Color.Transparent;
            this._optGenB.Cursor = System.Windows.Forms.Cursors.Default;
            this._optGenB.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optGenB.Location = new System.Drawing.Point(109, 91);
            this._optGenB.Name = "_optGenB";
            this._optGenB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optGenB.Size = new System.Drawing.Size(82, 25);
            this._optGenB.TabIndex = 44;
            this._optGenB.TabStop = true;
            this._optGenB.Text = "Building";
            this._optGenB.UseVisualStyleBackColor = false;
            this._optGenB.CheckedChanged += new System.EventHandler(this.OptGenB_CheckedChanged);
            // 
            // _optMDL
            // 
            this._optMDL.BackColor = System.Drawing.Color.Transparent;
            this._optMDL.Cursor = System.Windows.Forms.Cursors.Default;
            this._optMDL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optMDL.Location = new System.Drawing.Point(109, 67);
            this._optMDL.Name = "_optMDL";
            this._optMDL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optMDL.Size = new System.Drawing.Size(64, 25);
            this._optMDL.TabIndex = 43;
            this._optMDL.TabStop = true;
            this._optMDL.Text = "MDL";
            this._optMDL.UseVisualStyleBackColor = false;
            this._optMDL.CheckedChanged += new System.EventHandler(this.OptMDL_CheckedChanged);
            // 
            // _cmdOption
            // 
            this._cmdOption.BackColor = System.Drawing.Color.Transparent;
            this._cmdOption.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOption.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOption.Location = new System.Drawing.Point(135, 118);
            this._cmdOption.Name = "_cmdOption";
            this._cmdOption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOption.Size = new System.Drawing.Size(46, 21);
            this._cmdOption.TabIndex = 42;
            this._cmdOption.Text = ">>>";
            this._cmdOption.UseVisualStyleBackColor = false;
            this._cmdOption.Click += new System.EventHandler(this.CmdOption_Click);
            // 
            // _optRwy12
            // 
            this._optRwy12.BackColor = System.Drawing.Color.Transparent;
            this._optRwy12.Cursor = System.Windows.Forms.Cursors.Default;
            this._optRwy12.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optRwy12.Location = new System.Drawing.Point(15, 71);
            this._optRwy12.Name = "_optRwy12";
            this._optRwy12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optRwy12.Size = new System.Drawing.Size(70, 16);
            this._optRwy12.TabIndex = 41;
            this._optRwy12.TabStop = true;
            this._optRwy12.Text = "Rwy12";
            this._optRwy12.UseVisualStyleBackColor = false;
            this._optRwy12.CheckedChanged += new System.EventHandler(this.OptRwy12_CheckedChanged);
            // 
            // _optMacro
            // 
            this._optMacro.BackColor = System.Drawing.Color.Transparent;
            this._optMacro.Cursor = System.Windows.Forms.Cursors.Default;
            this._optMacro.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optMacro.Location = new System.Drawing.Point(15, 46);
            this._optMacro.Name = "_optMacro";
            this._optMacro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optMacro.Size = new System.Drawing.Size(70, 19);
            this._optMacro.TabIndex = 40;
            this._optMacro.TabStop = true;
            this._optMacro.Text = "Macro";
            this._optMacro.UseVisualStyleBackColor = false;
            this._optMacro.CheckedChanged += new System.EventHandler(this.OptMacro_CheckedChanged);
            // 
            // _optBeacon
            // 
            this._optBeacon.BackColor = System.Drawing.Color.Transparent;
            this._optBeacon.Cursor = System.Windows.Forms.Cursors.Default;
            this._optBeacon.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optBeacon.Location = new System.Drawing.Point(109, 43);
            this._optBeacon.Name = "_optBeacon";
            this._optBeacon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optBeacon.Size = new System.Drawing.Size(64, 25);
            this._optBeacon.TabIndex = 27;
            this._optBeacon.TabStop = true;
            this._optBeacon.Text = "Beacon";
            this._optBeacon.UseVisualStyleBackColor = false;
            this._optBeacon.CheckedChanged += new System.EventHandler(this.OptBeacon_CheckedChanged);
            // 
            // _optWindsock
            // 
            this._optWindsock.BackColor = System.Drawing.Color.Transparent;
            this._optWindsock.Cursor = System.Windows.Forms.Cursors.Default;
            this._optWindsock.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optWindsock.Location = new System.Drawing.Point(109, 21);
            this._optWindsock.Name = "_optWindsock";
            this._optWindsock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optWindsock.Size = new System.Drawing.Size(77, 23);
            this._optWindsock.TabIndex = 26;
            this._optWindsock.TabStop = true;
            this._optWindsock.Text = "Windsock";
            this._optWindsock.UseVisualStyleBackColor = false;
            this._optWindsock.CheckedChanged += new System.EventHandler(this.OptWindSock_CheckedChanged);
            // 
            // _optEffect
            // 
            this._optEffect.BackColor = System.Drawing.Color.Transparent;
            this._optEffect.Cursor = System.Windows.Forms.Cursors.Default;
            this._optEffect.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optEffect.Location = new System.Drawing.Point(15, 91);
            this._optEffect.Name = "_optEffect";
            this._optEffect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optEffect.Size = new System.Drawing.Size(58, 25);
            this._optEffect.TabIndex = 25;
            this._optEffect.TabStop = true;
            this._optEffect.Text = "Effect";
            this._optEffect.UseVisualStyleBackColor = false;
            this._optEffect.CheckedChanged += new System.EventHandler(this.OptEffect_CheckedChanged);
            // 
            // _optTaxiwaySign
            // 
            this._optTaxiwaySign.BackColor = System.Drawing.Color.Transparent;
            this._optTaxiwaySign.Cursor = System.Windows.Forms.Cursors.Default;
            this._optTaxiwaySign.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optTaxiwaySign.Location = new System.Drawing.Point(15, 113);
            this._optTaxiwaySign.Name = "_optTaxiwaySign";
            this._optTaxiwaySign.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optTaxiwaySign.Size = new System.Drawing.Size(94, 31);
            this._optTaxiwaySign.TabIndex = 24;
            this._optTaxiwaySign.TabStop = true;
            this._optTaxiwaySign.Text = "Taxiway Sign";
            this._optTaxiwaySign.UseVisualStyleBackColor = false;
            this._optTaxiwaySign.CheckedChanged += new System.EventHandler(this.OptTaxiwaySign_CheckedChanged);
            // 
            // _optLib
            // 
            this._optLib.BackColor = System.Drawing.Color.Transparent;
            this._optLib.Checked = true;
            this._optLib.Cursor = System.Windows.Forms.Cursors.Default;
            this._optLib.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optLib.Location = new System.Drawing.Point(15, 20);
            this._optLib.Name = "_optLib";
            this._optLib.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optLib.Size = new System.Drawing.Size(97, 25);
            this._optLib.TabIndex = 23;
            this._optLib.TabStop = true;
            this._optLib.Text = "Library Object";
            this._optLib.UseVisualStyleBackColor = false;
            this._optLib.CheckedChanged += new System.EventHandler(this.OptLib_CheckedChanged);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.Color.Transparent;
            this.Frame1.Controls.Add(this.txtLat);
            this.Frame1.Controls.Add(this.txtLon);
            this.Frame1.Controls.Add(this.ckAGL);
            this.Frame1.Controls.Add(this.txtAltitude);
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label1);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Frame1.Location = new System.Drawing.Point(21, 24);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(161, 127);
            this.Frame1.TabIndex = 1;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Geographic Position";
            // 
            // txtLat
            // 
            this.txtLat.AcceptsReturn = true;
            this.txtLat.BackColor = System.Drawing.SystemColors.Window;
            this.txtLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLat.Location = new System.Drawing.Point(36, 24);
            this.txtLat.MaxLength = 0;
            this.txtLat.Name = "txtLat";
            this.txtLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLat.Size = new System.Drawing.Size(109, 20);
            this.txtLat.TabIndex = 9;
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLon
            // 
            this.txtLon.AcceptsReturn = true;
            this.txtLon.BackColor = System.Drawing.SystemColors.Window;
            this.txtLon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLon.Location = new System.Drawing.Point(36, 57);
            this.txtLon.MaxLength = 0;
            this.txtLon.Name = "txtLon";
            this.txtLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLon.Size = new System.Drawing.Size(109, 20);
            this.txtLon.TabIndex = 8;
            this.txtLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckAGL
            // 
            this.ckAGL.BackColor = System.Drawing.Color.Transparent;
            this.ckAGL.Checked = true;
            this.ckAGL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAGL.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckAGL.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckAGL.Location = new System.Drawing.Point(95, 91);
            this.ckAGL.Name = "ckAGL";
            this.ckAGL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckAGL.Size = new System.Drawing.Size(50, 19);
            this.ckAGL.TabIndex = 3;
            this.ckAGL.Text = "AGL";
            this.ckAGL.UseVisualStyleBackColor = false;
            // 
            // txtAltitude
            // 
            this.txtAltitude.AcceptsReturn = true;
            this.txtAltitude.BackColor = System.Drawing.SystemColors.Window;
            this.txtAltitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAltitude.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAltitude.Location = new System.Drawing.Point(36, 90);
            this.txtAltitude.MaxLength = 0;
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAltitude.Size = new System.Drawing.Size(49, 20);
            this.txtAltitude.TabIndex = 2;
            this.txtAltitude.Text = "0";
            this.txtAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(12, 93);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(25, 16);
            this.Label3.TabIndex = 12;
            this.Label3.Text = "Alt:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(9, 27);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(28, 19);
            this.Label1.TabIndex = 11;
            this.Label1.Text = "Lat:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(6, 61);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(31, 19);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "Lon:";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.Color.Transparent;
            this.Frame2.Controls.Add(this.txtBank);
            this.Frame2.Controls.Add(this.txtPitch);
            this.Frame2.Controls.Add(this.txtHeading);
            this.Frame2.Controls.Add(this.Label6);
            this.Frame2.Controls.Add(this.Label5);
            this.Frame2.Controls.Add(this.Label4);
            this.Frame2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Frame2.Location = new System.Drawing.Point(202, 24);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(127, 127);
            this.Frame2.TabIndex = 4;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Angular Orientation";
            // 
            // txtBank
            // 
            this.txtBank.AcceptsReturn = true;
            this.txtBank.BackColor = System.Drawing.SystemColors.Window;
            this.txtBank.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBank.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBank.Location = new System.Drawing.Point(61, 88);
            this.txtBank.MaxLength = 0;
            this.txtBank.Name = "txtBank";
            this.txtBank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBank.Size = new System.Drawing.Size(52, 20);
            this.txtBank.TabIndex = 7;
            this.txtBank.Text = "0";
            this.txtBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPitch
            // 
            this.txtPitch.AcceptsReturn = true;
            this.txtPitch.BackColor = System.Drawing.SystemColors.Window;
            this.txtPitch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPitch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPitch.Location = new System.Drawing.Point(61, 58);
            this.txtPitch.MaxLength = 0;
            this.txtPitch.Name = "txtPitch";
            this.txtPitch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPitch.Size = new System.Drawing.Size(52, 20);
            this.txtPitch.TabIndex = 6;
            this.txtPitch.Text = "0";
            this.txtPitch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeading
            // 
            this.txtHeading.AcceptsReturn = true;
            this.txtHeading.BackColor = System.Drawing.SystemColors.Window;
            this.txtHeading.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeading.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHeading.Location = new System.Drawing.Point(61, 27);
            this.txtHeading.MaxLength = 0;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHeading.Size = new System.Drawing.Size(52, 20);
            this.txtHeading.TabIndex = 5;
            this.txtHeading.Text = "0";
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(19, 91);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(43, 19);
            this.Label6.TabIndex = 15;
            this.Label6.Text = "Bank:";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(25, 59);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(37, 19);
            this.Label5.TabIndex = 14;
            this.Label5.Text = "Pitch:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(10, 30);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(52, 19);
            this.Label4.TabIndex = 13;
            this.Label4.Text = "Heading:";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.Color.Transparent;
            this.Frame3.Controls.Add(this.opEDense);
            this.Frame3.Controls.Add(this.opVDense);
            this.Frame3.Controls.Add(this.opDense);
            this.Frame3.Controls.Add(this.opNormal);
            this.Frame3.Controls.Add(this.opSparse);
            this.Frame3.Controls.Add(this.opVSparse);
            this.Frame3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Frame3.Location = new System.Drawing.Point(239, 164);
            this.Frame3.Name = "Frame3";
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(90, 147);
            this.Frame3.TabIndex = 16;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Complexity";
            // 
            // opEDense
            // 
            this.opEDense.BackColor = System.Drawing.Color.Transparent;
            this.opEDense.Cursor = System.Windows.Forms.Cursors.Default;
            this.opEDense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opEDense.Location = new System.Drawing.Point(15, 122);
            this.opEDense.Name = "opEDense";
            this.opEDense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opEDense.Size = new System.Drawing.Size(82, 18);
            this.opEDense.TabIndex = 22;
            this.opEDense.TabStop = true;
            this.opEDense.Text = "E. Dense";
            this.opEDense.UseVisualStyleBackColor = false;
            // 
            // opVDense
            // 
            this.opVDense.BackColor = System.Drawing.Color.Transparent;
            this.opVDense.Cursor = System.Windows.Forms.Cursors.Default;
            this.opVDense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opVDense.Location = new System.Drawing.Point(15, 100);
            this.opVDense.Name = "opVDense";
            this.opVDense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opVDense.Size = new System.Drawing.Size(82, 18);
            this.opVDense.TabIndex = 21;
            this.opVDense.TabStop = true;
            this.opVDense.Text = "V. Dense";
            this.opVDense.UseVisualStyleBackColor = false;
            // 
            // opDense
            // 
            this.opDense.BackColor = System.Drawing.Color.Transparent;
            this.opDense.Cursor = System.Windows.Forms.Cursors.Default;
            this.opDense.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opDense.Location = new System.Drawing.Point(15, 80);
            this.opDense.Name = "opDense";
            this.opDense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opDense.Size = new System.Drawing.Size(61, 16);
            this.opDense.TabIndex = 20;
            this.opDense.TabStop = true;
            this.opDense.Text = "Dense";
            this.opDense.UseVisualStyleBackColor = false;
            // 
            // opNormal
            // 
            this.opNormal.BackColor = System.Drawing.Color.Transparent;
            this.opNormal.Checked = true;
            this.opNormal.Cursor = System.Windows.Forms.Cursors.Default;
            this.opNormal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opNormal.Location = new System.Drawing.Point(15, 60);
            this.opNormal.Name = "opNormal";
            this.opNormal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opNormal.Size = new System.Drawing.Size(61, 16);
            this.opNormal.TabIndex = 19;
            this.opNormal.TabStop = true;
            this.opNormal.Text = "Normal";
            this.opNormal.UseVisualStyleBackColor = false;
            // 
            // opSparse
            // 
            this.opSparse.BackColor = System.Drawing.Color.Transparent;
            this.opSparse.Cursor = System.Windows.Forms.Cursors.Default;
            this.opSparse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opSparse.Location = new System.Drawing.Point(15, 40);
            this.opSparse.Name = "opSparse";
            this.opSparse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opSparse.Size = new System.Drawing.Size(61, 16);
            this.opSparse.TabIndex = 18;
            this.opSparse.TabStop = true;
            this.opSparse.Text = "Sparse";
            this.opSparse.UseVisualStyleBackColor = false;
            // 
            // opVSparse
            // 
            this.opVSparse.BackColor = System.Drawing.Color.Transparent;
            this.opVSparse.Cursor = System.Windows.Forms.Cursors.Default;
            this.opVSparse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.opVSparse.Location = new System.Drawing.Point(15, 20);
            this.opVSparse.Name = "opVSparse";
            this.opVSparse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.opVSparse.Size = new System.Drawing.Size(82, 16);
            this.opVSparse.TabIndex = 17;
            this.opVSparse.TabStop = true;
            this.opVSparse.Text = "V. Sparse";
            this.opVSparse.UseVisualStyleBackColor = false;
            // 
            // Frame5
            // 
            this.Frame5.BackColor = System.Drawing.Color.Transparent;
            this.Frame5.Controls.Add(this.txtBiasX);
            this.Frame5.Controls.Add(this.txtBiasY);
            this.Frame5.Controls.Add(this.txtBiasZ);
            this.Frame5.Controls.Add(this.Label17);
            this.Frame5.Controls.Add(this.Label18);
            this.Frame5.Controls.Add(this.Label19);
            this.Frame5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Frame5.Location = new System.Drawing.Point(348, 24);
            this.Frame5.Name = "Frame5";
            this.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame5.Size = new System.Drawing.Size(113, 127);
            this.Frame5.TabIndex = 28;
            this.Frame5.TabStop = false;
            this.Frame5.Text = " Bias";
            // 
            // txtBiasX
            // 
            this.txtBiasX.AcceptsReturn = true;
            this.txtBiasX.BackColor = System.Drawing.SystemColors.Window;
            this.txtBiasX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBiasX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBiasX.Location = new System.Drawing.Point(55, 30);
            this.txtBiasX.MaxLength = 0;
            this.txtBiasX.Name = "txtBiasX";
            this.txtBiasX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBiasX.Size = new System.Drawing.Size(36, 20);
            this.txtBiasX.TabIndex = 45;
            this.txtBiasX.Text = "0";
            this.txtBiasX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBiasY
            // 
            this.txtBiasY.AcceptsReturn = true;
            this.txtBiasY.BackColor = System.Drawing.SystemColors.Window;
            this.txtBiasY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBiasY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBiasY.Location = new System.Drawing.Point(55, 60);
            this.txtBiasY.MaxLength = 0;
            this.txtBiasY.Name = "txtBiasY";
            this.txtBiasY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBiasY.Size = new System.Drawing.Size(36, 20);
            this.txtBiasY.TabIndex = 44;
            this.txtBiasY.Text = "0";
            this.txtBiasY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBiasZ
            // 
            this.txtBiasZ.AcceptsReturn = true;
            this.txtBiasZ.BackColor = System.Drawing.SystemColors.Window;
            this.txtBiasZ.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBiasZ.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBiasZ.Location = new System.Drawing.Point(55, 90);
            this.txtBiasZ.MaxLength = 0;
            this.txtBiasZ.Name = "txtBiasZ";
            this.txtBiasZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBiasZ.Size = new System.Drawing.Size(37, 20);
            this.txtBiasZ.TabIndex = 43;
            this.txtBiasZ.Text = "0";
            this.txtBiasZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label17
            // 
            this.Label17.BackColor = System.Drawing.Color.Transparent;
            this.Label17.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label17.Location = new System.Drawing.Point(11, 34);
            this.Label17.Name = "Label17";
            this.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label17.Size = new System.Drawing.Size(43, 16);
            this.Label17.TabIndex = 48;
            this.Label17.Text = "X Bias:";
            this.Label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label18.Location = new System.Drawing.Point(6, 63);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(48, 16);
            this.Label18.TabIndex = 47;
            this.Label18.Text = "Y Bias:";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label19
            // 
            this.Label19.BackColor = System.Drawing.Color.Transparent;
            this.Label19.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label19.Location = new System.Drawing.Point(11, 92);
            this.Label19.Name = "Label19";
            this.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label19.Size = new System.Drawing.Size(43, 16);
            this.Label19.TabIndex = 46;
            this.Label19.Text = "Z Bias:";
            this.Label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _cmdPosFs
            // 
            this._cmdPosFs.BackColor = System.Drawing.Color.Transparent;
            this._cmdPosFs.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdPosFs.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdPosFs.Location = new System.Drawing.Point(349, 282);
            this._cmdPosFs.Name = "_cmdPosFs";
            this._cmdPosFs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdPosFs.Size = new System.Drawing.Size(112, 25);
            this._cmdPosFs.TabIndex = 49;
            this._cmdPosFs.Text = "Position from FS";
            this._cmdPosFs.UseVisualStyleBackColor = false;
            this._cmdPosFs.Click += new System.EventHandler(this.CmdPosFs_Click);
            // 
            // Frame6
            // 
            this.Frame6.BackColor = System.Drawing.Color.Transparent;
            this.Frame6.Controls.Add(this.txtV2);
            this.Frame6.Controls.Add(this.txtV1);
            this.Frame6.Controls.Add(this.Label8);
            this.Frame6.Controls.Add(this.Label7);
            this.Frame6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Frame6.Location = new System.Drawing.Point(348, 164);
            this.Frame6.Name = "Frame6";
            this.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame6.Size = new System.Drawing.Size(112, 97);
            this.Frame6.TabIndex = 94;
            this.Frame6.TabStop = false;
            this.Frame6.Text = "Visibility (FS8 style)";
            // 
            // txtV2
            // 
            this.txtV2.AcceptsReturn = true;
            this.txtV2.BackColor = System.Drawing.SystemColors.Window;
            this.txtV2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtV2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtV2.Location = new System.Drawing.Point(42, 57);
            this.txtV2.MaxLength = 0;
            this.txtV2.Name = "txtV2";
            this.txtV2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtV2.Size = new System.Drawing.Size(52, 20);
            this.txtV2.TabIndex = 96;
            this.txtV2.Text = "0";
            this.txtV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV1
            // 
            this.txtV1.AcceptsReturn = true;
            this.txtV1.BackColor = System.Drawing.SystemColors.Window;
            this.txtV1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtV1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtV1.Location = new System.Drawing.Point(42, 27);
            this.txtV1.MaxLength = 0;
            this.txtV1.Name = "txtV1";
            this.txtV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtV1.Size = new System.Drawing.Size(52, 20);
            this.txtV1.TabIndex = 95;
            this.txtV1.Text = "0";
            this.txtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(2, 60);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(41, 16);
            this.Label8.TabIndex = 98;
            this.Label8.Text = "V2(m):";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.Transparent;
            this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label7.Location = new System.Drawing.Point(3, 30);
            this.Label7.Name = "Label7";
            this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label7.Size = new System.Drawing.Size(40, 19);
            this.Label7.TabIndex = 97;
            this.Label7.Text = "V1(m):";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _SSTab1_TabPage1
            // 
            this._SSTab1_TabPage1.Controls.Add(this.frLib);
            this._SSTab1_TabPage1.Controls.Add(this.labelLibMouse);
            this._SSTab1_TabPage1.Controls.Add(this._imgLib);
            this._SSTab1_TabPage1.Controls.Add(this.LabelCat);
            this._SSTab1_TabPage1.Controls.Add(this.labelFS);
            this._SSTab1_TabPage1.Controls.Add(this._lstLib);
            this._SSTab1_TabPage1.Controls.Add(this.txtLibID);
            this._SSTab1_TabPage1.Controls.Add(this._cmbLibCat);
            this._SSTab1_TabPage1.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
            this._SSTab1_TabPage1.Size = new System.Drawing.Size(486, 322);
            this._SSTab1_TabPage1.TabIndex = 1;
            this._SSTab1_TabPage1.Text = "Lib Objects";
            this._SSTab1_TabPage1.UseVisualStyleBackColor = true;
            // 
            // frLib
            // 
            this.frLib.BackColor = System.Drawing.Color.Transparent;
            this.frLib.Controls.Add(this._txtLibName);
            this.frLib.Controls.Add(this._txtLibWidth);
            this.frLib.Controls.Add(this._txtLibLength);
            this.frLib.Controls.Add(this._cmdUpDefault);
            this.frLib.Controls.Add(this._txtLibScale);
            this.frLib.Controls.Add(this.LabelLibName);
            this.frLib.Controls.Add(this.labelLib2);
            this.frLib.Controls.Add(this.LabelLib1);
            this.frLib.Controls.Add(this.LabelLib3);
            this.frLib.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.frLib.Location = new System.Drawing.Point(18, 18);
            this.frLib.Name = "frLib";
            this.frLib.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frLib.Size = new System.Drawing.Size(208, 91);
            this.frLib.TabIndex = 103;
            this.frLib.TabStop = false;
            this.frLib.Text = "Change Name Scale and Footprint";
            // 
            // _txtLibName
            // 
            this._txtLibName.AcceptsReturn = true;
            this._txtLibName.BackColor = System.Drawing.SystemColors.Window;
            this._txtLibName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLibName.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLibName.Location = new System.Drawing.Point(53, 60);
            this._txtLibName.MaxLength = 0;
            this._txtLibName.Name = "_txtLibName";
            this._txtLibName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLibName.Size = new System.Drawing.Size(143, 20);
            this._txtLibName.TabIndex = 106;
            this._txtLibName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtLibName.TextChanged += new System.EventHandler(this.TxtLibName_TextChanged);
            // 
            // _txtLibWidth
            // 
            this._txtLibWidth.AcceptsReturn = true;
            this._txtLibWidth.BackColor = System.Drawing.SystemColors.Window;
            this._txtLibWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLibWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLibWidth.Location = new System.Drawing.Point(70, 32);
            this._txtLibWidth.MaxLength = 0;
            this._txtLibWidth.Name = "_txtLibWidth";
            this._txtLibWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLibWidth.Size = new System.Drawing.Size(44, 20);
            this._txtLibWidth.TabIndex = 37;
            this._txtLibWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtLibWidth.TextChanged += new System.EventHandler(this.TxtLibWidth_TextChanged);
            // 
            // _txtLibLength
            // 
            this._txtLibLength.AcceptsReturn = true;
            this._txtLibLength.BackColor = System.Drawing.SystemColors.Window;
            this._txtLibLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLibLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLibLength.Location = new System.Drawing.Point(16, 32);
            this._txtLibLength.MaxLength = 0;
            this._txtLibLength.Name = "_txtLibLength";
            this._txtLibLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLibLength.Size = new System.Drawing.Size(45, 20);
            this._txtLibLength.TabIndex = 36;
            this._txtLibLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtLibLength.TextChanged += new System.EventHandler(this.TxtLibLength_TextChanged);
            // 
            // _cmdUpDefault
            // 
            this._cmdUpDefault.Enabled = false;
            this._cmdUpDefault.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUpDefault.Location = new System.Drawing.Point(163, 29);
            this._cmdUpDefault.Name = "_cmdUpDefault";
            this._cmdUpDefault.Size = new System.Drawing.Size(31, 23);
            this._cmdUpDefault.TabIndex = 105;
            this._cmdUpDefault.Text = "OK";
            this._cmdUpDefault.UseVisualStyleBackColor = true;
            this._cmdUpDefault.Click += new System.EventHandler(this.CmdUpDefault_Click);
            // 
            // _txtLibScale
            // 
            this._txtLibScale.AcceptsReturn = true;
            this._txtLibScale.BackColor = System.Drawing.SystemColors.Window;
            this._txtLibScale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLibScale.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLibScale.Location = new System.Drawing.Point(123, 32);
            this._txtLibScale.MaxLength = 0;
            this._txtLibScale.Name = "_txtLibScale";
            this._txtLibScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLibScale.Size = new System.Drawing.Size(29, 20);
            this._txtLibScale.TabIndex = 34;
            this._txtLibScale.Text = "1";
            this._txtLibScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtLibScale.TextChanged += new System.EventHandler(this.TxtLibScale_TextChanged);
            // 
            // LabelLibName
            // 
            this.LabelLibName.BackColor = System.Drawing.Color.Transparent;
            this.LabelLibName.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelLibName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelLibName.Location = new System.Drawing.Point(13, 63);
            this.LabelLibName.Name = "LabelLibName";
            this.LabelLibName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelLibName.Size = new System.Drawing.Size(51, 19);
            this.LabelLibName.TabIndex = 39;
            this.LabelLibName.Text = "Name:";
            // 
            // labelLib2
            // 
            this.labelLib2.BackColor = System.Drawing.Color.Transparent;
            this.labelLib2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelLib2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLib2.Location = new System.Drawing.Point(13, 17);
            this.labelLib2.Name = "labelLib2";
            this.labelLib2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLib2.Size = new System.Drawing.Size(51, 19);
            this.labelLib2.TabIndex = 39;
            this.labelLib2.Text = "Length:";
            // 
            // LabelLib1
            // 
            this.LabelLib1.BackColor = System.Drawing.Color.Transparent;
            this.LabelLib1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelLib1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelLib1.Location = new System.Drawing.Point(67, 17);
            this.LabelLib1.Name = "LabelLib1";
            this.LabelLib1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelLib1.Size = new System.Drawing.Size(38, 18);
            this.LabelLib1.TabIndex = 38;
            this.LabelLib1.Text = "Width:";
            // 
            // LabelLib3
            // 
            this.LabelLib3.BackColor = System.Drawing.Color.Transparent;
            this.LabelLib3.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelLib3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelLib3.Location = new System.Drawing.Point(120, 17);
            this.LabelLib3.Name = "LabelLib3";
            this.LabelLib3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelLib3.Size = new System.Drawing.Size(37, 16);
            this.LabelLib3.TabIndex = 35;
            this.LabelLib3.Text = "Scale:";
            // 
            // labelLibMouse
            // 
            this.labelLibMouse.AutoSize = true;
            this.labelLibMouse.Location = new System.Drawing.Point(16, 124);
            this.labelLibMouse.Name = "labelLibMouse";
            this.labelLibMouse.Size = new System.Drawing.Size(189, 13);
            this.labelLibMouse.TabIndex = 100;
            this.labelLibMouse.Text = "Mouse: left to enlarge; right to capture.";
            // 
            // _imgLib
            // 
            this._imgLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgLib.ContextMenuStrip = this.PopUpMenu;
            this._imgLib.Cursor = System.Windows.Forms.Cursors.Default;
            this._imgLib.Location = new System.Drawing.Point(18, 140);
            this._imgLib.Name = "_imgLib";
            this._imgLib.Size = new System.Drawing.Size(208, 166);
            this._imgLib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgLib.TabIndex = 0;
            this._imgLib.TabStop = false;
            this._imgLib.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgLib_MouseDown);
            // 
            // PopUpMenu
            // 
            this.PopUpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TitlePopUpMenuItem,
            this.ToolStripSeparator1,
            this._EnlargePopUpMenuItem,
            this._DeletePopUpMenuItem,
            this._FromFilePopUpMenuItem,
            this._CapturePopUpMenuItem,
            this._PurgePopUPMenuItem});
            this.PopUpMenu.Name = "PopUpMenu";
            this.PopUpMenu.Size = new System.Drawing.Size(134, 142);
            // 
            // TitlePopUpMenuItem
            // 
            this.TitlePopUpMenuItem.Name = "TitlePopUpMenuItem";
            this.TitlePopUpMenuItem.Size = new System.Drawing.Size(133, 22);
            this.TitlePopUpMenuItem.Text = "TITLE";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // _EnlargePopUpMenuItem
            // 
            this._EnlargePopUpMenuItem.Name = "_EnlargePopUpMenuItem";
            this._EnlargePopUpMenuItem.Size = new System.Drawing.Size(133, 22);
            this._EnlargePopUpMenuItem.Text = "Enlarge";
            this._EnlargePopUpMenuItem.Click += new System.EventHandler(this.EnlargePopUpMenuItem_Click);
            // 
            // _DeletePopUpMenuItem
            // 
            this._DeletePopUpMenuItem.Name = "_DeletePopUpMenuItem";
            this._DeletePopUpMenuItem.Size = new System.Drawing.Size(133, 22);
            this._DeletePopUpMenuItem.Text = "Delete";
            this._DeletePopUpMenuItem.Click += new System.EventHandler(this.DeletePopUpMenuItem_Click);
            // 
            // _FromFilePopUpMenuItem
            // 
            this._FromFilePopUpMenuItem.Name = "_FromFilePopUpMenuItem";
            this._FromFilePopUpMenuItem.Size = new System.Drawing.Size(133, 22);
            this._FromFilePopUpMenuItem.Text = "From file ...";
            this._FromFilePopUpMenuItem.Click += new System.EventHandler(this.FromFilePopUpMenuItem_Click);
            // 
            // _CapturePopUpMenuItem
            // 
            this._CapturePopUpMenuItem.Name = "_CapturePopUpMenuItem";
            this._CapturePopUpMenuItem.Size = new System.Drawing.Size(133, 22);
            this._CapturePopUpMenuItem.Text = "Capture ...";
            this._CapturePopUpMenuItem.Click += new System.EventHandler(this.CapturePopUPMenuItem_Click);
            // 
            // _PurgePopUPMenuItem
            // 
            this._PurgePopUPMenuItem.Name = "_PurgePopUPMenuItem";
            this._PurgePopUPMenuItem.Size = new System.Drawing.Size(133, 22);
            this._PurgePopUPMenuItem.Text = "Purge ...";
            this._PurgePopUPMenuItem.Click += new System.EventHandler(this.PurgePopUPMenuItem_Click);
            // 
            // LabelCat
            // 
            this.LabelCat.AutoSize = true;
            this.LabelCat.BackColor = System.Drawing.Color.Transparent;
            this.LabelCat.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelCat.Location = new System.Drawing.Point(243, 18);
            this.LabelCat.Name = "LabelCat";
            this.LabelCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelCat.Size = new System.Drawing.Size(83, 13);
            this.LabelCat.TabIndex = 51;
            this.LabelCat.Text = "Object Category";
            // 
            // labelFS
            // 
            this.labelFS.AutoSize = true;
            this.labelFS.BackColor = System.Drawing.Color.Transparent;
            this.labelFS.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFS.Location = new System.Drawing.Point(354, 117);
            this.labelFS.Name = "labelFS";
            this.labelFS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFS.Size = new System.Drawing.Size(116, 13);
            this.labelFS.TabIndex = 99;
            this.labelFS.Text = "New FS9 LibraryObject";
            this.labelFS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _lstLib
            // 
            this._lstLib.BackColor = System.Drawing.SystemColors.Window;
            this._lstLib.Cursor = System.Windows.Forms.Cursors.Default;
            this._lstLib.ForeColor = System.Drawing.SystemColors.WindowText;
            this._lstLib.Location = new System.Drawing.Point(246, 133);
            this._lstLib.Name = "_lstLib";
            this._lstLib.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lstLib.Size = new System.Drawing.Size(224, 173);
            this._lstLib.TabIndex = 31;
            this._lstLib.SelectedIndexChanged += new System.EventHandler(this.LstLib_SelectedIndexChanged);
            // 
            // txtLibID
            // 
            this.txtLibID.AcceptsReturn = true;
            this.txtLibID.BackColor = System.Drawing.SystemColors.Window;
            this.txtLibID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLibID.Location = new System.Drawing.Point(246, 78);
            this.txtLibID.MaxLength = 0;
            this.txtLibID.Name = "txtLibID";
            this.txtLibID.ReadOnly = true;
            this.txtLibID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLibID.Size = new System.Drawing.Size(224, 20);
            this.txtLibID.TabIndex = 32;
            this.txtLibID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmbLibCat
            // 
            this._cmbLibCat.BackColor = System.Drawing.SystemColors.Window;
            this._cmbLibCat.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmbLibCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbLibCat.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cmbLibCat.Location = new System.Drawing.Point(246, 34);
            this._cmbLibCat.Name = "_cmbLibCat";
            this._cmbLibCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmbLibCat.Size = new System.Drawing.Size(224, 21);
            this._cmbLibCat.TabIndex = 50;
            this._cmbLibCat.SelectedIndexChanged += new System.EventHandler(this.CmbLibCat_SelectedIndexChanged);
            // 
            // _SSTab1_TabPage2
            // 
            this._SSTab1_TabPage2.Controls.Add(this.Label16);
            this._SSTab1_TabPage2.Controls.Add(this.Label14);
            this._SSTab1_TabPage2.Controls.Add(this.Label15);
            this._SSTab1_TabPage2.Controls.Add(this._cmdGBDelete);
            this._SSTab1_TabPage2.Controls.Add(this._cmdGbStore);
            this._SSTab1_TabPage2.Controls.Add(this._cmdGbLoad);
            this._SSTab1_TabPage2.Controls.Add(this._lstGenB);
            this._SSTab1_TabPage2.Controls.Add(this.nUPscale);
            this._SSTab1_TabPage2.Controls.Add(this.nUPsizeZ);
            this._SSTab1_TabPage2.Controls.Add(this.nUPsizeX);
            this._SSTab1_TabPage2.Controls.Add(this._cmdGbDetail);
            this._SSTab1_TabPage2.Controls.Add(this.lbgb2);
            this._SSTab1_TabPage2.Controls.Add(this.lbgb1);
            this._SSTab1_TabPage2.Controls.Add(this._imgGenB);
            this._SSTab1_TabPage2.Controls.Add(this.frGenB);
            this._SSTab1_TabPage2.Controls.Add(this.lbgb3);
            this._SSTab1_TabPage2.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage2.Name = "_SSTab1_TabPage2";
            this._SSTab1_TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._SSTab1_TabPage2.Size = new System.Drawing.Size(486, 322);
            this._SSTab1_TabPage2.TabIndex = 5;
            this._SSTab1_TabPage2.Text = "Gen Buildings";
            this._SSTab1_TabPage2.UseVisualStyleBackColor = true;
            // 
            // Label16
            // 
            this.Label16.BackColor = System.Drawing.Color.Black;
            this.Label16.Location = new System.Drawing.Point(20, 109);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(446, 8);
            this.Label16.TabIndex = 116;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(240, 169);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(142, 13);
            this.Label14.TabIndex = 115;
            this.Label14.Text = "Pre-Stored Generic Buildings";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(18, 127);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(189, 13);
            this.Label15.TabIndex = 115;
            this.Label15.Text = "Mouse: left to enlarge; right to capture.";
            // 
            // _cmdGBDelete
            // 
            this._cmdGBDelete.BackColor = System.Drawing.SystemColors.Control;
            this._cmdGBDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdGBDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._cmdGBDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdGBDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cmdGBDelete.Location = new System.Drawing.Point(414, 140);
            this._cmdGBDelete.Name = "_cmdGBDelete";
            this._cmdGBDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdGBDelete.Size = new System.Drawing.Size(51, 25);
            this._cmdGBDelete.TabIndex = 113;
            this._cmdGBDelete.Text = "Delete";
            this._cmdGBDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this._cmdGBDelete.UseVisualStyleBackColor = false;
            this._cmdGBDelete.Click += new System.EventHandler(this.CmdGBDelete_Click);
            // 
            // _cmdGbStore
            // 
            this._cmdGbStore.BackColor = System.Drawing.SystemColors.Control;
            this._cmdGbStore.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdGbStore.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdGbStore.Image = ((System.Drawing.Image)(resources.GetObject("_cmdGbStore.Image")));
            this._cmdGbStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cmdGbStore.Location = new System.Drawing.Point(301, 141);
            this._cmdGbStore.Name = "_cmdGbStore";
            this._cmdGbStore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdGbStore.Size = new System.Drawing.Size(52, 25);
            this._cmdGbStore.TabIndex = 113;
            this._cmdGbStore.Text = "Store";
            this._cmdGbStore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cmdGbStore.UseVisualStyleBackColor = false;
            this._cmdGbStore.Click += new System.EventHandler(this.CmdGbStore_Click);
            // 
            // _cmdGbLoad
            // 
            this._cmdGbLoad.BackColor = System.Drawing.SystemColors.Control;
            this._cmdGbLoad.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdGbLoad.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdGbLoad.Image = ((System.Drawing.Image)(resources.GetObject("_cmdGbLoad.Image")));
            this._cmdGbLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._cmdGbLoad.Location = new System.Drawing.Point(243, 140);
            this._cmdGbLoad.Name = "_cmdGbLoad";
            this._cmdGbLoad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdGbLoad.Size = new System.Drawing.Size(52, 25);
            this._cmdGbLoad.TabIndex = 112;
            this._cmdGbLoad.Text = "Load";
            this._cmdGbLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._cmdGbLoad.UseVisualStyleBackColor = false;
            this._cmdGbLoad.Click += new System.EventHandler(this.CmdGbLoad_Click);
            // 
            // _lstGenB
            // 
            this._lstGenB.BackColor = System.Drawing.SystemColors.Window;
            this._lstGenB.Cursor = System.Windows.Forms.Cursors.Default;
            this._lstGenB.ForeColor = System.Drawing.SystemColors.WindowText;
            this._lstGenB.Location = new System.Drawing.Point(243, 184);
            this._lstGenB.Name = "_lstGenB";
            this._lstGenB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lstGenB.Size = new System.Drawing.Size(224, 121);
            this._lstGenB.TabIndex = 60;
            this._lstGenB.SelectedIndexChanged += new System.EventHandler(this.LstGenB_SelectedIndexChanged);
            // 
            // nUPscale
            // 
            this.nUPscale.BackColor = System.Drawing.SystemColors.Window;
            this.nUPscale.DecimalPlaces = 2;
            this.nUPscale.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPscale.Location = new System.Drawing.Point(414, 33);
            this.nUPscale.Name = "nUPscale";
            this.nUPscale.Size = new System.Drawing.Size(51, 20);
            this.nUPscale.TabIndex = 58;
            this.nUPscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPscale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPsizeZ
            // 
            this.nUPsizeZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeZ.DecimalPlaces = 2;
            this.nUPsizeZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPsizeZ.Location = new System.Drawing.Point(340, 33);
            this.nUPsizeZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPsizeZ.Name = "nUPsizeZ";
            this.nUPsizeZ.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeZ.TabIndex = 57;
            this.nUPsizeZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeZ.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPsizeX
            // 
            this.nUPsizeX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeX.DecimalPlaces = 2;
            this.nUPsizeX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPsizeX.Location = new System.Drawing.Point(267, 33);
            this.nUPsizeX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPsizeX.Name = "nUPsizeX";
            this.nUPsizeX.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeX.TabIndex = 56;
            this.nUPsizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // _cmdGbDetail
            // 
            this._cmdGbDetail.BackColor = System.Drawing.Color.Transparent;
            this._cmdGbDetail.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdGbDetail.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdGbDetail.Location = new System.Drawing.Point(414, 59);
            this._cmdGbDetail.Name = "_cmdGbDetail";
            this._cmdGbDetail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdGbDetail.Size = new System.Drawing.Size(53, 26);
            this._cmdGbDetail.TabIndex = 52;
            this._cmdGbDetail.Text = "Detail";
            this._cmdGbDetail.UseVisualStyleBackColor = false;
            this._cmdGbDetail.Click += new System.EventHandler(this.CmdGbDetail_Click);
            // 
            // lbgb2
            // 
            this.lbgb2.AutoSize = true;
            this.lbgb2.Location = new System.Drawing.Point(337, 17);
            this.lbgb2.Name = "lbgb2";
            this.lbgb2.Size = new System.Drawing.Size(43, 13);
            this.lbgb2.TabIndex = 55;
            this.lbgb2.Text = "Deep Z";
            // 
            // lbgb1
            // 
            this.lbgb1.AutoSize = true;
            this.lbgb1.Location = new System.Drawing.Point(266, 17);
            this.lbgb1.Name = "lbgb1";
            this.lbgb1.Size = new System.Drawing.Size(45, 13);
            this.lbgb1.TabIndex = 54;
            this.lbgb1.Text = "Width X";
            // 
            // _imgGenB
            // 
            this._imgGenB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgGenB.ContextMenuStrip = this.PopUpMenu;
            this._imgGenB.Cursor = System.Windows.Forms.Cursors.Default;
            this._imgGenB.Location = new System.Drawing.Point(18, 140);
            this._imgGenB.Name = "_imgGenB";
            this._imgGenB.Size = new System.Drawing.Size(208, 165);
            this._imgGenB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgGenB.TabIndex = 34;
            this._imgGenB.TabStop = false;
            this._imgGenB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgGenB_MouseDown);
            // 
            // frGenB
            // 
            this.frGenB.BackColor = System.Drawing.Color.Transparent;
            this.frGenB.Controls.Add(this.optGbMultiSided);
            this.frGenB.Controls.Add(this.optGbPyramidal);
            this.frGenB.Controls.Add(this.optGbSlant);
            this.frGenB.Controls.Add(this.optGbRidge);
            this.frGenB.Controls.Add(this.optGbPeaked);
            this.frGenB.Controls.Add(this.optGbFlat);
            this.frGenB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.frGenB.Location = new System.Drawing.Point(18, 12);
            this.frGenB.Name = "frGenB";
            this.frGenB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frGenB.Size = new System.Drawing.Size(232, 81);
            this.frGenB.TabIndex = 35;
            this.frGenB.TabStop = false;
            this.frGenB.Text = "Building Type";
            // 
            // optGbMultiSided
            // 
            this.optGbMultiSided.AutoSize = true;
            this.optGbMultiSided.ForeColor = System.Drawing.Color.Black;
            this.optGbMultiSided.Location = new System.Drawing.Point(152, 46);
            this.optGbMultiSided.Name = "optGbMultiSided";
            this.optGbMultiSided.Size = new System.Drawing.Size(74, 17);
            this.optGbMultiSided.TabIndex = 0;
            this.optGbMultiSided.Text = "MultiSided";
            this.optGbMultiSided.UseVisualStyleBackColor = true;
            // 
            // optGbPyramidal
            // 
            this.optGbPyramidal.AutoSize = true;
            this.optGbPyramidal.ForeColor = System.Drawing.Color.Black;
            this.optGbPyramidal.Location = new System.Drawing.Point(152, 23);
            this.optGbPyramidal.Name = "optGbPyramidal";
            this.optGbPyramidal.Size = new System.Drawing.Size(70, 17);
            this.optGbPyramidal.TabIndex = 0;
            this.optGbPyramidal.Text = "Pyramidal";
            this.optGbPyramidal.UseVisualStyleBackColor = true;
            // 
            // optGbSlant
            // 
            this.optGbSlant.AutoSize = true;
            this.optGbSlant.ForeColor = System.Drawing.Color.Black;
            this.optGbSlant.Location = new System.Drawing.Point(81, 47);
            this.optGbSlant.Name = "optGbSlant";
            this.optGbSlant.Size = new System.Drawing.Size(49, 17);
            this.optGbSlant.TabIndex = 0;
            this.optGbSlant.Text = "Slant";
            this.optGbSlant.UseVisualStyleBackColor = true;
            // 
            // optGbRidge
            // 
            this.optGbRidge.AutoSize = true;
            this.optGbRidge.ForeColor = System.Drawing.Color.Black;
            this.optGbRidge.Location = new System.Drawing.Point(81, 24);
            this.optGbRidge.Name = "optGbRidge";
            this.optGbRidge.Size = new System.Drawing.Size(53, 17);
            this.optGbRidge.TabIndex = 0;
            this.optGbRidge.Text = "Ridge";
            this.optGbRidge.UseVisualStyleBackColor = true;
            // 
            // optGbPeaked
            // 
            this.optGbPeaked.AutoSize = true;
            this.optGbPeaked.ForeColor = System.Drawing.Color.Black;
            this.optGbPeaked.Location = new System.Drawing.Point(14, 46);
            this.optGbPeaked.Name = "optGbPeaked";
            this.optGbPeaked.Size = new System.Drawing.Size(62, 17);
            this.optGbPeaked.TabIndex = 0;
            this.optGbPeaked.Text = "Peaked";
            this.optGbPeaked.UseVisualStyleBackColor = true;
            // 
            // optGbFlat
            // 
            this.optGbFlat.AutoSize = true;
            this.optGbFlat.Checked = true;
            this.optGbFlat.ForeColor = System.Drawing.Color.Black;
            this.optGbFlat.Location = new System.Drawing.Point(14, 23);
            this.optGbFlat.Name = "optGbFlat";
            this.optGbFlat.Size = new System.Drawing.Size(42, 17);
            this.optGbFlat.TabIndex = 0;
            this.optGbFlat.TabStop = true;
            this.optGbFlat.Text = "Flat";
            this.optGbFlat.UseVisualStyleBackColor = true;
            // 
            // lbgb3
            // 
            this.lbgb3.BackColor = System.Drawing.Color.Transparent;
            this.lbgb3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbgb3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbgb3.Location = new System.Drawing.Point(411, 17);
            this.lbgb3.Name = "lbgb3";
            this.lbgb3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbgb3.Size = new System.Drawing.Size(37, 16);
            this.lbgb3.TabIndex = 35;
            this.lbgb3.Text = "Scale";
            this.lbgb3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _SSTab1_TabPage3
            // 
            this._SSTab1_TabPage3.Controls.Add(this.labelMacroMouse);
            this._SSTab1_TabPage3.Controls.Add(this.LabelMacro1);
            this._SSTab1_TabPage3.Controls.Add(this.LabelMacroCat);
            this._SSTab1_TabPage3.Controls.Add(this._imgMacro);
            this._SSTab1_TabPage3.Controls.Add(this._frMacro);
            this._SSTab1_TabPage3.Controls.Add(this._cmbMacroCat);
            this._SSTab1_TabPage3.Controls.Add(this._lstMacro);
            this._SSTab1_TabPage3.Controls.Add(this._frMacro1);
            this._SSTab1_TabPage3.Controls.Add(this._cmdMacroEdit);
            this._SSTab1_TabPage3.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage3.Name = "_SSTab1_TabPage3";
            this._SSTab1_TabPage3.Size = new System.Drawing.Size(486, 322);
            this._SSTab1_TabPage3.TabIndex = 2;
            this._SSTab1_TabPage3.Text = "Macros";
            this._SSTab1_TabPage3.UseVisualStyleBackColor = true;
            // 
            // labelMacroMouse
            // 
            this.labelMacroMouse.AutoSize = true;
            this.labelMacroMouse.Location = new System.Drawing.Point(15, 125);
            this.labelMacroMouse.Name = "labelMacroMouse";
            this.labelMacroMouse.Size = new System.Drawing.Size(189, 13);
            this.labelMacroMouse.TabIndex = 120;
            this.labelMacroMouse.Text = "Mouse: left to enlarge; right to capture.";
            // 
            // LabelMacro1
            // 
            this.LabelMacro1.BackColor = System.Drawing.Color.Transparent;
            this.LabelMacro1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMacro1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMacro1.Location = new System.Drawing.Point(243, 195);
            this.LabelMacro1.Name = "LabelMacro1";
            this.LabelMacro1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMacro1.Size = new System.Drawing.Size(109, 16);
            this.LabelMacro1.TabIndex = 109;
            this.LabelMacro1.Text = "Macro Object";
            // 
            // LabelMacroCat
            // 
            this.LabelMacroCat.BackColor = System.Drawing.Color.Transparent;
            this.LabelMacroCat.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMacroCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMacroCat.Location = new System.Drawing.Point(243, 152);
            this.LabelMacroCat.Name = "LabelMacroCat";
            this.LabelMacroCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMacroCat.Size = new System.Drawing.Size(55, 16);
            this.LabelMacroCat.TabIndex = 110;
            this.LabelMacroCat.Text = "Category:";
            // 
            // _imgMacro
            // 
            this._imgMacro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgMacro.ContextMenuStrip = this.PopUpMenu;
            this._imgMacro.Cursor = System.Windows.Forms.Cursors.Default;
            this._imgMacro.Location = new System.Drawing.Point(18, 141);
            this._imgMacro.Name = "_imgMacro";
            this._imgMacro.Size = new System.Drawing.Size(208, 166);
            this._imgMacro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgMacro.TabIndex = 111;
            this._imgMacro.TabStop = false;
            this._imgMacro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgMacro_MouseDown);
            // 
            // _frMacro
            // 
            this._frMacro.BackColor = System.Drawing.Color.Transparent;
            this._frMacro.Controls.Add(this.txtMacroRange);
            this._frMacro.Controls.Add(this.txtMacroScale);
            this._frMacro.Controls.Add(this.txtMacroLength);
            this._frMacro.Controls.Add(this.txtMacroWidth);
            this._frMacro.Controls.Add(this.LabelMacroRange);
            this._frMacro.Controls.Add(this.LabelMacroScale);
            this._frMacro.Controls.Add(this.LabelMacroWidth);
            this._frMacro.Controls.Add(this.LabelMacroLength);
            this._frMacro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frMacro.Location = new System.Drawing.Point(18, 18);
            this._frMacro.Name = "_frMacro";
            this._frMacro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frMacro.Size = new System.Drawing.Size(208, 103);
            this._frMacro.TabIndex = 100;
            this._frMacro.TabStop = false;
            this._frMacro.Text = "Scale and Footprint";
            this._frMacro.Click += new System.EventHandler(this.Frmacro_Click);
            // 
            // txtMacroRange
            // 
            this.txtMacroRange.AcceptsReturn = true;
            this.txtMacroRange.BackColor = System.Drawing.SystemColors.Window;
            this.txtMacroRange.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMacroRange.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMacroRange.Location = new System.Drawing.Point(150, 66);
            this.txtMacroRange.MaxLength = 0;
            this.txtMacroRange.Name = "txtMacroRange";
            this.txtMacroRange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMacroRange.Size = new System.Drawing.Size(36, 20);
            this.txtMacroRange.TabIndex = 112;
            this.txtMacroRange.Text = "30";
            this.txtMacroRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMacroScale
            // 
            this.txtMacroScale.AcceptsReturn = true;
            this.txtMacroScale.BackColor = System.Drawing.SystemColors.Window;
            this.txtMacroScale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMacroScale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMacroScale.Location = new System.Drawing.Point(150, 25);
            this.txtMacroScale.MaxLength = 0;
            this.txtMacroScale.Name = "txtMacroScale";
            this.txtMacroScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMacroScale.Size = new System.Drawing.Size(36, 20);
            this.txtMacroScale.TabIndex = 103;
            this.txtMacroScale.Text = "1";
            this.txtMacroScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMacroLength
            // 
            this.txtMacroLength.AcceptsReturn = true;
            this.txtMacroLength.BackColor = System.Drawing.SystemColors.Window;
            this.txtMacroLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMacroLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMacroLength.Location = new System.Drawing.Point(55, 25);
            this.txtMacroLength.MaxLength = 0;
            this.txtMacroLength.Name = "txtMacroLength";
            this.txtMacroLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMacroLength.Size = new System.Drawing.Size(36, 20);
            this.txtMacroLength.TabIndex = 102;
            this.txtMacroLength.Text = "20";
            this.txtMacroLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMacroWidth
            // 
            this.txtMacroWidth.AcceptsReturn = true;
            this.txtMacroWidth.BackColor = System.Drawing.SystemColors.Window;
            this.txtMacroWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMacroWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMacroWidth.Location = new System.Drawing.Point(55, 65);
            this.txtMacroWidth.MaxLength = 0;
            this.txtMacroWidth.Name = "txtMacroWidth";
            this.txtMacroWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMacroWidth.Size = new System.Drawing.Size(36, 20);
            this.txtMacroWidth.TabIndex = 101;
            this.txtMacroWidth.Text = "30";
            this.txtMacroWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelMacroRange
            // 
            this.LabelMacroRange.BackColor = System.Drawing.Color.Transparent;
            this.LabelMacroRange.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMacroRange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMacroRange.Location = new System.Drawing.Point(97, 67);
            this.LabelMacroRange.Name = "LabelMacroRange";
            this.LabelMacroRange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMacroRange.Size = new System.Drawing.Size(48, 14);
            this.LabelMacroRange.TabIndex = 113;
            this.LabelMacroRange.Text = "Range:";
            this.LabelMacroRange.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMacroScale
            // 
            this.LabelMacroScale.BackColor = System.Drawing.Color.Transparent;
            this.LabelMacroScale.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMacroScale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMacroScale.Location = new System.Drawing.Point(108, 28);
            this.LabelMacroScale.Name = "LabelMacroScale";
            this.LabelMacroScale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMacroScale.Size = new System.Drawing.Size(37, 16);
            this.LabelMacroScale.TabIndex = 106;
            this.LabelMacroScale.Text = "Scale:";
            this.LabelMacroScale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMacroWidth
            // 
            this.LabelMacroWidth.BackColor = System.Drawing.Color.Transparent;
            this.LabelMacroWidth.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMacroWidth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMacroWidth.Location = new System.Drawing.Point(11, 66);
            this.LabelMacroWidth.Name = "LabelMacroWidth";
            this.LabelMacroWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMacroWidth.Size = new System.Drawing.Size(38, 19);
            this.LabelMacroWidth.TabIndex = 105;
            this.LabelMacroWidth.Text = "Width:";
            this.LabelMacroWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMacroLength
            // 
            this.LabelMacroLength.BackColor = System.Drawing.Color.Transparent;
            this.LabelMacroLength.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMacroLength.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMacroLength.Location = new System.Drawing.Point(6, 28);
            this.LabelMacroLength.Name = "LabelMacroLength";
            this.LabelMacroLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMacroLength.Size = new System.Drawing.Size(43, 19);
            this.LabelMacroLength.TabIndex = 104;
            this.LabelMacroLength.Text = "Length:";
            this.LabelMacroLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _cmbMacroCat
            // 
            this._cmbMacroCat.BackColor = System.Drawing.SystemColors.Window;
            this._cmbMacroCat.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmbMacroCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbMacroCat.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cmbMacroCat.Location = new System.Drawing.Point(246, 171);
            this._cmbMacroCat.Name = "_cmbMacroCat";
            this._cmbMacroCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmbMacroCat.Size = new System.Drawing.Size(153, 21);
            this._cmbMacroCat.TabIndex = 107;
            this._cmbMacroCat.SelectedIndexChanged += new System.EventHandler(this.CmbMacroCat_SelectedIndexChanged);
            // 
            // _lstMacro
            // 
            this._lstMacro.BackColor = System.Drawing.SystemColors.Window;
            this._lstMacro.Cursor = System.Windows.Forms.Cursors.Default;
            this._lstMacro.ForeColor = System.Drawing.SystemColors.WindowText;
            this._lstMacro.Location = new System.Drawing.Point(246, 212);
            this._lstMacro.Name = "_lstMacro";
            this._lstMacro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lstMacro.Size = new System.Drawing.Size(225, 95);
            this._lstMacro.TabIndex = 108;
            this._lstMacro.SelectedIndexChanged += new System.EventHandler(this.LstMacro_SelectedIndexChanged);
            // 
            // _frMacro1
            // 
            this._frMacro1.BackColor = System.Drawing.Color.Transparent;
            this._frMacro1.Controls.Add(this._cmdExpand);
            this._frMacro1.Controls.Add(this.txtP7);
            this._frMacro1.Controls.Add(this.txtP9);
            this._frMacro1.Controls.Add(this.txtP8);
            this._frMacro1.Controls.Add(this.txtP6);
            this._frMacro1.Controls.Add(this.lbP9);
            this._frMacro1.Controls.Add(this.lbP7);
            this._frMacro1.Controls.Add(this.lbP8);
            this._frMacro1.Controls.Add(this.lbP6);
            this._frMacro1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frMacro1.Location = new System.Drawing.Point(246, 18);
            this._frMacro1.Name = "_frMacro1";
            this._frMacro1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frMacro1.Size = new System.Drawing.Size(225, 120);
            this._frMacro1.TabIndex = 114;
            this._frMacro1.TabStop = false;
            this._frMacro1.Text = "Other Parameters";
            this._frMacro1.Click += new System.EventHandler(this.Frmacro1_Click);
            // 
            // _cmdExpand
            // 
            this._cmdExpand.BackColor = System.Drawing.Color.Transparent;
            this._cmdExpand.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdExpand.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdExpand.Location = new System.Drawing.Point(91, 55);
            this._cmdExpand.Name = "_cmdExpand";
            this._cmdExpand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdExpand.Size = new System.Drawing.Size(41, 25);
            this._cmdExpand.TabIndex = 124;
            this._cmdExpand.Text = "More";
            this._cmdExpand.UseVisualStyleBackColor = false;
            this._cmdExpand.Click += new System.EventHandler(this.CmdExpand_Click);
            // 
            // txtP7
            // 
            this.txtP7.AcceptsReturn = true;
            this.txtP7.BackColor = System.Drawing.SystemColors.Window;
            this.txtP7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtP7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtP7.Location = new System.Drawing.Point(152, 37);
            this.txtP7.MaxLength = 0;
            this.txtP7.Name = "txtP7";
            this.txtP7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtP7.Size = new System.Drawing.Size(61, 20);
            this.txtP7.TabIndex = 118;
            this.txtP7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP9
            // 
            this.txtP9.AcceptsReturn = true;
            this.txtP9.BackColor = System.Drawing.SystemColors.Window;
            this.txtP9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtP9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtP9.Location = new System.Drawing.Point(150, 83);
            this.txtP9.MaxLength = 0;
            this.txtP9.Name = "txtP9";
            this.txtP9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtP9.Size = new System.Drawing.Size(63, 20);
            this.txtP9.TabIndex = 117;
            this.txtP9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP8
            // 
            this.txtP8.AcceptsReturn = true;
            this.txtP8.BackColor = System.Drawing.SystemColors.Window;
            this.txtP8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtP8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtP8.Location = new System.Drawing.Point(12, 83);
            this.txtP8.MaxLength = 0;
            this.txtP8.Name = "txtP8";
            this.txtP8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtP8.Size = new System.Drawing.Size(61, 20);
            this.txtP8.TabIndex = 116;
            this.txtP8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtP6
            // 
            this.txtP6.AcceptsReturn = true;
            this.txtP6.BackColor = System.Drawing.SystemColors.Window;
            this.txtP6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtP6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtP6.Location = new System.Drawing.Point(12, 37);
            this.txtP6.MaxLength = 0;
            this.txtP6.Name = "txtP6";
            this.txtP6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtP6.Size = new System.Drawing.Size(61, 20);
            this.txtP6.TabIndex = 115;
            this.txtP6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbP9
            // 
            this.lbP9.AutoSize = true;
            this.lbP9.BackColor = System.Drawing.Color.Transparent;
            this.lbP9.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbP9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbP9.Location = new System.Drawing.Point(149, 67);
            this.lbP9.Name = "lbP9";
            this.lbP9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbP9.Size = new System.Drawing.Size(20, 13);
            this.lbP9.TabIndex = 123;
            this.lbP9.Text = "P9";
            // 
            // lbP7
            // 
            this.lbP7.AutoSize = true;
            this.lbP7.BackColor = System.Drawing.Color.Transparent;
            this.lbP7.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbP7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbP7.Location = new System.Drawing.Point(149, 21);
            this.lbP7.Name = "lbP7";
            this.lbP7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbP7.Size = new System.Drawing.Size(20, 13);
            this.lbP7.TabIndex = 122;
            this.lbP7.Text = "P7";
            // 
            // lbP8
            // 
            this.lbP8.AutoSize = true;
            this.lbP8.BackColor = System.Drawing.Color.Transparent;
            this.lbP8.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbP8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbP8.Location = new System.Drawing.Point(9, 67);
            this.lbP8.Name = "lbP8";
            this.lbP8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbP8.Size = new System.Drawing.Size(20, 13);
            this.lbP8.TabIndex = 121;
            this.lbP8.Text = "P8";
            // 
            // lbP6
            // 
            this.lbP6.AutoSize = true;
            this.lbP6.BackColor = System.Drawing.Color.Transparent;
            this.lbP6.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbP6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbP6.Location = new System.Drawing.Point(9, 21);
            this.lbP6.Name = "lbP6";
            this.lbP6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbP6.Size = new System.Drawing.Size(64, 13);
            this.lbP6.TabIndex = 120;
            this.lbP6.Text = "Parameter 6";
            // 
            // _cmdMacroEdit
            // 
            this._cmdMacroEdit.BackColor = System.Drawing.Color.Transparent;
            this._cmdMacroEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdMacroEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdMacroEdit.Location = new System.Drawing.Point(414, 168);
            this._cmdMacroEdit.Name = "_cmdMacroEdit";
            this._cmdMacroEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdMacroEdit.Size = new System.Drawing.Size(57, 25);
            this._cmdMacroEdit.TabIndex = 119;
            this._cmdMacroEdit.Text = "Edit";
            this._cmdMacroEdit.UseVisualStyleBackColor = false;
            this._cmdMacroEdit.Click += new System.EventHandler(this.CmdMacroEdit_Click);
            // 
            // _SSTab1_TabPage4
            // 
            this._SSTab1_TabPage4.Controls.Add(this.labelRwy12Mouse);
            this._SSTab1_TabPage4.Controls.Add(this._lstRwy12);
            this._SSTab1_TabPage4.Controls.Add(this.txtRwy12ID);
            this._SSTab1_TabPage4.Controls.Add(this._frRwy12);
            this._SSTab1_TabPage4.Controls.Add(this._cmbRwy12Cat);
            this._SSTab1_TabPage4.Controls.Add(this.LabelRwy121);
            this._SSTab1_TabPage4.Controls.Add(this._imgRwy12);
            this._SSTab1_TabPage4.Controls.Add(this.LabelRwy12Cat);
            this._SSTab1_TabPage4.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage4.Name = "_SSTab1_TabPage4";
            this._SSTab1_TabPage4.Size = new System.Drawing.Size(486, 322);
            this._SSTab1_TabPage4.TabIndex = 3;
            this._SSTab1_TabPage4.Text = "Rwy12 Objects";
            this._SSTab1_TabPage4.UseVisualStyleBackColor = true;
            // 
            // labelRwy12Mouse
            // 
            this.labelRwy12Mouse.AutoSize = true;
            this.labelRwy12Mouse.Location = new System.Drawing.Point(15, 124);
            this.labelRwy12Mouse.Name = "labelRwy12Mouse";
            this.labelRwy12Mouse.Size = new System.Drawing.Size(189, 13);
            this.labelRwy12Mouse.TabIndex = 113;
            this.labelRwy12Mouse.Text = "Mouse: left to enlarge; right to capture.";
            // 
            // _lstRwy12
            // 
            this._lstRwy12.BackColor = System.Drawing.SystemColors.Window;
            this._lstRwy12.Cursor = System.Windows.Forms.Cursors.Default;
            this._lstRwy12.ForeColor = System.Drawing.SystemColors.WindowText;
            this._lstRwy12.Location = new System.Drawing.Point(246, 133);
            this._lstRwy12.Name = "_lstRwy12";
            this._lstRwy12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lstRwy12.Size = new System.Drawing.Size(224, 173);
            this._lstRwy12.TabIndex = 92;
            this._lstRwy12.SelectedIndexChanged += new System.EventHandler(this.LstRwy12_SelectedIndexChanged);
            // 
            // txtRwy12ID
            // 
            this.txtRwy12ID.AcceptsReturn = true;
            this.txtRwy12ID.BackColor = System.Drawing.SystemColors.Window;
            this.txtRwy12ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRwy12ID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRwy12ID.Location = new System.Drawing.Point(246, 78);
            this.txtRwy12ID.MaxLength = 0;
            this.txtRwy12ID.Name = "txtRwy12ID";
            this.txtRwy12ID.ReadOnly = true;
            this.txtRwy12ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRwy12ID.Size = new System.Drawing.Size(224, 20);
            this.txtRwy12ID.TabIndex = 91;
            this.txtRwy12ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _frRwy12
            // 
            this._frRwy12.BackColor = System.Drawing.Color.Transparent;
            this._frRwy12.Controls.Add(this.txtRwy12Scale);
            this._frRwy12.Controls.Add(this.txtRwy12Length);
            this._frRwy12.Controls.Add(this.txtRwy12Width);
            this._frRwy12.Controls.Add(this.LabelRwy12Scale);
            this._frRwy12.Controls.Add(this.LabelRwy12Width);
            this._frRwy12.Controls.Add(this.LabelRwy12Length);
            this._frRwy12.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frRwy12.Location = new System.Drawing.Point(18, 18);
            this._frRwy12.Name = "_frRwy12";
            this._frRwy12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frRwy12.Size = new System.Drawing.Size(208, 103);
            this._frRwy12.TabIndex = 84;
            this._frRwy12.TabStop = false;
            this._frRwy12.Text = "Scale and Footprint";
            this._frRwy12.Click += new System.EventHandler(this.FrRwy12_Click);
            // 
            // txtRwy12Scale
            // 
            this.txtRwy12Scale.AcceptsReturn = true;
            this.txtRwy12Scale.BackColor = System.Drawing.SystemColors.Window;
            this.txtRwy12Scale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRwy12Scale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRwy12Scale.Location = new System.Drawing.Point(150, 25);
            this.txtRwy12Scale.MaxLength = 0;
            this.txtRwy12Scale.Name = "txtRwy12Scale";
            this.txtRwy12Scale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRwy12Scale.Size = new System.Drawing.Size(36, 20);
            this.txtRwy12Scale.TabIndex = 87;
            this.txtRwy12Scale.Text = "1";
            this.txtRwy12Scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRwy12Length
            // 
            this.txtRwy12Length.AcceptsReturn = true;
            this.txtRwy12Length.BackColor = System.Drawing.SystemColors.Window;
            this.txtRwy12Length.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRwy12Length.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRwy12Length.Location = new System.Drawing.Point(55, 25);
            this.txtRwy12Length.MaxLength = 0;
            this.txtRwy12Length.Name = "txtRwy12Length";
            this.txtRwy12Length.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRwy12Length.Size = new System.Drawing.Size(36, 20);
            this.txtRwy12Length.TabIndex = 86;
            this.txtRwy12Length.Text = "20";
            this.txtRwy12Length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRwy12Width
            // 
            this.txtRwy12Width.AcceptsReturn = true;
            this.txtRwy12Width.BackColor = System.Drawing.SystemColors.Window;
            this.txtRwy12Width.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRwy12Width.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtRwy12Width.Location = new System.Drawing.Point(55, 65);
            this.txtRwy12Width.MaxLength = 0;
            this.txtRwy12Width.Name = "txtRwy12Width";
            this.txtRwy12Width.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRwy12Width.Size = new System.Drawing.Size(36, 20);
            this.txtRwy12Width.TabIndex = 85;
            this.txtRwy12Width.Text = "30";
            this.txtRwy12Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelRwy12Scale
            // 
            this.LabelRwy12Scale.BackColor = System.Drawing.Color.Transparent;
            this.LabelRwy12Scale.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelRwy12Scale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelRwy12Scale.Location = new System.Drawing.Point(108, 28);
            this.LabelRwy12Scale.Name = "LabelRwy12Scale";
            this.LabelRwy12Scale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelRwy12Scale.Size = new System.Drawing.Size(37, 16);
            this.LabelRwy12Scale.TabIndex = 90;
            this.LabelRwy12Scale.Text = "Scale:";
            this.LabelRwy12Scale.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelRwy12Width
            // 
            this.LabelRwy12Width.BackColor = System.Drawing.Color.Transparent;
            this.LabelRwy12Width.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelRwy12Width.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelRwy12Width.Location = new System.Drawing.Point(11, 66);
            this.LabelRwy12Width.Name = "LabelRwy12Width";
            this.LabelRwy12Width.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelRwy12Width.Size = new System.Drawing.Size(38, 19);
            this.LabelRwy12Width.TabIndex = 89;
            this.LabelRwy12Width.Text = "Width:";
            this.LabelRwy12Width.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelRwy12Length
            // 
            this.LabelRwy12Length.BackColor = System.Drawing.Color.Transparent;
            this.LabelRwy12Length.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelRwy12Length.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelRwy12Length.Location = new System.Drawing.Point(2, 28);
            this.LabelRwy12Length.Name = "LabelRwy12Length";
            this.LabelRwy12Length.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelRwy12Length.Size = new System.Drawing.Size(47, 19);
            this.LabelRwy12Length.TabIndex = 88;
            this.LabelRwy12Length.Text = "Length:";
            this.LabelRwy12Length.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _cmbRwy12Cat
            // 
            this._cmbRwy12Cat.BackColor = System.Drawing.SystemColors.Window;
            this._cmbRwy12Cat.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmbRwy12Cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbRwy12Cat.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cmbRwy12Cat.Location = new System.Drawing.Point(246, 34);
            this._cmbRwy12Cat.Name = "_cmbRwy12Cat";
            this._cmbRwy12Cat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmbRwy12Cat.Size = new System.Drawing.Size(224, 21);
            this._cmbRwy12Cat.TabIndex = 83;
            this._cmbRwy12Cat.SelectedIndexChanged += new System.EventHandler(this.CmbRwy12Cat_SelectedIndexChanged);
            // 
            // LabelRwy121
            // 
            this.LabelRwy121.BackColor = System.Drawing.Color.Transparent;
            this.LabelRwy121.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelRwy121.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelRwy121.Location = new System.Drawing.Point(382, 114);
            this.LabelRwy121.Name = "LabelRwy121";
            this.LabelRwy121.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelRwy121.Size = new System.Drawing.Size(88, 16);
            this.LabelRwy121.TabIndex = 111;
            this.LabelRwy121.Text = "Rwy12 Object";
            this.LabelRwy121.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _imgRwy12
            // 
            this._imgRwy12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgRwy12.ContextMenuStrip = this.PopUpMenu;
            this._imgRwy12.Cursor = System.Windows.Forms.Cursors.Default;
            this._imgRwy12.Location = new System.Drawing.Point(18, 140);
            this._imgRwy12.Name = "_imgRwy12";
            this._imgRwy12.Size = new System.Drawing.Size(208, 166);
            this._imgRwy12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgRwy12.TabIndex = 112;
            this._imgRwy12.TabStop = false;
            this._imgRwy12.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgRwy12_MouseDown);
            // 
            // LabelRwy12Cat
            // 
            this.LabelRwy12Cat.AutoSize = true;
            this.LabelRwy12Cat.BackColor = System.Drawing.Color.Transparent;
            this.LabelRwy12Cat.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelRwy12Cat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelRwy12Cat.Location = new System.Drawing.Point(243, 18);
            this.LabelRwy12Cat.Name = "LabelRwy12Cat";
            this.LabelRwy12Cat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelRwy12Cat.Size = new System.Drawing.Size(83, 13);
            this.LabelRwy12Cat.TabIndex = 93;
            this.LabelRwy12Cat.Text = "Object Category";
            // 
            // _SSTab1_TabPage5
            // 
            this._SSTab1_TabPage5.Controls.Add(this._frMDL);
            this._SSTab1_TabPage5.Controls.Add(this._frBeaconType);
            this._SSTab1_TabPage5.Controls.Add(this._frBeaconBase);
            this._SSTab1_TabPage5.Controls.Add(this._frWindsock);
            this._SSTab1_TabPage5.Controls.Add(this._frEffect);
            this._SSTab1_TabPage5.Controls.Add(this._frTaxiway);
            this._SSTab1_TabPage5.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage5.Name = "_SSTab1_TabPage5";
            this._SSTab1_TabPage5.Size = new System.Drawing.Size(486, 322);
            this._SSTab1_TabPage5.TabIndex = 4;
            this._SSTab1_TabPage5.Text = "Other Objects";
            this._SSTab1_TabPage5.UseVisualStyleBackColor = true;
            // 
            // _frMDL
            // 
            this._frMDL.BackColor = System.Drawing.Color.Transparent;
            this._frMDL.Controls.Add(this.txtMDLscale);
            this._frMDL.Controls.Add(this.labelMDLguid);
            this._frMDL.Controls.Add(this.Label9);
            this._frMDL.Controls.Add(this.labelMDLName);
            this._frMDL.Controls.Add(this.txtMDLWidth);
            this._frMDL.Controls.Add(this.txtMDLLength);
            this._frMDL.Controls.Add(this.LabelMDL2);
            this._frMDL.Controls.Add(this.LabelMDL3);
            this._frMDL.Controls.Add(this.txtMDLFile);
            this._frMDL.Controls.Add(this.LabelMDL1);
            this._frMDL.Controls.Add(this._cmdMDL);
            this._frMDL.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frMDL.Location = new System.Drawing.Point(239, 138);
            this._frMDL.Name = "_frMDL";
            this._frMDL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frMDL.Size = new System.Drawing.Size(230, 135);
            this._frMDL.TabIndex = 76;
            this._frMDL.TabStop = false;
            this._frMDL.Text = "MDL Model";
            this._frMDL.Click += new System.EventHandler(this.FrmDL_Click);
            // 
            // txtMDLscale
            // 
            this.txtMDLscale.AcceptsReturn = true;
            this.txtMDLscale.BackColor = System.Drawing.SystemColors.Window;
            this.txtMDLscale.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDLscale.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMDLscale.Location = new System.Drawing.Point(195, 71);
            this.txtMDLscale.MaxLength = 0;
            this.txtMDLscale.Name = "txtMDLscale";
            this.txtMDLscale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMDLscale.Size = new System.Drawing.Size(23, 20);
            this.txtMDLscale.TabIndex = 81;
            this.txtMDLscale.Text = "1";
            this.txtMDLscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelMDLguid
            // 
            this.labelMDLguid.AutoSize = true;
            this.labelMDLguid.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelMDLguid.Location = new System.Drawing.Point(9, 115);
            this.labelMDLguid.Name = "labelMDLguid";
            this.labelMDLguid.Size = new System.Drawing.Size(41, 13);
            this.labelMDLguid.TabIndex = 80;
            this.labelMDLguid.Text = "Guid = ";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.ForeColor = System.Drawing.SystemColors.MenuText;
            this.Label9.Location = new System.Drawing.Point(152, 74);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(37, 13);
            this.Label9.TabIndex = 80;
            this.Label9.Text = "Scale:";
            // 
            // labelMDLName
            // 
            this.labelMDLName.AutoSize = true;
            this.labelMDLName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.labelMDLName.Location = new System.Drawing.Point(9, 102);
            this.labelMDLName.Name = "labelMDLName";
            this.labelMDLName.Size = new System.Drawing.Size(79, 13);
            this.labelMDLName.TabIndex = 80;
            this.labelMDLName.Text = "Model Name = ";
            // 
            // txtMDLWidth
            // 
            this.txtMDLWidth.AcceptsReturn = true;
            this.txtMDLWidth.BackColor = System.Drawing.SystemColors.Window;
            this.txtMDLWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDLWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMDLWidth.Location = new System.Drawing.Point(14, 71);
            this.txtMDLWidth.MaxLength = 0;
            this.txtMDLWidth.Name = "txtMDLWidth";
            this.txtMDLWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMDLWidth.Size = new System.Drawing.Size(57, 20);
            this.txtMDLWidth.TabIndex = 76;
            this.txtMDLWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMDLLength
            // 
            this.txtMDLLength.AcceptsReturn = true;
            this.txtMDLLength.BackColor = System.Drawing.SystemColors.Window;
            this.txtMDLLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDLLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMDLLength.Location = new System.Drawing.Point(89, 71);
            this.txtMDLLength.MaxLength = 0;
            this.txtMDLLength.Name = "txtMDLLength";
            this.txtMDLLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMDLLength.Size = new System.Drawing.Size(57, 20);
            this.txtMDLLength.TabIndex = 75;
            this.txtMDLLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LabelMDL2
            // 
            this.LabelMDL2.BackColor = System.Drawing.Color.Transparent;
            this.LabelMDL2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMDL2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMDL2.Location = new System.Drawing.Point(83, 56);
            this.LabelMDL2.Name = "LabelMDL2";
            this.LabelMDL2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMDL2.Size = new System.Drawing.Size(47, 19);
            this.LabelMDL2.TabIndex = 78;
            this.LabelMDL2.Text = "Length:";
            this.LabelMDL2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMDL3
            // 
            this.LabelMDL3.BackColor = System.Drawing.Color.Transparent;
            this.LabelMDL3.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMDL3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMDL3.Location = new System.Drawing.Point(17, 56);
            this.LabelMDL3.Name = "LabelMDL3";
            this.LabelMDL3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMDL3.Size = new System.Drawing.Size(38, 19);
            this.LabelMDL3.TabIndex = 77;
            this.LabelMDL3.Text = "Width:";
            this.LabelMDL3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtMDLFile
            // 
            this.txtMDLFile.AcceptsReturn = true;
            this.txtMDLFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtMDLFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMDLFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtMDLFile.Location = new System.Drawing.Point(14, 31);
            this.txtMDLFile.MaxLength = 0;
            this.txtMDLFile.Name = "txtMDLFile";
            this.txtMDLFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMDLFile.Size = new System.Drawing.Size(165, 20);
            this.txtMDLFile.TabIndex = 72;
            // 
            // LabelMDL1
            // 
            this.LabelMDL1.AutoSize = true;
            this.LabelMDL1.BackColor = System.Drawing.Color.Transparent;
            this.LabelMDL1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelMDL1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelMDL1.Location = new System.Drawing.Point(17, 16);
            this.LabelMDL1.Name = "LabelMDL1";
            this.LabelMDL1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelMDL1.Size = new System.Drawing.Size(54, 13);
            this.LabelMDL1.TabIndex = 74;
            this.LabelMDL1.Text = "FileName:";
            // 
            // _cmdMDL
            // 
            this._cmdMDL.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._cmdMDL.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdMDL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdMDL.Location = new System.Drawing.Point(185, 29);
            this._cmdMDL.Name = "_cmdMDL";
            this._cmdMDL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdMDL.Size = new System.Drawing.Size(31, 22);
            this._cmdMDL.TabIndex = 79;
            this._cmdMDL.Text = "...";
            this._cmdMDL.UseVisualStyleBackColor = false;
            this._cmdMDL.Click += new System.EventHandler(this.CmdMDL_Click);
            // 
            // _frBeaconType
            // 
            this._frBeaconType.BackColor = System.Drawing.Color.Transparent;
            this._frBeaconType.Controls.Add(this.optBeaconCivilian);
            this._frBeaconType.Controls.Add(this.optBeaconMil);
            this._frBeaconType.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frBeaconType.Location = new System.Drawing.Point(239, 19);
            this._frBeaconType.Name = "_frBeaconType";
            this._frBeaconType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frBeaconType.Size = new System.Drawing.Size(100, 108);
            this._frBeaconType.TabIndex = 56;
            this._frBeaconType.TabStop = false;
            this._frBeaconType.Text = "Beacon Type";
            this._frBeaconType.Click += new System.EventHandler(this.FrBeaconType_Click);
            // 
            // optBeaconCivilian
            // 
            this.optBeaconCivilian.BackColor = System.Drawing.Color.Transparent;
            this.optBeaconCivilian.Checked = true;
            this.optBeaconCivilian.Cursor = System.Windows.Forms.Cursors.Default;
            this.optBeaconCivilian.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optBeaconCivilian.Location = new System.Drawing.Point(18, 32);
            this.optBeaconCivilian.Name = "optBeaconCivilian";
            this.optBeaconCivilian.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optBeaconCivilian.Size = new System.Drawing.Size(82, 16);
            this.optBeaconCivilian.TabIndex = 58;
            this.optBeaconCivilian.TabStop = true;
            this.optBeaconCivilian.Text = "Civilian";
            this.optBeaconCivilian.UseVisualStyleBackColor = false;
            // 
            // optBeaconMil
            // 
            this.optBeaconMil.BackColor = System.Drawing.Color.Transparent;
            this.optBeaconMil.Cursor = System.Windows.Forms.Cursors.Default;
            this.optBeaconMil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optBeaconMil.Location = new System.Drawing.Point(18, 62);
            this.optBeaconMil.Name = "optBeaconMil";
            this.optBeaconMil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optBeaconMil.Size = new System.Drawing.Size(70, 16);
            this.optBeaconMil.TabIndex = 57;
            this.optBeaconMil.TabStop = true;
            this.optBeaconMil.Text = "Military";
            this.optBeaconMil.UseVisualStyleBackColor = false;
            // 
            // _frBeaconBase
            // 
            this._frBeaconBase.BackColor = System.Drawing.Color.Transparent;
            this._frBeaconBase.Controls.Add(this.optBeaconAirport);
            this._frBeaconBase.Controls.Add(this.optBeaconHeliport);
            this._frBeaconBase.Controls.Add(this.optBeaconSeaBase);
            this._frBeaconBase.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frBeaconBase.Location = new System.Drawing.Point(355, 19);
            this._frBeaconBase.Name = "_frBeaconBase";
            this._frBeaconBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frBeaconBase.Size = new System.Drawing.Size(114, 108);
            this._frBeaconBase.TabIndex = 59;
            this._frBeaconBase.TabStop = false;
            this._frBeaconBase.Text = "Beacon Base Type";
            this._frBeaconBase.Click += new System.EventHandler(this.FrBeaconBase_Click);
            // 
            // optBeaconAirport
            // 
            this.optBeaconAirport.BackColor = System.Drawing.Color.Transparent;
            this.optBeaconAirport.Checked = true;
            this.optBeaconAirport.Cursor = System.Windows.Forms.Cursors.Default;
            this.optBeaconAirport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optBeaconAirport.Location = new System.Drawing.Point(16, 19);
            this.optBeaconAirport.Name = "optBeaconAirport";
            this.optBeaconAirport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optBeaconAirport.Size = new System.Drawing.Size(70, 16);
            this.optBeaconAirport.TabIndex = 62;
            this.optBeaconAirport.TabStop = true;
            this.optBeaconAirport.Text = "Airport";
            this.optBeaconAirport.UseVisualStyleBackColor = false;
            // 
            // optBeaconHeliport
            // 
            this.optBeaconHeliport.BackColor = System.Drawing.Color.Transparent;
            this.optBeaconHeliport.Cursor = System.Windows.Forms.Cursors.Default;
            this.optBeaconHeliport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optBeaconHeliport.Location = new System.Drawing.Point(16, 70);
            this.optBeaconHeliport.Name = "optBeaconHeliport";
            this.optBeaconHeliport.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optBeaconHeliport.Size = new System.Drawing.Size(70, 16);
            this.optBeaconHeliport.TabIndex = 60;
            this.optBeaconHeliport.TabStop = true;
            this.optBeaconHeliport.Text = "Heliport";
            this.optBeaconHeliport.UseVisualStyleBackColor = false;
            // 
            // optBeaconSeaBase
            // 
            this.optBeaconSeaBase.BackColor = System.Drawing.Color.Transparent;
            this.optBeaconSeaBase.Cursor = System.Windows.Forms.Cursors.Default;
            this.optBeaconSeaBase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.optBeaconSeaBase.Location = new System.Drawing.Point(16, 43);
            this.optBeaconSeaBase.Name = "optBeaconSeaBase";
            this.optBeaconSeaBase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.optBeaconSeaBase.Size = new System.Drawing.Size(76, 19);
            this.optBeaconSeaBase.TabIndex = 61;
            this.optBeaconSeaBase.TabStop = true;
            this.optBeaconSeaBase.Text = "Sea Base";
            this.optBeaconSeaBase.UseVisualStyleBackColor = false;
            // 
            // _frWindsock
            // 
            this._frWindsock.BackColor = System.Drawing.Color.Transparent;
            this._frWindsock.Controls.Add(this.RadioButton3);
            this._frWindsock.Controls.Add(this.RadioButton2);
            this._frWindsock.Controls.Add(this._txtWindsockLength);
            this._frWindsock.Controls.Add(this.RadioButton1);
            this._frWindsock.Controls.Add(this._txtWindsockHeight);
            this._frWindsock.Controls.Add(this.ckWindsockLight);
            this._frWindsock.Controls.Add(this.LabelWin3);
            this._frWindsock.Controls.Add(this.LabelWin2);
            this._frWindsock.Controls.Add(this.LabelWin1);
            this._frWindsock.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frWindsock.Location = new System.Drawing.Point(13, 138);
            this._frWindsock.Name = "_frWindsock";
            this._frWindsock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frWindsock.Size = new System.Drawing.Size(200, 91);
            this._frWindsock.TabIndex = 63;
            this._frWindsock.TabStop = false;
            this._frWindsock.Text = "WindSock";
            this._frWindsock.Click += new System.EventHandler(this.FrWindsock_Click);
            // 
            // RadioButton3
            // 
            this.RadioButton3.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButton3.Checked = true;
            this.RadioButton3.Cursor = System.Windows.Forms.Cursors.Default;
            this.RadioButton3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioButton3.Location = new System.Drawing.Point(144, 179);
            this.RadioButton3.Name = "RadioButton3";
            this.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadioButton3.Size = new System.Drawing.Size(70, 16);
            this.RadioButton3.TabIndex = 62;
            this.RadioButton3.TabStop = true;
            this.RadioButton3.Text = "Airport";
            this.RadioButton3.UseVisualStyleBackColor = false;
            // 
            // RadioButton2
            // 
            this.RadioButton2.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButton2.Cursor = System.Windows.Forms.Cursors.Default;
            this.RadioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioButton2.Location = new System.Drawing.Point(144, 203);
            this.RadioButton2.Name = "RadioButton2";
            this.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadioButton2.Size = new System.Drawing.Size(76, 19);
            this.RadioButton2.TabIndex = 61;
            this.RadioButton2.TabStop = true;
            this.RadioButton2.Text = "Sea Base";
            this.RadioButton2.UseVisualStyleBackColor = false;
            // 
            // _txtWindsockLength
            // 
            this._txtWindsockLength.AcceptsReturn = true;
            this._txtWindsockLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this._txtWindsockLength.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtWindsockLength.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtWindsockLength.Location = new System.Drawing.Point(149, 59);
            this._txtWindsockLength.MaxLength = 0;
            this._txtWindsockLength.Name = "_txtWindsockLength";
            this._txtWindsockLength.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtWindsockLength.Size = new System.Drawing.Size(29, 20);
            this._txtWindsockLength.TabIndex = 66;
            this._txtWindsockLength.Text = "1";
            this._txtWindsockLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtWindsockLength.DoubleClick += new System.EventHandler(this.TxtWindsockLength_DoubleClick);
            // 
            // RadioButton1
            // 
            this.RadioButton1.BackColor = System.Drawing.SystemColors.Control;
            this.RadioButton1.Cursor = System.Windows.Forms.Cursors.Default;
            this.RadioButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RadioButton1.Location = new System.Drawing.Point(144, 230);
            this.RadioButton1.Name = "RadioButton1";
            this.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RadioButton1.Size = new System.Drawing.Size(70, 16);
            this.RadioButton1.TabIndex = 60;
            this.RadioButton1.TabStop = true;
            this.RadioButton1.Text = "Heliport";
            this.RadioButton1.UseVisualStyleBackColor = false;
            // 
            // _txtWindsockHeight
            // 
            this._txtWindsockHeight.AcceptsReturn = true;
            this._txtWindsockHeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this._txtWindsockHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtWindsockHeight.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtWindsockHeight.Location = new System.Drawing.Point(149, 24);
            this._txtWindsockHeight.MaxLength = 0;
            this._txtWindsockHeight.Name = "_txtWindsockHeight";
            this._txtWindsockHeight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtWindsockHeight.Size = new System.Drawing.Size(29, 20);
            this._txtWindsockHeight.TabIndex = 65;
            this._txtWindsockHeight.Text = "6";
            this._txtWindsockHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtWindsockHeight.DoubleClick += new System.EventHandler(this.TxtWindsockHeight_DoubleClick);
            // 
            // ckWindsockLight
            // 
            this.ckWindsockLight.AutoSize = true;
            this.ckWindsockLight.BackColor = System.Drawing.Color.Transparent;
            this.ckWindsockLight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckWindsockLight.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckWindsockLight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckWindsockLight.Location = new System.Drawing.Point(11, 62);
            this.ckWindsockLight.Name = "ckWindsockLight";
            this.ckWindsockLight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckWindsockLight.Size = new System.Drawing.Size(61, 17);
            this.ckWindsockLight.TabIndex = 64;
            this.ckWindsockLight.Text = "Lighted";
            this.ckWindsockLight.UseVisualStyleBackColor = true;
            // 
            // LabelWin3
            // 
            this.LabelWin3.BackColor = System.Drawing.Color.Transparent;
            this.LabelWin3.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelWin3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWin3.Location = new System.Drawing.Point(108, 16);
            this.LabelWin3.Name = "LabelWin3";
            this.LabelWin3.Size = new System.Drawing.Size(41, 33);
            this.LabelWin3.TabIndex = 69;
            this.LabelWin3.Text = "Pole height:";
            // 
            // LabelWin2
            // 
            this.LabelWin2.BackColor = System.Drawing.Color.Transparent;
            this.LabelWin2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelWin2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWin2.Location = new System.Drawing.Point(106, 49);
            this.LabelWin2.Name = "LabelWin2";
            this.LabelWin2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelWin2.Size = new System.Drawing.Size(55, 29);
            this.LabelWin2.TabIndex = 68;
            this.LabelWin2.Text = "Sock Length:";
            // 
            // LabelWin1
            // 
            this.LabelWin1.BackColor = System.Drawing.Color.Transparent;
            this.LabelWin1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelWin1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelWin1.Location = new System.Drawing.Point(8, 27);
            this.LabelWin1.Name = "LabelWin1";
            this.LabelWin1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelWin1.Size = new System.Drawing.Size(92, 33);
            this.LabelWin1.TabIndex = 67;
            this.LabelWin1.Text = "Double Click to change colors";
            // 
            // _frEffect
            // 
            this._frEffect.BackColor = System.Drawing.Color.Transparent;
            this._frEffect.Controls.Add(this.txtEffectName);
            this._frEffect.Controls.Add(this.txtEffectParameters);
            this._frEffect.Controls.Add(this.LabelEffect1);
            this._frEffect.Controls.Add(this.LabelEffect2);
            this._frEffect.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frEffect.Location = new System.Drawing.Point(13, 240);
            this._frEffect.Name = "_frEffect";
            this._frEffect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frEffect.Size = new System.Drawing.Size(200, 68);
            this._frEffect.TabIndex = 70;
            this._frEffect.TabStop = false;
            this._frEffect.Text = "Effect";
            this._frEffect.Click += new System.EventHandler(this.FrEffect_Click);
            // 
            // txtEffectName
            // 
            this.txtEffectName.AcceptsReturn = true;
            this.txtEffectName.BackColor = System.Drawing.SystemColors.Window;
            this.txtEffectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEffectName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEffectName.Location = new System.Drawing.Point(12, 36);
            this.txtEffectName.MaxLength = 0;
            this.txtEffectName.Name = "txtEffectName";
            this.txtEffectName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEffectName.Size = new System.Drawing.Size(83, 20);
            this.txtEffectName.TabIndex = 72;
            // 
            // txtEffectParameters
            // 
            this.txtEffectParameters.AcceptsReturn = true;
            this.txtEffectParameters.BackColor = System.Drawing.SystemColors.Window;
            this.txtEffectParameters.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEffectParameters.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEffectParameters.Location = new System.Drawing.Point(111, 36);
            this.txtEffectParameters.MaxLength = 0;
            this.txtEffectParameters.Name = "txtEffectParameters";
            this.txtEffectParameters.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEffectParameters.Size = new System.Drawing.Size(67, 20);
            this.txtEffectParameters.TabIndex = 71;
            // 
            // LabelEffect1
            // 
            this.LabelEffect1.AutoSize = true;
            this.LabelEffect1.BackColor = System.Drawing.Color.Transparent;
            this.LabelEffect1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelEffect1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelEffect1.Location = new System.Drawing.Point(12, 20);
            this.LabelEffect1.Name = "LabelEffect1";
            this.LabelEffect1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelEffect1.Size = new System.Drawing.Size(38, 13);
            this.LabelEffect1.TabIndex = 74;
            this.LabelEffect1.Text = "Name:";
            // 
            // LabelEffect2
            // 
            this.LabelEffect2.AutoSize = true;
            this.LabelEffect2.BackColor = System.Drawing.Color.Transparent;
            this.LabelEffect2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelEffect2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelEffect2.Location = new System.Drawing.Point(110, 20);
            this.LabelEffect2.Name = "LabelEffect2";
            this.LabelEffect2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelEffect2.Size = new System.Drawing.Size(63, 13);
            this.LabelEffect2.TabIndex = 73;
            this.LabelEffect2.Text = "Parameters:";
            this.LabelEffect2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _frTaxiway
            // 
            this._frTaxiway.BackColor = System.Drawing.Color.Transparent;
            this._frTaxiway.Controls.Add(this.txtTaxiwayText);
            this._frTaxiway.Controls.Add(this.combTaxiwaySize);
            this._frTaxiway.Controls.Add(this.combTaxiwayJustification);
            this._frTaxiway.Controls.Add(this._cmdTaxiwayHelp);
            this._frTaxiway.Controls.Add(this.LabelTax1);
            this._frTaxiway.Controls.Add(this.LabelTax2);
            this._frTaxiway.Controls.Add(this.LabelTax3);
            this._frTaxiway.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this._frTaxiway.Location = new System.Drawing.Point(13, 17);
            this._frTaxiway.Name = "_frTaxiway";
            this._frTaxiway.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._frTaxiway.Size = new System.Drawing.Size(200, 110);
            this._frTaxiway.TabIndex = 75;
            this._frTaxiway.TabStop = false;
            this._frTaxiway.Text = "Taxiway Sign";
            this._frTaxiway.Click += new System.EventHandler(this.FrTaxiway_Click);
            // 
            // txtTaxiwayText
            // 
            this.txtTaxiwayText.AcceptsReturn = true;
            this.txtTaxiwayText.BackColor = System.Drawing.SystemColors.Window;
            this.txtTaxiwayText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTaxiwayText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTaxiwayText.Location = new System.Drawing.Point(13, 79);
            this.txtTaxiwayText.MaxLength = 0;
            this.txtTaxiwayText.Name = "txtTaxiwayText";
            this.txtTaxiwayText.ReadOnly = true;
            this.txtTaxiwayText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTaxiwayText.Size = new System.Drawing.Size(78, 20);
            this.txtTaxiwayText.TabIndex = 79;
            this.txtTaxiwayText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // combTaxiwaySize
            // 
            this.combTaxiwaySize.BackColor = System.Drawing.SystemColors.Window;
            this.combTaxiwaySize.Cursor = System.Windows.Forms.Cursors.Default;
            this.combTaxiwaySize.ForeColor = System.Drawing.SystemColors.WindowText;
            this.combTaxiwaySize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.combTaxiwaySize.Location = new System.Drawing.Point(20, 36);
            this.combTaxiwaySize.Name = "combTaxiwaySize";
            this.combTaxiwaySize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combTaxiwaySize.Size = new System.Drawing.Size(40, 21);
            this.combTaxiwaySize.TabIndex = 78;
            this.combTaxiwaySize.Text = "5";
            // 
            // combTaxiwayJustification
            // 
            this.combTaxiwayJustification.BackColor = System.Drawing.SystemColors.Window;
            this.combTaxiwayJustification.Cursor = System.Windows.Forms.Cursors.Default;
            this.combTaxiwayJustification.ForeColor = System.Drawing.SystemColors.WindowText;
            this.combTaxiwayJustification.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.combTaxiwayJustification.Location = new System.Drawing.Point(114, 39);
            this.combTaxiwayJustification.Name = "combTaxiwayJustification";
            this.combTaxiwayJustification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.combTaxiwayJustification.Size = new System.Drawing.Size(61, 21);
            this.combTaxiwayJustification.TabIndex = 77;
            this.combTaxiwayJustification.Text = "Left";
            // 
            // _cmdTaxiwayHelp
            // 
            this._cmdTaxiwayHelp.BackColor = System.Drawing.Color.Transparent;
            this._cmdTaxiwayHelp.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdTaxiwayHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdTaxiwayHelp.Location = new System.Drawing.Point(115, 74);
            this._cmdTaxiwayHelp.Name = "_cmdTaxiwayHelp";
            this._cmdTaxiwayHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdTaxiwayHelp.Size = new System.Drawing.Size(46, 25);
            this._cmdTaxiwayHelp.TabIndex = 76;
            this._cmdTaxiwayHelp.Text = "Make";
            this._cmdTaxiwayHelp.UseVisualStyleBackColor = false;
            this._cmdTaxiwayHelp.Click += new System.EventHandler(this.CmdTaxiwayHelp_Click);
            // 
            // LabelTax1
            // 
            this.LabelTax1.AutoSize = true;
            this.LabelTax1.BackColor = System.Drawing.Color.Transparent;
            this.LabelTax1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTax1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTax1.Location = new System.Drawing.Point(20, 21);
            this.LabelTax1.Name = "LabelTax1";
            this.LabelTax1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTax1.Size = new System.Drawing.Size(30, 13);
            this.LabelTax1.TabIndex = 82;
            this.LabelTax1.Text = "Size:";
            // 
            // LabelTax2
            // 
            this.LabelTax2.AutoSize = true;
            this.LabelTax2.BackColor = System.Drawing.Color.Transparent;
            this.LabelTax2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTax2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTax2.Location = new System.Drawing.Point(110, 23);
            this.LabelTax2.Name = "LabelTax2";
            this.LabelTax2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTax2.Size = new System.Drawing.Size(65, 13);
            this.LabelTax2.TabIndex = 81;
            this.LabelTax2.Text = "Justification:";
            // 
            // LabelTax3
            // 
            this.LabelTax3.BackColor = System.Drawing.Color.Transparent;
            this.LabelTax3.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelTax3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelTax3.Location = new System.Drawing.Point(13, 64);
            this.LabelTax3.Name = "LabelTax3";
            this.LabelTax3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelTax3.Size = new System.Drawing.Size(67, 19);
            this.LabelTax3.TabIndex = 80;
            this.LabelTax3.Text = "Label:";
            // 
            // lbComment
            // 
            this.lbComment.BackColor = System.Drawing.SystemColors.Control;
            this.lbComment.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbComment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbComment.Location = new System.Drawing.Point(12, 381);
            this.lbComment.Name = "lbComment";
            this.lbComment.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbComment.Size = new System.Drawing.Size(78, 16);
            this.lbComment.TabIndex = 61;
            this.lbComment.Text = "Object Name:";
            this.lbComment.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // FrmObjectsP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 416);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this._cmdOrder);
            this.Controls.Add(this._SSTab1);
            this.Controls.Add(this.lbComment);
            this.Controls.Add(this._cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmObjectsP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Object Properties";
            this._SSTab1.ResumeLayout(false);
            this._SSTab1_TabPage0.ResumeLayout(false);
            this.Frame4.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.Frame3.ResumeLayout(false);
            this.Frame5.ResumeLayout(false);
            this.Frame5.PerformLayout();
            this.Frame6.ResumeLayout(false);
            this.Frame6.PerformLayout();
            this._SSTab1_TabPage1.ResumeLayout(false);
            this._SSTab1_TabPage1.PerformLayout();
            this.frLib.ResumeLayout(false);
            this.frLib.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgLib)).EndInit();
            this.PopUpMenu.ResumeLayout(false);
            this._SSTab1_TabPage2.ResumeLayout(false);
            this._SSTab1_TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._imgGenB)).EndInit();
            this.frGenB.ResumeLayout(false);
            this.frGenB.PerformLayout();
            this._SSTab1_TabPage3.ResumeLayout(false);
            this._SSTab1_TabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgMacro)).EndInit();
            this._frMacro.ResumeLayout(false);
            this._frMacro.PerformLayout();
            this._frMacro1.ResumeLayout(false);
            this._frMacro1.PerformLayout();
            this._SSTab1_TabPage4.ResumeLayout(false);
            this._SSTab1_TabPage4.PerformLayout();
            this._frRwy12.ResumeLayout(false);
            this._frRwy12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgRwy12)).EndInit();
            this._SSTab1_TabPage5.ResumeLayout(false);
            this._frMDL.ResumeLayout(false);
            this._frMDL.PerformLayout();
            this._frBeaconType.ResumeLayout(false);
            this._frBeaconBase.ResumeLayout(false);
            this._frWindsock.ResumeLayout(false);
            this._frWindsock.PerformLayout();
            this._frEffect.ResumeLayout(false);
            this._frEffect.PerformLayout();
            this._frTaxiway.ResumeLayout(false);
            this._frTaxiway.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button _cmdOrder;

        public Button cmdOrder
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdOrder;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdOrder != null)
                {
                    _cmdOrder.Click -= CmdOrder_Click;
                }

                _cmdOrder = value;
                if (_cmdOrder != null)
                {
                    _cmdOrder.Click += CmdOrder_Click;
                }
            }
        }

        public TextBox txtComment;
        private Button _cmdOK;

        public Button cmdOK
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdOK;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdOK != null)
                {
                    _cmdOK.Click -= CmdOK_Click;
                }

                _cmdOK = value;
                if (_cmdOK != null)
                {
                    _cmdOK.Click += CmdOK_Click;
                }
            }
        }

        private Button _cmdCancel;

        public Button cmdCancel
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCancel;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCancel != null)
                {
                    _cmdCancel.Click -= CmdCancel_Click;
                }

                _cmdCancel = value;
                if (_cmdCancel != null)
                {
                    _cmdCancel.Click += CmdCancel_Click;
                }
            }
        }

        private TabControl _SSTab1;

        public TabControl SSTab1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _SSTab1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_SSTab1 != null)
                {
                    _SSTab1.SelectedIndexChanged -= SSTab1_SelectedIndexChanged;
                }

                _SSTab1 = value;
                if (_SSTab1 != null)
                {
                    _SSTab1.SelectedIndexChanged += SSTab1_SelectedIndexChanged;
                }
            }
        }

        public TabPage _SSTab1_TabPage0;
        public GroupBox Frame1;
        public TextBox txtLat;
        public TextBox txtLon;
        public CheckBox ckAGL;
        public TextBox txtAltitude;
        public Label Label3;
        public Label Label1;
        public Label Label2;
        public GroupBox Frame2;
        public TextBox txtBank;
        public TextBox txtPitch;
        public TextBox txtHeading;
        public Label Label6;
        public Label Label5;
        public Label Label4;
        public GroupBox Frame3;
        public RadioButton opVDense;
        public RadioButton opDense;
        public RadioButton opNormal;
        public RadioButton opSparse;
        public RadioButton opVSparse;
        public GroupBox Frame5;
        public TextBox txtBiasX;
        public TextBox txtBiasY;
        public TextBox txtBiasZ;
        public Label Label17;
        public Label Label18;
        public Label Label19;
        private Button _cmdPosFs;

        public Button cmdPosFs
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPosFs;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPosFs != null)
                {
                    _cmdPosFs.Click -= CmdPosFs_Click;
                }

                _cmdPosFs = value;
                if (_cmdPosFs != null)
                {
                    _cmdPosFs.Click += CmdPosFs_Click;
                }
            }
        }

        public GroupBox Frame6;
        public TextBox txtV2;
        public TextBox txtV1;
        public Label Label8;
        public Label Label7;
        public TabPage _SSTab1_TabPage1;
        private PictureBox _imgLib;

        public PictureBox imgLib
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgLib;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgLib != null)
                {
                    _imgLib.MouseDown -= ImgLib_MouseDown;
                }

                _imgLib = value;
                if (_imgLib != null)
                {
                    _imgLib.MouseDown += ImgLib_MouseDown;
                }
            }
        }

        public Label LabelCat;
        public Label labelFS;
        private ListBox _lstLib;

        public ListBox lstLib
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lstLib;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lstLib != null)
                {
                    _lstLib.SelectedIndexChanged -= LstLib_SelectedIndexChanged;
                }

                _lstLib = value;
                if (_lstLib != null)
                {
                    _lstLib.SelectedIndexChanged += LstLib_SelectedIndexChanged;
                }
            }
        }

        public TextBox txtLibID;
        private ComboBox _cmbLibCat;

        public ComboBox cmbLibCat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmbLibCat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbLibCat != null)
                {
                    _cmbLibCat.SelectedIndexChanged -= CmbLibCat_SelectedIndexChanged;
                }

                _cmbLibCat = value;
                if (_cmbLibCat != null)
                {
                    _cmbLibCat.SelectedIndexChanged += CmbLibCat_SelectedIndexChanged;
                }
            }
        }

        public TabPage _SSTab1_TabPage3;
        public Label LabelMacro1;
        public Label LabelMacroCat;
        private PictureBox _imgMacro;

        public PictureBox imgMacro
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgMacro;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgMacro != null)
                {
                    _imgMacro.MouseDown -= ImgMacro_MouseDown;
                }

                _imgMacro = value;
                if (_imgMacro != null)
                {
                    _imgMacro.MouseDown += ImgMacro_MouseDown;
                }
            }
        }

        private GroupBox _frMacro;

        public GroupBox frMacro
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frMacro;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frMacro != null)
                {
                    _frMacro.Click -= Frmacro_Click;
                }

                _frMacro = value;
                if (_frMacro != null)
                {
                    _frMacro.Click += Frmacro_Click;
                }
            }
        }

        public TextBox txtMacroRange;
        public TextBox txtMacroScale;
        public TextBox txtMacroLength;
        public TextBox txtMacroWidth;
        public Label LabelMacroRange;
        public Label LabelMacroScale;
        public Label LabelMacroWidth;
        public Label LabelMacroLength;
        private ComboBox _cmbMacroCat;

        public ComboBox cmbMacroCat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmbMacroCat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbMacroCat != null)
                {
                    _cmbMacroCat.SelectedIndexChanged -= CmbMacroCat_SelectedIndexChanged;
                }

                _cmbMacroCat = value;
                if (_cmbMacroCat != null)
                {
                    _cmbMacroCat.SelectedIndexChanged += CmbMacroCat_SelectedIndexChanged;
                }
            }
        }

        private ListBox _lstMacro;

        public ListBox lstMacro
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lstMacro;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lstMacro != null)
                {
                    _lstMacro.SelectedIndexChanged -= LstMacro_SelectedIndexChanged;
                }

                _lstMacro = value;
                if (_lstMacro != null)
                {
                    _lstMacro.SelectedIndexChanged += LstMacro_SelectedIndexChanged;
                }
            }
        }

        private GroupBox _frMacro1;

        public GroupBox frMacro1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frMacro1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frMacro1 != null)
                {
                    _frMacro1.Click -= Frmacro1_Click;
                }

                _frMacro1 = value;
                if (_frMacro1 != null)
                {
                    _frMacro1.Click += Frmacro1_Click;
                }
            }
        }

        private Button _cmdExpand;

        public Button cmdExpand
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdExpand;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdExpand != null)
                {
                    _cmdExpand.Click -= CmdExpand_Click;
                }

                _cmdExpand = value;
                if (_cmdExpand != null)
                {
                    _cmdExpand.Click += CmdExpand_Click;
                }
            }
        }

        public TextBox txtP7;
        public TextBox txtP9;
        public TextBox txtP8;
        public TextBox txtP6;
        public Label lbP9;
        public Label lbP7;
        public Label lbP8;
        public Label lbP6;
        private Button _cmdMacroEdit;

        public Button cmdMacroEdit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdMacroEdit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdMacroEdit != null)
                {
                    _cmdMacroEdit.Click -= CmdMacroEdit_Click;
                }

                _cmdMacroEdit = value;
                if (_cmdMacroEdit != null)
                {
                    _cmdMacroEdit.Click += CmdMacroEdit_Click;
                }
            }
        }

        public TabPage _SSTab1_TabPage4;
        private ListBox _lstRwy12;

        public ListBox lstRwy12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lstRwy12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lstRwy12 != null)
                {
                    _lstRwy12.SelectedIndexChanged -= LstRwy12_SelectedIndexChanged;
                }

                _lstRwy12 = value;
                if (_lstRwy12 != null)
                {
                    _lstRwy12.SelectedIndexChanged += LstRwy12_SelectedIndexChanged;
                }
            }
        }

        public TextBox txtRwy12ID;
        private GroupBox _frRwy12;

        public GroupBox frRwy12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frRwy12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frRwy12 != null)
                {
                    _frRwy12.Click -= FrRwy12_Click;
                }

                _frRwy12 = value;
                if (_frRwy12 != null)
                {
                    _frRwy12.Click += FrRwy12_Click;
                }
            }
        }

        public TextBox txtRwy12Scale;
        public TextBox txtRwy12Length;
        public TextBox txtRwy12Width;
        public Label LabelRwy12Scale;
        public Label LabelRwy12Width;
        public Label LabelRwy12Length;
        private ComboBox _cmbRwy12Cat;

        public ComboBox cmbRwy12Cat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmbRwy12Cat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmbRwy12Cat != null)
                {
                    _cmbRwy12Cat.SelectedIndexChanged -= CmbRwy12Cat_SelectedIndexChanged;
                }

                _cmbRwy12Cat = value;
                if (_cmbRwy12Cat != null)
                {
                    _cmbRwy12Cat.SelectedIndexChanged += CmbRwy12Cat_SelectedIndexChanged;
                }
            }
        }

        public Label LabelRwy121;
        private PictureBox _imgRwy12;

        public PictureBox imgRwy12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgRwy12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgRwy12 != null)
                {
                    _imgRwy12.MouseDown -= ImgRwy12_MouseDown;
                }

                _imgRwy12 = value;
                if (_imgRwy12 != null)
                {
                    _imgRwy12.MouseDown += ImgRwy12_MouseDown;
                }
            }
        }

        public Label LabelRwy12Cat;
        public TabPage _SSTab1_TabPage5;
        private GroupBox _frBeaconType;

        public GroupBox frBeaconType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frBeaconType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frBeaconType != null)
                {
                    _frBeaconType.Click -= FrBeaconType_Click;
                }

                _frBeaconType = value;
                if (_frBeaconType != null)
                {
                    _frBeaconType.Click += FrBeaconType_Click;
                }
            }
        }

        public RadioButton optBeaconCivilian;
        public RadioButton optBeaconMil;
        private GroupBox _frBeaconBase;

        public GroupBox frBeaconBase
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frBeaconBase;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frBeaconBase != null)
                {
                    _frBeaconBase.Click -= FrBeaconBase_Click;
                }

                _frBeaconBase = value;
                if (_frBeaconBase != null)
                {
                    _frBeaconBase.Click += FrBeaconBase_Click;
                }
            }
        }

        public RadioButton optBeaconAirport;
        public RadioButton optBeaconSeaBase;
        public RadioButton optBeaconHeliport;
        private GroupBox _frWindsock;

        public GroupBox frWindsock
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frWindsock;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frWindsock != null)
                {
                    _frWindsock.Click -= FrWindsock_Click;
                }

                _frWindsock = value;
                if (_frWindsock != null)
                {
                    _frWindsock.Click += FrWindsock_Click;
                }
            }
        }

        private TextBox _txtWindsockLength;

        public TextBox txtWindsockLength
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtWindsockLength;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtWindsockLength != null)
                {
                    _txtWindsockLength.DoubleClick -= TxtWindsockLength_DoubleClick;
                }

                _txtWindsockLength = value;
                if (_txtWindsockLength != null)
                {
                    _txtWindsockLength.DoubleClick += TxtWindsockLength_DoubleClick;
                }
            }
        }

        private TextBox _txtWindsockHeight;

        public TextBox txtWindsockHeight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtWindsockHeight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtWindsockHeight != null)
                {
                    _txtWindsockHeight.DoubleClick -= TxtWindsockHeight_DoubleClick;
                }

                _txtWindsockHeight = value;
                if (_txtWindsockHeight != null)
                {
                    _txtWindsockHeight.DoubleClick += TxtWindsockHeight_DoubleClick;
                }
            }
        }

        public CheckBox ckWindsockLight;
        public Label LabelWin3;
        public Label LabelWin2;
        public Label LabelWin1;
        private GroupBox _frEffect;

        public GroupBox frEffect
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frEffect;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frEffect != null)
                {
                    _frEffect.Click -= FrEffect_Click;
                }

                _frEffect = value;
                if (_frEffect != null)
                {
                    _frEffect.Click += FrEffect_Click;
                }
            }
        }

        public TextBox txtEffectName;
        public TextBox txtEffectParameters;
        public Label LabelEffect1;
        public Label LabelEffect2;
        private GroupBox _frTaxiway;

        public GroupBox frTaxiway
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frTaxiway;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frTaxiway != null)
                {
                    _frTaxiway.Click -= FrTaxiway_Click;
                }

                _frTaxiway = value;
                if (_frTaxiway != null)
                {
                    _frTaxiway.Click += FrTaxiway_Click;
                }
            }
        }

        public TextBox txtTaxiwayText;
        public ComboBox combTaxiwaySize;
        public ComboBox combTaxiwayJustification;
        private Button _cmdTaxiwayHelp;

        public Button cmdTaxiwayHelp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTaxiwayHelp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTaxiwayHelp != null)
                {
                    _cmdTaxiwayHelp.Click -= CmdTaxiwayHelp_Click;
                }

                _cmdTaxiwayHelp = value;
                if (_cmdTaxiwayHelp != null)
                {
                    _cmdTaxiwayHelp.Click += CmdTaxiwayHelp_Click;
                }
            }
        }

        public Label LabelTax1;
        public Label LabelTax2;
        public Label LabelTax3;
        public Label lbComment;
        public RadioButton RadioButton3;
        public RadioButton RadioButton2;
        public RadioButton RadioButton1;
        internal TabPage _SSTab1_TabPage2;
        private PictureBox _imgGenB;

        public PictureBox imgGenB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgGenB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgGenB != null)
                {
                    _imgGenB.MouseDown -= ImgGenB_MouseDown;
                }

                _imgGenB = value;
                if (_imgGenB != null)
                {
                    _imgGenB.MouseDown += ImgGenB_MouseDown;
                }
            }
        }

        public GroupBox frGenB;
        private Button _cmdGbDetail;

        public Button cmdGbDetail
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdGbDetail;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdGbDetail != null)
                {
                    _cmdGbDetail.Click -= CmdGbDetail_Click;
                }

                _cmdGbDetail = value;
                if (_cmdGbDetail != null)
                {
                    _cmdGbDetail.Click += CmdGbDetail_Click;
                }
            }
        }

        public Label lbgb3;
        private GroupBox _frMDL;

        public GroupBox frMDL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _frMDL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_frMDL != null)
                {
                    _frMDL.Click -= FrmDL_Click;
                }

                _frMDL = value;
                if (_frMDL != null)
                {
                    _frMDL.Click += FrmDL_Click;
                }
            }
        }

        public TextBox txtMDLFile;
        public Label LabelMDL1;
        public TextBox txtMDLWidth;
        public TextBox txtMDLLength;
        public Label LabelMDL2;
        public Label LabelMDL3;
        internal Label labelLibMouse;
        internal Label labelMacroMouse;
        internal Label labelRwy12Mouse;
        private Button _cmdMDL;

        public Button cmdMDL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdMDL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdMDL != null)
                {
                    _cmdMDL.Click -= CmdMDL_Click;
                }

                _cmdMDL = value;
                if (_cmdMDL != null)
                {
                    _cmdMDL.Click += CmdMDL_Click;
                }
            }
        }

        public GroupBox Frame4;
        private RadioButton _optGenB;

        public RadioButton optGenB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGenB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGenB != null)
                {
                    _optGenB.CheckedChanged -= OptGenB_CheckedChanged;
                }

                _optGenB = value;
                if (_optGenB != null)
                {
                    _optGenB.CheckedChanged += OptGenB_CheckedChanged;
                }
            }
        }

        private RadioButton _optMDL;

        public RadioButton optMDL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMDL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMDL != null)
                {
                    _optMDL.CheckedChanged -= OptMDL_CheckedChanged;
                }

                _optMDL = value;
                if (_optMDL != null)
                {
                    _optMDL.CheckedChanged += OptMDL_CheckedChanged;
                }
            }
        }

        private Button _cmdOption;

        public Button cmdOption
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdOption;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdOption != null)
                {
                    _cmdOption.Click -= CmdOption_Click;
                }

                _cmdOption = value;
                if (_cmdOption != null)
                {
                    _cmdOption.Click += CmdOption_Click;
                }
            }
        }

        private RadioButton _optRwy12;

        public RadioButton optRwy12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optRwy12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optRwy12 != null)
                {
                    _optRwy12.CheckedChanged -= OptRwy12_CheckedChanged;
                }

                _optRwy12 = value;
                if (_optRwy12 != null)
                {
                    _optRwy12.CheckedChanged += OptRwy12_CheckedChanged;
                }
            }
        }

        private RadioButton _optMacro;

        public RadioButton optMacro
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optMacro;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optMacro != null)
                {
                    _optMacro.CheckedChanged -= OptMacro_CheckedChanged;
                }

                _optMacro = value;
                if (_optMacro != null)
                {
                    _optMacro.CheckedChanged += OptMacro_CheckedChanged;
                }
            }
        }

        private RadioButton _optBeacon;

        public RadioButton optBeacon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optBeacon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optBeacon != null)
                {
                    _optBeacon.CheckedChanged -= OptBeacon_CheckedChanged;
                }

                _optBeacon = value;
                if (_optBeacon != null)
                {
                    _optBeacon.CheckedChanged += OptBeacon_CheckedChanged;
                }
            }
        }

        private RadioButton _optWindsock;

        public RadioButton optWindsock
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optWindsock;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optWindsock != null)
                {
                    _optWindsock.CheckedChanged -= OptWindSock_CheckedChanged;
                }

                _optWindsock = value;
                if (_optWindsock != null)
                {
                    _optWindsock.CheckedChanged += OptWindSock_CheckedChanged;
                }
            }
        }

        private RadioButton _optEffect;

        public RadioButton optEffect
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optEffect;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optEffect != null)
                {
                    _optEffect.CheckedChanged -= OptEffect_CheckedChanged;
                }

                _optEffect = value;
                if (_optEffect != null)
                {
                    _optEffect.CheckedChanged += OptEffect_CheckedChanged;
                }
            }
        }

        private RadioButton _optTaxiwaySign;

        public RadioButton optTaxiwaySign
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTaxiwaySign;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTaxiwaySign != null)
                {
                    _optTaxiwaySign.CheckedChanged -= OptTaxiwaySign_CheckedChanged;
                }

                _optTaxiwaySign = value;
                if (_optTaxiwaySign != null)
                {
                    _optTaxiwaySign.CheckedChanged += OptTaxiwaySign_CheckedChanged;
                }
            }
        }

        private RadioButton _optLib;

        public RadioButton optLib
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optLib;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optLib != null)
                {
                    _optLib.CheckedChanged -= OptLib_CheckedChanged;
                }

                _optLib = value;
                if (_optLib != null)
                {
                    _optLib.CheckedChanged += OptLib_CheckedChanged;
                }
            }
        }

        internal Label labelMDLguid;
        internal Label labelMDLName;
        public TextBox txtMDLscale;
        internal Label Label9;
        public GroupBox frLib;
        private TextBox _txtLibName;

        public TextBox txtLibName
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLibName;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLibName != null)
                {
                    _txtLibName.TextChanged -= TxtLibName_TextChanged;
                }

                _txtLibName = value;
                if (_txtLibName != null)
                {
                    _txtLibName.TextChanged += TxtLibName_TextChanged;
                }
            }
        }

        private TextBox _txtLibWidth;

        public TextBox txtLibWidth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLibWidth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLibWidth != null)
                {
                    _txtLibWidth.TextChanged -= TxtLibWidth_TextChanged;
                }

                _txtLibWidth = value;
                if (_txtLibWidth != null)
                {
                    _txtLibWidth.TextChanged += TxtLibWidth_TextChanged;
                }
            }
        }

        private TextBox _txtLibLength;

        public TextBox txtLibLength
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLibLength;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLibLength != null)
                {
                    _txtLibLength.TextChanged -= TxtLibLength_TextChanged;
                }

                _txtLibLength = value;
                if (_txtLibLength != null)
                {
                    _txtLibLength.TextChanged += TxtLibLength_TextChanged;
                }
            }
        }

        private Button _cmdUpDefault;

        internal Button cmdUpDefault
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUpDefault;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUpDefault != null)
                {
                    _cmdUpDefault.Click -= CmdUpDefault_Click;
                }

                _cmdUpDefault = value;
                if (_cmdUpDefault != null)
                {
                    _cmdUpDefault.Click += CmdUpDefault_Click;
                }
            }
        }

        private TextBox _txtLibScale;

        public TextBox txtLibScale
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLibScale;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLibScale != null)
                {
                    _txtLibScale.TextChanged -= TxtLibScale_TextChanged;
                }

                _txtLibScale = value;
                if (_txtLibScale != null)
                {
                    _txtLibScale.TextChanged += TxtLibScale_TextChanged;
                }
            }
        }

        public Label LabelLibName;
        public Label labelLib2;
        public Label LabelLib1;
        public Label LabelLib3;
        internal ContextMenuStrip PopUpMenu;
        private ToolStripMenuItem _DeletePopUpMenuItem;

        internal ToolStripMenuItem DeletePopUpMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _DeletePopUpMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_DeletePopUpMenuItem != null)
                {
                    _DeletePopUpMenuItem.Click -= DeletePopUpMenuItem_Click;
                }

                _DeletePopUpMenuItem = value;
                if (_DeletePopUpMenuItem != null)
                {
                    _DeletePopUpMenuItem.Click += DeletePopUpMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _FromFilePopUpMenuItem;

        internal ToolStripMenuItem FromFilePopUpMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _FromFilePopUpMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_FromFilePopUpMenuItem != null)
                {
                    _FromFilePopUpMenuItem.Click -= FromFilePopUpMenuItem_Click;
                }

                _FromFilePopUpMenuItem = value;
                if (_FromFilePopUpMenuItem != null)
                {
                    _FromFilePopUpMenuItem.Click += FromFilePopUpMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _CapturePopUpMenuItem;

        internal ToolStripMenuItem CapturePopUpMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _CapturePopUpMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_CapturePopUpMenuItem != null)
                {
                    _CapturePopUpMenuItem.Click -= CapturePopUPMenuItem_Click;
                }

                _CapturePopUpMenuItem = value;
                if (_CapturePopUpMenuItem != null)
                {
                    _CapturePopUpMenuItem.Click += CapturePopUPMenuItem_Click;
                }
            }
        }

        internal ToolStripMenuItem TitlePopUpMenuItem;
        internal ToolStripSeparator ToolStripSeparator1;
        private ToolStripMenuItem _PurgePopUPMenuItem;

        internal ToolStripMenuItem PurgePopUPMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _PurgePopUPMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_PurgePopUPMenuItem != null)
                {
                    _PurgePopUPMenuItem.Click -= PurgePopUPMenuItem_Click;
                }

                _PurgePopUPMenuItem = value;
                if (_PurgePopUPMenuItem != null)
                {
                    _PurgePopUPMenuItem.Click += PurgePopUPMenuItem_Click;
                }
            }
        }

        private ToolStripMenuItem _EnlargePopUpMenuItem;

        internal ToolStripMenuItem EnlargePopUpMenuItem
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _EnlargePopUpMenuItem;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_EnlargePopUpMenuItem != null)
                {
                    _EnlargePopUpMenuItem.Click -= EnlargePopUpMenuItem_Click;
                }

                _EnlargePopUpMenuItem = value;
                if (_EnlargePopUpMenuItem != null)
                {
                    _EnlargePopUpMenuItem.Click += EnlargePopUpMenuItem_Click;
                }
            }
        }

        internal RadioButton optGbMultiSided;
        internal RadioButton optGbPyramidal;
        internal RadioButton optGbSlant;
        internal RadioButton optGbRidge;
        internal RadioButton optGbPeaked;
        internal RadioButton optGbFlat;
        internal NumericUpDown nUPscale;
        internal NumericUpDown nUPsizeZ;
        internal NumericUpDown nUPsizeX;
        internal Label lbgb2;
        internal Label lbgb1;
        private ListBox _lstGenB;

        public ListBox lstGenB
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lstGenB;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lstGenB != null)
                {
                    _lstGenB.SelectedIndexChanged -= LstGenB_SelectedIndexChanged;
                }

                _lstGenB = value;
                if (_lstGenB != null)
                {
                    _lstGenB.SelectedIndexChanged += LstGenB_SelectedIndexChanged;
                }
            }
        }

        private Button _cmdGbLoad;

        public Button cmdGbLoad
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdGbLoad;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdGbLoad != null)
                {
                    _cmdGbLoad.Click -= CmdGbLoad_Click;
                }

                _cmdGbLoad = value;
                if (_cmdGbLoad != null)
                {
                    _cmdGbLoad.Click += CmdGbLoad_Click;
                }
            }
        }

        private Button _cmdGbStore;

        public Button cmdGbStore
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdGbStore;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdGbStore != null)
                {
                    _cmdGbStore.Click -= CmdGbStore_Click;
                }

                _cmdGbStore = value;
                if (_cmdGbStore != null)
                {
                    _cmdGbStore.Click += CmdGbStore_Click;
                }
            }
        }

        private Button _cmdGBDelete;

        public Button cmdGBDelete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdGBDelete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdGBDelete != null)
                {
                    _cmdGBDelete.Click -= CmdGBDelete_Click;
                }

                _cmdGBDelete = value;
                if (_cmdGBDelete != null)
                {
                    _cmdGBDelete.Click += CmdGBDelete_Click;
                }
            }
        }

        internal Label Label15;
        internal Label Label14;
        internal Label Label16;
        public RadioButton opEDense;
    }
}