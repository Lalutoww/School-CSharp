using System;

namespace zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кв.м Лозе: ");
            int loze = int.Parse(Console.ReadLine());
            Console.Write("Грозде за 1 кв. м: ");
            double grapes = double.Parse(Console.ReadLine());
            Console.Write("Нужни литри вино: ");
            int litersWine = int.Parse(Console.ReadLine());
            Console.Write("Брой работници: ");
            int workers = int.Parse(Console.ReadLine());

            double totalGrapes = loze * grapes;
            double totalWine = 0.40 * totalGrapes / 2.5;
            double needed = Math.Abs(totalWine - litersWine);
            if(totalWine < litersWine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needed)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(totalWine)} liters. ");
                Console.WriteLine($"{Math.Ceiling(needed)} liters left -> {Math.Ceiling(needed / workers)} liters per person.");
            }

        }
    }
}

