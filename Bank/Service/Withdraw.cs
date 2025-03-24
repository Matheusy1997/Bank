using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class Withdraw
    {
        public static void PerformWithdraw(Account account)
        {
            Console.Write("Enter the amount to withdraw: R$ ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
    }
}
