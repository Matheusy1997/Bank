using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities.Exception;

namespace Bank.Entities.Controllers
{
    internal class Create
    {
        public static void CreateAccount(List<Account> listAccount)
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
                        int numberAccount = random.Next(1, 5001);
                        Account resultado = listAccount.Find(x => x.NumberAccount == numberAccount);
                        if (resultado == null)
                        {
                            listAccount.Add(new BusinessAccount(nameAccount.Trim().ToUpper(),
                                numberAccount, 500.00, "Business"));
                            break;
                        }
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
                        int numberAccount = random.Next(1, 5001);
                        Account resultado = listAccount.Find(x => x.NumberAccount == numberAccount);
                        if (resultado == null)
                        {
                            listAccount.Add(new SavingAccount(nameAccount, numberAccount, "Savings"));
                            break;
                        }
                    }
                    break;
            }
        }
    }
}
