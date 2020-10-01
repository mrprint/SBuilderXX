using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    public partial class FrmLibrary : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrary));
            this._lstBGL = new System.Windows.Forms.ListBox();
            this._cmbLibCat = new System.Windows.Forms.ComboBox();
            this._cmdAdd = new System.Windows.Forms.Button();
            this._lstLib = new System.Windows.Forms.ListBox();
            this.labelFS = new System.Windows.Forms.Label();
            this.frLib = new System.Windows.Forms.GroupBox();
            this._txtLibName = new System.Windows.Forms.TextBox();
            this._txtLibWidth = new System.Windows.Forms.TextBox();
            this._txtLibLength = new System.Windows.Forms.TextBox();
            this._cmdUpdate = new System.Windows.Forms.Button();
            this._txtLibScale = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.LabelLib2 = new System.Windows.Forms.Label();
            this.LabelLib1 = new System.Windows.Forms.Label();
            this.LabelLib3 = new System.Windows.Forms.Label();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdOK = new System.Windows.Forms.Button();
            this.txtBGLFile = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.labelFSTemp = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this._cmdNewCat = new System.Windows.Forms.Button();
            this.txtLibID = new System.Windows.Forms.TextBox();
            this.txtBGLID = new System.Windows.Forms.TextBox();
            this._cmdBGL = new System.Windows.Forms.Button();
            this._cmdDown = new System.Windows.Forms.Button();
            this._cmdUP = new System.Windows.Forms.Button();
            this.imgLib = new System.Windows.Forms.PictureBox();
            this._cmdRemove = new System.Windows.Forms.Button();
            this.LabelNoBGLs = new System.Windows.Forms.Label();
            this.LabelNoLIBs = new System.Windows.Forms.Label();
            this._cmdAZ = new System.Windows.Forms.Button();
            this._cmdEditCat = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.frLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLib)).BeginInit();
            this.SuspendLayout();
            // 
            // _lstBGL
            // 
            this._lstBGL.FormattingEnabled = true;
            this._lstBGL.Location = new System.Drawing.Point(504, 54);
            this._lstBGL.Name = "_lstBGL";
            this._lstBGL.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._lstBGL.Size = new System.Drawing.Size(224, 147);
            this._lstBGL.TabIndex = 3;
            this._lstBGL.SelectedIndexChanged += new System.EventHandler(this.LstBGL_SelectedIndexChanged);
            // 
            // _cmbLibCat
            // 
            this._cmbLibCat.FormattingEnabled = true;
            this._cmbLibCat.Location = new System.Drawing.Point(235, 27);
            this._cmbLibCat.Name = "_cmbLibCat";
            this._cmbLibCat.Size = new System.Drawing.Size(224, 21);
            this._cmbLibCat.TabIndex = 4;
            this._cmbLibCat.SelectedIndexChanged += new System.EventHandler(this.CmbLibCat_SelectedIndexChanged);
            // 
            // _cmdAdd
            // 
            this._cmdAdd.Image = ((System.Drawing.Image)(resources.GetObject("_cmdAdd.Image")));
            this._cmdAdd.Location = new System.Drawing.Point(465, 178);
            this._cmdAdd.Name = "_cmdAdd";
            this._cmdAdd.Size = new System.Drawing.Size(33, 23);
            this._cmdAdd.TabIndex = 5;
            this._cmdAdd.UseVisualStyleBackColor = true;
            this._cmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // _lstLib
            // 
            this._lstLib.FormattingEnabled = true;
            this._lstLib.Location = new System.Drawing.Point(235, 54);
            this._lstLib.Name = "_lstLib";
            this._lstLib.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this._lstLib.Size = new System.Drawing.Size(224, 147);
            this._lstLib.TabIndex = 6;
            this._lstLib.SelectedIndexChanged += new System.EventHandler(this.LstLib_SelectedIndexChanged);
            // 
            // labelFS
            // 
            this.labelFS.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelFS.AutoSize = true;
            this.labelFS.BackColor = System.Drawing.Color.Transparent;
            this.labelFS.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFS.Location = new System.Drawing.Point(306, 211);
            this.labelFS.Name = "labelFS";
            this.labelFS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFS.Size = new System.Drawing.Size(153, 13);
            this.labelFS.TabIndex = 103;
            this.labelFS.Text = "Categorized FS9 Library Object";
            this.labelFS.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frLib
            // 
            this.frLib.BackColor = System.Drawing.Color.Transparent;
            this.frLib.Controls.Add(this._txtLibName);
            this.frLib.Controls.Add(this._txtLibWidth);
            this.frLib.Controls.Add(this._txtLibLength);
            this.frLib.Controls.Add(this._cmdUpdate);
            this.frLib.Controls.Add(this._txtLibScale);
            this.frLib.Controls.Add(this.Label2);
            this.frLib.Controls.Add(this.LabelLib2);
            this.frLib.Controls.Add(this.LabelLib1);
            this.frLib.Controls.Add(this.LabelLib3);
            this.frLib.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.frLib.Location = new System.Drawing.Point(12, 11);
            this.frLib.Name = "frLib";
            this.frLib.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.frLib.Size = new System.Drawing.Size(208, 91);
            this.frLib.TabIndex = 102;
            this.frLib.TabStop = false;
            this.frLib.Text = "Change Name Scale and Footprint";
            // 
            // _txtLibName
            // 
            this._txtLibName.AcceptsReturn = true;
            this._txtLibName.BackColor = System.Drawing.SystemColors.Window;
            this._txtLibName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLibName.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLibName.Location = new System.Drawing.Point(54, 63);
            this._txtLibName.MaxLength = 0;
            this._txtLibName.Name = "_txtLibName";
            this._txtLibName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLibName.Size = new System.Drawing.Size(140, 20);
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
            // _cmdUpdate
            // 
            this._cmdUpdate.Enabled = false;
            this._cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUpdate.Location = new System.Drawing.Point(163, 29);
            this._cmdUpdate.Name = "_cmdUpdate";
            this._cmdUpdate.Size = new System.Drawing.Size(31, 23);
            this._cmdUpdate.TabIndex = 105;
            this._cmdUpdate.Text = "OK";
            this._cmdUpdate.UseVisualStyleBackColor = true;
            this._cmdUpdate.Click += new System.EventHandler(this.CmdUpdate_Click);
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
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(13, 66);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(51, 19);
            this.Label2.TabIndex = 39;
            this.Label2.Text = "Name:";
            // 
            // LabelLib2
            // 
            this.LabelLib2.BackColor = System.Drawing.Color.Transparent;
            this.LabelLib2.Cursor = System.Windows.Forms.Cursors.Default;
            this.LabelLib2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LabelLib2.Location = new System.Drawing.Point(13, 17);
            this.LabelLib2.Name = "LabelLib2";
            this.LabelLib2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelLib2.Size = new System.Drawing.Size(51, 19);
            this.LabelLib2.TabIndex = 39;
            this.LabelLib2.Text = "Length:";
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
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(600, 262);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(55, 23);
            this._cmdCancel.TabIndex = 104;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(673, 262);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(55, 23);
            this._cmdOK.TabIndex = 105;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // txtBGLFile
            // 
            this.txtBGLFile.AcceptsReturn = true;
            this.txtBGLFile.BackColor = System.Drawing.SystemColors.Window;
            this.txtBGLFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBGLFile.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBGLFile.Location = new System.Drawing.Point(504, 27);
            this.txtBGLFile.MaxLength = 0;
            this.txtBGLFile.Name = "txtBGLFile";
            this.txtBGLFile.ReadOnly = true;
            this.txtBGLFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBGLFile.Size = new System.Drawing.Size(181, 20);
            this.txtBGLFile.TabIndex = 109;
            this.txtBGLFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(501, 12);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(179, 13);
            this.Label1.TabIndex = 103;
            this.Label1.Text = "Get Temporary Objects from BGL file";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFSTemp
            // 
            this.labelFSTemp.AutoSize = true;
            this.labelFSTemp.BackColor = System.Drawing.Color.Transparent;
            this.labelFSTemp.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFSTemp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelFSTemp.Location = new System.Drawing.Point(581, 211);
            this.labelFSTemp.Name = "labelFSTemp";
            this.labelFSTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelFSTemp.Size = new System.Drawing.Size(147, 13);
            this.labelFSTemp.TabIndex = 103;
            this.labelFSTemp.Text = "Temporary FS9 Library Object";
            this.labelFSTemp.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(363, 11);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(96, 13);
            this.Label3.TabIndex = 103;
            this.Label3.Text = "Existing Categories";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _cmdNewCat
            // 
            this._cmdNewCat.Location = new System.Drawing.Point(405, 262);
            this._cmdNewCat.Name = "_cmdNewCat";
            this._cmdNewCat.Size = new System.Drawing.Size(54, 23);
            this._cmdNewCat.TabIndex = 5;
            this._cmdNewCat.Text = "New";
            this._cmdNewCat.UseVisualStyleBackColor = true;
            this._cmdNewCat.Click += new System.EventHandler(this.CmdNewCat_Click);
            // 
            // txtLibID
            // 
            this.txtLibID.AcceptsReturn = true;
            this.txtLibID.BackColor = System.Drawing.SystemColors.Window;
            this.txtLibID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLibID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLibID.Location = new System.Drawing.Point(235, 227);
            this.txtLibID.MaxLength = 0;
            this.txtLibID.Name = "txtLibID";
            this.txtLibID.ReadOnly = true;
            this.txtLibID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLibID.Size = new System.Drawing.Size(224, 20);
            this.txtLibID.TabIndex = 110;
            this.txtLibID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBGLID
            // 
            this.txtBGLID.AcceptsReturn = true;
            this.txtBGLID.BackColor = System.Drawing.SystemColors.Window;
            this.txtBGLID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBGLID.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtBGLID.Location = new System.Drawing.Point(504, 227);
            this.txtBGLID.MaxLength = 0;
            this.txtBGLID.Name = "txtBGLID";
            this.txtBGLID.ReadOnly = true;
            this.txtBGLID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBGLID.Size = new System.Drawing.Size(224, 20);
            this.txtBGLID.TabIndex = 110;
            this.txtBGLID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdBGL
            // 
            this._cmdBGL.Location = new System.Drawing.Point(691, 25);
            this._cmdBGL.Name = "_cmdBGL";
            this._cmdBGL.Size = new System.Drawing.Size(37, 23);
            this._cmdBGL.TabIndex = 5;
            this._cmdBGL.Text = "...";
            this._cmdBGL.UseVisualStyleBackColor = true;
            this._cmdBGL.Click += new System.EventHandler(this.CmdBGL_Click);
            // 
            // _cmdDown
            // 
            this._cmdDown.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDown.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDown.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDown.Image")));
            this._cmdDown.Location = new System.Drawing.Point(465, 116);
            this._cmdDown.Name = "_cmdDown";
            this._cmdDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDown.Size = new System.Drawing.Size(25, 25);
            this._cmdDown.TabIndex = 111;
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
            this._cmdUP.Location = new System.Drawing.Point(465, 85);
            this._cmdUP.Name = "_cmdUP";
            this._cmdUP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdUP.Size = new System.Drawing.Size(25, 25);
            this._cmdUP.TabIndex = 111;
            this._cmdUP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdUP.UseVisualStyleBackColor = false;
            this._cmdUP.Click += new System.EventHandler(this.CmdUP_Click);
            // 
            // imgLib
            // 
            this.imgLib.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgLib.Location = new System.Drawing.Point(12, 116);
            this.imgLib.Name = "imgLib";
            this.imgLib.Size = new System.Drawing.Size(208, 169);
            this.imgLib.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgLib.TabIndex = 100;
            this.imgLib.TabStop = false;
            // 
            // _cmdRemove
            // 
            this._cmdRemove.Image = ((System.Drawing.Image)(resources.GetObject("_cmdRemove.Image")));
            this._cmdRemove.Location = new System.Drawing.Point(465, 147);
            this._cmdRemove.Name = "_cmdRemove";
            this._cmdRemove.Size = new System.Drawing.Size(33, 23);
            this._cmdRemove.TabIndex = 5;
            this._cmdRemove.UseVisualStyleBackColor = true;
            this._cmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // LabelNoBGLs
            // 
            this.LabelNoBGLs.AutoSize = true;
            this.LabelNoBGLs.Location = new System.Drawing.Point(501, 206);
            this.LabelNoBGLs.Name = "LabelNoBGLs";
            this.LabelNoBGLs.Size = new System.Drawing.Size(33, 13);
            this.LabelNoBGLs.TabIndex = 112;
            this.LabelNoBGLs.Text = "BGLs";
            // 
            // LabelNoLIBs
            // 
            this.LabelNoLIBs.AutoSize = true;
            this.LabelNoLIBs.Location = new System.Drawing.Point(232, 206);
            this.LabelNoLIBs.Name = "LabelNoLIBs";
            this.LabelNoLIBs.Size = new System.Drawing.Size(28, 13);
            this.LabelNoLIBs.TabIndex = 112;
            this.LabelNoLIBs.Text = "LIBs";
            // 
            // _cmdAZ
            // 
            this._cmdAZ.BackColor = System.Drawing.SystemColors.Control;
            this._cmdAZ.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAZ.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAZ.Image = ((System.Drawing.Image)(resources.GetObject("_cmdAZ.Image")));
            this._cmdAZ.Location = new System.Drawing.Point(465, 54);
            this._cmdAZ.Name = "_cmdAZ";
            this._cmdAZ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAZ.Size = new System.Drawing.Size(25, 25);
            this._cmdAZ.TabIndex = 111;
            this._cmdAZ.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdAZ.UseVisualStyleBackColor = false;
            this._cmdAZ.Click += new System.EventHandler(this.CmdAZ_Click);
            // 
            // _cmdEditCat
            // 
            this._cmdEditCat.Location = new System.Drawing.Point(345, 262);
            this._cmdEditCat.Name = "_cmdEditCat";
            this._cmdEditCat.Size = new System.Drawing.Size(54, 23);
            this._cmdEditCat.TabIndex = 5;
            this._cmdEditCat.Text = "Name";
            this._cmdEditCat.UseVisualStyleBackColor = true;
            this._cmdEditCat.Click += new System.EventHandler(this.CmdEditCat_Click);
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(214, 255);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(128, 30);
            this.Label4.TabIndex = 113;
            this.Label4.Text = "Change the Name or create a New category";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 299);
            this.Controls.Add(this.LabelNoLIBs);
            this.Controls.Add(this.LabelNoBGLs);
            this.Controls.Add(this._cmdDown);
            this.Controls.Add(this._cmdAZ);
            this.Controls.Add(this._cmdUP);
            this.Controls.Add(this.txtBGLID);
            this.Controls.Add(this.txtLibID);
            this.Controls.Add(this.txtBGLFile);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.imgLib);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.labelFSTemp);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.labelFS);
            this.Controls.Add(this.frLib);
            this.Controls.Add(this._lstLib);
            this.Controls.Add(this._cmdAdd);
            this.Controls.Add(this._cmdBGL);
            this.Controls.Add(this._cmdEditCat);
            this.Controls.Add(this._cmdNewCat);
            this.Controls.Add(this._cmdRemove);
            this.Controls.Add(this._cmbLibCat);
            this.Controls.Add(this._lstBGL);
            this.Controls.Add(this.Label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLibrary";
            this.Text = "SBuilderXX - Object Library Manager";
            this.Load += new System.EventHandler(this.FrmLibrary_Load);
            this.frLib.ResumeLayout(false);
            this.frLib.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLib)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ListBox _lstBGL;

        internal ListBox lstBGL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lstBGL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lstBGL != null)
                {
                    _lstBGL.SelectedIndexChanged -= LstBGL_SelectedIndexChanged;
                }

                _lstBGL = value;
                if (_lstBGL != null)
                {
                    _lstBGL.SelectedIndexChanged += LstBGL_SelectedIndexChanged;
                }
            }
        }

        private ComboBox _cmbLibCat;

        internal ComboBox cmbLibCat
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

        private Button _cmdRemove;

        internal Button cmdRemove
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdRemove;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdRemove != null)
                {
                    _cmdRemove.Click -= CmdRemove_Click;
                }

                _cmdRemove = value;
                if (_cmdRemove != null)
                {
                    _cmdRemove.Click += CmdRemove_Click;
                }
            }
        }

        private Button _cmdAdd;

        internal Button cmdAdd
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAdd;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAdd != null)
                {
                    _cmdAdd.Click -= CmdAdd_Click;
                }

                _cmdAdd = value;
                if (_cmdAdd != null)
                {
                    _cmdAdd.Click += CmdAdd_Click;
                }
            }
        }

        private ListBox _lstLib;

        internal ListBox lstLib
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

        public PictureBox imgLib;
        public Label labelFS;
        public GroupBox frLib;
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

        public Label LabelLib1;
        public Label LabelLib3;
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

        public TextBox txtBGLFile;
        public Label Label1;
        public Label labelFSTemp;
        public Label Label3;
        private Button _cmdNewCat;

        internal Button cmdNewCat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdNewCat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdNewCat != null)
                {
                    _cmdNewCat.Click -= CmdNewCat_Click;
                }

                _cmdNewCat = value;
                if (_cmdNewCat != null)
                {
                    _cmdNewCat.Click += CmdNewCat_Click;
                }
            }
        }

        private Button _cmdUpdate;

        internal Button cmdUpdate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUpdate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUpdate != null)
                {
                    _cmdUpdate.Click -= CmdUpdate_Click;
                }

                _cmdUpdate = value;
                if (_cmdUpdate != null)
                {
                    _cmdUpdate.Click += CmdUpdate_Click;
                }
            }
        }

        public TextBox txtLibID;
        public TextBox txtBGLID;
        private Button _cmdBGL;

        internal Button cmdBGL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdBGL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdBGL != null)
                {
                    _cmdBGL.Click -= CmdBGL_Click;
                }

                _cmdBGL = value;
                if (_cmdBGL != null)
                {
                    _cmdBGL.Click += CmdBGL_Click;
                }
            }
        }

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

        internal Label LabelNoBGLs;
        internal Label LabelNoLIBs;
        private Button _cmdAZ;

        public Button cmdAZ
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAZ;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAZ != null)
                {
                    _cmdAZ.Click -= CmdAZ_Click;
                }

                _cmdAZ = value;
                if (_cmdAZ != null)
                {
                    _cmdAZ.Click += CmdAZ_Click;
                }
            }
        }

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

        public Label Label2;
        public Label LabelLib2;
        private Button _cmdEditCat;

        internal Button cmdEditCat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdEditCat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdEditCat != null)
                {
                    _cmdEditCat.Click -= CmdEditCat_Click;
                }

                _cmdEditCat = value;
                if (_cmdEditCat != null)
                {
                    _cmdEditCat.Click += CmdEditCat_Click;
                }
            }
        }

        internal Label Label4;
    }
}