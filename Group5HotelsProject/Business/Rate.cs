using System;

namespace Group5HotelsProject.Business
{
    public class Rate
    {
        #region Attributes
        private int rateID;
        private string roomType;
        private decimal dailyRate;
        private int seasonID;
        #endregion

        #region Properties
        public int RateID
        {
            get { return rateID; }
            set { rateID = value; }
        }

        public string RoomType
        {
            get { return roomType; }
            set { roomType = value; }
        }

        public decimal DailyRate
        {
            get { return dailyRate; }
            set { dailyRate = value; }
        }

        public int SeasonID
        {
            get { return seasonID; }
            set { seasonID = value; }
        }
        #endregion

        #region Constructors
        public Rate()
        {
        }

        public Rate(int rateID, string roomType, decimal dailyRate, int seasonID)
        {
            this.rateID = rateID;
            this.roomType = roomType;
            this.dailyRate = dailyRate;
            this.seasonID = seasonID;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return roomType + ": " + dailyRate.ToString("C") + " (Season " + seasonID + ")";
        }
        #endregion
    }
}
