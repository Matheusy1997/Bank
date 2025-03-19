using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities.Controllers.Perform.Operation;

namespace Bank.Entities.Controllers.Perform
{
    internal class PerformSavingsAccount
    {
        public static void PerformSavingsAccountOperation(SortedSet<Account> listAccount,SavingAccount savingAccount)
        {
            while (true)
            {
                Console.WriteLine("Choose a service");
                Console.Write("Deposit/Withdraw/UpdateBalance: ");
                string service = Console.ReadLine();
                double amount = 0.0;

                switch (service)
                {
                    case "Deposit":
                        Deposit.PerformDeposit(savingAccount);
                        break;
                    case "Withdraw":
                        Withdraw.PerformWithdraw(savingAccount);
                        break;
                    case "UpdateBalance":
                        savingAccount.UpdateBalance();
                        Console.WriteLine($"Update balance: " +
                            $"{savingAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
                        break;
                    case "Transfer":
                        Transfer.TransferAccount(listAccount, savingAccount);
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
