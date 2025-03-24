using Bank.Entities;
using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class Withdraw
    {
        public static void PerformWithdraw(Account account, IMessageService messageService)
        {
            ConsoleWithdrawInput withdrawInput = new ConsoleWithdrawInput();
            string input = withdrawInput.GetAmount();
            ValidateService.ValidateWithdraw(account, input);
            double amount = double.Parse(input);
            account.Withdraw(amount);
            messageService.ShowWithdrawrMessage(account, amount);
        }
    }
}
