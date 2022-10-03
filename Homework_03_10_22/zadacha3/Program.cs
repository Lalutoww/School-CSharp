using System;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Периметър и лице на правоъгълник - калкулатор");
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            double perimeter = a * 2 + b * 2;
            double area = a * b;

            Console.WriteLine($"Perimeter = {perimeter}");
            Console.WriteLine($"Area = {area}");
        }
    }
}

