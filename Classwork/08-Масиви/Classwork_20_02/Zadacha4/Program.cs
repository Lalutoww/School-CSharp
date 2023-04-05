namespace Zadacha4;
class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
        int sum = 0;
        foreach (int element in array)
        {
            if (element >= 0)
            {
                sum += element;
                if(element>0) Console.WriteLine(element);
            }
            else break;
        }
        Console.WriteLine("Sum " + sum);
    }
}

