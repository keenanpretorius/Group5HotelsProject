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
        public int RateID { get => rateID; set => rateID = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public decimal DailyRate { get => dailyRate; set => dailyRate = value; }
        public int SeasonID { get => seasonID; set => seasonID = value; }
        #endregion

        #region Constructors
        public Rate() { }

        public Rate(int rateID, string roomType, decimal dailyRate, int seasonID)
        {
            RateID = rateID;
            RoomType = roomType;
            DailyRate = dailyRate;
            SeasonID = seasonID;
        }
        #endregion

        #region Methods
        public override string ToString() => $"{RoomType}: {DailyRate:C} (Season {SeasonID})";
        #endregion
    }
}
