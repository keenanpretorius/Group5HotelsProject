using Group5HotelsProject.Business;
using Group5HotelsProject.Data;
using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;

namespace Group5HotelsProject.Controllers
{
    public class BookingController
    {
        #region Attributes
        private BookingDB bookingDB;
        private Collection<Booking> bookings;
        private RoomDB roomDB;
        private Collection<Room> rooms;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get { return bookings; }
        }

        public Collection<Room> AllRooms
        {
            get { return rooms; }
        }
        #endregion

        #region Constructors
        public BookingController()
        {
            bookingDB = new BookingDB();
            bookings = bookingDB.AllBookings;


            roomDB = new RoomDB();
            rooms = roomDB.AllRooms;
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

        public void AddRoom(Room room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room), "Room cannot be null.");
            roomDB.DataSetChange(room, DB.DBOperation.Add);
            roomDB.UpdateDataSource(room);
        }

        public void EditRoom(Room updatedRoom)
        {
            if (updatedRoom == null)
                throw new ArgumentNullException(nameof(updatedRoom), "Updated room cannot be null.");
            roomDB.DataSetChange(updatedRoom, DB.DBOperation.Edit);
            roomDB.UpdateDataSource(updatedRoom);
        }

        public void DeleteRoom(Room room)
        {
            if (room == null)
                throw new ArgumentNullException(nameof(room), "Room to delete cannot be null.");
            roomDB.DataSetChange(room, DB.DBOperation.Delete);
            roomDB.UpdateDataSource(room);
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
        
        public Room FindRoom(int roomID)
        {
            foreach (Room r in rooms)
            {
                if (r.RoomID == roomID)
                {
                    return r;
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

        public Collection<Room> GetAvailableRoomsInDateRange(DateTime start, DateTime end)
        {
            Collection<Booking> bookingsInRange = new Collection<Booking>();
            bookingsInRange = GetBookingsInDateRange(start, end);

            Collection<Room> result = new Collection<Room>(rooms);
            
            foreach (Booking b in bookingsInRange)
                {
                Room room = FindRoom(b.RoomID);
                if (room != null)
                {
                    result.Remove(room);
                }
            }
            return result;
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
            roomDB = new RoomDB();
            rooms = roomDB.AllRooms;
        }

        public decimal CalculateBaseCost(DateTime start, DateTime end)
        {
       
            decimal totalCost = 0;

            while (start.CompareTo(end) == -1) { 
                if (start.Month == 12)
                {
                    if (start.Day >= 1 && start.Day <= 7)
                    {
                        totalCost += 550;
                    }
                    else if (start.Day >= 8 && start.Day <= 15)
                    {
                        totalCost += 750;
                    }
                    else if (start.Day >= 16 && start.Day <= 31)
                    {
                        totalCost += 995;
                    }
                }
                start = start.AddDays(1);
            }

            return totalCost;

        }
        #endregion
    }
}
