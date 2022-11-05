using System.Drawing;

namespace Lab9.Triangles
{
    public class IsTriangle : Triangle
    {
        public override string Name { get; }
        public override Color TriangleColor { get; set; }
        public override int SideLength { get; set; }
        public override int OtherSideLength { get; set; }
        public override int AngleBetweenSides { get; set; }
        public override double TriangleArea { get; set; }
        public override double TrianglePerimeter { get; set; }


        public IsTriangle(string name)
        {
            Name = name;
            TriangleColor = Color.Brown;
            SideLength = Rand.Next(1, 10);
            OtherSideLength = SideLength;
            AngleBetweenSides = Rand.Next(10, 170);
        }

        public IsTriangle(string name, int sideLength)
        {
            Name = name;
            TriangleColor = GetRandomColor();
            SideLength = sideLength;
            OtherSideLength = SideLength;
            AngleBetweenSides = Rand.Next(10, 170);
        }

        public IsTriangle(string name, Color color, int sideLength)
        {
            Name = name;
            TriangleColor = color;
            SideLength = sideLength;
            OtherSideLength = SideLength;
            AngleBetweenSides = Rand.Next(10, 170);
        }

        public void Init()
        {
            AreaCalculation();
            PerimeterCalculation();
        }

        public override void AreaCalculation()
        {
            double calculate = 1 / 2 * OtherSideLength * HighCalculation();
            TriangleArea = calculate;
        }

        private double HighCalculation() => Math.Sqrt((Math.Pow(SideLength, 2) - Math.Pow(OtherSideLength, 2)) / 4);

        public override void PerimeterCalculation()
        {
            double calculate = SideLength * 2 + OtherSideLength;
            TrianglePerimeter = calculate;
        }
    }
}