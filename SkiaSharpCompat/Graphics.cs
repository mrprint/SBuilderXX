// Graphics.cs
using System;
using System.Collections.Generic;
using SkiaSharp;

namespace Drawing
{
    // ────────────────────────────────────────────────────────────────────────
    // Supporting enums
    // ────────────────────────────────────────────────────────────────────────

    public enum SmoothingMode
    {
        Default     = 0,
        HighSpeed   = 1,
        HighQuality = 2,
        None        = 3,
        AntiAlias   = 4,
        Invalid     = -1
    }

    public enum InterpolationMode
    {
        Default              = 0,
        Low                  = 1,
        High                 = 2,
        Bilinear             = 3,
        Bicubic              = 4,
        NearestNeighbor      = 5,
        HighQualityBilinear  = 6,
        HighQualityBicubic   = 7,
        Invalid              = -1
    }

    public enum TextRenderingHint
    {
        SystemDefault             = 0,
        SingleBitPerPixelGridFit  = 1,
        SingleBitPerPixel         = 2,
        AntiAliasGridFit          = 3,
        AntiAlias                 = 4,
        ClearTypeGridFit          = 5
    }

    public enum CompositingMode    { SourceOver = 0, SourceCopy = 1 }
    public enum CompositingQuality { Default = 0, HighSpeed = 1, HighQuality = 2,
                                     GammaCorrected = 3, AssumeLinear = 4 }

    public enum StringAlignment    { Near = 0, Center = 1, Far = 2 }

    // ────────────────────────────────────────────────────────────────────────
    // StringFormat
    // ────────────────────────────────────────────────────────────────────────

    public sealed class StringFormat : IDisposable
    {
        public static StringFormat GenericDefault    { get; } = new StringFormat();
        public static StringFormat GenericTypographic { get; } = new StringFormat
        {
            Alignment     = StringAlignment.Near,
            LineAlignment = StringAlignment.Near,
        };

        public StringAlignment Alignment     { get; set; } = StringAlignment.Near;
        public StringAlignment LineAlignment { get; set; } = StringAlignment.Near;

        public SKTextAlign ToSKTextAlign()
            => Alignment switch
            {
                StringAlignment.Center => SKTextAlign.Center,
                StringAlignment.Far    => SKTextAlign.Right,
                _                      => SKTextAlign.Left,
            };

        public void Dispose() { /* nothing to release */ }
    }

    // ────────────────────────────────────────────────────────────────────────
    // Graphics  (partial — extended in SystemDrawingBridge.cs)
    // ────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Drop-in replacement for System.Drawing.Graphics.
    /// Wraps an SKCanvas and optionally owns the backing surface.
    /// </summary>
    public sealed partial class Graphics : IDisposable
    {
        private bool      _disposed;
        private SKCanvas  _canvas;
        private SKSurface _surface; // non-null only when we own the surface

        // ── Properties ───────────────────────────────────────────────────────

        private SmoothingMode _smoothingMode = SmoothingMode.Default;
        public SmoothingMode SmoothingMode
        {
            get => _smoothingMode;
            set => _smoothingMode = value;
        }

        public InterpolationMode  InterpolationMode  { get; set; } = InterpolationMode.Default;
        public TextRenderingHint  TextRenderingHint  { get; set; } = TextRenderingHint.AntiAlias;
        public CompositingMode    CompositingMode    { get; set; } = CompositingMode.SourceOver;
        public CompositingQuality CompositingQuality { get; set; } = CompositingQuality.Default;
        public float              PageScale          { get; set; } = 1f;

        /// <summary>Direct access to the underlying SKCanvas (caller must not dispose).</summary>
        public SKCanvas Canvas => _canvas;

        // ── Factories ────────────────────────────────────────────────────────

        public static Graphics FromImage(Image image)
            => new Graphics(new SKCanvas(image.SKBitmap), null, ownsCanvas: true);

        public static Graphics FromSKCanvas(SKCanvas canvas)
            => new Graphics(canvas, null, ownsCanvas: false);

        /// <summary>Creates a Graphics that draws into a new in-memory bitmap surface.</summary>
        public static Graphics FromSize(int width, int height)
        {
            var surface = SKSurface.Create(new SKImageInfo(width, height));
            return new Graphics(surface.Canvas, surface, ownsCanvas: false);
        }

        private bool _ownsCanvas;

        private Graphics(SKCanvas canvas, SKSurface surface, bool ownsCanvas = true)
        {
            _canvas     = canvas ?? throw new ArgumentNullException(nameof(canvas));
            _surface    = surface;
            _ownsCanvas = ownsCanvas;
        }

