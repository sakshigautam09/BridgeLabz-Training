using System;

public class AddressBookUtilityImpl : IAddressBook
{
    private Contact[] contacts;  // Array of contacts in this book
    private int count;           // Current number of contacts

    // Arrays to manage multiple address books
    private static AddressBookUtilityImpl[] addressBooksArray = new AddressBookUtilityImpl[10];
    private static string[] addressBookNames = new string[10];
    private static int bookCount = 0;
    public static AddressBookUtilityImpl selectedBook = null;

    // Constructor: Initialize contacts array for a new book
    public AddressBookUtilityImpl()
    {
        Console.Write("Enter Address Book Size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        contacts = new Contact[size];
        count = 0;
    }

    // UC-2 / UC-5 / UC-7: Add single contact with duplicate check
    public void AddContact()
    {
        if (count >= contacts.Length)
        {
            Console.WriteLine("Address Book is full.");
            return;
        }

        Console.WriteLine("\nEnter Contact Details:");
        Console.Write("First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last Name: ");
        string lastName = Console.ReadLine();

        // 🔹 UC-7: Check for duplicate in this address book
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase)
                && contacts[i].GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Duplicate contact! Person already exists in this address book.");
                return; // Stop adding
            }
        }

        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State: ");
        string state = Console.ReadLine();
        Console.Write("Zip: ");
        string zip = Console.ReadLine();
        Console.Write("Phone Number: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        contacts[count] = new Contact(firstName, lastName, address, city, state, zip, phone, email);
        count++;
        Console.WriteLine("Contact added successfully!");
    }

    // UC-5: Add multiple contacts
    public void AddMultipleContacts()
    {
        Console.Write("How many contacts do you want to add? ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            if (count >= contacts.Length)
            {
                Console.WriteLine("Address Book is full.");
                return;
            }

            Console.WriteLine($"\nAdding Contact {i + 1}");
            AddContact();  // Duplicate check runs inside AddContact
        }
    }

    // Display all contacts
    public void DisplayContacts()
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nContact {i + 1}:");
            Console.WriteLine("First Name: " + contacts[i].GetFirstName());
            Console.WriteLine("Last Name: " + contacts[i].GetLastName());
            Console.WriteLine("Address: " + contacts[i].GetAddress());
            Console.WriteLine("City: " + contacts[i].GetCity());
            Console.WriteLine("State: " + contacts[i].GetState());
            Console.WriteLine("Zip: " + contacts[i].GetZip());
            Console.WriteLine("Phone: " + contacts[i].GetPhoneNumber());
            Console.WriteLine("Email: " + contacts[i].GetEmail());
        }
    }

    // Edit a contact
    public void EditContact()
    {
        Console.Write("Enter First Name to edit: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("Enter new Phone Number: ");
                contacts[i].SetPhoneNumber(Console.ReadLine());

                Console.Write("Enter new Email: ");
                contacts[i].SetEmail(Console.ReadLine());

                Console.WriteLine("Contact updated successfully!");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // Delete a contact
    public void DeleteContact()
    {
        Console.Write("Enter First Name to delete: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < count - 1; j++)
                    contacts[j] = contacts[j + 1];

                contacts[count - 1] = null;
                count--;
                Console.WriteLine("Contact deleted successfully!");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // UC-6: Create a new address book (arrays only)
    public static void CreateAddressBook()
    {
        if (bookCount >= addressBooksArray.Length)
        {
            Console.WriteLine("Maximum address books reached!");
            return;
        }

        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        // Check if a book with same name exists
        for (int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Address Book already exists!");
                return;
            }
        }

        AddressBookUtilityImpl book = new AddressBookUtilityImpl();
        addressBooksArray[bookCount] = book;
        addressBookNames[bookCount] = name;
        selectedBook = book;
        bookCount++;

        Console.WriteLine("Address Book created successfully!");
    }

    // UC-6: Select an existing address book
    public static void SelectAddressBook()
    {
        Console.Write("Enter Address Book Name to select: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
        {
            if (addressBookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                selectedBook = addressBooksArray[i];
                Console.WriteLine("Address Book selected: " + name);
                return;
            }
        }

        Console.WriteLine("Address Book not found.");
    }
    // UC-8: Search person in all address books by city
    public static void SearchByCity()
    {
        Console.Write("Enter City to search: ");
        string city = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtilityImpl book = addressBooksArray[i];
            for (int j = 0; j < book.count; j++)
            {
                if (book.contacts[j].GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\nFound in Address Book: {addressBookNames[i]}");
                    Console.WriteLine("First Name: " + book.contacts[j].GetFirstName());
                    Console.WriteLine("Last Name: " + book.contacts[j].GetLastName());
                    Console.WriteLine("Address: " + book.contacts[j].GetAddress());
                    Console.WriteLine("Phone: " + book.contacts[j].GetPhoneNumber());
                    found = true;
                }
            }
        }

        if (!found)
            Console.WriteLine("No contacts found in city: " + city);
    }

    // UC-8: Search person in all address books by state
    public static void SearchByState()
    {
        Console.Write("Enter State to search: ");
        string state = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtilityImpl book = addressBooksArray[i];
            for (int j = 0; j < book.count; j++)
            {
                if (book.contacts[j].GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\nFound in Address Book: {addressBookNames[i]}");
                    Console.WriteLine("First Name: " + book.contacts[j].GetFirstName());
                    Console.WriteLine("Last Name: " + book.contacts[j].GetLastName());
                    Console.WriteLine("Address: " + book.contacts[j].GetAddress());
                    Console.WriteLine("Phone: " + book.contacts[j].GetPhoneNumber());
                    found = true;
                }
            }
        }

        if (!found)
            Console.WriteLine("No contacts found in state: " + state);
    }

    // UC-9: View persons by City across all address books
    public static void ViewPersonsByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtilityImpl book = addressBooksArray[i];

            for (int j = 0; j < book.count; j++)
            {
                if (book.contacts[j].GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nAddress Book: " + addressBookNames[i]);
                    Console.WriteLine("Name: " + book.contacts[j].GetFirstName() + " " +
                                    book.contacts[j].GetLastName());
                    Console.WriteLine("City: " + book.contacts[j].GetCity());
                    Console.WriteLine("State: " + book.contacts[j].GetState());
                    Console.WriteLine("Phone: " + book.contacts[j].GetPhoneNumber());
                    found = true;
                }
            }
        }

        if (!found)
            Console.WriteLine("No persons found in city: " + city);
    }
    // UC-9: View persons by State across all address books
    public static void ViewPersonsByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtilityImpl book = addressBooksArray[i];

            for (int j = 0; j < book.count; j++)
            {
                if (book.contacts[j].GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\nAddress Book: " + addressBookNames[i]);
                    Console.WriteLine("Name: " + book.contacts[j].GetFirstName() + " " +
                                    book.contacts[j].GetLastName());
                    Console.WriteLine("City: " + book.contacts[j].GetCity());
                    Console.WriteLine("State: " + book.contacts[j].GetState());
                    Console.WriteLine("Phone: " + book.contacts[j].GetPhoneNumber());
                    found = true;
                }
            }
        }

        if (!found)
            Console.WriteLine("No persons found in state: " + state);
    }
    // UC-10: Count contacts by City across all address books
    public static void CountByCity()
    {
        Console.Write("Enter City: ");
        string city = Console.ReadLine();
        int totalCount = 0;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtilityImpl book = addressBooksArray[i];

            for (int j = 0; j < book.count; j++)
            {
                if (book.contacts[j].GetCity().Equals(city, StringComparison.OrdinalIgnoreCase))
                {
                    totalCount++;
                }
            }
        }

        Console.WriteLine("Total number of contacts in city '" + city + "' = " + totalCount);
    }
    // UC-10: Count contacts by State across all address books
    public static void CountByState()
    {
        Console.Write("Enter State: ");
        string state = Console.ReadLine();
        int totalCount = 0;

        for (int i = 0; i < bookCount; i++)
        {
            AddressBookUtilityImpl book = addressBooksArray[i];

            for (int j = 0; j < book.count; j++)
            {
                if (book.contacts[j].GetState().Equals(state, StringComparison.OrdinalIgnoreCase))
                {
                    totalCount++;
                }
            }
        }

        Console.WriteLine("Total number of contacts in state '" + state + "' = " + totalCount);
    }
    // UC-11: Sort contacts alphabetically by Person's name
    public void SortContactsByName()
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts to sort.");
            return;
        }

        // Bubble Sort (arrays only)
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                int firstNameCompare = string.Compare(
                    contacts[j].GetFirstName(),
                    contacts[j + 1].GetFirstName(),
                    StringComparison.OrdinalIgnoreCase);

                if (firstNameCompare > 0 ||
                (firstNameCompare == 0 &&
                    string.Compare(
                        contacts[j].GetLastName(),
                        contacts[j + 1].GetLastName(),
                        StringComparison.OrdinalIgnoreCase) > 0))
                {
                    // Swap
                    Contact temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nContacts sorted alphabetically by name:\n");

        // Print using ToString()
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(contacts[i]);
            Console.WriteLine("-----------------------");
        }
    }
}
