using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Data;
using Bank.Entities;
using Bank.Service;

namespace Bank.Controllers
{
    internal class Option
    {
        public static void OptionMenu(Dictionary<int, Account> dictionaryAccount,Dictionary<int, BankDelegate.MenuOption> menuOptions)
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Register Account");
                Console.WriteLine("2. Search Account");
                Console.WriteLine("3. List All Accounts");
                Console.WriteLine("4. Delet Account");
                Console.WriteLine("5. Out");
                Console.Write("Choose a service: ");

                string input = InputHandler.GetInput();

                option = ValidateService.ParseInt(input);
                ValidateService.ValidateKey(menuOptions, option);
                menuOptions[option](dictionaryAccount);
              
                Console.WriteLine();
            } while (option != 5);

        }
    }
}
