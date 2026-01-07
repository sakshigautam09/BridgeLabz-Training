using System;

public class NonVegItem : FoodItem, IDiscountable
{
    private double extraCharge;

    public NonVegItem(string itemName, double price, int quantity, double extraCharge)
        : base(itemName, price, quantity)
    {
        this.extraCharge = extraCharge;
    }

    public override double CalculateTotalPrice()
    {
        // Extra charge applied per item
        return (Price + extraCharge) * Quantity;
    }

    public double ApplyDiscount()
    {
        // 5% discount on non-veg items
        return CalculateTotalPrice() * 0.05;
    }

    public string GetDiscountDetails()
    {
        return "Non-Veg Item Discount: 5%";
    }
}
