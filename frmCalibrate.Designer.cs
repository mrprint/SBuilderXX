using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmCalibrate : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCalibrate));
            Frame1 = new GroupBox();
            _cmdLL2 = new Button();
            _cmdLL2.Click += new EventHandler(CmdLL2_Click);
            txtLon2 = new TextBox();
            txtLat2 = new TextBox();
            txtPX2 = new TextBox();
            txtPY2 = new TextBox();
            _cmdPP2 = new Button();
            _cmdPP2.Click += new EventHandler(CmdPP2_Click);
            Label6 = new Label();
            Label5 = new Label();
            Label4 = new Label();
            Label3 = new Label();
            _cmdCalibrate = new Button();
            _cmdCalibrate.Click += new EventHandler(CmdCalibrate_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdHelp = new Button();
            _cmdHelp.Click += new EventHandler(CmdHelp_Click);
            Frame3 = new GroupBox();
            optLat = new RadioButton();
            optLon = new RadioButton();
            optLatLon = new RadioButton();
            Frame4 = new GroupBox();
            _cmdPP1 = new Button();
            _cmdPP1.Click += new EventHandler(CmdPP1_Click);
            txtPY1 = new TextBox();
            txtPX1 = new TextBox();
            txtLat1 = new TextBox();
            txtLon1 = new TextBox();
            _cmdLL1 = new Button();
            _cmdLL1.Click += new EventHandler(CmdLL1_Click);
            Label2 = new Label();
            Label1 = new Label();
            Label20 = new Label();
            Label19 = new Label();
            Frame1.SuspendLayout();
            Frame3.SuspendLayout();
            Frame4.SuspendLayout();
            SuspendLayout();
            // 
            // Frame1
            // 
            Frame1.BackColor = SystemColors.Control;
            Frame1.Controls.Add(_cmdLL2);
            Frame1.Controls.Add(txtLon2);
            Frame1.Controls.Add(txtLat2);
            Frame1.Controls.Add(txtPX2);
            Frame1.Controls.Add(txtPY2);
            Frame1.Controls.Add(_cmdPP2);
            Frame1.Controls.Add(Label6);
            Frame1.Controls.Add(Label5);
            Frame1.Controls.Add(Label4);
            Frame1.Controls.Add(Label3);
            Frame1.ForeColor = SystemColors.ControlText;
            Frame1.Location = new Point(12, 141);
            Frame1.Name = "Frame1";
            Frame1.RightToLeft = RightToLeft.No;
            Frame1.Size = new Size(319, 118);
            Frame1.TabIndex = 24;
            Frame1.TabStop = false;
            Frame1.Text = "Lat/Lon and Pixel X/Y of Point P2";
            // 
            // cmdLL2
            // 
            _cmdLL2.BackColor = SystemColors.Control;
            _cmdLL2.Cursor = Cursors.Default;
            _cmdLL2.ForeColor = SystemColors.ControlText;
            _cmdLL2.Location = new Point(15, 54);
            _cmdLL2.Name = "_cmdLL2";
            _cmdLL2.RightToLeft = RightToLeft.No;
            _cmdLL2.Size = new Size(52, 25);
            _cmdLL2.TabIndex = 24;
            _cmdLL2.Text = "Change";
            _cmdLL2.UseVisualStyleBackColor = false;
            // 
            // txtLon2
            // 
            txtLon2.AcceptsReturn = true;
            txtLon2.BackColor = SystemColors.Window;
            txtLon2.Cursor = Cursors.IBeam;
            txtLon2.ForeColor = SystemColors.WindowText;
            txtLon2.Location = new Point(75, 81);
            txtLon2.MaxLength = 0;
            txtLon2.Name = "txtLon2";
            txtLon2.RightToLeft = RightToLeft.No;
            txtLon2.Size = new Size(103, 20);
            txtLon2.TabIndex = 23;
            txtLon2.Text = "W001:00:00.0000";
            txtLon2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLat2
            // 
            txtLat2.AcceptsReturn = true;
            txtLat2.BackColor = SystemColors.Window;
            txtLat2.Cursor = Cursors.IBeam;
            txtLat2.ForeColor = SystemColors.WindowText;
            txtLat2.Location = new Point(75, 36);
            txtLat2.MaxLength = 0;
            txtLat2.Name = "txtLat2";
            txtLat2.RightToLeft = RightToLeft.No;
            txtLat2.Size = new Size(103, 20);
            txtLat2.TabIndex = 22;
            txtLat2.Text = "N01:00:00.0000";
            txtLat2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPX2
            // 
            txtPX2.AcceptsReturn = true;
            txtPX2.BackColor = SystemColors.Window;
            txtPX2.Cursor = Cursors.IBeam;
            txtPX2.ForeColor = SystemColors.WindowText;
            txtPX2.Location = new Point(189, 36);
            txtPX2.MaxLength = 0;
            txtPX2.Name = "txtPX2";
            txtPX2.RightToLeft = RightToLeft.No;
            txtPX2.Size = new Size(46, 20);
            txtPX2.TabIndex = 21;
            txtPX2.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPY2
            // 
            txtPY2.AcceptsReturn = true;
            txtPY2.BackColor = SystemColors.Window;
            txtPY2.Cursor = Cursors.IBeam;
            txtPY2.ForeColor = SystemColors.WindowText;
            txtPY2.Location = new Point(189, 81);
            txtPY2.MaxLength = 0;
            txtPY2.Name = "txtPY2";
            txtPY2.RightToLeft = RightToLeft.No;
            txtPY2.Size = new Size(46, 20);
            txtPY2.TabIndex = 20;
            txtPY2.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdPP2
            // 
            _cmdPP2.BackColor = SystemColors.Control;
            _cmdPP2.Cursor = Cursors.Default;
            _cmdPP2.ForeColor = SystemColors.ControlText;
            _cmdPP2.Location = new Point(243, 54);
            _cmdPP2.Name = "_cmdPP2";
            _cmdPP2.RightToLeft = RightToLeft.No;
            _cmdPP2.Size = new Size(55, 25);
            _cmdPP2.TabIndex = 19;
            _cmdPP2.Text = "Change";
            _cmdPP2.UseVisualStyleBackColor = false;
            // 
            // Label6
            // 
            Label6.BackColor = SystemColors.Control;
            Label6.Cursor = Cursors.Default;
            Label6.ForeColor = SystemColors.ControlText;
            Label6.Location = new Point(75, 21);
            Label6.Name = "Label6";
            Label6.RightToLeft = RightToLeft.No;
            Label6.Size = new Size(52, 13);
            Label6.TabIndex = 28;
            Label6.Text = "Latitude :";
            // 
            // Label5
            // 
            Label5.BackColor = SystemColors.Control;
            Label5.Cursor = Cursors.Default;
            Label5.ForeColor = SystemColors.ControlText;
            Label5.Location = new Point(75, 66);
            Label5.Name = "Label5";
            Label5.RightToLeft = RightToLeft.No;
            Label5.Size = new Size(58, 13);
            Label5.TabIndex = 27;
            Label5.Text = "Longitude :";
            // 
            // Label4
            // 
            Label4.BackColor = SystemColors.Control;
            Label4.Cursor = Cursors.Default;
            Label4.ForeColor = SystemColors.ControlText;
            Label4.Location = new Point(189, 21);
            Label4.Name = "Label4";
            Label4.RightToLeft = RightToLeft.No;
            Label4.Size = new Size(46, 16);
            Label4.TabIndex = 26;
            Label4.Text = "Pixel X";
            // 
            // Label3
            // 
            Label3.BackColor = SystemColors.Control;
            Label3.Cursor = Cursors.Default;
            Label3.ForeColor = SystemColors.ControlText;
            Label3.Location = new Point(189, 66);
            Label3.Name = "Label3";
            Label3.RightToLeft = RightToLeft.No;
            Label3.Size = new Size(52, 19);
            Label3.TabIndex = 25;
            Label3.Text = "Pixel Y";
            // 
            // cmdCalibrate
            // 
            _cmdCalibrate.BackColor = SystemColors.Control;
            _cmdCalibrate.Cursor = Cursors.Default;
            _cmdCalibrate.ForeColor = SystemColors.ControlText;
            _cmdCalibrate.Location = new Point(369, 234);
            _cmdCalibrate.Name = "_cmdCalibrate";
            _cmdCalibrate.RightToLeft = RightToLeft.No;
            _cmdCalibrate.Size = new Size(79, 25);
            _cmdCalibrate.TabIndex = 23;
            _cmdCalibrate.Text = "Calibrate";
            _cmdCalibrate.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(369, 195);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(79, 25);
            _cmdCancel.TabIndex = 22;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdHelp
            // 
            _cmdHelp.BackColor = SystemColors.Control;
            _cmdHelp.Cursor = Cursors.Default;
            _cmdHelp.ForeColor = SystemColors.ControlText;
            _cmdHelp.Location = new Point(369, 156);
            _cmdHelp.Name = "_cmdHelp";
            _cmdHelp.RightToLeft = RightToLeft.No;
            _cmdHelp.Size = new Size(79, 25);
            _cmdHelp.TabIndex = 21;
            _cmdHelp.Text = "Help";
            _cmdHelp.UseVisualStyleBackColor = false;
            // 
            // Frame3
            // 
            Frame3.BackColor = SystemColors.Control;
            Frame3.Controls.Add(optLat);
            Frame3.Controls.Add(optLon);
            Frame3.Controls.Add(optLatLon);
            Frame3.ForeColor = SystemColors.ControlText;
            Frame3.Location = new Point(348, 12);
            Frame3.Name = "Frame3";
            Frame3.RightToLeft = RightToLeft.No;
            Frame3.Size = new Size(112, 106);
            Frame3.TabIndex = 20;
            Frame3.TabStop = false;
            Frame3.Text = "How to Calibrate";
            // 
            // optLat
            // 
            optLat.BackColor = SystemColors.Control;
            optLat.Cursor = Cursors.Default;
            optLat.ForeColor = SystemColors.ControlText;
            optLat.Location = new Point(9, 21);
            optLat.Name = "optLat";
            optLat.RightToLeft = RightToLeft.No;
            optLat.Size = new Size(88, 30);
            optLat.TabIndex = 14;
            optLat.TabStop = true;
            optLat.Text = "Use Latitude";
            optLat.UseVisualStyleBackColor = false;
            // 
            // optLon
            // 
            optLon.BackColor = SystemColors.Control;
            optLon.Cursor = Cursors.Default;
            optLon.ForeColor = SystemColors.ControlText;
            optLon.Location = new Point(9, 48);
            optLon.Name = "optLon";
            optLon.RightToLeft = RightToLeft.No;
            optLon.Size = new Size(97, 21);
            optLon.TabIndex = 13;
            optLon.TabStop = true;
            optLon.Text = "Use Longitude";
            optLon.UseVisualStyleBackColor = false;
            // 
            // optLatLon
            // 
            optLatLon.BackColor = SystemColors.Control;
            optLatLon.Checked = true;
            optLatLon.Cursor = Cursors.Default;
            optLatLon.ForeColor = SystemColors.ControlText;
            optLatLon.Location = new Point(9, 75);
            optLatLon.Name = "optLatLon";
            optLatLon.RightToLeft = RightToLeft.No;
            optLatLon.Size = new Size(83, 17);
            optLatLon.TabIndex = 12;
            optLatLon.TabStop = true;
            optLatLon.Text = "Use Both";
            optLatLon.UseVisualStyleBackColor = false;
            // 
            // Frame4
            // 
            Frame4.BackColor = SystemColors.Control;
            Frame4.Controls.Add(_cmdPP1);
            Frame4.Controls.Add(txtPY1);
            Frame4.Controls.Add(txtPX1);
            Frame4.Controls.Add(txtLat1);
            Frame4.Controls.Add(txtLon1);
            Frame4.Controls.Add(_cmdLL1);
            Frame4.Controls.Add(Label2);
            Frame4.Controls.Add(Label1);
            Frame4.Controls.Add(Label20);
            Frame4.Controls.Add(Label19);
            Frame4.ForeColor = SystemColors.ControlText;
            Frame4.Location = new Point(12, 12);
            Frame4.Name = "Frame4";
            Frame4.RightToLeft = RightToLeft.No;
            Frame4.Size = new Size(319, 118);
            Frame4.TabIndex = 19;
            Frame4.TabStop = false;
            Frame4.Text = "Lat/Lon and Pixel X/Y of Point P1";
            // 
            // cmdPP1
            // 
            _cmdPP1.BackColor = SystemColors.Control;
            _cmdPP1.Cursor = Cursors.Default;
            _cmdPP1.ForeColor = SystemColors.ControlText;
            _cmdPP1.Location = new Point(243, 54);
            _cmdPP1.Name = "_cmdPP1";
            _cmdPP1.RightToLeft = RightToLeft.No;
            _cmdPP1.Size = new Size(55, 25);
            _cmdPP1.TabIndex = 8;
            _cmdPP1.Text = "Change";
            _cmdPP1.UseVisualStyleBackColor = false;
            // 
            // txtPY1
            // 
            txtPY1.AcceptsReturn = true;
            txtPY1.BackColor = SystemColors.Window;
            txtPY1.Cursor = Cursors.IBeam;
            txtPY1.ForeColor = SystemColors.WindowText;
            txtPY1.Location = new Point(189, 81);
            txtPY1.MaxLength = 0;
            txtPY1.Name = "txtPY1";
            txtPY1.RightToLeft = RightToLeft.No;
            txtPY1.Size = new Size(46, 20);
            txtPY1.TabIndex = 7;
            txtPY1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPX1
            // 
            txtPX1.AcceptsReturn = true;
            txtPX1.BackColor = SystemColors.Window;
            txtPX1.Cursor = Cursors.IBeam;
            txtPX1.ForeColor = SystemColors.WindowText;
            txtPX1.Location = new Point(189, 36);
            txtPX1.MaxLength = 0;
            txtPX1.Name = "txtPX1";
            txtPX1.RightToLeft = RightToLeft.No;
            txtPX1.Size = new Size(46, 20);
            txtPX1.TabIndex = 6;
            txtPX1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLat1
            // 
            txtLat1.AcceptsReturn = true;
            txtLat1.BackColor = SystemColors.Window;
            txtLat1.Cursor = Cursors.IBeam;
            txtLat1.ForeColor = SystemColors.WindowText;
            txtLat1.Location = new Point(75, 36);
            txtLat1.MaxLength = 0;
            txtLat1.Name = "txtLat1";
            txtLat1.RightToLeft = RightToLeft.No;
            txtLat1.Size = new Size(103, 20);
            txtLat1.TabIndex = 3;
            txtLat1.Text = "N01:00:00.0000";
            txtLat1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLon1
            // 
            txtLon1.AcceptsReturn = true;
            txtLon1.BackColor = SystemColors.Window;
            txtLon1.Cursor = Cursors.IBeam;
            txtLon1.ForeColor = SystemColors.WindowText;
            txtLon1.Location = new Point(75, 81);
            txtLon1.MaxLength = 0;
            txtLon1.Name = "txtLon1";
            txtLon1.RightToLeft = RightToLeft.No;
            txtLon1.Size = new Size(103, 20);
            txtLon1.TabIndex = 2;
            txtLon1.Text = "W001:00:00.0000";
            txtLon1.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdLL1
            // 
            _cmdLL1.BackColor = SystemColors.Control;
            _cmdLL1.Cursor = Cursors.Default;
            _cmdLL1.ForeColor = SystemColors.ControlText;
            _cmdLL1.Location = new Point(15, 54);
            _cmdLL1.Name = "_cmdLL1";
            _cmdLL1.RightToLeft = RightToLeft.No;
            _cmdLL1.Size = new Size(52, 25);
            _cmdLL1.TabIndex = 1;
            _cmdLL1.Text = "Change";
            _cmdLL1.UseVisualStyleBackColor = false;
            // 
            // Label2
            // 
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(189, 66);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(52, 19);
            Label2.TabIndex = 10;
            Label2.Text = "Pixel Y";
            // 
            // Label1
            // 
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(189, 21);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(46, 16);
            Label1.TabIndex = 9;
            Label1.Text = "Pixel X";
            // 
            // Label20
            // 
            Label20.BackColor = SystemColors.Control;
            Label20.Cursor = Cursors.Default;
            Label20.ForeColor = SystemColors.ControlText;
            Label20.Location = new Point(75, 66);
            Label20.Name = "Label20";
            Label20.RightToLeft = RightToLeft.No;
            Label20.Size = new Size(58, 13);
            Label20.TabIndex = 5;
            Label20.Text = "Longitude :";
            // 
            // Label19
            // 
            Label19.BackColor = SystemColors.Control;
            Label19.Cursor = Cursors.Default;
            Label19.ForeColor = SystemColors.ControlText;
            Label19.Location = new Point(75, 21);
            Label19.Name = "Label19";
            Label19.RightToLeft = RightToLeft.No;
            Label19.Size = new Size(52, 13);
            Label19.TabIndex = 4;
            Label19.Text = "Latitude :";
            // 
            // frmCalibrate
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 277);
            Controls.Add(Frame1);
            Controls.Add(_cmdCalibrate);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdHelp);
            Controls.Add(Frame3);
            Controls.Add(Frame4);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCalibrate";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SBuilderX - Map Calibration";
            Frame1.ResumeLayout(false);
            Frame1.PerformLayout();
            Frame3.ResumeLayout(false);
            Frame4.ResumeLayout(false);
            Frame4.PerformLayout();
            Load += new EventHandler(FrmCalibrate_Load);
            ResumeLayout(false);
        }

        public GroupBox Frame1;
        private Button _cmdLL2;

        public Button cmdLL2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLL2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLL2 != null)
                {
                    _cmdLL2.Click -= CmdLL2_Click;
                }

                _cmdLL2 = value;
                if (_cmdLL2 != null)
                {
                    _cmdLL2.Click += CmdLL2_Click;
                }
            }
        }

        public TextBox txtLon2;
        public TextBox txtLat2;
        public TextBox txtPX2;
        public TextBox txtPY2;
        private Button _cmdPP2;

        public Button cmdPP2
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPP2;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPP2 != null)
                {
                    _cmdPP2.Click -= CmdPP2_Click;
                }

                _cmdPP2 = value;
                if (_cmdPP2 != null)
                {
                    _cmdPP2.Click += CmdPP2_Click;
                }
            }
        }

        public Label Label6;
        public Label Label5;
        public Label Label4;
        public Label Label3;
        private Button _cmdCalibrate;

        public Button cmdCalibrate
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCalibrate;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCalibrate != null)
                {
                    _cmdCalibrate.Click -= CmdCalibrate_Click;
                }

                _cmdCalibrate = value;
                if (_cmdCalibrate != null)
                {
                    _cmdCalibrate.Click += CmdCalibrate_Click;
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

        private Button _cmdHelp;

        public Button cmdHelp
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdHelp;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdHelp != null)
                {
                    _cmdHelp.Click -= CmdHelp_Click;
                }

                _cmdHelp = value;
                if (_cmdHelp != null)
                {
                    _cmdHelp.Click += CmdHelp_Click;
                }
            }
        }

        public GroupBox Frame3;
        public RadioButton optLat;
        public RadioButton optLon;
        public RadioButton optLatLon;
        public GroupBox Frame4;
        private Button _cmdPP1;

        public Button cmdPP1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdPP1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdPP1 != null)
                {
                    _cmdPP1.Click -= CmdPP1_Click;
                }

                _cmdPP1 = value;
                if (_cmdPP1 != null)
                {
                    _cmdPP1.Click += CmdPP1_Click;
                }
            }
        }

        public TextBox txtPY1;
        public TextBox txtPX1;
        public TextBox txtLat1;
        public TextBox txtLon1;
        private Button _cmdLL1;

        public Button cmdLL1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdLL1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdLL1 != null)
                {
                    _cmdLL1.Click -= CmdLL1_Click;
                }

                _cmdLL1 = value;
                if (_cmdLL1 != null)
                {
                    _cmdLL1.Click += CmdLL1_Click;
                }
            }
        }

        public Label Label2;
        public Label Label1;
        public Label Label20;
        public Label Label19;
    }
}