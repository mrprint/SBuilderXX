using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    internal partial class FrmLinesP : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLinesP));
            this.imgVector = new System.Windows.Forms.PictureBox();
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.ckThisColor = new System.Windows.Forms.CheckBox();
            this._cmdColor = new System.Windows.Forms.Button();
            this._cmdWinding = new System.Windows.Forms.Button();
            this.labelReverse = new System.Windows.Forms.Label();
            this.boxType = new System.Windows.Forms.GroupBox();
            this._optObjects = new System.Windows.Forms.RadioButton();
            this._cmdType = new System.Windows.Forms.Button();
            this._optExtrusion = new System.Windows.Forms.RadioButton();
            this._optTexture = new System.Windows.Forms.RadioButton();
            this._optVector = new System.Windows.Forms.RadioButton();
            this.boxAltitude = new System.Windows.Forms.GroupBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this._cmdAlt = new System.Windows.Forms.Button();
            this.boxProgressive = new System.Windows.Forms.GroupBox();
            this._cmdReverse = new System.Windows.Forms.Button();
            this._cmdWidth12 = new System.Windows.Forms.Button();
            this.txtWidth1 = new System.Windows.Forms.TextBox();
            this.txtWidth2 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.boxWidth = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this._cmdWidth = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this._TabPage2 = new System.Windows.Forms.TabPage();
            this.labelDir = new System.Windows.Forms.Label();
            this.cbLanes = new System.Windows.Forms.ComboBox();
            this.labelLanes = new System.Windows.Forms.Label();
            this.cbDir = new System.Windows.Forms.ComboBox();
            this._cmdDetail = new System.Windows.Forms.Button();
            this.labelVectorTexture = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this._listVector = new System.Windows.Forms.ListBox();
            this._TabPage3 = new System.Windows.Forms.TabPage();
            this.boxTexType = new System.Windows.Forms.GroupBox();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtTexPri = new System.Windows.Forms.TextBox();
            this.cmbComplex = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.optStanding = new System.Windows.Forms.RadioButton();
            this._optLying = new System.Windows.Forms.RadioButton();
            this.lbTexPri = new System.Windows.Forms.Label();
            this.LbV1 = new System.Windows.Forms.Label();
            this.imgTex = new System.Windows.Forms.PictureBox();
            this.boxTexTexture = new System.Windows.Forms.GroupBox();
            this._optTile = new System.Windows.Forms.RadioButton();
            this._optStretch = new System.Windows.Forms.RadioButton();
            this._cmdTex = new System.Windows.Forms.Button();
            this.txtTexName = new System.Windows.Forms.TextBox();
            this.ckNight = new System.Windows.Forms.CheckBox();
            this.optFull = new System.Windows.Forms.RadioButton();
            this._TabPage4 = new System.Windows.Forms.TabPage();
            this._cmdExtrusionProperties = new System.Windows.Forms.Button();
            this.labelProfile = new System.Windows.Forms.Label();
            this.lbguid = new System.Windows.Forms.Label();
            this.lbExt1 = new System.Windows.Forms.Label();
            this._listExtrusion = new System.Windows.Forms.ListBox();
            this._imgExtrusion = new System.Windows.Forms.PictureBox();
            this._TabPage5 = new System.Windows.Forms.TabPage();
            this.boxHeading = new System.Windows.Forms.GroupBox();
            this._ckRandom = new System.Windows.Forms.CheckBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this._cmdHeading = new System.Windows.Forms.Button();
            this.cmbComplexity = new System.Windows.Forms.ComboBox();
            this.labelComplexity = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.imgLib = new System.Windows.Forms.PictureBox();
            this._lstLib = new System.Windows.Forms.ListBox();
            this.labelLibID = new System.Windows.Forms.Label();
            this._cmbLibCat = new System.Windows.Forms.ComboBox();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdSample = new System.Windows.Forms.Button();
            this._cmdSmooth = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVector)).BeginInit();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.boxType.SuspendLayout();
            this.boxAltitude.SuspendLayout();
            this.boxProgressive.SuspendLayout();
            this.boxWidth.SuspendLayout();
            this._TabPage2.SuspendLayout();
            this._TabPage3.SuspendLayout();
            this.boxTexType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTex)).BeginInit();
            this.boxTexTexture.SuspendLayout();
            this._TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgExtrusion)).BeginInit();
            this._TabPage5.SuspendLayout();
            this.boxHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLib)).BeginInit();
            this.SuspendLayout();
            // 
            // imgVector
            // 
            this.imgVector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgVector.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgVector.Location = new System.Drawing.Point(15, 29);
            this.imgVector.Name = "imgVector";
            this.imgVector.Size = new System.Drawing.Size(200, 200);
            this.imgVector.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgVector.TabIndex = 7;
            this.imgVector.TabStop = false;
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this._TabPage2);
            this.TabControl1.Controls.Add(this._TabPage3);
            this.TabControl1.Controls.Add(this._TabPage4);
            this.TabControl1.Controls.Add(this._TabPage5);
            this.TabControl1.Location = new System.Drawing.Point(12, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(488, 267);
            this.TabControl1.TabIndex = 25;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.ckThisColor);
            this.TabPage1.Controls.Add(this._cmdColor);
            this.TabPage1.Controls.Add(this._cmdWinding);
            this.TabPage1.Controls.Add(this.labelReverse);
            this.TabPage1.Controls.Add(this.boxType);
            this.TabPage1.Controls.Add(this.boxAltitude);
            this.TabPage1.Controls.Add(this.boxProgressive);
            this.TabPage1.Controls.Add(this.boxWidth);
            this.TabPage1.Controls.Add(this.txtName);
            this.TabPage1.Controls.Add(this.labelName);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(480, 241);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // ckThisColor
            // 
            this.ckThisColor.AllowDrop = true;
            this.ckThisColor.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ckThisColor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckThisColor.Location = new System.Drawing.Point(344, 16);
            this.ckThisColor.Name = "ckThisColor";
            this.ckThisColor.Size = new System.Drawing.Size(118, 32);
            this.ckThisColor.TabIndex = 40;
            this.ckThisColor.Text = "Also use this Color if Vector Line?";
            this.ckThisColor.UseVisualStyleBackColor = false;
            // 
            // _cmdColor
            // 
            this._cmdColor.Location = new System.Drawing.Point(298, 19);
            this._cmdColor.Name = "_cmdColor";
            this._cmdColor.Size = new System.Drawing.Size(40, 25);
            this._cmdColor.TabIndex = 39;
            this._cmdColor.Text = "Color";
            this._cmdColor.UseVisualStyleBackColor = true;
            this._cmdColor.Click += new System.EventHandler(this.CmdColor_Click);
            // 
            // _cmdWinding
            // 
            this._cmdWinding.Location = new System.Drawing.Point(134, 83);
            this._cmdWinding.Name = "_cmdWinding";
            this._cmdWinding.Size = new System.Drawing.Size(63, 25);
            this._cmdWinding.TabIndex = 40;
            this._cmdWinding.Text = "Reverse";
            this._cmdWinding.UseVisualStyleBackColor = true;
            this._cmdWinding.Click += new System.EventHandler(this.CmdWinding_Click);
            // 
            // labelReverse
            // 
            this.labelReverse.Location = new System.Drawing.Point(14, 63);
            this.labelReverse.Name = "labelReverse";
            this.labelReverse.Size = new System.Drawing.Size(114, 57);
            this.labelReverse.TabIndex = 66;
            this.labelReverse.Text = "On a shoreline with waves, Reverse will place the waves on the other side.";
            // 
            // boxType
            // 
            this.boxType.Controls.Add(this._optObjects);
            this.boxType.Controls.Add(this._cmdType);
            this.boxType.Controls.Add(this._optExtrusion);
            this.boxType.Controls.Add(this._optTexture);
            this.boxType.Controls.Add(this._optVector);
            this.boxType.Location = new System.Drawing.Point(15, 123);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(182, 97);
            this.boxType.TabIndex = 65;
            this.boxType.TabStop = false;
            this.boxType.Text = "Line type";
            // 
            // _optObjects
            // 
            this._optObjects.Location = new System.Drawing.Point(109, 9);
            this._optObjects.Name = "_optObjects";
            this._optObjects.Size = new System.Drawing.Size(67, 37);
            this._optObjects.TabIndex = 1;
            this._optObjects.Text = "Line of Objects";
            this._optObjects.UseVisualStyleBackColor = true;
            this._optObjects.CheckedChanged += new System.EventHandler(this.OptObjects_CheckedChanged);
            // 
            // _cmdType
            // 
            this._cmdType.Location = new System.Drawing.Point(135, 59);
            this._cmdType.Name = "_cmdType";
            this._cmdType.Size = new System.Drawing.Size(34, 24);
            this._cmdType.TabIndex = 2;
            this._cmdType.Text = ">>>";
            this._cmdType.UseVisualStyleBackColor = true;
            this._cmdType.Click += new System.EventHandler(this.CmdType_Click);
            // 
            // _optExtrusion
            // 
            this._optExtrusion.AutoSize = true;
            this._optExtrusion.Location = new System.Drawing.Point(13, 42);
            this._optExtrusion.Name = "_optExtrusion";
            this._optExtrusion.Size = new System.Drawing.Size(101, 17);
            this._optExtrusion.TabIndex = 1;
            this._optExtrusion.Text = "Extrusion Bridge";
            this._optExtrusion.UseVisualStyleBackColor = true;
            this._optExtrusion.CheckedChanged += new System.EventHandler(this.OptExtrusion_CheckedChanged);
            // 
            // _optTexture
            // 
            this._optTexture.AutoSize = true;
            this._optTexture.Location = new System.Drawing.Point(13, 63);
            this._optTexture.Name = "_optTexture";
            this._optTexture.Size = new System.Drawing.Size(90, 17);
            this._optTexture.TabIndex = 1;
            this._optTexture.Text = "Textured Line";
            this._optTexture.UseVisualStyleBackColor = true;
            this._optTexture.CheckedChanged += new System.EventHandler(this.OptTexture_CheckedChanged);
            // 
            // _optVector
            // 
            this._optVector.AutoSize = true;
            this._optVector.Checked = true;
            this._optVector.Location = new System.Drawing.Point(13, 19);
            this._optVector.Name = "_optVector";
            this._optVector.Size = new System.Drawing.Size(79, 17);
            this._optVector.TabIndex = 0;
            this._optVector.TabStop = true;
            this._optVector.Text = "Vector Line";
            this._optVector.UseVisualStyleBackColor = true;
            this._optVector.CheckedChanged += new System.EventHandler(this.OptVector_CheckedChanged);
            // 
            // boxAltitude
            // 
            this.boxAltitude.Controls.Add(this.txtAlt);
            this.boxAltitude.Controls.Add(this._cmdAlt);
            this.boxAltitude.Location = new System.Drawing.Point(344, 152);
            this.boxAltitude.Name = "boxAltitude";
            this.boxAltitude.Size = new System.Drawing.Size(118, 68);
            this.boxAltitude.TabIndex = 58;
            this.boxAltitude.TabStop = false;
            this.boxAltitude.Text = "Altitude";
            // 
            // txtAlt
            // 
            this.txtAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlt.Location = new System.Drawing.Point(12, 26);
            this.txtAlt.MaxLength = 0;
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlt.Size = new System.Drawing.Size(50, 20);
            this.txtAlt.TabIndex = 29;
            this.txtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdAlt
            // 
            this._cmdAlt.BackColor = System.Drawing.SystemColors.Control;
            this._cmdAlt.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAlt.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAlt.Location = new System.Drawing.Point(68, 23);
            this._cmdAlt.Name = "_cmdAlt";
            this._cmdAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAlt.Size = new System.Drawing.Size(35, 25);
            this._cmdAlt.TabIndex = 28;
            this._cmdAlt.Text = "Set";
            this._cmdAlt.UseVisualStyleBackColor = false;
            this._cmdAlt.Click += new System.EventHandler(this.CmdAlt_Click);
            // 
            // boxProgressive
            // 
            this.boxProgressive.Controls.Add(this._cmdReverse);
            this.boxProgressive.Controls.Add(this._cmdWidth12);
            this.boxProgressive.Controls.Add(this.txtWidth1);
            this.boxProgressive.Controls.Add(this.txtWidth2);
            this.boxProgressive.Controls.Add(this.Label1);
            this.boxProgressive.Controls.Add(this.Label2);
            this.boxProgressive.Location = new System.Drawing.Point(212, 63);
            this.boxProgressive.Name = "boxProgressive";
            this.boxProgressive.Size = new System.Drawing.Size(250, 77);
            this.boxProgressive.TabIndex = 38;
            this.boxProgressive.TabStop = false;
            this.boxProgressive.Text = "Progressive width";
            // 
            // _cmdReverse
            // 
            this._cmdReverse.BackColor = System.Drawing.SystemColors.Control;
            this._cmdReverse.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdReverse.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdReverse.Location = new System.Drawing.Point(138, 40);
            this._cmdReverse.Name = "_cmdReverse";
            this._cmdReverse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdReverse.Size = new System.Drawing.Size(50, 25);
            this._cmdReverse.TabIndex = 42;
            this._cmdReverse.Text = "Switch";
            this._cmdReverse.UseVisualStyleBackColor = false;
            this._cmdReverse.Click += new System.EventHandler(this.CmdReverse_Click);
            // 
            // _cmdWidth12
            // 
            this._cmdWidth12.BackColor = System.Drawing.SystemColors.Control;
            this._cmdWidth12.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdWidth12.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdWidth12.Location = new System.Drawing.Point(200, 40);
            this._cmdWidth12.Name = "_cmdWidth12";
            this._cmdWidth12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdWidth12.Size = new System.Drawing.Size(35, 25);
            this._cmdWidth12.TabIndex = 39;
            this._cmdWidth12.Text = "Set";
            this._cmdWidth12.UseVisualStyleBackColor = false;
            this._cmdWidth12.Click += new System.EventHandler(this.CmdWidth12_Click);
            // 
            // txtWidth1
            // 
            this.txtWidth1.AcceptsReturn = true;
            this.txtWidth1.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWidth1.Location = new System.Drawing.Point(10, 43);
            this.txtWidth1.MaxLength = 0;
            this.txtWidth1.Name = "txtWidth1";
            this.txtWidth1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWidth1.Size = new System.Drawing.Size(53, 20);
            this.txtWidth1.TabIndex = 38;
            this.txtWidth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWidth2
            // 
            this.txtWidth2.AcceptsReturn = true;
            this.txtWidth2.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWidth2.Location = new System.Drawing.Point(73, 43);
            this.txtWidth2.MaxLength = 0;
            this.txtWidth2.Name = "txtWidth2";
            this.txtWidth2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWidth2.Size = new System.Drawing.Size(53, 20);
            this.txtWidth2.TabIndex = 37;
            this.txtWidth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(10, 27);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "Start";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(70, 27);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(26, 13);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "End";
            // 
            // boxWidth
            // 
            this.boxWidth.Controls.Add(this.txtWidth);
            this.boxWidth.Controls.Add(this._cmdWidth);
            this.boxWidth.Location = new System.Drawing.Point(212, 152);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(118, 68);
            this.boxWidth.TabIndex = 37;
            this.boxWidth.TabStop = false;
            this.boxWidth.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.AcceptsReturn = true;
            this.txtWidth.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWidth.Location = new System.Drawing.Point(9, 29);
            this.txtWidth.MaxLength = 0;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWidth.Size = new System.Drawing.Size(53, 20);
            this.txtWidth.TabIndex = 29;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdWidth
            // 
            this._cmdWidth.BackColor = System.Drawing.SystemColors.Control;
            this._cmdWidth.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdWidth.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdWidth.Location = new System.Drawing.Point(68, 26);
            this._cmdWidth.Name = "_cmdWidth";
            this._cmdWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdWidth.Size = new System.Drawing.Size(35, 25);
            this._cmdWidth.TabIndex = 28;
            this._cmdWidth.Text = "Set";
            this._cmdWidth.UseVisualStyleBackColor = false;
            this._cmdWidth.Click += new System.EventHandler(this.CmdWidth_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(62, 22);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(201, 20);
            this.txtName.TabIndex = 32;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(21, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Name";
            // 
            // _TabPage2
            // 
            this._TabPage2.Controls.Add(this.labelDir);
            this._TabPage2.Controls.Add(this.cbLanes);
            this._TabPage2.Controls.Add(this.labelLanes);
            this._TabPage2.Controls.Add(this.cbDir);
            this._TabPage2.Controls.Add(this._cmdDetail);
            this._TabPage2.Controls.Add(this.labelVectorTexture);
            this._TabPage2.Controls.Add(this.Label5);
            this._TabPage2.Controls.Add(this._listVector);
            this._TabPage2.Controls.Add(this.imgVector);
            this._TabPage2.Location = new System.Drawing.Point(4, 22);
            this._TabPage2.Name = "_TabPage2";
            this._TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._TabPage2.Size = new System.Drawing.Size(480, 241);
            this._TabPage2.TabIndex = 1;
            this._TabPage2.Text = "Vector Lines";
            this._TabPage2.UseVisualStyleBackColor = true;
            this._TabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // labelDir
            // 
            this.labelDir.AutoSize = true;
            this.labelDir.Location = new System.Drawing.Point(320, 18);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(49, 13);
            this.labelDir.TabIndex = 19;
            this.labelDir.Text = "Direction";
            // 
            // cbLanes
            // 
            this.cbLanes.FormattingEnabled = true;
            this.cbLanes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbLanes.Location = new System.Drawing.Point(273, 34);
            this.cbLanes.Name = "cbLanes";
            this.cbLanes.Size = new System.Drawing.Size(44, 21);
            this.cbLanes.TabIndex = 20;
            this.cbLanes.Text = "2";
            // 
            // labelLanes
            // 
            this.labelLanes.Location = new System.Drawing.Point(235, 30);
            this.labelLanes.Name = "labelLanes";
            this.labelLanes.Size = new System.Drawing.Size(41, 27);
            this.labelLanes.TabIndex = 18;
            this.labelLanes.Text = "Traffic Lanes";
            // 
            // cbDir
            // 
            this.cbDir.FormattingEnabled = true;
            this.cbDir.Items.AddRange(new object[] {
            "F",
            "T"});
            this.cbDir.Location = new System.Drawing.Point(323, 34);
            this.cbDir.Name = "cbDir";
            this.cbDir.Size = new System.Drawing.Size(46, 21);
            this.cbDir.TabIndex = 17;
            this.cbDir.Text = "F";
            // 
            // _cmdDetail
            // 
            this._cmdDetail.Location = new System.Drawing.Point(414, 30);
            this._cmdDetail.Name = "_cmdDetail";
            this._cmdDetail.Size = new System.Drawing.Size(43, 25);
            this._cmdDetail.TabIndex = 34;
            this._cmdDetail.Text = "Info";
            this._cmdDetail.UseVisualStyleBackColor = true;
            this._cmdDetail.Click += new System.EventHandler(this.CmdDetail_Click);
            // 
            // labelVectorTexture
            // 
            this.labelVectorTexture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelVectorTexture.Location = new System.Drawing.Point(377, 33);
            this.labelVectorTexture.Name = "labelVectorTexture";
            this.labelVectorTexture.Size = new System.Drawing.Size(31, 21);
            this.labelVectorTexture.TabIndex = 33;
            this.labelVectorTexture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(235, 64);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(192, 13);
            this.Label5.TabIndex = 32;
            this.Label5.Text = "Right click to copy GUID into Clipboard";
            // 
            // _listVector
            // 
            this._listVector.BackColor = System.Drawing.SystemColors.Window;
            this._listVector.Cursor = System.Windows.Forms.Cursors.Default;
            this._listVector.ForeColor = System.Drawing.SystemColors.WindowText;
            this._listVector.Location = new System.Drawing.Point(234, 80);
            this._listVector.Name = "_listVector";
            this._listVector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._listVector.Size = new System.Drawing.Size(223, 147);
            this._listVector.TabIndex = 27;
            this._listVector.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged);
            this._listVector.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List1_MouseDown);
            // 
            // _TabPage3
            // 
            this._TabPage3.Controls.Add(this.boxTexType);
            this._TabPage3.Controls.Add(this.imgTex);
            this._TabPage3.Controls.Add(this.boxTexTexture);
            this._TabPage3.Location = new System.Drawing.Point(4, 22);
            this._TabPage3.Name = "_TabPage3";
            this._TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this._TabPage3.Size = new System.Drawing.Size(480, 241);
            this._TabPage3.TabIndex = 2;
            this._TabPage3.Text = "Textured Lines";
            this._TabPage3.UseVisualStyleBackColor = true;
            this._TabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // boxTexType
            // 
            this.boxTexType.Controls.Add(this.txtV1);
            this.boxTexType.Controls.Add(this.txtTexPri);
            this.boxTexType.Controls.Add(this.cmbComplex);
            this.boxTexType.Controls.Add(this.Label3);
            this.boxTexType.Controls.Add(this.optStanding);
            this.boxTexType.Controls.Add(this._optLying);
            this.boxTexType.Controls.Add(this.lbTexPri);
            this.boxTexType.Controls.Add(this.LbV1);
            this.boxTexType.Location = new System.Drawing.Point(228, 140);
            this.boxTexType.Name = "boxTexType";
            this.boxTexType.Size = new System.Drawing.Size(234, 86);
            this.boxTexType.TabIndex = 99;
            this.boxTexType.TabStop = false;
            this.boxTexType.Text = "Type";
            // 
            // txtV1
            // 
            this.txtV1.AcceptsReturn = true;
            this.txtV1.BackColor = System.Drawing.SystemColors.Window;
            this.txtV1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtV1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtV1.Location = new System.Drawing.Point(124, 22);
            this.txtV1.MaxLength = 0;
            this.txtV1.Name = "txtV1";
            this.txtV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtV1.Size = new System.Drawing.Size(39, 20);
            this.txtV1.TabIndex = 94;
            this.txtV1.Text = "25000";
            this.txtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTexPri
            // 
            this.txtTexPri.AcceptsReturn = true;
            this.txtTexPri.BackColor = System.Drawing.SystemColors.Window;
            this.txtTexPri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTexPri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTexPri.Location = new System.Drawing.Point(190, 21);
            this.txtTexPri.MaxLength = 0;
            this.txtTexPri.Name = "txtTexPri";
            this.txtTexPri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTexPri.Size = new System.Drawing.Size(25, 20);
            this.txtTexPri.TabIndex = 91;
            this.txtTexPri.Text = "4";
            this.txtTexPri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbComplex
            // 
            this.cmbComplex.FormattingEnabled = true;
            this.cmbComplex.Items.AddRange(new object[] {
            "Very Sparse",
            "Sparse",
            "Normal",
            "Dense",
            "Very Dense",
            "Extra Dense"});
            this.cmbComplex.Location = new System.Drawing.Point(124, 52);
            this.cmbComplex.Name = "cmbComplex";
            this.cmbComplex.Size = new System.Drawing.Size(91, 21);
            this.cmbComplex.TabIndex = 107;
            this.cmbComplex.Text = "Normal";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(88, 56);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(39, 13);
            this.Label3.TabIndex = 106;
            this.Label3.Text = "Compl.";
            // 
            // optStanding
            // 
            this.optStanding.AutoSize = true;
            this.optStanding.Location = new System.Drawing.Point(15, 54);
            this.optStanding.Name = "optStanding";
            this.optStanding.Size = new System.Drawing.Size(67, 17);
            this.optStanding.TabIndex = 97;
            this.optStanding.Text = "Standing";
            this.optStanding.UseVisualStyleBackColor = true;
            // 
            // _optLying
            // 
            this._optLying.AutoSize = true;
            this._optLying.Checked = true;
            this._optLying.Location = new System.Drawing.Point(15, 24);
            this._optLying.Name = "_optLying";
            this._optLying.Size = new System.Drawing.Size(50, 17);
            this._optLying.TabIndex = 96;
            this._optLying.TabStop = true;
            this._optLying.Text = "Lying";
            this._optLying.UseVisualStyleBackColor = true;
            this._optLying.CheckedChanged += new System.EventHandler(this.OptLying_CheckedChanged);
            // 
            // lbTexPri
            // 
            this.lbTexPri.AutoSize = true;
            this.lbTexPri.BackColor = System.Drawing.Color.Transparent;
            this.lbTexPri.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTexPri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTexPri.Location = new System.Drawing.Point(171, 27);
            this.lbTexPri.Name = "lbTexPri";
            this.lbTexPri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTexPri.Size = new System.Drawing.Size(22, 13);
            this.lbTexPri.TabIndex = 93;
            this.lbTexPri.Text = "Pri.";
            // 
            // LbV1
            // 
            this.LbV1.AutoSize = true;
            this.LbV1.BackColor = System.Drawing.Color.Transparent;
            this.LbV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbV1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LbV1.Location = new System.Drawing.Point(101, 27);
            this.LbV1.Name = "LbV1";
            this.LbV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbV1.Size = new System.Drawing.Size(24, 13);
            this.LbV1.TabIndex = 95;
            this.LbV1.Text = "Vis.";
            this.LbV1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // imgTex
            // 
            this.imgTex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgTex.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgTex.ErrorImage = null;
            this.imgTex.InitialImage = null;
            this.imgTex.Location = new System.Drawing.Point(18, 22);
            this.imgTex.Name = "imgTex";
            this.imgTex.Size = new System.Drawing.Size(444, 111);
            this.imgTex.TabIndex = 8;
            this.imgTex.TabStop = false;
            // 
            // boxTexTexture
            // 
            this.boxTexTexture.Controls.Add(this._optTile);
            this.boxTexTexture.Controls.Add(this._optStretch);
            this.boxTexTexture.Controls.Add(this._cmdTex);
            this.boxTexTexture.Controls.Add(this.txtTexName);
            this.boxTexTexture.Controls.Add(this.ckNight);
            this.boxTexTexture.Controls.Add(this.optFull);
            this.boxTexTexture.Location = new System.Drawing.Point(18, 139);
            this.boxTexTexture.Name = "boxTexTexture";
            this.boxTexTexture.Size = new System.Drawing.Size(194, 87);
            this.boxTexTexture.TabIndex = 98;
            this.boxTexTexture.TabStop = false;
            this.boxTexTexture.Text = "Texture";
            // 
            // _optTile
            // 
            this._optTile.AutoSize = true;
            this._optTile.Checked = true;
            this._optTile.Location = new System.Drawing.Point(12, 18);
            this._optTile.Name = "_optTile";
            this._optTile.Size = new System.Drawing.Size(42, 17);
            this._optTile.TabIndex = 98;
            this._optTile.TabStop = true;
            this._optTile.Text = "Tile";
            this._optTile.UseVisualStyleBackColor = true;
            this._optTile.CheckedChanged += new System.EventHandler(this.OptTile_CheckedChanged);
            // 
            // _optStretch
            // 
            this._optStretch.AutoSize = true;
            this._optStretch.Location = new System.Drawing.Point(12, 64);
            this._optStretch.Name = "_optStretch";
            this._optStretch.Size = new System.Drawing.Size(59, 17);
            this._optStretch.TabIndex = 97;
            this._optStretch.Text = "Stretch";
            this._optStretch.UseVisualStyleBackColor = true;
            this._optStretch.CheckedChanged += new System.EventHandler(this.OptStretch_CheckedChanged);
            // 
            // _cmdTex
            // 
            this._cmdTex.BackColor = System.Drawing.SystemColors.Control;
            this._cmdTex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._cmdTex.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdTex.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdTex.Location = new System.Drawing.Point(151, 16);
            this._cmdTex.Name = "_cmdTex";
            this._cmdTex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdTex.Size = new System.Drawing.Size(32, 25);
            this._cmdTex.TabIndex = 92;
            this._cmdTex.Text = "...";
            this._cmdTex.UseVisualStyleBackColor = false;
            this._cmdTex.Click += new System.EventHandler(this.CmdTex_Click);
            // 
            // txtTexName
            // 
            this.txtTexName.AcceptsReturn = true;
            this.txtTexName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTexName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTexName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTexName.Location = new System.Drawing.Point(60, 18);
            this.txtTexName.MaxLength = 0;
            this.txtTexName.Name = "txtTexName";
            this.txtTexName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTexName.Size = new System.Drawing.Size(85, 20);
            this.txtTexName.TabIndex = 90;
            this.txtTexName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckNight
            // 
            this.ckNight.BackColor = System.Drawing.Color.Transparent;
            this.ckNight.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckNight.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckNight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckNight.Location = new System.Drawing.Point(125, 54);
            this.ckNight.Name = "ckNight";
            this.ckNight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckNight.Size = new System.Drawing.Size(58, 21);
            this.ckNight.TabIndex = 96;
            this.ckNight.Text = "Night";
            this.ckNight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckNight.UseVisualStyleBackColor = false;
            // 
            // optFull
            // 
            this.optFull.AutoSize = true;
            this.optFull.Location = new System.Drawing.Point(12, 41);
            this.optFull.Name = "optFull";
            this.optFull.Size = new System.Drawing.Size(89, 17);
            this.optFull.TabIndex = 97;
            this.optFull.Text = "Complete Tile";
            this.optFull.UseVisualStyleBackColor = true;
            // 
            // _TabPage4
            // 
            this._TabPage4.Controls.Add(this._cmdExtrusionProperties);
            this._TabPage4.Controls.Add(this.labelProfile);
            this._TabPage4.Controls.Add(this.lbguid);
            this._TabPage4.Controls.Add(this.lbExt1);
            this._TabPage4.Controls.Add(this._listExtrusion);
            this._TabPage4.Controls.Add(this._imgExtrusion);
            this._TabPage4.Location = new System.Drawing.Point(4, 22);
            this._TabPage4.Name = "_TabPage4";
            this._TabPage4.Size = new System.Drawing.Size(480, 241);
            this._TabPage4.TabIndex = 3;
            this._TabPage4.Text = "Extrusion Bridges";
            this._TabPage4.UseVisualStyleBackColor = true;
            this._TabPage4.Click += new System.EventHandler(this.TabPage4_Click);
            // 
            // _cmdExtrusionProperties
            // 
            this._cmdExtrusionProperties.Location = new System.Drawing.Point(235, 29);
            this._cmdExtrusionProperties.Name = "_cmdExtrusionProperties";
            this._cmdExtrusionProperties.Size = new System.Drawing.Size(68, 25);
            this._cmdExtrusionProperties.TabIndex = 96;
            this._cmdExtrusionProperties.Text = "Properties";
            this._cmdExtrusionProperties.UseVisualStyleBackColor = true;
            this._cmdExtrusionProperties.Click += new System.EventHandler(this.CmdExtrusionProperties_Click);
            // 
            // labelProfile
            // 
            this.labelProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProfile.Location = new System.Drawing.Point(235, 73);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(223, 19);
            this.labelProfile.TabIndex = 95;
            this.labelProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbguid
            // 
            this.lbguid.AutoSize = true;
            this.lbguid.Location = new System.Drawing.Point(355, 60);
            this.lbguid.Name = "lbguid";
            this.lbguid.Size = new System.Drawing.Size(107, 13);
            this.lbguid.TabIndex = 35;
            this.lbguid.Text = "Extrusion Profile Guid";
            // 
            // lbExt1
            // 
            this.lbExt1.AutoSize = true;
            this.lbExt1.Location = new System.Drawing.Point(12, 16);
            this.lbExt1.Name = "lbExt1";
            this.lbExt1.Size = new System.Drawing.Size(99, 13);
            this.lbExt1.TabIndex = 35;
            this.lbExt1.Text = "Click to see a detail";
            // 
            // _listExtrusion
            // 
            this._listExtrusion.BackColor = System.Drawing.SystemColors.Window;
            this._listExtrusion.Cursor = System.Windows.Forms.Cursors.Default;
            this._listExtrusion.ForeColor = System.Drawing.SystemColors.WindowText;
            this._listExtrusion.Location = new System.Drawing.Point(235, 95);
            this._listExtrusion.Name = "_listExtrusion";
            this._listExtrusion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._listExtrusion.Size = new System.Drawing.Size(223, 134);
            this._listExtrusion.TabIndex = 34;
            this._listExtrusion.SelectedIndexChanged += new System.EventHandler(this.ListExtrusion_SelectedIndexChanged);
            // 
            // _imgExtrusion
            // 
            this._imgExtrusion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgExtrusion.Cursor = System.Windows.Forms.Cursors.Default;
            this._imgExtrusion.Location = new System.Drawing.Point(15, 29);
            this._imgExtrusion.Name = "_imgExtrusion";
            this._imgExtrusion.Size = new System.Drawing.Size(200, 200);
            this._imgExtrusion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgExtrusion.TabIndex = 8;
            this._imgExtrusion.TabStop = false;
            this._imgExtrusion.Click += new System.EventHandler(this.ImgExtrusion_Click);
            // 
            // _TabPage5
            // 
            this._TabPage5.Controls.Add(this.boxHeading);
            this._TabPage5.Controls.Add(this.cmbComplexity);
            this._TabPage5.Controls.Add(this.labelComplexity);
            this._TabPage5.Controls.Add(this.labelCat);
            this._TabPage5.Controls.Add(this.imgLib);
            this._TabPage5.Controls.Add(this._lstLib);
            this._TabPage5.Controls.Add(this.labelLibID);
            this._TabPage5.Controls.Add(this._cmbLibCat);
            this._TabPage5.Location = new System.Drawing.Point(4, 22);
            this._TabPage5.Name = "_TabPage5";
            this._TabPage5.Padding = new System.Windows.Forms.Padding(3);
            this._TabPage5.Size = new System.Drawing.Size(480, 241);
            this._TabPage5.TabIndex = 4;
            this._TabPage5.Text = "Line of Objects";
            this._TabPage5.UseVisualStyleBackColor = true;
            this._TabPage5.Click += new System.EventHandler(this.TabPage5_Click);
            // 
            // boxHeading
            // 
            this.boxHeading.Controls.Add(this._ckRandom);
            this.boxHeading.Controls.Add(this.txtHeading);
            this.boxHeading.Controls.Add(this._cmdHeading);
            this.boxHeading.Location = new System.Drawing.Point(235, 17);
            this.boxHeading.Name = "boxHeading";
            this.boxHeading.Size = new System.Drawing.Size(224, 51);
            this.boxHeading.TabIndex = 106;
            this.boxHeading.TabStop = false;
            this.boxHeading.Text = "Heading";
            // 
            // _ckRandom
            // 
            this._ckRandom.AutoSize = true;
            this._ckRandom.Location = new System.Drawing.Point(16, 21);
            this._ckRandom.Name = "_ckRandom";
            this._ckRandom.Size = new System.Drawing.Size(66, 17);
            this._ckRandom.TabIndex = 2;
            this._ckRandom.Text = "Random";
            this._ckRandom.UseVisualStyleBackColor = true;
            this._ckRandom.CheckedChanged += new System.EventHandler(this.CkRandom_CheckedChanged);
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(102, 18);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(51, 20);
            this.txtHeading.TabIndex = 1;
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdHeading
            // 
            this._cmdHeading.Location = new System.Drawing.Point(166, 16);
            this._cmdHeading.Name = "_cmdHeading";
            this._cmdHeading.Size = new System.Drawing.Size(40, 23);
            this._cmdHeading.TabIndex = 0;
            this._cmdHeading.Text = "Set";
            this._cmdHeading.UseVisualStyleBackColor = true;
            this._cmdHeading.Click += new System.EventHandler(this.CmdHeading_Click);
            // 
            // cmbComplexity
            // 
            this.cmbComplexity.FormattingEnabled = true;
            this.cmbComplexity.Items.AddRange(new object[] {
            "Very Sparse",
            "Sparse",
            "Normal",
            "Dense",
            "Very Dense",
            "Extra Dense"});
            this.cmbComplexity.Location = new System.Drawing.Point(235, 91);
            this.cmbComplexity.Name = "cmbComplexity";
            this.cmbComplexity.Size = new System.Drawing.Size(75, 21);
            this.cmbComplexity.TabIndex = 105;
            this.cmbComplexity.Text = "Normal";
            // 
            // labelComplexity
            // 
            this.labelComplexity.AutoSize = true;
            this.labelComplexity.BackColor = System.Drawing.Color.Transparent;
            this.labelComplexity.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelComplexity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelComplexity.Location = new System.Drawing.Point(232, 75);
            this.labelComplexity.Name = "labelComplexity";
            this.labelComplexity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelComplexity.Size = new System.Drawing.Size(57, 13);
            this.labelComplexity.TabIndex = 103;
            this.labelComplexity.Text = "Complexity";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.BackColor = System.Drawing.Color.Transparent;
            this.labelCat.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelCat.Location = new System.Drawing.Point(320, 75);
            this.labelCat.Name = "labelCat";
            this.labelCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelCat.Size = new System.Drawing.Size(83, 13);
            this.labelCat.TabIndex = 103;
            this.labelCat.Text = "Object Category";
            // 
            // imgLib
            // 
            this.imgLib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgLib.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLib.Location = new System.Drawing.Point(15, 29);
            this.imgLib.Name = "imgLib";
            this.imgLib.Size = new System.Drawing.Size(200, 200);
            this.imgLib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLib.TabIndex = 9;
            this.imgLib.TabStop = false;
            // 
            // _lstLib
            // 
            this._lstLib.BackColor = System.Drawing.SystemColors.Window;
            this._lstLib.Cursor = System.Windows.Forms.Cursors.Default;
            this._lstLib.ForeColor = System.Drawing.SystemColors.WindowText;
            this._lstLib.Location = new System.Drawing.Point(235, 134);
            this._lstLib.Name = "_lstLib";
            this._lstLib.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lstLib.Size = new System.Drawing.Size(224, 95);
            this._lstLib.TabIndex = 100;
            this._lstLib.SelectedIndexChanged += new System.EventHandler(this.LstLib_SelectedIndexChanged);
            // 
            // labelLibID
            // 
            this.labelLibID.BackColor = System.Drawing.Color.Transparent;
            this.labelLibID.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelLibID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelLibID.Location = new System.Drawing.Point(235, 115);
            this.labelLibID.Name = "labelLibID";
            this.labelLibID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelLibID.Size = new System.Drawing.Size(227, 16);
            this.labelLibID.TabIndex = 104;
            this.labelLibID.Text = "GUID";
            this.labelLibID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cmbLibCat
            // 
            this._cmbLibCat.BackColor = System.Drawing.SystemColors.Window;
            this._cmbLibCat.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmbLibCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbLibCat.ForeColor = System.Drawing.SystemColors.WindowText;
            this._cmbLibCat.Location = new System.Drawing.Point(323, 91);
            this._cmbLibCat.Name = "_cmbLibCat";
            this._cmbLibCat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmbLibCat.Size = new System.Drawing.Size(136, 21);
            this._cmbLibCat.TabIndex = 102;
            this._cmbLibCat.SelectedIndexChanged += new System.EventHandler(this.CmbLibCat_SelectedIndexChanged);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(348, 295);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(66, 25);
            this._cmdCancel.TabIndex = 26;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(430, 295);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(66, 25);
            this._cmdOK.TabIndex = 25;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdSample
            // 
            this._cmdSample.Location = new System.Drawing.Point(125, 295);
            this._cmdSample.Name = "_cmdSample";
            this._cmdSample.Size = new System.Drawing.Size(62, 25);
            this._cmdSample.TabIndex = 38;
            this._cmdSample.Text = "Sample";
            this._cmdSample.UseVisualStyleBackColor = true;
            this._cmdSample.Click += new System.EventHandler(this.CmdSample_Click);
            // 
            // _cmdSmooth
            // 
            this._cmdSmooth.Location = new System.Drawing.Point(46, 295);
            this._cmdSmooth.Name = "_cmdSmooth";
            this._cmdSmooth.Size = new System.Drawing.Size(62, 25);
            this._cmdSmooth.TabIndex = 37;
            this._cmdSmooth.Text = "Smooth";
            this._cmdSmooth.UseVisualStyleBackColor = true;
            this._cmdSmooth.Click += new System.EventHandler(this.CmdSmooth_Click);
            // 
            // FrmLinesP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 334);
            this.Controls.Add(this._cmdSample);
            this.Controls.Add(this._cmdSmooth);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLinesP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Line Properties";
            this.Load += new System.EventHandler(this.FrmLinesP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVector)).EndInit();
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.boxType.ResumeLayout(false);
            this.boxType.PerformLayout();
            this.boxAltitude.ResumeLayout(false);
            this.boxAltitude.PerformLayout();
            this.boxProgressive.ResumeLayout(false);
            this.boxProgressive.PerformLayout();
            this.boxWidth.ResumeLayout(false);
            this.boxWidth.PerformLayout();
            this._TabPage2.ResumeLayout(false);
            this._TabPage2.PerformLayout();
            this._TabPage3.ResumeLayout(false);
            this.boxTexType.ResumeLayout(false);
            this.boxTexType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgTex)).EndInit();
            this.boxTexTexture.ResumeLayout(false);
            this.boxTexTexture.PerformLayout();
            this._TabPage4.ResumeLayout(false);
            this._TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgExtrusion)).EndInit();
            this._TabPage5.ResumeLayout(false);
            this._TabPage5.PerformLayout();
            this.boxHeading.ResumeLayout(false);
            this.boxHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLib)).EndInit();
            this.ResumeLayout(false);

        }

        public PictureBox imgVector;
        internal TabControl TabControl1;
        internal TabPage TabPage1;
        private TabPage _TabPage2;

        internal TabPage TabPage2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabPage2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabPage2 != null)
                {
                    _TabPage2.Click -= TabPage2_Click;
                }

                _TabPage2 = value;
                if (_TabPage2 != null)
                {
                    _TabPage2.Click += TabPage2_Click;
                }
            }
        }

        private TabPage _TabPage3;

        internal TabPage TabPage3
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabPage3;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabPage3 != null)
                {
                    _TabPage3.Click -= TabPage3_Click;
                }

                _TabPage3 = value;
                if (_TabPage3 != null)
                {
                    _TabPage3.Click += TabPage3_Click;
                }
            }
        }

        private TabPage _TabPage4;

        internal TabPage TabPage4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabPage4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabPage4 != null)
                {
                    _TabPage4.Click -= TabPage4_Click;
                }

                _TabPage4 = value;
                if (_TabPage4 != null)
                {
                    _TabPage4.Click += TabPage4_Click;
                }
            }
        }

        private Button _cmdDetail;

        internal Button cmdDetail
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDetail;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDetail != null)
                {
                    _cmdDetail.Click -= CmdDetail_Click;
                }

                _cmdDetail = value;
                if (_cmdDetail != null)
                {
                    _cmdDetail.Click += CmdDetail_Click;
                }
            }
        }

        internal Label labelVectorTexture;
        internal Label Label5;
        internal ComboBox cbLanes;
        internal Label labelDir;
        internal Label labelLanes;
        internal ComboBox cbDir;
        private ListBox _listVector;

        public ListBox listVector
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _listVector;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_listVector != null)
                {
                    _listVector.MouseDown -= List1_MouseDown;
                    _listVector.SelectedIndexChanged -= List1_SelectedIndexChanged;
                }

                _listVector = value;
                if (_listVector != null)
                {
                    _listVector.MouseDown += List1_MouseDown;
                    _listVector.SelectedIndexChanged += List1_SelectedIndexChanged;
                }
            }
        }

        private Button _cmdCancel;

        internal Button cmdCancel
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

        internal Button cmdOK
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

        private Button _cmdSample;

        internal Button cmdSample
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSample;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSample != null)
                {
                    _cmdSample.Click -= CmdSample_Click;
                }

                _cmdSample = value;
                if (_cmdSample != null)
                {
                    _cmdSample.Click += CmdSample_Click;
                }
            }
        }

        private Button _cmdSmooth;

        internal Button cmdSmooth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSmooth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSmooth != null)
                {
                    _cmdSmooth.Click -= CmdSmooth_Click;
                }

                _cmdSmooth = value;
                if (_cmdSmooth != null)
                {
                    _cmdSmooth.Click += CmdSmooth_Click;
                }
            }
        }

        internal TextBox txtName;
        internal Label labelName;
        private Button _cmdWinding;

        internal Button cmdWinding
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWinding;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWinding != null)
                {
                    _cmdWinding.Click -= CmdWinding_Click;
                }

                _cmdWinding = value;
                if (_cmdWinding != null)
                {
                    _cmdWinding.Click += CmdWinding_Click;
                }
            }
        }

        internal GroupBox boxProgressive;
        private Button _cmdReverse;

        public Button cmdReverse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdReverse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdReverse != null)
                {
                    _cmdReverse.Click -= CmdReverse_Click;
                }

                _cmdReverse = value;
                if (_cmdReverse != null)
                {
                    _cmdReverse.Click += CmdReverse_Click;
                }
            }
        }

        private Button _cmdWidth12;

        public Button cmdWidth12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWidth12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWidth12 != null)
                {
                    _cmdWidth12.Click -= CmdWidth12_Click;
                }

                _cmdWidth12 = value;
                if (_cmdWidth12 != null)
                {
                    _cmdWidth12.Click += CmdWidth12_Click;
                }
            }
        }

        public TextBox txtWidth1;
        public TextBox txtWidth2;
        public Label Label1;
        public Label Label2;
        internal GroupBox boxWidth;
        public TextBox txtWidth;
        private Button _cmdWidth;

        public Button cmdWidth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWidth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWidth != null)
                {
                    _cmdWidth.Click -= CmdWidth_Click;
                }

                _cmdWidth = value;
                if (_cmdWidth != null)
                {
                    _cmdWidth.Click += CmdWidth_Click;
                }
            }
        }

        internal GroupBox boxAltitude;
        public TextBox txtAlt;
        private Button _cmdAlt;

        public Button cmdAlt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAlt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAlt != null)
                {
                    _cmdAlt.Click -= CmdAlt_Click;
                }

                _cmdAlt = value;
                if (_cmdAlt != null)
                {
                    _cmdAlt.Click += CmdAlt_Click;
                }
            }
        }

        internal GroupBox boxType;
        private Button _cmdType;

        internal Button cmdType
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdType;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdType != null)
                {
                    _cmdType.Click -= CmdType_Click;
                }

                _cmdType = value;
                if (_cmdType != null)
                {
                    _cmdType.Click += CmdType_Click;
                }
            }
        }

        private RadioButton _optExtrusion;

        internal RadioButton optExtrusion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optExtrusion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optExtrusion != null)
                {
                    _optExtrusion.CheckedChanged -= OptExtrusion_CheckedChanged;
                }

                _optExtrusion = value;
                if (_optExtrusion != null)
                {
                    _optExtrusion.CheckedChanged += OptExtrusion_CheckedChanged;
                }
            }
        }

        private RadioButton _optTexture;

        internal RadioButton optTexture
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTexture;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTexture != null)
                {
                    _optTexture.CheckedChanged -= OptTexture_CheckedChanged;
                }

                _optTexture = value;
                if (_optTexture != null)
                {
                    _optTexture.CheckedChanged += OptTexture_CheckedChanged;
                }
            }
        }

        private RadioButton _optVector;

        internal RadioButton optVector
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optVector;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optVector != null)
                {
                    _optVector.CheckedChanged -= OptVector_CheckedChanged;
                }

                _optVector = value;
                if (_optVector != null)
                {
                    _optVector.CheckedChanged += OptVector_CheckedChanged;
                }
            }
        }

        internal Label labelReverse;
        private PictureBox _imgExtrusion;

        public PictureBox imgExtrusion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgExtrusion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgExtrusion != null)
                {
                    _imgExtrusion.Click -= ImgExtrusion_Click;
                }

                _imgExtrusion = value;
                if (_imgExtrusion != null)
                {
                    _imgExtrusion.Click += ImgExtrusion_Click;
                }
            }
        }

        public PictureBox imgTex;
        public Label lbTexPri;
        public Label LbV1;
        public TextBox txtTexName;
        public TextBox txtTexPri;
        private Button _cmdTex;

        public Button cmdTex
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTex;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTex != null)
                {
                    _cmdTex.Click -= CmdTex_Click;
                }

                _cmdTex = value;
                if (_cmdTex != null)
                {
                    _cmdTex.Click += CmdTex_Click;
                }
            }
        }

        public TextBox txtV1;
        public CheckBox ckNight;
        internal Label lbExt1;
        private ListBox _listExtrusion;

        public ListBox listExtrusion
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _listExtrusion;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_listExtrusion != null)
                {
                    _listExtrusion.SelectedIndexChanged -= ListExtrusion_SelectedIndexChanged;
                }

                _listExtrusion = value;
                if (_listExtrusion != null)
                {
                    _listExtrusion.SelectedIndexChanged += ListExtrusion_SelectedIndexChanged;
                }
            }
        }

        internal Label lbguid;
        internal Label labelProfile;
        private Button _cmdExtrusionProperties;

        internal Button cmdExtrusionProperties
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdExtrusionProperties;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdExtrusionProperties != null)
                {
                    _cmdExtrusionProperties.Click -= CmdExtrusionProperties_Click;
                }

                _cmdExtrusionProperties = value;
                if (_cmdExtrusionProperties != null)
                {
                    _cmdExtrusionProperties.Click += CmdExtrusionProperties_Click;
                }
            }
        }

        private RadioButton _optObjects;

        internal RadioButton optObjects
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optObjects;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optObjects != null)
                {
                    _optObjects.CheckedChanged -= OptObjects_CheckedChanged;
                }

                _optObjects = value;
                if (_optObjects != null)
                {
                    _optObjects.CheckedChanged += OptObjects_CheckedChanged;
                }
            }
        }

        private TabPage _TabPage5;

        internal TabPage TabPage5
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _TabPage5;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_TabPage5 != null)
                {
                    _TabPage5.Click -= TabPage5_Click;
                }

                _TabPage5 = value;
                if (_TabPage5 != null)
                {
                    _TabPage5.Click += TabPage5_Click;
                }
            }
        }

        public PictureBox imgLib;
        public Label labelCat;
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

        public Label labelLibID;
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

        internal ComboBox cmbComplexity;
        internal GroupBox boxHeading;
        internal TextBox txtHeading;
        private Button _cmdHeading;

        internal Button cmdHeading
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdHeading;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdHeading != null)
                {
                    _cmdHeading.Click -= CmdHeading_Click;
                }

                _cmdHeading = value;
                if (_cmdHeading != null)
                {
                    _cmdHeading.Click += CmdHeading_Click;
                }
            }
        }

        public Label labelComplexity;
        internal CheckBox ckThisColor;
        private Button _cmdColor;

        internal Button cmdColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdColor != null)
                {
                    _cmdColor.Click -= CmdColor_Click;
                }

                _cmdColor = value;
                if (_cmdColor != null)
                {
                    _cmdColor.Click += CmdColor_Click;
                }
            }
        }

        private CheckBox _ckRandom;

        internal CheckBox ckRandom
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckRandom;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckRandom != null)
                {
                    _ckRandom.CheckedChanged -= CkRandom_CheckedChanged;
                }

                _ckRandom = value;
                if (_ckRandom != null)
                {
                    _ckRandom.CheckedChanged += CkRandom_CheckedChanged;
                }
            }
        }

        internal GroupBox boxTexTexture;
        private RadioButton _optTile;

        internal RadioButton optTile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optTile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optTile != null)
                {
                    _optTile.CheckedChanged -= OptTile_CheckedChanged;
                }

                _optTile = value;
                if (_optTile != null)
                {
                    _optTile.CheckedChanged += OptTile_CheckedChanged;
                }
            }
        }

        private RadioButton _optStretch;

        internal RadioButton optStretch
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optStretch;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optStretch != null)
                {
                    _optStretch.CheckedChanged -= OptStretch_CheckedChanged;
                }

                _optStretch = value;
                if (_optStretch != null)
                {
                    _optStretch.CheckedChanged += OptStretch_CheckedChanged;
                }
            }
        }

        internal GroupBox boxTexType;
        private RadioButton _optLying;

        internal RadioButton optLying
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optLying;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optLying != null)
                {
                    _optLying.CheckedChanged -= OptLying_CheckedChanged;
                }

                _optLying = value;
                if (_optLying != null)
                {
                    _optLying.CheckedChanged += OptLying_CheckedChanged;
                }
            }
        }

        internal RadioButton optStanding;
        internal ComboBox cmbComplex;
        public Label Label3;
        internal RadioButton optFull;
    }
}