using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAltitudeLine));
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            txtAlt = new TextBox();
            _cmdAlt = new Button();
            _cmdAlt.Click += new EventHandler(CmdAlt_Click);
            Label1 = new Label();
            SuspendLayout();
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(78, 54);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(57, 25);
            _cmdCancel.TabIndex = 56;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // txtAlt
            // 
            txtAlt.AcceptsReturn = true;
            txtAlt.BackColor = SystemColors.Window;
            txtAlt.Cursor = Cursors.IBeam;
            txtAlt.ForeColor = SystemColors.WindowText;
            txtAlt.Location = new Point(141, 12);
            txtAlt.MaxLength = 0;
            txtAlt.Name = "txtAlt";
            txtAlt.RightToLeft = RightToLeft.No;
            txtAlt.Size = new Size(69, 20);
            txtAlt.TabIndex = 29;
            txtAlt.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdAlt
            // 
            _cmdAlt.BackColor = SystemColors.Control;
            _cmdAlt.Cursor = Cursors.Default;
            _cmdAlt.ForeColor = SystemColors.ControlText;
            _cmdAlt.Location = new Point(153, 54);
            _cmdAlt.Name = "_cmdAlt";
            _cmdAlt.RightToLeft = RightToLeft.No;
            _cmdAlt.Size = new Size(57, 25);
            _cmdAlt.TabIndex = 28;
            _cmdAlt.Text = "OK";
            _cmdAlt.UseVisualStyleBackColor = false;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 15);
            Label1.Name = "Label1";
            Label1.Size = new Size(126, 13);
            Label1.TabIndex = 57;
            Label1.Text = "Apply altitude to all points";
            // 
            // frmAltitudeLine
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 95);
            Controls.Add(Label1);
            Controls.Add(_cmdAlt);
            Controls.Add(txtAlt);
            Controls.Add(_cmdCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAltitudeLine";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Set Line Altitude";
            Load += new EventHandler(FrmAltitudeLine_Load);
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