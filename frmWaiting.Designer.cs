using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderXX
{
    [DesignerGenerated()]
    public partial class frmWaiting : Form
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
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWaiting));
            bar = new ProgressBar();
            Label1 = new Label();
            labelFile = new Label();
            PictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bar
            // 
            bar.Location = new Point(12, 121);
            bar.Name = "bar";
            bar.Size = new Size(256, 12);
            bar.TabIndex = 0;
            // 
            // Label1
            // 
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(256, 44);
            Label1.TabIndex = 1;
            Label1.Text = "You must wait several minutes until SBuilderXX copies some bitmaps! The next time " + "SBuilderXX runs in this computer, it will start faster!";
            // 
            // labelFile
            // 
            labelFile.AutoSize = true;
            labelFile.Location = new Point(12, 105);
            labelFile.Name = "labelFile";
            labelFile.Size = new Size(39, 13);
            labelFile.TabIndex = 2;
            labelFile.Text = "Label2";
            // 
            // PictureBox1
            // 
            PictureBox1.Image = (Image)resources.GetObject("PictureBox1.Image");
            PictureBox1.Location = new Point(45, 66);
            PictureBox1.Name = "PictureBox1";
            PictureBox1.Size = new Size(181, 27);
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureBox1.TabIndex = 3;
            PictureBox1.TabStop = false;
            // 
            // frmWaiting
            // 
            AutoScaleDimensions = new SizeF(6.0f, 13.0f);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(280, 145);
            ControlBox = false;
            Controls.Add(PictureBox1);
            Controls.Add(labelFile);
            Controls.Add(Label1);
            Controls.Add(bar);
            Name = "frmWaiting";
            Text = "SBuilderXX - Running for the 1st time!";
            ((System.ComponentModel.ISupportInitialize)PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        internal ProgressBar bar;
        internal Label Label1;
        internal Label labelFile;
        internal PictureBox PictureBox1;
    }
}