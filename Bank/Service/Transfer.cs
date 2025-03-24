using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Bank.Entities;
using Bank.Data;
using Bank.Interfaces;

namespace Bank.Service
{
    internal class Transfer
    {
        public static void TransferAccount(Dictionary<int, Account> dictionaryAccount, Account account, IMessageService messageService)
        {

            Console.Write("Enter the amount to transfer: R$ ");
            string input = Console.ReadLine();

            Console.Write("Enter the account number to receive the transfer: ");
            int numberAccountReceive = int.Parse(Console.ReadLine());

            ValidateService.ValidateAccount(dictionaryAccount, numberAccountReceive);

            Account accountReceive = dictionaryAccount[numberAccountReceive];
            
            ValidateService.ValidateTransfer(input, account, accountReceive);

            double amount = double.Parse(input);

            account.Transfer(amount, accountReceive);

            messageService.ShowTransferMessage(account, accountReceive, amount);

            CreateFile.CreateFileTransactions(account, accountReceive, amount);
            CreateFile.CreateFileAccounts(dictionaryAccount);
        }
    }
}
