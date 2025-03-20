using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities.Controllers
{
    internal class Display
    {
        public static void DisplayAccount(Dictionary<int, Account> dictionaryAccount)
        {
            foreach (var account in dictionaryAccount)
            {
                Console.WriteLine(account.Value);
            }
        }
    }
}
