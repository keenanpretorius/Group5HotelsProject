namespace Group5HotelsProject.Presentation
{
    partial class ProgramMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip = new MenuStrip();
            makeNewBookingToolStripMenuItem = new ToolStripMenuItem();
            bookingEnquiryToolStripMenuItem = new ToolStripMenuItem();
            guestManagementToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            changeCancelBookingToolStripMenuItem = new ToolStripMenuItem();
            toolTip = new ToolTip(components);
            tableViewerToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { makeNewBookingToolStripMenuItem, bookingEnquiryToolStripMenuItem, guestManagementToolStripMenuItem, reportsToolStripMenuItem, changeCancelBookingToolStripMenuItem, tableViewerToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(7, 2, 0, 2);
            menuStrip.Size = new Size(786, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip";
            // 
            // makeNewBookingToolStripMenuItem
            // 
            makeNewBookingToolStripMenuItem.Name = "makeNewBookingToolStripMenuItem";
            makeNewBookingToolStripMenuItem.Size = new Size(122, 20);
            makeNewBookingToolStripMenuItem.Text = "Make New Booking";
            makeNewBookingToolStripMenuItem.Click += makeNewBookingToolStripMenuItem_Click;
            // 
            // bookingEnquiryToolStripMenuItem
            // 
            bookingEnquiryToolStripMenuItem.Name = "bookingEnquiryToolStripMenuItem";
            bookingEnquiryToolStripMenuItem.Size = new Size(106, 20);
            bookingEnquiryToolStripMenuItem.Text = "Booking Enquiry";
            bookingEnquiryToolStripMenuItem.Click += bookingEnquiryToolStripMenuItem_Click;
            // 
            // guestManagementToolStripMenuItem
            // 
            guestManagementToolStripMenuItem.Name = "guestManagementToolStripMenuItem";
            guestManagementToolStripMenuItem.Size = new Size(123, 20);
            guestManagementToolStripMenuItem.Text = "Guest Management";
            guestManagementToolStripMenuItem.Click += guestManagementToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            reportsToolStripMenuItem.Click += reportsToolStripMenuItem_Click;
            // 
            // changeCancelBookingToolStripMenuItem
            // 
            changeCancelBookingToolStripMenuItem.Name = "changeCancelBookingToolStripMenuItem";
            changeCancelBookingToolStripMenuItem.Size = new Size(148, 20);
            changeCancelBookingToolStripMenuItem.Text = "Change/Cancel Booking";
            changeCancelBookingToolStripMenuItem.Click += changeCancelBookingToolStripMenuItem_Click;
            // 
            // tableViewerToolStripMenuItem
            // 
            tableViewerToolStripMenuItem.Name = "tableViewerToolStripMenuItem";
            tableViewerToolStripMenuItem.Size = new Size(85, 20);
            tableViewerToolStripMenuItem.Text = "Table Viewer";
            tableViewerToolStripMenuItem.Click += tableViewerToolStripMenuItem_Click;
            // 
            // ProgramMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 581);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProgramMDI";
            Text = "Group 5 Hotels Management System";
            Load += ProgramMDI_Load_1;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolTip toolTip;
        private ToolStripMenuItem makeNewBookingToolStripMenuItem;
        private ToolStripMenuItem bookingEnquiryToolStripMenuItem;
        private ToolStripMenuItem guestManagementToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem changeCancelBookingToolStripMenuItem;
        private ToolStripMenuItem tableViewerToolStripMenuItem;
    }
}
