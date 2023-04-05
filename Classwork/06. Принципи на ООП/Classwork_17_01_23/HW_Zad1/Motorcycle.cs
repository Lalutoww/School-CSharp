using System;
namespace HW_Zad1
{
	public class Motorcycle : Mps
	{
        protected const int TireCount = 2;
        protected const char Category = 'A';
        public Motorcycle(string registration) : base(Category, TireCount, registration)
        {
        }
    }
}

