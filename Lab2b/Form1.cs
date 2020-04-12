using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2b
{
    public partial class Form1 : Form
    {

        Square[] squares;
        Pyramid[] pyramids;

        public Form1()
        {
            InitializeComponent();
            squares = new Square[0];
            pyramids = new Pyramid[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double sumSquare = 0;
            double minimalSquarePyramid = 0;
            Array.Resize(ref squares, Convert.ToInt32(textBoxCountSquares.Text));
            Array.Resize(ref pyramids, Convert.ToInt32(textBoxCountPyramids.Text));

            for (int i = 0; i < squares.Length; i++)
            {
                squares[i] = new Square(Math.Round(r.NextDouble() * 10, 2), "S" + (i + 1).ToString());
                richTextBoxInfo.Text += squares[i].ToString();
                sumSquare += squares[i].getSquare();
            }

            labelAvarageSquare.Text = Convert.ToString(Math.Round(sumSquare / squares.Length,2));


            for (int i = 0; i < pyramids.Length; i++)
            {
                pyramids[i] = new Pyramid(Math.Round(r.NextDouble() * 10, 2), "P" + (i + 1).ToString(), Math.Round(r.NextDouble() * 10, 2));
                richTextBoxInfo.Text += pyramids[i].ToString();
                if(minimalSquarePyramid > pyramids[i].getSquare() || minimalSquarePyramid == 0)
                {
                    minimalSquarePyramid = pyramids[i].getSquare();
                }
            }

            labelMinimalPyramidSquare.Text = Convert.ToString(Math.Round(minimalSquarePyramid,2));
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {}
        private void label4_Click(object sender, EventArgs e) {}
        private void richTextBoxInfo_TextChanged(object sender, EventArgs e) {}
        private void textBoxCountPyramids_TextChanged(object sender, EventArgs e) {}
        private void label1_Click(object sender, EventArgs e) {}
        private void Form1_Load(object sender, EventArgs e) {}
    }
}
