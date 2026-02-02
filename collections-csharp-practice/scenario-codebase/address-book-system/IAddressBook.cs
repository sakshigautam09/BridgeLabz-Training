public interface IAddressBook
{
    void AddContact();               // Add single contact
    void AddMultipleContacts();      // Add multiple contacts
    void DisplayContacts();          // Display all contacts
    void EditContact();              // Edit a contact
    void DeleteContact();            // Delete a contact

    // Sorting methods
    void SortContactsByName();
    void SortContactsByCity();
    void SortContactsByState();
    void SortContactsByZip();
}
