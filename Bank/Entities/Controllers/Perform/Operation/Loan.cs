using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities.Controllers.Perform.Operation
{
    internal class Loan
    {
        public static void PerformLoan(BusinessAccount businessAccount)
        {
            Console.Write("Enter the amount to loan: R$ ");
            double amount = double.Parse(Console.ReadLine());
            businessAccount.Loan(amount);
        }
    }
}
