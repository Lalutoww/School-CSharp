using System;
namespace Zadacha1
{
	class Dog : Animal
	{
        public Dog(string name, int age) : base(name, age) {}

        public void Bark()
		{
			Console.WriteLine("barking...");

		}
    }
}

