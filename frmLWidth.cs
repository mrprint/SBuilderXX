using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmLWidth
    {
        public FrmLWidth()
        {
            InitializeComponent();
            _cmdWidth.Name = "cmdWidth";
            _cmdReverse.Name = "cmdReverse";
            _cmdWidth12.Name = "cmdWidth12";
            _cmdCancel.Name = "cmdCancel";
            _cmdWinding.Name = "cmdWinding";
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
                Close();
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Check width value!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmLWidth_Load(object sender, EventArgs e)
        {
            txtWidth1.Text = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[1].wid.ToString();
            txtWidth2.Text = moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints].wid.ToString();
            double W;
            int K;
            W = 0d;
            var loopTo = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
                W = W + moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[K].wid;
            txtWidth.Text = (W / moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints).ToString();
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
    }
}