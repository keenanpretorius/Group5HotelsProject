using Group5HotelsProject.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group5HotelsProject.Data
{
    public class RoomDB : DB
    {
        #region Attributes
        private string table = "Room";
        private string sql = "SELECT * FROM Room";
        private Collection<Room> rooms;
        #endregion

        #region Properties
        public Collection<Room> AllRooms
        {
            get { return rooms; }
        }
        #endregion

        #region Constructors
        public RoomDB()
        {
            rooms = new Collection<Room>();
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
                    Room room = new Room();
                    room.RoomID = Convert.ToInt32(row["RoomID"]);
                    room.RoomNumber = row["RoomNumber"].ToString();
                    room.RoomType = row["RoomType"].ToString();
                    room.MaxOccupancy = Convert.ToInt32(row["MaxOccupancy"]);
                    room.RoomStatus = row["RoomStatus"].ToString();
                    room.Description = row["Description"].ToString();

                    rooms.Add(room);
                }
            }
        }
        #endregion

        #region Public Methods
        public void DataSetChange(Room room, DBOperation operation)
        {
            DataRow row = null;

            switch (operation)
            {
                case DBOperation.Add:
                    row = dsMain.Tables[table].NewRow();
                    row["RoomID"] = room.RoomID;
                    row["RoomNumber"] = room.RoomNumber;
                    row["RoomType"] = room.RoomType;
                    row["MaxOccupancy"] = room.MaxOccupancy;
                    row["RoomStatus"] = room.RoomStatus;
                    row["Description"] = room.Description;
                    dsMain.Tables[table].Rows.Add(row);
                    rooms.Add(room);
                    break;

                case DBOperation.Edit:
                    foreach (DataRow r in dsMain.Tables[table].Rows)
                    {
                        if (Convert.ToInt32(r["RoomID"]) == room.RoomID)
                        {
                            r["RoomNumber"] = room.RoomNumber;
                            r["RoomType"] = room.RoomType;
                            r["MaxOccupancy"] = room.MaxOccupancy;
                            r["RoomStatus"] = room.RoomStatus;
                            r["Description"] = room.Description;
                            break;
                        }
                    }
                    break;

                case DBOperation.Delete:
                    for (int i = 0; i < dsMain.Tables[table].Rows.Count; i++)
                    {
                        if (Convert.ToInt32(dsMain.Tables[table].Rows[i]["RoomID"]) == room.RoomID)
                        {
                            dsMain.Tables[table].Rows[i].Delete();
                            break;
                        }
                    }
                    rooms.Remove(room);
                    break;
            }
        }

        public void UpdateDataSource(Room room)
        {
            UpdateDataSource(sql, table);
        }
        #endregion
    }
}
