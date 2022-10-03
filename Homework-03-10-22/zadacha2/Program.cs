using System;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                string row = "";
                for (int j = 1; j <= i; j++)
                {
                    row += "* ";
                }
                Console.WriteLine(row);
            }
        }
    }
}

