using System;

public class AddressMenu
{
    private IAddressBook addressBook;

    public AddressMenu()
    {
        addressBook = new AddressBookUtilityImpl();
    }

    public void ShowMenu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Address Book Menu ===");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contacts");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Delete Contact");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    addressBook.AddContact();
                    break;

                case "2":
                    addressBook.DisplayContacts();
                    break;

                case "3":
                    addressBook.EditContact();
                    break;

                case "4":
                    addressBook.DeleteContact();
                    break;

                case "5":
                    exit = true;
                    Console.WriteLine("Exiting Address Book...");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
