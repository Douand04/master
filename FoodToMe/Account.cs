using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodToMeApp
{
    enum TypeOfAccounts
    {
        User,
        Administrator
    }
    /// <summary>
    /// Defines all properties and methods for Accounts
    /// </summary>
    class Accounts
    {

        private static int lastAccountNumber = 0; 

        #region properties
        /// <summary>
        /// Account number for the account
        /// </summary>
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string PayPalAddress { get; set; }
		public int AccountNumber {get; set;}
        public TypeOfAccounts AccountType { get; set; }
        public DateTime CreatedDate { get; set; }

        #endregion
        #region Constructor
		


        public Accounts()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

		#endregion

		#region Methods

		#endregion

	}
}
