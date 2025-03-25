using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Interfaces
{
    internal interface IMessageService
    {
        void ShowTransferMessage(Account originAccount, Account destinationAccount, double amount);
        void ShowDepositMessage(Account originAccount, double amount);
        void ShowLoanMessage(BusinessAccount originAccount, double amount);
        void ShowWithdrawrMessage(Account originAccount, double amount);
        void ShowCreateAccountMessage(Account account);
        void ShowMenuOption();
        void ShowSavingsAccountOperation();
        void ShowBusinessAccountOperation();
    }
}
