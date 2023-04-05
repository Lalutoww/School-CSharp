namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Car");
        Car v1 = new Car(20, 300, 10);
        v1.Drive();
        Console.WriteLine("Truck");
        Truck t1 = new Truck(30, 400, 10);
        t1.Drive(); Car v2 = new Car(20, 100, 10);
        v2.Drive();
    }
}
abstract class Vehicle
{
    protected double fuelQuantity;
    protected double fuelConsumption;
    protected double distance;
    public Vehicle(double distance, double fuelQuantity, double fuelConsumption)
    {
        this.distance = distance;
        this.fuelQuantity = fuelQuantity;
        this.fuelConsumption = fuelConsumption;
    }
    abstract public void Drive();
}
class Car : Vehicle
{
    public Car(double distance, double fuelQuantity, double fuelConsumption) : base(distance, fuelQuantity, fuelConsumption)
    {
    }
    public override void Drive()
    {
        double totalConsumption = distance * (fuelConsumption + 0.9);
        bool isEnough = fuelQuantity >= totalConsumption;
        Console.WriteLine($"totalConsumption: {totalConsumption}");
        Console.WriteLine($"Quantity: {fuelQuantity}");
        if (isEnough) Console.WriteLine($"Car travelled {distance} km");
        else Console.WriteLine("Car needs refueling");
    }
}
class Truck : Vehicle
{
    public Truck(double distance, double fuelQuantity, double fuelConsumption) : base(distance, fuelQuantity, fuelConsumption)
    {
    }
    public override void Drive()
    {
        double totalConsumption = distance * (fuelConsumption + 1.6);
        fuelQuantity = fuelQuantity * 0.95;
        bool isEnough = fuelQuantity > totalConsumption;
        Console.WriteLine($"totalConsumption: {totalConsumption}");
        Console.WriteLine($"Quantity: {fuelQuantity}");
        if (isEnough) Console.WriteLine($"Truck travelled {distance} km");
        else Console.WriteLine("Truck needs refueling");
    }
}


