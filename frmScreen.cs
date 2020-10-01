using System;
using System.Drawing;
using System.Windows.Forms;

namespace SBuilderXX
{
    public partial class frmSCREEN
    {
        public frmSCREEN()
        {
            InitializeComponent();
        }

        private Bitmap Screen = new Bitmap(My.MyProject.Computer.Screen.Bounds.Width, My.MyProject.Computer.Screen.Bounds.Height);
        private Size Screensize = new Size(My.MyProject.Computer.Screen.Bounds.Width, My.MyProject.Computer.Screen.Bounds.Height);
        private bool MouseIsDown = false;
        private int X0 = 0;
        private int Y0 = 0;
        private int X1 = 0;
        private int Y1 = 0;
        private int DX = 0;
        private int DY = 0;
        private int PX, PY;
        private Bitmap _myCapture;

        internal Bitmap MyCapture => _myCapture;

        private void FrmSCREEN_KeyDown(object sender, KeyEventArgs e)
        {
            Keys KeyCode = e.KeyCode;
            if (KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
            if (KeyCode == Keys.Space)
            {
                if (DX < 5)
                    return;
                if (DY < 5)
                    return;
                UpDateDisplay();
                Bitmap myScreen = new Bitmap(DX, DY);
                Graphics GS = Graphics.FromImage(myScreen);
                GS.CopyFromScreen(new Point(PX, PY), new Point(), new Size(DX, DY)); // Takes a screen shot of the screen
                GS.Dispose();
                _myCapture = myScreen;
                DialogResult = DialogResult.OK;
            }
        }

        private void FrmSCREEN_Load(object sender, EventArgs e)
        {
            string A = "  You are in screen capture mode! Select a region with the mouse and press" + Environment.NewLine;
            A = A + " <Esc> (or right click) to cancel or <Space> to capture the selected region.";
            Graphics GS = Graphics.FromImage(Screen);
            Font drawFont = new Font("Arial", 10f);
            GS.CopyFromScreen(new Point(), new Point(), Screensize); // Takes a screen shot of the screen
            GS.FillRectangle(Brushes.Beige, new Rectangle(0, 0, 460, 45));
            GS.DrawString(A, drawFont, Brushes.Black, 0f, 5f);
            drawFont.Dispose();
            GS.Dispose();
            WindowState = FormWindowState.Maximized;
            FormBorderStyle = FormBorderStyle.None;
            BackgroundImage = Screen;
            Cursor = new Cursor(moduleMAIN.AppPath + @"\Tools\Cursors\grab.cur");
        }

        private void FrmSCREEN_MouseDown(object sender, MouseEventArgs e)
        {
            MouseIsDown = false;
            int Button = (int)e.Button / 0x100000;
            if (Button == 2)
                DialogResult = DialogResult.Cancel;
            if (Button == 1)
            {
                X0 = e.X;
                Y0 = e.Y;
                MouseIsDown = true;
            }
        }

        private void FrmSCREEN_MouseMove(object sender, MouseEventArgs e)
        {
            if (!MouseIsDown)
                return;
            X1 = e.X;
            Y1 = e.Y;
            DrawSelectBox(X1, Y1);
        }

        private void FrmSCREEN_MouseUp(object sender, MouseEventArgs e)
        {

            // If Not MouseIsDown Then Exit Sub
            MouseIsDown = false;
        }

        private void DrawSelectBox(int X, int Y)
        {
            UpDateDisplay();
            Pen p = new Pen(Color.Red);
            Graphics g;
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            g = CreateGraphics();
            DX = X - X0;
            DY = Y - Y0;
            PX = X0;
            PY = Y0;
            if (X < X0)
            {
                DX = X0 - X;
                PX = X;
            }

            if (Y < Y0)
            {
                DY = Y0 - Y;
                PY = Y;
            }

            g.DrawRectangle(p, new Rectangle(PX, PY, DX, DY));
            p.Dispose();
            g.Dispose();
        }

        private void UpDateDisplay()
        {
            Graphics gr = CreateGraphics();
            gr.DrawImageUnscaled(Screen, new Point(0, 0));   // copy buffer to display
            gr.Dispose();
        }
    }
}