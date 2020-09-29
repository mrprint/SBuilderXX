using System;
using System.Drawing;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmTransparency
    {
        public FrmTransparency()
        {
            InitializeComponent();
            _BarA.Name = "BarA";
            _cmdCancel.Name = "cmdCancel";
            _cmdOK.Name = "cmdOK";
            _BarR.Name = "BarR";
            _BarG.Name = "BarG";
            _BarB.Name = "BarB";
            _txtR.Name = "txtR";
            _txtG.Name = "txtG";
            _txtB.Name = "txtB";
            _txtA.Name = "txtA";
            _Label1.Name = "Label1";
            _Label2.Name = "Label2";
            _Label3.Name = "Label3";
            _Label4.Name = "Label4";
            _Label5.Name = "Label5";
            _Label6.Name = "Label6";
            _Label7.Name = "Label7";
            _Label8.Name = "Label8";
            _Label9.Name = "Label9";
            _Label10.Name = "Label10";
            _Label11.Name = "Label11";
            _Label12.Name = "Label12";
            _Label13.Name = "Label13";
            _Label14.Name = "Label14";
            _Label15.Name = "Label15";
            _Label16.Name = "Label16";
            _Label17.Name = "Label17";
            _Label18.Name = "Label18";
            _Label19.Name = "Label19";
            _Label20.Name = "Label20";
            _Label21.Name = "Label21";
            _Label22.Name = "Label22";
            _Label23.Name = "Label23";
            _Label24.Name = "Label24";
            _Label25.Name = "Label25";
            _Label26.Name = "Label26";
            _Label27.Name = "Label27";
        }

        private bool Init = true;
        private int Alpha;
        private int Red;
        private int Green;
        private int Blue;

        private void CmdOK_Click(object sender, EventArgs e)
        {
            moduleMAIN.ARGBColor = Color.FromArgb(Alpha, Red, Green, Blue);
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void FrmTransparency_Load(object sender, EventArgs e)
        {

            // Dim myColor As Color

            // If POPType = "Line" Then myColor = Lines(POPIndex).Color
            // If POPType = "Poly" Then myColor = Polys(POPIndex).Color

            Alpha = moduleMAIN.ARGBColor.A;
            Red = moduleMAIN.ARGBColor.R;
            Green = moduleMAIN.ARGBColor.G;
            Blue = moduleMAIN.ARGBColor.B;
            UpDateValues();
        }

        private void FrmTransparency_Paint(object sender, PaintEventArgs e)
        {
            if (Init)
                return;
            var mycolor = Color.FromArgb(Alpha, Red, Green, Blue);
            var mybrush1 = new SolidBrush(mycolor);
            var mybrush2 = new SolidBrush(Color.White);
            var mybrush3 = new SolidBrush(Color.Black);
            var myPen = new Pen(Color.Black);
            var drawFont = new Font("Arial", 46f);
            Graphics g;
            g = e.Graphics;
            g.FillRectangle(mybrush2, new Rectangle(15, 20, 110, 80));
            g.DrawString("OK", drawFont, mybrush3, 18f, 28f);
            g.FillRectangle(mybrush1, new Rectangle(15, 20, 110, 80));
            g.DrawRectangle(myPen, new Rectangle(15, 20, 110, 80));
            mybrush1.Dispose();
            mybrush2.Dispose();
            mybrush3.Dispose();
            drawFont.Dispose();
            myPen.Dispose();
        }

        private void BarA_ValueChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            Alpha = BarA.Value;
            UpDateValues();
        }

        private void BarR_ValueChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            Red = BarR.Value;
            UpDateValues();
        }

        private void BarG_ValueChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            Green = BarG.Value;
            UpDateValues();
        }

        private void BarB_ValueChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            Blue = BarB.Value;
            UpDateValues();
        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {
            int EC = Alpha;
            if (Init)
                return;
            try
            {
                Alpha = Convert.ToInt32(txtA.Text);
                if (Alpha < 0)
                    Alpha = 0;
                if (Alpha > 255)
                    Alpha = 255;
                UpDateValues();
            }
            catch (Exception ex)
            {
                Alpha = EC;
                txtA.Text = EC.ToString();
            }
        }

        private void TxtR_TextChanged(object sender, EventArgs e)
        {
            int EC = Red;
            if (Init)
                return;
            try
            {
                Red = Convert.ToInt32(txtR.Text);
                if (Red < 0)
                    Red = 0;
                if (Red > 255)
                    Red = 255;
                UpDateValues();
            }
            catch (Exception ex)
            {
                Red = EC;
                txtR.Text = EC.ToString();
            }
        }

        private void TxtG_TextChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            int EC = Green;
            try
            {
                Green = Convert.ToInt32(txtG.Text);
                if (Green < 0)
                    Green = 0;
                if (Green > 255)
                    Green = 255;
                UpDateValues();
            }
            catch (Exception ex)
            {
                Green = EC;
                txtG.Text = EC.ToString();
            }
        }

        private void TxtB_TextChanged(object sender, EventArgs e)
        {
            if (Init)
                return;
            int EC = Blue;
            try
            {
                Blue = Convert.ToInt32(txtB.Text);
                if (Blue < 0)
                    Blue = 0;
                if (Blue > 255)
                    Blue = 255;
                UpDateValues();
            }
            catch (Exception ex)
            {
                Blue = EC;
                txtB.Text = EC.ToString();
            }
        }

        private void UpDateValues()
        {
            Init = true;
            BarA.Value = Alpha;
            BarR.Value = Red;
            BarG.Value = Green;
            BarB.Value = Blue;
            txtA.Text = Alpha.ToString();
            txtR.Text = Red.ToString();
            txtG.Text = Green.ToString();
            txtB.Text = Blue.ToString();
            Init = false;
            Refresh();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            SetThisColor(1);
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            SetThisColor(2);
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            SetThisColor(3);
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            SetThisColor(4);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            SetThisColor(5);
        }

        private void Label6_Click(object sender, EventArgs e)
        {
            SetThisColor(6);
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            SetThisColor(7);
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            SetThisColor(8);
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            SetThisColor(9);
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            SetThisColor(10);
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            SetThisColor(11);
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            SetThisColor(12);
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            SetThisColor(13);
        }

        private void Label14_Click(object sender, EventArgs e)
        {
            SetThisColor(14);
        }

        private void Label15_Click(object sender, EventArgs e)
        {
            SetThisColor(15);
        }

        private void Label16_Click(object sender, EventArgs e)
        {
            SetThisColor(16);
        }

        private void Label17_Click(object sender, EventArgs e)
        {
            SetThisColor(17);
        }

        private void Label18_Click(object sender, EventArgs e)
        {
            SetThisColor(18);
        }

        private void Label19_Click(object sender, EventArgs e)
        {
            SetThisColor(19);
        }

        private void Label20_Click(object sender, EventArgs e)
        {
            SetThisColor(20);
        }

        private void Label21_Click(object sender, EventArgs e)
        {
            SetThisColor(21);
        }

        private void Label22_Click(object sender, EventArgs e)
        {
            SetThisColor(22);
        }

        private void Label23_Click(object sender, EventArgs e)
        {
            SetThisColor(23);
        }

        private void Label24_Click(object sender, EventArgs e)
        {
            SetThisColor(24);
        }

        private void Label25_Click(object sender, EventArgs e)
        {
            SetThisColor(25);
        }

        private void Label26_Click(object sender, EventArgs e)
        {
            SetThisColor(26);
        }

        private void Label27_Click(object sender, EventArgs e)
        {
            SetThisColor(27);
        }

        public void SetThisColor(int N)
        {
            var myColor = default(Color);
            Label1.BorderStyle = BorderStyle.None;
            Label2.BorderStyle = BorderStyle.None;
            Label3.BorderStyle = BorderStyle.None;
            Label4.BorderStyle = BorderStyle.None;
            Label5.BorderStyle = BorderStyle.None;
            Label6.BorderStyle = BorderStyle.None;
            Label7.BorderStyle = BorderStyle.None;
            Label8.BorderStyle = BorderStyle.None;
            Label9.BorderStyle = BorderStyle.None;
            Label10.BorderStyle = BorderStyle.None;
            Label11.BorderStyle = BorderStyle.None;
            Label12.BorderStyle = BorderStyle.None;
            Label13.BorderStyle = BorderStyle.None;
            Label14.BorderStyle = BorderStyle.None;
            Label15.BorderStyle = BorderStyle.None;
            Label16.BorderStyle = BorderStyle.None;
            Label17.BorderStyle = BorderStyle.None;
            Label18.BorderStyle = BorderStyle.None;
            Label19.BorderStyle = BorderStyle.None;
            Label20.BorderStyle = BorderStyle.None;
            Label21.BorderStyle = BorderStyle.None;
            Label22.BorderStyle = BorderStyle.None;
            Label23.BorderStyle = BorderStyle.None;
            Label24.BorderStyle = BorderStyle.None;
            Label25.BorderStyle = BorderStyle.None;
            Label26.BorderStyle = BorderStyle.None;
            Label27.BorderStyle = BorderStyle.None;
            switch (N)
            {
                case 1:
                    {
                        Label1.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label1.BackColor;
                        break;
                    }

                case 2:
                    {
                        Label2.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label2.BackColor;
                        break;
                    }

                case 3:
                    {
                        Label3.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label3.BackColor;
                        break;
                    }

                case 4:
                    {
                        Label4.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label4.BackColor;
                        break;
                    }

                case 5:
                    {
                        Label5.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label5.BackColor;
                        break;
                    }

                case 6:
                    {
                        Label6.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label6.BackColor;
                        break;
                    }

                case 7:
                    {
                        Label7.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label7.BackColor;
                        break;
                    }

                case 8:
                    {
                        Label8.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label8.BackColor;
                        break;
                    }

                case 9:
                    {
                        Label9.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label9.BackColor;
                        break;
                    }

                case 10:
                    {
                        Label10.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label10.BackColor;
                        break;
                    }

                case 11:
                    {
                        Label11.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label11.BackColor;
                        break;
                    }

                case 12:
                    {
                        Label12.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label12.BackColor;
                        break;
                    }

                case 13:
                    {
                        Label13.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label13.BackColor;
                        break;
                    }

                case 14:
                    {
                        Label14.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label14.BackColor;
                        break;
                    }

                case 15:
                    {
                        Label15.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label15.BackColor;
                        break;
                    }

                case 16:
                    {
                        Label16.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label16.BackColor;
                        break;
                    }

                case 17:
                    {
                        Label17.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label17.BackColor;
                        break;
                    }

                case 18:
                    {
                        Label18.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label18.BackColor;
                        break;
                    }

                case 19:
                    {
                        Label19.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label19.BackColor;
                        break;
                    }

                case 20:
                    {
                        Label20.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label20.BackColor;
                        break;
                    }

                case 21:
                    {
                        Label21.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label21.BackColor;
                        break;
                    }

                case 22:
                    {
                        Label22.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label22.BackColor;
                        break;
                    }

                case 23:
                    {
                        Label23.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label23.BackColor;
                        break;
                    }

                case 24:
                    {
                        Label24.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label24.BackColor;
                        break;
                    }

                case 25:
                    {
                        Label25.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label25.BackColor;
                        break;
                    }

                case 26:
                    {
                        Label26.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label26.BackColor;
                        break;
                    }

                case 27:
                    {
                        Label27.BorderStyle = BorderStyle.Fixed3D;
                        myColor = Label27.BackColor;
                        break;
                    }
            }

            Red = myColor.R;
            Green = myColor.G;
            Blue = myColor.B;
            UpDateValues();
        }
    }
}