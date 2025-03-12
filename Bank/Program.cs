using System.Collections.Generic;
using Bank.Entities;
using Bank.Entities.Controllers;
using Bank.Entities.Controllers.Option;
using Bank.Entities.Controllers.Perform;
using Bank.Entities.Exception;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Account> listAccount = new List<Account>();

                SearchFile.SearchFileAccount(listAccount);

                Option.OptionMenu(listAccount);

                CreateFile.CreateFileAccount(listAccount);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error in business rule: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred while accessing the file: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
