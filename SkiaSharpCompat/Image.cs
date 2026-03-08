// Image.cs
using System;
using System.IO;
using SkiaSharp;

namespace Drawing
{
    // ────────────────────────────────────────────────────────────────────────
    // ImageFormat
    // ────────────────────────────────────────────────────────────────────────

    public enum ImageFormat { Png, Jpeg, Bmp, Gif, Tiff, Webp }

    // ────────────────────────────────────────────────────────────────────────
    // PropertyItem  (stub for System.Drawing.Imaging.PropertyItem)
    // Used by GetPropertyItem / SetPropertyItem on Image.
    // ────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Stub for System.Drawing.Imaging.PropertyItem.
    /// SkiaSharp does not expose raw EXIF property items; this class exists
    /// so code that reads/writes property items compiles and runs without
    /// crashing. Property values are stored in-memory only.
    /// </summary>
    public sealed class PropertyItem
    {
        public int Id { get; set; }
        public int Len { get; set; }
        public short Type { get; set; }
        public byte[] Value { get; set; }
    }

    // ────────────────────────────────────────────────────────────────────────
    // Image (abstract base)
    // ────────────────────────────────────────────────────────────────────────

    public abstract class Image : IDisposable
    {
        protected bool _disposed;
        protected SKBitmap _bitmap;

        // In-memory property item store (EXIF stub)
        private System.Collections.Generic.Dictionary<int, PropertyItem> _propertyItems;

        public int Width => _bitmap?.Width ?? 0;
        public int Height => _bitmap?.Height ?? 0;
        public Size Size => new Size(Width, Height);

        /// <summary>Raw access to the underlying SKBitmap (caller must not dispose).</summary>
        public SKBitmap SKBitmap => _bitmap;

        // ── RawFormat ────────────────────────────────────────────────────────

        /// <summary>
        /// The format in which this image was loaded/created.
        /// Defaults to Png. Set during load if the source format is known.
        /// Matches System.Drawing.Image.RawFormat semantics.
        /// </summary>
        public ImageFormat RawFormat { get; protected set; } = ImageFormat.Png;

        // ── PropertyItem (EXIF stub) ──────────────────────────────────────────

        /// <summary>
        /// Returns the property item with the specified ID.
        /// Throws ArgumentException if not found (matches System.Drawing behaviour).
        /// </summary>
        public PropertyItem GetPropertyItem(int propid)
        {
            if (_propertyItems != null && _propertyItems.TryGetValue(propid, out var item))
                return item;
            throw new ArgumentException($"Property not found: 0x{propid:X4}", nameof(propid));
        }

        /// <summary>Stores a property item (in-memory only; not written to the file).</summary>
        public void SetPropertyItem(PropertyItem propitem)
        {
            if (propitem == null) throw new ArgumentNullException(nameof(propitem));
            if (_propertyItems == null)
                _propertyItems = new System.Collections.Generic.Dictionary<int, PropertyItem>();
            _propertyItems[propitem.Id] = propitem;
        }

        /// <summary>Returns all stored property items (may be empty).</summary>
        public PropertyItem[] PropertyItems
        {
            get
            {
                if (_propertyItems == null || _propertyItems.Count == 0)
                    return Array.Empty<PropertyItem>();
                var arr = new PropertyItem[_propertyItems.Count];
                _propertyItems.Values.CopyTo(arr, 0);
                return arr;
            }
        }

        // ── Factories ────────────────────────────────────────────────────────

        public static Image FromFile(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Image file not found.", path);
            var bmp = SKBitmap.Decode(path)
                   ?? throw new InvalidOperationException($"Cannot decode image: {path}");
            var img = new Bitmap(bmp);
            img.RawFormat = GuessFormat(path);
            return img;
        }

        public static Image FromStream(Stream stream)
        {
            var bmp = SKBitmap.Decode(stream)
                   ?? throw new InvalidOperationException("Cannot decode image from stream.");
            return new Bitmap(bmp);
        }

        private static ImageFormat GuessFormat(string path)
        {
            var ext = Path.GetExtension(path)?.ToLowerInvariant();
            switch (ext)
            {
                case ".jpg":
                case ".jpeg": return ImageFormat.Jpeg;
                case ".bmp": return ImageFormat.Bmp;
                case ".gif": return ImageFormat.Gif;
                case ".tif":
                case ".tiff": return ImageFormat.Tiff;
                case ".webp": return ImageFormat.Webp;
                default: return ImageFormat.Png;
            }
        }

        // ── Save ─────────────────────────────────────────────────────────────

        public void Save(string path, ImageFormat format = ImageFormat.Png)
        {
            using var image = SKImage.FromBitmap(_bitmap);
            using var data = image.Encode(ToSkEncoded(format), 90);
            using var stream = File.OpenWrite(path);
            data.SaveTo(stream);
        }

        public void Save(Stream stream, ImageFormat format = ImageFormat.Png)
        {
            using var image = SKImage.FromBitmap(_bitmap);
            using var data = image.Encode(ToSkEncoded(format), 90);
            data.SaveTo(stream);
        }

        private static SKEncodedImageFormat ToSkEncoded(ImageFormat fmt)
            => fmt switch
            {
                ImageFormat.Jpeg => SKEncodedImageFormat.Jpeg,
                ImageFormat.Bmp => SKEncodedImageFormat.Bmp,
                ImageFormat.Gif => SKEncodedImageFormat.Gif,
                ImageFormat.Webp => SKEncodedImageFormat.Webp,
                _ => SKEncodedImageFormat.Png,
            };

