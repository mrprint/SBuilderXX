using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLPPointsP));
            this._cmdOK = new System.Windows.Forms.Button();
            this._cmdCancel = new System.Windows.Forms.Button();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.lbAltitude = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.lbWidth = new System.Windows.Forms.Label();
            this.lbPt = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.Frame2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdOK
            // 
            this._cmdOK.BackColor = System.Drawing.SystemColors.Control;
            this._cmdOK.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdOK.Location = new System.Drawing.Point(179, 133);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdOK.Size = new System.Drawing.Size(70, 25);
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
            this._cmdCancel.Location = new System.Drawing.Point(179, 87);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(70, 25);
            this._cmdCancel.TabIndex = 12;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.lbAltitude);
            this.Frame2.Controls.Add(this.txtAltitude);
            this.Frame2.Controls.Add(this.txtLat);
            this.Frame2.Controls.Add(this.txtLon);
            this.Frame2.Controls.Add(this.Label2);
            this.Frame2.Controls.Add(this.Label1);
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(12, 12);
            this.Frame2.Name = "Frame2";
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(146, 146);
            this.Frame2.TabIndex = 11;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Geographic Coordinates";
            // 
            // lbAltitude
            // 
            this.lbAltitude.AutoSize = true;
            this.lbAltitude.Location = new System.Drawing.Point(15, 98);
            this.lbAltitude.Name = "lbAltitude";
            this.lbAltitude.Size = new System.Drawing.Size(42, 13);
            this.lbAltitude.TabIndex = 16;
            this.lbAltitude.Text = "Altitude";
            // 
            // txtAltitude
            // 
            this.txtAltitude.AcceptsReturn = true;
            this.txtAltitude.BackColor = System.Drawing.SystemColors.Window;
            this.txtAltitude.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAltitude.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAltitude.Location = new System.Drawing.Point(15, 113);
            this.txtAltitude.MaxLength = 0;
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAltitude.Size = new System.Drawing.Size(108, 20);
            this.txtAltitude.TabIndex = 7;
            this.txtAltitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLat
            // 
            this.txtLat.AcceptsReturn = true;
            this.txtLat.BackColor = System.Drawing.SystemColors.Window;
            this.txtLat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLat.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLat.Location = new System.Drawing.Point(15, 36);
            this.txtLat.MaxLength = 0;
            this.txtLat.Name = "txtLat";
            this.txtLat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLat.Size = new System.Drawing.Size(108, 20);
            this.txtLat.TabIndex = 2;
            this.txtLat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLon
            // 
            this.txtLon.AcceptsReturn = true;
            this.txtLon.BackColor = System.Drawing.SystemColors.Window;
            this.txtLon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLon.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtLon.Location = new System.Drawing.Point(15, 75);
            this.txtLon.MaxLength = 0;
            this.txtLon.Name = "txtLon";
            this.txtLon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtLon.Size = new System.Drawing.Size(108, 20);
            this.txtLon.TabIndex = 1;
            this.txtLon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(15, 59);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(54, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Longitude";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(12, 20);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(45, 13);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Latitude";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbWidth
            // 
            this.lbWidth.AutoSize = true;
            this.lbWidth.BackColor = System.Drawing.SystemColors.Control;
            this.lbWidth.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbWidth.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbWidth.Location = new System.Drawing.Point(178, 32);
            this.lbWidth.Name = "lbWidth";
            this.lbWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbWidth.Size = new System.Drawing.Size(35, 13);
            this.lbWidth.TabIndex = 8;
            this.lbWidth.Text = "Width";
            this.lbWidth.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbPt
            // 
            this.lbPt.BackColor = System.Drawing.SystemColors.Control;
            this.lbPt.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPt.Location = new System.Drawing.Point(178, 12);
            this.lbPt.Name = "lbPt";
            this.lbPt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPt.Size = new System.Drawing.Size(46, 19);
            this.lbPt.TabIndex = 15;
            this.lbPt.Text = "PT #";
            // 
            // txtWidth
            // 
            this.txtWidth.AcceptsReturn = true;
            this.txtWidth.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWidth.Location = new System.Drawing.Point(179, 48);
            this.txtWidth.MaxLength = 0;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWidth.Size = new System.Drawing.Size(70, 20);
            this.txtWidth.TabIndex = 16;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmLPPointsP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 175);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.lbWidth);
            this.Controls.Add(this.lbPt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLPPointsP";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FrmPointsP_Load);
            this.Frame2.ResumeLayout(false);
            this.Frame2.PerformLayout();
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