using System;
//using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    public partial class FrmLibrary
    {
        public FrmLibrary()
        {
            InitializeComponent();
            _lstBGL.Name = "lstBGL";
            _cmbLibCat.Name = "cmbLibCat";
            _cmdAdd.Name = "cmdAdd";
            _lstLib.Name = "lstLib";
            _txtLibName.Name = "txtLibName";
            _txtLibWidth.Name = "txtLibWidth";
            _txtLibLength.Name = "txtLibLength";
            _cmdUpdate.Name = "cmdUpdate";
            _txtLibScale.Name = "txtLibScale";
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _cmdNewCat.Name = "cmdNewCat";
            _cmdBGL.Name = "cmdBGL";
            _cmdDown.Name = "cmdDown";
            _cmdUP.Name = "cmdUP";
            _cmdRemove.Name = "cmdRemove";
            _cmdAZ.Name = "cmdAZ";
            _cmdEditCat.Name = "cmdEditCat";
        }

        private List<moduleOBJECTS.LibObject> TempCategory = new List<moduleOBJECTS.LibObject>();
        private bool ChangeIsOFF = false;
        private bool IsLib = true;
        private moduleOBJECTS.LibCategory[] LibCategoriesX;
        private int NoOfLibCategoriesX;
        private List<string> RemovedObjs = new List<string>();  // go there the origin category and the guid separated by a space
        private bool[] CatOrderChanged;
        private bool[] CatObjectsAdded;

        private void FrmLibrary_Load(object sender, EventArgs e)
        {
            int K;
            string a, LibCat;
            IsLib = true;
            if (moduleOBJECTS.NoOfLibCategories == 0)
                return;
            cmbLibCat.Items.Clear();
            lstLib.Items.Clear();
            NoOfLibCategoriesX = moduleOBJECTS.NoOfLibCategories; // make the copies
            LibCategoriesX = new moduleOBJECTS.LibCategory[NoOfLibCategoriesX + 1];
            CatOrderChanged = new bool[NoOfLibCategoriesX + 1];
            CatObjectsAdded = new bool[NoOfLibCategoriesX + 1];
            var loopTo = NoOfLibCategoriesX;
            for (K = 1; K <= loopTo; K++)
            {
                LibCategoriesX[K].Objs = new List<moduleOBJECTS.LibObject>();
                CatOrderChanged[K] = false;
                CatObjectsAdded[K] = false;
            }

            LibCategoriesX = moduleOBJECTS.LibCategories;
            var loopTo1 = moduleOBJECTS.NoOfLibCategories;
            for (K = 1; K <= loopTo1; K++)

                // Dim g As LibCategory
                cmbLibCat.Items.Add(moduleOBJECTS.LibCategories[K].Name);   // display
            foreach (var g in moduleOBJECTS.LibCategories[1].Objs)
                lstLib.Items.Add(g.Name);
            cmbLibCat.SelectedIndex = 0;
            lstLib.SelectedIndex = 0;
            LibCat = moduleOBJECTS.LibCategories[1].Name;
            var myLibObj = moduleOBJECTS.LibCategories[1].Objs[0];
            txtLibID.Text = myLibObj.ID;
            txtLibWidth.Text = myLibObj.Width.ToString();
            txtLibLength.Text = myLibObj.Length.ToString();
            txtLibScale.Text = myLibObj.Scaling.ToString();
            txtLibName.Text = myLibObj.Name;
            moduleOBJECTS.ObjLibType = myLibObj.Type;
            labelFSTemp.Text = "Categorized " + GetFSType(moduleOBJECTS.ObjLibType);
            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtLibID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
            }

            imgLib.Image = Image.FromFile(a);
            moduleMAIN.ImageFileName = a;
            CheckUI();
        }

        private void CmbLibCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChangeIsOFF)
                return;
            IsLib = true;
            int K;
            string a, LibCat;

            // first remove all listings
            lstLib.Items.Clear();

            // get the category index

            // Dim g As LibCategory
            K = cmbLibCat.SelectedIndex + 1;
            foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                lstLib.Items.Add(g.Name);
            if (moduleOBJECTS.LibCategories[K].Objs.Count == 0)
            {
                txtLibWidth.Text = "";
                txtLibLength.Text = "";
                txtLibScale.Text = "";
                txtLibName.Text = "";
                CheckUI();
                return;
            }

            LibCat = moduleOBJECTS.LibCategories[K].Name;
            var myLibObj = moduleOBJECTS.LibCategories[K].Objs[0];
            lstLib.SelectedIndex = 0;
            txtLibID.Text = myLibObj.ID;
            txtLibWidth.Text = myLibObj.Width.ToString();
            txtLibLength.Text = myLibObj.Length.ToString();
            txtLibScale.Text = myLibObj.Scaling.ToString();
            txtLibName.Text = myLibObj.Name;
            labelFSTemp.Text = "Categorized " + GetFSType(moduleOBJECTS.ObjLibType);
            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtLibID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
            }

            imgLib.Image = Image.FromFile(a);
            moduleMAIN.ImageFileName = a;
            CheckUI();
        }

        private void LstLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChangeIsOFF)
                return;
            int N, K;
            string a, LibCat;

            // get the category index
            K = cmbLibCat.SelectedIndex + 1;
            if (K < 1)
                return;
            N = lstLib.SelectedIndex;
            if (N < 0)
                return;
            IsLib = true;
            LibCat = moduleOBJECTS.LibCategories[K].Name;
            var myLibObj = moduleOBJECTS.LibCategories[K].Objs[N];
            txtLibID.Text = myLibObj.ID;
            txtLibWidth.Text = myLibObj.Width.ToString();
            txtLibLength.Text = myLibObj.Length.ToString();
            txtLibScale.Text = myLibObj.Scaling.ToString();
            txtLibName.Text = myLibObj.Name;
            moduleOBJECTS.ObjLibType = myLibObj.Type;

            // ' after 205
            // txtComment.Text = myLibObj.Name

            labelFSTemp.Text = "Categorized " + GetFSType(moduleOBJECTS.ObjLibType);

            // cmdUpDefault.Enabled = False

            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtLibID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
            }

            imgLib.Image = Image.FromFile(a);
            moduleMAIN.ImageFileName = a;
            CheckUI();
        }

        private void CmdRemove_Click(object sender, EventArgs e)
        {
            if (lstLib.SelectedItems.Count == 0)
                return;
            ChangeIsOFF = true;
            int N, J, K;
            K = cmbLibCat.SelectedIndex + 1;
            if (K < 1)
                return;
            ListBox.SelectedIndexCollection JJ;
            JJ = lstLib.SelectedIndices;
            lstBGL.ClearSelected();
            N = lstBGL.Items.Count;
            foreach (int currentJ in JJ)
            {
                J = currentJ;
                lstBGL.Items.Add(moduleOBJECTS.LibCategories[K].Objs[J].Name);
                lstBGL.SetSelected(N, true);
                N = N + 1;
            }

            CatOrderChanged[K] = true;
            bool Flag = K <= NoOfLibCategoriesX;
            string A = K.ToString() + " ";
            foreach (int currentJ1 in JJ)
            {
                J = currentJ1;
                TempCategory.Add(moduleOBJECTS.LibCategories[K].Objs[J]);
                if (Flag)
                    RemovedObjs.Add(A + moduleOBJECTS.LibCategories[K].Objs[J].ID);
            }

            N = JJ.Count - 1;
            for (J = N; J >= 0; J -= 1)
                moduleOBJECTS.LibCategories[K].Objs.RemoveAt(JJ[J]);

            // Dim g As LibCategory
            lstLib.Items.Clear();
            foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                lstLib.Items.Add(g.Name);
            ChangeIsOFF = false;
            IsLib = false;
            CheckUI();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            if (lstBGL.SelectedItems.Count == 0)
                return;
            ChangeIsOFF = true;
            int N, J, K;
            K = cmbLibCat.SelectedIndex + 1;
            if (K < 1)
            {
                Interaction.MsgBox("Make a Category first");
                return;
            }

            CatOrderChanged[K] = true;
            CatObjectsAdded[K] = true;
            ListBox.SelectedIndexCollection JJ;
            JJ = lstBGL.SelectedIndices;
            lstLib.ClearSelected();
            N = lstLib.Items.Count;
            foreach (int currentJ in JJ)
            {
                J = currentJ;
                lstLib.Items.Add(TempCategory[J].Name);
                lstLib.SetSelected(N, true);
                N = N + 1;
            }
            // N = N - 1

            foreach (int currentJ1 in JJ)
            {
                J = currentJ1;
                moduleOBJECTS.LibCategories[K].Objs.Add(TempCategory[J]);
            }

            N = JJ.Count - 1;
            for (J = N; J >= 0; J -= 1)
                TempCategory.RemoveAt(JJ[J]);
            lstBGL.Items.Clear();
            foreach (var g in TempCategory)
                lstBGL.Items.Add(g.Name);
            ChangeIsOFF = false;
            IsLib = true;
            CheckUI();
        }

        private void CheckUI()
        {
            LabelNoBGLs.Text = TempCategory.Count.ToString();
            int K = cmbLibCat.SelectedIndex + 1;
            if (K < 1)
                return;
            LabelNoLIBs.Text = moduleOBJECTS.LibCategories[K].Objs.Count.ToString();
            if (lstBGL.SelectedItems.Count > 0)
            {
                cmdAdd.Enabled = true;
                txtBGLID.Text = TempCategory[lstBGL.SelectedIndex].ID;
                labelFSTemp.Text = "Temporary " + GetFSType(TempCategory[lstBGL.SelectedIndex].Type);
            }
            else
            {
                cmdAdd.Enabled = false;
                txtBGLID.Text = "";
                labelFSTemp.Text = "";
            }

            if (lstLib.SelectedItems.Count > 0)
            {
                cmdRemove.Enabled = true;
                txtLibID.Text = moduleOBJECTS.LibCategories[K].Objs[lstLib.SelectedIndex].ID;
                labelFS.Text = "Categorized " + GetFSType(moduleOBJECTS.LibCategories[K].Objs[lstLib.SelectedIndex].Type);
            }
            else
            {
                cmdRemove.Enabled = false;
                txtLibID.Text = "";
                labelFS.Text = "";
            }

            cmdUP.Enabled = false;
            cmdDown.Enabled = false;
            if (lstLib.SelectedItems.Count == 1)
            {
                if (lstLib.SelectedIndex > 0)
                {
                    cmdUP.Enabled = true;
                }

                if (lstLib.SelectedIndex < lstLib.Items.Count - 1)
                {
                    cmdDown.Enabled = true;
                }
            }

            if (lstLib.Items.Count == 0)
            {
                txtLibID.Text = "";
                labelFS.Text = "";
            }

            if (lstBGL.Items.Count == 0)
            {
                txtBGLID.Text = "";
                labelFSTemp.Text = "";
            }

            cmdUpdate.Enabled = false;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            moduleOBJECTS.NoOfLibCategories = NoOfLibCategoriesX;  // get the copies
            moduleOBJECTS.LibCategories = new moduleOBJECTS.LibCategory[moduleOBJECTS.NoOfLibCategories + 1];
            moduleOBJECTS.LibCategories = LibCategoriesX;
            Dispose();
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            try
            {
                try
                {
                    imgLib.Image.Dispose();
                }
                catch (Exception ex)
                {
                }

                string A, B, C;
                int K, N;
                var newCatNames = new List<string>();
                FileStream stream;
                StreamWriter fileWriter;
                StreamReader fileReader;
                string data = Strings.Replace(DateTime.Now.ToString(), " ", "_");
                data = Strings.Replace(data, "-", "_");
                data = Strings.Replace(data, ":", "_") + "_";
                string outfile = "";
                string LibCatFolder = "";

                // put removed jpegs in the bin
                A = moduleOBJECTS.LibObjectsPath + @"\NewJpegs\";
                var loopTo = RemovedObjs.Count - 1;
                for (N = 0; N <= loopTo; N++)
                {
                    B = RemovedObjs[N].ToString();
                    K = Strings.InStr(B, " ");
                    C = B.Substring(K) + ".jpg";
                    K = Conversions.ToInteger(B.Substring(0, K - 1));
                    B = moduleOBJECTS.LibObjectsPath + @"\" + moduleOBJECTS.LibCategories[K].Name + @"\" + C;
                    if (My.MyProject.Computer.FileSystem.FileExists(B))
                    {
                        // Try
                        // My.Computer.FileSystem.MoveFile(B, A & C, True)
                        // Catch ex As Exception
                        My.MyProject.Computer.FileSystem.CopyFile(B, A + C, true);
                        // End Try
                    }
                }

                // Count Objects and initiate NoOfJpegs
                System.Collections.ObjectModel.ReadOnlyCollection<string> counter;
                counter = My.MyProject.Computer.FileSystem.GetFiles(moduleOBJECTS.LibObjectsPath + @"\NewJpegs");
                moduleOBJECTS.NoOfJpegs = counter.Count;
                moduleOBJECTS.LibObject g;
                var loopTo1 = moduleOBJECTS.NoOfLibCategories;
                for (N = 1; N <= loopTo1; N++)
                {
                    // put backups of changed TXTs in LibObjects\BackUps and create new one in LibObjects
                    if (moduleOBJECTS.LibCategories[N].Objs.Count > 0)
                    {
                        // this cat exists
                        newCatNames.Add(moduleOBJECTS.LibCategories[N].Name);
                        if (CatOrderChanged[N]) // if order changed
                        {
                            A = moduleOBJECTS.LibObjectsPath + @"\" + moduleOBJECTS.LibCategories[N].Name + ".txt";
                            if (File.Exists(A))
                            {
                                B = moduleOBJECTS.LibObjectsPath + @"\BackUps\" + data + moduleOBJECTS.LibCategories[N].Name + ".txt";
                                My.MyProject.Computer.FileSystem.MoveFile(A, B, true);
                            }

                            stream = new FileStream(moduleOBJECTS.LibObjectsPath + @"\" + moduleOBJECTS.LibCategories[N].Name + ".txt", FileMode.Create);
                            fileWriter = new StreamWriter(stream);
                            fileWriter.WriteLine("[" + moduleOBJECTS.LibCategories[N].Name + "]");
                            foreach (var currentG in moduleOBJECTS.LibCategories[N].Objs)
                            {
                                g = currentG;
                                A = g.ID + " " + g.Type + " " + g.Width + " " + g.Length + " " + g.Scaling + " " + g.Name;
                                fileWriter.WriteLine(A);
                            }
                            // should I realy comment the following? October 2017
                            // fileWriter.Close()
                            stream.Close();
                        }

                        if (CatObjectsAdded[N])
                        {
                            if (moduleOBJECTS.NoOfJpegs > 0)
                            {
                                foreach (var currentG1 in moduleOBJECTS.LibCategories[N].Objs)
                                {
                                    g = currentG1;
                                    LibCatFolder = moduleOBJECTS.LibObjectsPath + @"\" + moduleOBJECTS.LibCategories[N].Name;
                                    B = LibCatFolder + @"\" + g.ID + ".jpg";
                                    if (!My.MyProject.Computer.FileSystem.FileExists(B))
                                    {
                                        C = g.ID + "*.jpg";
                                        var myfiles = My.MyProject.Computer.FileSystem.GetFiles(moduleOBJECTS.LibObjectsPath + @"\NewJpegs", Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, C);
                                        foreach (string myfile in myfiles)
                                        {
                                            My.MyProject.Computer.FileSystem.MoveFile(myfile, B, true);
                                            moduleOBJECTS.NoOfJpegs = moduleOBJECTS.NoOfJpegs - 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                // now change objects.txt for next startups
                if (My.MyProject.Computer.FileSystem.FileExists(moduleOBJECTS.LibObjectsPath + @"\objects.txt"))
                {
                    // rewrite objects.txt
                    stream = new FileStream(moduleOBJECTS.LibObjectsPath + @"\objects.txt", FileMode.Open);
                    fileReader = new StreamReader(stream);
                    string line = "";
                    while (!fileReader.EndOfStream)
                    {
                        line = fileReader.ReadLine();
                        if (line.Length > 0)
                        {
                            if (line.Substring(0, 1) == "i")
                            {
                                A = line.Substring(8);
                                N = A.Length;
                                A = A.Substring(0, N - 4);
                                if (newCatNames.Contains(A))
                                {
                                    newCatNames.Remove(A);
                                }
                                else
                                {
                                    line = "; comment on " + DateTime.Now.ToString() + Constants.vbCrLf + "; " + line;
                                }
                            }
                        }

                        outfile = outfile + line + Constants.vbCrLf;
                    }
                    // should I realy comment the following? October 2017
                    // fileReader.Close()
                    stream.Close();
                }

                if (newCatNames.Count > 0)
                {
                    outfile = outfile + Constants.vbCrLf + "; added in " + DateTime.Now.ToString() + Constants.vbCrLf;
                    foreach (string name in newCatNames)
                        outfile = outfile + "include=" + name + ".txt" + Constants.vbCrLf;
                }

                A = moduleOBJECTS.LibObjectsPath + @"\objects.txt";
                if (My.MyProject.Computer.FileSystem.FileExists(A))
                {
                    B = moduleOBJECTS.LibObjectsPath + @"\BackUps\" + data + "objects.txt";
                    My.MyProject.Computer.FileSystem.CopyFile(A, B, true);
                }

                stream = new FileStream(A, FileMode.Create);
                fileWriter = new StreamWriter(stream);
                fileWriter.Write(outfile);
                // should I realy comment the following? October 2017
                // fileWriter.Close()
                stream.Close();

                // SetLibObjects()

                // move rest of New to BackUp jpegs
                A = moduleOBJECTS.LibObjectsPath + @"\NewJpegs";
                B = moduleOBJECTS.LibObjectsPath + @"\BackUps\";
                foreach (string foundFile in My.MyProject.Computer.FileSystem.GetFiles(A, Microsoft.VisualBasic.FileIO.SearchOption.SearchAllSubDirectories, "*.*"))
                {
                    var foundFileInfo = new FileInfo(foundFile);
                    My.MyProject.Computer.FileSystem.MoveFile(foundFile, B + foundFileInfo.Name, true);
                }
            }
            catch (Exception ex)
            {
                Interaction.MsgBox("Could not update Categories!", MsgBoxStyle.Critical);
            }

            Dispose();
        }

        private void LstBGL_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChangeIsOFF)
                return;
            int N, K;
            string a, LibCat;

            // get the category index
            K = cmbLibCat.SelectedIndex + 1;
            N = lstBGL.SelectedIndex;
            if (K < 1)
                return;
            if (N < 0)
                return;
            IsLib = false;
            LibCat = moduleOBJECTS.LibCategories[K].Name;
            var myLibObj = TempCategory[N];
            txtBGLID.Text = myLibObj.ID;
            txtLibWidth.Text = myLibObj.Width.ToString();
            txtLibLength.Text = myLibObj.Length.ToString();
            txtLibScale.Text = myLibObj.Scaling.ToString();
            txtLibName.Text = myLibObj.Name;
            moduleOBJECTS.ObjLibType = myLibObj.Type;
            labelFSTemp.Text = "Temporary " + GetFSType(moduleOBJECTS.ObjLibType);
            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtBGLID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + txtBGLID.Text + ".bmp";
                if (!File.Exists(a))
                {
                    a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
                }
            }

            imgLib.Image = Image.FromFile(a);
            moduleMAIN.ImageFileName = a;
            CheckUI();
        }

        private void CmdNewCat_Click(object sender, EventArgs e)
        {
            try
            {
                string A = "Enter a Name for a Category without spaces. The ";
                A = A + "category will be empty until you add objects from the ";
                A = A + "temporary container on the right. If the category remains ";
                A = A + "empty when you press OK, it will be eliminated.";
                A = Strings.Trim(Interaction.InputBox(A, DefaultResponse: "FSX_New_Category"));
                int N = A.Length;
                if (N == 0)
                    return;
                A = Strings.Replace(A, " ", "_");
                var loopTo = moduleOBJECTS.NoOfLibCategories;
                for (N = 1; N <= loopTo; N++)
                {
                    if ((moduleOBJECTS.LibCategories[N].Name ?? "") == (A ?? ""))
                    {
                        Interaction.MsgBox("The name already exists!", MsgBoxStyle.Exclamation);
                        return;
                    }
                }

                int K = moduleOBJECTS.NoOfLibCategories + 1;
                Array.Resize(ref moduleOBJECTS.LibCategories, K + 1);
                Array.Resize(ref CatOrderChanged, K + 1);
                Array.Resize(ref CatObjectsAdded, K + 1);

                // CatOrderChanged(K) = True ' not needed because it is created empty
                // CatObjectsAdded(K) = True

                moduleOBJECTS.LibCategories[K].Name = A;
                moduleOBJECTS.LibCategories[K].Objs = new List<moduleOBJECTS.LibObject>();
                ChangeIsOFF = true;
                cmbLibCat.Items.Add(moduleOBJECTS.LibCategories[K].Name);
                cmbLibCat.SelectedIndex = K - 1;
                lstLib.Items.Clear();
                ChangeIsOFF = false;
                moduleOBJECTS.NoOfLibCategories = moduleOBJECTS.NoOfLibCategories + 1;
                return;
            }
            catch (Exception exc)
            {
                Interaction.MsgBox("Could not create a New Category!", MsgBoxStyle.Exclamation);
            }
        }

        private void CmdEditCat_Click(object sender, EventArgs e)
        {
            int K = cmbLibCat.SelectedIndex + 1;
            if (K < 1)
                return;
            string B = moduleOBJECTS.LibCategories[K].Name;
            string A = "Enter a New name for this Category without spaces.";
            A = Strings.Trim(Interaction.InputBox(A, DefaultResponse: B));
            int N = A.Length;
            if (N == 0)
                return;
            A = Strings.Replace(A, " ", "_");
            var loopTo = moduleOBJECTS.NoOfLibCategories;
            for (N = 1; N <= loopTo; N++)
            {
                if ((moduleOBJECTS.LibCategories[N].Name ?? "") == (A ?? ""))
                {
                    Interaction.MsgBox("The name already exists!", MsgBoxStyle.Exclamation);
                    return;
                }
            }

            CatOrderChanged[K] = true;
            moduleOBJECTS.LibCategories[K].Name = A;
            cmbLibCat.Items.Clear();
            var loopTo1 = moduleOBJECTS.NoOfLibCategories;
            for (N = 1; N <= loopTo1; N++)
                cmbLibCat.Items.Add(moduleOBJECTS.LibCategories[N].Name);   // display
            cmbLibCat.SelectedIndex = K - 1;
        }

        private void CmdAZ_Click(object sender, EventArgs e)
        {
            int K = cmbLibCat.SelectedIndex + 1;
            if (K <= 0)
            {
                return;
            }

            ChangeIsOFF = true;
            moduleOBJECTS.LibCategories[K].Objs.Sort();
            // Dim g As LibCategory
            lstLib.Items.Clear();
            foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                lstLib.Items.Add(g.Name);
            ChangeIsOFF = false;
            CatOrderChanged[K] = true;
        }

        private void CmdUP_Click(object sender, EventArgs e)
        {
            int N = lstLib.SelectedIndex;
            if (N <= 0)
            {
                return;
            }
            else
            {
                int K = cmbLibCat.SelectedIndex + 1;
                moduleOBJECTS.LibCategories[K].Objs.Reverse(N - 1, 2);
                // Dim g As LibCategory
                lstLib.Items.Clear();
                foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                    lstLib.Items.Add(g.Name);
                lstLib.SelectedIndex = N - 1;
                CatOrderChanged[K] = true;
            }
        }

        private void CmdDown_Click(object sender, EventArgs e)
        {
            int N = lstLib.SelectedIndex;
            if (N >= lstLib.Items.Count - 1)
            {
                return;
            }
            else
            {
                int K = cmbLibCat.SelectedIndex + 1;
                moduleOBJECTS.LibCategories[K].Objs.Reverse(N, 2);
                // Dim g As LibCategory
                lstLib.Items.Clear();
                foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                    lstLib.Items.Add(g.Name);
                lstLib.SelectedIndex = N + 1;
                CatOrderChanged[K] = true;
            }
        }

        private string GetFSType(int N)
        {
            string GetFSTypeRet = default;
            GetFSTypeRet = "";
            if (N == 0)
            {
                GetFSTypeRet = "FS8 Library Object";
            }
            else if (N == 1)
            {
                GetFSTypeRet = "FS9 Library Object";
            }
            else if (N == 2)
            {
                GetFSTypeRet = "FSX Library Object";
            }

            return GetFSTypeRet;
        }

        private void CmdUpdate_Click(object sender, EventArgs e)
        {
            var myObj = new moduleOBJECTS.LibObject();
            if (IsLib)
            {
                int K = cmbLibCat.SelectedIndex + 1;
                if (K < 1)
                    return;
                int N = lstLib.SelectedIndex;
                if (N < 0)
                    return;
                myObj.ID = moduleOBJECTS.LibCategories[K].Objs[N].ID;
                myObj.Name = txtLibName.Text;
                myObj.Type = moduleOBJECTS.LibCategories[K].Objs[N].Type;
                myObj.Width = (float)Conversion.Val(txtLibWidth.Text);
                myObj.Length = (float)Conversion.Val(txtLibLength.Text);
                myObj.Scaling = (float)Conversion.Val(txtLibScale.Text);
                moduleOBJECTS.LibCategories[K].Objs[N] = myObj;
                // Dim g As LibCategory
                lstLib.Items.Clear();
                foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                    lstLib.Items.Add(g.Name);
                lstLib.SelectedIndex = N;
                CatOrderChanged[K] = true;
            }
            else
            {
                int N = lstBGL.SelectedIndex;
                if (N < 0)
                    return;
                myObj.ID = TempCategory[N].ID;
                myObj.Name = txtLibName.Text;
                myObj.Type = TempCategory[N].Type;
                myObj.Width = (float)Conversion.Val(txtLibWidth.Text);
                myObj.Length = (float)Conversion.Val(txtLibLength.Text);
                myObj.Scaling = (float)Conversion.Val(txtLibScale.Text);
                TempCategory[N] = myObj;
                lstBGL.Items.Clear();
                foreach (var g in TempCategory)
                    lstBGL.Items.Add(g.Name);
                lstBGL.SelectedIndex = N;
            }

            cmdUpdate.Enabled = false;
        }

        private void CmdBGL_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string A, B;
            A = "Object Library file (*.BGL)|*.bgl";
            B = "SBuilderX: Open a Library BGL file";
            A = moduleFILE_IO.FileNameToOpen(A, B, "LIB");
            if (string.IsNullOrEmpty(A))
            {
                return;
            }

            Cursor = Cursors.WaitCursor;
            var fs = new FileStream(A, FileMode.Open, FileAccess.Read);
            var reader = new BinaryReader(fs);
            var bgl = new BGLReader();
            if (bgl.read(reader) == false)
            {
                Cursor = Cursors.Default;
                Interaction.MsgBox("Not a valid BGL!", MsgBoxStyle.Exclamation);
                // should I realy comment the following? October 2017
                // reader.Close()
                fs.Dispose();
                return;
            }
            // should I realy comment the following? October 2017
            // reader.Close()
            fs.Dispose();
            if (bgl.NoOfMDLs == 0)
            {
                Cursor = Cursors.Default;
                Interaction.MsgBox("The BGL file does not contain objects!", MsgBoxStyle.Exclamation);
                return;
            }

            txtBGLFile.Text = Path.GetFileName(A);
            ChangeIsOFF = true;
            IsLib = false;
            lstBGL.Items.Clear();
            TempCategory.Clear();
            A = Path.GetFileNameWithoutExtension(A);
            if (bgl.Type == 2)
                A = "";
            var myLibObj = new moduleOBJECTS.LibObject();
            int N;
            var loopTo = bgl.NoOfMDLs;
            for (N = 1; N <= loopTo; N++)
            {
                myLibObj.ID = bgl.MDLs[N].Guid;
                myLibObj.Name = A + bgl.MDLs[N].Name;
                myLibObj.Width = bgl.MDLs[N].W;
                myLibObj.Length = bgl.MDLs[N].L;
                myLibObj.Type = bgl.MDLs[N].Type;
                // myLibObj.Type = bgl.Type  ' remove this after Lance
                // myLibObj.Type = 2 ' Luis Feliz Tirado
                myLibObj.Scaling = 1f;
                lstBGL.Items.Add(myLibObj.Name);
                TempCategory.Add(myLibObj);
            }

            lstBGL.SelectedIndex = 0;
            CheckUI();
            ChangeIsOFF = false;
            Cursor = Cursors.Default;
        }

        private void TxtLibLength_TextChanged(object sender, EventArgs e)
        {
            cmdUpdate.Enabled = true;
        }

        private void TxtLibWidth_TextChanged(object sender, EventArgs e)
        {
            cmdUpdate.Enabled = true;
        }

        private void TxtLibScale_TextChanged(object sender, EventArgs e)
        {
            cmdUpdate.Enabled = true;
        }

        private void TxtLibName_TextChanged(object sender, EventArgs e)
        {
            cmdUpdate.Enabled = true;
        }
    }
}