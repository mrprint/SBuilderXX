using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    internal partial class frmExtraMacro
    {
        /* TODO ERROR: Skipped RegionDirectiveTrivia */
        [DebuggerNonUserCode()]
        public frmExtraMacro() : base()
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
        }
        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool Disposing)
        {
            if (Disposing)
            {
                if (components is object)
                {
                    components.Dispose();
                }
            }

            base.Dispose(Disposing);
        }
        // Required by the Windows Form Designer
        private System.ComponentModel.IContainer components;
        public ToolTip ToolTip1;
        public TextBox txtPD;
        public TextBox txtPC;
        public TextBox txtPB;
        public TextBox txtPA;
        private Button _cmdClose;

        public Button cmdClose
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdClose;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdClose != null)
                {
                    _cmdClose.Click -= CmdClose_Click;
                }

                _cmdClose = value;
                if (_cmdClose != null)
                {
                    _cmdClose.Click += CmdClose_Click;
                }
            }
        }

        public TextBox txtP9;
        public Label lbPA;
        public Label lbP9;
        public Label lbPD;
        public Label lbPC;
        public Label lbPB;
        // NOTE: The following procedure is required by the Windows Form Designer
        // It can be modified using the Windows Form Designer.
        // Do not modify it using the code editor.
        [DebuggerStepThrough()]
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtraMacro));
            ToolTip1 = new ToolTip(components);
            txtPD = new TextBox();
            txtPC = new TextBox();
            txtPB = new TextBox();
            txtPA = new TextBox();
            _cmdClose = new Button();
            _cmdClose.Click += new EventHandler(CmdClose_Click);
            txtP9 = new TextBox();
            lbPA = new Label();
            lbP9 = new Label();
            lbPD = new Label();
            lbPC = new Label();
            lbPB = new Label();
            SuspendLayout();
            // 
            // txtPD
            // 
            txtPD.AcceptsReturn = true;
            txtPD.BackColor = SystemColors.Window;
            txtPD.Cursor = Cursors.IBeam;
            txtPD.ForeColor = SystemColors.WindowText;
            txtPD.Location = new Point(102, 150);
            txtPD.MaxLength = 0;
            txtPD.Name = "txtPD";
            txtPD.RightToLeft = RightToLeft.No;
            txtPD.Size = new Size(94, 20);
            txtPD.TabIndex = 7;
            txtPD.TextAlign = HorizontalAlignment.Center;
            txtPD.Visible = false;
            // 
            // txtPC
            // 
            txtPC.AcceptsReturn = true;
            txtPC.BackColor = SystemColors.Window;
            txtPC.Cursor = Cursors.IBeam;
            txtPC.ForeColor = SystemColors.WindowText;
            txtPC.Location = new Point(102, 117);
            txtPC.MaxLength = 0;
            txtPC.Name = "txtPC";
            txtPC.RightToLeft = RightToLeft.No;
            txtPC.Size = new Size(94, 20);
            txtPC.TabIndex = 5;
            txtPC.TextAlign = HorizontalAlignment.Center;
            txtPC.Visible = false;
            // 
            // txtPB
            // 
            txtPB.AcceptsReturn = true;
            txtPB.BackColor = SystemColors.Window;
            txtPB.Cursor = Cursors.IBeam;
            txtPB.ForeColor = SystemColors.WindowText;
            txtPB.Location = new Point(102, 84);
            txtPB.MaxLength = 0;
            txtPB.Name = "txtPB";
            txtPB.RightToLeft = RightToLeft.No;
            txtPB.Size = new Size(94, 20);
            txtPB.TabIndex = 3;
            txtPB.TextAlign = HorizontalAlignment.Center;
            txtPB.Visible = false;
            // 
            // txtPA
            // 
            txtPA.AcceptsReturn = true;
            txtPA.BackColor = SystemColors.Window;
            txtPA.Cursor = Cursors.IBeam;
            txtPA.ForeColor = SystemColors.WindowText;
            txtPA.Location = new Point(102, 51);
            txtPA.MaxLength = 0;
            txtPA.Name = "txtPA";
            txtPA.RightToLeft = RightToLeft.No;
            txtPA.Size = new Size(94, 20);
            txtPA.TabIndex = 2;
            txtPA.TextAlign = HorizontalAlignment.Center;
            txtPA.Visible = false;
            // 
            // cmdClose
            // 
            _cmdClose.BackColor = SystemColors.Control;
            _cmdClose.Cursor = Cursors.Default;
            _cmdClose.ForeColor = SystemColors.ControlText;
            _cmdClose.Location = new Point(225, 147);
            _cmdClose.Name = "_cmdClose";
            _cmdClose.RightToLeft = RightToLeft.No;
            _cmdClose.Size = new Size(70, 25);
            _cmdClose.TabIndex = 1;
            _cmdClose.Text = "Close";
            _cmdClose.UseVisualStyleBackColor = false;
            // 
            // txtP9
            // 
            txtP9.AcceptsReturn = true;
            txtP9.BackColor = SystemColors.Window;
            txtP9.Cursor = Cursors.IBeam;
            txtP9.ForeColor = SystemColors.WindowText;
            txtP9.Location = new Point(102, 18);
            txtP9.MaxLength = 0;
            txtP9.Name = "txtP9";
            txtP9.RightToLeft = RightToLeft.No;
            txtP9.Size = new Size(94, 20);
            txtP9.TabIndex = 0;
            txtP9.TextAlign = HorizontalAlignment.Center;
            txtP9.Visible = false;
            // 
            // lbPA
            // 
            lbPA.BackColor = SystemColors.Control;
            lbPA.Cursor = Cursors.Default;
            lbPA.ForeColor = SystemColors.ControlText;
            lbPA.Location = new Point(12, 54);
            lbPA.Name = "lbPA";
            lbPA.RightToLeft = RightToLeft.No;
            lbPA.Size = new Size(82, 16);
            lbPA.TabIndex = 10;
            lbPA.Text = "Label1";
            lbPA.TextAlign = ContentAlignment.TopRight;
            lbPA.Visible = false;
            // 
            // lbP9
            // 
            lbP9.BackColor = SystemColors.Control;
            lbP9.Cursor = Cursors.Default;
            lbP9.ForeColor = SystemColors.ControlText;
            lbP9.Location = new Point(12, 21);
            lbP9.Name = "lbP9";
            lbP9.RightToLeft = RightToLeft.No;
            lbP9.Size = new Size(82, 16);
            lbP9.TabIndex = 9;
            lbP9.Text = "Label1";
            lbP9.TextAlign = ContentAlignment.TopRight;
            lbP9.Visible = false;
            // 
            // lbPD
            // 
            lbPD.BackColor = SystemColors.Control;
            lbPD.Cursor = Cursors.Default;
            lbPD.ForeColor = SystemColors.ControlText;
            lbPD.Location = new Point(12, 153);
            lbPD.Name = "lbPD";
            lbPD.RightToLeft = RightToLeft.No;
            lbPD.Size = new Size(82, 16);
            lbPD.TabIndex = 8;
            lbPD.Text = "Label1";
            lbPD.TextAlign = ContentAlignment.TopRight;
            lbPD.Visible = false;
            // 
            // lbPC
            // 
            lbPC.BackColor = SystemColors.Control;
            lbPC.Cursor = Cursors.Default;
            lbPC.ForeColor = SystemColors.ControlText;
            lbPC.Location = new Point(12, 120);
            lbPC.Name = "lbPC";
            lbPC.RightToLeft = RightToLeft.No;
            lbPC.Size = new Size(82, 16);
            lbPC.TabIndex = 6;
            lbPC.Text = "Label1";
            lbPC.TextAlign = ContentAlignment.TopRight;
            lbPC.Visible = false;
            // 
            // lbPB
            // 
            lbPB.BackColor = SystemColors.Control;
            lbPB.Cursor = Cursors.Default;
            lbPB.ForeColor = SystemColors.ControlText;
            lbPB.Location = new Point(12, 87);
            lbPB.Name = "lbPB";
            lbPB.RightToLeft = RightToLeft.No;
            lbPB.Size = new Size(82, 16);
            lbPB.TabIndex = 4;
            lbPB.Text = "Label1";
            lbPB.TextAlign = ContentAlignment.TopRight;
            lbPB.Visible = false;
            // 
            // frmExtraMacro
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(318, 189);
            Controls.Add(txtPD);
            Controls.Add(txtPC);
            Controls.Add(txtPB);
            Controls.Add(txtPA);
            Controls.Add(_cmdClose);
            Controls.Add(txtP9);
            Controls.Add(lbPA);
            Controls.Add(lbP9);
            Controls.Add(lbPD);
            Controls.Add(lbPC);
            Controls.Add(lbPB);
            Cursor = Cursors.Default;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(3, 29);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmExtraMacro";
            RightToLeft = RightToLeft.No;
            Text = "SBuilderX - Extra Macro Parameters";
            Load += new EventHandler(FrmExtraMacro_Load);
            ResumeLayout(false);
        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}