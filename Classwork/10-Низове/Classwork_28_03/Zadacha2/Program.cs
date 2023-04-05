namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string 1: ");
        string s1 = Console.ReadLine();
        Console.Write("Enter string 2: ");
        string s2 = Console.ReadLine();

        for (int i = 0; i < s1.Length; i++)
        {
            if (char.IsLetter(s1[i]) && !s2.Contains(s1[i]))
            {
                Console.Write(s1[i]);
            }
        }
        Console.WriteLine();
    }
}

