using Bank.Entities;
using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleMessageService : IMessageService
    {
        public void ShowTransferMessage(Account originAccount, Account destinationAccount, double amount)
        {
            Console.WriteLine($"Transferência realizada com sucesso!");
            Console.WriteLine($"Data: {DateTime.Now}");
            Console.WriteLine($"Valor: {amount.ToString("C", new CultureInfo("pt-br"))}");
            Console.WriteLine($"Conta de origem: {originAccount.NumberAccount}");
            Console.WriteLine($"Conta de destino: {destinationAccount.NumberAccount}");
            Console.WriteLine($"Novo saldo: {originAccount.Balance.ToString("C", new CultureInfo("pt-br"))}");
        }
    }
}
