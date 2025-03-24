using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    internal class SavingAccount : Account
    {
        public double InterestRate { get; set; } = 0.01;
        public SavingAccount() { }

        public SavingAccount(string name, int number,string typeAccount) : base(name, number, typeAccount)
        {
        }
        public SavingAccount(string name, int number, double balance, string typeAccount) : base(name, number, balance, typeAccount)
        {
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount + 5);
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number Account: {NumberAccount}, " +
                    $"Balance: {Balance.ToString("C", new CultureInfo("pt-br"))}, Type Account: {TypeAccount}";
        }
    }
}
