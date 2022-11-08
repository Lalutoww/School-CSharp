using System;

namespace circleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Програма за лице и дължина на окръжност");
            Console.Write("r = ");
            double r = double.Parse(Console.ReadLine());
            double C = 2 * Math.PI * r;
            double S = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"C = {C.ToString("0.00")}");
            Console.WriteLine($"S = {S.ToString("0.00")}");


        }
    }
}

