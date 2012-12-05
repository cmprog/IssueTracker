using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace TccLib.Drawing.Extensions
{
    public static class GraphicsExtensions
    {
        public static void DrawRoundedRectangle(this Graphics g, Pen pen, RectangleF bounds, float cornerRadius)
        {
            var lGraphicsPath = new GraphicsPath();
            lGraphicsPath.AddArc(bounds.Left, bounds.Top, cornerRadius, cornerRadius, 180, 90);
            lGraphicsPath.AddArc(bounds.Right - cornerRadius - 1, bounds.Top, cornerRadius, cornerRadius, 270, 90);
            lGraphicsPath.AddArc(bounds.Right - cornerRadius - 1, bounds.Bottom - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90);
            lGraphicsPath.AddArc(bounds.Left, bounds.Bottom - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90);
            lGraphicsPath.CloseAllFigures();

            g.DrawPath(pen, lGraphicsPath);
        }

        public static void FillRoundedRectangle(this Graphics g, Brush brush, RectangleF bounds, float cornerRadius)
        {
            var lGraphicsPath = new GraphicsPath();
            lGraphicsPath.AddArc(bounds.Left, bounds.Top, cornerRadius, cornerRadius, 180, 90);
            lGraphicsPath.AddArc(bounds.Right - cornerRadius - 1, bounds.Top, cornerRadius, cornerRadius, 270, 90);
            lGraphicsPath.AddArc(bounds.Right - cornerRadius - 1, bounds.Bottom - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90);
            lGraphicsPath.AddArc(bounds.Left, bounds.Bottom - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90);
            lGraphicsPath.CloseAllFigures();

            g.FillPath(brush, lGraphicsPath);
        }
    }
}
