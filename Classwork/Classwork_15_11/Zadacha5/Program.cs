using System;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol;
            bool hasDigit = false;
            int counter = 1;
            do
            {
                Console.Write("Enter symbol: ");
                symbol = char.Parse(Console.ReadLine());

                if (char.IsDigit(symbol)) hasDigit = true;
                counter++;
            } while (symbol != '.' && counter <= 10);
            if (hasDigit) Console.WriteLine("Има цифра");
            else Console.WriteLine("Няма цифра");
        }
    }
}

