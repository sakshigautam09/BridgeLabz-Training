using System;
class AddressBookMain
{
    static void Main(string[] args)
    {
        // UC-0: Welcome message
        Console.WriteLine("Welcome to Address Book Program\n");
        // UC-1: Create a Contact using encapsulated class
        Console.WriteLine("UC-1: Create Contact\n");
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        Console.Write("Enter Address: ");
        string address = Console.ReadLine();
        Console.Write("Enter City: ");
        string city = Console.ReadLine();
        Console.Write("Enter State: ");
        string state = Console.ReadLine();
        Console.Write("Enter Zip: ");
        string zip = Console.ReadLine();
        Console.Write("Enter Phone Number: ");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        // Create Contact object (UC-1)
        Contact contact = new Contact(firstName, lastName, address, city, state, zip, phoneNumber, email);
        Console.WriteLine("\nContact Created Successfully:");
        Console.WriteLine(contact.GetFirstName() + " " + contact.GetLastName() + ", " + contact.GetCity() + ", " +
        contact.GetState() + ", " + contact.GetPhoneNumber() + ", " + contact.GetEmail());
    }
}