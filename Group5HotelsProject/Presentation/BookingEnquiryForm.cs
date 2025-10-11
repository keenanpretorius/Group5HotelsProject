using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using Group5HotelsProject.Business;
using Group5HotelsProject.Controllers;

namespace Group5HotelsProject.Presentation
{
    public partial class BookingEnquiryForm : Form
    {
        private BookingController bookingController;
        private GuestController guestController;

        public BookingEnquiryForm()
        {
            InitializeComponent();

            bookingController = new BookingController();
            guestController = new GuestController();

            InitializeSearchOptions();
            LoadAllBookings();
        }

        private void InitializeSearchOptions()
        {
            searchByComboBox.Items.Add("Booking Reference");
            searchByComboBox.Items.Add("Guest Name");
            searchByComboBox.Items.Add("Guest ID");
            searchByComboBox.SelectedIndex = 0;

            statusComboBox.Items.Add("All");
            statusComboBox.Items.Add("Confirmed");
            statusComboBox.Items.Add("Pending");
            statusComboBox.Items.Add("Cancelled");
            statusComboBox.SelectedIndex = 0;
        }

        private void LoadAllBookings()
        {
            bookingResultsGrid.Rows.Clear();

            Collection<Booking> allBookings = bookingController.AllBookings;

            int total = 0;
            int confirmed = 0;
            int pending = 0;

            for (int i = 0; i < allBookings.Count; i++)
            {
                Booking booking = allBookings[i];
                Guest guest = guestController.FindGuest(booking.GuestID);

                bookingResultsGrid.Rows.Add(
                    booking.BookingReference,
                    guest != null ? guest.FirstName + " " + guest.LastName : "Unknown",
                    booking.CheckInDate.ToShortDateString(),
                    booking.CheckOutDate.ToShortDateString(),
                    booking.TotalAmount.ToString("C"),
                    "R 0.00", // Placeholder for balance if payment tracking is not yet implemented
                    booking.BookingStatus
                );

                total++;
                if (booking.BookingStatus == "Confirmed") confirmed++;
                if (booking.BookingStatus == "Pending") pending++;
            }

            totalBookingsTextBox.Text = total.ToString();
            confirmedTextBox.Text = confirmed.ToString();
            pendingTextBox.Text = pending.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            bookingResultsGrid.Rows.Clear();

            string searchBy = searchByComboBox.SelectedItem.ToString();
            string searchTerm = searchTermTextBox.Text.Trim().ToLower();
            string statusFilter = statusComboBox.SelectedItem.ToString();
            DateTime dateFrom = dateFromPicker.Value.Date;
            DateTime dateTo = dateToPicker.Value.Date;

            Collection<Booking> allBookings = bookingController.AllBookings;
            int total = 0;
            int confirmed = 0;
            int pending = 0;

            for (int i = 0; i < allBookings.Count; i++)
            {
                Booking booking = allBookings[i];
                Guest guest = guestController.FindGuest(booking.GuestID);

                bool matchesSearch = false;
                bool matchesStatus = false;
                bool matchesDateRange = false;

                // --- Search filter ---
                if (searchBy == "Booking Reference" && booking.BookingReference.ToLower().Contains(searchTerm))
                {
                    matchesSearch = true;
                }
                else if (searchBy == "Guest Name" && guest != null)
                {
                    string fullName = (guest.FirstName + " " + guest.LastName).ToLower();
                    if (fullName.Contains(searchTerm))
                        matchesSearch = true;
                }
                else if (searchBy == "Guest ID" && guest != null)
                {
                    if (guest.GuestID.ToString() == searchTerm)
                        matchesSearch = true;
                }
                else if (string.IsNullOrEmpty(searchTerm))
                {
                    matchesSearch = true; // If no search term, include all
                }

                // --- Status filter ---
                if (statusFilter == "All" || booking.BookingStatus.Equals(statusFilter, StringComparison.OrdinalIgnoreCase))
                {
                    matchesStatus = true;
                }

                // --- Date range filter ---
                if ((booking.CheckInDate.Date >= dateFrom && booking.CheckInDate.Date <= dateTo) ||
                    (booking.CheckOutDate.Date >= dateFrom && booking.CheckOutDate.Date <= dateTo))
                {
                    matchesDateRange = true;
                }

                if (matchesSearch && matchesStatus && matchesDateRange)
                {
                    bookingResultsGrid.Rows.Add(
                        booking.BookingReference,
                        guest != null ? guest.FirstName + " " + guest.LastName : "Unknown",
                        booking.CheckInDate.ToShortDateString(),
                        booking.CheckOutDate.ToShortDateString(),
                        booking.TotalAmount.ToString("C"),
                        "R 0.00",
                        booking.BookingStatus
                    );

                    total++;
                    if (booking.BookingStatus == "Confirmed") confirmed++;
                    if (booking.BookingStatus == "Pending") pending++;
                }
            }

            totalBookingsTextBox.Text = total.ToString();
            confirmedTextBox.Text = confirmed.ToString();
            pendingTextBox.Text = pending.ToString();

            if (total == 0)
            {
                MessageBox.Show("No matching bookings found.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
