using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmAltitudePoly : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltitudePoly));
            this._cmdCancel = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this._cmdAlt = new System.Windows.Forms.Button();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txtAlt0 = new System.Windows.Forms.TextBox();
            this._cmdHelpSlope = new System.Windows.Forms.Button();
            this._cmdSlope = new System.Windows.Forms.Button();
            this.txtSlope = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtPt0 = new System.Windows.Forms.TextBox();
            this.lbSX = new System.Windows.Forms.Label();
            this.lbSY = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(396, 99);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(57, 25);
            this._cmdCancel.TabIndex = 54;
            this._cmdCancel.Text = "Close";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtAlt);
            this.GroupBox1.Controls.Add(this._cmdAlt);
            this.GroupBox1.Location = new System.Drawing.Point(264, 13);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(205, 59);
            this.GroupBox1.TabIndex = 51;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Apply constant altitude to Points";
            // 
            // txtAlt
            // 
            this.txtAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlt.Location = new System.Drawing.Point(23, 27);
            this.txtAlt.MaxLength = 0;
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlt.Size = new System.Drawing.Size(85, 20);
            this.txtAlt.TabIndex = 29;
            this.txtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdAlt
            // 
            this._cmdAlt.BackColor = System.Drawing.SystemColors.Control;
            this._cmdAlt.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAlt.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAlt.Location = new System.Drawing.Point(132, 24);
            this._cmdAlt.Name = "_cmdAlt";
            this._cmdAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAlt.Size = new System.Drawing.Size(57, 25);
            this._cmdAlt.TabIndex = 28;
            this._cmdAlt.Text = "Set";
            this._cmdAlt.UseVisualStyleBackColor = false;
            this._cmdAlt.Click += new System.EventHandler(this.CmdAlt_Click);
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.txtHead);
            this.GroupBox3.Controls.Add(this.txtAlt0);
            this.GroupBox3.Controls.Add(this._cmdHelpSlope);
            this.GroupBox3.Controls.Add(this._cmdSlope);
            this.GroupBox3.Controls.Add(this.txtSlope);
            this.GroupBox3.Controls.Add(this.Label8);
            this.GroupBox3.Controls.Add(this.Label6);
            this.GroupBox3.Controls.Add(this.Label2);
            this.GroupBox3.Controls.Add(this.Label1);
            this.GroupBox3.Controls.Add(this.txtPt0);
            this.GroupBox3.Location = new System.Drawing.Point(12, 12);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(234, 126);
            this.GroupBox3.TabIndex = 55;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Set 1 point and maximum slope";
            // 
            // txtHead
            // 
            this.txtHead.BackColor = System.Drawing.SystemColors.Window;
            this.txtHead.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHead.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtHead.Location = new System.Drawing.Point(68, 66);
            this.txtHead.MaxLength = 0;
            this.txtHead.Name = "txtHead";
            this.txtHead.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtHead.Size = new System.Drawing.Size(71, 20);
            this.txtHead.TabIndex = 63;
            this.txtHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAlt0
            // 
            this.txtAlt0.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlt0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlt0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlt0.Location = new System.Drawing.Point(18, 40);
            this.txtAlt0.MaxLength = 0;
            this.txtAlt0.Name = "txtAlt0";
            this.txtAlt0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlt0.Size = new System.Drawing.Size(81, 20);
            this.txtAlt0.TabIndex = 62;
            this.txtAlt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdHelpSlope
            // 
            this._cmdHelpSlope.BackColor = System.Drawing.SystemColors.Control;
            this._cmdHelpSlope.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdHelpSlope.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdHelpSlope.Location = new System.Drawing.Point(161, 40);
            this._cmdHelpSlope.Name = "_cmdHelpSlope";
            this._cmdHelpSlope.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdHelpSlope.Size = new System.Drawing.Size(57, 25);
            this._cmdHelpSlope.TabIndex = 61;
            this._cmdHelpSlope.Text = "Help";
            this._cmdHelpSlope.UseVisualStyleBackColor = false;
            this._cmdHelpSlope.Click += new System.EventHandler(this.CmdHelpSlope_Click);
            // 
            // _cmdSlope
            // 
            this._cmdSlope.BackColor = System.Drawing.SystemColors.Control;
            this._cmdSlope.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdSlope.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdSlope.Location = new System.Drawing.Point(161, 87);
            this._cmdSlope.Name = "_cmdSlope";
            this._cmdSlope.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdSlope.Size = new System.Drawing.Size(57, 25);
            this._cmdSlope.TabIndex = 60;
            this._cmdSlope.Text = "Set";
            this._cmdSlope.UseVisualStyleBackColor = false;
            this._cmdSlope.Click += new System.EventHandler(this.CmdSlope_Click);
            // 
            // txtSlope
            // 
            this.txtSlope.BackColor = System.Drawing.SystemColors.Window;
            this.txtSlope.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSlope.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSlope.Location = new System.Drawing.Point(68, 92);
            this.txtSlope.MaxLength = 0;
            this.txtSlope.Name = "txtSlope";
            this.txtSlope.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSlope.Size = new System.Drawing.Size(71, 20);
            this.txtSlope.TabIndex = 58;
            this.txtSlope.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(28, 95);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(34, 13);
            this.Label8.TabIndex = 59;
            this.Label8.Text = "Slope";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(15, 68);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(47, 13);
            this.Label6.TabIndex = 57;
            this.Label6.Text = "Heading";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(102, 25);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(27, 13);
            this.Label2.TabIndex = 56;
            this.Label2.Text = "Pt #";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(15, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(42, 13);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "Altitude";
            // 
            // txtPt0
            // 
            this.txtPt0.BackColor = System.Drawing.SystemColors.Window;
            this.txtPt0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPt0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPt0.Location = new System.Drawing.Point(105, 40);
            this.txtPt0.MaxLength = 0;
            this.txtPt0.Name = "txtPt0";
            this.txtPt0.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPt0.Size = new System.Drawing.Size(34, 20);
            this.txtPt0.TabIndex = 52;
            this.txtPt0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbSX
            // 
            this.lbSX.AutoSize = true;
            this.lbSX.Location = new System.Drawing.Point(261, 99);
            this.lbSX.Name = "lbSX";
            this.lbSX.Size = new System.Drawing.Size(59, 13);
            this.lbSX.TabIndex = 56;
            this.lbSX.Text = "SlopeX = 0";
            // 
            // lbSY
            // 
            this.lbSY.AutoSize = true;
            this.lbSY.Location = new System.Drawing.Point(261, 115);
            this.lbSY.Name = "lbSY";
            this.lbSY.Size = new System.Drawing.Size(59, 13);
            this.lbSY.TabIndex = 57;
            this.lbSY.Text = "SlopeY = 0";
            // 
            // FrmAltitudePoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 151);
            this.Controls.Add(this.lbSY);
            this.Controls.Add(this.lbSX);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltitudePoly";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Set Polygon Altitude";
            this.Load += new System.EventHandler(this.FrmLPAltitude_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button _cmdCancel;

        internal Button cmdCancel
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

        internal GroupBox GroupBox1;
        public TextBox txtAlt;
        private Button _cmdAlt;

        public Button cmdAlt
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdAlt;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdAlt != null)
                {
                    _cmdAlt.Click -= CmdAlt_Click;
                }

                _cmdAlt = value;
                if (_cmdAlt != null)
                {
                    _cmdAlt.Click += CmdAlt_Click;
                }
            }
        }

        internal GroupBox GroupBox3;
        internal Label Label1;
        public TextBox txtPt0;
        internal Label Label8;
        public TextBox txtSlope;
        internal Label Label6;
        public Label Label2;
        private Button _cmdHelpSlope;

        public Button cmdHelpSlope
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdHelpSlope;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdHelpSlope != null)
                {
                    _cmdHelpSlope.Click -= CmdHelpSlope_Click;
                }

                _cmdHelpSlope = value;
                if (_cmdHelpSlope != null)
                {
                    _cmdHelpSlope.Click += CmdHelpSlope_Click;
                }
            }
        }

        private Button _cmdSlope;

        public Button cmdSlope
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSlope;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSlope != null)
                {
                    _cmdSlope.Click -= CmdSlope_Click;
                }

                _cmdSlope = value;
                if (_cmdSlope != null)
                {
                    _cmdSlope.Click += CmdSlope_Click;
                }
            }
        }

        internal Label lbSX;
        internal Label lbSY;
        public TextBox txtHead;
        public TextBox txtAlt0;
    }
}