using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    public partial class FrmGBuilding : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            vertexBuffer.Dispose();
            vertexBuffer0.Dispose();
            renderDevice.Dispose();
            fntOut.Dispose();
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGBuilding));
            nUPsizeBottomY = new NumericUpDown();
            nUPsizeWindowY = new NumericUpDown();
            nUPsizeTopY = new NumericUpDown();
            nUPsizeRoofY = new NumericUpDown();
            nUPsizeTopX = new NumericUpDown();
            nUPsizeTopZ = new NumericUpDown();
            nUPtextureIndexBottomX = new NumericUpDown();
            nUPtextureIndexBottomZ = new NumericUpDown();
            nUPtextureIndexWindowX = new NumericUpDown();
            nUPtextureIndexWindowY = new NumericUpDown();
            nUPtextureIndexWindowZ = new NumericUpDown();
            nUPtextureIndexTopX = new NumericUpDown();
            nUPtextureIndexTopZ = new NumericUpDown();
            nUPtextureIndexRoofX = new NumericUpDown();
            nUPtextureIndexRoofY = new NumericUpDown();
            nUPtextureIndexRoofZ = new NumericUpDown();
            nUPbuildingSides = new NumericUpDown();
            ckSmoothing = new CheckBox();
            lbSides = new Label();
            lbG = new Label();
            lbF = new Label();
            nUPgableTexture = new NumericUpDown();
            nUPfaceTexture = new NumericUpDown();
            nUPtextureIndexGableY = new NumericUpDown();
            nUPtextureIndexFaceX = new NumericUpDown();
            nUPtextureIndexGableZ = new NumericUpDown();
            nUPtextureIndexFaceY = new NumericUpDown();
            _cmdCancel = new Button();
            _cmdCancel.MouseHover += new EventHandler(CmdCancel_MouseHover);
            cmdOK = new Button();
            lbgb3 = new Label();
            lbBW = new Label();
            lbBD = new Label();
            nUPsizeX = new NumericUpDown();
            nUPsizeZ = new NumericUpDown();
            nUPscale = new NumericUpDown();
            nUPtopTexture = new NumericUpDown();
            nUPbottomTexture = new NumericUpDown();
            nUProofTexture = new NumericUpDown();
            nUPwindowTexture = new NumericUpDown();
            _imgGenB = new PictureBox();
            _imgGenB.MouseDown += new MouseEventHandler(ImgGenB_MouseDown);
            _imgGenB.MouseHover += new EventHandler(ImgGenB_MouseHover);
            _imgGenB.MouseMove += new MouseEventHandler(ImgGenB_MouseMove);
            _imgGenB.MouseUp += new MouseEventHandler(ImgGenB_MouseUp);
            _imgGenB.MouseWheel += new MouseEventHandler(ImgGenB_MouseWheel);
            frGenB = new GroupBox();
            _optGbMultiSided = new RadioButton();
            _optGbMultiSided.CheckedChanged += new EventHandler(OptGbMultiSided_CheckedChanged);
            _optGbPyramidal = new RadioButton();
            _optGbPyramidal.CheckedChanged += new EventHandler(OptGbPyramidal_CheckedChanged);
            _optGbSlant = new RadioButton();
            _optGbSlant.CheckedChanged += new EventHandler(OptGbSlant_CheckedChanged);
            _optGbRidge = new RadioButton();
            _optGbRidge.CheckedChanged += new EventHandler(OptGbRidge_CheckedChanged);
            _optGbPeaked = new RadioButton();
            _optGbPeaked.CheckedChanged += new EventHandler(OptGbPeaked_CheckedChanged);
            _optGbFlat = new RadioButton();
            _optGbFlat.CheckedChanged += new EventHandler(OptGbFlat_CheckedChanged);
            frBottom = new GroupBox();
            lbBH = new Label();
            lbBT = new Label();
            Label40 = new Label();
            lbBZT = new Label();
            lbRH = new Label();
            Label31 = new Label();
            Label32 = new Label();
            Label34 = new Label();
            lbWZT = new Label();
            Label37 = new Label();
            Label38 = new Label();
            Label39 = new Label();
            frWindow = new GroupBox();
            nUPWZ = new NumericUpDown();
            nUPWX = new NumericUpDown();
            Label5 = new Label();
            Label1 = new Label();
            lbGYT = new Label();
            Label43 = new Label();
            Label44 = new Label();
            frTop = new GroupBox();
            Label45 = new Label();
            lbTZT = new Label();
            Label8 = new Label();
            lbTD = new Label();
            lbTW = new Label();
            lbGZT = new Label();
            frRoof = new GroupBox();
            nUPRZ = new NumericUpDown();
            nUPRX = new NumericUpDown();
            lbFYT = new Label();
            Label2 = new Label();
            Label3 = new Label();
            lbFXT = new Label();
            lbRYT = new Label();
            frMulti = new GroupBox();
            nUPGrid = new NumericUpDown();
            Label4 = new Label();
            Label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)nUPsizeBottomY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeWindowY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeTopY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeRoofY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeTopX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeTopZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexBottomX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexBottomZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexWindowX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexWindowY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexWindowZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexTopX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexTopZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexRoofX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexRoofY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexRoofZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPbuildingSides).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPgableTexture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPfaceTexture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexGableY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexFaceX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexGableZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexFaceY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPscale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPtopTexture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPbottomTexture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUProofTexture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPwindowTexture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_imgGenB).BeginInit();
            frGenB.SuspendLayout();
            frBottom.SuspendLayout();
            frWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUPWZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPWX).BeginInit();
            frTop.SuspendLayout();
            frRoof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUPRZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPRX).BeginInit();
            frMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nUPGrid).BeginInit();
            SuspendLayout();
            // 
            // nUPsizeBottomY
            // 
            nUPsizeBottomY.BackColor = SystemColors.Window;
            nUPsizeBottomY.Enabled = false;
            nUPsizeBottomY.Location = new Point(143, 37);
            nUPsizeBottomY.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPsizeBottomY.Name = "nUPsizeBottomY";
            nUPsizeBottomY.Size = new Size(53, 20);
            nUPsizeBottomY.TabIndex = 57;
            nUPsizeBottomY.TextAlign = HorizontalAlignment.Right;
            nUPsizeBottomY.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPsizeWindowY
            // 
            nUPsizeWindowY.BackColor = SystemColors.Window;
            nUPsizeWindowY.Enabled = false;
            nUPsizeWindowY.Location = new Point(143, 36);
            nUPsizeWindowY.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPsizeWindowY.Name = "nUPsizeWindowY";
            nUPsizeWindowY.Size = new Size(55, 20);
            nUPsizeWindowY.TabIndex = 57;
            nUPsizeWindowY.TextAlign = HorizontalAlignment.Right;
            nUPsizeWindowY.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPsizeTopY
            // 
            nUPsizeTopY.BackColor = SystemColors.Window;
            nUPsizeTopY.Enabled = false;
            nUPsizeTopY.Location = new Point(142, 37);
            nUPsizeTopY.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPsizeTopY.Name = "nUPsizeTopY";
            nUPsizeTopY.Size = new Size(55, 20);
            nUPsizeTopY.TabIndex = 57;
            nUPsizeTopY.TextAlign = HorizontalAlignment.Right;
            nUPsizeTopY.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPsizeRoofY
            // 
            nUPsizeRoofY.BackColor = SystemColors.Window;
            nUPsizeRoofY.Enabled = false;
            nUPsizeRoofY.Location = new Point(143, 37);
            nUPsizeRoofY.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPsizeRoofY.Name = "nUPsizeRoofY";
            nUPsizeRoofY.Size = new Size(55, 20);
            nUPsizeRoofY.TabIndex = 57;
            nUPsizeRoofY.TextAlign = HorizontalAlignment.Right;
            nUPsizeRoofY.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPsizeTopX
            // 
            nUPsizeTopX.BackColor = SystemColors.Window;
            nUPsizeTopX.DecimalPlaces = 2;
            nUPsizeTopX.Enabled = false;
            nUPsizeTopX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPsizeTopX.Location = new Point(74, 37);
            nUPsizeTopX.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPsizeTopX.Name = "nUPsizeTopX";
            nUPsizeTopX.Size = new Size(55, 20);
            nUPsizeTopX.TabIndex = 57;
            nUPsizeTopX.TextAlign = HorizontalAlignment.Right;
            nUPsizeTopX.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPsizeTopZ
            // 
            nUPsizeTopZ.BackColor = SystemColors.Window;
            nUPsizeTopZ.DecimalPlaces = 2;
            nUPsizeTopZ.Enabled = false;
            nUPsizeTopZ.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPsizeTopZ.Location = new Point(210, 37);
            nUPsizeTopZ.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPsizeTopZ.Name = "nUPsizeTopZ";
            nUPsizeTopZ.Size = new Size(55, 20);
            nUPsizeTopZ.TabIndex = 57;
            nUPsizeTopZ.TextAlign = HorizontalAlignment.Right;
            nUPsizeTopZ.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPtextureIndexBottomX
            // 
            nUPtextureIndexBottomX.BackColor = SystemColors.Window;
            nUPtextureIndexBottomX.DecimalPlaces = 3;
            nUPtextureIndexBottomX.Enabled = false;
            nUPtextureIndexBottomX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexBottomX.Location = new Point(73, 78);
            nUPtextureIndexBottomX.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexBottomX.Name = "nUPtextureIndexBottomX";
            nUPtextureIndexBottomX.Size = new Size(55, 20);
            nUPtextureIndexBottomX.TabIndex = 59;
            nUPtextureIndexBottomX.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexBottomX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexBottomZ
            // 
            nUPtextureIndexBottomZ.BackColor = SystemColors.Window;
            nUPtextureIndexBottomZ.DecimalPlaces = 3;
            nUPtextureIndexBottomZ.Enabled = false;
            nUPtextureIndexBottomZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexBottomZ.Location = new Point(210, 78);
            nUPtextureIndexBottomZ.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexBottomZ.Name = "nUPtextureIndexBottomZ";
            nUPtextureIndexBottomZ.Size = new Size(55, 20);
            nUPtextureIndexBottomZ.TabIndex = 59;
            nUPtextureIndexBottomZ.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexBottomZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexWindowX
            // 
            nUPtextureIndexWindowX.BackColor = SystemColors.Window;
            nUPtextureIndexWindowX.DecimalPlaces = 3;
            nUPtextureIndexWindowX.Enabled = false;
            nUPtextureIndexWindowX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexWindowX.Location = new Point(73, 78);
            nUPtextureIndexWindowX.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexWindowX.Name = "nUPtextureIndexWindowX";
            nUPtextureIndexWindowX.Size = new Size(55, 20);
            nUPtextureIndexWindowX.TabIndex = 59;
            nUPtextureIndexWindowX.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexWindowX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexWindowY
            // 
            nUPtextureIndexWindowY.BackColor = SystemColors.Window;
            nUPtextureIndexWindowY.DecimalPlaces = 3;
            nUPtextureIndexWindowY.Enabled = false;
            nUPtextureIndexWindowY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexWindowY.Location = new Point(143, 78);
            nUPtextureIndexWindowY.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexWindowY.Name = "nUPtextureIndexWindowY";
            nUPtextureIndexWindowY.Size = new Size(55, 20);
            nUPtextureIndexWindowY.TabIndex = 59;
            nUPtextureIndexWindowY.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexWindowY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexWindowZ
            // 
            nUPtextureIndexWindowZ.BackColor = SystemColors.Window;
            nUPtextureIndexWindowZ.DecimalPlaces = 3;
            nUPtextureIndexWindowZ.Enabled = false;
            nUPtextureIndexWindowZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexWindowZ.Location = new Point(214, 78);
            nUPtextureIndexWindowZ.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexWindowZ.Name = "nUPtextureIndexWindowZ";
            nUPtextureIndexWindowZ.Size = new Size(55, 20);
            nUPtextureIndexWindowZ.TabIndex = 59;
            nUPtextureIndexWindowZ.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexWindowZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexTopX
            // 
            nUPtextureIndexTopX.BackColor = SystemColors.Window;
            nUPtextureIndexTopX.DecimalPlaces = 3;
            nUPtextureIndexTopX.Enabled = false;
            nUPtextureIndexTopX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexTopX.Location = new Point(74, 78);
            nUPtextureIndexTopX.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexTopX.Name = "nUPtextureIndexTopX";
            nUPtextureIndexTopX.Size = new Size(55, 20);
            nUPtextureIndexTopX.TabIndex = 59;
            nUPtextureIndexTopX.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexTopX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexTopZ
            // 
            nUPtextureIndexTopZ.BackColor = SystemColors.Window;
            nUPtextureIndexTopZ.DecimalPlaces = 3;
            nUPtextureIndexTopZ.Enabled = false;
            nUPtextureIndexTopZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexTopZ.Location = new Point(212, 78);
            nUPtextureIndexTopZ.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexTopZ.Name = "nUPtextureIndexTopZ";
            nUPtextureIndexTopZ.Size = new Size(55, 20);
            nUPtextureIndexTopZ.TabIndex = 59;
            nUPtextureIndexTopZ.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexTopZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexRoofX
            // 
            nUPtextureIndexRoofX.BackColor = SystemColors.Window;
            nUPtextureIndexRoofX.DecimalPlaces = 3;
            nUPtextureIndexRoofX.Enabled = false;
            nUPtextureIndexRoofX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexRoofX.Location = new Point(75, 78);
            nUPtextureIndexRoofX.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexRoofX.Name = "nUPtextureIndexRoofX";
            nUPtextureIndexRoofX.Size = new Size(55, 20);
            nUPtextureIndexRoofX.TabIndex = 59;
            nUPtextureIndexRoofX.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexRoofX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexRoofY
            // 
            nUPtextureIndexRoofY.BackColor = SystemColors.Window;
            nUPtextureIndexRoofY.DecimalPlaces = 3;
            nUPtextureIndexRoofY.Enabled = false;
            nUPtextureIndexRoofY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexRoofY.Location = new Point(143, 78);
            nUPtextureIndexRoofY.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexRoofY.Name = "nUPtextureIndexRoofY";
            nUPtextureIndexRoofY.Size = new Size(55, 20);
            nUPtextureIndexRoofY.TabIndex = 59;
            nUPtextureIndexRoofY.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexRoofY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexRoofZ
            // 
            nUPtextureIndexRoofZ.BackColor = SystemColors.Window;
            nUPtextureIndexRoofZ.DecimalPlaces = 3;
            nUPtextureIndexRoofZ.Enabled = false;
            nUPtextureIndexRoofZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexRoofZ.Location = new Point(212, 78);
            nUPtextureIndexRoofZ.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexRoofZ.Name = "nUPtextureIndexRoofZ";
            nUPtextureIndexRoofZ.Size = new Size(55, 20);
            nUPtextureIndexRoofZ.TabIndex = 59;
            nUPtextureIndexRoofZ.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexRoofZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPbuildingSides
            // 
            nUPbuildingSides.BackColor = SystemColors.Window;
            nUPbuildingSides.Enabled = false;
            nUPbuildingSides.Location = new Point(138, 22);
            nUPbuildingSides.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            nUPbuildingSides.Minimum = new decimal(new int[] { 4, 0, 0, 0 });
            nUPbuildingSides.Name = "nUPbuildingSides";
            nUPbuildingSides.Size = new Size(40, 20);
            nUPbuildingSides.TabIndex = 59;
            nUPbuildingSides.TextAlign = HorizontalAlignment.Right;
            nUPbuildingSides.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // ckSmoothing
            // 
            ckSmoothing.AutoSize = true;
            ckSmoothing.Enabled = false;
            ckSmoothing.Location = new Point(12, 25);
            ckSmoothing.Name = "ckSmoothing";
            ckSmoothing.Size = new Size(76, 17);
            ckSmoothing.TabIndex = 60;
            ckSmoothing.Text = "Smoothing";
            ckSmoothing.UseVisualStyleBackColor = true;
            // 
            // lbSides
            // 
            lbSides.AutoSize = true;
            lbSides.Location = new Point(99, 27);
            lbSides.Name = "lbSides";
            lbSides.Size = new Size(33, 13);
            lbSides.TabIndex = 58;
            lbSides.Text = "Sides";
            // 
            // lbG
            // 
            lbG.AutoSize = true;
            lbG.Location = new Point(14, 104);
            lbG.Name = "lbG";
            lbG.Size = new Size(35, 13);
            lbG.TabIndex = 58;
            lbG.Text = "Gable";
            // 
            // lbF
            // 
            lbF.AutoSize = true;
            lbF.Location = new Point(13, 146);
            lbF.Name = "lbF";
            lbF.Size = new Size(31, 13);
            lbF.TabIndex = 58;
            lbF.Text = "Face";
            // 
            // nUPgableTexture
            // 
            nUPgableTexture.BackColor = SystemColors.Window;
            nUPgableTexture.Enabled = false;
            nUPgableTexture.Location = new Point(17, 120);
            nUPgableTexture.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPgableTexture.Name = "nUPgableTexture";
            nUPgableTexture.Size = new Size(46, 20);
            nUPgableTexture.TabIndex = 59;
            nUPgableTexture.TextAlign = HorizontalAlignment.Right;
            nUPgableTexture.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPfaceTexture
            // 
            nUPfaceTexture.BackColor = SystemColors.Window;
            nUPfaceTexture.Enabled = false;
            nUPfaceTexture.Location = new Point(17, 161);
            nUPfaceTexture.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPfaceTexture.Name = "nUPfaceTexture";
            nUPfaceTexture.Size = new Size(46, 20);
            nUPfaceTexture.TabIndex = 59;
            nUPfaceTexture.TextAlign = HorizontalAlignment.Right;
            nUPfaceTexture.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexGableY
            // 
            nUPtextureIndexGableY.BackColor = SystemColors.Window;
            nUPtextureIndexGableY.DecimalPlaces = 3;
            nUPtextureIndexGableY.Enabled = false;
            nUPtextureIndexGableY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexGableY.Location = new Point(143, 120);
            nUPtextureIndexGableY.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexGableY.Name = "nUPtextureIndexGableY";
            nUPtextureIndexGableY.Size = new Size(55, 20);
            nUPtextureIndexGableY.TabIndex = 59;
            nUPtextureIndexGableY.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexGableY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexFaceX
            // 
            nUPtextureIndexFaceX.BackColor = SystemColors.Window;
            nUPtextureIndexFaceX.DecimalPlaces = 3;
            nUPtextureIndexFaceX.Enabled = false;
            nUPtextureIndexFaceX.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexFaceX.Location = new Point(75, 162);
            nUPtextureIndexFaceX.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexFaceX.Name = "nUPtextureIndexFaceX";
            nUPtextureIndexFaceX.Size = new Size(55, 20);
            nUPtextureIndexFaceX.TabIndex = 59;
            nUPtextureIndexFaceX.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexFaceX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexGableZ
            // 
            nUPtextureIndexGableZ.BackColor = SystemColors.Window;
            nUPtextureIndexGableZ.DecimalPlaces = 3;
            nUPtextureIndexGableZ.Enabled = false;
            nUPtextureIndexGableZ.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexGableZ.Location = new Point(212, 122);
            nUPtextureIndexGableZ.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexGableZ.Name = "nUPtextureIndexGableZ";
            nUPtextureIndexGableZ.Size = new Size(55, 20);
            nUPtextureIndexGableZ.TabIndex = 59;
            nUPtextureIndexGableZ.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexGableZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtextureIndexFaceY
            // 
            nUPtextureIndexFaceY.BackColor = SystemColors.Window;
            nUPtextureIndexFaceY.DecimalPlaces = 3;
            nUPtextureIndexFaceY.Enabled = false;
            nUPtextureIndexFaceY.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPtextureIndexFaceY.Location = new Point(143, 162);
            nUPtextureIndexFaceY.Maximum = new decimal(new int[] { 9999, 0, 0, 131072 });
            nUPtextureIndexFaceY.Name = "nUPtextureIndexFaceY";
            nUPtextureIndexFaceY.Size = new Size(55, 20);
            nUPtextureIndexFaceY.TabIndex = 59;
            nUPtextureIndexFaceY.TextAlign = HorizontalAlignment.Right;
            nUPtextureIndexFaceY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(465, 505);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(59, 23);
            _cmdCancel.TabIndex = 61;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            cmdOK.Location = new Point(549, 505);
            cmdOK.Name = "cmdOK";
            cmdOK.Size = new Size(59, 23);
            cmdOK.TabIndex = 61;
            cmdOK.Text = "OK";
            cmdOK.UseVisualStyleBackColor = true;
            // 
            // lbgb3
            // 
            lbgb3.BackColor = Color.Transparent;
            lbgb3.Cursor = Cursors.Default;
            lbgb3.ForeColor = SystemColors.ControlText;
            lbgb3.Location = new Point(23, 99);
            lbgb3.Name = "lbgb3";
            lbgb3.RightToLeft = RightToLeft.No;
            lbgb3.Size = new Size(37, 18);
            lbgb3.TabIndex = 64;
            lbgb3.Text = "Scale";
            lbgb3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbBW
            // 
            lbBW.AutoSize = true;
            lbBW.Location = new Point(64, 22);
            lbBW.Name = "lbBW";
            lbBW.Size = new Size(45, 13);
            lbBW.TabIndex = 66;
            lbBW.Text = "Width X";
            // 
            // lbBD
            // 
            lbBD.AutoSize = true;
            lbBD.Location = new Point(207, 22);
            lbBD.Name = "lbBD";
            lbBD.Size = new Size(43, 13);
            lbBD.TabIndex = 67;
            lbBD.Text = "Deep Z";
            // 
            // nUPsizeX
            // 
            nUPsizeX.BackColor = SystemColors.Window;
            nUPsizeX.DecimalPlaces = 2;
            nUPsizeX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPsizeX.Location = new Point(73, 36);
            nUPsizeX.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPsizeX.Name = "nUPsizeX";
            nUPsizeX.Size = new Size(55, 20);
            nUPsizeX.TabIndex = 68;
            nUPsizeX.TextAlign = HorizontalAlignment.Right;
            nUPsizeX.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPsizeZ
            // 
            nUPsizeZ.BackColor = SystemColors.Window;
            nUPsizeZ.DecimalPlaces = 2;
            nUPsizeZ.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPsizeZ.Location = new Point(209, 38);
            nUPsizeZ.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPsizeZ.Name = "nUPsizeZ";
            nUPsizeZ.Size = new Size(55, 20);
            nUPsizeZ.TabIndex = 69;
            nUPsizeZ.TextAlign = HorizontalAlignment.Right;
            nUPsizeZ.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPscale
            // 
            nUPscale.BackColor = SystemColors.Window;
            nUPscale.DecimalPlaces = 2;
            nUPscale.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nUPscale.Location = new Point(26, 120);
            nUPscale.Name = "nUPscale";
            nUPscale.Size = new Size(50, 20);
            nUPscale.TabIndex = 70;
            nUPscale.TextAlign = HorizontalAlignment.Right;
            nUPscale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nUPtopTexture
            // 
            nUPtopTexture.BackColor = SystemColors.Window;
            nUPtopTexture.Location = new Point(15, 37);
            nUPtopTexture.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPtopTexture.Name = "nUPtopTexture";
            nUPtopTexture.Size = new Size(46, 20);
            nUPtopTexture.TabIndex = 53;
            nUPtopTexture.TextAlign = HorizontalAlignment.Right;
            nUPtopTexture.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // nUPbottomTexture
            // 
            nUPbottomTexture.BackColor = SystemColors.Window;
            nUPbottomTexture.Location = new Point(14, 36);
            nUPbottomTexture.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPbottomTexture.Name = "nUPbottomTexture";
            nUPbottomTexture.Size = new Size(46, 20);
            nUPbottomTexture.TabIndex = 53;
            nUPbottomTexture.TextAlign = HorizontalAlignment.Right;
            nUPbottomTexture.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // nUProofTexture
            // 
            nUProofTexture.BackColor = SystemColors.Window;
            nUProofTexture.Location = new Point(16, 37);
            nUProofTexture.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUProofTexture.Name = "nUProofTexture";
            nUProofTexture.Size = new Size(46, 20);
            nUProofTexture.TabIndex = 53;
            nUProofTexture.TextAlign = HorizontalAlignment.Right;
            nUProofTexture.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // nUPwindowTexture
            // 
            nUPwindowTexture.BackColor = SystemColors.Window;
            nUPwindowTexture.Location = new Point(12, 36);
            nUPwindowTexture.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nUPwindowTexture.Name = "nUPwindowTexture";
            nUPwindowTexture.Size = new Size(46, 20);
            nUPwindowTexture.TabIndex = 53;
            nUPwindowTexture.TextAlign = HorizontalAlignment.Right;
            nUPwindowTexture.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // imgGenB
            // 
            _imgGenB.BorderStyle = BorderStyle.FixedSingle;
            _imgGenB.Location = new Point(323, 238);
            _imgGenB.Name = "_imgGenB";
            _imgGenB.Size = new Size(286, 252);
            _imgGenB.TabIndex = 72;
            _imgGenB.TabStop = false;
            // 
            // frGenB
            // 
            frGenB.BackColor = Color.Transparent;
            frGenB.Controls.Add(_optGbMultiSided);
            frGenB.Controls.Add(_optGbPyramidal);
            frGenB.Controls.Add(_optGbSlant);
            frGenB.Controls.Add(_optGbRidge);
            frGenB.Controls.Add(_optGbPeaked);
            frGenB.Controls.Add(_optGbFlat);
            frGenB.ForeColor = SystemColors.MenuHighlight;
            frGenB.Location = new Point(22, 14);
            frGenB.Name = "frGenB";
            frGenB.RightToLeft = RightToLeft.No;
            frGenB.Size = new Size(282, 73);
            frGenB.TabIndex = 74;
            frGenB.TabStop = false;
            frGenB.Text = "Building Type";
            // 
            // optGbMultiSided
            // 
            _optGbMultiSided.AutoSize = true;
            _optGbMultiSided.ForeColor = Color.Black;
            _optGbMultiSided.Location = new Point(183, 42);
            _optGbMultiSided.Name = "_optGbMultiSided";
            _optGbMultiSided.Size = new Size(74, 17);
            _optGbMultiSided.TabIndex = 0;
            _optGbMultiSided.Text = "MultiSided";
            _optGbMultiSided.UseVisualStyleBackColor = true;
            // 
            // optGbPyramidal
            // 
            _optGbPyramidal.AutoSize = true;
            _optGbPyramidal.ForeColor = Color.Black;
            _optGbPyramidal.Location = new Point(183, 19);
            _optGbPyramidal.Name = "_optGbPyramidal";
            _optGbPyramidal.Size = new Size(70, 17);
            _optGbPyramidal.TabIndex = 0;
            _optGbPyramidal.Text = "Pyramidal";
            _optGbPyramidal.UseVisualStyleBackColor = true;
            // 
            // optGbSlant
            // 
            _optGbSlant.AutoSize = true;
            _optGbSlant.ForeColor = Color.Black;
            _optGbSlant.Location = new Point(109, 44);
            _optGbSlant.Name = "_optGbSlant";
            _optGbSlant.Size = new Size(49, 17);
            _optGbSlant.TabIndex = 0;
            _optGbSlant.Text = "Slant";
            _optGbSlant.UseVisualStyleBackColor = true;
            // 
            // optGbRidge
            // 
            _optGbRidge.AutoSize = true;
            _optGbRidge.ForeColor = Color.Black;
            _optGbRidge.Location = new Point(109, 21);
            _optGbRidge.Name = "_optGbRidge";
            _optGbRidge.Size = new Size(53, 17);
            _optGbRidge.TabIndex = 0;
            _optGbRidge.Text = "Ridge";
            _optGbRidge.UseVisualStyleBackColor = true;
            // 
            // optGbPeaked
            // 
            _optGbPeaked.AutoSize = true;
            _optGbPeaked.ForeColor = Color.Black;
            _optGbPeaked.Location = new Point(25, 44);
            _optGbPeaked.Name = "_optGbPeaked";
            _optGbPeaked.Size = new Size(62, 17);
            _optGbPeaked.TabIndex = 0;
            _optGbPeaked.Text = "Peaked";
            _optGbPeaked.UseVisualStyleBackColor = true;
            // 
            // optGbFlat
            // 
            _optGbFlat.AutoSize = true;
            _optGbFlat.ForeColor = Color.Black;
            _optGbFlat.Location = new Point(25, 21);
            _optGbFlat.Name = "_optGbFlat";
            _optGbFlat.Size = new Size(42, 17);
            _optGbFlat.TabIndex = 0;
            _optGbFlat.Text = "Flat";
            _optGbFlat.UseVisualStyleBackColor = true;
            // 
            // frBottom
            // 
            frBottom.Controls.Add(nUPsizeBottomY);
            frBottom.Controls.Add(lbBH);
            frBottom.Controls.Add(nUPbottomTexture);
            frBottom.Controls.Add(lbBT);
            frBottom.Controls.Add(nUPtextureIndexBottomX);
            frBottom.Controls.Add(Label40);
            frBottom.Controls.Add(lbBZT);
            frBottom.Controls.Add(nUPtextureIndexBottomZ);
            frBottom.Controls.Add(nUPsizeX);
            frBottom.Controls.Add(nUPsizeZ);
            frBottom.Controls.Add(lbBD);
            frBottom.Controls.Add(lbBW);
            frBottom.Location = new Point(22, 160);
            frBottom.Name = "frBottom";
            frBottom.Size = new Size(283, 113);
            frBottom.TabIndex = 75;
            frBottom.TabStop = false;
            frBottom.Text = "Bottom Section";
            // 
            // lbBH
            // 
            lbBH.AutoSize = true;
            lbBH.Location = new Point(137, 21);
            lbBH.Name = "lbBH";
            lbBH.Size = new Size(48, 13);
            lbBH.TabIndex = 76;
            lbBH.Text = "Height Y";
            // 
            // lbBT
            // 
            lbBT.AutoSize = true;
            lbBT.Location = new Point(11, 20);
            lbBT.Name = "lbBT";
            lbBT.Size = new Size(43, 13);
            lbBT.TabIndex = 76;
            lbBT.Text = "Texture";
            // 
            // Label40
            // 
            Label40.AutoSize = true;
            Label40.Location = new Point(67, 62);
            Label40.Name = "Label40";
            Label40.Size = new Size(42, 13);
            Label40.TabIndex = 76;
            Label40.Text = "X Tiling";
            // 
            // lbBZT
            // 
            lbBZT.AutoSize = true;
            lbBZT.Location = new Point(207, 62);
            lbBZT.Name = "lbBZT";
            lbBZT.Size = new Size(42, 13);
            lbBZT.TabIndex = 76;
            lbBZT.Text = "Z Tiling";
            // 
            // lbRH
            // 
            lbRH.AutoSize = true;
            lbRH.Location = new Point(140, 21);
            lbRH.Name = "lbRH";
            lbRH.Size = new Size(48, 13);
            lbRH.TabIndex = 76;
            lbRH.Text = "Height Y";
            // 
            // Label31
            // 
            Label31.AutoSize = true;
            Label31.Location = new Point(137, 20);
            Label31.Name = "Label31";
            Label31.Size = new Size(48, 13);
            Label31.TabIndex = 76;
            Label31.Text = "Height Y";
            // 
            // Label32
            // 
            Label32.AutoSize = true;
            Label32.Location = new Point(140, 21);
            Label32.Name = "Label32";
            Label32.Size = new Size(48, 13);
            Label32.TabIndex = 76;
            Label32.Text = "Height Y";
            // 
            // Label34
            // 
            Label34.AutoSize = true;
            Label34.Location = new Point(139, 61);
            Label34.Name = "Label34";
            Label34.Size = new Size(42, 13);
            Label34.TabIndex = 76;
            Label34.Text = "Y Tiling";
            // 
            // lbWZT
            // 
            lbWZT.AutoSize = true;
            lbWZT.Location = new Point(211, 62);
            lbWZT.Name = "lbWZT";
            lbWZT.Size = new Size(42, 13);
            lbWZT.TabIndex = 76;
            lbWZT.Text = "Z Tiling";
            // 
            // Label37
            // 
            Label37.AutoSize = true;
            Label37.Location = new Point(67, 62);
            Label37.Name = "Label37";
            Label37.Size = new Size(42, 13);
            Label37.TabIndex = 76;
            Label37.Text = "X Tiling";
            // 
            // Label38
            // 
            Label38.AutoSize = true;
            Label38.Location = new Point(11, 20);
            Label38.Name = "Label38";
            Label38.Size = new Size(43, 13);
            Label38.TabIndex = 76;
            Label38.Text = "Texture";
            // 
            // Label39
            // 
            Label39.AutoSize = true;
            Label39.Location = new Point(14, 21);
            Label39.Name = "Label39";
            Label39.Size = new Size(43, 13);
            Label39.TabIndex = 76;
            Label39.Text = "Texture";
            // 
            // frWindow
            // 
            frWindow.Controls.Add(nUPwindowTexture);
            frWindow.Controls.Add(Label38);
            frWindow.Controls.Add(Label31);
            frWindow.Controls.Add(nUPsizeWindowY);
            frWindow.Controls.Add(lbWZT);
            frWindow.Controls.Add(nUPtextureIndexWindowX);
            frWindow.Controls.Add(Label34);
            frWindow.Controls.Add(Label37);
            frWindow.Controls.Add(nUPWZ);
            frWindow.Controls.Add(nUPWX);
            frWindow.Controls.Add(Label5);
            frWindow.Controls.Add(nUPtextureIndexWindowZ);
            frWindow.Controls.Add(nUPtextureIndexWindowY);
            frWindow.Controls.Add(Label1);
            frWindow.Location = new Point(22, 289);
            frWindow.Name = "frWindow";
            frWindow.Size = new Size(283, 113);
            frWindow.TabIndex = 77;
            frWindow.TabStop = false;
            frWindow.Text = "Window Section";
            // 
            // nUPWZ
            // 
            nUPWZ.BackColor = SystemColors.Window;
            nUPWZ.DecimalPlaces = 2;
            nUPWZ.Enabled = false;
            nUPWZ.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPWZ.Location = new Point(213, 36);
            nUPWZ.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPWZ.Name = "nUPWZ";
            nUPWZ.Size = new Size(55, 20);
            nUPWZ.TabIndex = 68;
            nUPWZ.TextAlign = HorizontalAlignment.Right;
            nUPWZ.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPWX
            // 
            nUPWX.BackColor = SystemColors.Window;
            nUPWX.DecimalPlaces = 2;
            nUPWX.Enabled = false;
            nUPWX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPWX.Location = new Point(73, 36);
            nUPWX.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPWX.Name = "nUPWX";
            nUPWX.Size = new Size(55, 20);
            nUPWX.TabIndex = 68;
            nUPWX.TextAlign = HorizontalAlignment.Right;
            nUPWX.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.Enabled = false;
            Label5.Location = new Point(213, 20);
            Label5.Name = "Label5";
            Label5.Size = new Size(43, 13);
            Label5.TabIndex = 67;
            Label5.Text = "Deep Z";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Enabled = false;
            Label1.Location = new Point(67, 20);
            Label1.Name = "Label1";
            Label1.Size = new Size(45, 13);
            Label1.TabIndex = 66;
            Label1.Text = "Width X";
            // 
            // lbGYT
            // 
            lbGYT.AutoSize = true;
            lbGYT.Location = new Point(146, 104);
            lbGYT.Name = "lbGYT";
            lbGYT.Size = new Size(42, 13);
            lbGYT.TabIndex = 76;
            lbGYT.Text = "Y Tiling";
            // 
            // Label43
            // 
            Label43.AutoSize = true;
            Label43.Location = new Point(72, 62);
            Label43.Name = "Label43";
            Label43.Size = new Size(42, 13);
            Label43.TabIndex = 76;
            Label43.Text = "X Tiling";
            // 
            // Label44
            // 
            Label44.AutoSize = true;
            Label44.Location = new Point(213, 62);
            Label44.Name = "Label44";
            Label44.Size = new Size(42, 13);
            Label44.TabIndex = 76;
            Label44.Text = "Z Tiling";
            // 
            // frTop
            // 
            frTop.Controls.Add(nUPtopTexture);
            frTop.Controls.Add(nUPsizeTopY);
            frTop.Controls.Add(Label45);
            frTop.Controls.Add(Label32);
            frTop.Controls.Add(nUPtextureIndexTopX);
            frTop.Controls.Add(nUPtextureIndexTopZ);
            frTop.Controls.Add(lbTZT);
            frTop.Controls.Add(Label8);
            frTop.Controls.Add(lbTD);
            frTop.Controls.Add(nUPsizeTopZ);
            frTop.Controls.Add(nUPsizeTopX);
            frTop.Controls.Add(lbTW);
            frTop.Location = new Point(19, 415);
            frTop.Name = "frTop";
            frTop.Size = new Size(285, 113);
            frTop.TabIndex = 79;
            frTop.TabStop = false;
            frTop.Text = "Top Section";
            // 
            // Label45
            // 
            Label45.AutoSize = true;
            Label45.Location = new Point(12, 21);
            Label45.Name = "Label45";
            Label45.Size = new Size(43, 13);
            Label45.TabIndex = 76;
            Label45.Text = "Texture";
            // 
            // lbTZT
            // 
            lbTZT.AutoSize = true;
            lbTZT.Location = new Point(211, 62);
            lbTZT.Name = "lbTZT";
            lbTZT.Size = new Size(42, 13);
            lbTZT.TabIndex = 76;
            lbTZT.Text = "Z Tiling";
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(70, 62);
            Label8.Name = "Label8";
            Label8.Size = new Size(42, 13);
            Label8.TabIndex = 76;
            Label8.Text = "X Tiling";
            // 
            // lbTD
            // 
            lbTD.AutoSize = true;
            lbTD.Location = new Point(210, 22);
            lbTD.Name = "lbTD";
            lbTD.Size = new Size(43, 13);
            lbTD.TabIndex = 67;
            lbTD.Text = "Deep Z";
            // 
            // lbTW
            // 
            lbTW.AutoSize = true;
            lbTW.Location = new Point(70, 22);
            lbTW.Name = "lbTW";
            lbTW.Size = new Size(45, 13);
            lbTW.TabIndex = 66;
            lbTW.Text = "Width X";
            // 
            // lbGZT
            // 
            lbGZT.AutoSize = true;
            lbGZT.Location = new Point(212, 106);
            lbGZT.Name = "lbGZT";
            lbGZT.Size = new Size(42, 13);
            lbGZT.TabIndex = 76;
            lbGZT.Text = "Z Tiling";
            // 
            // frRoof
            // 
            frRoof.Controls.Add(nUProofTexture);
            frRoof.Controls.Add(Label39);
            frRoof.Controls.Add(nUPtextureIndexRoofX);
            frRoof.Controls.Add(nUPtextureIndexRoofZ);
            frRoof.Controls.Add(Label44);
            frRoof.Controls.Add(Label43);
            frRoof.Controls.Add(lbGZT);
            frRoof.Controls.Add(nUPsizeRoofY);
            frRoof.Controls.Add(nUPRZ);
            frRoof.Controls.Add(nUPRX);
            frRoof.Controls.Add(lbFYT);
            frRoof.Controls.Add(Label2);
            frRoof.Controls.Add(lbGYT);
            frRoof.Controls.Add(Label3);
            frRoof.Controls.Add(lbFXT);
            frRoof.Controls.Add(lbRH);
            frRoof.Controls.Add(lbRYT);
            frRoof.Controls.Add(nUPtextureIndexRoofY);
            frRoof.Controls.Add(nUPgableTexture);
            frRoof.Controls.Add(lbG);
            frRoof.Controls.Add(nUPfaceTexture);
            frRoof.Controls.Add(lbF);
            frRoof.Controls.Add(nUPtextureIndexFaceY);
            frRoof.Controls.Add(nUPtextureIndexFaceX);
            frRoof.Controls.Add(nUPtextureIndexGableY);
            frRoof.Controls.Add(nUPtextureIndexGableZ);
            frRoof.Location = new Point(323, 14);
            frRoof.Name = "frRoof";
            frRoof.Size = new Size(285, 196);
            frRoof.TabIndex = 80;
            frRoof.TabStop = false;
            frRoof.Text = "Roof Section";
            // 
            // nUPRZ
            // 
            nUPRZ.BackColor = SystemColors.Window;
            nUPRZ.DecimalPlaces = 2;
            nUPRZ.Enabled = false;
            nUPRZ.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPRZ.Location = new Point(211, 37);
            nUPRZ.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPRZ.Name = "nUPRZ";
            nUPRZ.Size = new Size(55, 20);
            nUPRZ.TabIndex = 68;
            nUPRZ.TextAlign = HorizontalAlignment.Right;
            nUPRZ.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // nUPRX
            // 
            nUPRX.BackColor = SystemColors.Window;
            nUPRX.DecimalPlaces = 2;
            nUPRX.Enabled = false;
            nUPRX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPRX.Location = new Point(75, 37);
            nUPRX.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPRX.Name = "nUPRX";
            nUPRX.Size = new Size(55, 20);
            nUPRX.TabIndex = 68;
            nUPRX.TextAlign = HorizontalAlignment.Right;
            nUPRX.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // lbFYT
            // 
            lbFYT.AutoSize = true;
            lbFYT.Location = new Point(144, 146);
            lbFYT.Name = "lbFYT";
            lbFYT.Size = new Size(42, 13);
            lbFYT.TabIndex = 76;
            lbFYT.Text = "Y Tiling";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Enabled = false;
            Label2.Location = new Point(211, 21);
            Label2.Name = "Label2";
            Label2.Size = new Size(43, 13);
            Label2.TabIndex = 67;
            Label2.Text = "Deep Z";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Enabled = false;
            Label3.Location = new Point(70, 21);
            Label3.Name = "Label3";
            Label3.Size = new Size(45, 13);
            Label3.TabIndex = 66;
            Label3.Text = "Width X";
            // 
            // lbFXT
            // 
            lbFXT.AutoSize = true;
            lbFXT.Location = new Point(72, 146);
            lbFXT.Name = "lbFXT";
            lbFXT.Size = new Size(42, 13);
            lbFXT.TabIndex = 76;
            lbFXT.Text = "X Tiling";
            // 
            // lbRYT
            // 
            lbRYT.AutoSize = true;
            lbRYT.Location = new Point(140, 62);
            lbRYT.Name = "lbRYT";
            lbRYT.Size = new Size(42, 13);
            lbRYT.TabIndex = 76;
            lbRYT.Text = "Y Tiling";
            // 
            // frMulti
            // 
            frMulti.Controls.Add(ckSmoothing);
            frMulti.Controls.Add(nUPbuildingSides);
            frMulti.Controls.Add(lbSides);
            frMulti.Location = new Point(107, 99);
            frMulti.Name = "frMulti";
            frMulti.Size = new Size(197, 55);
            frMulti.TabIndex = 81;
            frMulti.TabStop = false;
            frMulti.Text = "MultiSided Building";
            // 
            // nUPGrid
            // 
            nUPGrid.BackColor = SystemColors.Window;
            nUPGrid.DecimalPlaces = 1;
            nUPGrid.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nUPGrid.Location = new Point(381, 505);
            nUPGrid.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            nUPGrid.Name = "nUPGrid";
            nUPGrid.Size = new Size(53, 20);
            nUPGrid.TabIndex = 82;
            nUPGrid.TextAlign = HorizontalAlignment.Right;
            nUPGrid.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // Label4
            // 
            Label4.Location = new Point(317, 507);
            Label4.Name = "Label4";
            Label4.Size = new Size(63, 16);
            Label4.TabIndex = 83;
            Label4.Text = "Grid meters";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(322, 222);
            Label6.Name = "Label6";
            Label6.Size = new Size(269, 13);
            Label6.TabIndex = 84;
            Label6.Text = "Right mouse to enlarge. Wheel and left mouse to move.";
            // 
            // frmGBuilding
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 547);
            ControlBox = false;
            Controls.Add(_imgGenB);
            Controls.Add(frMulti);
            Controls.Add(lbgb3);
            Controls.Add(frRoof);
            Controls.Add(frTop);
            Controls.Add(frWindow);
            Controls.Add(frBottom);
            Controls.Add(frGenB);
            Controls.Add(nUPscale);
            Controls.Add(cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(nUPGrid);
            Controls.Add(Label4);
            Controls.Add(Label6);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGBuilding";
            Text = "SBuilderX - Generic Buildings";
            ((System.ComponentModel.ISupportInitialize)nUPsizeBottomY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeWindowY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeTopY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeRoofY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeTopX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeTopZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexBottomX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexBottomZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexWindowX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexWindowY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexWindowZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexTopX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexTopZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexRoofX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexRoofY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexRoofZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPbuildingSides).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPgableTexture).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPfaceTexture).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexGableY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexFaceX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexGableZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtextureIndexFaceY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPsizeZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPscale).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPtopTexture).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPbottomTexture).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUProofTexture).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPwindowTexture).EndInit();
            ((System.ComponentModel.ISupportInitialize)_imgGenB).EndInit();
            frGenB.ResumeLayout(false);
            frGenB.PerformLayout();
            frBottom.ResumeLayout(false);
            frBottom.PerformLayout();
            frWindow.ResumeLayout(false);
            frWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUPWZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPWX).EndInit();
            frTop.ResumeLayout(false);
            frTop.PerformLayout();
            frRoof.ResumeLayout(false);
            frRoof.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUPRZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPRX).EndInit();
            frMulti.ResumeLayout(false);
            frMulti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nUPGrid).EndInit();
            Load += new EventHandler(FrmGBuilding_Load);
            FormClosing += new FormClosingEventHandler(FrmGBuilding_FormClosing);
            ResumeLayout(false);
            PerformLayout();
        }

        internal NumericUpDown nUPsizeBottomY;
        internal NumericUpDown nUPsizeWindowY;
        internal NumericUpDown nUPsizeTopY;
        internal NumericUpDown nUPsizeRoofY;
        internal NumericUpDown nUPsizeTopX;
        internal NumericUpDown nUPsizeTopZ;
        internal NumericUpDown nUPtextureIndexBottomX;
        internal NumericUpDown nUPtextureIndexBottomZ;
        internal NumericUpDown nUPtextureIndexWindowX;
        internal NumericUpDown nUPtextureIndexWindowY;
        internal NumericUpDown nUPtextureIndexWindowZ;
        internal NumericUpDown nUPtextureIndexTopX;
        internal NumericUpDown nUPtextureIndexTopZ;
        internal NumericUpDown nUPtextureIndexRoofX;
        internal NumericUpDown nUPtextureIndexRoofY;
        internal NumericUpDown nUPtextureIndexRoofZ;
        internal NumericUpDown nUPbuildingSides;
        internal CheckBox ckSmoothing;
        internal Label lbSides;
        internal Label lbG;
        internal Label lbF;
        internal NumericUpDown nUPgableTexture;
        internal NumericUpDown nUPfaceTexture;
        internal NumericUpDown nUPtextureIndexGableY;
        internal NumericUpDown nUPtextureIndexFaceX;
        internal NumericUpDown nUPtextureIndexGableZ;
        internal NumericUpDown nUPtextureIndexFaceY;
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
                    _cmdCancel.MouseHover -= CmdCancel_MouseHover;
                }

                _cmdCancel = value;
                if (_cmdCancel != null)
                {
                    _cmdCancel.MouseHover += CmdCancel_MouseHover;
                }
            }
        }

        internal Button cmdOK;
        public Label lbgb3;
        internal Label lbBW;
        internal Label lbBD;
        internal NumericUpDown nUPsizeX;
        internal NumericUpDown nUPsizeZ;
        internal NumericUpDown nUPscale;
        private NumericUpDown nUPtopTexture;
        internal NumericUpDown nUPbottomTexture;
        private NumericUpDown nUProofTexture;
        private NumericUpDown nUPwindowTexture;
        private PictureBox _imgGenB;

        internal PictureBox imgGenB
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
                    _imgGenB.MouseHover -= ImgGenB_MouseHover;
                    _imgGenB.MouseMove -= ImgGenB_MouseMove;
                    _imgGenB.MouseUp -= ImgGenB_MouseUp;
                    _imgGenB.MouseWheel -= ImgGenB_MouseWheel;
                }

                _imgGenB = value;
                if (_imgGenB != null)
                {
                    _imgGenB.MouseDown += ImgGenB_MouseDown;
                    _imgGenB.MouseHover += ImgGenB_MouseHover;
                    _imgGenB.MouseMove += ImgGenB_MouseMove;
                    _imgGenB.MouseUp += ImgGenB_MouseUp;
                    _imgGenB.MouseWheel += ImgGenB_MouseWheel;
                }
            }
        }

        public GroupBox frGenB;
        private RadioButton _optGbMultiSided;

        internal RadioButton optGbMultiSided
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGbMultiSided;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGbMultiSided != null)
                {
                    _optGbMultiSided.CheckedChanged -= OptGbMultiSided_CheckedChanged;
                }

                _optGbMultiSided = value;
                if (_optGbMultiSided != null)
                {
                    _optGbMultiSided.CheckedChanged += OptGbMultiSided_CheckedChanged;
                }
            }
        }

        private RadioButton _optGbPyramidal;

        internal RadioButton optGbPyramidal
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGbPyramidal;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGbPyramidal != null)
                {
                    _optGbPyramidal.CheckedChanged -= OptGbPyramidal_CheckedChanged;
                }

                _optGbPyramidal = value;
                if (_optGbPyramidal != null)
                {
                    _optGbPyramidal.CheckedChanged += OptGbPyramidal_CheckedChanged;
                }
            }
        }

        private RadioButton _optGbSlant;

        internal RadioButton optGbSlant
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGbSlant;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGbSlant != null)
                {
                    _optGbSlant.CheckedChanged -= OptGbSlant_CheckedChanged;
                }

                _optGbSlant = value;
                if (_optGbSlant != null)
                {
                    _optGbSlant.CheckedChanged += OptGbSlant_CheckedChanged;
                }
            }
        }

        private RadioButton _optGbRidge;

        internal RadioButton optGbRidge
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGbRidge;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGbRidge != null)
                {
                    _optGbRidge.CheckedChanged -= OptGbRidge_CheckedChanged;
                }

                _optGbRidge = value;
                if (_optGbRidge != null)
                {
                    _optGbRidge.CheckedChanged += OptGbRidge_CheckedChanged;
                }
            }
        }

        private RadioButton _optGbPeaked;

        internal RadioButton optGbPeaked
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGbPeaked;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGbPeaked != null)
                {
                    _optGbPeaked.CheckedChanged -= OptGbPeaked_CheckedChanged;
                }

                _optGbPeaked = value;
                if (_optGbPeaked != null)
                {
                    _optGbPeaked.CheckedChanged += OptGbPeaked_CheckedChanged;
                }
            }
        }

        private RadioButton _optGbFlat;

        internal RadioButton optGbFlat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optGbFlat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optGbFlat != null)
                {
                    _optGbFlat.CheckedChanged -= OptGbFlat_CheckedChanged;
                }

                _optGbFlat = value;
                if (_optGbFlat != null)
                {
                    _optGbFlat.CheckedChanged += OptGbFlat_CheckedChanged;
                }
            }
        }

        internal GroupBox frBottom;
        internal Label lbRH;
        internal Label lbBH;
        internal Label lbBT;
        internal Label Label31;
        internal Label Label32;
        internal Label Label34;
        internal Label lbWZT;
        internal Label Label37;
        internal Label Label38;
        internal Label Label39;
        internal Label Label40;
        internal Label lbBZT;
        internal GroupBox frWindow;
        internal Label lbGYT;
        internal Label Label43;
        internal Label Label44;
        internal GroupBox frTop;
        internal Label Label45;
        internal Label Label8;
        internal Label lbTZT;
        internal Label lbGZT;
        internal Label lbTW;
        internal Label lbTD;
        internal GroupBox frRoof;
        internal Label lbRYT;
        internal Label lbFXT;
        internal Label lbFYT;
        internal Label Label1;
        internal Label Label5;
        internal NumericUpDown nUPWZ;
        internal NumericUpDown nUPWX;
        internal GroupBox frMulti;
        internal NumericUpDown nUPRZ;
        internal NumericUpDown nUPRX;
        internal Label Label2;
        internal Label Label3;
        internal NumericUpDown nUPGrid;
        internal Label Label4;
        internal Label Label6;

        private void FrmGBuilding_FormClosing(object sender, FormClosingEventArgs e)
        {
            vertexBuffer.Dispose();
        }
    }
}