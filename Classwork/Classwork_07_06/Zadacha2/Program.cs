using System;

namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        int[] array = { 10, 23, 45, 12, 11, 4 };
        for (int i = 0; i < array.Length; i++)
        {
            int min = array[i];
            for (int n = i+1; n < array.Length; n++)
            {
                if (array[n] < array[i])
                {
                    min = array[i];
                    array[i] = array[n];
                    array[n] = min;
                }
            }
        }
        Console.WriteLine($"Array after change: [{string.Join(", ", array)}]");
    }
}
