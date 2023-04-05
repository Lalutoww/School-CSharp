using System;
namespace Zadacha1
{
	class Animal
	{
		protected string name;
		protected int age;

		public void Eat()
		{
			Console.WriteLine("eating...");
		}

		public void PrintNameAge()
		{
			Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

		public Animal(string name, int age)
		{
			this.name = name;
			this.age = age;
		}
	}
}

