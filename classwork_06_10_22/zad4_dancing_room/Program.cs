using System;

namespace zad4_dancing_room
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Length =");
            double L = double.Parse(Console.ReadLine());
            Console.Write("Width =");
            double W = double.Parse(Console.ReadLine());
            Console.Write("Wardrobe side =");
            double A = double.Parse(Console.ReadLine());

            double roomSize = (L * 100) * (W * 100);
            double wardrobe = (A * 100 * A * 100);
            double bench = roomSize / 10;
            double freeSpace = roomSize - wardrobe - bench;
            double dancers = freeSpace / (40 + 7000);
            Console.WriteLine(Math.Round(dancers));
        }
    }
}

