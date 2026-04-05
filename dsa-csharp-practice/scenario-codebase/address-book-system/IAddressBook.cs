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
