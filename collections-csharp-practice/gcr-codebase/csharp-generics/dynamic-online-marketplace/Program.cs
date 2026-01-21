class Program
{
    static void Main()
    {
        Category bookCategory = new Category("Book");
        Category clothingCategory = new Category("Clothing");

        Product book = new Product("C# Basics", 700, bookCategory);
        Product shirt = new Product("T-Shirt", 500, clothingCategory);

        book.ApplyDiscount(10);
        shirt.ApplyDiscount(20);

        Catalog catalog = new Catalog();
        catalog.Add(book);
        catalog.Add(shirt);

        catalog.DisplayAll();
    }
}
