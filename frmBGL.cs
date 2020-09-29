using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    internal partial class FrmBGL
    {
        public FrmBGL()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdCompile.Name = "cmdCompile";
            _ckLinesOfObjects.Name = "ckLinesOfObjects";
            _ckTexPolys.Name = "ckTexPolys";
            _ckExcludes.Name = "ckExcludes";
            _ckObjects.Name = "ckObjects";
            _ckExtrusions.Name = "ckExtrusions";
            _ckTexLines.Name = "ckTexLines";
            _ckPhoto.Name = "ckPhoto";
            _ckWater.Name = "ckWater";
            _ckLand.Name = "ckLand";
            _ckVector.Name = "ckVector";
        }

        private bool Init = true;
        private bool CopyBGLs = false;
        private bool FWX = false;
        private bool STX = false;
        private bool RDX = false;
        private bool HLX = false;
        private bool RRX = false;
        private bool UTX = false;
        private bool EXX = false;
        private bool FLX = false;
        private bool PKX = false;
        private bool HPX = false;
        private bool HGX = false;

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            Dispose();
        }

        private void CmdCompile_Click(object eventSender, EventArgs eventArgs)
        {


            // If FSXTools = False Then
            if (moduleMAIN.IsFSXTerrain == false | moduleMAIN.IsFSXBGLComp == false)
            {
                Interaction.MsgBox(@"SDK Tools are not present in ..\SBuilder\Tools folder!", MsgBoxStyle.Critical);
                return;
            }

            My.MyProject.Forms.FrmStart.Cursor = Cursors.WaitCursor;
            if ((int)ckCopyBGLs.CheckState == 1)
                CopyBGLs = true;
            if (ckVector.Checked)
                MakeBGLVector();
            if ((int)ckLand.CheckState == 1)
                moduleCLASSES.MakeBglLand(ref CopyBGLs);
            if ((int)ckWater.CheckState == 1)
                moduleCLASSES.MakeBglWater(ref CopyBGLs);
            if ((int)ckPhoto.CheckState == 1)
                moduleTILES.MakeBglPhoto(CopyBGLs);
            if ((int)ckObjects.CheckState == 1)
                moduleOBJECTS.MakeBGLObjects(CopyBGLs);
            if ((int)ckExcludes.CheckState == 1)
                moduleEXCLUDES.MakeBGLExcludes(CopyBGLs);
            if ((int)ckTexPolys.CheckState == 1)
                modulePOLYS.MakeBGLTexPolys(CopyBGLs);
            if ((int)ckExtrusions.CheckState == 1)
                moduleLINES.MakeBGLExtrusions(CopyBGLs);
            if ((int)ckTexLines.CheckState == 1)
                modulePOLYS.MakeBGLTexLines(CopyBGLs);
            if ((int)ckLinesOfObjects.CheckState == 1)
                moduleLINES.MakeBGLObjLines(CopyBGLs);

            // If ckStartFSX.CheckState = 1 Then Shell(FSPath & "fsx.exe", 1)  'it looks Win10 does not like it
            // If ckStartFSX.CheckState = 1 Then Process.Start(FSPath & "fsx.exe")
            if ((int)ckStartFSX.CheckState == 1)
                Process.Start(moduleMAIN.FSPath + moduleMAIN.SimExe);
            My.MyProject.Forms.FrmStart.SetMouseIcon();
            Dispose();
        }

        private void FrmBGL_Load(object sender, EventArgs e)
        {
            int N;
            string A;
            bool Flag1 = false;
            bool Flag2 = false;
            Init = true;
            ckLand.Enabled = false;
            ckVector.Enabled = false;
            ckWater.Enabled = false;
            ckPhoto.Enabled = false;
            ckObjects.Enabled = false;
            ckExcludes.Enabled = false;
            ckTexPolys.Enabled = false;
            ckExtrusions.Enabled = false;
            ckTexLines.Enabled = false;
            ckLinesOfObjects.Enabled = false;
            ckCopyBGLs.Enabled = false;
            ckLand.Checked = false;
            ckVector.Checked = false;
            ckWater.Checked = false;
            ckPhoto.Checked = false;
            ckObjects.Checked = false;
            ckExcludes.Checked = false;
            ckTexPolys.Checked = false;
            ckExtrusions.Checked = false;
            ckTexLines.Checked = false;
            ckLinesOfObjects.Checked = false;
            EXX = false;
            PKX = false;
            HPX = false;
            HGX = false;
            FLX = false;
            STX = false;
            FWX = false;
            RDX = false;
            HLX = false;
            RRX = false;
            UTX = false;
            var loopTo = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (modulePOLYS.Polys[N].Selected)
                {
                    A = Strings.Mid(modulePOLYS.Polys[N].Type, 1, 3);
                    if (A == "XXX")
                        EXX = true;
                    if (A == "EXX")
                        EXX = true;
                    if (A == "LCP")
                        PKX = true;
                    if (A == "HPX")
                        HPX = true;
                    if (A == "HGX")
                        HGX = true;
                    if (A == "FLX")
                        FLX = true;
                    if (A == "TEX")
                    {
                        ckTexPolys.Enabled = true;
                        lbNoSelection.Visible = false;
                        ckTexPolys.Checked = true;
                        ckCopyBGLs.Enabled = true;
                    }
                }
            }

            var loopTo1 = moduleLINES.NoOfLines;
            for (N = 1; N <= loopTo1; N++)
            {
                if (moduleLINES.Lines[N].Selected)
                {
                    A = Strings.Mid(moduleLINES.Lines[N].Type, 1, 3);
                    if (A == "STX")
                        STX = true;
                    if (A == "FWX")
                        FWX = true;
                    if (A == "RDX")
                        RDX = true;
                    if (A == "HLX")
                        HLX = true;
                    if (A == "RRX")
                        RRX = true;
                    if (A == "UTX")
                        UTX = true;
                    if (A == "TEX")
                    {
                        ckTexLines.Enabled = true;
                        lbNoSelection.Visible = false;
                        ckTexLines.Checked = true;
                        ckCopyBGLs.Enabled = true;
                    }

                    if (A == "EXT")
                    {
                        ckExtrusions.Enabled = true;
                        lbNoSelection.Visible = false;
                        ckExtrusions.Checked = true;
                        ckCopyBGLs.Enabled = true;
                    }

                    if (A == "OBJ")
                    {
                        ckLinesOfObjects.Enabled = true;
                        lbNoSelection.Visible = false;
                        ckLinesOfObjects.Checked = true;
                        ckCopyBGLs.Enabled = true;
                    }
                }
            }

            if (EXX | PKX | HPX | HGX | FLX | STX | FWX | RDX | HLX | RRX | UTX)
            {
                ckVector.Enabled = true;
                lbNoSelection.Visible = false;
                ckVector.Checked = true;
                ckCopyBGLs.Enabled = true;
            }

            if (moduleCLASSES.NoOfLandsSelected > 0)
            {
                ckLand.Enabled = true;
                lbNoSelection.Visible = false;
                ckLand.Checked = true;
                ckCopyBGLs.Enabled = true;
            }

            if (moduleCLASSES.NoOfWatersSelected > 0)
            {
                ckWater.Enabled = true;
                lbNoSelection.Visible = false;
                ckWater.Checked = true;
                ckCopyBGLs.Enabled = true;
            }

            Flag1 = false;
            var loopTo2 = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo2; N++)
            {
                if (moduleMAPS.Maps[N].Selected)
                {
                    A = Strings.UCase(Strings.Mid(moduleMAPS.Maps[N].Name, 1, 5));
                    if (A == "PHOTO")
                    {
                        A = Strings.UCase(Path.GetExtension(moduleMAPS.Maps[N].BMPSu));
                        if (A == ".BMP")
                        {
                            Flag1 = true;
                            break;
                        }
                    }
                }
            }

            if (Flag1)
            {
                ckPhoto.Enabled = true;
                lbNoSelection.Visible = false;
                ckPhoto.Checked = true;
                ckCopyBGLs.Enabled = true;
            }

            Flag1 = false;
            var loopTo3 = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo3; N++)
            {
                if (moduleOBJECTS.Objects[N].Selected)
                {
                    Flag1 = true;
                    break;
                }
            }

            if (Flag1)
            {
                ckObjects.Enabled = true;
                lbNoSelection.Visible = false;
                ckObjects.Checked = true;
                ckCopyBGLs.Enabled = true;
            }

            Flag1 = false;
            var loopTo4 = moduleEXCLUDES.NoOfExcludes;
            for (N = 1; N <= loopTo4; N++)
            {
                if (moduleEXCLUDES.Excludes[N].Selected)
                {
                    Flag1 = true;
                    break;
                }
            }

            if (Flag1)
            {
                ckExcludes.Enabled = true;
                lbNoSelection.Visible = false;
                ckExcludes.Checked = true;
                ckCopyBGLs.Enabled = true;
            }

            Init = false;
        }

        private void MakeBGLVector()
        {
            string sourcebase, destbase;
            string source, dest, shapefile;
            string[] shpfiles;
            string ProjectNameNoSpaces;
            ProjectNameNoSpaces = Strings.Replace(moduleMAIN.ProjectName, " ", "_");
            shpfiles = Directory.GetFiles(moduleMAIN.AppPath + @"\Tools\Shapes");
            foreach (var currentShapefile in shpfiles)
            {
                shapefile = currentShapefile;
                File.Delete(shapefile);
            }

            sourcebase = moduleMAIN.AppPath + @"\Tools\";
            destbase = moduleMAIN.AppPath + @"\Tools\Shapes\";
            FileSystem.ChDrive(My.MyProject.Application.Info.DirectoryPath);
            FileSystem.ChDir(My.MyProject.Application.Info.DirectoryPath + @"\Tools\Shapes");
            if (EXX)
            {
                source = sourcebase + "EXX.xml";
                shapefile = "EXX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPPolys(shapefile, "EXX");
            }

            if (PKX)
            {
                source = sourcebase + "PKX.xml";
                shapefile = "PKX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPPolys(shapefile, "LCP");
            }

            if (HPX)
            {
                source = sourcebase + "HPX.xml";
                shapefile = "HPX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPPolys(shapefile, "HPX");
            }

            if (HGX)
            {
                source = sourcebase + "HGX.xml";
                shapefile = "HGX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPPolys(shapefile, "HGX");
            }

            if (FLX)
            {
                source = sourcebase + "FLX.xml";
                shapefile = "FLX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPPolys(shapefile, "FLX");
            }

            if (STX)
            {
                source = sourcebase + "STX.xml";
                shapefile = "STX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPLines(shapefile, "STX");
            }

            if (FWX)
            {
                source = sourcebase + "FWX.xml";
                shapefile = "FWX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPLines(shapefile, "FWX");
            }

            if (RDX)
            {
                source = sourcebase + "RDX.xml";
                shapefile = "RDX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPLines(shapefile, "RDX");
            }

            if (HLX)
            {
                source = sourcebase + "HLX.xml";
                shapefile = "HLX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPLines(shapefile, "HLX");
            }

            if (RRX)
            {
                source = sourcebase + "RRX.xml";
                shapefile = "RRX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPLines(shapefile, "RRX");
            }

            if (UTX)
            {
                source = sourcebase + "UTX.xml";
                shapefile = "UTX_" + ProjectNameNoSpaces;
                dest = destbase + shapefile + ".xml";
                File.Copy(source, dest);
                shapefile = shapefile + ".shp";
                moduleSHAPE.MakeSHPLines(shapefile, "UTX");
            }

            FileSystem.ChDir(My.MyProject.Application.Info.DirectoryPath + @"\Tools");
            string myCommand;
            myCommand = "shp2vec Shapes _" + ProjectNameNoSpaces;
            if (moduleSHAPE.AddToCells)
                myCommand = myCommand + " -ADDTOCELLS";
            moduleMAIN.ExecCmd(myCommand);
            if (!CopyBGLs)
                return;
            try
            {
                source = destbase + "CVX_" + ProjectNameNoSpaces + ".BGL";
                if (File.Exists(source))
                {
                    dest = moduleMAIN.BGLProjectFolder + @"\CVX_" + ProjectNameNoSpaces + ".BGL";
                    File.Copy(source, dest, true);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Copying BGL files failed! Try to close FSX.", MsgBoxStyle.Information);
            }
        }

        private void CkVector_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }

        private void CkLand_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }

        private void CkWater_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }

        private void CkPhoto_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }

        private void SetChecks()
        {
            if (Init)
                return;
            ckCopyBGLs.Enabled = false;
            if (ckVector.Checked | ckLand.Checked | ckWater.Checked | ckPhoto.Checked | ckTexPolys.Checked | ckObjects.Checked | ckExcludes.Checked)
            {
                ckCopyBGLs.Enabled = true;
            }
        }

        private void CkTexPolys_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }

        private void CkObjects_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }

        private void CkExcludes_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }

        private void CkLinesOfObjects_CheckedChanged(object sender, EventArgs e)
        {
            SetChecks();
        }
    }
}