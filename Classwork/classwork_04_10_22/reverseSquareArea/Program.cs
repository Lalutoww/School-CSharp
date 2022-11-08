using System;

namespace reverseSquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Намиране на страна и лице на квадрат чрез периметъра му");
            Console.Write("P = ");
            double P = double.Parse(Console.ReadLine());
            double a = P / 4;
            double S = Math.Pow(a,2);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"S = {Math.Round(S, 2)}");

        }
    }
}