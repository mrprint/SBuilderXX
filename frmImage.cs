using System;
using System.Drawing;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmImage
    {
        public FrmImage()
        {
            InitializeComponent();
        }

        private Image img;
        private int myWidth;
        private int myHeight;

        private void FrmImage_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmImage_Load(object sender, EventArgs e)
        {
            img = Image.FromFile(moduleMAIN.ImageFileName);
            Width = img.Width;
            Height = img.Height + 32;
            myWidth = img.Width;
            myHeight = img.Height;
        }

        private void FrmImage_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0, myWidth, myHeight);
        }
    }
}