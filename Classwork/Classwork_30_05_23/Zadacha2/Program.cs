namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Number: ");
        int number = int.Parse(Console.ReadLine());
        try
        {
            if (number < 0) throw new Exception("The number is negative.");

            double sqrtNumber = Math.Sqrt(number);
            Console.WriteLine(sqrtNumber);
            

        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}

