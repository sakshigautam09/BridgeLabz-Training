using System;
public class AddressBookUtilityImpl : IAddressBook
{
    public Contact AddContact()
    {
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
        string phoneNumber = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);

        Console.WriteLine("\nContact added successfully!");
        return contact;
    }

    public void DisplayContact(Contact contact)
    {
        Console.WriteLine(
            contact.GetFirstName() + " " +
            contact.GetLastName() + ", " +
            contact.GetAddress() + ", " +
            contact.GetCity() + ", " +
            contact.GetState() + ", " +
            contact.GetPhoneNumber() + ", " +
            contact.GetEmail()
        );
    }
    // UC-3
    public void EditContact(Contact contact)
    {
        Console.Write("\nEnter First Name to Edit Contact: ");
        string name = Console.ReadLine();

        if (contact == null)
        {
            Console.WriteLine("No contact available to edit.");
            return;
        }

        if (contact.GetFirstName().Equals(name))
        {
            Console.WriteLine("\nEditing Contact Details:");

            Console.Write("New Last Name: ");
            contact.SetLastName(Console.ReadLine());

            Console.Write("New Address: ");
            contact.SetAddress(Console.ReadLine());

            Console.Write("New City: ");
            contact.SetCity(Console.ReadLine());

            Console.Write("New State: ");
            contact.SetState(Console.ReadLine());

            Console.Write("New Zip: ");
            contact.SetZip(Console.ReadLine());

            Console.Write("New Phone Number: ");
            contact.SetPhoneNumber(Console.ReadLine());

            Console.Write("New Email: ");
            contact.SetEmail(Console.ReadLine());

            Console.WriteLine("\nContact updated successfully!");
        }
        else
        {
            Console.WriteLine("Contact not found with given name.");
        }
    }
    // UC-4
    public Contact DeleteContact(Contact contact)
    {
        Console.Write("\nEnter First name to delete contact: ");
        string name = Console.ReadLine();

        if (contact == null)
        {
            Console.WriteLine("No contact available to delete.");
            return null;
        }

        if (contact.GetFirstName().Equals(name))
        {
            Console.WriteLine("Contact deleted successfully!");
            return null; // deleting contact
        }

        Console.WriteLine("Contact not found.");
        return contact;
    }
}
