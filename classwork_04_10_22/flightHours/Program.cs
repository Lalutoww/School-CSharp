using System;

namespace flightHours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hours = ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes = ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Fly time = ");
            int length = int.Parse(Console.ReadLine());
            //------------------------\\
            int hoursToMin = hours * 60;
            int allInMin = hoursToMin + minutes + length;
            int allMinToHours = allInMin / 60;
            int onlyMinutes = (minutes + length) % 60;
            Console.WriteLine($"{allMinToHours}:{onlyMinutes}h");


        }
    }
}

