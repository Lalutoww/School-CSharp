using System;

namespace zad1_percent_excellent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many classmates ? -> ");
            int classmates = int.Parse(Console.ReadLine());
            Console.Write("How many of them have exellent grade ? -> ");
            int excellentClassmates = int.Parse(Console.ReadLine());

            double percent = (double)(excellentClassmates )/ classmates * 100.00;
            Console.WriteLine($"Percent: {Math.Round(percent,2)}%");
        {

        }
        }
    }
}

