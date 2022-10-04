using System;

namespace inchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Конвертор на инчове в сантиметри");
            Console.Write("Inches = ");
            double inches = double.Parse(Console.ReadLine());
            double centimeters = inches * 2.54;
            Console.WriteLine($"Centimeters = {centimeters}"); */

            // Now cm to inches ---> Comment whichever you don't need.

            Console.WriteLine("Конвертор на сантиметри в инчове");
            Console.Write("Centimeters = ");
            double cm = double.Parse(Console.ReadLine());
            double inch = cm / 2.54;
            Console.WriteLine($"Centimeters = {Math.Round(inch)}");
        }
    }
}

