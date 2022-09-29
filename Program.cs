using System;

namespace arithmeticExperiments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5/3);
            Console.WriteLine(1/2);
            Console.WriteLine("5 % 3 = " + (5 % 3));
            Console.WriteLine("10 % 3 = " + (10 % 3));
            Console.WriteLine("10 / 3 = " + (10 / 3));
            Console.WriteLine("0 / 5 = " + (0 / 5));
            Console.WriteLine("0 % 5 = " + (0 % 5));
            // int x = 5.0 + 3; // - gives error because x is integer
            Console.WriteLine(5.0 + 3);
            double y = 5 + 3;
            Console.WriteLine(10.5 % 3);
            Console.WriteLine(6/2*3); //  = 9 -> priority is left to right
            Console.WriteLine(6 / (2 * 3)); // = 1 -> brackets are with highest priority

        }
    }
}

