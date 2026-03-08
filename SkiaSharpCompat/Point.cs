// Point.cs
using System;
using SkiaSharp;

namespace Drawing
{
    /// <summary>Drop-in replacement for System.Drawing.Point (integer).</summary>
    public partial struct Point : IEquatable<Point>
    {
        public static readonly Point Empty = new Point(0, 0);

        public int X { get; set; }
        public int Y { get; set; }

        public bool IsEmpty => X == 0 && Y == 0;

        public Point(int x, int y) { X = x; Y = y; }

        public static Point Add(Point pt, Size sz) => new Point(pt.X + sz.Width, pt.Y + sz.Height);
        public static Point Subtract(Point pt, Size sz) => new Point(pt.X - sz.Width, pt.Y - sz.Height);

        public static Point operator +(Point pt, Size sz) => Add(pt, sz);
        public static Point operator -(Point pt, Size sz) => Subtract(pt, sz);
        public static bool operator ==(Point a, Point b) => a.X == b.X && a.Y == b.Y;
        public static bool operator !=(Point a, Point b) => !(a == b);

        public static explicit operator Size(Point p) => new Size(p.X, p.Y);
        public static implicit operator PointF(Point p) => new PointF(p.X, p.Y);

        // ── SkiaSharp interop ────────────────────────────────────────────────
        public static implicit operator SKPoint(Point p) => new SKPoint(p.X, p.Y);
        public static explicit operator Point(SKPoint p) => new Point((int)p.X, (int)p.Y);
        public SKPoint ToSKPoint() => new SKPoint(X, Y);

        public bool Equals(Point other) => X == other.X && Y == other.Y;
        public override bool Equals(object obj) => obj is Point p && Equals(p);
        public override int GetHashCode() { unchecked { return X * 397 ^ Y; } }
        public override string ToString() => $"{{X={X}, Y={Y}}}";
    }

    /// <summary>Drop-in replacement for System.Drawing.PointF (float).</summary>
    public partial struct PointF : IEquatable<PointF>
    {
        public static readonly PointF Empty = new PointF(0f, 0f);

        public float X { get; set; }
        public float Y { get; set; }

        public bool IsEmpty => X == 0f && Y == 0f;

        public PointF(float x, float y) { X = x; Y = y; }

        public static PointF operator +(PointF pt, SizeF sz) => new PointF(pt.X + sz.Width, pt.Y + sz.Height);
        public static PointF operator -(PointF pt, SizeF sz) => new PointF(pt.X - sz.Width, pt.Y - sz.Height);
        public static bool operator ==(PointF a, PointF b) => a.X == b.X && a.Y == b.Y;
        public static bool operator !=(PointF a, PointF b) => !(a == b);

        // ── SkiaSharp interop ────────────────────────────────────────────────
        public static implicit operator SKPoint(PointF p) => new SKPoint(p.X, p.Y);
        public static implicit operator PointF(SKPoint p) => new PointF(p.X, p.Y);
        public SKPoint ToSKPoint() => new SKPoint(X, Y);

        public bool Equals(PointF other) => X == other.X && Y == other.Y;
        public override bool Equals(object obj) => obj is PointF p && Equals(p);
        public override int GetHashCode() { unchecked { return X.GetHashCode() * 397 ^ Y.GetHashCode(); } }
        public override string ToString() => $"{{X={X}, Y={Y}}}";
    }

    /// <summary>Drop-in replacement for System.Drawing.Size (integer).</summary>
    public partial struct Size : IEquatable<Size>
    {
        public static readonly Size Empty = new Size(0, 0);

        public int Width  { get; set; }
        public int Height { get; set; }

        public bool IsEmpty => Width == 0 && Height == 0;

        public Size(int width, int height) { Width = width; Height = height; }
        public Size(Point pt) { Width = pt.X; Height = pt.Y; }

        public static Size operator +(Size a, Size b) => new Size(a.Width + b.Width, a.Height + b.Height);
        public static Size operator -(Size a, Size b) => new Size(a.Width - b.Width, a.Height - b.Height);
        public static bool operator ==(Size a, Size b) => a.Width == b.Width && a.Height == b.Height;
        public static bool operator !=(Size a, Size b) => !(a == b);

        public static explicit operator Point(Size sz) => new Point(sz.Width, sz.Height);
        public static implicit operator SizeF(Size sz) => new SizeF(sz.Width, sz.Height);

        public bool Equals(Size other) => Width == other.Width && Height == other.Height;
        public override bool Equals(object obj) => obj is Size s && Equals(s);
        public override int GetHashCode() { unchecked { return Width * 397 ^ Height; } }
        public override string ToString() => $"{{Width={Width}, Height={Height}}}";
    }

    /// <summary>Drop-in replacement for System.Drawing.SizeF (float).</summary>
    public partial struct SizeF : IEquatable<SizeF>
    {
        public static readonly SizeF Empty = new SizeF(0f, 0f);

        public float Width  { get; set; }
        public float Height { get; set; }

        public bool IsEmpty => Width == 0f && Height == 0f;

        public SizeF(float width, float height) { Width = width; Height = height; }
        public SizeF(SizeF sz) { Width = sz.Width; Height = sz.Height; }

        public static SizeF operator +(SizeF a, SizeF b) => new SizeF(a.Width + b.Width, a.Height + b.Height);
        public static SizeF operator -(SizeF a, SizeF b) => new SizeF(a.Width - b.Width, a.Height - b.Height);
        public static bool operator ==(SizeF a, SizeF b) => a.Width == b.Width && a.Height == b.Height;
        public static bool operator !=(SizeF a, SizeF b) => !(a == b);

        public bool Equals(SizeF other) => Width == other.Width && Height == other.Height;
        public override bool Equals(object obj) => obj is SizeF s && Equals(s);
        public override int GetHashCode() { unchecked { return Width.GetHashCode() * 397 ^ Height.GetHashCode(); } }
        public override string ToString() => $"{{Width={Width}, Height={Height}}}";
    }
}
