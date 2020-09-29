using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLWidth));
            GroupBox1 = new GroupBox();
            Label3 = new Label();
            txtWidth = new TextBox();
            _cmdWidth = new Button();
            _cmdWidth.Click += new EventHandler(CmdWidth_Click);
            GroupBox2 = new GroupBox();
            _cmdReverse = new Button();
            _cmdReverse.Click += new EventHandler(CmdReverse_Click);
            _cmdWidth12 = new Button();
            _cmdWidth12.Click += new EventHandler(CmdWidth12_Click);
            txtWidth1 = new TextBox();
            txtWidth2 = new TextBox();
            Label1 = new Label();
            Label2 = new Label();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdWinding = new Button();
            _cmdWinding.Click += new EventHandler(CmdWinding_Click);
            GroupBox1.SuspendLayout();
            GroupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(txtWidth);
            GroupBox1.Controls.Add(_cmdWidth);
            GroupBox1.Location = new Point(216, 12);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(103, 115);
            GroupBox1.TabIndex = 32;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Constant width";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(20, 22);
            Label3.Name = "Label3";
            Label3.Size = new Size(35, 13);
            Label3.TabIndex = 30;
            Label3.Text = "Width";
            // 
            // txtWidth
            // 
            txtWidth.AcceptsReturn = true;
            txtWidth.BackColor = SystemColors.Window;
            txtWidth.Cursor = Cursors.IBeam;
            txtWidth.ForeColor = SystemColors.WindowText;
            txtWidth.Location = new Point(23, 38);
            txtWidth.MaxLength = 0;
            txtWidth.Name = "txtWidth";
            txtWidth.RightToLeft = RightToLeft.No;
            txtWidth.Size = new Size(57, 20);
            txtWidth.TabIndex = 29;
            txtWidth.TextAlign = HorizontalAlignment.Center;
            // 
            // cmdWidth
            // 
            _cmdWidth.BackColor = SystemColors.Control;
            _cmdWidth.Cursor = Cursors.Default;
            _cmdWidth.ForeColor = SystemColors.ControlText;
            _cmdWidth.Location = new Point(23, 75);
            _cmdWidth.Name = "_cmdWidth";
            _cmdWidth.RightToLeft = RightToLeft.No;
            _cmdWidth.Size = new Size(57, 25);
            _cmdWidth.TabIndex = 28;
            _cmdWidth.Text = "Set";
            _cmdWidth.UseVisualStyleBackColor = false;
            // 
            // GroupBox2
            // 
            GroupBox2.Controls.Add(_cmdReverse);
            GroupBox2.Controls.Add(_cmdWidth12);
            GroupBox2.Controls.Add(txtWidth1);
            GroupBox2.Controls.Add(txtWidth2);
            GroupBox2.Controls.Add(Label1);
            GroupBox2.Controls.Add(Label2);
            GroupBox2.Location = new Point(12, 12);
            GroupBox2.Name = "GroupBox2";
            GroupBox2.Size = new Size(189, 115);
            GroupBox2.TabIndex = 33;
            GroupBox2.TabStop = false;
            GroupBox2.Text = "Progressive width";
            // 
            // cmdReverse
            // 
            _cmdReverse.BackColor = SystemColors.Control;
            _cmdReverse.Cursor = Cursors.Default;
            _cmdReverse.ForeColor = SystemColors.ControlText;
            _cmdReverse.Location = new Point(24, 75);
            _cmdReverse.Name = "_cmdReverse";
            _cmdReverse.RightToLeft = RightToLeft.No;
            _cmdReverse.Size = new Size(57, 25);
            _cmdReverse.TabIndex = 42;
            _cmdReverse.Text = "Change";
            _cmdReverse.UseVisualStyleBackColor = false;
            // 
            // cmdWidth12
            // 
            _cmdWidth12.BackColor = SystemColors.Control;
            _cmdWidth12.Cursor = Cursors.Default;
            _cmdWidth12.ForeColor = SystemColors.ControlText;
            _cmdWidth12.Location = new Point(103, 75);
            _cmdWidth12.Name = "_cmdWidth12";
            _cmdWidth12.RightToLeft = RightToLeft.No;
            _cmdWidth12.Size = new Size(57, 25);
            _cmdWidth12.TabIndex = 39;
            _cmdWidth12.Text = "Set";
            _cmdWidth12.UseVisualStyleBackColor = false;
            // 
            // txtWidth1
            // 
            txtWidth1.AcceptsReturn = true;
            txtWidth1.BackColor = SystemColors.Window;
            txtWidth1.Cursor = Cursors.IBeam;
            txtWidth1.ForeColor = SystemColors.WindowText;
            txtWidth1.Location = new Point(24, 40);
            txtWidth1.MaxLength = 0;
            txtWidth1.Name = "txtWidth1";
            txtWidth1.RightToLeft = RightToLeft.No;
            txtWidth1.Size = new Size(57, 20);
            txtWidth1.TabIndex = 38;
            txtWidth1.TextAlign = HorizontalAlignment.Center;
            // 
            // txtWidth2
            // 
            txtWidth2.AcceptsReturn = true;
            txtWidth2.BackColor = SystemColors.Window;
            txtWidth2.Cursor = Cursors.IBeam;
            txtWidth2.ForeColor = SystemColors.WindowText;
            txtWidth2.Location = new Point(103, 40);
            txtWidth2.MaxLength = 0;
            txtWidth2.Name = "txtWidth2";
            txtWidth2.RightToLeft = RightToLeft.No;
            txtWidth2.Size = new Size(57, 20);
            txtWidth2.TabIndex = 37;
            txtWidth2.TextAlign = HorizontalAlignment.Center;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BackColor = SystemColors.Control;
            Label1.Cursor = Cursors.Default;
            Label1.ForeColor = SystemColors.ControlText;
            Label1.Location = new Point(21, 22);
            Label1.Name = "Label1";
            Label1.RightToLeft = RightToLeft.No;
            Label1.Size = new Size(53, 13);
            Label1.TabIndex = 41;
            Label1.Text = "First Point";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.BackColor = SystemColors.Control;
            Label2.Cursor = Cursors.Default;
            Label2.ForeColor = SystemColors.ControlText;
            Label2.Location = new Point(100, 22);
            Label2.Name = "Label2";
            Label2.RightToLeft = RightToLeft.No;
            Label2.Size = new Size(54, 13);
            Label2.TabIndex = 40;
            Label2.Text = "Last Point";
            // 
            // cmdCancel
            // 
            _cmdCancel.Location = new Point(335, 87);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.Size = new Size(63, 25);
            _cmdCancel.TabIndex = 35;
            _cmdCancel.Text = "Close";
            _cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdWinding
            // 
            _cmdWinding.Location = new Point(335, 47);
            _cmdWinding.Name = "_cmdWinding";
            _cmdWinding.Size = new Size(63, 25);
            _cmdWinding.TabIndex = 36;
            _cmdWinding.Text = "Reverse";
            _cmdWinding.UseVisualStyleBackColor = true;
            // 
            // frmLWidth
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 143);
            Controls.Add(_cmdWinding);
            Controls.Add(_cmdCancel);
            Controls.Add(GroupBox2);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLWidth";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "SBuilderX - Set Line Width";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            GroupBox2.ResumeLayout(false);
            GroupBox2.PerformLayout();
            Load += new EventHandler(FrmLWidth_Load);
            ResumeLayout(false);
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