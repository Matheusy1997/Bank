using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities.Controllers.Perform
{
    internal class PerformSavingsAccount
    {
        public static void PerformSavingsAccountOperation(SavingAccount savingAccount)
        {
            while (true)
            {
                Console.WriteLine("Choose a service");
                Console.Write("Deposit/Withdraw/UpdateBalance: ");
                string service = Console.ReadLine();
                double amount = 0.0;

                switch (service)
                {
                    case "Deposit":
                        Console.Write("Enter the amount to deposit: R$ ");
                        amount = double.Parse(Console.ReadLine());
                        savingAccount.Deposit(amount);
                        break;
                    case "Withdraw":
                        Console.Write("Enter the amount to withdraw: R$ ");
                        amount = double.Parse(Console.ReadLine());
                        savingAccount.Withdraw(amount);
                        break;
                    case "UpdateBalance":
                        Console.Write($"Updated balance: R$ ");
                        savingAccount.UpdateBalance();
                        Console.WriteLine($"Update balance: " +
                            $"{savingAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
                        break;
                    default:
                        Console.WriteLine("Invalid service");
                        break;
                }
                Console.Write("Want to do another operation y/n : ");
                char option = char.Parse(Console.ReadLine());
                if (option == 'n')
                {
                    break;
                }

            }
        }
    }
}
