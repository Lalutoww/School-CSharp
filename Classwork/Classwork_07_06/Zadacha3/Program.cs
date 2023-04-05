namespace Zadacha3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = i * 5;
        }
        if (numbers.Contains(26)) Console.WriteLine($"26 is at {Array.IndexOf(numbers,26)} position");
        if (numbers.Contains(15)) Console.WriteLine($"15 is at {Array.IndexOf(numbers, 15)} position");
        if (numbers.Contains(40)) Console.WriteLine($"40 is at {Array.IndexOf(numbers, 40)} position");

        Console.WriteLine($"Array after change: [{string.Join(", ", numbers)}]");
    }
}

