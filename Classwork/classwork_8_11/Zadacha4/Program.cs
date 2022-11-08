using System;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num:");
            int num = int.Parse(Console.ReadLine());

            while(!(num>=1 && num <= 100))
            {
                Console.WriteLine("Enter num:");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}

