using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities.Controllers
{
    internal class Delete
    {
        public static void DeleteAccount(Dictionary<int, Account> dictionaryAccount)
        {
            Console.Write("Enter the account number to delete: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Account account = dictionaryAccount[numberAccount];
            if (account != null)
            {
                dictionaryAccount.Remove(numberAccount);
                CreateFile.CreateFileAccounts(dictionaryAccount);
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
    }
}
