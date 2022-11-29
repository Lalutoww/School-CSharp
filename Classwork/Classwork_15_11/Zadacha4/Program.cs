using System;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int evenCount = 0;
            int oddSum = 0;
            do
            {
                Console.Write("Enter num: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0 && num >= 0)
                {
                    evenCount++;
                } else if (num % 2 == 1 && num >= 0 && num != 13)
                {
                    oddSum += num;
                }
            } while (num != 13);
            Console.WriteLine("Even numbers: " + evenCount);
            Console.WriteLine("Sum of odd numbers: " + oddSum);
        }
    }
}

