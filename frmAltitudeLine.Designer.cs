using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    internal partial class FrmAltitudeLine : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltitudeLine));
            this._cmdCancel = new System.Windows.Forms.Button();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this._cmdAlt = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(78, 54);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(57, 25);
            this._cmdCancel.TabIndex = 56;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // txtAlt
            // 
            this.txtAlt.AcceptsReturn = true;
            this.txtAlt.BackColor = System.Drawing.SystemColors.Window;
            this.txtAlt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAlt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAlt.Location = new System.Drawing.Point(141, 12);
            this.txtAlt.MaxLength = 0;
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAlt.Size = new System.Drawing.Size(69, 20);
            this.txtAlt.TabIndex = 29;
            this.txtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdAlt
            // 
            this._cmdAlt.BackColor = System.Drawing.SystemColors.Control;
            this._cmdAlt.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdAlt.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdAlt.Location = new System.Drawing.Point(153, 54);
            this._cmdAlt.Name = "_cmdAlt";
            this._cmdAlt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdAlt.Size = new System.Drawing.Size(57, 25);
            this._cmdAlt.TabIndex = 28;
            this._cmdAlt.Text = "OK";
            this._cmdAlt.UseVisualStyleBackColor = false;
            this._cmdAlt.Click += new System.EventHandler(this.CmdAlt_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(126, 13);
            this.Label1.TabIndex = 57;
            this.Label1.Text = "Apply altitude to all points";
            // 
            // FrmAltitudeLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 95);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._cmdAlt);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this._cmdCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltitudeLine";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Set Line Altitude";
            this.Load += new System.EventHandler(this.FrmAltitudeLine_Load);
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

        internal Label Label1;
    }
}