namespace bankAccountManager
{
    class Bank
    {
       public string BankName;
        public Branch[] Branches;
        public int BranchCount;

        public Bank(string name, int maxBranches)
        {
            BankName = name;
            Branches = new Branch[maxBranches];
            BranchCount = 0;
        }

        public void AddBranch(Branch branch)
        {
            Branches[BranchCount++] = branch;
        }
    }
}
