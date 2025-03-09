using UpcastingDowncasting.Entities;
using UpcastingDowncasting.Entities.Controllers;
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


                Console.Write("How many account will be registered? ");
                int number = int.Parse(Console.ReadLine());
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine($"Accout #{i}");
                    Create.CreateAccount(listAccount);
                }

                Display.DisplayAccount(listAccount);

                PerformAccount.PerformAccountOperation(listAccount);

                Display.DisplayAccount(listAccount);
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
