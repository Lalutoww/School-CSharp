using System;

namespace zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hours = ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes = ");
            int minutes = int.Parse(Console.ReadLine());
            //------------------------\\
            int hoursToMin = hours * 60;
            int allInMin = hoursToMin + minutes + 15;
            int allMinToHours = allInMin / 60;
            int onlyMinutes = (minutes + 15) % 60;
            if (allMinToHours >= 24) allMinToHours = 0;
            if (onlyMinutes < 10) Console.WriteLine($"{allMinToHours}:0{onlyMinutes}");
            else Console.WriteLine($"{allMinToHours}:{onlyMinutes}");
        }
    }
}

