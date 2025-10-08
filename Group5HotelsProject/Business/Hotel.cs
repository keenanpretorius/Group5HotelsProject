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
        public int HotelID { get => hotelID; set => hotelID = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        #endregion

        #region Methods
        public override string ToString() => $"{Name} ({PhoneNumber})";
        #endregion
    }
}
