using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person 1: ");
            Person p1 = new Person();
            p1.InputPerson();
            Console.WriteLine("Person 2: ");
            Person p2 = new Person();
            p2.InputPerson();
            Console.WriteLine("Person 3: ");
            Person p3 = new Person();
            p3.InputPerson();

            Console.WriteLine("Greet all people: ");
            p1.GreetPerson();
            p2.GreetPerson();
            p3.GreetPerson();

            double avgAge = (p1.Age + p2.Age + p3.Age) / 3;
            Console.WriteLine($"Average age: {avgAge:F1}");
        }
    }

    class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { if (value > 0) this.age = value; }
        }
        public string FullName
        {
            get { return this.firstName + " " + this.lastName; }
        }
        public void GreetPerson()
        {
            Console.WriteLine($"Hello, {FullName}!");
        }
        public void InputPerson()
        {
            Console.WriteLine("---------------------");
            Console.Write("First Name: ");
            this.FirstName = Console.ReadLine();
            Console.Write("Last Name: ");
            this.LastName = Console.ReadLine();
            Console.Write("Age: ");
            this.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
        }

    }
}

