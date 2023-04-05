using System;
namespace HW_Zad2
{
    class Animal
	{
        protected string Name { get; set; }
        protected int Age { get; set; }

        public virtual void MakeSound()
        {
            Console.WriteLine("I don't make any sounds");
        }
    }
}

