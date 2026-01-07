using System;

public class Electronics : Product, ITaxable
{
    private double taxRate;

    public Electronics(int productId, string name, double price, double taxRate)
        : base(productId, name, price)
    {
        this.taxRate = taxRate;
    }

    public override double CalculateDiscount()
    {
        return Price * 0.10;
    }

    public double CalculateTax()
    {
        return Price * taxRate / 100;
    }

    public string GetTaxDetails()
    {
        return "Electronics Tax Rate: " + taxRate + "%";
    }
}
