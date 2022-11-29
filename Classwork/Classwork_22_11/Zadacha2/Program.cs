using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Num: ");
            double n = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            double p1sum = 0;
            double p2sum = 0;
            double p3sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers % 2 == 0) p1++;
                if (numbers % 3 == 0) p2++;
                if (numbers % 4 == 0) p3++;

            }
            p1sum += p1 / n * 100;
            p2sum += p2 / n * 100;
            p3sum += p3 / n * 100;
            Console.WriteLine($"{p1sum:F2}%");
            Console.WriteLine($"{p2sum:F2}%");
            Console.WriteLine($"{p3sum:F2}%");
        }
    }
}

