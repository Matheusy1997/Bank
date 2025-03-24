
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ValidateService
    {
        public static void ValidateAccount(Dictionary<int, Account> account, string number)
        {
            int numberAccount = 0;
            if(!int.TryParse(number, out numberAccount))
            {
                throw new ArgumentException("Invalid input. Please enter a number Account");
            }
            if(!account.ContainsKey(numberAccount))
            {
                throw new ArgumentException("Destination account not found!");
            }
        }
        public static void ValidateTransfer(string input, Account origenAccount, Account destinationAccount)
        {
            double amount = 0;

            if(!double.TryParse(input, out amount))
            {
                throw new ArgumentException("Invalid input. Please enter a number");
            }

            if(amount < 0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }

            if(amount > origenAccount.Balance)
            {
                throw new ArgumentException("Insufficient balanace");
            }
        }

        public static void ValidateAmount(string input)
        {
            double amount = 0;
            if (!double.TryParse(input, out amount))
            {
                throw new ArgumentException("Invalid input. Please enter a number");
            }

            if (amount < 0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }
        }

        public static void ValidateLoan(BusinessAccount businessAccount, string input)
        {
            double amount = 0;
            if(!double.TryParse(input, out amount))
            {
                throw new ArgumentException("Invalid input. Please enter a number");
            }

            if (amount > businessAccount.LoanLimit)
            {
                throw new ArgumentException("Loan amount exceeds the limit");
            }
        }
    }
}
