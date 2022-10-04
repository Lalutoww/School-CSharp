using System;

namespace swapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            // Програма за размяна стойностите на две числови променливи
            Console.WriteLine("Enter two numbers:");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            int c = a;

            a = b;
            b = c;

            Console.WriteLine("--------------------");
            Console.WriteLine($"a = {a}");
            Console.WriteLine("b = " + b); // concatenation

        }
    }
}

