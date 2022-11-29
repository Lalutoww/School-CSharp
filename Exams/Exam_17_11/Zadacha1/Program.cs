using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int multiply = 1;
            Console.Write("Enter num: ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if(i % 2 == 0)
                {
                    multiply *= i;
                }
            }
            Console.WriteLine("Total: " + multiply);

        }
    }
}

