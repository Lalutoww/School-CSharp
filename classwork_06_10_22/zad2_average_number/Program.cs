using System;

namespace zad2_average_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a =");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int num2 = int.Parse(Console.ReadLine());

            double average = (num1 + num2) / 2.0;
            Console.WriteLine(average);
        }
    }
}

