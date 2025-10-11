using System;
using System.Collections.ObjectModel;
using Group5HotelsProject.Business;
using Group5HotelsProject.Data;

namespace Group5HotelsProject.Controllers
{
    public class RoomController
    {
        private RoomDB roomDB;
        private Collection<Room> rooms;

        public Collection<Room> AllRooms => rooms;

        public RoomController()
        {
            roomDB = new RoomDB();
            rooms = roomDB.AllRooms;
        }

        public void AddRoom(Room room)
        {
            if (room == null) throw new ArgumentNullException(nameof(room));
            roomDB.DataSetChange(room, DB.DBOperation.Add);
            roomDB.UpdateDataSource(room);
        }

        public void EditRoom(Room room)
        {
            if (room == null) throw new ArgumentNullException(nameof(room));
            roomDB.DataSetChange(room, DB.DBOperation.Edit);
            roomDB.UpdateDataSource(room);
        }

        public void DeleteRoom(Room room)
        {
            if (room == null) throw new ArgumentNullException(nameof(room));
            roomDB.DataSetChange(room, DB.DBOperation.Delete);
            roomDB.UpdateDataSource(room);
        }

        public Room FindRoom(int roomID)
        {
            foreach (var r in rooms)
                if (r.RoomID == roomID) return r;
            return null;
        }

        public Collection<Room> GetRoomsByStatus(string status)
        {
            var result = new Collection<Room>();
            foreach (var r in rooms)
                if (r.RoomStatus.Equals(status, StringComparison.OrdinalIgnoreCase))
                    result.Add(r);
            return result;
        }

        public void RefreshFromDatabase()
        {
            roomDB = new RoomDB();
            rooms = roomDB.AllRooms;
        }
    }
}
