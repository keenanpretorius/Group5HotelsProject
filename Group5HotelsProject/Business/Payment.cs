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
        public int PaymentID { get => paymentID; set => paymentID = value; }
        public int BookingID { get => bookingID; set => bookingID = value; }
        public DateTime PaymentDate { get => paymentDate; set => paymentDate = value; }
        public decimal AmountPaid { get => amountPaid; set => amountPaid = value; }
        public string PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        #endregion

        #region Constructors
        public Payment() { }

        public Payment(int paymentID, int bookingID, DateTime paymentDate, decimal amountPaid, string paymentMethod)
        {
            PaymentID = paymentID;
            BookingID = bookingID;
            PaymentDate = paymentDate;
            AmountPaid = amountPaid;
            PaymentMethod = paymentMethod;
        }
        #endregion

        #region Methods
        public override string ToString() => $"Payment #{PaymentID}: {AmountPaid:C} via {PaymentMethod} on {PaymentDate:d}";
        #endregion
    }
}
