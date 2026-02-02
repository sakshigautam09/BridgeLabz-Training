using System;
using System.Collections.Generic;

public class AddressBookUtilityImpl : IAddressBook
{
    // ---------- GENERIC LISTS ----------
    private List<Contact> contacts; // replaces ArrayList

    // Multiple address books
    private static List<AddressBookUtilityImpl> addressBooks = new List<AddressBookUtilityImpl>();
    private static List<string> bookNames = new List<string>();

    public static AddressBookUtilityImpl selectedBook = null;

    public AddressBookUtilityImpl()
    {
        contacts = new List<Contact>();
    }

    // ---------- SEARCH ----------
    private int FindContactIndex(string firstName, string lastName)
    {
        for (int i = 0; i < contacts.Count; i++)
        {
            Contact c = contacts[i];
            if (c.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                c.GetLastName().Equals(lastName, StringComparison.OrdinalIgnoreCase))
            {
                return i;
            }
        }
        return -1;
    }

    // ---------- ADD ----------
    public void AddContact()
    {
        Console.Write("First Name: ");
        string fn = Console.ReadLine();
        Console.Write("Last Name: ");
        string ln = Console.ReadLine();

        if (FindContactIndex(fn, ln) != -1)
        {
            Console.WriteLine("Duplicate contact found.");
            return;
        }

        Console.Write("Address: "); string addr = Console.ReadLine();
        Console.Write("City: "); string city = Console.ReadLine();
        Console.Write("State: "); string state = Console.ReadLine();
        Console.Write("Zip: "); string zip = Console.ReadLine();
        Console.Write("Phone: "); string phone = Console.ReadLine();
        Console.Write("Email: "); string email = Console.ReadLine();

        contacts.Add(new Contact(fn, ln, addr, city, state, zip, phone, email));
        Console.WriteLine("Contact added.");
    }

    public void AddMultipleContacts()
    {
        Console.Write("How many contacts? ");
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
            AddContact();
    }

    // ---------- DISPLAY ----------
    public void DisplayContacts()
    {
        foreach (Contact c in contacts)
        {
            Console.WriteLine(c);
            Console.WriteLine("------------------");
        }
    }

    // ---------- EDIT ----------
    public void EditContact()
    {
        Console.Write("Enter First Name: ");
        string name = Console.ReadLine();

        foreach (Contact c in contacts)
        {
            if (c.GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                Console.Write("New Phone: "); c.SetPhoneNumber(Console.ReadLine());
                Console.Write("New Email: "); c.SetEmail(Console.ReadLine());
                Console.WriteLine("Updated.");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // ---------- DELETE ----------
    public void DeleteContact()
    {
        Console.Write("Enter First Name: ");
        string name = Console.ReadLine();

        for (int i = 0; i < contacts.Count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                contacts.RemoveAt(i);
                Console.WriteLine("Deleted.");
                return;
            }
        }
        Console.WriteLine("Contact not found.");
    }

    // ---------- SORT ----------
    private void BubbleSort(Func<Contact, string> key)
    {
        for (int i = 0; i < contacts.Count - 1; i++)
        {
            for (int j = 0; j < contacts.Count - i - 1; j++)
            {
                if (string.Compare(key(contacts[j]), key(contacts[j + 1]), StringComparison.OrdinalIgnoreCase) > 0)
                {
                    Contact temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
            }
        }
    }

    public void SortContactsByName() { BubbleSort(c => c.GetFirstName()); DisplayContacts(); }
    public void SortContactsByCity() { BubbleSort(c => c.GetCity()); DisplayContacts(); }
    public void SortContactsByState() { BubbleSort(c => c.GetState()); DisplayContacts(); }
    public void SortContactsByZip() { BubbleSort(c => c.GetZip()); DisplayContacts(); }

    // ---------- MULTIPLE BOOKS ----------
    public static void CreateAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();
        if (bookNames.Contains(name))
        {
            Console.WriteLine("Already exists.");
            return;
        }

        AddressBookUtilityImpl book = new AddressBookUtilityImpl();
        addressBooks.Add(book);
        bookNames.Add(name);
        selectedBook = book;
        Console.WriteLine("Created.");
    }

    public static void SelectAddressBook()
    {
        Console.Write("Enter Address Book Name: ");
        string name = Console.ReadLine();
        for (int i = 0; i < bookNames.Count; i++)
        {
            if (bookNames[i].Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                selectedBook = addressBooks[i];
                Console.WriteLine("Selected.");
                return;
            }
        }
        Console.WriteLine("Not found.");
    }
}
