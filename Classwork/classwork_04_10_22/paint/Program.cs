using System;

namespace paint
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Налага се да се боядиса правоъгълна стена с дължина w и височина h.
              Известно е, че с една кутия боя могат да се боядисат m квадратни единици площ от стената.
              Напишете програма,която прочита от клавиатурата дробните числа w, h и m,
              и извежда на екрана колко кутии боя са необходими за да се боядиса стената. */

            Console.Write("w = ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            Console.Write("m = ");
            double m = double.Parse(Console.ReadLine());

            double S = (w * h) / m;

            Console.WriteLine(Math.Ceiling(S));
        }
    }
}

