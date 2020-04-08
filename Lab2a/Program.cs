using System;

namespace Lab2a
{

    

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter amount of squares:");
            int k = Convert.ToInt32(Console.ReadLine());
            Square[] squares = new Square[k];
            Random r = new Random();
            double sumSquare = 0;

            for(int i = 0; i <k; i++)
            {
                squares[i] = new Square(Math.Round(r.NextDouble() * 10, 2), "S" + (i + 1).ToString());
                Console.WriteLine(squares[i].ToString());
                sumSquare += squares[i].getSquare();

            }

            Console.WriteLine("\nAverage square of " + k + " square is: " + sumSquare / k);

        }
    }





}
