using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Controllers;
using Bank.Entities;
using Bank.Interfaces;

namespace Bank.Service
{
    internal class PerformSavingsAccount
    {
        public static void PerformSavingsAccountOperation(Dictionary<int, Account> dictionaryAccount, 
            SavingAccount savingAccount, Dictionary<int, BankDelegate.SavingsOperation> operation, IMessageService messageService)
        {
            while (true)
            {
                messageService.ShowSavingsAccountOperation();

                int service = ValidateService.ParseInt(InputHandler.GetInput());

                ValidateService.ValidateKey(operation, service);

                operation[service](dictionaryAccount, savingAccount);

                if (!Continue.ContinueOperation()) break;

            }
        }
    }
}
