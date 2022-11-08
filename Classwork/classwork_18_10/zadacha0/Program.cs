using System;

namespace zadacha0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведете оценка: ");
            int grade = int.Parse(Console.ReadLine());
            bool isCorrect = true;
            switch (grade)
            { 
                case 2: Console.WriteLine("Слаб"); break;
                case 3: Console.WriteLine("Среден"); break;
                case 4: Console.WriteLine("Добър"); break;
                case 5: Console.WriteLine("Много добър"); break;
                case 6: Console.WriteLine("Отличен"); break;
                default: Console.WriteLine("Некоректен вход"); break;
            }
        }
    }
}

