using System;
using Microsoft.VisualBasic;

namespace SBuilderX
{
    public class ClipPoly
    {
        private struct PathPt
        {
            public double X;
            public double Y;
            public int T;   // =0 is start  =1 is normal  =2 is end 
            public int IO;  // =0 is out    =1 is in      =2 is coming  =3 is leaving
        }

        private PathPt[] Path;
        private int NoOfPathPts = 0;

        private struct QuadPt : IComparable
        {
            public double X;
            public double Y;
            public int I;   // points to Path
            public double D;    // distance from NW corner - used to sort
            public int T;   // =1 the corners!  =2  enters the quad   =3 leaves the quad =0 already used

            int IComparable.CompareTo(object obj)
            {
                QuadPt tmp = (QuadPt)obj;
                return D.CompareTo(tmp.D);
            }
        }

        private QuadPt[] QPts;
        private int NoOfQPts = 0;

        // Private Structure Slice  ' in main module
        // Dim N As Long
        // Dim NC As Integer
        // Dim C() As Integer
        // Dim P() As XYDouble
        // End Structure

        // Public Slices() As Slice
        // Public NoOfSlices As Integer

        private int NoOfChilds = 0;
        private int PolyIndex;

        internal void SetPoly(int N)
        {
            int I, J, K, M;
            NoOfChilds = modulePOLYS.Polys[N].NoOfChilds;
            // Childs = Polys(N).Childs
            PolyIndex = N;
            int NP = modulePOLYS.Polys[N].NoOfPoints;
            var loopTo = NoOfChilds;
            for (J = 1; J <= loopTo; J++)
            {
                M = modulePOLYS.Polys[N].Childs[J];
                NP = NP + modulePOLYS.Polys[M].NoOfPoints + 1;
            }

            NoOfPathPts = NP;
            Path = new PathPt[NP + 1];
            var loopTo1 = modulePOLYS.Polys[N].NoOfPoints;
            for (J = 1; J <= loopTo1; J++)
            {
                Path[J].X = modulePOLYS.Polys[N].GPoints[J].lon;
                Path[J].Y = modulePOLYS.Polys[N].GPoints[J].lat;
                Path[J].T = 1;
            }

            Path[J - 1].T = 2;
            J = J - 1;
            Path[0].X = Path[J].X;
            Path[0].Y = Path[J].Y;
            Path[0].T = 0;
            if (NoOfChilds > 0)
            {
                var loopTo2 = NoOfChilds;
                for (I = 1; I <= loopTo2; I++)
                {
                    M = modulePOLYS.Polys[N].Childs[I];
                    var loopTo3 = modulePOLYS.Polys[M].NoOfPoints;
                    for (K = 1; K <= loopTo3; K++)
                    {
                        J = J + 1;
                        Path[J].X = modulePOLYS.Polys[M].GPoints[K].lon;
                        Path[J].Y = modulePOLYS.Polys[M].GPoints[K].lat;
                        Path[J].T = 1;
                        if (K == 1)
                            Path[J].T = 0;
                    }

                    J = J + 1;
                    Path[J].X = modulePOLYS.Polys[M].GPoints[1].lon;
                    Path[J].Y = modulePOLYS.Polys[M].GPoints[1].lat;
                    Path[J].T = 2;
                }
            }
        }

        private int QMID;
        private double NLat, SLat, WLon, ELon;  // borders
        private double CLat, CLon, DLat, DLon;  // center and delta
        private bool AllInside;
        private bool NoneInside;
        private int NoOfInside;

        internal void SetQuad(int Q, double lat, double lon)
        {

            // set QMID, NLat, SLat, WLon, ELon, DLat, DLon giving the QMID
            // and a lat/lon point inside the quad

            QMID = Q;
            Q = (int)Math.Pow(2d, Q - 2);
            DLat = 90d / Q;  // delta lat: the height of the quad
            DLon = 120d / Q;  // delta lon: the width of the quad
            WLon = Conversion.Int((lon + 180d) / DLon) * DLon - 180d;
            ELon = WLon + DLon;
            NLat = 90d - Conversion.Int((90d - lat) / DLat) * DLat;
            SLat = NLat - DLat;
            CLat = (NLat + SLat) / 2d;
            CLon = (WLon + ELon) / 2d;

            // check how many times the path enters this quad
            // and set a number of variables

            NoOfInside = 0;
            NoneInside = true;
            AllInside = true;
            bool PresentIsIn, PresentIsOut;
            bool PreviousIsIn = default, PreviousIsOut = default;
            int N, NS = default;  // NS start of a subpath
            var loopTo = NoOfPathPts;
            for (N = 0; N <= loopTo; N++)
            {
                PresentIsIn = IsPtInQuad(N);
                PresentIsOut = !PresentIsIn;
                if (Path[N].T == 0)               // point is the start of a sub poly (hole)
                {
                    NS = N;                          // sign the index in NS
                    PreviousIsIn = PresentIsIn;      // and set previous in/out as all the following
                    PreviousIsOut = PresentIsOut;    // elseifs are skipped
                }
                else if (Path[N].T > 0)           // normal or ending point of subpath
                {
                    if (PresentIsIn)
                    {
                        NoneInside = false;
                        NoOfInside = NoOfInside + 1;  // this can be revised later as it can be: either a "false" belong
                        Path[N].IO = 1;               // or an entry or leaving point
                    }
                    else
                    {
                        AllInside = false;
                        Path[N].IO = 0;
                    }

                    if (PreviousIsOut & PresentIsIn)
                    {
                        Path[N].IO = 2;                // this is an entry point
                    }

                    if (PreviousIsIn & PresentIsOut)
                    {
                        if (Path[N - 1].IO == 2)
                        {
                            Path[N - 1].IO = 0;           // can not enter and leave at same time 
                            NoOfInside = NoOfInside - 1;  // excepts if it touches the border
                        }
                        else if (Path[N - 1].IO == 1)
                        {
                            Path[N - 1].IO = 3;           // a leaving point
                        }

                        if (N - NS > 1)
                        {
                            if (Path[N - 2].IO == 2)
                            {
                                // check if n-2 and n-1 are on the same edge; if yes then n-1=n-2=0
                                if (CheckSameSide(N - 2, N - 1))
                                {
                                    Path[N - 2].IO = 0;
                                    Path[N - 1].IO = 0;
                                    NoOfInside = NoOfInside - 2;
                                }
                            }
                        }
                    }

                    PreviousIsIn = PresentIsIn;
                    PreviousIsOut = PresentIsOut;
                }
                else if (Path[N].T == 2)             // it is an end of path and was already treated
                {

                    // NS + 1 
                    PresentIsIn = IsPtInQuad(NS + 1);  // so re-check points 1 and 2 of path
                    PresentIsOut = !PresentIsIn;
                    if (PreviousIsIn & PresentIsOut)
                    {
                        if (Path[N].IO == 2)
                        {
                            Path[N].IO = 0;            // a false entry 
                            NoOfInside = NoOfInside - 1;
                        }
                        else if (Path[N].IO == 1)
                        {
                            Path[N].IO = 3;
                        }

                        if (Path[N - 1].IO == 2)
                        {
                            if (CheckSameSide(N - 1, N))
                            {
                                Path[N].IO = 0;
                                Path[N - 1].IO = 0;
                                NoOfInside = NoOfInside - 2;
                            }
                        }
                    }

                    PreviousIsIn = PresentIsIn;
                    PreviousIsOut = PresentIsOut;
                    // NS + 2
                    PresentIsIn = IsPtInQuad(NS + 2);
                    PresentIsOut = !PresentIsIn;
                    if (PreviousIsIn & PresentIsOut)
                    {
                        if (Path[NS + 1].IO == 2)
                        {
                            Path[NS + 1].IO = 0; // a false entry 
                            NoOfInside = NoOfInside - 1;
                        }
                        else if (Path[NS + 1].IO == 1)
                        {
                            Path[NS + 1].IO = 3;
                        }

                        if (Path[N].IO == 2)
                        {
                            if (CheckSameSide(N, NS + 1))
                            {
                                Path[NS + 1].IO = 0;
                                Path[N].IO = 0;
                                NoOfInside = NoOfInside - 2;
                            }
                        }
                    }
                }
            }

            NoOfQPts = 4;
            var loopTo1 = NoOfPathPts;
            for (N = 1; N <= loopTo1; N++)
            {
                // Debug.Print("Pt#" & N & "   Type=" & Path(N).T.ToString & "   IO=" & Path(N).IO.ToString)
                if (Path[N].IO == 2)
                    NoOfQPts = NoOfQPts + 1;
                if (Path[N].IO == 3)
                    NoOfQPts = NoOfQPts + 1;
            }
            // Debug.Print(NoOfInside)

            QPts = new QuadPt[NoOfQPts + 1];
            MakeQuadCorners();
            Q = 5;
            var loopTo2 = NoOfPathPts;
            for (N = 1; N <= loopTo2; N++)
            {
                if (Path[N].IO == 2)
                {
                    MakeQuadPoint(2, N, Q);
                    Q = Q + 1;
                }

                if (Path[N].IO == 3)
                {
                    MakeQuadPoint(3, N, Q);
                    Q = Q + 1;
                }
            }

            Array.Sort(QPts, 1, NoOfQPts);
        }

