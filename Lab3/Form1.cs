using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        Fraction fr1, fr2, fr3;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Fraction result1 = new Fraction(), result2 = new Fraction();
            fr1 = new Fraction(Convert.ToDouble(textBoxX1.Text), Convert.ToDouble(textBoxY1.Text));
            fr2 = new Fraction(Convert.ToDouble(textBoxX2.Text), Convert.ToDouble(textBoxY2.Text));
            fr3 = new Fraction(Convert.ToDouble(textBoxX3.Text), Convert.ToDouble(textBoxY3.Text));

            result1 = (fr3 - fr1) * fr3;
            labelResult1.Text = result1.ToString();

            result2 = (fr1 + fr2) / fr1.fractionPow(3);
            labelResult2.Text = result2.ToString();

        }

        private void ButtonCompare_Click(object sender, EventArgs e)
        {

            labelFr1Fr2.Text = fr1 > fr2 ? "Fraction 1 > Fraction 2" : "Fraction 1 < Fraction 2";
            labelFr2Fr3.Text = fr2 > fr3 ? "Fraction 2 > Fraction 3" : "Fraction 2 < Fraction 3";
            labelFr1Fr3.Text = fr1 > fr3 ? "Fraction 1 > Fraction 3" : "Fraction 1 < Fraction 3";

        }
    }
}
