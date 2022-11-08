using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(a, b));
        }
    }
}

