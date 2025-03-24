using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Controllers;
using Bank.Entities;

namespace Bank.Service
{
    internal class PerformSavingsAccount
    {
        public static void PerformSavingsAccountOperation(Dictionary<int, Account> dictionaryAccount, SavingAccount savingAccount)
        {
            while (true)
            {
                Console.WriteLine("1: Deposit");
                Console.WriteLine("2: Withdraw");
                Console.WriteLine("3: UpdateBalance");
                Console.WriteLine("4: Transfer");
                Console.Write("Choose a service: ");
                int service = int.Parse(Console.ReadLine());

                switch (service)
                {
                    case 1:
                        Deposit.PerformDeposit(savingAccount, new ConsoleMessageService());
                        break;
                    case 2:
                        Withdraw.PerformWithdraw(savingAccount);
                        break;
                    case 3:
                        savingAccount.UpdateBalance();
                        break;
                    case 4:
                        Transfer.TransferAccount(dictionaryAccount, savingAccount, new ConsoleMessageService());
                        break;
                    default:
                        Console.WriteLine("Invalid service");
                        break;
                }

                if (!Continue.ContinueOperation()) break;

            }
        }
    }
}
