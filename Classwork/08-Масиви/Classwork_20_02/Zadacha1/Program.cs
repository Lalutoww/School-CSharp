namespace Zadacha1;
class Program
{
    static void Swap(int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    static void Swap(ref int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    static void Swap(int x, ref int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    static void Swap(ref int x, int y)
    {
        int temp = x;
        x = y;
        y = temp;
    }
    static void Main(string[] args)
    {
        int x = 5, y = 6;
        Swap(x, y);
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("-------------------------------");
        x = 5; y = 6;
        Swap(ref x,ref y);
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("-------------------------------");
        x = 5; y = 6;
        Swap(x,ref y);
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine("-------------------------------");
        x = 5; y = 6;
        Swap(ref x, y);
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);

    }
}

