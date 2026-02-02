using System;
using System.Collections.Generic;

public class AddressBookUtilityImpl : IAddressBook
{
    private List<Contact> contacts;
    private static List<AddressBookUtilityImpl> addressBooks = new List<AddressBookUtilityImpl>();
    private static List<string> bookNames = new List<string>();

    public static AddressBookUtilityImpl selectedBook = null;

    public AddressBookUtilityImpl()
    {
        contacts = new List<Contact>();
    }

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

    public void AddContact()
    {
        try
        {
            Console.Write("First Name: "); string fn = Console.ReadLine();
            Console.Write("Last Name: "); string ln = Console.ReadLine();

            if (FindContactIndex(fn, ln) != -1)
                throw new AddressBookException("Duplicate contact found.");

            Console.Write("Address: "); string addr = Console.ReadLine();
            Console.Write("City: "); string city = Console.ReadLine();
            Console.Write("State: "); string state = Console.ReadLine();
            Console.Write("Zip: "); string zip = Console.ReadLine();
            Console.Write("Phone: "); string phone = Console.ReadLine();
            Console.Write("Email: "); string email = Console.ReadLine();

            contacts.Add(new Contact(fn, ln, addr, city, state, zip, phone, email));
            Console.WriteLine("Contact added.");
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }

    public void AddMultipleContacts()
    {
        try
        {
            Console.Write("How many contacts? ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0) throw new AddressBookException("Number of contacts must be greater than 0.");

            for (int i = 0; i < n; i++)
                AddContact();
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number entered.");
        }
    }

    public void DisplayContacts()
    {
        try
        {
            if (contacts.Count == 0) throw new AddressBookException("No contacts available.");

            foreach (Contact c in contacts)
            {
                Console.WriteLine(c);
                Console.WriteLine("------------------");
            }
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public void EditContact()
    {
        try
        {
            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();
            bool found = false;

            foreach (Contact c in contacts)
            {
                if (c.GetFirstName().Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("New Phone: "); c.SetPhoneNumber(Console.ReadLine());
                    Console.Write("New Email: "); c.SetEmail(Console.ReadLine());
                    Console.WriteLine("Updated.");
                    found = true;
                    break;
                }
            }

            if (!found) throw new AddressBookException("Contact not found.");
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public void DeleteContact()
    {
        try
        {
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();
            int index = FindContactIndex(name, ""); // search only by first name

            if (index == -1) throw new AddressBookException("Contact not found.");
            contacts.RemoveAt(index);
            Console.WriteLine("Deleted.");
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

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

    public static void CreateAddressBook()
    {
        try
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();
            if (bookNames.Contains(name))
                throw new AddressBookException("Address Book already exists.");

            AddressBookUtilityImpl book = new AddressBookUtilityImpl();
            addressBooks.Add(book);
            bookNames.Add(name);
            selectedBook = book;
            Console.WriteLine("Created.");
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    public static void SelectAddressBook()
    {
        try
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();
            int index = bookNames.FindIndex(b => b.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (index == -1) throw new AddressBookException("Address Book not found.");

            selectedBook = addressBooks[index];
            Console.WriteLine("Selected.");
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
