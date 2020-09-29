using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLibrary));
            _lstBGL = new ListBox();
            _lstBGL.SelectedIndexChanged += new EventHandler(LstBGL_SelectedIndexChanged);
            _cmbLibCat = new ComboBox();
            _cmbLibCat.SelectedIndexChanged += new EventHandler(CmbLibCat_SelectedIndexChanged);
            _cmdAdd = new Button();
            _cmdAdd.Click += new EventHandler(CmdAdd_Click);
            _lstLib = new ListBox();
            _lstLib.SelectedIndexChanged += new EventHandler(LstLib_SelectedIndexChanged);
            labelFS = new Label();
            frLib = new GroupBox();
            _txtLibName = new TextBox();
            _txtLibName.TextChanged += new EventHandler(TxtLibName_TextChanged);
            _txtLibWidth = new TextBox();
            _txtLibWidth.TextChanged += new EventHandler(TxtLibWidth_TextChanged);
            _txtLibLength = new TextBox();
            _txtLibLength.TextChanged += new EventHandler(TxtLibLength_TextChanged);
            _cmdUpdate = new Button();
            _cmdUpdate.Click += new EventHandler(CmdUpdate_Click);
            _txtLibScale = new TextBox();
            _txtLibScale.TextChanged += new EventHandler(TxtLibScale_TextChanged);
            Label2 = new Label();
            LabelLib2 = new Label();
            LabelLib1 = new Label();
            LabelLib3 = new Label();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            txtBGLFile = new TextBox();
            Label1 = new Label();
            labelFSTemp = new Label();
            Label3 = new Label();
            _cmdNewCat = new Button();
            _cmdNewCat.Click += new EventHandler(CmdNewCat_Click);
            txtLibID = new TextBox();
            txtBGLID = new TextBox();
            _cmdBGL = new Button();
            _cmdBGL.Click += new EventHandler(CmdBGL_Click);
            _cmdDown = new Button();
            _cmdDown.Click += new EventHandler(CmdDown_Click);
            _cmdUP = new Button();
            _cmdUP.Click += new EventHandler(CmdUP_Click);
            imgLib = new PictureBox();
            _cmdRemove = new Button();
            _cmdRemove.Click += new EventHandler(CmdRemove_Click);
            LabelNoBGLs = new Label();
            LabelNoLIBs = new Label();
            _cmdAZ = new Button();
            _cmdAZ.Click += new EventHandler(CmdAZ_Click);
            _cmdEditCat = new Button();
            _cmdEditCat.Click += new EventHandler(CmdEditCat_Click);
            Label4 = new Label();
            frLib.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgLib).BeginInit();
            SuspendLayout();
            // 
            // lstBGL
            // 
            _lstBGL.FormattingEnabled = true;
            _lstBGL.Location = new Point(504, 54);
            _lstBGL.Name = "_lstBGL";
            _lstBGL.SelectionMode = SelectionMode.MultiExtended;
            _lstBGL.Size = new Size(224, 147);
            _lstBGL.TabIndex = 3;
            // 
            // cmbLibCat
            // 
            _cmbLibCat.FormattingEnabled = true;
            _cmbLibCat.Location = new Point(235, 27);
            _cmbLibCat.Name = "_cmbLibCat";
            _cmbLibCat.Size = new Size(224, 21);
            _cmbLibCat.TabIndex = 4;
            // 
            // cmdAdd
            // 
            _cmdAdd.Image = (Image)resources.GetObject("cmdAdd.Image");
            _cmdAdd.Location = new Point(465, 178);
            _cmdAdd.Name = "_cmdAdd";
            _cmdAdd.Size = new Size(33, 23);
            _cmdAdd.TabIndex = 5;
            _cmdAdd.UseVisualStyleBackColor = true;
            // 
            // lstLib
            // 
            _lstLib.FormattingEnabled = true;
            _lstLib.Location = new Point(235, 54);
            _lstLib.Name = "_lstLib";
            _lstLib.SelectionMode = SelectionMode.MultiExtended;
            _lstLib.Size = new Size(224, 147);
            _lstLib.TabIndex = 6;
            // 
            // labelFS
            // 
            labelFS.Anchor = AnchorStyles.Right;
            labelFS.AutoSize = true;
            labelFS.BackColor = Color.Transparent;
            labelFS.Cursor = Cursors.Default;
            labelFS.ForeColor = SystemColors.ControlText;
            labelFS.Location = new Point(306, 211);
            labelFS.Name = "labelFS";
            labelFS.RightToLeft = RightToLeft.No;
            labelFS.Size = new Size(153, 13);
            labelFS.TabIndex = 103;
            labelFS.Text = "Categorized FS9 Library Object";
            labelFS.TextAlign = ContentAlignment.TopRight;
            // 
            // frLib
            // 
            frLib.BackColor = Color.Transparent;
            frLib.Controls.Add(_txtLibName);
            frLib.Controls.Add(_txtLibWidth);
            frLib.Controls.Add(_txtLibLength);
            frLib.Controls.Add(_cmdUpdate);
            frLib.Controls.Add(_txtLibScale);
            frLib.Controls.Add(Label2);
            frLib.Controls.Add(LabelLib2);
            frLib.Controls.Add(LabelLib1);
            frLib.Controls.Add(LabelLib3);
            frLib.ForeColor = SystemColors.MenuHighlight;
            frLib.Location = new Point(12, 11);
            frLib.Name = "frLib";
            frLib.RightToLeft = RightToLeft.No;
            frLib.Size = new Size(208, 91);
            frLib.TabIndex = 102;
            frLib.TabStop = false;
            frLib.Text = "Change Name Scale and Footprint";
            // 
            // txtLibName
            // 
            _txtLibName.AcceptsReturn = true;
            _txtLibName.BackColor = SystemColors.Window;
            _txtLibName.Cursor = Cursors.IBeam;
            _txtLibName.ForeColor = SystemColors.WindowText;
            _txtLibName.Location = new Point(54, 63);
            _txtLibName.MaxLength = 0;
            _txtLibName.Name = "_txtLibName";
            _txtLibName.RightToLeft = RightToLeft.No;
            _txtLibName.Size = new Size(140, 20);
            _txtLibName.TabIndex = 106;
            _txtLibName.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLibWidth
            // 
            _txtLibWidth.AcceptsReturn = true;
            _txtLibWidth.BackColor = SystemColors.Window;
            _txtLibWidth.Cursor = Cursors.IBeam;
            _txtLibWidth.ForeColor = SystemColors.WindowText;
            _txtLibWidth.Location = new Point(70, 32);
            _txtLibWidth.MaxLength = 0;
            _txtLibWidth.Name = "_txtLibWidth";
            _txtLibWidth.RightToLeft = RightToLeft.No;
            _txtLibWidth.Size = new Size(44, 20);
            _txtLibWidth.TabIndex = 37;
            _txtLibWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLibLength
            // 
            _txtLibLength.AcceptsReturn = true;
            _txtLibLength.BackColor = SystemColors.Window;
            _txtLibLength.Cursor = Cursors.IBeam;
            _txtLibLength.ForeColor = SystemColors.WindowText;
            _txtLibLength.Location = new Point(16, 32);
            _txtLibLength.MaxLength = 0;
            _txtLibLength.Name = "_txtLibLength";
            _txtLibLength.RightToLeft = RightToLeft.No;
            _txtLibLength.Size = new Size(45, 20);
            _txtLibLength.TabIndex = 36;
            _txtLibLength.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdUpdate
            // 
            _cmdUpdate.Enabled = false;
            _cmdUpdate.ForeColor = SystemColors.ControlText;
            _cmdUpdate.Location = new Point(163, 29);
            _cmdUpdate.Name = "_cmdUpdate";
            _cmdUpdate.Size = new Size(31, 23);
            _cmdUpdate.TabIndex = 105;
            _cmdUpdate.Text = "OK";
            _cmdUpdate.UseVisualStyleBackColor = true;
            // 
            // txtLibScale
            // 
            _txtLibScale.AcceptsReturn = true;
            _txtLibScale.BackColor = SystemColors.Window;
            _txtLibScale.Cursor = Cursors.IBeam;
            _txtLibScale.ForeColor = SystemColors.WindowText;
            _txtLibScale.Location = new Point(123, 32);
            _txtLibScale.MaxLength = 0;
            _txtLibScale.Name = "_txtLibScale";
            _txtLibScale.RightToLeft = RightToLeft.No;
            _txtLibScale.Size = new Size(29, 20);
            _txtLibScale.TabIndex = 34;
            _txtLibScale.Text = "1";
            _txtLibScale.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.BackColor = Color.Transparent;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(13, 66);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(51, 19);
            Label2.TabIndex = 39;
            Label2.Text = "Name:";
            // 
            // LabelLib2
            // 
            LabelLib2.BackColor = Color.Transparent;
            LabelLib2.Cursor = Cursors.Default;
            LabelLib2.ForeColor = SystemColors.ControlText;
            LabelLib2.Location = new Point(13, 17);
            LabelLib2.Name = "LabelLib2";
            LabelLib2.RightToLeft = RightToLeft.No;
            LabelLib2.Size = new Size(51, 19);
            LabelLib2.TabIndex = 39;
            LabelLib2.Text = "Length:";
            // 
            // LabelLib1
            // 
            LabelLib1.BackColor = Color.Transparent;
            LabelLib1.Cursor = Cursors.Default;
            LabelLib1.ForeColor = SystemColors.ControlText;
            LabelLib1.Location = new Point(67, 17);
            LabelLib1.Name = "LabelLib1";
            LabelLib1.RightToLeft = RightToLeft.No;
            LabelLib1.Size = new Size(38, 18);
            LabelLib1.TabIndex = 38;
            LabelLib1.Text = "Width:";
            // 
            // LabelLib3
            // 
            LabelLib3.BackColor = Color.Transparent;
            LabelLib3.Cursor = Cursors.Default;
            LabelLib3.ForeColor = SystemColors.ControlText;
            LabelLib3.Location = new Point(120, 17);
            LabelLib3.Name = "LabelLib3";
            LabelLib3.RightToLeft = RightToLeft.No;
            LabelLib3.Size = new Size(37, 16);
            LabelLib3.TabIndex = 35;
            LabelLib3.Text = "Scale:";
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(600, 262);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(55, 23);
            _cmdCancel.TabIndex = 104;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(673, 262);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(55, 23);
            _cmdOK.TabIndex = 105;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // txtBGLFile
            // 
            txtBGLFile.AcceptsReturn = true;
            txtBGLFile.BackColor = SystemColors.Window;
            txtBGLFile.Cursor = Cursors.IBeam;
            txtBGLFile.ForeColor = SystemColors.WindowText;
            txtBGLFile.Location = new Point(504, 27);
            txtBGLFile.MaxLength = 0;
            txtBGLFile.Name = "txtBGLFile";
            txtBGLFile.ReadOnly = true;
            txtBGLFile.RightToLeft = RightToLeft.No;
            txtBGLFile.Size = new Size(181, 20);
            txtBGLFile.TabIndex = 109;
            txtBGLFile.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = Color.Transparent;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(501, 12);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(179, 13);
            Label1.TabIndex = 103;
            Label1.Text = "Get Temporary Objects from BGL file";
            Label1.TextAlign = ContentAlignment.TopRight;
            // 
            // labelFSTemp
            // 
            labelFSTemp.AutoSize = true;
            labelFSTemp.BackColor = Color.Transparent;
            labelFSTemp.Cursor = Cursors.Default;
            labelFSTemp.ForeColor = SystemColors.ControlText;
            labelFSTemp.Location = new Point(581, 211);
            labelFSTemp.Name = "labelFSTemp";
            labelFSTemp.RightToLeft = RightToLeft.No;
            labelFSTemp.Size = new Size(147, 13);
            labelFSTemp.TabIndex = 103;
            labelFSTemp.Text = "Temporary FS9 Library Object";
            labelFSTemp.TextAlign = ContentAlignment.TopRight;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = Color.Transparent;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(363, 11);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(96, 13);
            Label3.TabIndex = 103;
            Label3.Text = "Existing Categories";
            Label3.TextAlign = ContentAlignment.TopRight;
            // 
            // cmdNewCat
            // 
            _cmdNewCat.Location = new Point(405, 262);
            _cmdNewCat.Name = "_cmdNewCat";
            _cmdNewCat.Size = new Size(54, 23);
            _cmdNewCat.TabIndex = 5;
            _cmdNewCat.Text = "New";
            _cmdNewCat.UseVisualStyleBackColor = true;
            // 
            // txtLibID
            // 
            txtLibID.AcceptsReturn = true;
            txtLibID.BackColor = SystemColors.Window;
            txtLibID.Cursor = Cursors.IBeam;
            txtLibID.ForeColor = SystemColors.WindowText;
            txtLibID.Location = new Point(235, 227);
            txtLibID.MaxLength = 0;
            txtLibID.Name = "txtLibID";
            txtLibID.ReadOnly = true;
            txtLibID.RightToLeft = RightToLeft.No;
            txtLibID.Size = new Size(224, 20);
            txtLibID.TabIndex = 110;
            txtLibID.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBGLID
            // 
            txtBGLID.AcceptsReturn = true;
            txtBGLID.BackColor = SystemColors.Window;
            txtBGLID.Cursor = Cursors.IBeam;
            txtBGLID.ForeColor = SystemColors.WindowText;
            txtBGLID.Location = new Point(504, 227);
            txtBGLID.MaxLength = 0;
            txtBGLID.Name = "txtBGLID";
            txtBGLID.ReadOnly = true;
            txtBGLID.RightToLeft = RightToLeft.No;
            txtBGLID.Size = new Size(224, 20);
            txtBGLID.TabIndex = 110;
            txtBGLID.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdBGL
            // 
            _cmdBGL.Location = new Point(691, 25);
            _cmdBGL.Name = "_cmdBGL";
            _cmdBGL.Size = new Size(37, 23);
            _cmdBGL.TabIndex = 5;
            _cmdBGL.Text = "...";
            _cmdBGL.UseVisualStyleBackColor = true;
            // 
            // cmdDown
            // 
            _cmdDown.BackColor = SystemColors.Control;
            _cmdDown.Cursor = Cursors.Default;
            _cmdDown.ForeColor = SystemColors.ControlText;
            _cmdDown.Image = (Image)resources.GetObject("cmdDown.Image");
            _cmdDown.Location = new Point(465, 116);
            _cmdDown.Name = "_cmdDown";
            _cmdDown.RightToLeft = RightToLeft.No;
            _cmdDown.Size = new Size(25, 25);
            _cmdDown.TabIndex = 111;
            _cmdDown.TextAlign = ContentAlignment.BottomCenter;
            _cmdDown.UseVisualStyleBackColor = false;
            // 
            // cmdUP
            // 
            _cmdUP.BackColor = SystemColors.Control;
            _cmdUP.Cursor = Cursors.Default;
            _cmdUP.ForeColor = SystemColors.ControlText;
            _cmdUP.Image = (Image)resources.GetObject("cmdUP.Image");
            _cmdUP.Location = new Point(465, 85);
            _cmdUP.Name = "_cmdUP";
            _cmdUP.RightToLeft = RightToLeft.No;
            _cmdUP.Size = new Size(25, 25);
            _cmdUP.TabIndex = 111;
            _cmdUP.TextAlign = ContentAlignment.BottomCenter;
            _cmdUP.UseVisualStyleBackColor = false;
            // 
            // imgLib
            // 
            imgLib.Cursor = Cursors.Default;
            imgLib.Location = new Point(12, 116);
            imgLib.Name = "imgLib";
            imgLib.Size = new Size(208, 169);
            imgLib.SizeMode = PictureBoxSizeMode.StretchImage;
            imgLib.TabIndex = 100;
            imgLib.TabStop = false;
            // 
            // cmdRemove
            // 
            _cmdRemove.Image = (Image)resources.GetObject("cmdRemove.Image");
            _cmdRemove.Location = new Point(465, 147);
            _cmdRemove.Name = "_cmdRemove";
            _cmdRemove.Size = new Size(33, 23);
            _cmdRemove.TabIndex = 5;
            _cmdRemove.UseVisualStyleBackColor = true;
            // 
            // LabelNoBGLs
            // 
            LabelNoBGLs.AutoSize = true;
            LabelNoBGLs.Location = new Point(501, 206);
            LabelNoBGLs.Name = "LabelNoBGLs";
            LabelNoBGLs.Size = new Size(33, 13);
            LabelNoBGLs.TabIndex = 112;
            LabelNoBGLs.Text = "BGLs";
            // 
            // LabelNoLIBs
            // 
            LabelNoLIBs.AutoSize = true;
            LabelNoLIBs.Location = new Point(232, 206);
            LabelNoLIBs.Name = "LabelNoLIBs";
            LabelNoLIBs.Size = new Size(28, 13);
            LabelNoLIBs.TabIndex = 112;
            LabelNoLIBs.Text = "LIBs";
            // 
            // cmdAZ
            // 
            _cmdAZ.BackColor = SystemColors.Control;
            _cmdAZ.Cursor = Cursors.Default;
            _cmdAZ.ForeColor = SystemColors.ControlText;
            _cmdAZ.Image = (Image)resources.GetObject("cmdAZ.Image");
            _cmdAZ.Location = new Point(465, 54);
            _cmdAZ.Name = "_cmdAZ";
            _cmdAZ.RightToLeft = RightToLeft.No;
            _cmdAZ.Size = new Size(25, 25);
            _cmdAZ.TabIndex = 111;
            _cmdAZ.TextAlign = ContentAlignment.BottomCenter;
            _cmdAZ.UseVisualStyleBackColor = false;
            // 
            // cmdEditCat
            // 
            _cmdEditCat.Location = new Point(345, 262);
            _cmdEditCat.Name = "_cmdEditCat";
            _cmdEditCat.Size = new Size(54, 23);
            _cmdEditCat.TabIndex = 5;
            _cmdEditCat.Text = "Name";
            _cmdEditCat.UseVisualStyleBackColor = true;
            // 
            // Label4
            // 
            Label4.Location = new Point(214, 255);
            Label4.Name = "Label4";
            Label4.Size = new Size(128, 30);
            Label4.TabIndex = 113;
            Label4.Text = "Change the Name or create a New category";
            Label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmLibrary
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 299);
            Controls.Add(LabelNoLIBs);
            Controls.Add(LabelNoBGLs);
            Controls.Add(_cmdDown);
            Controls.Add(_cmdAZ);
            Controls.Add(_cmdUP);
            Controls.Add(txtBGLID);
            Controls.Add(txtLibID);
            Controls.Add(txtBGLFile);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(imgLib);
            Controls.Add(Label1);
            Controls.Add(labelFSTemp);
            Controls.Add(Label3);
            Controls.Add(labelFS);
            Controls.Add(frLib);
            Controls.Add(_lstLib);
            Controls.Add(_cmdAdd);
            Controls.Add(_cmdBGL);
            Controls.Add(_cmdEditCat);
            Controls.Add(_cmdNewCat);
            Controls.Add(_cmdRemove);
            Controls.Add(_cmbLibCat);
            Controls.Add(_lstBGL);
            Controls.Add(Label4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLibrary";
            Text = "SBuilderX - Object Library Manager";
            frLib.ResumeLayout(false);
            frLib.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgLib).EndInit();
            Load += new EventHandler(FrmLibrary_Load);
            ResumeLayout(false);
            PerformLayout();
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