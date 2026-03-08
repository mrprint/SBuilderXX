// Rectangle.cs
using System;
using SkiaSharp;

namespace Drawing
{
    /// <summary>Drop-in replacement for System.Drawing.Rectangle (integer).</summary>
    public partial struct Rectangle : IEquatable<Rectangle>
    {
        public static readonly Rectangle Empty = new Rectangle(0, 0, 0, 0);

        public int X      { get; set; }
        public int Y      { get; set; }
        public int Width  { get; set; }
        public int Height { get; set; }

        public int Left   => X;
        public int Top    => Y;
        public int Right  => X + Width;
        public int Bottom => Y + Height;

        public bool IsEmpty => Width <= 0 || Height <= 0;

        public Point Location
        {
            get => new Point(X, Y);
            set { X = value.X; Y = value.Y; }
        }

        public Size Size
        {
            get => new Size(Width, Height);
            set { Width = value.Width; Height = value.Height; }
        }

        public Rectangle(int x, int y, int width, int height)
        {
            X = x; Y = y; Width = width; Height = height;
        }

        public Rectangle(Point location, Size size)
        {
            X = location.X; Y = location.Y;
            Width = size.Width; Height = size.Height;
        }

        public static Rectangle FromLTRB(int left, int top, int right, int bottom)
            => new Rectangle(left, top, right - left, bottom - top);

        public bool Contains(int x, int y)
            => x >= Left && x < Right && y >= Top && y < Bottom;

        public bool Contains(Point pt) => Contains(pt.X, pt.Y);

        public bool Contains(Rectangle rect)
            => rect.Left >= Left && rect.Right <= Right
            && rect.Top  >= Top  && rect.Bottom <= Bottom;

        public bool IntersectsWith(Rectangle rect)
            => rect.Left < Right && Left < rect.Right
            && rect.Top  < Bottom && Top < rect.Bottom;

        public void Intersect(Rectangle rect)
        {
            int l = Math.Max(Left, rect.Left);
            int t = Math.Max(Top, rect.Top);
            int r = Math.Min(Right, rect.Right);
            int b = Math.Min(Bottom, rect.Bottom);
            if (l >= r || t >= b) { X = Y = Width = Height = 0; return; }
            X = l; Y = t; Width = r - l; Height = b - t;
        }

        public static Rectangle Intersect(Rectangle a, Rectangle b)
        {
            var result = a;
            result.Intersect(b);
            return result;
        }

        public static Rectangle Union(Rectangle a, Rectangle b)
        {
            int l  = Math.Min(a.Left,   b.Left);
            int t  = Math.Min(a.Top,    b.Top);
            int r  = Math.Max(a.Right,  b.Right);
            int bb = Math.Max(a.Bottom, b.Bottom);
            return FromLTRB(l, t, r, bb);
        }

        public void Inflate(int width, int height)
        {
            X -= width; Y -= height;
            Width += 2 * width; Height += 2 * height;
        }

        public static Rectangle Inflate(Rectangle rect, int x, int y)
        {
            var r = rect;
            r.Inflate(x, y);
            return r;
        }

        public void Offset(int dx, int dy) { X += dx; Y += dy; }
        public void Offset(Point pt) => Offset(pt.X, pt.Y);

        // ── SkiaSharp interop ────────────────────────────────────────────────

        public SKRect  ToSKRect()  => new SKRect(Left, Top, Right, Bottom);
        public SKRectI ToSKRectI() => new SKRectI(Left, Top, Right, Bottom);

        public static implicit operator SKRect(Rectangle r)   => r.ToSKRect();
        public static implicit operator SKRectI(Rectangle r)  => r.ToSKRectI();
        public static explicit operator Rectangle(SKRect r)
            => FromLTRB((int)r.Left, (int)r.Top, (int)r.Right, (int)r.Bottom);
        public static explicit operator Rectangle(SKRectI r)
            => FromLTRB(r.Left, r.Top, r.Right, r.Bottom);
        public static implicit operator RectangleF(Rectangle r)
            => new RectangleF(r.X, r.Y, r.Width, r.Height);

        // ── Equality ─────────────────────────────────────────────────────────

