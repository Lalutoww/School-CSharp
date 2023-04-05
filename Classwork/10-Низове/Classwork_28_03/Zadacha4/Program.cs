namespace Zadacha4;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        Console.Write("Enter char: ");
        char ch = char.Parse(Console.ReadLine());

        int countChar = 0;
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == ch) countChar++;
        }
        int indCh = s.IndexOf(ch);
        Console.WriteLine($"{ch}'s first position is {indCh} and is found {countChar} times in the string");

        if (countChar == 1) Console.WriteLine(s.Substring(s.IndexOf(ch)+1));
        if (countChar > 1)
        {
            int subLength = s.LastIndexOf(ch) - s.IndexOf(ch) - 1;
            Console.WriteLine(s.Substring(s.IndexOf(ch) + 1, subLength));
        }
    }
}

