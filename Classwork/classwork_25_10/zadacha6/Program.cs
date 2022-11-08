using System;

namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 1;
            double averageSum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Num: ");
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    sum = (a) + sum;
                }
                else if (a % 2 != 0)
                {
                    sum1 = (a) + sum1;
                }
                averageSum += a;
            }
            if(sum == sum1)
            {
                Console.WriteLine("yes " + sum);
            }
            else
            {
                Console.WriteLine($"no, \n diff = {Math.Abs(sum-sum1)}");
            }
        }
    }
}

