namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 10, 20, 30, 40, 50, 60, 10, 30, 20, 10 };
        //a
        numbers.RemoveAt(2);
        PrintElements(numbers);
        Console.WriteLine();
        //b
        numbers.Remove(10);
        PrintElements(numbers);
        Console.WriteLine();
        //c
        numbers.Add(90);
        PrintElements(numbers);
        Console.WriteLine();
        //d
        numbers.Insert(0, -5);
        PrintElements(numbers);
        Console.WriteLine();
        //e
        int[] arr = new int[numbers.Count];
        numbers.CopyTo(arr);
        Array.Sort(arr);
        Console.WriteLine("Sum: " + arr.Sum());
        Console.WriteLine("Max Element: " + arr.Max());
        Console.WriteLine("Min Element: " + arr.Min());
        PrintElements(numbers);
        Console.WriteLine();
        //f
        numbers.AddRange(arr);
        PrintElements(numbers);
        Console.WriteLine();
        //g
        numbers.LastIndexOf(10);
        PrintElements(numbers);
        Console.WriteLine();
        //h
        if (!numbers.Contains(-70)) numbers.Insert(1, -70);
        PrintElements(numbers);
        Console.WriteLine();
        //i
        Console.WriteLine("Sum: " + numbers.Sum());
        Console.WriteLine("Max: " + numbers.Max());
        Console.WriteLine("Min: " + numbers.Min());
        PrintElements(numbers);
        Console.WriteLine();
        //j
        numbers.Reverse();
        PrintElements(numbers);
        Console.WriteLine();
        //k
        int count = 0;
        foreach (int number in numbers)
        {
            if (number % 20 == 0) count++;
        }
        Console.WriteLine("Numbers divided by 20: " + count);
        PrintElements(numbers);
        Console.WriteLine();
        //l
        numbers.Clear();
        PrintElements(numbers);
        Console.WriteLine();
    }
    static void PrintElements(List<int> numbers)
    {
        Console.WriteLine("List: " + string.Join("; ", numbers));
        Console.WriteLine("Count: " + numbers.Count());
    }
}

