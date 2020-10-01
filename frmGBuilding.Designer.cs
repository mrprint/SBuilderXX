using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGBuilding));
            this.nUPsizeBottomY = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeWindowY = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeTopY = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeRoofY = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeTopX = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeTopZ = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexBottomX = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexBottomZ = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexWindowX = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexWindowY = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexWindowZ = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexTopX = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexTopZ = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexRoofX = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexRoofY = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexRoofZ = new System.Windows.Forms.NumericUpDown();
            this.nUPbuildingSides = new System.Windows.Forms.NumericUpDown();
            this.ckSmoothing = new System.Windows.Forms.CheckBox();
            this.lbSides = new System.Windows.Forms.Label();
            this.lbG = new System.Windows.Forms.Label();
            this.lbF = new System.Windows.Forms.Label();
            this.nUPgableTexture = new System.Windows.Forms.NumericUpDown();
            this.nUPfaceTexture = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexGableY = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexFaceX = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexGableZ = new System.Windows.Forms.NumericUpDown();
            this.nUPtextureIndexFaceY = new System.Windows.Forms.NumericUpDown();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.lbgb3 = new System.Windows.Forms.Label();
            this.lbBW = new System.Windows.Forms.Label();
            this.lbBD = new System.Windows.Forms.Label();
            this.nUPsizeX = new System.Windows.Forms.NumericUpDown();
            this.nUPsizeZ = new System.Windows.Forms.NumericUpDown();
            this.nUPscale = new System.Windows.Forms.NumericUpDown();
            this.nUPtopTexture = new System.Windows.Forms.NumericUpDown();
            this.nUPbottomTexture = new System.Windows.Forms.NumericUpDown();
            this.nUProofTexture = new System.Windows.Forms.NumericUpDown();
            this.nUPwindowTexture = new System.Windows.Forms.NumericUpDown();
            this._imgGenB = new System.Windows.Forms.PictureBox();
            this.frGenB = new System.Windows.Forms.GroupBox();
            this._optGbMultiSided = new System.Windows.Forms.RadioButton();
            this._optGbPyramidal = new System.Windows.Forms.RadioButton();
            this._optGbSlant = new System.Windows.Forms.RadioButton();
            this._optGbRidge = new System.Windows.Forms.RadioButton();
            this._optGbPeaked = new System.Windows.Forms.RadioButton();
            this._optGbFlat = new System.Windows.Forms.RadioButton();
            this.frBottom = new System.Windows.Forms.GroupBox();
            this.lbBH = new System.Windows.Forms.Label();
            this.lbBT = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.lbBZT = new System.Windows.Forms.Label();
            this.lbRH = new System.Windows.Forms.Label();
            this.Label31 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Label34 = new System.Windows.Forms.Label();
            this.lbWZT = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.frWindow = new System.Windows.Forms.GroupBox();
            this.nUPWZ = new System.Windows.Forms.NumericUpDown();
            this.nUPWX = new System.Windows.Forms.NumericUpDown();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbGYT = new System.Windows.Forms.Label();
            this.Label43 = new System.Windows.Forms.Label();
            this.Label44 = new System.Windows.Forms.Label();
            this.frTop = new System.Windows.Forms.GroupBox();
            this.Label45 = new System.Windows.Forms.Label();
            this.lbTZT = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.lbTD = new System.Windows.Forms.Label();
            this.lbTW = new System.Windows.Forms.Label();
            this.lbGZT = new System.Windows.Forms.Label();
            this.frRoof = new System.Windows.Forms.GroupBox();
            this.nUPRZ = new System.Windows.Forms.NumericUpDown();
            this.nUPRX = new System.Windows.Forms.NumericUpDown();
            this.lbFYT = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbFXT = new System.Windows.Forms.Label();
            this.lbRYT = new System.Windows.Forms.Label();
            this.frMulti = new System.Windows.Forms.GroupBox();
            this.nUPGrid = new System.Windows.Forms.NumericUpDown();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeBottomY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeWindowY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeTopY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeRoofY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeTopX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeTopZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexBottomX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexBottomZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexWindowX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexWindowY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexWindowZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexTopX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexTopZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexRoofX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexRoofY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexRoofZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPbuildingSides)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPgableTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPfaceTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexGableY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexFaceX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexGableZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexFaceY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPscale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtopTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPbottomTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUProofTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPwindowTexture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._imgGenB)).BeginInit();
            this.frGenB.SuspendLayout();
            this.frBottom.SuspendLayout();
            this.frWindow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPWZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPWX)).BeginInit();
            this.frTop.SuspendLayout();
            this.frRoof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPRZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPRX)).BeginInit();
            this.frMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // nUPsizeBottomY
            // 
            this.nUPsizeBottomY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeBottomY.Enabled = false;
            this.nUPsizeBottomY.Location = new System.Drawing.Point(143, 37);
            this.nUPsizeBottomY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPsizeBottomY.Name = "nUPsizeBottomY";
            this.nUPsizeBottomY.Size = new System.Drawing.Size(53, 20);
            this.nUPsizeBottomY.TabIndex = 57;
            this.nUPsizeBottomY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeBottomY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPsizeWindowY
            // 
            this.nUPsizeWindowY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeWindowY.Enabled = false;
            this.nUPsizeWindowY.Location = new System.Drawing.Point(143, 36);
            this.nUPsizeWindowY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPsizeWindowY.Name = "nUPsizeWindowY";
            this.nUPsizeWindowY.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeWindowY.TabIndex = 57;
            this.nUPsizeWindowY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeWindowY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPsizeTopY
            // 
            this.nUPsizeTopY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeTopY.Enabled = false;
            this.nUPsizeTopY.Location = new System.Drawing.Point(142, 37);
            this.nUPsizeTopY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPsizeTopY.Name = "nUPsizeTopY";
            this.nUPsizeTopY.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeTopY.TabIndex = 57;
            this.nUPsizeTopY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeTopY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPsizeRoofY
            // 
            this.nUPsizeRoofY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeRoofY.Enabled = false;
            this.nUPsizeRoofY.Location = new System.Drawing.Point(143, 37);
            this.nUPsizeRoofY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPsizeRoofY.Name = "nUPsizeRoofY";
            this.nUPsizeRoofY.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeRoofY.TabIndex = 57;
            this.nUPsizeRoofY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeRoofY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPsizeTopX
            // 
            this.nUPsizeTopX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeTopX.DecimalPlaces = 2;
            this.nUPsizeTopX.Enabled = false;
            this.nUPsizeTopX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPsizeTopX.Location = new System.Drawing.Point(74, 37);
            this.nUPsizeTopX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPsizeTopX.Name = "nUPsizeTopX";
            this.nUPsizeTopX.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeTopX.TabIndex = 57;
            this.nUPsizeTopX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeTopX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPsizeTopZ
            // 
            this.nUPsizeTopZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPsizeTopZ.DecimalPlaces = 2;
            this.nUPsizeTopZ.Enabled = false;
            this.nUPsizeTopZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPsizeTopZ.Location = new System.Drawing.Point(210, 37);
            this.nUPsizeTopZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPsizeTopZ.Name = "nUPsizeTopZ";
            this.nUPsizeTopZ.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeTopZ.TabIndex = 57;
            this.nUPsizeTopZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeTopZ.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPtextureIndexBottomX
            // 
            this.nUPtextureIndexBottomX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexBottomX.DecimalPlaces = 3;
            this.nUPtextureIndexBottomX.Enabled = false;
            this.nUPtextureIndexBottomX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexBottomX.Location = new System.Drawing.Point(73, 78);
            this.nUPtextureIndexBottomX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexBottomX.Name = "nUPtextureIndexBottomX";
            this.nUPtextureIndexBottomX.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexBottomX.TabIndex = 59;
            this.nUPtextureIndexBottomX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexBottomX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexBottomZ
            // 
            this.nUPtextureIndexBottomZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexBottomZ.DecimalPlaces = 3;
            this.nUPtextureIndexBottomZ.Enabled = false;
            this.nUPtextureIndexBottomZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexBottomZ.Location = new System.Drawing.Point(210, 78);
            this.nUPtextureIndexBottomZ.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexBottomZ.Name = "nUPtextureIndexBottomZ";
            this.nUPtextureIndexBottomZ.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexBottomZ.TabIndex = 59;
            this.nUPtextureIndexBottomZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexBottomZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexWindowX
            // 
            this.nUPtextureIndexWindowX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexWindowX.DecimalPlaces = 3;
            this.nUPtextureIndexWindowX.Enabled = false;
            this.nUPtextureIndexWindowX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexWindowX.Location = new System.Drawing.Point(73, 78);
            this.nUPtextureIndexWindowX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexWindowX.Name = "nUPtextureIndexWindowX";
            this.nUPtextureIndexWindowX.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexWindowX.TabIndex = 59;
            this.nUPtextureIndexWindowX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexWindowX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexWindowY
            // 
            this.nUPtextureIndexWindowY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexWindowY.DecimalPlaces = 3;
            this.nUPtextureIndexWindowY.Enabled = false;
            this.nUPtextureIndexWindowY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexWindowY.Location = new System.Drawing.Point(143, 78);
            this.nUPtextureIndexWindowY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexWindowY.Name = "nUPtextureIndexWindowY";
            this.nUPtextureIndexWindowY.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexWindowY.TabIndex = 59;
            this.nUPtextureIndexWindowY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexWindowY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexWindowZ
            // 
            this.nUPtextureIndexWindowZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexWindowZ.DecimalPlaces = 3;
            this.nUPtextureIndexWindowZ.Enabled = false;
            this.nUPtextureIndexWindowZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexWindowZ.Location = new System.Drawing.Point(214, 78);
            this.nUPtextureIndexWindowZ.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexWindowZ.Name = "nUPtextureIndexWindowZ";
            this.nUPtextureIndexWindowZ.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexWindowZ.TabIndex = 59;
            this.nUPtextureIndexWindowZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexWindowZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexTopX
            // 
            this.nUPtextureIndexTopX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexTopX.DecimalPlaces = 3;
            this.nUPtextureIndexTopX.Enabled = false;
            this.nUPtextureIndexTopX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexTopX.Location = new System.Drawing.Point(74, 78);
            this.nUPtextureIndexTopX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexTopX.Name = "nUPtextureIndexTopX";
            this.nUPtextureIndexTopX.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexTopX.TabIndex = 59;
            this.nUPtextureIndexTopX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexTopX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexTopZ
            // 
            this.nUPtextureIndexTopZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexTopZ.DecimalPlaces = 3;
            this.nUPtextureIndexTopZ.Enabled = false;
            this.nUPtextureIndexTopZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexTopZ.Location = new System.Drawing.Point(212, 78);
            this.nUPtextureIndexTopZ.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexTopZ.Name = "nUPtextureIndexTopZ";
            this.nUPtextureIndexTopZ.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexTopZ.TabIndex = 59;
            this.nUPtextureIndexTopZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexTopZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexRoofX
            // 
            this.nUPtextureIndexRoofX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexRoofX.DecimalPlaces = 3;
            this.nUPtextureIndexRoofX.Enabled = false;
            this.nUPtextureIndexRoofX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexRoofX.Location = new System.Drawing.Point(75, 78);
            this.nUPtextureIndexRoofX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexRoofX.Name = "nUPtextureIndexRoofX";
            this.nUPtextureIndexRoofX.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexRoofX.TabIndex = 59;
            this.nUPtextureIndexRoofX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexRoofX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexRoofY
            // 
            this.nUPtextureIndexRoofY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexRoofY.DecimalPlaces = 3;
            this.nUPtextureIndexRoofY.Enabled = false;
            this.nUPtextureIndexRoofY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexRoofY.Location = new System.Drawing.Point(143, 78);
            this.nUPtextureIndexRoofY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexRoofY.Name = "nUPtextureIndexRoofY";
            this.nUPtextureIndexRoofY.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexRoofY.TabIndex = 59;
            this.nUPtextureIndexRoofY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexRoofY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexRoofZ
            // 
            this.nUPtextureIndexRoofZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexRoofZ.DecimalPlaces = 3;
            this.nUPtextureIndexRoofZ.Enabled = false;
            this.nUPtextureIndexRoofZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexRoofZ.Location = new System.Drawing.Point(212, 78);
            this.nUPtextureIndexRoofZ.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexRoofZ.Name = "nUPtextureIndexRoofZ";
            this.nUPtextureIndexRoofZ.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexRoofZ.TabIndex = 59;
            this.nUPtextureIndexRoofZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexRoofZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPbuildingSides
            // 
            this.nUPbuildingSides.BackColor = System.Drawing.SystemColors.Window;
            this.nUPbuildingSides.Enabled = false;
            this.nUPbuildingSides.Location = new System.Drawing.Point(138, 22);
            this.nUPbuildingSides.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nUPbuildingSides.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUPbuildingSides.Name = "nUPbuildingSides";
            this.nUPbuildingSides.Size = new System.Drawing.Size(40, 20);
            this.nUPbuildingSides.TabIndex = 59;
            this.nUPbuildingSides.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPbuildingSides.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // ckSmoothing
            // 
            this.ckSmoothing.AutoSize = true;
            this.ckSmoothing.Enabled = false;
            this.ckSmoothing.Location = new System.Drawing.Point(12, 25);
            this.ckSmoothing.Name = "ckSmoothing";
            this.ckSmoothing.Size = new System.Drawing.Size(76, 17);
            this.ckSmoothing.TabIndex = 60;
            this.ckSmoothing.Text = "Smoothing";
            this.ckSmoothing.UseVisualStyleBackColor = true;
            // 
            // lbSides
            // 
            this.lbSides.AutoSize = true;
            this.lbSides.Location = new System.Drawing.Point(99, 27);
            this.lbSides.Name = "lbSides";
            this.lbSides.Size = new System.Drawing.Size(33, 13);
            this.lbSides.TabIndex = 58;
            this.lbSides.Text = "Sides";
            // 
            // lbG
            // 
            this.lbG.AutoSize = true;
            this.lbG.Location = new System.Drawing.Point(14, 104);
            this.lbG.Name = "lbG";
            this.lbG.Size = new System.Drawing.Size(35, 13);
            this.lbG.TabIndex = 58;
            this.lbG.Text = "Gable";
            // 
            // lbF
            // 
            this.lbF.AutoSize = true;
            this.lbF.Location = new System.Drawing.Point(13, 146);
            this.lbF.Name = "lbF";
            this.lbF.Size = new System.Drawing.Size(31, 13);
            this.lbF.TabIndex = 58;
            this.lbF.Text = "Face";
            // 
            // nUPgableTexture
            // 
            this.nUPgableTexture.BackColor = System.Drawing.SystemColors.Window;
            this.nUPgableTexture.Enabled = false;
            this.nUPgableTexture.Location = new System.Drawing.Point(17, 120);
            this.nUPgableTexture.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPgableTexture.Name = "nUPgableTexture";
            this.nUPgableTexture.Size = new System.Drawing.Size(46, 20);
            this.nUPgableTexture.TabIndex = 59;
            this.nUPgableTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPgableTexture.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPfaceTexture
            // 
            this.nUPfaceTexture.BackColor = System.Drawing.SystemColors.Window;
            this.nUPfaceTexture.Enabled = false;
            this.nUPfaceTexture.Location = new System.Drawing.Point(17, 161);
            this.nUPfaceTexture.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPfaceTexture.Name = "nUPfaceTexture";
            this.nUPfaceTexture.Size = new System.Drawing.Size(46, 20);
            this.nUPfaceTexture.TabIndex = 59;
            this.nUPfaceTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPfaceTexture.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexGableY
            // 
            this.nUPtextureIndexGableY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexGableY.DecimalPlaces = 3;
            this.nUPtextureIndexGableY.Enabled = false;
            this.nUPtextureIndexGableY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexGableY.Location = new System.Drawing.Point(143, 120);
            this.nUPtextureIndexGableY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexGableY.Name = "nUPtextureIndexGableY";
            this.nUPtextureIndexGableY.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexGableY.TabIndex = 59;
            this.nUPtextureIndexGableY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexGableY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexFaceX
            // 
            this.nUPtextureIndexFaceX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexFaceX.DecimalPlaces = 3;
            this.nUPtextureIndexFaceX.Enabled = false;
            this.nUPtextureIndexFaceX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexFaceX.Location = new System.Drawing.Point(75, 162);
            this.nUPtextureIndexFaceX.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexFaceX.Name = "nUPtextureIndexFaceX";
            this.nUPtextureIndexFaceX.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexFaceX.TabIndex = 59;
            this.nUPtextureIndexFaceX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexFaceX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexGableZ
            // 
            this.nUPtextureIndexGableZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexGableZ.DecimalPlaces = 3;
            this.nUPtextureIndexGableZ.Enabled = false;
            this.nUPtextureIndexGableZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexGableZ.Location = new System.Drawing.Point(212, 122);
            this.nUPtextureIndexGableZ.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexGableZ.Name = "nUPtextureIndexGableZ";
            this.nUPtextureIndexGableZ.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexGableZ.TabIndex = 59;
            this.nUPtextureIndexGableZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexGableZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtextureIndexFaceY
            // 
            this.nUPtextureIndexFaceY.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtextureIndexFaceY.DecimalPlaces = 3;
            this.nUPtextureIndexFaceY.Enabled = false;
            this.nUPtextureIndexFaceY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nUPtextureIndexFaceY.Location = new System.Drawing.Point(143, 162);
            this.nUPtextureIndexFaceY.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            131072});
            this.nUPtextureIndexFaceY.Name = "nUPtextureIndexFaceY";
            this.nUPtextureIndexFaceY.Size = new System.Drawing.Size(55, 20);
            this.nUPtextureIndexFaceY.TabIndex = 59;
            this.nUPtextureIndexFaceY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtextureIndexFaceY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(465, 505);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(59, 23);
            this._cmdCancel.TabIndex = 61;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.MouseHover += new System.EventHandler(this.CmdCancel_MouseHover);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(549, 505);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(59, 23);
            this.cmdOK.TabIndex = 61;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            // 
            // lbgb3
            // 
            this.lbgb3.BackColor = System.Drawing.Color.Transparent;
            this.lbgb3.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbgb3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbgb3.Location = new System.Drawing.Point(23, 99);
            this.lbgb3.Name = "lbgb3";
            this.lbgb3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbgb3.Size = new System.Drawing.Size(37, 18);
            this.lbgb3.TabIndex = 64;
            this.lbgb3.Text = "Scale";
            this.lbgb3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBW
            // 
            this.lbBW.AutoSize = true;
            this.lbBW.Location = new System.Drawing.Point(64, 22);
            this.lbBW.Name = "lbBW";
            this.lbBW.Size = new System.Drawing.Size(45, 13);
            this.lbBW.TabIndex = 66;
            this.lbBW.Text = "Width X";
            // 
            // lbBD
            // 
            this.lbBD.AutoSize = true;
            this.lbBD.Location = new System.Drawing.Point(207, 22);
            this.lbBD.Name = "lbBD";
            this.lbBD.Size = new System.Drawing.Size(43, 13);
            this.lbBD.TabIndex = 67;
            this.lbBD.Text = "Deep Z";
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
            this.nUPsizeX.Location = new System.Drawing.Point(73, 36);
            this.nUPsizeX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPsizeX.Name = "nUPsizeX";
            this.nUPsizeX.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeX.TabIndex = 68;
            this.nUPsizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeX.Value = new decimal(new int[] {
            10,
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
            this.nUPsizeZ.Location = new System.Drawing.Point(209, 38);
            this.nUPsizeZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPsizeZ.Name = "nUPsizeZ";
            this.nUPsizeZ.Size = new System.Drawing.Size(55, 20);
            this.nUPsizeZ.TabIndex = 69;
            this.nUPsizeZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPsizeZ.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
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
            this.nUPscale.Location = new System.Drawing.Point(26, 120);
            this.nUPscale.Name = "nUPscale";
            this.nUPscale.Size = new System.Drawing.Size(50, 20);
            this.nUPscale.TabIndex = 70;
            this.nUPscale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPscale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUPtopTexture
            // 
            this.nUPtopTexture.BackColor = System.Drawing.SystemColors.Window;
            this.nUPtopTexture.Location = new System.Drawing.Point(15, 37);
            this.nUPtopTexture.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPtopTexture.Name = "nUPtopTexture";
            this.nUPtopTexture.Size = new System.Drawing.Size(46, 20);
            this.nUPtopTexture.TabIndex = 53;
            this.nUPtopTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPtopTexture.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nUPbottomTexture
            // 
            this.nUPbottomTexture.BackColor = System.Drawing.SystemColors.Window;
            this.nUPbottomTexture.Location = new System.Drawing.Point(14, 36);
            this.nUPbottomTexture.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPbottomTexture.Name = "nUPbottomTexture";
            this.nUPbottomTexture.Size = new System.Drawing.Size(46, 20);
            this.nUPbottomTexture.TabIndex = 53;
            this.nUPbottomTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPbottomTexture.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nUProofTexture
            // 
            this.nUProofTexture.BackColor = System.Drawing.SystemColors.Window;
            this.nUProofTexture.Location = new System.Drawing.Point(16, 37);
            this.nUProofTexture.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUProofTexture.Name = "nUProofTexture";
            this.nUProofTexture.Size = new System.Drawing.Size(46, 20);
            this.nUProofTexture.TabIndex = 53;
            this.nUProofTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUProofTexture.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // nUPwindowTexture
            // 
            this.nUPwindowTexture.BackColor = System.Drawing.SystemColors.Window;
            this.nUPwindowTexture.Location = new System.Drawing.Point(12, 36);
            this.nUPwindowTexture.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nUPwindowTexture.Name = "nUPwindowTexture";
            this.nUPwindowTexture.Size = new System.Drawing.Size(46, 20);
            this.nUPwindowTexture.TabIndex = 53;
            this.nUPwindowTexture.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPwindowTexture.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // _imgGenB
            // 
            this._imgGenB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._imgGenB.Location = new System.Drawing.Point(323, 238);
            this._imgGenB.Name = "_imgGenB";
            this._imgGenB.Size = new System.Drawing.Size(286, 252);
            this._imgGenB.TabIndex = 72;
            this._imgGenB.TabStop = false;
            this._imgGenB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgGenB_MouseDown);
            this._imgGenB.MouseHover += new System.EventHandler(this.ImgGenB_MouseHover);
            this._imgGenB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgGenB_MouseMove);
            this._imgGenB.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgGenB_MouseUp);
            this._imgGenB.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.ImgGenB_MouseWheel);
            // 
            // frGenB
            // 
            this.frGenB.BackColor = System.Drawing.Color.Transparent;
            this.frGenB.Controls.Add(this._optGbMultiSided);
            this.frGenB.Controls.Add(this._optGbPyramidal);
            this.frGenB.Controls.Add(this._optGbSlant);
            this.frGenB.Controls.Add(this._optGbRidge);
            this.frGenB.Controls.Add(this._optGbPeaked);
            this.frGenB.Controls.Add(this._optGbFlat);
            this.frGenB.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.frGenB.Location = new System.Drawing.Point(22, 14);
            this.frGenB.Name = "frGenB";
            this.frGenB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frGenB.Size = new System.Drawing.Size(282, 73);
            this.frGenB.TabIndex = 74;
            this.frGenB.TabStop = false;
            this.frGenB.Text = "Building Type";
            // 
            // _optGbMultiSided
            // 
            this._optGbMultiSided.AutoSize = true;
            this._optGbMultiSided.ForeColor = System.Drawing.Color.Black;
            this._optGbMultiSided.Location = new System.Drawing.Point(183, 42);
            this._optGbMultiSided.Name = "_optGbMultiSided";
            this._optGbMultiSided.Size = new System.Drawing.Size(74, 17);
            this._optGbMultiSided.TabIndex = 0;
            this._optGbMultiSided.Text = "MultiSided";
            this._optGbMultiSided.UseVisualStyleBackColor = true;
            this._optGbMultiSided.CheckedChanged += new System.EventHandler(this.OptGbMultiSided_CheckedChanged);
            // 
            // _optGbPyramidal
            // 
            this._optGbPyramidal.AutoSize = true;
            this._optGbPyramidal.ForeColor = System.Drawing.Color.Black;
            this._optGbPyramidal.Location = new System.Drawing.Point(183, 19);
            this._optGbPyramidal.Name = "_optGbPyramidal";
            this._optGbPyramidal.Size = new System.Drawing.Size(70, 17);
            this._optGbPyramidal.TabIndex = 0;
            this._optGbPyramidal.Text = "Pyramidal";
            this._optGbPyramidal.UseVisualStyleBackColor = true;
            this._optGbPyramidal.CheckedChanged += new System.EventHandler(this.OptGbPyramidal_CheckedChanged);
            // 
            // _optGbSlant
            // 
            this._optGbSlant.AutoSize = true;
            this._optGbSlant.ForeColor = System.Drawing.Color.Black;
            this._optGbSlant.Location = new System.Drawing.Point(109, 44);
            this._optGbSlant.Name = "_optGbSlant";
            this._optGbSlant.Size = new System.Drawing.Size(49, 17);
            this._optGbSlant.TabIndex = 0;
            this._optGbSlant.Text = "Slant";
            this._optGbSlant.UseVisualStyleBackColor = true;
            this._optGbSlant.CheckedChanged += new System.EventHandler(this.OptGbSlant_CheckedChanged);
            // 
            // _optGbRidge
            // 
            this._optGbRidge.AutoSize = true;
            this._optGbRidge.ForeColor = System.Drawing.Color.Black;
            this._optGbRidge.Location = new System.Drawing.Point(109, 21);
            this._optGbRidge.Name = "_optGbRidge";
            this._optGbRidge.Size = new System.Drawing.Size(53, 17);
            this._optGbRidge.TabIndex = 0;
            this._optGbRidge.Text = "Ridge";
            this._optGbRidge.UseVisualStyleBackColor = true;
            this._optGbRidge.CheckedChanged += new System.EventHandler(this.OptGbRidge_CheckedChanged);
            // 
            // _optGbPeaked
            // 
            this._optGbPeaked.AutoSize = true;
            this._optGbPeaked.ForeColor = System.Drawing.Color.Black;
            this._optGbPeaked.Location = new System.Drawing.Point(25, 44);
            this._optGbPeaked.Name = "_optGbPeaked";
            this._optGbPeaked.Size = new System.Drawing.Size(62, 17);
            this._optGbPeaked.TabIndex = 0;
            this._optGbPeaked.Text = "Peaked";
            this._optGbPeaked.UseVisualStyleBackColor = true;
            this._optGbPeaked.CheckedChanged += new System.EventHandler(this.OptGbPeaked_CheckedChanged);
            // 
            // _optGbFlat
            // 
            this._optGbFlat.AutoSize = true;
            this._optGbFlat.ForeColor = System.Drawing.Color.Black;
            this._optGbFlat.Location = new System.Drawing.Point(25, 21);
            this._optGbFlat.Name = "_optGbFlat";
            this._optGbFlat.Size = new System.Drawing.Size(42, 17);
            this._optGbFlat.TabIndex = 0;
            this._optGbFlat.Text = "Flat";
            this._optGbFlat.UseVisualStyleBackColor = true;
            this._optGbFlat.CheckedChanged += new System.EventHandler(this.OptGbFlat_CheckedChanged);
            // 
            // frBottom
            // 
            this.frBottom.Controls.Add(this.nUPsizeBottomY);
            this.frBottom.Controls.Add(this.lbBH);
            this.frBottom.Controls.Add(this.nUPbottomTexture);
            this.frBottom.Controls.Add(this.lbBT);
            this.frBottom.Controls.Add(this.nUPtextureIndexBottomX);
            this.frBottom.Controls.Add(this.Label40);
            this.frBottom.Controls.Add(this.lbBZT);
            this.frBottom.Controls.Add(this.nUPtextureIndexBottomZ);
            this.frBottom.Controls.Add(this.nUPsizeX);
            this.frBottom.Controls.Add(this.nUPsizeZ);
            this.frBottom.Controls.Add(this.lbBD);
            this.frBottom.Controls.Add(this.lbBW);
            this.frBottom.Location = new System.Drawing.Point(22, 160);
            this.frBottom.Name = "frBottom";
            this.frBottom.Size = new System.Drawing.Size(283, 113);
            this.frBottom.TabIndex = 75;
            this.frBottom.TabStop = false;
            this.frBottom.Text = "Bottom Section";
            // 
            // lbBH
            // 
            this.lbBH.AutoSize = true;
            this.lbBH.Location = new System.Drawing.Point(137, 21);
            this.lbBH.Name = "lbBH";
            this.lbBH.Size = new System.Drawing.Size(48, 13);
            this.lbBH.TabIndex = 76;
            this.lbBH.Text = "Height Y";
            // 
            // lbBT
            // 
            this.lbBT.AutoSize = true;
            this.lbBT.Location = new System.Drawing.Point(11, 20);
            this.lbBT.Name = "lbBT";
            this.lbBT.Size = new System.Drawing.Size(43, 13);
            this.lbBT.TabIndex = 76;
            this.lbBT.Text = "Texture";
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.Location = new System.Drawing.Point(67, 62);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(42, 13);
            this.Label40.TabIndex = 76;
            this.Label40.Text = "X Tiling";
            // 
            // lbBZT
            // 
            this.lbBZT.AutoSize = true;
            this.lbBZT.Location = new System.Drawing.Point(207, 62);
            this.lbBZT.Name = "lbBZT";
            this.lbBZT.Size = new System.Drawing.Size(42, 13);
            this.lbBZT.TabIndex = 76;
            this.lbBZT.Text = "Z Tiling";
            // 
            // lbRH
            // 
            this.lbRH.AutoSize = true;
            this.lbRH.Location = new System.Drawing.Point(140, 21);
            this.lbRH.Name = "lbRH";
            this.lbRH.Size = new System.Drawing.Size(48, 13);
            this.lbRH.TabIndex = 76;
            this.lbRH.Text = "Height Y";
            // 
            // Label31
            // 
            this.Label31.AutoSize = true;
            this.Label31.Location = new System.Drawing.Point(137, 20);
            this.Label31.Name = "Label31";
            this.Label31.Size = new System.Drawing.Size(48, 13);
            this.Label31.TabIndex = 76;
            this.Label31.Text = "Height Y";
            // 
            // Label32
            // 
            this.Label32.AutoSize = true;
            this.Label32.Location = new System.Drawing.Point(140, 21);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(48, 13);
            this.Label32.TabIndex = 76;
            this.Label32.Text = "Height Y";
            // 
            // Label34
            // 
            this.Label34.AutoSize = true;
            this.Label34.Location = new System.Drawing.Point(139, 61);
            this.Label34.Name = "Label34";
            this.Label34.Size = new System.Drawing.Size(42, 13);
            this.Label34.TabIndex = 76;
            this.Label34.Text = "Y Tiling";
            // 
            // lbWZT
            // 
            this.lbWZT.AutoSize = true;
            this.lbWZT.Location = new System.Drawing.Point(211, 62);
            this.lbWZT.Name = "lbWZT";
            this.lbWZT.Size = new System.Drawing.Size(42, 13);
            this.lbWZT.TabIndex = 76;
            this.lbWZT.Text = "Z Tiling";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(67, 62);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(42, 13);
            this.Label37.TabIndex = 76;
            this.Label37.Text = "X Tiling";
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.Location = new System.Drawing.Point(11, 20);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(43, 13);
            this.Label38.TabIndex = 76;
            this.Label38.Text = "Texture";
            // 
            // Label39
            // 
            this.Label39.AutoSize = true;
            this.Label39.Location = new System.Drawing.Point(14, 21);
            this.Label39.Name = "Label39";
            this.Label39.Size = new System.Drawing.Size(43, 13);
            this.Label39.TabIndex = 76;
            this.Label39.Text = "Texture";
            // 
            // frWindow
            // 
            this.frWindow.Controls.Add(this.nUPwindowTexture);
            this.frWindow.Controls.Add(this.Label38);
            this.frWindow.Controls.Add(this.Label31);
            this.frWindow.Controls.Add(this.nUPsizeWindowY);
            this.frWindow.Controls.Add(this.lbWZT);
            this.frWindow.Controls.Add(this.nUPtextureIndexWindowX);
            this.frWindow.Controls.Add(this.Label34);
            this.frWindow.Controls.Add(this.Label37);
            this.frWindow.Controls.Add(this.nUPWZ);
            this.frWindow.Controls.Add(this.nUPWX);
            this.frWindow.Controls.Add(this.Label5);
            this.frWindow.Controls.Add(this.nUPtextureIndexWindowZ);
            this.frWindow.Controls.Add(this.nUPtextureIndexWindowY);
            this.frWindow.Controls.Add(this.Label1);
            this.frWindow.Location = new System.Drawing.Point(22, 289);
            this.frWindow.Name = "frWindow";
            this.frWindow.Size = new System.Drawing.Size(283, 113);
            this.frWindow.TabIndex = 77;
            this.frWindow.TabStop = false;
            this.frWindow.Text = "Window Section";
            // 
            // nUPWZ
            // 
            this.nUPWZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPWZ.DecimalPlaces = 2;
            this.nUPWZ.Enabled = false;
            this.nUPWZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPWZ.Location = new System.Drawing.Point(213, 36);
            this.nUPWZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPWZ.Name = "nUPWZ";
            this.nUPWZ.Size = new System.Drawing.Size(55, 20);
            this.nUPWZ.TabIndex = 68;
            this.nUPWZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPWZ.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPWX
            // 
            this.nUPWX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPWX.DecimalPlaces = 2;
            this.nUPWX.Enabled = false;
            this.nUPWX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPWX.Location = new System.Drawing.Point(73, 36);
            this.nUPWX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPWX.Name = "nUPWX";
            this.nUPWX.Size = new System.Drawing.Size(55, 20);
            this.nUPWX.TabIndex = 68;
            this.nUPWX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPWX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Enabled = false;
            this.Label5.Location = new System.Drawing.Point(213, 20);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(43, 13);
            this.Label5.TabIndex = 67;
            this.Label5.Text = "Deep Z";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Enabled = false;
            this.Label1.Location = new System.Drawing.Point(67, 20);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 66;
            this.Label1.Text = "Width X";
            // 
            // lbGYT
            // 
            this.lbGYT.AutoSize = true;
            this.lbGYT.Location = new System.Drawing.Point(146, 104);
            this.lbGYT.Name = "lbGYT";
            this.lbGYT.Size = new System.Drawing.Size(42, 13);
            this.lbGYT.TabIndex = 76;
            this.lbGYT.Text = "Y Tiling";
            // 
            // Label43
            // 
            this.Label43.AutoSize = true;
            this.Label43.Location = new System.Drawing.Point(72, 62);
            this.Label43.Name = "Label43";
            this.Label43.Size = new System.Drawing.Size(42, 13);
            this.Label43.TabIndex = 76;
            this.Label43.Text = "X Tiling";
            // 
            // Label44
            // 
            this.Label44.AutoSize = true;
            this.Label44.Location = new System.Drawing.Point(213, 62);
            this.Label44.Name = "Label44";
            this.Label44.Size = new System.Drawing.Size(42, 13);
            this.Label44.TabIndex = 76;
            this.Label44.Text = "Z Tiling";
            // 
            // frTop
            // 
            this.frTop.Controls.Add(this.nUPtopTexture);
            this.frTop.Controls.Add(this.nUPsizeTopY);
            this.frTop.Controls.Add(this.Label45);
            this.frTop.Controls.Add(this.Label32);
            this.frTop.Controls.Add(this.nUPtextureIndexTopX);
            this.frTop.Controls.Add(this.nUPtextureIndexTopZ);
            this.frTop.Controls.Add(this.lbTZT);
            this.frTop.Controls.Add(this.Label8);
            this.frTop.Controls.Add(this.lbTD);
            this.frTop.Controls.Add(this.nUPsizeTopZ);
            this.frTop.Controls.Add(this.nUPsizeTopX);
            this.frTop.Controls.Add(this.lbTW);
            this.frTop.Location = new System.Drawing.Point(19, 415);
            this.frTop.Name = "frTop";
            this.frTop.Size = new System.Drawing.Size(285, 113);
            this.frTop.TabIndex = 79;
            this.frTop.TabStop = false;
            this.frTop.Text = "Top Section";
            // 
            // Label45
            // 
            this.Label45.AutoSize = true;
            this.Label45.Location = new System.Drawing.Point(12, 21);
            this.Label45.Name = "Label45";
            this.Label45.Size = new System.Drawing.Size(43, 13);
            this.Label45.TabIndex = 76;
            this.Label45.Text = "Texture";
            // 
            // lbTZT
            // 
            this.lbTZT.AutoSize = true;
            this.lbTZT.Location = new System.Drawing.Point(211, 62);
            this.lbTZT.Name = "lbTZT";
            this.lbTZT.Size = new System.Drawing.Size(42, 13);
            this.lbTZT.TabIndex = 76;
            this.lbTZT.Text = "Z Tiling";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(70, 62);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(42, 13);
            this.Label8.TabIndex = 76;
            this.Label8.Text = "X Tiling";
            // 
            // lbTD
            // 
            this.lbTD.AutoSize = true;
            this.lbTD.Location = new System.Drawing.Point(210, 22);
            this.lbTD.Name = "lbTD";
            this.lbTD.Size = new System.Drawing.Size(43, 13);
            this.lbTD.TabIndex = 67;
            this.lbTD.Text = "Deep Z";
            // 
            // lbTW
            // 
            this.lbTW.AutoSize = true;
            this.lbTW.Location = new System.Drawing.Point(70, 22);
            this.lbTW.Name = "lbTW";
            this.lbTW.Size = new System.Drawing.Size(45, 13);
            this.lbTW.TabIndex = 66;
            this.lbTW.Text = "Width X";
            // 
            // lbGZT
            // 
            this.lbGZT.AutoSize = true;
            this.lbGZT.Location = new System.Drawing.Point(212, 106);
            this.lbGZT.Name = "lbGZT";
            this.lbGZT.Size = new System.Drawing.Size(42, 13);
            this.lbGZT.TabIndex = 76;
            this.lbGZT.Text = "Z Tiling";
            // 
            // frRoof
            // 
            this.frRoof.Controls.Add(this.nUProofTexture);
            this.frRoof.Controls.Add(this.Label39);
            this.frRoof.Controls.Add(this.nUPtextureIndexRoofX);
            this.frRoof.Controls.Add(this.nUPtextureIndexRoofZ);
            this.frRoof.Controls.Add(this.Label44);
            this.frRoof.Controls.Add(this.Label43);
            this.frRoof.Controls.Add(this.lbGZT);
            this.frRoof.Controls.Add(this.nUPsizeRoofY);
            this.frRoof.Controls.Add(this.nUPRZ);
            this.frRoof.Controls.Add(this.nUPRX);
            this.frRoof.Controls.Add(this.lbFYT);
            this.frRoof.Controls.Add(this.Label2);
            this.frRoof.Controls.Add(this.lbGYT);
            this.frRoof.Controls.Add(this.Label3);
            this.frRoof.Controls.Add(this.lbFXT);
            this.frRoof.Controls.Add(this.lbRH);
            this.frRoof.Controls.Add(this.lbRYT);
            this.frRoof.Controls.Add(this.nUPtextureIndexRoofY);
            this.frRoof.Controls.Add(this.nUPgableTexture);
            this.frRoof.Controls.Add(this.lbG);
            this.frRoof.Controls.Add(this.nUPfaceTexture);
            this.frRoof.Controls.Add(this.lbF);
            this.frRoof.Controls.Add(this.nUPtextureIndexFaceY);
            this.frRoof.Controls.Add(this.nUPtextureIndexFaceX);
            this.frRoof.Controls.Add(this.nUPtextureIndexGableY);
            this.frRoof.Controls.Add(this.nUPtextureIndexGableZ);
            this.frRoof.Location = new System.Drawing.Point(323, 14);
            this.frRoof.Name = "frRoof";
            this.frRoof.Size = new System.Drawing.Size(285, 196);
            this.frRoof.TabIndex = 80;
            this.frRoof.TabStop = false;
            this.frRoof.Text = "Roof Section";
            // 
            // nUPRZ
            // 
            this.nUPRZ.BackColor = System.Drawing.SystemColors.Window;
            this.nUPRZ.DecimalPlaces = 2;
            this.nUPRZ.Enabled = false;
            this.nUPRZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPRZ.Location = new System.Drawing.Point(211, 37);
            this.nUPRZ.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPRZ.Name = "nUPRZ";
            this.nUPRZ.Size = new System.Drawing.Size(55, 20);
            this.nUPRZ.TabIndex = 68;
            this.nUPRZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPRZ.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nUPRX
            // 
            this.nUPRX.BackColor = System.Drawing.SystemColors.Window;
            this.nUPRX.DecimalPlaces = 2;
            this.nUPRX.Enabled = false;
            this.nUPRX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPRX.Location = new System.Drawing.Point(75, 37);
            this.nUPRX.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPRX.Name = "nUPRX";
            this.nUPRX.Size = new System.Drawing.Size(55, 20);
            this.nUPRX.TabIndex = 68;
            this.nUPRX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPRX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lbFYT
            // 
            this.lbFYT.AutoSize = true;
            this.lbFYT.Location = new System.Drawing.Point(144, 146);
            this.lbFYT.Name = "lbFYT";
            this.lbFYT.Size = new System.Drawing.Size(42, 13);
            this.lbFYT.TabIndex = 76;
            this.lbFYT.Text = "Y Tiling";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Enabled = false;
            this.Label2.Location = new System.Drawing.Point(211, 21);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(43, 13);
            this.Label2.TabIndex = 67;
            this.Label2.Text = "Deep Z";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Enabled = false;
            this.Label3.Location = new System.Drawing.Point(70, 21);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(45, 13);
            this.Label3.TabIndex = 66;
            this.Label3.Text = "Width X";
            // 
            // lbFXT
            // 
            this.lbFXT.AutoSize = true;
            this.lbFXT.Location = new System.Drawing.Point(72, 146);
            this.lbFXT.Name = "lbFXT";
            this.lbFXT.Size = new System.Drawing.Size(42, 13);
            this.lbFXT.TabIndex = 76;
            this.lbFXT.Text = "X Tiling";
            // 
            // lbRYT
            // 
            this.lbRYT.AutoSize = true;
            this.lbRYT.Location = new System.Drawing.Point(140, 62);
            this.lbRYT.Name = "lbRYT";
            this.lbRYT.Size = new System.Drawing.Size(42, 13);
            this.lbRYT.TabIndex = 76;
            this.lbRYT.Text = "Y Tiling";
            // 
            // frMulti
            // 
            this.frMulti.Controls.Add(this.ckSmoothing);
            this.frMulti.Controls.Add(this.nUPbuildingSides);
            this.frMulti.Controls.Add(this.lbSides);
            this.frMulti.Location = new System.Drawing.Point(107, 99);
            this.frMulti.Name = "frMulti";
            this.frMulti.Size = new System.Drawing.Size(197, 55);
            this.frMulti.TabIndex = 81;
            this.frMulti.TabStop = false;
            this.frMulti.Text = "MultiSided Building";
            // 
            // nUPGrid
            // 
            this.nUPGrid.BackColor = System.Drawing.SystemColors.Window;
            this.nUPGrid.DecimalPlaces = 1;
            this.nUPGrid.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUPGrid.Location = new System.Drawing.Point(381, 505);
            this.nUPGrid.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nUPGrid.Name = "nUPGrid";
            this.nUPGrid.Size = new System.Drawing.Size(53, 20);
            this.nUPGrid.TabIndex = 82;
            this.nUPGrid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nUPGrid.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(317, 507);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(63, 16);
            this.Label4.TabIndex = 83;
            this.Label4.Text = "Grid meters";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(322, 222);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(269, 13);
            this.Label6.TabIndex = 84;
            this.Label6.Text = "Right mouse to enlarge. Wheel and left mouse to move.";
            // 
            // FrmGBuilding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 547);
            this.ControlBox = false;
            this.Controls.Add(this._imgGenB);
            this.Controls.Add(this.frMulti);
            this.Controls.Add(this.lbgb3);
            this.Controls.Add(this.frRoof);
            this.Controls.Add(this.frTop);
            this.Controls.Add(this.frWindow);
            this.Controls.Add(this.frBottom);
            this.Controls.Add(this.frGenB);
            this.Controls.Add(this.nUPscale);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.nUPGrid);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGBuilding";
            this.Text = "SBuilderXX - Generic Buildings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGBuilding_FormClosing);
            this.Load += new System.EventHandler(this.FrmGBuilding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeBottomY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeWindowY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeTopY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeRoofY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeTopX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeTopZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexBottomX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexBottomZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexWindowX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexWindowY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexWindowZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexTopX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexTopZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexRoofX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexRoofY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexRoofZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPbuildingSides)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPgableTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPfaceTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexGableY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexFaceX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexGableZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtextureIndexFaceY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPsizeZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPscale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPtopTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPbottomTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUProofTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPwindowTexture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._imgGenB)).EndInit();
            this.frGenB.ResumeLayout(false);
            this.frGenB.PerformLayout();
            this.frBottom.ResumeLayout(false);
            this.frBottom.PerformLayout();
            this.frWindow.ResumeLayout(false);
            this.frWindow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPWZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPWX)).EndInit();
            this.frTop.ResumeLayout(false);
            this.frTop.PerformLayout();
            this.frRoof.ResumeLayout(false);
            this.frRoof.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPRZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUPRX)).EndInit();
            this.frMulti.ResumeLayout(false);
            this.frMulti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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