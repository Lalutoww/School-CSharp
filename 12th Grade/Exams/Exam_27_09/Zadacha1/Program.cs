namespace Zadacha1;

abstract class Building
{
    public int BuildingLevels { get; set; }
    public string Adress { get; set; }

    public Building(int buildingLevels, string adress)
    {
        BuildingLevels = buildingLevels;
        Adress = adress;
    }

    public void GetAdress()
    {
        Console.WriteLine($"Building's adress is: {this.Adress}");
    }

    abstract public int GetHeight();
}

class House : Building
{
    public string Owner { get; set; }
    public House(int buildingLevels, string adress, string owner) : base(buildingLevels, adress)
    {
        BuildingLevels = buildingLevels;
        Adress = adress;
        Owner = owner;
    }

    public override int GetHeight()
    {
        int height = BuildingLevels * 3 + 2;
        return height;
    }
    public override string ToString()
    {
        return $"Adress: {Adress}; Height: {GetHeight()}" ;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int n;
        do
        {
            Console.Write("Enter number [1;100]: ");
            n = int.Parse(Console.ReadLine());
        } while (n<1 || n>100);

        List<House> houseList = new List<House>();
        for (int i = 0; i < n; i++)
        {
            string fix;
            switch (i+1)
            {
                case 1: fix = "st"; break;
                case 2: fix = "nd"; break;
                case 3: fix = "rd"; break;
                default: fix = "th"; break;
            }
            Console.Write($"Enter {i+1}{fix} Adress: ");
            string adressInput = Console.ReadLine();
            Console.Write($"Enter {i+1}{fix} building levels: ");
            int buildingLevelsInput = int.Parse(Console.ReadLine());
            Console.Write($"Enter {i+1}{fix} Owner: ");
            string ownerInput = Console.ReadLine();

            House newHouse = new House(buildingLevelsInput, adressInput, ownerInput);
            houseList.Add(newHouse);
            Console.WriteLine("------------------");
        }

        foreach (var house in houseList)
        {
            Console.WriteLine(house.ToString());
        }
    }
}