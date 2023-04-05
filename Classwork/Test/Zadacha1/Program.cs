namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        SportsCar s1 = new SportsCar("Peugeot", 2, 100, 15);
        SportsCar s2 = new SportsCar("Kia Sportage", 4, 380, 220);

        s1.GetBrand();
        Console.WriteLine($"{s1.GetFuelConsumption():F2}");

        s2.GetBrand();
        Console.WriteLine($"{s2.GetFuelConsumption():F2}");
    }
}

abstract class Vehicle
{
    protected string brand;
    protected int passengers;

    public Vehicle(string brand, int passengers)
    {
        this.brand = brand;
        this.passengers = passengers;
    }
    public void GetBrand()
    {
        Console.WriteLine($"Car Brand: {brand}");
    }
    public abstract double GetFuelConsumption();
}
class SportsCar : Vehicle
{
    protected int fuel;
    protected int kilometers;

    public SportsCar(string brand, int passengers, int fuel, int kilometers): base(brand, passengers)
    {
        this.fuel = fuel;
        this.kilometers = kilometers;
    }

    public override double GetFuelConsumption()
    {
        double total = fuel / (kilometers / 100.0);
        return total;
    }
}
