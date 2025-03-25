using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class PerformAccount
    {
        public static void PerformAccountOperation(Dictionary<int, Account> dictionaryAccount)
        {
            Console.Write("Enter account number: ");
            int numberSelected = int.Parse(Console.ReadLine());
            Account accountNumber = dictionaryAccount[numberSelected];

            if (accountNumber != null)
            {
                if (accountNumber is BusinessAccount businessAccount)
                {
                    PerformBusinessAccount.PerformBusinessAccountOperation(dictionaryAccount, businessAccount, 
                        BankDelegate.BusinessOperations, new ConsoleMessageService());

                }
                else if (accountNumber is SavingAccount savingAccount)
                {
                    PerformSavingsAccount.PerformSavingsAccountOperation(dictionaryAccount, savingAccount, 
                        BankDelegate.SavingsOperations, new ConsoleMessageService());

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
