using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities.Controllers.Perform.Operation;

namespace Bank.Entities.Controllers.Perform
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
                        Deposit.PerformDeposit(businessAccount);
                        break;
                    case "Withdraw":
                        Withdraw.PerformWithdraw(businessAccount);
                        break;
                    case "Loan":
                        Loan.PerformLoan(businessAccount);
                        break;
                    case "UpdateLoanLimit":
                        UpdateLoanLimit.PerformUpdateLoanLimit(businessAccount);
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
