using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities.Controllers.Perform
{
    internal class PerformBusinessAccount
    {
        public static void PerformBusinessAccountOperation(BusinessAccount businessAccount)
        {
            while (true)
            {
                Console.WriteLine("Choose a service");
                Console.Write("Deposit/Withdraw/Loan/UpdateLoanLimit: ");
                string service = Console.ReadLine();
                double amount = 0.0;
                switch (service)
                {
                    case "Deposit":
                        Console.Write("Enter the amount to deposit: R$ ");
                        amount = double.Parse(Console.ReadLine());
                        businessAccount.Deposit(amount);
                        break;
                    case "Withdraw":
                        Console.Write("Enter the amount to withdraw: R$ ");
                        amount = double.Parse(Console.ReadLine());
                        businessAccount.Withdraw(amount);
                        break;
                    case "Loan":
                        Console.Write("Enter the amount to loan: R$ ");
                        amount = double.Parse(Console.ReadLine());
                        businessAccount.Loan(amount);
                        break;
                    case "UpdateLoanLimit":
                        Console.Write("Enter the amount to update the loan limit: R$ ");
                        amount = double.Parse(Console.ReadLine());
                        businessAccount.UpdateLoanLimited(amount);
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
