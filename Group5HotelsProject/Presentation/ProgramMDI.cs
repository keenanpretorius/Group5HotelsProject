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
        // Closes all child forms
        private void CloseAllChildForms()
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void ProgramMDI_Load(object sender, EventArgs e)
        {

            this.Text = "Group 5 Hotels Management System";
            this.WindowState = FormWindowState.Maximized;
        }

        private void makeNewBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Form childForm = new NewBookingForm();
            childForm.MdiParent = this;
            childForm.Text = "Make New Booking";
            childForm.StartPosition = FormStartPosition.CenterScreen;
            childForm.Show();
        }

        private void bookingEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Form childForm = new BookingEnquiryForm();
            childForm.MdiParent = this;
            childForm.Text = "Booking Enquiry";
            childForm.Show();
        }

        private void guestManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CloseAllChildForms();
            Form childForm = new GuestManagementForm();
            childForm.MdiParent = this;
            childForm.Text = "Guest Management";
            childForm.Show();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Form childForm = new OccupancyReportForm();
            childForm.MdiParent = this;
            childForm.Text = "Reports";
            childForm.Show();
        }

        private void changeCancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Form childForm = new ChangeCancelBookingForm();
            childForm.MdiParent = this;
            childForm.Text = "Change / Cancel Booking";
            childForm.Show();
        }

        private void ProgramMDI_Load_1(object sender, EventArgs e)
        {
            this.Text = "Group 5 Hotels Management System";
            this.WindowState = FormWindowState.Maximized;

        }

        private void tableViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            Form childForm = new TableViewerForm();
            childForm.MdiParent = this;
            childForm.Text = "TableViewer";
            childForm.Show();
        }
    }
}
