using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Data;
using Bank.Entities;
using Bank.Interfaces;
using Bank.Service;

namespace Bank.Controllers
{
    internal class Option
    {
        public static void OptionMenu(Dictionary<int, Account> dictionaryAccount,Dictionary<int, 
            BankDelegate.MenuOption> menuOptions, IMessageService messageService)
        {
            int option = 0;
            do
            {
                messageService.ShowMenuOption();

                string input = InputHandler.GetInput();

                option = ValidateService.ParseInt(input);

                ValidateService.ValidateKey(menuOptions, option);

                menuOptions[option](dictionaryAccount);
              
                Console.WriteLine();
            } while (option != 5);

        }
    }
}
