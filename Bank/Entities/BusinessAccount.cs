using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities
{
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        public BusinessAccount() { }
        public BusinessAccount(string name, int number, double loanLimit, string typeAccount) : base(name, number, typeAccount)
        {
            LoanLimit = loanLimit;
        }
        public BusinessAccount(string name, int number, double balance, double loanLimit, string typeAccount) : base(name, number, balance, typeAccount)
        {
            LoanLimit = loanLimit;
        }
        public override void Deposit(double amount)
        {
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount + 10);
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
                LoanLimit -= amount;
                Console.WriteLine($"Loaned R$ {amount}. " +
                    $"New balance: {Balance.ToString("C", new CultureInfo("pt-br"))}" +
                    $". New LoanLimit {LoanLimit.ToString("C", new CultureInfo("pt-br"))}");
            }
            else if (amount > LoanLimit)
            {
                throw new ArgumentException("Loan amount exceeds the limit");
            }
            
        }

        public void UpdateLoanLimited(double amount)
        {
            LoanLimit += amount;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Number Account: {NumberAccount}, " +
                    $"Balance: {Balance.ToString("C", new CultureInfo("pt-br"))}, " +
                    $"Loan Limit: {LoanLimit.ToString("C", new CultureInfo("pt-br"))}, Type Account: {TypeAccount}";
        }
    }
}
