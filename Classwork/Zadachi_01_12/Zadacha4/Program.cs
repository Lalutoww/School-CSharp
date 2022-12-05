using System;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle(3);
            Triangle(4);
        }
        static void Triangle(int num)
        {
            for(int row = 1; row <= num; row++)
            {
                Console.WriteLine();
                for (int col = 1; col <= row; col++)
                {  
                    Console.Write(col + " ");
                }
            }
            for (int row = num-1; row >= 1; row--)
            {
                Console.WriteLine();
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
            }
        }
    }
}

