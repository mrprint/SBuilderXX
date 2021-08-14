using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    public partial class frmTexPoly : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            if (disposing && imgBuffer is object)
            {
                imgBuffer.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTexPoly));
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._cmdLL = new System.Windows.Forms.Button();
            this._cmdRR = new System.Windows.Forms.Button();
            this._txtPY = new System.Windows.Forms.TextBox();
            this._cmdDD = new System.Windows.Forms.Button();
            this._cmdUU = new System.Windows.Forms.Button();
            this._txtPX = new System.Windows.Forms.TextBox();
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdReset = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this._imgText = new System.Windows.Forms.PictureBox();
            this._Timer1 = new System.Timers.Timer();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Timer1)).BeginInit();
            this.SuspendLayout();
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.Label3);
            this.Frame1.Controls.Add(this.Label2);
            this.Frame1.Controls.Add(this._cmdLL);
            this.Frame1.Controls.Add(this._cmdRR);
            this.Frame1.Controls.Add(this._txtPY);
            this.Frame1.Controls.Add(this._cmdDD);
            this.Frame1.Controls.Add(this._cmdUU);
            this.Frame1.Controls.Add(this._txtPX);
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(554, 180);
            this.Frame1.Name = "Frame1";
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(86, 172);
            this.Frame1.TabIndex = 23;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Point # 1";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(18, 103);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(17, 13);
            this.Label3.TabIndex = 11;
            this.Label3.Text = "Y:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(18, 28);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(17, 13);
            this.Label2.TabIndex = 10;
            this.Label2.Text = "X:";
            // 
            // _cmdLL
            // 
            this._cmdLL.BackColor = System.Drawing.SystemColors.Control;
            this._cmdLL.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdLL.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdLL.Image = ((System.Drawing.Image)(resources.GetObject("_cmdLL.Image")));
            this._cmdLL.Location = new System.Drawing.Point(13, 51);
            this._cmdLL.Name = "_cmdLL";
            this._cmdLL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdLL.Size = new System.Drawing.Size(25, 25);
            this._cmdLL.TabIndex = 9;
            this._cmdLL.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdLL.UseVisualStyleBackColor = false;
            this._cmdLL.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmdLL_MouseDown);
            this._cmdLL.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmdLL_MouseUp);
            // 
            // _cmdRR
            // 
            this._cmdRR.BackColor = System.Drawing.SystemColors.Control;
            this._cmdRR.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdRR.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdRR.Image = ((System.Drawing.Image)(resources.GetObject("_cmdRR.Image")));
            this._cmdRR.Location = new System.Drawing.Point(48, 51);
            this._cmdRR.Name = "_cmdRR";
            this._cmdRR.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdRR.Size = new System.Drawing.Size(25, 25);
            this._cmdRR.TabIndex = 8;
            this._cmdRR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdRR.UseVisualStyleBackColor = false;
            this._cmdRR.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmdRR_MouseDown);
            this._cmdRR.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmdRR_MouseUp);
            // 
            // _txtPY
            // 
            this._txtPY.AcceptsReturn = true;
            this._txtPY.BackColor = System.Drawing.SystemColors.Window;
            this._txtPY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtPY.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtPY.Location = new System.Drawing.Point(41, 100);
            this._txtPY.MaxLength = 0;
            this._txtPY.Name = "_txtPY";
            this._txtPY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtPY.Size = new System.Drawing.Size(32, 20);
            this._txtPY.TabIndex = 7;
            this._txtPY.Text = "255";
            this._txtPY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtPY.TextChanged += new System.EventHandler(this.TxtPY_TextChanged);
            // 
            // _cmdDD
            // 
            this._cmdDD.BackColor = System.Drawing.SystemColors.Control;
            this._cmdDD.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdDD.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdDD.Image = ((System.Drawing.Image)(resources.GetObject("_cmdDD.Image")));
            this._cmdDD.Location = new System.Drawing.Point(13, 126);
            this._cmdDD.Name = "_cmdDD";
            this._cmdDD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdDD.Size = new System.Drawing.Size(25, 25);
            this._cmdDD.TabIndex = 6;
            this._cmdDD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdDD.UseVisualStyleBackColor = false;
            this._cmdDD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmdDD_MouseDown);
            this._cmdDD.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmdDD_MouseUp);
            // 
            // _cmdUU
            // 
            this._cmdUU.BackColor = System.Drawing.SystemColors.Control;
            this._cmdUU.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdUU.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdUU.Image = ((System.Drawing.Image)(resources.GetObject("_cmdUU.Image")));
            this._cmdUU.Location = new System.Drawing.Point(48, 126);
            this._cmdUU.Name = "_cmdUU";
            this._cmdUU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdUU.Size = new System.Drawing.Size(25, 25);
            this._cmdUU.TabIndex = 5;
            this._cmdUU.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this._cmdUU.UseVisualStyleBackColor = false;
            this._cmdUU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CmdUU_MouseDown);
            this._cmdUU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CmdUU_MouseUp);
            // 
            // _txtPX
            // 
            this._txtPX.AcceptsReturn = true;
            this._txtPX.BackColor = System.Drawing.SystemColors.Window;
            this._txtPX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtPX.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtPX.Location = new System.Drawing.Point(41, 25);
            this._txtPX.MaxLength = 0;
            this._txtPX.Name = "_txtPX";
            this._txtPX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtPX.Size = new System.Drawing.Size(32, 20);
            this._txtPX.TabIndex = 4;
            this._txtPX.Text = "0";
            this._txtPX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtPX.TextChanged += new System.EventHandler(this.TxtPX_TextChanged);
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(566, 473);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(61, 25);
            this._cmdOK.TabIndex = 21;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(566, 428);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(61, 25);
            this._cmdCancel.TabIndex = 20;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdReset
            // 
            this._cmdReset.BackColor = System.Drawing.SystemColors.Control;
            this._cmdReset.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdReset.Location = new System.Drawing.Point(566, 383);
            this._cmdReset.Name = "_cmdReset";
            this._cmdReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdReset.Size = new System.Drawing.Size(61, 25);
            this._cmdReset.TabIndex = 19;
            this._cmdReset.Text = "Reset";
            this._cmdReset.UseVisualStyleBackColor = false;
            this._cmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(551, 51);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(89, 126);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Adjust the tie points by selecting and moving with the mouse or by using the arro" +
    "ws comands below.";
            // 
            // _imgText
            // 
            this._imgText.Location = new System.Drawing.Point(12, 12);
            this._imgText.Name = "_imgText";
            this._imgText.Size = new System.Drawing.Size(512, 512);
            this._imgText.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._imgText.TabIndex = 24;
            this._imgText.TabStop = false;
            this._imgText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ImgText_MouseDown);
            this._imgText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ImgText_MouseMove);
            this._imgText.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ImgText_MouseUp);
            // 
            // _Timer1
            // 
            this._Timer1.Enabled = true;
            this._Timer1.SynchronizingObject = this;
            this._Timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.Timer1_Elapsed);
            // 
            // frmTexPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 535);
            this.Controls.Add(this._imgText);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdReset);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTexPoly";
            this.Load += new System.EventHandler(this.FrmTexPoly_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmTexPoly_Paint);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._imgText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Timer1)).EndInit();
            this.ResumeLayout(false);

        }

        public GroupBox Frame1;
        private Button _cmdLL;

        public Button cmdLL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLL != null)
                {
                    _cmdLL.MouseDown -= CmdLL_MouseDown;
                    _cmdLL.MouseUp -= CmdLL_MouseUp;
                }

                _cmdLL = value;
                if (_cmdLL != null)
                {
                    _cmdLL.MouseDown += CmdLL_MouseDown;
                    _cmdLL.MouseUp += CmdLL_MouseUp;
                }
            }
        }

        private Button _cmdRR;

        public Button cmdRR
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdRR;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdRR != null)
                {
                    _cmdRR.MouseDown -= CmdRR_MouseDown;
                    _cmdRR.MouseUp -= CmdRR_MouseUp;
                }

                _cmdRR = value;
                if (_cmdRR != null)
                {
                    _cmdRR.MouseDown += CmdRR_MouseDown;
                    _cmdRR.MouseUp += CmdRR_MouseUp;
                }
            }
        }

        private TextBox _txtPY;

        public TextBox txtPY
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtPY;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtPY != null)
                {
                    _txtPY.TextChanged -= TxtPY_TextChanged;
                }

                _txtPY = value;
                if (_txtPY != null)
                {
                    _txtPY.TextChanged += TxtPY_TextChanged;
                }
            }
        }

        private Button _cmdDD;

        public Button cmdDD
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdDD;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdDD != null)
                {
                    _cmdDD.MouseDown -= CmdDD_MouseDown;
                    _cmdDD.MouseUp -= CmdDD_MouseUp;
                }

                _cmdDD = value;
                if (_cmdDD != null)
                {
                    _cmdDD.MouseDown += CmdDD_MouseDown;
                    _cmdDD.MouseUp += CmdDD_MouseUp;
                }
            }
        }

        private Button _cmdUU;

        public Button cmdUU
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdUU;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdUU != null)
                {
                    _cmdUU.MouseDown -= CmdUU_MouseDown;
                    _cmdUU.MouseUp -= CmdUU_MouseUp;
                }

                _cmdUU = value;
                if (_cmdUU != null)
                {
                    _cmdUU.MouseDown += CmdUU_MouseDown;
                    _cmdUU.MouseUp += CmdUU_MouseUp;
                }
            }
        }

        private TextBox _txtPX;

        public TextBox txtPX
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtPX;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtPX != null)
                {
                    _txtPX.TextChanged -= TxtPX_TextChanged;
                }

                _txtPX = value;
                if (_txtPX != null)
                {
                    _txtPX.TextChanged += TxtPX_TextChanged;
                }
            }
        }

        private Button _cmdOK;

        public Button cmdOK
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

        private Button _cmdReset;

        public Button cmdReset
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdReset;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdReset != null)
                {
                    _cmdReset.Click -= CmdReset_Click;
                }

                _cmdReset = value;
                if (_cmdReset != null)
                {
                    _cmdReset.Click += CmdReset_Click;
                }
            }
        }

        public Label Label1;
        private PictureBox _imgText;

        internal PictureBox imgText
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _imgText;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_imgText != null)
                {
                    _imgText.MouseDown -= ImgText_MouseDown;
                    _imgText.MouseMove -= ImgText_MouseMove;
                    _imgText.MouseUp -= ImgText_MouseUp;
                }

                _imgText = value;
                if (_imgText != null)
                {
                    _imgText.MouseDown += ImgText_MouseDown;
                    _imgText.MouseMove += ImgText_MouseMove;
                    _imgText.MouseUp += ImgText_MouseUp;
                }
            }
        }

        private System.Timers.Timer _Timer1;

        internal System.Timers.Timer Timer1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Timer1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Timer1 != null)
                {
                    _Timer1.Elapsed -= Timer1_Elapsed;
                }

                _Timer1 = value;
                if (_Timer1 != null)
                {
                    _Timer1.Elapsed += Timer1_Elapsed;
                }
            }
        }

        internal Label Label3;
        internal Label Label2;
    }
}