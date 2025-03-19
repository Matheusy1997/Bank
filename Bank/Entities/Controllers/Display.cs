using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities.Controllers
{
    internal class Display
    {
        public static void DisplayAccount(SortedSet<Account> listAccount)
        {
            foreach (Account account in listAccount)
            {
                Console.WriteLine(account);
            }
        }
    }
}