        // ── State: Save / Restore ─────────────────────────────────────────────

        public int  Save()                       => _canvas.Save();
        public void Restore()                    => _canvas.Restore();
        public void RestoreToCount(int n)        => _canvas.RestoreToCount(n);

        // ── Clipping ─────────────────────────────────────────────────────────

        public void SetClip(RectangleF rect)     => _canvas.ClipRect(rect.ToSKRect());
        public void SetClip(Rectangle rect)      => _canvas.ClipRect(rect.ToSKRect());
        public void SetClip(GraphicsPath path)   => _canvas.ClipPath(path.SKPath);
        public void ResetClip()                  => _canvas.RestoreToCount(0);

        // ── Transforms ───────────────────────────────────────────────────────

        public void TranslateTransform(float dx, float dy) => _canvas.Translate(dx, dy);
        public void RotateTransform(float angle)           => _canvas.RotateDegrees(angle);
        public void ScaleTransform(float sx, float sy)     => _canvas.Scale(sx, sy);

        public void MultiplyTransform(Matrix matrix)
        {
            var m = matrix.SKMatrix;
            _canvas.Concat(ref m);
        }

        public Matrix Transform
        {
            get => new Matrix(_canvas.TotalMatrix);
            set { var m = value.SKMatrix; _canvas.SetMatrix(m); }
        }

        public void ResetTransform() => _canvas.ResetMatrix();

        // ── Clear ─────────────────────────────────────────────────────────────

        public void Clear(Color color) => _canvas.Clear(color.ToSKColor());

        // ── Draw / Fill primitives ────────────────────────────────────────────

        public void DrawLine(Pen pen, float x1, float y1, float x2, float y2)
        {
            using var p = pen.ToSKPaint(); ApplySmoothingMode(p);
            _canvas.DrawLine(x1, y1, x2, y2, p);
        }

        public void DrawLine(Pen pen, PointF pt1, PointF pt2)
            => DrawLine(pen, pt1.X, pt1.Y, pt2.X, pt2.Y);

        public void DrawLine(Pen pen, Point pt1, Point pt2)
            => DrawLine(pen, pt1.X, pt1.Y, pt2.X, pt2.Y);

        public void DrawLines(Pen pen, PointF[] points)
        {
            using var p = pen.ToSKPaint(); ApplySmoothingMode(p);
            for (int i = 0; i < points.Length - 1; i++)
                _canvas.DrawLine(points[i].X, points[i].Y, points[i+1].X, points[i+1].Y, p);
        }

        // Overload accepting Point[] — converts implicitly
        public void DrawLines(Pen pen, Point[] points)
        {
            using var p = pen.ToSKPaint(); ApplySmoothingMode(p);
            for (int i = 0; i < points.Length - 1; i++)
                _canvas.DrawLine(points[i].X, points[i].Y, points[i+1].X, points[i+1].Y, p);
        }

        public void DrawRectangle(Pen pen, float x, float y, float w, float h)
        {
            using var p = pen.ToSKPaint(); ApplySmoothingMode(p);
            _canvas.DrawRect(x, y, w, h, p);
        }

        public void DrawRectangle(Pen pen, Rectangle rect)
            => DrawRectangle(pen, rect.X, rect.Y, rect.Width, rect.Height);

        public void FillRectangle(Brush brush, float x, float y, float w, float h)
        {
            using var p = brush.CreateFillPaint(); ApplySmoothingMode(p);
            _canvas.DrawRect(x, y, w, h, p);
        }

        public void FillRectangle(Brush brush, RectangleF rect)
            => FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Height);

        public void FillRectangle(Brush brush, Rectangle rect)
            => FillRectangle(brush, rect.X, rect.Y, rect.Width, rect.Height);

        public void DrawEllipse(Pen pen, float x, float y, float w, float h)
        {
            using var p = pen.ToSKPaint(); ApplySmoothingMode(p);
            _canvas.DrawOval(x + w/2f, y + h/2f, w/2f, h/2f, p);
        }

        public void DrawEllipse(Pen pen, RectangleF rect)
            => DrawEllipse(pen, rect.X, rect.Y, rect.Width, rect.Height);

        public void FillEllipse(Brush brush, float x, float y, float w, float h)
        {
            using var p = brush.CreateFillPaint(); ApplySmoothingMode(p);
            _canvas.DrawOval(x + w/2f, y + h/2f, w/2f, h/2f, p);
        }

        public void FillEllipse(Brush brush, RectangleF rect)
            => FillEllipse(brush, rect.X, rect.Y, rect.Width, rect.Height);

