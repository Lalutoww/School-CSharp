namespace HW_Zad1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Motorcycle:");
        Motorcycle motor1 = new Motorcycle("A 2569 KX");
        motor1.Print();

        Console.WriteLine("");

        Console.WriteLine("Car: ");
        Car car1 = new Car("PB 7114 BH");
        car1.Print();
    }
}

