using System;

namespace zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            while (true)
            {
                if(num % 2 == 0)
                {
                    break;
                }
                Console.Write("Num = ");
                num = int.Parse(Console.ReadLine());
            }
        }
    }
}

