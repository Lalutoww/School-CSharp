namespace Zadacha10;
class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();

        for (int i = 0; i < s.Length; i++)
        {
            if (char.IsLetter(s[i]))
            {
                if (char.IsUpper(s[i]))
                {
                    char lowerCase = char.ToLower(s[i]);
                    Console.Write(lowerCase);
                }
                else if (char.IsLower(s[i]))
                {
                    char upperCase = char.ToUpper(s[i]);
                    Console.Write(upperCase);
                }
            }
            else Console.Write(s[i]);
        }
    }
}

