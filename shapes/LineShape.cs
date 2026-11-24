using System.Drawing;

namespace shapes
{
    public class LineShape : Shape
    {
        public LineShape(Color color, int width, Point start)
            : base(color, width, start)
        {
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Width))
            {
                g.DrawLine(pen, Start, End);
            }
        }
    }
}