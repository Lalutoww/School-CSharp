using System;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете: x = ");
            double x = double.Parse(Console.ReadLine());
            double y = (29 - x) / (Math.Pow(x, 2) + 4);
            double z = x + Math.Sqrt(6 * y);
            Console.WriteLine($"Y = {Math.Round(y,2)}");
            Console.WriteLine($"Z = {Math.Round(z, 2)}");

        }
    }
}

