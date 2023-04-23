namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        int[] a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        Console.Write("How many rotations: ");
        int rotations = int.Parse(Console.ReadLine());


        for (int i = 0; i < rotations; i++)
        {
            int firstElement = a[0];
            for (int j = 0; j < a.Length-1; j++)
            {
                a[j] = a[j + 1];
            }
            a[a.Length - 1] = firstElement;
        }

        Console.WriteLine(string.Join(' ',a));
    }
}

