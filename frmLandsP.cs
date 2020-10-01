using System;
using System.Drawing;
using System.Windows.Forms;

namespace SBuilderXX
{
    internal partial class FrmLandsP
    {
        public FrmLandsP()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdClose.Name = "cmdClose";
            _List1.Name = "List1";
            _cmdAuto.Name = "cmdAuto";
            _cmdEdit.Name = "cmdEdit";
            _lbLand.Name = "lbLand";
            _ImgText.Name = "ImgText";
            _ck4.Name = "ck4";
            _ck2.Name = "ck2";
            _ck1.Name = "ck1";
            _optDelete.Name = "optDelete";
            _optRaster.Name = "optRaster";
            _optClick.Name = "optClick";
        }

        private byte EntryLC;

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmProjectP.Show();
            My.MyProject.Forms.FrmProjectP.TabControl1.SelectTab(1);
        }

        private void CmdAuto_Click(object sender, EventArgs e)
        {
            int N;
            string A;
            bool Flag = false;
            if (moduleMAPS.NoOfMaps == 0)
                return;
            moduleMAIN.WAIT = true;
            Cursor = Cursors.WaitCursor;
            int loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                A = (moduleMAPS.Maps[N].Name.Length < 5) ? "" : moduleMAPS.Maps[N].Name.Substring(0, 5).ToUpper();
                if (A != "CLASS")
                    goto NextMap;
                moduleCLASSES.FillLand(N);
                Flag = true;
            NextMap:
                ;
            }

            Cursor = Cursors.Arrow;
            moduleMAIN.WAIT = false;
            moduleMAIN.Dirty = true;
            moduleMAIN.RebuildDisplay();
            if (Flag)
            {
                MessageBox.Show("Class Maps have been processed!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No Class Map was found!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            moduleCLASSES.DefaultLC = EntryLC;
            Dispose();
        }

        private void FrmLandsP_Load(object sender, EventArgs e)
        {
            string A;
            int N;
            string jpg = ".jpg";
            moduleCLASSES.LandWaterDELETE = false;
            moduleCLASSES.LandWaterRASTER = false;

            // SetLWCIs()

            int loopTo = moduleCLASSES.NoOfLCs;
            for (N = 1; N <= loopTo; N++)
                List1.Items.Add(moduleCLASSES.LC[N].Caption);
            EntryLC = moduleCLASSES.DefaultLC;
            N = moduleCLASSES.DefaultLC;
            lbLand.Text = List1.GetItemText(N - 1);
            lbLand.BackColor = moduleCLASSES.LC[N].Color;
            lbLand.ForeColor = moduleMAIN.InvertColor(moduleCLASSES.LC[N].Color);
            A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + moduleCLASSES.LC[N].Texture + jpg;
            ImgText.Image = Image.FromFile(A);
            moduleMAIN.ImageFileName = A;

            // If Not PolyViewer Then lbPolyViewer.Text = vbCrLf & "PolyView not detected!"

        }

        // Public Sub ShowLandProperty(ByVal POPIndex)

        // Dim N, J, K, C, R As Integer
        // Dim A As String

        // N = POPIndex
        // R = N Mod 512
        // N = N >> 9
        // C = N Mod 512
        // N = N >> 6
        // K = N Mod 64
        // N = N >> 7
        // J = N Mod 128

        // N = CInt(LLands(C, R, LL_XY(J, K).Pointer) And 127)

        // DefaultLC = CByte(N)

        // lbLand.Text = VB6.GetItemString(List1, N - 1)
        // List1.SelectedIndex = N - 1

        // lbLand.BackColor = LC(N).Color

        // lbLand.ForeColor = InvertColor(LC(N).Color)

        // A = My.Application.Info.DirectoryPath & "\tools\bmps\" & LC(N).Texture & ".jpg"
        // ImgText.Image = System.Drawing.Image.FromFile(A)



        // End Sub

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N;
            string A;
            string jpg = ".jpg";
            N = List1.SelectedIndex + 1;
            moduleCLASSES.DefaultLC = (byte)N;
            lbLand.Text = List1.GetItemText(N - 1);
            lbLand.BackColor = moduleCLASSES.LC[N].Color;
            lbLand.ForeColor = moduleMAIN.InvertColor(moduleCLASSES.LC[N].Color);
            A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + moduleCLASSES.LC[N].Texture + jpg;
            ImgText.Image = Image.FromFile(A);
            moduleMAIN.ImageFileName = A;
        }

        private void SetOptions()
        {
            if (optClick.Checked)
            {
                moduleCLASSES.LandWaterDELETE = false;
                moduleCLASSES.LandWaterRASTER = false;
            }

            if (optRaster.Checked)
            {
                moduleCLASSES.LandWaterDELETE = false;
                moduleCLASSES.LandWaterRASTER = true;
            }

            if (optDelete.Checked)
            {
                moduleCLASSES.LandWaterDELETE = true;
                moduleCLASSES.LandWaterRASTER = false;
            }
        }

        private void OptClick_CheckedChanged(object sender, EventArgs e)
        {
            SetOptions();
        }

        private void OptRaster_CheckedChanged(object sender, EventArgs e)
        {
            SetOptions();
        }

        private void OptDelete_CheckedChanged(object sender, EventArgs e)
        {
            SetOptions();
        }

        private void Ck1_CheckedChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        private void Ck2_CheckedChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        private void Ck4_CheckedChanged(object sender, EventArgs e)
        {
            SetSize();
        }

        private void SetSize()
        {
            if (ck1.Checked)
                moduleCLASSES.BrushSize = 1;
            if (ck2.Checked)
                moduleCLASSES.BrushSize = 2;
            if (ck4.Checked)
                moduleCLASSES.BrushSize = 4;
        }

        private void LbLand_Click(object sender, EventArgs e)
        {
            moduleMAIN.ARGBColor = lbLand.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                lbLand.BackColor = moduleMAIN.ARGBColor;
            }
        }

        private void ImgText_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmImage.ShowDialog();
        }
    }
}