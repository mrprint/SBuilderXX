using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmTerrainExclude
    {
        public FrmTerrainExclude()
        {
            InitializeComponent();
            _List.Name = "List";
            _cmdDetail.Name = "cmdDetail";
            _Cancel_Button.Name = "Cancel_Button";
            _OK_Button.Name = "OK_Button";
        }

        private string Guid;
        private int Index;
        private bool Init = true;

        private void OK_Button_Click(object sender, EventArgs e)
        {
            string name;
            int LT;
            LT = List.SelectedIndex + 1;
            // name = VB6.GetItemString(List, LT - 1)
            name = List.GetItemText(LT - 1);
            GetGuidAndIndex(name);
            modulePOLYS.ParticularExcludeGUID = Guid;
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void CmdDetail_Click(object sender, EventArgs e)
        {
            string name;
            int LT;
            LT = List.SelectedIndex + 1;

            // name = VB6.GetItemString(List, LT - 1)
            name = List.GetItemText(LT - 1);
            GetGuidAndIndex(name);
            if (Index < 0)
            {
                MessageBox.Show("This type is not described in Terrain.cfg!");
                return;
            }

            if (!moduleMAIN.IsFSX)
            {
                MessageBox.Show("Terrain.cfg could not be found!");
                return;
            }

            string TerrainFile, A, B, Key;
            int N, Marker;
            bool F1;
            TerrainFile = moduleMAIN.FSPath + "Terrain.cfg";
            Key = "[Texture." + Index.ToString().Trim() + "]";
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

            MessageBox.Show(B, "Description from Terrain.cfg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FileSystem.FileClose();
        }

        private void FrmTerrainExclude_Load(object sender, EventArgs e)
        {
            List.Items.Clear();
            int N, K, LT;
            LT = 1;
            K = 0;
            int loopTo = modulePOLYS.NoOfPolyTypes;
            for (N = moduleMAIN.PolyInit; N <= loopTo; N++)
            {
                K = K + 1;
                List.Items.Add(modulePOLYS.PolyTypes[N].Name);
                if ((modulePOLYS.PolyTypes[N].Guid ?? "") == (modulePOLYS.ParticularExcludeGUID ?? ""))
                    LT = K;
            }

            int loopTo1 = moduleLINES.NoOfLineTypes;
            for (N = moduleMAIN.LineInit; N <= loopTo1; N++)
            {
                K = K + 1;
                List.Items.Add(moduleLINES.LineTypes[N].Name);
                if ((moduleLINES.LineTypes[N].Guid ?? "") == (modulePOLYS.ParticularExcludeGUID ?? ""))
                    LT = K;
            }

            List.SelectedIndex = LT - 1;
            Init = false;
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            int LT;
            LT = List.SelectedIndex + 1;
            // lbTex.Text = VB6.GetItemString(List, LT - 1)
            lbTex.Text = List.GetItemText(LT - 1);
        }

        private void GetGuidAndIndex(string name)
        {
            int N;
            Guid = "{00000000-0000-0000-0000-000000000000}";
            Index = -1;
            int loopTo = modulePOLYS.NoOfPolyTypes;
            for (N = moduleMAIN.PolyInit; N <= loopTo; N++)
            {
                if ((modulePOLYS.PolyTypes[N].Name ?? "") == (name ?? ""))
                {
                    Guid = modulePOLYS.PolyTypes[N].Guid;
                    Index = modulePOLYS.PolyTypes[N].TerrainIndex;
                    return;
                }
            }

            int loopTo1 = moduleLINES.NoOfLineTypes;
            for (N = moduleMAIN.LineInit; N <= loopTo1; N++)
            {
                if ((moduleLINES.LineTypes[N].Name ?? "") == (name ?? ""))
                {
                    Guid = moduleLINES.LineTypes[N].Guid;
                    Index = moduleLINES.LineTypes[N].TerrainIndex;
                    return;
                }
            }
        }
    }
}