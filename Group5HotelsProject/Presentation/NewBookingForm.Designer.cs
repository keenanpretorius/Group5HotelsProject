namespace Group5HotelsProject.Presentation
{
    partial class NewBookingForm
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
            bookingDatesPanel = new Panel();
            label1 = new Label();
            checkAvailablityButton = new Button();
            roomsComboBox = new ComboBox();
            roomsLabel = new Label();
            checkOutDatePicker = new DateTimePicker();
            checkInDatePicker = new DateTimePicker();
            checkInLabel = new Label();
            checkOutLabel = new Label();
            paymentPanel = new Panel();
            paymentInformationLabel = new Label();
            CVVLabel = new Label();
            cardNumberLabel = new Label();
            expiryDateLabel = new Label();
            cardNameLabel = new Label();
            expiryDatePicker = new DateTimePicker();
            cardNumberTextBox = new TextBox();
            cardNameTextBox = new TextBox();
            CVVTextBox = new TextBox();
            guestInformationPanel = new Panel();
            addNewGuestButton = new Button();
            guestInformationLabel = new Label();
            searchGuestButton = new Button();
            emailTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            IDTextBox = new TextBox();
            nameTextBox = new TextBox();
            phoneLabel = new Label();
            emailLabel = new Label();
            IDLabel = new Label();
            guestNameLabel = new Label();
            addressLabel = new Label();
            clearButton = new Button();
            submitButton = new Button();
            makeNewBookingHeadingPanel = new Panel();
            backToMenuButton = new Button();
            makeNewBookingHeader = new Label();
            roomAvailabilityPanel = new Panel();
            textBox2 = new TextBox();
            depositRequiredLabel = new Label();
            totalCostTextBox = new TextBox();
            totalCostLabel = new Label();
            roomAvailabilityGrid = new DataGridView();
            dateColumn = new DataGridViewTextBoxColumn();
            seasonColumn = new DataGridViewTextBoxColumn();
            ratePerNightColumn = new DataGridViewTextBoxColumn();
            availableRoomsColumn = new DataGridViewTextBoxColumn();
            roomAvailabilityLabel = new Label();
            SurnameTextBox = new TextBox();
            SurnameLabel = new Label();
            bookingDatesPanel.SuspendLayout();
            paymentPanel.SuspendLayout();
            guestInformationPanel.SuspendLayout();
            makeNewBookingHeadingPanel.SuspendLayout();
            roomAvailabilityPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomAvailabilityGrid).BeginInit();
            SuspendLayout();
            // 
            // bookingDatesPanel
            // 
            bookingDatesPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingDatesPanel.Controls.Add(label1);
            bookingDatesPanel.Controls.Add(checkAvailablityButton);
            bookingDatesPanel.Controls.Add(roomsComboBox);
            bookingDatesPanel.Controls.Add(roomsLabel);
            bookingDatesPanel.Controls.Add(checkOutDatePicker);
            bookingDatesPanel.Controls.Add(checkInDatePicker);
            bookingDatesPanel.Controls.Add(checkInLabel);
            bookingDatesPanel.Controls.Add(checkOutLabel);
            bookingDatesPanel.Location = new Point(52, 75);
            bookingDatesPanel.Name = "bookingDatesPanel";
            bookingDatesPanel.Size = new Size(594, 126);
            bookingDatesPanel.TabIndex = 0;
            bookingDatesPanel.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 9);
            label1.Name = "label1";
            label1.Size = new Size(223, 19);
            label1.TabIndex = 9;
            label1.Text = "Booking Dates and Room Selection";
            // 
            // checkAvailablityButton
            // 
            checkAvailablityButton.Location = new Point(428, 88);
            checkAvailablityButton.Name = "checkAvailablityButton";
            checkAvailablityButton.Size = new Size(133, 23);
            checkAvailablityButton.TabIndex = 8;
            checkAvailablityButton.Text = "Check Availablity";
            checkAvailablityButton.UseVisualStyleBackColor = true;
            checkAvailablityButton.Click += checkAvailablityButton_Click;
            // 
            // roomsComboBox
            // 
            roomsComboBox.FormattingEnabled = true;
            roomsComboBox.Location = new Point(343, 52);
            roomsComboBox.Name = "roomsComboBox";
            roomsComboBox.Size = new Size(121, 23);
            roomsComboBox.TabIndex = 7;
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Location = new Point(343, 34);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new Size(47, 15);
            roomsLabel.TabIndex = 6;
            roomsLabel.Text = "Rooms:";
            // 
            // checkOutDatePicker
            // 
            checkOutDatePicker.Format = DateTimePickerFormat.Short;
            checkOutDatePicker.Location = new Point(169, 52);
            checkOutDatePicker.Name = "checkOutDatePicker";
            checkOutDatePicker.Size = new Size(144, 23);
            checkOutDatePicker.TabIndex = 4;
            checkOutDatePicker.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // checkInDatePicker
            // 
            checkInDatePicker.Format = DateTimePickerFormat.Short;
            checkInDatePicker.Location = new Point(5, 52);
            checkInDatePicker.Name = "checkInDatePicker";
            checkInDatePicker.Size = new Size(149, 23);
            checkInDatePicker.TabIndex = 3;
            // 
            // checkInLabel
            // 
            checkInLabel.AutoSize = true;
            checkInLabel.Location = new Point(5, 34);
            checkInLabel.Name = "checkInLabel";
            checkInLabel.Size = new Size(85, 15);
            checkInLabel.TabIndex = 2;
            checkInLabel.Text = "Check-in Date:";
            // 
            // checkOutLabel
            // 
            checkOutLabel.AutoSize = true;
            checkOutLabel.Location = new Point(169, 34);
            checkOutLabel.Name = "checkOutLabel";
            checkOutLabel.Size = new Size(93, 15);
            checkOutLabel.TabIndex = 1;
            checkOutLabel.Text = "Check-out Date:";
            // 
            // paymentPanel
            // 
            paymentPanel.BorderStyle = BorderStyle.FixedSingle;
            paymentPanel.Controls.Add(paymentInformationLabel);
            paymentPanel.Controls.Add(CVVLabel);
            paymentPanel.Controls.Add(cardNumberLabel);
            paymentPanel.Controls.Add(expiryDateLabel);
            paymentPanel.Controls.Add(cardNameLabel);
            paymentPanel.Controls.Add(expiryDatePicker);
            paymentPanel.Controls.Add(cardNumberTextBox);
            paymentPanel.Controls.Add(cardNameTextBox);
            paymentPanel.Controls.Add(CVVTextBox);
            paymentPanel.Location = new Point(52, 614);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(594, 148);
            paymentPanel.TabIndex = 1;
            // 
            // paymentInformationLabel
            // 
            paymentInformationLabel.AutoSize = true;
            paymentInformationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            paymentInformationLabel.Location = new Point(12, 10);
            paymentInformationLabel.Name = "paymentInformationLabel";
            paymentInformationLabel.Size = new Size(139, 19);
            paymentInformationLabel.TabIndex = 21;
            paymentInformationLabel.Text = "Payment Information";
            // 
            // CVVLabel
            // 
            CVVLabel.AutoSize = true;
            CVVLabel.Location = new Point(371, 45);
            CVVLabel.Name = "CVVLabel";
            CVVLabel.Size = new Size(32, 15);
            CVVLabel.TabIndex = 8;
            CVVLabel.Text = "CVV:";
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Location = new Point(12, 45);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(117, 15);
            cardNumberLabel.TabIndex = 7;
            cardNumberLabel.Text = "Credit Card Number:";
            // 
            // expiryDateLabel
            // 
            expiryDateLabel.AutoSize = true;
            expiryDateLabel.Location = new Point(219, 45);
            expiryDateLabel.Name = "expiryDateLabel";
            expiryDateLabel.Size = new Size(68, 15);
            expiryDateLabel.TabIndex = 6;
            expiryDateLabel.Text = "Expiry Date:";
            // 
            // cardNameLabel
            // 
            cardNameLabel.AutoSize = true;
            cardNameLabel.Location = new Point(15, 95);
            cardNameLabel.Name = "cardNameLabel";
            cardNameLabel.Size = new Size(109, 15);
            cardNameLabel.TabIndex = 5;
            cardNameLabel.Text = "Card Holder Name:";
            cardNameLabel.Click += label1_Click;
            // 
            // expiryDatePicker
            // 
            expiryDatePicker.Format = DateTimePickerFormat.Custom;
            expiryDatePicker.Location = new Point(219, 63);
            expiryDatePicker.Name = "expiryDatePicker";
            expiryDatePicker.Size = new Size(101, 23);
            expiryDatePicker.TabIndex = 4;
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(12, 63);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(164, 23);
            cardNumberTextBox.TabIndex = 3;
            // 
            // cardNameTextBox
            // 
            cardNameTextBox.Location = new Point(12, 113);
            cardNameTextBox.Name = "cardNameTextBox";
            cardNameTextBox.Size = new Size(164, 23);
            cardNameTextBox.TabIndex = 1;
            // 
            // CVVTextBox
            // 
            CVVTextBox.Location = new Point(371, 63);
            CVVTextBox.Name = "CVVTextBox";
            CVVTextBox.Size = new Size(136, 23);
            CVVTextBox.TabIndex = 0;
            // 
            // guestInformationPanel
            // 
            guestInformationPanel.BorderStyle = BorderStyle.FixedSingle;
            guestInformationPanel.Controls.Add(SurnameLabel);
            guestInformationPanel.Controls.Add(SurnameTextBox);
            guestInformationPanel.Controls.Add(addNewGuestButton);
            guestInformationPanel.Controls.Add(guestInformationLabel);
            guestInformationPanel.Controls.Add(searchGuestButton);
            guestInformationPanel.Controls.Add(emailTextBox);
            guestInformationPanel.Controls.Add(addressTextBox);
            guestInformationPanel.Controls.Add(phoneTextBox);
            guestInformationPanel.Controls.Add(IDTextBox);
            guestInformationPanel.Controls.Add(nameTextBox);
            guestInformationPanel.Controls.Add(phoneLabel);
            guestInformationPanel.Controls.Add(emailLabel);
            guestInformationPanel.Controls.Add(IDLabel);
            guestInformationPanel.Controls.Add(guestNameLabel);
            guestInformationPanel.Controls.Add(addressLabel);
            guestInformationPanel.Location = new Point(52, 442);
            guestInformationPanel.Name = "guestInformationPanel";
            guestInformationPanel.Size = new Size(594, 167);
            guestInformationPanel.TabIndex = 1;
            // 
            // addNewGuestButton
            // 
            addNewGuestButton.Location = new Point(410, 132);
            addNewGuestButton.Name = "addNewGuestButton";
            addNewGuestButton.Size = new Size(130, 23);
            addNewGuestButton.TabIndex = 21;
            addNewGuestButton.Text = "Add new Guest";
            addNewGuestButton.UseVisualStyleBackColor = true;
            addNewGuestButton.Click += addNewGuestButton_Click;
            // 
            // guestInformationLabel
            // 
            guestInformationLabel.AutoSize = true;
            guestInformationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            guestInformationLabel.Location = new Point(16, 8);
            guestInformationLabel.Name = "guestInformationLabel";
            guestInformationLabel.Size = new Size(121, 19);
            guestInformationLabel.TabIndex = 20;
            guestInformationLabel.Text = "Guest Information";
            // 
            // searchGuestButton
            // 
            searchGuestButton.Location = new Point(252, 132);
            searchGuestButton.Name = "searchGuestButton";
            searchGuestButton.Size = new Size(142, 23);
            searchGuestButton.TabIndex = 19;
            searchGuestButton.Text = "Search Existing Guest";
            searchGuestButton.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(252, 94);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(148, 23);
            emailTextBox.TabIndex = 18;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(16, 94);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(176, 23);
            addressTextBox.TabIndex = 17;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(428, 52);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(156, 23);
            phoneTextBox.TabIndex = 16;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(20, 135);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(156, 23);
            IDTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(16, 52);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(176, 23);
            nameTextBox.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(428, 34);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(91, 15);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(252, 76);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(20, 117);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(71, 15);
            IDLabel.TabIndex = 9;
            IDLabel.Text = "ID/Passport:";
            // 
            // guestNameLabel
            // 
            guestNameLabel.AutoSize = true;
            guestNameLabel.Location = new Point(16, 34);
            guestNameLabel.Name = "guestNameLabel";
            guestNameLabel.Size = new Size(75, 15);
            guestNameLabel.TabIndex = 11;
            guestNameLabel.Text = "Guest Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(16, 76);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Address:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(415, 774);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(85, 23);
            clearButton.TabIndex = 20;
            clearButton.Text = "Clear Form";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(505, 774);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(136, 23);
            submitButton.TabIndex = 21;
            submitButton.Text = "Create Booking";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // makeNewBookingHeadingPanel
            // 
            makeNewBookingHeadingPanel.BorderStyle = BorderStyle.FixedSingle;
            makeNewBookingHeadingPanel.Controls.Add(backToMenuButton);
            makeNewBookingHeadingPanel.Controls.Add(makeNewBookingHeader);
            makeNewBookingHeadingPanel.Location = new Point(20, 18);
            makeNewBookingHeadingPanel.Margin = new Padding(3, 2, 3, 2);
            makeNewBookingHeadingPanel.Name = "makeNewBookingHeadingPanel";
            makeNewBookingHeadingPanel.Size = new Size(646, 52);
            makeNewBookingHeadingPanel.TabIndex = 22;
            // 
            // backToMenuButton
            // 
            backToMenuButton.Location = new Point(544, 8);
            backToMenuButton.Margin = new Padding(3, 2, 3, 2);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(97, 22);
            backToMenuButton.TabIndex = 2;
            backToMenuButton.Text = "Back to Menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            // 
            // makeNewBookingHeader
            // 
            makeNewBookingHeader.AutoSize = true;
            makeNewBookingHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeNewBookingHeader.Location = new Point(172, 8);
            makeNewBookingHeader.Name = "makeNewBookingHeader";
            makeNewBookingHeader.Size = new Size(267, 37);
            makeNewBookingHeader.TabIndex = 0;
            makeNewBookingHeader.Text = "Make New Booking";
            // 
            // roomAvailabilityPanel
            // 
            roomAvailabilityPanel.BorderStyle = BorderStyle.FixedSingle;
            roomAvailabilityPanel.Controls.Add(textBox2);
            roomAvailabilityPanel.Controls.Add(depositRequiredLabel);
            roomAvailabilityPanel.Controls.Add(totalCostTextBox);
            roomAvailabilityPanel.Controls.Add(totalCostLabel);
            roomAvailabilityPanel.Controls.Add(roomAvailabilityGrid);
            roomAvailabilityPanel.Controls.Add(roomAvailabilityLabel);
            roomAvailabilityPanel.Location = new Point(52, 206);
            roomAvailabilityPanel.Margin = new Padding(3, 2, 3, 2);
            roomAvailabilityPanel.Name = "roomAvailabilityPanel";
            roomAvailabilityPanel.Size = new Size(594, 232);
            roomAvailabilityPanel.TabIndex = 23;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(220, 200);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 18;
            // 
            // depositRequiredLabel
            // 
            depositRequiredLabel.AutoSize = true;
            depositRequiredLabel.Location = new Point(220, 182);
            depositRequiredLabel.Name = "depositRequiredLabel";
            depositRequiredLabel.Size = new Size(133, 15);
            depositRequiredLabel.TabIndex = 17;
            depositRequiredLabel.Text = "Deposit Required (10%):";
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.Location = new Point(35, 200);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.Size = new Size(100, 23);
            totalCostTextBox.TabIndex = 16;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(35, 182);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(87, 15);
            totalCostLabel.TabIndex = 15;
            totalCostLabel.Text = "Total stay Cost:";
            // 
            // roomAvailabilityGrid
            // 
            roomAvailabilityGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomAvailabilityGrid.Columns.AddRange(new DataGridViewColumn[] { dateColumn, seasonColumn, ratePerNightColumn, availableRoomsColumn });
            roomAvailabilityGrid.Location = new Point(12, 31);
            roomAvailabilityGrid.Margin = new Padding(3, 2, 3, 2);
            roomAvailabilityGrid.Name = "roomAvailabilityGrid";
            roomAvailabilityGrid.RowHeadersWidth = 51;
            roomAvailabilityGrid.Size = new Size(553, 141);
            roomAvailabilityGrid.TabIndex = 2;
            // 
            // dateColumn
            // 
            dateColumn.HeaderText = "Date";
            dateColumn.MinimumWidth = 6;
            dateColumn.Name = "dateColumn";
            dateColumn.Width = 125;
            // 
            // seasonColumn
            // 
            seasonColumn.HeaderText = "Season";
            seasonColumn.MinimumWidth = 6;
            seasonColumn.Name = "seasonColumn";
            seasonColumn.Width = 125;
            // 
            // ratePerNightColumn
            // 
            ratePerNightColumn.HeaderText = "Rate/Night";
            ratePerNightColumn.MinimumWidth = 6;
            ratePerNightColumn.Name = "ratePerNightColumn";
            ratePerNightColumn.Width = 125;
            // 
            // availableRoomsColumn
            // 
            availableRoomsColumn.HeaderText = "Available Rooms";
            availableRoomsColumn.MinimumWidth = 6;
            availableRoomsColumn.Name = "availableRoomsColumn";
            availableRoomsColumn.Width = 125;
            // 
            // roomAvailabilityLabel
            // 
            roomAvailabilityLabel.AutoSize = true;
            roomAvailabilityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            roomAvailabilityLabel.Location = new Point(11, 10);
            roomAvailabilityLabel.Name = "roomAvailabilityLabel";
            roomAvailabilityLabel.Size = new Size(186, 19);
            roomAvailabilityLabel.TabIndex = 1;
            roomAvailabilityLabel.Text = "Room Availability and Pricing";
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(234, 52);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(156, 23);
            SurnameTextBox.TabIndex = 22;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(234, 34);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(57, 15);
            SurnameLabel.TabIndex = 23;
            SurnameLabel.Text = "Surname:";
            // 
            // NewBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 796);
            Controls.Add(roomAvailabilityPanel);
            Controls.Add(makeNewBookingHeadingPanel);
            Controls.Add(submitButton);
            Controls.Add(clearButton);
            Controls.Add(paymentPanel);
            Controls.Add(guestInformationPanel);
            Controls.Add(bookingDatesPanel);
            Name = "NewBookingForm";
            Text = "New Booking";
            Load += NewBookingForm_Load;
            bookingDatesPanel.ResumeLayout(false);
            bookingDatesPanel.PerformLayout();
            paymentPanel.ResumeLayout(false);
            paymentPanel.PerformLayout();
            guestInformationPanel.ResumeLayout(false);
            guestInformationPanel.PerformLayout();
            makeNewBookingHeadingPanel.ResumeLayout(false);
            makeNewBookingHeadingPanel.PerformLayout();
            roomAvailabilityPanel.ResumeLayout(false);
            roomAvailabilityPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomAvailabilityGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bookingDatesPanel;
        private Panel paymentPanel;
        private Panel guestInformationPanel;
        private Label checkInLabel;
        private Label checkOutLabel;
        private DateTimePicker checkOutDatePicker;
        private DateTimePicker checkInDatePicker;
        private ComboBox roomsComboBox;
        private Label roomsLabel;
        private Button checkAvailablityButton;
        private Label guestNameLabel;
        private Label addressLabel;
        private Label IDLabel;
        private TextBox addressTextBox;
        private TextBox phoneTextBox;
        private TextBox IDTextBox;
        private TextBox nameTextBox;
        private Label phoneLabel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private TextBox cardNumberTextBox;
        private TextBox cardNameTextBox;
        private TextBox TextBox;
        private TextBox textBox2;
        private TextBox CVVTextBox;
        private Button searchGuestButton;
        private Button clearButton;
        private Button submitButton;
        private DateTimePicker expiryDatePicker;
        private Label cardNameLabel;
        private Label expiryDateLabel;
        private Label CVVLabel;
        private Label cardNumberLabel;
        private Panel makeNewBookingHeadingPanel;
        private Button backToMenuButton;
        private Label makeNewBookingHeader;
        private Panel roomAvailabilityPanel;
        private DataGridView roomAvailabilityGrid;
        private DataGridViewTextBoxColumn dateColumn;
        private DataGridViewTextBoxColumn seasonColumn;
        private DataGridViewTextBoxColumn ratePerNightColumn;
        private DataGridViewTextBoxColumn availableRoomsColumn;
        private Label roomAvailabilityLabel;
        private Label label1;
        private Label depositRequiredLabel;
        private TextBox totalCostTextBox;
        private Label totalCostLabel;
        private Label guestInformationLabel;
        private Label paymentInformationLabel;
        private Button addNewGuestButton;
        private Label SurnameLabel;
        private TextBox SurnameTextBox;
    }
}