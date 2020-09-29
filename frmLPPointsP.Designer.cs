using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class FrmLPPointsP : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLPPointsP));
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            Frame2 = new GroupBox();
            lbAltitude = new Label();
            txtAltitude = new TextBox();
            txtLat = new TextBox();
            txtLon = new TextBox();
            Label2 = new Label();
            Label1 = new Label();
            lbWidth = new Label();
            lbPt = new Label();
            txtWidth = new TextBox();
            Frame2.SuspendLayout();
            SuspendLayout();
            // 
            // cmdOK
            // 
            _cmdOK.BackColor = SystemColors.Control;
            _cmdOK.Cursor = Cursors.Default;
            _cmdOK.ForeColor = SystemColors.ControlText;
            _cmdOK.Location = new Point(179, 133);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.RightToLeft = RightToLeft.No;
            _cmdOK.Size = new Size(70, 25);
            _cmdOK.TabIndex = 13;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(179, 87);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(70, 25);
            _cmdCancel.TabIndex = 12;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // Frame2
            // 
            Frame2.BackColor = SystemColors.Control;
            Frame2.Controls.Add(lbAltitude);
            Frame2.Controls.Add(txtAltitude);
            Frame2.Controls.Add(txtLat);
            Frame2.Controls.Add(txtLon);
            Frame2.Controls.Add(Label2);
            Frame2.Controls.Add(Label1);
            Frame2.ForeColor = SystemColors.ControlText;
            Frame2.Location = new Point(12, 12);
            Frame2.Name = "Frame2";
            Frame2.RightToLeft = RightToLeft.No;
            Frame2.Size = new Size(146, 146);
            Frame2.TabIndex = 11;
            Frame2.TabStop = false;
            Frame2.Text = "Geographic Coordinates";
            // 
            // lbAltitude
            // 
            lbAltitude.AutoSize = true;
            lbAltitude.Location = new Point(15, 98);
            lbAltitude.Name = "lbAltitude";
            lbAltitude.Size = new Size(42, 13);
            lbAltitude.TabIndex = 16;
            lbAltitude.Text = "Altitude";
            // 
            // txtAltitude
            // 
            txtAltitude.AcceptsReturn = true;
            txtAltitude.BackColor = SystemColors.Window;
            txtAltitude.Cursor = Cursors.IBeam;
            txtAltitude.ForeColor = SystemColors.WindowText;
            txtAltitude.Location = new Point(15, 113);
            txtAltitude.MaxLength = 0;
            txtAltitude.Name = "txtAltitude";
            txtAltitude.RightToLeft = RightToLeft.No;
            txtAltitude.Size = new Size(108, 20);
            txtAltitude.TabIndex = 7;
            txtAltitude.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLat
            // 
            txtLat.AcceptsReturn = true;
            txtLat.BackColor = SystemColors.Window;
            txtLat.Cursor = Cursors.IBeam;
            txtLat.ForeColor = SystemColors.WindowText;
            txtLat.Location = new Point(15, 36);
            txtLat.MaxLength = 0;
            txtLat.Name = "txtLat";
            txtLat.RightToLeft = RightToLeft.No;
            txtLat.Size = new Size(108, 20);
            txtLat.TabIndex = 2;
            txtLat.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLon
            // 
            txtLon.AcceptsReturn = true;
            txtLon.BackColor = SystemColors.Window;
            txtLon.Cursor = Cursors.IBeam;
            txtLon.ForeColor = SystemColors.WindowText;
            txtLon.Location = new Point(15, 75);
            txtLon.MaxLength = 0;
            txtLon.Name = "txtLon";
            txtLon.RightToLeft = RightToLeft.No;
            txtLon.Size = new Size(108, 20);
            txtLon.TabIndex = 1;
            txtLon.TextAlign = HorizontalAlignment.Center;
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(15, 59);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(54, 13);
            Label2.TabIndex = 3;
            Label2.Text = "Longitude";
            Label2.TextAlign = ContentAlignment.TopRight;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(12, 20);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(45, 13);
            Label1.TabIndex = 4;
            Label1.Text = "Latitude";
            Label1.TextAlign = ContentAlignment.TopRight;
            // 
            // lbWidth
            // 
            lbWidth.AutoSize = true;
            lbWidth.BackColor = SystemColors.Control;
            lbWidth.Cursor = Cursors.Default;
            lbWidth.ForeColor = SystemColors.ControlText;
            lbWidth.Location = new Point(178, 32);
            lbWidth.Name = "lbWidth";
            lbWidth.RightToLeft = RightToLeft.No;
            lbWidth.Size = new Size(35, 13);
            lbWidth.TabIndex = 8;
            lbWidth.Text = "Width";
            lbWidth.TextAlign = ContentAlignment.TopRight;
            // 
            // lbPt
            // 
            lbPt.BackColor = SystemColors.Control;
            lbPt.Cursor = Cursors.Default;
            lbPt.ForeColor = SystemColors.ControlText;
            lbPt.Location = new Point(178, 12);
            lbPt.Name = "lbPt";
            lbPt.RightToLeft = RightToLeft.No;
            lbPt.Size = new Size(46, 19);
            lbPt.TabIndex = 15;
            lbPt.Text = "PT #";
            // 
            // txtWidth
            // 
            txtWidth.AcceptsReturn = true;
            txtWidth.BackColor = SystemColors.Window;
            txtWidth.Cursor = Cursors.IBeam;
            txtWidth.ForeColor = SystemColors.WindowText;
            txtWidth.Location = new Point(179, 48);
            txtWidth.MaxLength = 0;
            txtWidth.Name = "txtWidth";
            txtWidth.RightToLeft = RightToLeft.No;
            txtWidth.Size = new Size(70, 20);
            txtWidth.TabIndex = 16;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // frmLPPointsP
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 175);
            Controls.Add(txtWidth);
            Controls.Add(_cmdOK);
            Controls.Add(_cmdCancel);
            Controls.Add(Frame2);
            Controls.Add(lbWidth);
            Controls.Add(lbPt);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLPPointsP";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Frame2.ResumeLayout(false);
            Frame2.PerformLayout();
            Load += new EventHandler(FrmPointsP_Load);
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
        public TextBox txtAltitude;
        public TextBox txtLat;
        public TextBox txtLon;
        public Label lbWidth;
        public Label Label1;
        public Label Label2;
        public Label lbPt;
        internal Label lbAltitude;
        public TextBox txtWidth;
    }
}