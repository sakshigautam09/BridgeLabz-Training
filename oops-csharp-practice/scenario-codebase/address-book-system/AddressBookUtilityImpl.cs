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

    // UC-2 / UC-5: Add single contact
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
            AddContact();  // No duplicate check
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
}