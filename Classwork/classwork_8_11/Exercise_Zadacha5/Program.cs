using System;

namespace Exercise_Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            string command;

            while (true)
            {
                Console.Write("Enter command: ");
                command = Console.ReadLine();
                if (command == "NoMoreMoney")
                {
                    break;
                }
                double num = double.Parse(command);
                if (num >= 0)
                {
                    Console.WriteLine("Increase: " + num);
                    sum += num;
                }
                else
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
            }
            Console.WriteLine("Total: " + sum);
        }
    }
}

