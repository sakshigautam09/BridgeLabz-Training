public class AddressBookMain
{
    static void Main()
    {
        Console.WriteLine("Welcome to Address Book Program");

        while (true)
        {
            Console.WriteLine("\n---- MAIN MENU ----");
            Console.WriteLine("1. Create Address Book");      // UC-6
            Console.WriteLine("2. Select Address Book");      // UC-6
            Console.WriteLine("3. Open Selected Address Book Menu"); // UC-1 to UC-5
            Console.WriteLine("4. Search Person by City (all books)"); // UC-8
            Console.WriteLine("5. Search Person by State (all books)"); // UC-8
            Console.WriteLine("6. View Persons by City");   // UC-9
            Console.WriteLine("7. View Persons by State");  // UC-9

            Console.WriteLine("0. Exit");


            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddressBookUtilityImpl.CreateAddressBook();
                    break;

                case 2:
                    AddressBookUtilityImpl.SelectAddressBook();
                    break;

                case 3:
                    if (AddressBookUtilityImpl.selectedBook != null)
                    {
                        AddressMenu menu = new AddressMenu(AddressBookUtilityImpl.selectedBook);
                        menu.ShowMenu();
                    }
                    else
                    {
                        Console.WriteLine("Please create or select an address book first.");
                    }
                    break;
                case 4:
                    AddressBookUtilityImpl.SearchByCity();
                    break;

                case 5:
                    AddressBookUtilityImpl.SearchByState();
                    break;
                case 6:
                    AddressBookUtilityImpl.ViewPersonsByCity();
                    break;

                case 7:
                    AddressBookUtilityImpl.ViewPersonsByState();
                    break;

                case 0:
                    Console.WriteLine("Exiting Program.");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }
}