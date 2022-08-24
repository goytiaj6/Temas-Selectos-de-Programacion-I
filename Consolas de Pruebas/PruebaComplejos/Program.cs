using System;
using System.Numerics;

namespace PruebaComplejos
{
    class Program
    {
        static void Main(string[] _)
        {
            int c = 5;
            double SQRT = Math.Sqrt(Math.Pow(1, 2) - (4 * c));
            double raiz1 = (-1 + SQRT) / 2;
            double raiz2 = (-1 - SQRT) / 2;

            Console.WriteLine(raiz1);
            Console.WriteLine(raiz2);
            Console.Read();
        }
    }
}
