using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using UpcastingDowncasting.Entities.Enums;

namespace UpcastingDowncasting.Entities.Controllers
{
    internal class SearchFile
    {
        public static void SearchFileAccount(List<Account> listAccount)
        {
            string searchPath = @"C:\Users\Matheus\Documents\File\Bank\Account.txt";
            using (StreamReader sr = File.OpenText(searchPath))
            {
                while (sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(';');
                    if (fields[4].Trim() == "Business")
                    {
                        string name = fields[0];
                        int number = int.Parse(fields[1]);
                        double balance = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        double loanLimit = double.Parse(fields[3], CultureInfo.InvariantCulture);
                        TypeAccount typeAccount = TypeAccount.Business;
                        listAccount.Add(new BusinessAccount(name, number, balance, loanLimit, typeAccount));
                    }
                    else
                    {
                        string name = fields[0];
                        int number = int.Parse(fields[1]);
                        double balance = double.Parse(fields[2], CultureInfo.InvariantCulture);
                        TypeAccount typeAccount = TypeAccount.Savings;
                        double interestRate = double.Parse(fields[4], CultureInfo.InvariantCulture);
                        listAccount.Add(new SavingAccount(name, number, balance, typeAccount));
                    }
                }
            }

            Display.DisplayAccount(listAccount);
        }
    }
}
