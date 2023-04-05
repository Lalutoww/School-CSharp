namespace Zadacha5;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter wagons: ");
        int wagons = int.Parse(Console.ReadLine());
        int[] train = new int[wagons];
        int sum = 0;
        for (int i = 0; i < wagons; i++)
        {
            Console.Write("How many people in wagon: ");
            int people = int.Parse(Console.ReadLine());
            train[i] = people;
            sum += people;
        }
        Console.WriteLine(string.Join(" ", train));
        Console.WriteLine(sum);
    }
}

