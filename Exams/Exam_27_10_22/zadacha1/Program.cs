using System;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Product: ");
            string product = Console.ReadLine();
            Console.Write("Town: ");
            string town = Console.ReadLine();
            Console.Write("Quantity: ");
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            switch (town)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.50;
                            break;
                        case "water":
                            price = 0.80;
                            break;
                        case "beer":
                            price = 1.20;
                            break;

                        case "sweets":
                            price = 1.45;
                            break;
                    }

                break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.40;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.15;
                            break;

                        case "sweets":
                            price = 1.30;
                            break;
                    }

                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            price = 0.45;
                            break;
                        case "water":
                            price = 0.70;
                            break;
                        case "beer":
                            price = 1.10;
                            break;

                        case "sweets":
                            price = 1.35;
                            break;
                    }

                    break;
            }
            double totalPrice = price * quantity;

            Console.WriteLine($"{totalPrice:F2}");

        }
    }
}

