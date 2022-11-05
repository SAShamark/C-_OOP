using System.Drawing;

namespace Lab9;

public class EqTriangle : Triangle
{
    public override string Name { get; }
    public override Color TriangleColor { get; set; }
    public override int SideLength { get; set; }
    public override int OtherSideLength { get; set; }
    public override int AngleBetweenSides { get; set; }

    public double TriangleArea { get; private set; }
    public double TrianglePerimeter { get; private set; }

    public EqTriangle(string name)
    {
        Name = name;
        TriangleColor = Color.Brown;
        SideLength = Rand.Next(1, 10);
        OtherSideLength = SideLength;
        AngleBetweenSides = 60;
    }

    public EqTriangle(string name, int sideLength)
    {
        Name = name;
        TriangleColor = GetRandomColor();
        SideLength = sideLength;
        OtherSideLength = SideLength;
        AngleBetweenSides = 60;
    }

    public EqTriangle(string name, int sideLength, int otherSideLength)
    {
        Name = name;
        TriangleColor = GetRandomColor();
        SideLength = sideLength;
        OtherSideLength = SideLength;
        AngleBetweenSides = 60;
    }

    public EqTriangle(string name, Color color, int sideLength, int otherSideLength)
    {
        Name = name;
        TriangleColor = color;
        SideLength = sideLength;
        OtherSideLength = SideLength;
        AngleBetweenSides = 60;
    }

    public void Init()
    {
        AreaCalculation();
        PerimeterCalculation();
    }

    public override void AreaCalculation()
    {
        double calculate = 1 / 2 * SideLength * HighCalculation();
        TriangleArea = calculate;
    }

    private double HighCalculation() => SideLength * Math.Sqrt(3) / 2;

    public override void PerimeterCalculation()
    {
        double calculate = SideLength * 3;
        TrianglePerimeter = calculate;
    }
}