using System;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            if (a <= 0 || b <= 0) Console.WriteLine("Въвели сте неположително число!");
            else
            {
                Console.WriteLine($"P = {2 * (a+b)}");
                Console.WriteLine($"S = {a * b}");

            }
        }
    }
}

