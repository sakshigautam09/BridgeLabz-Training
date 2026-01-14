public interface IAddressBook
{
    Contact AddContact(); // UC-2
    void DisplayContact(Contact contact);
    void EditContact(Contact contact);
}
