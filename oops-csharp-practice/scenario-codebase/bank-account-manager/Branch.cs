namespace bankAccountManager
{
    class Branch
    {
        public string BranchName;
        public string BranchCode;
        public Customer[] Customers;
        public int CustomerCount;
        public BankManager Manager;

        public Branch(string name, string code)
        {
            BranchName = name;
            BranchCode = code;
            Customers = new Customer[50]; // supports many customers
            CustomerCount = 0;
        }

        public void AddCustomer(Customer customer)
        {
            Customers[CustomerCount++] = customer;
        }

        public Customer FindCustomer(string name)
        {
            for (int i = 0; i < CustomerCount; i++)
                if (Customers[i].Name == name)
                    return Customers[i];

            return null;
        }
    }
}
