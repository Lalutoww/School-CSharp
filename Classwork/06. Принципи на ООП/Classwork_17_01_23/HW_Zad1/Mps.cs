using System;
namespace HW_Zad1
{
	public class Mps
	{
        protected char category;
        protected int tireCount;
        protected string registration;

        public Mps(char category, int tireCount, string registration)
        {
            this.category = category;
            this.tireCount = tireCount;
            this.registration = registration;
        }

        public void Print()
        {
            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Wheels: {tireCount}");
            Console.WriteLine($"Registration Number: {registration}");
        }
    }
}

