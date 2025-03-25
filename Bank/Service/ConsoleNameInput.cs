using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleNameInput : INameOut
    {
        public void OutName(string typeAccount)
        {
            Console.WriteLine($"Type Account: {typeAccount}");
            Console.Write("Write the account name: ");
        }

        public void OutTypeAccount()
        {
            Console.WriteLine("What type of account to register?");
            Console.Write("Business or Savings: ");
        }
    }
}
