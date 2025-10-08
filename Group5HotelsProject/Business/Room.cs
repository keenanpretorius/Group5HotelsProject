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
        public int RoomID { get => roomID; set => roomID = value; }
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public int MaxOccupancy { get => maxOccupancy; set => maxOccupancy = value; }
        public string RoomStatus { get => roomStatus; set => roomStatus = value; }
        public string Description { get => description; set => description = value; }
        #endregion

        #region Constructors
        public Room() { }

        public Room(int roomID, string roomNumber, string roomType, int maxOccupancy, string roomStatus, string description)
        {
            RoomID = roomID;
            RoomNumber = roomNumber;
            RoomType = roomType;
            MaxOccupancy = maxOccupancy;
            RoomStatus = roomStatus;
            Description = description;
        }
        #endregion

        #region Methods
        public override string ToString() => $"{RoomNumber} - {RoomType} ({RoomStatus})";
        #endregion
    }
}
