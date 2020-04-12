using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{
    class Pyramid : Square
    {

        double apothem;

        public Pyramid()
        {
        }

        public Pyramid(double side, string title, double apothem)
        {
            base.Side = side;
            base.Title = title;
            this.apothem = apothem;
        }

        double getVolume()
        {
            double height = Math.Sqrt(Math.Abs(Math.Pow(this.apothem, 2) - Math.Pow(base.Side, 2)));
            return Math.Round(height * Math.Pow(base.Side, 2) / 3, 2);
        }

        new public double getSquare ()
        {
            return Math.Round(base.getSquare() + 4 * 1 / 2 * apothem * (base.Side / 2), 2); 
        }

        public override String ToString()
        {
            return
                "\nPyramid:    " + base.Title + " (" + base.Side + ")" +
                "\nSquare:    " + this.getSquare() +
                "\nVolume: " + this.getVolume() + "\n";

        }

    }
}
