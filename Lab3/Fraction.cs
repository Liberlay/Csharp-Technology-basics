using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Fraction
    {
        double numerator;
        double denominator;

        public Fraction () {}

        public Fraction (double numerator, double denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction fractionPow (int degree)
        {
            return new Fraction(Math.Pow(this.numerator / this.denominator, degree), 1);
        }

        public static Fraction operator +(Fraction slogan1, Fraction slogan2)
        {
            return new Fraction((slogan1.numerator / slogan1.denominator) + (slogan2.numerator / slogan2.denominator), 1);
        }

        public static Fraction operator -(Fraction tempted, Fraction deduction)
        {
            return new Fraction((tempted.numerator / tempted.denominator) - (deduction.numerator / deduction.denominator), 1); 
        }

        public static Fraction operator *(Fraction factor1, Fraction factor2)
        {
            return new Fraction((factor1.numerator / factor1.denominator) * (factor2.numerator / factor2.denominator), 1); 
        }

        public static Fraction operator /(Fraction dividend, Fraction divider)
        {
            return new Fraction((dividend.numerator / dividend.denominator) / (divider.numerator / divider.denominator), 1); 
        }

        public static bool operator <(Fraction operand1, Fraction operand2)
        {
            return (operand1.numerator / operand1.denominator) < (operand2.numerator / operand2.denominator) ? true : false;
        }

        public static bool operator >(Fraction operand1, Fraction operand2)
        {
            return (operand1.numerator / operand1.denominator) > (operand2.numerator / operand2.denominator) ? true : false;
        }


        public override string ToString()
        {
            return denominator == 1 ? $"{Math.Round(numerator, 2)}" : $"{Math.Round(numerator,2)} / {Math.Round(denominator, 2)}" ;
        }

    }
}
