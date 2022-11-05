using Lab9.Abilities;
using Lab9.Triangles;

namespace Lab9
{
    public static class Program
    {
        private static int _numberTriangle;

        private static void Main()
        {
            var painter = new Painter();
            painter.Draw();

            var picture = new Picture(3);
            picture.Init();

            picture.GetInfoAboutTriangles();
            Console.WriteLine($"1- add triangle\n" +
                              $"2- check triangle area for remove");
            int action = int.Parse(Console.ReadLine());
            switch (action)
            {
                case 1:
                    picture.AddTriangle(new IsTriangle($"is{_numberTriangle}"));
                    _numberTriangle++;
                    break;
                case 2:
                    Console.WriteLine("Write triangle name");
                    string name = Console.ReadLine();
                    picture.CheckAreaTriangleForMove(name);
                    break;
            }

            picture.GetInfoAboutTriangles();

            Console.WriteLine("Draw info");

            picture.Draw();
        }
    }
}