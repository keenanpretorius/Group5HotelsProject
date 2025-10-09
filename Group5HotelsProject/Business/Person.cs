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
        public int PersonID
        {
            get { return personID; }
            set { personID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
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

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        #endregion

        #region Constructors
        protected Person() { }

        protected Person(int personID, string firstName, string lastName, string phoneNumber, string email, string address, string city)
        {
            this.personID = personID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.city = city;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return FullName + " (" + Email + ")";
        }
        #endregion
    }
}
