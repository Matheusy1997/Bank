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
            ConsoleNameInput nameInput = new ConsoleNameInput();
            nameInput.OutTypeAccount();
            string accountTypeInput = InputHandler.GetInput();
            Console.WriteLine();

            string nameAccount;

            switch (accountTypeInput.ToLower())
            {
                case "business":
                    ConsoleMessageService messageService = new ConsoleMessageService();
                    nameInput.OutName(accountTypeInput);
                    nameAccount = InputHandler.GetInput();

                    ValidateService.ValidateNameAccount(nameAccount);

                    int numberAccount = GenerateNumber.UniqueAccountNumber(dictionaryAccount);

                    BusinessAccount businessAccount = new BusinessAccount(nameAccount.Trim().ToUpper(),
                            numberAccount, 500.00, "Business");

                    dictionaryAccount[numberAccount] = businessAccount;
                    messageService.ShowCreateAccountMessage(businessAccount);
                    CreateFile.CreateFileAccounts(dictionaryAccount);
                    break;
                case "savings":
                    messageService = new ConsoleMessageService();

                    nameInput.OutName(accountTypeInput);
                    nameAccount = InputHandler.GetInput();

                    ValidateService.ValidateNameAccount(nameAccount);

                    numberAccount = GenerateNumber.UniqueAccountNumber(dictionaryAccount);

                    SavingAccount savingAccount = new SavingAccount(nameAccount.Trim().ToUpper(),
                            numberAccount, "Savings");

                    dictionaryAccount[numberAccount] = savingAccount;

                    messageService.ShowCreateAccountMessage(savingAccount);

                    CreateFile.CreateFileAccounts(dictionaryAccount);

                    break;
                default:
                    ValidateService.ValidateTypeAccount(accountTypeInput);
                    break;
            }
        }
    }
}
