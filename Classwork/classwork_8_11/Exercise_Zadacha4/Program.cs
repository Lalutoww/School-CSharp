using System;

namespace Exercise_Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Num = ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            do
            {
                sum += int.Parse(Console.ReadLine());

            } while (!(sum >= num));

        }
    }
}

