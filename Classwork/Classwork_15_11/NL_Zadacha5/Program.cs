using System;

namespace NL_Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter magic num: ");
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = i; j <= b; j++)
                {
                    if(i + j == magicNum)
                    {
                        if(i != j)
                            Console.WriteLine($"{i} + {j} = {magicNum}");
                            counter++;
                    }
                }
            }
            Console.WriteLine("---------------");
            Console.WriteLine(counter + " combinations");
        }
    }
}

