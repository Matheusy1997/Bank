using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleDepositInput : IAmountInput
    {
        public string GetAmount()
        {
            Console.Write("Enter the amount to deposit: R$ ");
            string amount = Console.ReadLine();
            return amount;
        }
    }
}
