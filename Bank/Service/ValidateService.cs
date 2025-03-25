
using Bank.Entities;
using Bank.Entities.Exception;
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

        public static void ValidateTransfer(string input, Account originAccount, Account destinationAccount)
        {
            double amount = ParseDouble(input);

            ValidateAmountGreaterThanZero(amount);

            ValidateSufficientBalance(originAccount, amount);
        }

        public static void ValidateAmount(string input)
        {
            double amount = ParseDouble(input);

            ValidateAmountGreaterThanZero(amount);
        }

        public static void ValidateLoan(BusinessAccount businessAccount, string input)
        {
            double amount = 0;

            if (amount > businessAccount.LoanLimit)
            {
                throw new ArgumentException("Loan amount exceeds the limit");
            }
        }

        public static void ValidateWithdraw(Account account, string input)
        {
           double amount =  ParseDouble(input);
            ValidateAmountGreaterThanZero(amount);
            ValidateSufficientBalance(account, amount);
        }

        public static void ValidateNameAccount(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                throw new DomainException("Name is required");
            }
        }

        public static void ValidateTypeAccount(string typeAccount)
        {
            if (string.IsNullOrEmpty(typeAccount) || string.IsNullOrWhiteSpace(typeAccount))
            {
                throw new DomainException("Type account is required");
            }
            if(typeAccount.ToLower() != "business" || typeAccount.ToLower() != "savings")
            {
                throw new DomainException("Type account invalid!");
            }
        }

        public static void ValidateKey(Dictionary<int, BankDelegate.MenuOption> dictionary, int input)
        {
            if(!dictionary.ContainsKey(input))
            {
                throw new DomainException("Service not found");
            }
        }
        public static int ParseInt(string input)
        {
            int result = 0;

            if(!int.TryParse(input, out result))
            {
                throw new ArgumentException("Invalid input. Please enter a number");
            }
            return result;
        }
        private static double ParseDouble(string input)
        {
            double result = 0;
            if(!double.TryParse(input, out result))
            {
                throw new ArgumentException("Invalid input. Please enter a number");
            }
            return result;
        }
        private static void ValidateSufficientBalance(Account originAccount, double amount)
        {
            if (amount > originAccount.Balance)
            {
                throw new ArgumentException("Insufficient balanace");
            }
        }
        private static void ValidateAmountGreaterThanZero(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be greater than zero.");
            }
        }
    }
}
