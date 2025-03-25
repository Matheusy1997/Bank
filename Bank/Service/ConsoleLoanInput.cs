using Bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Service
{
    internal class ConsoleLoanInput : IOutString
    {
        public void OutString()
        {
            Console.Write("Enter the amount to loan: R$ ");
        }
    }
}
