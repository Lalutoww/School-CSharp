using System;

namespace NL_Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
            }
            Console.WriteLine("\n \n-----------------");

            for (int i = a; i >= 1; i--)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
            }
        }
    }
}

