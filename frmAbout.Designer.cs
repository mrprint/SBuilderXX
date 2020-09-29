using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    [DesignerGenerated()]
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            LabelCopyright = new Label();
            _cmdOK = new Button();
            _cmdOK.Click += new EventHandler(CmdOK_Click);
            Label1 = new Label();
            _Button1 = new Button();
            _Button1.Click += new EventHandler(Button1_Click);
            LogoPictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // LabelCopyright
            // 
            LabelCopyright.Location = new Point(12, 150);
            LabelCopyright.Name = "LabelCopyright";
            LabelCopyright.Size = new Size(284, 32);
            LabelCopyright.TabIndex = 4;
            LabelCopyright.Text = "Copyright © Luis Sб 2007-2017.  The collaboration of Luis Fйliz-Tirado and Richar" + "d Ludowise is acknowledge.";
            LabelCopyright.TextAlign = ContentAlignment.TopCenter;
            // 
            // cmdOK
            // 
            _cmdOK.Location = new Point(448, 143);
            _cmdOK.Name = "_cmdOK";
            _cmdOK.Size = new Size(67, 27);
            _cmdOK.TabIndex = 6;
            _cmdOK.Text = "OK";
            _cmdOK.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            Label1.Location = new Point(322, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(193, 140);
            Label1.TabIndex = 7;
            Label1.Text = resources.GetString("Label1.Text");
            Label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Button1
            // 
            _Button1.Location = new Point(339, 143);
            _Button1.Name = "_Button1";
            _Button1.Size = new Size(67, 27);
            _Button1.TabIndex = 8;
            _Button1.Text = "Donate";
            _Button1.UseVisualStyleBackColor = true;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = My.Resources.Resources.newsbuilderx315;
            LogoPictureBox.Location = new Point(12, 12);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(284, 135);
            LogoPictureBox.TabIndex = 1;
            LogoPictureBox.TabStop = false;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(535, 187);
            Controls.Add(_Button1);
            Controls.Add(Label1);
            Controls.Add(_cmdOK);
            Controls.Add(LabelCopyright);
            Controls.Add(LogoPictureBox);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "About SBuilderX";
            TransparencyKey = Color.Crimson;
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            ResumeLayout(false);
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
        private Button _Button1;

        internal Button Button1
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get
            {
                return _Button1;
            }

            [MethodImpl(MethodImplOptions.Synchronized)]
            set
            {
                if (_Button1 != null)
                {
                    _Button1.Click -= Button1_Click;
                }

                _Button1 = value;
                if (_Button1 != null)
                {
                    _Button1.Click += Button1_Click;
                }
            }
        }
    }
}