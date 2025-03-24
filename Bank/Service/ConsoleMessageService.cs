using Bank.Entities;
using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleMessageService : IMessageService
    {
        public void ShowDepositMessage(Account originAccount, double amount)
        {
            Console.WriteLine($"Deposit made successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Amount: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Origin account: {originAccount.NumberAccount}");
            Console.WriteLine($"New Balance: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
        }

        public void ShowLoanMessage(BusinessAccount originAccount, double amount)
        {
            Console.WriteLine($"Loan made successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Amount: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Origin account: {originAccount.NumberAccount}");
            Console.WriteLine($"New Balance: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"New Loan Limit: {originAccount.LoanLimit.ToString("C", new CultureInfo("pt-br"))}");
        }

        public void ShowTransferMessage(Account originAccount, Account destinationAccount, double amount)
        {
            Console.WriteLine($"Transfer made successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Amount: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Origin Account: {originAccount.NumberAccount}");
            Console.WriteLine($"Destination Account: {destinationAccount.NumberAccount}");
            Console.WriteLine($"New Balance: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
        }
    }
}
