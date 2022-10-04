using System;

namespace sumOfWholeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сумиране на трицифрено число");

            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            int num1 = num % 10;
            int num2 = (num / 10) % 10;
            int num3 = (num / 100) % 10;
            int sum = num1 + num2 + num3;
            Console.WriteLine($"Sum of numbers: {sum}");
        }
    }
}

