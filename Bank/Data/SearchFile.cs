﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Bank.Entities;

namespace Bank.Data
{
    internal class SearchFile
    {
        public static void SearchFileAccount(Dictionary<int, Account> dictionaryAccount)
        {
            string searchPath = @"C:\Users\Matheus\Documents\File\Bank\Account.txt";
            string[] lines = File.ReadAllLines(searchPath);
            foreach (string line in lines)
            {
                string[] fields = line.Split(';');
                if (fields.Length >= 5 && fields[4].Trim().Equals("Business", StringComparison.OrdinalIgnoreCase))
                {
                    string name = fields[0];
                    int number = int.Parse(fields[1]);
                    double balance = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    double loanLimit = double.Parse(fields[3], CultureInfo.InvariantCulture);
                    string typeAccount = fields[4];
                    dictionaryAccount[number] = new BusinessAccount(name, number, balance, loanLimit, typeAccount);
                }
                else if (fields.Length >= 4 && fields[3].Trim().Equals("Savings", StringComparison.OrdinalIgnoreCase))
                {
                    string name = fields[0];
                    int number = int.Parse(fields[1]);
                    double balance = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    string typeAccount = fields[3];
                    dictionaryAccount[number] = new SavingAccount(name, number, balance, typeAccount);
                }
            }
        }
    }
}
