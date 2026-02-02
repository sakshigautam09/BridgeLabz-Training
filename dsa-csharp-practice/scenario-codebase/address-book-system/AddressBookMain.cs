using System;

public class AddressBookMain
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        while (true)
        {
            Console.WriteLine("\n1. Create Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Open Address Book");
            Console.WriteLine("0. Exit");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1: AddressBookUtilityImpl.CreateAddressBook(); break;
                case 2: AddressBookUtilityImpl.SelectAddressBook(); break;
                case 3:
                    if (AddressBookUtilityImpl.selectedBook != null)
                        new AddressMenu(AddressBookUtilityImpl.selectedBook).ShowMenu();
                    else
                        Console.WriteLine("Select a book first.");
                    break;
                case 0: return;
            }
        }
    }
}
