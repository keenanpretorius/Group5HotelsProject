using System;

namespace Group5HotelsProject.Business
{
    public class GuestAccount
    {
        #region Attributes
        private int accountID;
        private int guestID;
        private decimal balance;
        private DateTime lastUpdated;
        #endregion

        #region Properties
        public int AccountID
        {
            get { return accountID; }
            set { accountID = value; }
        }

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            set { lastUpdated = value; }
        }
        #endregion

        #region Constructors
        public GuestAccount()
        {
        }

        public GuestAccount(int accountID, int guestID, decimal balance, DateTime lastUpdated)
        {
            this.accountID = accountID;
            this.guestID = guestID;
            this.balance = balance;
            this.lastUpdated = lastUpdated;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Account #" + accountID + ": Guest " + guestID + ", Balance " + balance.ToString("C");
        }
        #endregion
    }
}
