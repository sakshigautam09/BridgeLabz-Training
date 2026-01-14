using System;
// UC-1 (encapsulated class creation)
public class Contact
{
    private string firstName;
    private string lastName;
    private string address;
    private string city;
    private string state;
    private string zip;
    private string phoneNumber;
    private string email;

    public Contact(string firstName, string lastName, string address, string city,
                   string state, string zip, string phoneNumber, string email)
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

    // Getters
    public string GetFirstName() { return firstName; }
    public string GetLastName() { return lastName; }
    public string GetAddress() { return address; }
    public string GetCity() { return city; }
    public string GetState() { return state; }
    public string GetZip() { return zip; }
    public string GetPhoneNumber() { return phoneNumber; }
    public string GetEmail() { return email; }

    // Setters
    public void SetFirstName(string value) { firstName = value; }
    public void SetLastName(string value) { lastName = value; }
    public void SetAddress(string value) { address = value; }
    public void SetCity(string value) { city = value; }
    public void SetState(string value) { state = value; }
    public void SetZip(string value) { zip = value; }
    public void SetPhoneNumber(string value) { phoneNumber = value; }
    public void SetEmail(string value) { email = value; }
}
