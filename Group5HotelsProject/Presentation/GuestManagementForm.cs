using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group5HotelsProject.Business;
using Group5HotelsProject.Controllers;
namespace Group5HotelsProject.Presentation
{
    public partial class GuestManagementForm : Form
    {
        private GuestController guestController;
        public GuestManagementForm()
        {
            InitializeComponent();
            guestController = new GuestController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addNewGuestButton_Click(object sender, EventArgs e)
        {
            string firstName = nameTextBox.Text;
            string lastName = SurnameTextBox.Text;
            string phoneNumber = phoneTextBox.Text;
            string email = emailTextBox.Text;
            string address = addressTextBox.Text;
            string idNumber = idTextBox.Text;
            string city = CityTextBox.Text;
            string postalCode = PostalCodeTextBox.Text;
            string addreess = addressTextBox.Text;

            Guest newGuest = new Guest
            {
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address,
                City = city,
                PostalCode = postalCode,
                IDPassportNumber = idNumber
            };

            guestController.AddGuest(newGuest);
            guestResultsGrid.DataSource = guestController.AllGuests;



        }

        private void GuestManagementForm_Load(object sender, EventArgs e)
        {
            searchByComboBox.Items.Add("First Name");
            searchByComboBox.Items.Add("Last Name");
            searchByComboBox.Items.Add("ID/Passport Number");
            searchByComboBox.SelectedIndex = 0; // Default to first option

            guestResultsGrid.DataSource = guestController.AllGuests;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            int searchBy = searchByComboBox.SelectedIndex;
            string searchText = searchTermTextBox.Text.Trim();
            switch (searchBy)
            {
                case 0:
                    guestResultsGrid.DataSource = guestController.GetGuestsByFirstName(searchText);
                    break;
                case 1:
                    guestResultsGrid.DataSource = guestController.GetGuestsByLastName(searchText);
                    break;
                case 2:
                    guestResultsGrid.DataSource = guestController.GetGuestsByIDNumber(searchText);
                    break;


            }
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {

        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
