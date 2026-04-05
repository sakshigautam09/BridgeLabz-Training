using System;
class Program
{
    static void Main()
    {
        FoodItem[] items = new FoodItem[3];

        VegItem item1 = new VegItem("Paneer Butter Masala", 250, 2);
        NonVegItem item2 = new NonVegItem("Paneer Lababdar", 300, 1, 50);
        VegItem item3 = new VegItem("Veg Fried Rice", 180, 3);

        items[0] = item1;
        items[1] = item2;
        items[2] = item3;

        Console.WriteLine("=== Online Food Delivery System ===\n");

        for (int i = 0; i < items.Length; i++)
        {
            items[i].GetItemDetails();

            double totalPrice = items[i].CalculateTotalPrice();
            Console.WriteLine("Total Price: " + totalPrice);

            IDiscountable discountable = items[i] as IDiscountable;
            if (discountable != null)
            {
                double discount = discountable.ApplyDiscount();
                Console.WriteLine(discountable.GetDiscountDetails());
                Console.WriteLine("Discount Amount: " + discount);
                Console.WriteLine("Final Payable Amount: " + (totalPrice - discount));
            }
        }
    }
}
