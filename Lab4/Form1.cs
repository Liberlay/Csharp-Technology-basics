using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

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

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream fs = openFileDialog1.OpenFile();

                //FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs, Encoding.UTF8);
                string str = File.ReadAllText(openFileDialog1.FileName);
                br.Close();
                fs.Close();

                int indexCountSquares = str.IndexOf("Count of squares: ") + 18;
                int indexCountPyramids = str.IndexOf("\nCount of pyramids: ");
                int indexResult = str.IndexOf("\n\nResult:");
                string countSquares = str.Substring(indexCountSquares, indexCountPyramids - indexCountSquares);
                string countPyramids = str.Substring(indexCountPyramids + 20, indexResult - (indexCountPyramids + 20));

                textBoxCountSquares.Text = countSquares;
                textBoxCountPyramids.Text = countPyramids;

                int indexAverageSquares = str.IndexOf("Average square of squares: ");
                int indexMinimalSquare = str.IndexOf("\nMinimal pyramid square: ");
                string averageSquares = str.Substring(indexAverageSquares + 27, indexMinimalSquare - (indexAverageSquares + 27));
                string pyramidMinimalSquare = str.Substring(indexMinimalSquare + 25, str.Length - (indexMinimalSquare + 25));

                labelAvarageSquare.Text = averageSquares;
                labelMinimalPyramidSquare.Text = pyramidMinimalSquare;

                string Result = str.Substring(indexResult + 9, indexAverageSquares - (indexResult + 9));

                richTextBoxInfo.Text = Result;

                //int countSquares = br.ReadInt32();
                /*byte[] array = new byte[fs.Length];
                fs.Read(array, 0, array.Length);
                richTextBoxInfo.Text = System.Text.Encoding.Default.GetString(array); */

            }

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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Stream fs;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((fs = saveFileDialog1.OpenFile()) != null)
                {
                    BinaryWriter bw = new BinaryWriter(fs, Encoding.UTF8);

                    bw.Write(Encoding.Default.GetBytes("Count of squares: " + textBoxCountSquares.Text));
                    bw.Write(Encoding.Default.GetBytes("\nCount of pyramids: " + textBoxCountPyramids.Text));

                    bw.Write(Encoding.Default.GetBytes("\n\nResult: "));
                    bw.Write(Encoding.Default.GetBytes(richTextBoxInfo.Text));

                    bw.Write(Encoding.Default.GetBytes("\nAverage square of squares: " + labelAvarageSquare.Text));
                    bw.Write(Encoding.Default.GetBytes("\nMinimal pyramid square: " + labelMinimalPyramidSquare.Text));

                    bw.Close();
                    fs.Close();
                }
            }

        }
    }
}
