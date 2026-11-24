using System;
using System.Drawing;

namespace shapes
{
    // Бүх дүрсийн суурь класс
    public abstract class Shape
    {
        public Color Color { get; set; }
        public int Width { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }

        protected Shape(Color color, int width, Point start)
        {
            Color = color;
            Width = width;
            Start = start;
            End = start;
        }

        // Хулганыг хаашаа ч чирсэн тэгш өнцөгийн хэмжээ зөв гарна
        protected Rectangle GetRect()
        {
            return new Rectangle(
                Math.Min(Start.X, End.X),
                Math.Min(Start.Y, End.Y),
                Math.Abs(End.X - Start.X),
                Math.Abs(End.Y - Start.Y));
        }

        // Хулганы байрлал өөрчлөгдөхөд дүрсийг шинэчилнэ
        public virtual void Update(Point p)
        {
            End = p;
        }

        // Дүрсийг зурах (класс бүр өөрөө зурдаг)
        public abstract void Draw(Graphics g);
    }
}