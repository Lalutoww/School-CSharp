namespace Recursion;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(F(5));
    }

    static int F(int n)
    {
        if (n == 1) return 1;
        return F(n - 1) * n;
    }
}
