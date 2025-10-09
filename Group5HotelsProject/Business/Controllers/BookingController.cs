using System;
using System.Collections.ObjectModel;
using System.Linq;
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

            // Add to the DataSet and in-memory collection
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
            return bookings.FirstOrDefault(b => b.BookingID == bookingID);
        }

        public Collection<Booking> GetBookingsByGuest(int guestID)
        {
            var results = bookings.Where(b => b.GuestID == guestID).ToList();
            return new Collection<Booking>(results);
        }

        public Collection<Booking> GetBookingsByStatus(string status)
        {
            var results = bookings
                .Where(b => string.Equals(b.BookingStatus, status, StringComparison.OrdinalIgnoreCase))
                .ToList();
            return new Collection<Booking>(results);
        }

        public Collection<Booking> GetBookingsInDateRange(DateTime start, DateTime end)
        {
            var results = bookings
                .Where(b => b.CheckInDate >= start && b.CheckOutDate <= end)
                .ToList();
            return new Collection<Booking>(results);
        }

        public decimal GetTotalRevenue()
        {
            return bookings.Sum(b => b.TotalAmount);
        }

        public int GetNextBookingID()
        {
            if (bookings.Count == 0)
                return 1;
            return bookings.Max(b => b.BookingID) + 1;
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
