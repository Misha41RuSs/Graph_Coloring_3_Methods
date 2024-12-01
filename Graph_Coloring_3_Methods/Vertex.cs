using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Coloring_3_Methods
{
    internal class Vertex
    {
        public Point position;

        private Graphics graphEgitorBox;

        private int radius;

        public Rectangle Properties => new Rectangle(position.X - radius, position.Y - radius, radius * 2, radius * 2);

        public bool IsSelected = false;

        public int index;

        public Vertex(Point position, int radius, int index, Graphics graphEgitorBox)
        {
            this.graphEgitorBox = graphEgitorBox;

            this.position = position;
            this.radius = radius;
            this.index = index;
        }

        public void Draw()
        {
            Pen pen = IsSelected ? new Pen(Color.Red) : new Pen(Color.Black);

            pen.Width = 3;
            graphEgitorBox.DrawEllipse(pen, Properties);
            ColorVertex(Color.White);
        }
        // Рисуем вершинки
        public void ColorVertex(Color color) 
        {
            graphEgitorBox.FillEllipse(new SolidBrush(color), Properties);
            Color colorForPen = Color.Black;
            if (color != Color.White)
            {
                colorForPen = Color.White;
            }
            graphEgitorBox.DrawString(index.ToString(), new Font("Arial", 14), new SolidBrush(colorForPen), position.X + 12 - radius, position.Y + 9 - radius);
        }

        public void Move(Point point)
        {
            position = point;
            VertexUnselected();
        }

        public void VertexSelected()
        {
            IsSelected = true;
            Draw();
        }

        public void VertexUnselected()
        {
            IsSelected = false;
            Draw();
        }
    }
}

