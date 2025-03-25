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
            consoleTransferInput.OutNumberAccount();
            string numberAccountReceive = InputHandler.GetInput();

            ValidateService.ValidateAccount(dictionaryAccount, numberAccountReceive);
            consoleTransferInput.OutAmount();
            string input = InputHandler.GetInput();

            ValidateService.ValidateTransfer(input, account, dictionaryAccount[int.Parse(numberAccountReceive)]);

            double amount = double.Parse(input);

            account.Transfer(amount, dictionaryAccount[int.Parse(numberAccountReceive)]);

            messageService.ShowTransferMessage(account, dictionaryAccount[int.Parse(numberAccountReceive)], amount);

            CreateFile.CreateFileTransactions(account, dictionaryAccount[int.Parse(numberAccountReceive)], amount);
            CreateFile.CreateFileAccounts(dictionaryAccount);
        }
    }
}
