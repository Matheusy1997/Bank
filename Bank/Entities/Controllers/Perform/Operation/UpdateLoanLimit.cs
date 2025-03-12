using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities.Controllers.Perform.Operation
{
    internal class UpdateLoanLimit
    {
        public static void PerformUpdateLoanLimit(BusinessAccount businessAccount)
        {
            Console.Write("Enter the amount to update the loan limit: R$ ");
            double amount = double.Parse(Console.ReadLine());
            businessAccount.UpdateLoanLimited(amount);
        }
    }
}
