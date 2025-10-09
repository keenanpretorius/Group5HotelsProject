using System;

namespace Group5HotelsProject.Business
{
    public class Booking
    {
        #region Attributes
        private int bookingID;
        private int guestID;
        private int roomID;
        private int receptionistID;
        private string bookingReference;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private int numberOfGuests;
        private int numberOfNights;
        private decimal totalAmount;
        private string bookingStatus;
        private DateTime createdDate;
        #endregion

        #region Properties
        public int BookingID { get => bookingID; set => bookingID = value; }
        public int GuestID { get => guestID; set => guestID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public int ReceptionistID { get => receptionistID; set => receptionistID = value; }
        public string BookingReference { get => bookingReference; set => bookingReference = value; }
        public DateTime CheckInDate { get => checkInDate; set => checkInDate = value; }
        public DateTime CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public int NumberOfGuests { get => numberOfGuests; set => numberOfGuests = value; }
        public int NumberOfNights { get => numberOfNights; set => numberOfNights = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public string BookingStatus { get => bookingStatus; set => bookingStatus = value; }
        public DateTime CreatedDate { get => createdDate; set => createdDate = value; }
        #endregion

        #region Constructors
        public Booking() { }

        public Booking(
            int bookingID,
            int guestID,
            int roomID,
            int receptionistID,
            string bookingReference,
            DateTime checkInDate,
            DateTime checkOutDate,
            int numberOfGuests,
            int numberOfNights,
            decimal totalAmount,
            string bookingStatus,
            DateTime createdDate)
        {
            BookingID = bookingID;
            GuestID = guestID;
            RoomID = roomID;
            ReceptionistID = receptionistID;
            BookingReference = bookingReference;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            NumberOfGuests = numberOfGuests;
            NumberOfNights = numberOfNights;
            TotalAmount = totalAmount;
            BookingStatus = bookingStatus;
            CreatedDate = createdDate;
        }
        #endregion

        #region Methods
        public override string ToString() =>
            $"Booking #{BookingID} ({BookingReference}) - Guest {GuestID}, Room {RoomID}, {CheckInDate:d} to {CheckOutDate:d}, Status: {BookingStatus}";
        #endregion
    }
}
