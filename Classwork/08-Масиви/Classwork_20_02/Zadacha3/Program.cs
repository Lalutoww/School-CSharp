namespace Zadacha3;
class Program
{
    static void Main(string[] args)
    {
        double[] array = Console.ReadLine().Split(',').Select(double.Parse).ToArray();
        bool hasEqual = false;
        //a
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i+1; j < array.Length; j++)
            {
                if (hasEqual) break;
                if (array[i] == array[j])
                {
                    hasEqual = true;
                    break;
                }
            }
        }
        Console.WriteLine("Has equal numbers: " + hasEqual);
        //b
        bool isSymetric = true;
        for (int i = 0; i < array.Length/2; i++)
        {
            if (array[i] != array[array.Length - 1 - i])
            {
                isSymetric = false;
                break;
            }
        }
        Console.WriteLine("Is Symetric: " + isSymetric);
        //c
        double min = array.Min();
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == min)
            {
                Console.Write(i + ", ");
                counter++;
            }
        }
        Console.WriteLine("Elements equal to min: " + counter);
    }
}

