namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = new int[2, 4];
        for (int row = 0; row < 2; row++)
        {
            int[] red = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < 4; col++)
            {
                arr[row, col] = red[col];
            }
        }
        // Normal
        Console.WriteLine("Normal");
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write($"{arr[row, col]} ");
            }
            Console.WriteLine();
        }
        // New
        Console.WriteLine("New");
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                Console.Write($"{arr[row, col]} ");
            }
            Console.WriteLine();
        }
    }
}

