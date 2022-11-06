namespace Lab10
{
    public static class Program
    {
        private static void Main()
        {
            //Task 4
            int[] arrayValues = { 1, 2, 3, 10 };
            Console.WriteLine(MathematicalCalculations.ArithmeticMean(arrayValues));
            Console.WriteLine(MathematicalCalculations.GeometricMean(arrayValues));
        }
    }
}