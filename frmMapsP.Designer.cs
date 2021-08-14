using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMapsP));
            this._cmdCalibrateMain = new System.Windows.Forms.Button();
            this._cmdData = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.SSTab1 = new System.Windows.Forms.TabControl();
            this._SSTab1_TabPage4 = new System.Windows.Forms.TabPage();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.txtCellY = new System.Windows.Forms.TextBox();
            this.txtCellX = new System.Windows.Forms.TextBox();
            this.Label18 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbRows = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.lbCols = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.txtELon = new System.Windows.Forms.TextBox();
            this.txtSLat = new System.Windows.Forms.TextBox();
            this.txtWLon = new System.Windows.Forms.TextBox();
            this.txtNLat = new System.Windows.Forms.TextBox();
            this._SSTab1_TabPage1 = new System.Windows.Forms.TabPage();
            this._cmdSummer = new System.Windows.Forms.Button();
            this.Label21 = new System.Windows.Forms.Label();
            this.txtBMPSummer = new System.Windows.Forms.TextBox();
            this.txtBMPSpring = new System.Windows.Forms.TextBox();
            this.txtBMPFall = new System.Windows.Forms.TextBox();
            this.txtBMPWinter = new System.Windows.Forms.TextBox();
            this.txtBMPHard = new System.Windows.Forms.TextBox();
            this.txtBMPNight = new System.Windows.Forms.TextBox();
            this._cmdSpring = new System.Windows.Forms.Button();
            this._cmdFall = new System.Windows.Forms.Button();
            this._cmdWinter = new System.Windows.Forms.Button();
            this._cmdHard = new System.Windows.Forms.Button();
            this._cmdNight = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this._cmdGeoTiff = new System.Windows.Forms.Button();
            this.SSTab1.SuspendLayout();
            this._SSTab1_TabPage4.SuspendLayout();
            this._SSTab1_TabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdCalibrateMain
            // 
            this._cmdCalibrateMain.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCalibrateMain.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCalibrateMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCalibrateMain.Location = new System.Drawing.Point(178, 247);
            this._cmdCalibrateMain.Name = "_cmdCalibrateMain";
            this._cmdCalibrateMain.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCalibrateMain.Size = new System.Drawing.Size(62, 25);
            this._cmdCalibrateMain.TabIndex = 84;
            this._cmdCalibrateMain.Text = "Calibrate";
            this._cmdCalibrateMain.UseVisualStyleBackColor = false;
            this._cmdCalibrateMain.Click += new System.EventHandler(this.CmdCalibrateMain_Click);
            // 
            // _cmdData
            // 
            this._cmdData.BackColor = System.Drawing.SystemColors.Control;
            this._cmdData.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdData.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdData.Location = new System.Drawing.Point(97, 247);
            this._cmdData.Name = "_cmdData";
            this._cmdData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdData.Size = new System.Drawing.Size(62, 25);
            this._cmdData.TabIndex = 83;
            this._cmdData.Text = "Data File";
            this._cmdData.UseVisualStyleBackColor = false;
            this._cmdData.Click += new System.EventHandler(this.CmdData_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(259, 247);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(62, 25);
            this._cmdCancel.TabIndex = 82;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(340, 247);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(62, 25);
            this._cmdOK.TabIndex = 81;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // SSTab1
            // 
            this.SSTab1.Controls.Add(this._SSTab1_TabPage4);
            this.SSTab1.Controls.Add(this._SSTab1_TabPage1);
            this.SSTab1.ItemSize = new System.Drawing.Size(42, 18);
            this.SSTab1.Location = new System.Drawing.Point(17, 13);
            this.SSTab1.Name = "SSTab1";
            this.SSTab1.SelectedIndex = 0;
            this.SSTab1.Size = new System.Drawing.Size(388, 224);
            this.SSTab1.TabIndex = 80;
            // 
            // _SSTab1_TabPage4
            // 
            this._SSTab1_TabPage4.BackColor = System.Drawing.Color.Transparent;
            this._SSTab1_TabPage4.Controls.Add(this.Label1);
            this._SSTab1_TabPage4.Controls.Add(this.Label15);
            this._SSTab1_TabPage4.Controls.Add(this.Label14);
            this._SSTab1_TabPage4.Controls.Add(this.txtCellY);
            this._SSTab1_TabPage4.Controls.Add(this.txtCellX);
            this._SSTab1_TabPage4.Controls.Add(this.Label18);
            this._SSTab1_TabPage4.Controls.Add(this.txtName);
            this._SSTab1_TabPage4.Controls.Add(this.lbRows);
            this._SSTab1_TabPage4.Controls.Add(this.Label13);
            this._SSTab1_TabPage4.Controls.Add(this.Label12);
            this._SSTab1_TabPage4.Controls.Add(this.lbCols);
            this._SSTab1_TabPage4.Controls.Add(this.Label11);
            this._SSTab1_TabPage4.Controls.Add(this.Label10);
            this._SSTab1_TabPage4.Controls.Add(this.Label9);
            this._SSTab1_TabPage4.Controls.Add(this.Label8);
            this._SSTab1_TabPage4.Controls.Add(this.txtELon);
            this._SSTab1_TabPage4.Controls.Add(this.txtSLat);
            this._SSTab1_TabPage4.Controls.Add(this.txtWLon);
            this._SSTab1_TabPage4.Controls.Add(this.txtNLat);
            this._SSTab1_TabPage4.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage4.Name = "_SSTab1_TabPage4";
            this._SSTab1_TabPage4.Size = new System.Drawing.Size(380, 198);
            this._SSTab1_TabPage4.TabIndex = 4;
            this._SSTab1_TabPage4.Text = "General";
            this._SSTab1_TabPage4.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(359, 33);
            this.Label1.TabIndex = 71;
            this.Label1.Text = "Class and Photo maps should have names starting by \"Class\" or \"Photo\". In additio" +
    "n Photo Maps need to be placed in the ../Tools/Work/ folder.";
            // 
            // Label15
            // 
            this.Label15.BackColor = System.Drawing.Color.Transparent;
            this.Label15.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label15.Location = new System.Drawing.Point(207, 146);
            this.Label15.Name = "Label15";
            this.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label15.Size = new System.Drawing.Size(112, 16);
            this.Label15.TabIndex = 69;
            this.Label15.Text = "CellYDimensionDeg";
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.Transparent;
            this.Label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label14.Location = new System.Drawing.Point(23, 146);
            this.Label14.Name = "Label14";
            this.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label14.Size = new System.Drawing.Size(112, 16);
            this.Label14.TabIndex = 70;
            this.Label14.Text = "CellXDimensionDeg";
            // 
            // txtCellY
            // 
            this.txtCellY.AcceptsReturn = true;
            this.txtCellY.BackColor = System.Drawing.SystemColors.Window;
            this.txtCellY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCellY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCellY.Location = new System.Drawing.Point(210, 165);
            this.txtCellY.MaxLength = 0;
            this.txtCellY.Name = "txtCellY";
            this.txtCellY.ReadOnly = true;
            this.txtCellY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCellY.Size = new System.Drawing.Size(149, 20);
            this.txtCellY.TabIndex = 67;
            this.txtCellY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCellX
            // 
            this.txtCellX.AcceptsReturn = true;
            this.txtCellX.BackColor = System.Drawing.SystemColors.Window;
            this.txtCellX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCellX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCellX.Location = new System.Drawing.Point(26, 165);
            this.txtCellX.MaxLength = 0;
            this.txtCellX.Name = "txtCellX";
            this.txtCellX.ReadOnly = true;
            this.txtCellX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCellX.Size = new System.Drawing.Size(149, 20);
            this.txtCellX.TabIndex = 68;
            this.txtCellX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label18
            // 
            this.Label18.BackColor = System.Drawing.Color.Transparent;
            this.Label18.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label18.Location = new System.Drawing.Point(4, 60);
            this.Label18.Name = "Label18";
            this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label18.Size = new System.Drawing.Size(64, 13);
            this.Label18.TabIndex = 66;
            this.Label18.Text = "Map Name";
            this.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.BackColor = System.Drawing.SystemColors.Window;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(72, 57);
            this.txtName.MaxLength = 0;
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtName.Size = new System.Drawing.Size(103, 20);
            this.txtName.TabIndex = 65;
            // 
            // lbRows
            // 
            this.lbRows.BackColor = System.Drawing.Color.Transparent;
            this.lbRows.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbRows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRows.Location = new System.Drawing.Point(316, 64);
            this.lbRows.Name = "lbRows";
            this.lbRows.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbRows.Size = new System.Drawing.Size(46, 19);
            this.lbRows.TabIndex = 54;
            // 
            // Label13
            // 
            this.Label13.BackColor = System.Drawing.Color.Transparent;
            this.Label13.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label13.Location = new System.Drawing.Point(224, 64);
            this.Label13.Name = "Label13";
            this.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label13.Size = new System.Drawing.Size(95, 16);
            this.Label13.TabIndex = 53;
            this.Label13.Text = "No of Rows  =";
            this.Label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.Transparent;
            this.Label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label12.Location = new System.Drawing.Point(221, 48);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label12.Size = new System.Drawing.Size(98, 16);
            this.Label12.TabIndex = 52;
            this.Label12.Text = "No of Columns  =";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbCols
            // 
            this.lbCols.BackColor = System.Drawing.Color.Transparent;
            this.lbCols.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbCols.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbCols.Location = new System.Drawing.Point(316, 48);
            this.lbCols.Name = "lbCols";
            this.lbCols.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCols.Size = new System.Drawing.Size(46, 19);
            this.lbCols.TabIndex = 51;
            // 
            // Label11
            // 
            this.Label11.BackColor = System.Drawing.Color.Transparent;
            this.Label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label11.Location = new System.Drawing.Point(196, 117);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label11.Size = new System.Drawing.Size(61, 16);
            this.Label11.TabIndex = 44;
            this.Label11.Text = "East Long";
            this.Label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label10
            // 
            this.Label10.BackColor = System.Drawing.Color.Transparent;
            this.Label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label10.Location = new System.Drawing.Point(199, 88);
            this.Label10.Name = "Label10";
            this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label10.Size = new System.Drawing.Size(58, 16);
            this.Label10.TabIndex = 45;
            this.Label10.Text = "South Lat";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label9
            // 
            this.Label9.BackColor = System.Drawing.Color.Transparent;
            this.Label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label9.Location = new System.Drawing.Point(12, 122);
            this.Label9.Name = "Label9";
            this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label9.Size = new System.Drawing.Size(56, 16);
            this.Label9.TabIndex = 46;
            this.Label9.Text = "West Lon";
            this.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label8
            // 
            this.Label8.BackColor = System.Drawing.Color.Transparent;
            this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label8.Location = new System.Drawing.Point(15, 92);
            this.Label8.Name = "Label8";
            this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label8.Size = new System.Drawing.Size(55, 16);
            this.Label8.TabIndex = 47;
            this.Label8.Text = "North Lat";
            this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtELon
            // 
            this.txtELon.AcceptsReturn = true;
            this.txtELon.BackColor = System.Drawing.SystemColors.Window;
            this.txtELon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtELon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtELon.Location = new System.Drawing.Point(259, 114);
            this.txtELon.MaxLength = 0;
            this.txtELon.Name = "txtELon";
            this.txtELon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtELon.Size = new System.Drawing.Size(100, 20);
            this.txtELon.TabIndex = 40;
            this.txtELon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSLat
            // 
            this.txtSLat.AcceptsReturn = true;
            this.txtSLat.BackColor = System.Drawing.SystemColors.Window;
            this.txtSLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSLat.Location = new System.Drawing.Point(259, 84);
            this.txtSLat.MaxLength = 0;
            this.txtSLat.Name = "txtSLat";
            this.txtSLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSLat.Size = new System.Drawing.Size(100, 20);
            this.txtSLat.TabIndex = 41;
            this.txtSLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWLon
            // 
            this.txtWLon.AcceptsReturn = true;
            this.txtWLon.BackColor = System.Drawing.SystemColors.Window;
            this.txtWLon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWLon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWLon.Location = new System.Drawing.Point(72, 119);
            this.txtWLon.MaxLength = 0;
            this.txtWLon.Name = "txtWLon";
            this.txtWLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWLon.Size = new System.Drawing.Size(103, 20);
            this.txtWLon.TabIndex = 42;
            this.txtWLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNLat
            // 
            this.txtNLat.AcceptsReturn = true;
            this.txtNLat.BackColor = System.Drawing.SystemColors.Window;
            this.txtNLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNLat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNLat.Location = new System.Drawing.Point(72, 88);
            this.txtNLat.MaxLength = 0;
            this.txtNLat.Name = "txtNLat";
            this.txtNLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNLat.Size = new System.Drawing.Size(103, 20);
            this.txtNLat.TabIndex = 43;
            this.txtNLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _SSTab1_TabPage1
            // 
            this._SSTab1_TabPage1.BackColor = System.Drawing.Color.Transparent;
            this._SSTab1_TabPage1.Controls.Add(this._cmdSummer);
            this._SSTab1_TabPage1.Controls.Add(this.Label21);
            this._SSTab1_TabPage1.Controls.Add(this.txtBMPSummer);
            this._SSTab1_TabPage1.Controls.Add(this.txtBMPSpring);
            this._SSTab1_TabPage1.Controls.Add(this.txtBMPFall);
            this._SSTab1_TabPage1.Controls.Add(this.txtBMPWinter);
            this._SSTab1_TabPage1.Controls.Add(this.txtBMPHard);
            this._SSTab1_TabPage1.Controls.Add(this.txtBMPNight);
            this._SSTab1_TabPage1.Controls.Add(this._cmdSpring);
            this._SSTab1_TabPage1.Controls.Add(this._cmdFall);
            this._SSTab1_TabPage1.Controls.Add(this._cmdWinter);
            this._SSTab1_TabPage1.Controls.Add(this._cmdHard);
            this._SSTab1_TabPage1.Controls.Add(this._cmdNight);
            this._SSTab1_TabPage1.Controls.Add(this.Label2);
            this._SSTab1_TabPage1.Controls.Add(this.Label3);
            this._SSTab1_TabPage1.Controls.Add(this.Label4);
            this._SSTab1_TabPage1.Controls.Add(this.Label5);
            this._SSTab1_TabPage1.Controls.Add(this.Label6);
            this._SSTab1_TabPage1.Location = new System.Drawing.Point(4, 22);
            this._SSTab1_TabPage1.Name = "_SSTab1_TabPage1";
            this._SSTab1_TabPage1.Size = new System.Drawing.Size(380, 198);
            this._SSTab1_TabPage1.TabIndex = 1;
            this._SSTab1_TabPage1.Text = "Seasons";
            this._SSTab1_TabPage1.UseVisualStyleBackColor = true;
            // 
            // _cmdSummer
            // 
            this._cmdSummer.BackColor = System.Drawing.SystemColors.Control;
            this._cmdSummer.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdSummer.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdSummer.Location = new System.Drawing.Point(329, 15);
            this._cmdSummer.Name = "_cmdSummer";
            this._cmdSummer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdSummer.Size = new System.Drawing.Size(34, 20);
            this._cmdSummer.TabIndex = 52;
            this._cmdSummer.Text = " ...";
            this._cmdSummer.UseVisualStyleBackColor = false;
            this._cmdSummer.Click += new System.EventHandler(this.CmdSummer_Click);
            // 
            // Label21
            // 
            this.Label21.BackColor = System.Drawing.Color.Transparent;
            this.Label21.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label21.Location = new System.Drawing.Point(24, 17);
            this.Label21.Name = "Label21";
            this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label21.Size = new System.Drawing.Size(53, 18);
            this.Label21.TabIndex = 51;
            this.Label21.Text = "Summer";
            this.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBMPSummer
            // 
            this.txtBMPSummer.AcceptsReturn = true;
            this.txtBMPSummer.BackColor = System.Drawing.SystemColors.Window;
            this.txtBMPSummer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBMPSummer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBMPSummer.Location = new System.Drawing.Point(83, 17);
            this.txtBMPSummer.MaxLength = 0;
            this.txtBMPSummer.Name = "txtBMPSummer";
            this.txtBMPSummer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBMPSummer.Size = new System.Drawing.Size(228, 20);
            this.txtBMPSummer.TabIndex = 49;
            // 
            // txtBMPSpring
            // 
            this.txtBMPSpring.AcceptsReturn = true;
            this.txtBMPSpring.BackColor = System.Drawing.SystemColors.Window;
            this.txtBMPSpring.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBMPSpring.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBMPSpring.Location = new System.Drawing.Point(83, 43);
            this.txtBMPSpring.MaxLength = 0;
            this.txtBMPSpring.Name = "txtBMPSpring";
            this.txtBMPSpring.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBMPSpring.Size = new System.Drawing.Size(228, 20);
            this.txtBMPSpring.TabIndex = 14;
            // 
            // txtBMPFall
            // 
            this.txtBMPFall.AcceptsReturn = true;
            this.txtBMPFall.BackColor = System.Drawing.SystemColors.Window;
            this.txtBMPFall.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBMPFall.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBMPFall.Location = new System.Drawing.Point(83, 69);
            this.txtBMPFall.MaxLength = 0;
            this.txtBMPFall.Name = "txtBMPFall";
            this.txtBMPFall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBMPFall.Size = new System.Drawing.Size(228, 20);
            this.txtBMPFall.TabIndex = 13;
            // 
            // txtBMPWinter
            // 
            this.txtBMPWinter.AcceptsReturn = true;
            this.txtBMPWinter.BackColor = System.Drawing.SystemColors.Window;
            this.txtBMPWinter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBMPWinter.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBMPWinter.Location = new System.Drawing.Point(83, 95);
            this.txtBMPWinter.MaxLength = 0;
            this.txtBMPWinter.Name = "txtBMPWinter";
            this.txtBMPWinter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBMPWinter.Size = new System.Drawing.Size(228, 20);
            this.txtBMPWinter.TabIndex = 12;
            // 
            // txtBMPHard
            // 
            this.txtBMPHard.AcceptsReturn = true;
            this.txtBMPHard.BackColor = System.Drawing.SystemColors.Window;
            this.txtBMPHard.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBMPHard.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBMPHard.Location = new System.Drawing.Point(83, 121);
            this.txtBMPHard.MaxLength = 0;
            this.txtBMPHard.Name = "txtBMPHard";
            this.txtBMPHard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBMPHard.Size = new System.Drawing.Size(228, 20);
            this.txtBMPHard.TabIndex = 11;
            // 
            // txtBMPNight
            // 
            this.txtBMPNight.AcceptsReturn = true;
            this.txtBMPNight.BackColor = System.Drawing.SystemColors.Window;
            this.txtBMPNight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBMPNight.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBMPNight.Location = new System.Drawing.Point(83, 160);
            this.txtBMPNight.MaxLength = 0;
            this.txtBMPNight.Name = "txtBMPNight";
            this.txtBMPNight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBMPNight.Size = new System.Drawing.Size(228, 20);
            this.txtBMPNight.TabIndex = 10;
            // 
            // _cmdSpring
            // 
            this._cmdSpring.BackColor = System.Drawing.SystemColors.Control;
            this._cmdSpring.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdSpring.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdSpring.Location = new System.Drawing.Point(329, 42);
            this._cmdSpring.Name = "_cmdSpring";
            this._cmdSpring.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdSpring.Size = new System.Drawing.Size(34, 20);
            this._cmdSpring.TabIndex = 8;
            this._cmdSpring.Text = "...";
            this._cmdSpring.UseVisualStyleBackColor = false;
            this._cmdSpring.Click += new System.EventHandler(this.CmdSpring_Click);
            // 
            // _cmdFall
            // 
            this._cmdFall.BackColor = System.Drawing.SystemColors.Control;
            this._cmdFall.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdFall.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdFall.Location = new System.Drawing.Point(329, 68);
            this._cmdFall.Name = "_cmdFall";
            this._cmdFall.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdFall.Size = new System.Drawing.Size(34, 20);
            this._cmdFall.TabIndex = 7;
            this._cmdFall.Text = "...";
            this._cmdFall.UseVisualStyleBackColor = false;
            this._cmdFall.Click += new System.EventHandler(this.CmdFall_Click);
            // 
            // _cmdWinter
            // 
            this._cmdWinter.BackColor = System.Drawing.SystemColors.Control;
            this._cmdWinter.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdWinter.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdWinter.Location = new System.Drawing.Point(329, 94);
            this._cmdWinter.Name = "_cmdWinter";
            this._cmdWinter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdWinter.Size = new System.Drawing.Size(34, 20);
            this._cmdWinter.TabIndex = 6;
            this._cmdWinter.Text = "...";
            this._cmdWinter.UseVisualStyleBackColor = false;
            this._cmdWinter.Click += new System.EventHandler(this.CmdWinter_Click);
            // 
            // _cmdHard
            // 
            this._cmdHard.BackColor = System.Drawing.SystemColors.Control;
            this._cmdHard.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdHard.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdHard.Location = new System.Drawing.Point(329, 121);
            this._cmdHard.Name = "_cmdHard";
            this._cmdHard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdHard.Size = new System.Drawing.Size(34, 20);
            this._cmdHard.TabIndex = 5;
            this._cmdHard.Text = "...";
            this._cmdHard.UseVisualStyleBackColor = false;
            this._cmdHard.Click += new System.EventHandler(this.CmdHard_Click);
            // 
            // _cmdNight
            // 
            this._cmdNight.BackColor = System.Drawing.SystemColors.Control;
            this._cmdNight.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdNight.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdNight.Location = new System.Drawing.Point(329, 160);
            this._cmdNight.Name = "_cmdNight";
            this._cmdNight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdNight.Size = new System.Drawing.Size(34, 20);
            this._cmdNight.TabIndex = 3;
            this._cmdNight.Text = "...";
            this._cmdNight.UseVisualStyleBackColor = false;
            this._cmdNight.Click += new System.EventHandler(this.CmdNight_Click);
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(22, 46);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(55, 16);
            this.Label2.TabIndex = 20;
            this.Label2.Text = "Spring";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(22, 73);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(55, 16);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Fall";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(22, 98);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(55, 16);
            this.Label4.TabIndex = 18;
            this.Label4.Text = "Winter";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label5
            // 
            this.Label5.BackColor = System.Drawing.Color.Transparent;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(2, 121);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(75, 19);
            this.Label5.TabIndex = 17;
            this.Label5.Text = "Hard Winter";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label6
            // 
            this.Label6.BackColor = System.Drawing.Color.Transparent;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(22, 164);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(55, 16);
            this.Label6.TabIndex = 16;
            this.Label6.Text = "Night";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // _cmdGeoTiff
            // 
            this._cmdGeoTiff.BackColor = System.Drawing.SystemColors.Control;
            this._cmdGeoTiff.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdGeoTiff.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdGeoTiff.Location = new System.Drawing.Point(16, 247);
            this._cmdGeoTiff.Name = "_cmdGeoTiff";
            this._cmdGeoTiff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdGeoTiff.Size = new System.Drawing.Size(62, 25);
            this._cmdGeoTiff.TabIndex = 85;
            this._cmdGeoTiff.Text = "GeoTiff";
            this._cmdGeoTiff.UseVisualStyleBackColor = false;
            this._cmdGeoTiff.Click += new System.EventHandler(this.CmdGeoTiff_Click);
            // 
            // FrmMapsP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 284);
            this.Controls.Add(this._cmdGeoTiff);
            this.Controls.Add(this._cmdCalibrateMain);
            this.Controls.Add(this._cmdData);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this.SSTab1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMapsP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Map Properties";
            this.Load += new System.EventHandler(this.FrmMapsP_Load);
            this.SSTab1.ResumeLayout(false);
            this._SSTab1_TabPage4.ResumeLayout(false);
            this._SSTab1_TabPage4.PerformLayout();
            this._SSTab1_TabPage1.ResumeLayout(false);
            this._SSTab1_TabPage1.PerformLayout();
            this.ResumeLayout(false);

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