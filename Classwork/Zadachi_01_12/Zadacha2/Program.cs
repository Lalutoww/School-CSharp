using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Num: ");
            int x = int.Parse(Console.ReadLine());
            Define(x);
            Define(-100);
        }

        static void Define(int number)
        {
            if (number > 0) Console.WriteLine("Positive");
            else if(number<0) Console.WriteLine("Negative");
            else Console.WriteLine("Zero");

            
        }
    }
}

