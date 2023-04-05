namespace Zadacha4;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Multiply(4));
    }

    static int Multiply(int n)
    {
        if (n == 1) return 1;
        return Multiply(n - 1) * (2 * n - 1);
    }
}

