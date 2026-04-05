using System;

public class AddressBookUtilityImpl : IAddressBook
{
    // ---------- DSA: ARRAY STORAGE ----------
    private Contact[] contacts;
    private int count;

    // ---------- MULTIPLE ADDRESS BOOKS (ARRAYS) ----------
    private static AddressBookUtilityImpl[] addressBooks = new AddressBookUtilityImpl[10];
    private static string[] bookNames = new string[10];
    private static int bookCount = 0;

    public static AddressBookUtilityImpl selectedBook = null;

    public AddressBookUtilityImpl()
    {
        Console.Write("Enter Address Book Size: ");
        int size = Convert.ToInt32(Console.ReadLine());
        contacts = new Contact[size];
        count = 0;
    }

    // ---------- UC-2 / UC-7 : LINEAR SEARCH ----------
    private int FindContactIndex(string firstName, string lastName)
    {
        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                contacts[i].GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                return i; // FOUND
            }
        }
        return -1; // NOT FOUND
    }

    public void AddContact()
    {
        if (count >= contacts.Length)
        {
            Console.WriteLine("Address Book is full.");
            return;
        }

        Console.Write("First Name: ");
        string fn = Console.ReadLine();
        Console.Write("Last Name: ");
        string ln = Console.ReadLine();

        if (FindContactIndex(fn, ln) != -1)
        {
            Console.WriteLine("Duplicate contact found.");
            return;
        }

        Console.Write("Address: ");
        string address = Console.ReadLine();
        Console.Write("City: ");
        string city = Console.ReadLine();
        Console.Write("State: ");
        string state = Console.ReadLine();
        Console.Write("Zip: ");
        string zip = Console.ReadLine();
        Console.Write("Phone: ");
        string phone = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        contacts[count++] = new Contact(fn, ln, address, city, state, zip, phone, email);
        Console.WriteLine("Contact added.");
    }

    public void AddMultipleContacts()
    {
        Console.Write("How many contacts? ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
            AddContact();
    }

    // ---------- ARRAY TRAVERSAL ----------
    public void DisplayContacts()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(contacts[i]);
            Console.WriteLine("------------------");
        }
    }

    public void EditContact()
    {
        Console.Write("Enter First Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("New Phone: ");
                contacts[i].SetPhoneNumber(Console.ReadLine());
                Console.Write("New Email: ");
                contacts[i].SetEmail(Console.ReadLine());
                Console.WriteLine("Updated.");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // ---------- ARRAY SHIFT (DELETE) ----------
    public void DeleteContact()
    {
        Console.Write("Enter First Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                for (int j = i; j < count - 1; j++)
                    contacts[j] = contacts[j + 1];

                contacts[--count] = null;
                Console.WriteLine("Deleted.");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // ---------- BUBBLE SORT (DSA) ----------
    private void BubbleSort(Func<Contact, string> key)
    {
        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (string.Compare(
                        key(contacts[j]),
                        key(contacts[j + 1]),
                        StringComparison.OrdinalIgnoreCase) > 0)
                {
                    Contact temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }
    }

    public void SortContactsByName()
    {
        BubbleSort(c => c.GetFirstName());
        DisplayContacts();
    }

    public void SortContactsByCity()
    {
        BubbleSort(c => c.GetCity());
        DisplayContacts();
    }

    public void SortContactsByState()
    {
        BubbleSort(c => c.GetState());
        DisplayContacts();
    }

    public void SortContactsByZip()
    {
        BubbleSort(c => c.GetZip());
        DisplayContacts();
    }

    // ---------- MULTI BOOK OPS (ARRAYS) ----------
    public static void CreateAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
            if (bookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Already exists.");
                return;
            }

        AddressBookUtilityImpl book = new AddressBookUtilityImpl();
        addressBooks[bookCount] = book;
        bookNames[bookCount] = name;
        selectedBook = book;
        bookCount++;

        Console.WriteLine("Address Book created.");
    }

    public static void SelectAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < bookCount; i++)
            if (bookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                selectedBook = addressBooks[i];
                Console.WriteLine("Selected.");
                return;
            }

        Console.WriteLine("Not found.");
    }
}
