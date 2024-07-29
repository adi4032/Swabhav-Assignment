using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Serialize_;

namespace Bank
{
    internal class Account
    {
        private int _accountNo { get; set; }
        private string _accountHolderName { get; set; }
        private string _bankname;
        private double _balance;
        private int _adhaarNo;
        static double MIN_AMOUNT = 500;
        public Account() { }
        public Account(int accountNo, string accountHolderName, string bankname) : this(accountNo, accountHolderName, bankname, MIN_AMOUNT, 0)
        {

        }
        public Account(int accountNo, string accountHolderName, string bankName, double balance, int adhaarNo)
        {
            _accountNo = accountNo;
            _accountHolderName = accountHolderName;
            _bankname = bankName;
            _balance = balance;
            _adhaarNo = adhaarNo;
        }
        public int adhaarNo
        {
            get { return _adhaarNo; }
            set { _adhaarNo = value; }
        }
        public int accountNo
        {
            get { return _accountNo; }
            set { _accountNo = value; }
        }
        public string accountHolderName
        {
            get { return _accountHolderName; }
            set { _accountHolderName = value; }
        }
        public string bankname
        {
            get { return _bankname; }
            set { _bankname = value; }
        }
        public double balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public double AmountDeposit(double amount)
        {
            _balance += amount;
            return _balance;
        }

        public double WithdrawAmount(double amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
            return _balance;
        }

        public double checkBalance()
        {
            return _balance;
        }
public static void AddNewAccount(List<Account> accounts)
    {
        Console.WriteLine("Enter account number:");
        int accountNo = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter account holder name:");
        string accountHolderName = Console.ReadLine();

        Console.WriteLine("Enter bank name:");
        string bankName = Console.ReadLine();

        Console.WriteLine("Enter initial balance:");
        double balance = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter Aadhar number:");
        int adhaarNo = int.Parse(Console.ReadLine());

        Account newAccount = new Account(accountNo, accountHolderName, bankName, balance, adhaarNo);

        accounts.Add(newAccount); 
        SerialDesearialize.SerializeData(accounts); 

        Console.WriteLine("New account created successfully!");
    }
}
}