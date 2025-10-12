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
        private GuestController guestController;
        private BookingController bookingController;
        public enum FormMode { Edit, View, PreSelect }
        private FormMode currentMode;



        public ChangeCancelBookingForm()
        {
            InitializeComponent();
            guestController = new GuestController();
            bookingController = new BookingController();
            currentMode = FormMode.View;
        }

        public void ClearForm()
        {
            IDTextBox.Clear();
            SelectBookingComboBox.Items.Clear();
            bookingReferenceTextBox.Clear();
            statusTextBox.Clear();
            checkInDatePicker.Value = DateTime.Now;
            checkOutDatePicker.Value = DateTime.Now;
            nightsTextBox.Clear();
            roomCostTextBox.Clear();
            NumGuestsTextBox.Clear();
            totalCostTextBox.Clear();
            depositPaidTextBox.Clear();
        }

        public void ChangeMode(FormMode mode)
        {
            currentMode = mode;
            if ((currentMode == FormMode.View) || (currentMode == FormMode.PreSelect))
            {

                SaveSelectedButton.Enabled = false;
                SaveSelectedButton.Visible = false;

                cancelBookingbutton.Enabled = true;
                cancelBookingbutton.Visible = true;

                editButton.Enabled = true;
                editButton.Visible = true;

                bookingReferenceTextBox.ReadOnly = true;
                statusTextBox.ReadOnly = true;
                checkInDatePicker.Enabled = false;
                checkOutDatePicker.Enabled = false;
                nightsTextBox.ReadOnly = true;
                roomCostTextBox.ReadOnly = true;
                NumGuestsTextBox.ReadOnly = true;
                roomCostTextBox.ReadOnly = true;
                totalCostTextBox.ReadOnly = true;
                depositPaidTextBox.ReadOnly = true;

            }
            else if (currentMode == FormMode.Edit)
            {

                SaveSelectedButton.Enabled = true;
                SaveSelectedButton.Visible = true;

                cancelBookingbutton.Enabled = true;
                cancelBookingbutton.Visible = true;

                editButton.Enabled = false;
                editButton.Visible = false;

                bookingReferenceTextBox.ReadOnly = false;
                statusTextBox.ReadOnly = false;
                checkInDatePicker.Enabled = true;
                checkOutDatePicker.Enabled = true;
                nightsTextBox.ReadOnly = false;
                roomCostTextBox.ReadOnly = false;
                NumGuestsTextBox.ReadOnly = false;
            }

            if (currentMode == FormMode.PreSelect)
            {
                SaveSelectedButton.Enabled = false;
                SaveSelectedButton.Visible = false;
                cancelBookingbutton.Enabled = false;
                cancelBookingbutton.Visible = false;

                editButton.Enabled = false;
                editButton.Visible = false;


            }

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
            nightsTextBox.Text = booking.NumberOfNights.ToString();
            roomCostTextBox.Text = booking.TotalAmount.ToString();
            NumGuestsTextBox.Text = booking.NumberOfGuests.ToString();
            ChangeMode(FormMode.View);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            ChangeMode(FormMode.Edit);
        }

        private void SaveSelectedButton_Click(object sender, EventArgs e)
        {
            string selectedBookingID = SelectBookingComboBox.SelectedItem.ToString();

            Booking booking = bookingController.FindBooking(int.Parse(selectedBookingID));

            booking.BookingReference = bookingReferenceTextBox.Text;
            booking.BookingStatus = statusTextBox.Text;
            booking.CheckInDate = checkInDatePicker.Value;
            booking.CheckOutDate = checkOutDatePicker.Value;
            booking.NumberOfNights = int.Parse(nightsTextBox.Text);
            booking.TotalAmount = decimal.Parse(roomCostTextBox.Text);
            booking.NumberOfGuests = int.Parse(NumGuestsTextBox.Text);
            bookingController.EditBooking(booking);
            ChangeMode(FormMode.View);
        }

        private void ChangeCancelBookingForm_Activated(object sender, EventArgs e)
        {
            ChangeMode(FormMode.PreSelect);
        }

        private void cancelBookingbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string selectedBookingID = SelectBookingComboBox.SelectedItem.ToString();
                Booking booking = bookingController.FindBooking(int.Parse(selectedBookingID));
                booking.BookingStatus = "Cancelled";
                bookingController.DeleteBooking(booking);
                MessageBox.Show("Booking Cancelled Successfully");
            }
            ClearForm();
            ChangeMode(FormMode.PreSelect);
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
