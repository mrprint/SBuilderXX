# Drawing.SkiaSharpCompat

A **drop-in replacement** for `System.Drawing` on .NET 4.8, backed entirely by SkiaSharp.

## Namespace

```csharp
// Before
using System.Drawing;
using System.Drawing.Drawing2D;

// After – single change
using Drawing;
```

No other source changes are required for the covered API surface.

---

## Class Map

| System.Drawing | Drawing (this library) | SkiaSharp backing |
|---|---|---|
| `Color` | `Drawing.Color` | `SKColor` |
| `Point` | `Drawing.Point` | `SKPoint` |
| `PointF` | `Drawing.PointF` | `SKPoint` |
| `Size` / `SizeF` | `Drawing.Size` / `Drawing.SizeF` | — |
| `Rectangle` | `Drawing.Rectangle` | `SKRect` / `SKRectI` |
| `RectangleF` | `Drawing.RectangleF` | `SKRect` |
| `Font` | `Drawing.Font` | `SKTypeface` + `SKPaint` |
| `Brush` (abstract) | `Drawing.Brush` | `SKPaint` |
| `SolidBrush` | `Drawing.SolidBrush` | `SKPaint` |
| `Pen` | `Drawing.Pen` | `SKPaint` |
| `Matrix` | `Drawing.Matrix` | `SKMatrix` |
| `GraphicsPath` | `Drawing.GraphicsPath` | `SKPath` |
| `Image` | `Drawing.Image` | `SKBitmap` / `SKImage` |
| `Bitmap` | `Drawing.Bitmap` | `SKBitmap` |
| `Graphics` | `Drawing.Graphics` | `SKCanvas` |
| `StringFormat` | `Drawing.StringFormat` | — |
| `Brushes` (static) | `Drawing.Brushes` | — |
| `Pens` (static) | `Drawing.Pens` | — |
| `SystemColors` | `Drawing.SystemColors` | — |

---

## Method Map

| System.Drawing | Drawing (this library) |
|---|---|
| `Color.FromArgb(a,r,g,b)` | `Color.FromArgb(a,r,g,b)` ✓ |
| `Color.FromArgb(r,g,b)` | `Color.FromArgb(r,g,b)` ✓ |
| `Bitmap.Clone(rect, fmt)` | `Bitmap.Clone(rect, fmt)` ✓ |
| `Bitmap.GetPixel / SetPixel` | `Bitmap.GetPixel / SetPixel` ✓ |
| `Image.FromFile(path)` | `Image.FromFile(path)` / `Bitmap.FromFile(path)` ✓ |
| `Image.FromStream(stream)` | `Image.FromStream(stream)` / `Bitmap.FromStream(stream)` ✓ |
| `Graphics.DrawImage(...)` | `Graphics.DrawImage(...)` ✓ |
| `Graphics.DrawString(...)` | `Graphics.DrawString(...)` ✓ |
| `Graphics.MeasureString(...)` | `Graphics.MeasureString(...)` ✓ |
| `Graphics.SmoothingMode` | `Graphics.SmoothingMode` ✓ |
| `Graphics.TranslateTransform` | `Graphics.TranslateTransform` ✓ |
| `Graphics.RotateTransform` | `Graphics.RotateTransform` ✓ |
| `Graphics.ScaleTransform` | `Graphics.ScaleTransform` ✓ |
| `Graphics.Clear(color)` | `Graphics.Clear(color)` ✓ |
| `Graphics.Save / Restore` | `Graphics.Save / Restore` ✓ |
| `Font.GetHeight(dpi)` | `Font.GetHeight(dpi)` ✓ |
| `Rectangle.Intersect` | `Rectangle.Intersect` ✓ |

---

## Implicit Conversions

Every type exposes implicit/explicit operators so you can pass `Drawing.*` types directly to SkiaSharp APIs:

```csharp
Drawing.Color    → SKColor    (implicit both ways)
Drawing.Point    → SKPoint    (implicit)
Drawing.PointF   → SKPoint    (implicit both ways)
Drawing.Rectangle → SKRect / SKRectI (implicit)
Drawing.RectangleF → SKRect   (implicit both ways)
Drawing.Matrix   → SKMatrix   (implicit both ways)
Drawing.Bitmap   → SKBitmap   (implicit both ways)
Drawing.Image    → SKBitmap / SKImage (implicit)
Drawing.GraphicsPath → SKPath (implicit)
Drawing.Font     → SKPaint    (implicit)
Drawing.Brush    → SKPaint    (implicit)
Drawing.Pen      → SKPaint    (implicit)
Drawing.SolidBrush → SKColor  (implicit)
```

---

## Usage Examples

### Create a bitmap and draw on it

```csharp
using Drawing;

var bmp = new Bitmap(400, 300);
using var g = bmp.CreateGraphics();

g.Clear(Color.White);
g.SmoothingMode = SmoothingMode.AntiAlias;

using var pen  = new Pen(Color.Red, 2f);
using var fill = new SolidBrush(Color.FromArgb(128, Color.Blue));
var font       = new Font("Arial", 14f, FontStyle.Bold);

g.DrawRectangle(pen, new Rectangle(10, 10, 200, 100));
g.FillEllipse(fill, 50, 50, 100, 80);
g.DrawString("Hello SkiaSharp!", font, new SolidBrush(Color.Black), 10, 130);

bmp.Save("output.png", ImageFormat.Png);
```

### Load, clone, resize

```csharp
var original = Bitmap.FromFile("photo.jpg");
var cropped  = original.Clone(new Rectangle(0, 0, 200, 200));
var thumb    = cropped.Resize(64, 64);
thumb.Save("thumb.png");
```

### GraphicsPath

```csharp
using var path = new GraphicsPath();
path.AddRectangle(new RectangleF(10, 10, 80, 80));
path.AddEllipse(new RectangleF(30, 30, 40, 40));
path.FillMode = FillMode.Winding;

using var g    = Graphics.FromImage(bmp);
using var fill = new SolidBrush(Color.Teal);
g.FillPath(fill, path);
```

### Interop with raw SkiaSharp

```csharp
// Drawing types convert implicitly
SKColor sk1 = Color.Red;
Color   cl1 = new SKColor(255, 0, 128);

SKBitmap sk2 = bmp;        // Drawing.Bitmap → SKBitmap
Bitmap   cl2 = sk2;        // SKBitmap → Drawing.Bitmap

SKMatrix sk3 = matrix;     // Drawing.Matrix → SKMatrix
```

---

## Known Limitations / Notes

* **Text underline / strikeout** – SkiaSharp doesn't natively underline text. If your code requires these, draw horizontal lines manually after `DrawString`.
* **Gradient / Texture brushes** – Not included. Use `SKShader` directly with `SKPaint` and cast to/from `SKPaint` as needed.
* **GDI+ metafiles / EMF/WMF** – Not supported by SkiaSharp.
* **`Graphics.DrawImage` with `PointF[]` (affine warp)** – Approximate; use `SKCanvas.DrawBitmap` with an `SKMatrix` for precise control.
* **`Brushes.*/Pens.*` static properties** – Each access creates a new object; dispose it after use (or use `using`).
