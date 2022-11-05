using System.Drawing;
using Lab9.Interface;

namespace Lab9.Triangles
{
    public abstract class Triangle: IDraw
    {
        protected Random Rand { get; } = new();
        private int Max => byte.MaxValue + 1; //256
        public abstract string Name { get; }
        public abstract Color TriangleColor { get; set; }
        public abstract int SideLength { get; set; }

        public abstract int OtherSideLength { get; set; }

        public abstract int AngleBetweenSides { get; set; }
        public abstract double TriangleArea { get; set; }
        public abstract double TrianglePerimeter { get; set; }

        protected Color GetRandomColor()
        {
            int r = Rand.Next(Max);
            int g = Rand.Next(Max);
            int b = Rand.Next(Max);
            var color = Color.FromArgb(r, g, b);
            return color;
        }

        public abstract void AreaCalculation();

        public abstract void PerimeterCalculation();

        public virtual void Draw()
        {
            Console.WriteLine($"Name: {Name}\n" +
                              $"Area: {TriangleArea}\n" +
                              $"Perimeter: {TrianglePerimeter}\n" +
                              $"Color: {TriangleColor.ToString()}\n");
        }
    }
}