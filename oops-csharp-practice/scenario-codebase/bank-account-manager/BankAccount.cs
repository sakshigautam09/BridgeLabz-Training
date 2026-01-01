using System;

namespace bankAccountManager
{
    internal class BankAccount
    {
        public string AccountNumber;
        public double Balance;
        public Branch Branch;

        public BankAccount(string accNo, Branch branch)
        {
            AccountNumber = accNo;
            Branch = branch;
            Balance = 0;
        }
    }
}
