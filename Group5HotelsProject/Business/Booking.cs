using System;

namespace Group5HotelsProject.Business
{
    public class Booking
    {
        #region Attributes
        private int bookingID;
        private int guestID;
        private int roomID;
        private DateTime checkInDate;
        private DateTime checkOutDate;
        private string bookingStatus;
        private decimal totalAmount;
        private int receptionistID;
        #endregion

        #region Properties
        public int BookingID { get => bookingID; set => bookingID = value; }
        public int GuestID { get => guestID; set => guestID = value; }
        public int RoomID { get => roomID; set => roomID = value; }
        public DateTime CheckInDate { get => checkInDate; set => checkInDate = value; }
        public DateTime CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public string BookingStatus { get => bookingStatus; set => bookingStatus = value; }
        public decimal TotalAmount { get => totalAmount; set => totalAmount = value; }
        public int ReceptionistID { get => receptionistID; set => receptionistID = value; }
        #endregion

        #region Constructors
        public Booking() { }

        public Booking(int bookingID, int guestID, int roomID, DateTime checkInDate, DateTime checkOutDate,
                       string bookingStatus, decimal totalAmount, int receptionistID)
        {
            BookingID = bookingID;
            GuestID = guestID;
            RoomID = roomID;
            CheckInDate = checkInDate;
            CheckOutDate = checkOutDate;
            BookingStatus = bookingStatus;
            TotalAmount = totalAmount;
            ReceptionistID = receptionistID;
        }
        #endregion

        #region Methods
        public override string ToString() =>
            $"Booking #{BookingID}: Guest {GuestID}, Room {RoomID}, {CheckInDate:d} - {CheckOutDate:d}, Status: {BookingStatus}";
        #endregion
    }
}
