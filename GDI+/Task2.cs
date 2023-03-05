using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_
{
    public partial class Task2 : Form
    {
        public Task2()
        {
            InitializeComponent();
        }
        int level = 0;
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            level = 1;
            pictureBox1.Invalidate();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (level == 1)
            {

                Point point1 = new Point(50, 50);
                Point point2 = new Point(100, 100);
                Point point3 = new Point(0, 100);

                Point[] triangle = { point1, point2, point3 };

                g.DrawPolygon(Pens.Black, triangle);
            }
            else if (level == 2)
            {
                int x = 50;
                int y = 50;
                int width = 100;
                int height = 50;

                g.DrawRectangle(Pens.Black, x, y, width, height);

            }
            else if (level == 3)
            {
                int x = 50;
                int y = 50;
                int width = 100;
                int height = 100;

                g.DrawEllipse(Pens.Black, x, y, width, height);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            level = 2;
            pictureBox1.Invalidate();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            level = 3;
            pictureBox1.Invalidate();
        }
    }
}
