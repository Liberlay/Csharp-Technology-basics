using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 19. Реализовать функцию возведения в куб суммы двух целых чисел 
            int a, b, c;
            Console.WriteLine("Write two integer numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = Convert.ToInt32(Math.Pow(a + b, 3));

            Console.WriteLine("Сube of difference of two numbers: " + c);
        }
    }
}
