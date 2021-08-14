using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLandsP));
            this.Label2 = new System.Windows.Forms.Label();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdClose = new System.Windows.Forms.Button();
            this._List1 = new System.Windows.Forms.ListBox();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this._cmdAuto = new System.Windows.Forms.Button();
            this._cmdEdit = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this._lbLand = new System.Windows.Forms.Label();
            this._ImgText = new System.Windows.Forms.PictureBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._ck4 = new System.Windows.Forms.RadioButton();
            this._ck2 = new System.Windows.Forms.RadioButton();
            this._ck1 = new System.Windows.Forms.RadioButton();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this._optDelete = new System.Windows.Forms.RadioButton();
            this._optRaster = new System.Windows.Forms.RadioButton();
            this._optClick = new System.Windows.Forms.RadioButton();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ImgText)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(12, 9);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(213, 13);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Click to see a larger image in a new window";
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(540, 256);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(60, 25);
            this._cmdCancel.TabIndex = 50;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdClose
            // 
            this._cmdClose.BackColor = System.Drawing.SystemColors.Control;
            this._cmdClose.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdClose.Location = new System.Drawing.Point(612, 256);
            this._cmdClose.Name = "_cmdClose";
            this._cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdClose.Size = new System.Drawing.Size(62, 25);
            this._cmdClose.TabIndex = 48;
            this._cmdClose.Text = "OK";
            this._cmdClose.UseVisualStyleBackColor = false;
            this._cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // _List1
            // 
            this._List1.BackColor = System.Drawing.SystemColors.Window;
            this._List1.Cursor = System.Windows.Forms.Cursors.Default;
            this._List1.ForeColor = System.Drawing.SystemColors.WindowText;
            this._List1.Location = new System.Drawing.Point(285, 56);
            this._List1.Name = "_List1";
            this._List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._List1.Size = new System.Drawing.Size(240, 225);
            this._List1.TabIndex = 45;
            this._List1.SelectedIndexChanged += new System.EventHandler(this.List1_SelectedIndexChanged);
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this._cmdAuto);
            this.Frame1.Controls.Add(this._cmdEdit);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Frame1.Location = new System.Drawing.Point(540, 169);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(134, 68);
            this.Frame1.TabIndex = 52;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Class Map";
            // 
            // _cmdAuto
            // 
            this._cmdAuto.BackColor = System.Drawing.SystemColors.Control;
            this._cmdAuto.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAuto.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAuto.Location = new System.Drawing.Point(72, 27);
            this._cmdAuto.Name = "_cmdAuto";
            this._cmdAuto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAuto.Size = new System.Drawing.Size(48, 25);
            this._cmdAuto.TabIndex = 12;
            this._cmdAuto.Text = "Make";
            this._cmdAuto.UseVisualStyleBackColor = false;
            this._cmdAuto.Click += new System.EventHandler(this.CmdAuto_Click);
            // 
            // _cmdEdit
            // 
            this._cmdEdit.BackColor = System.Drawing.SystemColors.Control;
            this._cmdEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdEdit.Location = new System.Drawing.Point(12, 27);
            this._cmdEdit.Name = "_cmdEdit";
            this._cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdEdit.Size = new System.Drawing.Size(51, 25);
            this._cmdEdit.TabIndex = 11;
            this._cmdEdit.Text = "Edit";
            this._cmdEdit.UseVisualStyleBackColor = false;
            this._cmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(282, 9);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(184, 13);
            this.Label3.TabIndex = 47;
            this.Label3.Text = "Click to Edit the Color";
            // 
            // _lbLand
            // 
            this._lbLand.BackColor = System.Drawing.SystemColors.Control;
            this._lbLand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this._lbLand.Cursor = System.Windows.Forms.Cursors.Default;
            this._lbLand.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lbLand.Location = new System.Drawing.Point(285, 25);
            this._lbLand.Name = "_lbLand";
            this._lbLand.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._lbLand.Size = new System.Drawing.Size(240, 19);
            this._lbLand.TabIndex = 46;
            this._lbLand.Text = "Label1";
            this._lbLand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._lbLand.Click += new System.EventHandler(this.LbLand_Click);
            // 
            // _ImgText
            // 
            this._ImgText.Cursor = System.Windows.Forms.Cursors.Default;
            this._ImgText.Location = new System.Drawing.Point(15, 25);
            this._ImgText.Name = "_ImgText";
            this._ImgText.Size = new System.Drawing.Size(256, 256);
            this._ImgText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._ImgText.TabIndex = 53;
            this._ImgText.TabStop = false;
            this._ImgText.Click += new System.EventHandler(this.ImgText_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this._ck4);
            this.GroupBox1.Controls.Add(this._ck2);
            this.GroupBox1.Controls.Add(this._ck1);
            this.GroupBox1.Location = new System.Drawing.Point(540, 114);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(134, 49);
            this.GroupBox1.TabIndex = 54;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Brush Insert Size";
            // 
            // _ck4
            // 
            this._ck4.AutoSize = true;
            this._ck4.Location = new System.Drawing.Point(93, 19);
            this._ck4.Name = "_ck4";
            this._ck4.Size = new System.Drawing.Size(37, 17);
            this._ck4.TabIndex = 2;
            this._ck4.Text = "49";
            this._ck4.UseVisualStyleBackColor = true;
            this._ck4.CheckedChanged += new System.EventHandler(this.Ck4_CheckedChanged);
            // 
            // _ck2
            // 
            this._ck2.AutoSize = true;
            this._ck2.Location = new System.Drawing.Point(54, 19);
            this._ck2.Name = "_ck2";
            this._ck2.Size = new System.Drawing.Size(31, 17);
            this._ck2.TabIndex = 1;
            this._ck2.Text = "9";
            this._ck2.UseVisualStyleBackColor = true;
            this._ck2.CheckedChanged += new System.EventHandler(this.Ck2_CheckedChanged);
            // 
            // _ck1
            // 
            this._ck1.AutoSize = true;
            this._ck1.Checked = true;
            this._ck1.Location = new System.Drawing.Point(15, 19);
            this._ck1.Name = "_ck1";
            this._ck1.Size = new System.Drawing.Size(31, 17);
            this._ck1.TabIndex = 0;
            this._ck1.TabStop = true;
            this._ck1.Text = "1";
            this._ck1.UseVisualStyleBackColor = true;
            this._ck1.CheckedChanged += new System.EventHandler(this.Ck1_CheckedChanged);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this._optDelete);
            this.GroupBox2.Controls.Add(this._optRaster);
            this.GroupBox2.Controls.Add(this._optClick);
            this.GroupBox2.Location = new System.Drawing.Point(540, 9);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(134, 99);
            this.GroupBox2.TabIndex = 55;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Mode";
            // 
            // _optDelete
            // 
            this._optDelete.AutoSize = true;
            this._optDelete.BackColor = System.Drawing.SystemColors.Control;
            this._optDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this._optDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optDelete.Location = new System.Drawing.Point(18, 65);
            this._optDelete.Name = "_optDelete";
            this._optDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optDelete.Size = new System.Drawing.Size(97, 17);
            this._optDelete.TabIndex = 10;
            this._optDelete.TabStop = true;
            this._optDelete.Text = "Delete on Click";
            this._optDelete.UseVisualStyleBackColor = false;
            this._optDelete.CheckedChanged += new System.EventHandler(this.OptDelete_CheckedChanged);
            // 
            // _optRaster
            // 
            this._optRaster.AutoSize = true;
            this._optRaster.BackColor = System.Drawing.SystemColors.Control;
            this._optRaster.Cursor = System.Windows.Forms.Cursors.Default;
            this._optRaster.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optRaster.Location = new System.Drawing.Point(18, 44);
            this._optRaster.Name = "_optRaster";
            this._optRaster.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optRaster.Size = new System.Drawing.Size(100, 17);
            this._optRaster.TabIndex = 9;
            this._optRaster.TabStop = true;
            this._optRaster.Text = "Insert on Raster";
            this._optRaster.UseVisualStyleBackColor = false;
            this._optRaster.CheckedChanged += new System.EventHandler(this.OptRaster_CheckedChanged);
            // 
            // _optClick
            // 
            this._optClick.AutoSize = true;
            this._optClick.BackColor = System.Drawing.SystemColors.Control;
            this._optClick.Checked = true;
            this._optClick.Cursor = System.Windows.Forms.Cursors.Default;
            this._optClick.ForeColor = System.Drawing.SystemColors.ControlText;
            this._optClick.Location = new System.Drawing.Point(18, 23);
            this._optClick.Name = "_optClick";
            this._optClick.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._optClick.Size = new System.Drawing.Size(92, 17);
            this._optClick.TabIndex = 8;
            this._optClick.TabStop = true;
            this._optClick.Text = "Insert on Click";
            this._optClick.UseVisualStyleBackColor = false;
            this._optClick.CheckedChanged += new System.EventHandler(this.OptClick_CheckedChanged);
            // 
            // FrmLandsP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 297);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdClose);
            this.Controls.Add(this._List1);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this._lbLand);
            this.Controls.Add(this._ImgText);
            this.Controls.Add(this.Label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmLandsP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SBuilderXX - Land Class Properties";
            this.Load += new System.EventHandler(this.FrmLandsP_Load);
            this.Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._ImgText)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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