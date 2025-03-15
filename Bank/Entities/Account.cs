using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    internal abstract class Account : IComparable
    {
        public string Name { get; set; }
        public int NumberAccount { get; set; }
        public double Balance { get; protected set; }
        public string TypeAccount { get; set; }

        public Account()
        {
        }
        public Account(string name, int numberAccount, string typeAccount)
        {
            Name = name;
            NumberAccount = numberAccount;
            TypeAccount = typeAccount;
        }

        protected Account(string name, int numberAccount, double balance, string typeAccount)
        {
            Name = name;
            NumberAccount = numberAccount;
            Balance = balance;
            TypeAccount = typeAccount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("Insufficient balance");
            }

            Balance -= amount;
        }

        public abstract void Deposit(double amount);

        public int CompareTo(object? obj)
        {
            if (!(obj is Account))
            {
                throw new ArgumentException("Comparing object is not an Account");
            }

            return NumberAccount.CompareTo(((Account)obj).NumberAccount);
        }

        public void Transfer(double amount, Account account)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("Insufficient balance");
            }
            Balance -= amount;
            account.Deposit(amount);
            Console.WriteLine(DateTime.Now + ", " + amount.ToString("C", new CultureInfo("pt-br")) + "Recipient: " + account.Name + 
                "New Balance: " + Balance.ToString("C", new CultureInfo("pt-br")));
        }
    }
}
