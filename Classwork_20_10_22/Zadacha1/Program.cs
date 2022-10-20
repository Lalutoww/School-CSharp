using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Euro / Leva : ");
            string answer = Console.ReadLine();
            const double euro = 1.958;

            if (answer.ToLower() == "leva")
            {
                Console.Write("Въведете сума в BGN: ");
                double leva = double.Parse(Console.ReadLine());
                double levaToEuro = leva / euro;
                Console.WriteLine($"{levaToEuro:F2}");
            }
            else if(answer.ToLower() == "euro")
            {
                Console.Write("Въведете сума в EUR: ");
                double euroInput = double.Parse(Console.ReadLine());
                double euroToLeva = euroInput * euro;
                Console.WriteLine(Math.Ceiling(euroToLeva));
            }
        }
    }
}

