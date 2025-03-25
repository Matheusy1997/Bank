using Bank.Controllers;
using Bank.Data;
using Bank.Entities;
using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class BankDelegate
    {
        public delegate void BusinessOperation(Dictionary<int, Account> accounts, BusinessAccount businessAccount);
        public delegate void SavingsOperation(Dictionary<int, Account> accounts, SavingAccount savingsAccount);
        public delegate void MenuOption(Dictionary<int, Account> accounts);
        public delegate void ConsoleOutput(ConsoleMessageService messageService);

        public static Dictionary<int, BusinessOperation> BusinessOperations = new Dictionary<int, BusinessOperation>
        {
            {1, (account, acc) => Deposit.PerformDeposit(acc, new ConsoleMessageService(), new ConsoleDepositInput())},
            {2, (account, acc) => Withdraw.PerformWithdraw(acc, new ConsoleMessageService(), new ConsoleWithdrawInput())},
            {3, (account, acc) => Loan.PerformLoan(acc, new ConsoleMessageService(), new ConsoleLoanInput())},
            {4, (account, acc) => UpdateLoanLimit.PerformUpdateLoanLimit(acc)},
            {5, (account, acc) => Transfer.TransferAccount(account, acc, new ConsoleMessageService(), new ConsoleTransferInput())}
        };

        public static Dictionary<int, SavingsOperation> SavingsOperations = new Dictionary<int, SavingsOperation>
        {
            {1, (account, acc) => Deposit.PerformDeposit(acc, new ConsoleMessageService(), new ConsoleDepositInput())},
            {2, (account, acc) => Withdraw.PerformWithdraw(acc, new ConsoleMessageService(), new ConsoleWithdrawInput())},
            {3, (account, acc) => acc.UpdateBalance()},
            {4, (account, acc) => Transfer.TransferAccount(account, acc, new ConsoleMessageService(), new ConsoleTransferInput())}
        };

        public static Dictionary<int, MenuOption> MenuOperations = new Dictionary<int, MenuOption>
        {
            {1, (account) => Create.CreateAccount(account, new ConsoleNameInput())},
            {2, (account) => PerformAccount.PerformAccountOperation(account)},
            {3, (account) => Display.DisplayAccount(account)},
            {4, (account) => Delete.DeleteAccount(account)}
        };


    }
}
