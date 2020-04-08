using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2a
{
    class Square
    {

        double side;
        string title;

        public Square(double side, string title)
        {
            this.side = side;
            this.title = title;
        }

        public double getDiagonal ()
        {
            return Math.Round(Math.Sqrt(2) * this.side, 2); 
        }

        public double getPerimeter()
        {
            return this.side * 4;
        }

        public double getSquare ()
        {
            return Math.Round(Math.Pow(this.side, 2), 2); 
        }

        public override String ToString()
        {
            return
                "\nSquare:    " + this.title + " (" + this.side + ")" +
                "\nDiagonal:  " + this.getDiagonal() +
                "\nPerimeter: " + this.getPerimeter() +
                "\nSquare:    " + this.getSquare();
        }

    }
}
