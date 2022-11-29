using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = a; i <= b; i++)
            {
                if(i % x == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

