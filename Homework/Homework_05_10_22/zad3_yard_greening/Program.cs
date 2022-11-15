using System;

namespace zad3_yard_greening
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many square meters need to be greened? -> ");
            double squareMeters = double.Parse(Console.ReadLine());
            const double pricePerMeter = 7.61;
            double priceNoDiscount = squareMeters * pricePerMeter;
            double discount = priceNoDiscount * 0.18;
            double totalPrice = priceNoDiscount - discount;
            Console.WriteLine($"The final price is: {Math.Round(totalPrice, 2)} lv.");
            Console.WriteLine($"The discount is: {Math.Round(discount, 2)} lv.");

        }
    }
}