        private void MakeQuadPoint(int T, int N, int Q)
        {
            QPts[Q].T = T;
            QPts[Q].X = Path[N].X;
            QPts[Q].Y = Path[N].Y;
            QPts[Q].I = N;
            if (Path[N].Y == NLat)
            {
                QPts[Q].D = (Path[N].X - WLon) / DLon;
                return;
            }

            if (Path[N].Y == SLat)
            {
                QPts[Q].D = 2d + (ELon - Path[N].X) / DLon;
                return;
            }

            if (Path[N].X == ELon)
            {
                QPts[Q].D = 1d + (NLat - Path[N].Y) / DLat;
                return;
            }

            if (Path[N].X == WLon)
            {
                QPts[Q].D = 3d + (Path[N].Y - SLat) / DLat;
                return;
            }
        }

        private void MakeQuadCorners()
        {
            QPts[1].X = WLon;
            QPts[1].Y = NLat;
            QPts[1].T = 1;
            QPts[1].D = 0d;
            QPts[2].X = ELon;
            QPts[2].Y = NLat;
            QPts[2].T = 1;
            QPts[2].D = 1d;
            QPts[3].X = ELon;
            QPts[3].Y = SLat;
            QPts[3].T = 1;
            QPts[3].D = 2d;
            QPts[4].X = WLon;
            QPts[4].Y = SLat;
            QPts[4].T = 1;
            QPts[4].D = 3d;
        }

        private bool CheckSameSide(int J, int K)
        {
            bool CheckSameSideRet = default;
            CheckSameSideRet = true;
            if (Path[J].X == WLon)
            {
                if (Path[K].X == WLon)
                    return CheckSameSideRet;
            }

            if (Path[J].X == ELon)
            {
                if (Path[K].X == ELon)
                    return CheckSameSideRet;
            }

            if (Path[J].Y == NLat)
            {
                if (Path[K].Y == NLat)
                    return CheckSameSideRet;
            }

            if (Path[J].Y == SLat)
            {
                if (Path[K].Y == SLat)
                    return CheckSameSideRet;
            }

            CheckSameSideRet = false;
            return CheckSameSideRet;
        }

        internal void InsertLatCrossing(double LA)
        {
            int N;
            double D;
            double Y1, Y0;
            double X1, X0;
            N = 1;
            do
            {
                if (!(Path[N].T == 0))
                {
                    Y0 = Path[N - 1].Y;
                    Y1 = Path[N].Y;
                    if (Y0 < LA & Y1 > LA | Y0 > LA & Y1 < LA)
                    {
                        X0 = Path[N - 1].X;
                        X1 = Path[N].X;
                        D = (X1 - X0) / (Y1 - Y0);
                        X0 = D * (LA - Y1);
                        X1 = X1 + X0;
                        InsertPointInPath(X1, LA, N);
                        N = N + 1;
                    }
                }

                N = N + 1;
            }
            while (N <= NoOfPathPts);
        }

        internal void InsertLonCrossing(double LO)
        {
            int N;
            double D;
            double Y1, Y0;
            double X1, X0;
            N = 1;
            do
            {
                if (!(Path[N].T == 0))
                {
                    X0 = Path[N - 1].X;
                    X1 = Path[N].X;
                    if (X0 < LO & X1 > LO | X0 > LO & X1 < LO)
                    {
                        Y0 = Path[N - 1].Y;
                        Y1 = Path[N].Y;
                        D = (Y1 - Y0) / (X1 - X0);
                        Y0 = D * (X1 - LO);
                        Y1 = Y1 - Y0;
                        InsertPointInPath(LO, Y1, N);
                        N = N + 1;
                    }
                }

                N = N + 1;
            }
            while (N <= NoOfPathPts);
        }

        internal void InsertPointInPath(double X, double Y, int Point)
        {
            int K;
            NoOfPathPts = NoOfPathPts + 1;
            Array.Resize(ref Path, NoOfPathPts + 1);
            var loopTo = Point;
            for (K = NoOfPathPts - 1; K >= loopTo; K -= 1)
                Path[K + 1] = Path[K];
            Path[Point].Y = Y;
            Path[Point].X = X;
            Path[Point].T = 1;
        }

        private bool IsPtInQuad(int N)
        {
            bool IsPtInQuadRet = default;

            // checks if point N of Path is inside the borders of quad
            // if exactly on the border, returns true

            IsPtInQuadRet = false;
            if (Path[N].Y > NLat)
                return IsPtInQuadRet;
            if (Path[N].Y < SLat)
                return IsPtInQuadRet;
            if (Path[N].X < WLon)
                return IsPtInQuadRet;
            if (Path[N].X > ELon)
                return IsPtInQuadRet;
            IsPtInQuadRet = true;
            return IsPtInQuadRet;
        }

        private bool IsLLInQuad(double lat, double lon)
        {
            bool IsLLInQuadRet = default;

            // checks if (lon, lat) is inside the borders of quad
            // if exactly on the border, returns true

            IsLLInQuadRet = false;
            if (lat > NLat)
                return IsLLInQuadRet;
            if (lat < SLat)
                return IsLLInQuadRet;
            if (lon < WLon)
                return IsLLInQuadRet;
            if (lon > ELon)
                return IsLLInQuadRet;
            IsLLInQuadRet = true;
            return IsLLInQuadRet;
        }

        private bool IsPtInPath(double Y, double X)
        {
            bool IsPtInPathRet = default;

            // checks point of longitude=x and latitude=y is inside the path

            int N;
            double X1;
            double Y1;
            double X0;
            double Y0;
            double CP;  // to make cross product

            // test = going to infinitum_north and counting the jumps across borders
            IsPtInPathRet = false;
            var loopTo = NoOfPathPts;
            for (N = 1; N <= loopTo; N++)
            {
                if (Path[N].T == 0)
                    goto next_N;
                Y1 = Path[N].Y;
                Y0 = Path[N - 1].Y;
                if (Y1 == Y0)
                    goto next_N;
                if (Y <= Y1 & Y <= Y0)
                    goto next_N;
                if (Y > Y1 & Y > Y0)
                    goto next_N;
                X1 = Path[N].X;
                X0 = Path[N - 1].X;
                if (X < X1 & X < X0)
                {
                    IsPtInPathRet = !IsPtInPathRet;
                    goto next_N;
                }

                if (X > X1 & X > X0)
                    goto next_N;
                CP = (X1 - X0) * (Y - Y0) / (Y1 - Y0) + X0;
                if (X < CP)
                    IsPtInPathRet = !IsPtInPathRet;
                next_N:
                ;
            }

            return IsPtInPathRet;
        }

