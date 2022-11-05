using Lab9.Triangles;

namespace Lab9
{
    public class Picture
    {
        public int CountTriangle { get; private set; }
        private readonly List<Triangle> _triangles;
        private readonly List<Triangle> _trianglesPrefab = new()
        {
            new EqTriangle("eq1"),
            new IsTriangle("is1"),
            new RectTriangle("rect1")
        };
        private double _maxArea = 50;
        private Random _random = new();

        public Picture()
        {
            _triangles = new List<Triangle>();
        }

        public Picture(int countTriangles)
        {
            _triangles = new List<Triangle>();
            for (int i = 0; i < countTriangles; i++)
            {
                AddTriangle(_trianglesPrefab?[_random.Next(0, _trianglesPrefab.Count)]);
            }
        }

        public void Init()
        {
            CountTriangle = _triangles.Count;
        }

        public void AddTriangle(Triangle? triangle)
        {
            _triangles.Add(triangle);
            CountTriangle = _triangles.Count;
        }

        public void CheckAreaTriangleForMove(string name)
        {
            foreach (var triangle in _triangles)
            {
                if (triangle.Name == name)
                {
                    if (triangle.TriangleArea > _maxArea)
                    {
                        RemoveTriangle(triangle);
                    }
                    else
                    {
                        Console.WriteLine("A triangle has a permissible area");
                    }
                }
            }
            
        }
        private void RemoveTriangle(Triangle triangle)
        {
            _triangles.Remove(triangle);
            CountTriangle = _triangles.Count;
        }
        public void GetInfoAboutTriangles()
        {
            foreach (var triangle in _triangles)
            {
                Console.WriteLine(triangle.Name);
            }
        }
    }
}