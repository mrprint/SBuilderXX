// GraphicsPath.cs
using System;
using SkiaSharp;

namespace Drawing
{
    // ────────────────────────────────────────────────────────────────────────
    // FillMode
    // ────────────────────────────────────────────────────────────────────────

    public enum FillMode { Alternate = 0, Winding = 1 }

    // ────────────────────────────────────────────────────────────────────────
    // GraphicsPath
    // ────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Drop-in replacement for System.Drawing.Drawing2D.GraphicsPath.
    /// Wraps SKPath.
    /// </summary>
    public sealed class GraphicsPath : IDisposable
    {
        private bool   _disposed;
        private SKPath _path;

        public FillMode FillMode
        {
            get => _path.FillType == SKPathFillType.Winding
                     ? FillMode.Winding
                     : FillMode.Alternate;
            set => _path.FillType = value == FillMode.Winding
                     ? SKPathFillType.Winding
                     : SKPathFillType.EvenOdd;
        }

        public SKPath SKPath => _path;

        public RectangleF GetBounds()
        {
            var b = _path.Bounds;
            return new RectangleF(b.Left, b.Top, b.Width, b.Height);
        }

        public GraphicsPath(FillMode fillMode = FillMode.Alternate)
        {
            _path = new SKPath
            {
                FillType = fillMode == FillMode.Winding
                             ? SKPathFillType.Winding
                             : SKPathFillType.EvenOdd
            };
        }

        public GraphicsPath(SKPath existingPath)
        {
            _path = existingPath ?? throw new ArgumentNullException(nameof(existingPath));
        }

        // ── Reset ────────────────────────────────────────────────────────────

        /// <summary>
        /// Empties the path, preserving the current FillMode.
        /// Matches System.Drawing.Drawing2D.GraphicsPath.Reset().
        /// </summary>
        public void Reset()
        {
            var fillType = _path.FillType;
            _path.Dispose();
            _path = new SKPath { FillType = fillType };
        }

        // ── Figure ───────────────────────────────────────────────────────────

        public void StartFigure() => _path.MoveTo(0, 0);
        public void CloseFigure() => _path.Close();
        public void CloseAllFigures() => _path.Close();

        // ── Lines ────────────────────────────────────────────────────────────

        public void AddLine(float x1, float y1, float x2, float y2)
        {
            _path.MoveTo(x1, y1);
            _path.LineTo(x2, y2);
        }

        public void AddLine(PointF pt1, PointF pt2) => AddLine(pt1.X, pt1.Y, pt2.X, pt2.Y);
        public void AddLine(Point  pt1, Point  pt2) => AddLine(pt1.X, pt1.Y, pt2.X, pt2.Y);

        public void AddLines(PointF[] points)
        {
            if (points == null || points.Length < 2)
                throw new ArgumentException("At least 2 points required.", nameof(points));
            _path.MoveTo(points[0].X, points[0].Y);
            for (int i = 1; i < points.Length; i++) _path.LineTo(points[i].X, points[i].Y);
        }

        public void AddLines(Point[] points)
        {
            if (points == null || points.Length < 2)
                throw new ArgumentException("At least 2 points required.", nameof(points));
            _path.MoveTo(points[0].X, points[0].Y);
            for (int i = 1; i < points.Length; i++) _path.LineTo(points[i].X, points[i].Y);
        }

        // ── Shapes ───────────────────────────────────────────────────────────

        public void AddRectangle(RectangleF rect) => _path.AddRect(rect.ToSKRect());
        public void AddRectangle(Rectangle  rect) => _path.AddRect(rect.ToSKRect());

        public void AddEllipse(float x, float y, float width, float height)
            => _path.AddOval(SKRect.Create(x, y, width, height));

        public void AddEllipse(RectangleF rect) => AddEllipse(rect.X, rect.Y, rect.Width, rect.Height);
        public void AddEllipse(Rectangle  rect) => AddEllipse(rect.X, rect.Y, rect.Width, rect.Height);

        public void AddArc(float x, float y, float width, float height,
                           float startAngle, float sweepAngle)
        {
            using var arcPath = new SKPath();
            arcPath.AddArc(SKRect.Create(x, y, width, height), startAngle, sweepAngle);
            _path.AddPath(arcPath);
        }

        public void AddArc(RectangleF rect, float startAngle, float sweepAngle)
            => AddArc(rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle);

        public void AddBezier(float x1, float y1,
                              float cx1, float cy1,
                              float cx2, float cy2,
                              float x2,  float y2)
        {
            _path.MoveTo(x1, y1);
            _path.CubicTo(cx1, cy1, cx2, cy2, x2, y2);
        }

        public void AddBezier(PointF p1, PointF c1, PointF c2, PointF p2)
            => AddBezier(p1.X, p1.Y, c1.X, c1.Y, c2.X, c2.Y, p2.X, p2.Y);

        public void AddBeziers(PointF[] points)
        {
            if (points == null || points.Length < 4 || (points.Length - 1) % 3 != 0)
                throw new ArgumentException("Points must be 4 + multiples of 3.");
            _path.MoveTo(points[0].X, points[0].Y);
            for (int i = 1; i < points.Length; i += 3)
                _path.CubicTo(points[i], points[i+1], points[i+2]);
        }

        public void AddPolygon(PointF[] points)
        {
            if (points == null || points.Length < 3)
                throw new ArgumentException("At least 3 points required.");
            _path.MoveTo(points[0].X, points[0].Y);
            for (int i = 1; i < points.Length; i++) _path.LineTo(points[i].X, points[i].Y);
            _path.Close();
        }

        public void AddPolygon(Point[] points)
        {
            if (points == null || points.Length < 3)
                throw new ArgumentException("At least 3 points required.");
            _path.MoveTo(points[0].X, points[0].Y);
            for (int i = 1; i < points.Length; i++) _path.LineTo(points[i].X, points[i].Y);
            _path.Close();
        }

        public void AddRoundedRectangle(RectangleF rect, float radius)
            => _path.AddRoundRect(new SKRoundRect(rect.ToSKRect(), radius));

        // ── Path combination ─────────────────────────────────────────────────

        public void AddPath(GraphicsPath addingPath, bool connect = false)
            => _path.AddPath(addingPath._path, SKPathAddMode.Append);

        // ── Transform ────────────────────────────────────────────────────────

        public void Transform(Matrix matrix) => _path.Transform(matrix.SKMatrix);

        // ── Hit-testing ──────────────────────────────────────────────────────

        public bool IsVisible(float x, float y) => _path.Contains(x, y);
        public bool IsVisible(PointF pt) => IsVisible(pt.X, pt.Y);

        // ── Clone ────────────────────────────────────────────────────────────

        public GraphicsPath Clone() => new GraphicsPath(new SKPath(_path));

        // ── Conversions ──────────────────────────────────────────────────────

        public static implicit operator SKPath(GraphicsPath gp) => gp._path;

        // ── IDisposable ──────────────────────────────────────────────────────

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            _path?.Dispose();
        }
    }
}
