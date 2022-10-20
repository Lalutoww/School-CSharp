using System;

namespace zadacha2
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

            double d = (b * b) - (4 * a * c);

            if (d < 0)
            {
                Console.WriteLine("Н.Р.К");
            }
            else if (d == 0)
            {
                Console.WriteLine($"x = {-b / (2 * a)}");
            }
            else if(d > 0)
            {
                Console.WriteLine($"x1 = {(-b + Math.Sqrt(d))/(2*a)}");
                Console.WriteLine($"x2 = {(-b - Math.Sqrt(d)) / (2 * a)}");
            }
        }
    }
}

