using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class Loan
    {
        public static void PerformLoan(BusinessAccount businessAccount)
        {
            Console.Write("Enter the amount to loan: R$ ");
            double amount = double.Parse(Console.ReadLine());
            businessAccount.Loan(amount);
        }
    }
}
