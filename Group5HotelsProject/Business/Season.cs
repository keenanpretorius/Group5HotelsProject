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
        public int SeasonID
        {
            get { return seasonID; }
            set { seasonID = value; }
        }

        public string SeasonName
        {
            get { return seasonName; }
            set { seasonName = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        #endregion

        #region Constructors
        public Season()
        {
        }

        public Season(int seasonID, string seasonName, DateTime startDate, DateTime endDate)
        {
            this.seasonID = seasonID;
            this.seasonName = seasonName;
            this.startDate = startDate;
            this.endDate = endDate;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return seasonName + " (" + startDate.ToShortDateString() + " - " + endDate.ToShortDateString() + ")";
        }
        #endregion
    }
}
