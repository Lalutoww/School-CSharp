using System;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a = ");

            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            double x = 0;

            if(a == 0 && b == 0)
            {
                Console.WriteLine("Всяко X е решение");
            }
            else if(a != 0)
            {
                x = -b / a;
                Console.WriteLine($"x = {Math.Abs(x)}");
            }
            else
            {
                Console.WriteLine("Няма решение");
            }
        }
    }
}

