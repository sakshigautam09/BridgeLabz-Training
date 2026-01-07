using System;
public class VegItem : FoodItem, IDiscountable
{
    public VegItem(string itemName, double price, int quantity)
        : base(itemName, price, quantity)
    {
    }

    public override double CalculateTotalPrice()
    {
        // No extra charges for veg items
        return Price * Quantity;
    }

    public double ApplyDiscount()
    {
        // 10% discount on veg items
        return CalculateTotalPrice() * 0.10;
    }

    public string GetDiscountDetails()
    {
        return "Veg Item Discount: 10%";
    }
}
