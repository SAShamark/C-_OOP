using System.Drawing;

namespace Lab9;

public class RectTriangle : Triangle
{
    public override string Name { get; }
    public override Color TriangleColor { get; set; }
    public override int SideLength { get; set; }
    public override int OtherSideLength { get; set; }
    public override int AngleBetweenSides { get; set; }
    public double TriangleArea { get; private set; }
    public double TrianglePerimeter { get; private set; }

    public RectTriangle(string name)
    {
        Name = name;
        TriangleColor = Color.Brown;
        SideLength = Rand.Next(1, 10);
        OtherSideLength = Rand.Next(1, 10);
        ;
        AngleBetweenSides = 90;
    }

    public RectTriangle(string name, int sideLength)
    {
        Name = name;
        TriangleColor = GetRandomColor();
        SideLength = sideLength;
        OtherSideLength = Rand.Next(1, 10);
        ;
        AngleBetweenSides = 90;
    }

    public RectTriangle(string name, int sideLength, int otherSideLength)
    {
        Name = name;
        TriangleColor = GetRandomColor();
        SideLength = sideLength;
        OtherSideLength = otherSideLength;
        AngleBetweenSides = 90;
    }

    public RectTriangle(string name, Color color, int sideLength, int otherSideLength)
    {
        Name = name;
        TriangleColor = color;
        SideLength = sideLength;
        OtherSideLength = otherSideLength;
        AngleBetweenSides = 90;
    }

    public void Init()
    {
        AreaCalculation();
        PerimeterCalculation();
    }

    public override void AreaCalculation()
    {
        double calculate = 1 / 2 * SideLength * OtherSideLength;
        TriangleArea = calculate;
    }


    public override void PerimeterCalculation()
    {
        double calculate = SideLength + OtherSideLength + FindThirdSide();
        TrianglePerimeter = calculate;
    }

    private double FindThirdSide() => SideLength + OtherSideLength;
}