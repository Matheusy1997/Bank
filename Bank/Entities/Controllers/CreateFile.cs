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
        public static void CreateFileAccounts(Dictionary<int, Account> dictionaryAccount)
        {
            List<string> files = new List<string>();
            string searchPath = @"C:\Users\Matheus\Documents\File\Bank\Account.txt";

            File.WriteAllText(searchPath, string.Empty);
            using (StreamWriter sw = File.AppendText(searchPath))
            {
                foreach (var account in dictionaryAccount)
                {
                    if (account.Value is BusinessAccount businessAccount)
                    {

                        sw.WriteLine($"{businessAccount.Name}; {businessAccount.NumberAccount}; " +
                            $"{businessAccount.Balance}; {businessAccount.LoanLimit}; {businessAccount.TypeAccount};");

                    }
                    else if (account.Value is SavingAccount savingAccount)
                    {
                        sw.WriteLine($"{savingAccount.Name};{savingAccount.NumberAccount};" +
                            $"{savingAccount.Balance};{savingAccount.TypeAccount};");
                    }
                }
            }
        }

        public static void CreateFileTransactions(Account accountTransfer,Account accountReceive, double amount)
        {
            string searchPath = $@"C:\Users\Matheus\Documents\File\Bank\Account\{accountTransfer.NumberAccount}.txt";
            using (StreamWriter sw = File.AppendText(searchPath))
            {
                sw.WriteLine($"{DateTime.Now}; {amount.ToString("C", new CultureInfo("pt-br"))}; Recipient: {accountReceive.Name}" +
                    $"; New Banlace: {accountTransfer.Balance}");
            }
        }
    }
}
