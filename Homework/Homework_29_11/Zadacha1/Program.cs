using System;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.studentName = "Ivan";
            student1.schoolClass = "12 a";
            student1.bulGrade = 5;
            student1.enGrade = 3;
            student1.mathGrade = 2;

            Student student2 = new Student();

            Console.WriteLine("Enter info for student 2:");
            Console.Write("Name: ");
            student2.studentName = Console.ReadLine();
            Console.Write("Class: ");
            student2.schoolClass = Console.ReadLine();
            Console.Write("Bulgarian Grade: ");
            student2.bulGrade = double.Parse(Console.ReadLine());
            Console.Write("English Grade: ");
            student2.enGrade = double.Parse(Console.ReadLine());
            Console.Write("Maths Grade: ");
            student2.mathGrade = double.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Student 1 Info: ");
            student1.IntroduceSelf();
            student1.AverageScore();

            Console.WriteLine();

            Console.WriteLine("Student 2 Info: ");
            student2.IntroduceSelf();
            student2.AverageScore();
        }
    }
}
