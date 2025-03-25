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
        public void ShowCreateAccountMessage(Account account)
        {
            Console.WriteLine();
            Console.WriteLine("Account created successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Type account: {account.TypeAccount}");
            Console.WriteLine($"Number account: {account.NumberAccount}");
            Console.WriteLine($"Name Account: {account.Name}");
            Console.WriteLine();

        }

        public void ShowDepositMessage(Account originAccount, double amount)
        {
            Console.WriteLine();
            Console.WriteLine($"Deposit made successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Amount: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Origin account: {originAccount.NumberAccount}");
            Console.WriteLine($"New Balance: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine();
        }

        public void ShowLoanMessage(BusinessAccount originAccount, double amount)
        {
            Console.WriteLine();
            Console.WriteLine($"Loan made successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Amount: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Origin account: {originAccount.NumberAccount}");
            Console.WriteLine($"New Balance: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"New Loan Limit: {originAccount.LoanLimit.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine();
        }

        public void ShowMenuOption()
        {
            Console.WriteLine("1. Register Account");
            Console.WriteLine("2. Search Account");
            Console.WriteLine("3. List All Accounts");
            Console.WriteLine("4. Delet Account");
            Console.WriteLine("5. Out");
            Console.Write("Choose a service: ");
        }

        public void ShowTransferMessage(Account originAccount, Account destinationAccount, double amount)
        {
            Console.WriteLine();
            Console.WriteLine($"Transfer made successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Amount: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Origin Account: {originAccount.NumberAccount}");
            Console.WriteLine($"Destination Account: {destinationAccount.NumberAccount}");
            Console.WriteLine($"New Balance: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine();
        }

        public void ShowWithdrawrMessage(Account originAccount, double amount)
        {
            Console.WriteLine();
            Console.WriteLine($"Withdraw made successfully!");
            Console.WriteLine($"Date: {DateTime.Now}");
            Console.WriteLine($"Amount: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Origin Account: {originAccount.NumberAccount}");
            Console.WriteLine($"New Balance: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine();
        }
    }
}
