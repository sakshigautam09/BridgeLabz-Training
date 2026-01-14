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
}
