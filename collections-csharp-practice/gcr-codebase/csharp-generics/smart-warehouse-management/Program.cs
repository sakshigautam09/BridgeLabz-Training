using System;

class Program
{
    static void Main()
    {
        Storage<Electronics> electronicsStorage = new Storage<Electronics>();
        electronicsStorage.AddItem(new Electronics("Laptop", "Dell", 10));
        electronicsStorage.AddItem(new Electronics("Phone", "Samsung", 20));

        Storage<Groceries> groceryStorage = new Storage<Groceries>();
        groceryStorage.AddItem(new Groceries("Milk", DateTime.Now.AddDays(5), 30));
        groceryStorage.AddItem(new Groceries("Bread", DateTime.Now.AddDays(2), 15));

        Storage<Furniture> furnitureStorage = new Storage<Furniture>();
        furnitureStorage.AddItem(new Furniture("Chair", "Wood", 25));
        furnitureStorage.AddItem(new Furniture("Table", "Metal", 10));

        electronicsStorage.DisplayAllItems();
        groceryStorage.DisplayAllItems();
        furnitureStorage.DisplayAllItems();
    }
}
