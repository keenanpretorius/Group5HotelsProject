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
        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public int GuestID
        {
            get { return guestID; }
            set { guestID = value; }
        }

        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public int ReceptionistID
        {
            get { return receptionistID; }
            set { receptionistID = value; }
        }

        public string BookingReference
        {
            get { return bookingReference; }
            set { bookingReference = value; }
        }

        public DateTime CheckInDate
        {
            get { return checkInDate; }
            set { checkInDate = value; }
        }

        public DateTime CheckOutDate
        {
            get { return checkOutDate; }
            set { checkOutDate = value; }
        }

        public int NumberOfGuests
        {
            get { return numberOfGuests; }
            set { numberOfGuests = value; }
        }

        public int NumberOfNights
        {
            get { return numberOfNights; }
            set { numberOfNights = value; }
        }

        public decimal TotalAmount
        {
            get { return totalAmount; }
            set { totalAmount = value; }
        }

        public string BookingStatus
        {
            get { return bookingStatus; }
            set { bookingStatus = value; }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set { createdDate = value; }
        }
        #endregion

        #region Constructors
        public Booking()
        {
        }

        public Booking(
            int bookingID,
            int guestID,
            int roomID,
            int receptionistID,

            string bookingReference,

            DateTime checkInDate,
            DateTime checkOutDate,
            int numberOfGuests,
            decimal totalAmount,
            string bookingStatus,
            DateTime createdDate)
        {
            this.bookingID = bookingID;
            this.guestID = guestID;
            this.roomID = roomID;
            this.receptionistID = receptionistID;

            this.bookingReference = bookingReference;

            this.checkInDate = checkInDate;
            this.checkOutDate = checkOutDate;
            this.numberOfGuests = numberOfGuests;
            
            this.totalAmount = totalAmount;
            this.bookingStatus = bookingStatus;
            this.createdDate = createdDate;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Booking #" + bookingID + " (" + bookingReference + ") - Guest " + guestID +
                   ", Room " + roomID + ", " + checkInDate.ToShortDateString() +
                   " to " + checkOutDate.ToShortDateString() + ", Status: " + bookingStatus;
        }
        #endregion
    }
}
