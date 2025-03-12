using System.Collections.Generic;
using UpcastingDowncasting.Entities;
using UpcastingDowncasting.Entities.Controllers;
using UpcastingDowncasting.Entities.Controllers.Option;
using UpcastingDowncasting.Entities.Controllers.Perform;
using UpcastingDowncasting.Entities.Exception;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Account> listAccount = new List<Account>();


                Option.OptionMenu(listAccount);

                //PerformAccount.PerformAccountOperation(listAccount);

                //Display.DisplayAccount(listAccount);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in business rule: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
