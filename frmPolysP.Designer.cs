using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPolysP));
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.BoxOrder = new System.Windows.Forms.GroupBox();
            this._cmdBottom = new System.Windows.Forms.Button();
            this._cmdTop = new System.Windows.Forms.Button();
            this._cmdDown = new System.Windows.Forms.Button();
            this._cmdUP = new System.Windows.Forms.Button();
            this.lbOrder = new System.Windows.Forms.Label();
            this.boxType = new System.Windows.Forms.GroupBox();
            this._cmdType = new System.Windows.Forms.Button();
            this._optTexture = new System.Windows.Forms.RadioButton();
            this._optVector = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.boxAltitude = new System.Windows.Forms.GroupBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this._cmdAlt = new System.Windows.Forms.Button();
            this.boxSlope = new System.Windows.Forms.GroupBox();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txtAlt0 = new System.Windows.Forms.TextBox();
            this._cmdHelpSlope = new System.Windows.Forms.Button();
            this._cmdSlope = new System.Windows.Forms.Button();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.lbSY = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lbSX = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtPt0 = new System.Windows.Forms.TextBox();
            this._TabPage2 = new System.Windows.Forms.TabPage();
            this.lbTexture = new System.Windows.Forms.Label();
            this._cmdColor = new System.Windows.Forms.Button();
            this.ckThisColor = new System.Windows.Forms.CheckBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._lbExclude = new System.Windows.Forms.Label();
            this.lbExcludeCaption = new System.Windows.Forms.Label();
            this._cmdDetail = new System.Windows.Forms.Button();
            this._imgTexture = new System.Windows.Forms.PictureBox();
            this._List1 = new System.Windows.Forms.ListBox();
            this._TabPage3 = new System.Windows.Forms.TabPage();
            this.lbPolyColor = new System.Windows.Forms.Label();
            this._cmdColor2 = new System.Windows.Forms.Button();
            this.boxTiling = new System.Windows.Forms.GroupBox();
            this.lbTex4 = new System.Windows.Forms.Label();
            this.txtTexTileX = new System.Windows.Forms.TextBox();
            this.lbTex5 = new System.Windows.Forms.Label();
            this.txtTexTileY = new System.Windows.Forms.TextBox();
            this.lbTexName = new System.Windows.Forms.Label();
            this._imgTex = new System.Windows.Forms.PictureBox();
            this.lbTex1 = new System.Windows.Forms.Label();
            this.lbTexPri = new System.Windows.Forms.Label();
            this.LbV1 = new System.Windows.Forms.Label();
            this.txtTexName = new System.Windows.Forms.TextBox();
            this.txtTexPri = new System.Windows.Forms.TextBox();
            this._cmdTex = new System.Windows.Forms.Button();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.ckNight = new System.Windows.Forms.CheckBox();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdSmooth = new System.Windows.Forms.Button();
            this._cmdSample = new System.Windows.Forms.Button();
            this.TabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.BoxOrder.SuspendLayout();
            this.boxType.SuspendLayout();
            this.boxAltitude.SuspendLayout();
            this.boxSlope.SuspendLayout();
            this._TabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgTexture)).BeginInit();
            this._TabPage3.SuspendLayout();
            this.boxTiling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgTex)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.TabPage1);
            this.TabControl1.Controls.Add(this._TabPage2);
            this.TabControl1.Controls.Add(this._TabPage3);
            this.TabControl1.Location = new System.Drawing.Point(17, 12);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(469, 272);
            this.TabControl1.TabIndex = 34;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.BoxOrder);
            this.TabPage1.Controls.Add(this.boxType);
            this.TabPage1.Controls.Add(this.txtName);
            this.TabPage1.Controls.Add(this.lbName);
            this.TabPage1.Controls.Add(this.boxAltitude);
            this.TabPage1.Controls.Add(this.boxSlope);
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(461, 246);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "General";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // BoxOrder
            // 
            this.BoxOrder.Controls.Add(this._cmdBottom);
            this.BoxOrder.Controls.Add(this._cmdTop);
            this.BoxOrder.Controls.Add(this._cmdDown);
            this.BoxOrder.Controls.Add(this._cmdUP);
            this.BoxOrder.Controls.Add(this.lbOrder);
            this.BoxOrder.Location = new System.Drawing.Point(18, 66);
            this.BoxOrder.Name = "BoxOrder";
            this.BoxOrder.Size = new System.Drawing.Size(171, 78);
            this.BoxOrder.TabIndex = 66;
            this.BoxOrder.TabStop = false;
            this.BoxOrder.Text = "Drawing order";
            // 
            // _cmdBottom
            // 
            this._cmdBottom.BackColor = System.Drawing.SystemColors.Control;
            this._cmdBottom.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdBottom.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdBottom.Image = ((System.Drawing.Image)(resources.GetObject("_cmdBottom.Image")));
            this._cmdBottom.Location = new System.Drawing.Point(136, 41);
            this._cmdBottom.Name = "_cmdBottom";
            this._cmdBottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdBottom.Size = new System.Drawing.Size(25, 25);
            this._cmdBottom.TabIndex = 18;
            this._cmdBottom.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdBottom.UseVisualStyleBackColor = false;
            this._cmdBottom.Click += new System.EventHandler(this.CmdBottom_Click);
            // 
            // _cmdTop
            // 
            this._cmdTop.BackColor = System.Drawing.SystemColors.Control;
            this._cmdTop.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdTop.Image = ((System.Drawing.Image)(resources.GetObject("_cmdTop.Image")));
            this._cmdTop.Location = new System.Drawing.Point(96, 41);
            this._cmdTop.Name = "_cmdTop";
            this._cmdTop.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdTop.Size = new System.Drawing.Size(25, 25);
            this._cmdTop.TabIndex = 17;
            this._cmdTop.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdTop.UseVisualStyleBackColor = false;
            this._cmdTop.Click += new System.EventHandler(this.CmdTop_Click);
            // 
            // _cmdDown
            // 
            this._cmdDown.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDown.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDown.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDown.Image")));
            this._cmdDown.Location = new System.Drawing.Point(57, 41);
            this._cmdDown.Name = "_cmdDown";
            this._cmdDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDown.Size = new System.Drawing.Size(25, 25);
            this._cmdDown.TabIndex = 16;
            this._cmdDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDown.UseVisualStyleBackColor = false;
            this._cmdDown.Click += new System.EventHandler(this.CmdDown_Click);
            // 
            // _cmdUP
            // 
            this._cmdUP.BackColor = System.Drawing.SystemColors.Control;
            this._cmdUP.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdUP.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUP.Image = ((System.Drawing.Image)(resources.GetObject("_cmdUP.Image")));
            this._cmdUP.Location = new System.Drawing.Point(18, 41);
            this._cmdUP.Name = "_cmdUP";
            this._cmdUP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdUP.Size = new System.Drawing.Size(25, 25);
            this._cmdUP.TabIndex = 2;
            this._cmdUP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdUP.UseVisualStyleBackColor = false;
            this._cmdUP.Click += new System.EventHandler(this.CmdUP_Click);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbOrder.Location = new System.Drawing.Point(42, 19);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbOrder.Size = new System.Drawing.Size(41, 13);
            this.lbOrder.TabIndex = 34;
            this.lbOrder.Text = "lbOrder";
            // 
            // boxType
            // 
            this.boxType.Controls.Add(this._cmdType);
            this.boxType.Controls.Add(this._optTexture);
            this.boxType.Controls.Add(this._optVector);
            this.boxType.Location = new System.Drawing.Point(18, 160);
            this.boxType.Name = "boxType";
            this.boxType.Size = new System.Drawing.Size(171, 73);
            this.boxType.TabIndex = 64;
            this.boxType.TabStop = false;
            this.boxType.Text = "Polygon type";
            // 
            // _cmdType
            // 
            this._cmdType.Location = new System.Drawing.Point(112, 25);
            this._cmdType.Name = "_cmdType";
            this._cmdType.Size = new System.Drawing.Size(47, 24);
            this._cmdType.TabIndex = 2;
            this._cmdType.Text = ">>>";
            this._cmdType.UseVisualStyleBackColor = true;
            this._cmdType.Click += new System.EventHandler(this.CmdType_Click);
            // 
            // _optTexture
            // 
            this._optTexture.AutoSize = true;
            this._optTexture.Location = new System.Drawing.Point(17, 43);
            this._optTexture.Name = "_optTexture";
            this._optTexture.Size = new System.Drawing.Size(90, 17);
            this._optTexture.TabIndex = 1;
            this._optTexture.TabStop = true;
            this._optTexture.Text = "Textured Poly";
            this._optTexture.UseVisualStyleBackColor = true;
            this._optTexture.CheckedChanged += new System.EventHandler(this.OptTexture_CheckedChanged);
            // 
            // _optVector
            // 
            this._optVector.AutoSize = true;
            this._optVector.Location = new System.Drawing.Point(17, 18);
            this._optVector.Name = "_optVector";
            this._optVector.Size = new System.Drawing.Size(79, 17);
            this._optVector.TabIndex = 0;
            this._optVector.TabStop = true;
            this._optVector.Text = "Vector Poly";
            this._optVector.UseVisualStyleBackColor = true;
            this._optVector.CheckedChanged += new System.EventHandler(this.OptVector_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(18, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(232, 20);
            this.txtName.TabIndex = 61;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(15, 14);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 62;
            this.lbName.Text = "Name";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // boxAltitude
            // 
            this.boxAltitude.Controls.Add(this.txtAlt);
            this.boxAltitude.Controls.Add(this._cmdAlt);
            this.boxAltitude.Location = new System.Drawing.Point(271, 14);
            this.boxAltitude.Name = "boxAltitude";
            this.boxAltitude.Size = new System.Drawing.Size(171, 58);
            this.boxAltitude.TabIndex = 57;
            this.boxAltitude.TabStop = false;
            this.boxAltitude.Text = "Constant altitude";
            // 
            // txtAlt
            // 
            this.txtAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlt.Location = new System.Drawing.Point(16, 24);
            this.txtAlt.MaxLength = 0;
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlt.Size = new System.Drawing.Size(70, 20);
            this.txtAlt.TabIndex = 29;
            this.txtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdAlt
            // 
            this._cmdAlt.BackColor = System.Drawing.SystemColors.Control;
            this._cmdAlt.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAlt.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAlt.Location = new System.Drawing.Point(110, 19);
            this._cmdAlt.Name = "_cmdAlt";
            this._cmdAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAlt.Size = new System.Drawing.Size(44, 25);
            this._cmdAlt.TabIndex = 28;
            this._cmdAlt.Text = "Set";
            this._cmdAlt.UseVisualStyleBackColor = false;
            this._cmdAlt.Click += new System.EventHandler(this.CmdAlt_Click);
            // 
            // boxSlope
            // 
            this.boxSlope.Controls.Add(this.txtHead);
            this.boxSlope.Controls.Add(this.txtAlt0);
            this.boxSlope.Controls.Add(this._cmdHelpSlope);
            this.boxSlope.Controls.Add(this._cmdSlope);
            this.boxSlope.Controls.Add(this.txtSlope);
            this.boxSlope.Controls.Add(this.lbSY);
            this.boxSlope.Controls.Add(this.Label8);
            this.boxSlope.Controls.Add(this.lbSX);
            this.boxSlope.Controls.Add(this.Label6);
            this.boxSlope.Controls.Add(this.Label4);
            this.boxSlope.Controls.Add(this.Label5);
            this.boxSlope.Controls.Add(this.txtPt0);
            this.boxSlope.Location = new System.Drawing.Point(209, 88);
            this.boxSlope.Name = "boxSlope";
            this.boxSlope.Size = new System.Drawing.Size(233, 145);
            this.boxSlope.TabIndex = 56;
            this.boxSlope.TabStop = false;
            this.boxSlope.Text = "Variable Altitude";
            // 
            // txtHead
            // 
            this.txtHead.BackColor = System.Drawing.SystemColors.Window;
            this.txtHead.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHead.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHead.Location = new System.Drawing.Point(77, 62);
            this.txtHead.MaxLength = 0;
            this.txtHead.Name = "txtHead";
            this.txtHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHead.Size = new System.Drawing.Size(71, 20);
            this.txtHead.TabIndex = 63;
            this.txtHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlt0
            // 
            this.txtAlt0.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlt0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlt0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlt0.Location = new System.Drawing.Point(18, 36);
            this.txtAlt0.MaxLength = 0;
            this.txtAlt0.Name = "txtAlt0";
            this.txtAlt0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlt0.Size = new System.Drawing.Size(90, 20);
            this.txtAlt0.TabIndex = 62;
            this.txtAlt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdHelpSlope
            // 
            this._cmdHelpSlope.BackColor = System.Drawing.SystemColors.Control;
            this._cmdHelpSlope.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdHelpSlope.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdHelpSlope.Location = new System.Drawing.Point(171, 36);
            this._cmdHelpSlope.Name = "_cmdHelpSlope";
            this._cmdHelpSlope.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdHelpSlope.Size = new System.Drawing.Size(44, 25);
            this._cmdHelpSlope.TabIndex = 61;
            this._cmdHelpSlope.Text = "Help";
            this._cmdHelpSlope.UseVisualStyleBackColor = false;
            this._cmdHelpSlope.Click += new System.EventHandler(this.CmdHelpSlope_Click);
            // 
            // _cmdSlope
            // 
            this._cmdSlope.BackColor = System.Drawing.SystemColors.Control;
            this._cmdSlope.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdSlope.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdSlope.Location = new System.Drawing.Point(171, 83);
            this._cmdSlope.Name = "_cmdSlope";
            this._cmdSlope.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdSlope.Size = new System.Drawing.Size(44, 25);
            this._cmdSlope.TabIndex = 60;
            this._cmdSlope.Text = "Set";
            this._cmdSlope.UseVisualStyleBackColor = false;
            this._cmdSlope.Click += new System.EventHandler(this.CmdSlope_Click);
            // 
            // txtSlope
            // 
            this.txtSlope.BackColor = System.Drawing.SystemColors.Window;
            this.txtSlope.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlope.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSlope.Location = new System.Drawing.Point(77, 88);
            this.txtSlope.MaxLength = 0;
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSlope.Size = new System.Drawing.Size(71, 20);
            this.txtSlope.TabIndex = 58;
            this.txtSlope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSY
            // 
            this.lbSY.AutoSize = true;
            this.lbSY.Location = new System.Drawing.Point(136, 119);
            this.lbSY.Name = "lbSY";
            this.lbSY.Size = new System.Drawing.Size(59, 13);
            this.lbSY.TabIndex = 59;
            this.lbSY.Text = "SlopeY = 0";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(40, 91);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(34, 13);
            this.Label8.TabIndex = 59;
            this.Label8.Text = "Slope";
            // 
            // lbSX
            // 
            this.lbSX.AutoSize = true;
            this.lbSX.Location = new System.Drawing.Point(15, 119);
            this.lbSX.Name = "lbSX";
            this.lbSX.Size = new System.Drawing.Size(59, 13);
            this.lbSX.TabIndex = 58;
            this.lbSX.Text = "SlopeX = 0";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(24, 65);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 13);
            this.Label6.TabIndex = 57;
            this.Label6.Text = "Heading";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(111, 21);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(27, 13);
            this.Label4.TabIndex = 56;
            this.Label4.Text = "Pt #";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(59, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(54, 13);
            this.Label5.TabIndex = 53;
            this.Label5.Text = "Altitude of";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPt0
            // 
            this.txtPt0.BackColor = System.Drawing.SystemColors.Window;
            this.txtPt0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPt0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPt0.Location = new System.Drawing.Point(114, 36);
            this.txtPt0.MaxLength = 0;
            this.txtPt0.Name = "txtPt0";
            this.txtPt0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPt0.Size = new System.Drawing.Size(34, 20);
            this.txtPt0.TabIndex = 52;
            this.txtPt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _TabPage2
            // 
            this._TabPage2.Controls.Add(this.lbTexture);
            this._TabPage2.Controls.Add(this._cmdColor);
            this._TabPage2.Controls.Add(this.ckThisColor);
            this._TabPage2.Controls.Add(this.Label1);
            this._TabPage2.Controls.Add(this.Label3);
            this._TabPage2.Controls.Add(this.Label2);
            this._TabPage2.Controls.Add(this._lbExclude);
            this._TabPage2.Controls.Add(this.lbExcludeCaption);
            this._TabPage2.Controls.Add(this._cmdDetail);
            this._TabPage2.Controls.Add(this._imgTexture);
            this._TabPage2.Controls.Add(this._List1);
            this._TabPage2.Location = new System.Drawing.Point(4, 22);
            this._TabPage2.Name = "_TabPage2";
            this._TabPage2.Padding = new System.Windows.Forms.Padding(3);
            this._TabPage2.Size = new System.Drawing.Size(461, 246);
            this._TabPage2.TabIndex = 1;
            this._TabPage2.Text = "Vector Polys";
            this._TabPage2.UseVisualStyleBackColor = true;
            this._TabPage2.Click += new System.EventHandler(this.TabPage2_Click);
            // 
            // lbTexture
            // 
            this.lbTexture.BackColor = System.Drawing.SystemColors.Control;
            this.lbTexture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTexture.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTexture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTexture.Location = new System.Drawing.Point(330, 24);
            this.lbTexture.Name = "lbTexture";
            this.lbTexture.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTexture.Size = new System.Drawing.Size(44, 20);
            this.lbTexture.TabIndex = 66;
            this.lbTexture.Text = "Label1";
            this.lbTexture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cmdColor
            // 
            this._cmdColor.Location = new System.Drawing.Point(276, 19);
            this._cmdColor.Name = "_cmdColor";
            this._cmdColor.Size = new System.Drawing.Size(44, 25);
            this._cmdColor.TabIndex = 65;
            this._cmdColor.Text = "Color";
            this._cmdColor.UseVisualStyleBackColor = true;
            this._cmdColor.Click += new System.EventHandler(this.CmdColor_Click);
            // 
            // ckThisColor
            // 
            this.ckThisColor.BackColor = System.Drawing.Color.Maroon;
            this.ckThisColor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckThisColor.Location = new System.Drawing.Point(380, 14);
            this.ckThisColor.Name = "ckThisColor";
            this.ckThisColor.Size = new System.Drawing.Size(66, 30);
            this.ckThisColor.TabIndex = 64;
            this.ckThisColor.Text = "Use this Color";
            this.ckThisColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ckThisColor.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(327, 11);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(31, 13);
            this.Label1.TabIndex = 59;
            this.Label1.Text = "Type";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(223, 47);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(192, 13);
            this.Label3.TabIndex = 58;
            this.Label3.Text = "Right click to copy GUID into Clipboard";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(7, 14);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(128, 13);
            this.Label2.TabIndex = 57;
            this.Label2.Text = "Click to get larger window";
            // 
            // _lbExclude
            // 
            this._lbExclude.BackColor = System.Drawing.SystemColors.Control;
            this._lbExclude.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lbExclude.Cursor = System.Windows.Forms.Cursors.Default;
            this._lbExclude.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lbExclude.Location = new System.Drawing.Point(226, 211);
            this._lbExclude.Name = "_lbExclude";
            this._lbExclude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lbExclude.Size = new System.Drawing.Size(220, 20);
            this._lbExclude.TabIndex = 56;
            this._lbExclude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lbExclude.Click += new System.EventHandler(this.LbExclude_Click);
            // 
            // lbExcludeCaption
            // 
            this.lbExcludeCaption.AutoSize = true;
            this.lbExcludeCaption.BackColor = System.Drawing.Color.Transparent;
            this.lbExcludeCaption.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbExcludeCaption.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbExcludeCaption.Location = new System.Drawing.Point(223, 198);
            this.lbExcludeCaption.Name = "lbExcludeCaption";
            this.lbExcludeCaption.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbExcludeCaption.Size = new System.Drawing.Size(175, 13);
            this.lbExcludeCaption.TabIndex = 55;
            this.lbExcludeCaption.Text = "Terrain to Exclude (click to change)";
            this.lbExcludeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _cmdDetail
            // 
            this._cmdDetail.Location = new System.Drawing.Point(226, 19);
            this._cmdDetail.Name = "_cmdDetail";
            this._cmdDetail.Size = new System.Drawing.Size(44, 25);
            this._cmdDetail.TabIndex = 54;
            this._cmdDetail.Text = "Info";
            this._cmdDetail.UseVisualStyleBackColor = true;
            this._cmdDetail.Click += new System.EventHandler(this.CmdDetail_Click);
            // 
            // _imgTexture
            // 
            this._imgTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgTexture.Cursor = System.Windows.Forms.Cursors.Default;
            this._imgTexture.Location = new System.Drawing.Point(10, 30);
            this._imgTexture.Name = "_imgTexture";
            this._imgTexture.Size = new System.Drawing.Size(200, 200);
            this._imgTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgTexture.TabIndex = 50;
            this._imgTexture.TabStop = false;
            this._imgTexture.Click += new System.EventHandler(this.ImgTexture_Click);
            // 
            // _List1
            // 
            this._List1.BackColor = System.Drawing.SystemColors.Window;
            this._List1.Cursor = System.Windows.Forms.Cursors.Default;
            this._List1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._List1.Location = new System.Drawing.Point(226, 61);
            this._List1.Name = "_List1";
            this._List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._List1.Size = new System.Drawing.Size(220, 134);
            this._List1.TabIndex = 48;
            this._List1.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged);
            this._List1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.List1_MouseDown);
            // 
            // _TabPage3
            // 
            this._TabPage3.BackColor = System.Drawing.Color.Transparent;
            this._TabPage3.Controls.Add(this.lbPolyColor);
            this._TabPage3.Controls.Add(this._cmdColor2);
            this._TabPage3.Controls.Add(this.boxTiling);
            this._TabPage3.Controls.Add(this.lbTexName);
            this._TabPage3.Controls.Add(this._imgTex);
            this._TabPage3.Controls.Add(this.lbTex1);
            this._TabPage3.Controls.Add(this.lbTexPri);
            this._TabPage3.Controls.Add(this.LbV1);
            this._TabPage3.Controls.Add(this.txtTexName);
            this._TabPage3.Controls.Add(this.txtTexPri);
            this._TabPage3.Controls.Add(this._cmdTex);
            this._TabPage3.Controls.Add(this.txtV1);
            this._TabPage3.Controls.Add(this.ckNight);
            this._TabPage3.Location = new System.Drawing.Point(4, 22);
            this._TabPage3.Name = "_TabPage3";
            this._TabPage3.Padding = new System.Windows.Forms.Padding(3);
            this._TabPage3.Size = new System.Drawing.Size(461, 246);
            this._TabPage3.TabIndex = 2;
            this._TabPage3.Text = "Textured Polys";
            this._TabPage3.Click += new System.EventHandler(this.TabPage3_Click);
            // 
            // lbPolyColor
            // 
            this.lbPolyColor.BackColor = System.Drawing.Color.Silver;
            this.lbPolyColor.Location = new System.Drawing.Point(355, 21);
            this.lbPolyColor.Name = "lbPolyColor";
            this.lbPolyColor.Size = new System.Drawing.Size(91, 20);
            this.lbPolyColor.TabIndex = 89;
            this.lbPolyColor.Text = "Polygon Color";
            this.lbPolyColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _cmdColor2
            // 
            this._cmdColor2.Location = new System.Drawing.Point(296, 19);
            this._cmdColor2.Name = "_cmdColor2";
            this._cmdColor2.Size = new System.Drawing.Size(44, 25);
            this._cmdColor2.TabIndex = 87;
            this._cmdColor2.Text = "Color";
            this._cmdColor2.UseVisualStyleBackColor = true;
            this._cmdColor2.Click += new System.EventHandler(this.CmdColor2_Click);
            // 
            // boxTiling
            // 
            this.boxTiling.Controls.Add(this.lbTex4);
            this.boxTiling.Controls.Add(this.txtTexTileX);
            this.boxTiling.Controls.Add(this.lbTex5);
            this.boxTiling.Controls.Add(this.txtTexTileY);
            this.boxTiling.Location = new System.Drawing.Point(226, 108);
            this.boxTiling.Name = "boxTiling";
            this.boxTiling.Size = new System.Drawing.Size(147, 82);
            this.boxTiling.TabIndex = 86;
            this.boxTiling.TabStop = false;
            this.boxTiling.Text = "Texture Tiling";
            // 
            // lbTex4
            // 
            this.lbTex4.AutoSize = true;
            this.lbTex4.BackColor = System.Drawing.Color.Transparent;
            this.lbTex4.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTex4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTex4.Location = new System.Drawing.Point(40, 25);
            this.lbTex4.Name = "lbTex4";
            this.lbTex4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTex4.Size = new System.Drawing.Size(100, 13);
            this.lbTex4.TabIndex = 80;
            this.lbTex4.Text = "Horizontal Repetion";
            // 
            // txtTexTileX
            // 
            this.txtTexTileX.AcceptsReturn = true;
            this.txtTexTileX.BackColor = System.Drawing.SystemColors.Window;
            this.txtTexTileX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTexTileX.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTexTileX.Location = new System.Drawing.Point(13, 22);
            this.txtTexTileX.MaxLength = 0;
            this.txtTexTileX.Name = "txtTexTileX";
            this.txtTexTileX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTexTileX.Size = new System.Drawing.Size(22, 20);
            this.txtTexTileX.TabIndex = 74;
            this.txtTexTileX.Text = "1";
            this.txtTexTileX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTex5
            // 
            this.lbTex5.AutoSize = true;
            this.lbTex5.BackColor = System.Drawing.Color.Transparent;
            this.lbTex5.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTex5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTex5.Location = new System.Drawing.Point(40, 53);
            this.lbTex5.Name = "lbTex5";
            this.lbTex5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTex5.Size = new System.Drawing.Size(93, 13);
            this.lbTex5.TabIndex = 81;
            this.lbTex5.Text = "Vertical Repetition";
            // 
            // txtTexTileY
            // 
            this.txtTexTileY.AcceptsReturn = true;
            this.txtTexTileY.BackColor = System.Drawing.SystemColors.Window;
            this.txtTexTileY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTexTileY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTexTileY.Location = new System.Drawing.Point(13, 50);
            this.txtTexTileY.MaxLength = 0;
            this.txtTexTileY.Name = "txtTexTileY";
            this.txtTexTileY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTexTileY.Size = new System.Drawing.Size(22, 20);
            this.txtTexTileY.TabIndex = 73;
            this.txtTexTileY.Text = "1";
            this.txtTexTileY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTexName
            // 
            this.lbTexName.AutoSize = true;
            this.lbTexName.Location = new System.Drawing.Point(223, 51);
            this.lbTexName.Name = "lbTexName";
            this.lbTexName.Size = new System.Drawing.Size(74, 13);
            this.lbTexName.TabIndex = 85;
            this.lbTexName.Text = "Texture Name";
            // 
            // _imgTex
            // 
            this._imgTex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgTex.Cursor = System.Windows.Forms.Cursors.Default;
            this._imgTex.Location = new System.Drawing.Point(10, 30);
            this._imgTex.Name = "_imgTex";
            this._imgTex.Size = new System.Drawing.Size(200, 200);
            this._imgTex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgTex.TabIndex = 71;
            this._imgTex.TabStop = false;
            this._imgTex.Click += new System.EventHandler(this.ImgTex_Click);
            // 
            // lbTex1
            // 
            this.lbTex1.AutoSize = true;
            this.lbTex1.BackColor = System.Drawing.Color.Transparent;
            this.lbTex1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTex1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTex1.Location = new System.Drawing.Point(7, 12);
            this.lbTex1.Name = "lbTex1";
            this.lbTex1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTex1.Size = new System.Drawing.Size(172, 13);
            this.lbTex1.TabIndex = 77;
            this.lbTex1.Text = "Click on the picture to adjust points";
            // 
            // lbTexPri
            // 
            this.lbTexPri.AutoSize = true;
            this.lbTexPri.BackColor = System.Drawing.Color.Transparent;
            this.lbTexPri.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbTexPri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTexPri.Location = new System.Drawing.Point(369, 213);
            this.lbTexPri.Name = "lbTexPri";
            this.lbTexPri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbTexPri.Size = new System.Drawing.Size(41, 13);
            this.lbTexPri.TabIndex = 79;
            this.lbTexPri.Text = "Priority:";
            // 
            // LbV1
            // 
            this.LbV1.AutoSize = true;
            this.LbV1.BackColor = System.Drawing.Color.Transparent;
            this.LbV1.Cursor = System.Windows.Forms.Cursors.Default;
            this.LbV1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LbV1.Location = new System.Drawing.Point(234, 213);
            this.LbV1.Name = "LbV1";
            this.LbV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LbV1.Size = new System.Drawing.Size(63, 13);
            this.LbV1.TabIndex = 83;
            this.LbV1.Text = "Visibility (m):";
            this.LbV1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTexName
            // 
            this.txtTexName.AcceptsReturn = true;
            this.txtTexName.BackColor = System.Drawing.SystemColors.Window;
            this.txtTexName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTexName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTexName.Location = new System.Drawing.Point(226, 67);
            this.txtTexName.MaxLength = 0;
            this.txtTexName.Name = "txtTexName";
            this.txtTexName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTexName.Size = new System.Drawing.Size(147, 20);
            this.txtTexName.TabIndex = 72;
            this.txtTexName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTexPri
            // 
            this.txtTexPri.AcceptsReturn = true;
            this.txtTexPri.BackColor = System.Drawing.SystemColors.Window;
            this.txtTexPri.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTexPri.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTexPri.Location = new System.Drawing.Point(416, 210);
            this.txtTexPri.MaxLength = 0;
            this.txtTexPri.Name = "txtTexPri";
            this.txtTexPri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTexPri.Size = new System.Drawing.Size(25, 20);
            this.txtTexPri.TabIndex = 75;
            this.txtTexPri.Text = "4";
            this.txtTexPri.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdTex
            // 
            this._cmdTex.BackColor = System.Drawing.SystemColors.Control;
            this._cmdTex.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdTex.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdTex.Location = new System.Drawing.Point(402, 62);
            this._cmdTex.Name = "_cmdTex";
            this._cmdTex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdTex.Size = new System.Drawing.Size(44, 25);
            this._cmdTex.TabIndex = 76;
            this._cmdTex.Text = "...";
            this._cmdTex.UseVisualStyleBackColor = false;
            this._cmdTex.Click += new System.EventHandler(this.CmdTex_Click);
            // 
            // txtV1
            // 
            this.txtV1.AcceptsReturn = true;
            this.txtV1.BackColor = System.Drawing.SystemColors.Window;
            this.txtV1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtV1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtV1.Location = new System.Drawing.Point(303, 210);
            this.txtV1.MaxLength = 0;
            this.txtV1.Name = "txtV1";
            this.txtV1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtV1.Size = new System.Drawing.Size(52, 20);
            this.txtV1.TabIndex = 82;
            this.txtV1.Text = "5000";
            this.txtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ckNight
            // 
            this.ckNight.BackColor = System.Drawing.Color.Transparent;
            this.ckNight.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckNight.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckNight.Location = new System.Drawing.Point(387, 135);
            this.ckNight.Name = "ckNight";
            this.ckNight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckNight.Size = new System.Drawing.Size(54, 39);
            this.ckNight.TabIndex = 84;
            this.ckNight.Text = "Night Map";
            this.ckNight.UseVisualStyleBackColor = false;
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(344, 290);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(62, 25);
            this._cmdCancel.TabIndex = 21;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(420, 290);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(62, 25);
            this._cmdOK.TabIndex = 20;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdSmooth
            // 
            this._cmdSmooth.Location = new System.Drawing.Point(17, 290);
            this._cmdSmooth.Name = "_cmdSmooth";
            this._cmdSmooth.Size = new System.Drawing.Size(62, 25);
            this._cmdSmooth.TabIndex = 35;
            this._cmdSmooth.Text = "Smooth";
            this._cmdSmooth.UseVisualStyleBackColor = true;
            this._cmdSmooth.Click += new System.EventHandler(this.CmdSmooth_Click);
            // 
            // _cmdSample
            // 
            this._cmdSample.Location = new System.Drawing.Point(98, 290);
            this._cmdSample.Name = "_cmdSample";
            this._cmdSample.Size = new System.Drawing.Size(62, 25);
            this._cmdSample.TabIndex = 36;
            this._cmdSample.Text = "Sample";
            this._cmdSample.UseVisualStyleBackColor = true;
            this._cmdSample.Click += new System.EventHandler(this.CmdSample_Click);
            // 
            // FrmPolysP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 327);
            this.Controls.Add(this._cmdSample);
            this.Controls.Add(this._cmdSmooth);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.TabControl1);
            this.Controls.Add(this._cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPolysP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Polygon Properties";
            this.Load += new System.EventHandler(this.FrmPolysP_Load);
            this.TabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.BoxOrder.ResumeLayout(false);
            this.BoxOrder.PerformLayout();
            this.boxType.ResumeLayout(false);
            this.boxType.PerformLayout();
            this.boxAltitude.ResumeLayout(false);
            this.boxAltitude.PerformLayout();
            this.boxSlope.ResumeLayout(false);
            this.boxSlope.PerformLayout();
            this._TabPage2.ResumeLayout(false);
            this._TabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgTexture)).EndInit();
            this._TabPage3.ResumeLayout(false);
            this._TabPage3.PerformLayout();
            this.boxTiling.ResumeLayout(false);
            this.boxTiling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgTex)).EndInit();
            this.ResumeLayout(false);

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