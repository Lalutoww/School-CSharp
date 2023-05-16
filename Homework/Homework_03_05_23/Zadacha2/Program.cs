namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        int[] inputArray = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        List<int> inputList = new List<int>(inputArray);
        List<int> distinctList = inputList.Distinct().ToList();
        distinctList.Sort(); // Sort numbers - needed by the task
        List<int> countList = new List<int>();

        for(int i = 0; i<distinctList.Count; i++)
        {
            int counter = 0;
            for(int j = 0; j<inputList.Count; j++)
            {
                if (distinctList[i] == inputList[j]) counter++;
            }
            countList.Add(counter);
        }
        for (int i = 0; i<distinctList.Count; i++)
        {
            Console.WriteLine($"{distinctList[i]} -> {countList[i]} times");
        }
    }
}
