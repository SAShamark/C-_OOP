namespace Lab11
{
    public static class Program
    {
        private static void Main()
        {
        }
    }

    public class Conveyor
    {
        public delegate void OnDimensionsRemoved(Product product);

        public delegate void OnCutOff(Product product);

        public delegate void OnSharpened(Product product);

        public delegate void OnCutThread(Product product);

        public delegate void OnDrilled(Product product);

        public delegate void OnPainted(Product product);

        public delegate void OnTested(Product product);

        public delegate void OnPacked(Product product);

        public void DimensionsRemoved(Product product)
        {
            product.IsDimensionsRemoved = true;
        }

        public void CutOff(Product product)
        {
            product.IsCutOff = true;
        }

        public void Sharpened(Product product)
        {
            product.IsSharpened = true;
        }

        public void CutThread(Product product)
        {
            product.IsCutThread = true;
        }

        public void Drilled(Product product)
        {
            product.IsDrilled = true;
        }

        public void Painted(Product product)
        {
            product.IsPainted = true;
        }

        public void Tested(Product product)
        {
            product.IsTested = true;
        }

        public void Packed(Product product)
        {
            product.IsPacked = true;
        }
    }


    public class Product
    {
        public bool IsDimensionsRemoved { get; set; }
        public bool IsCutOff { get; set; }
        public bool IsSharpened { get; set; }
        public bool IsCutThread { get; set; }
        public bool IsDrilled { get; set; }
        public bool IsPainted { get; set; }
        public bool IsTested { get; set; }
        public bool IsPacked { get; set; }
    }
}