using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGotoPos));
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this._txtLat = new System.Windows.Forms.TextBox();
            this._txtLon = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this._txtU = new System.Windows.Forms.TextBox();
            this._txtV = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._txtL = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this._cmdCheck = new System.Windows.Forms.Button();
            this.Frame2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(316, 108);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(56, 25);
            this._cmdOK.TabIndex = 13;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = false;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(316, 67);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(56, 25);
            this._cmdCancel.TabIndex = 12;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Frame2.Controls.Add(this.Label2);
            this.Frame2.Controls.Add(this._txtLat);
            this.Frame2.Controls.Add(this._txtLon);
            this.Frame2.Controls.Add(this.Label1);
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(21, 12);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(146, 132);
            this.Frame2.TabIndex = 11;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Geographic";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(15, 77);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(54, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Longitude";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _txtLat
            // 
            this._txtLat.AcceptsReturn = true;
            this._txtLat.BackColor = System.Drawing.SystemColors.Window;
            this._txtLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLat.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLat.Location = new System.Drawing.Point(18, 41);
            this._txtLat.MaxLength = 0;
            this._txtLat.Name = "_txtLat";
            this._txtLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLat.Size = new System.Drawing.Size(108, 20);
            this._txtLat.TabIndex = 2;
            this._txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtLat.LostFocus += new System.EventHandler(this.TxtLat_LostFocus);
            // 
            // _txtLon
            // 
            this._txtLon.AcceptsReturn = true;
            this._txtLon.BackColor = System.Drawing.SystemColors.Window;
            this._txtLon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtLon.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtLon.Location = new System.Drawing.Point(18, 93);
            this._txtLon.MaxLength = 0;
            this._txtLon.Name = "_txtLon";
            this._txtLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtLon.Size = new System.Drawing.Size(108, 20);
            this._txtLon.TabIndex = 1;
            this._txtLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtLon.LostFocus += new System.EventHandler(this.TxtLon_LostFocus);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(15, 25);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Latitude";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _txtU
            // 
            this._txtU.AcceptsReturn = true;
            this._txtU.BackColor = System.Drawing.SystemColors.Window;
            this._txtU.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtU.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtU.Location = new System.Drawing.Point(37, 28);
            this._txtU.MaxLength = 0;
            this._txtU.Name = "_txtU";
            this._txtU.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtU.Size = new System.Drawing.Size(53, 20);
            this._txtU.TabIndex = 2;
            this._txtU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtU.LostFocus += new System.EventHandler(this.TxtU_LostFocus);
            // 
            // _txtV
            // 
            this._txtV.AcceptsReturn = true;
            this._txtV.BackColor = System.Drawing.SystemColors.Window;
            this._txtV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtV.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtV.Location = new System.Drawing.Point(37, 63);
            this._txtV.MaxLength = 0;
            this._txtV.Name = "_txtV";
            this._txtV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtV.Size = new System.Drawing.Size(53, 20);
            this._txtV.TabIndex = 1;
            this._txtV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtV.LostFocus += new System.EventHandler(this.TxtV_LostFocus);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(17, 66);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(14, 13);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "V";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(16, 28);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(15, 13);
            this.Label4.TabIndex = 4;
            this.Label4.Text = "U";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this._txtU);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this._txtV);
            this.GroupBox1.Location = new System.Drawing.Point(185, 45);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(108, 99);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "(U, V)";
            // 
            // _txtL
            // 
            this._txtL.AcceptsReturn = true;
            this._txtL.BackColor = System.Drawing.SystemColors.Window;
            this._txtL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this._txtL.ForeColor = System.Drawing.SystemColors.WindowText;
            this._txtL.Location = new System.Drawing.Point(237, 12);
            this._txtL.MaxLength = 0;
            this._txtL.Name = "_txtL";
            this._txtL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._txtL.Size = new System.Drawing.Size(38, 20);
            this._txtL.TabIndex = 15;
            this._txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtL.LostFocus += new System.EventHandler(this.TxtL_LostFocus);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(202, 15);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(29, 13);
            this.Label5.TabIndex = 16;
            this.Label5.Text = "LOD";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // _cmdCheck
            // 
            this._cmdCheck.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCheck.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCheck.Location = new System.Drawing.Point(316, 25);
            this._cmdCheck.Name = "_cmdCheck";
            this._cmdCheck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCheck.Size = new System.Drawing.Size(56, 25);
            this._cmdCheck.TabIndex = 15;
            this._cmdCheck.Text = "Check";
            this._cmdCheck.UseVisualStyleBackColor = false;
            this._cmdCheck.Click += new System.EventHandler(this.CmdCheck_Click);
            // 
            // FrmGotoPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 165);
            this.Controls.Add(this._txtL);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this._cmdCheck);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.Frame2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGotoPos";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmGotoPos_Load);
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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