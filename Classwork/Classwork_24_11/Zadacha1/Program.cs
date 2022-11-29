using System;

namespace Zadacha1
{
    class Robot
    {
        public string name;
        public string color;
        public int weight;

        public void IntroduceSelf()
        {
            Console.WriteLine($"My name is {name}!");
        }

        public void AllInfo()
        {
            Console.WriteLine($"I am {color} and I weigh {weight} kg!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Robot r1 = new Robot();
            r1.name = "Tom";
            r1.color = "blue";
            r1.weight = 32;

            Robot r2 = new Robot();

            Console.WriteLine("Enter info for robot 2:");
            Console.Write("Name: ");
            r2.name = Console.ReadLine();
            Console.Write("Color: ");
            r2.color = Console.ReadLine();
            Console.Write("Weight: ");
            r2.weight = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Robot 1 Info: ");
            r1.IntroduceSelf();
            r1.AllInfo();

            Console.WriteLine();

            Console.WriteLine("Robot 2 Info: ");
            r2.IntroduceSelf();
            r2.AllInfo();

        }
    }
}

