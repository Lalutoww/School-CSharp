using System;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;

            do
            {
                Console.Write("Enter word");
                command = Console.ReadLine();
            } while (command != "Stop");
        }
    }
}

