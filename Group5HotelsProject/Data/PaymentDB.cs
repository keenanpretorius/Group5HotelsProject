using System;
using System.Collections.ObjectModel;
using System.Data;
using Group5HotelsProject.Business;

namespace Group5HotelsProject.Data
{
    public class PaymentDB : DB
    {
        #region Attributes
        private string table = "Payment";
        private string sql = "SELECT * FROM Payment";
        private Collection<Payment> payments;
        #endregion

        #region Properties
        public Collection<Payment> AllPayments => payments;
        #endregion

        #region Constructors
        public PaymentDB()
        {
            payments = new Collection<Payment>();
            FillDataSet(sql, table);
            Add2Collection();
        }
        #endregion

        #region Private Methods
        private void Add2Collection()
        {
            payments.Clear();
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    Payment payment = new Payment
                    {
                        PaymentID = Convert.ToInt32(row["PaymentID"]),
                        BookingID = Convert.ToInt32(row["BookingID"]),
                        PaymentDate = Convert.ToDateTime(row["PaymentDate"]),
                        AmountPaid = Convert.ToDecimal(row["AmountPaid"]),
                        PaymentMethod = row["PaymentMethod"].ToString()
                    };
                    payments.Add(payment);
                }
            }
        }

        private void FillRow(DataRow row, Payment payment, DBOperation operation)
        {
            if (operation == DBOperation.Add)
            {
                row["PaymentID"] = payment.PaymentID;
            }
            row["BookingID"] = payment.BookingID;
            row["PaymentDate"] = payment.PaymentDate;
            row["AmountPaid"] = payment.AmountPaid;
            row["PaymentMethod"] = payment.PaymentMethod;
            row["TransactionID"] = Guid.NewGuid().ToString("N").Substring(0, 12).ToUpper();
            row["AccountID"] = payment.BookingID;
            row["CardNumber"] = payment.CardNumber;
        }
        #endregion

        #region CRUD Methods
        public void DataSetChange(Payment payment, DBOperation operation)
        {
            DataRow row;
            switch (operation)
            {
                case DBOperation.Add:
                    row = dsMain.Tables[table].NewRow();
                    FillRow(row, payment, operation);
                    dsMain.Tables[table].Rows.Add(row);
                    payments.Add(payment);
                    break;

                case DBOperation.Edit:
                    row = dsMain.Tables[table].Rows.Find(payment.PaymentID);
                    FillRow(row, payment, operation);
                    break;

                case DBOperation.Delete:
                    row = dsMain.Tables[table].Rows.Find(payment.PaymentID);
                    row.Delete();
                    payments.Remove(payment);
                    break;
            }
        }

        public bool UpdateDataSource(Payment payment)
        {
            return UpdateDataSource(sql, table);
        }
        #endregion
    }
}