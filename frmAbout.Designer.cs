using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmAbout : Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            this.LabelCopyright = new System.Windows.Forms.Label();
            this._cmdOK = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelCopyright
            // 
            this.LabelCopyright.Location = new System.Drawing.Point(12, 150);
            this.LabelCopyright.Name = "LabelCopyright";
            this.LabelCopyright.Size = new System.Drawing.Size(284, 41);
            this.LabelCopyright.TabIndex = 4;
            this.LabelCopyright.Text = "Copyright © mrprint@github.com 2020.\nCopyright © Luis Sб 2007-2017.  The collabor" +
    "ation of Luis Fйliz-Tirado and Richard Ludowise is acknowledge.";
            // 
            // _cmdOK
            // 
            this._cmdOK.Location = new System.Drawing.Point(428, 164);
            this._cmdOK.Name = "_cmdOK";
            this._cmdOK.Size = new System.Drawing.Size(67, 27);
            this._cmdOK.TabIndex = 6;
            this._cmdOK.Text = "OK";
            this._cmdOK.UseVisualStyleBackColor = true;
            this._cmdOK.Click += new System.EventHandler(this.CmdOK_Click);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(322, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(173, 128);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "SBuilderXX is a scenery design tool that you can use free of charge to produce an" +
    "y scenery project.";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::SBuilderXX.My.Resources.Resources.mylogo;
            this.LogoPictureBox.Location = new System.Drawing.Point(12, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(284, 135);
            this.LogoPictureBox.TabIndex = 1;
            this.LogoPictureBox.TabStop = false;
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 202);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this._cmdOK);
            this.Controls.Add(this.LabelCopyright);
            this.Controls.Add(this.LogoPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAbout";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About SBuilderXX";
            this.TransparencyKey = System.Drawing.Color.Crimson;
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        internal Label LabelCopyright;
        private Button _cmdOK;

        internal Button cmdOK
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _cmdOK;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_cmdOK != null)
                {
                    _cmdOK.Click -= CmdOK_Click;
                }

                _cmdOK = value;
                if (_cmdOK != null)
                {
                    _cmdOK.Click += CmdOK_Click;
                }
            }
        }

        internal PictureBox LogoPictureBox;
        internal Label Label1;

    }
}