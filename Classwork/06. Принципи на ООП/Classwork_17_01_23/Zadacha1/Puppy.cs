using System;
namespace Zadacha1
{
	class Puppy : Dog
	{
        public Puppy(string name, int age) : base(name, age) {}

        public void Weep()
		{
			Console.WriteLine("weeping...");
		}
	}
}

