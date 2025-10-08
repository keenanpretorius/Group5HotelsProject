using System;
using System.Windows.Forms;

namespace Group5HotelsProject.Presentation
{
    public partial class ProgramMDI : Form
    {
        public ProgramMDI()
        {
            InitializeComponent();
        }

        private void ProgramMDI_Load(object sender, EventArgs e)
        {
            this.Text = "Group 5 Hotels Management System";
            this.WindowState = FormWindowState.Maximized;
        }

        private void makeNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new NewBookingForm();
            childForm.MdiParent = this;
            childForm.Text = "Make New Booking";
            childForm.Show();
        }

        private void bookingEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new BookingEnquiryForm(); 
            childForm.MdiParent = this;
            childForm.Text = "Booking Enquiry";
            childForm.Show();
        }

        private void guestManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new GuestManagementForm(); 
            childForm.MdiParent = this;
            childForm.Text = "Guest Management";
            childForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new OccupancyReport(); 
            childForm.MdiParent = this;
            childForm.Text = "Reports";
            childForm.Show();
        }

        private void changeCancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form childForm = new ChangeCancelBookingForm(); 
            childForm.MdiParent = this;
            childForm.Text = "Change / Cancel Booking";
            childForm.Show();
        }
    }
}
