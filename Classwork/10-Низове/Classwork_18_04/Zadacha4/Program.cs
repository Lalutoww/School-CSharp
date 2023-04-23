using System.Collections;

namespace Zadacha4;
class Program
{
    static void Main(string[] args)
    {
        ArrayList al = new ArrayList() { 1, 32, 5, "Stamat", "Georgi", 123, 5};

        foreach (var item in al) Console.WriteLine(item);
        Console.WriteLine("-------------------------------"); // Remove all 5s
        while(al.Contains(5)) al.Remove(5);
        Console.WriteLine("-------------------------------"); // Check if the element exists
        if (al.Contains(5)) Console.WriteLine("First index of element: " + al.IndexOf(5));
        else Console.WriteLine("The element doesnt exist");
        Console.WriteLine("-------------------------------"); // Display items
        foreach (var item in al) Console.WriteLine(item);
    }
}

