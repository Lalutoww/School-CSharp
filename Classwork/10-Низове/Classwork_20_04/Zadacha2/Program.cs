using System.Collections;

namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        ArrayList even = new ArrayList();
        Stack<int> odd = new Stack<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) even.Add(arr[i]);
            else odd.Push(arr[i]);
        }

        Console.WriteLine(string.Join(", ", even.ToArray()));
        Console.WriteLine(string.Join(", ", odd));
    }
}

