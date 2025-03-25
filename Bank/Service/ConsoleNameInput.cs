using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleNameInput : INameInput
    {
        public string GetName(string typeAccount)
        {
            Console.WriteLine($"Type Account: {typeAccount}");
            Console.Write("Write the account name: ");
            return Console.ReadLine();
        }

        public string GetTypeAccount()
        {
            Console.WriteLine("What type of account to register?");
            Console.Write("Business or Savings: ");
            return Console.ReadLine();
        }
    }
}
