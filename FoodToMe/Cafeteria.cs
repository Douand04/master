using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToMe
{	  #comment
    static class Cafeteria
    {

        #region methods

        /// <summary>
        /// create an account with the Main Cafeteria
        /// </summary>
        /// <param name="emailAddress">Email Address associated with the account</param>
        /// <param name="accountType">type of account</param>
        /// <param name="initialDeposit">Initial amount to deposit</param>
        /// <returns>Account</returns>
        /// 
        public static Account CreateAccount(string emailAddress, TypeOfAccounts accountType = TypeOfAccounts.FTE, decimal initialDeposit = 0)
        {
            var account = new Account
            {
                EmailAddress = emailAddress,
                AccountType = accountType
            };

            if (initialDeposit > 0)
            {
                account.Deposit(initialDeposit);
            };

            return account;
        }

        #endregion
    }
}
