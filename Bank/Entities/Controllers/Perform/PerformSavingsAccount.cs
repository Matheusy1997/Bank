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
                Console.Write("1: Deposit");
                Console.WriteLine("2: Withdraw");
                Console.WriteLine("3: UpdateBalance");
                Console.WriteLine("4: Transfer");
                Console.Write("Choose a service: ");
                int service = int.Parse(Console.ReadLine());

                switch (service)
                {
                    case 1:
                        Deposit.PerformDeposit(savingAccount);
                        break;
                    case 2:
                        Withdraw.PerformWithdraw(savingAccount);
                        break;
                    case 3:
                        savingAccount.UpdateBalance();
                        Console.WriteLine($"Update balance: " +
                            $"{savingAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
                        break;
                    case 4:
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
