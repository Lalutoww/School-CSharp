using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter operator ( + OR *): ");

            char sign = char.Parse(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    Console.WriteLine(Arithmetics.Add(a, b));
                    break;
                case '*':
                    Console.WriteLine(Arithmetics.Multiply(a, b));
                    break;
                default: Console.WriteLine("Invalid sign");
                    break;
            }
            
        }
        
    }
}

