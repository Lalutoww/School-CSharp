using System;

namespace zad4_tailoring_workshop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tables: ");
            int tables = int.Parse(Console.ReadLine());
            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            double areaTableCloth = tables * (length + 2 * 0.30) * (width + 2 * 0.30);
            double areaSquareCloth = tables * (length / 2) * (length / 2);

            double totalPriceInDollars = areaTableCloth * 7 + areaSquareCloth * 9;
            double totalPriceInBGN = totalPriceInDollars * 1.85;

            Console.WriteLine($"{totalPriceInDollars.ToString("0.00")} USD");
            Console.WriteLine($"{totalPriceInBGN.ToString("0.00")} BGN");
        }
    }
}

