using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controllers
{
    internal class Continue
    {
        public static bool ContinueOperation()
        {
            Console.Write("Want to do another operation y/n : ");
            return char.Parse(Console.ReadLine()) == 'y';
        }
    }
}
