using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int width = pictureBox1.Width;
            int height = pictureBox1.Height;
            float xMin = -5.0f;
            float xMax = 5.0f;
            float yMin = -2.0f;
            float yMax = 27.0f;
            float scaleX = width / (xMax - xMin);
            float scaleY = height / (yMax - yMin);
            if (radioButton1.Checked)
            {

                xMin = -5.0f;
                xMax = 5.0f;
                yMin = -2.0f;
                yMax = 27.0f;
                scaleX = width / (xMax - xMin);
                scaleY = height / (yMax - yMin);

           
                g.DrawLine(Pens.Black, 0, scaleY * (yMax - 0), width, scaleY * (yMax - 0));
                g.DrawLine(Pens.Black, scaleX * (-xMin), 0, scaleX * (-xMin), height);

          
                Pen pen = new Pen(Color.Blue, 2);
                PointF[] points = new PointF[width];
                for (int i = 0; i < width; i++)
                {
                    float x = xMin + (float)i / scaleX;
                    float y = x * x;
                    points[i] = new PointF(i, height - (y - yMin) * scaleY);
                }
                g.DrawLines(pen, points);
            }
            if (radioButton2.Checked)
            {
                xMin = (float)-Math.PI;
                xMax = (float)Math.PI;
                yMin = -1.2f;
                yMax = 1.2f;
                scaleX = width / (xMax - xMin);
                scaleY = height / (yMax - yMin);

             
                g.DrawLine(Pens.Black, 0, scaleY * (yMax - 0), width, scaleY * (yMax - 0));
                g.DrawLine(Pens.Black, scaleX * (-xMin), 0, scaleX * (-xMin), height);

            
                Pen pen = new Pen(Color.Blue, 2);
                PointF[] points = new PointF[width];
                for (int i = 0; i < width; i++)
                {
                    float x = xMin + (float)i / scaleX;
                    float y = (float)Math.Sin(x);
                    points[i] = new PointF(i, height - (y - yMin) * scaleY);
                }
                g.DrawLines(pen, points);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Invalidate();
        }
    }
}
