// Font_Brush_Pen_Matrix.cs
using System;
using SkiaSharp;

namespace Drawing
{
    // ────────────────────────────────────────────────────────────────────────
    // FontStyle enum
    // ────────────────────────────────────────────────────────────────────────

    [Flags]
    public enum FontStyle
    {
        Regular   = 0,
        Bold      = 1,
        Italic    = 2,
        Underline = 4,
        Strikeout = 8
    }

    // ────────────────────────────────────────────────────────────────────────
    // GraphicsUnit enum
    // ────────────────────────────────────────────────────────────────────────

    public enum GraphicsUnit
    {
        World      = 0,
        Display    = 1,
        Pixel      = 2,
        Point      = 3,
        Inch       = 4,
        Document   = 5,
        Millimeter = 6
    }

    // ────────────────────────────────────────────────────────────────────────
    // Font
    // ────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Drop-in replacement for System.Drawing.Font.
    /// Backed by an SKTypeface + size; converts to/from SKPaint as needed.
    /// </summary>
    public sealed class Font : IDisposable
    {
        private bool _disposed;

        public string      FamilyName { get; }
        public float       Size       { get; }
        public FontStyle   Style      { get; }
        public GraphicsUnit Unit      { get; }
        public bool        GdiCharSet { get; } // 5th arg compat — ignored at runtime

        public bool Bold      => (Style & FontStyle.Bold)      != 0;
        public bool Italic    => (Style & FontStyle.Italic)    != 0;
        public bool Underline => (Style & FontStyle.Underline) != 0;
        public bool Strikeout => (Style & FontStyle.Strikeout) != 0;

        /// <summary>The underlying SkiaSharp typeface (caller must not dispose).</summary>
        public SKTypeface Typeface { get; }

        // ── Constructors ─────────────────────────────────────────────────────

        public Font(string familyName, float emSize,
                    FontStyle style = FontStyle.Regular,
                    GraphicsUnit unit = GraphicsUnit.Point)
            : this(familyName, emSize, style, unit, false) { }

        /// <summary>
        /// 5-argument constructor matching System.Drawing.Font(string, float, FontStyle, GraphicsUnit, byte).
        /// The <paramref name="gdiCharSet"/> parameter is accepted but ignored (SkiaSharp doesn't use it).
        /// </summary>
        public Font(string familyName, float emSize,
                    FontStyle style,
                    GraphicsUnit unit,
                    bool gdiCharSet)
        {
            FamilyName = familyName ?? throw new ArgumentNullException(nameof(familyName));
            Size       = emSize;
            Style      = style;
            Unit       = unit;
            GdiCharSet = gdiCharSet;

            var skStyle = SKFontStyle.Normal;
            if (Bold && Italic)   skStyle = SKFontStyle.BoldItalic;
            else if (Bold)         skStyle = SKFontStyle.Bold;
            else if (Italic)       skStyle = SKFontStyle.Italic;

            Typeface = SKTypeface.FromFamilyName(familyName, skStyle)
                    ?? SKTypeface.Default;
        }

        /// <summary>
        /// Overload accepting a byte for gdiCharSet (System.Drawing uses byte).
        /// </summary>
        public Font(string familyName, float emSize,
                    FontStyle style,
                    GraphicsUnit unit,
                    byte gdiCharSet)
            : this(familyName, emSize, style, unit, gdiCharSet != 0) { }

        // ── Methods ──────────────────────────────────────────────────────────

        public float GetHeight(float dpi = 96f)
        {
            using var paint = ToSKPaint();
            paint.GetFontMetrics(out var metrics);
            return Math.Abs(metrics.Ascent) + Math.Abs(metrics.Descent) + metrics.Leading;
        }

        public SKPaint ToSKPaint(Color? color = null)
        {
            return new SKPaint
            {
                Typeface    = Typeface,
                TextSize    = ToPixelSize(),
                IsAntialias = true,
                Color       = color.HasValue ? color.Value.ToSKColor() : SKColors.Black,
            };
        }

