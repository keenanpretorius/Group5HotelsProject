using System;
using System.Collections.ObjectModel;
using System.Data;
using Group5HotelsProject.Business;

namespace Group5HotelsProject.Data
{
    public class GuestDB : DB
    {
        #region Attributes
        private string table = "Guest";
        private string sql = "SELECT * FROM Guest";
        private Collection<Guest> guests;
        #endregion

        #region Properties
        public Collection<Guest> AllGuests
        {
            get { return guests; }
        }
        #endregion

        #region Constructors
        public GuestDB()
        {
            guests = new Collection<Guest>();
            FillDataSet(sql, table);
            Add2Collection();
        }
        #endregion

        #region Private Methods
        private void Add2Collection()
        {
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    Guest guest = new Guest();
                    guest.GuestID = Convert.ToInt32(row["GuestID"]);
                    guest.FirstName = row["FirstName"].ToString();
                    guest.LastName = row["LastName"].ToString();
                    guest.Address = row["_Address"].ToString();
                    guest.City = row["City"].ToString();
                    guest.PostalCode = row["PostalCode"].ToString();
                    guest.PhoneNumber = row["Phonenumber"].ToString();
                    guest.Email = row["Email"].ToString();
                    guest.IDPassportNumber = row["idpassportnumber"].ToString();
                    guest.LoyaltyStatus = row["LoyaltyStatus"].ToString();

                    guests.Add(guest);
                }
            }
        }
        #endregion

        #region Public Methods
        public void DataSetChange(Guest guest, DBOperation operation)
        {
            DataRow row = null;

            switch (operation)
            {
                case DBOperation.Add:
                    row = dsMain.Tables[table].NewRow();
                    row["GuestID"] = guest.GuestID;
                    row["FirstName"] = guest.FirstName;
                    row["LastName"] = guest.LastName;
                    row["_Address"] = guest.Address;
                    row["City"] = guest.City;
                    row["PostalCode"] = guest.PostalCode;
                    row["Phonenumber"] = guest.PhoneNumber;
                    row["Email"] = guest.Email;
                    row["idpassportnumber"] = guest.IDPassportNumber;
                    row["LoyaltyStatus"] = guest.LoyaltyStatus;
                    dsMain.Tables[table].Rows.Add(row);
                    guests.Add(guest);
                    break;

                case DBOperation.Edit:
                    foreach (DataRow r in dsMain.Tables[table].Rows)
                    {
                        if (Convert.ToInt32(r["GuestID"]) == guest.GuestID)
                        {
                            r["FirstName"] = guest.FirstName;
                            r["LastName"] = guest.LastName;
                            r["_Address"] = guest.Address;
                            r["City"] = guest.City;
                            r["PostalCode"] = guest.PostalCode;
                            r["Phonenumber"] = guest.PhoneNumber;
                            r["Email"] = guest.Email;
                            r["idpassportnumber"] = guest.IDPassportNumber;
                            r["LoyaltyStatus"] = guest.LoyaltyStatus;
                            break;
                        }
                    }
                    break;

                case DBOperation.Delete:
                    for (int i = 0; i < dsMain.Tables[table].Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dsMain.Tables[table].Rows[i]["GuestID"]) == guest.GuestID)
                        {
                            dsMain.Tables[table].Rows[i].Delete();
                            break;
                        }
                    }
                    guests.Remove(guest);
                    break;
            }
        }

        public void UpdateDataSource(Guest guest)
        {
            UpdateDataSource(sql, table);
        }
        #endregion
    }
}
