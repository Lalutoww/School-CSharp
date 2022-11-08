using System;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter input: ");
            string input = Console.ReadLine().ToLower();
            if(input == "banana" || input == "apple" || input == "kiwi" || input == "cherry" || input == "lemon" || input == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if(input == "tomato" || input == "cucumber" || input == "pepper" || input == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}

