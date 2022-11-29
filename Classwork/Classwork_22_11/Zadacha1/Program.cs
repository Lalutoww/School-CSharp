using System;

namespace Zadacha1
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
            int p4 = 0;
            int p5 = 0;
            double p1sum = 0;
            double p2sum = 0;
            double p3sum = 0;
            double p4sum = 0;
            double p5sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                if (numbers < 200) p1++;
                else if (numbers >= 200 && numbers < 400) p2++;
                else if (numbers >= 400 && numbers < 600) p3++;
                else if (numbers >= 600 && numbers < 800) p4++;
                else if (numbers >= 800) p5++;

            }
            p1sum += p1 / n * 100;
            p2sum += p2 / n * 100;
            p3sum += p3 / n * 100;
            p4sum += p4 / n * 100;
            p5sum += p5 / n * 100;
            Console.WriteLine($"{p1sum:F2}%");
            Console.WriteLine($"{p2sum:F2}%");
            Console.WriteLine($"{p3sum:F2}%");
            Console.WriteLine($"{p4sum:F2}%");
            Console.WriteLine($"{p5sum:F2}%");


        }
    }
}

