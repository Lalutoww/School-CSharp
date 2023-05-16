namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {

        List<int> inputList = Console.ReadLine().Split().Select(int.Parse).ToList();
        int maxLength = 1;
        int maxNumber = 0;

        for (int i = 0; i<inputList.Count-1; i++)
        {
            int count = 1;
            for(int j = i+1; j<inputList.Count; j++)
            {
                if (inputList[i] == inputList[j])
                {
                    count++;
                    if (count > maxLength)
                    {
                        maxLength = count;
                        maxNumber = inputList[i];
                    }
                }
                else break;
            }
        }
        for (int i = 0; i < maxLength; i++)
        {
            Console.Write(maxNumber + " ");
            
            
        }
    }
}

/* 3 4 4 5 5 5 6 7 7;

output: 3

countFirst 1
countNext 2 */

