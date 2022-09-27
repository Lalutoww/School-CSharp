using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello Profil!");
             string name = "Ivan"; 
             Console.WriteLine("Hello " + name); */

            // Променлива за име
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            
        }
    }
}

