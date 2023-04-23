namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        int[] numberArr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        for (int i = 0; i < numberArr.Length; i++)
        {
            bool isHigher = true;
            for (int j = i+1; j < numberArr.Length; j++)
            {
                if (numberArr[i] <= numberArr[j])
                {
                    isHigher = false;
                    break;
                }
            }
            if (isHigher) Console.WriteLine(numberArr[i]);
        }
    }
}

