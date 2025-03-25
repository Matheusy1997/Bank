using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Controllers;
using Bank.Entities;
using Bank.Interfaces;

namespace Bank.Service
{
    internal class PerformBusinessAccount
    {
        public static void PerformBusinessAccountOperation(Dictionary<int, Account> dictionaryAccount, 
            BusinessAccount businessAccount, Dictionary<int, BankDelegate.BusinessOperation> operation, IMessageService messageService)
        {
            while (true)
            {
                messageService.ShowBusinessAccountOperation();

                int service = ValidateService.ParseInt(InputHandler.GetInput());

                ValidateService.ValidateKey(operation,service);

                operation[service](dictionaryAccount, businessAccount);

                if (!Continue.ContinueOperation()) break;
            }
        }
    }
}
