using System.Collections;

namespace Zadacha3_arrayList;
class Program
{
    static void Main(string[] args)
    {
        ArrayList a = new ArrayList();
        Console.WriteLine(a.Capacity);
        a.Add(5);
        Console.WriteLine(a.Capacity);
        a.Add("Stamat");
        a.Add(7);
        a.Add(8);
        Console.WriteLine(a.Capacity);
        a.Add(9);
        Console.WriteLine(a.Capacity);
        Console.WriteLine(a.Count);
        a.Remove(9);
        Console.WriteLine(a.Capacity);
        Console.WriteLine(a.Count);

    }
}

