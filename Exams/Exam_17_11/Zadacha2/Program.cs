using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            double positiveSum = 0;
            double negativeSum = 0;
            double n;
            do
            {
                Console.Write("Enter num: ");
                n = int.Parse(Console.ReadLine());

                if(n > 0) positiveSum += n;
                else negativeSum += n;

            } while (n != 0);

            Console.WriteLine("Positive sum: " + positiveSum);
            Console.WriteLine("Negative sum: " + negativeSum);
        }
    }
}

