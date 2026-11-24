using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace shapes
{
    // Харандаа: хулганы бүх цэгийг хадгалж, холбон зурна
    public class PenShape : Shape
    {
        private readonly List<Point> points = new List<Point>();

        public PenShape(Color color, int width, Point start)
            : base(color, width, start)
        {
            points.Add(start);
        }

        public override void Update(Point p)
        {
            points.Add(p);
            End = p;
        }

        public override void Draw(Graphics g)
        {
            if (points.Count < 2) return;

            using (Pen pen = new Pen(Color, Width)
            {
                StartCap = LineCap.Round,
                EndCap = LineCap.Round,
                LineJoin = LineJoin.Round
            })
            {
                g.DrawLines(pen, points.ToArray());
            }
        }
    }
}