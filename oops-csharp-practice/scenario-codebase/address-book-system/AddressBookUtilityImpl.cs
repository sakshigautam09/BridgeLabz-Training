using System;

public class AddressBookUtilityImpl : IAddressBook
{
    private Contact[] contacts;
    private int count;

    public AddressBookUtilityImpl()
    {
        Console.Write("Enter Address Book Size: ");
        int size = Convert.ToInt32(Console.ReadLine());

        contacts = new Contact[size];
        count = 0;
    }

    // UC-2 / UC-5 (Single Contact)
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

        contacts[count] = new Contact(
            firstName, lastName, address, city, state, zip, phone, email);

        count++;
        Console.WriteLine("Contact added successfully!");
    }

    // 🔥 NEW — UC-5 (Multiple Contacts)
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

            Console.WriteLine("\nAdding Contact " + (i + 1));
            AddContact();
        }
    }

    public void DisplayContacts()
    {
        if (count == 0)
        {
            Console.WriteLine("No contacts available.");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("\nContact " + (i + 1));
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

    public void EditContact()
    {
        Console.Write("Enter First Name to edit: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name))
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

    public void DeleteContact()
    {
        Console.Write("Enter First Name to delete: ");
        string name = Console.ReadLine();

        for (int i = 0; i < count; i++)
        {
            if (contacts[i].GetFirstName().Equals(name))
            {
                for (int j = i; j < count - 1; j++)
                {
                    contacts[j] = contacts[j + 1];
                }

                contacts[count - 1] = null;
                count--;
                Console.WriteLine("Contact deleted successfully!");
                return;
            }
        }

        Console.WriteLine("Contact not found.");
    }
}
