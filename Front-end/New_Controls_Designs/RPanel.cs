using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Demo_Project
{
    public class RPanel : Panel
    {
        //Fields
        private int _borderRadius = 0;

        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            Rectangle rectangle = new Rectangle(0, 0, this.Width, this.Height);
            int borderRadius = _borderRadius;

            if (borderRadius > 0)
            {
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.StartFigure();

                    // Top left corner
                    path.AddArc(new Rectangle(rectangle.X, rectangle.Y, borderRadius * 2, borderRadius * 2), 180, 90);

                    // Top right corner
                    path.AddArc(new Rectangle(rectangle.Width - (borderRadius * 2), rectangle.Y, borderRadius * 2, borderRadius * 2), 270, 90);

                    // Bottom right corner
                    path.AddArc(new Rectangle(rectangle.Width - (borderRadius * 2), rectangle.Height - (borderRadius * 2), borderRadius * 2, borderRadius * 2), 0, 90);

                    // Bottom left corner
                    path.AddArc(new Rectangle(rectangle.X, rectangle.Height - (borderRadius * 2), borderRadius * 2, borderRadius * 2), 90, 90);

                    path.CloseFigure();

                    this.Region = new Region(path);
                }
            }
        }


    }
}
