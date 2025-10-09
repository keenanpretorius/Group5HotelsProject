using System;

namespace Group5HotelsProject.Business
{
    public class Room
    {
        #region Attributes
        private int roomID;
        private string roomNumber;
        private string roomType;
        private int maxOccupancy;
        private string roomStatus;
        private string description;
        #endregion

        #region Properties
        public int RoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public int MaxOccupancy
        {
            get { return maxOccupancy; }
            set { maxOccupancy = value; }
        }

        public string RoomStatus
        {
            get { return roomStatus; }
            set { roomStatus = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion

        #region Constructors
        public Room()
        {
        }

        public Room(int roomID, string roomNumber, string roomType, int maxOccupancy, string roomStatus, string description)
        {
            this.roomID = roomID;
            this.roomNumber = roomNumber;
            this.roomType = roomType;
            this.maxOccupancy = maxOccupancy;
            this.roomStatus = roomStatus;
            this.description = description;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return roomNumber + " - " + roomType + " (" + roomStatus + ")";
        }
        #endregion
    }
}
