using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmGotoPos : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGotoPos));
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            Frame2 = new GroupBox();
            Label2 = new Label();
            _txtLat = new TextBox();
            _txtLat.LostFocus += new EventHandler(TxtLat_LostFocus);
            _txtLon = new TextBox();
            _txtLon.LostFocus += new EventHandler(TxtLon_LostFocus);
            Label1 = new Label();
            _txtU = new TextBox();
            _txtU.LostFocus += new EventHandler(TxtU_LostFocus);
            _txtV = new TextBox();
            _txtV.LostFocus += new EventHandler(TxtV_LostFocus);
            Label3 = new Label();
            Label4 = new Label();
            GroupBox1 = new GroupBox();
            _txtL = new TextBox();
            _txtL.LostFocus += new EventHandler(TxtL_LostFocus);
            Label5 = new Label();
            _cmdCheck = new Button();
            _cmdCheck.Click += new EventHandler(CmdCheck_Click);
            Frame2.SuspendLayout();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(316, 108);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(56, 25);
            _cmdOK.TabIndex = 13;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(316, 67);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(56, 25);
            _cmdCancel.TabIndex = 12;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // Frame2
            // 
            Frame2.BackColor = SystemColors.Control;
            Frame2.BackgroundImageLayout = ImageLayout.None;
            Frame2.Controls.Add(Label2);
            Frame2.Controls.Add(_txtLat);
            Frame2.Controls.Add(_txtLon);
            Frame2.Controls.Add(Label1);
            Frame2.ForeColor = SystemColors.ControlText;
            Frame2.Location = new Point(21, 12);
            Frame2.Name = "Frame2";
            Frame2.RightToLeft = RightToLeft.No;
            Frame2.Size = new Size(146, 132);
            Frame2.TabIndex = 11;
            Frame2.TabStop = false;
            Frame2.Text = "Geographic";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(15, 77);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(54, 13);
            Label2.TabIndex = 3;
            Label2.Text = "Longitude";
            Label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtLat
            // 
            _txtLat.AcceptsReturn = true;
            _txtLat.BackColor = SystemColors.Window;
            _txtLat.Cursor = Cursors.IBeam;
            _txtLat.ForeColor = SystemColors.WindowText;
            _txtLat.Location = new Point(18, 41);
            _txtLat.MaxLength = 0;
            _txtLat.Name = "_txtLat";
            _txtLat.RightToLeft = RightToLeft.No;
            _txtLat.Size = new Size(108, 20);
            _txtLat.TabIndex = 2;
            _txtLat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLon
            // 
            _txtLon.AcceptsReturn = true;
            _txtLon.BackColor = SystemColors.Window;
            _txtLon.Cursor = Cursors.IBeam;
            _txtLon.ForeColor = SystemColors.WindowText;
            _txtLon.Location = new Point(18, 93);
            _txtLon.MaxLength = 0;
            _txtLon.Name = "_txtLon";
            _txtLon.RightToLeft = RightToLeft.No;
            _txtLon.Size = new Size(108, 20);
            _txtLon.TabIndex = 1;
            _txtLon.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(15, 25);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(45, 13);
            Label1.TabIndex = 4;
            Label1.Text = "Latitude";
            Label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txtU
            // 
            _txtU.AcceptsReturn = true;
            _txtU.BackColor = SystemColors.Window;
            _txtU.Cursor = Cursors.IBeam;
            _txtU.ForeColor = SystemColors.WindowText;
            _txtU.Location = new Point(37, 28);
            _txtU.MaxLength = 0;
            _txtU.Name = "_txtU";
            _txtU.RightToLeft = RightToLeft.No;
            _txtU.Size = new Size(53, 20);
            _txtU.TabIndex = 2;
            _txtU.TextAlign = HorizontalAlignment.Center;
            // 
            // txtV
            // 
            _txtV.AcceptsReturn = true;
            _txtV.BackColor = SystemColors.Window;
            _txtV.Cursor = Cursors.IBeam;
            _txtV.ForeColor = SystemColors.WindowText;
            _txtV.Location = new Point(37, 63);
            _txtV.MaxLength = 0;
            _txtV.Name = "_txtV";
            _txtV.RightToLeft = RightToLeft.No;
            _txtV.Size = new Size(53, 20);
            _txtV.TabIndex = 1;
            _txtV.TextAlign = HorizontalAlignment.Center;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = SystemColors.Control;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(17, 66);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(14, 13);
            Label3.TabIndex = 3;
            Label3.Text = "V";
            Label3.TextAlign = ContentAlignment.TopRight;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.BackColor = SystemColors.Control;
            Label4.Cursor = Cursors.Default;
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(16, 28);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(15, 13);
            Label4.TabIndex = 4;
            Label4.Text = "U";
            Label4.TextAlign = ContentAlignment.TopRight;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(_txtU);
            GroupBox1.Controls.Add(Label4);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(_txtV);
            GroupBox1.Location = new Point(185, 45);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(108, 99);
            GroupBox1.TabIndex = 14;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "(U, V)";
            // 
            // txtL
            // 
            _txtL.AcceptsReturn = true;
            _txtL.BackColor = SystemColors.Window;
            _txtL.Cursor = Cursors.IBeam;
            _txtL.ForeColor = SystemColors.WindowText;
            _txtL.Location = new Point(237, 12);
            _txtL.MaxLength = 0;
            _txtL.Name = "_txtL";
            _txtL.RightToLeft = RightToLeft.No;
            _txtL.Size = new Size(38, 20);
            _txtL.TabIndex = 15;
            _txtL.TextAlign = HorizontalAlignment.Center;
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = SystemColors.Control;
            Label5.Cursor = Cursors.Default;
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(202, 15);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(29, 13);
            Label5.TabIndex = 16;
            Label5.Text = "LOD";
            Label5.TextAlign = ContentAlignment.TopRight;
            // 
            // cmdCheck
            // 
            _cmdCheck.BackColor = SystemColors.Control;
            _cmdCheck.Cursor = Cursors.Default;
            _cmdCheck.ForeColor = SystemColors.ControlText;
            _cmdCheck.Location = new Point(316, 25);
            _cmdCheck.Name = "_cmdCheck";
            _cmdCheck.RightToLeft = RightToLeft.No;
            _cmdCheck.Size = new Size(56, 25);
            _cmdCheck.TabIndex = 15;
            _cmdCheck.Text = "Check";
            _cmdCheck.UseVisualStyleBackColor = false;
            // 
            // frmGotoPos
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 165);
            Controls.Add(_txtL);
            Controls.Add(Label5);
            Controls.Add(_cmdCheck);
            Controls.Add(GroupBox1);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(Frame2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmGotoPos";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Frame2.ResumeLayout(false);
            Frame2.PerformLayout();
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            Load += new EventHandler(FrmGotoPos_Load);
            ResumeLayout(false);
            PerformLayout();
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

        public GroupBox Frame2;
        private TextBox _txtLat;

        public TextBox txtLat
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLat;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLat != null)
                {
                    _txtLat.LostFocus -= TxtLat_LostFocus;
                }

                _txtLat = value;
                if (_txtLat != null)
                {
                    _txtLat.LostFocus += TxtLat_LostFocus;
                }
            }
        }

        private TextBox _txtLon;

        public TextBox txtLon
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLon;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLon != null)
                {
                    _txtLon.LostFocus -= TxtLon_LostFocus;
                }

                _txtLon = value;
                if (_txtLon != null)
                {
                    _txtLon.LostFocus += TxtLon_LostFocus;
                }
            }
        }

        public Label Label1;
        public Label Label2;
        private TextBox _txtU;

        public TextBox txtU
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtU;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtU != null)
                {
                    _txtU.LostFocus -= TxtU_LostFocus;
                }

                _txtU = value;
                if (_txtU != null)
                {
                    _txtU.LostFocus += TxtU_LostFocus;
                }
            }
        }

        private TextBox _txtV;

        public TextBox txtV
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtV;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtV != null)
                {
                    _txtV.LostFocus -= TxtV_LostFocus;
                }

                _txtV = value;
                if (_txtV != null)
                {
                    _txtV.LostFocus += TxtV_LostFocus;
                }
            }
        }

        public Label Label3;
        public Label Label4;
        internal GroupBox GroupBox1;
        private TextBox _txtL;

        public TextBox txtL
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtL;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtL != null)
                {
                    _txtL.LostFocus -= TxtL_LostFocus;
                }

                _txtL = value;
                if (_txtL != null)
                {
                    _txtL.LostFocus += TxtL_LostFocus;
                }
            }
        }

        public Label Label5;
        private Button _cmdCheck;

        public Button cmdCheck
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCheck;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCheck != null)
                {
                    _cmdCheck.Click -= CmdCheck_Click;
                }

                _cmdCheck = value;
                if (_cmdCheck != null)
                {
                    _cmdCheck.Click += CmdCheck_Click;
                }
            }
        }
    }
}