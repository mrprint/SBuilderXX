using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SBuilderX
{
    public partial class FrmBackground
    {
        public FrmBackground()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdCompile.Name = "cmdCompile";
            _cmdSave.Name = "cmdSave";
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void CmdCompile_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            if (moduleMAIN.Zoom < 5)
            {
                MessageBox.Show("Zoom is too low for photo scenery!", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Dispose();
                return;  // added this. It is right? in October 2017
            }

            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            moduleTILES.MakeBglPhotoBackground(ckCopyBGLs.Checked);

            // If ckStartFSX.CheckState = 1 Then Shell(FSPath & "fsx.exe", 1)  'it looks Win10 does not like it
            // If ckStartFSX.CheckState = 1 Then Process.Start(FSPath & "fsx.exe")
            if ((int)ckStartFSX.CheckState == 1)
                Process.Start(moduleMAIN.FSPath + moduleMAIN.SimExe);
            My.MyProject.Forms.FrmStart.SetMouseIcon();
            Dispose();
        }
    }
}