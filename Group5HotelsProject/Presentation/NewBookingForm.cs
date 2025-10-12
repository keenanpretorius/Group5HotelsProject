using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Group5HotelsProject.Business;
using Group5HotelsProject.Controllers;

namespace Group5HotelsProject.Presentation
{
    public partial class NewBookingForm : Form
    {
        private GuestController guestController = new GuestController();
        private RoomController roomController = new RoomController();
        public NewBookingForm()
        {
            InitializeComponent();
        }


        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Close(); // or navigate to your main menu form
        }

        private void addNewGuestButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                var newGuest = new Guest
                {
                    FirstName = nameTextBox.Text,
                    LastName = SurnameTextBox.Text,
                    PhoneNumber = phoneTextBox.Text,
                    Email = emailTextBox.Text,
                    Address = addressTextBox.Text,
                    IDPassportNumber = IDTextBox.Text,
                    PostalCode = "" // Optional: add postal code TextBox if needed
                };

                if (!guestController.Exists(newGuest))
                {
                    guestController.AddGuest(newGuest); // Assuming you have this method in your controller
                    MessageBox.Show("New guest added successfully!");
                }
                else { MessageBox.Show("Guest already exists!"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding guest: {ex.Message}");
            }
        }

        private void searchGuestButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = IDTextBox.Text;
                if (string.IsNullOrWhiteSpace(id))
                {
                    MessageBox.Show("Please enter ID/Passport to search.");
                    return;
                }

