namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter array: ");
        int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();

        Console.WriteLine("Number to find: ");
        int numToFind = int.Parse(Console.ReadLine());
        if (array.Contains(numToFind)) Console.WriteLine("Array contains " + numToFind);

        foreach (int num in array)
        {
            if (num == numToFind)
            {
                Console.WriteLine("Array contains " + numToFind);
                break;
            }
        }

        Check(array, numToFind);
    }
    static bool Check(int[] array, int n)
    {
        bool hasEqual = false;
        foreach (int num in array)
        {
            if (num == n)
            {
                hasEqual = true;
            }
        }
        return hasEqual;
    }
}