using System;
using System.Text;
using System.Windows.Forms;
using Group5HotelsProject.Controllers;
using Group5HotelsProject.Business;

namespace Group5HotelsProject.Presentation
{
    public partial class BookingConfirmationForm : Form
    {
        private BookingController bookingController;
        private GuestController guestController;

        public BookingConfirmationForm()
        {
            InitializeComponent();

            bookingController = new BookingController();
            guestController = new GuestController();

            LoadMostRecentBooking();
        }

        private void LoadMostRecentBooking()
        {
            if (bookingController.AllBookings.Count == 0)
            {
                MessageBox.Show("No bookings found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            // Get the most recently created booking
            Booking latestBooking = bookingController.AllBookings[0];
            for (int i = 1; i < bookingController.AllBookings.Count; i++)
            {
                if (bookingController.AllBookings[i].CreatedDate > latestBooking.CreatedDate)
                {
                    latestBooking = bookingController.AllBookings[i];
                }
            }

            // Find guest info
            var guest = guestController.FindGuest(latestBooking.GuestID);

            // Populate form controls
            guestNameTextBox.Text = guest.FirstName + " " + guest.LastName;
            phoneTextBox.Text = guest.PhoneNumber;
            emailTextBox.Text = guest.Email;
            checkInTextBox.Text = latestBooking.CheckInDate.ToShortDateString();
            checkOutTextBox.Text = latestBooking.CheckOutDate.ToShortDateString();
            nightsTextBox.Text = latestBooking.NumberOfNights.ToString();
            numberOfGuestTextBox.Text = latestBooking.NumberOfGuests.ToString();
            bookingStatusTextBox.Text = latestBooking.BookingStatus;
            bookingNumberRichTextBox.Text = latestBooking.BookingReference;
            checkInTimeTextBox.Text = "15:00";
            checkOutTimeTextBox.Text = "10:00";  
            decimal total = latestBooking.TotalAmount;
            totalRoomChargesTextBox.Text = total.ToString("C");
            depositTextBox.Text = (total * 0.1m).ToString("C");
            balanceDueTextBox.Text = (total * 0.9m).ToString("C");
            paymentMethodTextBox.Text = "Card Payment";

            bookingNumberRichTextBox.SelectAll();
            bookingNumberRichTextBox.SelectionFont = new Font(bookingNumberRichTextBox.Font, FontStyle.Bold);
            bookingNumberRichTextBox.SelectionAlignment = HorizontalAlignment.Center;

            guestNameTextBox.Enabled = false;
            phoneTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            checkInTextBox.Enabled = false;
            checkOutTextBox.Enabled = false;
            nightsTextBox.Enabled = false;
            numberOfGuestTextBox.Enabled = false;
            bookingStatusTextBox.Enabled = false;
            bookingNumberRichTextBox.Enabled = false;
            checkInTextBox.Enabled = false;
            checkOutTimeTextBox.Enabled = false;
            totalRoomChargesTextBox.Enabled = false;
            depositTextBox.Enabled = false;
            balanceDueTextBox.Enabled = false;
            paymentMethodTextBox.Enabled = false;

            // Confirmation Letter
            GenerateConfirmationLetter(latestBooking, guest);
        }

        private void GenerateConfirmationLetter(Booking booking, dynamic guest)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Dear " + (guest != null ? guest.FirstName + " " + guest.LastName : "Guest") + ",");
            sb.AppendLine();
            sb.AppendLine("Thank you for your booking with us. Here are your booking details:");
            sb.AppendLine("Booking Reference: " + booking.BookingReference);
            sb.AppendLine("Check-in: " + booking.CheckInDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("Check-out: " + booking.CheckOutDate.ToString("dd/MM/yyyy"));
            sb.AppendLine("Number of Guests: " + booking.NumberOfGuests);
            sb.AppendLine("Number of Nights: " + booking.NumberOfNights);
            sb.AppendLine("Total Amount: " + booking.TotalAmount.ToString("C"));
            sb.AppendLine();
            sb.AppendLine("We look forward to welcoming you!");
            sb.AppendLine();
            sb.AppendLine("Kind regards,");
            sb.AppendLine("Your Hotel Team");

            confirmationLetterRichTextBox.Text = sb.ToString();
        }

        private void backToMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void makeAnotherBookingButton_Click(object sender, EventArgs e)
        {
            NewBookingForm bookingForm = new NewBookingForm();
            bookingForm.Show();
            Close();
        }

        private void printConfirmationButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Printing confirmation...", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void emailGuestButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email sent to guest.", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void returnToMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
