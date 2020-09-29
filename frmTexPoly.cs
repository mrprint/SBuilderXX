using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    public partial class frmTexPoly
    {
        public frmTexPoly()
        {
            InitializeComponent();
            _cmdLL.Name = "cmdLL";
            _cmdRR.Name = "cmdRR";
            _txtPY.Name = "txtPY";
            _cmdDD.Name = "cmdDD";
            _cmdUU.Name = "cmdUU";
            _txtPX.Name = "txtPX";
            _cmdOK.Name = "cmdOK";
            _cmdCancel.Name = "cmdCancel";
            _cmdReset.Name = "cmdReset";
            _imgText.Name = "imgText";
        }

        private Point[] Pts;
        private int NoOfPts;
        private int SelPt;
        private bool MoveON;
        private bool MouseDownDone = false;
        private int MoveDir; // 1 east  2 south  3 west 4 north
        private Bitmap imgBuffer = new Bitmap(512, 512);
        private int AuxX;
        private int AuxY;
        private bool IsInit = true;

        private void FrmTexPoly_Load(object eventSender, EventArgs eventArgs)
        {
            string a;
            a = "SBuilderX - Set Tying Points for Texture ";
            a = a + Strings.UCase(modulePOLYS.PolyTex);
            Text = a;
            string BmpPath = moduleMAIN.AppPath + @"\Tools\Work\temp.bmp";
            var bmp = Image.FromFile(BmpPath);
            var cpy = new Bitmap(bmp);
            bmp.Dispose();
            imgBuffer = cpy;
            String2Pts();
            ShowCoordinates();
            IsInit = false;
        }

        private void String2Pts()
        {
            int N, K;
            string a, b;
            NoOfPts = modulePOLYS.Polys[modulePOLYS.PolyTexIndex].NoOfPoints;
            Pts = new Point[NoOfPts + 1];
            a = modulePOLYS.PolyTexString;
            SelPt = 1;
            var loopTo = NoOfPts;
            for (N = 1; N <= loopTo; N++)
            {
                K = Strings.InStr(1, a, "//");
                b = Strings.Mid(a, 1, K - 1);
                a = Strings.Mid(a, K + 2);
                K = Strings.InStr(1, b, ",");
                Pts[N].X = 2 * Conversions.ToInteger(Strings.Mid(b, 1, K - 1));
                Pts[N].Y = 512 - 2 * Conversions.ToInteger(Strings.Mid(b, K + 1));
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void DoDD()
        {
            int N;
            N = Conversions.ToInteger(txtPY.Text);
            N = N - 1;
            if (N < 0)
                N = 0;
            Pts[SelPt].Y = T2PY(N);
            DisplayPoly();
            ShowCoordinates();
        }

        private void CmdDD_MouseDown(object eventSender, MouseEventArgs eventArgs)
        {
            DoDD();
            MoveDir = 2;
            Timer1.Interval = 512d;
            Timer1.Enabled = true;
        }

        private void CmdDD_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            Timer1.Enabled = false;
        }

        private void DoLL()
        {
            int N;
            N = Conversions.ToInteger(txtPX.Text);
            N = N - 1;
            if (N < 0)
                N = 0;
            Pts[SelPt].X = T2PX(N);
            DisplayPoly();
            ShowCoordinates();
        }

        private void CmdLL_MouseDown(object eventSender, MouseEventArgs eventArgs)
        {
            DoLL();
            MoveDir = 3;
            Timer1.Interval = 512d;
            Timer1.Enabled = true;
        }

        private void CmdLL_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            Timer1.Enabled = false;
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            int N;
            modulePOLYS.PolyTexString = "";
            var loopTo = NoOfPts;
            for (N = 1; N <= loopTo; N++)
            {
                modulePOLYS.PolyTexString = modulePOLYS.PolyTexString + Pt2X(N).ToString() + ",";
                modulePOLYS.PolyTexString = modulePOLYS.PolyTexString + Pt2Y(N).ToString() + "//";
            }

            Dispose();
        }

        private void CmdReset_Click(object eventSender, EventArgs eventArgs)
        {
            modulePOLYS.MakePolyTexString(modulePOLYS.PolyTexIndex, true);
            String2Pts();
            DisplayPoly();
            ShowCoordinates();
        }

        private void DoRR()
        {
            int N;
            N = Conversions.ToInteger(txtPX.Text);
            N = N + 1;
            if (N > 256)
                N = 256;
            Pts[SelPt].X = T2PX(N);
            DisplayPoly();
            ShowCoordinates();
        }

        private void DoUU()
        {
            int N;
            N = Conversions.ToInteger(txtPY.Text);
            N = N + 1;
            if (N > 256)
                N = 256;
            Pts[SelPt].Y = T2PY(N);
            DisplayPoly();
            ShowCoordinates();
        }

        private void CmdRR_MouseDown(object eventSender, MouseEventArgs eventArgs)
        {
            DoRR();
            MoveDir = 1;
            Timer1.Interval = 512d;
            Timer1.Enabled = true;
        }

        private void CmdRR_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            Timer1.Enabled = false;
        }

        private void CmdUU_MouseDown(object eventSender, MouseEventArgs eventArgs)
        {
            DoUU();
            MoveDir = 4;
            Timer1.Interval = 512d;
            Timer1.Enabled = true;
        }

        private void CmdUU_MouseUp(object eventSender, MouseEventArgs eventArgs)
        {
            Timer1.Enabled = false;
        }

        private void DisplayPoly()
        {
            int N;
            var g = imgText.CreateGraphics();
            var myPen = new Pen(Color.Black);
            var myBrush = new SolidBrush(Color.White);
            g.DrawImage(imgBuffer, 0, 0, 512, 512);
            myPen.Color = Color.Black;
            var loopTo = NoOfPts - 1;
            for (N = 1; N <= loopTo; N++)
                g.DrawLine(myPen, Pts[N], Pts[N + 1]);
            g.DrawLine(myPen, Pts[NoOfPts], Pts[1]);
            var loopTo1 = NoOfPts;
            for (N = 1; N <= loopTo1; N++)
            {
                if (N == SelPt)
                {
                    myPen.Color = Color.Green;
                }
                else
                {
                    myPen.Color = Color.Black;
                }

                g.FillRectangle(myBrush, Pts[N].X - 3, Pts[N].Y - 3, 6, 6);
                g.DrawRectangle(myPen, Pts[N].X - 3, Pts[N].Y - 3, 6, 6);
            }

            myBrush.Dispose();
            myPen.Dispose();
            g.Dispose();
        }

        // 'UPGRADE_WARNING: Event txtPX.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        // Private Sub TxtPX_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPX.TextChanged

        // Dim N, N0, N1 As Integer

        // If NoChange Then Exit Sub

        // N0 = Pts(SelPt).x

        // On Error GoTo erro

        // N = CInt(txtPX.Text)
        // If N > 256 Then N = 256
        // If N < 0 Then N = 0

        // Pts(SelPt).X = T2PX(N)
        // DisplayPoly()

        // NoChange = True
        // ShowCoordinates()
        // NoChange = False

        // Exit Sub

        // erro:
        // Pts(SelPt).x = N0
        // txtPX.Text = CStr(Pt2X(SelPt))
        // NoChange = False

        // End Sub

        // UPGRADE_WARNING: Event txtPY.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
        // Private Sub TxtPY_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPY.TextChanged

        // Dim N, N0, N1 As Integer

        // If NoChange Then Exit Sub

        // N0 = Pts(SelPt).Y

        // On Error GoTo erro

        // N = CInt(txtPY.Text)
        // If N > 256 Then N = 256
        // If N < 0 Then N = 0

        // Pts(SelPt).Y = T2PY(N)
        // DisplayPoly()

        // NoChange = True
        // ShowCoordinates()
        // NoChange = False

        // Exit Sub

        // erro:
        // Pts(SelPt).Y = N0
        // txtPY.Text = CStr(Pt2Y(SelPt))
        // NoChange = False

        // End Sub

        private void ShowCoordinates()
        {
            IsInit = true;
            txtPY.Text = Pt2Y(SelPt).ToString();
            txtPX.Text = Pt2X(SelPt).ToString();
            Frame1.Text = "Point # " + SelPt.ToString();
            IsInit = false;
        }

        private int T2PX(int T)
        {
            int T2PXRet = default;
            T2PXRet = 2 * T;
            return T2PXRet;
        }

        private int T2PY(int T)
        {
            int T2PYRet = default;
            T2PYRet = 512 - 2 * T;
            return T2PYRet;
        }

        private int Pt2X(int PT)
        {
            int Pt2XRet = default;
            Pt2XRet = (int)(Pts[PT].X / 2d);
            return Pt2XRet;
        }

        private int Pt2Y(int PT)
        {
            int Pt2YRet = default;
            Pt2YRet = (int)(512d - Pts[PT].Y / 2d);
            return Pt2YRet;
        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            double N;
            N = Timer1.Interval;
            N = N / 2d;
            if (N < 8d)
                N = 8d;
            if (MoveDir == 1)
                DoRR();
            if (MoveDir == 2)
                DoDD();
            if (MoveDir == 3)
                DoLL();
            if (MoveDir == 4)
                DoUU();
            Timer1.Interval = N;
        }

        private void FrmTexPoly_Paint(object sender, PaintEventArgs e)
        {
            DisplayPoly();
        }

        private void ImgText_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            int PY, PX, N;
            if (x < 0 | x > 512)
                return;
            if (y < 0 | y > 512)
                return;
            if (MouseDownDone)
                return;
            MoveON = false;
            MouseDownDone = true;
            PX = x;
            PY = y;
            var loopTo = NoOfPts;
            for (N = 1; N <= loopTo; N++)
            {
                if (Math.Abs(PX - Pts[N].X) > 3)
                    goto next_N;
                if (Math.Abs(PY - Pts[N].Y) > 3)
                    goto next_N;
                MoveON = true;
                SelPt = N;
                DisplayPoly();
                ShowCoordinates();
                return;
            next_N:
                ;
            }
        }

        private void ImgText_MouseMove(object sender, MouseEventArgs e)
        {
            if (MoveON == false)
                return;
            int x = e.X;
            int y = e.Y;
            if (x == AuxX & y == AuxY)
                return;
            if (y < 0)
                y = 0;
            if (y > 511)
                y = 511;
            if (x < 0)
                x = 0;
            if (x > 511)
                x = 511;
            Pts[SelPt].X = x;
            Pts[SelPt].Y = y;
            AuxX = x;
            AuxY = y;
            DisplayPoly();
            ShowCoordinates();
        }

        private void ImgText_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDownDone = false;
            MoveON = false;
        }

        private void TxtPX_TextChanged(object sender, EventArgs e)
        {
            if (IsInit)
                return;
            int N, N0, N1;
            N0 = Pts[SelPt].X;

            try
            {
                N = Conversions.ToInteger(txtPX.Text);
                if (N > 256)
                    N = 256;
                if (N < 0)
                    N = 0;
                Pts[SelPt].X = T2PX(N);
                DisplayPoly();
                ShowCoordinates();
                return;
            }
            catch (Exception exc)
            {
                Pts[SelPt].X = N0;
                txtPX.Text = Pt2X(SelPt).ToString();
            }
        }

        private void TxtPY_TextChanged(object sender, EventArgs e)
        {
            if (IsInit)
                return;
            int N, N0, N1;
            N0 = Pts[SelPt].Y;

            try
            {
                N = Conversions.ToInteger(txtPY.Text);
                if (N > 256)
                    N = 256;
                if (N < 0)
                    N = 0;
                Pts[SelPt].Y = T2PY(N);
                DisplayPoly();
                ShowCoordinates();
                return;
            }
            catch (Exception exc)
            {
                Pts[SelPt].Y = N0;
                txtPY.Text = Pt2Y(SelPt).ToString();
            }
        }
    }
}