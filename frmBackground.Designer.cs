using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
    public partial class FrmBackground : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackground));
            ckStartFSX = new CheckBox();
            ckCopyBGLs = new CheckBox();
            _cmdCancel = new Button();
            _cmdCancel.Click += new EventHandler(CmdCancel_Click);
            _cmdCompile = new Button();
            _cmdCompile.Click += new EventHandler(CmdCompile_Click);
            GroupBox1 = new GroupBox();
            _cmdSave = new Button();
            _cmdSave.Click += new EventHandler(CmdSave_Click);
            Label1 = new Label();
            GroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ckStartFSX
            // 
            ckStartFSX.AutoSize = true;
            ckStartFSX.BackColor = SystemColors.Control;
            ckStartFSX.CheckAlign = ContentAlignment.MiddleRight;
            ckStartFSX.Cursor = Cursors.Default;
            ckStartFSX.ForeColor = SystemColors.ControlText;
            ckStartFSX.Location = new Point(109, 29);
            ckStartFSX.Name = "ckStartFSX";
            ckStartFSX.RightToLeft = RightToLeft.Yes;
            ckStartFSX.Size = new Size(71, 17);
            ckStartFSX.TabIndex = 27;
            ckStartFSX.Text = "Start FSX";
            ckStartFSX.UseVisualStyleBackColor = false;
            // 
            // ckCopyBGLs
            // 
            ckCopyBGLs.BackColor = SystemColors.Control;
            ckCopyBGLs.Checked = true;
            ckCopyBGLs.CheckState = CheckState.Checked;
            ckCopyBGLs.Cursor = Cursors.Default;
            ckCopyBGLs.ForeColor = SystemColors.ControlText;
            ckCopyBGLs.Location = new Point(17, 20);
            ckCopyBGLs.Name = "ckCopyBGLs";
            ckCopyBGLs.RightToLeft = RightToLeft.No;
            ckCopyBGLs.Size = new Size(97, 34);
            ckCopyBGLs.TabIndex = 26;
            ckCopyBGLs.Text = "Copy BGL file to BGL folder";
            ckCopyBGLs.UseVisualStyleBackColor = false;
            // 
            // cmdCancel
            // 
            _cmdCancel.BackColor = SystemColors.Control;
            _cmdCancel.Cursor = Cursors.Default;
            _cmdCancel.ForeColor = SystemColors.ControlText;
            _cmdCancel.Location = new Point(226, 32);
            _cmdCancel.Name = "_cmdCancel";
            _cmdCancel.RightToLeft = RightToLeft.No;
            _cmdCancel.Size = new Size(57, 25);
            _cmdCancel.TabIndex = 25;
            _cmdCancel.Text = "Cancel";
            _cmdCancel.UseVisualStyleBackColor = false;
            // 
            // cmdCompile
            // 
            _cmdCompile.BackColor = SystemColors.Control;
            _cmdCompile.Cursor = Cursors.Default;
            _cmdCompile.ForeColor = SystemColors.ControlText;
            _cmdCompile.Location = new Point(226, 112);
            _cmdCompile.Name = "_cmdCompile";
            _cmdCompile.RightToLeft = RightToLeft.No;
            _cmdCompile.Size = new Size(57, 25);
            _cmdCompile.TabIndex = 24;
            _cmdCompile.Text = "Compile";
            _cmdCompile.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            GroupBox1.Controls.Add(ckStartFSX);
            GroupBox1.Controls.Add(ckCopyBGLs);
            GroupBox1.Location = new Point(14, 70);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(186, 67);
            GroupBox1.TabIndex = 28;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Compile Options";
            // 
            // cmdSave
            // 
            _cmdSave.Location = new Point(226, 70);
            _cmdSave.Name = "_cmdSave";
            _cmdSave.Size = new Size(57, 25);
            _cmdSave.TabIndex = 29;
            _cmdSave.Text = "Save ...";
            _cmdSave.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.Location = new Point(14, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(195, 48);
            Label1.TabIndex = 30;
            Label1.Text = "You can save the background image as a Geotiff file or you can compile the backgr" + "ound as a photo scenery BGL.";
            // 
            // frmBackground
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 152);
            Controls.Add(Label1);
            Controls.Add(_cmdCancel);
            Controls.Add(_cmdSave);
            Controls.Add(GroupBox1);
            Controls.Add(_cmdCompile);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmBackground";
            Text = "SBuilderX - Background";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        public CheckBox ckStartFSX;
        public CheckBox ckCopyBGLs;
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

        private Button _cmdCompile;

        public Button cmdCompile
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdCompile;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdCompile != null)
                {
                    _cmdCompile.Click -= CmdCompile_Click;
                }

                _cmdCompile = value;
                if (_cmdCompile != null)
                {
                    _cmdCompile.Click += CmdCompile_Click;
                }
            }
        }

        internal GroupBox GroupBox1;
        private Button _cmdSave;

        internal Button cmdSave
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdSave;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdSave != null)
                {
                    _cmdSave.Click -= CmdSave_Click;
                }

                _cmdSave = value;
                if (_cmdSave != null)
                {
                    _cmdSave.Click += CmdSave_Click;
                }
            }
        }

        internal Label Label1;
    }
}