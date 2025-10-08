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
            checkAvailablityButton = new Button();
            roomsComboBox = new ComboBox();
            roomsLabel = new Label();
            checkOutDatePicker = new DateTimePicker();
            checkInDatePicker = new DateTimePicker();
            checkInLabel = new Label();
            checkOutLabel = new Label();
            paymentPanel = new Panel();
            CVVLabel = new Label();
            cardNumberLabel = new Label();
            expiryDateLabel = new Label();
            cardNameLabel = new Label();
            expiryDatePicker = new DateTimePicker();
            cardNumberTextBox = new TextBox();
            cardNameTextBox = new TextBox();
            CVVTextBox = new TextBox();
            guestInformationPanel = new Panel();
            searchGuestButton = new Button();
            emailTextBox = new TextBox();
            addressTextBox = new TextBox();
            phoneTextBox = new TextBox();
            IDTextBox = new TextBox();
            nameTextBox = new TextBox();
            phoneLabel = new Label();
            emailLabel = new Label();
            guestNameLabel = new Label();
            addressLabel = new Label();
            IDLabel = new Label();
            clearButton = new Button();
            submitButton = new Button();
            makeNewBookingHeadingPanel = new Panel();
            backToMenuButton = new Button();
            makeNewBookingHeader = new Label();
            roomAvailabilityPanel = new Panel();
            roomAvailabilityGrid = new DataGridView();
            roomAvailabilityLabel = new Label();
            dateColumn = new DataGridViewTextBoxColumn();
            seasonColumn = new DataGridViewTextBoxColumn();
            ratePerNightColumn = new DataGridViewTextBoxColumn();
            availableRoomsColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            totalCostTextBox = new TextBox();
            totalCostLabel = new Label();
            textBox2 = new TextBox();
            depositRequiredLabel = new Label();
            guestInformationLabel = new Label();
            addNewGuestButton = new Button();
            paymentInformationLabel = new Label();
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
            bookingDatesPanel.Location = new Point(59, 100);
            bookingDatesPanel.Margin = new Padding(3, 4, 3, 4);
            bookingDatesPanel.Name = "bookingDatesPanel";
            bookingDatesPanel.Size = new Size(679, 167);
            bookingDatesPanel.TabIndex = 0;
            bookingDatesPanel.Paint += panel1_Paint;
            // 
            // checkAvailablityButton
            // 
            checkAvailablityButton.Location = new Point(489, 117);
            checkAvailablityButton.Margin = new Padding(3, 4, 3, 4);
            checkAvailablityButton.Name = "checkAvailablityButton";
            checkAvailablityButton.Size = new Size(152, 31);
            checkAvailablityButton.TabIndex = 8;
            checkAvailablityButton.Text = "Check Availablity";
            checkAvailablityButton.UseVisualStyleBackColor = true;
            // 
            // roomsComboBox
            // 
            roomsComboBox.FormattingEnabled = true;
            roomsComboBox.Location = new Point(392, 69);
            roomsComboBox.Margin = new Padding(3, 4, 3, 4);
            roomsComboBox.Name = "roomsComboBox";
            roomsComboBox.Size = new Size(138, 28);
            roomsComboBox.TabIndex = 7;
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Location = new Point(392, 45);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new Size(58, 20);
            roomsLabel.TabIndex = 6;
            roomsLabel.Text = "Rooms:";
            // 
            // checkOutDatePicker
            // 
            checkOutDatePicker.Format = DateTimePickerFormat.Short;
            checkOutDatePicker.Location = new Point(193, 69);
            checkOutDatePicker.Margin = new Padding(3, 4, 3, 4);
            checkOutDatePicker.Name = "checkOutDatePicker";
            checkOutDatePicker.Size = new Size(164, 27);
            checkOutDatePicker.TabIndex = 4;
            checkOutDatePicker.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // checkInDatePicker
            // 
            checkInDatePicker.Format = DateTimePickerFormat.Short;
            checkInDatePicker.Location = new Point(6, 69);
            checkInDatePicker.Margin = new Padding(3, 4, 3, 4);
            checkInDatePicker.Name = "checkInDatePicker";
            checkInDatePicker.Size = new Size(170, 27);
            checkInDatePicker.TabIndex = 3;
            // 
            // checkInLabel
            // 
            checkInLabel.AutoSize = true;
            checkInLabel.Location = new Point(6, 45);
            checkInLabel.Name = "checkInLabel";
            checkInLabel.Size = new Size(105, 20);
            checkInLabel.TabIndex = 2;
            checkInLabel.Text = "Check-in Date:";
            // 
            // checkOutLabel
            // 
            checkOutLabel.AutoSize = true;
            checkOutLabel.Location = new Point(193, 45);
            checkOutLabel.Name = "checkOutLabel";
            checkOutLabel.Size = new Size(115, 20);
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
            paymentPanel.Location = new Point(59, 819);
            paymentPanel.Margin = new Padding(3, 4, 3, 4);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(679, 197);
            paymentPanel.TabIndex = 1;
            // 
            // CVVLabel
            // 
            CVVLabel.AutoSize = true;
            CVVLabel.Location = new Point(424, 60);
            CVVLabel.Name = "CVVLabel";
            CVVLabel.Size = new Size(39, 20);
            CVVLabel.TabIndex = 8;
            CVVLabel.Text = "CVV:";
            // 
            // cardNumberLabel
            // 
            cardNumberLabel.AutoSize = true;
            cardNumberLabel.Location = new Point(14, 60);
            cardNumberLabel.Name = "cardNumberLabel";
            cardNumberLabel.Size = new Size(145, 20);
            cardNumberLabel.TabIndex = 7;
            cardNumberLabel.Text = "Credit Card Number:";
            // 
            // expiryDateLabel
            // 
            expiryDateLabel.AutoSize = true;
            expiryDateLabel.Location = new Point(250, 60);
            expiryDateLabel.Name = "expiryDateLabel";
            expiryDateLabel.Size = new Size(88, 20);
            expiryDateLabel.TabIndex = 6;
            expiryDateLabel.Text = "Expiry Date:";
            // 
            // cardNameLabel
            // 
            cardNameLabel.AutoSize = true;
            cardNameLabel.Location = new Point(17, 127);
            cardNameLabel.Name = "cardNameLabel";
            cardNameLabel.Size = new Size(137, 20);
            cardNameLabel.TabIndex = 5;
            cardNameLabel.Text = "Card Holder Name:";
            cardNameLabel.Click += label1_Click;
            // 
            // expiryDatePicker
            // 
            expiryDatePicker.Format = DateTimePickerFormat.Custom;
            expiryDatePicker.Location = new Point(250, 84);
            expiryDatePicker.Margin = new Padding(3, 4, 3, 4);
            expiryDatePicker.Name = "expiryDatePicker";
            expiryDatePicker.Size = new Size(115, 27);
            expiryDatePicker.TabIndex = 4;
            // 
            // cardNumberTextBox
            // 
            cardNumberTextBox.Location = new Point(14, 84);
            cardNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            cardNumberTextBox.Name = "cardNumberTextBox";
            cardNumberTextBox.Size = new Size(187, 27);
            cardNumberTextBox.TabIndex = 3;
            // 
            // cardNameTextBox
            // 
            cardNameTextBox.Location = new Point(14, 151);
            cardNameTextBox.Margin = new Padding(3, 4, 3, 4);
            cardNameTextBox.Name = "cardNameTextBox";
            cardNameTextBox.Size = new Size(187, 27);
            cardNameTextBox.TabIndex = 1;
            // 
            // CVVTextBox
            // 
            CVVTextBox.Location = new Point(424, 84);
            CVVTextBox.Margin = new Padding(3, 4, 3, 4);
            CVVTextBox.Name = "CVVTextBox";
            CVVTextBox.Size = new Size(155, 27);
            CVVTextBox.TabIndex = 0;
            // 
            // guestInformationPanel
            // 
            guestInformationPanel.BorderStyle = BorderStyle.FixedSingle;
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
            guestInformationPanel.Location = new Point(59, 589);
            guestInformationPanel.Margin = new Padding(3, 4, 3, 4);
            guestInformationPanel.Name = "guestInformationPanel";
            guestInformationPanel.Size = new Size(679, 222);
            guestInformationPanel.TabIndex = 1;
            // 
            // searchGuestButton
            // 
            searchGuestButton.Location = new Point(288, 176);
            searchGuestButton.Margin = new Padding(3, 4, 3, 4);
            searchGuestButton.Name = "searchGuestButton";
            searchGuestButton.Size = new Size(162, 31);
            searchGuestButton.TabIndex = 19;
            searchGuestButton.Text = "Search Existing Guest";
            searchGuestButton.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(288, 125);
            emailTextBox.Margin = new Padding(3, 4, 3, 4);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(169, 27);
            emailTextBox.TabIndex = 18;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(18, 125);
            addressTextBox.Margin = new Padding(3, 4, 3, 4);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(200, 27);
            addressTextBox.TabIndex = 17;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(288, 70);
            phoneTextBox.Margin = new Padding(3, 4, 3, 4);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(178, 27);
            phoneTextBox.TabIndex = 16;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(23, 180);
            IDTextBox.Margin = new Padding(3, 4, 3, 4);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(178, 27);
            IDTextBox.TabIndex = 15;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(18, 70);
            nameTextBox.Margin = new Padding(3, 4, 3, 4);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(200, 27);
            nameTextBox.TabIndex = 14;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(288, 46);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(111, 20);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone Number:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(288, 101);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(49, 20);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // guestNameLabel
            // 
            guestNameLabel.AutoSize = true;
            guestNameLabel.Location = new Point(18, 46);
            guestNameLabel.Name = "guestNameLabel";
            guestNameLabel.Size = new Size(93, 20);
            guestNameLabel.TabIndex = 11;
            guestNameLabel.Text = "Guest Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(18, 101);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(65, 20);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Address:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(23, 156);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(88, 20);
            IDLabel.TabIndex = 9;
            IDLabel.Text = "ID/Passport:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(474, 1032);
            clearButton.Margin = new Padding(3, 4, 3, 4);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(97, 31);
            clearButton.TabIndex = 20;
            clearButton.Text = "Clear Form";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(577, 1032);
            submitButton.Margin = new Padding(3, 4, 3, 4);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(156, 31);
            submitButton.TabIndex = 21;
            submitButton.Text = "Create Booking";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // makeNewBookingHeadingPanel
            // 
            makeNewBookingHeadingPanel.BorderStyle = BorderStyle.FixedSingle;
            makeNewBookingHeadingPanel.Controls.Add(backToMenuButton);
            makeNewBookingHeadingPanel.Controls.Add(makeNewBookingHeader);
            makeNewBookingHeadingPanel.Location = new Point(23, 24);
            makeNewBookingHeadingPanel.Name = "makeNewBookingHeadingPanel";
            makeNewBookingHeadingPanel.Size = new Size(738, 69);
            makeNewBookingHeadingPanel.TabIndex = 22;
            // 
            // backToMenuButton
            // 
            backToMenuButton.Location = new Point(622, 10);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(111, 29);
            backToMenuButton.TabIndex = 2;
            backToMenuButton.Text = "Back to Menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            // 
            // makeNewBookingHeader
            // 
            makeNewBookingHeader.AutoSize = true;
            makeNewBookingHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            makeNewBookingHeader.Location = new Point(197, 10);
            makeNewBookingHeader.Name = "makeNewBookingHeader";
            makeNewBookingHeader.Size = new Size(333, 46);
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
            roomAvailabilityPanel.Location = new Point(59, 274);
            roomAvailabilityPanel.Name = "roomAvailabilityPanel";
            roomAvailabilityPanel.Size = new Size(679, 308);
            roomAvailabilityPanel.TabIndex = 23;
            // 
            // roomAvailabilityGrid
            // 
            roomAvailabilityGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomAvailabilityGrid.Columns.AddRange(new DataGridViewColumn[] { dateColumn, seasonColumn, ratePerNightColumn, availableRoomsColumn });
            roomAvailabilityGrid.Location = new Point(40, 39);
            roomAvailabilityGrid.Name = "roomAvailabilityGrid";
            roomAvailabilityGrid.RowHeadersWidth = 51;
            roomAvailabilityGrid.Size = new Size(551, 188);
            roomAvailabilityGrid.TabIndex = 2;
            // 
            // roomAvailabilityLabel
            // 
            roomAvailabilityLabel.AutoSize = true;
            roomAvailabilityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            roomAvailabilityLabel.Location = new Point(13, 13);
            roomAvailabilityLabel.Name = "roomAvailabilityLabel";
            roomAvailabilityLabel.Size = new Size(232, 23);
            roomAvailabilityLabel.TabIndex = 1;
            roomAvailabilityLabel.Text = "Room Availability and Pricing";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 12);
            label1.Name = "label1";
            label1.Size = new Size(278, 23);
            label1.TabIndex = 9;
            label1.Text = "Booking Dates and Room Selection";
            // 
            // totalCostTextBox
            // 
            totalCostTextBox.Location = new Point(40, 266);
            totalCostTextBox.Margin = new Padding(3, 4, 3, 4);
            totalCostTextBox.Name = "totalCostTextBox";
            totalCostTextBox.Size = new Size(114, 27);
            totalCostTextBox.TabIndex = 16;
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new Point(40, 242);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new Size(108, 20);
            totalCostLabel.TabIndex = 15;
            totalCostLabel.Text = "Total stay Cost:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 266);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 18;
            // 
            // depositRequiredLabel
            // 
            depositRequiredLabel.AutoSize = true;
            depositRequiredLabel.Location = new Point(252, 242);
            depositRequiredLabel.Name = "depositRequiredLabel";
            depositRequiredLabel.Size = new Size(170, 20);
            depositRequiredLabel.TabIndex = 17;
            depositRequiredLabel.Text = "Deposit Required (10%):";
            // 
            // guestInformationLabel
            // 
            guestInformationLabel.AutoSize = true;
            guestInformationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            guestInformationLabel.Location = new Point(18, 10);
            guestInformationLabel.Name = "guestInformationLabel";
            guestInformationLabel.Size = new Size(149, 23);
            guestInformationLabel.TabIndex = 20;
            guestInformationLabel.Text = "Guest Information";
            // 
            // addNewGuestButton
            // 
            addNewGuestButton.Location = new Point(468, 176);
            addNewGuestButton.Margin = new Padding(3, 4, 3, 4);
            addNewGuestButton.Name = "addNewGuestButton";
            addNewGuestButton.Size = new Size(148, 31);
            addNewGuestButton.TabIndex = 21;
            addNewGuestButton.Text = "Add new Guest";
            addNewGuestButton.UseVisualStyleBackColor = true;
            // 
            // paymentInformationLabel
            // 
            paymentInformationLabel.AutoSize = true;
            paymentInformationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            paymentInformationLabel.Location = new Point(14, 13);
            paymentInformationLabel.Name = "paymentInformationLabel";
            paymentInformationLabel.Size = new Size(171, 23);
            paymentInformationLabel.TabIndex = 21;
            paymentInformationLabel.Text = "Payment Information";
            // 
            // NewBookingForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 1084);
            Controls.Add(roomAvailabilityPanel);
            Controls.Add(makeNewBookingHeadingPanel);
            Controls.Add(submitButton);
            Controls.Add(clearButton);
            Controls.Add(paymentPanel);
            Controls.Add(guestInformationPanel);
            Controls.Add(bookingDatesPanel);
            Margin = new Padding(3, 4, 3, 4);
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
    }
}