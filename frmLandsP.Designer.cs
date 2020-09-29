using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmLandsP : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLandsP));
            Label2 = new Label();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdClose = new Button();
            _cmdClose.Click += new EventHandler(CmdClose_Click);
            _List1 = new ListBox();
            _List1.SelectedIndexChanged += new EventHandler(List1_SelectedIndexChanged);
            Frame1 = new GroupBox();
            _cmdAuto = new Button();
            _cmdAuto.Click += new EventHandler(CmdAuto_Click);
            _cmdEdit = new Button();
            _cmdEdit.Click += new EventHandler(CmdEdit_Click);
            Label3 = new Label();
            _lbLand = new Label();
            _lbLand.Click += new EventHandler(LbLand_Click);
            _ImgText = new PictureBox();
            _ImgText.Click += new EventHandler(ImgText_Click);
            GroupBox1 = new GroupBox();
            _ck4 = new RadioButton();
            _ck4.CheckedChanged += new EventHandler(Ck4_CheckedChanged);
            _ck2 = new RadioButton();
            _ck2.CheckedChanged += new EventHandler(Ck2_CheckedChanged);
            _ck1 = new RadioButton();
            _ck1.CheckedChanged += new EventHandler(Ck1_CheckedChanged);
            GroupBox2 = new GroupBox();
            _optDelete = new RadioButton();
            _optDelete.CheckedChanged += new EventHandler(OptDelete_CheckedChanged);
            _optRaster = new RadioButton();
            _optRaster.CheckedChanged += new EventHandler(OptRaster_CheckedChanged);
            _optClick = new RadioButton();
            _optClick.CheckedChanged += new EventHandler(OptClick_CheckedChanged);
            Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_ImgText).BeginInit();
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(12, 9);
            Label2.Name = "Label2";
            Label2.Size = new Size(213, 13);
            Label2.TabIndex = 44;
            Label2.Text = "Click to see a larger image in a new window";
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(540, 256);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(60, 25);
            _cmdCancel.TabIndex = 50;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdClose
            // 
            _cmdClose.BackColor = SystemColors.Control;
            _cmdClose.Cursor = Cursors.Default;
            _cmdClose.ForeColor = SystemColors.ControlText;
            _cmdClose.Location = new Point(612, 256);
            _cmdClose.Name = "_cmdClose";
            _cmdClose.RightToLeft = RightToLeft.No;
            _cmdClose.Size = new Size(62, 25);
            _cmdClose.TabIndex = 48;
            _cmdClose.Text = "OK";
            _cmdClose.UseVisualStyleBackColor = false;
            // 
            // List1
            // 
            _List1.BackColor = SystemColors.Window;
            _List1.Cursor = Cursors.Default;
            _List1.ForeColor = SystemColors.WindowText;
            _List1.Location = new Point(285, 56);
            _List1.Name = "_List1";
            _List1.RightToLeft = RightToLeft.No;
            _List1.Size = new Size(240, 225);
            _List1.TabIndex = 45;
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Control;
            Frame1.Controls.Add(_cmdAuto);
            Frame1.Controls.Add(_cmdEdit);
            Frame1.ForeColor = SystemColors.ActiveCaption;
            Frame1.Location = new Point(540, 169);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(134, 68);
            Frame1.TabIndex = 52;
            Frame1.TabStop = false;
            Frame1.Text = "Class Map";
            // 
            // cmdAuto
            // 
            _cmdAuto.BackColor = SystemColors.Control;
            _cmdAuto.Cursor = Cursors.Default;
            _cmdAuto.ForeColor = SystemColors.ControlText;
            _cmdAuto.Location = new Point(72, 27);
            _cmdAuto.Name = "_cmdAuto";
            _cmdAuto.RightToLeft = RightToLeft.No;
            _cmdAuto.Size = new Size(48, 25);
            _cmdAuto.TabIndex = 12;
            _cmdAuto.Text = "Make";
            _cmdAuto.UseVisualStyleBackColor = false;
            // 
            // cmdEdit
            // 
            _cmdEdit.BackColor = SystemColors.Control;
            _cmdEdit.Cursor = Cursors.Default;
            _cmdEdit.ForeColor = SystemColors.ControlText;
            _cmdEdit.Location = new Point(12, 27);
            _cmdEdit.Name = "_cmdEdit";
            _cmdEdit.RightToLeft = RightToLeft.No;
            _cmdEdit.Size = new Size(51, 25);
            _cmdEdit.TabIndex = 11;
            _cmdEdit.Text = "Edit";
            _cmdEdit.UseVisualStyleBackColor = false;
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Control;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(282, 9);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(184, 13);
            Label3.TabIndex = 47;
            Label3.Text = "Click to Edit the Color";
            // 
            // lbLand
            // 
            _lbLand.BackColor = SystemColors.Control;
            _lbLand.BorderStyle = BorderStyle.Fixed3D;
            _lbLand.Cursor = Cursors.Default;
            _lbLand.ForeColor = SystemColors.ControlText;
            _lbLand.Location = new Point(285, 25);
            _lbLand.Name = "_lbLand";
            _lbLand.RightToLeft = RightToLeft.No;
            _lbLand.Size = new Size(240, 19);
            _lbLand.TabIndex = 46;
            _lbLand.Text = "Label1";
            _lbLand.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ImgText
            // 
            _ImgText.Cursor = Cursors.Default;
            _ImgText.Location = new Point(15, 25);
            _ImgText.Name = "_ImgText";
            _ImgText.Size = new Size(256, 256);
            _ImgText.SizeMode = PictureBoxSizeMode.StretchImage;
            _ImgText.TabIndex = 53;
            _ImgText.TabStop = false;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_ck4);
            GroupBox1.Controls.Add(_ck2);
            GroupBox1.Controls.Add(_ck1);
            GroupBox1.Location = new Point(540, 114);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(134, 49);
            GroupBox1.TabIndex = 54;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Brush Insert Size";
            // 
            // ck4
            // 
            _ck4.AutoSize = true;
            _ck4.Location = new Point(93, 19);
            _ck4.Name = "_ck4";
            _ck4.Size = new Size(37, 17);
            _ck4.TabIndex = 2;
            _ck4.Text = "49";
            _ck4.UseVisualStyleBackColor = true;
            // 
            // ck2
            // 
            _ck2.AutoSize = true;
            _ck2.Location = new Point(54, 19);
            _ck2.Name = "_ck2";
            _ck2.Size = new Size(31, 17);
            _ck2.TabIndex = 1;
            _ck2.Text = "9";
            _ck2.UseVisualStyleBackColor = true;
            // 
            // ck1
            // 
            _ck1.AutoSize = true;
            _ck1.Checked = true;
            _ck1.Location = new Point(15, 19);
            _ck1.Name = "_ck1";
            _ck1.Size = new Size(31, 17);
            _ck1.TabIndex = 0;
            _ck1.TabStop = true;
            _ck1.Text = "1";
            _ck1.UseVisualStyleBackColor = true;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(_optDelete);
            GroupBox2.Controls.Add(_optRaster);
            GroupBox2.Controls.Add(_optClick);
            GroupBox2.Location = new Point(540, 9);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(134, 99);
            GroupBox2.TabIndex = 55;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Mode";
            // 
            // optDelete
            // 
            _optDelete.AutoSize = true;
            _optDelete.BackColor = SystemColors.Control;
            _optDelete.Cursor = Cursors.Default;
            _optDelete.ForeColor = SystemColors.ControlText;
            _optDelete.Location = new Point(18, 65);
            _optDelete.Name = "_optDelete";
            _optDelete.RightToLeft = RightToLeft.No;
            _optDelete.Size = new Size(97, 17);
            _optDelete.TabIndex = 10;
            _optDelete.TabStop = true;
            _optDelete.Text = "Delete on Click";
            _optDelete.UseVisualStyleBackColor = false;
            // 
            // optRaster
            // 
            _optRaster.AutoSize = true;
            _optRaster.BackColor = SystemColors.Control;
            _optRaster.Cursor = Cursors.Default;
            _optRaster.ForeColor = SystemColors.ControlText;
            _optRaster.Location = new Point(18, 44);
            _optRaster.Name = "_optRaster";
            _optRaster.RightToLeft = RightToLeft.No;
            _optRaster.Size = new Size(100, 17);
            _optRaster.TabIndex = 9;
            _optRaster.TabStop = true;
            _optRaster.Text = "Insert on Raster";
            _optRaster.UseVisualStyleBackColor = false;
            // 
            // optClick
            // 
            _optClick.AutoSize = true;
            _optClick.BackColor = SystemColors.Control;
            _optClick.Checked = true;
            _optClick.Cursor = Cursors.Default;
            _optClick.ForeColor = SystemColors.ControlText;
            _optClick.Location = new Point(18, 23);
            _optClick.Name = "_optClick";
            _optClick.RightToLeft = RightToLeft.No;
            _optClick.Size = new Size(92, 17);
            _optClick.TabIndex = 8;
            _optClick.TabStop = true;
            _optClick.Text = "Insert on Click";
            _optClick.UseVisualStyleBackColor = false;
            // 
            // frmLandsP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 297);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdClose);
            Controls.Add(_List1);
            Controls.Add(Frame1);
            Controls.Add(Label3);
            Controls.Add(_lbLand);
            Controls.Add(_ImgText);
            Controls.Add(Label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmLandsP";
            StartPosition = FormStartPosition.Manual;
            Text = "SBuilderX - Land Class Properties";
            Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_ImgText).EndInit();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Load += new EventHandler(FrmLandsP_Load);
            ResumeLayout(false);
            PerformLayout();
        }

        internal Label Label2;
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

        private Button _cmdClose;

        public Button cmdClose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClose != null)
                {
                    _cmdClose.Click -= CmdClose_Click;
                }

                _cmdClose = value;
                if (_cmdClose != null)
                {
                    _cmdClose.Click += CmdClose_Click;
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
                    _List1.SelectedIndexChanged -= List1_SelectedIndexChanged;
                }

                _List1 = value;
                if (_List1 != null)
                {
                    _List1.SelectedIndexChanged += List1_SelectedIndexChanged;
                }
            }
        }

        public GroupBox Frame1;
        private Button _cmdAuto;

        public Button cmdAuto
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAuto;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAuto != null)
                {
                    _cmdAuto.Click -= CmdAuto_Click;
                }

                _cmdAuto = value;
                if (_cmdAuto != null)
                {
                    _cmdAuto.Click += CmdAuto_Click;
                }
            }
        }

        private Button _cmdEdit;

        public Button cmdEdit
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdEdit;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdEdit != null)
                {
                    _cmdEdit.Click -= CmdEdit_Click;
                }

                _cmdEdit = value;
                if (_cmdEdit != null)
                {
                    _cmdEdit.Click += CmdEdit_Click;
                }
            }
        }

        public Label Label3;
        private Label _lbLand;

        public Label lbLand
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbLand;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbLand != null)
                {
                    _lbLand.Click -= LbLand_Click;
                }

                _lbLand = value;
                if (_lbLand != null)
                {
                    _lbLand.Click += LbLand_Click;
                }
            }
        }

        private PictureBox _ImgText;

        public PictureBox ImgText
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ImgText;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ImgText != null)
                {
                    _ImgText.Click -= ImgText_Click;
                }

                _ImgText = value;
                if (_ImgText != null)
                {
                    _ImgText.Click += ImgText_Click;
                }
            }
        }

        private RadioButton _ck4;

        internal RadioButton ck4
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ck4;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ck4 != null)
                {
                    _ck4.CheckedChanged -= Ck4_CheckedChanged;
                }

                _ck4 = value;
                if (_ck4 != null)
                {
                    _ck4.CheckedChanged += Ck4_CheckedChanged;
                }
            }
        }

        private RadioButton _ck2;

        internal RadioButton ck2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ck2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ck2 != null)
                {
                    _ck2.CheckedChanged -= Ck2_CheckedChanged;
                }

                _ck2 = value;
                if (_ck2 != null)
                {
                    _ck2.CheckedChanged += Ck2_CheckedChanged;
                }
            }
        }

        private RadioButton _ck1;

        internal RadioButton ck1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ck1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ck1 != null)
                {
                    _ck1.CheckedChanged -= Ck1_CheckedChanged;
                }

                _ck1 = value;
                if (_ck1 != null)
                {
                    _ck1.CheckedChanged += Ck1_CheckedChanged;
                }
            }
        }

        public GroupBox GroupBox1;
        internal GroupBox GroupBox2;
        private RadioButton _optDelete;

        public RadioButton optDelete
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optDelete;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optDelete != null)
                {
                    _optDelete.CheckedChanged -= OptDelete_CheckedChanged;
                }

                _optDelete = value;
                if (_optDelete != null)
                {
                    _optDelete.CheckedChanged += OptDelete_CheckedChanged;
                }
            }
        }

        private RadioButton _optRaster;

        public RadioButton optRaster
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optRaster;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optRaster != null)
                {
                    _optRaster.CheckedChanged -= OptRaster_CheckedChanged;
                }

                _optRaster = value;
                if (_optRaster != null)
                {
                    _optRaster.CheckedChanged += OptRaster_CheckedChanged;
                }
            }
        }

        private RadioButton _optClick;

        public RadioButton optClick
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _optClick;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_optClick != null)
                {
                    _optClick.CheckedChanged -= OptClick_CheckedChanged;
                }

                _optClick = value;
                if (_optClick != null)
                {
                    _optClick.CheckedChanged += OptClick_CheckedChanged;
                }
            }
        }
    }
}