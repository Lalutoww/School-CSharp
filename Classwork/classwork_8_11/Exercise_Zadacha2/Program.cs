using System;

namespace Exercise_Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter pass: ");
            string pass = Console.ReadLine();
            string tryPass;
            do
            {
                Console.Write("Enter password");
                tryPass = Console.ReadLine();
            } while (tryPass != pass);
            Console.WriteLine($"Welcome, {name}");

        }
    }
}

