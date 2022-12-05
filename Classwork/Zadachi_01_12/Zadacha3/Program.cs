using System;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Start: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter End: ");
            int end = int.Parse(Console.ReadLine());
            PrintInterval(start, end);
        }
        static void PrintInterval(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}