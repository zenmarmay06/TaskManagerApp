using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;

namespace TaskManager.UI.Helpers
{
    using System.Drawing;
    using System.Drawing.Drawing2D;

    public static class GraphicsExtensions
    {

        public static void FillRoundedRectangle(this Graphics g, Brush brush, Rectangle rect, int radius)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                int d = radius * 2;

                path.AddArc(rect.X, rect.Y, d, d, 180, 90);
                path.AddArc(rect.Right - d, rect.Y, d, d, 270, 90);
                path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
                path.AddArc(rect.X, rect.Bottom - d, d, d, 90, 90);

                path.CloseFigure();
                g.FillPath(brush, path);
            }
        
         }
    }
}
