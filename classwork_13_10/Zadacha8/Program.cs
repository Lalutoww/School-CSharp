using System;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            if (a <= 0 && b <= 0 && c <= 0)
            {
                Console.WriteLine("Няма такъв триъгълник");
            }
            else if (a + b <= c || b+c <= a || a+c <= b)
            {
                Console.WriteLine("Няма такъв триъгълник");
            }
            else
            {
                Console.WriteLine($"Perimeter = {a + b + c}");
                double s = (a + b + c) / 2;
                Console.WriteLine($"Area = {Math.Sqrt(s * (s - a) * (s - b) * (s - c))}");
            }
        }
    }
}

