namespace Zadacha6;
class Program
{
    static void Main(string[] args)
    {
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');
        Console.WriteLine("Number of words: " + words.Length);

        int maxLength = -1;
        int maxWordIndex = -1;
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > maxLength)
            {
                maxLength = words[i].Length;
                maxWordIndex = i;
            }
        }
        Console.WriteLine($"The longest word is {words[maxWordIndex]} with length - {maxLength}");

    }
}

