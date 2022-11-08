using System;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                sum += i;
               // Console.Write(sum + " ");
            }

            Console.WriteLine("Sum: " + sum);

            Console.WriteLine("\n-------------------");

            int sum1 = 1;
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 1; i <= m; i ++)
            {
                sum1 *= i;
               // Console.Write(sum1 + " ");
            }
            Console.WriteLine("Product: " + sum1);


        }
    }
}

