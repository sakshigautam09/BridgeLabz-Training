class Program
{
    static void Main()
    {
        Console.Write("Enter number of products: ");
        int n = int.Parse(Console.ReadLine());

        Product[] products = new Product[n];

        Console.WriteLine("Enter Product ID and Discount:");

        for (int i = 0; i < n; i++)
        {
            Console.Write("Product ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Discount (%): ");
            int discount = int.Parse(Console.ReadLine());

            products[i] = new Product(id, discount);
        }

        QuickSort quickSort = new QuickSort(products);
        quickSort.SortByDiscountDescending();

        Console.WriteLine("\nTop Discounted Products:");
        quickSort.Display();
    }
}
