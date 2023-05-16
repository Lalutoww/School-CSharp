namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
        for (int i = 0; i < numbers.Count - 1; i++)
        {
            if (numbers[i] == numbers[i + 1])
            {
                int sum = numbers[i] + numbers[i + 1];
                numbers[i] = sum;
                numbers.RemoveAt(i + 1);
            }
            if (i != 0)
            {
                for (int j = 0; j < numbers.Count - 1; j++)
                {
                    if (numbers[j] == numbers[j+1])
                    {
                        int sum = numbers[j] + numbers[j+1];
                        numbers[j] = sum;
                        numbers.RemoveAt(j+1);
                    }
                }
            }
        }
        Console.WriteLine(String.Join(",", numbers));
    }
}