        internal void Clip2Quad()
        {
            int N, K;
            double lat, lon;
            if (AllInside)  // if all points inside the quad, path into slices and exit
            {
                AddAllToSlices();
                return;
            }

            if (NoneInside)
            {
                if (IsPtInPath(CLat, CLon) == false)  // center of quad inside poly?
                {
                    return;   // the quad has nothing to do with the poly
                }
                else
                {
                    AddFullSlice(); // no points because the whole quad is inside poly
                    return;
                }
            }

            // we get here, meaning that there are points inside and points outside
            if (NoOfQPts == 4)     // no crossings meaning there is a hole inside
            {
                AddFullSlice();
                var loopTo = NoOfChilds;
                for (N = 1; N <= loopTo; N++)
                {
                    lat = modulePOLYS.Polys[modulePOLYS.Polys[PolyIndex].Childs[N]].GPoints[1].lat;
                    lon = modulePOLYS.Polys[modulePOLYS.Polys[PolyIndex].Childs[N]].GPoints[1].lon;
                    if (IsLLInQuad(lat, lon))
                    {
                        // Slices(1).NC = Slices(1).NC + 1
                        // ReDim Preserve Slices(1).C(Slices(1).NC)
                        // Slices(1).C(Slices(1).NC) = Slices(1).NC + 1
                        AddHoleSlice(N, 1);
                    }
                }

                return;
            }

            int Rest;    // Remaining points in QPts
            Rest = NoOfQPts - 4;
            int M;       // index to Quad Points
            int Mi;      // initial M
            int I;       // index to Path Points
            int C = 0;   // to count Consumed "NoOfInside" points
            moduleMAIN.Slice S;
            S.P = new moduleMAIN.Double_XY[NoOfPathPts + 1]; // just in case!
            do
            {
                M = 1;
                K = 1;
                // get the index of an unused entry point  
                while (QPts[M].T != 2)
                    M = IncrementM(M);
                Mi = M;
                // starting the creation of polygon
                do
                {
                    I = QPts[M].I;   // start with this I
                    QPts[M].T = 0;   // mark as used
                    Rest = Rest - 1;
                    do
                    {
                        S.P[K].X = Path[I].X;
                        S.P[K].Y = Path[I].Y;
                        C = C + 1;
                        K = K + 1;
                        I = IncrementI(I);
                    }
                    while (Path[I].IO != 3);
                    S.P[K].X = Path[I].X;
                    S.P[K].Y = Path[I].Y;
                    C = C + 1;
                    K = K + 1;
                    M = GetQPtFromPath(I);
                    QPts[M].T = 0;    // used
                    Rest = Rest - 1;
                    M = IncrementM(M);
                    while (QPts[M].T == 1)
                    {
                        S.P[K].X = QPts[M].X;
                        S.P[K].Y = QPts[M].Y;
                        M = IncrementM(M);
                        K = K + 1;
                    }
                }
                while (M != Mi);
                moduleMAIN.NoOfSlices = moduleMAIN.NoOfSlices + 1;
                Array.Resize(ref moduleMAIN.Slices, moduleMAIN.NoOfSlices + 1);
                moduleMAIN.Slices[moduleMAIN.NoOfSlices].N = K - 1;
                moduleMAIN.Slices[moduleMAIN.NoOfSlices].P = new moduleMAIN.Double_XY[moduleMAIN.Slices[moduleMAIN.NoOfSlices].N + 1];
                moduleMAIN.Slices[moduleMAIN.NoOfSlices].NC = 0;
                var loopTo1 = moduleMAIN.Slices[moduleMAIN.NoOfSlices].N;
                for (K = 1; K <= loopTo1; K++)
                {
                    moduleMAIN.Slices[moduleMAIN.NoOfSlices].P[K].X = S.P[K].X;
                    moduleMAIN.Slices[moduleMAIN.NoOfSlices].P[K].Y = S.P[K].Y;
                }

                K = K - 1;
                moduleMAIN.Slices[moduleMAIN.NoOfSlices].P[0].X = S.P[K].X;
                moduleMAIN.Slices[moduleMAIN.NoOfSlices].P[0].Y = S.P[K].Y;
            }
            while (Rest > 1);
            Rest = NoOfInside - C;   // Rest is now used for unused Inside points
            int NOfS = moduleMAIN.NoOfSlices;
            var loopTo2 = NoOfChilds;
            for (C = 1; C <= loopTo2; C++)
            {
                if (modulePOLYS.Polys[modulePOLYS.Polys[PolyIndex].Childs[C]].NoOfPoints <= Rest)
                {
                    var loopTo3 = NOfS;
                    for (N = 1; N <= loopTo3; N++)
                    {
                        if (ChildInSlice(C, N))
                        {
                            // add slice
                            AddHoleSlice(C, N);
                            Rest = Rest - modulePOLYS.Polys[modulePOLYS.Polys[PolyIndex].Childs[C]].NoOfPoints;
                            break;
                        }
                    }

                    if (Rest < 3)
                        break;
                }
            }
        }

        private bool ChildInSlice(int C, int N)
        {
            bool ChildInSliceRet = default;
            ChildInSliceRet = false;
            int K;
            double lat, lon;
            var loopTo = modulePOLYS.Polys[modulePOLYS.Polys[PolyIndex].Childs[C]].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
            {
                lat = modulePOLYS.Polys[modulePOLYS.Polys[PolyIndex].Childs[C]].GPoints[K].lat;
                lon = modulePOLYS.Polys[modulePOLYS.Polys[PolyIndex].Childs[C]].GPoints[K].lon;
                if (!IsPtInSlice(lat, lon, N))
                    return ChildInSliceRet;
            }

            ChildInSliceRet = true;
            return ChildInSliceRet;
        }

        private bool IsPtInSlice(double Y, double X, int I)
        {
            bool IsPtInSliceRet = default;

            // checks point of longitude=x and latitude=y is inside slice I

            int N;
            double X1;
            double Y1;
            double X0;
            double Y0;
            double CP;  // to make cross product

            // test = going to infinitum_north and counting the jumps across borders
            IsPtInSliceRet = false;
            var loopTo = moduleMAIN.Slices[I].N;
            for (N = 1; N <= loopTo; N++)
            {
                // If Path(N).T = 0 Then GoTo next_N
                Y1 = moduleMAIN.Slices[I].P[N].Y;
                Y0 = moduleMAIN.Slices[I].P[N - 1].Y;
                if (Y1 == Y0)
                    goto next_N;
                if (Y <= Y1 & Y <= Y0)
                    goto next_N;
                if (Y > Y1 & Y > Y0)
                    goto next_N;
                X1 = moduleMAIN.Slices[I].P[N].X;
                X0 = moduleMAIN.Slices[I].P[N - 1].X;
                if (X < X1 & X < X0)
                {
                    IsPtInSliceRet = !IsPtInSliceRet;
                    goto next_N;
                }

                if (X > X1 & X > X0)
                    goto next_N;
                CP = (X1 - X0) * (Y - Y0) / (Y1 - Y0) + X0;
                if (X < CP)
                    IsPtInSliceRet = !IsPtInSliceRet;
                next_N:
                ;
            }

            return IsPtInSliceRet;
        }

        private int IncrementI(int I)
        {
            int IncrementIRet = default;
            if (Path[I].T == 2)
            {
                do
                    I = I - 1;
                while (Path[I].T == 1);
            }

            IncrementIRet = I + 1;
            return IncrementIRet;
        }

        private int IncrementM(int M)
        {
            int IncrementMRet = default;
            IncrementMRet = M + 1;
            if (IncrementMRet > NoOfQPts)
                IncrementMRet = 1;
            return IncrementMRet;
        }

        private int GetQPtFromPath(int I)
        {
            int GetQPtFromPathRet = default;
            int N;
            GetQPtFromPathRet = 0;
            var loopTo = NoOfQPts;
            for (N = 1; N <= loopTo; N++)
            {
                if (QPts[N].I == I)
                {
                    GetQPtFromPathRet = N;
                    return GetQPtFromPathRet;
                }
            }

            return GetQPtFromPathRet;
        }

        private void AddFullSlice()
        {

            // create a slice with the 4 corners of the quad
            moduleMAIN.NoOfSlices = 1;
            moduleMAIN.Slices = new moduleMAIN.Slice[2];
            moduleMAIN.Slices[1].N = 4;
            moduleMAIN.Slices[1].NC = 0;
            moduleMAIN.Slices[1].P = new moduleMAIN.Double_XY[5];
            moduleMAIN.Slices[1].P[1].X = WLon;
            moduleMAIN.Slices[1].P[1].Y = NLat;
            moduleMAIN.Slices[1].P[2].X = ELon;
            moduleMAIN.Slices[1].P[2].Y = NLat;
            moduleMAIN.Slices[1].P[3].X = ELon;
            moduleMAIN.Slices[1].P[3].Y = SLat;
            moduleMAIN.Slices[1].P[4].X = WLon;
            moduleMAIN.Slices[1].P[4].Y = SLat;
        }

        private void AddHoleSlice(int C, int P)
        {

            // add poly hole C to parent slice P

            int K;
            int M = modulePOLYS.Polys[PolyIndex].Childs[C];
            moduleMAIN.Slices[P].NC = moduleMAIN.Slices[P].NC + 1;
            Array.Resize(ref moduleMAIN.Slices[P].C, moduleMAIN.Slices[P].NC + 1);
            // Slices(P).C(Slices(P).NC) = Slices(P).NC + 1  ' aqui

            moduleMAIN.NoOfSlices = moduleMAIN.NoOfSlices + 1;
            Array.Resize(ref moduleMAIN.Slices, moduleMAIN.NoOfSlices + 1);
            moduleMAIN.Slices[P].C[moduleMAIN.Slices[P].NC] = moduleMAIN.NoOfSlices; // aqui
            moduleMAIN.Slices[moduleMAIN.NoOfSlices].N = modulePOLYS.Polys[M].NoOfPoints;
            moduleMAIN.Slices[moduleMAIN.NoOfSlices].P = new moduleMAIN.Double_XY[moduleMAIN.Slices[moduleMAIN.NoOfSlices].N + 1];
            moduleMAIN.Slices[moduleMAIN.NoOfSlices].NC = -P;
            var loopTo = modulePOLYS.Polys[M].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
            {
                moduleMAIN.Slices[moduleMAIN.NoOfSlices].P[K].X = modulePOLYS.Polys[M].GPoints[K].lon;
                moduleMAIN.Slices[moduleMAIN.NoOfSlices].P[K].Y = modulePOLYS.Polys[M].GPoints[K].lat;
            }
        }

