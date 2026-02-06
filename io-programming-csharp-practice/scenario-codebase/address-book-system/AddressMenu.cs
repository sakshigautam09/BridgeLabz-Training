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
            Console.WriteLine("6. Sort Contacts by Name");
            Console.WriteLine("7. Sort Contacts by City");
            Console.WriteLine("8. Sort Contacts by State");
            Console.WriteLine("9. Sort Contacts by Zip");
            Console.WriteLine("10. View Persons by City/State");
            Console.WriteLine("11. Count Persons by City/State");
            Console.WriteLine("12. Search Person Across Address Books by City/State");
            Console.WriteLine("13. Read or Write Contacts to File");
            Console.WriteLine("14. Read/Write Contacts as CSV File");
            Console.WriteLine("15. Read/Write Contacts as JSON File");
            Console.WriteLine("16. Read/Write Contacts from/to JSON Server");

            Console.WriteLine("0. Exit Address Book");

            Console.Write("Enter choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0) break;

            switch (choice)
            {
                case 1: addressBook.AddContact(); break;
                case 2: addressBook.AddMultipleContacts(); break;
                case 3: addressBook.DisplayContacts(); break;
                case 4: addressBook.EditContact(); break;
                case 5: addressBook.DeleteContact(); break;
                case 6: addressBook.SortContactsByName(); break;
                case 7: addressBook.SortContactsByCity(); break;
                case 8: addressBook.SortContactsByState(); break;
                case 9: addressBook.SortContactsByZip(); break;
                case 10: addressBook.ViewPersonsByCityOrState(); break;
                case 11: addressBook.CountPersonsByCityOrState(); break;
                case 12: AddressBookUtilityImpl.SearchPersonAcrossAddressBooks(); break;
                case 13:
                    Console.WriteLine("1. Write Contacts to File");
                    Console.WriteLine("2. Read Contacts from File");
                    Console.Write("Enter choice: ");
                    int fileChoice = Convert.ToInt32(Console.ReadLine());

                    if (fileChoice == 1)
                        addressBook.WriteContactsToFile();
                    else if (fileChoice == 2)
                        addressBook.ReadContactsFromFile();
                    else
                        Console.WriteLine("Invalid choice");
                    break;
                case 14:
                    Console.WriteLine("1. Write Contacts to CSV");
                    Console.WriteLine("2. Read Contacts from CSV");
                    Console.Write("Enter choice: ");
                    int csvChoice = Convert.ToInt32(Console.ReadLine());

                    if (csvChoice == 1)
                        addressBook.WriteContactsToCsv();
                    else if (csvChoice == 2)
                        addressBook.ReadContactsFromCsv();
                    else
                        Console.WriteLine("Invalid choice");
                    break;
                case 15:
                    Console.WriteLine("1. Write Contacts to JSON");
                    Console.WriteLine("2. Read Contacts from JSON");
                    Console.Write("Enter choice: ");
                    int jsonChoice = Convert.ToInt32(Console.ReadLine());

                    if (jsonChoice == 1)
                        addressBook.WriteContactsToJson();
                    else if (jsonChoice == 2)
                        addressBook.ReadContactsFromJson();
                    else
                        Console.WriteLine("Invalid choice");
                    break;
                case 16:
                    Console.WriteLine("Enter JSON server URL: ");
                    string url = Console.ReadLine();
                    Console.WriteLine("1. Write Contacts to Server");
                    Console.WriteLine("2. Read Contacts from Server");
                    Console.Write("Enter choice: ");
                    int serverChoice = Convert.ToInt32(Console.ReadLine());

                    if (serverChoice == 1)
                        await addressBook.WriteContactsToJsonServerAsync(url);
                    else if (serverChoice == 2)
                        await addressBook.ReadContactsFromJsonServerAsync(url);
                    else
                        Console.WriteLine("Invalid choice");
                    break;
                

                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
}
