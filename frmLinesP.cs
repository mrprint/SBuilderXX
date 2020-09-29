using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    internal partial class FrmLinesP
    {
        public FrmLinesP()
        {
            InitializeComponent();
            _cmdColor.Name = "cmdColor";
            _cmdWinding.Name = "cmdWinding";
            _optObjects.Name = "optObjects";
            _cmdType.Name = "cmdType";
            _optExtrusion.Name = "optExtrusion";
            _optTexture.Name = "optTexture";
            _optVector.Name = "optVector";
            _cmdAlt.Name = "cmdAlt";
            _cmdReverse.Name = "cmdReverse";
            _cmdWidth12.Name = "cmdWidth12";
            _cmdWidth.Name = "cmdWidth";
            _TabPage2.Name = "TabPage2";
            _cmdDetail.Name = "cmdDetail";
            _listVector.Name = "listVector";
            _TabPage3.Name = "TabPage3";
            _optLying.Name = "optLying";
            _optTile.Name = "optTile";
            _optStretch.Name = "optStretch";
            _cmdTex.Name = "cmdTex";
            _TabPage4.Name = "TabPage4";
            _cmdExtrusionProperties.Name = "cmdExtrusionProperties";
            _listExtrusion.Name = "listExtrusion";
            _imgExtrusion.Name = "imgExtrusion";
            _TabPage5.Name = "TabPage5";
            _ckRandom.Name = "ckRandom";
            _cmdHeading.Name = "cmdHeading";
            _lstLib.Name = "lstLib";
            _cmbLibCat.Name = "cmbLibCat";
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _cmdSample.Name = "cmdSample";
            _cmdSmooth.Name = "cmdSmooth";
        }

        private int ThisLineType;
        private int ThisExtrusionType;

        // Private ThisObjectType As Integer
        private float ObjWidth;
        private float ObjLength;
        internal string ProfileGuid;
        internal string MaterialGuid;
        internal string PylonGuid;
        internal double ExtrusionWidth;
        internal double ExtrusionProbability;
        internal bool SuppressPlatform;
        internal int Complexity;  // for extrusions
        private bool Init = true; // controls call to LoadList

        private void SetThisVectorLineProperties(int N)
        {
            if (ckThisColor.Checked)
            {
                moduleLINES.Lines[N].Color = ckThisColor.BackColor;
            }
            else
            {
                moduleLINES.Lines[N].Color = labelVectorTexture.BackColor;
            }

            moduleLINES.Lines[N].Guid = moduleLINES.LineTypes[ThisLineType].Guid;
            if ((moduleLINES.LineTypes[ThisLineType].Guid ?? "") != (moduleLINES.DefaultLineFS9Guid ?? ""))
            {
                string A;
                A = moduleLINES.LineTypes[ThisLineType].Type;
                A = (A.Length < 3) ? "" : A.Substring(0, 3);
                if (A == "FWX")
                {
                    moduleLINES.Lines[N].Type = "FWX" + cbLanes.SelectedItem + cbDir.SelectedItem;
                }
                else
                {
                    moduleLINES.Lines[N].Type = moduleLINES.LineTypes[ThisLineType].Type;
                }
            }

            moduleLINES.Lines[N].Name = CheckVectorLineName(N);
        }

        private void SetThisExtrusionLineProperties(int N)
        {
            try
            {
                moduleLINES.Lines[N].Color = ckThisColor.BackColor;
                moduleLINES.Lines[N].Name = CheckExtrusionLineName(N);
                moduleLINES.Lines[N].Guid = labelProfile.Text;
                moduleLINES.Lines[N].Type = "EXT|" + MaterialGuid + "|" + PylonGuid + "|" + Complexity.ToString() + "|" + ExtrusionWidth.ToString() + "|" + ExtrusionProbability.ToString() + "|" + SuppressPlatform.ToString();

                int K;
                var loopTo = moduleLINES.Lines[N].NoOfPoints;
                for (K = 1; K <= loopTo; K++)
                    moduleLINES.Lines[N].GLPoints[K].wid = ExtrusionWidth;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check your Extrusion Line parameters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetThisTexturedLineProperties(int N)
        {
            try
            {
                int Complex = cmbComplex.SelectedIndex;
                string X = "Standing";
                if (optLying.Checked)
                    X = "Lying";
                if (string.IsNullOrEmpty(txtTexName.Text))
                {
                    MessageBox.Show("You need to specify a texture for the line!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                string A = "TEX|" + X + "|";
                A = A + txtTexName.Text + "|";
                if (string.IsNullOrEmpty(txtTexPri.Text))
                    txtTexPri.Text = "4";
                if (string.IsNullOrEmpty(txtV1.Text))
                    txtV1.Text = "15000";
                A = A + Convert.ToInt32(txtTexPri.Text).ToString() + "|";
                A = A + Convert.ToInt32(txtV1.Text).ToString() + "|";
                A = A + Complex.ToString() + "|";
                A = A + ckNight.Checked.ToString() + "|";
                X = "Tile";
                if (optStretch.Checked)
                    X = "Stretch";
                if (optFull.Checked)
                    X = "FullTile";
                A = A + X;
                moduleLINES.Lines[N].Type = A;
                moduleLINES.Lines[N].Color = ckThisColor.BackColor;
                moduleLINES.Lines[N].Name = CheckTexturedLineName(N);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check your Textured Line parameters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SetThisLineOfObjectsProperties(int N)
        {
            try
            {
                if (lstLib.SelectedIndex == -1)
                    return; // because unknown
                int Complexity = cmbComplexity.SelectedIndex;
                moduleLINES.Lines[N].Color = ckThisColor.BackColor;
                moduleLINES.Lines[N].Name = CheckLineOfObjectsName(N);
                moduleLINES.Lines[N].Guid = labelLibID.Text;
                moduleLINES.Lines[N].Type = "OBJ|" + ObjWidth.ToString().Trim() + "|" + ObjLength.ToString().Trim() + "|" + Complexity.ToString();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check your Line of Objects parameters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string CheckLineOfObjectsName(object N)
        {
            string CheckLineOfObjectsNameRet = default;
            CheckLineOfObjectsNameRet = moduleLINES.Lines[Convert.ToInt32(N)].Name;
            if (string.IsNullOrEmpty(CheckLineOfObjectsNameRet))
                CheckLineOfObjectsNameRet = moduleLINES.Lines[Convert.ToInt32(N)].NoOfPoints.ToString() + "_Pts_";
            int K = CheckLineOfObjectsNameRet.IndexOf("_");
            if (K == -1)
                return CheckLineOfObjectsNameRet;
            string A = CheckLineOfObjectsNameRet.Substring(K, 5);
            if (A == "_Pts_")
            {
                CheckLineOfObjectsNameRet = CheckLineOfObjectsNameRet.Substring(0, K + 5) + labelLibID.Text;
            }

            return CheckLineOfObjectsNameRet;
        }

        private string CheckVectorLineName(int N)
        {
            string CheckVectorLineNameRet = default;
            try
            {
                CheckVectorLineNameRet = moduleLINES.Lines[N].Name;
                if (string.IsNullOrEmpty(CheckVectorLineNameRet))
                    CheckVectorLineNameRet = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_";
                int K = CheckVectorLineNameRet.IndexOf("_");
                if (K == -1)
                    return CheckVectorLineNameRet;
                string A = CheckVectorLineNameRet.Substring(K, 5);
                if (A == "_Pts_")
                {
                    CheckVectorLineNameRet = CheckVectorLineNameRet.Substring(0, K + 5) + moduleLINES.LineTypes[ThisLineType].Name;
                }
            }
            catch (Exception)
            {
            }
            return CheckVectorLineNameRet;
        }

        private string CheckExtrusionLineName(int N)
        {
            string CheckExtrusionLineNameRet = default;
            CheckExtrusionLineNameRet = moduleLINES.Lines[N].Name;
            if (string.IsNullOrEmpty(CheckExtrusionLineNameRet))
                CheckExtrusionLineNameRet = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_";
            int K = CheckExtrusionLineNameRet.IndexOf("_");
            if (K == -1)
                return CheckExtrusionLineNameRet;
            string A = CheckExtrusionLineNameRet.Substring(K, 5);
            if (A == "_Pts_")
            {
                CheckExtrusionLineNameRet = CheckExtrusionLineNameRet.Substring(0, K + 5) + moduleLINES.ExtrusionTypes[ThisExtrusionType].Name;
            }

            return CheckExtrusionLineNameRet;
        }

        private string CheckTexturedLineName(int N)
        {
            string CheckTexturedLineNameRet = default;
            CheckTexturedLineNameRet = moduleLINES.Lines[N].Name;
            if (string.IsNullOrEmpty(CheckTexturedLineNameRet))
                CheckTexturedLineNameRet = moduleLINES.Lines[N].NoOfPoints.ToString() + "_Pts_";
            int K = CheckTexturedLineNameRet.IndexOf("_");
            if (K == -1)
                return CheckTexturedLineNameRet;
            string A = CheckTexturedLineNameRet.Substring(K, 5);
            if (A == "_Pts_")
            {
                CheckTexturedLineNameRet = CheckTexturedLineNameRet.Substring(0, K + 5) + "Line_" + txtTexName.Text;
            }

            return CheckTexturedLineNameRet;
        }

        private void FrmLinesP_Load(object sender, EventArgs e)
        {
            LoadForm(); // only used here
        }

        private void LoadForm()
        {
            string Guid;
            if (modulePOPUP.POPMode == "SHP")
            {
                Guid = moduleSHAPE.ShapeLineGuid;
                LoadListVector(Guid);
                cmdSmooth.Enabled = false;
                cmdSample.Enabled = false;
                EnableVectorLine(true);
                ckThisColor.Enabled = false;
                cmdColor.Enabled = false;
                EnableName(false);
                EnableReverse(false);
                EnableWidthAndAltitude(false);
                boxType.Enabled = false;
                EnableExtrusionLine(false);
                EnableTexturedLine(false);
                EnableLineOfObjects(false);
                TabControl1.SelectedIndex = 1;
                Init = false;
                return;
            }

            if (modulePOPUP.POPMode == "SUR")
            {
                Guid = moduleSURFER.BLNLineGuid;
                LoadListVector(Guid);
                cmdSmooth.Enabled = false;
                cmdSample.Enabled = false;
                EnableVectorLine(true);
                ckThisColor.Enabled = false;
                cmdColor.Enabled = false;
                EnableName(false);
                EnableReverse(false);
                EnableWidthAndAltitude(false);
                boxType.Enabled = false;
                EnableExtrusionLine(false);
                EnableTexturedLine(false);
                EnableLineOfObjects(false);
                TabControl1.SelectedIndex = 1;
                Init = false;
                return;
            }

            if (modulePOPUP.POPMode == "Many")  // many to show
            {
                EnableName(false);
                ckThisColor.BackColor = moduleLINES.DefaultLineColor;
                ckThisColor.ForeColor = moduleMAIN.InvertColor(moduleLINES.DefaultLineColor);
                Guid = moduleLINES.Lines[modulePOPUP.POPIndex].Guid;
                LoadListVector(Guid);
                EnableVectorLine(true);
                EnableWidthAndAltitude(true);
                boxType.Enabled = false;
                EnableExtrusionLine(false);
                EnableTexturedLine(false);
                EnableLineOfObjects(false);
                Init = false;
                return;
            }

            // or just one to show
            EnableName(true);
            txtName.Text = moduleLINES.Lines[modulePOPUP.POPIndex].Name;
            ckThisColor.BackColor = moduleLINES.Lines[modulePOPUP.POPIndex].Color;
            ckThisColor.ForeColor = moduleMAIN.InvertColor(moduleLINES.Lines[modulePOPUP.POPIndex].Color);
            Guid = moduleLINES.Lines[modulePOPUP.POPIndex].Guid;
            LoadWidthAndAltitude();
            LoadListVector(Guid);
            LoadListExtrusion(Guid);
            LoadListObjects(Guid);
            Init = false;   // before the opts
            try
            {
                string A = moduleLINES.Lines[modulePOPUP.POPIndex].Type;
                A = (A.Length < 3) ? "" : A.Substring(0, 3).ToUpper();
                if (A == "EXT")
                {
                    optExtrusion.Checked = true;
                    GetExtrusionLine(modulePOPUP.POPIndex);
                }
                else if (A == "TEX")
                {
                    optTexture.Checked = true;
                    GetTexturedLine(modulePOPUP.POPIndex);
                }
                else if (A == "OBJ")
                {
                    optObjects.Checked = true;
                    GetLineOfObjects(modulePOPUP.POPIndex);
                }
                else
                {
                    optVector.Checked = false;
                    optVector.Checked = true;
                }
            }
            catch (Exception ex)   // line has no type yet
            {
                optVector.Checked = false;
                optVector.Checked = true;
            }
        }

        private void LoadListVector(string Guid)
        {
            int K, N, LT;
            listVector.Items.Clear();
            LT = 1;
            K = 0;
            var loopTo = moduleLINES.NoOfLineTypes;
            for (N = 1; N <= loopTo; N++)
            {
                K = K + 1;
                listVector.Items.Add(moduleLINES.LineTypes[N].Name);
                if ((moduleLINES.LineTypes[N].Guid ?? "") == (Guid ?? ""))
                    LT = K;
            }

            listVector.SelectedIndex = LT - 1;
            ShowThisVectorType(LT);
            CheckIfFWX(LT);
            ThisLineType = LT;
        }

        private void LoadListExtrusion(string guid)
        {
            int K, N, LT;
            listExtrusion.Items.Clear();
            LT = 1;
            K = 0;
            var loopTo = moduleLINES.NoOfExtrusionTypes;
            for (N = 1; N <= loopTo; N++)
            {
                K = K + 1;
                listExtrusion.Items.Add(moduleLINES.ExtrusionTypes[N].Name);
                if ((moduleLINES.ExtrusionTypes[N].Profile ?? "") == (guid ?? ""))
                    LT = K;
            }

            listExtrusion.SelectedIndex = LT - 1;
            labelProfile.Text = moduleLINES.ExtrusionTypes[LT].Profile;
            ShowThisExtrusionType(LT);
            ThisExtrusionType = LT;
        }

        private void LoadListObjects(string Guid)
        {
            int N = default, K;
            string a;
            string LibCat = "";
            moduleOBJECTS.LibObject g;
            if (moduleOBJECTS.NoOfLibCategories == 0)
                return;
            labelLibID.Text = Guid;

            // first remove
            lstLib.Items.Clear();
            cmbLibCat.Items.Clear();
            var loopTo = moduleOBJECTS.NoOfLibCategories;
            for (K = 1; K <= loopTo; K++)
                cmbLibCat.Items.Add(moduleOBJECTS.LibCategories[K].Name);
            bool Flag = false;
            var loopTo1 = moduleOBJECTS.NoOfLibCategories;
            for (K = 1; K <= loopTo1; K++)
            {
                N = 0;
                foreach (var currentG in moduleOBJECTS.LibCategories[K].Objs)
                {
                    g = currentG;
                    if (g.ID == Guid)
                    {
                        Flag = true;
                        break;
                    }

                    N = N + 1;
                }

                if (Flag)
                    break;
            }

            labelLibID.Text = Guid;
            if (Flag == false)
                K = 1;
            // N = 0

            // End If

            // select category
            LibCat = moduleOBJECTS.LibCategories[K].Name;
            cmbLibCat.SelectedIndex = K - 1;
            // fill objects and set selected
            foreach (var currentG1 in moduleOBJECTS.LibCategories[K].Objs)
            {
                g = currentG1;
                lstLib.Items.Add(g.Name);
            }

            if (Flag == false)
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\unknown.jpg";  // no index selected!
            }
            else
            {
                lstLib.SelectedIndex = N;
                a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + labelLibID.Text + ".jpg";
                moduleMAIN.ImageFileNameTrue = a;
                if (!File.Exists(a))
                {
                    a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
                }
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            imgLib.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
        }

        private void GetTexturedLine(int K)
        {
            string A, B;
            int N;
            A = moduleLINES.Lines[K].Type;
            N = A.IndexOf("|");
            A = A.Substring(N + 1);
            // TEX| was removed

            N = A.IndexOf("|");
            B = A.Substring(0, 1);
            if (B == "S")
            {
                optStanding.Checked = true;
                optLying.Checked = false;
            }
            else if (B == "L")
            {
                optStanding.Checked = false;
                optLying.Checked = true;
            }

            A = A.Substring(N + 1);
            N = A.IndexOf("|");
            B = A.Substring(0, N);
            ShowLineTex(B);
            A = A.Substring(N + 1);
            N = A.IndexOf("|");
            B = A.Substring(0, N);
            txtTexPri.Text = Convert.ToInt32(B).ToString();
            A = A.Substring(N + 1);
            N = A.IndexOf("|");
            B = A.Substring(0, N);
            txtV1.Text = Convert.ToInt32(B).ToString();
            A = A.Substring(N + 1);
            N = A.IndexOf("|");
            B = A.Substring(0, N);
            cmbComplex.SelectedIndex = Convert.ToInt32(B);
            A = A.Substring(N + 1);
            N = A.IndexOf("|");
            B = A.Substring(0, N);
            ckNight.Checked = Convert.ToBoolean(B);
            A = A.Substring(N + 1, 1);
            if (A == "T")
            {
                optTile.Checked = true;
                optStretch.Checked = false;
                optFull.Checked = false;
            }
            else if (A == "S")
            {
                optTile.Checked = false;
                optStretch.Checked = true;
                optFull.Checked = false;
            }
            else if (A == "F")
            {
                optTile.Checked = false;
                optStretch.Checked = false;
                optFull.Checked = true;
            }

            ckThisColor.BackColor = moduleLINES.Lines[K].Color;
            ckThisColor.ForeColor = moduleMAIN.InvertColor(moduleLINES.Lines[K].Color);
        }

        private void LoadWidthAndAltitude()
        {
            int N;
            double X;

            // altitude
            X = 0d;
            var loopTo = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
            for (N = 1; N <= loopTo; N++)
                X = X + moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[N].alt;
            txtAlt.Text = (X / moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints).ToString();

            // progressive width
            txtWidth1.Text = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[1].wid.ToString();
            txtWidth2.Text = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints].wid.ToString();
            double W;
            W = 0d;
            var loopTo1 = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
            for (N = 1; N <= loopTo1; N++)
                W = W + moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[N].wid;
            txtWidth.Text = (W / moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints).ToString();
        }

        private void ShowThisVectorType(int LT)
        {
            string A = default;
            string jpg = ".jpg";
            try
            {
                labelVectorTexture.BackColor = moduleLINES.LineTypes[LT].Color;
                labelVectorTexture.ForeColor = moduleMAIN.InvertColor(labelVectorTexture.BackColor);
                // labelVectorTexture.Text = VB6.GetItemString(listVector, LT - 1)
                labelVectorTexture.Text = listVector.GetItemText(LT - 1);
                A = My.MyProject.Application.Info.DirectoryPath + @"\Tools\Bmps\" + moduleLINES.LineTypes[LT].Texture + jpg;
                imgVector.Image = Image.FromFile(A);
                moduleMAIN.ImageFileName = A;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show(A);
            }
        }

        private void ShowThisExtrusionType(object LT)
        {
            string A;
            string jpg = ".jpg";
            string closejpg = "_close.jpg";
            Color C;
            try
            {
                C = moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Color;
                labelProfile.BackColor = C;
                C = moduleMAIN.InvertColor(C);
                labelProfile.ForeColor = C;
                labelProfile.Text = moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Profile;
                ProfileGuid = moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Profile;
                MaterialGuid = moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Material;
                PylonGuid = moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Pylon;
                ExtrusionWidth = moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Width;
                ExtrusionProbability = 0.5d;
                SuppressPlatform = true;
                Complexity = 2;
                A = My.MyProject.Application.Info.DirectoryPath + @"\Tools\Bmps\" + moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Name + jpg;
                imgExtrusion.Image = Image.FromFile(A);
                moduleMAIN.ImageFileName = My.MyProject.Application.Info.DirectoryPath + @"\Tools\Bmps\" + moduleLINES.ExtrusionTypes[Convert.ToInt32(LT)].Name + closejpg;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Image for Extrusion Bridge could not be used!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void GetExtrusionLine(int N)
        {
            string A;
            int J;
            A = moduleLINES.Lines[N].Type.Substring(4);
            J = A.IndexOf("|");
            MaterialGuid = A.Substring(0, J);
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            PylonGuid = A.Substring(0, J);
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            Complexity = Convert.ToInt32(A.Substring(0, J));
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            ExtrusionWidth = Convert.ToDouble(A.Substring(0, J));
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            ExtrusionProbability = Convert.ToDouble(A.Substring(0, J));
            A = A.Substring(J + 1);
            SuppressPlatform = Convert.ToBoolean(A);
            ckThisColor.BackColor = moduleLINES.Lines[N].Color;
            ckThisColor.ForeColor = moduleMAIN.InvertColor(moduleLINES.Lines[N].Color);
        }

        private void GetLineOfObjects(int N)
        {
            string A;
            int J;
            A = moduleLINES.Lines[N].Type.Substring(4);
            J = A.IndexOf("|");
            ObjWidth = Convert.ToSingle(A.Substring(0, J));
            A = A.Substring(J + 1);
            J = A.IndexOf("|");
            ObjLength = Convert.ToSingle(A.Substring(0, J));
            A = A.Substring(J + 1);
            cmbComplexity.SelectedIndex = Convert.ToInt32(A);
            double X = 0d;
            var loopTo = moduleLINES.Lines[N].NoOfPoints;
            for (J = 1; J <= loopTo; J++)
                X = X + moduleLINES.Lines[N].GLPoints[J].wid;
            txtHeading.Text = (X / moduleLINES.Lines[N].NoOfPoints).ToString("0.00");
            ckThisColor.BackColor = moduleLINES.Lines[N].Color;
            ckThisColor.ForeColor = moduleMAIN.InvertColor(moduleLINES.Lines[N].Color);
        }

        private void CheckIfFWX(int K)
        {
            string A, B;
            A = moduleLINES.LineTypes[K].Type;
            A = (A.Length < 3) ? "" : A.Substring(0, 3);
            if (A == "FWX")
            {
                EnableTraffic(true);
                B = moduleLINES.Lines[modulePOPUP.POPIndex].Type;
                B = (B.Length < 3) ? "" : B.Substring(0, 3);
                if (B == "FWX")
                {
                    cbLanes.Text = moduleLINES.Lines[modulePOPUP.POPIndex].Type.Substring(3, 1);
                    cbDir.Text = moduleLINES.Lines[modulePOPUP.POPIndex].Type.Substring(4, 1);
                }
            }
            else
            {
                EnableTraffic(false);
            }
        }

        private void EnableVectorLine(bool Flag)
        {
            Label5.Enabled = Flag;
            labelVectorTexture.Enabled = Flag;
            listVector.Enabled = Flag;
            imgVector.Enabled = Flag;
            cmdDetail.Enabled = Flag;
            EnableReverse(true);
        }

        private void EnableExtrusionLine(bool Flag)
        {
            lbguid.Enabled = Flag;
            labelProfile.Enabled = Flag;
            listExtrusion.Enabled = Flag;
            imgExtrusion.Enabled = Flag;
            lbExt1.Enabled = Flag;
            boxWidth.Enabled = Flag;
            EnableReverse(false);
            cmdExtrusionProperties.Enabled = Flag;
        }

        private void EnableTexturedLine(bool Flag)
        {

            // txtTexName.Enabled = Flag
            // cmdTex.Enabled = Flag
            // ckNight.Enabled = Flag

            boxTexType.Enabled = Flag;
            boxTexTexture.Enabled = Flag;
            imgTex.Enabled = Flag;


            // LbV1.Enabled = Flag
            // lbTexPri.Enabled = Flag
            // txtV1.Enabled = Flag
            // txtTexPri.Enabled = Flag
            // EnableReverse(False)

        }

        private void EnableLineOfObjects(bool Flag)
        {
            labelComplexity.Enabled = Flag;
            labelLibID.Enabled = Flag;
            labelCat.Enabled = Flag;
            boxHeading.Enabled = Flag;
            cmbComplexity.Enabled = Flag;
            cmbLibCat.Enabled = Flag;
            imgLib.Enabled = Flag;
            lstLib.Enabled = Flag;
            EnableReverse(false);
        }

        private void EnableWidthAndAltitude(bool flag)
        {
            boxWidth.Enabled = flag;
            boxProgressive.Enabled = flag;
            boxAltitude.Enabled = flag;
        }

        private void EnableReverse(bool flag)
        {
            cmdWinding.Enabled = flag;
            labelReverse.Enabled = flag;
        }

        private void EnableName(bool flag)
        {
            labelName.Enabled = flag;
            txtName.Enabled = flag;
        }

        private void EnableTraffic(bool Flag)
        {
            labelLanes.Enabled = Flag;
            cbLanes.Enabled = Flag;
            labelDir.Enabled = Flag;
            cbDir.Enabled = Flag;
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            int N;
            if (modulePOPUP.POPMode == "Many") // many to set
            {
                moduleMAIN.Dirty = true;
                var loopTo = moduleLINES.NoOfLines;
                for (N = 1; N <= loopTo; N++)
                {
                    if (moduleLINES.Lines[N].Selected)
                    {
                        SetThisLineProperties(N);
                    }
                }

                moduleMAIN.RebuildDisplay();
            }
            else if (modulePOPUP.POPMode == "SHP")
            {
                moduleSHAPE.ShapeLineGuid = moduleLINES.LineTypes[ThisLineType].Guid;
            }
            else if (modulePOPUP.POPMode == "SUR")
            {
                moduleSURFER.BLNLineGuid = moduleLINES.LineTypes[ThisLineType].Guid;
            }
            else
            {
                moduleMAIN.Dirty = true;
                moduleLINES.Lines[modulePOPUP.POPIndex].Name = txtName.Text;
                SetThisLineProperties(modulePOPUP.POPIndex);
                moduleMAIN.RebuildDisplay();
            }

            // this could be used when appending FWX lines
            moduleSHAPE.DefaultNoOfLanes = Convert.ToByte(cbLanes.SelectedItem);
            moduleSHAPE.DefaultTrafficDir = Convert.ToString(cbDir.SelectedItem);
            Init = true;
            modulePOPUP.POPIndex = 0;
            Dispose();
        }

        private void SetThisLineProperties(object N)
        {
            if (optVector.Checked)
            {
                SetThisVectorLineProperties(Convert.ToInt32(N));
            }
            else if (optExtrusion.Checked)
            {
                SetThisExtrusionLineProperties(Convert.ToInt32(N));
            }
            else if (optTexture.Checked)
            {
                SetThisTexturedLineProperties(Convert.ToInt32(N));
            }
            else if (optObjects.Checked)
            {
                SetThisLineOfObjectsProperties(Convert.ToInt32(N));
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Init = true;
            modulePOPUP.POPIndex = 0;
            Dispose();
        }

        private void CmdSample_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLPSample.ShowDialog();
        }

        private void CmdSmooth_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmLPSmooth.ShowDialog();
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

        private void CmdDetail_Click(object sender, EventArgs e)
        {
            if (moduleLINES.LineTypes[ThisLineType].TerrainIndex < 0)
            {
                MessageBox.Show("This type is not described in Terrain.cfg!");
                return;
            }

            string TerrainFile, A, B, C, Key;
            int N, Marker;
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

            Key = "[Texture." + moduleLINES.LineTypes[ThisLineType].TerrainIndex.ToString().Trim() + "]";
            FileSystem.FileOpen(2, TerrainFile, OpenMode.Input);
            N = (int)FileSystem.LOF(2);
            Marker = 0;
            F1 = false;
            B = "";
            while (Marker < N)
            {
                A = FileSystem.LineInput(2);
                Marker = Marker + A.Length + 2;
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

            MessageBox.Show(B, C, MessageBoxButtons.OK, MessageBoxIcon.Information);
            FileSystem.FileClose();
        }

        private void List1_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            if (Button == 2)
            {
                int LT;
                LT = listVector.SelectedIndex + 1;
                My.MyProject.Computer.Clipboard.SetText(moduleLINES.LineTypes[LT].Guid);
            }
        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            int LT;
            LT = listVector.SelectedIndex + 1;
            ShowThisVectorType(LT);
            CheckIfFWX(LT);
            ThisLineType = LT;
        }

        private void CmdWidth_Click(object sender, EventArgs e)
        {
            int N, K;
            double X;
            try
            {
                X = Convert.ToDouble(txtWidth.Text);
                if (modulePOPUP.POPMode == "One")
                {
                    var loopTo = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
                    for (K = 1; K <= loopTo; K++)
                        moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[K].wid = X;
                }
                else
                {
                    var loopTo1 = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            var loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                            for (K = 1; K <= loopTo2; K++)
                                moduleLINES.Lines[N].GLPoints[K].wid = X;
                        }
                    }
                }

                moduleMAIN.RebuildDisplay();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check width value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmdAlt_Click(object sender, EventArgs e)
        {
            int N, K;
            double X;
            try
            {
                X = Convert.ToDouble(txtAlt.Text);
                if (modulePOPUP.POPMode == "One")
                {
                    var loopTo = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
                    for (K = 1; K <= loopTo; K++)
                        moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[K].alt = X;
                }
                else
                {
                    var loopTo1 = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            var loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                            for (K = 1; K <= loopTo2; K++)
                                moduleLINES.Lines[N].GLPoints[K].alt = X;
                        }
                    }
                }

                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check altitude value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmdWidth12_Click(object sender, EventArgs e)
        {
            int N, K;
            double W1, W21, DW, W;

            try
            {
                W1 = Convert.ToDouble(txtWidth1.Text);
                W21 = Convert.ToDouble(txtWidth2.Text);
                W21 = W21 - W1;
                if (modulePOPUP.POPMode == "One")
                {
                    W = W1;
                    DW = W21 / (moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints - 1);
                    var loopTo = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
                    for (K = 1; K <= loopTo; K++)
                    {
                        moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[K].wid = W;
                        W = W + DW;
                    }
                }
                else
                {
                    var loopTo1 = moduleLINES.NoOfLines;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (moduleLINES.Lines[N].Selected)
                        {
                            W = W1;
                            DW = W21 / (moduleLINES.Lines[N].NoOfPoints - 1);
                            var loopTo2 = moduleLINES.Lines[N].NoOfPoints;
                            for (K = 1; K <= loopTo2; K++)
                            {
                                moduleLINES.Lines[N].GLPoints[K].wid = W;
                                W = W + DW;
                            }
                        }
                    }
                }

                moduleMAIN.RebuildDisplay();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check width values!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmdReverse_Click(object sender, EventArgs e)
        {
            int N;
            string A;
            A = txtWidth1.Text;
            txtWidth1.Text = txtWidth2.Text;
            txtWidth2.Text = A;
            if (modulePOPUP.POPMode == "One")
            {
                ReverseLine(modulePOPUP.POPIndex);
            }
            else
            {
                var loopTo = moduleLINES.NoOfLines;
                for (N = 1; N <= loopTo; N++)
                {
                    if (moduleLINES.Lines[N].Selected)
                        ReverseLine(N);
                }
            }

            moduleMAIN.RebuildDisplay();
        }

        private void ReverseLine(int N)
        {
            moduleLINES.GLine myLine;
            int K, NP;
            NP = moduleLINES.Lines[N].NoOfPoints;
            myLine.NoOfPoints = NP;
            myLine.GLPoints = new modulePOINTS.GLPoint[NP + 1];
            var loopTo = NP;
            for (K = 1; K <= loopTo; K++)
                // myLine.GLPoints(K).lon = Lines(N).GLPoints(K).lon
                // myLine.GLPoints(K).lat = Lines(N).GLPoints(K).lat
                // myLine.GLPoints(K).alt = Lines(N).GLPoints(K).alt
                myLine.GLPoints[K].wid = moduleLINES.Lines[N].GLPoints[K].wid;
            var loopTo1 = NP;
            for (K = 1; K <= loopTo1; K++)
                // Lines(N).GLPoints(K).lon = myLine.GLPoints(NP + 1 - K).lon
                // Lines(N).GLPoints(K).lat = myLine.GLPoints(NP + 1 - K).lat
                // Lines(N).GLPoints(K).alt = myLine.GLPoints(NP + 1 - K).alt
                moduleLINES.Lines[N].GLPoints[K].wid = myLine.GLPoints[NP + 1 - K].wid;
        }

        private void CmdWinding_Click(object sender, EventArgs e)
        {
            int N;
            if (modulePOPUP.POPMode == "One")
            {
                ChangeWinding(modulePOPUP.POPIndex);
            }
            else
            {
                var loopTo = moduleLINES.NoOfLines;
                for (N = 1; N <= loopTo; N++)
                {
                    if (moduleLINES.Lines[N].Selected)
                        ChangeWinding(N);
                }
            }

            moduleMAIN.RebuildDisplay();
        }

        private void ChangeWinding(int N)
        {
            moduleLINES.GLine myLine;
            int K, NP;
            NP = moduleLINES.Lines[N].NoOfPoints;
            myLine.NoOfPoints = NP;
            myLine.GLPoints = new modulePOINTS.GLPoint[NP + 1];
            var loopTo = NP;
            for (K = 1; K <= loopTo; K++)
            {
                myLine.GLPoints[K].lon = moduleLINES.Lines[N].GLPoints[K].lon;
                myLine.GLPoints[K].lat = moduleLINES.Lines[N].GLPoints[K].lat;
                myLine.GLPoints[K].alt = moduleLINES.Lines[N].GLPoints[K].alt;
                myLine.GLPoints[K].wid = moduleLINES.Lines[N].GLPoints[K].wid;
            }

            var loopTo1 = NP;
            for (K = 1; K <= loopTo1; K++)
            {
                moduleLINES.Lines[N].GLPoints[K].lon = myLine.GLPoints[NP + 1 - K].lon;
                moduleLINES.Lines[N].GLPoints[K].lat = myLine.GLPoints[NP + 1 - K].lat;
                moduleLINES.Lines[N].GLPoints[K].alt = myLine.GLPoints[NP + 1 - K].alt;
                moduleLINES.Lines[N].GLPoints[K].wid = myLine.GLPoints[NP + 1 - K].wid;
            }
        }

        private void ListExtrusion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            int LT;
            LT = listExtrusion.SelectedIndex + 1;
            if (!(ThisExtrusionType == LT))
            {
                ThisExtrusionType = LT;
                ShowThisExtrusionType(LT);
            }
        }

        private void ImgExtrusion_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmImage.ShowDialog();
        }

        private void OptVector_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(sender.GetType().GetField("Checked")))
            {
                if (Init)
                    return;
                EnableTexturedLine(false);
                EnableExtrusionLine(false);
                EnableLineOfObjects(false);
                EnableWidthAndAltitude(true);
                EnableVectorLine(true);
                TabControl1.SelectedIndex = 1;
            }
        }

        private void OptTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(sender.GetType().GetField("Checked")))
            {
                if (Init)
                    return;
                EnableVectorLine(false);
                EnableExtrusionLine(false);
                EnableLineOfObjects(false);
                EnableWidthAndAltitude(true);
                EnableTexturedLine(true);
                TabControl1.SelectedIndex = 2;
            }
        }

        private void OptExtrusion_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(sender.GetType().GetField("Checked")))
            {
                if (Init)
                    return;
                EnableVectorLine(false);
                EnableTexturedLine(false);
                EnableLineOfObjects(false);
                EnableWidthAndAltitude(false);
                boxAltitude.Enabled = true;
                EnableExtrusionLine(true);
                TabControl1.SelectedIndex = 3;
            }
        }

        private void OptObjects_CheckedChanged(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(sender.GetType().GetField("Checked")))
            {
                if (Init)
                    return;
                EnableVectorLine(false);
                EnableTexturedLine(false);
                EnableExtrusionLine(false);
                EnableLineOfObjects(true);
                EnableWidthAndAltitude(false);
                boxAltitude.Enabled = true;
                TabControl1.SelectedIndex = 4;
            }
        }

        private void CmdType_Click(object sender, EventArgs e)
        {
            if (optVector.Checked)
                TabControl1.SelectedIndex = 1;
            if (optTexture.Checked)
                TabControl1.SelectedIndex = 2;
            if (optExtrusion.Checked)
                TabControl1.SelectedIndex = 3;
            if (optObjects.Checked)
                TabControl1.SelectedIndex = 4;
        }

        private void CmdExtrusionProperties_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmExtrusions.ShowDialog();
        }

        private void CmdTex_Click(object sender, EventArgs e)
        {
            string A, B;
            string Tex = "";
            A = "FSX Texture File (*.BMP)|*.BMP";
            B = "SBuilderX: Open Texture File";
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
                    B = "This file already exists in the ../SBuilderX/Texture" + Environment.NewLine;
                    B = B + "folder and it will be overwriten! Do you want to continue?";
                    if (Interaction.MsgBox(B, MsgBoxStyle.YesNo) == MsgBoxResult.No)
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
            catch (Exception ex)
            {
                MessageBox.Show("The file could not be loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ShowLineTex(Tex);
        }

        private void ShowLineTex(string Tex)
        {
            if (string.IsNullOrEmpty(Tex))
                return;
            try
            {
                FileSystem.ChDrive(My.MyProject.Application.Info.DirectoryPath);
                FileSystem.ChDir(My.MyProject.Application.Info.DirectoryPath + @"\Tools\");
                string ImageTool;
                // Dim BmpPath As String = AppPath & "\Tools\Work\temp.bmp"
                string BmpPath = moduleMAIN.AppPath + @"\Tools\Work\" + Tex;
                txtTexName.Text = Tex;
                string TexPath = moduleMAIN.AppPath + @"\Texture\" + Tex;
                if (My.MyProject.Computer.FileSystem.FileExists(TexPath))
                {
                    // ImageTool = "imagetool -nogui -nomip -32 Work\temp.bmp"
                    ImageTool = @"imagetool -nogui -nomip -32 Work\" + Tex;
                    File.Copy(TexPath, BmpPath, true);
                    moduleMAIN.ExecCmd(ImageTool);
                }
                else
                {
                    FileSystem.FileCopy(moduleMAIN.AppPath + @"\Tools\BMPs\none.jpg", BmpPath);
                }

                var bmp = Image.FromFile(BmpPath);
                int width = bmp.Width;
                int height = imgTex.Height;
                var thumb = new Bitmap(width, height);
                var g = Graphics.FromImage(thumb);
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(bmp, new Rectangle(0, 0, width, height), new Rectangle(0, 0, bmp.Width, bmp.Height), GraphicsUnit.Pixel);
                g.Dispose();
                bmp.Dispose();
                imgTex.BackgroundImage = thumb;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is a problem with the display of this image!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {
            optVector.Checked = true;
        }

        private void TabPage3_Click(object sender, EventArgs e)
        {
            if (modulePOPUP.POPMode == "SHP" | modulePOPUP.POPMode == "SUR" | modulePOPUP.POPMode == "Many")
                return;
            optTexture.Checked = true;
        }

        private void TabPage4_Click(object sender, EventArgs e)
        {
            if (modulePOPUP.POPMode == "SHP" | modulePOPUP.POPMode == "SUR" | modulePOPUP.POPMode == "Many")
                return;
            optExtrusion.Checked = true;
        }

        private void TabPage5_Click(object sender, EventArgs e)
        {
            if (modulePOPUP.POPMode == "SHP" | modulePOPUP.POPMode == "SUR" | modulePOPUP.POPMode == "Many")
                return;
            optObjects.Checked = true;
        }

        private void OptTile_CheckedChanged(object sender, EventArgs e)
        {
            if (optTile.Checked | optFull.Checked)
            {
                imgTex.BackgroundImageLayout = ImageLayout.Tile;
            }
            else
            {
                imgTex.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void OptStretch_CheckedChanged(object sender, EventArgs e)
        {
            if (optTile.Checked | optFull.Checked)
            {
                imgTex.BackgroundImageLayout = ImageLayout.Tile;
            }
            else
            {
                imgTex.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void OptLying_CheckedChanged(object sender, EventArgs e)
        {
            if (optLying.Checked)
            {
                lbTexPri.Enabled = true;
                txtTexPri.Enabled = true;
                LbV1.Enabled = true;
                txtV1.Enabled = true;
            }
            else
            {
                lbTexPri.Enabled = false;
                txtTexPri.Enabled = false;
                LbV1.Enabled = false;
                txtV1.Enabled = false;
            }
        }

        private void LstLib_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            int N, K;
            string a, LibCat;

            // get the category index
            K = cmbLibCat.SelectedIndex + 1;
            LibCat = moduleOBJECTS.LibCategories[K].Name;
            N = lstLib.SelectedIndex;
            var myLibObj = moduleOBJECTS.LibCategories[K].Objs[N];
            labelLibID.Text = myLibObj.ID;
            ObjWidth = myLibObj.Width;
            ObjLength = myLibObj.Length;
            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + labelLibID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            imgLib.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
        }

        private void CmbLibCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            int K;
            string a, LibCat;

            // first remove all listings
            lstLib.Items.Clear();

            // get the category index
            K = cmbLibCat.SelectedIndex + 1;
            foreach (var g in moduleOBJECTS.LibCategories[K].Objs)
                lstLib.Items.Add(g.Name);
            if (moduleOBJECTS.LibCategories[K].Objs.Count == 0)
            {
                labelLibID.Text = "";
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
                imgLib.Image = Image.FromFile(a);
                moduleMAIN.ImageFileName = a;
                return;
            }

            LibCat = moduleOBJECTS.LibCategories[K].Name;
            var myLibObj = moduleOBJECTS.LibCategories[K].Objs[0];
            lstLib.SelectedIndex = 0;
            labelLibID.Text = myLibObj.ID;
            ObjWidth = myLibObj.Width;
            ObjLength = myLibObj.Length;
            a = moduleOBJECTS.LibObjectsPath + @"\" + LibCat + @"\" + labelLibID.Text + ".jpg";
            moduleMAIN.ImageFileNameTrue = a;
            if (!File.Exists(a))
            {
                a = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\none.jpg";
            }

            var fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            imgLib.Image = Image.FromStream(fs);
            fs.Close();
            moduleMAIN.ImageFileName = a;
        }

        private void CkRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (ckRandom.CheckState == CheckState.Checked)
            {
                txtHeading.Enabled = false;
            }
            else
            {
                txtHeading.Enabled = true;
            }
        }

        private void CmdHeading_Click(object sender, EventArgs e)
        {
            double W = Convert.ToDouble(txtHeading.Text);
            int K;
            if (ckRandom.Checked)
                VBMath.Randomize();
            var loopTo = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
            {
                if (ckRandom.Checked == false)
                {
                    moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[K].wid = W;
                }
                else
                {
                    moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[K].wid = 360f * VBMath.Rnd();
                }
            }

            moduleMAIN.RebuildDisplay();
        }
    }
}