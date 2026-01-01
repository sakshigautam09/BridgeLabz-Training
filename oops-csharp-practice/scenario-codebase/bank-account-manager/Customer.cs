namespace bankAccountManager
{
    class Customer
    {
        public string Name;
        public int Pin;
        public BankAccount Account;

        public Customer(string name, int pin, BankAccount account)
        {
            Name = name;
            Pin = pin;
            Account = account;
        }

        public bool ValidatePin(int pin)
        {
            return Pin == pin;
        }

        public void Deposit(double amount)
        {
            Account.Balance += amount;
            Console.WriteLine("Deposit Successful");
        }

        public void Withdraw(double amount)
        {
            if (amount > Account.Balance)
            {
                Console.WriteLine("Insufficient Balance");
                return;
            }

            Account.Balance -= amount;
            Console.WriteLine("Withdrawal Successful");
        }

        public void ShowBalance()
        {
            Console.WriteLine("Balance: ₹" + Account.Balance);
        }
    }
}
