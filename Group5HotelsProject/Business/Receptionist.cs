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
        public int ReceptionistID { get => receptionistID; set => receptionistID = value; }
        public string EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public string Username { get => username; set => username = value; }
        public string PasswordHash { get => passwordHash; set => passwordHash = value; }
        public DateTime DateHired { get => dateHired; set => dateHired = value; }
        #endregion

        #region Constructors
        public Receptionist() { }

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
            ReceptionistID = receptionistID;
            EmployeeNumber = employeeNumber;
            Username = username;
            PasswordHash = passwordHash;
            DateHired = dateHired;
        }
        #endregion

        #region Methods
        public override string ToString() => $"{FullName} (Receptionist #{EmployeeNumber})";
        #endregion
    }
}
