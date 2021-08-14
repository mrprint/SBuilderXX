using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtraMacro));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtPD = new System.Windows.Forms.TextBox();
            this.txtPC = new System.Windows.Forms.TextBox();
            this.txtPB = new System.Windows.Forms.TextBox();
            this.txtPA = new System.Windows.Forms.TextBox();
            this._cmdClose = new System.Windows.Forms.Button();
            this.txtP9 = new System.Windows.Forms.TextBox();
            this.lbPA = new System.Windows.Forms.Label();
            this.lbP9 = new System.Windows.Forms.Label();
            this.lbPD = new System.Windows.Forms.Label();
            this.lbPC = new System.Windows.Forms.Label();
            this.lbPB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPD
            // 
            this.txtPD.AcceptsReturn = true;
            this.txtPD.BackColor = System.Drawing.SystemColors.Window;
            this.txtPD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPD.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPD.Location = new System.Drawing.Point(102, 150);
            this.txtPD.MaxLength = 0;
            this.txtPD.Name = "txtPD";
            this.txtPD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPD.Size = new System.Drawing.Size(94, 20);
            this.txtPD.TabIndex = 7;
            this.txtPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPD.Visible = false;
            // 
            // txtPC
            // 
            this.txtPC.AcceptsReturn = true;
            this.txtPC.BackColor = System.Drawing.SystemColors.Window;
            this.txtPC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPC.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPC.Location = new System.Drawing.Point(102, 117);
            this.txtPC.MaxLength = 0;
            this.txtPC.Name = "txtPC";
            this.txtPC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPC.Size = new System.Drawing.Size(94, 20);
            this.txtPC.TabIndex = 5;
            this.txtPC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPC.Visible = false;
            // 
            // txtPB
            // 
            this.txtPB.AcceptsReturn = true;
            this.txtPB.BackColor = System.Drawing.SystemColors.Window;
            this.txtPB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPB.Location = new System.Drawing.Point(102, 84);
            this.txtPB.MaxLength = 0;
            this.txtPB.Name = "txtPB";
            this.txtPB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPB.Size = new System.Drawing.Size(94, 20);
            this.txtPB.TabIndex = 3;
            this.txtPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPB.Visible = false;
            // 
            // txtPA
            // 
            this.txtPA.AcceptsReturn = true;
            this.txtPA.BackColor = System.Drawing.SystemColors.Window;
            this.txtPA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPA.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtPA.Location = new System.Drawing.Point(102, 51);
            this.txtPA.MaxLength = 0;
            this.txtPA.Name = "txtPA";
            this.txtPA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPA.Size = new System.Drawing.Size(94, 20);
            this.txtPA.TabIndex = 2;
            this.txtPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPA.Visible = false;
            // 
            // _cmdClose
            // 
            this._cmdClose.BackColor = System.Drawing.SystemColors.Control;
            this._cmdClose.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdClose.Location = new System.Drawing.Point(225, 147);
            this._cmdClose.Name = "_cmdClose";
            this._cmdClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdClose.Size = new System.Drawing.Size(70, 25);
            this._cmdClose.TabIndex = 1;
            this._cmdClose.Text = "Close";
            this._cmdClose.UseVisualStyleBackColor = false;
            this._cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // txtP9
            // 
            this.txtP9.AcceptsReturn = true;
            this.txtP9.BackColor = System.Drawing.SystemColors.Window;
            this.txtP9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtP9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtP9.Location = new System.Drawing.Point(102, 18);
            this.txtP9.MaxLength = 0;
            this.txtP9.Name = "txtP9";
            this.txtP9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtP9.Size = new System.Drawing.Size(94, 20);
            this.txtP9.TabIndex = 0;
            this.txtP9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtP9.Visible = false;
            // 
            // lbPA
            // 
            this.lbPA.BackColor = System.Drawing.SystemColors.Control;
            this.lbPA.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPA.Location = new System.Drawing.Point(12, 54);
            this.lbPA.Name = "lbPA";
            this.lbPA.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPA.Size = new System.Drawing.Size(82, 16);
            this.lbPA.TabIndex = 10;
            this.lbPA.Text = "Label1";
            this.lbPA.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbPA.Visible = false;
            // 
            // lbP9
            // 
            this.lbP9.BackColor = System.Drawing.SystemColors.Control;
            this.lbP9.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbP9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbP9.Location = new System.Drawing.Point(12, 21);
            this.lbP9.Name = "lbP9";
            this.lbP9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbP9.Size = new System.Drawing.Size(82, 16);
            this.lbP9.TabIndex = 9;
            this.lbP9.Text = "Label1";
            this.lbP9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbP9.Visible = false;
            // 
            // lbPD
            // 
            this.lbPD.BackColor = System.Drawing.SystemColors.Control;
            this.lbPD.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPD.Location = new System.Drawing.Point(12, 153);
            this.lbPD.Name = "lbPD";
            this.lbPD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPD.Size = new System.Drawing.Size(82, 16);
            this.lbPD.TabIndex = 8;
            this.lbPD.Text = "Label1";
            this.lbPD.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbPD.Visible = false;
            // 
            // lbPC
            // 
            this.lbPC.BackColor = System.Drawing.SystemColors.Control;
            this.lbPC.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPC.Location = new System.Drawing.Point(12, 120);
            this.lbPC.Name = "lbPC";
            this.lbPC.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPC.Size = new System.Drawing.Size(82, 16);
            this.lbPC.TabIndex = 6;
            this.lbPC.Text = "Label1";
            this.lbPC.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbPC.Visible = false;
            // 
            // lbPB
            // 
            this.lbPB.BackColor = System.Drawing.SystemColors.Control;
            this.lbPB.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbPB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbPB.Location = new System.Drawing.Point(12, 87);
            this.lbPB.Name = "lbPB";
            this.lbPB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPB.Size = new System.Drawing.Size(82, 16);
            this.lbPB.TabIndex = 4;
            this.lbPB.Text = "Label1";
            this.lbPB.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbPB.Visible = false;
            // 
            // frmExtraMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(318, 189);
            this.Controls.Add(this.txtPD);
            this.Controls.Add(this.txtPC);
            this.Controls.Add(this.txtPB);
            this.Controls.Add(this.txtPA);
            this.Controls.Add(this._cmdClose);
            this.Controls.Add(this.txtP9);
            this.Controls.Add(this.lbPA);
            this.Controls.Add(this.lbP9);
            this.Controls.Add(this.lbPD);
            this.Controls.Add(this.lbPC);
            this.Controls.Add(this.lbPB);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(3, 29);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExtraMacro";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "SBuilderXX - Extra Macro Parameters";
            this.Load += new System.EventHandler(this.FrmExtraMacro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /* TODO ERROR: Skipped EndRegionDirectiveTrivia */
    }
}