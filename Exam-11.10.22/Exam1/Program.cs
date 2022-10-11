using System;

namespace Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double puzzlePrice = 2.50;
            const double teddyBearPrice = 10;
            const double minionPrice = 8.30;
            const double truckPrice = 2;

            Console.Write("Puzzle Quantity: ");
            int puzzleQuantity = int.Parse(Console.ReadLine());
            Console.Write("TeddyBear Quantity: ");
            int teddyBearQuantity = int.Parse(Console.ReadLine());
            Console.Write("Minion Quantity: ");
            int minionQuantity = int.Parse(Console.ReadLine());
            Console.Write("Truck Quantity: ");
            int truckQuantity = int.Parse(Console.ReadLine());

            double sum = puzzlePrice * puzzleQuantity + teddyBearPrice * teddyBearQuantity + minionPrice * minionQuantity + truckPrice * truckQuantity;
            double sumDiscount = sum * 0.30;
            Console.WriteLine($"Profit: {sumDiscount:F2}");
        }
    }
}

