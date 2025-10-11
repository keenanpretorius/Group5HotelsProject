using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group5HotelsProject.Presentation
{
    public partial class TableViewerForm : Form
    {
        private Controllers.GuestController guestController = new Controllers.GuestController();
        private Controllers.BookingController bookingController = new Controllers.BookingController();

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
    }
}
