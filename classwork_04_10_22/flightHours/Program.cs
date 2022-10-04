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
            int hoursToMin = hours * 60;
            int allMin = hoursToMin + minutes + length;
            int allMinToHours = allMin / 60;
            int totalMin = minutes + length;
            double ath = (minutes + length) / 60.0;
            Console.WriteLine(ath);

            if (totalMin > 60)
            {
                totalMin -= 60;
            }
            Console.WriteLine($"{allMinToHours}:{totalMin}h");


        }
    }
}

