using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class NewBookingForm : Form

    {
        private BookingController bookingController;
        private GuestController guestController;
        public NewBookingForm()
        {
            InitializeComponent();
            bookingController = new BookingController();
            guestController = new GuestController();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewBookingForm_Load(object sender, EventArgs e)
        {

        }

        private void checkAvailablityButton_Click(object sender, EventArgs e)
        {

            // Code to check room availability based on selected dates
            DateTime checkInDate = checkInDatePicker.Value;
            DateTime checkOutDate = checkOutDatePicker.Value;
            if (checkInDate >= checkOutDate)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Here you would typically call a method from your BookingController to check availability
            bool isAvailable = true;
            Collection<Room> availableRooms = new Collection<Room>(bookingController.GetAvailableRoomsInDateRange(checkInDate, checkOutDate));
            if (availableRooms.Count <= 0)
            {
                isAvailable = false;
            }


            if (isAvailable)
            {
                MessageBox.Show("Rooms are available for the selected dates.", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                roomAvailabilityGrid.DataSource = availableRooms;

            }
            else
            {
                MessageBox.Show("No rooms available for the selected dates.", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void addNewGuestButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = "Tim";
            SurnameTextBox.Text = "Sasman";
            phoneTextBox.Text = "0626256607";
            emailTextBox.Text = "timsas@gmial.com";
            addressTextBox.Text = "Cape Town,8001,123 Street";
            IDTextBox.Text = "123456789";
            string firstName = nameTextBox.Text;
            string lastName = SurnameTextBox.Text;
            string PhoneNumber = phoneTextBox.Text;

            string email = emailTextBox.Text;
            string IDNumber = IDTextBox.Text;

            string[] addressParts = addressTextBox.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            string city = addressParts[0];
            string postalCode = addressParts[1];
            string address = addressParts[2];

            Guest newGuest = new Guest(123456789, firstName, lastName,PhoneNumber,email,address,city,postalCode,IDNumber);
            
            guestController.AddGuest(newGuest);

            MessageBox.Show("New guest added successfully."+ newGuest.ToString, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
