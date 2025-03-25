using Bank.Data;
using Bank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class GenerateNumber
    {
        public static int UniqueAccountNumber(Dictionary<int, Account> dictionaryAccount)
        {
            Random random = new Random();
            while (true)
            {
                int numberAccount = random.Next(100000, 200000);

                if (!dictionaryAccount.ContainsKey(numberAccount))
                {
                    return numberAccount;
                }
                continue;
            }
        }
    }
}
