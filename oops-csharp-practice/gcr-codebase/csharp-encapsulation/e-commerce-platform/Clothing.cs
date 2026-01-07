using System;

public class Clothing : Product, ITaxable
{
    private double taxRate;

    public Clothing(int productId, string name, double price, double taxRate)
        : base(productId, name, price)
    {
        this.taxRate = taxRate;
    }

    public override double CalculateDiscount()
    {
        return Price * 0.05;
    }
    public double CalculateTax()
    {
        return Price * taxRate / 100;
    }

    public string GetTaxDetails()
    {
        return "Clothing Tax Rate: " + taxRate + "%";
    }
}
