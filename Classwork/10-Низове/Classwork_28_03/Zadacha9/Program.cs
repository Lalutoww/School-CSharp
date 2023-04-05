namespace Zadacha9;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        char ch = char.Parse(Console.ReadLine());

        CheckCount(s, ch);

    }

    static void CheckCount(string s, char ch)
    {
        int count = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ch) count++;
        }
        Console.WriteLine("Char is found " + count + " times");
    }
}

