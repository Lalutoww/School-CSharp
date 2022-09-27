using System;

namespace _2_sum_of_numbers
{
    class Program
    {
        static void Main()
        {
            // деклариране на две целочислени променливи
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("a + b " + " = " + (a + b));

            // деклариране на променлива за сума
            int sum = a + b;
            Console.WriteLine(a + " + " + b + " = " + sum);

            Console.WriteLine("{0} + {1} = {2}", a, b, sum);

            Console.WriteLine($"{a} + {b} = {sum}");
        }
    }
}
