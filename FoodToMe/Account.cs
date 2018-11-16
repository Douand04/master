using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    enum TypeOfAccounts
    {
        Savings,
        Checking
    }
    /// <summary>
    /// Defines all properties and methods for a bank app
    /// </summary>
    class Account
    {

        private static int lastAccountNumber = 0; 
        #region properties
        /// <summary>
        /// Exczema, LOL, Account number for the account
        /// </summary>
        public int AccountNumber { get;  }
        public string EmailAddress { get; set; }
        public decimal Balance { get; private set; }
        public TypeOfAccounts AccountType { get; set; }
        public DateTime CreatedDate { get; set; }

        #endregion
        #region Constructor

        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

        #endregion
        #region Methods

        /// <summary>
        /// deposit money into the account
        /// </summary>
        /// <param name="amount">Amount to Deposit</param>
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }


        
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion

    }
}
