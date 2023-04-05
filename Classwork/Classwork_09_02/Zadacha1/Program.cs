namespace Zadacha1;
class Program
{
    static void Main(string[] args)
    {
        Circle c1 = new Circle(1);
        Console.WriteLine($"Circle - r = {c1.r}");
        Console.WriteLine(c1.GetArea());

        Cylinder cyl1 = new Cylinder(1, 2);
        Console.WriteLine("Cylinder:");
        Console.WriteLine(cyl1.GetVolume());

        Cone con1 = new Cone(1, 2);
        Console.WriteLine("Cone:");
        Console.WriteLine(con1.GetVolume());
    }
}

interface IShapes
{
    //string Color { get; set; }
}

interface I3DShapes : IShapes
{
    double GetVolume();
    double GetArea();
}

interface I2DShapes : IShapes
{
    double GetArea();
}

class Circle : I2DShapes
{
    public Circle(double radius)
    {
        this.r = radius;
    }
    public double r;
    public double GetArea()
    {
        return Math.PI * Math.Pow(r, 2);
    }
}

class Cylinder : Circle, I3DShapes
{
    public Cylinder(double radius, double height) : base(radius)
    {
        this.h = height;
    }
    protected double h;

        public virtual double GetVolume()
        {
            return GetArea() * h;
        }
}

class Cone : Cylinder, I3DShapes
{
    public Cone(double radius, double height) : base(radius, height)
    {
    }

    public override double GetVolume()
    {
        return (GetArea() * h) / 3;
    }
}
