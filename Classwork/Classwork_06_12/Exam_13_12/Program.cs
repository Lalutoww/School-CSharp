using System;
using System.Diagnostics;
using System.Drawing;

namespace Exam_13_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trapezius 1");
            Trapezius trap1 = new Trapezius();
            trap1.TrapInfo();

            Console.WriteLine("Trapezius 2");
            Console.WriteLine("Enter a,b,h");
            Trapezius trap2 = new Trapezius(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));

            trap2.TrapInfo();
        }
    }

    class Trapezius
    {
        private double a;
        private double b;
        private double h;

        public double A
        {
            get { return this.a; }
            set { this.a = value; }
        }

        public double B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public double H
        {
            get { return this.h; }
            set { this.h = value; }
        }

        public Trapezius()
        {
            this.a = 10;
            this.b = 15;
            this.h = 6;
        }
        public Trapezius(double width, double length, double height)
        {
            this.a = width;
            this.b = length;
            this.h = height;
        }

        public double CalculateC()
        {
            double minus = a - b;
            return Math.Sqrt(Math.Pow(this.h, 2) + Math.Pow(minus, 2) / 4);
        }
        public void CalculatePerimeter()
        {
            Console.WriteLine($"P = {a + b + 2*CalculateC()}");
        }
        public void TrapInfo()
        {
            Console.WriteLine($"a = {this.A}");
            Console.WriteLine($"b = {this.B}");
            Console.WriteLine($"h = {this.H}");
            this.CalculatePerimeter();
            Console.WriteLine($"c = {this.CalculateC()}");
        }
    }
}

