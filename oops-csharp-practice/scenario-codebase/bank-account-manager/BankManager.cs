namespace bankAccountManager
{
    class BankManager
    {
        public string Name;
        public int Pin;
        public Branch Branch;

        public BankManager(string name, int pin, Branch branch)
        {
            Name = name;
            Pin = pin;
            Branch = branch;
        }

        public bool ValidatePin(int pin)
        {
            return Pin == pin;
        }

        public void ViewAllCustomers()
        {
            Console.WriteLine("\nCustomers List:");
            for (int i = 0; i < Branch.CustomerCount; i++)
                Console.WriteLine("- " + Branch.Customers[i].Name);
        }
    }
}
