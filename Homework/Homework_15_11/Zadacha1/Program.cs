using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num: ");
            int num = int.Parse(Console.ReadLine());
            bool isBigger = false;
            int sum = 1;


            for(int i = 1; i <= num; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());

                if (inputNum > 10)
                {
                    isBigger = true;
                }
                if(i % 2 == 0)
                {
                    sum *= inputNum;
                }
            }

            if (isBigger) Console.WriteLine("Yes");
            else Console.WriteLine("No");

            Console.WriteLine(sum);
        }
    }
}

