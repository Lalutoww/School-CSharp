using System;

namespace desk_Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Enter num: ");
                num = int.Parse(Console.ReadLine());
            } while ((num < 1 && num > 27));

            int digitSum;

            for(int i = 100; i <= 999; i++)
            {
                int numOne = i % 10;
                int numTwo = i / 10 % 10;
                int numThree = i / 100 % 10;
                digitSum = numOne + numTwo + numThree;

                if(digitSum == num)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }

            }
        }
    }
}

