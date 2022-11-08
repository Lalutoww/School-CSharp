using System;

namespace Exercise_Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            double ton = 130;
            int year = 2010;
            while(ton >= 10)
            {
                ton *= 0.9;
                Console.WriteLine(year++);
            }
            Console.WriteLine(year);
        }
    }
}

