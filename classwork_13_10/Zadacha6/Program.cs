using System;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter word:");
            string word1 = Console.ReadLine();
            Console.Write("Enter second word:");
            string word2 = Console.ReadLine();

            if(word1.ToLower() == word2.ToLower())
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}

