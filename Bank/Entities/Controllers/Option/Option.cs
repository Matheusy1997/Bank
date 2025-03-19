using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Entities.Controllers.Perform;

namespace Bank.Entities.Controllers.Option
{
    internal class Option
    {
        public static void OptionMenu(SortedSet<Account> listAccount)
        {
            int option = 0;
            do
            {
                Console.WriteLine("1. Register Account");
                Console.WriteLine("2. Search Account");
                Console.WriteLine("3. List All Accounts");
                Console.WriteLine("4. Delet Account");
                Console.WriteLine("5. Out");
                Console.Write("Select an Option: ");
                string input = Console.ReadLine();
                if (!int.TryParse(input, out option))
                {
                    Console.WriteLine("Invalid input. Please enter a number");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Create.CreateAccount(listAccount);
                        break;
                    case 2:
                        PerformAccount.PerformAccountOperation(listAccount);
                        break;
                    case 3:
                        Display.DisplayAccount(listAccount);
                        break;
                    case 4:
                        Delete.DeleteAccount(listAccount);
                        break;
                    case 5:
                        Console.WriteLine("Bye!");
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            } while (option != 5);

        }
    }
}
