using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleTransferInput : ITransferInput
    {
        public string GetAmount()
        {
            Console.Write("Enter the amount to transfer: R$ ");
            string input = Console.ReadLine();
            return input;
        }

        public string GetNumberAccount()
        {
            Console.Write("Enter the account number to receive the transfer: ");
            string numberAccountReceive = Console.ReadLine();
            return numberAccountReceive;
        }
    }
}
