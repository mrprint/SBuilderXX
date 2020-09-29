using System;
using System.Windows.Forms;

namespace SBuilderX
{
    public partial class FrmObjectFolders
    {
        public FrmObjectFolders()
        {
            InitializeComponent();
            _cmdAPI.Name = "cmdAPI";
            _cmdRyw12.Name = "cmdRyw12";
            _cmdASD.Name = "cmdASD";
            _cmdLibObjects.Name = "cmdLibObjects";
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
        }

        private string IniAPIPath;
        private string IniRwy12Path;
        private string IniASDPath;
        private string IniLibObjectsPath;

        private void FrmObjectFolders_Load(object sender, EventArgs e)
        {
            txtRwy12Folder.Text = moduleOBJECTS.Rwy12Path;
            txtASDFolder.Text = moduleMACROS.MacroASDPath;
            txtAPIFolder.Text = moduleMACROS.MacroAPIPath;
            txtLibObjectsFolder.Text = moduleOBJECTS.LibObjectsPath;
            IniRwy12Path = moduleOBJECTS.Rwy12Path;
            IniASDPath = moduleMACROS.MacroASDPath;
            IniAPIPath = moduleMACROS.MacroAPIPath;
            IniLibObjectsPath = moduleOBJECTS.LibObjectsPath;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            moduleMACROS.MacroASDPath = txtASDFolder.Text;
            moduleMACROS.MacroAPIPath = txtAPIFolder.Text;
            moduleOBJECTS.Rwy12Path = txtRwy12Folder.Text;
            moduleOBJECTS.LibObjectsPath = txtLibObjectsFolder.Text;

            // WriteObjectsSettings()

            if ((IniLibObjectsPath ?? "") != (moduleOBJECTS.LibObjectsPath ?? ""))
                moduleOBJECTS.SetLibObjects();
            if ((IniRwy12Path ?? "") != (moduleOBJECTS.Rwy12Path ?? ""))
                moduleOBJECTS.SetRwy12Objects();
            if ((IniASDPath ?? "") != (moduleMACROS.MacroASDPath ?? "") | (IniAPIPath ?? "") != (moduleMACROS.MacroAPIPath ?? ""))
                moduleMACROS.SetMacroObjects();
            moduleFILE_IO.WriteSettings();
            Dispose();
        }

        private void CmdLibObjects_Click(object sender, EventArgs e)
        {
            string A = "Choose the Folder that contains Library Objects.";
            My.MyProject.Forms.FrmStart.FolderBrowserDialog1.Description = A;
            if (My.MyProject.Forms.FrmStart.FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLibObjectsFolder.Text = My.MyProject.Forms.FrmStart.FolderBrowserDialog1.SelectedPath;
            }
        }

        private void CmdRyw12_Click(object sender, EventArgs e)
        {
            string A = "Choose the Folder that contains Rwy12 Objects.";
            My.MyProject.Forms.FrmStart.FolderBrowserDialog1.Description = A;
            if (My.MyProject.Forms.FrmStart.FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtRwy12Folder.Text = My.MyProject.Forms.FrmStart.FolderBrowserDialog1.SelectedPath;
            }
        }

        private void CmdAPI_Click(object sender, EventArgs e)
        {
            string A = "Choose the Folder that contains API macros.";
            My.MyProject.Forms.FrmStart.FolderBrowserDialog1.Description = A;
            if (My.MyProject.Forms.FrmStart.FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtAPIFolder.Text = My.MyProject.Forms.FrmStart.FolderBrowserDialog1.SelectedPath;
            }
        }

        private void CmdASD_Click(object sender, EventArgs e)
        {
            string A = "Choose the Folder that contains ASD macros.";
            My.MyProject.Forms.FrmStart.FolderBrowserDialog1.Description = A;
            if (My.MyProject.Forms.FrmStart.FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtASDFolder.Text = My.MyProject.Forms.FrmStart.FolderBrowserDialog1.SelectedPath;
            }
        }
    }
}