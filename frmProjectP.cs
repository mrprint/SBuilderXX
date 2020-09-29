using System;
using System.Drawing;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmProjectP
    {
        public FrmProjectP()
        {
            InitializeComponent();
            _cmdBGL.Name = "cmdBGL";
            _lbClassItem.Name = "lbClassItem";
            _lstClassItems.Name = "lstClassItems";
            _cmdClassIndexDelete.Name = "cmdClassIndexDelete";
            _cmdClassIndexEdit.Name = "cmdClassIndexEdit";
            _cmdClassIndexAdd.Name = "cmdClassIndexAdd";
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
        }

        private bool DoBackUp;
        private bool DoCenter;
        private short MouseButton;

        private void FrmProjectP_Load(object sender, EventArgs e)
        {
            int N;
            lbMaps.Text = "Maps = " + moduleMAPS.NoOfMaps;
            lbLines.Text = "Lines = " + moduleLINES.NoOfLines;
            lbPolys.Text = "Polys = " + modulePOLYS.NoOfPolys;
            lbWaters.Text = "Waters = " + moduleCLASSES.NoOfWaters;
            lbObjects.Text = "Objects = " + moduleOBJECTS.NoOfObjects;
            lbExcludes.Text = "Excludes = " + moduleEXCLUDES.NoOfExcludes;
            lbLands.Text = "Lands = " + moduleCLASSES.NoOfLands;
            txtName.Text = moduleMAIN.ProjectName;
            txtBGLFolder.Text = moduleMAIN.BGLProjectFolder;
            int loopTo = moduleCLASSES.NoOfLWCIs;
            for (N = 1; N <= loopTo; N++)
                lstClassItems.Items.Add(moduleCLASSES.LWCIs[N].Text);
            N = moduleCLASSES.NoOfLWCIs;
            if (N > 0)
            {
                // lbClassItem.Text = VB6.GetItemString(lstClassItems, N - 1)
                lbClassItem.Text = lstClassItems.GetItemText(N - 1);
                lbClassItem.BackColor = moduleCLASSES.LWCIs[N].Color;
                lbClassItem.ForeColor = moduleMAIN.InvertColor(moduleCLASSES.LWCIs[N].Color);
                lstClassItems.SelectedIndex = N - 1;
            }

            DoBackUp = false;
            DoCenter = false;
        }

        private void CmdOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            if (DoBackUp)
                moduleEDIT.BackUp();
            moduleMAIN.ProjectName = txtName.Text;
            My.MyProject.Forms.FrmStart.Text = moduleMAIN.AppTitle + "  " + moduleMAIN.ProjectName.ToUpper();
            if (!string.IsNullOrEmpty(txtBGLFolder.Text))
                moduleMAIN.BGLProjectFolder = txtBGLFolder.Text;
            moduleMAIN.CheckFolders();
            if (ckBGLFolder.Checked)
            {
                moduleMAIN.BGLFolder = moduleMAIN.BGLProjectFolder;
                string argPutKey = "Main";
                string argPutVariable = "BGLFolder";
                string argPutValue = moduleMAIN.BGLFolder;
                moduleFILE_IO.WriteIniValue(ref moduleMAIN.AppIni, ref argPutKey, ref argPutVariable, ref argPutValue);
            }

            ckBGLFolder.Checked = false;
            moduleMAIN.ViewON = true;
            moduleMAIN.RebuildDisplay();
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void CmdBGL_Click(object sender, EventArgs e)
        {
            string A = "Choose the Scenery Folder where BGL Files are copied into.";
            My.MyProject.Forms.FrmStart.FolderBrowserDialog1.Description = A;
            if (My.MyProject.Forms.FrmStart.FolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBGLFolder.Text = My.MyProject.Forms.FrmStart.FolderBrowserDialog1.SelectedPath;
            }
        }

        private void CmdClassIndexAdd_Click(object sender, EventArgs e)
        {
            moduleMAIN.Zoom = 1;
            string A, B;
            bool IsLand = default;
            int N2, N, N1;
            byte P0, P1, P2, P3;

            try
            {
                A = "Each definition starts either with the word Land or Water and then 3 numbers ";
                A = A + "separated by spaces. You can also add text at the end ";
                A = A + "as in the example. The 3 numbers refer to 3 classes ";
                A = A + "and the definition is assigned to a color. ";
                A = A + "Whenever this color is found on a Class Map, the 1st class is used 60% of the time, the 2nd ";
                A = A + "class 25% and the 3rd class 15%. You can mix Land and Water definitions.";
                A = Utilities.InputBox("", A, "Land 101 102 103 City Textures").Trim() + " ";
                N2 = A.IndexOf(" ");
                B = A.Substring(0, N2).ToUpper();
                if (B == "LAND")
                {
                    IsLand = true;
                }
                else if (B == "WATER")
                {
                    IsLand = false;
                }
                else
                {
                    throw new Exception();
                }

                N1 = N2 + 1;
                N2 = A.IndexOf(" ", N1);
                P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                if (IsLand)
                {
                    int loopTo = moduleCLASSES.NoOfLCs;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (P0 == moduleCLASSES.LC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfLCs)
                        throw new Exception();
                }
                else
                {
                    int loopTo1 = moduleCLASSES.NoOfWCs;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (P0 == moduleCLASSES.WC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfWCs)
                        throw new Exception();
                }

                P1 = (byte)N;
                N1 = N2 + 1;
                N2 = A.IndexOf(" ", N1);
                P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                if (IsLand)
                {
                    int loopTo2 = moduleCLASSES.NoOfLCs;
                    for (N = 1; N <= loopTo2; N++)
                    {
                        if (P0 == moduleCLASSES.LC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfLCs)
                        throw new Exception();
                }
                else
                {
                    int loopTo3 = moduleCLASSES.NoOfWCs;
                    for (N = 1; N <= loopTo3; N++)
                    {
                        if (P0 == moduleCLASSES.WC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfWCs)
                        throw new Exception();
                }

                P2 = (byte)N;
                N1 = N2 + 1;
                N2 = A.IndexOf(" ", N1);
                P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                if (IsLand)
                {
                    int loopTo4 = moduleCLASSES.NoOfLCs;
                    for (N = 1; N <= loopTo4; N++)
                    {
                        if (P0 == moduleCLASSES.LC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfLCs)
                        throw new Exception();
                }
                else
                {
                    int loopTo5 = moduleCLASSES.NoOfWCs;
                    for (N = 1; N <= loopTo5; N++)
                    {
                        if (P0 == moduleCLASSES.WC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfWCs)
                        throw new Exception();
                }

                P3 = (byte)N;
                moduleEDIT.BackUp();
                if (moduleCLASSES.NoOfLWCIs == 0)
                {
                    moduleCLASSES.NoOfLWCIs = 1;
                }
                else
                {
                    moduleCLASSES.NoOfLWCIs = moduleCLASSES.NoOfLWCIs + 1;
                    Array.Resize(ref moduleCLASSES.LWCIs, moduleCLASSES.NoOfLWCIs + 1);
                }

                N = moduleCLASSES.NoOfLWCIs;
                moduleCLASSES.LWCIs[N].Class1 = P1;
                moduleCLASSES.LWCIs[N].Class2 = P2;
                moduleCLASSES.LWCIs[N].Class3 = P3;
                if (IsLand)
                {
                    moduleCLASSES.LWCIs[N].Color = Color.GreenYellow;
                    moduleCLASSES.LWCIs[N].IsLand = true;
                }
                else
                {
                    moduleCLASSES.LWCIs[N].Color = Color.Blue;
                    moduleCLASSES.LWCIs[N].IsLand = false;
                }

                moduleCLASSES.LWCIs[N].Text = A;
                lstClassItems.Items.Add(A);
                // lbClassItem.Text = VB6.GetItemString(lstClassItems, N - 1)
                lbClassItem.Text = lstClassItems.GetItemText(N - 1);
                lbClassItem.BackColor = moduleCLASSES.LWCIs[N].Color;
                lbClassItem.ForeColor = moduleMAIN.InvertColor(moduleCLASSES.LWCIs[N].Color);
                moduleMAIN.Dirty = true;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your entry!");
            }
        }

        private void CmdClassIndexDelete_Click(object sender, EventArgs e)
        {
            int N, K;
            if (moduleCLASSES.NoOfLWCIs == 0)
                return;
            moduleEDIT.BackUp();
            if (moduleCLASSES.NoOfLWCIs == 1)
            {
                moduleCLASSES.NoOfLWCIs = 0;
                lstClassItems.Items.RemoveAt(0);
                lbClassItem.Text = "";
                lbClassItem.BackColor = Color.FromArgb(255, 255, 255);
                return;
            }

            N = lstClassItems.SelectedIndex + 1;
            if (N == moduleCLASSES.NoOfLWCIs)
            {
                Array.Resize(ref moduleCLASSES.LWCIs, N);
                moduleCLASSES.NoOfLWCIs = moduleCLASSES.NoOfLWCIs - 1;
                lstClassItems.Items.RemoveAt(N - 1);
                lstClassItems.SelectedIndex = N - 2;
                // lstClassItems_SelectedIndexChanged(lstClassItems, New System.EventArgs())
                return;
            }

            int loopTo = moduleCLASSES.NoOfLWCIs - 1;
            for (K = N; K <= loopTo; K++)
            {
                moduleCLASSES.LWCIs[K].Class1 = moduleCLASSES.LWCIs[K + 1].Class1;
                moduleCLASSES.LWCIs[K].Class2 = moduleCLASSES.LWCIs[K + 1].Class2;
                moduleCLASSES.LWCIs[K].Class3 = moduleCLASSES.LWCIs[K + 1].Class3;
                moduleCLASSES.LWCIs[K].Color = moduleCLASSES.LWCIs[K + 1].Color;
                moduleCLASSES.LWCIs[K].IsLand = moduleCLASSES.LWCIs[K + 1].IsLand;
                moduleCLASSES.LWCIs[K].Text = moduleCLASSES.LWCIs[K + 1].Text;
            }

            moduleCLASSES.NoOfLWCIs = moduleCLASSES.NoOfLWCIs - 1;
            Array.Resize(ref moduleCLASSES.LWCIs, moduleCLASSES.NoOfLWCIs + 1);
            lstClassItems.Items.RemoveAt(N - 1);
            lstClassItems.SelectedIndex = N - 1;
            // lstClassItems_SelectedIndexChanged(lstClassItems, New System.EventArgs())

            moduleMAIN.Dirty = true;
        }

        private void CmdClassIndexEdit_Click(object sender, EventArgs e)
        {
            string A, B;
            int P2, N2, N, N1, P1, P3;
            byte P0;
            int N0;
            bool IsLand = default;

            try
            {
                if (moduleCLASSES.NoOfLWCIs == 0)
                    return;
                N0 = lstClassItems.SelectedIndex + 1;
                A = "Each definition starts either with the word Land or Water and then 3 numbers ";
                A = A + "separated by spaces. You can also add text at the end ";
                A = A + "as in the example. The 3 numbers refer to 3 classes ";
                A = A + "and the definition is assigned to a color. ";
                A = A + "Whenever this color is found on a Class Map, the 1st class is used 60% of the time, the 2nd ";
                A = A + "class 25% and the 3rd class 15%. You can mix Land and Water definitions.";
                A = Utilities.InputBox("", A, moduleCLASSES.LWCIs[N0].Text).Trim() + " ";
                N2 = A.IndexOf(" ");
                B = A.Substring(0, N2).ToUpper();
                if (B == "LAND")
                {
                    IsLand = true;
                }
                else if (B == "WATER")
                {
                    IsLand = false;
                }
                else
                {
                    throw new Exception();
                }

                N1 = N2 + 1;
                N2 = A.IndexOf(" ", N1);
                P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                if (IsLand)
                {
                    int loopTo = moduleCLASSES.NoOfLCs;
                    for (N = 1; N <= loopTo; N++)
                    {
                        if (P0 == moduleCLASSES.LC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfLCs)
                        throw new Exception();
                }
                else
                {
                    int loopTo1 = moduleCLASSES.NoOfWCs;
                    for (N = 1; N <= loopTo1; N++)
                    {
                        if (P0 == moduleCLASSES.WC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfWCs)
                        throw new Exception();
                }

                P1 = (byte)N;
                N1 = N2 + 1;
                N2 = A.IndexOf(" ", N1);
                P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                if (IsLand)
                {
                    int loopTo2 = moduleCLASSES.NoOfLCs;
                    for (N = 1; N <= loopTo2; N++)
                    {
                        if (P0 == moduleCLASSES.LC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfLCs)
                        throw new Exception();
                }
                else
                {
                    int loopTo3 = moduleCLASSES.NoOfWCs;
                    for (N = 1; N <= loopTo3; N++)
                    {
                        if (P0 == moduleCLASSES.WC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfWCs)
                        throw new Exception();
                }

                P2 = (byte)N;
                N1 = N2 + 1;
                N2 = A.IndexOf(" ", N1);
                P0 = Convert.ToByte(A.Substring(N1, N2 - N1));
                if (IsLand)
                {
                    int loopTo4 = moduleCLASSES.NoOfLCs;
                    for (N = 1; N <= loopTo4; N++)
                    {
                        if (P0 == moduleCLASSES.LC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfLCs)
                        throw new Exception();
                }
                else
                {
                    int loopTo5 = moduleCLASSES.NoOfWCs;
                    for (N = 1; N <= loopTo5; N++)
                    {
                        if (P0 == moduleCLASSES.WC[N].Index)
                            break;
                    }

                    if (N > moduleCLASSES.NoOfWCs)
                        throw new Exception();
                }

                P3 = (byte)N;
                moduleEDIT.BackUp();
                moduleCLASSES.LWCIs[N0].Class1 = (byte)P1;
                moduleCLASSES.LWCIs[N0].Class2 = (byte)P2;
                moduleCLASSES.LWCIs[N0].Class3 = (byte)P3;
                moduleCLASSES.LWCIs[N0].Text = A;
                moduleCLASSES.LWCIs[N0].IsLand = IsLand;

                // VB6.SetItemString(lstClassItems, N0 - 1, A)
                lstClassItems.Items[N0 - 1] = A;
                lbClassItem.Text = A;
                moduleMAIN.Dirty = true;
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Please check your entry!");
            }
        }

        private void LstClassItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N;
            N = lstClassItems.SelectedIndex + 1;

            // lbClassItem.Text = VB6.GetItemString(lstClassItems, N - 1)
            lbClassItem.Text = lstClassItems.GetItemText(N - 1);
            lbClassItem.BackColor = moduleCLASSES.LWCIs[N].Color;
            lbClassItem.ForeColor = moduleMAIN.InvertColor(moduleCLASSES.LWCIs[N].Color);
        }

        private void LbClassItem_Click(object sender, EventArgs e)
        {
            if (moduleCLASSES.NoOfLWCIs == 0)
                return;
            if (MouseButton == 1)
            {
                ColorFromPalette();
                return;
            }

            if (MouseButton == 2)
            {
                My.MyProject.Forms.FrmStart.PointerToolStripButton.PerformClick();
                My.MyProject.Forms.FrmStart.SetMouseIcon();
                moduleCLASSES.LColPickON = true;
                Hide();
            }
        }

        private void LbClassItem_MouseDown(object sender, MouseEventArgs e)
        {
            short Button = (short)((int)e.Button / 0x100000);
            if (moduleCLASSES.NoOfLWCIs == 0)
                return;
            if (Button == 2)
            {
                MouseButton = 2;
                return;
            }

            if (Button == 1)
            {
                MouseButton = 1;
            }
        }

        private void ColorFromPalette()
        {
            moduleMAIN.ARGBColor = lbClassItem.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                lbClassItem.BackColor = moduleMAIN.ARGBColor;
            }

            int N;
            N = lstClassItems.SelectedIndex + 1;
            moduleCLASSES.LWCIs[N].Color = moduleMAIN.ARGBColor;
            lbClassItem.ForeColor = moduleMAIN.InvertColor(moduleMAIN.ARGBColor);
            moduleEDIT.BackUp();
            moduleMAIN.Dirty = true;
        }
    }
}