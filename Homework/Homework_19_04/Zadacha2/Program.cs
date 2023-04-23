using System.Collections;

namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        ArrayList cars = new ArrayList()
        {
            new Car("Nissan", 20000),
            new Car("Peugeot", 4000),
            new Car("Porsche", 300000),
        };
        Console.WriteLine($"We have {cars.Count} cars.");

        Console.WriteLine();

        foreach (Car item in cars)
        {
            Console.Write(item.Brand + " ");
        }
        Console.WriteLine();
        foreach (Car item in cars)
        {
            Console.Write(item.Price + " ");
        }
    }
}

class Car
{

    public string Brand { get; }
    public decimal Price { get; }

    public Car(string brand, decimal price)
    {
        Brand = brand;
        Price = price;
    }
    public override string ToString()
    {
        return $"Car: {Brand}, {Price}";
    }

}

