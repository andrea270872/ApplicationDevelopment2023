namespace Chpt6
{

    class Account
    {
        protected int balance;
        public Account()
        {
            balance = 1000;
        }

        public int getBalance() {
            return balance;
        }
    }

    class SavingsAccount : Account
    {
        // returns a text describing the operation
        public string Withdraw(int amount)
        {
            if (balance - amount -50 > 0)
            {
                balance = balance - amount - 50;
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
            balance -= amount;
            return "Operation sucessful";
        }
    }

    internal class Program
    { 
        static void Main(string[] args)
        {
            CheckingAccount account = new CheckingAccount();
            Console.WriteLine(account.getBalance());
            Console.WriteLine(account.Withdraw(100));
            Console.WriteLine(account.getBalance());

            Console.WriteLine("----------------");

            SavingsAccount account2 = new SavingsAccount();
            Console.WriteLine(account2.getBalance());
            Console.WriteLine(account2.Withdraw(500));
            Console.WriteLine(account2.getBalance());
        }
    }
}