        public float ToPixelSize(float dpi = 96f)
        {
            return Unit switch
            {
                GraphicsUnit.Point  => Size * dpi / 72f,
                GraphicsUnit.Inch   => Size * dpi,
                GraphicsUnit.Pixel  => Size,
                _                   => Size,
            };
        }

        // ── Implicit conversions ─────────────────────────────────────────────

        public static implicit operator SKPaint(Font f) => f.ToSKPaint();

        // ── IDisposable ──────────────────────────────────────────────────────

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            Typeface?.Dispose();
        }
    }

    // ────────────────────────────────────────────────────────────────────────
    // Brush (abstract base)
    // ────────────────────────────────────────────────────────────────────────

    public abstract class Brush : IDisposable
    {
        private bool _disposed;

        public abstract SKPaint CreateFillPaint();

        public static implicit operator SKPaint(Brush b) => b.CreateFillPaint();

        protected virtual void Dispose(bool disposing) { }

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    // ────────────────────────────────────────────────────────────────────────
    // SolidBrush
    // ────────────────────────────────────────────────────────────────────────

    public sealed class SolidBrush : Brush
    {
        public Color Color { get; set; }

        public SolidBrush(Color color) { Color = color; }

        public override SKPaint CreateFillPaint()
            => new SKPaint
            {
                Style       = SKPaintStyle.Fill,
                Color       = Color.ToSKColor(),
                IsAntialias = true,
            };

        public static implicit operator SKColor(SolidBrush b)  => b.Color.ToSKColor();
        public static implicit operator SKPaint(SolidBrush b)  => b.CreateFillPaint();
    }

    // ────────────────────────────────────────────────────────────────────────
    // Pen
    // ────────────────────────────────────────────────────────────────────────

    public sealed class Pen : IDisposable
    {
        private bool _disposed;

        public Color     Color       { get; set; }
        public float     Width       { get; set; }
        public DashStyle DashStyle   { get; set; } = DashStyle.Solid;
        public float[]   DashPattern { get; set; } = null;

        /// <summary>
        /// Stub for System.Drawing.Pen.CompoundArray — accepted but not rendered by SkiaSharp.
        /// Set it to avoid CS1061 errors; the value is stored but ignored at draw time.
        /// </summary>
        public float[] CompoundArray { get; set; } = null;

        /// <summary>Line join style (stored; applied to SKPaint.StrokeJoin).</summary>
        public LineJoin LineJoin { get; set; } = LineJoin.Miter;

        /// <summary>Line cap style (stored; applied to SKPaint.StrokeCap).</summary>
        public LineCap StartCap { get; set; } = LineCap.Flat;
        public LineCap EndCap   { get; set; } = LineCap.Flat;

        /// <summary>Miter limit (passed to SKPaint.StrokeMiter).</summary>
        public float MiterLimit { get; set; } = 10f;

        public Pen(Color color, float width = 1f)
        {
            Color = color;
            Width = width;
        }

        public Pen(Brush brush, float width = 1f)
        {
            if (brush is SolidBrush sb) Color = sb.Color;
            Width = width;
        }

        public SKPaint ToSKPaint()
        {
            var paint = new SKPaint
            {
                Style        = SKPaintStyle.Stroke,
                Color        = Color.ToSKColor(),
                StrokeWidth  = Width,
                IsAntialias  = true,
                StrokeMiter  = MiterLimit,
                StrokeJoin   = ToSKJoin(LineJoin),
                StrokeCap    = ToSKCap(StartCap),
            };

            if (DashStyle != DashStyle.Solid)
            {
                float[] intervals = DashPattern ?? GetDefaultIntervals(DashStyle, Width);
                if (intervals != null)
                    paint.PathEffect = SKPathEffect.CreateDash(intervals, 0);
            }

            return paint;
        }

        public static implicit operator SKPaint(Pen p) => p.ToSKPaint();

        private static float[] GetDefaultIntervals(DashStyle style, float w)
        {
            float d = Math.Max(1f, w);
            return style switch
            {
                DashStyle.Dash       => new[] { 4*d, 2*d },
                DashStyle.Dot        => new[] { d,   2*d },
                DashStyle.DashDot    => new[] { 4*d, 2*d, d, 2*d },
                DashStyle.DashDotDot => new[] { 4*d, 2*d, d, 2*d, d, 2*d },
                _                    => null
            };
        }

        private static SKStrokeJoin ToSKJoin(LineJoin j) => j switch
        {
            LineJoin.Bevel => SKStrokeJoin.Bevel,
            LineJoin.Round => SKStrokeJoin.Round,
            _              => SKStrokeJoin.Miter,
        };

        private static SKStrokeCap ToSKCap(LineCap c) => c switch
        {
            LineCap.Round  => SKStrokeCap.Round,
            LineCap.Square => SKStrokeCap.Square,
            _              => SKStrokeCap.Butt,
        };

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
        }
    }

    // ────────────────────────────────────────────────────────────────────────
    // Enums
    // ────────────────────────────────────────────────────────────────────────

    public enum DashStyle   { Solid, Dash, Dot, DashDot, DashDotDot, Custom }
    public enum LineJoin    { Miter = 0, Bevel = 1, Round = 2, MiterClipped = 3 }
    public enum LineCap     { Flat = 0, Square = 1, Round = 2, Triangle = 3,
                              NoAnchor = 16, SquareAnchor = 17, RoundAnchor = 18,
                              DiamondAnchor = 19, ArrowAnchor = 20, Custom = 255 }

    // ────────────────────────────────────────────────────────────────────────
    // Matrix
    // ────────────────────────────────────────────────────────────────────────

    public sealed class Matrix : IDisposable
    {
        private bool _disposed;

        public SKMatrix SKMatrix { get; private set; }

        public Matrix() { SKMatrix = SKMatrix.Identity; }

        public Matrix(SKMatrix m) { SKMatrix = m; }

        public Matrix(float m11, float m12,
                      float m21, float m22,
                      float dx,  float dy)
        {
            SKMatrix = new SKMatrix(m11, m21, dx,
                                   m12, m22, dy,
                                   0,   0,   1);
        }

        public float[] Elements => new[]
        {
            SKMatrix.ScaleX, SKMatrix.SkewY,
            SKMatrix.SkewX,  SKMatrix.ScaleY,
            SKMatrix.TransX, SKMatrix.TransY
        };

        public bool IsIdentity => SKMatrix.IsIdentity;

        public void Reset() => SKMatrix = SKMatrix.Identity;

        public void Multiply(Matrix other)
            => SKMatrix = SKMatrix.Concat(SKMatrix, other.SKMatrix);

        public void Translate(float dx, float dy)
            => SKMatrix = SKMatrix.Concat(SKMatrix, SKMatrix.CreateTranslation(dx, dy));

        public void Scale(float sx, float sy)
            => SKMatrix = SKMatrix.Concat(SKMatrix, SKMatrix.CreateScale(sx, sy));

        public void Rotate(float angle)
            => SKMatrix = SKMatrix.Concat(SKMatrix, SKMatrix.CreateRotationDegrees(angle));

        public void RotateAt(float angle, PointF point)
        {
            Translate(point.X, point.Y);
            Rotate(angle);
            Translate(-point.X, -point.Y);
        }

        public void Shear(float shearX, float shearY)
            => SKMatrix = SKMatrix.Concat(SKMatrix, SKMatrix.CreateSkew(shearX, shearY));

        public void Invert()
        {
            if (!SKMatrix.TryInvert(out var inv))
                throw new InvalidOperationException("Matrix is not invertible.");
            SKMatrix = inv;
        }

        public Matrix Clone() => new Matrix(SKMatrix);

        public static implicit operator SKMatrix(Matrix m) => m.SKMatrix;
        public static implicit operator Matrix(SKMatrix m) => new Matrix(m);

        public void Dispose()
        {
            if (_disposed) return;
            _disposed = true;
        }
    }
}
