using System.Collections.Generic;

namespace Chpt6
{
    interface IConvertible
    {
        public double convertBalanceToUSD(double excgRate);
    }

    abstract class Account : IConvertible
    {
        protected int balance;
        public Account()
        {
            balance = 1000;
        }

        public int getBalance()
        {
            return balance;
        }

        public abstract void Deposit(int amount);

        public double convertBalanceToUSD(double excgRate)
        {
            return getBalance() * excgRate;
        }
    }

    class SavingsAccount : Account
    {
        public override void Deposit(int amount)
        {
            balance += amount;
        }

        // returns a text describing the operation
        public string Withdraw(int amount)
        {
            if (balance - amount - 50 > 0)
            {
                balance -= amount - 50;
                return "Operation sucessful. It costed you 50kr to withdraw.";
            }
            return "Operation failed - not enough founds";
        }
    }

    class CheckingAccount : Account
    {
        // no cost when taking money from a CheckingAcc.
        public string Withdraw(int amount)
        {
            if (balance - amount > 0)
            {
                balance -= amount;
                return "Operation sucessful";
            }
            return "Operation failed - not enough founds";
        }
        public override void Deposit(int amount)
        {
            // balance cannot exceed 20000 kr
            if (balance + amount > 20000)
            {
                Console.WriteLine("Cannot perform deposit. Max reached.");
            }
            else
            {
                balance += amount;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // using polymorphism in a collection!

            List<IConvertible> myAccounts = new List<IConvertible>();

            CheckingAccount a = new CheckingAccount();
                a.Deposit(123);
            myAccounts.Add(a);

            SavingsAccount b = new SavingsAccount();
                b.Deposit(999);
            myAccounts.Add(b);  

            myAccounts.Add(new CheckingAccount());

            // print all the balances
            for (int i= 0;i < myAccounts.Count; i++) {
                // I have to force a CAST here to Account
                Console.WriteLine("Account #"+ i +" -> "+ ((Account)myAccounts[i]).getBalance());
            }

        }
    }
}