namespace Group5HotelsProject.Presentation
{
    partial class ChangeCancelBookingForm
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            NumOfGuestLabel = new Label();
            NumGuestsTextBox = new TextBox();
            statusTextBox = new TextBox();
            bookingDetailsLabel = new Label();
            checkInDatePicker = new DateTimePicker();
            checkOutDatePicker = new DateTimePicker();
            nightsTextBox = new TextBox();
            roomCostTextBox = new TextBox();
            depositPaidTextBox = new TextBox();
            totalCostTextBox = new TextBox();
            bookingReferenceTextBox = new TextBox();
            checkOutLabel = new Label();
            checkInLabel = new Label();
            nightsLabel = new Label();
            roomCostLabel = new Label();
            depositPaidLabel = new Label();
            totalCostlabel = new Label();
            statusLabel = new Label();
            label4 = new Label();
            bookingReferenceLabel = new Label();
            panel3 = new Panel();
            label1 = new Label();
            newCheckInDatePicker = new DateTimePicker();
            newCheckOutDatePicker = new DateTimePicker();
            checkAvailabilityButton = new Button();
            newCheckOutLabel = new Label();
            newCheckInLabel = new Label();
            cancelBookingbutton = new Button();
            editButton = new Button();
            SaveSelectedButton = new Button();
            searchGuestPanel = new Panel();
            SelectBookingLabel = new Label();
            SelectBookingComboBox = new ComboBox();
            IDTextBox = new TextBox();
            searchButton = new Button();
            searchIDLabel = new Label();
            searchGuestHeadingLabel = new Label();
            changeBookingHeadingPanel = new Panel();
            backToMenuButton = new Button();
            changeBookingHeader = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            searchGuestPanel.SuspendLayout();
            changeBookingHeadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(NumOfGuestLabel);
            panel2.Controls.Add(NumGuestsTextBox);
            panel2.Controls.Add(statusTextBox);
            panel2.Controls.Add(bookingDetailsLabel);
            panel2.Controls.Add(checkInDatePicker);
            panel2.Controls.Add(checkOutDatePicker);
            panel2.Controls.Add(nightsTextBox);
            panel2.Controls.Add(roomCostTextBox);
            panel2.Controls.Add(depositPaidTextBox);
            panel2.Controls.Add(totalCostTextBox);
            panel2.Controls.Add(bookingReferenceTextBox);
            panel2.Controls.Add(checkOutLabel);
            panel2.Controls.Add(checkInLabel);
            panel2.Controls.Add(nightsLabel);
            panel2.Controls.Add(roomCostLabel);
            panel2.Controls.Add(depositPaidLabel);
            panel2.Controls.Add(totalCostlabel);
            panel2.Controls.Add(statusLabel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(bookingReferenceLabel);
            panel2.Location = new Point(94, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 250);
            panel2.TabIndex = 4;
            // 
            // NumOfGuestLabel
            // 
            NumOfGuestLabel.AutoSize = true;
            NumOfGuestLabel.Location = new Point(437, 35);
            NumOfGuestLabel.Name = "NumOfGuestLabel";
            NumOfGuestLabel.Size = new Size(106, 15);
            NumOfGuestLabel.TabIndex = 30;
            NumOfGuestLabel.Text = "Number of Guests:";
            // 
            // NumGuestsTextBox
            // 
            NumGuestsTextBox.Location = new Point(434, 60);
            NumGuestsTextBox.Name = "NumGuestsTextBox";
            NumGuestsTextBox.Size = new Size(154, 23);
            NumGuestsTextBox.TabIndex = 29;
            // 
            // statusTextBox
            // 
            statusTextBox.Location = new Point(222, 60);
            statusTextBox.Name = "statusTextBox";
            statusTextBox.Size = new Size(154, 23);
            statusTextBox.TabIndex = 28;
            // 
            // bookingDetailsLabel
            // 
            bookingDetailsLabel.AutoSize = true;
            bookingDetailsLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            bookingDetailsLabel.Location = new Point(11, 13);
            bookingDetailsLabel.Name = "bookingDetailsLabel";
            bookingDetailsLabel.Size = new Size(155, 19);
            bookingDetailsLabel.TabIndex = 27;
            bookingDetailsLabel.Text = "Current Booking Details";
            // 
            // checkInDatePicker
            // 
            checkInDatePicker.Format = DateTimePickerFormat.Short;
            checkInDatePicker.Location = new Point(14, 111);
            checkInDatePicker.Name = "checkInDatePicker";
            checkInDatePicker.Size = new Size(154, 23);
            checkInDatePicker.TabIndex = 26;
            checkInDatePicker.ValueChanged += checkInDatePicker_ValueChanged;
            // 
            // checkOutDatePicker
            // 
            checkOutDatePicker.Format = DateTimePickerFormat.Short;
            checkOutDatePicker.Location = new Point(224, 111);
            checkOutDatePicker.Name = "checkOutDatePicker";
            checkOutDatePicker.Size = new Size(157, 23);
            checkOutDatePicker.TabIndex = 25;
            checkOutDatePicker.ValueChanged += checkOutDatePicker_ValueChanged;
            // 
            // nightsTextBox
            // 
            nightsTextBox.Location = new Point(436, 114);
            nightsTextBox.Name = "nightsTextBox";
            nightsTextBox.Size = new Size(124, 23);
            nightsTextBox.TabIndex = 23;
            // 
            // roomCostTextBox
            // 
            roomCostTextBox.Location = new Point(437, 162);
            roomCostTextBox.Name = "roomCostTextBox";
            roomCostTextBox.Size = new Size(124, 23);
            roomCostTextBox.TabIndex = 21;
            // 
            // depositPaidTextBox
            // 
            depositPaidTextBox.Location = new Point(225, 162);
            depositPaidTextBox.Name = "depositPaidTextBox";
            depositPaidTextBox.Size = new Size(157, 23);
            depositPaidTextBox.TabIndex = 20;
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.Location = new Point(15, 162);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.Size = new Size(129, 23);
            totalCostTextBox.TabIndex = 18;
            // 
            // bookingReferenceTextBox
            // 
            bookingReferenceTextBox.Location = new Point(12, 60);
            bookingReferenceTextBox.Name = "bookingReferenceTextBox";
            bookingReferenceTextBox.Size = new Size(154, 23);
            bookingReferenceTextBox.TabIndex = 16;
            // 
            // checkOutLabel
            // 
            checkOutLabel.AutoSize = true;
            checkOutLabel.Location = new Point(224, 93);
            checkOutLabel.Name = "checkOutLabel";
            checkOutLabel.Size = new Size(66, 15);
            checkOutLabel.TabIndex = 15;
            checkOutLabel.Text = "Check-out:";
            // 
            // checkInLabel
            // 
            checkInLabel.AutoSize = true;
            checkInLabel.Location = new Point(14, 93);
            checkInLabel.Name = "checkInLabel";
            checkInLabel.Size = new Size(58, 15);
            checkInLabel.TabIndex = 14;
            checkInLabel.Text = "Check-in:";
            checkInLabel.UseMnemonic = false;
            // 
            // nightsLabel
            // 
            nightsLabel.AutoSize = true;
            nightsLabel.Location = new Point(436, 93);
            nightsLabel.Name = "nightsLabel";
            nightsLabel.Size = new Size(45, 15);
            nightsLabel.TabIndex = 13;
            nightsLabel.Text = "Nights:";
            // 
            // roomCostLabel
            // 
            roomCostLabel.AutoSize = true;
            roomCostLabel.Location = new Point(437, 144);
            roomCostLabel.Name = "roomCostLabel";
            roomCostLabel.Size = new Size(69, 15);
            roomCostLabel.TabIndex = 11;
            roomCostLabel.Text = "Room Cost:";
            // 
            // depositPaidLabel
            // 
            depositPaidLabel.AutoSize = true;
            depositPaidLabel.Location = new Point(225, 144);
            depositPaidLabel.Name = "depositPaidLabel";
            depositPaidLabel.Size = new Size(76, 15);
            depositPaidLabel.TabIndex = 10;
            depositPaidLabel.Text = "Deposit Paid:";
            // 
            // totalCostlabel
            // 
            totalCostlabel.AutoSize = true;
            totalCostlabel.Location = new Point(15, 144);
            totalCostlabel.Name = "totalCostlabel";
            totalCostlabel.Size = new Size(63, 15);
            totalCostlabel.TabIndex = 4;
            totalCostlabel.Text = "Total Cost:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(222, 42);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(42, 15);
            statusLabel.TabIndex = 2;
            statusLabel.Text = "Status:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 57);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
            // 
            // bookingReferenceLabel
            // 
            bookingReferenceLabel.AutoSize = true;
            bookingReferenceLabel.Location = new Point(12, 42);
            bookingReferenceLabel.Name = "bookingReferenceLabel";
            bookingReferenceLabel.Size = new Size(109, 15);
            bookingReferenceLabel.TabIndex = 0;
            bookingReferenceLabel.Text = "Booking Reference:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(newCheckInDatePicker);
            panel3.Controls.Add(newCheckOutDatePicker);
            panel3.Controls.Add(checkAvailabilityButton);
            panel3.Controls.Add(newCheckOutLabel);
            panel3.Controls.Add(newCheckInLabel);
            panel3.Location = new Point(94, 600);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 100);
            panel3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 19);
            label1.TabIndex = 28;
            label1.Text = "Current Booking Details";
            // 
            // newCheckInDatePicker
            // 
            newCheckInDatePicker.Format = DateTimePickerFormat.Short;
            newCheckInDatePicker.Location = new Point(13, 56);
            newCheckInDatePicker.Name = "newCheckInDatePicker";
            newCheckInDatePicker.Size = new Size(200, 23);
            newCheckInDatePicker.TabIndex = 18;
            // 
            // newCheckOutDatePicker
            // 
            newCheckOutDatePicker.Format = DateTimePickerFormat.Short;
            newCheckOutDatePicker.Location = new Point(257, 56);
            newCheckOutDatePicker.Name = "newCheckOutDatePicker";
            newCheckOutDatePicker.Size = new Size(200, 23);
            newCheckOutDatePicker.TabIndex = 17;
            // 
            // checkAvailabilityButton
            // 
            checkAvailabilityButton.Location = new Point(474, 53);
            checkAvailabilityButton.Name = "checkAvailabilityButton";
            checkAvailabilityButton.Size = new Size(120, 23);
            checkAvailabilityButton.TabIndex = 16;
            checkAvailabilityButton.Text = "Check Availability";
            checkAvailabilityButton.UseVisualStyleBackColor = true;
            // 
            // newCheckOutLabel
            // 
            newCheckOutLabel.AutoSize = true;
            newCheckOutLabel.Location = new Point(257, 35);
            newCheckOutLabel.Name = "newCheckOutLabel";
            newCheckOutLabel.Size = new Size(120, 15);
            newCheckOutLabel.TabIndex = 15;
            newCheckOutLabel.Text = "New Check-out Date:";
            // 
            // newCheckInLabel
            // 
            newCheckInLabel.AutoSize = true;
            newCheckInLabel.Location = new Point(13, 35);
            newCheckInLabel.Name = "newCheckInLabel";
            newCheckInLabel.Size = new Size(112, 15);
            newCheckInLabel.TabIndex = 14;
            newCheckInLabel.Text = "New Check-in Date:";
            newCheckInLabel.UseMnemonic = false;
            // 
            // cancelBookingbutton
            // 
            cancelBookingbutton.Location = new Point(80, 446);
            cancelBookingbutton.Name = "cancelBookingbutton";
            cancelBookingbutton.Size = new Size(217, 57);
            cancelBookingbutton.TabIndex = 6;
            cancelBookingbutton.Text = "Cancel Selected Booking";
            cancelBookingbutton.UseVisualStyleBackColor = true;
            cancelBookingbutton.Click += cancelBookingbutton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(529, 446);
            editButton.Name = "editButton";
            editButton.Size = new Size(217, 57);
            editButton.TabIndex = 19;
            editButton.Text = "Edit Selected Booking";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // SaveSelectedButton
            // 
            SaveSelectedButton.Location = new Point(305, 446);
            SaveSelectedButton.Name = "SaveSelectedButton";
            SaveSelectedButton.Size = new Size(217, 57);
            SaveSelectedButton.TabIndex = 20;
            SaveSelectedButton.Text = "Save Selected Booking";
            SaveSelectedButton.UseVisualStyleBackColor = true;
            SaveSelectedButton.Click += SaveSelectedButton_Click;
            // 
            // searchGuestPanel
            // 
            searchGuestPanel.BorderStyle = BorderStyle.FixedSingle;
            searchGuestPanel.Controls.Add(SelectBookingLabel);
            searchGuestPanel.Controls.Add(SelectBookingComboBox);
            searchGuestPanel.Controls.Add(IDTextBox);
            searchGuestPanel.Controls.Add(searchButton);
            searchGuestPanel.Controls.Add(searchIDLabel);
            searchGuestPanel.Controls.Add(searchGuestHeadingLabel);
            searchGuestPanel.Location = new Point(94, 65);
            searchGuestPanel.Margin = new Padding(3, 2, 3, 2);
            searchGuestPanel.Name = "searchGuestPanel";
            searchGuestPanel.Size = new Size(612, 106);
            searchGuestPanel.TabIndex = 22;
            // 
            // SelectBookingLabel
            // 
            SelectBookingLabel.AutoSize = true;
            SelectBookingLabel.Location = new Point(406, 33);
            SelectBookingLabel.Name = "SelectBookingLabel";
            SelectBookingLabel.Size = new Size(88, 15);
            SelectBookingLabel.TabIndex = 8;
            SelectBookingLabel.Text = "Select Booking:";
            // 
            // SelectBookingComboBox
            // 
            SelectBookingComboBox.FormattingEnabled = true;
            SelectBookingComboBox.Location = new Point(406, 51);
            SelectBookingComboBox.Name = "SelectBookingComboBox";
            SelectBookingComboBox.Size = new Size(121, 23);
            SelectBookingComboBox.TabIndex = 7;
            SelectBookingComboBox.SelectedIndexChanged += SelectBookingComboBox_SelectedIndexChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(9, 52);
            IDTextBox.Margin = new Padding(3, 2, 3, 2);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(193, 23);
            IDTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(222, 51);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(83, 23);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchIDLabel
            // 
            searchIDLabel.AutoSize = true;
            searchIDLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchIDLabel.Location = new Point(9, 33);
            searchIDLabel.Name = "searchIDLabel";
            searchIDLabel.Size = new Size(116, 15);
            searchIDLabel.TabIndex = 2;
            searchIDLabel.Text = "Search ID/Passport:";
            // 
            // searchGuestHeadingLabel
            // 
            searchGuestHeadingLabel.AutoSize = true;
            searchGuestHeadingLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            searchGuestHeadingLabel.Location = new Point(10, 7);
            searchGuestHeadingLabel.Name = "searchGuestHeadingLabel";
            searchGuestHeadingLabel.Size = new Size(95, 19);
            searchGuestHeadingLabel.TabIndex = 0;
            searchGuestHeadingLabel.Text = "Search Guests";
            // 
            // changeBookingHeadingPanel
            // 
            changeBookingHeadingPanel.BorderStyle = BorderStyle.FixedSingle;
            changeBookingHeadingPanel.Controls.Add(backToMenuButton);
            changeBookingHeadingPanel.Controls.Add(changeBookingHeader);
            changeBookingHeadingPanel.Location = new Point(10, 9);
            changeBookingHeadingPanel.Margin = new Padding(3, 2, 3, 2);
            changeBookingHeadingPanel.Name = "changeBookingHeadingPanel";
            changeBookingHeadingPanel.Size = new Size(768, 52);
            changeBookingHeadingPanel.TabIndex = 21;
            // 
            // backToMenuButton
            // 
            backToMenuButton.Location = new Point(667, 8);
            backToMenuButton.Margin = new Padding(3, 2, 3, 2);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(97, 22);
            backToMenuButton.TabIndex = 1;
            backToMenuButton.Text = "Back to Menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            backToMenuButton.Click += backToMenuButton_Click;
            // 
            // changeBookingHeader
            // 
            changeBookingHeader.AutoSize = true;
            changeBookingHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            changeBookingHeader.Location = new Point(201, 8);
            changeBookingHeader.Name = "changeBookingHeader";
            changeBookingHeader.Size = new Size(353, 37);
            changeBookingHeader.TabIndex = 0;
            changeBookingHeader.Text = "Change or Cancel Booking";
            // 
            // ChangeCancelBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 622);
            Controls.Add(searchGuestPanel);
            Controls.Add(changeBookingHeadingPanel);
            Controls.Add(cancelBookingbutton);
            Controls.Add(editButton);
            Controls.Add(SaveSelectedButton);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "ChangeCancelBookingForm";
            Text = "Form1";
            Activated += ChangeCancelBookingForm_Activated;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            searchGuestPanel.ResumeLayout(false);
            searchGuestPanel.PerformLayout();
            changeBookingHeadingPanel.ResumeLayout(false);
            changeBookingHeadingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label statusLabel;
        private Label label4;
        private Label bookingReferenceLabel;
        private Label totalCostlabel;
        private Label roomCostLabel;
        private Label depositPaidLabel;
        private Label checkOutLabel;
        private Label checkInLabel;
        private Label nightsLabel;
        private Panel panel3;
        private Button checkAvailabilityButton;
        private Label newCheckOutLabel;
        private Label newCheckInLabel;
        private DateTimePicker newCheckInDatePicker;
        private DateTimePicker newCheckOutDatePicker;
        private Button SaveSelectedButton;
        private Button editButton;
        private Button cancelBookingbutton;
        private DateTimePicker checkInDatePicker;
        private DateTimePicker checkOutDatePicker;
        private TextBox nightsTextBox;
        private TextBox roomCostTextBox;
        private TextBox depositPaidTextBox;
        private TextBox totalCostTextBox;
        private TextBox bookingReferenceTextBox;
        private Panel searchGuestPanel;
        private ComboBox searchByComboBox;
        private TextBox IDTextBox;
        private Button searchButton;
        private Label searchIDLabel;
        private Label seachByLabel;
        private Label searchGuestHeadingLabel;
        private Panel changeBookingHeadingPanel;
        private Button backToMenuButton;
        private Label changeBookingHeader;
        private TextBox statusTextBox;
        private Label bookingDetailsLabel;
        private Label label1;
        private Label SelectBookingLabel;
        private ComboBox SelectBookingComboBox;
        private Label NumOfGuestLabel;
        private TextBox NumGuestsTextBox;
    }
}