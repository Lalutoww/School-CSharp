using System;

namespace zadacha9
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            int sum = 0;

            while(sum < target)
            {
                int add = int.Parse(Console.ReadLine());

                sum += add;
            }

            Console.WriteLine("\n" + sum);
        }
    }
}

