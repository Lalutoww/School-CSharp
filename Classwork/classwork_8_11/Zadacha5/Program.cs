using System;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Num = ");
                num = int.Parse(Console.ReadLine());
            } while (num % 2 != 0);
        }
    }
}

