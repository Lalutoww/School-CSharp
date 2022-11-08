using System;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i<= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-------------------");

            for (int i = 1; i <= 10; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n-------------------");

            for (int i = 30; i >= 20; i--)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n-------------------");

            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());


            for (int i = m; i <= n; i++)
            {
                if (i % 5 == 0) Console.Write(i + ",");
            }

            Console.WriteLine("\n-------------------");

            for (int i = 1; i <= 100; i++)
            {
                if (i % 10 == 7) Console.Write(i + " ");
            }

            Console.WriteLine("\n-------------------");

            int sum = 0;
            Console.Write("Sum: ");
            for (int i = 1; i <= 10; i+=n)
            {
                sum += i;
                Console.Write(sum + " ");
            }

        }
    }
}

