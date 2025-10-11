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
using System.Collections.ObjectModel;


namespace Group5HotelsProject.Presentation
{
    public partial class ChangeCancelBookingForm : Form
    {
        GuestController guestController;
        BookingController bookingController;


        public ChangeCancelBookingForm()
        {
            InitializeComponent();
            guestController = new GuestController();
            bookingController = new BookingController();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string idNumber = IDTextBox.Text;
            Guest guest = guestController.GetGuestsByIDNumber(idNumber)[0];
            int guestID = guest.GuestID;
            MessageBox.Show("Guest found: " + guest.FirstName + " " + guest.LastName);

            Collection<Booking> bookings = bookingController.GetBookingsByGuest(guestID);
            foreach (Booking b in bookings)
            {
                SelectBookingComboBox.Items.Add(b.BookingID);
            }




        }

        private void SelectBookingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedBookingID = SelectBookingComboBox.SelectedItem.ToString();
            Booking booking = bookingController.FindBooking(int.Parse(selectedBookingID));

            bookingReferenceTextBox.Text = booking.BookingReference;
            statusTextBox.Text = booking.BookingStatus;

            checkInDatePicker.Value = booking.CheckInDate;
            checkOutDatePicker.Value = booking.CheckOutDate;
           // roomCostLab
        }
    }
}
