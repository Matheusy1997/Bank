using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleWithdrawInput : IAmountInput
    {
        public string GetAmount()
        {
            Console.Write("Enter the amount to withdraw: R$ ");
            string input = Console.ReadLine();
            return input;
        }
    }
}
