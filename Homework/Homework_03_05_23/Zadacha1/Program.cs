using System.Linq;
namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        int[] arrayOne = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int[] arrayTwo = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        List<int> firstList = new List<int>(arrayOne);
        List<int> secondList = new List<int>(arrayTwo);

        //a) Merge both lists:
        Console.WriteLine("Обединение (с повторение): " + Merge(firstList, secondList));
        //b) Merge without repeating items:
        firstList = new List<int>(arrayOne); //get firstList back to it's old status
        Console.WriteLine("Обединение (без повторение): " + MergeNoRepeating(firstList,secondList));
        //c) Display section/cut:
        firstList = new List<int>(arrayOne);
        Console.WriteLine("Сечение: " + Section(firstList,secondList));
    }
    static object Merge(List<int> firstList, List<int> secondList)
    {
        foreach (int number in secondList) firstList.Add(number);
        return string.Join(", ", firstList);
    }

    static object MergeNoRepeating(List<int> firstList, List<int> secondList)
    {
        // remove first list's duplicates with built-in function
        // otherwise use another for loop to remove duplicates
        firstList = firstList.Distinct().ToList();
        foreach (int number in secondList)
        {
            if (!firstList.Contains(number)) firstList.Add(number);
        }
        return string.Join(", ", firstList);
    }

    static object Section(List<int> firstList, List<int> secondList)
    {
        firstList = firstList.Distinct().ToList(); // remove duplicates to make it easier
        secondList = secondList.Distinct().ToList();
        List<int> section = new List<int>();
        for(int i = 0; i<firstList.Count; i++)
        {
            int firstItem = firstList[i];
            for (int j = 0; j < secondList.Count; j++)
            {
                if (firstItem == secondList[j]) section.Add(firstItem);
            }
        }
        return string.Join(", ", section);
    }
}

