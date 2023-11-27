using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskowSubstitution
{

    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;

        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine("Deposit :" + amount + "and Total Amount :" + Balance);
        }

        public virtual void WithDraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance.");
            }
        }
    }

    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string accountNumber, decimal balance,decimal intersetRate) : base(accountNumber, balance)
        {
            InterestRate = intersetRate;
        }

        public override void WithDraw(decimal amount)
        {
            if(amount<=Balance)
            {
                Balance -=amount;
                Console.WriteLine("AccountNumber :" + AccountNumber + " WithDraw :" + amount + " Balance :" + Balance);
            }
            else
            {
                Console.WriteLine("AccountNumber :" + AccountNumber + " WithDraw :" + amount + " Insufficient Funds..Available Funds :" + Balance);
            }
        }
    }

    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; private set; }

        public CurrentAccount(string accountNumber,decimal balance,decimal overdraftLimit):base(accountNumber, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public override void WithDraw(decimal amount)
        {
            if(amount <= Balance + OverdraftLimit)
            {
                Balance-=amount;
                Console.WriteLine("AccountNumber :" + AccountNumber + " WithDraw :" + amount + " Balance :" + Balance);
            }
            else
            {
                Console.WriteLine("AccountNumber :" + AccountNumber + " Exceeded Overdraft limit");
            }
        }
    }


    internal class Program
    {
        static void PrintDetails(BankAccount bankAccount)
        {
            Console.WriteLine("Account Number :" + bankAccount.AccountNumber + " and Balance :" + bankAccount.Balance);
        }
        static void Main(string[] args)
        {
            BankAccount savingsAccount = new SavingsAccount("SA123", 1000m, 0.03m);
            BankAccount currentAccount = new CurrentAccount("CA456", 1500m, 500m);

            Console.WriteLine("Before Transactions");
            PrintDetails(savingsAccount);
            PrintDetails(currentAccount);

            savingsAccount.WithDraw(500m);
            currentAccount.WithDraw(2000m);

            Console.WriteLine("After Transactions");
            PrintDetails(savingsAccount);
            PrintDetails(currentAccount);

            Console.ReadLine();
        }
    }
}

