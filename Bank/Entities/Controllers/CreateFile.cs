using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Bank.Entities.Controllers
{
    internal class CreateFile
    {
        public static void CreateFileAccount(List<Account> listAccount)
        {
            List<string> files = new List<string>();
            string searchPath = @"C:\Users\Matheus\Documents\File\Bank\Account.txt";

            File.WriteAllText(searchPath, string.Empty);
            using (StreamWriter sw = File.AppendText(searchPath))
            {
                foreach (Account account in listAccount)
                {
                    if (account is BusinessAccount businessAccount)
                    {

                        sw.WriteLine($"{businessAccount.Name}; {businessAccount.NumberAccount}; " +
                            $"{businessAccount.Balance}; {businessAccount.LoanLimit}; {account.TypeAccount};");

                    }
                    else if (account is SavingAccount savingAccount)
                    {
                        sw.WriteLine($"{savingAccount.Name};{savingAccount.NumberAccount};" +
                            $"{savingAccount.Balance};{savingAccount.TypeAccount};");
                    }
                }

            }
        }
    }
}
