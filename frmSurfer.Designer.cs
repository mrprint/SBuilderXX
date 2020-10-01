using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    internal partial class FrmSurfer : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSurfer));
            this._ckAutoLine = new System.Windows.Forms.CheckBox();
            this._ckLineAltitude = new System.Windows.Forms.CheckBox();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdContinue = new System.Windows.Forms.Button();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this._lbLineColor = new System.Windows.Forms.Label();
            this.txtEndW = new System.Windows.Forms.TextBox();
            this._txtLineGuid = new System.Windows.Forms.TextBox();
            this.txtStartW = new System.Windows.Forms.TextBox();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this._lbPolyColor = new System.Windows.Forms.Label();
            this._ckPolyAltitude = new System.Windows.Forms.CheckBox();
            this.Label6 = new System.Windows.Forms.Label();
            this._txtPolyGuid = new System.Windows.Forms.TextBox();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ckAutoLine
            // 
            this._ckAutoLine.BackColor = System.Drawing.SystemColors.Control;
            this._ckAutoLine.Cursor = System.Windows.Forms.Cursors.Default;
            this._ckAutoLine.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ckAutoLine.Location = new System.Drawing.Point(16, 66);
            this._ckAutoLine.Name = "_ckAutoLine";
            this._ckAutoLine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ckAutoLine.Size = new System.Drawing.Size(114, 35);
            this._ckAutoLine.TabIndex = 22;
            this._ckAutoLine.Text = "Create closed line";
            this._ckAutoLine.UseVisualStyleBackColor = false;
            this._ckAutoLine.CheckStateChanged += new System.EventHandler(this.CkAutoLine_CheckStateChanged);
            // 
            // _ckLineAltitude
            // 
            this._ckLineAltitude.BackColor = System.Drawing.SystemColors.Control;
            this._ckLineAltitude.Cursor = System.Windows.Forms.Cursors.Default;
            this._ckLineAltitude.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ckLineAltitude.Location = new System.Drawing.Point(17, 110);
            this._ckLineAltitude.Name = "_ckLineAltitude";
            this._ckLineAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ckLineAltitude.Size = new System.Drawing.Size(241, 21);
            this._ckLineAltitude.TabIndex = 19;
            this._ckLineAltitude.Text = "Interpret 3rd parameter, if present, as altitude";
            this._ckLineAltitude.UseVisualStyleBackColor = false;
            this._ckLineAltitude.CheckStateChanged += new System.EventHandler(this.CkLineAltitude_CheckStateChanged);
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(142, 314);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(70, 25);
            this._cmdCancel.TabIndex = 16;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdContinue
            // 
            this._cmdContinue.BackColor = System.Drawing.SystemColors.Control;
            this._cmdContinue.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdContinue.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdContinue.Location = new System.Drawing.Point(240, 314);
            this._cmdContinue.Name = "_cmdContinue";
            this._cmdContinue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdContinue.Size = new System.Drawing.Size(70, 25);
            this._cmdContinue.TabIndex = 13;
            this._cmdContinue.Text = "Continue ...";
            this._cmdContinue.UseVisualStyleBackColor = false;
            this._cmdContinue.Click += new System.EventHandler(this.CmdContinue_Click);
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.BackColor = System.Drawing.SystemColors.Control;
            this.lbEnd.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbEnd.Location = new System.Drawing.Point(80, 68);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbEnd.Size = new System.Drawing.Size(57, 13);
            this.lbEnd.TabIndex = 21;
            this.lbEnd.Text = "End Width";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.BackColor = System.Drawing.SystemColors.Control;
            this.lbStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbStart.Location = new System.Drawing.Point(14, 68);
            this.lbStart.Name = "lbStart";
            this.lbStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbStart.Size = new System.Drawing.Size(60, 13);
            this.lbStart.TabIndex = 20;
            this.lbStart.Text = "Start Width";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(14, 25);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(244, 13);
            this.Label3.TabIndex = 14;
            this.Label3.Text = "Guid of imported lines. Click on the box to change.";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(12, 314);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(112, 32);
            this.Label1.TabIndex = 12;
            this.Label1.Text = "Edit SBuilder.ini to change Separator";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this._lbLineColor);
            this.GroupBox1.Controls.Add(this.txtEndW);
            this.GroupBox1.Controls.Add(this._txtLineGuid);
            this.GroupBox1.Controls.Add(this.txtStartW);
            this.GroupBox1.Controls.Add(this._ckLineAltitude);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.lbStart);
            this.GroupBox1.Controls.Add(this.lbEnd);
            this.GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(298, 136);
            this.GroupBox1.TabIndex = 24;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Properties of Imported Lines";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(137, 87);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(113, 13);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Color (click to change)";
            // 
            // _lbLineColor
            // 
            this._lbLineColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbLineColor.Location = new System.Drawing.Point(256, 84);
            this._lbLineColor.Name = "_lbLineColor";
            this._lbLineColor.Size = new System.Drawing.Size(23, 20);
            this._lbLineColor.TabIndex = 23;
            this._lbLineColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lbLineColor.Click += new System.EventHandler(this.LbLineColor_Click);
            // 
            // txtEndW
            // 
            this.txtEndW.Location = new System.Drawing.Point(80, 84);
            this.txtEndW.Name = "txtEndW";
            this.txtEndW.Size = new System.Drawing.Size(51, 20);
            this.txtEndW.TabIndex = 22;
            this.txtEndW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _txtLineGuid
            // 
            this._txtLineGuid.BackColor = System.Drawing.Color.White;
            this._txtLineGuid.Location = new System.Drawing.Point(17, 41);
            this._txtLineGuid.Name = "_txtLineGuid";
            this._txtLineGuid.ReadOnly = true;
            this._txtLineGuid.Size = new System.Drawing.Size(262, 20);
            this._txtLineGuid.TabIndex = 21;
            this._txtLineGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtLineGuid.Click += new System.EventHandler(this.TxtLineGuid_Click);
            // 
            // txtStartW
            // 
            this.txtStartW.Location = new System.Drawing.Point(17, 84);
            this.txtStartW.Name = "txtStartW";
            this.txtStartW.Size = new System.Drawing.Size(57, 20);
            this.txtStartW.TabIndex = 20;
            this.txtStartW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this._lbPolyColor);
            this.GroupBox2.Controls.Add(this._ckPolyAltitude);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this._txtPolyGuid);
            this.GroupBox2.Controls.Add(this._ckAutoLine);
            this.GroupBox2.Location = new System.Drawing.Point(13, 163);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(297, 132);
            this.GroupBox2.TabIndex = 25;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Properties of Imported Polygons";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BackColor = System.Drawing.SystemColors.Control;
            this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label5.Location = new System.Drawing.Point(136, 76);
            this.Label5.Name = "Label5";
            this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label5.Size = new System.Drawing.Size(113, 13);
            this.Label5.TabIndex = 26;
            this.Label5.Text = "Color (click to change)";
            // 
            // _lbPolyColor
            // 
            this._lbPolyColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lbPolyColor.Location = new System.Drawing.Point(255, 74);
            this._lbPolyColor.Name = "_lbPolyColor";
            this._lbPolyColor.Size = new System.Drawing.Size(23, 20);
            this._lbPolyColor.TabIndex = 25;
            this._lbPolyColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._lbPolyColor.Click += new System.EventHandler(this.LbPolyColor_Click);
            // 
            // _ckPolyAltitude
            // 
            this._ckPolyAltitude.AutoSize = true;
            this._ckPolyAltitude.BackColor = System.Drawing.SystemColors.Control;
            this._ckPolyAltitude.Cursor = System.Windows.Forms.Cursors.Default;
            this._ckPolyAltitude.ForeColor = System.Drawing.SystemColors.ControlText;
            this._ckPolyAltitude.Location = new System.Drawing.Point(16, 107);
            this._ckPolyAltitude.Name = "_ckPolyAltitude";
            this._ckPolyAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._ckPolyAltitude.Size = new System.Drawing.Size(236, 17);
            this._ckPolyAltitude.TabIndex = 24;
            this._ckPolyAltitude.Text = "Interpret 3rd parameter, if present, as altitude";
            this._ckPolyAltitude.UseVisualStyleBackColor = false;
            this._ckPolyAltitude.CheckStateChanged += new System.EventHandler(this.CkPolyAltitude_CheckStateChanged);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.BackColor = System.Drawing.SystemColors.Control;
            this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label6.Location = new System.Drawing.Point(13, 24);
            this.Label6.Name = "Label6";
            this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label6.Size = new System.Drawing.Size(265, 13);
            this.Label6.TabIndex = 23;
            this.Label6.Text = "Guid of imported polygons. Click on the box to change.";
            // 
            // _txtPolyGuid
            // 
            this._txtPolyGuid.BackColor = System.Drawing.Color.White;
            this._txtPolyGuid.Location = new System.Drawing.Point(16, 40);
            this._txtPolyGuid.Name = "_txtPolyGuid";
            this._txtPolyGuid.ReadOnly = true;
            this._txtPolyGuid.Size = new System.Drawing.Size(262, 20);
            this._txtPolyGuid.TabIndex = 21;
            this._txtPolyGuid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._txtPolyGuid.Click += new System.EventHandler(this.TxtPolyGuid_Click);
            // 
            // FrmSurfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 355);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdContinue);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSurfer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - BLN Import Properties";
            this.Load += new System.EventHandler(this.FrmSurfer_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private CheckBox _ckAutoLine;

        public CheckBox ckAutoLine
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckAutoLine;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckAutoLine != null)
                {
                    _ckAutoLine.CheckStateChanged -= CkAutoLine_CheckStateChanged;
                }

                _ckAutoLine = value;
                if (_ckAutoLine != null)
                {
                    _ckAutoLine.CheckStateChanged += CkAutoLine_CheckStateChanged;
                }
            }
        }

        private CheckBox _ckLineAltitude;

        public CheckBox ckLineAltitude
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckLineAltitude;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckLineAltitude != null)
                {
                    _ckLineAltitude.CheckStateChanged -= CkLineAltitude_CheckStateChanged;
                }

                _ckLineAltitude = value;
                if (_ckLineAltitude != null)
                {
                    _ckLineAltitude.CheckStateChanged += CkLineAltitude_CheckStateChanged;
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

        private Button _cmdContinue;

        public Button cmdContinue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdContinue;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdContinue != null)
                {
                    _cmdContinue.Click -= CmdContinue_Click;
                }

                _cmdContinue = value;
                if (_cmdContinue != null)
                {
                    _cmdContinue.Click += CmdContinue_Click;
                }
            }
        }

        public Label lbEnd;
        public Label lbStart;
        public Label Label3;
        public Label Label1;
        internal GroupBox GroupBox1;
        internal TextBox txtStartW;
        internal TextBox txtEndW;
        private TextBox _txtLineGuid;

        internal TextBox txtLineGuid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtLineGuid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtLineGuid != null)
                {
                    _txtLineGuid.Click -= TxtLineGuid_Click;
                }

                _txtLineGuid = value;
                if (_txtLineGuid != null)
                {
                    _txtLineGuid.Click += TxtLineGuid_Click;
                }
            }
        }

        internal GroupBox GroupBox2;
        private TextBox _txtPolyGuid;

        internal TextBox txtPolyGuid
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _txtPolyGuid;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_txtPolyGuid != null)
                {
                    _txtPolyGuid.Click -= TxtPolyGuid_Click;
                }

                _txtPolyGuid = value;
                if (_txtPolyGuid != null)
                {
                    _txtPolyGuid.Click += TxtPolyGuid_Click;
                }
            }
        }

        private Label _lbLineColor;

        internal Label lbLineColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbLineColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbLineColor != null)
                {
                    _lbLineColor.Click -= LbLineColor_Click;
                }

                _lbLineColor = value;
                if (_lbLineColor != null)
                {
                    _lbLineColor.Click += LbLineColor_Click;
                }
            }
        }

        private Label _lbPolyColor;

        internal Label lbPolyColor
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _lbPolyColor;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_lbPolyColor != null)
                {
                    _lbPolyColor.Click -= LbPolyColor_Click;
                }

                _lbPolyColor = value;
                if (_lbPolyColor != null)
                {
                    _lbPolyColor.Click += LbPolyColor_Click;
                }
            }
        }

        private CheckBox _ckPolyAltitude;

        public CheckBox ckPolyAltitude
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _ckPolyAltitude;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_ckPolyAltitude != null)
                {
                    _ckPolyAltitude.CheckStateChanged -= CkPolyAltitude_CheckStateChanged;
                }

                _ckPolyAltitude = value;
                if (_ckPolyAltitude != null)
                {
                    _ckPolyAltitude.CheckStateChanged += CkPolyAltitude_CheckStateChanged;
                }
            }
        }

        public Label Label6;
        public Label Label2;
        public Label Label5;
    }
}