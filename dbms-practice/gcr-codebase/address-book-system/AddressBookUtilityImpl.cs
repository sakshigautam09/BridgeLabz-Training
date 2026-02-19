using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class AddressBookUtilityImpl : IAddressBook
{
    internal List<Contact> contacts;
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
                return i;
        }
        return -1;
    }

    // ------------------- CRUD -------------------
    // ------------------- CRUD -------------------
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
            int index = FindContactIndex(name, "");

            if (index == -1) throw new AddressBookException("Contact not found.");
            contacts.RemoveAt(index);
            Console.WriteLine("Deleted.");
        }
        catch (AddressBookException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    // ------------------- SORT -------------------
    private void BubbleSort(Func<Contact, string> key)
    {
        for (int i = 0; i < contacts.Count - 1; i++)
            for (int j = 0; j < contacts.Count - i - 1; j++)
                if (string.Compare(key(contacts[j]), key(contacts[j + 1]), StringComparison.OrdinalIgnoreCase) > 0)
                {
                    Contact temp = contacts[j];
                    contacts[j] = contacts[j + 1];
                    contacts[j + 1] = temp;
                }
    }

    public void SortContactsByName() { BubbleSort(c => c.GetFirstName()); DisplayContacts(); }
    public void SortContactsByCity() { BubbleSort(c => c.GetCity()); DisplayContacts(); }
    public void SortContactsByState() { BubbleSort(c => c.GetState()); DisplayContacts(); }
    public void SortContactsByZip() { BubbleSort(c => c.GetZip()); DisplayContacts(); }

     // ------------------- ADDRESS BOOK MANAGEMENT -------------------
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

    // ------------------- SEARCH/VIEW/COUNT -------------------
    public void ViewPersonsByCityOrState()
    {
        Console.Write("Enter City or State to view persons: ");
        string location = Console.ReadLine();
        var filtered = contacts.FindAll(c => c.GetCity().Equals(location, StringComparison.OrdinalIgnoreCase) ||
                                             c.GetState().Equals(location, StringComparison.OrdinalIgnoreCase));
        if (filtered.Count == 0)
            Console.WriteLine("No persons found for " + location);
        else
        {
            foreach (var c in filtered)
            {
                Console.WriteLine(c);
                Console.WriteLine("------------------");
            }
        }
    }

    public void CountPersonsByCityOrState()
    {
        Console.Write("Enter City or State to count persons: ");
        string location = Console.ReadLine();
        int count = contacts.FindAll(c => c.GetCity().Equals(location, StringComparison.OrdinalIgnoreCase) ||
                                          c.GetState().Equals(location, StringComparison.OrdinalIgnoreCase)).Count;
        Console.WriteLine("Number of persons in " + location + ": " + count);
    }

    public static void SearchPersonAcrossAddressBooks()
    {
        Console.Write("Enter City or State to search across all Address Books: ");
        string location = Console.ReadLine();
        int totalCount = 0;

        for (int i = 0; i < addressBooks.Count; i++)
        {
            var filtered = addressBooks[i].contacts.FindAll(c => c.GetCity().Equals(location, StringComparison.OrdinalIgnoreCase) ||
                                                                 c.GetState().Equals(location, StringComparison.OrdinalIgnoreCase));
            totalCount += filtered.Count;
            if (filtered.Count > 0)
            {
                Console.WriteLine("\nAddress Book: " + i);
                foreach (var c in filtered)
                {
                    Console.WriteLine(c);
                    Console.WriteLine("------------------");
                }
            }
        }

        Console.WriteLine("Total persons found across all address books in " + location + ": " + totalCount);
    }

    // ============================================================
    // UC-17 NON-BLOCKING IO IMPLEMENTATION
    // ============================================================

    // ------------------- FILE IO ASYNC -------------------
    public async Task WriteContactsToFileAsync()
    {
        Console.Write("Enter file path to save contacts: ");
        string path = Console.ReadLine();

        await Task.Run(() =>
        {
            using StreamWriter writer = new StreamWriter(path);
            foreach (var c in contacts)
            {
                writer.WriteLine($"{c.GetFirstName()}|{c.GetLastName()}|{c.GetAddress()}|{c.GetCity()}|{c.GetState()}|{c.GetZip()}|{c.GetPhoneNumber()}|{c.GetEmail()}");
            }
        });

        Console.WriteLine("Contacts written asynchronously.");
    }

    public async Task ReadContactsFromFileAsync()
    {
        Console.Write("Enter file path: ");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("File not found.");
            return;
        }

        await Task.Run(() =>
        {
            contacts.Clear();
            using StreamReader reader = new StreamReader(path);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split('|');
                if (data.Length == 8)
                    contacts.Add(new Contact(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]));
            }
        });

        Console.WriteLine("Contacts loaded asynchronously.");
    }

    // ------------------- CSV ASYNC -------------------
    public async Task WriteContactsToCsvAsync()
    {
        Console.Write("Enter CSV path: ");
        string path = Console.ReadLine();

        await Task.Run(() =>
        {
            using StreamWriter writer = new StreamWriter(path);
            writer.WriteLine("FirstName,LastName,Address,City,State,Zip,Phone,Email");

            foreach (var c in contacts)
            {
                writer.WriteLine($"{c.GetFirstName()},{c.GetLastName()},{c.GetAddress()},{c.GetCity()},{c.GetState()},{c.GetZip()},{c.GetPhoneNumber()},{c.GetEmail()}");
            }
        });

        Console.WriteLine("CSV written asynchronously.");
    }

    public async Task ReadContactsFromCsvAsync()
    {
        Console.Write("Enter CSV path: ");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("CSV not found.");
            return;
        }

        await Task.Run(() =>
        {
            contacts.Clear();
            using StreamReader reader = new StreamReader(path);
            reader.ReadLine();

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] data = line.Split(',');
                if (data.Length == 8)
                    contacts.Add(new Contact(data[0], data[1], data[2], data[3], data[4], data[5], data[6], data[7]));
            }
        });

        Console.WriteLine("CSV loaded asynchronously.");
    }

    // ------------------- JSON FILE ASYNC -------------------
    public async Task WriteContactsToJsonAsync()
    {
        Console.Write("Enter JSON path: ");
        string path = Console.ReadLine();

        await Task.Run(() =>
        {
            string json = JsonSerializer.Serialize(contacts, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        });

        Console.WriteLine("JSON saved asynchronously.");
    }

    public async Task ReadContactsFromJsonAsync()
    {
        Console.Write("Enter JSON path: ");
        string path = Console.ReadLine();

        if (!File.Exists(path))
        {
            Console.WriteLine("JSON file not found.");
            return;
        }

        await Task.Run(() =>
        {
            string json = File.ReadAllText(path);
            contacts = JsonSerializer.Deserialize<List<Contact>>(json);
        });

        Console.WriteLine("JSON loaded asynchronously.");
    }

    public async Task WriteContactsToJsonServerAsync(string serverUrl)
    {
        using HttpClient client = new HttpClient();
        await client.PostAsJsonAsync(serverUrl, contacts);
        Console.WriteLine("Sent to server asynchronously.");
    }

    public async Task ReadContactsFromJsonServerAsync(string serverUrl)
    {
        using HttpClient client = new HttpClient();
        contacts = await client.GetFromJsonAsync<List<Contact>>(serverUrl);
        Console.WriteLine("Fetched from server asynchronously.");
    }
    // ------------------- UC-18 DATABASE (OCP) -------------------

    public async Task SaveContactsToDatabaseAsync(string bookName)
    {
        IDataSource dbSource = new DatabaseDataSource();
        await dbSource.SaveAsync(contacts, bookName);
    }

    public async Task LoadContactsFromDatabaseAsync(string bookName)
    {
        IDataSource dbSource = new DatabaseDataSource();
        contacts = await dbSource.LoadAsync(bookName);
    }


    //for testing
    // ========================= MANUAL METHODS FOR TESTING =========================
    // ========================= MANUAL METHODS FOR TESTING =========================
    public void AddContactManually(Contact c)
    {
        if (FindContactIndex(c.GetFirstName(), c.GetLastName()) != -1)
            throw new AddressBookException("Duplicate contact found.");

        contacts.Add(c);
    }

    public List<Contact> GetAllContacts()
    {
        return new List<Contact>(contacts);
    }

    public bool EditContactManually(string firstName, string newPhone = null, string newEmail = null)
    {
        var contact = contacts.Find(c => c.GetFirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase));
        if (contact == null)
            throw new AddressBookException("Contact not found.");

        if (newPhone != null) contact.SetPhoneNumber(newPhone);
        if (newEmail != null) contact.SetEmail(newEmail);
        return true;
    }

    public bool DeleteContactManually(string firstName, string lastName)
    {
        int index = FindContactIndex(firstName, lastName);
        if (index == -1)
            throw new AddressBookException("Contact not found.");

        contacts.RemoveAt(index);
        return true;
    }

    public List<Contact> ViewPersonsByCityOrStateManually(string location)
    {
        return contacts.FindAll(c => c.GetCity().Equals(location, StringComparison.OrdinalIgnoreCase) ||
                                    c.GetState().Equals(location, StringComparison.OrdinalIgnoreCase));
    }

    public int CountPersonsByCityOrStateManually(string location)
    {
        return contacts.FindAll(c => c.GetCity().Equals(location, StringComparison.OrdinalIgnoreCase) ||
                                    c.GetState().Equals(location, StringComparison.OrdinalIgnoreCase)).Count;
    }

    public void SortContactsByNameManually()
    {
        BubbleSort(c => c.GetFirstName());
    }


}
