using Bank.Entities;
using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class Loan
    {
        public static void PerformLoan(BusinessAccount businessAccount, IMessageService messageService, IOutString outString)
        {
            outString.OutString();
            string input = InputHandler.GetInput();
            ValidateService.ValidateLoan(businessAccount, input);
            double amount = double.Parse(input);
            businessAccount.Loan(amount);
            messageService.ShowLoanMessage(businessAccount, amount);
        }
    }
}
