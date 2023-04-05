namespace Zadacha3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[,] arr = new int[n, n];
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            int[] red = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                arr[row, col] = red[col];
            }
        }

        int sum = 0;
        int multiplication = 1;
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (col < row) sum+= arr[row, col];
                if (row+col < n-1) multiplication *= arr[row, col];
            }
        }
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Multiplication: " + multiplication);
    }
}

