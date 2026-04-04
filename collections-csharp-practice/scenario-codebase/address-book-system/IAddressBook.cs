using System;

[AddressBookMetadata("Contract Interface", "AddressBook Team", "1.0")]
public interface IAddressBook
{
    void AddContact();
    void AddMultipleContacts();
    void DisplayContacts();
    void EditContact();
    void DeleteContact();

    void SortContactsByName();
    void SortContactsByCity();
    void SortContactsByState();
    void SortContactsByZip();
}
