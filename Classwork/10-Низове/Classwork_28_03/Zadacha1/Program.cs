namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split(',');
        bool isInAlphabeticalOrder = true;
        for (int i = 0; i < words.Length - 1; i++)
        {
            if (string.Compare(words[i], words[i+1], true) == 1) // true means ignore lower and higher case;
            {
                isInAlphabeticalOrder = false;
                break;
            }
        }
        if (isInAlphabeticalOrder) Console.WriteLine("Yes");
        else Console.WriteLine("No");
    }
}

