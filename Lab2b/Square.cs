using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2b
{
    class Square
    {

        double side;
        string title;

        public Square()
        {
        }

        public Square(double side, string title)
        {
            this.side = side;
            this.title = title;
        }

        public double getDiagonal()
        {
            return Math.Round(Math.Sqrt(2) * this.side, 2);
        }

        public double getPerimeter()
        {
            return this.side * 4;
        }

        public double getSquare()
        {
            return Math.Round(Math.Pow(this.side, 2), 2);
        }

        public override String ToString()
        {
            return
                "\nSquare:    " + this.title + " (" + this.side + ")" +
                "\nDiagonal:  " + this.getDiagonal() +
                "\nPerimeter: " + this.getPerimeter() +
                "\nSquare:    " + this.getSquare() + "\n";
        }
        public double Side { get => side; set => side = value >= 0 ? value : 0; }
        public string Title { get => title; set => title = value; }
    }
}
