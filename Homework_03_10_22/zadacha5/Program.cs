using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dog count: ");
            int dogCount = int.Parse(Console.ReadLine());
            Console.Write("Other animals count: ");
            int otherAnimalsCount = int.Parse(Console.ReadLine());

            double dogFoodPrice = dogCount * 2.50;
            double otherAnimalFoodPrice = otherAnimalsCount * 4.00;

            double sum = dogFoodPrice + otherAnimalFoodPrice;

            Console.WriteLine($"{sum.ToString("0.00")} lv.");
        }
    }
}

