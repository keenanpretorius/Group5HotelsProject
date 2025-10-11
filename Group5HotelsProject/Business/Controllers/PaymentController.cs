using System;
using System.Collections.ObjectModel;
using Group5HotelsProject.Business;
using Group5HotelsProject.Data;

namespace Group5HotelsProject.Controllers
{
    public class PaymentController
    {
        private PaymentDB paymentDB;
        private Collection<Payment> payments;

        public Collection<Payment> AllPayments => payments;

        public PaymentController()
        {
            paymentDB = new PaymentDB();
            payments = paymentDB.AllPayments;
        }

        public void AddPayment(Payment payment)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));
            paymentDB.DataSetChange(payment, DB.DBOperation.Add);
            paymentDB.UpdateDataSource(payment);
        }

        public void EditPayment(Payment payment)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));
            paymentDB.DataSetChange(payment, DB.DBOperation.Edit);
            paymentDB.UpdateDataSource(payment);
        }

        public void DeletePayment(Payment payment)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));
            paymentDB.DataSetChange(payment, DB.DBOperation.Delete);
            paymentDB.UpdateDataSource(payment);
        }

        public Payment FindPayment(int paymentID)
        {
            foreach (var p in payments)
                if (p.PaymentID == paymentID) return p;
            return null;
        }

        public Collection<Payment> GetPaymentsByBooking(int bookingID)
        {
            var result = new Collection<Payment>();
            foreach (var p in payments)
                if (p.BookingID == bookingID) result.Add(p);
            return result;
        }

        public decimal GetTotalPayments()
        {
            decimal total = 0;
            foreach (var p in payments) total += p.AmountPaid;
            return total;
        }

        public void RefreshFromDatabase()
        {
            paymentDB = new PaymentDB();
            payments = paymentDB.AllPayments;
        }
    }
}
