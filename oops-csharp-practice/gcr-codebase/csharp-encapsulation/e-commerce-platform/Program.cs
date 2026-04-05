using System;
class Program
{
    static void Main()
    {
        Product[] products = new Product[5];

        Electronics p1 = new Electronics(101, "Laptop", 50000, 18);
        Clothing p2 = new Clothing(102, "Jeans", 2000, 12);
        Groceries p3 = new Groceries(103, "Rice", 1500);
        Electronics p4 = new Electronics(104, "Smartphone", 30000, 18);
        Clothing p5 = new Clothing(105, "Shirt", 1000, 12);

        products[0] = p1;
        products[1] = p2;
        products[2] = p3;
        products[3] = p4;
        products[4] = p5;

        Console.WriteLine("=== Product Final Prices ===");
        for (int i = 0; i < products.Length; i++)
        {
            products[i].DisplayDetails();
            double discount = products[i].CalculateDiscount();
            double tax = 0;

            ITaxable taxableProduct = products[i] as ITaxable;
            if (taxableProduct != null)
            {
                tax = taxableProduct.CalculateTax();
                Console.WriteLine(taxableProduct.GetTaxDetails());
            }

            double finalPrice = products[i].Price + tax - discount;
            Console.WriteLine("Discount: " + discount);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Final Price: " + finalPrice);
        }
    }
}
