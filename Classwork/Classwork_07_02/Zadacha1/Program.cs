namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        Person b1 = new Bulgarian("Bulgaria", "Ivan");
        b1.SayHello();
        b1.Info();
        Person e1 = new English("England", "John");
        e1.SayHello();
        e1.Info();
        Person g1 = new German("Germany", "Adolf");
        g1.SayHello();
        g1.Info();
    }

    abstract class Person
    {   
        protected string nationality;
        protected string name;

        public abstract void SayHello();
        public void Info()
        {
            Console.WriteLine($"My name is {name} and I'm from {nationality}");
        }

        public Person(string nationality, string name)
        {
            this.nationality = nationality;
            this.name = name;
        }
    }

    class English : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("Hello");
        }

        public English(string nationality, string name) : base(nationality, name)
        {
        }
    }
    class German : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("Hallo");
        }

        public German(string nationality, string name) : base(nationality, name)
        {
        }
    }
    class Bulgarian : Person
    {
        public override void SayHello()
        {
            Console.WriteLine("Zdravei");
        }

        public Bulgarian(string nationality, string name) : base(nationality, name)
        {
        }
    }
}

