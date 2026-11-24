using System.Drawing;

namespace shapes
{
    public class RectShape : Shape
    {
        public RectShape(Color color, int width, Point start)
            : base(color, width, start)
        {
        }

        public override void Draw(Graphics g)
        {
            using (Pen pen = new Pen(Color, Width))
            {
                g.DrawRectangle(pen, GetRect());
            }
        }
    }
}