using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSurfer));
            _ckAutoLine = new CheckBox();
            _ckAutoLine.CheckStateChanged += new EventHandler(CkAutoLine_CheckStateChanged);
            _ckLineAltitude = new CheckBox();
            _ckLineAltitude.CheckStateChanged += new EventHandler(CkLineAltitude_CheckStateChanged);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdContinue = new Button();
            _cmdContinue.Click += new EventHandler(CmdContinue_Click);
            lbEnd = new Label();
            lbStart = new Label();
            Label3 = new Label();
            Label1 = new Label();
            GroupBox1 = new GroupBox();
            Label2 = new Label();
            _lbLineColor = new Label();
            _lbLineColor.Click += new EventHandler(LbLineColor_Click);
            txtEndW = new TextBox();
            _txtLineGuid = new TextBox();
            _txtLineGuid.Click += new EventHandler(TxtLineGuid_Click);
            txtStartW = new TextBox();
            GroupBox2 = new GroupBox();
            Label5 = new Label();
            _lbPolyColor = new Label();
            _lbPolyColor.Click += new EventHandler(LbPolyColor_Click);
            _ckPolyAltitude = new CheckBox();
            _ckPolyAltitude.CheckStateChanged += new EventHandler(CkPolyAltitude_CheckStateChanged);
            Label6 = new Label();
            _txtPolyGuid = new TextBox();
            _txtPolyGuid.Click += new EventHandler(TxtPolyGuid_Click);
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ckAutoLine
            // 
            _ckAutoLine.BackColor = SystemColors.Control;
            _ckAutoLine.Cursor = Cursors.Default;
            _ckAutoLine.ForeColor = SystemColors.ControlText;
            _ckAutoLine.Location = new Point(16, 66);
            _ckAutoLine.Name = "_ckAutoLine";
            _ckAutoLine.RightToLeft = RightToLeft.No;
            _ckAutoLine.Size = new Size(114, 35);
            _ckAutoLine.TabIndex = 22;
            _ckAutoLine.Text = "Create closed line";
            _ckAutoLine.UseVisualStyleBackColor = false;
            // 
            // ckLineAltitude
            // 
            _ckLineAltitude.BackColor = SystemColors.Control;
            _ckLineAltitude.Cursor = Cursors.Default;
            _ckLineAltitude.ForeColor = SystemColors.ControlText;
            _ckLineAltitude.Location = new Point(17, 110);
            _ckLineAltitude.Name = "_ckLineAltitude";
            _ckLineAltitude.RightToLeft = RightToLeft.No;
            _ckLineAltitude.Size = new Size(241, 21);
            _ckLineAltitude.TabIndex = 19;
            _ckLineAltitude.Text = "Interpret 3rd parameter, if present, as altitude";
            _ckLineAltitude.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(142, 314);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(70, 25);
            _cmdCancel.TabIndex = 16;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdContinue
            // 
            _cmdContinue.BackColor = SystemColors.Control;
            _cmdContinue.Cursor = Cursors.Default;
            _cmdContinue.ForeColor = SystemColors.ControlText;
            _cmdContinue.Location = new Point(240, 314);
            _cmdContinue.Name = "_cmdContinue";
            _cmdContinue.RightToLeft = RightToLeft.No;
            _cmdContinue.Size = new Size(70, 25);
            _cmdContinue.TabIndex = 13;
            _cmdContinue.Text = "Continue ...";
            _cmdContinue.UseVisualStyleBackColor = false;
            // 
            // lbEnd
            // 
            lbEnd.AutoSize = true;
            lbEnd.BackColor = SystemColors.Control;
            lbEnd.Cursor = Cursors.Default;
            lbEnd.ForeColor = SystemColors.ControlText;
            lbEnd.Location = new Point(80, 68);
            lbEnd.Name = "lbEnd";
            lbEnd.RightToLeft = RightToLeft.No;
            lbEnd.Size = new Size(57, 13);
            lbEnd.TabIndex = 21;
            lbEnd.Text = "End Width";
            // 
            // lbStart
            // 
            lbStart.AutoSize = true;
            lbStart.BackColor = SystemColors.Control;
            lbStart.Cursor = Cursors.Default;
            lbStart.ForeColor = SystemColors.ControlText;
            lbStart.Location = new Point(14, 68);
            lbStart.Name = "lbStart";
            lbStart.RightToLeft = RightToLeft.No;
            lbStart.Size = new Size(60, 13);
            lbStart.TabIndex = 20;
            lbStart.Text = "Start Width";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.BackColor = SystemColors.Control;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(14, 25);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(244, 13);
            Label3.TabIndex = 14;
            Label3.Text = "Guid of imported lines. Click on the box to change.";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(12, 314);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(112, 32);
            Label1.TabIndex = 12;
            Label1.Text = "Edit SBuilder.ini to change Separator";
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(_lbLineColor);
            GroupBox1.Controls.Add(txtEndW);
            GroupBox1.Controls.Add(_txtLineGuid);
            GroupBox1.Controls.Add(txtStartW);
            GroupBox1.Controls.Add(_ckLineAltitude);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(lbStart);
            GroupBox1.Controls.Add(lbEnd);
            GroupBox1.Location = new Point(12, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(298, 136);
            GroupBox1.TabIndex = 24;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Properties of Imported Lines";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(137, 87);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(113, 13);
            Label2.TabIndex = 27;
            Label2.Text = "Color (click to change)";
            // 
            // lbLineColor
            // 
            _lbLineColor.BorderStyle = BorderStyle.FixedSingle;
            _lbLineColor.Location = new Point(256, 84);
            _lbLineColor.Name = "_lbLineColor";
            _lbLineColor.Size = new Size(23, 20);
            _lbLineColor.TabIndex = 23;
            _lbLineColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEndW
            // 
            txtEndW.Location = new Point(80, 84);
            txtEndW.Name = "txtEndW";
            txtEndW.Size = new Size(51, 20);
            txtEndW.TabIndex = 22;
            txtEndW.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLineGuid
            // 
            _txtLineGuid.BackColor = Color.White;
            _txtLineGuid.Location = new Point(17, 41);
            _txtLineGuid.Name = "_txtLineGuid";
            _txtLineGuid.ReadOnly = true;
            _txtLineGuid.Size = new Size(262, 20);
            _txtLineGuid.TabIndex = 21;
            _txtLineGuid.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStartW
            // 
            txtStartW.Location = new Point(17, 84);
            txtStartW.Name = "txtStartW";
            txtStartW.Size = new Size(57, 20);
            txtStartW.TabIndex = 20;
            txtStartW.TextAlign = HorizontalAlignment.Center;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(Label5);
            GroupBox2.Controls.Add(_lbPolyColor);
            GroupBox2.Controls.Add(_ckPolyAltitude);
            GroupBox2.Controls.Add(Label6);
            GroupBox2.Controls.Add(_txtPolyGuid);
            GroupBox2.Controls.Add(_ckAutoLine);
            GroupBox2.Location = new Point(13, 163);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(297, 132);
            GroupBox2.TabIndex = 25;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Properties of Imported Polygons";
            // 
            // Label5
            // 
            Label5.AutoSize = true;
            Label5.BackColor = SystemColors.Control;
            Label5.Cursor = Cursors.Default;
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(136, 76);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(113, 13);
            Label5.TabIndex = 26;
            Label5.Text = "Color (click to change)";
            // 
            // lbPolyColor
            // 
            _lbPolyColor.BorderStyle = BorderStyle.FixedSingle;
            _lbPolyColor.Location = new Point(255, 74);
            _lbPolyColor.Name = "_lbPolyColor";
            _lbPolyColor.Size = new Size(23, 20);
            _lbPolyColor.TabIndex = 25;
            _lbPolyColor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckPolyAltitude
            // 
            _ckPolyAltitude.AutoSize = true;
            _ckPolyAltitude.BackColor = SystemColors.Control;
            _ckPolyAltitude.Cursor = Cursors.Default;
            _ckPolyAltitude.ForeColor = SystemColors.ControlText;
            _ckPolyAltitude.Location = new Point(16, 107);
            _ckPolyAltitude.Name = "_ckPolyAltitude";
            _ckPolyAltitude.RightToLeft = RightToLeft.No;
            _ckPolyAltitude.Size = new Size(236, 17);
            _ckPolyAltitude.TabIndex = 24;
            _ckPolyAltitude.Text = "Interpret 3rd parameter, if present, as altitude";
            _ckPolyAltitude.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.BackColor = SystemColors.Control;
            Label6.Cursor = Cursors.Default;
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(13, 24);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(265, 13);
            Label6.TabIndex = 23;
            Label6.Text = "Guid of imported polygons. Click on the box to change.";
            // 
            // txtPolyGuid
            // 
            _txtPolyGuid.BackColor = Color.White;
            _txtPolyGuid.Location = new Point(16, 40);
            _txtPolyGuid.Name = "_txtPolyGuid";
            _txtPolyGuid.ReadOnly = true;
            _txtPolyGuid.Size = new Size(262, 20);
            _txtPolyGuid.TabIndex = 21;
            _txtPolyGuid.TextAlign = HorizontalAlignment.Center;
            // 
            // frmSurfer
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 355);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdContinue);
            Controls.Add(Label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSurfer";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - BLN Import Properties";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Load += new EventHandler(FrmSurfer_Load);
            ResumeLayout(false);
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