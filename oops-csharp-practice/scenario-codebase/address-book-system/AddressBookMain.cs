using System;
public class AddressBookMain
{
    static void Main()
    {
        // UC-0: Welcome message
        Console.WriteLine("Welcome to Address Book Program");

        // UC-1: Create Contact object
        Console.WriteLine("UC-1: Creating Contact");

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
        Console.WriteLine("\nContact Created Successfully!");

        Console.WriteLine("Contact Details:");
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
