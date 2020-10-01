using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace SBuilderXX
{
    [Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
    public partial class frmSCREEN : Form
    {

        // Form overrides dispose to clean up the component list.
        [DebuggerNonUserCode()]
        protected override void Dispose(bool disposing)
        {
            if (disposing && components is object)
            {
                components.Dispose();
            }

            Screen.Dispose();
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
            SuspendLayout();
            // 
            // frmSCREEN
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(388, 232);
            ControlBox = false;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSCREEN";
            Text = "Form1";
            KeyDown += new KeyEventHandler(FrmSCREEN_KeyDown);
            Load += new EventHandler(FrmSCREEN_Load);
            MouseDown += new MouseEventHandler(FrmSCREEN_MouseDown);
            MouseMove += new MouseEventHandler(FrmSCREEN_MouseMove);
            MouseUp += new MouseEventHandler(FrmSCREEN_MouseUp);
            ResumeLayout(false);
        }
    }
}