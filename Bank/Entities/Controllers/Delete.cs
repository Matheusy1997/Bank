using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Entities.Controllers
{
    internal class Delete
    {
        public static void DeleteAccount(SortedSet<Account> listAccount)
        {
            Console.Write("Enter the account number to delete: ");
            int numberAccount = int.Parse(Console.ReadLine());
            Account account = listAccount.FirstOrDefault(x => x.NumberAccount == numberAccount);
            if (account != null)
            {
                listAccount.Remove(account);
                CreateFile.CreateFileAccounts(listAccount);
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
    }
}
