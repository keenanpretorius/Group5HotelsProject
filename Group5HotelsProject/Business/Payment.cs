using System;

namespace Group5HotelsProject.Business
{
    public class Payment
    {
        #region Attributes
        private int paymentID;
        private int bookingID;
        private DateTime paymentDate;
        private decimal amountPaid;
        private string paymentMethod;
        #endregion

        #region Properties
        public int PaymentID
        {
            get { return paymentID; }
            set { paymentID = value; }
        }

        public int BookingID
        {
            get { return bookingID; }
            set { bookingID = value; }
        }

        public DateTime PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        public decimal AmountPaid
        {
            get { return amountPaid; }
            set { amountPaid = value; }
        }

        public string PaymentMethod
        {
            get { return paymentMethod; }
            set { paymentMethod = value; }
        }
        #endregion

        #region Constructors
        public Payment()
        {
        }

        public Payment(int paymentID, int bookingID, DateTime paymentDate, decimal amountPaid, string paymentMethod)
        {
            this.paymentID = paymentID;
            this.bookingID = bookingID;
            this.paymentDate = paymentDate;
            this.amountPaid = amountPaid;
            this.paymentMethod = paymentMethod;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return "Payment #" + paymentID + ": " + amountPaid.ToString("C") +
                   " via " + paymentMethod + " on " + paymentDate.ToShortDateString();
        }
        #endregion
    }
}
