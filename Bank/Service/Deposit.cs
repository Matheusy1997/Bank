using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class Deposit
    {
        public static void PerformDeposit(Account account)
        {
            Console.Write("Enter the amount to deposit: R$ ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine($"New balance: {account.Balance.ToString("C", new CultureInfo("pt-br"))}");
        }
    }
}
