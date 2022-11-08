using System;

namespace zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score = ");
            int num = int.Parse(Console.ReadLine());
            double points = 0;

            if(num <= 100) points = 5;
            else if(num > 100) points = num * 0.2;
            else if(num > 1000) points = num * 0.1;

            if (num % 2 == 0) points += 1;
            else if (num % 10 == 5) points += 2;

            Console.WriteLine($"Bonus score: {points}");
            Console.WriteLine($"Total score: {num + points}");
        }
    }
}

