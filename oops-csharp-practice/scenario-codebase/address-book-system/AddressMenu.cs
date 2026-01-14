using System;

public class AddressMenu
{
    private IAddressBook addressBookUtility;
    private Contact contact;

    public AddressMenu()
    {
        addressBookUtility = new AddressBookUtilityImpl();
    }

    public void ShowMenu()
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\n=== Address Book Menu ===");
            Console.WriteLine("1. Add Contact");
            Console.WriteLine("2. Display Contact");
            Console.WriteLine("3. Edit Contact");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    contact = addressBookUtility.AddContact();
                    break;

                case "2":
                    if (contact != null)
                        addressBookUtility.DisplayContact(contact);
                    else
                        Console.WriteLine("No contact available.");
                    break;

                case "3":
                    addressBookUtility.EditContact(contact);
                    break;

                case "4":
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
