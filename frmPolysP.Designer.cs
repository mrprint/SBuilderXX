using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmPolysP : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPolysP));
            TabControl1 = new TabControl();
            TabPage1 = new TabPage();
            BoxOrder = new GroupBox();
            _cmdBottom = new Button();
            _cmdBottom.Click += new EventHandler(CmdBottom_Click);
            _cmdTop = new Button();
            _cmdTop.Click += new EventHandler(CmdTop_Click);
            _cmdDown = new Button();
            _cmdDown.Click += new EventHandler(CmdDown_Click);
            _cmdUP = new Button();
            _cmdUP.Click += new EventHandler(CmdUP_Click);
            lbOrder = new Label();
            boxType = new GroupBox();
            _cmdType = new Button();
            _cmdType.Click += new EventHandler(CmdType_Click);
            _optTexture = new RadioButton();
            _optTexture.CheckedChanged += new EventHandler(OptTexture_CheckedChanged);
            _optVector = new RadioButton();
            _optVector.CheckedChanged += new EventHandler(OptVector_CheckedChanged);
            txtName = new TextBox();
            lbName = new Label();
            boxAltitude = new GroupBox();
            txtAlt = new TextBox();
            _cmdAlt = new Button();
            _cmdAlt.Click += new EventHandler(CmdAlt_Click);
            boxSlope = new GroupBox();
            txtHead = new TextBox();
            txtAlt0 = new TextBox();
            _cmdHelpSlope = new Button();
            _cmdHelpSlope.Click += new EventHandler(CmdHelpSlope_Click);
            _cmdSlope = new Button();
            _cmdSlope.Click += new EventHandler(CmdSlope_Click);
            txtSlope = new TextBox();
            lbSY = new Label();
            Label8 = new Label();
            lbSX = new Label();
            Label6 = new Label();
            Label4 = new Label();
            Label5 = new Label();
            txtPt0 = new TextBox();
            _TabPage2 = new TabPage();
            _TabPage2.Click += new EventHandler(TabPage2_Click);
            lbTexture = new Label();
            _cmdColor = new Button();
            _cmdColor.Click += new EventHandler(CmdColor_Click);
            ckThisColor = new CheckBox();
            Label1 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            _lbExclude = new Label();
            _lbExclude.Click += new EventHandler(LbExclude_Click);
            lbExcludeCaption = new Label();
            _cmdDetail = new Button();
            _cmdDetail.Click += new EventHandler(CmdDetail_Click);
            _imgTexture = new PictureBox();
            _imgTexture.Click += new EventHandler(ImgTexture_Click);
            _List1 = new ListBox();
            _List1.MouseDown += new MouseEventHandler(List1_MouseDown);
            _List1.SelectedIndexChanged += new EventHandler(List1_SelectedIndexChanged);
            _TabPage3 = new TabPage();
            _TabPage3.Click += new EventHandler(TabPage3_Click);
            lbPolyColor = new Label();
            _cmdColor2 = new Button();
            _cmdColor2.Click += new EventHandler(CmdColor2_Click);
            boxTiling = new GroupBox();
            lbTex4 = new Label();
            txtTexTileX = new TextBox();
            lbTex5 = new Label();
            txtTexTileY = new TextBox();
            lbTexName = new Label();
            _imgTex = new PictureBox();
            _imgTex.Click += new EventHandler(ImgTex_Click);
            lbTex1 = new Label();
            lbTexPri = new Label();
            LbV1 = new Label();
            txtTexName = new TextBox();
            txtTexPri = new TextBox();
            _cmdTex = new Button();
            _cmdTex.Click += new EventHandler(CmdTex_Click);
            txtV1 = new TextBox();
            ckNight = new CheckBox();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdSmooth = new Button();
            _cmdSmooth.Click += new EventHandler(CmdSmooth_Click);
            _cmdSample = new Button();
            _cmdSample.Click += new EventHandler(CmdSample_Click);
            TabControl1.SuspendLayout();
            TabPage1.SuspendLayout();
            BoxOrder.SuspendLayout();
            boxType.SuspendLayout();
            boxAltitude.SuspendLayout();
            boxSlope.SuspendLayout();
            _TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_imgTexture).BeginInit();
            _TabPage3.SuspendLayout();
            boxTiling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_imgTex).BeginInit();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(TabPage1);
            TabControl1.Controls.Add(_TabPage2);
            TabControl1.Controls.Add(_TabPage3);
            TabControl1.Location = new Point(17, 12);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(469, 272);
            TabControl1.TabIndex = 34;
            // 
            // TabPage1
            // 
            TabPage1.Controls.Add(BoxOrder);
            TabPage1.Controls.Add(boxType);
            TabPage1.Controls.Add(txtName);
            TabPage1.Controls.Add(lbName);
            TabPage1.Controls.Add(boxAltitude);
            TabPage1.Controls.Add(boxSlope);
            TabPage1.Location = new Point(4, 22);
            TabPage1.Name = "TabPage1";
            TabPage1.Padding = new Padding(3);
            TabPage1.Size = new Size(461, 246);
            TabPage1.TabIndex = 0;
            TabPage1.Text = "General";
            TabPage1.UseVisualStyleBackColor = true;
            // 
            // BoxOrder
            // 
            BoxOrder.Controls.Add(_cmdBottom);
            BoxOrder.Controls.Add(_cmdTop);
            BoxOrder.Controls.Add(_cmdDown);
            BoxOrder.Controls.Add(_cmdUP);
            BoxOrder.Controls.Add(lbOrder);
            BoxOrder.Location = new Point(18, 66);
            BoxOrder.Name = "BoxOrder";
            BoxOrder.Size = new Size(171, 78);
            BoxOrder.TabIndex = 66;
            BoxOrder.TabStop = false;
            BoxOrder.Text = "Drawing order";
            // 
            // cmdBottom
            // 
            _cmdBottom.BackColor = SystemColors.Control;
            _cmdBottom.Cursor = Cursors.Default;
            _cmdBottom.ForeColor = SystemColors.ControlText;
            _cmdBottom.Image = (Image)resources.GetObject("cmdBottom.Image");
            _cmdBottom.Location = new Point(136, 41);
            _cmdBottom.Name = "_cmdBottom";
            _cmdBottom.RightToLeft = RightToLeft.No;
            _cmdBottom.Size = new Size(25, 25);
            _cmdBottom.TabIndex = 18;
            _cmdBottom.TextAlign = ContentAlignment.BottomCenter;
            _cmdBottom.UseVisualStyleBackColor = false;
            // 
            // cmdTop
            // 
            _cmdTop.BackColor = SystemColors.Control;
            _cmdTop.Cursor = Cursors.Default;
            _cmdTop.ForeColor = SystemColors.ControlText;
            _cmdTop.Image = (Image)resources.GetObject("cmdTop.Image");
            _cmdTop.Location = new Point(96, 41);
            _cmdTop.Name = "_cmdTop";
            _cmdTop.RightToLeft = RightToLeft.No;
            _cmdTop.Size = new Size(25, 25);
            _cmdTop.TabIndex = 17;
            _cmdTop.TextAlign = ContentAlignment.BottomCenter;
            _cmdTop.UseVisualStyleBackColor = false;
            // 
            // cmdDown
            // 
            _cmdDown.BackColor = SystemColors.Control;
            _cmdDown.Cursor = Cursors.Default;
            _cmdDown.ForeColor = SystemColors.ControlText;
            _cmdDown.Image = (Image)resources.GetObject("cmdDown.Image");
            _cmdDown.Location = new Point(57, 41);
            _cmdDown.Name = "_cmdDown";
            _cmdDown.RightToLeft = RightToLeft.No;
            _cmdDown.Size = new Size(25, 25);
            _cmdDown.TabIndex = 16;
            _cmdDown.TextAlign = ContentAlignment.BottomCenter;
            _cmdDown.UseVisualStyleBackColor = false;
            // 
            // cmdUP
            // 
            _cmdUP.BackColor = SystemColors.Control;
            _cmdUP.Cursor = Cursors.Default;
            _cmdUP.ForeColor = SystemColors.ControlText;
            _cmdUP.Image = (Image)resources.GetObject("cmdUP.Image");
            _cmdUP.Location = new Point(18, 41);
            _cmdUP.Name = "_cmdUP";
            _cmdUP.RightToLeft = RightToLeft.No;
            _cmdUP.Size = new Size(25, 25);
            _cmdUP.TabIndex = 2;
            _cmdUP.TextAlign = ContentAlignment.BottomCenter;
            _cmdUP.UseVisualStyleBackColor = false;
            // 
            // lbOrder
            // 
            lbOrder.AutoSize = true;
            lbOrder.BackColor = Color.Transparent;
            lbOrder.Cursor = Cursors.Default;
            lbOrder.ForeColor = SystemColors.ControlText;
            lbOrder.Location = new Point(42, 19);
            lbOrder.Name = "lbOrder";
            lbOrder.RightToLeft = RightToLeft.No;
            lbOrder.Size = new Size(41, 13);
            lbOrder.TabIndex = 34;
            lbOrder.Text = "lbOrder";
            // 
            // boxType
            // 
            boxType.Controls.Add(_cmdType);
            boxType.Controls.Add(_optTexture);
            boxType.Controls.Add(_optVector);
            boxType.Location = new Point(18, 160);
            boxType.Name = "boxType";
            boxType.Size = new Size(171, 73);
            boxType.TabIndex = 64;
            boxType.TabStop = false;
            boxType.Text = "Polygon type";
            // 
            // cmdType
            // 
            _cmdType.Location = new Point(112, 25);
            _cmdType.Name = "_cmdType";
            _cmdType.Size = new Size(47, 24);
            _cmdType.TabIndex = 2;
            _cmdType.Text = ">>>";
            _cmdType.UseVisualStyleBackColor = true;
            // 
            // optTexture
            // 
            _optTexture.AutoSize = true;
            _optTexture.Location = new Point(17, 43);
            _optTexture.Name = "_optTexture";
            _optTexture.Size = new Size(90, 17);
            _optTexture.TabIndex = 1;
            _optTexture.TabStop = true;
            _optTexture.Text = "Textured Poly";
            _optTexture.UseVisualStyleBackColor = true;
            // 
            // optVector
            // 
            _optVector.AutoSize = true;
            _optVector.Location = new Point(17, 18);
            _optVector.Name = "_optVector";
            _optVector.Size = new Size(79, 17);
            _optVector.TabIndex = 0;
            _optVector.TabStop = true;
            _optVector.Text = "Vector Poly";
            _optVector.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            txtName.Location = new Point(18, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(232, 20);
            txtName.TabIndex = 61;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(15, 14);
            lbName.Name = "lbName";
            lbName.Size = new Size(35, 13);
            lbName.TabIndex = 62;
            lbName.Text = "Name";
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // boxAltitude
            // 
            boxAltitude.Controls.Add(txtAlt);
            boxAltitude.Controls.Add(_cmdAlt);
            boxAltitude.Location = new Point(271, 14);
            boxAltitude.Name = "boxAltitude";
            boxAltitude.Size = new Size(171, 58);
            boxAltitude.TabIndex = 57;
            boxAltitude.TabStop = false;
            boxAltitude.Text = "Constant altitude";
            // 
            // txtAlt
            // 
            txtAlt.BackColor = SystemColors.Window;
            txtAlt.Cursor = Cursors.IBeam;
            txtAlt.ForeColor = SystemColors.WindowText;
            txtAlt.Location = new Point(16, 24);
            txtAlt.MaxLength = 0;
            txtAlt.Name = "txtAlt";
            txtAlt.RightToLeft = RightToLeft.No;
            txtAlt.Size = new Size(70, 20);
            txtAlt.TabIndex = 29;
            txtAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdAlt
            // 
            _cmdAlt.BackColor = SystemColors.Control;
            _cmdAlt.Cursor = Cursors.Default;
            _cmdAlt.ForeColor = SystemColors.ControlText;
            _cmdAlt.Location = new Point(110, 19);
            _cmdAlt.Name = "_cmdAlt";
            _cmdAlt.RightToLeft = RightToLeft.No;
            _cmdAlt.Size = new Size(44, 25);
            _cmdAlt.TabIndex = 28;
            _cmdAlt.Text = "Set";
            _cmdAlt.UseVisualStyleBackColor = false;
            // 
            // boxSlope
            // 
            boxSlope.Controls.Add(txtHead);
            boxSlope.Controls.Add(txtAlt0);
            boxSlope.Controls.Add(_cmdHelpSlope);
            boxSlope.Controls.Add(_cmdSlope);
            boxSlope.Controls.Add(txtSlope);
            boxSlope.Controls.Add(lbSY);
            boxSlope.Controls.Add(Label8);
            boxSlope.Controls.Add(lbSX);
            boxSlope.Controls.Add(Label6);
            boxSlope.Controls.Add(Label4);
            boxSlope.Controls.Add(Label5);
            boxSlope.Controls.Add(txtPt0);
            boxSlope.Location = new Point(209, 88);
            boxSlope.Name = "boxSlope";
            boxSlope.Size = new Size(233, 145);
            boxSlope.TabIndex = 56;
            boxSlope.TabStop = false;
            boxSlope.Text = "Variable Altitude";
            // 
            // txtHead
            // 
            txtHead.BackColor = SystemColors.Window;
            txtHead.Cursor = Cursors.IBeam;
            txtHead.ForeColor = SystemColors.WindowText;
            txtHead.Location = new Point(77, 62);
            txtHead.MaxLength = 0;
            txtHead.Name = "txtHead";
            txtHead.RightToLeft = RightToLeft.No;
            txtHead.Size = new Size(71, 20);
            txtHead.TabIndex = 63;
            txtHead.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAlt0
            // 
            txtAlt0.BackColor = SystemColors.Window;
            txtAlt0.Cursor = Cursors.IBeam;
            txtAlt0.ForeColor = SystemColors.WindowText;
            txtAlt0.Location = new Point(18, 36);
            txtAlt0.MaxLength = 0;
            txtAlt0.Name = "txtAlt0";
            txtAlt0.RightToLeft = RightToLeft.No;
            txtAlt0.Size = new Size(90, 20);
            txtAlt0.TabIndex = 62;
            txtAlt0.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdHelpSlope
            // 
            _cmdHelpSlope.BackColor = SystemColors.Control;
            _cmdHelpSlope.Cursor = Cursors.Default;
            _cmdHelpSlope.ForeColor = SystemColors.ControlText;
            _cmdHelpSlope.Location = new Point(171, 36);
            _cmdHelpSlope.Name = "_cmdHelpSlope";
            _cmdHelpSlope.RightToLeft = RightToLeft.No;
            _cmdHelpSlope.Size = new Size(44, 25);
            _cmdHelpSlope.TabIndex = 61;
            _cmdHelpSlope.Text = "Help";
            _cmdHelpSlope.UseVisualStyleBackColor = false;
            // 
            // cmdSlope
            // 
            _cmdSlope.BackColor = SystemColors.Control;
            _cmdSlope.Cursor = Cursors.Default;
            _cmdSlope.ForeColor = SystemColors.ControlText;
            _cmdSlope.Location = new Point(171, 83);
            _cmdSlope.Name = "_cmdSlope";
            _cmdSlope.RightToLeft = RightToLeft.No;
            _cmdSlope.Size = new Size(44, 25);
            _cmdSlope.TabIndex = 60;
            _cmdSlope.Text = "Set";
            _cmdSlope.UseVisualStyleBackColor = false;
            // 
            // txtSlope
            // 
            txtSlope.BackColor = SystemColors.Window;
            txtSlope.Cursor = Cursors.IBeam;
            txtSlope.ForeColor = SystemColors.WindowText;
            txtSlope.Location = new Point(77, 88);
            txtSlope.MaxLength = 0;
            txtSlope.Name = "txtSlope";
            txtSlope.RightToLeft = RightToLeft.No;
            txtSlope.Size = new Size(71, 20);
            txtSlope.TabIndex = 58;
            txtSlope.TextAlign = HorizontalAlignment.Center;
            // 
            // lbSY
            // 
            lbSY.AutoSize = true;
            lbSY.Location = new Point(136, 119);
            lbSY.Name = "lbSY";
            lbSY.Size = new Size(59, 13);
            lbSY.TabIndex = 59;
            lbSY.Text = "SlopeY = 0";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(40, 91);
            Label8.Name = "Label8";
            Label8.Size = new Size(34, 13);
            Label8.TabIndex = 59;
            Label8.Text = "Slope";
            // 
            // lbSX
            // 
            lbSX.AutoSize = true;
            lbSX.Location = new Point(15, 119);
            lbSX.Name = "lbSX";
            lbSX.Size = new Size(59, 13);
            lbSX.TabIndex = 58;
            lbSX.Text = "SlopeX = 0";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(24, 65);
            Label6.Name = "Label6";
            Label6.Size = new Size(47, 13);
            Label6.TabIndex = 57;
            Label6.Text = "Heading";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = SystemColors.Control;
            Label4.Cursor = Cursors.Default;
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(111, 21);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(27, 13);
            Label4.TabIndex = 56;
            Label4.Text = "Pt #";
            Label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Location = new Point(59, 20);
            Label5.Name = "Label5";
            Label5.Size = new Size(54, 13);
            Label5.TabIndex = 53;
            Label5.Text = "Altitude of";
            Label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPt0
            // 
            txtPt0.BackColor = SystemColors.Window;
            txtPt0.Cursor = Cursors.IBeam;
            txtPt0.ForeColor = SystemColors.WindowText;
            txtPt0.Location = new Point(114, 36);
            txtPt0.MaxLength = 0;
            txtPt0.Name = "txtPt0";
            txtPt0.RightToLeft = RightToLeft.No;
            txtPt0.Size = new Size(34, 20);
            txtPt0.TabIndex = 52;
            txtPt0.TextAlign = HorizontalAlignment.Center;
            // 
            // TabPage2
            // 
            _TabPage2.Controls.Add(lbTexture);
            _TabPage2.Controls.Add(_cmdColor);
            _TabPage2.Controls.Add(ckThisColor);
            _TabPage2.Controls.Add(Label1);
            _TabPage2.Controls.Add(Label3);
            _TabPage2.Controls.Add(Label2);
            _TabPage2.Controls.Add(_lbExclude);
            _TabPage2.Controls.Add(lbExcludeCaption);
            _TabPage2.Controls.Add(_cmdDetail);
            _TabPage2.Controls.Add(_imgTexture);
            _TabPage2.Controls.Add(_List1);
            _TabPage2.Location = new Point(4, 22);
            _TabPage2.Name = "_TabPage2";
            _TabPage2.Padding = new Padding(3);
            _TabPage2.Size = new Size(461, 246);
            _TabPage2.TabIndex = 1;
            _TabPage2.Text = "Vector Polys";
            _TabPage2.UseVisualStyleBackColor = true;
            // 
            // lbTexture
            // 
            lbTexture.BackColor = SystemColors.Control;
            lbTexture.BorderStyle = BorderStyle.Fixed3D;
            lbTexture.Cursor = Cursors.Default;
            lbTexture.ForeColor = SystemColors.ControlText;
            lbTexture.Location = new Point(330, 24);
            lbTexture.Name = "lbTexture";
            lbTexture.RightToLeft = RightToLeft.No;
            lbTexture.Size = new Size(44, 20);
            lbTexture.TabIndex = 66;
            lbTexture.Text = "Label1";
            lbTexture.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmdColor
            // 
            _cmdColor.Location = new Point(276, 19);
            _cmdColor.Name = "_cmdColor";
            _cmdColor.Size = new Size(44, 25);
            _cmdColor.TabIndex = 65;
            _cmdColor.Text = "Color";
            _cmdColor.UseVisualStyleBackColor = true;
            // 
            // ckThisColor
            // 
            ckThisColor.BackColor = Color.Maroon;
            ckThisColor.CheckAlign = ContentAlignment.MiddleRight;
            ckThisColor.Location = new Point(380, 14);
            ckThisColor.Name = "ckThisColor";
            ckThisColor.Size = new Size(66, 30);
            ckThisColor.TabIndex = 64;
            ckThisColor.Text = "Use this Color";
            ckThisColor.TextAlign = ContentAlignment.MiddleCenter;
            ckThisColor.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(327, 11);
            Label1.Name = "Label1";
            Label1.Size = new Size(31, 13);
            Label1.TabIndex = 59;
            Label1.Text = "Type";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(223, 47);
            Label3.Name = "Label3";
            Label3.Size = new Size(192, 13);
            Label3.TabIndex = 58;
            Label3.Text = "Right click to copy GUID into Clipboard";
            Label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(7, 14);
            Label2.Name = "Label2";
            Label2.Size = new Size(128, 13);
            Label2.TabIndex = 57;
            Label2.Text = "Click to get larger window";
            // 
            // lbExclude
            // 
            _lbExclude.BackColor = SystemColors.Control;
            _lbExclude.BorderStyle = BorderStyle.Fixed3D;
            _lbExclude.Cursor = Cursors.Default;
            _lbExclude.ForeColor = SystemColors.ControlText;
            _lbExclude.Location = new Point(226, 211);
            _lbExclude.Name = "_lbExclude";
            _lbExclude.RightToLeft = RightToLeft.No;
            _lbExclude.Size = new Size(220, 20);
            _lbExclude.TabIndex = 56;
            _lbExclude.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbExcludeCaption
            // 
            lbExcludeCaption.AutoSize = true;
            lbExcludeCaption.BackColor = Color.Transparent;
            lbExcludeCaption.Cursor = Cursors.Default;
            lbExcludeCaption.ForeColor = SystemColors.ControlText;
            lbExcludeCaption.Location = new Point(223, 198);
            lbExcludeCaption.Name = "lbExcludeCaption";
            lbExcludeCaption.RightToLeft = RightToLeft.No;
            lbExcludeCaption.Size = new Size(175, 13);
            lbExcludeCaption.TabIndex = 55;
            lbExcludeCaption.Text = "Terrain to Exclude (click to change)";
            lbExcludeCaption.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmdDetail
            // 
            _cmdDetail.Location = new Point(226, 19);
            _cmdDetail.Name = "_cmdDetail";
            _cmdDetail.Size = new Size(44, 25);
            _cmdDetail.TabIndex = 54;
            _cmdDetail.Text = "Info";
            _cmdDetail.UseVisualStyleBackColor = true;
            // 
            // imgTexture
            // 
            _imgTexture.BorderStyle = BorderStyle.FixedSingle;
            _imgTexture.Cursor = Cursors.Default;
            _imgTexture.Location = new Point(10, 30);
            _imgTexture.Name = "_imgTexture";
            _imgTexture.Size = new Size(200, 200);
            _imgTexture.SizeMode = PictureBoxSizeMode.StretchImage;
            _imgTexture.TabIndex = 50;
            _imgTexture.TabStop = false;
            // 
            // List1
            // 
            _List1.BackColor = SystemColors.Window;
            _List1.Cursor = Cursors.Default;
            _List1.ForeColor = SystemColors.WindowText;
            _List1.Location = new Point(226, 61);
            _List1.Name = "_List1";
            _List1.RightToLeft = RightToLeft.No;
            _List1.Size = new Size(220, 134);
            _List1.TabIndex = 48;
            // 
            // TabPage3
            // 
            _TabPage3.BackColor = Color.Transparent;
            _TabPage3.Controls.Add(lbPolyColor);
            _TabPage3.Controls.Add(_cmdColor2);
            _TabPage3.Controls.Add(boxTiling);
            _TabPage3.Controls.Add(lbTexName);
            _TabPage3.Controls.Add(_imgTex);
            _TabPage3.Controls.Add(lbTex1);
            _TabPage3.Controls.Add(lbTexPri);
            _TabPage3.Controls.Add(LbV1);
            _TabPage3.Controls.Add(txtTexName);
            _TabPage3.Controls.Add(txtTexPri);
            _TabPage3.Controls.Add(_cmdTex);
            _TabPage3.Controls.Add(txtV1);
            _TabPage3.Controls.Add(ckNight);
            _TabPage3.Location = new Point(4, 22);
            _TabPage3.Name = "_TabPage3";
            _TabPage3.Padding = new Padding(3);
            _TabPage3.Size = new Size(461, 246);
            _TabPage3.TabIndex = 2;
            _TabPage3.Text = "Textured Polys";
            // 
            // lbPolyColor
            // 
            lbPolyColor.BackColor = Color.Silver;
            lbPolyColor.Location = new Point(355, 21);
            lbPolyColor.Name = "lbPolyColor";
            lbPolyColor.Size = new Size(91, 20);
            lbPolyColor.TabIndex = 89;
            lbPolyColor.Text = "Polygon Color";
            lbPolyColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cmdColor2
            // 
            _cmdColor2.Location = new Point(296, 19);
            _cmdColor2.Name = "_cmdColor2";
            _cmdColor2.Size = new Size(44, 25);
            _cmdColor2.TabIndex = 87;
            _cmdColor2.Text = "Color";
            _cmdColor2.UseVisualStyleBackColor = true;
            // 
            // boxTiling
            // 
            boxTiling.Controls.Add(lbTex4);
            boxTiling.Controls.Add(txtTexTileX);
            boxTiling.Controls.Add(lbTex5);
            boxTiling.Controls.Add(txtTexTileY);
            boxTiling.Location = new Point(226, 108);
            boxTiling.Name = "boxTiling";
            boxTiling.Size = new Size(147, 82);
            boxTiling.TabIndex = 86;
            boxTiling.TabStop = false;
            boxTiling.Text = "Texture Tiling";
            // 
            // lbTex4
            // 
            lbTex4.AutoSize = true;
            lbTex4.BackColor = Color.Transparent;
            lbTex4.Cursor = Cursors.Default;
            lbTex4.ForeColor = SystemColors.ControlText;
            lbTex4.Location = new Point(40, 25);
            lbTex4.Name = "lbTex4";
            lbTex4.RightToLeft = RightToLeft.No;
            lbTex4.Size = new Size(100, 13);
            lbTex4.TabIndex = 80;
            lbTex4.Text = "Horizontal Repetion";
            // 
            // txtTexTileX
            // 
            txtTexTileX.AcceptsReturn = true;
            txtTexTileX.BackColor = SystemColors.Window;
            txtTexTileX.Cursor = Cursors.IBeam;
            txtTexTileX.ForeColor = SystemColors.WindowText;
            txtTexTileX.Location = new Point(13, 22);
            txtTexTileX.MaxLength = 0;
            txtTexTileX.Name = "txtTexTileX";
            txtTexTileX.RightToLeft = RightToLeft.No;
            txtTexTileX.Size = new Size(22, 20);
            txtTexTileX.TabIndex = 74;
            txtTexTileX.Text = "1";
            txtTexTileX.TextAlign = HorizontalAlignment.Center;
            // 
            // lbTex5
            // 
            lbTex5.AutoSize = true;
            lbTex5.BackColor = Color.Transparent;
            lbTex5.Cursor = Cursors.Default;
            lbTex5.ForeColor = SystemColors.ControlText;
            lbTex5.Location = new Point(40, 53);
            lbTex5.Name = "lbTex5";
            lbTex5.RightToLeft = RightToLeft.No;
            lbTex5.Size = new Size(93, 13);
            lbTex5.TabIndex = 81;
            lbTex5.Text = "Vertical Repetition";
            // 
            // txtTexTileY
            // 
            txtTexTileY.AcceptsReturn = true;
            txtTexTileY.BackColor = SystemColors.Window;
            txtTexTileY.Cursor = Cursors.IBeam;
            txtTexTileY.ForeColor = SystemColors.WindowText;
            txtTexTileY.Location = new Point(13, 50);
            txtTexTileY.MaxLength = 0;
            txtTexTileY.Name = "txtTexTileY";
            txtTexTileY.RightToLeft = RightToLeft.No;
            txtTexTileY.Size = new Size(22, 20);
            txtTexTileY.TabIndex = 73;
            txtTexTileY.Text = "1";
            txtTexTileY.TextAlign = HorizontalAlignment.Center;
            // 
            // lbTexName
            // 
            lbTexName.AutoSize = true;
            lbTexName.Location = new Point(223, 51);
            lbTexName.Name = "lbTexName";
            lbTexName.Size = new Size(74, 13);
            lbTexName.TabIndex = 85;
            lbTexName.Text = "Texture Name";
            // 
            // imgTex
            // 
            _imgTex.BorderStyle = BorderStyle.FixedSingle;
            _imgTex.Cursor = Cursors.Default;
            _imgTex.Location = new Point(10, 30);
            _imgTex.Name = "_imgTex";
            _imgTex.Size = new Size(200, 200);
            _imgTex.SizeMode = PictureBoxSizeMode.StretchImage;
            _imgTex.TabIndex = 71;
            _imgTex.TabStop = false;
            // 
            // lbTex1
            // 
            lbTex1.AutoSize = true;
            lbTex1.BackColor = Color.Transparent;
            lbTex1.Cursor = Cursors.Default;
            lbTex1.ForeColor = SystemColors.ControlText;
            lbTex1.Location = new Point(7, 12);
            lbTex1.Name = "lbTex1";
            lbTex1.RightToLeft = RightToLeft.No;
            lbTex1.Size = new Size(172, 13);
            lbTex1.TabIndex = 77;
            lbTex1.Text = "Click on the picture to adjust points";
            // 
            // lbTexPri
            // 
            lbTexPri.AutoSize = true;
            lbTexPri.BackColor = Color.Transparent;
            lbTexPri.Cursor = Cursors.Default;
            lbTexPri.ForeColor = SystemColors.ControlText;
            lbTexPri.Location = new Point(369, 213);
            lbTexPri.Name = "lbTexPri";
            lbTexPri.RightToLeft = RightToLeft.No;
            lbTexPri.Size = new Size(41, 13);
            lbTexPri.TabIndex = 79;
            lbTexPri.Text = "Priority:";
            // 
            // LbV1
            // 
            LbV1.AutoSize = true;
            LbV1.BackColor = Color.Transparent;
            LbV1.Cursor = Cursors.Default;
            LbV1.ForeColor = SystemColors.ControlText;
            LbV1.Location = new Point(234, 213);
            LbV1.Name = "LbV1";
            LbV1.RightToLeft = RightToLeft.No;
            LbV1.Size = new Size(63, 13);
            LbV1.TabIndex = 83;
            LbV1.Text = "Visibility (m):";
            LbV1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtTexName
            // 
            txtTexName.AcceptsReturn = true;
            txtTexName.BackColor = SystemColors.Window;
            txtTexName.Cursor = Cursors.IBeam;
            txtTexName.ForeColor = SystemColors.WindowText;
            txtTexName.Location = new Point(226, 67);
            txtTexName.MaxLength = 0;
            txtTexName.Name = "txtTexName";
            txtTexName.RightToLeft = RightToLeft.No;
            txtTexName.Size = new Size(147, 20);
            txtTexName.TabIndex = 72;
            txtTexName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtTexPri
            // 
            txtTexPri.AcceptsReturn = true;
            txtTexPri.BackColor = SystemColors.Window;
            txtTexPri.Cursor = Cursors.IBeam;
            txtTexPri.ForeColor = SystemColors.WindowText;
            txtTexPri.Location = new Point(416, 210);
            txtTexPri.MaxLength = 0;
            txtTexPri.Name = "txtTexPri";
            txtTexPri.RightToLeft = RightToLeft.No;
            txtTexPri.Size = new Size(25, 20);
            txtTexPri.TabIndex = 75;
            txtTexPri.Text = "4";
            txtTexPri.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdTex
            // 
            _cmdTex.BackColor = SystemColors.Control;
            _cmdTex.Cursor = Cursors.Default;
            _cmdTex.ForeColor = SystemColors.ControlText;
            _cmdTex.Location = new Point(402, 62);
            _cmdTex.Name = "_cmdTex";
            _cmdTex.RightToLeft = RightToLeft.No;
            _cmdTex.Size = new Size(44, 25);
            _cmdTex.TabIndex = 76;
            _cmdTex.Text = "...";
            _cmdTex.UseVisualStyleBackColor = false;
            // 
            // txtV1
            // 
            txtV1.AcceptsReturn = true;
            txtV1.BackColor = SystemColors.Window;
            txtV1.Cursor = Cursors.IBeam;
            txtV1.ForeColor = SystemColors.WindowText;
            txtV1.Location = new Point(303, 210);
            txtV1.MaxLength = 0;
            txtV1.Name = "txtV1";
            txtV1.RightToLeft = RightToLeft.No;
            txtV1.Size = new Size(52, 20);
            txtV1.TabIndex = 82;
            txtV1.Text = "5000";
            txtV1.TextAlign = HorizontalAlignment.Center;
            // 
            // ckNight
            // 
            ckNight.BackColor = Color.Transparent;
            ckNight.Cursor = Cursors.Default;
            ckNight.ForeColor = SystemColors.ControlText;
            ckNight.Location = new Point(387, 135);
            ckNight.Name = "ckNight";
            ckNight.RightToLeft = RightToLeft.No;
            ckNight.Size = new Size(54, 39);
            ckNight.TabIndex = 84;
            ckNight.Text = "Night Map";
            ckNight.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(344, 290);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(62, 25);
            _cmdCancel.TabIndex = 21;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(420, 290);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(62, 25);
            _cmdOK.TabIndex = 20;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // cmdSmooth
            // 
            _cmdSmooth.Location = new Point(17, 290);
            _cmdSmooth.Name = "_cmdSmooth";
            _cmdSmooth.Size = new Size(62, 25);
            _cmdSmooth.TabIndex = 35;
            _cmdSmooth.Text = "Smooth";
            _cmdSmooth.UseVisualStyleBackColor = true;
            // 
            // cmdSample
            // 
            _cmdSample.Location = new Point(98, 290);
            _cmdSample.Name = "_cmdSample";
            _cmdSample.Size = new Size(62, 25);
            _cmdSample.TabIndex = 36;
            _cmdSample.Text = "Sample";
            _cmdSample.UseVisualStyleBackColor = true;
            // 
            // FrmPolysP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 327);
            Controls.Add(_cmdSample);
            Controls.Add(_cmdSmooth);
            Controls.Add(_cmdCancel);
            Controls.Add(TabControl1);
            Controls.Add(_cmdOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPolysP";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Polygon Properties";
            TabControl1.ResumeLayout(false);
            TabPage1.ResumeLayout(false);
            TabPage1.PerformLayout();
            BoxOrder.ResumeLayout(false);
            BoxOrder.PerformLayout();
            boxType.ResumeLayout(false);
            boxType.PerformLayout();
            boxAltitude.ResumeLayout(false);
            boxAltitude.PerformLayout();
            boxSlope.ResumeLayout(false);
            boxSlope.PerformLayout();
            _TabPage2.ResumeLayout(false);
            _TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_imgTexture).EndInit();
            _TabPage3.ResumeLayout(false);
            _TabPage3.PerformLayout();
            boxTiling.ResumeLayout(false);
            boxTiling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_imgTex).EndInit();
            Load += new EventHandler(FrmPolysP_Load);
            ResumeLayout(false);
        }

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

        internal Label Label3;
        internal Label Label2;
        private Label _lbExclude;

        public Label lbExclude
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbExclude;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbExclude != null)
                {
                    _lbExclude.Click -= LbExclude_Click;
                }

                _lbExclude = value;
                if (_lbExclude != null)
                {
                    _lbExclude.Click += LbExclude_Click;
                }
            }
        }

        public Label lbExcludeCaption;
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

        private PictureBox _imgTexture;

        public PictureBox imgTexture
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgTexture;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgTexture != null)
                {
                    _imgTexture.Click -= ImgTexture_Click;
                }

                _imgTexture = value;
                if (_imgTexture != null)
                {
                    _imgTexture.Click += ImgTexture_Click;
                }
            }
        }

        private ListBox _List1;

        public ListBox List1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _List1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_List1 != null)
                {
                    _List1.MouseDown -= List1_MouseDown;
                    _List1.SelectedIndexChanged -= List1_SelectedIndexChanged;
                }

                _List1 = value;
                if (_List1 != null)
                {
                    _List1.MouseDown += List1_MouseDown;
                    _List1.SelectedIndexChanged += List1_SelectedIndexChanged;
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

        internal GroupBox boxSlope;
        public TextBox txtHead;
        public TextBox txtAlt0;
        private Button _cmdHelpSlope;

        public Button cmdHelpSlope
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdHelpSlope;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdHelpSlope != null)
                {
                    _cmdHelpSlope.Click -= CmdHelpSlope_Click;
                }

                _cmdHelpSlope = value;
                if (_cmdHelpSlope != null)
                {
                    _cmdHelpSlope.Click += CmdHelpSlope_Click;
                }
            }
        }

        private Button _cmdSlope;

        public Button cmdSlope
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSlope;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSlope != null)
                {
                    _cmdSlope.Click -= CmdSlope_Click;
                }

                _cmdSlope = value;
                if (_cmdSlope != null)
                {
                    _cmdSlope.Click += CmdSlope_Click;
                }
            }
        }

        public TextBox txtSlope;
        internal Label Label8;
        internal Label Label6;
        public Label Label4;
        internal Label Label5;
        public TextBox txtPt0;
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

        internal TextBox txtName;
        internal Label lbName;
        internal Label lbSY;
        internal Label lbSX;
        internal GroupBox boxType;
        public Label lbOrder;
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

        internal GroupBox BoxOrder;
        private Button _cmdUP;

        public Button cmdUP
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUP;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUP != null)
                {
                    _cmdUP.Click -= CmdUP_Click;
                }

                _cmdUP = value;
                if (_cmdUP != null)
                {
                    _cmdUP.Click += CmdUP_Click;
                }
            }
        }

        private Button _cmdBottom;

        public Button cmdBottom
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdBottom;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdBottom != null)
                {
                    _cmdBottom.Click -= CmdBottom_Click;
                }

                _cmdBottom = value;
                if (_cmdBottom != null)
                {
                    _cmdBottom.Click += CmdBottom_Click;
                }
            }
        }

        private Button _cmdTop;

        public Button cmdTop
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdTop;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdTop != null)
                {
                    _cmdTop.Click -= CmdTop_Click;
                }

                _cmdTop = value;
                if (_cmdTop != null)
                {
                    _cmdTop.Click += CmdTop_Click;
                }
            }
        }

        private Button _cmdDown;

        public Button cmdDown
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDown;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDown != null)
                {
                    _cmdDown.Click -= CmdDown_Click;
                }

                _cmdDown = value;
                if (_cmdDown != null)
                {
                    _cmdDown.Click += CmdDown_Click;
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

        private PictureBox _imgTex;

        public PictureBox imgTex
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgTex;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgTex != null)
                {
                    _imgTex.Click -= ImgTex_Click;
                }

                _imgTex = value;
                if (_imgTex != null)
                {
                    _imgTex.Click += ImgTex_Click;
                }
            }
        }

        public Label lbTex1;
        public Label lbTexPri;
        public Label lbTex4;
        public Label lbTex5;
        public Label LbV1;
        public TextBox txtTexName;
        public TextBox txtTexTileY;
        public TextBox txtTexTileX;
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
        internal Label Label1;
        internal Label lbTexName;
        internal GroupBox boxTiling;
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

        internal CheckBox ckThisColor;
        private Button _cmdColor2;

        internal Button cmdColor2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdColor2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdColor2 != null)
                {
                    _cmdColor2.Click -= CmdColor2_Click;
                }

                _cmdColor2 = value;
                if (_cmdColor2 != null)
                {
                    _cmdColor2.Click += CmdColor2_Click;
                }
            }
        }

        internal Label lbPolyColor;
        public Label lbTexture;
    }
}