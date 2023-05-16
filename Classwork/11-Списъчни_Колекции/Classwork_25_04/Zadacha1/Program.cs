using System.Collections;

namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        double[] firstNumbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        Stack<double> numbers = new Stack<double>(firstNumbers);
        string[] command;
        string firstEl;

        do
        {
            Console.Write("Enter command: {add & num1, num2}/{remove & how many items}/{end}: ");
            command = Console.ReadLine().Split(' ').ToArray();
            firstEl = command[0].ToLower();

            switch (firstEl)
            {
                case "add":
                    numbers.Push(int.Parse(command[1]));
                    numbers.Push(int.Parse(command[2]));
                    break;
                case "remove":
                    int countToRemove = int.Parse(command[1]);
                    if (numbers.Count >= countToRemove)
                    {
                        for (int i = 0; i < countToRemove; i++)
                        {
                           numbers.Pop();
                        }
                    }
                    else Console.WriteLine("Not enough elements in stack");
                    break;
            }

        } while (firstEl != "end");
        Console.WriteLine("Sum: " + numbers.Sum());
    }
}

