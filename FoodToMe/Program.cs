using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToMeApp
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
                Console.WriteLine("2. Order Food");
                Console.WriteLine("3. Print All accounts");
                Console.WriteLine("Please Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Email Address: ");
                        var emailAddress = Console.ReadLine();
						Console.WriteLine("Phone Number: ");
						var phoneNumber = Console.ReadLine();
						Console.WriteLine("PayPal Address: ");
						var paypalAddress = Console.ReadLine();
                        var accountTypes = Enum.GetNames(typeof(TypeOfAccounts));
                        for (var i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {accountTypes[i]}");

                        }
                        Console.Write("Account Type: ");
                        var accountTypeOption = Convert.ToInt32(Console.ReadLine());
                        var accountType = (TypeOfAccounts)Enum.Parse(typeof(TypeOfAccounts), accountTypes[accountTypeOption - 1]);
                        


                        var account = Cafeteria.CreateAccount(emailAddress, phoneNumber, paypalAddress, accountType );
                        Console.WriteLine($"AN: {account.EmailAddress}, B: {account.PhoneNumber}, AT: {account.AccountType}");

					case "2":
						Console.WriteLine("")
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
