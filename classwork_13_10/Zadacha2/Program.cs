using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double min = double.Parse(Console.ReadLine());

            if (a < min) min = a;
            Console.Write("c = ");
            a = double.Parse(Console.ReadLine());
            if (a < min) min = a;
            Console.WriteLine($"Min = {min}");

        }
    }
}