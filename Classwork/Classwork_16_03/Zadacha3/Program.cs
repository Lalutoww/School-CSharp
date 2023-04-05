namespace Zadacha3;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Sum(12));
        Console.WriteLine(Sum1(15));
    }

    static int Sum(int n)
    {
        if (n == 1) return 1;
        return Sum(n-1) + n;
    }

    static long Sum1(int n)
    {
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}

