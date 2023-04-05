namespace Zadacha8;
class Program
{
    static void Main(string[] args)
    {
        string sentence = Console.ReadLine();
        string[] words = sentence.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length < 3)
            {
                int countToRemove = words[i].Length;
                int firstIndex = sentence.IndexOf(words[i]);
                sentence = sentence.Remove(firstIndex, countToRemove);
            }
        }
        Console.WriteLine(sentence);
    }
}

