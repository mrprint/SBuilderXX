// SystemDrawingBridge.cs
// Provides implicit conversions between Drawing.* and System.Drawing.* types.
//
// WHY THIS IS NEEDED:
//   Windows Forms designer generates code like:
//       this.button1.Location = new Drawing.Point(10, 20);
//   But 'Location' is System.Drawing.Point. C# won't apply cross-assembly
//   implicit operators on struct property assignments even with implicit
//   operators defined, so we add bridge operators that target System.Drawing.

using System;
using System.Drawing;
using System.IO;
using SD = System.Drawing;

namespace Drawing
{
    // ── Point ────────────────────────────────────────────────────────────────

    public partial struct Point
    {
        public static implicit operator SD.Point(Point p) => new SD.Point(p.X, p.Y);
        public static implicit operator Point(SD.Point p) => new Point(p.X, p.Y);
    }

    public partial struct PointF
    {
        public static implicit operator SD.PointF(PointF p) => new SD.PointF(p.X, p.Y);
        public static implicit operator PointF(SD.PointF p) => new PointF(p.X, p.Y);
    }

    // ── Size ─────────────────────────────────────────────────────────────────

    public partial struct Size
    {
        public static implicit operator SD.Size(Size s) => new SD.Size(s.Width, s.Height);
        public static implicit operator Size(SD.Size s) => new Size(s.Width, s.Height);
    }

    public partial struct SizeF
    {
        public static implicit operator SD.SizeF(SizeF s) => new SD.SizeF(s.Width, s.Height);
        public static implicit operator SizeF(SD.SizeF s) => new SizeF(s.Width, s.Height);
    }

    // ── Rectangle ────────────────────────────────────────────────────────────

    public partial struct Rectangle
    {
        public static implicit operator SD.Rectangle(Rectangle r)
            => new SD.Rectangle(r.X, r.Y, r.Width, r.Height);
        public static implicit operator Rectangle(SD.Rectangle r)
            => new Rectangle(r.X, r.Y, r.Width, r.Height);
    }

    public partial struct RectangleF
    {
        public static implicit operator SD.RectangleF(RectangleF r)
            => new SD.RectangleF(r.X, r.Y, r.Width, r.Height);
        public static implicit operator RectangleF(SD.RectangleF r)
            => new RectangleF(r.X, r.Y, r.Width, r.Height);
    }

    // ── Color ────────────────────────────────────────────────────────────────

    public partial struct Color
    {
        public static implicit operator SD.Color(Color c)
            => SD.Color.FromArgb(c.A, c.R, c.G, c.B);
        public static implicit operator Color(SD.Color c)
            => Color.FromArgb(c.A, c.R, c.G, c.B);
    }

    // ── ContentAlignment ─────────────────────────────────────────────────────
    // WinForms Button/Label.TextAlign is System.Drawing.ContentAlignment.
    // Designer code: this.label1.TextAlign = Drawing.ContentAlignment.MiddleLeft;
    // The enum values are identical between both enums (same underlying int layout),
    // so a cast-based conversion is safe.

    public static class ContentAlignmentConverter
    {
        public static SD.ContentAlignment ToSystem(ContentAlignment a)
            => (SD.ContentAlignment)(int)a;
        public static ContentAlignment FromSystem(SD.ContentAlignment a)
            => (ContentAlignment)(int)a;
    }

    // ── Image ────────────────────────────────────────────────────────────────
    // Drawing.Image and System.Drawing.Image are unrelated class hierarchies;
    // implicit operators between classes are not allowed in C#.
    // We solve this by adding a ToSystemImage() extension and a static
    // Graphics.FromSystemGraphics() helper so app code can bridge the gap.
    //
    // For DESIGNER files that assign Drawing.Image to a Button/PictureBox.Image
    // property (which expects System.Drawing.Image), the only clean solution is
    // to make Drawing.Image inherit from System.Drawing.Image — but that conflicts
    // with the SkiaSharp backing.
    //
    // RECOMMENDED APPROACH for designer Image assignments:
    //   Replace `resources.GetObject("...")` calls in designer files with a
    //   helper that returns System.Drawing.Image directly, OR keep using
    //   System.Drawing.Bitmap for UI resources and only use Drawing.Bitmap
    //   for SkiaSharp rendering.
    //
    // The extension methods below enable manual conversion where needed in code:

    public static class DrawingBridgeExtensions
    {
        /// <summary>
        /// Converts a Drawing.Bitmap to a System.Drawing.Bitmap by round-tripping
        /// through a PNG memory stream. Use for control .Image property assignments.
        /// </summary>
        public static SD.Bitmap ToSystemBitmap(this Bitmap src)
        {
            using (var stream = new MemoryStream())
            {
                src.Save(stream, ImageFormat.Png);
                stream.Position = 0;
                return new SD.Bitmap(stream);
            }
        }

