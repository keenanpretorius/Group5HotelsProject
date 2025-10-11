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
            GenerateReportButton.Enabled = true;
            // Code to generate occupancy report based on selected dates
            DateTime startDate = startDateTimePicker.Value;
            DateTime endDate = endDateTimePicker.Value;

            if (startDate >= endDate)
            {
                MessageBox.Show("End date must be after start date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Collection<Room> OccuptiedRooms = new Collection<Room>(bookingController.AllRooms);
            OccupancyListView.Items.Clear();
            OccupancyListView.Columns.Clear();
            OccupancyListView.Columns.Add("Room Number", 100);
            OccupancyListView.Columns.Add("Room Type", 100);
            OccupancyListView.Columns.Add("Max Occupancy", 100);

            // Fix: Add each room as a ListViewItem instead of assigning to Items
            foreach (Room room in OccuptiedRooms)
            {
                var item = new ListViewItem(room.RoomNumber);
                item.SubItems.Add(room.RoomType);
                item.SubItems.Add(room.MaxOccupancy.ToString());
                OccupancyListView.Items.Add(item);
            }
        }

        private void OccupancyReportForm_Load(object sender, EventArgs e)
        {
        }
    }
}
