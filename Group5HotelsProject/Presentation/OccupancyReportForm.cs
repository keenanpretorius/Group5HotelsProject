using Group5HotelsProject.Business;
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
using Group5HotelsProject.Controllers;


namespace Group5HotelsProject.Presentation
{
    public partial class OccupancyReportForm : Form
    {
        private BookingController bookingController =new BookingController();
        public OccupancyReportForm()
        {
            InitializeComponent();
          //  BookingController bookingController = new BookingController();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            // Code to generate occupancy report based on selected dates
            DateTime startDate = startDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;

            if (startDate >= endDate)
            {
                MessageBox.Show("End date must be after start date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Collection<Room> allRooms = new Collection<Room>(bookingController.AllRooms);
            Collection<Booking> bookingsInRange = bookingController.GetBookingsInDateRange(startDate, endDate);


            OccupancyListView.Items.Clear();


            // Fix: Add each room as a ListViewItem instead of assigning to Items
            int occupiedCount = 0;
            foreach (Room room in allRooms)
            {
                
                var item = new ListViewItem(room.RoomNumber);
                item.SubItems.Add(room.RoomType);
                if (bookingsInRange.Any(b => b.RoomID == room.RoomID))
                {
                    item.SubItems.Add("Occupied");
                    occupiedCount++;
                    
                }
                else
                {

                    item.SubItems.Add("Available");
                }
                item.SubItems.Add(room.Description);
                OccupancyListView.Items.Add(item);
            }

            //find day with most occupi

            AverageOccupancyTextBox.Text = (occupiedCount / allRooms.Count).ToString("P2");

        }

        private void OccupancyReportForm_Load(object sender, EventArgs e)
        {
            OccupancyListView.Items.Clear();
            OccupancyListView.Columns.Clear();
            OccupancyListView.Columns.Add("Room Number", 100);
            OccupancyListView.Columns.Add("Room Type", 100);
            OccupancyListView.Columns.Add("Room Status", 100);
            OccupancyListView.Columns.Add("Room Description", 100);
            OccupancyListView.View = View.Details;



        }

    }
}
