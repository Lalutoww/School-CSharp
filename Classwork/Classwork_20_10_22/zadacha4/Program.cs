using System;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            bool isHigh = false;

            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                isHigh = true;
            }

            if (isHigh) Console.WriteLine("Високосна");
            else Console.WriteLine("Не е високосна");
        }
    }
}