        private void AddAllToSlices()
        {
            int J, K, N, C;
            int M = modulePOLYS.Polys[PolyIndex].NoOfChilds;
            moduleMAIN.NoOfSlices = modulePOLYS.Polys[PolyIndex].NoOfChilds + 1;
            moduleMAIN.Slices = new moduleMAIN.Slice[moduleMAIN.NoOfSlices + 1];
            moduleMAIN.Slices[1].N = modulePOLYS.Polys[PolyIndex].NoOfPoints;
            moduleMAIN.Slices[1].P = new moduleMAIN.Double_XY[moduleMAIN.Slices[1].N + 1];
            moduleMAIN.Slices[moduleMAIN.NoOfSlices].NC = -1;
            var loopTo = modulePOLYS.Polys[PolyIndex].NoOfPoints;
            for (K = 1; K <= loopTo; K++)
            {
                moduleMAIN.Slices[1].P[K].X = modulePOLYS.Polys[PolyIndex].GPoints[K].lon;
                moduleMAIN.Slices[1].P[K].Y = modulePOLYS.Polys[PolyIndex].GPoints[K].lat;
            }

            moduleMAIN.Slices[1].NC = M;
            if (M > 0)
            {
                moduleMAIN.Slices[1].C = new int[M + 1];
                var loopTo1 = M;
                for (K = 1; K <= loopTo1; K++)
                {
                    moduleMAIN.Slices[1].C[K] = K + 1;
                    // Next
                    // For K = 1 To M
                    C = modulePOLYS.Polys[PolyIndex].Childs[K];
                    N = modulePOLYS.Polys[C].NoOfPoints;
                    moduleMAIN.Slices[K + 1].N = N;
                    moduleMAIN.Slices[K + 1].P = new moduleMAIN.Double_XY[N + 1];
                    moduleMAIN.Slices[K + 1].NC = -1;
                    var loopTo2 = N;
                    for (J = 1; J <= loopTo2; J++)
                    {
                        moduleMAIN.Slices[K + 1].P[J].X = modulePOLYS.Polys[C].GPoints[J].lon;
                        moduleMAIN.Slices[K + 1].P[J].Y = modulePOLYS.Polys[C].GPoints[J].lat;
                    }
                }
            }
        }

        internal void Fill2Quad()
        {
            if (NoneInside)
            {
                if (IsPtInPath(CLat, CLon) == false)  // center of quad inside poly?
                {
                    return;   // the quad has nothing to do with the poly
                }
                else
                {
                    AddFullSlice(); // no points because the whole quad is inside poly
                    return;
                }
            }
            else
            {
                AddFullSlice(); // one point at least so fill the quad
                return;
            }
        }
    }

    internal class ClipLine
    {

        // Friend Structure Fragment  ' for lines
        // Dim N As Long
        // Dim NC As Integer
        // Dim C() As Integer
        // Dim P() As Double_XYZW
        // End Structure

        // Friend Fragments() As Fragment
        // Friend NoOfFragments As Integer

        private moduleMAIN.Double_XYZW[] Path;
        private int NoOfPathPts = 0;

        internal void SetLine(int N)
        {

            // Fill Path with X Y data from Line N
            int J;
            NoOfPathPts = moduleLINES.Lines[N].NoOfPoints - 1;
            Path = new moduleMAIN.Double_XYZW[NoOfPathPts + 1];
            var loopTo = NoOfPathPts;
            for (J = 0; J <= loopTo; J++)
            {
                Path[J].X = moduleLINES.Lines[N].GLPoints[J + 1].lon;
                Path[J].Y = moduleLINES.Lines[N].GLPoints[J + 1].lat;
                Path[J].Z = moduleLINES.Lines[N].GLPoints[J + 1].alt;
                Path[J].W = moduleLINES.Lines[N].GLPoints[J + 1].wid;
            }
        }

        private int QMID;
        private double NLat, SLat, WLon, ELon;  // borders
        private double CLat, CLon, DLat, DLon;  // center and delta

        internal void SetQuad(int Q, double lat, double lon)
        {

            // set QMID, NLat, SLat, WLon, ELon, DLat, DLon giving the QMID
            // and a lat/lon point inside the quad

            QMID = Q;
            Q = (int)Math.Pow(2d, Q - 2);
            DLat = 90d / Q;  // delta lat: the height of the quad
            DLon = 120d / Q;  // delta lon: the width of the quad
            WLon = Conversion.Int((lon + 180d) / DLon) * DLon - 180d;
            ELon = WLon + DLon;
            NLat = 90d - Conversion.Int((90d - lat) / DLat) * DLat;
            SLat = NLat - DLat;
            CLat = (NLat + SLat) / 2d;
            CLon = (WLon + ELon) / 2d;

            // check how many times the polygon line enters this quad
            // and set a number of variables

            NoOfInside = 0;
            // NoOfEntries = 0
            FirstIn = 0;
            NoneInside = true;
            AllInside = true;
            bool PreviousIsOut = !IsPtInQuad(0);
            bool PresentIsIn;
            int N;
            if (PreviousIsOut)
                AllInside = false;
            var loopTo = NoOfPathPts;
            for (N = 1; N <= loopTo; N++)
            {
                PresentIsIn = IsPtInQuad(N);
                if (PresentIsIn)
                {
                    NoneInside = false;
                    NoOfInside = NoOfInside + 1;
                }
                else
                {
                    AllInside = false;
                }

                if (PreviousIsOut & PresentIsIn)
                {
                    if (FirstIn == 0)
                        FirstIn = N;
                }

                PreviousIsOut = !PresentIsIn;
            }
        }

        private bool AllInside;
        private bool NoneInside;
        private int NoOfInside;
        private int FirstIn;

        internal void InsertLatCrossing(double LA)
        {
            int N;
            double D;
            double Y1, Y0;
            double X1, X0;
            N = 1;
            do
            {
                Y0 = Path[N - 1].Y;
                Y1 = Path[N].Y;
                if (Y0 < LA & Y1 > LA | Y0 > LA & Y1 < LA)
                {
                    X0 = Path[N - 1].X;
                    X1 = Path[N].X;
                    D = (X1 - X0) / (Y1 - Y0);
                    X0 = D * (LA - Y1);
                    X1 = X1 + X0;
                    InsertPointInPath(X1, LA, N);
                    N = N + 1;
                }

                N = N + 1;
            }
            while (N <= NoOfPathPts);
        }

        internal void InsertLonCrossing(double LO)
        {
            int N;
            double D;
            double Y1, Y0;
            double X1, X0;
            N = 1;
            do
            {
                X0 = Path[N - 1].X;
                X1 = Path[N].X;
                if (X0 < LO & X1 > LO | X0 > LO & X1 < LO)
                {
                    Y0 = Path[N - 1].Y;
                    Y1 = Path[N].Y;
                    D = (Y1 - Y0) / (X1 - X0);
                    Y0 = D * (X1 - LO);
                    Y1 = Y1 - Y0;
                    InsertPointInPath(LO, Y1, N);
                    N = N + 1;
                }

                N = N + 1;
            }
            while (N <= NoOfPathPts);
        }

        internal void InsertPointInPath(double X, double Y, int Point)
        {
            int K;
            NoOfPathPts = NoOfPathPts + 1;
            Array.Resize(ref Path, NoOfPathPts + 1);
            var loopTo = Point;
            for (K = NoOfPathPts - 1; K >= loopTo; K -= 1)
                Path[K + 1] = Path[K];
            Path[Point].Y = Y;
            Path[Point].X = X;
            double Z = default, W = default;
            ZWFromXY(ref Z, ref W, X, Y, Point - 1, Point + 1);
            Path[Point].Z = Z;
            Path[Point].W = W;
        }

        private void ZWFromXY(ref double Z, ref double W, double x, double y, int P0, int P1)

        {
            double x0, y0, z0, w0, x1, y1, z1, w1, dx, dy;
            x0 = Path[P0].X;
            y0 = Path[P0].Y;
            z0 = Path[P0].Z;
            w0 = Path[P0].W;
            x1 = Path[P1].X;
            y1 = Path[P1].Y;
            z1 = Path[P1].Z;
            w1 = Path[P1].W;
            dx = x1 - x0;
            dy = y1 - y0;
            if (dy > dx)
            {
                y = (y1 - y) / dy;
                x = 1d - y;
                Z = y * z0 + x * z1;
                W = y * w0 + x * w1;
            }
            else
            {
                x = (x1 - x) / dx;
                y = 1d - x;
                Z = x * z0 + y * z1;
                W = x * w0 + y * w1;
            }
        }

        private bool IsPtInQuad(int N)
        {
            bool IsPtInQuadRet = default;

            // checks if point N of Path is inside the borders of quad
            // if exactly on the border, returns true

            IsPtInQuadRet = false;
            if (Path[N].Y > NLat)
                return IsPtInQuadRet;
            if (Path[N].Y < SLat)
                return IsPtInQuadRet;
            if (Path[N].X < WLon)
                return IsPtInQuadRet;
            if (Path[N].X > ELon)
                return IsPtInQuadRet;
            IsPtInQuadRet = true;
            return IsPtInQuadRet;
        }

