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
        public int AccountID { get => accountID; set => accountID = value; }
        public int GuestID { get => guestID; set => guestID = value; }
        public decimal Balance { get => balance; set => balance = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }
        #endregion

        #region Constructors
        public GuestAccount() { }

        public GuestAccount(int accountID, int guestID, decimal balance, DateTime lastUpdated)
        {
            AccountID = accountID;
            GuestID = guestID;
            Balance = balance;
            LastUpdated = lastUpdated;
        }
        #endregion

        #region Methods
        public override string ToString() => $"Account #{AccountID}: Guest {GuestID}, Balance {Balance:C}";
        #endregion
    }
}
