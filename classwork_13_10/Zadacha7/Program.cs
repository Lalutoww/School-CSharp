using System;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            int days = 0;
            switch (month)
            {
                case 1: days = 31; break;
                case 2: Console.WriteLine("28 или 29 дни"); break;
                case 3: days = 31; break;
                case 4: days = 30; break;
                case 5: days = 31; break;
                case 6: days = 30; break;
                case 7: days = 31; break;
                case 8: days = 31; break;
                case 9: days = 30; break;
                case 10: days = 31; break;
                case 11: days = 30; break;
                case 12: days = 31; break;
                default: Console.WriteLine("Некоректен вход!"); break;
            }
            if (month != 2 && month <= 12 && month >= 1)
            {
                Console.WriteLine($"{days} дни");
            }
        }
    }
}

