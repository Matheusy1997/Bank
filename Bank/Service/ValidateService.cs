
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
        public static void ValidateAccount(Dictionary<int, Account> account, int number)
        {
            if(!account.ContainsKey(number))
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
    }
}
