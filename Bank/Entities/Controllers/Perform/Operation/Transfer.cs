using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bank.Entities.Controllers.Perform.Operation
{
    internal class Transfer
    {
        public static void TransferAccount(SortedSet<Account> listAccount, Account account)
        {

            Console.Write("Enter the amount to transfer: R$ ");
            double amount = double.Parse(Console.ReadLine());

            Console.Write("Enter the account number to receive the transfer: ");
            int numberAccountReceive = int.Parse(Console.ReadLine());
            Account accountReceive = listAccount.FirstOrDefault(x => x.NumberAccount == numberAccountReceive);
            if (accountReceive != null)
            {
                account.Transfer(amount, accountReceive);
                CreateFile.CreateFileTransactions(account, accountReceive, amount);
                CreateFile.CreateFileAccounts(listAccount);
            }
            else
            {
                Console.WriteLine("Account not found");
            }
            CreateFile.CreateFileAccounts(listAccount);
        }
    }
}
