using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackground));
            this.ckStartFSX = new System.Windows.Forms.CheckBox();
            this.ckCopyBGLs = new System.Windows.Forms.CheckBox();
            this._cmdCancel = new System.Windows.Forms.Button();
            this._cmdCompile = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this._cmdSave = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckStartFSX
            // 
            this.ckStartFSX.AutoSize = true;
            this.ckStartFSX.BackColor = System.Drawing.SystemColors.Control;
            this.ckStartFSX.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckStartFSX.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckStartFSX.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckStartFSX.Location = new System.Drawing.Point(109, 29);
            this.ckStartFSX.Name = "ckStartFSX";
            this.ckStartFSX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ckStartFSX.Size = new System.Drawing.Size(71, 17);
            this.ckStartFSX.TabIndex = 27;
            this.ckStartFSX.Text = "Start FSX";
            this.ckStartFSX.UseVisualStyleBackColor = false;
            // 
            // ckCopyBGLs
            // 
            this.ckCopyBGLs.BackColor = System.Drawing.SystemColors.Control;
            this.ckCopyBGLs.Checked = true;
            this.ckCopyBGLs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckCopyBGLs.Cursor = System.Windows.Forms.Cursors.Default;
            this.ckCopyBGLs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ckCopyBGLs.Location = new System.Drawing.Point(17, 20);
            this.ckCopyBGLs.Name = "ckCopyBGLs";
            this.ckCopyBGLs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ckCopyBGLs.Size = new System.Drawing.Size(97, 34);
            this.ckCopyBGLs.TabIndex = 26;
            this.ckCopyBGLs.Text = "Copy BGL file to BGL folder";
            this.ckCopyBGLs.UseVisualStyleBackColor = false;
            // 
            // _cmdCancel
            // 
            this._cmdCancel.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCancel.Location = new System.Drawing.Point(226, 32);
            this._cmdCancel.Name = "_cmdCancel";
            this._cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCancel.Size = new System.Drawing.Size(57, 25);
            this._cmdCancel.TabIndex = 25;
            this._cmdCancel.Text = "Cancel";
            this._cmdCancel.UseVisualStyleBackColor = false;
            this._cmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
            // 
            // _cmdCompile
            // 
            this._cmdCompile.BackColor = System.Drawing.SystemColors.Control;
            this._cmdCompile.Cursor = System.Windows.Forms.Cursors.Default;
            this._cmdCompile.ForeColor = System.Drawing.SystemColors.ControlText;
            this._cmdCompile.Location = new System.Drawing.Point(226, 112);
            this._cmdCompile.Name = "_cmdCompile";
            this._cmdCompile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this._cmdCompile.Size = new System.Drawing.Size(57, 25);
            this._cmdCompile.TabIndex = 24;
            this._cmdCompile.Text = "Compile";
            this._cmdCompile.UseVisualStyleBackColor = false;
            this._cmdCompile.Click += new System.EventHandler(this.CmdCompile_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ckStartFSX);
            this.GroupBox1.Controls.Add(this.ckCopyBGLs);
            this.GroupBox1.Location = new System.Drawing.Point(14, 70);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(186, 67);
            this.GroupBox1.TabIndex = 28;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Compile Options";
            // 
            // _cmdSave
            // 
            this._cmdSave.Location = new System.Drawing.Point(226, 70);
            this._cmdSave.Name = "_cmdSave";
            this._cmdSave.Size = new System.Drawing.Size(57, 25);
            this._cmdSave.TabIndex = 29;
            this._cmdSave.Text = "Save ...";
            this._cmdSave.UseVisualStyleBackColor = true;
            this._cmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(14, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(195, 48);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "You can save the background image as a Geotiff file or you can compile the backgr" +
    "ound as a photo scenery BGL.";
            // 
            // FrmBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 152);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._cmdCancel);
            this.Controls.Add(this._cmdSave);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this._cmdCompile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBackground";
            this.Text = "SBuilderXX - Background";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

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