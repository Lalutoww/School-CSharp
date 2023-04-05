namespace Zadacha5;
class Program
{
    static void Main(string[] args)
    {
        string s1 = Console.ReadLine().ToLower();
        string s2 = Console.ReadLine().ToLower();

        int minLength = Math.Min(s1.Length, s2.Length);
        for (int i = 0; i < minLength; i++)
        {
            if (s1[i] != s2[i])
            {
                Console.WriteLine($"{i+1} {s1[i]} - {s2[i]}");
            }
        }
        int compare = string.Compare(s1,s2,true);
        if (compare == -1) Console.WriteLine("s1<s2");
        else if (compare == 0) Console.WriteLine("s1=s2");
        else Console.WriteLine("s1>s2");
    }
}

