using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command;
            string buff = "";
            int digitCounter = 0;
            string hasLowerCase = "No";
            do
            {
                command = Console.ReadLine();
                buff += $"{command} \n";

            } while (command != "0");

            for(int i = 0; i < buff.Length; i++)
            {
                if (Char.IsLower(buff[i]))
                {
                    hasLowerCase = "Yes";
                }
                for(int j = 1; j <= 9; j++)
                {
                    char intChar = (char)(j + 48);
                    if ((buff[i]) == intChar)
                    {
                        digitCounter++;
                    }
                }
            }
            Console.WriteLine(hasLowerCase);
            Console.WriteLine(digitCounter);
        }
    }
}

