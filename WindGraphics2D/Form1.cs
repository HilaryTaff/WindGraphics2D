using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindGraphics2D
{
    public partial class Form1 : Form
    {
        int vertexNum = 3;
        float[,] vertices;
        int counter;
        bool polygon=false;
        Graphics graphics; 
        List<string> transformations = new List<string>();
        public Form1()
        {
            InitializeComponent();
            graphics=pictureBox1.CreateGraphics();
            dataGridView1.ColumnCount = 5;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width = 50;
            }
            dataGridView1.Columns[0].HeaderText = "X";
            dataGridView1.Columns[1].HeaderText= "Y";
            dataGridView1.Columns[2].HeaderText = "Z";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            vertexNum= (int)numericUpDown1.Value;
           

        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            int index = e.Index;
            switch (index)
            {
                case 0:if (e.NewValue.ToString().Equals("Checked")) transformations.Add("Translation");
                    else transformations.Remove("Translation");
                        break;
                case 1:
                    if (e.NewValue.ToString().Equals("Checked")) transformations.Add("Rotation about Origin");
                    else transformations.Remove("Rotation about Origin");
                    break;
                case 2:
                    if (e.NewValue.ToString().Equals("Checked")) transformations.Add("Rotation about Point");
                    else transformations.Remove("Rotation about Point");
                    break;
                case 3:
                    if(e.NewValue.ToString().Equals("Checked")) transformations.Add("Scaling");
                    else transformations.Remove("Scaling");
                    break;
                default:
                    break;
            }
            lblTransformations.Text = string.Empty;
            foreach (string item in transformations)
            {
                switch (item)
                {
                    case "Translation":
                        label4.ForeColor = Color.Red;
                        break;
                    case "Rotation about Point":
                        label6.ForeColor = Color.BlueViolet;
                        break;
                    case "Rotation about Origin":
                        label7.ForeColor = Color.Brown;
                        break;
                    case "Scaling":
                        label8.ForeColor = Color.Green;
                        break;
                    default:
                        break;
                }
                lblTransformations.Text += item + " ,";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.Black);
            if (polygon)
            {
                
                MouseEventArgs point = (MouseEventArgs)e;
                if (counter<vertices.GetLength(0))
                {
                    vertices[counter,0] = point.X;
                    vertices[counter, 1] = point.Y;
                    vertices[counter, 2] = 1;
                    if (counter>=1)
                    {
                        graphics.DrawLine(pen, vertices[counter - 1, 0], vertices[counter-1,1],
                            vertices[counter, 0], vertices[counter,1]);
                        

                    }
                    counter++;
                    if (counter==vertices.GetLength(0))
                    {
                        graphics.DrawLine(pen, vertices[counter-1, 0], vertices[counter-1, 1],
                            vertices[0, 0], vertices[0, 1]);
                        Transformation2D.displayMatrix(vertices,dataGridView1);
                    }
                }
            }
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = false;
            polygon = true;
            btnPolygon.Enabled = false;
            vertices = new float[vertexNum, 3];
            counter = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTransformation_Click(object sender, EventArgs e)
        {
            float[,] transformMatrix;
            foreach (string item in transformations)
            {
                switch (item)
                {
                    case "Translation":
                        float tx = Convert.ToSingle(txtboxTranslationX.Text);
                        float ty = Convert.ToSingle(txtboxTranslationY.Text);
                        transformMatrix = Transformation2D.RightTranslationMatrix(tx, ty);
                        vertices = Transformation2D.MatrixMultiplication(vertices, transformMatrix);
                        Transformation2D.displayMatrix(vertices, dataGridView1);
                        drawPolygon(new Pen(Color.Red));
                        break;
                    case "Rotation about Point":
                        double rotateangle = Convert.ToDouble(txtboxRotationAngle.Text)*Math.PI/180;
                        float rx = Convert.ToSingle(txtBoxRotationX.Text);
                        float ry = Convert.ToSingle(txtboxRotationY.Text);
                        transformMatrix = Transformation2D.RightRotationAboutPointMatrix(rx,ry,rotateangle);
                        vertices = Transformation2D.MatrixMultiplication(vertices, transformMatrix);
                        Transformation2D.displayMatrix(vertices, dataGridView1);
                        drawPolygon(new Pen(Color.BlueViolet));
                        break;
                    case "Rotation about Origin":
                        double angle = Convert.ToDouble(txtboxRotationOrigin.Text) * Math.PI / 180;
                        transformMatrix = Transformation2D.RightRotationMatrix(angle);
                        vertices = Transformation2D.MatrixMultiplication(vertices, transformMatrix);
                        Transformation2D.displayMatrix(vertices, dataGridView1);
                        drawPolygon(new Pen(Color.Brown));
                        break;
                    case "Scaling":
                        float sx = Convert.ToSingle(txtboxScalingX.Text);
                        float sy = Convert.ToSingle(txtboxScalingY.Text);
                        transformMatrix = Transformation2D.ScalingMatrix(sx,sy);
                        Transformation2D.displayMatrix(vertices, dataGridView1);
                        vertices = Transformation2D.MatrixMultiplication(vertices, transformMatrix);
                        drawPolygon(new Pen(Color.Green));break;
                    default:
                        break;
                }
            }
            
        }
        private void drawPolygon(Pen pen) {
            for (int i = 1; i < vertices.GetLength(0); i++)
            {
                graphics.DrawLine(pen, vertices[i - 1, 0], vertices[i - 1, 1], vertices[i, 0], vertices[i, 1]);
            }
            graphics.DrawLine(pen, vertices[0, 0], vertices[0, 1], vertices[vertices.GetLength(0)-1, 0], vertices[vertices.GetLength(0)-1, 1]);
        }
    }
}
