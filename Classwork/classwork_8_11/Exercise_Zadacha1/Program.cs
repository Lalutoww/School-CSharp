using System;

namespace Exercise_Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int count = 0;
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    count++;
                }

            } while (num != 0);
            Console.WriteLine("Otricatelni chisla: "+ count);
            
        }
    }
}

