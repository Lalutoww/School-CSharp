namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("Horse", 6);
        Dog dog = new Dog("Stanimir", 8);
        Puppy puppy = new Puppy("Lisa", 1);

        Console.WriteLine("Animal:");
        animal.Eat();
        animal.PrintNameAge();

        Console.WriteLine();

        Console.WriteLine("Dog: ");
        dog.Eat();
        dog.Bark();
        dog.PrintNameAge();

        Console.WriteLine();

        Console.WriteLine("Puppy: ");
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();
        puppy.PrintNameAge();

        Console.WriteLine();

        Animal a1 = new Dog("A1-dog", 10);
        a1.Eat();
        a1.PrintNameAge();
    }
}

