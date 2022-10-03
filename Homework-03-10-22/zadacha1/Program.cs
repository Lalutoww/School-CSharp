using System;

namespace zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            // A)  Числата от 1 до 10
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Б) Буквите от а до f
            char character;

            for (character = 'a'; character <= 'f'; character++)
            {
                Console.Write(character + " ");
            }
        }
    }
}

