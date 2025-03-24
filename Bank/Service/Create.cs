using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Data;
using Bank.Entities;
using Bank.Entities.Exception;

namespace Bank.Service
{
    internal class Create
    {
        public static void CreateAccount(Dictionary<int, Account> dictionaryAccount)
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

                    if (string.IsNullOrEmpty(nameAccount) || string.IsNullOrWhiteSpace(nameAccount))
                    {
                        throw new DomainException("Name is required");
                    }

                    while (true)
                    {
                        int numberAccount = random.Next(100000, 200000);

                        if (!dictionaryAccount.ContainsKey(numberAccount))
                        {
                            BusinessAccount businessAccount = new BusinessAccount(nameAccount.Trim().ToUpper(),
                                    numberAccount, 500.00, "Business");
                            dictionaryAccount[numberAccount] = businessAccount;
                            CreateFile.CreateFileAccounts(dictionaryAccount);
                            break;
                        }
                        continue;
                    }
                    break;
                case "savings":
                    Console.WriteLine("Type Account: Savings");
                    Console.Write("Write the account name: ");
                    nameAccount = Console.ReadLine();

                    if (string.IsNullOrEmpty(nameAccount) || string.IsNullOrWhiteSpace(nameAccount))
                    {
                        throw new DomainException("Name is required");
                    }

                    while (true)
                    {
                        int numberAccount = random.Next(100000, 200000);


                        if (!dictionaryAccount.ContainsKey(numberAccount))
                        {
                            SavingAccount savingAccount = new SavingAccount(nameAccount.Trim().ToUpper(),
                                    numberAccount, "Savings");
                            dictionaryAccount[numberAccount] = savingAccount;
                            CreateFile.CreateFileAccounts(dictionaryAccount);
                            break;
                        }
                        continue;
                    }
                    break;
                default:
                    if (string.IsNullOrEmpty(accountTypeInput) || string.IsNullOrWhiteSpace(accountTypeInput)
                        || accountTypeInput.ToLower() != "business" || accountTypeInput.ToLower() != "savings")
                    {
                        Console.WriteLine("Type account invalid!");
                    }
                    break;
            }
        }
    }
}
