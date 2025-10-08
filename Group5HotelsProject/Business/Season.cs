using System;

namespace Group5HotelsProject.Business
{
    public class Season
    {
        #region Attributes
        private int seasonID;
        private string seasonName;
        private DateTime startDate;
        private DateTime endDate;
        #endregion

        #region Properties
        public int SeasonID { get => seasonID; set => seasonID = value; }
        public string SeasonName { get => seasonName; set => seasonName = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        #endregion

        #region Constructors
        public Season() { }

        public Season(int seasonID, string seasonName, DateTime startDate, DateTime endDate)
        {
            SeasonID = seasonID;
            SeasonName = seasonName;
            StartDate = startDate;
            EndDate = endDate;
        }
        #endregion

        #region Methods
        public override string ToString() => $"{SeasonName} ({StartDate:d} - {EndDate:d})";
        #endregion
    }
}
