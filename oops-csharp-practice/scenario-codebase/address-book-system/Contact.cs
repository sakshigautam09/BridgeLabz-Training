using System;
public class Contact
{
    // Private fields (encapsulation)
    private string firstName;
    private string lastName;
    private string address;
    private string city;
    private string state;
    private string zip;
    private string phoneNumber;
    private string email;
    // Constructor
    public Contact(string firstName, string lastName, string address, string city, string state, string zip,
        string phoneNumber, string email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.city = city;
        this.state = state;
        this.zip = zip;
        this.phoneNumber = phoneNumber;
        this.email = email;
    }
    // Getter methods
    public string GetFirstName() { return firstName; }
    public string GetLastName() {return lastName; }
    public string GetAddress() { return address; }
    public string GetCity() { return city; }
    public string GetState() { return state; }
    public string GetZip() { return zip; }
    public string GetPhoneNumber() { return phoneNumber; }
    public string GetEmail() { return email; }
}