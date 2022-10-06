using System;

namespace zad5_alchohol_market
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Whisky Price: ");
            double whiskyPrice = double.Parse(Console.ReadLine());
            Console.Write("Beer Liters: ");
            double beerLiters = double.Parse(Console.ReadLine());
            Console.Write("Wine Liters: ");
            double wineLiters = double.Parse(Console.ReadLine());
            Console.Write("Brandy Liters: ");
            double brandyLiters = double.Parse(Console.ReadLine());
            Console.Write("Whisky Liters: ");
            double whiskyLiters = double.Parse(Console.ReadLine());

            double brandyPrice = whiskyPrice / 2;
            double winePrice = brandyPrice - (0.4 * brandyPrice);
            double beerPrice = brandyPrice - (0.8 * brandyPrice);


            double totalSum = whiskyLiters * whiskyPrice + beerLiters * beerPrice + wineLiters * winePrice + brandyLiters * brandyPrice;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}

