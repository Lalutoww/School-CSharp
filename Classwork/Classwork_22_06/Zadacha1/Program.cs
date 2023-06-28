namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(' ').ToArray();
        var counts = new Dictionary<string, int>();

        foreach (var item in arr)
        {
            if (counts.ContainsKey(item))
            {
                counts[item]++;
            }
            else
            {
                counts[item] = 1;
            }
        }
        Console.WriteLine("---------------");
        foreach (var item in counts)
        {
            if (item.Value % 2 == 1)
            {
                Console.WriteLine(item.Key);
            }
        }
    }
}