        internal void Fragment2Quad()
        {
            int N;
            if (NoneInside)
                return;
            if (AllInside)  // if all points inside the quad, make a fragment with them and exit
            {
                moduleMAIN.NoOfFragments = moduleMAIN.NoOfFragments + 1;
                Array.Resize(ref moduleMAIN.Fragments, moduleMAIN.NoOfFragments + 1);
                moduleMAIN.Fragments[moduleMAIN.NoOfFragments].N = NoOfPathPts + 1;
                // Fragments(NoOfFragments).N = NoOfPathPts

                moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P = new moduleMAIN.Double_XYZW[NoOfPathPts + 1 + 1];
                var loopTo = NoOfPathPts + 1;
                for (N = 1; N <= loopTo; N++)
                {
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[N].X = Path[N - 1].X;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[N].Y = Path[N - 1].Y;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[N].Z = Path[N - 1].Z;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[N].W = Path[N - 1].W;
                }

                return;
            }

            // we get here, meaning that there are points inside and points outside
            // and there will be one fragment at least

            bool PreviousIsIn = false;
            bool PreviousIsOut = true;
            bool PresentIsOut;
            bool PresentIsIn;
            int K;
            K = 1; // index to fragments()
            var loopTo1 = NoOfPathPts;
            for (N = FirstIn; N <= loopTo1; N++)
            {
                PresentIsIn = IsPtInQuad(N);
                PresentIsOut = !PresentIsIn;
                if (PreviousIsOut & PresentIsIn)
                {
                    moduleMAIN.NoOfFragments = moduleMAIN.NoOfFragments + 1;
                    Array.Resize(ref moduleMAIN.Fragments, moduleMAIN.NoOfFragments + 1);
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P = new moduleMAIN.Double_XYZW[NoOfPathPts + 1];
                }

                if (PresentIsIn)
                {
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].X = Path[N].X;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].Y = Path[N].Y;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].Z = Path[N].Z;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].W = Path[N].W;
                    K = K + 1;
                }

                if (PreviousIsIn & PresentIsOut)
                {
                    Array.Resize(ref moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P, K);
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].N = K - 1;
                    K = 1;
                }

                PreviousIsOut = PresentIsOut;
                PreviousIsIn = PresentIsIn;
            }

            var loopTo2 = FirstIn - 1;
            for (N = 0; N <= loopTo2; N++)
            {
                PresentIsIn = IsPtInQuad(N);
                PresentIsOut = !PresentIsIn;
                if (PreviousIsOut & PresentIsIn)
                {
                    moduleMAIN.NoOfFragments = moduleMAIN.NoOfFragments + 1;
                    Array.Resize(ref moduleMAIN.Fragments, moduleMAIN.NoOfFragments + 1);
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P = new moduleMAIN.Double_XYZW[NoOfPathPts + 1];
                }

                if (PresentIsIn)
                {
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].X = Path[N].X;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].Y = Path[N].Y;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].Z = Path[N].Z;
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P[K].W = Path[N].W;
                    K = K + 1;
                }

                if (PreviousIsIn & PresentIsOut)
                {
                    Array.Resize(ref moduleMAIN.Fragments[moduleMAIN.NoOfFragments].P, K);
                    moduleMAIN.Fragments[moduleMAIN.NoOfFragments].N = K - 1;
                    K = 1;
                }

                PreviousIsOut = PresentIsOut;
                PreviousIsIn = PresentIsIn;
            }
        }
    }
}


// ORIGINAL FOLLOWS!


// Public Class SliceFill

// Private WP() As Double_XYZW ' the working polygon
// Private QQ() As Double_XY ' points inside the quad
// Private NP() As Double_XY
// Private IO() As Double

// 'Private Structure XYDouble
// '    Dim X As Double
// '    Dim Y As Double
// 'End Structure

// 'Private Structure Slice
// '    Dim N As Long
// '    Dim P() As XYDouble
// 'End Structure

// 'Public Slices() As Slice
// 'Public NoOfSlices As Integer


// ' HOW IT WORKS
// ' ************

// ' SetPoly  < sets the poligon that will be sliced
// ' SetQuad  < sets the quad 
// ' SlicePoly  < gets the slices of the set poly on the set quad

// Private NoOfChilds As Integer

// Public Sub SetPoly(ByVal N As Integer)

// ' Fill WP with X Y data from Polygon N
// Dim J As Integer

// NoOfWPPts = Polys(N).NoOfPoints
// ReDim WP(NoOfWPPts)
// For J = 1 To NoOfWPPts
// WP(J).X = Polys(N).GPoints(J).lon
// WP(J).Y = Polys(N).GPoints(J).lat
// Next
// WP(0).X = WP(J - 1).X
// WP(0).Y = WP(J - 1).Y

// End Sub

// Public Sub SetLine(ByVal N As Integer)

// ' Fill WP with X Y data from Polygon N
// Dim J As Integer

// NoOfWPPts = Lines(N).NoOfPoints - 1
// ReDim WP(NoOfWPPts)
// For J = 0 To NoOfWPPts
// WP(J).X = Lines(N).GLPoints(J + 1).lon
// WP(J).Y = Lines(N).GLPoints(J + 1).lat
// WP(J).Z = Lines(N).GLPoints(J + 1).alt
// WP(J).W = Lines(N).GLPoints(J + 1).wid
// Next

// End Sub


// Private QMID As Integer
// Private NLat, SLat, WLon, ELon As Double  ' borders
// Private CLat, CLon, DLat, DLon As Double  ' center and delta
// Public Sub SetQuad(ByVal Q As Integer, ByVal lat As Double, ByVal lon As Double)

// ' set QMID, NLat, SLat, WLon, ELon, DLat, DLon giving the QMID
// ' and a lat/lon point inside the quad

// QMID = Q
// Q = 2 ^ (Q - 2)
// DLat = CDbl(90 / Q)  ' delta lat: the height of the quad
// DLon = CDbl(120 / Q)  ' delta lon: the width of the quad

// WLon = Int((lon + 180) / DLon) * DLon - 180
// ELon = WLon + DLon
// NLat = 90 - Int((90 - lat) / DLat) * DLat
// SLat = NLat - DLat
// CLat = (NLat + SLat) / 2
// CLon = (WLon + ELon) / 2

// ' check how many times the polygon line enters this quad
// ' and set a number of variables

// NoOfInside = 0
// 'NoOfEntries = 0
// FirstIn = 0
// NoneInside = True
// AllInside = True

// Dim PreviousIsOut As Boolean = Not IsPtInQuad(0)
// Dim PresentIsIn As Boolean
// Dim N As Integer

// If PreviousIsOut Then AllInside = False

// For N = 1 To NoOfWPPts
// PresentIsIn = IsPtInQuad(N)
// If PresentIsIn Then
// NoneInside = False
// NoOfInside = NoOfInside + 1
// Else
// AllInside = False
// End If
// If PreviousIsOut And PresentIsIn Then
// If FirstIn = 0 Then FirstIn = N
// End If
// PreviousIsOut = Not PresentIsIn
// Next

// End Sub

// Private AllInside As Boolean
// Private NoneInside As Boolean
// Private NoOfInside As Integer
// Private NoOfWPPts As Integer
// Private NoOfQQPts As Integer
// Private FirstIn As Integer

// Public Sub InsertLatCrossing(ByVal LA As Double)

// Dim N As Integer
// Dim D As Double
// Dim Y1, Y0 As Double
// Dim X1, X0 As Double

// N = 1
// Do
// Y0 = WP(N - 1).Y
// Y1 = WP(N).Y
// If (Y0 < LA And Y1 > LA) Or (Y0 > LA And Y1 < LA) Then
// X0 = WP(N - 1).X
// X1 = WP(N).X
// D = (X1 - X0) / (Y1 - Y0)
// 'X = D * (lat  - Y1)
// X0 = D * (LA - Y1)
// X1 = X1 + X0
// InsertPointInWP(X1, LA, N)
// N = N + 1
// End If
// N = N + 1
// Loop While N <= NoOfWPPts


// End Sub


// Public Sub InsertLonCrossing(ByVal LO As Double)

// Dim N As Integer
// Dim D As Double
// Dim Y1, Y0 As Double
// Dim X1, X0 As Double

// N = 1
// Do
// X0 = WP(N - 1).X
// X1 = WP(N).X
// If (X0 < LO And X1 > LO) Or (X0 > LO And X1 < LO) Then
// Y0 = WP(N - 1).Y
// Y1 = WP(N).Y
// D = (Y1 - Y0) / (X1 - X0)
// 'Y = D * (X1 - LO)
// Y0 = D * (X1 - LO)
// Y1 = Y1 - Y0
// InsertPointInWP(LO, Y1, N)
// N = N + 1
// End If
// N = N + 1
// Loop While N <= NoOfWPPts


// End Sub

// Friend Sub InsertPointInWP(ByVal X As Double, ByVal Y As Double, ByVal Point As Integer)

// Dim K As Integer

// NoOfWPPts = NoOfWPPts + 1
// ReDim Preserve WP(NoOfWPPts)

// 'If Point = 1 Then Point = NoOfWPPts  ' never happens

// For K = NoOfWPPts - 1 To Point Step -1
// WP(K + 1) = WP(K)
// Next K

// WP(Point).Y = Y
// WP(Point).X = X

// Dim Z, W As Double
// ZWFromXY(Z, W, X, Y, Point - 1, Point + 1)
// WP(Point).Z = Z
// WP(Point).W = W

// 'WP(0).X = WP(NoOfWPPts).X  ' never happens
// 'WP(0).Y = WP(NoOfWPPts).Y

// End Sub

// Private Sub ZWFromXY(ByRef Z As Double, ByRef W As Double, _
// ByVal x As Double, ByVal y As Double, _
// ByVal P0 As Integer, ByVal P1 As Integer)

// Dim x0, y0, z0, w0, x1, y1, z1, w1, dx, dy As Double

// x0 = WP(P0).X
// y0 = WP(P0).Y
// z0 = WP(P0).Z
// w0 = WP(P0).W

