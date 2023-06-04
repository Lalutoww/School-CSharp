namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        ReadNumber(0, 100);
    }

    static void ReadNumber(int start, int end)
    {
        int count = 0;
        do
        {
            Console.Write($"Enter number{count}: ");
            try
            {
                int newNumber = int.Parse(Console.ReadLine());
                if (newNumber < start || newNumber > end)
                {
                    throw new Exception("Number out of range");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            
            count++;
        } while (count <= 5);
    }
}

