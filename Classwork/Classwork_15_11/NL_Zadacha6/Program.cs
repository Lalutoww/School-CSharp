using System;

namespace NL_Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Етажи: ");
            int line = int.Parse(Console.ReadLine());
            Console.Write("Стаи: ");
            int row = int.Parse(Console.ReadLine());

            for (int i = line; i >= 1; i--)
            {
                Console.WriteLine();
                for (int j = 0; j < row; j++)
                {
                    if (i == line) Console.Write("L");
                    else if (i % 2 == 0 && i != line) Console.Write("O");
                    else Console.Write("A");
                    Console.Write(i * 10 + j + " ");
                }
            }
        }
    }
}

