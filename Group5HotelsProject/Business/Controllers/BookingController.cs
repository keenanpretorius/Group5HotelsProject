using System;
using System.Collections.ObjectModel;
using Group5HotelsProject.Business;
using Group5HotelsProject.Data;

namespace Group5HotelsProject.Controllers
{
    public class BookingController
    {
        #region Attributes
        private BookingDB bookingDB;
        private Collection<Booking> bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }
        #endregion

        #region Constructors
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }
        #endregion

        #region CRUD Methods
        public void AddBooking(Booking booking)
        {
            if (booking == null)
                throw new ArgumentNullException(nameof(booking), "Booking cannot be null.");

            bookingDB.DataSetChange(booking, DB.DBOperation.Add);
            bookingDB.UpdateDataSource(booking);
        }

        public void EditBooking(Booking updatedBooking)
        {
            if (updatedBooking == null)
                throw new ArgumentNullException(nameof(updatedBooking), "Updated booking cannot be null.");

            bookingDB.DataSetChange(updatedBooking, DB.DBOperation.Edit);
            bookingDB.UpdateDataSource(updatedBooking);
        }

        public void DeleteBooking(Booking booking)
        {
            if (booking == null)
                throw new ArgumentNullException(nameof(booking), "Booking to delete cannot be null.");

            bookingDB.DataSetChange(booking, DB.DBOperation.Delete);
            bookingDB.UpdateDataSource(booking);
        }
        #endregion

        #region Lookup / Query Methods
        public Booking FindBooking(int bookingID)
        {
            foreach (Booking b in bookings)
            {
                if (b.BookingID == bookingID)
                {
                    return b;
                }
            }
            return null;
        }

        public Collection<Booking> GetBookingsByGuest(int guestID)
        {
            Collection<Booking> results = new Collection<Booking>();
            foreach (Booking b in bookings)
            {
                if (b.GuestID == guestID)
                {
                    results.Add(b);
                }
            }
            return results;
        }

        public Collection<Booking> GetBookingsByStatus(string status)
        {
            Collection<Booking> results = new Collection<Booking>();
            foreach (Booking b in bookings)
            {
                if (string.Equals(b.BookingStatus, status, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(b);
                }
            }
            return results;
        }

        public Collection<Booking> GetBookingsInDateRange(DateTime start, DateTime end)
        {
            Collection<Booking> results = new Collection<Booking>();
            foreach (Booking b in bookings)
            {
                if (b.CheckInDate >= start && b.CheckOutDate <= end)
                {
                    results.Add(b);
                }
            }
            return results;
        }

        public decimal GetTotalRevenue()
        {
            decimal total = 0;
            foreach (Booking b in bookings)
            {
                total += b.TotalAmount;
            }
            return total;
        }

        public int GetNextBookingID()
        {
            int maxID = 0;
            if (bookings.Count == 0)
                return 1;

            foreach (Booking b in bookings)
            {
                if (b.BookingID > maxID)
                {
                    maxID = b.BookingID;
                }
            }

            return maxID + 1;
        }
        #endregion

        #region Utility Methods
        public void RefreshFromDatabase()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;
        }
        #endregion
    }
}
