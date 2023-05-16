namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        List<string> names = new List<string>() {"Petar", "Ani", "Georgi"};
        PrintElements(names);
        names[1] = "Anelia";
        PrintElements(names);
        names.Add("Petko");
        PrintElements(names);
        names.Sort();
        PrintElements(names);
        if (names.Contains("Lora")) Console.WriteLine("List has the name Lora");
        else names.Insert(0, "Lora");
        PrintElements(names);
        names.Sort();
        names.Reverse();
        PrintElements(names);
        Console.WriteLine("----------------");
        foreach (string name in names) Console.Write(name + " ");
        for (int i = 0; i < names.Count; i++) Console.Write(i + " ");
        Console.WriteLine("List: " + string.Join(' ', names));

    }
    static void PrintElements(List<string> names)
    {
        Console.WriteLine("Count: " + names.Count());
        Console.WriteLine("List: " + string.Join(' ', names));
    }
}