        // ── Conversions ──────────────────────────────────────────────────────

        public static implicit operator SKBitmap(Image img) => img._bitmap;
        public static implicit operator SKImage(Image img) => SKImage.FromBitmap(img._bitmap);

        // ── IDisposable ──────────────────────────────────────────────────────

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing) _bitmap?.Dispose();
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }

    // ────────────────────────────────────────────────────────────────────────
    // PixelFormat enum
    // ────────────────────────────────────────────────────────────────────────

    public enum PixelFormat
    {
        Format32bppArgb = 0,
        Format32bppRgb = 1,
        Format24bppRgb = 2,
        Format8bppIndexed = 3,
        DontCare = -1
    }

    // ────────────────────────────────────────────────────────────────────────
    // Bitmap
    // ────────────────────────────────────────────────────────────────────────

    public sealed class Bitmap : Image
    {
        public Bitmap(int width, int height,
                      PixelFormat format = PixelFormat.Format32bppArgb)
        {
            _bitmap = new SKBitmap(width, height, ToColorType(format), SKAlphaType.Premul);
            _bitmap.Erase(SKColors.Transparent);
        }

        public Bitmap(string path)
        {
            if (!File.Exists(path))
                throw new FileNotFoundException("Bitmap file not found.", path);
            _bitmap = SKBitmap.Decode(path)
                      ?? throw new InvalidOperationException($"Cannot decode bitmap: {path}");
            RawFormat = GuessFormat(path);
        }

        public Bitmap(Stream stream)
        {
            _bitmap = SKBitmap.Decode(stream)
                   ?? throw new InvalidOperationException("Cannot decode bitmap from stream.");
        }

        public Bitmap(Image original, int width, int height)
        {
            _bitmap = original.SKBitmap.Resize(
                new SKImageInfo(width, height), SKFilterQuality.High)
                ?? throw new InvalidOperationException("Failed to resize bitmap.");
        }

        internal Bitmap(SKBitmap skBitmap)
        {
            _bitmap = skBitmap ?? throw new ArgumentNullException(nameof(skBitmap));
        }

        // ── Factories ────────────────────────────────────────────────────────

        public static new Bitmap FromFile(string path)
        {
            var bmp = SKBitmap.Decode(path)
                   ?? throw new InvalidOperationException($"Cannot decode image: {path}");
            return new Bitmap(bmp) { RawFormat = GuessFormat(path) };
        }

        public static new Bitmap FromStream(Stream stream)
        {
            var bmp = SKBitmap.Decode(stream)
                   ?? throw new InvalidOperationException("Cannot decode image from stream.");
            return new Bitmap(bmp);
        }

        // ── Pixel access ─────────────────────────────────────────────────────

        public Color GetPixel(int x, int y)
        {
            var c = _bitmap.GetPixel(x, y);
            return Color.FromArgb(c.Alpha, c.Red, c.Green, c.Blue);
        }

        public void SetPixel(int x, int y, Color color)
            => _bitmap.SetPixel(x, y, color.ToSKColor());

        // ── Clone ────────────────────────────────────────────────────────────

        public Bitmap Clone() => new Bitmap(_bitmap.Copy());

        public Bitmap Clone(RectangleF rect, PixelFormat format = PixelFormat.Format32bppArgb)
            => Clone(new Rectangle((int)rect.X, (int)rect.Y,
                                   (int)rect.Width, (int)rect.Height), format);

        public Bitmap Clone(Rectangle rect, PixelFormat format = PixelFormat.Format32bppArgb)
        {
            var info = new SKImageInfo(rect.Width, rect.Height, ToColorType(format), SKAlphaType.Premul);
            var dest = new SKBitmap(info);
            using var canvas = new SKCanvas(dest);
            canvas.DrawBitmap(_bitmap,
                new SKRect(rect.Left, rect.Top, rect.Right, rect.Bottom),
                new SKRect(0, 0, rect.Width, rect.Height));
            return new Bitmap(dest);
        }

        // ── Resize ───────────────────────────────────────────────────────────

        public Bitmap Resize(int width, int height,
                             SKFilterQuality quality = SKFilterQuality.High)
            => new Bitmap(_bitmap.Resize(new SKImageInfo(width, height), quality));

        // ── Graphics ─────────────────────────────────────────────────────────

        public Graphics CreateGraphics() => Graphics.FromImage(this);

        // ── Conversions ──────────────────────────────────────────────────────

        public static implicit operator SKBitmap(Bitmap b) => b._bitmap;
        public static implicit operator Bitmap(SKBitmap b) => new Bitmap(b);

        // ── Helpers ──────────────────────────────────────────────────────────

        private static ImageFormat GuessFormat(string path)
        {
            var ext = System.IO.Path.GetExtension(path)?.ToLowerInvariant();
            switch (ext)
            {
                case ".jpg":
                case ".jpeg": return ImageFormat.Jpeg;
                case ".bmp": return ImageFormat.Bmp;
                case ".gif": return ImageFormat.Gif;
                case ".tif":
                case ".tiff": return ImageFormat.Tiff;
                case ".webp": return ImageFormat.Webp;
                default: return ImageFormat.Png;
            }
        }

        private static SKColorType ToColorType(PixelFormat fmt)
            => fmt switch
            {
                PixelFormat.Format32bppRgb => SKColorType.Rgb888x,
                PixelFormat.Format24bppRgb => SKColorType.Rgb888x,
                PixelFormat.Format8bppIndexed => SKColorType.Gray8,
                _ => SKColorType.Bgra8888,
            };
    }
}