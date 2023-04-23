using System.Collections;

namespace Zadacha1;
class Program
{
    // Stack
    static void Main(string[] args)
    {
        Stack a = new Stack();
        a.Push(5);
        a.Push(6);
        a.Push("7");
        foreach (var item in a)
        {
            Console.Write(item + " ");
        }

        Stack<int> b = new Stack<int>();
        b.Push(1);
        b.Push(2);
        b.Push(3);

        Console.WriteLine();
        foreach (int item in b)
        {
            Console.Write(item + " ");
        }

        int[] arr = { 1, 2, 3, 4, 5 };
        Stack c = new Stack(arr);
        Console.WriteLine();
        Console.WriteLine(string.Join(", ", c.ToArray()));
    }
}

