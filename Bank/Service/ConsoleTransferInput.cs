using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleTransferInput : ITransferOut
    {
        public void OutAmount()
        {
            Console.Write("Enter the amount to transfer: R$ ");
        }

        public void OutNumberAccount()
        {
            Console.Write("Enter the account number to receive the transfer: ");
        }
    }
}
