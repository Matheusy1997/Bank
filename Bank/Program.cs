using System.Collections.Generic;
using Bank.Controllers;
using Bank.Data;
using Bank.Entities;
using Bank.Entities.Exception;
using Bank.Service;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dictionary<int, Account> dictionaryAccount = new Dictionary<int, Account>();
                
                SearchFile.SearchFileAccount(dictionaryAccount);

                Option.OptionMenu(dictionaryAccount, BankDelegate.MenuOperations);

                
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