        /// <summary>Converts a System.Drawing.Bitmap to a Drawing.Bitmap.</summary>
        public static Bitmap ToDrawingBitmap(this SD.Bitmap src)
        {
            using (var stream = new MemoryStream())
            {
                src.Save(stream, SD.Imaging.ImageFormat.Png);
                stream.Position = 0;
                return Bitmap.FromStream(stream) as Bitmap;
            }
        }

        /// <summary>Converts a Drawing.Font to a System.Drawing.Font.</summary>
        public static SD.Font ToSystemFont(this Font f)
            => new SD.Font(f.FamilyName, f.Size,
                           (SD.FontStyle)(int)f.Style,
                           (SD.GraphicsUnit)(int)f.Unit);

        /// <summary>Converts a System.Drawing.Font to a Drawing.Font.</summary>
        public static Font ToDrawingFont(this SD.Font f)
            => new Font(f.FontFamily.Name, f.Size,
                        (FontStyle)(int)f.Style,
                        (GraphicsUnit)(int)f.Unit);
    }

    // ── Graphics bridge ───────────────────────────────────────────────────────
    // System.Drawing.Graphics cannot be implicitly converted to Drawing.Graphics.
    // The partial class adds a factory method so app code can write:
    //   Drawing.Graphics g = Graphics.FromSystemGraphics(e.Graphics);

    public sealed partial class Graphics
    {
        /// <summary>
        /// Creates a Drawing.Graphics wrapper around a System.Drawing.Graphics
        /// obtained from WinForms paint events (e.g., PaintEventArgs.Graphics).
        ///
        /// NOTE: Drawing operations go to a temporary SkiaSharp surface and are
        /// then composited back. For simple paint handlers, use the WinForms
        /// Graphics directly, or migrate the form to use SKControl/SKGLControl.
        ///
        /// Usage:
        ///   void OnPaint(object s, PaintEventArgs e) {
        ///       using var g = Graphics.FromSystemGraphics(e.Graphics);
        ///       g.DrawLine(...);
        ///   }  // auto-flushes on dispose
        /// </summary>
        public static Graphics FromSystemGraphics(SD.Graphics sdg)
        {
            int w = (int)sdg.ClipBounds.Width;
            int h = (int)sdg.ClipBounds.Height;
            if (w <= 0) w = 1;
            if (h <= 0) h = 1;

            // Create an off-screen SkiaSharp surface the same size as the clip rect.
            var g = FromSize(w, h);
            g._systemGraphicsTarget = sdg;
            g._systemGraphicsOffsetX = (int)sdg.ClipBounds.Left;
            g._systemGraphicsOffsetY = (int)sdg.ClipBounds.Top;
            return g;
        }

        // Fields used by FromSystemGraphics; flushed on Dispose.
        private SD.Graphics _systemGraphicsTarget;
        private int _systemGraphicsOffsetX;
        private int _systemGraphicsOffsetY;

        partial void OnDisposing()
        {
            FlushToSystemGraphics();
        }

        private void FlushToSystemGraphics()
        {
            if (_systemGraphicsTarget == null) return;
            try
            {
                var bmp = ToBitmap();
                using (var sysBmp = bmp.ToSystemBitmap())
                {
                    _systemGraphicsTarget.DrawImage(
                        sysBmp,
                        _systemGraphicsOffsetX,
                        _systemGraphicsOffsetY);
                }
            }
            catch { /* best-effort */ }
            finally
            {
                _systemGraphicsTarget = null;
            }
        }
    }

    // ────────────────────────────────────────────────────────────────────────
    // ContentAlignment  (replaces System.Drawing.ContentAlignment)
    // ────────────────────────────────────────────────────────────────────────

    public enum ContentAlignment
    {
        TopLeft      = 0x001,
        TopCenter    = 0x002,
        TopRight     = 0x004,
        MiddleLeft   = 0x010,
        MiddleCenter = 0x020,
        MiddleRight  = 0x040,
        BottomLeft   = 0x100,
        BottomCenter = 0x200,
        BottomRight  = 0x400,
    }

    /// <summary>
    /// Converts between Drawing.ContentAlignment and System.Drawing.ContentAlignment.
    /// The underlying int values are identical (defined by WinForms spec).
    /// </summary>
    public static class ContentAlignmentEx
    {
        public static SD.ContentAlignment ToSystem(this ContentAlignment a)
            => (SD.ContentAlignment)(int)a;

        public static ContentAlignment FromSystem(SD.ContentAlignment a)
            => (ContentAlignment)(int)a;
    }
}

// ── Font bridge ───────────────────────────────────────────────────────────
// Drawing.Font cannot implicitly convert to System.Drawing.Font (unrelated
// class hierarchies). The bridge adds a static helper on the Font class so
// designer-generated code that does:
//   this.label1.Font = new Drawing.Font(...)
// can be patched to:
//   this.label1.Font = new System.Drawing.Font(...)
//
// The PowerShell script handles this replacement automatically for
// .Font = new Drawing.Font( patterns in Designer files.
//
// For explicit Drawing.Font -> System.Drawing.Font conversions in app code,
// use the ToSystemFont() extension defined above.