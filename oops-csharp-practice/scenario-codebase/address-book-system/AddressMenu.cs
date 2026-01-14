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
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
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
                        Console.WriteLine("No contact available. Add first.");
                    break;

                case "3":
                    exit = true;
                    Console.WriteLine("Exiting Address Book. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}
