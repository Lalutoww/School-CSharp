namespace Zadacha5;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("First Array: ");
        int[] array1 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        Console.Write("Second Array: ");
        int[] array2 = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        bool areTheSame = true;

        if (array1.Length == array2.Length)
        {
            for (int i = 0; i < array2.Length; i++)
            {
                if (array1[i] != array2[i])
                {
                    areTheSame = false;
                    break;
                }
            }
        }
        else areTheSame = false;

        Console.WriteLine($"Are the arrays the same ?: {areTheSame}");
    }
}

