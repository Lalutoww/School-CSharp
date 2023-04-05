using System.Xml.Linq;

namespace Zadacha2;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Annual Salary: ");
        double salary1 = double.Parse(Console.ReadLine());
        Employee e1 = new FullTimeEmployee("Stefan", salary1);
        e1.GetMonthlySalary();
        Console.Write("Hourly Salary: ");
        double hourly = double.Parse(Console.ReadLine());
        Console.Write("Hours Per Month: ");
        double hoursPerMonth = double.Parse(Console.ReadLine());
        Employee e2 = new ContractEmployee("Slavi", hourly, hoursPerMonth);
        e2.GetMonthlySalary();

    }
}

abstract class Employee
{
    private string Name { get; set; }

    public abstract void GetMonthlySalary();

    public Employee(string name)
    {
        this.Name = name;
    }
}

class FullTimeEmployee : Employee
{
    public double AnnualSalary { get; set; }

    public FullTimeEmployee(string name, double annualSalary) : base(name)
    {
        this.AnnualSalary = annualSalary;
    }

    public override void GetMonthlySalary()
    {
        Console.WriteLine($"Monthly Salary: {AnnualSalary / 12}");
    }
}
class ContractEmployee : Employee
{
    public double HourlySalary { get; set; }
    public double HoursPerMonth { get; set; }

    public override void GetMonthlySalary()
    {
        Console.WriteLine($"Monthly Salary: {HoursPerMonth * HourlySalary}");
    }

    public ContractEmployee(string name, double hourlySalary, double hoursPerMonth) : base(name)
    {
        this.HourlySalary = hourlySalary;
        this.HoursPerMonth = hoursPerMonth;
    }
}

