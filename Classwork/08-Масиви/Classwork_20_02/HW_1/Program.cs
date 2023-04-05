namespace HW_1;
class Program
{
    static void Main(string[] args)
    {
        //a
        int n;
        do
        {
            Console.Write("Array Length: ");
            n = int.Parse(Console.ReadLine());
            if (!(n >= 2 && n <= 10)) Console.WriteLine("Incorrect entry!");
        } while (!(n>=2&&n<=10));
        int[] arr1 = new int[n];
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.Write($"arr1[{i}] = ");
            arr1[i] = int.Parse(Console.ReadLine());
        }
        //b
        int count = 0;
        foreach (int num in arr1)
        {
            if (num < 0) count++;
        }
        //c
        bool hasDivisibleByThree = false;
        foreach (int num in arr1)
        {
            if (num % 3 == 0 && num != 0)
            {
                hasDivisibleByThree = true;
                break;
            }
        }
        //d
        int sum = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            if(i%2== 0)
            {
                sum += arr1[i];
            }
        }
        //e
        int maxNum = 0;
        int index = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] > maxNum)
            {
                maxNum = arr1[i];
                index = i;
            }
        }
        //f
        arr1[index] = arr1[0];
        arr1[0] = maxNum;

        Console.WriteLine("Negative Count: " + count);
        Console.WriteLine("Does the array contain numbers divisible by 3: " + hasDivisibleByThree);
        Console.WriteLine("Sum of all even indices: " + sum);
        Console.WriteLine("Highest number in array: " + maxNum);
        Console.WriteLine($"Array after change: [{string.Join(", ", arr1)}]");
    }
}

