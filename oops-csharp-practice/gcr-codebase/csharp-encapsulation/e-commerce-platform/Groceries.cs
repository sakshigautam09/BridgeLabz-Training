using System;

public class Groceries : Product
{
    public Groceries(int productId, string name, double price)
        : base(productId, name, price)
    {
    }

    public override double CalculateDiscount()
    {
        // Groceries: flat 2% discount
        return Price * 0.02;
    }

    // No tax applied, so no ITaxable implementation
}
