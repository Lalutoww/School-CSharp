namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"numbers[{i}] = ");
            numbers[i] = int.Parse(Console.ReadLine());
            numbers[i]++;
        }
        Console.WriteLine("-------------------------------");
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
    }
}

