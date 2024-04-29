using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HiraKata_Kaizen {
    public class CustomPanel : Panel {
        byte borderRadius = 30;

        public CustomPanel() {
            BackColor = Color.FromArgb(24, 24, 27);
            ForeColor = Color.Snow;
            Size = new Size(400, 200);
        }

        public byte BorderRadius { get => borderRadius; set { borderRadius = value; Invalidate(); } }

        GraphicsPath GetPanelPath(RectangleF rec, float radius) {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rec.Width - radius, rec.Height - radius, radius, radius, 0, 90);
            path.AddArc(rec.X, rec.Height - radius, radius, radius, 90, 90);
            path.AddArc(rec.X, rec.Y, radius, radius, 180, 90);
            path.AddArc(rec.Width - radius, rec.Y, radius, radius, 270, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // borderRadius
            RectangleF rec = new RectangleF(0, 0, Width, Height);
            if (borderRadius > 2) {
                using (GraphicsPath path = GetPanelPath(rec, borderRadius))
                using (Pen pen = new Pen(Parent.BackColor, 2)) {
                    Region = new Region(path);
                    e.Graphics.DrawPath(pen, path);
                }
            }
            else {
                Region = new Region(rec);
            }
        }
    }
}
