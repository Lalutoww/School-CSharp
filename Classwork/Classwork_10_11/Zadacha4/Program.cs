using System;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            int failedCount = 0;
            double sum = 0;

            for(int i = 1; i <= 12; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                if(grade < 4.00)
                {
                    failedCount++;
                    sum += grade;
                }
                else
                {
                    sum += grade;
                }
                if(failedCount > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {i-1} grade");
                }
            }
            if (failedCount <= 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {(sum/12).ToString("N2")}");
            }
        }
    }
}

