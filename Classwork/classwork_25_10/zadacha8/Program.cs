using System;

namespace zadacha8
{
    class Program
    {
        static void Main(string[] args)
        {
            string buff = "";
            string command = Console.ReadLine();

            while(command != "Stop")
            {
                    buff += $"{command} \n";
                    command = Console.ReadLine();
            }
            Console.WriteLine("-------------------");
            Console.WriteLine(buff);
        }
    }
}