        public bool Equals(Rectangle other)
            => X == other.X && Y == other.Y && Width == other.Width && Height == other.Height;
        public override bool Equals(object obj) => obj is Rectangle r && Equals(r);
        public override int GetHashCode()
        {
            unchecked
            {
                int h = X * 397 ^ Y;
                h = h * 397 ^ Width;
                return h * 397 ^ Height;
            }
        }
        public static bool operator ==(Rectangle a, Rectangle b) => a.Equals(b);
        public static bool operator !=(Rectangle a, Rectangle b) => !a.Equals(b);

        public override string ToString()
            => $"{{X={X},Y={Y},Width={Width},Height={Height}}}";
    }

    /// <summary>Drop-in replacement for System.Drawing.RectangleF (float).</summary>
    public partial struct RectangleF : IEquatable<RectangleF>
    {
        public static readonly RectangleF Empty = new RectangleF(0f, 0f, 0f, 0f);

        public float X      { get; set; }
        public float Y      { get; set; }
        public float Width  { get; set; }
        public float Height { get; set; }

        public float Left   => X;
        public float Top    => Y;
        public float Right  => X + Width;
        public float Bottom => Y + Height;

        public bool IsEmpty => Width <= 0f || Height <= 0f;

        public PointF Location
        {
            get => new PointF(X, Y);
            set { X = value.X; Y = value.Y; }
        }

        public SizeF Size
        {
            get => new SizeF(Width, Height);
            set { Width = value.Width; Height = value.Height; }
        }

        public RectangleF(float x, float y, float width, float height)
        {
            X = x; Y = y; Width = width; Height = height;
        }

        public RectangleF(PointF location, SizeF size)
        {
            X = location.X; Y = location.Y;
            Width = size.Width; Height = size.Height;
        }

        public static RectangleF FromLTRB(float l, float t, float r, float b)
            => new RectangleF(l, t, r - l, b - t);

        public bool Contains(float x, float y)
            => x >= Left && x < Right && y >= Top && y < Bottom;

        public bool Contains(PointF pt) => Contains(pt.X, pt.Y);

        public bool IntersectsWith(RectangleF rect)
            => rect.Left < Right && Left < rect.Right
            && rect.Top  < Bottom && Top < rect.Bottom;

        public void Intersect(RectangleF rect)
        {
            float l = Math.Max(Left,   rect.Left);
            float t = Math.Max(Top,    rect.Top);
            float r = Math.Min(Right,  rect.Right);
            float b = Math.Min(Bottom, rect.Bottom);
            if (l >= r || t >= b) { X = Y = Width = Height = 0; return; }
            X = l; Y = t; Width = r - l; Height = b - t;
        }

        public static RectangleF Intersect(RectangleF a, RectangleF b)
        {
            var result = a;
            result.Intersect(b);
            return result;
        }

        public static RectangleF Union(RectangleF a, RectangleF b)
            => FromLTRB(Math.Min(a.Left, b.Left),  Math.Min(a.Top, b.Top),
                        Math.Max(a.Right, b.Right), Math.Max(a.Bottom, b.Bottom));

        public void Inflate(float w, float h) { X -= w; Y -= h; Width += 2*w; Height += 2*h; }
        public void Offset(float dx, float dy) { X += dx; Y += dy; }

        // ── SkiaSharp interop ────────────────────────────────────────────────

        public SKRect ToSKRect() => new SKRect(Left, Top, Right, Bottom);

        public static implicit operator SKRect(RectangleF r) => r.ToSKRect();
        public static implicit operator RectangleF(SKRect r)
            => FromLTRB(r.Left, r.Top, r.Right, r.Bottom);

        // ── Equality ─────────────────────────────────────────────────────────

        public bool Equals(RectangleF other)
            => X == other.X && Y == other.Y && Width == other.Width && Height == other.Height;
        public override bool Equals(object obj) => obj is RectangleF r && Equals(r);
        public override int GetHashCode()
        {
            unchecked
            {
                int h = X.GetHashCode() * 397 ^ Y.GetHashCode();
                h = h * 397 ^ Width.GetHashCode();
                return h * 397 ^ Height.GetHashCode();
            }
        }
        public static bool operator ==(RectangleF a, RectangleF b) => a.Equals(b);
        public static bool operator !=(RectangleF a, RectangleF b) => !a.Equals(b);

        public override string ToString()
            => $"{{X={X},Y={Y},Width={Width},Height={Height}}}";
    }
}
