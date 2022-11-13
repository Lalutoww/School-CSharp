using System;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int num1 = num;
            int min = num1;
            int max = num1;

            while (sum < num1)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                if (num < min) min = num;
                if (num > max) max = num;
            }
            Console.WriteLine("Max: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Sum: " + sum);
        }
    }
}

