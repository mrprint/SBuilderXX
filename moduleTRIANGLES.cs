using System;
using System.Windows.Forms;

namespace SBuilderX
{
    static class moduleTRIANGLES
    {
        internal struct Pts2Tri
        {
            public double X;
            public double Y;
            public double T; // turn =positive if clockwise
            public int N;
        }

        internal static Pts2Tri[] Pts2Tris;
        internal static int NoOfPts2Tris;

        // this is output for triangles
        internal struct Tri
        {
            public int N1;
            public int N2;
            public int N3;
        }

        internal static Tri[] Tris;
        internal static int NoOfTris;

        internal static void MakeTris()
        {
            int N1 = default(int);
            NoOfTris = 0;
            SetTriConcaves();
            do
            {
                FindTri(ref N1);
                RemoveTri(N1);
            }
            while (NoOfPts2Tris > 3);
            NoOfTris = NoOfTris + 1;
            Array.Resize(ref Tris, NoOfTris + 1);
            Tris[NoOfTris].N1 = Pts2Tris[1].N;
            Tris[NoOfTris].N2 = Pts2Tris[2].N;
            Tris[NoOfTris].N3 = Pts2Tris[3].N;
        }

        private static void FindTri(ref int N1)
        {
            int N;
            int loopTo = NoOfPts2Tris;
            for (N = 2; N <= loopTo; N++)
            {
                if (!IsTri(N))
                    continue;
                // ok on some
                N1 = N;
                return;
            }

            MessageBox.Show("Error on the triangulation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private static void RemoveTri(int N1)
        {
            int K;
            NoOfTris = NoOfTris + 1;
            Array.Resize(ref Tris, NoOfTris + 1);
            Tris[NoOfTris].N1 = Pts2Tris[N1 - 1].N;
            Tris[NoOfTris].N2 = Pts2Tris[N1].N;
            Tris[NoOfTris].N3 = Pts2Tris[N1 + 1].N;

            // fazer o novo Pts2Tri
            NoOfPts2Tris = NoOfPts2Tris - 1;
            int loopTo = NoOfPts2Tris;
            for (K = N1; K <= loopTo; K++)
                Pts2Tris[K] = Pts2Tris[K + 1];
            SetTriConcaves();
            Pts2Tris[0] = Pts2Tris[NoOfPts2Tris];
            Pts2Tris[NoOfPts2Tris + 1] = Pts2Tris[1];
        }

        private static bool IsTri(int N1)
        {
            bool IsTriRet = default;
            int K;
            IsTriRet = false;
            if (Pts2Tris[N1].T < 0d)
                return IsTriRet;
            int loopTo = NoOfPts2Tris;
            for (K = N1 + 2; K <= loopTo; K++)
            {
                // If Pts2Tris(K).T < 0 Then GoTo next_1:
                if (IsPtInTri(N1, K))
                    return IsTriRet;
                //next_1:
                //;
            }

            int loopTo1 = N1 - 2;
            for (K = 1; K <= loopTo1; K++)
            {
                // If Pts2Tri(K).T < 0 Then GoTo next_2:
                if (IsPtInTri(N1, K))
                    return IsTriRet;
                //next_2:
                //;
            }

            IsTriRet = true;
            return IsTriRet;
        }

        private static void SetTriConcaves()
        {
            int N;
            int loopTo = NoOfPts2Tris;
            for (N = 1; N <= loopTo; N++)
                Pts2Tris[N].T = GetTriTurn(N);
        }

        private static double GetTriTurn(int N)
        {
            double GetTriTurnRet = default;
            double X1, X0, Y0, Y1;
            X0 = Pts2Tris[N].X - Pts2Tris[N - 1].X;
            Y0 = Pts2Tris[N].Y - Pts2Tris[N - 1].Y;
            X1 = Pts2Tris[N + 1].X - Pts2Tris[N].X;
            Y1 = Pts2Tris[N + 1].Y - Pts2Tris[N].Y;
            GetTriTurnRet = Y0 * X1 - X0 * Y1; // this is when GetTurn returns a double
            return GetTriTurnRet;
        }

        private static bool IsPtInTri(int N1, int K)
        {
            bool IsPtInTriRet = default;
            moduleMAIN.Double_XY[] P = new moduleMAIN.Double_XY[5];
            int C;
            double X1, Y1;
            double X0, Y0;
            double X, Y;
            double CP;
            P[1].X = Pts2Tris[N1 - 1].X;
            P[1].Y = Pts2Tris[N1 - 1].Y;
            P[2].X = Pts2Tris[N1].X;
            P[2].Y = Pts2Tris[N1].Y;
            P[3].X = Pts2Tris[N1 + 1].X;
            P[3].Y = Pts2Tris[N1 + 1].Y;
            P[4].X = Pts2Tris[N1 - 1].X;
            P[4].Y = Pts2Tris[N1 - 1].Y;
            X = Pts2Tris[K].X;
            Y = Pts2Tris[K].Y;
            IsPtInTriRet = false;
            for (C = 2; C <= 4; C++)
            {
                Y1 = P[C].Y;
                Y0 = P[C - 1].Y;
                if (Y1 == Y0)
                    continue;
                if (Y <= Y1 & Y <= Y0)
                    continue;
                if (Y > Y1 & Y > Y0)
                    continue;
                X1 = P[C].X;
                X0 = P[C - 1].X;
                if (X < X1 & X < X0)
                {
                    IsPtInTriRet = !IsPtInTriRet;
                    continue;
                }

                if (X > X1 & X > X0)
                    continue;
                CP = (X1 - X0) * (Y - Y0) / (Y1 - Y0) + X0;
                if (X < CP)
                    IsPtInTriRet = !IsPtInTriRet;
            }

            return IsPtInTriRet;
        }
    }
}