        public void DrawArc(Pen pen, float x, float y, float w, float h,
                            float startAngle, float sweepAngle)
        {
            using var p    = pen.ToSKPaint();
            using var path = new SKPath();
            path.AddArc(SKRect.Create(x, y, w, h), startAngle, sweepAngle);
            ApplySmoothingMode(p);
            _canvas.DrawPath(path, p);
        }

        public void DrawArc(Pen pen, Rectangle rect, float startAngle, float sweepAngle)
            => DrawArc(pen, rect.X, rect.Y, rect.Width, rect.Height, startAngle, sweepAngle);

        public void DrawPolygon(Pen pen, PointF[] points)
        {
            using var path = BuildPolygon(points);
            using var p    = pen.ToSKPaint(); ApplySmoothingMode(p);
            _canvas.DrawPath(path, p);
        }

        public void DrawPolygon(Pen pen, Point[] points)
        {
            using var path = BuildPolygon(points);
            using var p    = pen.ToSKPaint(); ApplySmoothingMode(p);
            _canvas.DrawPath(path, p);
        }

        public void FillPolygon(Brush brush, PointF[] points)
        {
            using var path = BuildPolygon(points);
            using var p    = brush.CreateFillPaint(); ApplySmoothingMode(p);
            _canvas.DrawPath(path, p);
        }

        public void FillPolygon(Brush brush, Point[] points)
        {
            using var path = BuildPolygon(points);
            using var p    = brush.CreateFillPaint(); ApplySmoothingMode(p);
            _canvas.DrawPath(path, p);
        }

        // ── Path ─────────────────────────────────────────────────────────────

        public void DrawPath(Pen pen, GraphicsPath path)
        {
            using var p = pen.ToSKPaint(); ApplySmoothingMode(p);
            _canvas.DrawPath(path.SKPath, p);
        }

        public void FillPath(Brush brush, GraphicsPath path)
        {
            using var p = brush.CreateFillPaint(); ApplySmoothingMode(p);
            _canvas.DrawPath(path.SKPath, p);
        }

        // ── Images ───────────────────────────────────────────────────────────

        public void DrawImage(Image image, float x, float y)
            => _canvas.DrawBitmap(image.SKBitmap, x, y);

        public void DrawImage(Image image, PointF point)
            => DrawImage(image, point.X, point.Y);

        public void DrawImage(Image image, Point point)
            => DrawImage(image, point.X, point.Y);

        public void DrawImage(Image image, float x, float y, float w, float h)
            => _canvas.DrawBitmap(image.SKBitmap,
                   new SKRect(0, 0, image.Width, image.Height),
                   new SKRect(x, y, x + w, y + h));

        public void DrawImage(Image image, RectangleF dest)
            => DrawImage(image, dest.X, dest.Y, dest.Width, dest.Height);

        public void DrawImage(Image image, Rectangle dest)
            => DrawImage(image, dest.X, dest.Y, dest.Width, dest.Height);

        public void DrawImage(Image image, RectangleF dest, RectangleF src,
                              GraphicsUnit srcUnit = GraphicsUnit.Pixel)
            => _canvas.DrawBitmap(image.SKBitmap, src.ToSKRect(), dest.ToSKRect());

        public void DrawImage(Image image, Rectangle dest, Rectangle src,
                              GraphicsUnit srcUnit = GraphicsUnit.Pixel)
            => _canvas.DrawBitmap(image.SKBitmap, src.ToSKRect(), dest.ToSKRect());

        public void DrawImage(Image image, PointF[] destPoints)
        {
            if (destPoints == null || destPoints.Length < 3)
                throw new ArgumentException("Need at least 3 points.");
            using var paint = new SKPaint { FilterQuality = SKFilterQuality.High };
            _canvas.DrawBitmapNinePatch(image.SKBitmap,
                new SKRectI(0, 0, image.Width, image.Height),
                new SKRect(destPoints[0].X, destPoints[0].Y,
                           destPoints[1].X, destPoints[2].Y),
                paint);
        }

        // ── Text ─────────────────────────────────────────────────────────────

        public void DrawString(string text, Font font, Brush brush,
                               float x, float y, StringFormat format = null)
        {
            if (string.IsNullOrEmpty(text)) return;
            using var paint = font.ToSKPaint();
            paint.Color       = GetBrushColor(brush);
            paint.IsAntialias = true;
            paint.TextAlign   = format?.ToSKTextAlign() ?? SKTextAlign.Left;
            ApplySmoothingMode(paint);
            paint.GetFontMetrics(out var metrics);
            _canvas.DrawText(text, x, y - metrics.Ascent, paint);
        }

