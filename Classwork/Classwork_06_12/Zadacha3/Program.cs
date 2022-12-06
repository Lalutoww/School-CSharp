using System;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square 1:");
            Square s1 = new Square(5);
            Console.WriteLine("Square 2:");
            Square s2 = new Square();
            s2.Side = 3;
            Console.WriteLine("Square 3:");
            Square s3 = new Square(s1);

            Console.WriteLine("-----------------");
            Console.WriteLine("\nSquare 1:"); // \n makes a new line - same as Console.WriteLine()e
            s1.PrintInfo();
            Console.WriteLine("\nSquare 2:");
            s2.PrintInfo();
            Console.WriteLine("\nSquare 3:");
            s3.PrintInfo();
        }
    }
}

