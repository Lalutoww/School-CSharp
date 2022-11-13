using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberCount = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numberCount; i++)
            {
                int addNum = int.Parse(Console.ReadLine());
                if(i % 2 == 0)
                {
                    evenSum += addNum;
                }else if(i % 2 != 0)
                {
                    oddSum += addNum;
                }
            }
            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {oddSum}");
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}