        public void DrawString(string text, Font font, Brush brush,
                               PointF point, StringFormat format = null)
            => DrawString(text, font, brush, point.X, point.Y, format);

        public void DrawString(string text, Font font, Brush brush,
                               RectangleF layoutRect, StringFormat format = null)
        {
            if (string.IsNullOrEmpty(text)) return;
            using var paint = font.ToSKPaint();
            paint.Color       = GetBrushColor(brush);
            paint.IsAntialias = true;
            paint.TextAlign   = format?.ToSKTextAlign() ?? SKTextAlign.Left;
            ApplySmoothingMode(paint);
            paint.GetFontMetrics(out var metrics);
            float lineH  = -metrics.Ascent + metrics.Descent + metrics.Leading;
            float cursorY = layoutRect.Top + (-metrics.Ascent);
            var words = text.Split(' ');
            var line  = new System.Text.StringBuilder();
            foreach (var word in words)
            {
                string candidate = line.Length == 0 ? word : line + " " + word;
                if (paint.MeasureText(candidate) > layoutRect.Width && line.Length > 0)
                {
                    _canvas.DrawText(line.ToString(), layoutRect.Left, cursorY, paint);
                    cursorY += lineH;
                    if (cursorY > layoutRect.Bottom) return;
                    line.Clear();
                    line.Append(word);
                }
                else
                {
                    if (line.Length > 0) line.Append(' ');
                    line.Append(word);
                }
            }
            if (line.Length > 0)
                _canvas.DrawText(line.ToString(), layoutRect.Left, cursorY, paint);
        }

        // ── MeasureString ─────────────────────────────────────────────────────

        public SizeF MeasureString(string text, Font font)
        {
            using var paint = font.ToSKPaint();
            float w = paint.MeasureText(text);
            paint.GetFontMetrics(out var metrics);
            return new SizeF(w, -metrics.Ascent + metrics.Descent);
        }

        public SizeF MeasureString(string text, Font font, SizeF layoutArea,
                                   StringFormat format = null)
        {
            var sz = MeasureString(text, font);
            return new SizeF(Math.Min(sz.Width, layoutArea.Width), sz.Height);
        }

        public SizeF MeasureString(string text, Font font, int width,
                                   StringFormat format = null)
            => MeasureString(text, font, new SizeF(width, float.MaxValue), format);

        // ── Flush / Snapshot ──────────────────────────────────────────────────

        public void Flush() => _canvas.Flush();

        /// <summary>
        /// Snapshots the canvas as a Bitmap. Only valid when created via FromSize().
        /// </summary>
        public Bitmap ToBitmap()
        {
            if (_surface == null)
                throw new InvalidOperationException(
                    "ToBitmap is only supported when Graphics owns the backing surface. " +
                    "Use Graphics.FromSize() to create one.");
            using var snap = _surface.Snapshot();
            return new Bitmap(SKBitmap.FromImage(snap));
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private void ApplySmoothingMode(SKPaint paint)
        {
            paint.IsAntialias = _smoothingMode != SmoothingMode.None
                             && _smoothingMode != SmoothingMode.HighSpeed;
        }

        private static SKColor GetBrushColor(Brush brush)
        {
            if (brush is SolidBrush sb) return sb.Color.ToSKColor();
            return SKColors.Black;
        }

        private static SKPath BuildPolygon(PointF[] points)
        {
            var path = new SKPath();
            path.MoveTo(points[0].X, points[0].Y);
            for (int i = 1; i < points.Length; i++) path.LineTo(points[i].X, points[i].Y);
            path.Close();
            return path;
        }

        private static SKPath BuildPolygon(Point[] points)
        {
            var path = new SKPath();
            path.MoveTo(points[0].X, points[0].Y);
            for (int i = 1; i < points.Length; i++) path.LineTo(points[i].X, points[i].Y);
            path.Close();
            return path;
        }

        // ── IDisposable ───────────────────────────────────────────────────────

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            OnDisposing();
            if (_ownsCanvas) _canvas?.Dispose();  // ← only dispose if we created it
            _surface?.Dispose();
        }

        // Partial hook called at start of Dispose — implemented in SystemDrawingBridge.cs
        partial void OnDisposing();
    }

    // ── Extensions ────────────────────────────────────────────────────────────

    public static class GraphicsExtensions
    {
        public static void DrawImageUnscaled(this Graphics g, Image image, Point pt)
            => g.DrawImage(image, (float)pt.X, (float)pt.Y);

        public static void DrawImageUnscaled(this Graphics g, Image image, int x, int y)
            => g.DrawImage(image, (float)x, (float)y);
    }
}
