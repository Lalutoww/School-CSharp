namespace Zadacha4;
class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        Array.Sort(array);
        Console.WriteLine($"Array after change: [{string.Join(", ", array)}]");
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine($"Number at index {k} is: {array[k]}");
        double mid = (array.Length / 2)+1;
        if (array.Length % 2 == 0) mid = ((array[array.Length/2] + array[(array.Length / 2)-1]) / 2.0);
        Console.WriteLine($"Middle: {mid}");
    }
}
