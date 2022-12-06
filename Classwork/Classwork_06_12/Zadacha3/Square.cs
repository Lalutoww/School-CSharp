using System;
namespace Zadacha3
{
	public class Square
	{
		private double side;
		public double Side
		{
			get { return this.side; }
			set { if(value > 0) this.side = value; }
		}
		public Square() { }
		public Square(double s)
		{
			this.side = s;
		}
		public Square(Square sq)
		{
			this.side = sq.side;
		}

		public void PrintArea()
		{
			Console.WriteLine($"Area: {Math.Pow(this.side,2)}");
		}
		public double CalcPerimeter()
		{
			return side * 4; // "this.side" is the same as just "side"
		}
		public void PrintInfo()
		{
			Console.WriteLine($"Side: {side}");
			Console.Write($"Area: ");
			PrintArea();
			Console.WriteLine($"Perimeter: {CalcPerimeter()}");
		}
	}
}

