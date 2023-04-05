namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Fib(50));
    }

    static double Fib(double n)
    {
        if (n == 1 || n == 2) return 1;
        return Fib(n - 1) + Fib(n - 2);
    }
}

