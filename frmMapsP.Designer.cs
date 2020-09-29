using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmMapsP : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapsP));
            _cmdCalibrateMain = new Button();
            _cmdCalibrateMain.Click += new EventHandler(CmdCalibrateMain_Click);
            _cmdData = new Button();
            _cmdData.Click += new EventHandler(CmdData_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            SSTab1 = new TabControl();
            _SSTab1_TabPage4 = new TabPage();
            Label1 = new Label();
            Label15 = new Label();
            Label14 = new Label();
            txtCellY = new TextBox();
            txtCellX = new TextBox();
            Label18 = new Label();
            txtName = new TextBox();
            lbRows = new Label();
            Label13 = new Label();
            Label12 = new Label();
            lbCols = new Label();
            Label11 = new Label();
            Label10 = new Label();
            Label9 = new Label();
            Label8 = new Label();
            txtELon = new TextBox();
            txtSLat = new TextBox();
            txtWLon = new TextBox();
            txtNLat = new TextBox();
            _SSTab1_TabPage1 = new TabPage();
            _cmdSummer = new Button();
            _cmdSummer.Click += new EventHandler(CmdSummer_Click);
            Label21 = new Label();
            txtBMPSummer = new TextBox();
            txtBMPSpring = new TextBox();
            txtBMPFall = new TextBox();
            txtBMPWinter = new TextBox();
            txtBMPHard = new TextBox();
            txtBMPNight = new TextBox();
            _cmdSpring = new Button();
            _cmdSpring.Click += new EventHandler(CmdSpring_Click);
            _cmdFall = new Button();
            _cmdFall.Click += new EventHandler(CmdFall_Click);
            _cmdWinter = new Button();
            _cmdWinter.Click += new EventHandler(CmdWinter_Click);
            _cmdHard = new Button();
            _cmdHard.Click += new EventHandler(CmdHard_Click);
            _cmdNight = new Button();
            _cmdNight.Click += new EventHandler(CmdNight_Click);
            Label2 = new Label();
            Label3 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            Label6 = new Label();
            _cmdGeoTiff = new Button();
            _cmdGeoTiff.Click += new EventHandler(CmdGeoTiff_Click);
            SSTab1.SuspendLayout();
            _SSTab1_TabPage4.SuspendLayout();
            _SSTab1_TabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdCalibrateMain
            // 
            _cmdCalibrateMain.BackColor = SystemColors.Control;
            _cmdCalibrateMain.Cursor = Cursors.Default;
            _cmdCalibrateMain.ForeColor = SystemColors.ControlText;
            _cmdCalibrateMain.Location = new Point(178, 247);
            _cmdCalibrateMain.Name = "_cmdCalibrateMain";
            _cmdCalibrateMain.RightToLeft = RightToLeft.No;
            _cmdCalibrateMain.Size = new Size(62, 25);
            _cmdCalibrateMain.TabIndex = 84;
            _cmdCalibrateMain.Text = "Calibrate";
            _cmdCalibrateMain.UseVisualStyleBackColor = false;
            // 
            // cmdData
            // 
            _cmdData.BackColor = SystemColors.Control;
            _cmdData.Cursor = Cursors.Default;
            _cmdData.ForeColor = SystemColors.ControlText;
            _cmdData.Location = new Point(97, 247);
            _cmdData.Name = "_cmdData";
            _cmdData.RightToLeft = RightToLeft.No;
            _cmdData.Size = new Size(62, 25);
            _cmdData.TabIndex = 83;
            _cmdData.Text = "Data File";
            _cmdData.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(259, 247);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(62, 25);
            _cmdCancel.TabIndex = 82;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(340, 247);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(62, 25);
            _cmdOK.TabIndex = 81;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // SSTab1
            // 
            SSTab1.Controls.Add(_SSTab1_TabPage4);
            SSTab1.Controls.Add(_SSTab1_TabPage1);
            SSTab1.ItemSize = new Size(42, 18);
            SSTab1.Location = new Point(17, 13);
            SSTab1.Name = "SSTab1";
            SSTab1.SelectedIndex = 0;
            SSTab1.Size = new Size(388, 224);
            SSTab1.TabIndex = 80;
            // 
            // _SSTab1_TabPage4
            // 
            _SSTab1_TabPage4.BackColor = Color.Transparent;
            _SSTab1_TabPage4.Controls.Add(Label1);
            _SSTab1_TabPage4.Controls.Add(Label15);
            _SSTab1_TabPage4.Controls.Add(Label14);
            _SSTab1_TabPage4.Controls.Add(txtCellY);
            _SSTab1_TabPage4.Controls.Add(txtCellX);
            _SSTab1_TabPage4.Controls.Add(Label18);
            _SSTab1_TabPage4.Controls.Add(txtName);
            _SSTab1_TabPage4.Controls.Add(lbRows);
            _SSTab1_TabPage4.Controls.Add(Label13);
            _SSTab1_TabPage4.Controls.Add(Label12);
            _SSTab1_TabPage4.Controls.Add(lbCols);
            _SSTab1_TabPage4.Controls.Add(Label11);
            _SSTab1_TabPage4.Controls.Add(Label10);
            _SSTab1_TabPage4.Controls.Add(Label9);
            _SSTab1_TabPage4.Controls.Add(Label8);
            _SSTab1_TabPage4.Controls.Add(txtELon);
            _SSTab1_TabPage4.Controls.Add(txtSLat);
            _SSTab1_TabPage4.Controls.Add(txtWLon);
            _SSTab1_TabPage4.Controls.Add(txtNLat);
            _SSTab1_TabPage4.Location = new Point(4, 22);
            _SSTab1_TabPage4.Name = "_SSTab1_TabPage4";
            _SSTab1_TabPage4.Size = new Size(380, 198);
            _SSTab1_TabPage4.TabIndex = 4;
            _SSTab1_TabPage4.Text = "General";
            _SSTab1_TabPage4.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.Location = new Point(12, 12);
            Label1.Name = "Label1";
            Label1.Size = new Size(359, 33);
            Label1.TabIndex = 71;
            Label1.Text = "Class and Photo maps should have names starting by \"Class\" or \"Photo\". In additio" + "n Photo Maps need to be placed in the ../Tools/Work/ folder.";
            // 
            // Label15
            // 
            Label15.BackColor = Color.Transparent;
            Label15.Cursor = Cursors.Default;
            Label15.ForeColor = SystemColors.ControlText;
            Label15.Location = new Point(207, 146);
            Label15.Name = "Label15";
            Label15.RightToLeft = RightToLeft.No;
            Label15.Size = new Size(112, 16);
            Label15.TabIndex = 69;
            Label15.Text = "CellYDimensionDeg";
            // 
            // Label14
            // 
            Label14.BackColor = Color.Transparent;
            Label14.Cursor = Cursors.Default;
            Label14.ForeColor = SystemColors.ControlText;
            Label14.Location = new Point(23, 146);
            Label14.Name = "Label14";
            Label14.RightToLeft = RightToLeft.No;
            Label14.Size = new Size(112, 16);
            Label14.TabIndex = 70;
            Label14.Text = "CellXDimensionDeg";
            // 
            // txtCellY
            // 
            txtCellY.AcceptsReturn = true;
            txtCellY.BackColor = SystemColors.Window;
            txtCellY.Cursor = Cursors.IBeam;
            txtCellY.ForeColor = SystemColors.WindowText;
            txtCellY.Location = new Point(210, 165);
            txtCellY.MaxLength = 0;
            txtCellY.Name = "txtCellY";
            txtCellY.ReadOnly = true;
            txtCellY.RightToLeft = RightToLeft.No;
            txtCellY.Size = new Size(149, 20);
            txtCellY.TabIndex = 67;
            txtCellY.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCellX
            // 
            txtCellX.AcceptsReturn = true;
            txtCellX.BackColor = SystemColors.Window;
            txtCellX.Cursor = Cursors.IBeam;
            txtCellX.ForeColor = SystemColors.WindowText;
            txtCellX.Location = new Point(26, 165);
            txtCellX.MaxLength = 0;
            txtCellX.Name = "txtCellX";
            txtCellX.ReadOnly = true;
            txtCellX.RightToLeft = RightToLeft.No;
            txtCellX.Size = new Size(149, 20);
            txtCellX.TabIndex = 68;
            txtCellX.TextAlign = HorizontalAlignment.Center;
            // 
            // Label18
            // 
            Label18.BackColor = Color.Transparent;
            Label18.Cursor = Cursors.Default;
            Label18.ForeColor = SystemColors.ControlText;
            Label18.Location = new Point(4, 60);
            Label18.Name = "Label18";
            Label18.RightToLeft = RightToLeft.No;
            Label18.Size = new Size(64, 13);
            Label18.TabIndex = 66;
            Label18.Text = "Map Name";
            Label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            txtName.AcceptsReturn = true;
            txtName.BackColor = SystemColors.Window;
            txtName.Cursor = Cursors.IBeam;
            txtName.ForeColor = SystemColors.WindowText;
            txtName.Location = new Point(72, 57);
            txtName.MaxLength = 0;
            txtName.Name = "txtName";
            txtName.RightToLeft = RightToLeft.No;
            txtName.Size = new Size(103, 20);
            txtName.TabIndex = 65;
            // 
            // lbRows
            // 
            lbRows.BackColor = Color.Transparent;
            lbRows.Cursor = Cursors.Default;
            lbRows.ForeColor = SystemColors.ControlText;
            lbRows.Location = new Point(316, 64);
            lbRows.Name = "lbRows";
            lbRows.RightToLeft = RightToLeft.No;
            lbRows.Size = new Size(46, 19);
            lbRows.TabIndex = 54;
            // 
            // Label13
            // 
            Label13.BackColor = Color.Transparent;
            Label13.Cursor = Cursors.Default;
            Label13.ForeColor = SystemColors.ControlText;
            Label13.Location = new Point(224, 64);
            Label13.Name = "Label13";
            Label13.RightToLeft = RightToLeft.No;
            Label13.Size = new Size(95, 16);
            Label13.TabIndex = 53;
            Label13.Text = "No of Rows  =";
            Label13.TextAlign = ContentAlignment.TopRight;
            // 
            // Label12
            // 
            Label12.BackColor = Color.Transparent;
            Label12.Cursor = Cursors.Default;
            Label12.ForeColor = SystemColors.ControlText;
            Label12.Location = new Point(221, 48);
            Label12.Name = "Label12";
            Label12.RightToLeft = RightToLeft.No;
            Label12.Size = new Size(98, 16);
            Label12.TabIndex = 52;
            Label12.Text = "No of Columns  =";
            Label12.TextAlign = ContentAlignment.TopRight;
            // 
            // lbCols
            // 
            lbCols.BackColor = Color.Transparent;
            lbCols.Cursor = Cursors.Default;
            lbCols.ForeColor = SystemColors.ControlText;
            lbCols.Location = new Point(316, 48);
            lbCols.Name = "lbCols";
            lbCols.RightToLeft = RightToLeft.No;
            lbCols.Size = new Size(46, 19);
            lbCols.TabIndex = 51;
            // 
            // Label11
            // 
            Label11.BackColor = Color.Transparent;
            Label11.Cursor = Cursors.Default;
            Label11.ForeColor = SystemColors.ControlText;
            Label11.Location = new Point(196, 117);
            Label11.Name = "Label11";
            Label11.RightToLeft = RightToLeft.No;
            Label11.Size = new Size(61, 16);
            Label11.TabIndex = 44;
            Label11.Text = "East Long";
            Label11.TextAlign = ContentAlignment.TopRight;
            // 
            // Label10
            // 
            Label10.BackColor = Color.Transparent;
            Label10.Cursor = Cursors.Default;
            Label10.ForeColor = SystemColors.ControlText;
            Label10.Location = new Point(199, 88);
            Label10.Name = "Label10";
            Label10.RightToLeft = RightToLeft.No;
            Label10.Size = new Size(58, 16);
            Label10.TabIndex = 45;
            Label10.Text = "South Lat";
            Label10.TextAlign = ContentAlignment.TopRight;
            // 
            // Label9
            // 
            Label9.BackColor = Color.Transparent;
            Label9.Cursor = Cursors.Default;
            Label9.ForeColor = SystemColors.ControlText;
            Label9.Location = new Point(12, 122);
            Label9.Name = "Label9";
            Label9.RightToLeft = RightToLeft.No;
            Label9.Size = new Size(56, 16);
            Label9.TabIndex = 46;
            Label9.Text = "West Lon";
            Label9.TextAlign = ContentAlignment.TopRight;
            // 
            // Label8
            // 
            Label8.BackColor = Color.Transparent;
            Label8.Cursor = Cursors.Default;
            Label8.ForeColor = SystemColors.ControlText;
            Label8.Location = new Point(15, 92);
            Label8.Name = "Label8";
            Label8.RightToLeft = RightToLeft.No;
            Label8.Size = new Size(55, 16);
            Label8.TabIndex = 47;
            Label8.Text = "North Lat";
            Label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtELon
            // 
            txtELon.AcceptsReturn = true;
            txtELon.BackColor = SystemColors.Window;
            txtELon.Cursor = Cursors.IBeam;
            txtELon.ForeColor = SystemColors.WindowText;
            txtELon.Location = new Point(259, 114);
            txtELon.MaxLength = 0;
            txtELon.Name = "txtELon";
            txtELon.RightToLeft = RightToLeft.No;
            txtELon.Size = new Size(100, 20);
            txtELon.TabIndex = 40;
            txtELon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtSLat
            // 
            txtSLat.AcceptsReturn = true;
            txtSLat.BackColor = SystemColors.Window;
            txtSLat.Cursor = Cursors.IBeam;
            txtSLat.ForeColor = SystemColors.WindowText;
            txtSLat.Location = new Point(259, 84);
            txtSLat.MaxLength = 0;
            txtSLat.Name = "txtSLat";
            txtSLat.RightToLeft = RightToLeft.No;
            txtSLat.Size = new Size(100, 20);
            txtSLat.TabIndex = 41;
            txtSLat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWLon
            // 
            txtWLon.AcceptsReturn = true;
            txtWLon.BackColor = SystemColors.Window;
            txtWLon.Cursor = Cursors.IBeam;
            txtWLon.ForeColor = SystemColors.WindowText;
            txtWLon.Location = new Point(72, 119);
            txtWLon.MaxLength = 0;
            txtWLon.Name = "txtWLon";
            txtWLon.RightToLeft = RightToLeft.No;
            txtWLon.Size = new Size(103, 20);
            txtWLon.TabIndex = 42;
            txtWLon.TextAlign = HorizontalAlignment.Center;
            // 
            // txtNLat
            // 
            txtNLat.AcceptsReturn = true;
            txtNLat.BackColor = SystemColors.Window;
            txtNLat.Cursor = Cursors.IBeam;
            txtNLat.ForeColor = SystemColors.WindowText;
            txtNLat.Location = new Point(72, 88);
            txtNLat.MaxLength = 0;
            txtNLat.Name = "txtNLat";
            txtNLat.RightToLeft = RightToLeft.No;
            txtNLat.Size = new Size(103, 20);
            txtNLat.TabIndex = 43;
            txtNLat.TextAlign = HorizontalAlignment.Center;
            // 
            // _SSTab1_TabPage1
            // 
            _SSTab1_TabPage1.BackColor = Color.Transparent;
            _SSTab1_TabPage1.Controls.Add(_cmdSummer);
            _SSTab1_TabPage1.Controls.Add(Label21);
            _SSTab1_TabPage1.Controls.Add(txtBMPSummer);
            _SSTab1_TabPage1.Controls.Add(txtBMPSpring);
            _SSTab1_TabPage1.Controls.Add(txtBMPFall);
            _SSTab1_TabPage1.Controls.Add(txtBMPWinter);
            _SSTab1_TabPage1.Controls.Add(txtBMPHard);
            _SSTab1_TabPage1.Controls.Add(txtBMPNight);
            _SSTab1_TabPage1.Controls.Add(_cmdSpring);
            _SSTab1_TabPage1.Controls.Add(_cmdFall);
            _SSTab1_TabPage1.Controls.Add(_cmdWinter);
            _SSTab1_TabPage1.Controls.Add(_cmdHard);
            _SSTab1_TabPage1.Controls.Add(_cmdNight);
            _SSTab1_TabPage1.Controls.Add(Label2);
            _SSTab1_TabPage1.Controls.Add(Label3);
            _SSTab1_TabPage1.Controls.Add(Label4);
            _SSTab1_TabPage1.Controls.Add(Label5);
            _SSTab1_TabPage1.Controls.Add(Label6);
            _SSTab1_TabPage1.Location = new Point(4, 22);
            _SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
            _SSTab1_TabPage1.Size = new Size(380, 198);
            _SSTab1_TabPage1.TabIndex = 1;
            _SSTab1_TabPage1.Text = "Seasons";
            _SSTab1_TabPage1.UseVisualStyleBackColor = true;
            // 
            // cmdSummer
            // 
            _cmdSummer.BackColor = SystemColors.Control;
            _cmdSummer.Cursor = Cursors.Default;
            _cmdSummer.ForeColor = SystemColors.ControlText;
            _cmdSummer.Location = new Point(329, 15);
            _cmdSummer.Name = "_cmdSummer";
            _cmdSummer.RightToLeft = RightToLeft.No;
            _cmdSummer.Size = new Size(34, 20);
            _cmdSummer.TabIndex = 52;
            _cmdSummer.Text = " ...";
            _cmdSummer.UseVisualStyleBackColor = false;
            // 
            // Label21
            // 
            Label21.BackColor = Color.Transparent;
            Label21.Cursor = Cursors.Default;
            Label21.ForeColor = SystemColors.ControlText;
            Label21.Location = new Point(24, 17);
            Label21.Name = "Label21";
            Label21.RightToLeft = RightToLeft.No;
            Label21.Size = new Size(53, 18);
            Label21.TabIndex = 51;
            Label21.Text = "Summer";
            Label21.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtBMPSummer
            // 
            txtBMPSummer.AcceptsReturn = true;
            txtBMPSummer.BackColor = SystemColors.Window;
            txtBMPSummer.Cursor = Cursors.IBeam;
            txtBMPSummer.ForeColor = SystemColors.WindowText;
            txtBMPSummer.Location = new Point(83, 17);
            txtBMPSummer.MaxLength = 0;
            txtBMPSummer.Name = "txtBMPSummer";
            txtBMPSummer.RightToLeft = RightToLeft.No;
            txtBMPSummer.Size = new Size(228, 20);
            txtBMPSummer.TabIndex = 49;
            // 
            // txtBMPSpring
            // 
            txtBMPSpring.AcceptsReturn = true;
            txtBMPSpring.BackColor = SystemColors.Window;
            txtBMPSpring.Cursor = Cursors.IBeam;
            txtBMPSpring.ForeColor = SystemColors.WindowText;
            txtBMPSpring.Location = new Point(83, 43);
            txtBMPSpring.MaxLength = 0;
            txtBMPSpring.Name = "txtBMPSpring";
            txtBMPSpring.RightToLeft = RightToLeft.No;
            txtBMPSpring.Size = new Size(228, 20);
            txtBMPSpring.TabIndex = 14;
            // 
            // txtBMPFall
            // 
            txtBMPFall.AcceptsReturn = true;
            txtBMPFall.BackColor = SystemColors.Window;
            txtBMPFall.Cursor = Cursors.IBeam;
            txtBMPFall.ForeColor = SystemColors.WindowText;
            txtBMPFall.Location = new Point(83, 69);
            txtBMPFall.MaxLength = 0;
            txtBMPFall.Name = "txtBMPFall";
            txtBMPFall.RightToLeft = RightToLeft.No;
            txtBMPFall.Size = new Size(228, 20);
            txtBMPFall.TabIndex = 13;
            // 
            // txtBMPWinter
            // 
            txtBMPWinter.AcceptsReturn = true;
            txtBMPWinter.BackColor = SystemColors.Window;
            txtBMPWinter.Cursor = Cursors.IBeam;
            txtBMPWinter.ForeColor = SystemColors.WindowText;
            txtBMPWinter.Location = new Point(83, 95);
            txtBMPWinter.MaxLength = 0;
            txtBMPWinter.Name = "txtBMPWinter";
            txtBMPWinter.RightToLeft = RightToLeft.No;
            txtBMPWinter.Size = new Size(228, 20);
            txtBMPWinter.TabIndex = 12;
            // 
            // txtBMPHard
            // 
            txtBMPHard.AcceptsReturn = true;
            txtBMPHard.BackColor = SystemColors.Window;
            txtBMPHard.Cursor = Cursors.IBeam;
            txtBMPHard.ForeColor = SystemColors.WindowText;
            txtBMPHard.Location = new Point(83, 121);
            txtBMPHard.MaxLength = 0;
            txtBMPHard.Name = "txtBMPHard";
            txtBMPHard.RightToLeft = RightToLeft.No;
            txtBMPHard.Size = new Size(228, 20);
            txtBMPHard.TabIndex = 11;
            // 
            // txtBMPNight
            // 
            txtBMPNight.AcceptsReturn = true;
            txtBMPNight.BackColor = SystemColors.Window;
            txtBMPNight.Cursor = Cursors.IBeam;
            txtBMPNight.ForeColor = SystemColors.WindowText;
            txtBMPNight.Location = new Point(83, 160);
            txtBMPNight.MaxLength = 0;
            txtBMPNight.Name = "txtBMPNight";
            txtBMPNight.RightToLeft = RightToLeft.No;
            txtBMPNight.Size = new Size(228, 20);
            txtBMPNight.TabIndex = 10;
            // 
            // cmdSpring
            // 
            _cmdSpring.BackColor = SystemColors.Control;
            _cmdSpring.Cursor = Cursors.Default;
            _cmdSpring.ForeColor = SystemColors.ControlText;
            _cmdSpring.Location = new Point(329, 42);
            _cmdSpring.Name = "_cmdSpring";
            _cmdSpring.RightToLeft = RightToLeft.No;
            _cmdSpring.Size = new Size(34, 20);
            _cmdSpring.TabIndex = 8;
            _cmdSpring.Text = "...";
            _cmdSpring.UseVisualStyleBackColor = false;
            // 
            // cmdFall
            // 
            _cmdFall.BackColor = SystemColors.Control;
            _cmdFall.Cursor = Cursors.Default;
            _cmdFall.ForeColor = SystemColors.ControlText;
            _cmdFall.Location = new Point(329, 68);
            _cmdFall.Name = "_cmdFall";
            _cmdFall.RightToLeft = RightToLeft.No;
            _cmdFall.Size = new Size(34, 20);
            _cmdFall.TabIndex = 7;
            _cmdFall.Text = "...";
            _cmdFall.UseVisualStyleBackColor = false;
            // 
            // cmdWinter
            // 
            _cmdWinter.BackColor = SystemColors.Control;
            _cmdWinter.Cursor = Cursors.Default;
            _cmdWinter.ForeColor = SystemColors.ControlText;
            _cmdWinter.Location = new Point(329, 94);
            _cmdWinter.Name = "_cmdWinter";
            _cmdWinter.RightToLeft = RightToLeft.No;
            _cmdWinter.Size = new Size(34, 20);
            _cmdWinter.TabIndex = 6;
            _cmdWinter.Text = "...";
            _cmdWinter.UseVisualStyleBackColor = false;
            // 
            // cmdHard
            // 
            _cmdHard.BackColor = SystemColors.Control;
            _cmdHard.Cursor = Cursors.Default;
            _cmdHard.ForeColor = SystemColors.ControlText;
            _cmdHard.Location = new Point(329, 121);
            _cmdHard.Name = "_cmdHard";
            _cmdHard.RightToLeft = RightToLeft.No;
            _cmdHard.Size = new Size(34, 20);
            _cmdHard.TabIndex = 5;
            _cmdHard.Text = "...";
            _cmdHard.UseVisualStyleBackColor = false;
            // 
            // cmdNight
            // 
            _cmdNight.BackColor = SystemColors.Control;
            _cmdNight.Cursor = Cursors.Default;
            _cmdNight.ForeColor = SystemColors.ControlText;
            _cmdNight.Location = new Point(329, 160);
            _cmdNight.Name = "_cmdNight";
            _cmdNight.RightToLeft = RightToLeft.No;
            _cmdNight.Size = new Size(34, 20);
            _cmdNight.TabIndex = 3;
            _cmdNight.Text = "...";
            _cmdNight.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            Label2.BackColor = Color.Transparent;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(22, 46);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(55, 16);
            Label2.TabIndex = 20;
            Label2.Text = "Spring";
            Label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.BackColor = Color.Transparent;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(22, 73);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(55, 16);
            Label3.TabIndex = 19;
            Label3.Text = "Fall";
            Label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.BackColor = Color.Transparent;
            Label4.Cursor = Cursors.Default;
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(22, 98);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(55, 16);
            Label4.TabIndex = 18;
            Label4.Text = "Winter";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            Label5.BackColor = Color.Transparent;
            Label5.Cursor = Cursors.Default;
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(2, 121);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(75, 19);
            Label5.TabIndex = 17;
            Label5.Text = "Hard Winter";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            Label6.BackColor = Color.Transparent;
            Label6.Cursor = Cursors.Default;
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(22, 164);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(55, 16);
            Label6.TabIndex = 16;
            Label6.Text = "Night";
            Label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cmdGeoTiff
            // 
            _cmdGeoTiff.BackColor = SystemColors.Control;
            _cmdGeoTiff.Cursor = Cursors.Default;
            _cmdGeoTiff.ForeColor = SystemColors.ControlText;
            _cmdGeoTiff.Location = new Point(16, 247);
            _cmdGeoTiff.Name = "_cmdGeoTiff";
            _cmdGeoTiff.RightToLeft = RightToLeft.No;
            _cmdGeoTiff.Size = new Size(62, 25);
            _cmdGeoTiff.TabIndex = 85;
            _cmdGeoTiff.Text = "GeoTiff";
            _cmdGeoTiff.UseVisualStyleBackColor = false;
            // 
            // frmMapsP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 284);
            Controls.Add(_cmdGeoTiff);
            Controls.Add(_cmdCalibrateMain);
            Controls.Add(_cmdData);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdOK);
            Controls.Add(SSTab1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMapsP";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Map Properties";
            SSTab1.ResumeLayout(false);
            _SSTab1_TabPage4.ResumeLayout(false);
            _SSTab1_TabPage4.PerformLayout();
            _SSTab1_TabPage1.ResumeLayout(false);
            _SSTab1_TabPage1.PerformLayout();
            Load += new EventHandler(FrmMapsP_Load);
            ResumeLayout(false);
        }

        private Button _cmdCalibrateMain;

        public Button cmdCalibrateMain
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalibrateMain;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalibrateMain != null)
                {
                    _cmdCalibrateMain.Click -= CmdCalibrateMain_Click;
                }

                _cmdCalibrateMain = value;
                if (_cmdCalibrateMain != null)
                {
                    _cmdCalibrateMain.Click += CmdCalibrateMain_Click;
                }
            }
        }

        private Button _cmdData;

        public Button cmdData
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdData;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdData != null)
                {
                    _cmdData.Click -= CmdData_Click;
                }

                _cmdData = value;
                if (_cmdData != null)
                {
                    _cmdData.Click += CmdData_Click;
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

        public TabControl SSTab1;
        public TabPage _SSTab1_TabPage4;
        public Label Label15;
        public Label Label14;
        public TextBox txtCellY;
        public TextBox txtCellX;
        public Label Label18;
        public TextBox txtName;
        public Label lbRows;
        public Label Label13;
        public Label Label12;
        public Label lbCols;
        public Label Label11;
        public Label Label10;
        public Label Label9;
        public Label Label8;
        public TextBox txtELon;
        public TextBox txtSLat;
        public TextBox txtWLon;
        public TextBox txtNLat;
        public TabPage _SSTab1_TabPage1;
        private Button _cmdSummer;

        public Button cmdSummer
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSummer;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSummer != null)
                {
                    _cmdSummer.Click -= CmdSummer_Click;
                }

                _cmdSummer = value;
                if (_cmdSummer != null)
                {
                    _cmdSummer.Click += CmdSummer_Click;
                }
            }
        }

        public Label Label21;
        public TextBox txtBMPSummer;
        public TextBox txtBMPSpring;
        public TextBox txtBMPFall;
        public TextBox txtBMPWinter;
        public TextBox txtBMPHard;
        public TextBox txtBMPNight;
        private Button _cmdSpring;

        public Button cmdSpring
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSpring;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSpring != null)
                {
                    _cmdSpring.Click -= CmdSpring_Click;
                }

                _cmdSpring = value;
                if (_cmdSpring != null)
                {
                    _cmdSpring.Click += CmdSpring_Click;
                }
            }
        }

        private Button _cmdFall;

        public Button cmdFall
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdFall;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdFall != null)
                {
                    _cmdFall.Click -= CmdFall_Click;
                }

                _cmdFall = value;
                if (_cmdFall != null)
                {
                    _cmdFall.Click += CmdFall_Click;
                }
            }
        }

        private Button _cmdWinter;

        public Button cmdWinter
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWinter;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWinter != null)
                {
                    _cmdWinter.Click -= CmdWinter_Click;
                }

                _cmdWinter = value;
                if (_cmdWinter != null)
                {
                    _cmdWinter.Click += CmdWinter_Click;
                }
            }
        }

        private Button _cmdHard;

        public Button cmdHard
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdHard;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdHard != null)
                {
                    _cmdHard.Click -= CmdHard_Click;
                }

                _cmdHard = value;
                if (_cmdHard != null)
                {
                    _cmdHard.Click += CmdHard_Click;
                }
            }
        }

        private Button _cmdNight;

        public Button cmdNight
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdNight;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdNight != null)
                {
                    _cmdNight.Click -= CmdNight_Click;
                }

                _cmdNight = value;
                if (_cmdNight != null)
                {
                    _cmdNight.Click += CmdNight_Click;
                }
            }
        }

        public Label Label2;
        public Label Label3;
        public Label Label4;
        public Label Label5;
        public Label Label6;
        internal Label Label1;
        private Button _cmdGeoTiff;

        public Button cmdGeoTiff
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdGeoTiff;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdGeoTiff != null)
                {
                    _cmdGeoTiff.Click -= CmdGeoTiff_Click;
                }

                _cmdGeoTiff = value;
                if (_cmdGeoTiff != null)
                {
                    _cmdGeoTiff.Click += CmdGeoTiff_Click;
                }
            }
        }
    }
}