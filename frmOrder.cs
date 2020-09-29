using System;
using System.Windows.Forms;

namespace SBuilderX
{
    internal partial class FrmOrder : Form
    {
        private string[] O;

        private void CmdCancel_Click(object eventSender, EventArgs eventArgs)
        {
            moduleOBJECTS.ObjOrder = false;
            Dispose();
        }

        private void CmdDOWN_Click(object eventSender, EventArgs eventArgs)
        {
            int K, N;
            N = lstObject.SelectedIndex + 1;
            if (N == 0)
                return;
            if (N == moduleOBJECTS.NoOfObjects)
                return;

            // remove the list
            for (K = moduleOBJECTS.NoOfObjects; K >= 1; K -= 1)
            {
                // O(K) = VB6.GetItemString(lstObject, K - 1)
                O[K] = lstObject.GetItemText(K - 1);
                lstObject.Items.RemoveAt(K - 1);
            }

            // and add in new order
            var loopTo = N - 1;
            for (K = 1; K <= loopTo; K++)
                lstObject.Items.Add(O[K]);
            lstObject.Items.Add(O[N + 1]);
            lstObject.Items.Add(O[N]);
            var loopTo1 = moduleOBJECTS.NoOfObjects;
            for (K = N + 2; K <= loopTo1; K++)
                lstObject.Items.Add(O[K]);
            lstObject.SelectedIndex = N;
            moduleOBJECTS.ObjOrder = true;
        }

        private void CmdOK_Click(object eventSender, EventArgs eventArgs)
        {
            moduleOBJECTS.Objecto[] ObjectCopies;
            int N, K;
            string A;
            ObjectCopies = new moduleOBJECTS.Objecto[moduleOBJECTS.NoOfObjects + 1];

            // ObjectCopies = VB6.CopyArray(Objects)
            Array.Copy(moduleOBJECTS.Objects, ObjectCopies, moduleOBJECTS.NoOfObjects);
            var loopTo = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                A = lstObject.GetItemText(N - 1);
                A = A.Substring(57, 5);
                K = Convert.ToInt32(A);
                // added after 205
                // If K = ObjPOPIndex Then ObjPOPIndex = N
                if (K == modulePOPUP.POPIndex)
                    modulePOPUP.POPIndex = N;
                moduleOBJECTS.Objects[N] = ObjectCopies[K];
            }

            Dispose();
        }

        private void CmdUp_Click(object eventSender, EventArgs eventArgs)
        {
            int N, K;
            N = lstObject.SelectedIndex + 1;
            if (N == 0)
                return;
            if (N == 1)
                return;

            // remove the list
            for (K = moduleOBJECTS.NoOfObjects; K >= 1; K -= 1)
            {
                // O(K) = VB6.GetItemString(lstObject, K - 1)
                O[K] = lstObject.GetItemText(K - 1);
                lstObject.Items.RemoveAt(K - 1);
            }

            // and add in new order
            var loopTo = N - 2;
            for (K = 1; K <= loopTo; K++)
                lstObject.Items.Add(O[K]);
            lstObject.Items.Add(O[N]);
            lstObject.Items.Add(O[N - 1]);
            var loopTo1 = moduleOBJECTS.NoOfObjects;
            for (K = N + 1; K <= loopTo1; K++)
                lstObject.Items.Add(O[K]);
            lstObject.SelectedIndex = N - 2;
            moduleOBJECTS.ObjOrder = true;
        }

        private void FrmOrder_Load(object eventSender, EventArgs eventArgs)
        {
            int J, N, K, M;
            string A, B;

            // UPGRADE_WARNING: Lower bound of array O was changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="0F1C9BE1-AF9D-476E-83B1-17D43BECFF20"'
            O = new string[moduleOBJECTS.NoOfObjects + 1];
            var loopTo = moduleOBJECTS.NoOfObjects;
            for (N = 1; N <= loopTo; N++)
            {
                K = moduleOBJECTS.Objects[N].Type;
                if (K == 0)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.IndexOf("|");
                        B = A.Substring(0, M - 1);
                    }

                    O[N] = "FSX Library Object  " + B;
                }

                if (K == 1)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.IndexOf("|");
                        B = A.Substring(0, M - 1);
                    }

                    O[N] = "FS8 Library Object  " + B;
                }

                if (K == 2)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.IndexOf("|");
                        B = A.Substring(0, M - 1);
                    }

                    O[N] = "FS9 Library Object  " + B;
                }

                if (K == 3)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.IndexOf("|");
                        B = A.Substring(0, M - 1);
                    }

                    O[N] = "Rwy12 Object        " + B;
                }

                if (K == 4)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.IndexOf("|");
                        B = A.Substring(0, M - 1);
                    }

                    O[N] = "API Macro Object    " + B;
                }

                if (K == 5)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.IndexOf("|");
                        B = A.Substring(0, M - 1);
                    }

                    O[N] = "ASD Macro Object    " + B;
                }

                if (K == 8)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.Length;
                        A = A.Substring(0, M - 1);
                        M = A.LastIndexOf("|");
                        B = A.Substring(M + 1);
                    }

                    O[N] = "Taxiway Sign        " + B;
                }

                if (K == 16)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        M = A.IndexOf("|");
                        B = A.Substring(0, M - 1);
                    }

                    O[N] = "Effect Object       " + B;
                }

                if (K == 32)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        B = "Object # " + N.ToString().Trim();
                    }

                    O[N] = "Beacon Object       " + B;
                }

                if (K == 64)
                {
                    A = moduleOBJECTS.Objects[N].Description;
                    M = A.LastIndexOf("|");
                    B = A.Substring(M + 1);
                    if (string.IsNullOrEmpty(B))
                    {
                        B = "Object # " + N.ToString().Trim();
                    }

                    O[N] = "Windsock Object     " + B;
                }

                O[N] = O[N].Substring(0, 57);
                K = O[N].Length;
                for (J = K + 1; J <= 57; J++)
                    O[N] = O[N] + " ";
                B = N.ToString("00000");
                O[N] = O[N] + B;
                lstObject.Items.Add(O[N]);
            }
        }
    }
}