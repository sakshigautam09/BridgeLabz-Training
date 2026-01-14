using System;
public class AddressBookMain
{
    static void Main()
    {
        // UC-0
        Console.WriteLine("Welcome to Address Book Program");

        // menu object creation
        AddressMenu menu = new AddressMenu();
        menu.ShowMenu();
    }
}
