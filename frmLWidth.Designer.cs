using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmLWidth : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLWidth));
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this._cmdWidth = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this._cmdReverse = new System.Windows.Forms.Button();
            this._cmdWidth12 = new System.Windows.Forms.Button();
            this.txtWidth1 = new System.Windows.Forms.TextBox();
            this.txtWidth2 = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdWinding = new System.Windows.Forms.Button();
            this.GroupBox1.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtWidth);
            this.GroupBox1.Controls.Add(this._cmdWidth);
            this.GroupBox1.Location = new System.Drawing.Point(216, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(103, 115);
            this.GroupBox1.TabIndex = 32;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Constant width";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(20, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(35, 13);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.AcceptsReturn = true;
            this.txtWidth.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWidth.Location = new System.Drawing.Point(23, 38);
            this.txtWidth.MaxLength = 0;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWidth.Size = new System.Drawing.Size(57, 20);
            this.txtWidth.TabIndex = 29;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // _cmdWidth
            // 
            this._cmdWidth.BackColor = System.Drawing.SystemColors.Control;
            this._cmdWidth.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdWidth.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdWidth.Location = new System.Drawing.Point(23, 75);
            this._cmdWidth.Name = "_cmdWidth";
            this._cmdWidth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdWidth.Size = new System.Drawing.Size(57, 25);
            this._cmdWidth.TabIndex = 28;
            this._cmdWidth.Text = "Set";
            this._cmdWidth.UseVisualStyleBackColor = false;
            this._cmdWidth.Click += new System.EventHandler(this.CmdWidth_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this._cmdReverse);
            this.GroupBox2.Controls.Add(this._cmdWidth12);
            this.GroupBox2.Controls.Add(this.txtWidth1);
            this.GroupBox2.Controls.Add(this.txtWidth2);
            this.GroupBox2.Controls.Add(this.Label1);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(12, 12);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(189, 115);
            this.GroupBox2.TabIndex = 33;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Progressive width";
            // 
            // _cmdReverse
            // 
            this._cmdReverse.BackColor = System.Drawing.SystemColors.Control;
            this._cmdReverse.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdReverse.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdReverse.Location = new System.Drawing.Point(24, 75);
            this._cmdReverse.Name = "_cmdReverse";
            this._cmdReverse.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdReverse.Size = new System.Drawing.Size(57, 25);
            this._cmdReverse.TabIndex = 42;
            this._cmdReverse.Text = "Change";
            this._cmdReverse.UseVisualStyleBackColor = false;
            this._cmdReverse.Click += new System.EventHandler(this.CmdReverse_Click);
            // 
            // _cmdWidth12
            // 
            this._cmdWidth12.BackColor = System.Drawing.SystemColors.Control;
            this._cmdWidth12.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdWidth12.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdWidth12.Location = new System.Drawing.Point(103, 75);
            this._cmdWidth12.Name = "_cmdWidth12";
            this._cmdWidth12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdWidth12.Size = new System.Drawing.Size(57, 25);
            this._cmdWidth12.TabIndex = 39;
            this._cmdWidth12.Text = "Set";
            this._cmdWidth12.UseVisualStyleBackColor = false;
            this._cmdWidth12.Click += new System.EventHandler(this.CmdWidth12_Click);
            // 
            // txtWidth1
            // 
            this.txtWidth1.AcceptsReturn = true;
            this.txtWidth1.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWidth1.Location = new System.Drawing.Point(24, 40);
            this.txtWidth1.MaxLength = 0;
            this.txtWidth1.Name = "txtWidth1";
            this.txtWidth1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWidth1.Size = new System.Drawing.Size(57, 20);
            this.txtWidth1.TabIndex = 38;
            this.txtWidth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWidth2
            // 
            this.txtWidth2.AcceptsReturn = true;
            this.txtWidth2.BackColor = System.Drawing.SystemColors.Window;
            this.txtWidth2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWidth2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtWidth2.Location = new System.Drawing.Point(103, 40);
            this.txtWidth2.MaxLength = 0;
            this.txtWidth2.Name = "txtWidth2";
            this.txtWidth2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWidth2.Size = new System.Drawing.Size(57, 20);
            this.txtWidth2.TabIndex = 37;
            this.txtWidth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.Control;
            this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label1.Location = new System.Drawing.Point(21, 22);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label1.Size = new System.Drawing.Size(53, 13);
            this.Label1.TabIndex = 41;
            this.Label1.Text = "First Point";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(100, 22);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(54, 13);
            this.Label2.TabIndex = 40;
            this.Label2.Text = "Last Point";
            // 
            // _cmdCancel
            // 
            this._cmdCancel.Location = new System.Drawing.Point(335, 87);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.Size = new System.Drawing.Size(63, 25);
            this._cmdCancel.TabIndex = 35;
            this._cmdCancel.Text = "Close";
            this._cmdCancel.UseVisualStyleBackColor = true;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdWinding
            // 
            this._cmdWinding.Location = new System.Drawing.Point(335, 47);
            this._cmdWinding.Name = "_cmdWinding";
            this._cmdWinding.Size = new System.Drawing.Size(63, 25);
            this._cmdWinding.TabIndex = 36;
            this._cmdWinding.Text = "Reverse";
            this._cmdWinding.UseVisualStyleBackColor = true;
            this._cmdWinding.Click += new System.EventHandler(this.CmdWinding_Click);
            // 
            // FrmLWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 143);
            this.Controls.Add(this._cmdWinding);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLWidth";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SBuilderXX - Set Line Width";
            this.Load += new System.EventHandler(this.FrmLWidth_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        internal GroupBox GroupBox1;
        public TextBox txtWidth;
        internal GroupBox GroupBox2;
        private Button _cmdReverse;

        public Button cmdReverse
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdReverse;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdReverse != null)
                {
                    _cmdReverse.Click -= CmdReverse_Click;
                }

                _cmdReverse = value;
                if (_cmdReverse != null)
                {
                    _cmdReverse.Click += CmdReverse_Click;
                }
            }
        }

        public TextBox txtWidth1;
        public TextBox txtWidth2;
        public Label Label1;
        public Label Label2;
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

        private Button _cmdWidth;

        public Button cmdWidth
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWidth;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWidth != null)
                {
                    _cmdWidth.Click -= CmdWidth_Click;
                }

                _cmdWidth = value;
                if (_cmdWidth != null)
                {
                    _cmdWidth.Click += CmdWidth_Click;
                }
            }
        }

        private Button _cmdWidth12;

        public Button cmdWidth12
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWidth12;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWidth12 != null)
                {
                    _cmdWidth12.Click -= CmdWidth12_Click;
                }

                _cmdWidth12 = value;
                if (_cmdWidth12 != null)
                {
                    _cmdWidth12.Click += CmdWidth12_Click;
                }
            }
        }

        internal Label Label3;
        private Button _cmdWinding;

        internal Button cmdWinding
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdWinding;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdWinding != null)
                {
                    _cmdWinding.Click -= CmdWinding_Click;
                }

                _cmdWinding = value;
                if (_cmdWinding != null)
                {
                    _cmdWinding.Click += CmdWinding_Click;
                }
            }
        }
    }
}