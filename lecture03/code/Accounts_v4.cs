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
            CheckingAccount account = new CheckingAccount();
            Console.WriteLine(account.getBalance()); // -> 1000
            account.Deposit(200);
            Console.WriteLine(account.getBalance()); // -> 1200
            account.Deposit(50000); // error msg
            Console.WriteLine(account.convertBalanceToUSD(0.146) + " in USD");


            Console.WriteLine("----------------");

            SavingsAccount account2 = new SavingsAccount();
            Console.WriteLine(account2.getBalance());
            Console.WriteLine(account2.Withdraw(500));
            Console.WriteLine(account2.getBalance());
            Console.WriteLine(account2.convertBalanceToUSD(0.146) + " in USD");
        }
    }
}