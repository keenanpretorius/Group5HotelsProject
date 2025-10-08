using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using Group5HotelsProject.Business;

namespace Group5HotelsProject.Data
{
    public class GuestDB : DB
    {
        private string table = "Guest";
        private string sql = "SELECT * FROM Guest";
        private Collection<Guest> guests;

        public Collection<Guest> AllGuests => guests;

        public GuestDB()
        {
            guests = new Collection<Guest>();
            FillDataSet(sql, table);
            Add2Collection();
        }

        private void Add2Collection()
        {
            foreach (DataRow row in dsMain.Tables[table].Rows)
            {
                if (row.RowState != DataRowState.Deleted)
                {
                    Guest guest = new Guest
                    {
                        GuestID = Convert.ToInt32(row["GuestID"]),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Address = row["_Address"].ToString(),
                        City = row["City"].ToString(),
                        PostalCode = row["PostalCode"].ToString(),
                        Phonenumber = Convert.ToInt32(row["Phonenumber"]),
                        Email = row["Email"].ToString(),
                        IdPassportNumber = Convert.ToInt32(row["Id_PassportNumber"])
                    };
                    guests.Add(guest);
                }
            }
        }
    }
}
