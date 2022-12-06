using System;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dog 1");
            Dog dog1 = new Dog();
            Console.WriteLine($"Name: {dog1.Name}");

            Console.WriteLine("Dog 2");
            Dog dog2 = new Dog("Samuel");
            Console.WriteLine($"Name: {dog2.Name}");

            Console.WriteLine("Dog 3");
            Dog dog3 = new Dog(Console.ReadLine());
            Console.WriteLine($"Name: {dog3.Name}");

            Console.WriteLine("Dog 4");
            Dog dog4 = new Dog(Console.ReadLine(), int.Parse(Console.ReadLine()));
            Console.WriteLine($"Name: {dog4.Name}, Age: {dog4.Age}");
            Console.WriteLine("Dog 4");
            Dog dog5 = new Dog(dog2);
            Console.WriteLine(dog5.Name);
            Console.WriteLine(dog5.Age);

            Console.WriteLine("----------");
            dog1.SayHello();
            dog2.SayHello();
            dog3.SayHello();
            dog4.SayHello();
        }
    }

    class Dog
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Dog()
        {
            this.name = "Unnamed";
        }
        public Dog(string n)
        {
            this.name = n;
        }
        public Dog(string n, int a)
        {
            this.name = n;
            this.age = a;
        }
        public Dog(Dog d)
        {
            this.name = d.name;
            this.age = d.age;
        }
        public void SayHello()
        {
            Console.WriteLine($"Hello, {this.name}!");
        }
    }
}

