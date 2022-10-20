using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("price = ");
            int price = int.Parse(Console.ReadLine());

            if (a > 0 && b > 0 && price > 0)
            {
                Console.WriteLine($"{(a * b) * price} лева");
            }
            else Console.WriteLine("Некоректен вход!");
        }
    }
}

