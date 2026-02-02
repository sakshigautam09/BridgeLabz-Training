using System;

public class AddressBookMain
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        while (true)
        {
            Console.WriteLine("\n---- MAIN MENU ----");
            Console.WriteLine("1. Create Address Book");
            Console.WriteLine("2. Select Address Book");
            Console.WriteLine("3. Open Selected Address Book Menu");
            Console.WriteLine("0. Exit");

            Console.Write("Enter your choice: ");
            int choice;

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid input. Enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1: AddressBookUtilityImpl.CreateAddressBook(); break;
                case 2: AddressBookUtilityImpl.SelectAddressBook(); break;
                case 3:
                    if (AddressBookUtilityImpl.selectedBook != null)
                        new AddressMenu(AddressBookUtilityImpl.selectedBook).ShowMenu();
                    else
                        Console.WriteLine("Please create or select an address book first.");
                    break;
                case 0: return;
                default: Console.WriteLine("Invalid choice. Try again."); break;
            }
        }
    }
}
