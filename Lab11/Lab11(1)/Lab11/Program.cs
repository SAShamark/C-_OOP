namespace Lab11
{
    public static class Program
    {
        private static void Main()
        {
            //task 1
            var product = new Product();
            var conveyor = new Conveyor();
            
            conveyor.PredicateDelegateAcceptContainer.Invoke(product);
            product.PrintProductInfo();
        }
    }
}