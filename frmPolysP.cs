using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmPolysP
    {
        public FrmPolysP()
        {
            InitializeComponent();
            _cmdBottom.Name = "cmdBottom";
            _cmdTop.Name = "cmdTop";
            _cmdDown.Name = "cmdDown";
            _cmdUP.Name = "cmdUP";
            _cmdType.Name = "cmdType";
            _optTexture.Name = "optTexture";
            _optVector.Name = "optVector";
            _cmdAlt.Name = "cmdAlt";
            _cmdHelpSlope.Name = "cmdHelpSlope";
            _cmdSlope.Name = "cmdSlope";
            _TabPage2.Name = "TabPage2";
            _cmdColor.Name = "cmdColor";
            _lbExclude.Name = "lbExclude";
            _cmdDetail.Name = "cmdDetail";
            _imgTexture.Name = "imgTexture";
            _List1.Name = "List1";
            _TabPage3.Name = "TabPage3";
            _cmdColor2.Name = "cmdColor2";
            _imgTex.Name = "imgTex";
            _cmdTex.Name = "cmdTex";
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _cmdSmooth.Name = "cmdSmooth";
            _cmdSample.Name = "cmdSample";
        }

        private int ThisPolyType;
        private int ThisPoly;
        private bool IsInit = true;
        private int NoOfParents;
        private int ThisParent;

        private void FrmPolysP_Load(object sender, EventArgs e)
        {
            modulePOLYS.ParticularExcludeGUID = "{00000000-0000-0000-0000-111111111111}";
            modulePOLYS.Polys[0].GPoints = new modulePOINTS.GPoint[modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfPoints + 1];
            modulePOLYS.Polys[0] = modulePOLYS.Polys[modulePOPUP.POPIndex];
            if (modulePOLYS.Polys[0].Type == "XXX")
            {
                if (!string.IsNullOrEmpty(modulePOLYS.Polys[0].Guid))
                {
                    modulePOLYS.ParticularExcludeGUID = modulePOLYS.Polys[0].Guid;
                }
            }

            ThisPoly = modulePOPUP.POPIndex;
            int N;
            NoOfParents = 0;
            int loopTo = modulePOLYS.NoOfPolys;
            for (N = 1; N <= loopTo; N++)
            {
                if (modulePOLYS.Polys[N].NoOfChilds >= 0)
                    NoOfParents = NoOfParents + 1;
                if (N == ThisPoly)
                    ThisParent = NoOfParents;
            }

            lbOrder.Text = "Poly #" + ThisParent.ToString() + " out of " + NoOfParents.ToString();
            if (modulePOPUP.POPMode == "One")
            {
                if (IsTexPoly(ThisPoly))
                {
                    EnableTexPolys(true);
                    EnableVecPolys(false);
                    optTexture.Checked = true;
                    ShowTexturePoly();
                    TabControl1.SelectedIndex = 2;
                }
                else
                {
                    EnableTexPolys(false);
                    EnableVecPolys(true);
                    optVector.Checked = true;
                    ShowVectorPoly();
                    TabControl1.SelectedIndex = 1;
                }
            }
            else
            {
                BoxOrder.Enabled = false;
                EnableTexPolys(false);
                optVector.Checked = true;
                optTexture.Enabled = false;
                EnableVecPolys(true);
                ShowVectorPoly();
                TabControl1.SelectedIndex = 1;
            }

            IsInit = false;
            LoadForm();
        }

        private void ShowVectorPoly()
        {
            List1.Items.Clear();
            int N, LT, K;
            string A;
            if (modulePOPUP.POPMode == "Many" | modulePOPUP.POPMode == "SHP" | modulePOPUP.POPMode == "SUR")  // many to show
            {
                lbName.Enabled = false;
                txtName.Enabled = false;
                ckThisColor.BackColor = modulePOLYS.DefaultPolyColor;
                ckThisColor.ForeColor = moduleMAIN.InvertColor(modulePOLYS.DefaultPolyColor);
            }
            else
            {
                lbName.Enabled = true;
                txtName.Enabled = true;
                txtName.Text = modulePOLYS.Polys[0].Name;
                ckThisColor.BackColor = modulePOLYS.Polys[0].Color;
                ckThisColor.ForeColor = moduleMAIN.InvertColor(modulePOLYS.Polys[0].Color);
            }

            LT = 0;
            if (modulePOPUP.POPMode == "SHP")
            {
                A = moduleSHAPE.ShapePolyGuid;
                cmdSmooth.Enabled = false;
                cmdSample.Enabled = false;
            }
            else if (modulePOPUP.POPMode == "SUR")
            {
                A = moduleSURFER.BLNPolyGuid;
                cmdSmooth.Enabled = false;
                cmdSample.Enabled = false;
            }
            else
            {
                A = modulePOLYS.Polys[0].Guid;
            }

            if (!(modulePOLYS.Polys[0].Type == "XXX"))
            {
                K = 0;
                int loopTo = modulePOLYS.NoOfPolyTypes;
                for (N = 1; N <= loopTo; N++)
                {
                    K = K + 1;
                    List1.Items.Add(modulePOLYS.PolyTypes[N].Name);
                    if ((modulePOLYS.PolyTypes[N].Guid ?? "") == (A ?? ""))
                        LT = K;
                }
            }
            else
            {
                K = 0;
                int loopTo1 = modulePOLYS.NoOfPolyTypes;
                for (N = 1; N <= loopTo1; N++)
                {
                    K = K + 1;
                    List1.Items.Add(modulePOLYS.PolyTypes[N].Name);
                    if (modulePOLYS.PolyTypes[N].Type == "XXX")
                        LT = K;
                }
            }

            List1.SelectedIndex = LT - 1;
        }

        private void ShowTexturePoly()
        {
            string a, b;
            int N;
            a = modulePOLYS.Polys[modulePOPUP.POPIndex].Type;
            N = a.IndexOf("//");
            a = a.Substring(N + 2);
            N = a.IndexOf("//");
            b = a.Substring(0, N);
            ShowPolyTex(b);
            a = a.Substring(N + 2);
            N = a.IndexOf("//");
            b = a.Substring(0, N);
            txtTexPri.Text = Convert.ToInt32(b).ToString();
            a = a.Substring(N + 2);
            N = a.IndexOf("//");
            b = a.Substring(0, N);
            txtTexTileX.Text = Convert.ToInt32(b).ToString();
            a = a.Substring(N + 2);
            N = a.IndexOf("//");
            b = a.Substring(0, N);
            txtTexTileY.Text = Convert.ToInt32(b).ToString();
            a = a.Substring(N + 2);
            N = a.IndexOf("//");
            b = a.Substring(0, N);
            txtV1.Text = Convert.ToInt32(b).ToString();
            a = a.Substring(N + 2);
            N = a.IndexOf("//");
            ckNight.CheckState = (CheckState)Convert.ToInt32(a.Substring(0, N));
            a = a.Substring(N + 2);
            lbPolyColor.BackColor = modulePOLYS.Polys[modulePOPUP.POPIndex].Color;
            lbPolyColor.ForeColor = moduleMAIN.InvertColor(modulePOLYS.Polys[modulePOPUP.POPIndex].Color);
            modulePOLYS.PolyTexString = a;
        }

        private void ShowPolyTex(string Tex)
        {
            if (string.IsNullOrEmpty(Tex))
                return;
            try
            {
                Directory.SetCurrentDirectory(My.MyProject.Application.Info.DirectoryPath + @"\Tools\");
                string ImageTool;
                string BmpPath = moduleMAIN.AppPath + @"\Tools\Work\temp.bmp";
                txtTexName.Text = Tex;
                string TexPath = moduleMAIN.AppPath + @"\Texture\" + Tex;
                if (My.MyProject.Computer.FileSystem.FileExists(TexPath))
                {
                    ImageTool = @"imagetool -nogui -nomip -32 Work\temp.bmp";
                    File.Copy(TexPath, BmpPath, true);
                    moduleMAIN.ExecCmd(ImageTool);
                }
                else
                {
                    File.Copy(moduleMAIN.AppPath + @"\Tools\BMPs\none.jpg", BmpPath, true);
                }

                Image bmp = Image.FromFile(BmpPath);
                Bitmap cpy = new Bitmap(bmp);
                bmp.Dispose();
                imgTex.Image = cpy;
            }
            catch (Exception)
            {
                MessageBox.Show("There is a problem with the display of this image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            int N;
            if (modulePOPUP.POPMode == "Many") // many to set
            {
                moduleMAIN.Dirty = true;
                int loopTo = modulePOLYS.NoOfPolys;
                for (N = 1; N <= loopTo; N++)
                {
                    if (modulePOLYS.Polys[N].Selected & !IsTexPoly(N))
                    {
                        SetThisPolyProperties(N);
                    }
                }

                moduleMAIN.RebuildDisplay();
            }
            else if (modulePOPUP.POPMode == "SHP")
            {
                moduleSHAPE.ShapePolyGuid = modulePOLYS.PolyTypes[ThisPolyType].Guid;
            }
            else if (modulePOPUP.POPMode == "SUR")
            {
                moduleSURFER.BLNPolyGuid = modulePOLYS.PolyTypes[ThisPolyType].Guid;
            }
            else
            {
                moduleMAIN.Dirty = true;
                modulePOLYS.Polys[modulePOPUP.POPIndex].Name = txtName.Text;
                SetThisPolyProperties(modulePOPUP.POPIndex);
                moduleMAIN.RebuildDisplay();
            }

            modulePOPUP.POPIndex = 0;
            Dispose();
        }

        private void SetThisPolyProperties(int N)
        {
            int M;
            string A;
            if (optTexture.Checked)
            {
                try
                {
                    A = "TEX//" + txtTexName.Text + "//";
                    if (string.IsNullOrEmpty(txtTexPri.Text))
                        txtTexPri.Text = "4";
                    if (string.IsNullOrEmpty(txtTexTileX.Text))
                        txtTexTileX.Text = "1";
                    if (string.IsNullOrEmpty(txtTexTileY.Text))
                        txtTexTileY.Text = "1";
                    if (string.IsNullOrEmpty(txtV1.Text))
                        txtV1.Text = "5000";
                    A = A + Convert.ToInt32(txtTexPri.Text).ToString() + "//";
                    A = A + Convert.ToInt32(txtTexTileX.Text).ToString() + "//";
                    A = A + Convert.ToInt32(txtTexTileY.Text).ToString() + "//";
                    A = A + Convert.ToInt32(txtV1.Text).ToString() + "//";
                    A = A + ((int)ckNight.CheckState).ToString() + "//";
                    modulePOLYS.Polys[N].Type = A;
                    modulePOLYS.MakePolyTexString(N, false);
                    modulePOLYS.Polys[N].Type = A + modulePOLYS.PolyTexString;
                    modulePOLYS.Polys[N].Color = lbPolyColor.BackColor;
                    return;
                }
                catch (Exception)
                {
                    MessageBox.Show("Check your entries!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ckThisColor.Checked)
                {
                    modulePOLYS.Polys[N].Color = ckThisColor.BackColor;
                }
                else
                {
                    modulePOLYS.Polys[N].Color = lbTexture.BackColor;
                }

                if (modulePOLYS.PolyTypes[ThisPolyType].Type == "XXX")
                {
                    modulePOLYS.Polys[N].Guid = modulePOLYS.ParticularExcludeGUID;
                }
                else
                {
                    modulePOLYS.Polys[N].Guid = modulePOLYS.PolyTypes[ThisPolyType].Guid;
                }

                if ((modulePOLYS.PolyTypes[ThisPolyType].Guid ?? "") != (modulePOLYS.DefaultPolyFS9Guid ?? ""))
                {
                    modulePOLYS.Polys[N].Type = modulePOLYS.PolyTypes[ThisPolyType].Type;
                }

                if (modulePOLYS.Polys[N].NoOfChilds > 0)
                {
                    int loopTo = modulePOLYS.Polys[N].NoOfChilds;
                    for (M = 1; M <= loopTo; M++)
                        CopyProperties(N, modulePOLYS.Polys[N].Childs[M]);
                }

                modulePOLYS.Polys[N].Name = CheckVectorPolyName(N);
            }
        }

        private string CheckVectorPolyName(int N)
        {
            string CheckVectorPolyNameRet = default;

            try
            {
                CheckVectorPolyNameRet = modulePOLYS.Polys[N].Name;
                if (string.IsNullOrEmpty(CheckVectorPolyNameRet))
                    CheckVectorPolyNameRet = modulePOLYS.Polys[N].NoOfPoints.ToString() + "_Pts_";
                int K = CheckVectorPolyNameRet.IndexOf("_");
                if (K == -1)
                    return CheckVectorPolyNameRet;
                string A = CheckVectorPolyNameRet.Substring(K, 5);
                if (A == "_Pts_")
                {
                    CheckVectorPolyNameRet = CheckVectorPolyNameRet.Substring(0, K + 5) + modulePOLYS.PolyTypes[ThisPolyType].Name;
                }
            }
            catch (Exception)
            {
            }
            return CheckVectorPolyNameRet;
        }

        private void CopyProperties(int source, int dest)
        {
            modulePOLYS.Polys[dest].Color = modulePOLYS.Polys[source].Color;
            modulePOLYS.Polys[dest].Guid = modulePOLYS.Polys[source].Guid;
            modulePOLYS.Polys[dest].Type = modulePOLYS.Polys[source].Type;
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            modulePOPUP.POPIndex = 0;
            Dispose();
        }

        private void List1_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            if (Button == 2)
            {
                int LT;
                LT = List1.SelectedIndex + 1;
                My.MyProject.Computer.Clipboard.SetText(modulePOLYS.PolyTypes[LT].Guid);
            }
        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int LT;
            LT = List1.SelectedIndex + 1;
            ThisPolyType = LT;
            ShowVectorImage(LT);
            CheckIfXXX(LT);
        }

        private void ShowVectorImage(int LT)
        {
            string A = default;
            string jpg = ".jpg";

            try
            {
                // lbTexture.Text = VB6.GetItemString(List1, LT - 1)
                lbTexture.Text = List1.GetItemText(LT - 1);
                lbTexture.BackColor = modulePOLYS.PolyTypes[LT].Color;
                lbTexture.ForeColor = moduleMAIN.InvertColor(lbTexture.BackColor);
                A = My.MyProject.Application.Info.DirectoryPath + @"\Tools\Bmps\" + modulePOLYS.PolyTypes[LT].Texture + jpg;
                imgTexture.Image = Image.FromFile(A);
                moduleMAIN.ImageFileName = A;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(A);
            }
        }

        private void CheckIfXXX(int K)
        {
            if (modulePOLYS.PolyTypes[K].Type == "XXX")
            {
                lbExcludeCaption.Enabled = true;
                lbExclude.Enabled = true;
                lbExclude.Text = GetNameFromGuid(modulePOLYS.ParticularExcludeGUID);
            }
            else
            {
                lbExcludeCaption.Enabled = false;
                lbExclude.Enabled = false;
                lbExclude.Text = "";
            }
        }

        private void CmdDetail_Click(object sender, EventArgs e)
        {
            if (modulePOLYS.PolyTypes[ThisPolyType].TerrainIndex < 0)
            {
                MessageBox.Show("This type is not described in Terrain.cfg!");
                return;
            }

            string TerrainFile, A, B, C, Key;
            bool F1;
            if (moduleMAIN.IsFSX)
            {
                TerrainFile = moduleMAIN.FSPath + "Terrain.cfg";
                C = "Description from FSX/Terrain.cfg";
            }
            else
            {
                TerrainFile = moduleMAIN.AppPath + @"\Tools\Terrain.cfg";
                C = "Description from Tools/Terrain.cfg";
            }

            Key = "[Texture." + modulePOLYS.PolyTypes[ThisPolyType].TerrainIndex.ToString().Trim() + "]";
            using (var file = File.OpenText(TerrainFile))
            {
                F1 = false;
                B = "";
                while ((A = file.ReadLine()) != null)
                {
                    A = A.Trim();
                    if (F1)
                    {
                        if (string.IsNullOrEmpty(A))
                            break;
                        B = B + A + Environment.NewLine;
                    }

                    if (!F1)
                    {
                        if ((A ?? "") == (Key ?? ""))
                            F1 = true;
                    }
                }
            }

            MessageBox.Show(B, C, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LbExclude_Click(object sender, EventArgs e)
        {

            // ParticularExcludeGUID = lbExclude.Text
            if (My.MyProject.Forms.FrmTerrainExclude.ShowDialog() == DialogResult.OK)
            {
                lbExclude.Text = GetNameFromGuid(modulePOLYS.ParticularExcludeGUID);
            }
        }

        private void ImgTexture_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmImage.ShowDialog();
        }

        private string GetNameFromGuid(string GUID)
        {
            string GetNameFromGuidRet = default;
            int N;
            GetNameFromGuidRet = "Nothing to Exclude";
            int loopTo = modulePOLYS.NoOfPolyTypes;
            for (N = moduleMAIN.PolyInit; N <= loopTo; N++)
            {
                if ((modulePOLYS.PolyTypes[N].Guid ?? "") == (GUID ?? ""))
                {
                    GetNameFromGuidRet = modulePOLYS.PolyTypes[N].Name;
                    return GetNameFromGuidRet;
                }
            }

            int loopTo1 = moduleLINES.NoOfLineTypes;
            for (N = moduleMAIN.LineInit; N <= loopTo1; N++)
            {
                if ((moduleLINES.LineTypes[N].Guid ?? "") == (GUID ?? ""))
                {
                    GetNameFromGuidRet = moduleLINES.LineTypes[N].Name;
                    return GetNameFromGuidRet;
                }
            }

            return GetNameFromGuidRet;
        }

        private void CmdColor_Click(object sender, EventArgs e)
        {
            moduleMAIN.ARGBColor = ckThisColor.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                ckThisColor.BackColor = moduleMAIN.ARGBColor;
            }

            ckThisColor.ForeColor = moduleMAIN.InvertColor(moduleMAIN.ARGBColor);
        }

        private void CmdColor2_Click(object sender, EventArgs e)
        {
            moduleMAIN.ARGBColor = lbPolyColor.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                lbPolyColor.BackColor = moduleMAIN.ARGBColor;
            }

            lbPolyColor.ForeColor = moduleMAIN.InvertColor(moduleMAIN.ARGBColor);
        }

        private void CmdUP_Click(object sender, EventArgs e)
        {
            if (ThisParent == NoOfParents)
                return;
            moduleEDIT.BackUp();
            modulePOLYS.GPoly P1;
            int NP = NextParent();
            int J, N;
            P1 = modulePOLYS.Polys[NP];
            modulePOLYS.Polys[NP] = modulePOLYS.Polys[ThisPoly];
            modulePOLYS.Polys[ThisPoly] = P1;
            int loopTo = modulePOLYS.Polys[ThisPoly].NoOfChilds;
            for (N = 1; N <= loopTo; N++)
            {
                J = modulePOLYS.Polys[ThisPoly].Childs[N];
                modulePOLYS.Polys[J].NoOfChilds = -ThisPoly;
            }

            int loopTo1 = modulePOLYS.Polys[NP].NoOfChilds;
            for (N = 1; N <= loopTo1; N++)
            {
                J = modulePOLYS.Polys[NP].Childs[N];
                modulePOLYS.Polys[J].NoOfChilds = -NP;
            }

            ThisPoly = NP;
            ThisParent = ThisParent + 1;
            lbOrder.Text = "Poly #" + ThisParent.ToString() + " out of " + NoOfParents.ToString();
            moduleMAIN.RebuildDisplay();
        }

        private int NextParent()
        {
            int NextParentRet = default;
            NextParentRet = ThisPoly;
            do
            {
                NextParentRet = NextParentRet + 1;
                if (modulePOLYS.Polys[NextParentRet].NoOfChilds >= 0)
                    break;
            }
            while (true);
            return NextParentRet;
        }

        private int PreParent()
        {
            int PreParentRet = default;
            PreParentRet = ThisPoly;
            do
            {
                PreParentRet = PreParentRet - 1;
                if (modulePOLYS.Polys[PreParentRet].NoOfChilds >= 0)
                    break;
            }
            while (true);
            return PreParentRet;
        }

        private void CmdDown_Click(object sender, EventArgs e)
        {
            if (ThisParent == 1)
                return;
            moduleEDIT.BackUp();
            modulePOLYS.GPoly P1;
            int PP = PreParent();
            int J, N;
            P1 = modulePOLYS.Polys[PP];
            modulePOLYS.Polys[PP] = modulePOLYS.Polys[ThisPoly];
            modulePOLYS.Polys[ThisPoly] = P1;
            int loopTo = modulePOLYS.Polys[ThisPoly].NoOfChilds;
            for (N = 1; N <= loopTo; N++)
            {
                J = modulePOLYS.Polys[ThisPoly].Childs[N];
                modulePOLYS.Polys[J].NoOfChilds = -ThisPoly;
            }

            int loopTo1 = modulePOLYS.Polys[PP].NoOfChilds;
            for (N = 1; N <= loopTo1; N++)
            {
                J = modulePOLYS.Polys[PP].Childs[N];
                modulePOLYS.Polys[J].NoOfChilds = -PP;
            }

            ThisPoly = PP;
            ThisParent = ThisParent - 1;
            lbOrder.Text = "Poly #" + ThisParent.ToString() + " out of " + NoOfParents.ToString();
            moduleMAIN.RebuildDisplay();
        }

        private void CmdTop_Click(object sender, EventArgs e)
        {
            if (ThisParent == NoOfParents)
                return;
            moduleEDIT.BackUp();
            modulePOLYS.GPoly P1;
            int J, K, N, NP;
            P1 = modulePOLYS.Polys[ThisPoly];
            N = ThisPoly;
            do
            {
                NP = NextParent();
                modulePOLYS.Polys[N] = modulePOLYS.Polys[NP];
                int loopTo = modulePOLYS.Polys[N].NoOfChilds;
                for (K = 1; K <= loopTo; K++)
                {
                    J = modulePOLYS.Polys[N].Childs[K];
                    modulePOLYS.Polys[J].NoOfChilds = -N;
                }

                ThisParent = ThisParent + 1;
                ThisPoly = NP;
                if (ThisParent == NoOfParents)
                    break;
                N = NP;
            }
            while (true);
            modulePOLYS.Polys[NP] = P1;
            int loopTo1 = modulePOLYS.Polys[NP].NoOfChilds;
            for (K = 1; K <= loopTo1; K++)
            {
                J = modulePOLYS.Polys[NP].Childs[K];
                modulePOLYS.Polys[J].NoOfChilds = -NP;
            }

            lbOrder.Text = "Poly #" + ThisParent.ToString() + " out of " + NoOfParents.ToString();
            moduleMAIN.RebuildDisplay();
        }

        private void CmdBottom_Click(object sender, EventArgs e)
        {

            // Dim P1 As GPoly
            // Dim N As Integer

            // If ThisPoly = 1 Then Exit Sub
            // BackUp()
            // P1 = Polys(ThisPoly)
            // For N = ThisPoly To 2 Step -1
            // Polys(N) = Polys(N - 1)
            // Next
            // Polys(1) = P1
            // ThisPoly = 1

            // lbOrder.Text = "Poly #" & CStr(ThisPoly) & " out of " & CStr(NoOfParents)
            // RebuildDisplay()

            if (ThisParent == 1)
                return;
            moduleEDIT.BackUp();
            modulePOLYS.GPoly P1;
            int J, K, N, PP;
            P1 = modulePOLYS.Polys[ThisPoly];
            N = ThisPoly;
            do
            {
                PP = PreParent();
                modulePOLYS.Polys[N] = modulePOLYS.Polys[PP];
                int loopTo = modulePOLYS.Polys[N].NoOfChilds;
                for (K = 1; K <= loopTo; K++)
                {
                    J = modulePOLYS.Polys[N].Childs[K];
                    modulePOLYS.Polys[J].NoOfChilds = -N;
                }

                ThisParent = ThisParent - 1;
                ThisPoly = PP;
                if (ThisParent == 1)
                    break;
                N = PP;
            }
            while (true);
            modulePOLYS.Polys[PP] = P1;
            int loopTo1 = modulePOLYS.Polys[PP].NoOfChilds;
            for (K = 1; K <= loopTo1; K++)
            {
                J = modulePOLYS.Polys[PP].Childs[K];
                modulePOLYS.Polys[J].NoOfChilds = -PP;
            }

            lbOrder.Text = "Poly #" + ThisParent.ToString() + " out of " + NoOfParents.ToString();
            moduleMAIN.RebuildDisplay();
        }

        private void EnableTexPolys(bool Flag)
        {
            imgTex.Visible = Flag;
            cmdColor2.Enabled = Flag;
            lbPolyColor.Enabled = Flag;
            txtTexName.Enabled = Flag;
            cmdTex.Enabled = Flag;
            lbTexName.Enabled = Flag;
            ckNight.Enabled = Flag;
            boxTiling.Enabled = Flag;
            LbV1.Enabled = Flag;
            txtV1.Enabled = Flag;
            txtTexPri.Enabled = Flag;
            lbTexPri.Enabled = Flag;
            lbTex1.Enabled = Flag;
        }

        private void EnableVecPolys(bool Flag)
        {
            lbTexture.Enabled = Flag;
            cmdColor.Enabled = Flag;
            ckThisColor.Enabled = Flag;
            Label1.Enabled = Flag;
            Label2.Enabled = Flag;
            Label3.Enabled = Flag;
            lbExcludeCaption.Enabled = Flag;
            cmdDetail.Enabled = Flag;
            imgTexture.Visible = Flag;
            lbExclude.Enabled = Flag;
            List1.Enabled = Flag;
        }

        private void CmdType_Click(object sender, EventArgs e)
        {
            if (optVector.Checked)
                TabControl1.SelectedIndex = 1;
            if (optTexture.Checked)
                TabControl1.SelectedIndex = 2;
        }

        private void OptVector_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                if (IsInit)
                    return;
                EnableVecPolys(true);
                EnableTexPolys(false);
                ShowVectorPoly();
                TabControl1.SelectedIndex = 1;
            }
        }

        private void OptTexture_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                if (IsInit)
                    return;
                EnableVecPolys(false);
                EnableTexPolys(true);
                TabControl1.SelectedIndex = 2;
            }
        }

        private void LoadForm()
        {
            int N;
            double X, Y;
            bool Flag = false;
            int n0 = default, n1 = default, n2 = default;
            double k1 = default, k2 = default, k3 = default;
            double lat = default(double);
            double sxy = default, head = default;

            // added March 2009 Scott Smart 
            if (modulePOPUP.POPMode == "SHP" | modulePOPUP.POPMode == "SUR")
            {
                boxSlope.Enabled = false;
                boxAltitude.Enabled = false;
                return;
            }

            X = 0d;
            Y = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[1].alt;
            int loopTo = modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfPoints;
            for (N = 1; N <= loopTo; N++)
            {
                X = X + modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[N].alt;
                if (Y != modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[N].alt)
                    Flag = true;
            }

            txtAlt.Text = (X / modulePOLYS.Polys[modulePOPUP.POPIndex].NoOfPoints).ToString();
            if (Flag == false)
            {
                txtHead.Text = 0.ToString();
                txtSlope.Text = 0.ToString();
                txtAlt0.Text = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[1].alt.ToString();
                txtPt0.Text = 1.ToString();
                return;
            }

            modulePOLYS.Get3Points(modulePOPUP.POPIndex, ref n0, ref n1, ref n2, ref lat);
            modulePOLYS.GetSlopes(modulePOPUP.POPIndex, n0, n1, n2, ref k1, ref k2, ref k3);
            GetMaximumSlope(k1, k2, lat, ref sxy, ref head);
            txtHead.Text = head.ToString();
            txtSlope.Text = (sxy * 1000d).ToString();
            txtAlt0.Text = modulePOLYS.Polys[modulePOPUP.POPIndex].GPoints[n1].alt.ToString();
            txtPt0.Text = n1.ToString();
            string k1s = k1.ToString();
            string k2s = k2.ToString();
            lbSX.Text = "SlopeX = " + ((k1s.Length < 13) ? k1s : k1s.Substring(0, 13));
            lbSY.Text = "SlopeY = " + ((k2s.Length < 13) ? k2s : k2s.Substring(0, 13));
        }

        private void CmdSlope_Click(object sender, EventArgs e)
        {
            int N;

            try
            {
                if (modulePOPUP.POPMode == "One")
                {
                    SetPolyAltitudes(modulePOPUP.POPIndex);
                }
                else
                {
                    int loopTo = modulePOLYS.NoOfPolys;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected & modulePOLYS.Polys[N].NoOfChilds >= 0)
                        {
                            SetPolyAltitudes(N);
                        }
                    }
                }

                LoadForm();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check your entries!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetPolyAltitudes(int N)
        {
            double Head, lat, lon, sxy;
            double k1, k2, k3;
            double x0, y0, z0;
            int P;
            int K, J;
            Head = Convert.ToDouble(txtHead.Text);
            sxy = Convert.ToDouble(txtSlope.Text);
            lat = 0d;
            int loopTo = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                lat = lat + modulePOLYS.Polys[N].GPoints[K].lat;
            lat = lat / modulePOLYS.Polys[N].NoOfPoints;
            Head = Head * moduleMAIN.PI / 180.0d;
            sxy = sxy / 1000.0d;
            k1 = sxy * Math.Sin(Head);
            k2 = sxy * Math.Cos(Head);
            k1 = k1 * moduleMAIN.MetersPerDegLon(lat);
            k2 = k2 * moduleMAIN.MetersPerDegLat;
            P = Convert.ToInt32(txtPt0.Text);
            x0 = modulePOLYS.Polys[N].GPoints[P].lon;
            y0 = modulePOLYS.Polys[N].GPoints[P].lat;
            z0 = Convert.ToDouble(txtAlt0.Text);
            k3 = z0 - k1 * x0 - k2 * y0;
            int loopTo1 = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo1; K++)
            {
                lat = modulePOLYS.Polys[N].GPoints[K].lat;
                lon = modulePOLYS.Polys[N].GPoints[K].lon;
                modulePOLYS.Polys[N].GPoints[K].alt = k1 * lon + k2 * lat + k3;
            }

            int loopTo2 = modulePOLYS.Polys[N].NoOfChilds;
            for (P = 1; P <= loopTo2; P++)
            {
                J = modulePOLYS.Polys[N].Childs[P];
                int loopTo3 = modulePOLYS.Polys[J].NoOfPoints;
                for (K = 1; K <= loopTo3; K++)
                {
                    lat = modulePOLYS.Polys[J].GPoints[K].lat;
                    lon = modulePOLYS.Polys[J].GPoints[K].lon;
                    modulePOLYS.Polys[J].GPoints[K].alt = k1 * lon + k2 * lat + k3;
                }
            }
        }

        private void CmdAlt_Click(object sender, EventArgs e)
        {
            int N;
            double X;

            try
            {
                X = Convert.ToDouble(txtAlt.Text);
                if (modulePOPUP.POPMode == "One")
                {
                    SetConstantAltitude(modulePOPUP.POPIndex, X);
                }
                else
                {
                    int loopTo = modulePOLYS.NoOfPolys;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (modulePOLYS.Polys[N].Selected & modulePOLYS.Polys[N].NoOfChilds >= 0)
                        {
                            SetConstantAltitude(N, X);
                        }
                    }
                }

                LoadForm();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check altitude value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetConstantAltitude(int N, double H)
        {
            int K, P, J;
            int loopTo = modulePOLYS.Polys[N].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                modulePOLYS.Polys[N].GPoints[K].alt = H;
            int loopTo1 = modulePOLYS.Polys[N].NoOfChilds;
            for (P = 1; P <= loopTo1; P++)
            {
                J = modulePOLYS.Polys[N].Childs[P];
                int loopTo2 = modulePOLYS.Polys[J].NoOfPoints;
                for (K = 1; K <= loopTo2; K++)
                    modulePOLYS.Polys[J].GPoints[K].alt = H;
            }
        }

        private void CmdHelpSlope_Click(object sender, EventArgs e)
        {
            string A;
            A = "In this mode you specify: (i) the altitude and index of one" + Environment.NewLine;
            A = A + "point (ii) the heading of maximum slope and (iii) the maximum" + Environment.NewLine;
            A = A + "slope expressed as the altitude increase in meters per one" + Environment.NewLine;
            A = A + "thousand meters of horizontal shift.";
            MessageBox.Show(A, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Private Sub Get3Points(ByVal N As Integer, ByRef N1 As Integer, ByRef N2 As Integer, ByRef N3 As Integer, ByRef lat As Double)

        // Dim NP, J, K As Integer
        // Dim X1, X2, DX, DY, D As Double


        // NP = Polys(N).NoOfPoints
        // N1 = 1
        // N2 = 1
        // X1 = Polys(N).GPoints(1).lon
        // X2 = Polys(N).GPoints(1).lon

        // lat = 0

        // For J = 1 To NP
        // lat = lat + Polys(N).GPoints(J).lat
        // If Polys(N).GPoints(J).lon < X1 Then
        // N1 = J
        // X1 = Polys(N).GPoints(J).lon
        // End If
        // If Polys(N).GPoints(J).lon > X2 Then
        // N2 = J
        // X2 = Polys(N).GPoints(J).lon
        // End If
        // Next

        // lat = lat / NP

        // X1 = (Polys(N).GPoints(N1).lon - Polys(N).GPoints(N2).lon)
        // X1 = X1 * X1
        // X2 = (Polys(N).GPoints(N1).lat - Polys(N).GPoints(N2).lat)
        // X2 = X2 * X2
        // D = System.Math.Sqrt(X1 + X2)
        // For K = 1 To NP
        // If K <> N1 And K <> N2 Then
        // X1 = (Polys(N).GPoints(N1).lon - Polys(N).GPoints(K).lon)
        // X1 = X1 * X1
        // X2 = (Polys(N).GPoints(N1).lat - Polys(N).GPoints(K).lat)
        // X2 = X2 * X2
        // DX = System.Math.Sqrt(X1 + X2)
        // X1 = (Polys(N).GPoints(N2).lon - Polys(N).GPoints(K).lon)
        // X1 = X1 * X1
        // X2 = (Polys(N).GPoints(N2).lat - Polys(N).GPoints(K).lat)
        // X2 = X2 * X2
        // DY = System.Math.Sqrt(X1 + X2)
        // DX = DX + DY
        // If DX > D Then
        // D = DX
        // N3 = K
        // End If
        // End If
        // Next

        // End Sub

        // Private Sub GetSlopes(ByVal N As Integer, ByVal N0 As Integer, ByVal N1 As Integer, ByVal N2 As Integer, ByRef K1 As Double, ByRef K2 As Double, ByRef K3 As Double)

        // Dim z00, z01, z02 As Double
        // Dim x00, x01, x02 As Double
        // Dim y00, y01, y02 As Double
        // Dim a1, a2 As Double

        // x01 = Polys(N).GPoints(N0).lon - Polys(N).GPoints(N1).lon
        // x02 = Polys(N).GPoints(N0).lon - Polys(N).GPoints(N2).lon
        // y01 = Polys(N).GPoints(N0).lat - Polys(N).GPoints(N1).lat
        // y02 = Polys(N).GPoints(N0).lat - Polys(N).GPoints(N2).lat
        // z01 = Polys(N).GPoints(N0).alt - Polys(N).GPoints(N1).alt
        // z02 = Polys(N).GPoints(N0).alt - Polys(N).GPoints(N2).alt

        // If y01 = 0 Then
        // If x01 = 0 Then
        // K1 = 0
        // Else
        // K1 = z01 / x01
        // End If
        // Else
        // a1 = y02 / y01
        // z00 = z01 * a1 - z02
        // x00 = x01 * a1 - x02
        // K1 = z00 / x00
        // End If


        // If x01 = 0 Then
        // If y01 = 0 Then
        // K2 = 0
        // Else
        // K2 = z01 / y01
        // End If
        // Else
        // a2 = x02 / x01
        // z00 = z01 * a2 - z02
        // y00 = y01 * a2 - y02
        // K2 = z00 / y00
        // End If

        // K3 = Polys(N).GPoints(N0).alt - K1 * Polys(N).GPoints(N0).lon - K2 * Polys(N).GPoints(N0).lat

        // End Sub

        private void GetMaximumSlope(double k1, double k2, double lat, ref double sxy, ref double head)
        {
            double sx, sy;
            sxy = 0d;
            head = 0d;
            if (k1 == 0d & k2 == 0d)
                return;
            sx = k1 / moduleMAIN.MetersPerDegLon(lat);
            sy = k2 / moduleMAIN.MetersPerDegLat;
            sxy = Math.Sqrt(sx * sx + sy * sy);
            head = 0d;
            if (sx == 0d)
            {
                if (sy > 0d)
                {
                    head = 0d;
                    return;
                }
                else
                {
                    head = 180d;
                    return;
                }
            }

            if (sy == 0d)
            {
                if (sx > 0d)
                {
                    head = 90d;
                    return;
                }
                else
                {
                    head = 270d;
                    return;
                }
            }

            if (sx > 0d)
            {
                head = 90d - Math.Atan(sy / sx) * 180d / moduleMAIN.PI;
                return;
            }
            else
            {
                head = 270d - Math.Atan(sy / sx) * 180d / moduleMAIN.PI;
                return;
            }
        }

        private bool IsTexPoly(int N)
        {
            bool IsTexPolyRet = default;
            IsTexPolyRet = false;
            string type = modulePOLYS.Polys[N].Type;
            if (!string.IsNullOrEmpty(type) && type.Length >= 3 && type.Substring(0, 3) == "TEX")
                IsTexPolyRet = true;
            return IsTexPolyRet;
        }

        private void CmdSample_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLPSample.ShowDialog();
        }

        private void CmdSmooth_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLPSmooth.ShowDialog();
        }

        private void ImgTex_Click(object sender, EventArgs e)
        {
            bool Flag;

            Flag = false;
            if (string.IsNullOrEmpty(txtTexName.Text))
                Flag = true;
            if (txtTexName.Text == "na.bmp")
                Flag = true;
            if (modulePOPUP.POPMode != "One")
                Flag = true;
            if (Flag)
                return;
            modulePOLYS.PolyTex = txtTexName.Text;
            modulePOLYS.PolyTexIndex = modulePOPUP.POPIndex;
            modulePOLYS.MakePolyTexString(ThisPoly, false);
            My.MyProject.Forms.frmTexPoly.ShowDialog();
            return;
        }

        private void CmdTex_Click(object sender, EventArgs e)
        {
            string A, B;
            string Tex = "";
            A = "FSX Texture File (*.BMP)|*.BMP";
            B = "SBuilderXX: Open Texture File";
            A = moduleFILE_IO.FileNameToOpen(A, B, "TEX");
            if (string.IsNullOrEmpty(A))
            {
                return;
            }

            Tex = Path.GetFileName(A);
            string TexPath = moduleMAIN.AppPath + @"\Texture\" + Tex;
            if (File.Exists(TexPath))
            {
                if ((TexPath ?? "") != (A ?? ""))
                {
                    B = "This file already exists in the ../SBuilder/Texture" + Environment.NewLine;
                    B = B + "folder and it will be overwriten! Do you want to continue?";
                    if (MessageBox.Show(B, "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;
                }
            }

            try
            {
                if ((TexPath ?? "") != (A ?? ""))
                {
                    File.Delete(TexPath);
                    File.Copy(A, TexPath, true);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("The file could not be loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ShowPolyTex(Tex);
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {
            if (!(modulePOPUP.POPMode == "Many" | modulePOPUP.POPMode == "SHP" | modulePOPUP.POPMode == "SUR"))  // many to show
            {
                optTexture.Checked = true;
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
            if (!(modulePOPUP.POPMode == "Many" | modulePOPUP.POPMode == "SHP" | modulePOPUP.POPMode == "SUR"))  // many to show
            {
                optVector.Checked = true;
            }
        }
    }
}