// x1 = WP(P1).X
// y1 = WP(P1).Y
// z1 = WP(P1).Z
// w1 = WP(P1).W

// dx = x1 - x0
// dy = y1 - y0
// If dy > dx Then
// y = (y1 - y) / dy
// x = 1 - y
// Z = y * z0 + x * z1
// W = y * w0 + x * w1
// Else
// x = (x1 - x) / dx
// y = 1 - x
// Z = x * z0 + y * z1
// W = x * w0 + y * w1
// End If

// End Sub

// Public Sub FillPoly()

// If NoneInside Then
// If IsPtInPoly(CLat, CLon) = False Then  ' center of quad inside poly?
// Exit Sub   ' the quad has nothing to do with the poly
// Else
// AddFullSlice() ' no points because the whole quad is inside poly
// Exit Sub
// End If
// Else
// AddFullSlice() ' one point at least so fill the quad
// Exit Sub
// End If

// End Sub

// Public Sub SliceLine()

// Dim N As Integer

// If NoneInside Then Exit Sub

// If AllInside Then  ' if all points inside the quad, make a slice with them and exit
// NoOfSlices = NoOfSlices + 1
// ReDim Preserve Slices(NoOfSlices)
// Slices(NoOfSlices).N = NoOfWPPts + 1
// ' Slices(NoOfSlices).N = NoOfWPPts

// ReDim Slices(NoOfSlices).P(NoOfWPPts + 1)
// For N = 1 To NoOfWPPts + 1
// Slices(NoOfSlices).P(N).X = WP(N - 1).X
// Slices(NoOfSlices).P(N).Y = WP(N - 1).Y
// Slices(NoOfSlices).P(N).Z = WP(N - 1).Z
// Slices(NoOfSlices).P(N).W = WP(N - 1).W
// Next N
// Exit Sub
// End If

// ' we get here, meaning that there are points inside and points outside
// ' and there will be one slice at least

// Dim PreviousIsIn As Boolean = False
// Dim PreviousIsOut As Boolean = True
// Dim PresentIsOut As Boolean
// Dim PresentIsIn As Boolean

// Dim K As Integer

// K = 1 ' index to Slices()
// For N = FirstIn To NoOfWPPts
// PresentIsIn = IsPtInQuad(N)
// PresentIsOut = Not PresentIsIn
// If PreviousIsOut And PresentIsIn Then
// NoOfSlices = NoOfSlices + 1
// ReDim Preserve Slices(NoOfSlices)
// ReDim Slices(NoOfSlices).P(NoOfWPPts)
// End If
// If PresentIsIn Then
// Slices(NoOfSlices).P(K).X = WP(N).X
// Slices(NoOfSlices).P(K).Y = WP(N).Y
// Slices(NoOfSlices).P(K).Z = WP(N).Z
// Slices(NoOfSlices).P(K).W = WP(N).W
// K = K + 1
// End If
// If PreviousIsIn And PresentIsOut Then
// ReDim Preserve Slices(NoOfSlices).P(K - 1)
// Slices(NoOfSlices).N = K - 1
// K = 1
// End If
// PreviousIsOut = PresentIsOut
// PreviousIsIn = PresentIsIn
// Next

// For N = 0 To FirstIn - 1
// PresentIsIn = IsPtInQuad(N)
// PresentIsOut = Not PresentIsIn
// If PreviousIsOut And PresentIsIn Then
// NoOfSlices = NoOfSlices + 1
// ReDim Preserve Slices(NoOfSlices)
// ReDim Slices(NoOfSlices).P(NoOfWPPts)
// End If
// If PresentIsIn Then
// Slices(NoOfSlices).P(K).X = WP(N).X
// Slices(NoOfSlices).P(K).Y = WP(N).Y
// Slices(NoOfSlices).P(K).Z = WP(N).Z
// Slices(NoOfSlices).P(K).W = WP(N).W
// K = K + 1
// End If
// If PreviousIsIn And PresentIsOut Then
// ReDim Preserve Slices(NoOfSlices).P(K - 1)
// Slices(NoOfSlices).N = K - 1
// K = 1
// End If
// PreviousIsOut = PresentIsOut
// PreviousIsIn = PresentIsIn
// Next

// End Sub


// Public Sub SlicePoly()

// Dim N As Integer

// If AllInside Then  ' if all points inside the quad, make a slice with them and exit
// NoOfSlices = NoOfSlices + 1
// ReDim Preserve Slices(NoOfSlices)
// Slices(NoOfSlices).N = NoOfWPPts
// ReDim Slices(NoOfSlices).P(NoOfWPPts)
// For N = 1 To NoOfWPPts
// Slices(NoOfSlices).P(N).X = WP(N).X
// Slices(NoOfSlices).P(N).Y = WP(N).Y
// Next N
// Exit Sub
// End If

// If NoneInside Then
// If IsPtInPoly(CLat, CLon) = False Then  ' center of quad inside poly?
// Exit Sub   ' the quad has nothing to do with the poly
// Else
// AddFullSlice() ' no points because the whole quad is inside poly
// Exit Sub
// End If
// End If

// ' we get here, meaning that there are points inside and points outside
// ' prepare a new Poly called QQ to hold points that belong to the quad
// ' for each entry there will be a inner border point and an outer
// ' point that will be added to QQ

// NoOfQQPts = NoOfInside
// ReDim QQ(NoOfQQPts)
// ReDim IO(NoOfQQPts)

// SetQQPoly()  ' construct QQ() adding entry and exit points at the quad borders

// N = NoOfQQPts
// Do Until N < 2
// N = SliceFromQQ()
// Loop

// End Sub

// Private Function IsPtInQuad(ByVal N As Integer) As Boolean

// 'checks if point N of polygon WP is inside the borders of quad
// ' if on the border it is true

// IsPtInQuad = False
// If WP(N).Y > NLat Then Exit Function
// If WP(N).Y < SLat Then Exit Function
// If WP(N).X < WLon Then Exit Function
// If WP(N).X > ELon Then Exit Function
// IsPtInQuad = True

// End Function

// Private Sub AddFullSlice()

// ' create a slice with the 4 corners of the quad
// NoOfSlices = NoOfSlices + 1
// ReDim Preserve Slices(NoOfSlices)
// Slices(NoOfSlices).N = 4
// ReDim Slices(NoOfSlices).P(4)
// Slices(NoOfSlices).P(1).X = WLon
// Slices(NoOfSlices).P(1).Y = NLat
// Slices(NoOfSlices).P(2).X = ELon
// Slices(NoOfSlices).P(2).Y = NLat
// Slices(NoOfSlices).P(3).X = ELon
// Slices(NoOfSlices).P(3).Y = SLat
// Slices(NoOfSlices).P(4).X = WLon
// Slices(NoOfSlices).P(4).Y = SLat

// End Sub

// Private Sub SetQQPoly()

// ' check how many times the polygon line exits the quad

// Dim PreviousIsIn As Boolean = False
// Dim PreviousIsOut As Boolean = True
// Dim PresentIsOut As Boolean
// Dim PresentIsIn As Boolean

// Dim N, K As Integer

// K = 1 ' index to QQ()
// For N = FirstIn To NoOfWPPts
// PresentIsIn = IsPtInQuad(N)
// PresentIsOut = Not PresentIsIn
// If PresentIsIn Then
// QQ(K).X = WP(N).X
// QQ(K).Y = WP(N).Y
// IO(K) = -1
// End If
// If PreviousIsOut And PresentIsIn Then
// SetIOPoint(K, N)
// End If
// If PreviousIsIn And PresentIsOut Then
// SetIOPoint(K - 1, N - 1)
// End If
// If PresentIsIn Then K = K + 1
// PreviousIsOut = PresentIsOut
// PreviousIsIn = PresentIsIn
// Next

// For N = 1 To FirstIn - 1
// PresentIsIn = IsPtInQuad(N)
// PresentIsOut = Not PresentIsIn
// If PresentIsIn Then
// QQ(K).X = WP(N).X
// QQ(K).Y = WP(N).Y
// IO(K) = -1
// End If
// If PreviousIsOut And PresentIsIn Then
// SetIOPoint(K, N)
// End If
// If PreviousIsIn And PresentIsOut Then
// SetIOPoint(K - 1, N - 1)
// End If
// If PresentIsIn Then K = K + 1
// PreviousIsOut = PresentIsOut
// PreviousIsIn = PresentIsIn
// Next

// End Sub

// 'Private Sub SetEntryPoint(ByVal K As Integer, ByVal N As Integer)

// '    SetQuadTetas(N)

// '    Dim DY As Double = WP(N - 1).Y - WP(N).Y
// '    Dim DX As Double = WP(N - 1).X - WP(N).X
// '    Dim T As Double = Teta2(DY, DX)

// '    DY = -DY
// '    DX = -DX

// '    Dim M, A, B As Double   ' y = m x + b     m=dy/dx or  dx/dy   b=a/dx   or b=-a/dy

