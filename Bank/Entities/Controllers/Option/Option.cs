using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Entities.Controllers.Option
{
    internal class Option
    {
        public static void OptionMenu(List<Account> listAccount)
        {
            Console.WriteLine("1. Register Account");
            Console.WriteLine("2. Search Account");
            Console.WriteLine("3. List All Accounts");
            Console.WriteLine("4. Delet Account");
            Console.WriteLine("5. Out");
            Console.WriteLine("Select an Option");

            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Create.CreateAccount(listAccount);
                    break;
                case 2:
                    SearchFile.SearchFileAccount(listAccount);
                    break;
                case 3:
                    //Search.SearchAccount();
                    break;
                case 4:
                    //Delete.DeleteAccount(listAccount);
                    break;
                case 5:
                    Console.WriteLine("Bye!");
                    break;
                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }
    }
}
