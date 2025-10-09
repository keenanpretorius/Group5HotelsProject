namespace Group5HotelsProject.Business
{
    public class Hotel
    {
        #region Attributes
        private int hotelID;
        private string name;
        private string address;
        private string phoneNumber;
        private string email;
        #endregion

        #region Properties
        public int HotelID
        {
            get { return hotelID; }
            set { hotelID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return name + " (" + phoneNumber + ")";
        }
        #endregion
    }
}
