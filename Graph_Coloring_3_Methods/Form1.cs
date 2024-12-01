using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph_Coloring_3_Methods
{
    public partial class Form1 : Form
    {
        private Graphics graphEgitorBox;
        private Graph graph;

        public Form1()
        {
            InitializeComponent();
            graphEgitorBox = pictureBox1.CreateGraphics();
            graph = new Graph(graphEgitorBox);

            ClearEditorPictureBox();
            toolTip1.SetToolTip(addVertexButton, "Добавить вершину");
            toolTip2.SetToolTip(addEdgeButton, "Добавить ребро");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void ClearEditorPictureBox()
        {
            graphEgitorBox.Clear(Color.White);
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (addVertexButton.Focused)
            {
                graph.AddVertex(new Point(e.X, e.Y));
            }
            else if (addEdgeButton.Focused)
            {
                if (graph.CheckIfClickedOnVert(new Point(e.X, e.Y)) && graph.CountSelectedVertexes() == 2)
                    graph.AddRib();
            }
            else if (deleteVertexButon.Focused)
            {
                graph.DeleteVertex(new Point(e.X, e.Y));
                ClearEditorPictureBox();
                graph.DrawGraph();
            }
            else if (deleteEdgeButton.Focused &&
                     graph.CheckIfClickedOnVert(new Point(e.X, e.Y)) &&
                     graph.CountSelectedVertexes() == 2)
            {
                graph.DeleteRib();
                ClearEditorPictureBox();
                graph.UnselectAll();
                graph.DrawGraph();
            }
            else if (MoveVertexButton.Focused)
            {
                if (graph.CheckIfClickedOnVert(new Point(e.X, e.Y)))
                {
                    if (graph.CountSelectedVertexes() == 2)
                    {
                        ClearEditorPictureBox();
                        graph.UnselectAll();
                        graph.DrawGraph();
                    }
                }
                else
                {
                    graph.MoveVertex(new Point(e.X, e.Y));
                    ClearEditorPictureBox();
                    graph.DrawGraph();
                }
            }
        }

        private void colorGraphButton_Leave(object sender, EventArgs e)
        {
            ClearEditorPictureBox();
            graph.DrawGraph();
        }

        private void colorGraphButton_MouseClick(object sender, MouseEventArgs e)
        {
            graph.Coloring(ifSlowModeCheckBox.Checked);
        }
    }
}
