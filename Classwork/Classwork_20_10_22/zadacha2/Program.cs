using System;

namespace zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете първо число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Въведете второ число: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Въведете оператор: ");
            char op = char.Parse(Console.ReadLine());
            double sum = 0;
            bool isValid = true;

            switch (op)
            {
                case '+': sum = num1 + num2; break;
                case '-': sum = num1 - num2; break;
                case '/': if (num2 == 0) { isValid = false; Console.WriteLine("Невъзможно деление!"); } else sum = num1 / num2; break;
                case '*': sum = num1 * num2; break;
                default: Console.WriteLine("Невалидна операция!"); isValid = false; break;
            }

            if (isValid) Console.WriteLine(sum);
        }
    }
}

