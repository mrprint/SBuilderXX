// SystemColors_Brushes_Pens.cs
namespace Drawing
{
    /// <summary>
    /// Provides commonly used named colors (subset of System.Drawing.SystemColors).
    /// </summary>
    public static class SystemColors
    {
        public static Color Window          => Color.White;
        public static Color WindowText      => Color.Black;
        public static Color Control         => Color.FromArgb(240, 240, 240);
        public static Color ControlText     => Color.Black;
        public static Color ControlDark     => Color.FromArgb(160, 160, 160);
        public static Color ControlDarkDark => Color.FromArgb(105, 105, 105);
        public static Color ControlLight    => Color.FromArgb(227, 227, 227);
        public static Color Highlight       => Color.FromArgb(0, 120, 215);
        public static Color HighlightText   => Color.White;
        public static Color GrayText        => Color.Gray;
        public static Color ButtonFace      => Color.FromArgb(240, 240, 240);
        public static Color ButtonShadow    => Color.FromArgb(160, 160, 160);
        public static Color ActiveCaption   => Color.FromArgb(0, 120, 215);
        public static Color InactiveCaption => Color.FromArgb(153, 180, 209);
        public static Color Desktop         => Color.Black;
        public static Color Menu            => Color.FromArgb(240, 240, 240);
        public static Color MenuText        => Color.Black;
        public static Color ScrollBar       => Color.FromArgb(200, 200, 200);
    }

    /// <summary>
    /// Provides pre-built SolidBrush instances for common colors.
    /// NOTE: Each property creates a new SolidBrush; callers should dispose after use.
    /// </summary>
    public static class Brushes
    {
        public static SolidBrush Black       => new SolidBrush(Color.Black);
        public static SolidBrush White       => new SolidBrush(Color.White);
        public static SolidBrush Red         => new SolidBrush(Color.Red);
        public static SolidBrush Green       => new SolidBrush(Color.Green);
        public static SolidBrush Blue        => new SolidBrush(Color.Blue);
        public static SolidBrush Yellow      => new SolidBrush(Color.Yellow);
        public static SolidBrush Orange      => new SolidBrush(Color.Orange);
        public static SolidBrush Gray        => new SolidBrush(Color.Gray);
        public static SolidBrush LightGray   => new SolidBrush(Color.LightGray);
        public static SolidBrush DarkGray    => new SolidBrush(Color.DarkGray);
        public static SolidBrush Transparent => new SolidBrush(Color.Transparent);
        public static SolidBrush Purple      => new SolidBrush(Color.Purple);
        public static SolidBrush Cyan        => new SolidBrush(Color.Cyan);
        public static SolidBrush Magenta     => new SolidBrush(Color.Magenta);
        public static SolidBrush Pink        => new SolidBrush(Color.Pink);
        public static SolidBrush Brown       => new SolidBrush(Color.Brown);
        public static SolidBrush Navy        => new SolidBrush(Color.Navy);
        public static SolidBrush Teal        => new SolidBrush(Color.Teal);
        public static SolidBrush Maroon      => new SolidBrush(Color.Maroon);
        public static SolidBrush Lime        => new SolidBrush(Color.Lime);
        public static SolidBrush Beige       => new SolidBrush(Color.Beige);       // was missing
        public static SolidBrush Crimson     => new SolidBrush(Color.Crimson);
        public static SolidBrush Fuchsia     => new SolidBrush(Color.Fuchsia);
        public static SolidBrush Olive       => new SolidBrush(Color.Olive);
        public static SolidBrush DarkBlue    => new SolidBrush(Color.DarkBlue);
        public static SolidBrush Gold        => new SolidBrush(Color.Gold);
        public static SolidBrush Silver      => new SolidBrush(Color.Silver);
        public static SolidBrush SkyBlue     => new SolidBrush(Color.SkyBlue);
        public static SolidBrush Coral       => new SolidBrush(Color.Coral);
        public static SolidBrush Salmon      => new SolidBrush(Color.Salmon);
        public static SolidBrush Turquoise   => new SolidBrush(Color.Turquoise);
        public static SolidBrush Khaki       => new SolidBrush(Color.Khaki);
        public static SolidBrush Lavender    => new SolidBrush(Color.Lavender);
        public static SolidBrush Ivory       => new SolidBrush(Color.Ivory);
        public static SolidBrush Indigo      => new SolidBrush(Color.Indigo);
        public static SolidBrush Violet      => new SolidBrush(Color.Violet);
    }

    /// <summary>
    /// Provides pre-built Pen instances for common colors (width = 1).
    /// NOTE: Each property creates a new Pen; callers should dispose after use.
    /// </summary>
    public static class Pens
    {
        public static Pen Black       => new Pen(Color.Black);
        public static Pen White       => new Pen(Color.White);
        public static Pen Red         => new Pen(Color.Red);
        public static Pen Green       => new Pen(Color.Green);
        public static Pen Blue        => new Pen(Color.Blue);
        public static Pen Yellow      => new Pen(Color.Yellow);
        public static Pen Orange      => new Pen(Color.Orange);
        public static Pen Gray        => new Pen(Color.Gray);
        public static Pen LightGray   => new Pen(Color.LightGray);
        public static Pen DarkGray    => new Pen(Color.DarkGray);
        public static Pen Transparent => new Pen(Color.Transparent);
        public static Pen Purple      => new Pen(Color.Purple);
        public static Pen Cyan        => new Pen(Color.Cyan);
        public static Pen Magenta     => new Pen(Color.Magenta);
        public static Pen Pink        => new Pen(Color.Pink);
        public static Pen Brown       => new Pen(Color.Brown);
        public static Pen Navy        => new Pen(Color.Navy);
        public static Pen Teal        => new Pen(Color.Teal);
        public static Pen Maroon      => new Pen(Color.Maroon);
        public static Pen Lime        => new Pen(Color.Lime);
        public static Pen Beige       => new Pen(Color.Beige);
        public static Pen Crimson     => new Pen(Color.Crimson);
        public static Pen Gold        => new Pen(Color.Gold);
        public static Pen Silver      => new Pen(Color.Silver);
        public static Pen SkyBlue     => new Pen(Color.SkyBlue);
    }
}
