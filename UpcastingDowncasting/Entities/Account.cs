using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities
{
    internal abstract class Account
    {
        public string Name { get; set; }
        public int NumberAccount { get; set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }
        public Account(string name, int numberAccount)
        {
            Name = name;
            NumberAccount = numberAccount;
        }

        public abstract void Withdraw(double amount);

        public abstract void Deposit(double amount);
    }
}
