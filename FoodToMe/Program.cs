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

						///account stuff
						var accountTypes = Enum.GetNames(typeof(TypeOfAccounts));
                        for (var i = 0; i < accountTypes.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {accountTypes[i]}");

                        }
                        Console.Write("Account Type: ");
                        var accountTypeOption = Convert.ToInt32(Console.ReadLine());
                        var accountType = (TypeOfAccounts)Enum.Parse(typeof(TypeOfAccounts), accountTypes[accountTypeOption - 1]);
                        
						///EndOf allowing the end user to select account options user vs admin

                        var account = Cafeteria.CreateAccount(emailAddress, phoneNumber, paypalAddress, accountType );
                        Console.WriteLine($"AN: {account.AccountNumber}, EA: {account.EmailAddress}, B: {account.PhoneNumber}, PP: {account.PayPalAddress}, AT: {account.AccountType}");

						break;

					case "2":
						Console.WriteLine("Lets Build Your Burger!");
						var burgerSizes = Enum.GetNames(typeof(BurgerSize));
						for (var i = 0; i < burgerSizes.Length; i++)
						{
							Console.WriteLine($"{i + 1}. {burgerSizes[i]}");

						}
						Console.Write("Burger Size: ");
						var burgerSizeOption = Convert.ToInt32(Console.ReadLine());
						var burgerSize = (BurgerSize)Enum.Parse(typeof(BurgerSize), burgerSizes[burgerSizeOption - 1]);

						Console.WriteLine($"*************************************Burger Size: {burgerSize} ****************************************************");


						break;

					case "3":
						PrintAllAccounts();

						break;
					default:
                        break;
                }
            }

        }

		private static void PrintAllAccounts()
		{
			var accounts = Cafeteria.GetAllAccounts();
			foreach (var acnt in accounts)
			{
				Console.WriteLine($"AN: {acnt.AccountNumber}, EA: {acnt.EmailAddress}, B: {acnt.PhoneNumber}, PP: {acnt.PayPalAddress},  AT: {acnt.AccountType}");
			}
		}
	}
}