// '    If T > TetaNE And T <= TetaNW Then   ' the side is north = 1
// '        QQ(K).Y = NLat
// '        M = DX / DY
// '        A = WP(N - 1).X * WP(N).Y - WP(N - 1).Y * WP(N).X
// '        B = A / DY
// '        QQ(K).X = M * NLat + B
// '        IO(K) = (QQ(K).X - WLon) / DLon
// '    ElseIf T > TetaNW And T <= TetaSW Then ' the side is west = 4
// '        QQ(K).X = WLon
// '        M = DY / DX
// '        A = WP(N - 1).Y * WP(N).X - WP(N - 1).X * WP(N).Y
// '        B = A / DX
// '        QQ(K).Y = M * WLon + B
// '        IO(K) = 3 + (QQ(K).Y - SLat) / DLat
// '    ElseIf T > TetaSW And T <= TetaSE Then ' the side is south = 3
// '        QQ(K).Y = SLat
// '        M = DX / DY
// '        A = WP(N - 1).X * WP(N).Y - WP(N - 1).Y * WP(N).X
// '        B = A / DY
// '        QQ(K).X = M * SLat + B
// '        IO(K) = 2 + (ELon - QQ(K).X) / DLon
// '    Else ' the side is east = 2
// '        QQ(K).X = ELon
// '        M = DY / DX
// '        A = WP(N - 1).Y * WP(N).X - WP(N - 1).X * WP(N).Y
// '        B = A / DX
// '        QQ(K).Y = M * ELon + B
// '        IO(K) = 1 + (NLat - QQ(K).Y) / DLat
// '    End If

// 'End Sub

// 'Private Sub SetEntryPoint(ByVal K As Integer, ByVal N As Integer)

// '    Dim Y As Double = WP(N).Y
// '    Dim X As Double = WP(N).X

// '    QQ(K).Y = Y
// '    QQ(K).X = X

// '    If Y = NLat Then   ' the side is north = 1
// '        IO(K) = (X - WLon) / DLon
// '        Exit Sub
// '    End If

// '    If X = WLon Then ' the side is west = 4
// '        IO(K) = 3 + (Y - SLat) / DLat
// '        Exit Sub
// '    End If

// '    If Y = SLat Then ' the side is south = 3
// '        IO(K) = 2 + (ELon - X) / DLon
// '        Exit Sub
// '    End If

// '    If X = WLon Then ' the side is east = 2
// '        IO(K) = 1 + (NLat - Y) / DLat
// '        Exit Sub
// '    End If

// 'End Sub

// 'Private Sub SetExitPoint(ByVal K As Integer, ByVal N As Integer)

// '    SetQuadTetas(N - 1)

// '    Dim DY As Double = WP(N).Y - WP(N - 1).Y
// '    Dim DX As Double = WP(N).X - WP(N - 1).X
// '    Dim T As Double = Teta2(DY, DX)

// '    Dim M, A, B As Double   ' y = m x + b     m=dy/dx or  dx/dy   b=a/dx   or -a/dy

// '    If T > TetaNE And T <= TetaNW Then   ' the side is north = 1
// '        QQ(K).Y = NLat
// '        M = DX / DY
// '        A = WP(N - 1).X * WP(N).Y - WP(N - 1).Y * WP(N).X
// '        B = A / DY
// '        QQ(K).X = M * NLat + B
// '        IO(K) = (QQ(K).X - WLon) / DLon
// '    ElseIf T > TetaNW And T <= TetaSW Then ' the side is west = 4
// '        QQ(K).X = WLon
// '        M = DY / DX
// '        A = WP(N - 1).Y * WP(N).X - WP(N - 1).X * WP(N).Y
// '        B = A / DX
// '        QQ(K).Y = M * WLon + B
// '        IO(K) = 3 + (QQ(K).Y - SLat) / DLat
// '    ElseIf T > TetaSW And T <= TetaSE Then ' the side is south = 3
// '        QQ(K).Y = SLat
// '        M = DX / DY
// '        A = WP(N - 1).X * WP(N).Y - WP(N - 1).Y * WP(N).X
// '        B = A / DY
// '        QQ(K).X = M * SLat + B
// '        IO(K) = 2 + (ELon - QQ(K).X) / DLon
// '    Else ' the side is east = 2
// '        QQ(K).X = ELon
// '        M = DY / DX
// '        A = WP(N - 1).Y * WP(N).X - WP(N - 1).X * WP(N).Y
// '        B = A / DX
// '        QQ(K).Y = M * ELon + B
// '        IO(K) = 1 + (NLat - QQ(K).Y) / DLat
// '    End If

// 'End Sub

// Private Sub SetIOPoint(ByVal K As Integer, ByVal N As Integer)

// Dim Y As Double = WP(N).Y
// Dim X As Double = WP(N).X

// If Y = NLat Then   ' the side is north = 1
// IO(K) = (X - WLon) / DLon
// Exit Sub
// End If

// If X = WLon Then ' the side is west = 4
// IO(K) = 3 + (Y - SLat) / DLat
// Exit Sub
// End If

// If Y = SLat Then ' the side is south = 3
// IO(K) = 2 + (ELon - X) / DLon
// Exit Sub
// End If

// If X = ELon Then ' the side is east = 2
// IO(K) = 1 + (NLat - Y) / DLat
// Exit Sub
// End If


// End Sub


// 'Private Sub SetQuadTetas(ByVal N As Integer)

// '    ' set TetaNW TetaNE TetaSE TetaSW - the argument of the
// '    ' corners of quad using WP(N) as the origin

// '    TetaNW = Teta2(NLat - WP(N).Y, WLon - WP(N).X)
// '    TetaNE = Teta2(NLat - WP(N).Y, ELon - WP(N).X)
// '    TetaSE = Teta2(SLat - WP(N).Y, ELon - WP(N).X)
// '    TetaSW = Teta2(SLat - WP(N).Y, WLon - WP(N).X)

// 'End Sub

// Private Function Teta2(ByVal DY As Double, ByVal DX As Double) As Double

// If DY = 0 Then
// If DX < 0 Then
// Teta2 = PI
// Exit Function
// End If
// End If

// If DX = 0 Then  'dy = 0 is impossible to get here
// If DY > 0 Then Teta2 = PI / 2
// If DY < 0 Then Teta2 = 3 * PI / 2
// Exit Function
// End If

// Teta2 = Math.Atan2(DY, DX)
// If Teta2 < 0 Then Teta2 = Teta2 + 2 * PI

// End Function

// Private Function IsPtInPoly(ByVal y As Double, ByVal x As Double) As Boolean

// ' checks point of longitude=x and latitude=y is inside WP

// Dim N, S As Integer
// Dim X1 As Double, Y1 As Double
// Dim X0 As Double, Y0 As Double
// Dim CP As Double  ' to make cross product

// IsPtInPoly = False

// S = NoOfWPPts

// For N = 2 To S
// Y1 = WP(N).Y
// Y0 = WP(N - 1).Y
// If Y1 = Y0 Then GoTo next_N
// If y <= Y1 And y <= Y0 Then GoTo next_N
// If y > Y1 And y > Y0 Then GoTo next_N
// X1 = WP(N).X
// X0 = WP(N - 1).X
// If x < X1 And x < X0 Then
// IsPtInPoly = Not IsPtInPoly
// GoTo next_N
// End If
// If x > X1 And x > X0 Then GoTo next_N
// CP = (X1 - X0) * (y - Y0) / (Y1 - Y0) + X0
// If x < CP Then IsPtInPoly = Not IsPtInPoly

// next_N:
// Next N

// Y1 = WP(1).Y
// Y0 = WP(S).Y

// If Y0 = Y1 Then Exit Function
// If y <= Y1 And y <= Y0 Then Exit Function
// If y > Y1 And y > Y0 Then Exit Function
// X1 = WP(1).X
// X0 = WP(S).X
// If x < X1 And x < X0 Then
// IsPtInPoly = Not IsPtInPoly
// Exit Function
// End If
// If x > X1 And x > X0 Then Exit Function

// CP = (X1 - X0) * (y - Y0) / (Y1 - Y0) + X0
// If x < CP Then IsPtInPoly = Not IsPtInPoly

// End Function


// Private Function SliceFromQQ() As Integer

// Dim N, M, K, C As Integer

// Dim SKPQQ() As Double_XY  ' SKP = skip poly 
// Dim SKPIO() As Double
// Dim AP As Double_XY

// Dim K1, K2 As Integer
// Dim L1, L2 As Double

// ' examine points in QQ and copy to NP those points
// ' that form a good Slice poly. Insert corners if needed
// ' when finish construct QQ with unused or left points

// ' construt NP <<< new poly

// ReDim NP(NoOfQQPts + 15)   'Taburet error 7 in December 2004  ????
// ReDim SKPQQ(NoOfQQPts)
// ReDim SKPIO(NoOfQQPts)

// ' get side of first point (N=0 W=3 S=2 E=1) and initiate NP
// L1 = IO(1)
// NP(1) = QQ(1)

// M = 2 ' M points to NP
// N = 2 ' N points to QQ
// K = 1 ' K points to SKPQQ

// ' go until you get a border. Keep points
// Do
// NP(M) = QQ(N)
// M = M + 1
// N = N + 1
// Loop While IO(N - 1) = -1
// ' here N and M point to next free indexes

