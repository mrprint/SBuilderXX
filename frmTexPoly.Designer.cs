using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTexPoly));
            Frame1 = new GroupBox();
            _cmdLL = new Button();
            _cmdLL.MouseDown += new MouseEventHandler(CmdLL_MouseDown);
            _cmdLL.MouseUp += new MouseEventHandler(CmdLL_MouseUp);
            _cmdRR = new Button();
            _cmdRR.MouseDown += new MouseEventHandler(CmdRR_MouseDown);
            _cmdRR.MouseUp += new MouseEventHandler(CmdRR_MouseUp);
            _txtPY = new TextBox();
            _txtPY.TextChanged += new EventHandler(TxtPY_TextChanged);
            _cmdDD = new Button();
            _cmdDD.MouseDown += new MouseEventHandler(CmdDD_MouseDown);
            _cmdDD.MouseUp += new MouseEventHandler(CmdDD_MouseUp);
            _cmdUU = new Button();
            _cmdUU.MouseDown += new MouseEventHandler(CmdUU_MouseDown);
            _cmdUU.MouseUp += new MouseEventHandler(CmdUU_MouseUp);
            _txtPX = new TextBox();
            _txtPX.TextChanged += new EventHandler(TxtPX_TextChanged);
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdReset = new Button();
            _cmdReset.Click += new EventHandler(CmdReset_Click);
            Label1 = new Label();
            _imgText = new PictureBox();
            _imgText.MouseDown += new MouseEventHandler(ImgText_MouseDown);
            _imgText.MouseMove += new MouseEventHandler(ImgText_MouseMove);
            _imgText.MouseUp += new MouseEventHandler(ImgText_MouseUp);
            _Timer1 = new System.Timers.Timer();
            _Timer1.Elapsed += new System.Timers.ElapsedEventHandler(Timer1_Elapsed);
            Label2 = new Label();
            Label3 = new Label();
            Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_imgText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_Timer1).BeginInit();
            SuspendLayout();
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Control;
            Frame1.Controls.Add(Label3);
            Frame1.Controls.Add(Label2);
            Frame1.Controls.Add(_cmdLL);
            Frame1.Controls.Add(_cmdRR);
            Frame1.Controls.Add(_txtPY);
            Frame1.Controls.Add(_cmdDD);
            Frame1.Controls.Add(_cmdUU);
            Frame1.Controls.Add(_txtPX);
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(554, 180);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(86, 172);
            Frame1.TabIndex = 23;
            Frame1.TabStop = false;
            Frame1.Text = "Point # 1";
            // 
            // cmdLL
            // 
            _cmdLL.BackColor = SystemColors.Control;
            _cmdLL.Cursor = Cursors.Default;
            _cmdLL.ForeColor = SystemColors.ControlText;
            _cmdLL.Image = (Image)resources.GetObject("cmdLL.Image");
            _cmdLL.Location = new Point(13, 51);
            _cmdLL.Name = "_cmdLL";
            _cmdLL.RightToLeft = RightToLeft.No;
            _cmdLL.Size = new Size(25, 25);
            _cmdLL.TabIndex = 9;
            _cmdLL.TextAlign = ContentAlignment.BottomCenter;
            _cmdLL.UseVisualStyleBackColor = false;
            // 
            // cmdRR
            // 
            _cmdRR.BackColor = SystemColors.Control;
            _cmdRR.Cursor = Cursors.Default;
            _cmdRR.ForeColor = SystemColors.ControlText;
            _cmdRR.Image = (Image)resources.GetObject("cmdRR.Image");
            _cmdRR.Location = new Point(48, 51);
            _cmdRR.Name = "_cmdRR";
            _cmdRR.RightToLeft = RightToLeft.No;
            _cmdRR.Size = new Size(25, 25);
            _cmdRR.TabIndex = 8;
            _cmdRR.TextAlign = ContentAlignment.BottomCenter;
            _cmdRR.UseVisualStyleBackColor = false;
            // 
            // txtPY
            // 
            _txtPY.AcceptsReturn = true;
            _txtPY.BackColor = SystemColors.Window;
            _txtPY.Cursor = Cursors.IBeam;
            _txtPY.ForeColor = SystemColors.WindowText;
            _txtPY.Location = new Point(41, 100);
            _txtPY.MaxLength = 0;
            _txtPY.Name = "_txtPY";
            _txtPY.RightToLeft = RightToLeft.No;
            _txtPY.Size = new Size(32, 20);
            _txtPY.TabIndex = 7;
            _txtPY.Text = "255";
            _txtPY.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdDD
            // 
            _cmdDD.BackColor = SystemColors.Control;
            _cmdDD.Cursor = Cursors.Default;
            _cmdDD.ForeColor = SystemColors.ControlText;
            _cmdDD.Image = (Image)resources.GetObject("cmdDD.Image");
            _cmdDD.Location = new Point(13, 126);
            _cmdDD.Name = "_cmdDD";
            _cmdDD.RightToLeft = RightToLeft.No;
            _cmdDD.Size = new Size(25, 25);
            _cmdDD.TabIndex = 6;
            _cmdDD.TextAlign = ContentAlignment.BottomCenter;
            _cmdDD.UseVisualStyleBackColor = false;
            // 
            // cmdUU
            // 
            _cmdUU.BackColor = SystemColors.Control;
            _cmdUU.Cursor = Cursors.Default;
            _cmdUU.ForeColor = SystemColors.ControlText;
            _cmdUU.Image = (Image)resources.GetObject("cmdUU.Image");
            _cmdUU.Location = new Point(48, 126);
            _cmdUU.Name = "_cmdUU";
            _cmdUU.RightToLeft = RightToLeft.No;
            _cmdUU.Size = new Size(25, 25);
            _cmdUU.TabIndex = 5;
            _cmdUU.TextAlign = ContentAlignment.BottomCenter;
            _cmdUU.UseVisualStyleBackColor = false;
            // 
            // txtPX
            // 
            _txtPX.AcceptsReturn = true;
            _txtPX.BackColor = SystemColors.Window;
            _txtPX.Cursor = Cursors.IBeam;
            _txtPX.ForeColor = SystemColors.WindowText;
            _txtPX.Location = new Point(41, 25);
            _txtPX.MaxLength = 0;
            _txtPX.Name = "_txtPX";
            _txtPX.RightToLeft = RightToLeft.No;
            _txtPX.Size = new Size(32, 20);
            _txtPX.TabIndex = 4;
            _txtPX.Text = "0";
            _txtPX.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(566, 473);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(61, 25);
            _cmdOK.TabIndex = 21;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(566, 428);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(61, 25);
            _cmdCancel.TabIndex = 20;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdReset
            // 
            _cmdReset.BackColor = SystemColors.Control;
            _cmdReset.Cursor = Cursors.Default;
            _cmdReset.ForeColor = SystemColors.ControlText;
            _cmdReset.Location = new Point(566, 383);
            _cmdReset.Name = "_cmdReset";
            _cmdReset.RightToLeft = RightToLeft.No;
            _cmdReset.Size = new Size(61, 25);
            _cmdReset.TabIndex = 19;
            _cmdReset.Text = "Reset";
            _cmdReset.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(551, 51);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(89, 126);
            Label1.TabIndex = 22;
            Label1.Text = "Adjust the tie points by selecting and moving with the mouse or by using the arro" + "ws comands below.";
            // 
            // imgText
            // 
            _imgText.Location = new Point(12, 12);
            _imgText.Name = "_imgText";
            _imgText.Size = new Size(512, 512);
            _imgText.SizeMode = PictureBoxSizeMode.StretchImage;
            _imgText.TabIndex = 24;
            _imgText.TabStop = false;
            // 
            // Timer1
            // 
            _Timer1.Enabled = true;
            _Timer1.SynchronizingObject = this;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(18, 28);
            Label2.Name = "Label2";
            Label2.Size = new Size(17, 13);
            Label2.TabIndex = 10;
            Label2.Text = "X:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(18, 103);
            Label3.Name = "Label3";
            Label3.Size = new Size(17, 13);
            Label3.TabIndex = 11;
            Label3.Text = "Y:";
            // 
            // frmTexPoly
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 535);
            Controls.Add(_imgText);
            Controls.Add(Frame1);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdReset);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmTexPoly";
            Frame1.ResumeLayout(false);
            Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_imgText).EndInit();
            ((System.ComponentModel.ISupportInitialize)_Timer1).EndInit();
            Load += new EventHandler(FrmTexPoly_Load);
            Paint += new PaintEventHandler(FrmTexPoly_Paint);
            ResumeLayout(false);
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