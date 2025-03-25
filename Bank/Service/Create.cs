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
            ConsoleNameInput nameInput = new ConsoleNameInput();
            
            string accountTypeInput = nameInput.GetTypeAccount();
            Console.WriteLine();

            string nameAccount;

            switch (accountTypeInput.ToLower())
            {
                case "business":
                    
                    nameAccount = nameInput.GetName(accountTypeInput);

                    ValidateService.ValidateNameAccount(nameAccount);

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

                    nameAccount = nameInput.GetName(accountTypeInput);

                    ValidateService.ValidateNameAccount(nameAccount);

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
                    ValidateService.ValidateTypeAccount(accountTypeInput);
                    break;
            }
        }
    }
}
