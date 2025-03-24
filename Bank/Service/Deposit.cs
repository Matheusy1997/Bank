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
    internal class Deposit
    {
        public static void PerformDeposit(Account account, IMessageService messageService)
        {
            ConsoleDepositInput depositInput = new ConsoleDepositInput();
            string input = depositInput.GetAmount();
            ValidateService.ValidateAmount(input);
            double amount = double.Parse(input);
            account.Deposit(amount);
            messageService.ShowDepositMessage(account, amount);
        }
    }
}
