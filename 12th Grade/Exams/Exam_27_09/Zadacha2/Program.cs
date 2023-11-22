namespace Zadacha2;

class Program
{
    static void Main(string[] args)
    {
        //A)
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Add number: ");
            double num = double.Parse(Console.ReadLine());
            arr[i] = num;
        }
        Console.WriteLine();
        Console.WriteLine($"Array: {String.Join(' ', arr)}");
        //B
        PositiveSum(arr);
        //C
        Console.WriteLine();
        OddIndices(arr);
    }
    static void PositiveSum(double[] arr)
    {
        double sum = 0;
        foreach (double number in arr)
        {
            if (number> 0) sum += number;
        }
        Console.Write($"Positive Numbers Sum: {sum}");
    }
    static void OddIndices(double[] arr)
    {
        int length = arr.Length;
        Console.Write($"Odd indices: ");
        for (int i = 0; i < length; i++)
        {
            if (i % 2 != 0) Console.Write($"{arr[i]} ");
        }
    }
}

