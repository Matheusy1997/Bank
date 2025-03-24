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

            ConsoleTransferInput consoleTransferInput = new ConsoleTransferInput();

            string numberAccountReceive = consoleTransferInput.GetNumberAccount();

            ValidateService.ValidateAccount(dictionaryAccount, numberAccountReceive);

            Account accountReceive = dictionaryAccount[numberAccountReceive];

            string input = consoleTransferInput.GetAmount();

            ValidateService.ValidateTransfer(input, account, accountReceive);

            double amount = double.Parse(input);

            account.Transfer(amount, accountReceive);

            messageService.ShowTransferMessage(account, accountReceive, amount);

            CreateFile.CreateFileTransactions(account, accountReceive, amount);
            CreateFile.CreateFileAccounts(dictionaryAccount);
        }
    }
}
