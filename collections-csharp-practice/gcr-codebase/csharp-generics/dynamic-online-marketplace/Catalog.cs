using System.Collections.Generic;

public class Catalog
{
    private List<Product> products = new List<Product>();

    public void Add(Product product)
    {
        products.Add(product);
    }

    public void DisplayAll()
    {
        foreach (var product in products)
        {
            product.Display();
        }
    }
}
