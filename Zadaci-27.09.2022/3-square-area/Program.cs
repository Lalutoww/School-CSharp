using System;

namespace _3_square_area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            int area = a * a;
            int Perimeter = a * 4;
            Console.WriteLine($"Area = {area}");
            Console.WriteLine($"perimeter = {Perimeter}");
        }
    }
}

