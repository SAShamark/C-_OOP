namespace Lab11;

public class Conveyor
{
    public delegate void PredicateDelegateAccept(Product product);

    public readonly PredicateDelegateAccept PredicateDelegateAcceptContainer;

    public Conveyor()
    {
        PredicateDelegateAcceptContainer = delegate(Product product)
        {
            DimensionsRemoved(product);
            CutOff(product);
            Drilled(product);
            Tested(product);
        };
    }

    private void DimensionsRemoved(Product product)
    {
        product.IsDimensionsRemoved = true;
    }

    private void CutOff(Product product)
    {
        product.IsCutOff = true;
    }

    private void Sharpened(Product product)
    {
        product.IsSharpened = true;
    }

    private void CutThread(Product product)
    {
        product.IsCutThread = true;
    }

    private void Drilled(Product product)
    {
        product.IsDrilled = true;
    }

    private void Painted(Product product)
    {
        product.IsPainted = true;
    }

    private void Tested(Product product)
    {
        product.IsTested = true;
    }

    private void Packed(Product product)
    {
        product.IsPacked = true;
    }
}