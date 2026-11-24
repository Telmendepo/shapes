using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace shapes
{
    public partial class Form1 : Form
    {
        private readonly List<Shape> shapes = new List<Shape>();
        private Shape current;                 // одоо зурж буй дүрс
        private Color penColor = Color.Black;
        private int penWidth = 1;
        private string mode = "pen";           // pen, rect, line, circle

        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            KeyPreview = true;

            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            KeyDown += Form1_KeyDown;
            Paint += Form1_Paint;
        }

        // Горимын товчлол: P = харандаа, R = тэгш өнцөг, L = шулуун, C = дугуй
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.P) mode = "pen";
            else if (e.KeyCode == Keys.R) mode = "rect";
            else if (e.KeyCode == Keys.L) mode = "line";
            else if (e.KeyCode == Keys.C) mode = "circle";
        }

        private Shape CreateShape(Point p)
        {
            switch (mode)
            {
                case "rect": return new RectShape(penColor, penWidth, p);
                case "line": return new LineShape(penColor, penWidth, p);
                case "circle": return new CircleShape(penColor, penWidth, p);
                default: return new PenShape(penColor, penWidth, p);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;

            current = CreateShape(e.Location);
            shapes.Add(current);
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (current == null) return;

            current.Update(e.Location);
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            current = null;
            Invalidate();
        }

        // Бүх дүрсийг жагсаалтаас нь дахин зурна
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (Shape s in shapes)
            {
                s.Draw(e.Graphics);
            }
        }

        // Tools → Харандаа
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "pen";
        }

        // Tools → Тэгш өнцөг
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "rect";
        }

        // Tools → Шулуун
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "line";
        }

        // Tools → Дугуй
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = "circle";
        }

        // Tools → Өнгө
        private void өнгөToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = penColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                penColor = colorDialog1.Color;
            }
        }

        // Өргөн сонгох ComboBox
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(toolStripComboBox1.SelectedItem?.ToString(), out int w))
                penWidth = w;
        }
    }
}