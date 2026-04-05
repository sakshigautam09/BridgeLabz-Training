using System;

namespace bankAccountManager
{
    class BankApp
    {
        static void Main()
        {
            Bank sbi = new Bank("SBI", 5);

            sbi.AddBranch(new Branch("Mathura", "SBI001"));
            sbi.AddBranch(new Branch("Agra", "SBI002"));
            sbi.AddBranch(new Branch("Delhi", "SBI003"));

            while (true)
            {
                Console.WriteLine("\n===== SBI BANK SYSTEM =====");
                Console.WriteLine("1. Register Customer");
                Console.WriteLine("2. Customer Login");
                Console.WriteLine("3. Register Manager");
                Console.WriteLine("4. Manager Login");
                Console.WriteLine("5. Exit");
                Console.Write("Choice: ");

                int choice = int.Parse(Console.ReadLine());

                // Register Customer
                if (choice == 1)
                {
                    Branch branch = SelectBranch(sbi);

                    Console.Write("Customer Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Create PIN: ");
                    int pin = int.Parse(Console.ReadLine());

                    string accNo = "SBIACC" + (branch.CustomerCount + 1);
                    BankAccount acc = new BankAccount(accNo, branch);
                    Customer customer = new Customer(name, pin, acc);

                    branch.AddCustomer(customer);
                    Console.WriteLine("Customer Registered Successfully");
                }

                // Customer Login
                else if (choice == 2)
                {
                    Branch branch = FindBranch(sbi);
                    if (branch == null) continue;

                    Console.Write("Customer Name: ");
                    string name = Console.ReadLine();

                    Customer customer = branch.FindCustomer(name);
                    if (customer == null)
                    {
                        Console.WriteLine("Customer Not Found");
                        continue;
                    }

                    Console.Write("PIN: ");
                    if (!customer.ValidatePin(int.Parse(Console.ReadLine())))
                    {
                        Console.WriteLine("Invalid PIN");
                        continue;
                    }

                    Console.WriteLine("1. Deposit  2. Withdraw  3. Balance");
                    int act = int.Parse(Console.ReadLine());

                    if (act == 1)
                    {
                        Console.Write("Amount: ");
                        customer.Deposit(double.Parse(Console.ReadLine()));
                    }
                    else if (act == 2)
                    {
                        Console.Write("Amount: ");
                        customer.Withdraw(double.Parse(Console.ReadLine()));
                    }
                    else if (act == 3)
                    {
                        customer.ShowBalance();
                    }
                }

                // Register Manager
                else if (choice == 3)
                {
                    Branch branch = SelectBranch(sbi);

                    Console.Write("Manager Name: ");
                    string name = Console.ReadLine();

                    Console.Write("PIN: ");
                    int pin = int.Parse(Console.ReadLine());

                    branch.Manager = new BankManager(name, pin, branch);
                    Console.WriteLine("Manager Registered");
                }

                // Manager Login
                else if (choice == 4)
                {
                    Branch branch = FindBranch(sbi);
                    if (branch == null || branch.Manager == null)
                    {
                        Console.WriteLine("Manager Not Registered");
                        continue;
                    }

                    Console.Write("PIN: ");
                    if (branch.Manager.ValidatePin(int.Parse(Console.ReadLine())))
                        branch.Manager.ViewAllCustomers();
                    else
                        Console.WriteLine("Invalid PIN");
                }

                else if (choice == 5)
                {
                    Console.WriteLine("Thank you for using SBI Bank System");
                    break;
                }
            }
        }

        static Branch SelectBranch(Bank bank)
        {
            for (int i = 0; i < bank.BranchCount; i++)
                Console.WriteLine($"{i}. {bank.Branches[i].BranchName}");

            return bank.Branches[int.Parse(Console.ReadLine())];
        }

        static Branch FindBranch(Bank bank)
        {
            Console.Write("Branch Name: ");
            string name = Console.ReadLine();

            for (int i = 0; i < bank.BranchCount; i++)
                if (bank.Branches[i].BranchName == name)
                    return bank.Branches[i];

            return null;
        }
    }
}
