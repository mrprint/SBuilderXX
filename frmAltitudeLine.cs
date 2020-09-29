﻿using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace SBuilderX
{
    internal partial class FrmAltitudeLine
    {
        public FrmAltitudeLine()
        {
            InitializeComponent();
            _cmdCancel.Name = "cmdCancel";
            _cmdAlt.Name = "cmdAlt";
        }

        private void CmdCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CmdAlt_Click(object sender, EventArgs e)
        {
            int N, K;
            double X;

            try
            {
                X = Conversions.ToDouble(txtAlt.Text);
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

                Dispose();
                return;
            }
            catch (Exception exc)
            {
                Interaction.MsgBox("Check altitude value!", MsgBoxStyle.Critical);
                Dispose();
            }
        }

        private void FrmAltitudeLine_Load(object sender, EventArgs e)
        {
            int N;
            double X;
            X = 0d;
            var loopTo = moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints;
            for (N = 1; N <= loopTo; N++)
                X = X + moduleLINES.Lines[modulePOPUP.POPIndex].GLPoints[N].alt;
            txtAlt.Text = (X / moduleLINES.Lines[modulePOPUP.POPIndex].NoOfPoints).ToString();
        }
    }
}