using System;

namespace NL_Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int j = 1; j < b; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("* ");
            }
        }
    }
}

