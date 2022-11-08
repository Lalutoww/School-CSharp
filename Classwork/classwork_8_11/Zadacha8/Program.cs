using System;

namespace Zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 50; i++)
            {
                if(i%10 == 0)
                {
                    Console.WriteLine();
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

