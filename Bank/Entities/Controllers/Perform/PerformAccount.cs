using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities.Controllers.Perform
{
    internal class PerformAccount
    {
        public static void PerformAccountOperation(List<Account> listAccount)
        {
            Console.Write("Enter account number: ");
            int numberSelected = int.Parse(Console.ReadLine());
            Account accountNumber = listAccount.Find(x => x.NumberAccount == numberSelected);

            if (accountNumber is BusinessAccount businessAccount)
            {
                PerformBusinessAccount.PerformBusinessAccountOperation(businessAccount);

            }
            else if (accountNumber is SavingAccount savingAccount)
            {
                PerformSavingsAccount.PerformSavingsAccountOperation(savingAccount);

            }
        }
    }
}
