using System;

namespace Group5HotelsProject.Business
{
    public abstract class Person
    {
        #region Attributes
        private int personID;
        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string email;
        private string address;
        private string city;
        #endregion

        #region Properties
        public int PersonID { get => personID; set => personID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }

        public string FullName => $"{FirstName} {LastName}";
        #endregion

        #region Constructors
        protected Person() { }

        protected Person(int personID, string firstName, string lastName, string phoneNumber, string email, string address, string city)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
            City = city;
        }
        #endregion

        #region Methods
        public override string ToString() => $"{FullName} ({Email})";
        #endregion
    }
}
