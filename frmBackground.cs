using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
                Interaction.MsgBox("Zoom is too low for photo scenery!", MsgBoxStyle.Exclamation);
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