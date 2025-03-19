using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities.Controllers.Perform.Operation;
using Bank.Entities.Exception;

namespace Bank.Entities.Controllers
{
    internal class Create
    {
        public static void CreateAccount(SortedSet<Account> listAccount)
        {
            Random random = new Random();

            Console.WriteLine("What type of account to register?");
            Console.Write("Business or Savings: ");
            string accountTypeInput = Console.ReadLine();
            Console.WriteLine();

            string nameAccount;

            switch (accountTypeInput.ToLower())
            {
                case "business":
                    Console.WriteLine("Type Account: Business");
                    Console.Write("Write the account name: ");
                    nameAccount = Console.ReadLine();

                    if (String.IsNullOrEmpty(nameAccount) || String.IsNullOrWhiteSpace(nameAccount))
                    {
                        throw new DomainException("Name is required");
                    }

                    while (true)
                    {
                        int numberAccount = random.Next(100000, 200000);
                        BusinessAccount businessAccount = new BusinessAccount(nameAccount.Trim().ToUpper(),
                                numberAccount, 500.00, "Business");

                        if (!listAccount.Contains(businessAccount))
                        {
                            listAccount.Add(businessAccount);
                            CreateFile.CreateFileAccounts(listAccount); 
                            break;
                        }
                        continue;
                    }
                    break;
                case "savings":
                    Console.WriteLine("Type Account: Savings");
                    Console.Write("Write the account name: ");
                    nameAccount = Console.ReadLine();

                    if (String.IsNullOrEmpty(nameAccount) || String.IsNullOrWhiteSpace(nameAccount))
                    {
                        throw new DomainException("Name is required");
                    }

                    while (true)
                    {
                        int numberAccount = random.Next(100000, 200000);

                        SavingAccount savingAccount = new SavingAccount(nameAccount.Trim().ToUpper(),
                                numberAccount, 500.00, "Savings");

                        if (!listAccount.Contains(savingAccount))
                        {
                            listAccount.Add(savingAccount);
                            CreateFile.CreateFileAccounts(listAccount);
                            break;
                        }
                        continue;
                    }
                    break;
                default:
                    Console.WriteLine("Type account invalid!");
                    break;
            }
        }
    }
}
