using System;

namespace Group5HotelsProject.Business
{
    public class Receptionist : Person
    {
        #region Attributes
        private int receptionistID;
        private string employeeNumber;
        private string username;
        private string passwordHash;
        private DateTime dateHired;
        #endregion

        #region Properties
        public int ReceptionistID
        {
            get { return receptionistID; }
            set { receptionistID = value; }
        }

        public string EmployeeNumber
        {
            get { return employeeNumber; }
            set { employeeNumber = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string PasswordHash
        {
            get { return passwordHash; }
            set { passwordHash = value; }
        }

        public DateTime DateHired
        {
            get { return dateHired; }
            set { dateHired = value; }
        }
        #endregion

        #region Constructors
        public Receptionist()
        {
        }

        public Receptionist(
            int receptionistID,
            string firstName,
            string lastName,
            string phoneNumber,
            string email,
            string address,
            string city,
            string employeeNumber,
            string username,
            string passwordHash,
            DateTime dateHired
        ) : base(receptionistID, firstName, lastName, phoneNumber, email, address, city)
        {
            this.receptionistID = receptionistID;
            this.employeeNumber = employeeNumber;
            this.username = username;
            this.passwordHash = passwordHash;
            this.dateHired = dateHired;
        }
        #endregion

        #region Methods
        public override string ToString()
        {
            return FullName + " (Receptionist #" + employeeNumber + ")";
        }
        #endregion
    }
}
