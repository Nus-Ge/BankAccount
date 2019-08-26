using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class BankAccount
    {
        protected string acctNumber;
        protected string acctHolderId;
        protected double balance;

        public string AcctNumber
        {
            set
            {
                acctNumber = value;
            }
            get
            {
                return acctNumber;
            }
        }

        public string AcctHolderId
        {
            set
            {
                acctHolderId = value;
            }
            get
            {
                return acctHolderId;
            }
        }

        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }

        public BankAccount(string a, string b, double c)
        {
            acctNumber = a;
            acctHolderId = b;
            balance = c;
        }
        public void Deposit(double amt)
        {
            Balance = Balance + amt;
        }

        public void TansferTo(double amt, BankAccount another)
        {
            Balance -= amt;
            another.Balance += amt;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account_me = new BankAccount("12345","gao_ge",1234);
            BankAccount account_iss= new BankAccount("123456", "iss", 6666);
            account_me.TansferTo(1000, account_iss);
            Console.WriteLine(account_me.Balance);
        }
    }
}