// L2 = IO(N - 1)

// Return_Here:
// If N >= NoOfQQPts Then GoTo all_done

// ' now we turn clockwise
// ' if next point not on "clockwise rest of L2 border" skip set that follows
// ' otherwise keep in
// ' it is not like this!
// ' actually the next point could be in rest of the same border but a future point
// ' could be more close! in April 18 2004

// ' parameters L2 and M are called by reference
// If TakeNext(L1, L2, N, M) = False Then  ' skip points
// Do
// SKPQQ(K) = QQ(N)
// SKPIO(K) = IO(N)
// N = N + 1
// K = K + 1
// Loop While IO(N) = -1
// SKPQQ(K) = QQ(N)
// SKPIO(K) = IO(N)
// K = K + 1
// N = N + 1
// Else                                    ' keep points
// NP(M) = QQ(N)
// M = M + 1
// N = N + 1
// Do
// NP(M) = QQ(N)
// M = M + 1
// N = N + 1
// Loop While IO(N - 1) = -1
// L2 = IO(N - 1)
// End If

// GoTo Return_Here

// all_done:

// 'K1 = Int(L1 / 255)   ' October 8
// 'K2 = Int(L2 / 255)

// K1 = Int(L1)
// K2 = Int(L2)

// C = K1 - K2
// If C < 0 Then C = C + 4
// If C = 0 Then
// If L2 >= L1 Then C = 4
// If L2 = L1 Then ' added in September 2004
// If NPIsClock(M - 1, K2) Then C = 0
// End If
// End If

// Dim NoOfNPPts = M - 1 + C
// 'NP.N = M - 1 + C
// ReDim Preserve NP(NoOfNPPts)
// For N = 1 To C
// AP = Corner(L2, N)
// NP(M).X = AP.X
// NP(M).Y = AP.Y
// M = M + 1
// Next N

// N = NoOfSlices + 1
// NoOfSlices = N
// ReDim Preserve Slices(N)
// Slices(N).N = NoOfNPPts
// ReDim Slices(N).P(NoOfNPPts)
// For M = 1 To NoOfNPPts
// Slices(N).P(M).X = NP(M).X
// Slices(N).P(M).Y = NP(M).Y
// Next M

// skip_this:
// 'SliceFromQQ = K 
// 'If K > 1 Then
// '    ReDim Preserve SKPQQ(K - 1)
// '    QQ = SKPQQ
// 'End If

// NoOfQQPts = K - 1
// SliceFromQQ = NoOfQQPts
// If NoOfQQPts > 1 Then
// ReDim QQ(NoOfQQPts)
// ReDim IO(NoOfQQPts)
// For K = 1 To NoOfQQPts
// QQ(K) = SKPQQ(K)
// IO(K) = SKPIO(K)
// Next
// End If



// End Function

// Private Function TakeNext(ByVal L1 As Double, ByRef L2 As Double, ByVal N As Integer, ByRef M As Integer) As Boolean

// ' if true means that the next segment of QQ starting at N should be included in NP
// ' it starts looking to the clockwise side of L2 until the clockwise next corner.

// Dim K, P, PX As Double
// Dim C As Integer, Flag As Boolean

// Re_Do:
// ' If L2 = 1020 Then L2 = 0
// If L2 = 4 Then L2 = 0
// TakeNext = False

// ' changed 8 October
// 'K = Int((L2) / 255)
// 'If K = 0 Then K = 255
// 'If K = 1 Then K = 510
// 'If K = 2 Then K = 765
// 'If K = 3 Then K = 1020

// K = 1
// If L2 >= 1 Then K = 2
// If L2 >= 2 Then K = 3
// If L2 >= 3 Then K = 4



// 'P = GetBPSide(BP.P(N))
// P = IO(N)

// ' if L1 and L2 are on the same edge with L1 clockwise of L2
// ' then if and P not between L1 and L2 >>> skip next
// If L1 > L2 And L1 < K Then If P > L1 Or P < L2 Then Exit Function

// ' if next segment starts to the clockwise of L2 and before the corner
// ' and if there is no one nearer then take it

// If P >= L2 And P <= K Then

// ' added April 18
// 'For C = N + 1 To BP.N
// '    If BP.P(C).IO = 1 Then
// '        PX = GetBPSide(BP.P(C))
// '        If PX >= L2 And PX < P Then Exit Function
// '    End If
// 'Next C
// For C = N + 1 To NoOfQQPts
// If IO(C) >= 0 Then
// PX = IO(C)              ' DEVE SER ENTRY?
// If PX >= L2 And PX < P Then Exit Function
// End If
// Next C
// ' end of April 18

// TakeNext = True
// Exit Function
// End If

// ' so P is not on the clockwise rest of the edge! so check if there are more intersections
// Flag = False
// For C = N + 1 To NoOfQQPts
// If IO(C) >= 0 Then
// PX = IO(C)
// If PX > L2 And PX <= K Then Flag = True 'september 2004 was If px >= L2 And px <= K Then Flag = True
// End If
// Next C

// ' if there is no more intersects then add corner and increment L2
// If Flag Then
// Exit Function
// End If

// Dim AP As Double_XY = Corner(L2, 1)
// NP(M).X = AP.X
// NP(M).Y = AP.Y
// M = M + 1

// L2 = K
// GoTo Re_Do

// End Function

// Private Function Corner(ByVal L2 As Double, ByVal N As Integer) As Double_XY

// ' return the coordinates of the "next" (if N=1) "next next" (if N=2) clockwise
// ' corner that follows L2

// Dim K As Integer

// 'K = (Int(L2 / 255) + N) Mod 4
// K = (Int(L2) + N) Mod 4

// If K = 0 Then   ' corner 0 = NW
// Corner.X = WLon
// Corner.Y = NLat
// Exit Function
// End If
// If K = 1 Then   ' corner 1 = NE
// Corner.X = ELon
// Corner.Y = NLat
// Exit Function
// End If
// If K = 2 Then   ' corner 2 = SE
// Corner.X = ELon
// Corner.Y = SLat
// Exit Function
// End If
// If K = 3 Then   ' corner 3 = SW
// Corner.X = WLon
// Corner.Y = SLat
// Exit Function
// End If

// End Function

// Private Function NPIsClock(ByVal S As Integer, ByVal L As Integer) As Boolean

// Dim N, M As Integer
// Dim lat As Double, LatN As Double
// Dim X1 As Double, Y1 As Double
// Dim X2 As Double, Y2 As Double
// Dim X3 As Double, Y3 As Double

// If L <> 2 Then  ' not 2 points in south !!!

// ' get southest point in M (if 2 then the right most)
// lat = NP(1).Y
// M = 1
// For N = 2 To S
// LatN = NP(N).Y
// If LatN >= lat Then
// If LatN > lat Then
// M = N
// lat = LatN
// Else
// If NP(N).X > NP(M).X Then
// M = N
// lat = LatN
// End If
// End If
// End If
// Next N

// ' form the vectors M-1>M  and M>M+1  (1>2 2>3)
// X2 = NP(M).X
// Y2 = 255 - NP(M).Y
// If M = 1 Then
// X1 = NP(S).X
// Y1 = NP(S).Y
// Else
// X1 = NP(M - 1).X
// Y1 = NP(M - 1).Y
// End If
// If M = S Then
// X3 = NP(1).X
// Y3 = NP(1).Y
// Else
// X3 = NP(M + 1).X
// Y3 = NP(M + 1).Y
// End If

// ' vector 1>2 in 1 and 2>3 in 2 then cross product in x3
// X1 = X2 - X1
// Y1 = Y2 - Y1
// X2 = X3 - X2
// Y2 = Y3 - Y2

// X3 = X1 * Y2 - Y1 * X2

// NPIsClock = False

// If X3 < 0 Then NPIsClock = True ' is  clock wise

// Exit Function

// Else

// ' get eastest point in M (if 2 then the north most)
// lat = NP(1).X
// M = 1
// For N = 2 To S
// LatN = NP(N).X
// If LatN >= lat Then
// If LatN > lat Then
// M = N
// lat = LatN
// Else
// If NP(N).Y < NP(M).Y Then
// M = N
// lat = LatN
// End If
// End If
// End If
// Next N

// ' form the vectors M-1>M  and M>M+1  (1>2 2>3)
// X2 = NP(M).X
// Y2 = NP(M).Y
// If M = 1 Then
// X1 = NP(S).X
// Y1 = NP(S).Y
// Else
// X1 = NP(M - 1).X
// Y1 = NP(M - 1).Y
// End If
// If M = S Then
// X3 = NP(1).X
// Y3 = NP(1).Y
// Else
// X3 = NP(M + 1).X
// Y3 = NP(M + 1).Y
// End If

// ' vector 1>2 in 1 and 2>3 in 2 then cross product in x3
// X1 = X2 - X1
// Y1 = Y2 - Y1
// X2 = X3 - X2
// Y2 = Y3 - Y2

// X3 = X1 * Y2 - Y1 * X2

// NPIsClock = False

// If X3 < 0 Then NPIsClock = True ' is  clock wise

// Exit Function

// End If

// End Function

// End Class
