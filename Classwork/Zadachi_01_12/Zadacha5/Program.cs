using System;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine($"Rectangle Area: {RectangleArea(width, height)}");
        }
        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}

