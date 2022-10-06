using System;

namespace zad3_daily_income
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Workdays: ");
            int workDays = int.Parse(Console.ReadLine());
            Console.Write("Daily Income: ");
            double dailyIncome = double.Parse(Console.ReadLine());
            Console.Write("Dollar To Lev: ");
            double dollarToLev = double.Parse(Console.ReadLine());

            double monthlySalary = workDays * dailyIncome;
            double yearlyIncome = monthlySalary * 12 + monthlySalary * 2.5;
            double tax = yearlyIncome * 0.25;
            double yearlyIncomeNoTax = yearlyIncome - tax;
            double yearlyIncomeToBGN = yearlyIncomeNoTax * dollarToLev;
            double averageDailyIncome = yearlyIncomeToBGN / 365;
            Console.WriteLine($"{averageDailyIncome:F2}");
        }
    }
}

