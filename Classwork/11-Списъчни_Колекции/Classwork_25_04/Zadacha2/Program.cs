namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(' ');
        Array.Reverse(arr);
        Stack<string> equation = new Stack<string>(arr);
        int sum = int.Parse(equation.Pop());
        do
        {
            char assignment = char.Parse(equation.Pop());
            int num = int.Parse(equation.Pop());
            if (assignment == '+') sum += num;
            if (assignment == '-') sum -= num;
        } while (equation.Count>0);
        Console.WriteLine("Sum: " + sum);
    }
}

