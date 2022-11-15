using System;

namespace zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Architect's name: ");
            string architectName = Console.ReadLine();
            Console.Write("Project count: ");
            int projectCount = int.Parse(Console.ReadLine());
            int hoursNeeded = projectCount * 3;

            Console.WriteLine($"The architect {architectName} will need {hoursNeeded} hours to complete {projectCount} project/s.");
        }
    }
}

