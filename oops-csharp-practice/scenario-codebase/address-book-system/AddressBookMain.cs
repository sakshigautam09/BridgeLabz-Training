using System;
public class AddressBookMain
{
    static void Main()
    {
        // UC-0
        Console.WriteLine("Welcome to Address Book Program");

        // menu object creation
        AddressBookUtilityImpl addressBook = new AddressBookUtilityImpl();
        AddressMenu menu = new AddressMenu(addressBook);
        menu.ShowMenu();
    }
}
