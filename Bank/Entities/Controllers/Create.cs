using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpcastingDowncasting.Entities.Exception;
using UpcastingDowncasting.Entities.Enums;

namespace UpcastingDowncasting.Entities.Controllers
{
    internal class Create
    {
        public static void CreateAccount(List<Account> listAccount)
        {
            Random random = new Random();

            Console.WriteLine("What type of account to register?");
            Console.Write("Business or Savings: ");
            string typeAccount = Console.ReadLine();
            Console.WriteLine();
            string nameAccount;
            switch (typeAccount) 
            { 
                case "Business":
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
                            listAccount.Add(new BusinessAccount(nameAccount.Trim().ToUpper(), numberAccount, 500.00, TypeAccount.Business));
                            break;
                        }
                        break;                       
                    }
                    break;
                case "Savings":
                    Console.WriteLine("Type Account: Savings");
                    Console.Write("Write the account name: ");
                    nameAccount = Console.ReadLine();

                    if (String.IsNullOrEmpty(nameAccount) || String.IsNullOrWhiteSpace(nameAccount))
                    {
                        throw new DomainException("Name is required");
                    }

                    while (true) {
                        int numberAccount = random.Next(1, 5001);
                        Account resultado = listAccount.Find(x => x.NumberAccount == numberAccount);
                        if (resultado == null)
                        {
                            listAccount.Add(new SavingAccount(nameAccount.Trim().ToUpper(), numberAccount, TypeAccount.Savings));
                            break;
                        }
                        break;
                    }
                    break;
            }
        }
    }
}
