using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpcastingDowncasting.Entities.Enums;

namespace UpcastingDowncasting.Entities
{
    internal abstract class Account
    {
        public string Name { get; set; }
        public int NumberAccount { get; set; }
        public double Balance { get; protected set; }
        public TypeAccount TypeAccount { get; set; }

        public Account()
        {
        }
        public Account(string name, int numberAccount, TypeAccount typeAccount)
        {
            Name = name;
            NumberAccount = numberAccount;
        }

        protected Account(string name, int numberAccount, double balance, TypeAccount typeAccount)
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
    }
}