                Guest existingGuest = guestController.FindGuest(Convert.ToInt32(id)); // Use instance
                if (existingGuest != null)
                {
                    nameTextBox.Text = existingGuest.FirstName;
                    SurnameTextBox.Text = existingGuest.LastName;
                    IDTextBox.Text = existingGuest.IDPassportNumber;
                    emailTextBox.Text = existingGuest.Email;
                    phoneTextBox.Text = existingGuest.PhoneNumber;
                    addressTextBox.Text = existingGuest.Address;
                }
                else
                {
                    MessageBox.Show("Guest not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching guest: {ex.Message}");
            }
        }

        private void checkAvailablityButton_Click(object sender, EventArgs e)
        {
            if (roomsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a room.", "Room Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime checkIn = checkInDatePicker.Value.Date;
            DateTime checkOut = checkOutDatePicker.Value.Date;

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRoomNumber = roomsComboBox.SelectedItem.ToString().Split('-')[0].Trim();

            Room selectedRoom = null;
            foreach (var room in roomController.AllRooms)
            {
                if (room.RoomNumber == selectedRoomNumber)
                {
                    selectedRoom = room;
                    break;
                }
            }

            if (selectedRoom != null)
            {
                if (selectedRoom.RoomStatus.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show($"Room {selectedRoom.RoomNumber} is available from {checkIn:d} to {checkOut:d}.", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    totalCostTextBox.Text = new BookingController().CalculateBaseCost(checkIn, checkOut).ToString();
                    depositTextBox.Text = (Convert.ToInt32(totalCostTextBox.Text) * 0.1).ToString();
                    depositTextBox.Enabled = false;
                    totalCostTextBox.Enabled = false;
                }
                else
                    MessageBox.Show($"Room {selectedRoom.RoomNumber} is not available.", "Availability", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Selected room not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            SurnameTextBox.Clear();
            IDTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();

            // Booking Dates
            checkInDatePicker.Value = DateTime.Today;
            checkOutDatePicker.Value = DateTime.Today.AddDays(1);

            // Room Selection
            roomsComboBox.SelectedIndex = -1;

            // Payment fields (optional)
            cardNumberTextBox.Clear();
            cardNameTextBox.Clear();
            CVVTextBox.Clear();
            expiryDatePicker.Value = DateTime.Today;

            // Room Availability Grid (optional: clear or reload)
            roomAvailabilityGrid.Rows.Clear();

            // Deposit/Total
            totalCostTextBox.Clear();
            depositTextBox.Clear(); // deposit field
        }

        private void NewBookingForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            SurnameTextBox.Clear();
            IDTextBox.Clear();
            phoneTextBox.Clear();
            emailTextBox.Clear();
            addressTextBox.Clear();

            // Booking Dates
            checkInDatePicker.Value = DateTime.Today;
            checkOutDatePicker.Value = DateTime.Today.AddDays(1);

            // Room Selection
            roomsComboBox.SelectedIndex = -1;

            // Payment fields (optional)
            cardNumberTextBox.Clear();
            cardNameTextBox.Clear();
            CVVTextBox.Clear();
            expiryDatePicker.Value = DateTime.Today;

            // Room Availability Grid (optional: clear or reload)
            roomAvailabilityGrid.Rows.Clear();

            // Deposit/Total
            totalCostTextBox.Clear();
            depositTextBox.Clear(); // deposit field

            // Populate Rooms ComboBox
            roomsComboBox.Items.Clear();
            foreach (var room in roomController.AllRooms)
            {
                // Display format: "RoomNumber - RoomType"
                roomsComboBox.Items.Add($"{room.RoomNumber} - {room.RoomType}");
            }

            roomsComboBox.SelectedIndex = -1; // No selection by default

            // Initialize Room Availability Grid
            roomAvailabilityGrid.Rows.Clear();
            roomAvailabilityGrid.Columns.Clear();

            // Create columns
            roomAvailabilityGrid.Columns.Add("dateColumn", "Date");
            roomAvailabilityGrid.Columns.Add("seasonColumn", "Season");
            roomAvailabilityGrid.Columns.Add("ratePerNightColumn", "Rate/Night");
            roomAvailabilityGrid.Columns.Add("availableRoomsColumn", "Available Rooms");

            roomAvailabilityGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomAvailabilityGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            roomAvailabilityGrid.MultiSelect = false;
            roomAvailabilityGrid.AllowUserToAddRows = false;

            // Set default check-in and check-out dates
            checkInDatePicker.Value = DateTime.Today;
            checkOutDatePicker.Value = DateTime.Today.AddDays(1);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate guest fields
                if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(SurnameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(IDTextBox.Text))
                {
                    MessageBox.Show("Please complete guest information.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate room selection
                if (roomsComboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select a room.", "Room Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate dates
                DateTime checkIn = checkInDatePicker.Value.Date;
                DateTime checkOut = checkOutDatePicker.Value.Date;
                if (checkOut <= checkIn)
                {
                    MessageBox.Show("Check-out date must be after check-in date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Get selected room
                string selectedRoomNumber = roomsComboBox.SelectedItem.ToString().Split('-')[0].Trim();
                Room selectedRoom = null;
                foreach (var room in roomController.AllRooms)
                {
                    if (room.RoomNumber == selectedRoomNumber)
                    {
                        selectedRoom = room;
                        break;
                    }
                }

                if (selectedRoom == null || !selectedRoom.RoomStatus.Equals("Available", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Selected room is not available.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create or fetch guest
                Guest bookingGuest = guestController.FindGuest(Convert.ToInt32(IDTextBox.Text));
                if (bookingGuest == null)
                {
                    bookingGuest = new Guest
                    {
                        FirstName = nameTextBox.Text,
                        LastName = SurnameTextBox.Text,
                        PhoneNumber = phoneTextBox.Text,
                        Email = emailTextBox.Text,
                        Address = addressTextBox.Text,
                        IDPassportNumber = IDTextBox.Text
                    };
                    guestController.AddGuest(bookingGuest);
                }

                // Create Booking object with IDs
                Booking newBooking = new Booking
                {
                    GuestID = bookingGuest.GuestID,
                    RoomID = selectedRoom.RoomID,
                    CheckInDate = checkIn,
                    CheckOutDate = checkOut,
                    NumberOfGuests = Convert.ToInt32(numberOfGuestsUpDown.Value), // adjust if you have a numeric input
                    TotalAmount = new BookingController().CalculateBaseCost(checkIn, checkOut),
                    BookingStatus = "Confirmed",
                    CreatedDate = DateTime.Now,
                    BookingReference = Guid.NewGuid().ToString().Substring(0, 8) // simple reference
                };

                // Add booking
                BookingController bookingController = new BookingController();
                bookingController.AddBooking(newBooking);

                MessageBox.Show("Booking successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear form
                clearButton.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating booking: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backToMenuButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}

