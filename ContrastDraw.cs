namespace SBuilderXX
{
    internal static class ContrastDraw
    {
        internal static SkiaSharp.SKColor GetContrastColor(SkiaSharp.SKColor c)
        {
            float luminance = (0.299f * c.Red + 0.587f * c.Green + 0.114f * c.Blue) / 255f;
            return luminance > 0.5f ? SkiaSharp.SKColors.Black : SkiaSharp.SKColors.White;
        }

        internal static void DotLine(
            SkiaSharp.SKCanvas canvas,
            float x0, float y0, float x1, float y1,
            SkiaSharp.SKColor userColor,
            float strokeWidth = 2f, float dotSize = 3f, float gap = 3f)
        {
            var contrastColor = GetContrastColor(userColor);
            using var cp = MakeDotPaint(contrastColor, strokeWidth, dotSize, gap, 0f);
            using var up = MakeDotPaint(userColor, strokeWidth, dotSize, gap, dotSize + gap * 0.5f);
            canvas.DrawLine(x0, y0, x1, y1, cp);
            canvas.DrawLine(x0, y0, x1, y1, up);
        }

        internal static void DotRect(
            SkiaSharp.SKCanvas canvas,
            float x, float y, float width, float height,
            SkiaSharp.SKColor userColor,
            float strokeWidth = 2f, float dotSize = 3f, float gap = 3f)
        {
            var contrastColor = GetContrastColor(userColor);
            var rect = SkiaSharp.SKRect.Create(x, y, width, height);
            using var cp = MakeDotPaint(contrastColor, strokeWidth, dotSize, gap, 0f);
            using var up = MakeDotPaint(userColor, strokeWidth, dotSize, gap, dotSize + gap * 0.5f);
            canvas.DrawRect(rect, cp);
            canvas.DrawRect(rect, up);
        }

        internal static void DotRectFilled(
            SkiaSharp.SKCanvas canvas,
            float x, float y, float width, float height,
            SkiaSharp.SKColor fillColor,
            float strokeWidth = 2f, float dotSize = 3f, float gap = 3f)
        {
            var rect = SkiaSharp.SKRect.Create(x, y, width, height);
            using var fillPaint = new SkiaSharp.SKPaint
            {
                Color = fillColor,
                Style = SkiaSharp.SKPaintStyle.Fill,
                IsAntialias = true
            };
            canvas.DrawRect(rect, fillPaint);
            DotRect(canvas, x, y, width, height, fillColor, strokeWidth, dotSize, gap);
        }

        internal static void DotPoint(
            SkiaSharp.SKCanvas canvas,
            float cx, float cy,
            SkiaSharp.SKColor userColor,
            float radius = 3f)
        {
            var contrastColor = GetContrastColor(userColor);
            using var innerPaint = new SkiaSharp.SKPaint
            {
                Color = userColor,
                Style = SkiaSharp.SKPaintStyle.Fill,
                IsAntialias = true
            };
            using var outerPaint = new SkiaSharp.SKPaint
            {
                Color = contrastColor,
                Style = SkiaSharp.SKPaintStyle.Stroke,
                StrokeWidth = 1.5f,
                IsAntialias = true
            };
            canvas.DrawCircle(cx, cy, radius, innerPaint);
            canvas.DrawCircle(cx, cy, radius, outerPaint);
        }

        internal static void DotLineSelected(
            SkiaSharp.SKCanvas canvas,
            float x0, float y0, float x1, float y1,
            SkiaSharp.SKColor userColor,
            float marchOffset,
            float strokeWidth = 2f, float dotSize = 3f, float gap = 3f)
        {
            DotLine(canvas, x0, y0, x1, y1, userColor, strokeWidth, dotSize, gap);
            using var mp = MakeMarchPaint(strokeWidth + 1f, marchOffset);
            canvas.DrawLine(x0, y0, x1, y1, mp);
        }

        internal static void DotRectSelected(
            SkiaSharp.SKCanvas canvas,
            float x, float y, float width, float height,
            SkiaSharp.SKColor userColor,
            float marchOffset,
            float strokeWidth = 2f, float dotSize = 3f, float gap = 3f)
        {
            DotRect(canvas, x, y, width, height, userColor, strokeWidth, dotSize, gap);
            using var mp = MakeMarchPaint(strokeWidth + 1f, marchOffset);
            canvas.DrawRect(SkiaSharp.SKRect.Create(x, y, width, height), mp);
        }

        // ── private helpers ──────────────────────────────────────────────

        private static SkiaSharp.SKPaint MakeDotPaint(
            SkiaSharp.SKColor color,
            float strokeWidth, float dotSize, float gap, float offset)
        {
            return new SkiaSharp.SKPaint
            {
                Color = color,
                StrokeWidth = strokeWidth,
                IsAntialias = true,
                Style = SkiaSharp.SKPaintStyle.Stroke,
                StrokeCap = SkiaSharp.SKStrokeCap.Round,
                PathEffect = SkiaSharp.SKPathEffect.CreateDash(
                    new float[] { dotSize, gap }, offset)
            };
        }

        private static SkiaSharp.SKPaint MakeMarchPaint(
            float strokeWidth, float marchOffset)
        {
            return new SkiaSharp.SKPaint
            {
                Color = new SkiaSharp.SKColor(255, 255, 0, 180),
                StrokeWidth = strokeWidth,
                Style = SkiaSharp.SKPaintStyle.Stroke,
                StrokeCap = SkiaSharp.SKStrokeCap.Round,
                PathEffect = SkiaSharp.SKPathEffect.CreateDash(
                    new float[] { 4f, 4f }, marchOffset)
            };
        }
    }
}
