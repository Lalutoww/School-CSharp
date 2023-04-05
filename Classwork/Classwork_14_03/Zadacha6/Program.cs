namespace Zadacha6;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter rotations: ");
        int rotations = int.Parse(Console.ReadLine());

        int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        int lastElement = arr.Length - 1;
        for (int i = 0; i < rotations; i++)
        {
            int c = arr[0];
            arr[0] = arr[lastElement];
            arr[lastElement] = c;
        }
        Console.WriteLine(string.Join(' ', arr));
    }

    //2 4 15 31 = 4 15 31 2 = 15 31 2 4 = 31 2 4 15 = 2 4 15 31 = 4 15 31 2
}

