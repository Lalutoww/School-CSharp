using System;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumRight = 0;
            int sumLeft = 0;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sumRight += a;
            }
            for (int i = 1; i <= n; i++)
            {
                int a= int.Parse(Console.ReadLine());
                sumLeft += a;
            }

            if(sumRight == sumLeft)
            {
                Console.WriteLine($"Yes, \n sum = {sumRight}");
            }
            else
            {
                Console.WriteLine($"No, \n diff = {Math.Abs(sumRight - sumLeft)}");
            }
        }
    }
}

