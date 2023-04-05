namespace Zadacha7;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string strToCheck = Console.ReadLine();

        int count = 0;
        int strLength = strToCheck.Length;

        while (s.Contains(strToCheck))
        {
            count++;
            int startIndex = s.IndexOf(strToCheck);
            s = s.Remove(startIndex, strLength);
        }

        Console.WriteLine($"{strToCheck} is found {count} times");
    }
}

