using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SBuilderX
{
    public partial class FrmFSXSettings
    {
        public FrmFSXSettings()
        {
            InitializeComponent();
            _cmdFSX.Name = "cmdFSX";
            _cmdTerrain.Name = "cmdTerrain";
            _cmdBGLComp.Name = "cmdBGLComp";
            _cmdOK.Name = "cmdOK";
            _cmdPlugins.Name = "cmdPlugins";
        }

        private string SDKBglCompX;

        private void FrmFSXSettings_Load(object sender, EventArgs e)
        {
            string FSPathX = "";
            string SDKTerrainX = "";
            string SDKBglCompX = "";
            string SDKPluginsX = "";
            if (!string.IsNullOrEmpty(moduleMAIN.FSPath))
                FSPathX = moduleMAIN.FSPath.Substring(0, moduleMAIN.FSPath.Length - 1);
            if (!string.IsNullOrEmpty(moduleMAIN.SDKTerrain))
                SDKTerrainX = moduleMAIN.SDKTerrain.Substring(0, moduleMAIN.SDKTerrain.Length - 1);
            if (!string.IsNullOrEmpty(moduleMAIN.SDKBglComp))
                SDKBglCompX = moduleMAIN.SDKBglComp.Substring(0, moduleMAIN.SDKBglComp.Length - 1);
            if (!string.IsNullOrEmpty(moduleMAIN.SDKPlugins))
                SDKPluginsX = moduleMAIN.SDKPlugins.Substring(0, moduleMAIN.SDKPlugins.Length - 1);
            string ToolsFolder = moduleMAIN.AppPath + @"\Tools\";
            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "shp2vec.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "resample.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "imagetool.exe"))

            {
                SDKTerrainX = moduleMAIN.AppPath + @"\Tools";
            }

            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.xsd"))
            {
                SDKBglCompX = moduleMAIN.AppPath + @"\Tools";
            }

            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "XToMdl.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_CrashTree.dll") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_Lookup_Keyword.dll"))

            {
                SDKPluginsX = moduleMAIN.AppPath + @"\Tools";
            }

            txtNameOfSim.Text = moduleMAIN.NameOfSim;
            txtFSPath.Text = FSPathX;
            txtTerrain.Text = SDKTerrainX;
            txtBGLComp.Text = SDKBglCompX;
            txtPlugins.Text = SDKPluginsX;
            if (moduleMAIN.IsFSX == false & moduleMAIN.IgnoreFSX == false)
                txtFSPath.ForeColor = Color.Red;
            if (moduleMAIN.IsFSXBGLComp == false)
                txtBGLComp.ForeColor = Color.Red;
            if (moduleMAIN.IsFSXTerrain == false)
                txtTerrain.ForeColor = Color.Red;
            if (moduleMAIN.IsFSXPlugins == false)
                txtPlugins.ForeColor = Color.Red;
        }

        private void CmdFSX_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog1.ShowNewFolderButton = false;
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            FolderBrowserDialog1.SelectedPath = txtFSPath.Text;
            FolderBrowserDialog1.Description = "Set the Full Path to Flight Simulator";
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFSPath.Text = FolderBrowserDialog1.SelectedPath;
                if (My.MyProject.Computer.FileSystem.FileExists(txtFSPath.Text + @"\terrain.cfg"))
                {
                    txtFSPath.ForeColor = Color.Black;
                }
                else
                {
                    txtFSPath.ForeColor = Color.Red;
                }
            }
        }

        private void CmdTerrain_Click(object sender, EventArgs e)
        {
            string ToolsFolder = moduleMAIN.AppPath + @"\Tools\";
            string TerrainFolder;
            string B, C;
            FolderBrowserDialog1.ShowNewFolderButton = false;
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            FolderBrowserDialog1.SelectedPath = txtTerrain.Text;
            FolderBrowserDialog1.Description = "Point to the location of Shp2Vec.exe, Resample.exe and ImageTool.exe";
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                moduleMAIN.IsFSXTerrain = false;
                TerrainFolder = FolderBrowserDialog1.SelectedPath + @"\";
                if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "shp2vec.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "resample.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "imagetool.exe"))

                {
                    moduleMAIN.IsFSXTerrain = true;
                }
                else if (My.MyProject.Computer.FileSystem.FileExists(TerrainFolder + "shp2vec.exe") & My.MyProject.Computer.FileSystem.FileExists(TerrainFolder + "resample.exe") & My.MyProject.Computer.FileSystem.FileExists(TerrainFolder + "imagetool.exe"))

                {
                    B = TerrainFolder + "shp2vec.exe";
                    C = ToolsFolder + "shp2vec.exe";
                    File.Copy(B, C, true);
                    B = TerrainFolder + "resample.exe";
                    C = ToolsFolder + "resample.exe";
                    File.Copy(B, C, true);
                    B = TerrainFolder + "imagetool.exe";
                    C = ToolsFolder + "imagetool.exe";
                    File.Copy(B, C, true);
                    moduleMAIN.IsFSXTerrain = true;
                }

                if (moduleMAIN.IsFSXTerrain)
                {
                    txtTerrain.ForeColor = Color.Black;
                    txtTerrain.Text = moduleMAIN.AppPath + @"\Tools";
                }
                else
                {
                    txtTerrain.ForeColor = Color.Red;
                }
            }
        }

        private void CmdBGLComp_Click(object sender, EventArgs e)
        {
            string ToolsFolder = moduleMAIN.AppPath + @"\Tools\";
            string BGLCompFolder;
            string B, C;
            FolderBrowserDialog1.ShowNewFolderButton = false;
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            FolderBrowserDialog1.SelectedPath = txtBGLComp.Text;
            FolderBrowserDialog1.Description = "Point to the location of BglComp.exe and BglComp.xsd";
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                moduleMAIN.IsFSXBGLComp = false;
                BGLCompFolder = FolderBrowserDialog1.SelectedPath + @"\";
                if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.xsd"))
                {
                    moduleMAIN.IsFSXBGLComp = true;
                }
                else if (My.MyProject.Computer.FileSystem.FileExists(BGLCompFolder + "bglcomp.exe") & My.MyProject.Computer.FileSystem.FileExists(BGLCompFolder + "bglcomp.xsd"))
                {
                    B = BGLCompFolder + "bglcomp.exe";
                    C = ToolsFolder + "bglcomp.exe";
                    File.Copy(B, C, true);
                    B = BGLCompFolder + "bglcomp.xsd";
                    C = ToolsFolder + "bglcomp.xsd";
                    File.Copy(B, C, true);
                    moduleMAIN.IsFSXBGLComp = true;
                }

                if (moduleMAIN.IsFSXBGLComp)
                {
                    txtBGLComp.ForeColor = Color.Black;
                    txtBGLComp.Text = moduleMAIN.AppPath + @"\Tools";
                }
                else
                {
                    txtBGLComp.ForeColor = Color.Red;
                }
            }
        }

        private void CmdPlugins_Click(object sender, EventArgs e)
        {
            string ToolsFolder = moduleMAIN.AppPath + @"\Tools\";
            string PluginsFolder;
            string B, C;
            FolderBrowserDialog1.ShowNewFolderButton = false;
            FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            FolderBrowserDialog1.SelectedPath = txtPlugins.Text;
            FolderBrowserDialog1.Description = "Point to the location of XToMdl.exe";
            if (FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                moduleMAIN.IsFSXPlugins = false;
                PluginsFolder = FolderBrowserDialog1.SelectedPath + @"\";
                if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "XToMdl.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_CrashTree.dll") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_Lookup_Keyword.dll"))

                {
                    moduleMAIN.IsFSXPlugins = true;
                }
                else if (My.MyProject.Computer.FileSystem.FileExists(PluginsFolder + "XToMdl.exe") & My.MyProject.Computer.FileSystem.FileExists(PluginsFolder + "Managed_CrashTree.dll") & My.MyProject.Computer.FileSystem.FileExists(PluginsFolder + "Managed_Lookup_Keyword.dll"))

                {
                    B = PluginsFolder + "XToMdl.exe";
                    C = ToolsFolder + "XToMdl.exe";
                    File.Copy(B, C, true);
                    B = PluginsFolder + "Managed_CrashTree.dll";
                    C = ToolsFolder + "Managed_CrashTree.dll";
                    File.Copy(B, C, true);
                    B = PluginsFolder + "Managed_Lookup_Keyword.dll";
                    C = ToolsFolder + "Managed_Lookup_Keyword.dll";
                    File.Copy(B, C, true);
                    moduleMAIN.IsFSXPlugins = true;
                }

                if (moduleMAIN.IsFSXPlugins)
                {
                    txtPlugins.ForeColor = Color.Black;
                    txtPlugins.Text = moduleMAIN.AppPath + @"\Tools";
                }
                else
                {
                    txtPlugins.ForeColor = Color.Red;
                }
            }
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            string B, C;
            moduleMAIN.NameOfSim = txtNameOfSim.Text.Trim();
            moduleMAIN.SimPath = txtFSPath.Text.Trim();

            // FSX
            moduleMAIN.FSPath = txtFSPath.Text + @"\";
            moduleMAIN.IsFSX = false;
            moduleMAIN.FSTextureFolder = moduleMAIN.FSPath + @"Scenery\World\Texture\";
            if (My.MyProject.Computer.FileSystem.FileExists(moduleMAIN.FSPath + "terrain.cfg"))
                moduleMAIN.IsFSX = true;

            // Terrain
            string TerrainFolder = txtTerrain.Text + @"\";
            moduleMAIN.IsFSXTerrain = false;
            string ToolsFolder = moduleMAIN.AppPath + @"\Tools\";
            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "shp2vec.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "resample.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "imagetool.exe"))

            {
                moduleMAIN.IsFSXTerrain = true;
            }
            else if (My.MyProject.Computer.FileSystem.FileExists(TerrainFolder + "shp2vec.exe") & My.MyProject.Computer.FileSystem.FileExists(TerrainFolder + "resample.exe") & My.MyProject.Computer.FileSystem.FileExists(TerrainFolder + "imagetool.exe"))

            {
                B = TerrainFolder + "shp2vec.exe";
                C = ToolsFolder + "shp2vec.exe";
                File.Copy(B, C, true);
                B = TerrainFolder + "resample.exe";
                C = ToolsFolder + "resample.exe";
                File.Copy(B, C, true);
                B = TerrainFolder + "imagetool.exe";
                C = ToolsFolder + "imagetool.exe";
                File.Copy(B, C, true);
                moduleMAIN.IsFSXTerrain = true;
            }

            // Plugins
            string PluginsFolder = txtPlugins.Text + @"\";
            moduleMAIN.IsFSXPlugins = false;
            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "XToMdl.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_CrashTree.dll") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "Managed_Lookup_Keyword.dll"))

            {
                moduleMAIN.IsFSXPlugins = true;
            }
            else if (My.MyProject.Computer.FileSystem.FileExists(PluginsFolder + "XToMdl.exe") & My.MyProject.Computer.FileSystem.FileExists(PluginsFolder + "Managed_CrashTree.dll") & My.MyProject.Computer.FileSystem.FileExists(PluginsFolder + "Managed_Lookup_Keyword.dll"))

            {
                B = PluginsFolder + "XToMdl.exe";
                C = ToolsFolder + "XToMdl.exe";
                File.Copy(B, C, true);
                B = PluginsFolder + "Managed_CrashTree.dll";
                C = ToolsFolder + "Managed_CrashTree.dll";
                File.Copy(B, C, true);
                B = PluginsFolder + "Managed_Lookup_Keyword.dll";
                C = ToolsFolder + "Managed_Lookup_Keyword.dll";
                File.Copy(B, C, true);
                moduleMAIN.IsFSXPlugins = true;
            }

            string BGLCompFolder = txtBGLComp.Text + @"\";
            moduleMAIN.IsFSXBGLComp = false;
            if (My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.exe") & My.MyProject.Computer.FileSystem.FileExists(ToolsFolder + "bglcomp.xsd"))
            {
                moduleMAIN.IsFSXBGLComp = true;
            }
            else if (My.MyProject.Computer.FileSystem.FileExists(BGLCompFolder + "bglcomp.exe") & My.MyProject.Computer.FileSystem.FileExists(BGLCompFolder + "bglcomp.xsd"))
            {
                B = BGLCompFolder + "bglcomp.exe";
                C = ToolsFolder + "bglcomp.exe";
                File.Copy(B, C, true);
                B = BGLCompFolder + "bglcomp.xsd";
                C = ToolsFolder + "bglcomp.xsd";
                File.Copy(B, C, true);
                moduleMAIN.IsFSXBGLComp = true;
            }

            moduleFILE_IO.WriteSettings();
            Dispose();
        }
    }
}