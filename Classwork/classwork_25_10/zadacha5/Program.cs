using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool hasFive = false;

            for (int i = 1; i <= n; i++)
            {
                if(i == 5)
                {
                    hasFive = true;
                    break;
                }
                else
                {
                    hasFive = false;
                }
            }

            if (hasFive)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}

