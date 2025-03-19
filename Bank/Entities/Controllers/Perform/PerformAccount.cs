using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities.Controllers.Perform
{
    internal class PerformAccount
    {
        public static void PerformAccountOperation(SortedSet<Account> listAccount)
        {
            Console.Write("Enter account number: ");
            int numberSelected = int.Parse(Console.ReadLine());
            Account accountNumber = listAccount.FirstOrDefault(x => x.NumberAccount == numberSelected);

            if (accountNumber != null)
            {
                if (accountNumber is BusinessAccount businessAccount)
                {
                    PerformBusinessAccount.PerformBusinessAccountOperation(listAccount, businessAccount);

                }
                else if (accountNumber is SavingAccount savingAccount)
                {
                    PerformSavingsAccount.PerformSavingsAccountOperation(listAccount, savingAccount);

                }
                else
                {
                    Console.WriteLine("Account type not supported.");
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
    }
}
