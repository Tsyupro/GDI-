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
    public partial class Task1 : Form
    {
        private int squareSize = 50;
        private string[,] pieces = new string[8, 8]
        {
            {"R", "N", "B", "Q", "K", "B", "N", "R"},
            {"P", "P", "P", "P", "P", "P", "P", "P"},
            {"", "", "", "", "", "", "", ""},
            {"", "", "", "", "", "", "", ""},
            {"", "", "", "", "", "", "", ""},
            {"", "", "", "", "", "", "", ""},
            {"p", "p", "p", "p", "p", "p", "p", "p"},
            {"r", "n", "b", "q", "k", "b", "n", "r"}
        };
        public Task1()
        {
            InitializeComponent();
        }

        private void Task1_Paint(object sender, PaintEventArgs e)
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Brush brush = (row + col) % 2 == 0 ? Brushes.White : Brushes.Gray;
                    e.Graphics.FillRectangle(brush, col * squareSize, row * squareSize, squareSize, squareSize);
                    string piece = pieces[row, col];
                    if (!string.IsNullOrEmpty(piece))
                    {
                        Font font = new Font(FontFamily.GenericSansSerif, squareSize / 2);
                        SizeF size = e.Graphics.MeasureString(piece, font);
                        PointF point = new PointF(col * squareSize + (squareSize - size.Width) / 2, row * squareSize + (squareSize - size.Height) / 2);
                        e.Graphics.DrawString(piece, font, Brushes.Black, point);
                    }
                }
            }
        }

        private void Task1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(squareSize * 8, squareSize * 8);
        }
    }
}
