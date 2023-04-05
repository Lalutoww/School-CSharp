using System;
namespace HW_Zad1
{
	public class Car : Mps
	{
        protected const int TireCount = 4;
        protected const char Category = 'B';
        public Car(string registration) : base(Category, TireCount, registration)
        {
        }

    }
}

