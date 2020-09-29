using System;
using System.Drawing;

namespace SBuilderX
{
    static class modulePOINTS
    {
        internal static int CheckPoints; // 0=no ; 1=manual; 2=auto
        internal static float AutoCheckDistance;
        internal static Color SelectedPointColor;
        internal static Color UnselectedPointColor;

        [Serializable()]
        internal struct GPoint
        {
            public double lon;
            public double lat;
            public double alt;
            public bool Selected;
        }

        [Serializable()]
        internal struct GLPoint
        {
            public double lon;
            public double lat;
            public double alt;
            public double wid;
            public bool Selected;
        }

        internal static bool IsPoint(double X1, double Y1, double X, double Y)
        {
            bool IsPointRet = default;

            // X1 and Y1 are lon / lat
            // X and Y are pixels


            X1 = X1 * moduleMAIN.PixelsPerLonDeg;
            Y1 = Y1 * moduleMAIN.PixelsPerLatDeg;
            IsPointRet = false;
            if (X > X1 + 5d)
                return IsPointRet;
            if (X < X1 - 5d)
                return IsPointRet;
            if (Y > Y1 + 5d)
                return IsPointRet;
            if (Y < Y1 - 5d)
                return IsPointRet;
            IsPointRet = true;
            return IsPointRet;
        }

        internal static bool IsPointInSegment(double X0, double Y0, double X1, double Y1, double X, double Y)
        {
            bool IsPointInSegmentRet = default;
            // on entry X Y contain distance from earth in pixels
            // other parameters are lon and lat of line extremes

            X0 = X0 * moduleMAIN.PixelsPerLonDeg;
            X1 = X1 * moduleMAIN.PixelsPerLonDeg;
            Y0 = Y0 * moduleMAIN.PixelsPerLatDeg;
            Y1 = Y1 * moduleMAIN.PixelsPerLatDeg;
            IsPointInSegmentRet = false;

            try
            {
                if (X > X0 + 5d & X > X1 + 5d)
                    return IsPointInSegmentRet;
                if (X < X0 - 5d & X < X1 - 5d)
                    return IsPointInSegmentRet;
                if (Y > Y0 + 5d & Y > Y1 + 5d)
                    return IsPointInSegmentRet;
                if (Y < Y0 - 5d & Y < Y1 - 5d)
                    return IsPointInSegmentRet;
                X1 = X1 - X0;
                Y1 = Y1 - Y0;
                if (Math.Abs(X1) > Math.Abs(Y1))
                {
                    X = Y0 + Y1 * (X - X0) / X1;
                    if (X > Y + 5d)
                        return IsPointInSegmentRet;
                    if (X < Y - 5d)
                        return IsPointInSegmentRet;
                }
                else
                {
                    Y = X0 + X1 * (Y - Y0) / Y1;
                    if (Y > X + 5d)
                        return IsPointInSegmentRet;
                    if (Y < X - 5d)
                        return IsPointInSegmentRet;
                }

                IsPointInSegmentRet = true;
            }
            catch(Exception)
            {
            }
            return IsPointInSegmentRet;
        }
    }
}