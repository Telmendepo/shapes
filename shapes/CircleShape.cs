using System.Drawing;

namespace shapes
{
    public class CircleShape : Shape
    {
        public CircleShape(Color color, int width, Point start)
            : base(color, width, start)
        {
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Width))
            {
                g.DrawEllipse(pen, GetRect());
            }
        }
    }
}