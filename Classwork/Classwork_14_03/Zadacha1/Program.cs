namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        int[,] arr = { { 1, 1, 1 }, { 2, 4, 3 }, { 4, 5, 7 }, { 5, 6, 2 }, { 1, 1, 3 } };

        // а)

        int suma = 0;

        foreach (int x in arr)
        {
            suma = suma + x;

        }

        Console.WriteLine("Suma = " + suma);

        //print
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write($"{arr[row,col]} ");
            }
            Console.WriteLine();
        }

        // б)

        int countEvens = 0;

        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                if (col < row && arr[row, col] % 2 == 0) countEvens++;
            }
        }
        Console.WriteLine("Evens: " + countEvens);
    }
}