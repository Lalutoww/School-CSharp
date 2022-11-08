using System;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char i = 'a'; i<='z'; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n-------------------");

            Console.Write("Enter num: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 1;
            int negative = 0;
            int positive = 0;
            double averageSum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Num: ");
                int a = int.Parse(Console.ReadLine());
                if (a >= 0)
                {
                    sum = (a) + sum;
                    positive++;
                }
                else if(a<0)
                {
                    sum1 = (a) * sum1;
                    negative++;
                }
                averageSum += a;
            }
            if(negative == 0)
            {
                Console.WriteLine("No negative numbers entered");
            }
            else if(positive == 0)
            {
                Console.WriteLine("No positive numbers entered");
            }
            else
            {
                Console.WriteLine("\n-------------------");
                Console.Write("Sum: " + sum + " ");
                Console.WriteLine("\n-------------------");
                Console.Write("Product: " + sum1 + " ");
                Console.WriteLine("\n-------------------");
                Console.Write($"Average: { averageSum / n}");
            }
        }
    }
}

