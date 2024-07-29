using System;
using System.Collections.Generic;
using Bank;
using Bank_Serialize_;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.AddRange(SerialDesearialize.DeserializeData());

            bool continueRunning = true;

            while (continueRunning)
            {
                Console.WriteLine("Welcome to the Banking System!");
                Console.WriteLine("Choose an option: 1. Manage Accounts, 2. Exit");
                int mainChoice;

                while (!int.TryParse(Console.ReadLine(), out mainChoice) || (mainChoice < 1 || mainChoice > 2))
                {
                    Console.WriteLine("Invalid choice. Please enter 1 to manage accounts or 2 to exit.");
                }

                switch (mainChoice)
                {
                    case 1:
                        Transaction(accounts);
                        break;
                    case 2:
                        continueRunning = false;
                        Console.WriteLine("Thank you for using the Banking System. Goodbye!");
                        break;
                }
            }
        }

        public static void Transaction(List<Account> accounts)
        {
            if (accounts.Count == 0)
            {
                Console.WriteLine("No accounts available");
                Account.AddNewAccount(accounts); 
                return;
            }

         
            Console.WriteLine("Select an account:");
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account Number: {account.accountNo}, Account Holder: {account.accountHolderName}");
            }

            int selectedAccountNo;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out selectedAccountNo) &&
                    accounts.Exists(a => a.accountNo == selectedAccountNo))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid account number.");
            }

            Account selectedAccount = accounts.Find(a => a.accountNo == selectedAccountNo);
            bool continueTransaction = true;

            while (continueTransaction)
            {
                Console.WriteLine("Enter your choice: 1. Deposit, 2. Withdraw, 3. Account Balance, 4. Print Details, 5. Add Account");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 5))
                {
                    Console.WriteLine("Invalid choice.");
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter amount to deposit:");
                        double deposit;
                        while (!double.TryParse(Console.ReadLine(), out deposit) || deposit <= 0)
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        Console.WriteLine(selectedAccount.AmountDeposit(deposit));
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw:");
                        double withdraw;
                        while (!double.TryParse(Console.ReadLine(), out withdraw) || withdraw <= 0)
                        {
                            Console.WriteLine("Invalid amount. Please enter a positive number.");
                        }
                        Console.WriteLine(selectedAccount.WithdrawAmount(withdraw));
                        break;
                    case 3:
                        Console.WriteLine("Total amount present in your account: " + selectedAccount.checkBalance());
                        break;
                    case 4:
                        Console.WriteLine($"DETAILS OF ACCOUNT NUMBER {selectedAccount.accountNo}");
                        Console.WriteLine($"Account Name: {selectedAccount.accountHolderName}");
                        Console.WriteLine($"Bank Name: {selectedAccount.bankname}");
                        Console.WriteLine($"Account Balance: {selectedAccount.checkBalance()}");
                        Console.WriteLine($"Aadhar number: {selectedAccount.adhaarNo}");
                        break;
                    case 5:
                        Account.AddNewAccount(accounts);
                        break;
                }

                Console.WriteLine("Do you wish to continue with the same account? (Y/N)");
                string continueChoice = Console.ReadLine();
                continueTransaction = continueChoice.ToUpper() == "Y";

                SerialDesearialize.SerializeData(accounts);
            }
        }
    }
}