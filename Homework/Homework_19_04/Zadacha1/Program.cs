using System.Collections;

namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter numbers: ");
        int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        ArrayList numbers = new ArrayList(a);

        Console.Write("Enter rotations: ");
        int rotations = int.Parse(Console.ReadLine());

        for (int i = 0; i < rotations; i++)
        {
            numbers.Add(numbers[0]);
            numbers.RemoveAt(0);
        }
        Console.WriteLine(string.Join(" ", numbers.ToArray()));
    }
}

