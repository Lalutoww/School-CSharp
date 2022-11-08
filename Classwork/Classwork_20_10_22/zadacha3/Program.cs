using System;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter sex (m / f): ");
            char sex = char.Parse(Console.ReadLine());

            if(age < 16)
            {
                if(sex == 'm')
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }else if(age >= 16)
            {
                if (sex == 'm')
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }

        }
    }
}

