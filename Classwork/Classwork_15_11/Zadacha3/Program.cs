using System;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("How many numbers: ");
            int num = int.Parse(Console.ReadLine());

            int sum = 0;
            int multiply = 1;
            int min = 0;
            int max = 0;

            for(int i = 1; i <= num; i++)
            {
                Console.Write("Enter num: ");
                int inputNum = int.Parse(Console.ReadLine());

                if(i % 2 == 0)
                {
                    sum += inputNum;
                }
                else if(i % 2 != 0)
                {
                    multiply *= inputNum;
                }
                if (inputNum < min) min = inputNum;
                if (inputNum > max) max = inputNum;
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Multiply: " + multiply);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);
        }
    }
}

