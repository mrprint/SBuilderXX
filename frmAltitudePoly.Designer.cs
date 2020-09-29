using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltitudePoly));
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            GroupBox1 = new GroupBox();
            txtAlt = new TextBox();
            _cmdAlt = new Button();
            _cmdAlt.Click += new EventHandler(CmdAlt_Click);
            GroupBox3 = new GroupBox();
            txtHead = new TextBox();
            txtAlt0 = new TextBox();
            _cmdHelpSlope = new Button();
            _cmdHelpSlope.Click += new EventHandler(CmdHelpSlope_Click);
            _cmdSlope = new Button();
            _cmdSlope.Click += new EventHandler(CmdSlope_Click);
            txtSlope = new TextBox();
            Label8 = new Label();
            Label6 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            txtPt0 = new TextBox();
            lbSX = new Label();
            lbSY = new Label();
            GroupBox1.SuspendLayout();
            GroupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(396, 99);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(57, 25);
            _cmdCancel.TabIndex = 54;
            _cmdCancel.Text = "Close";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(txtAlt);
            GroupBox1.Controls.Add(_cmdAlt);
            GroupBox1.Location = new Point(264, 13);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(205, 59);
            GroupBox1.TabIndex = 51;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Apply constant altitude to Points";
            // 
            // txtAlt
            // 
            txtAlt.BackColor = SystemColors.Window;
            txtAlt.Cursor = Cursors.IBeam;
            txtAlt.ForeColor = SystemColors.WindowText;
            txtAlt.Location = new Point(23, 27);
            txtAlt.MaxLength = 0;
            txtAlt.Name = "txtAlt";
            txtAlt.RightToLeft = RightToLeft.No;
            txtAlt.Size = new Size(85, 20);
            txtAlt.TabIndex = 29;
            txtAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdAlt
            // 
            _cmdAlt.BackColor = SystemColors.Control;
            _cmdAlt.Cursor = Cursors.Default;
            _cmdAlt.ForeColor = SystemColors.ControlText;
            _cmdAlt.Location = new Point(132, 24);
            _cmdAlt.Name = "_cmdAlt";
            _cmdAlt.RightToLeft = RightToLeft.No;
            _cmdAlt.Size = new Size(57, 25);
            _cmdAlt.TabIndex = 28;
            _cmdAlt.Text = "Set";
            _cmdAlt.UseVisualStyleBackColor = false;
            // 
            // GroupBox3
            // 
            GroupBox3.Controls.Add(txtHead);
            GroupBox3.Controls.Add(txtAlt0);
            GroupBox3.Controls.Add(_cmdHelpSlope);
            GroupBox3.Controls.Add(_cmdSlope);
            GroupBox3.Controls.Add(txtSlope);
            GroupBox3.Controls.Add(Label8);
            GroupBox3.Controls.Add(Label6);
            GroupBox3.Controls.Add(Label2);
            GroupBox3.Controls.Add(Label1);
            GroupBox3.Controls.Add(txtPt0);
            GroupBox3.Location = new Point(12, 12);
            GroupBox3.Name = "GroupBox3";
            GroupBox3.Size = new Size(234, 126);
            GroupBox3.TabIndex = 55;
            GroupBox3.TabStop = false;
            GroupBox3.Text = "Set 1 point and maximum slope";
            // 
            // txtHead
            // 
            txtHead.BackColor = SystemColors.Window;
            txtHead.Cursor = Cursors.IBeam;
            txtHead.ForeColor = SystemColors.WindowText;
            txtHead.Location = new Point(68, 66);
            txtHead.MaxLength = 0;
            txtHead.Name = "txtHead";
            txtHead.RightToLeft = RightToLeft.No;
            txtHead.Size = new Size(71, 20);
            txtHead.TabIndex = 63;
            txtHead.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAlt0
            // 
            txtAlt0.BackColor = SystemColors.Window;
            txtAlt0.Cursor = Cursors.IBeam;
            txtAlt0.ForeColor = SystemColors.WindowText;
            txtAlt0.Location = new Point(18, 40);
            txtAlt0.MaxLength = 0;
            txtAlt0.Name = "txtAlt0";
            txtAlt0.RightToLeft = RightToLeft.No;
            txtAlt0.Size = new Size(81, 20);
            txtAlt0.TabIndex = 62;
            txtAlt0.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdHelpSlope
            // 
            _cmdHelpSlope.BackColor = SystemColors.Control;
            _cmdHelpSlope.Cursor = Cursors.Default;
            _cmdHelpSlope.ForeColor = SystemColors.ControlText;
            _cmdHelpSlope.Location = new Point(161, 40);
            _cmdHelpSlope.Name = "_cmdHelpSlope";
            _cmdHelpSlope.RightToLeft = RightToLeft.No;
            _cmdHelpSlope.Size = new Size(57, 25);
            _cmdHelpSlope.TabIndex = 61;
            _cmdHelpSlope.Text = "Help";
            _cmdHelpSlope.UseVisualStyleBackColor = false;
            // 
            // cmdSlope
            // 
            _cmdSlope.BackColor = SystemColors.Control;
            _cmdSlope.Cursor = Cursors.Default;
            _cmdSlope.ForeColor = SystemColors.ControlText;
            _cmdSlope.Location = new Point(161, 87);
            _cmdSlope.Name = "_cmdSlope";
            _cmdSlope.RightToLeft = RightToLeft.No;
            _cmdSlope.Size = new Size(57, 25);
            _cmdSlope.TabIndex = 60;
            _cmdSlope.Text = "Set";
            _cmdSlope.UseVisualStyleBackColor = false;
            // 
            // txtSlope
            // 
            txtSlope.BackColor = SystemColors.Window;
            txtSlope.Cursor = Cursors.IBeam;
            txtSlope.ForeColor = SystemColors.WindowText;
            txtSlope.Location = new Point(68, 92);
            txtSlope.MaxLength = 0;
            txtSlope.Name = "txtSlope";
            txtSlope.RightToLeft = RightToLeft.No;
            txtSlope.Size = new Size(71, 20);
            txtSlope.TabIndex = 58;
            txtSlope.TextAlign = HorizontalAlignment.Center;
            // 
            // Label8
            // 
            Label8.AutoSize = true;
            Label8.Location = new Point(28, 95);
            Label8.Name = "Label8";
            Label8.Size = new Size(34, 13);
            Label8.TabIndex = 59;
            Label8.Text = "Slope";
            // 
            // Label6
            // 
            Label6.AutoSize = true;
            Label6.Location = new Point(15, 68);
            Label6.Name = "Label6";
            Label6.Size = new Size(47, 13);
            Label6.TabIndex = 57;
            Label6.Text = "Heading";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(102, 25);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(27, 13);
            Label2.TabIndex = 56;
            Label2.Text = "Pt #";
            Label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(15, 25);
            Label1.Name = "Label1";
            Label1.Size = new Size(42, 13);
            Label1.TabIndex = 53;
            Label1.Text = "Altitude";
            // 
            // txtPt0
            // 
            txtPt0.BackColor = SystemColors.Window;
            txtPt0.Cursor = Cursors.IBeam;
            txtPt0.ForeColor = SystemColors.WindowText;
            txtPt0.Location = new Point(105, 40);
            txtPt0.MaxLength = 0;
            txtPt0.Name = "txtPt0";
            txtPt0.RightToLeft = RightToLeft.No;
            txtPt0.Size = new Size(34, 20);
            txtPt0.TabIndex = 52;
            txtPt0.TextAlign = HorizontalAlignment.Center;
            // 
            // lbSX
            // 
            lbSX.AutoSize = true;
            lbSX.Location = new Point(261, 99);
            lbSX.Name = "lbSX";
            lbSX.Size = new Size(59, 13);
            lbSX.TabIndex = 56;
            lbSX.Text = "SlopeX = 0";
            // 
            // lbSY
            // 
            lbSY.AutoSize = true;
            lbSY.Location = new Point(261, 115);
            lbSY.Name = "lbSY";
            lbSY.Size = new Size(59, 13);
            lbSY.TabIndex = 57;
            lbSY.Text = "SlopeY = 0";
            // 
            // frmAltitudePoly
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 151);
            Controls.Add(lbSY);
            Controls.Add(lbSX);
            Controls.Add(GroupBox3);
            Controls.Add(_cmdCancel);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAltitudePoly";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Set Polygon Altitude";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox3.ResumeLayout(false);
            GroupBox3.PerformLayout();
            Load += new EventHandler(FrmLPAltitude_Load);
            ResumeLayout(false);
            PerformLayout();
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