using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    internal partial class FrmWatersP
    {
        public FrmWatersP()
        {
            InitializeComponent();
            _optDelete.Name = "optDelete";
            _optRaster.Name = "optRaster";
            _optClick.Name = "optClick";
            _ck4.Name = "ck4";
            _ck2.Name = "ck2";
            _ck1.Name = "ck1";
            _cmdCancel.Name = "cmdCancel";
            _cmdClose.Name = "cmdClose";
            _List1.Name = "List1";
            _cmdAuto.Name = "cmdAuto";
            _cmdEdit.Name = "cmdEdit";
            _lbWater.Name = "lbWater";
            _ImgText.Name = "ImgText";
        }

        private byte EntryWC;

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
            var loopTo = moduleMAPS.NoOfMaps;
            for (N = 1; N <= loopTo; N++)
            {
                A = Strings.Mid(moduleMAPS.Maps[N].Name, 1, 5);
                A = Strings.UCase(A);
                if (A != "CLASS")
                    goto NextMap;
                moduleCLASSES.FillWater(N);
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
                Interaction.MsgBox("Class Maps have been processed!", MsgBoxStyle.Information);
            }
            else
            {
                Interaction.MsgBox("No Class Map was found!", MsgBoxStyle.Information);
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            moduleCLASSES.DefaultWC = EntryWC;
            Dispose();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmWatersP_Load(object sender, EventArgs e)
        {
            string A;
            int N;
            string jpg = ".jpg";
            moduleCLASSES.LandWaterDELETE = false;
            moduleCLASSES.LandWaterRASTER = false;

            // SetLWCIs()

            var loopTo = moduleCLASSES.NoOfWCs;
            for (N = 1; N <= loopTo; N++)
                List1.Items.Add(moduleCLASSES.WC[N].Caption);
            EntryWC = moduleCLASSES.DefaultWC;
            N = moduleCLASSES.DefaultWC;

            // lbWater.Text = VB6.GetItemString(List1, N - 1)
            lbWater.Text = List1.GetItemText(N - 1);
            lbWater.BackColor = moduleCLASSES.WC[N].Color;
            lbWater.ForeColor = moduleMAIN.InvertColor(moduleCLASSES.WC[N].Color);
            A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + moduleCLASSES.WC[N].Texture + jpg;
            ImgText.Image = Image.FromFile(A);
            moduleMAIN.ImageFileName = A;
        }

        private void List1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int N;
            string A;
            string jpg = ".jpg";
            N = List1.SelectedIndex + 1;
            moduleCLASSES.DefaultWC = (byte)N;

            // lbWater.Text = VB6.GetItemString(List1, N - 1)
            lbWater.Text = List1.GetItemText(N - 1);
            lbWater.BackColor = moduleCLASSES.WC[N].Color;
            lbWater.ForeColor = moduleMAIN.InvertColor(moduleCLASSES.WC[N].Color);
            A = My.MyProject.Application.Info.DirectoryPath + @"\tools\bmps\" + moduleCLASSES.WC[N].Texture + jpg;
            ImgText.Image = Image.FromFile(A);
            moduleMAIN.ImageFileName = A;
        }

        private void LbWater_Click(object sender, EventArgs e)
        {
            moduleMAIN.ARGBColor = lbWater.BackColor;
            if (My.MyProject.Forms.FrmTransparency.ShowDialog() == DialogResult.OK)
            {
                lbWater.BackColor = moduleMAIN.ARGBColor;
            }
        }

        private void ImgText_Click(object sender, EventArgs e)
        {
            My.MyProject.Forms.FrmImage.ShowDialog();
        }
    }
}