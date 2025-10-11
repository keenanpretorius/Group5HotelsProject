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
    public partial class TableViewerForm : Form
    {
        private Controllers.GuestController guestController = new GuestController();
        private Controllers.BookingController bookingController = new BookingController();

        public TableViewerForm()
        {
            InitializeComponent();
        }

        private void TableViewer_Load(object sender, EventArgs e)
        {
            GuestDataGridView.DataSource = guestController.AllGuests;
            RoomDataGridView.DataSource = bookingController.AllRooms;
            BookingDataGridView.DataSource = bookingController.AllBookings;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string selectedTable = TableComboBox.SelectedItem.ToString();
            string selectedAction = modeComboBox.SelectedItem.ToString();
            switch (selectedTable)
            {
                case "Room":
                    if (selectedAction.Equals("Add"))
                    {
                        string[] allInfo = allInfoTextBox.Text.Split(',');
                        string roomID = allInfo[0];
                        string roomNumber = allInfo[1];
                        string roomType = allInfo[2];
                        string maxOccupancy = allInfo[3];
                        string roomStatus = allInfo[4];
                        string description = allInfo[5];

                        Room newRoom = new Room(int.Parse(roomID), roomNumber, roomType, int.Parse(maxOccupancy), roomStatus, description);
                        bookingController.AddRoom(newRoom);
                    }
                    else if (selectedAction.Equals("Edit"))
                    {
                        string[] allInfo = allInfoTextBox.Text.Split(',');
                        string roomID = allInfo[0];
                        string roomNumber = allInfo[1];
                        string roomType = allInfo[2];
                        string maxOccupancy = allInfo[3];
                        string roomStatus = allInfo[4];
                        string description = allInfo[5];
                        Room updatedRoom = new Room(int.Parse(roomID), roomNumber, roomType, int.Parse(maxOccupancy), roomStatus, description);
                        bookingController.EditRoom(updatedRoom);
                    }
                    else if (selectedAction.Equals("Delete"))
                    {
                        int roomID = int.Parse(allInfoTextBox.Text);
                        Room roomToDelete = bookingController.FindRoom(roomID);
                        if (roomToDelete != null)
                        {
                            bookingController.DeleteRoom(roomToDelete);
                        }
                    }
                    break;
                    case "Booking":
                    if (selectedAction.Equals("Add"))
                    {
                        string[] allInfo = allInfoTextBox.Text.Split(',');
                        string bookingID = allInfo[0];
                        string guestID = allInfo[1];
                        string roomID = allInfo[2];
                        string receptionistID = allInfo[3];

                        string bookingRef = allInfo[4];
                        string checkInDate = allInfo[5];
                        string checkOutDate = allInfo[6];
                        string numberOfGuests = allInfo[7];
                        string totalPrice = allInfo[8];
                        string bookingStatus = allInfo[9];
                        string createdDate = allInfo[10];
                        

                        Booking newBooking = new Booking(int.Parse(bookingID), int.Parse(guestID), int.Parse(roomID), int.Parse(receptionistID), bookingRef, DateTime.Parse(checkInDate), DateTime.Parse(checkOutDate), int.Parse(numberOfGuests), decimal.Parse(totalPrice), bookingStatus, DateTime.Parse(createdDate));
                        bookingController.AddBooking(newBooking);
                    }
                    else if (selectedAction.Equals("Edit"))
                    {
                        string[] allInfo = allInfoTextBox.Text.Split(',');
                        string bookingID = allInfo[0];
                        string guestID = allInfo[1];
                        string roomID = allInfo[2];
                        string receptionistID = allInfo[3];
                        string bookingRef = allInfo[4];
                        string checkInDate = allInfo[5];
                        string checkOutDate = allInfo[6];
                        string numberOfGuests = allInfo[7];
                        string totalPrice = allInfo[8];
                        string bookingStatus = allInfo[9];
                        string createdDate = allInfo[10];
                        Booking updatedBooking = new Booking(int.Parse(bookingID), int.Parse(guestID), int.Parse(roomID), int.Parse(receptionistID), bookingRef, DateTime.Parse(checkInDate), DateTime.Parse(checkOutDate), int.Parse(numberOfGuests), decimal.Parse(totalPrice), bookingStatus, DateTime.Parse(createdDate));
                        bookingController.EditBooking(updatedBooking);
                    }
                    else if (selectedAction.Equals("Delete"))
                    {
                        int bookingID = int.Parse(allInfoTextBox.Text);
                        Booking bookingToDelete = bookingController.FindBooking(bookingID);
                        if (bookingToDelete != null)
                        {
                            bookingController.DeleteBooking(bookingToDelete);
                        }
                    }
                    break;

            }
            allInfoTextBox.Clear();
            TableViewer_Load(sender, e);


        }
    }
}
