using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToMeApp
{	  
    static class Cafeteria
    {

        #region methods

        /// <summary>
        /// create an account with the Main Cafeteria
        /// </summary>
        /// <param name="emailAddress">Email Address associated with the account</param>
        /// <param name="phoneNumber">Phone Number associated with the account</param>
        /// <param name="paypalAddress">PayPal Address associated with the account</param>
		/// <param name="accountType">type of account</param>
        /// <returns>Accounts</returns>
		
        public static Accounts CreateAccount(string emailAddress, string phoneNumber, string paypalAddress, TypeOfAccounts accountType = TypeOfAccounts.User)
        {
            var account = new Accounts
            {
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber,
				PayPalAddress = paypalAddress,
				AccountType = accountType,
            };

          
			
            return account;
        }

		#endregion


	}
}
