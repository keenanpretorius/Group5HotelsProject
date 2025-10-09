using System;
using System.Collections.ObjectModel;
using Group5HotelsProject.Business;
using Group5HotelsProject.Data;

namespace Group5HotelsProject.Controllers
{
    public class GuestController
    {
        #region Attributes
        private GuestDB guestDB;
        private Collection<Guest> guests;
        #endregion

        #region Properties
        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }
        #endregion

        #region Constructors
        public GuestController()
        {
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }
        #endregion

        #region CRUD Methods
        public void AddGuest(Guest guest)
        {
            if (guest == null)
                throw new ArgumentNullException(nameof(guest), "Guest cannot be null.");

            guestDB.DataSetChange(guest, DB.DBOperation.Add);
            guestDB.UpdateDataSource(guest);
        }

        public void EditGuest(Guest updatedGuest)
        {
            if (updatedGuest == null)
                throw new ArgumentNullException(nameof(updatedGuest), "Updated guest cannot be null.");

            guestDB.DataSetChange(updatedGuest, DB.DBOperation.Edit);
            guestDB.UpdateDataSource(updatedGuest);
        }

        public void DeleteGuest(Guest guest)
        {
            if (guest == null)
                throw new ArgumentNullException(nameof(guest), "Guest to delete cannot be null.");

            guestDB.DataSetChange(guest, DB.DBOperation.Delete);
            guestDB.UpdateDataSource(guest);
        }
        #endregion

        #region Lookup / Query Methods
        public Guest FindGuest(int guestID)
        {
            foreach (Guest g in guests)
            {
                if (g.GuestID == guestID)
                    return g;
            }
            return null;
        }

        public Collection<Guest> GetGuestsByLoyaltyStatus(string loyaltyStatus)
        {
            Collection<Guest> results = new Collection<Guest>();
            foreach (Guest g in guests)
            {
                if (string.Equals(g.LoyaltyStatus, loyaltyStatus, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(g);
                }
            }
            return results;
        }
        #endregion

        #region Utility Methods
        public void RefreshFromDatabase()
        {
            guestDB = new GuestDB();
            guests = guestDB.AllGuests;
        }
        #endregion
    }
}
