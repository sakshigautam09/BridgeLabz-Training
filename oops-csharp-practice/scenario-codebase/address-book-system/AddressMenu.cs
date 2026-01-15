using System;

public class AddressMenu
{
    private AddressBookUtilityImpl addressBook;

    public AddressMenu(AddressBookUtilityImpl addressBook)
    {
        this.addressBook = addressBook;
    }

    public void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\n---- ADDRESS BOOK MENU ----");
            Console.WriteLine("1. Add Single Contact");
            Console.WriteLine("2. Add Multiple Contacts");
            Console.WriteLine("3. Display Contacts");
            Console.WriteLine("4. Edit Contact");
            Console.WriteLine("5. Delete Contact");
            Console.WriteLine("0. Exit Address Book");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
                break;

            switch (choice)
            {
                case 1:
                    addressBook.AddContact();
                    break;

                case 2:
                    addressBook.AddMultipleContacts();
                    break;

                case 3:
                    addressBook.DisplayContacts();
                    break;

                case 4:
                    addressBook.EditContact();
                    break;

                case 5:
                    addressBook.DeleteContact();
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}