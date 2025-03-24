using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Controllers;
using Bank.Entities;

namespace Bank.Service
{
    internal class PerformBusinessAccount
    {
        public static void PerformBusinessAccountOperation(Dictionary<int, Account> dictionaryAccount, BusinessAccount businessAccount)
        {
            while (true)
            {
                Console.WriteLine("1: Deposit");
                Console.WriteLine("2: Withdraw");
                Console.WriteLine("3: Loan");
                Console.WriteLine("4: UpdateLoanLimit");
                Console.WriteLine("5: Transfer");
                Console.Write("Choose a service: ");

                int service = int.Parse(Console.ReadLine());
                switch (service)
                {
                    case 1:
                        Deposit.PerformDeposit(businessAccount, new ConsoleMessageService());
                        break;
                    case 2:
                        Withdraw.PerformWithdraw(businessAccount, new ConsoleMessageService());
                        break;
                    case 3:
                        Loan.PerformLoan(businessAccount, new ConsoleMessageService());
                        break;
                    case 4:
                        UpdateLoanLimit.PerformUpdateLoanLimit(businessAccount);
                        break;
                    case 5:
                        Transfer.TransferAccount(dictionaryAccount, businessAccount, new ConsoleMessageService());
                        break;
                    default:
                        Console.WriteLine("Invalid service");
                        break;
                }

                if (!Continue.ContinueOperation()) break;
            }
        }
    }
}
