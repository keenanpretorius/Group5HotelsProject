using System;

namespace Group5HotelsProject.Business
{
    public class Guest : Person
    {
        #region Attributes
        private int guestID;
        private string postalCode;
        private string idPassportNumber;
        private string loyaltyStatus;
        #endregion

        #region Properties
        public int GuestID { get => guestID; set => guestID = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
        public string IDPassportNumber { get => idPassportNumber; set => idPassportNumber = value; }
        public string LoyaltyStatus { get => loyaltyStatus; set => loyaltyStatus = value; }
        #endregion

        #region Constructors
        public Guest() { }

        public Guest(
            int guestID,
            string firstName,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string city,
            string postalCode,
            string idPassportNumber,
            string loyaltyStatus
        ) : base(guestID, firstName, lastName, phoneNumber, email, address, city)
        {
            GuestID = guestID;
            PostalCode = postalCode;
            IDPassportNumber = idPassportNumber;
            LoyaltyStatus = loyaltyStatus;
        }
        #endregion

        #region Methods
        public override string ToString() => $"{FullName} (Guest - {Email})";
        #endregion
    }
}
