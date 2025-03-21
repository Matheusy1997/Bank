using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    internal abstract class Account : IComparable<Account>
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


        public void Transfer(double amount, Account account)
        {
            if (amount > Balance)
            {
                throw new ArgumentException("Insufficient balance");
            }
            Balance -= amount;
            account.Deposit(amount);
            Console.WriteLine("Date: " + DateTime.Now + ", " 
                + "Value: " +  amount.ToString("C", new CultureInfo("pt-br")) + ", "
                + "Recipient: " + account.Name + ", "
                + "New Balance: " + Balance.ToString("C", new CultureInfo("pt-br")));
        }
        public int CompareTo(Account obj)
        {
            return NumberAccount.CompareTo(obj.NumberAccount);
        }

        public override int GetHashCode()
        {
            return NumberAccount.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if(obj is Account account)
            {
               return NumberAccount.Equals(account.NumberAccount);
            }
            return false;
        }
    }
}
