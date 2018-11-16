using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("welcome to Da Cafeteria!");
            Console.WriteLine("******************************************");
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. create an account");
                Console.WriteLine("2. Desposit Money");
                Console.WriteLine("3. Order Foodz");
                Console.WriteLine("4. Print All accounts");
                Console.WriteLine("Please Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Email Address: ");
                        var emailAddress = Console.ReadLine();
                        var accountTypes = Enum.GetNames(typeof(TypeOfAccounts));
                        for (var i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {accountTypes[i]}");

                        }
                        Console.Write("Account Type: ");
                        var accountTypeOption = Convert.ToInt32(Console.ReadLine());
                        var accountType = (TypeOfAccounts)Enum.Parse(typeof(TypeOfAccounts), accountTypes[accountTypeOption - 1]);
                        Console.Write("Initial Deposit: ");
                        var amount = Convert.ToDecimal(Console.ReadLine());


                        var account = Bank.CreateAccount(emailAddress, accountType, amount);
                        Console.WriteLine($"AN: {account.AccountNumber}, B: {account.Balance:C}, AT: {account.AccountType}");
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
