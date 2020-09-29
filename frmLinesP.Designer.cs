using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLinesP));
            imgVector = new PictureBox();
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            ckThisColor = new CheckBox();
            _cmdColor = new Button();
            _cmdColor.Click += new EventHandler(CmdColor_Click);
            _cmdWinding = new Button();
            _cmdWinding.Click += new EventHandler(CmdWinding_Click);
            labelReverse = new Label();
            boxType = new GroupBox();
            _optObjects = new RadioButton();
            _optObjects.CheckedChanged += new EventHandler(OptObjects_CheckedChanged);
            _cmdType = new Button();
            _cmdType.Click += new EventHandler(CmdType_Click);
            _optExtrusion = new RadioButton();
            _optExtrusion.CheckedChanged += new EventHandler(OptExtrusion_CheckedChanged);
            _optTexture = new RadioButton();
            _optTexture.CheckedChanged += new EventHandler(OptTexture_CheckedChanged);
            _optVector = new RadioButton();
            _optVector.CheckedChanged += new EventHandler(OptVector_CheckedChanged);
            boxAltitude = new GroupBox();
            txtAlt = new TextBox();
            _cmdAlt = new Button();
            _cmdAlt.Click += new EventHandler(CmdAlt_Click);
            boxProgressive = new GroupBox();
            _cmdReverse = new Button();
            _cmdReverse.Click += new EventHandler(CmdReverse_Click);
            _cmdWidth12 = new Button();
            _cmdWidth12.Click += new EventHandler(CmdWidth12_Click);
            txtWidth1 = new TextBox();
            txtWidth2 = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            boxWidth = new GroupBox();
            txtWidth = new TextBox();
            _cmdWidth = new Button();
            _cmdWidth.Click += new EventHandler(CmdWidth_Click);
            txtName = new TextBox();
            labelName = new Label();
            _TabPage2 = new TabPage();
            _TabPage2.Click += new EventHandler(TabPage2_Click);
            labelDir = new Label();
            cbLanes = new ComboBox();
            labelLanes = new Label();
            cbDir = new ComboBox();
            _cmdDetail = new Button();
            _cmdDetail.Click += new EventHandler(CmdDetail_Click);
            labelVectorTexture = new Label();
            Label5 = new Label();
            _listVector = new ListBox();
            _listVector.MouseDown += new MouseEventHandler(List1_MouseDown);
            _listVector.SelectedIndexChanged += new EventHandler(List1_SelectedIndexChanged);
            _TabPage3 = new TabPage();
            _TabPage3.Click += new EventHandler(TabPage3_Click);
            boxTexType = new GroupBox();
            txtV1 = new TextBox();
            txtTexPri = new TextBox();
            cmbComplex = new ComboBox();
            Label3 = new Label();
            optStanding = new RadioButton();
            _optLying = new RadioButton();
            _optLying.CheckedChanged += new EventHandler(OptLying_CheckedChanged);
            lbTexPri = new Label();
            LbV1 = new Label();
            imgTex = new PictureBox();
            boxTexTexture = new GroupBox();
            _optTile = new RadioButton();
            _optTile.CheckedChanged += new EventHandler(OptTile_CheckedChanged);
            _optStretch = new RadioButton();
            _optStretch.CheckedChanged += new EventHandler(OptStretch_CheckedChanged);
            _cmdTex = new Button();
            _cmdTex.Click += new EventHandler(CmdTex_Click);
            txtTexName = new TextBox();
            ckNight = new CheckBox();
            optFull = new RadioButton();
            _TabPage4 = new TabPage();
            _TabPage4.Click += new EventHandler(TabPage4_Click);
            _cmdExtrusionProperties = new Button();
            _cmdExtrusionProperties.Click += new EventHandler(CmdExtrusionProperties_Click);
            labelProfile = new Label();
            lbguid = new Label();
            lbExt1 = new Label();
            _listExtrusion = new ListBox();
            _listExtrusion.SelectedIndexChanged += new EventHandler(ListExtrusion_SelectedIndexChanged);
            _imgExtrusion = new PictureBox();
            _imgExtrusion.Click += new EventHandler(ImgExtrusion_Click);
            _TabPage5 = new TabPage();
            _TabPage5.Click += new EventHandler(TabPage5_Click);
            boxHeading = new GroupBox();
            _ckRandom = new CheckBox();
            _ckRandom.CheckedChanged += new EventHandler(CkRandom_CheckedChanged);
            txtHeading = new TextBox();
            _cmdHeading = new Button();
            _cmdHeading.Click += new EventHandler(CmdHeading_Click);
            cmbComplexity = new ComboBox();
            labelComplexity = new Label();
            labelCat = new Label();
            imgLib = new PictureBox();
            _lstLib = new ListBox();
            _lstLib.SelectedIndexChanged += new EventHandler(LstLib_SelectedIndexChanged);
            labelLibID = new Label();
            _cmbLibCat = new ComboBox();
            _cmbLibCat.SelectedIndexChanged += new EventHandler(CmbLibCat_SelectedIndexChanged);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdSample = new Button();
            _cmdSample.Click += new EventHandler(CmdSample_Click);
            _cmdSmooth = new Button();
            _cmdSmooth.Click += new EventHandler(CmdSmooth_Click);
            ((System.ComponentModel.ISupportInitialize)imgVector).BeginInit();
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            boxType.SuspendLayout();
            boxAltitude.SuspendLayout();
            boxProgressive.SuspendLayout();
            boxWidth.SuspendLayout();
            _TabPage2.SuspendLayout();
            _TabPage3.SuspendLayout();
            boxTexType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgTex).BeginInit();
            boxTexTexture.SuspendLayout();
            _TabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_imgExtrusion).BeginInit();
            _TabPage5.SuspendLayout();
            boxHeading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLib).BeginInit();
            SuspendLayout();
            // 
            // imgVector
            // 
            imgVector.BorderStyle = BorderStyle.FixedSingle;
            imgVector.Cursor = Cursors.Default;
            imgVector.Location = new Point(15, 29);
            imgVector.Name = "imgVector";
            imgVector.Size = new Size(200, 200);
            imgVector.SizeMode = PictureBoxSizeMode.StretchImage;
            imgVector.TabIndex = 7;
            imgVector.TabStop = false;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(_TabPage2);
            TabControl1.Controls.Add(_TabPage3);
            TabControl1.Controls.Add(_TabPage4);
            TabControl1.Controls.Add(_TabPage5);
            TabControl1.Location = new Point(12, 12);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(488, 267);
            TabControl1.TabIndex = 25;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(ckThisColor);
            TabPage1.Controls.Add(_cmdColor);
            TabPage1.Controls.Add(_cmdWinding);
            TabPage1.Controls.Add(labelReverse);
            TabPage1.Controls.Add(boxType);
            TabPage1.Controls.Add(boxAltitude);
            TabPage1.Controls.Add(boxProgressive);
            TabPage1.Controls.Add(boxWidth);
            TabPage1.Controls.Add(txtName);
            TabPage1.Controls.Add(labelName);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(480, 241);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "General";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // ckThisColor
            // 
            ckThisColor.AllowDrop = true;
            ckThisColor.BackColor = Color.DarkOliveGreen;
            ckThisColor.CheckAlign = ContentAlignment.MiddleRight;
            ckThisColor.Location = new Point(344, 16);
            ckThisColor.Name = "ckThisColor";
            ckThisColor.Size = new Size(118, 32);
            ckThisColor.TabIndex = 40;
            ckThisColor.Text = "Also use this Color if Vector Line?";
            ckThisColor.UseVisualStyleBackColor = false;
            // 
            // cmdColor
            // 
            _cmdColor.Location = new Point(298, 19);
            _cmdColor.Name = "_cmdColor";
            _cmdColor.Size = new Size(40, 25);
            _cmdColor.TabIndex = 39;
            _cmdColor.Text = "Color";
            _cmdColor.UseVisualStyleBackColor = true;
            // 
            // cmdWinding
            // 
            _cmdWinding.Location = new Point(134, 83);
            _cmdWinding.Name = "_cmdWinding";
            _cmdWinding.Size = new Size(63, 25);
            _cmdWinding.TabIndex = 40;
            _cmdWinding.Text = "Reverse";
            _cmdWinding.UseVisualStyleBackColor = true;
            // 
            // labelReverse
            // 
            labelReverse.Location = new Point(14, 63);
            labelReverse.Name = "labelReverse";
            labelReverse.Size = new Size(114, 57);
            labelReverse.TabIndex = 66;
            labelReverse.Text = "On a shoreline with waves, Reverse will place the waves on the other side.";
            // 
            // boxType
            // 
            boxType.Controls.Add(_optObjects);
            boxType.Controls.Add(_cmdType);
            boxType.Controls.Add(_optExtrusion);
            boxType.Controls.Add(_optTexture);
            boxType.Controls.Add(_optVector);
            boxType.Location = new Point(15, 123);
            boxType.Name = "boxType";
            boxType.Size = new Size(182, 97);
            boxType.TabIndex = 65;
            boxType.TabStop = false;
            boxType.Text = "Line type";
            // 
            // optObjects
            // 
            _optObjects.Location = new Point(109, 9);
            _optObjects.Name = "_optObjects";
            _optObjects.Size = new Size(67, 37);
            _optObjects.TabIndex = 1;
            _optObjects.Text = "Line of Objects";
            _optObjects.UseVisualStyleBackColor = true;
            // 
            // cmdType
            // 
            _cmdType.Location = new Point(135, 59);
            _cmdType.Name = "_cmdType";
            _cmdType.Size = new Size(34, 24);
            _cmdType.TabIndex = 2;
            _cmdType.Text = ">>>";
            _cmdType.UseVisualStyleBackColor = true;
            // 
            // optExtrusion
            // 
            _optExtrusion.AutoSize = true;
            _optExtrusion.Location = new Point(13, 42);
            _optExtrusion.Name = "_optExtrusion";
            _optExtrusion.Size = new Size(101, 17);
            _optExtrusion.TabIndex = 1;
            _optExtrusion.Text = "Extrusion Bridge";
            _optExtrusion.UseVisualStyleBackColor = true;
            // 
            // optTexture
            // 
            _optTexture.AutoSize = true;
            _optTexture.Location = new Point(13, 63);
            _optTexture.Name = "_optTexture";
            _optTexture.Size = new Size(90, 17);
            _optTexture.TabIndex = 1;
            _optTexture.Text = "Textured Line";
            _optTexture.UseVisualStyleBackColor = true;
            // 
            // optVector
            // 
            _optVector.AutoSize = true;
            _optVector.Checked = true;
            _optVector.Location = new Point(13, 19);
            _optVector.Name = "_optVector";
            _optVector.Size = new Size(79, 17);
            _optVector.TabIndex = 0;
            _optVector.TabStop = true;
            _optVector.Text = "Vector Line";
            _optVector.UseVisualStyleBackColor = true;
            // 
            // boxAltitude
            // 
            boxAltitude.Controls.Add(txtAlt);
            boxAltitude.Controls.Add(_cmdAlt);
            boxAltitude.Location = new Point(344, 152);
            boxAltitude.Name = "boxAltitude";
            boxAltitude.Size = new Size(118, 68);
            boxAltitude.TabIndex = 58;
            boxAltitude.TabStop = false;
            boxAltitude.Text = "Altitude";
            // 
            // txtAlt
            // 
            txtAlt.BackColor = SystemColors.Window;
            txtAlt.Cursor = Cursors.IBeam;
            txtAlt.ForeColor = SystemColors.WindowText;
            txtAlt.Location = new Point(12, 26);
            txtAlt.MaxLength = 0;
            txtAlt.Name = "txtAlt";
            txtAlt.RightToLeft = RightToLeft.No;
            txtAlt.Size = new Size(50, 20);
            txtAlt.TabIndex = 29;
            txtAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdAlt
            // 
            _cmdAlt.BackColor = SystemColors.Control;
            _cmdAlt.Cursor = Cursors.Default;
            _cmdAlt.ForeColor = SystemColors.ControlText;
            _cmdAlt.Location = new Point(68, 23);
            _cmdAlt.Name = "_cmdAlt";
            _cmdAlt.RightToLeft = RightToLeft.No;
            _cmdAlt.Size = new Size(35, 25);
            _cmdAlt.TabIndex = 28;
            _cmdAlt.Text = "Set";
            _cmdAlt.UseVisualStyleBackColor = false;
            // 
            // boxProgressive
            // 
            boxProgressive.Controls.Add(_cmdReverse);
            boxProgressive.Controls.Add(_cmdWidth12);
            boxProgressive.Controls.Add(txtWidth1);
            boxProgressive.Controls.Add(txtWidth2);
            boxProgressive.Controls.Add(Label1);
            boxProgressive.Controls.Add(Label2);
            boxProgressive.Location = new Point(212, 63);
            boxProgressive.Name = "boxProgressive";
            boxProgressive.Size = new Size(250, 77);
            boxProgressive.TabIndex = 38;
            boxProgressive.TabStop = false;
            boxProgressive.Text = "Progressive width";
            // 
            // cmdReverse
            // 
            _cmdReverse.BackColor = SystemColors.Control;
            _cmdReverse.Cursor = Cursors.Default;
            _cmdReverse.ForeColor = SystemColors.ControlText;
            _cmdReverse.Location = new Point(138, 40);
            _cmdReverse.Name = "_cmdReverse";
            _cmdReverse.RightToLeft = RightToLeft.No;
            _cmdReverse.Size = new Size(50, 25);
            _cmdReverse.TabIndex = 42;
            _cmdReverse.Text = "Switch";
            _cmdReverse.UseVisualStyleBackColor = false;
            // 
            // cmdWidth12
            // 
            _cmdWidth12.BackColor = SystemColors.Control;
            _cmdWidth12.Cursor = Cursors.Default;
            _cmdWidth12.ForeColor = SystemColors.ControlText;
            _cmdWidth12.Location = new Point(200, 40);
            _cmdWidth12.Name = "_cmdWidth12";
            _cmdWidth12.RightToLeft = RightToLeft.No;
            _cmdWidth12.Size = new Size(35, 25);
            _cmdWidth12.TabIndex = 39;
            _cmdWidth12.Text = "Set";
            _cmdWidth12.UseVisualStyleBackColor = false;
            // 
            // txtWidth1
            // 
            txtWidth1.AcceptsReturn = true;
            txtWidth1.BackColor = SystemColors.Window;
            txtWidth1.Cursor = Cursors.IBeam;
            txtWidth1.ForeColor = SystemColors.WindowText;
            txtWidth1.Location = new Point(10, 43);
            txtWidth1.MaxLength = 0;
            txtWidth1.Name = "txtWidth1";
            txtWidth1.RightToLeft = RightToLeft.No;
            txtWidth1.Size = new Size(53, 20);
            txtWidth1.TabIndex = 38;
            txtWidth1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWidth2
            // 
            txtWidth2.AcceptsReturn = true;
            txtWidth2.BackColor = SystemColors.Window;
            txtWidth2.Cursor = Cursors.IBeam;
            txtWidth2.ForeColor = SystemColors.WindowText;
            txtWidth2.Location = new Point(73, 43);
            txtWidth2.MaxLength = 0;
            txtWidth2.Name = "txtWidth2";
            txtWidth2.RightToLeft = RightToLeft.No;
            txtWidth2.Size = new Size(53, 20);
            txtWidth2.TabIndex = 37;
            txtWidth2.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(10, 27);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(29, 13);
            Label1.TabIndex = 41;
            Label1.Text = "Start";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = Color.Transparent;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(70, 27);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(26, 13);
            Label2.TabIndex = 40;
            Label2.Text = "End";
            // 
            // boxWidth
            // 
            boxWidth.Controls.Add(txtWidth);
            boxWidth.Controls.Add(_cmdWidth);
            boxWidth.Location = new Point(212, 152);
            boxWidth.Name = "boxWidth";
            boxWidth.Size = new Size(118, 68);
            boxWidth.TabIndex = 37;
            boxWidth.TabStop = false;
            boxWidth.Text = "Width";
            // 
            // txtWidth
            // 
            txtWidth.AcceptsReturn = true;
            txtWidth.BackColor = SystemColors.Window;
            txtWidth.Cursor = Cursors.IBeam;
            txtWidth.ForeColor = SystemColors.WindowText;
            txtWidth.Location = new Point(9, 29);
            txtWidth.MaxLength = 0;
            txtWidth.Name = "txtWidth";
            txtWidth.RightToLeft = RightToLeft.No;
            txtWidth.Size = new Size(53, 20);
            txtWidth.TabIndex = 29;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdWidth
            // 
            _cmdWidth.BackColor = SystemColors.Control;
            _cmdWidth.Cursor = Cursors.Default;
            _cmdWidth.ForeColor = SystemColors.ControlText;
            _cmdWidth.Location = new Point(68, 26);
            _cmdWidth.Name = "_cmdWidth";
            _cmdWidth.RightToLeft = RightToLeft.No;
            _cmdWidth.Size = new Size(35, 25);
            _cmdWidth.TabIndex = 28;
            _cmdWidth.Text = "Set";
            _cmdWidth.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 22);
            txtName.Name = "txtName";
            txtName.Size = new Size(201, 20);
            txtName.TabIndex = 32;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(21, 25);
            labelName.Name = "labelName";
            labelName.Size = new Size(35, 13);
            labelName.TabIndex = 33;
            labelName.Text = "Name";
            // 
            // TabPage2
            // 
            _TabPage2.Controls.Add(labelDir);
            _TabPage2.Controls.Add(cbLanes);
            _TabPage2.Controls.Add(labelLanes);
            _TabPage2.Controls.Add(cbDir);
            _TabPage2.Controls.Add(_cmdDetail);
            _TabPage2.Controls.Add(labelVectorTexture);
            _TabPage2.Controls.Add(Label5);
            _TabPage2.Controls.Add(_listVector);
            _TabPage2.Controls.Add(imgVector);
            _TabPage2.Location = new Point(4, 22);
            _TabPage2.Name = "_TabPage2";
            _TabPage2.Padding = new Padding(3);
            _TabPage2.Size = new Size(480, 241);
            _TabPage2.TabIndex = 1;
            _TabPage2.Text = "Vector Lines";
            _TabPage2.UseVisualStyleBackColor = true;
            // 
            // labelDir
            // 
            labelDir.AutoSize = true;
            labelDir.Location = new Point(320, 18);
            labelDir.Name = "labelDir";
            labelDir.Size = new Size(49, 13);
            labelDir.TabIndex = 19;
            labelDir.Text = "Direction";
            // 
            // cbLanes
            // 
            cbLanes.FormattingEnabled = true;
            cbLanes.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cbLanes.Location = new Point(273, 34);
            cbLanes.Name = "cbLanes";
            cbLanes.Size = new Size(44, 21);
            cbLanes.TabIndex = 20;
            cbLanes.Text = "2";
            // 
            // labelLanes
            // 
            labelLanes.Location = new Point(235, 30);
            labelLanes.Name = "labelLanes";
            labelLanes.Size = new Size(41, 27);
            labelLanes.TabIndex = 18;
            labelLanes.Text = "Traffic Lanes";
            // 
            // cbDir
            // 
            cbDir.FormattingEnabled = true;
            cbDir.Items.AddRange(new object[] { "F", "T" });
            cbDir.Location = new Point(323, 34);
            cbDir.Name = "cbDir";
            cbDir.Size = new Size(46, 21);
            cbDir.TabIndex = 17;
            cbDir.Text = "F";
            // 
            // cmdDetail
            // 
            _cmdDetail.Location = new Point(414, 30);
            _cmdDetail.Name = "_cmdDetail";
            _cmdDetail.Size = new Size(43, 25);
            _cmdDetail.TabIndex = 34;
            _cmdDetail.Text = "Info";
            _cmdDetail.UseVisualStyleBackColor = true;
            // 
            // labelVectorTexture
            // 
            labelVectorTexture.BorderStyle = BorderStyle.Fixed3D;
            labelVectorTexture.Location = new Point(377, 33);
            labelVectorTexture.Name = "labelVectorTexture";
            labelVectorTexture.Size = new Size(31, 21);
            labelVectorTexture.TabIndex = 33;
            labelVectorTexture.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(235, 64);
            Label5.Name = "Label5";
            Label5.Size = new Size(192, 13);
            Label5.TabIndex = 32;
            Label5.Text = "Right click to copy GUID into Clipboard";
            // 
            // listVector
            // 
            _listVector.BackColor = SystemColors.Window;
            _listVector.Cursor = Cursors.Default;
            _listVector.ForeColor = SystemColors.WindowText;
            _listVector.Location = new Point(234, 80);
            _listVector.Name = "_listVector";
            _listVector.RightToLeft = RightToLeft.No;
            _listVector.Size = new Size(223, 147);
            _listVector.TabIndex = 27;
            // 
            // TabPage3
            // 
            _TabPage3.Controls.Add(boxTexType);
            _TabPage3.Controls.Add(imgTex);
            _TabPage3.Controls.Add(boxTexTexture);
            _TabPage3.Location = new Point(4, 22);
            _TabPage3.Name = "_TabPage3";
            _TabPage3.Padding = new Padding(3);
            _TabPage3.Size = new Size(480, 241);
            _TabPage3.TabIndex = 2;
            _TabPage3.Text = "Textured Lines";
            _TabPage3.UseVisualStyleBackColor = true;
            // 
            // boxTexType
            // 
            boxTexType.Controls.Add(txtV1);
            boxTexType.Controls.Add(txtTexPri);
            boxTexType.Controls.Add(cmbComplex);
            boxTexType.Controls.Add(Label3);
            boxTexType.Controls.Add(optStanding);
            boxTexType.Controls.Add(_optLying);
            boxTexType.Controls.Add(lbTexPri);
            boxTexType.Controls.Add(LbV1);
            boxTexType.Location = new Point(228, 140);
            boxTexType.Name = "boxTexType";
            boxTexType.Size = new Size(234, 86);
            boxTexType.TabIndex = 99;
            boxTexType.TabStop = false;
            boxTexType.Text = "Type";
            // 
            // txtV1
            // 
            txtV1.AcceptsReturn = true;
            txtV1.BackColor = SystemColors.Window;
            txtV1.Cursor = Cursors.IBeam;
            txtV1.ForeColor = SystemColors.WindowText;
            txtV1.Location = new Point(124, 22);
            txtV1.MaxLength = 0;
            txtV1.Name = "txtV1";
            txtV1.RightToLeft = RightToLeft.No;
            txtV1.Size = new Size(39, 20);
            txtV1.TabIndex = 94;
            txtV1.Text = "25000";
            txtV1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTexPri
            // 
            txtTexPri.AcceptsReturn = true;
            txtTexPri.BackColor = SystemColors.Window;
            txtTexPri.Cursor = Cursors.IBeam;
            txtTexPri.ForeColor = SystemColors.WindowText;
            txtTexPri.Location = new Point(190, 21);
            txtTexPri.MaxLength = 0;
            txtTexPri.Name = "txtTexPri";
            txtTexPri.RightToLeft = RightToLeft.No;
            txtTexPri.Size = new Size(25, 20);
            txtTexPri.TabIndex = 91;
            txtTexPri.Text = "4";
            txtTexPri.TextAlign = HorizontalAlignment.Center;
            // 
            // cmbComplex
            // 
            cmbComplex.FormattingEnabled = true;
            cmbComplex.Items.AddRange(new object[] { "Very Sparse", "Sparse", "Normal", "Dense", "Very Dense", "Extra Dense" });
            cmbComplex.Location = new Point(124, 52);
            cmbComplex.Name = "cmbComplex";
            cmbComplex.Size = new Size(91, 21);
            cmbComplex.TabIndex = 107;
            cmbComplex.Text = "Normal";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(88, 56);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(39, 13);
            Label3.TabIndex = 106;
            Label3.Text = "Compl.";
            // 
            // optStanding
            // 
            optStanding.AutoSize = true;
            optStanding.Location = new Point(15, 54);
            optStanding.Name = "optStanding";
            optStanding.Size = new Size(67, 17);
            optStanding.TabIndex = 97;
            optStanding.Text = "Standing";
            optStanding.UseVisualStyleBackColor = true;
            // 
            // optLying
            // 
            _optLying.AutoSize = true;
            _optLying.Checked = true;
            _optLying.Location = new Point(15, 24);
            _optLying.Name = "_optLying";
            _optLying.Size = new Size(50, 17);
            _optLying.TabIndex = 96;
            _optLying.TabStop = true;
            _optLying.Text = "Lying";
            _optLying.UseVisualStyleBackColor = true;
            // 
            // lbTexPri
            // 
            lbTexPri.AutoSize = true;
            lbTexPri.BackColor = Color.Transparent;
            lbTexPri.Cursor = Cursors.Default;
            lbTexPri.ForeColor = SystemColors.ControlText;
            lbTexPri.Location = new Point(171, 27);
            lbTexPri.Name = "lbTexPri";
            lbTexPri.RightToLeft = RightToLeft.No;
            lbTexPri.Size = new Size(22, 13);
            lbTexPri.TabIndex = 93;
            lbTexPri.Text = "Pri.";
            // 
            // LbV1
            // 
            LbV1.AutoSize = true;
            LbV1.BackColor = Color.Transparent;
            LbV1.Cursor = Cursors.Default;
            LbV1.ForeColor = SystemColors.ControlText;
            LbV1.Location = new Point(101, 27);
            LbV1.Name = "LbV1";
            LbV1.RightToLeft = RightToLeft.No;
            LbV1.Size = new Size(24, 13);
            LbV1.TabIndex = 95;
            LbV1.Text = "Vis.";
            LbV1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // imgTex
            // 
            imgTex.BorderStyle = BorderStyle.FixedSingle;
            imgTex.Cursor = Cursors.Default;
            imgTex.ErrorImage = null;
            imgTex.InitialImage = null;
            imgTex.Location = new Point(18, 22);
            imgTex.Name = "imgTex";
            imgTex.Size = new Size(444, 111);
            imgTex.TabIndex = 8;
            imgTex.TabStop = false;
            // 
            // boxTexTexture
            // 
            boxTexTexture.Controls.Add(_optTile);
            boxTexTexture.Controls.Add(_optStretch);
            boxTexTexture.Controls.Add(_cmdTex);
            boxTexTexture.Controls.Add(txtTexName);
            boxTexTexture.Controls.Add(ckNight);
            boxTexTexture.Controls.Add(optFull);
            boxTexTexture.Location = new Point(18, 139);
            boxTexTexture.Name = "boxTexTexture";
            boxTexTexture.Size = new Size(194, 87);
            boxTexTexture.TabIndex = 98;
            boxTexTexture.TabStop = false;
            boxTexTexture.Text = "Texture";
            // 
            // optTile
            // 
            _optTile.AutoSize = true;
            _optTile.Checked = true;
            _optTile.Location = new Point(12, 18);
            _optTile.Name = "_optTile";
            _optTile.Size = new Size(42, 17);
            _optTile.TabIndex = 98;
            _optTile.TabStop = true;
            _optTile.Text = "Tile";
            _optTile.UseVisualStyleBackColor = true;
            // 
            // optStretch
            // 
            _optStretch.AutoSize = true;
            _optStretch.Location = new Point(12, 64);
            _optStretch.Name = "_optStretch";
            _optStretch.Size = new Size(59, 17);
            _optStretch.TabIndex = 97;
            _optStretch.Text = "Stretch";
            _optStretch.UseVisualStyleBackColor = true;
            // 
            // cmdTex
            // 
            _cmdTex.BackColor = SystemColors.Control;
            _cmdTex.BackgroundImageLayout = ImageLayout.None;
            _cmdTex.Cursor = Cursors.Default;
            _cmdTex.ForeColor = SystemColors.ControlText;
            _cmdTex.Location = new Point(151, 16);
            _cmdTex.Name = "_cmdTex";
            _cmdTex.RightToLeft = RightToLeft.No;
            _cmdTex.Size = new Size(32, 25);
            _cmdTex.TabIndex = 92;
            _cmdTex.Text = "...";
            _cmdTex.UseVisualStyleBackColor = false;
            // 
            // txtTexName
            // 
            txtTexName.AcceptsReturn = true;
            txtTexName.BackColor = SystemColors.Window;
            txtTexName.Cursor = Cursors.IBeam;
            txtTexName.ForeColor = SystemColors.WindowText;
            txtTexName.Location = new Point(60, 18);
            txtTexName.MaxLength = 0;
            txtTexName.Name = "txtTexName";
            txtTexName.RightToLeft = RightToLeft.No;
            txtTexName.Size = new Size(85, 20);
            txtTexName.TabIndex = 90;
            txtTexName.TextAlign = HorizontalAlignment.Center;
            // 
            // ckNight
            // 
            ckNight.BackColor = Color.Transparent;
            ckNight.CheckAlign = ContentAlignment.MiddleRight;
            ckNight.Cursor = Cursors.Default;
            ckNight.ForeColor = SystemColors.ControlText;
            ckNight.Location = new Point(125, 54);
            ckNight.Name = "ckNight";
            ckNight.RightToLeft = RightToLeft.No;
            ckNight.Size = new Size(58, 21);
            ckNight.TabIndex = 96;
            ckNight.Text = "Night";
            ckNight.TextAlign = ContentAlignment.MiddleRight;
            ckNight.UseVisualStyleBackColor = false;
            // 
            // optFull
            // 
            optFull.AutoSize = true;
            optFull.Location = new Point(12, 41);
            optFull.Name = "optFull";
            optFull.Size = new Size(89, 17);
            optFull.TabIndex = 97;
            optFull.Text = "Complete Tile";
            optFull.UseVisualStyleBackColor = true;
            // 
            // TabPage4
            // 
            _TabPage4.Controls.Add(_cmdExtrusionProperties);
            _TabPage4.Controls.Add(labelProfile);
            _TabPage4.Controls.Add(lbguid);
            _TabPage4.Controls.Add(lbExt1);
            _TabPage4.Controls.Add(_listExtrusion);
            _TabPage4.Controls.Add(_imgExtrusion);
            _TabPage4.Location = new Point(4, 22);
            _TabPage4.Name = "_TabPage4";
            _TabPage4.Size = new Size(480, 241);
            _TabPage4.TabIndex = 3;
            _TabPage4.Text = "Extrusion Bridges";
            _TabPage4.UseVisualStyleBackColor = true;
            // 
            // cmdExtrusionProperties
            // 
            _cmdExtrusionProperties.Location = new Point(235, 29);
            _cmdExtrusionProperties.Name = "_cmdExtrusionProperties";
            _cmdExtrusionProperties.Size = new Size(68, 25);
            _cmdExtrusionProperties.TabIndex = 96;
            _cmdExtrusionProperties.Text = "Properties";
            _cmdExtrusionProperties.UseVisualStyleBackColor = true;
            // 
            // labelProfile
            // 
            labelProfile.BorderStyle = BorderStyle.FixedSingle;
            labelProfile.Location = new Point(235, 73);
            labelProfile.Name = "labelProfile";
            labelProfile.Size = new Size(223, 19);
            labelProfile.TabIndex = 95;
            labelProfile.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbguid
            // 
            lbguid.AutoSize = true;
            lbguid.Location = new Point(355, 60);
            lbguid.Name = "lbguid";
            lbguid.Size = new Size(107, 13);
            lbguid.TabIndex = 35;
            lbguid.Text = "Extrusion Profile Guid";
            // 
            // lbExt1
            // 
            lbExt1.AutoSize = true;
            lbExt1.Location = new Point(12, 16);
            lbExt1.Name = "lbExt1";
            lbExt1.Size = new Size(99, 13);
            lbExt1.TabIndex = 35;
            lbExt1.Text = "Click to see a detail";
            // 
            // listExtrusion
            // 
            _listExtrusion.BackColor = SystemColors.Window;
            _listExtrusion.Cursor = Cursors.Default;
            _listExtrusion.ForeColor = SystemColors.WindowText;
            _listExtrusion.Location = new Point(235, 95);
            _listExtrusion.Name = "_listExtrusion";
            _listExtrusion.RightToLeft = RightToLeft.No;
            _listExtrusion.Size = new Size(223, 134);
            _listExtrusion.TabIndex = 34;
            // 
            // imgExtrusion
            // 
            _imgExtrusion.BorderStyle = BorderStyle.FixedSingle;
            _imgExtrusion.Cursor = Cursors.Default;
            _imgExtrusion.Location = new Point(15, 29);
            _imgExtrusion.Name = "_imgExtrusion";
            _imgExtrusion.Size = new Size(200, 200);
            _imgExtrusion.SizeMode = PictureBoxSizeMode.StretchImage;
            _imgExtrusion.TabIndex = 8;
            _imgExtrusion.TabStop = false;
            // 
            // TabPage5
            // 
            _TabPage5.Controls.Add(boxHeading);
            _TabPage5.Controls.Add(cmbComplexity);
            _TabPage5.Controls.Add(labelComplexity);
            _TabPage5.Controls.Add(labelCat);
            _TabPage5.Controls.Add(imgLib);
            _TabPage5.Controls.Add(_lstLib);
            _TabPage5.Controls.Add(labelLibID);
            _TabPage5.Controls.Add(_cmbLibCat);
            _TabPage5.Location = new Point(4, 22);
            _TabPage5.Name = "_TabPage5";
            _TabPage5.Padding = new Padding(3);
            _TabPage5.Size = new Size(480, 241);
            _TabPage5.TabIndex = 4;
            _TabPage5.Text = "Line of Objects";
            _TabPage5.UseVisualStyleBackColor = true;
            // 
            // boxHeading
            // 
            boxHeading.Controls.Add(_ckRandom);
            boxHeading.Controls.Add(txtHeading);
            boxHeading.Controls.Add(_cmdHeading);
            boxHeading.Location = new Point(235, 17);
            boxHeading.Name = "boxHeading";
            boxHeading.Size = new Size(224, 51);
            boxHeading.TabIndex = 106;
            boxHeading.TabStop = false;
            boxHeading.Text = "Heading";
            // 
            // ckRandom
            // 
            _ckRandom.AutoSize = true;
            _ckRandom.Location = new Point(16, 21);
            _ckRandom.Name = "_ckRandom";
            _ckRandom.Size = new Size(66, 17);
            _ckRandom.TabIndex = 2;
            _ckRandom.Text = "Random";
            _ckRandom.UseVisualStyleBackColor = true;
            // 
            // txtHeading
            // 
            txtHeading.Location = new Point(102, 18);
            txtHeading.Name = "txtHeading";
            txtHeading.Size = new Size(51, 20);
            txtHeading.TabIndex = 1;
            txtHeading.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdHeading
            // 
            _cmdHeading.Location = new Point(166, 16);
            _cmdHeading.Name = "_cmdHeading";
            _cmdHeading.Size = new Size(40, 23);
            _cmdHeading.TabIndex = 0;
            _cmdHeading.Text = "Set";
            _cmdHeading.UseVisualStyleBackColor = true;
            // 
            // cmbComplexity
            // 
            cmbComplexity.FormattingEnabled = true;
            cmbComplexity.Items.AddRange(new object[] { "Very Sparse", "Sparse", "Normal", "Dense", "Very Dense", "Extra Dense" });
            cmbComplexity.Location = new Point(235, 91);
            cmbComplexity.Name = "cmbComplexity";
            cmbComplexity.Size = new Size(75, 21);
            cmbComplexity.TabIndex = 105;
            cmbComplexity.Text = "Normal";
            // 
            // labelComplexity
            // 
            labelComplexity.AutoSize = true;
            labelComplexity.BackColor = Color.Transparent;
            labelComplexity.Cursor = Cursors.Default;
            labelComplexity.ForeColor = SystemColors.ControlText;
            labelComplexity.Location = new Point(232, 75);
            labelComplexity.Name = "labelComplexity";
            labelComplexity.RightToLeft = RightToLeft.No;
            labelComplexity.Size = new Size(57, 13);
            labelComplexity.TabIndex = 103;
            labelComplexity.Text = "Complexity";
            // 
            // labelCat
            // 
            labelCat.AutoSize = true;
            labelCat.BackColor = Color.Transparent;
            labelCat.Cursor = Cursors.Default;
            labelCat.ForeColor = SystemColors.ControlText;
            labelCat.Location = new Point(320, 75);
            labelCat.Name = "labelCat";
            labelCat.RightToLeft = RightToLeft.No;
            labelCat.Size = new Size(83, 13);
            labelCat.TabIndex = 103;
            labelCat.Text = "Object Category";
            // 
            // imgLib
            // 
            imgLib.BorderStyle = BorderStyle.FixedSingle;
            imgLib.Cursor = Cursors.Default;
            imgLib.Location = new Point(15, 29);
            imgLib.Name = "imgLib";
            imgLib.Size = new Size(200, 200);
            imgLib.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLib.TabIndex = 9;
            imgLib.TabStop = false;
            // 
            // lstLib
            // 
            _lstLib.BackColor = SystemColors.Window;
            _lstLib.Cursor = Cursors.Default;
            _lstLib.ForeColor = SystemColors.WindowText;
            _lstLib.Location = new Point(235, 134);
            _lstLib.Name = "_lstLib";
            _lstLib.RightToLeft = RightToLeft.No;
            _lstLib.Size = new Size(224, 95);
            _lstLib.TabIndex = 100;
            // 
            // labelLibID
            // 
            labelLibID.BackColor = Color.Transparent;
            labelLibID.Cursor = Cursors.Default;
            labelLibID.ForeColor = SystemColors.ControlText;
            labelLibID.Location = new Point(235, 115);
            labelLibID.Name = "labelLibID";
            labelLibID.RightToLeft = RightToLeft.No;
            labelLibID.Size = new Size(227, 16);
            labelLibID.TabIndex = 104;
            labelLibID.Text = "GUID";
            labelLibID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmbLibCat
            // 
            _cmbLibCat.BackColor = SystemColors.Window;
            _cmbLibCat.Cursor = Cursors.Default;
            _cmbLibCat.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbLibCat.ForeColor = SystemColors.WindowText;
            _cmbLibCat.Location = new Point(323, 91);
            _cmbLibCat.Name = "_cmbLibCat";
            _cmbLibCat.RightToLeft = RightToLeft.No;
            _cmbLibCat.Size = new Size(136, 21);
            _cmbLibCat.TabIndex = 102;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(348, 295);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(66, 25);
            _cmdCancel.TabIndex = 26;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(430, 295);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(66, 25);
            _cmdOK.TabIndex = 25;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdSample
            // 
            _cmdSample.Location = new Point(125, 295);
            _cmdSample.Name = "_cmdSample";
            _cmdSample.Size = new Size(62, 25);
            _cmdSample.TabIndex = 38;
            _cmdSample.Text = "Sample";
            _cmdSample.UseVisualStyleBackColor = true;
            // 
            // cmdSmooth
            // 
            _cmdSmooth.Location = new Point(46, 295);
            _cmdSmooth.Name = "_cmdSmooth";
            _cmdSmooth.Size = new Size(62, 25);
            _cmdSmooth.TabIndex = 37;
            _cmdSmooth.Text = "Smooth";
            _cmdSmooth.UseVisualStyleBackColor = true;
            // 
            // FrmLinesP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 334);
            Controls.Add(_cmdSample);
            Controls.Add(_cmdSmooth);
            Controls.Add(TabControl1);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLinesP";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Line Properties";
            ((System.ComponentModel.ISupportInitialize)imgVector).EndInit();
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            boxType.ResumeLayout(false);
            boxType.PerformLayout();
            boxAltitude.ResumeLayout(false);
            boxAltitude.PerformLayout();
            boxProgressive.ResumeLayout(false);
            boxProgressive.PerformLayout();
            boxWidth.ResumeLayout(false);
            boxWidth.PerformLayout();
            _TabPage2.ResumeLayout(false);
            _TabPage2.PerformLayout();
            _TabPage3.ResumeLayout(false);
            boxTexType.ResumeLayout(false);
            boxTexType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgTex).EndInit();
            boxTexTexture.ResumeLayout(false);
            boxTexTexture.PerformLayout();
            _TabPage4.ResumeLayout(false);
            _TabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_imgExtrusion).EndInit();
            _TabPage5.ResumeLayout(false);
            _TabPage5.PerformLayout();
            boxHeading.ResumeLayout(false);
            boxHeading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLib).EndInit();
            Load += new EventHandler(FrmLinesP_Load);
            ResumeLayout(false);
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