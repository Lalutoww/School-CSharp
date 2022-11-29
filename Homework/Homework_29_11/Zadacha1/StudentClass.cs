using System;
namespace Zadacha1
{
    public class Student
    {
        public string studentName;
        public string schoolClass;
        public double bulGrade;
        public double enGrade;
        public double mathGrade;

        public void IntroduceSelf()
        {
            Console.WriteLine($"I am {studentName} from {schoolClass}. My grades are:");
            Console.WriteLine($"Bulgarian: {bulGrade}");
            Console.WriteLine($"English: {enGrade}");
            Console.WriteLine($"Mathematics: {mathGrade}");
        }
        public void AverageScore()
        {
            double sum = bulGrade + enGrade + mathGrade;
            double avg = sum / 3;
            Console.WriteLine($"My average is {avg:F2}");
        }
    }
}

