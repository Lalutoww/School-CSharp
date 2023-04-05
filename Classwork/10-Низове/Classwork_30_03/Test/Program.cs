namespace Test;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        Console.WriteLine("Before: " + word);
        Console.WriteLine(word.Length);

        for (int i = 0; i < word.Length - 1; i++)
        {
            if (word[i] == word[i + 1])
            {
                for (int j = i+1; j < word.Length-1; j++)
                {
                    if (word[i] == word[j]) word = word.Remove(j, 1);
                    else break;
                }
            }
        }
        Console.WriteLine("After: " + word);
    }
}

