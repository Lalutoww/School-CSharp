using System;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers to be entered - N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Which num to search for - K: ");
            int k = int.Parse(Console.ReadLine());
            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter num: ");
                int inputNum = int.Parse(Console.ReadLine());

                if (inputNum == k) isFound = true;
            }
            if (isFound) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }
    }
}

