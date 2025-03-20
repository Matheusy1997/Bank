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
        public static void PerformSavingsAccountOperation(Dictionary<int, Account> dictionaryAccount,SavingAccount savingAccount)
        {
            while (true)
            {
                Console.WriteLine("Choose a service");
                Console.Write("Deposit/Withdraw/UpdateBalance/Transfer: ");
                string service = Console.ReadLine().ToLower();
                double amount = 0.0;

                switch (service)
                {
                    case "deposit":
                        Deposit.PerformDeposit(savingAccount);
                        break;
                    case "withdraw":
                        Withdraw.PerformWithdraw(savingAccount);
                        break;
                    case "updateBalance":
                        savingAccount.UpdateBalance();
                        Console.WriteLine($"Update balance: " +
                            $"{savingAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
                        break;
                    case "transfer":
                        Transfer.TransferAccount(dictionaryAccount, savingAccount);
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
