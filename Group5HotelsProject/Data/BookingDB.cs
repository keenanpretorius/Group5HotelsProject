using System;
using System.Collections.ObjectModel;
using System.Data;
using Group5HotelsProject.Business;

namespace Group5HotelsProject.Data
{
    public class BookingDB : DB
    {
        #region Attributes
        private string table = "Booking";
        private string sql = "SELECT * FROM Booking";
        private Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings => bookings;
        #endregion

        #region Constructors
        public BookingDB()
        {
            bookings = new Collection<Booking>();
            FillDataSet(sql, table);
            Add2Collection();
        }
        #endregion

        #region Private Methods
        private void Add2Collection()
        {
            bookings.Clear();
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    Booking booking = new Booking
                    {
                        BookingID = Convert.ToInt32(row["BookingID"]),
                        GuestID = Convert.ToInt32(row["GuestID"]),
                        RoomID = Convert.ToInt32(row["RoomID"]),
                        ReceptionistID = Convert.ToInt32(row["ReceptionistID"]),
                        BookingReference = row["BookingReference"].ToString(),
                        CheckInDate = Convert.ToDateTime(row["CheckInDate"]),
                        CheckOutDate = Convert.ToDateTime(row["CheckOutDate"]),
                        NumberOfGuests = Convert.ToInt32(row["NumberOfGuests"]),
                        NumberOfNights = Convert.ToInt32(row["NumberOfNights"]),
                        TotalAmount = Convert.ToDecimal(row["TotalAmount"]),
                        BookingStatus = row["BookingStatus"].ToString(),
                        CreatedDate = Convert.ToDateTime(row["CreatedDate"])
                    };
                    bookings.Add(booking);
                }
            }
        }

        private void FillRow(DataRow row, Booking booking, DB.DBOperation operation)
        {
            if (operation == DB.DBOperation.Add)
            {
                row["BookingID"] = booking.BookingID;
            }

            row["GuestID"] = booking.GuestID;
            row["RoomID"] = booking.RoomID;
            row["ReceptionistID"] = booking.ReceptionistID;
            row["BookingReference"] = booking.BookingReference;
            row["CheckInDate"] = booking.CheckInDate;
            row["CheckOutDate"] = booking.CheckOutDate;
            row["NumberOfGuests"] = booking.NumberOfGuests;
            row["NumberOfNights"] = booking.NumberOfNights;
            row["TotalAmount"] = booking.TotalAmount;
            row["BookingStatus"] = booking.BookingStatus;
            row["CreatedDate"] = booking.CreatedDate;
        }
        #endregion

        #region CRUD Sync Methods
        public void DataSetChange(Booking booking, DB.DBOperation operation)
        {
            DataRow row;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    row = dsMain.Tables[dataTable].NewRow();
                    FillRow(row, booking, operation);
                    dsMain.Tables[dataTable].Rows.Add(row);
                    break;

                case DB.DBOperation.Edit:
                    row = dsMain.Tables[dataTable].Rows.Find(booking.BookingID);
                    FillRow(row, booking, operation);
                    break;

                case DB.DBOperation.Delete:
                    row = dsMain.Tables[dataTable].Rows.Find(booking.BookingID);
                    row.Delete();
                    break;
            }
        }

        public bool UpdateDataSource(Booking booking)
        {
            return UpdateDataSource(sql, table);
        }
        #endregion
    }
}
