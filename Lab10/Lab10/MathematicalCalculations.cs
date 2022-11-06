namespace Lab10
{
    public static class MathematicalCalculations
    {
        public static int ArithmeticMean(int[] array)
        {
            int sum = array.Sum();
            int arithmeticMean = sum / array.Length;
            return arithmeticMean;
        }

        public static double GeometricMean(int[] array)
        {
            int product = 0;
            for (int i = 1; i < array.Length; i++)
            {
                product += array[i - 1] * array[i];
            }

            double power = 1.0 / array.Length;
            double geometricMean = Math.Pow(product, power);
            return geometricMean;
        }
    }
}