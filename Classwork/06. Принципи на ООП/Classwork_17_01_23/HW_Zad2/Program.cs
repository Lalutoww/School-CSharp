namespace HW_Zad2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Animal: ");
        Animal a1 = new Animal();
        a1.MakeSound();

        Console.WriteLine();

        Console.WriteLine("Dog: ");
        Dog d1 = new Dog();
        d1.MakeSound();

        Console.WriteLine();

        Console.WriteLine("Cat: ");
        Cat c1 = new Cat();
        c1.MakeSound();
    }
}

