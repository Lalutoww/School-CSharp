namespace Zadacha3;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        bool equalLetters = false;

        for (int i = 0; i < s.Length - 1; i++)
        {
            /*for (int j = i+1 ; j < s.Length; j++)
            {
                if (s[i] == s[j])
                {
                    equalLetters = true;
                    break;
                }
            }*/
            string sub = s.Substring(i + 1);
            if (sub.Contains(s[i]))
            {
                equalLetters = true;
            }
        }
        if (equalLetters) Console.WriteLine("There are equal letters");
        else Console.WriteLine("No equal letters");
    }
}

