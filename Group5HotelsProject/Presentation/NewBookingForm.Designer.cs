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
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            checkOutLabel = new Label();
            checkInLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            guestLabel = new Label();
            roomsLabel = new Label();
            roomsComboBox = new ComboBox();
            checkAvalablityButton = new Button();
            comboBox1 = new ComboBox();
            IDLabel = new Label();
            addressLabel = new Label();
            guestNameLabel = new Label();
            emailLabel = new Label();
            phoneLabel = new Label();
            nameTextBox = new TextBox();
            IDTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            emailTextBox = new TextBox();
            button1 = new Button();
            clearButton = new Button();
            submitButton = new Button();
            CVVTextBox = new TextBox();
            this.CardNameTextBox = new TextBox();
            CardNoTextBox = new TextBox();
            ExpiryDateTimePicker = new DateTimePicker();
            CardNameLabel = new Label();
            ExpirtyLabel = new Label();
            label1 = new Label();
            CVVLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkAvalablityButton);
            panel1.Controls.Add(roomsComboBox);
            panel1.Controls.Add(roomsLabel);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(checkInLabel);
            panel1.Controls.Add(checkOutLabel);
            panel1.Location = new Point(39, 273);
            panel1.Name = "panel1";
            panel1.Size = new Size(614, 177);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.Controls.Add(CVVLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ExpirtyLabel);
            panel2.Controls.Add(CardNameLabel);
            panel2.Controls.Add(ExpiryDateTimePicker);
            panel2.Controls.Add(CardNoTextBox);
            panel2.Controls.Add(this.CardNameTextBox);
            panel2.Controls.Add(CVVTextBox);
            panel2.Location = new Point(39, 473);
            panel2.Name = "panel2";
            panel2.Size = new Size(614, 154);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(emailTextBox);
            panel3.Controls.Add(addressTextBox);
            panel3.Controls.Add(PhoneTextBox);
            panel3.Controls.Add(IDTextBox);
            panel3.Controls.Add(nameTextBox);
            panel3.Controls.Add(phoneLabel);
            panel3.Controls.Add(emailLabel);
            panel3.Controls.Add(guestNameLabel);
            panel3.Controls.Add(addressLabel);
            panel3.Controls.Add(IDLabel);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(guestLabel);
            panel3.Location = new Point(39, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(614, 208);
            panel3.TabIndex = 1;
            // 
            // checkOutLabel
            // 
            checkOutLabel.AutoSize = true;
            checkOutLabel.Location = new Point(184, 81);
            checkOutLabel.Name = "checkOutLabel";
            checkOutLabel.Size = new Size(93, 15);
            checkOutLabel.TabIndex = 1;
            checkOutLabel.Text = "Check-out Date:";
            // 
            // checkInLabel
            // 
            checkInLabel.AutoSize = true;
            checkInLabel.Location = new Point(20, 81);
            checkInLabel.Name = "checkInLabel";
            checkInLabel.Size = new Size(85, 15);
            checkInLabel.TabIndex = 2;
            checkInLabel.Text = "Check-in Date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(20, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(149, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(184, 99);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(144, 23);
            dateTimePicker2.TabIndex = 4;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // guestLabel
            // 
            guestLabel.AutoSize = true;
            guestLabel.Location = new Point(20, 23);
            guestLabel.Name = "guestLabel";
            guestLabel.Size = new Size(37, 15);
            guestLabel.TabIndex = 5;
            guestLabel.Text = "Guest";
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Location = new Point(358, 81);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new Size(47, 15);
            roomsLabel.TabIndex = 6;
            roomsLabel.Text = "Rooms:";
            // 
            // roomsComboBox
            // 
            roomsComboBox.FormattingEnabled = true;
            roomsComboBox.Location = new Point(358, 99);
            roomsComboBox.Name = "roomsComboBox";
            roomsComboBox.Size = new Size(121, 23);
            roomsComboBox.TabIndex = 7;
            // 
            // checkAvalablityButton
            // 
            checkAvalablityButton.Location = new Point(440, 141);
            checkAvalablityButton.Name = "checkAvalablityButton";
            checkAvalablityButton.Size = new Size(161, 23);
            checkAvalablityButton.TabIndex = 8;
            checkAvalablityButton.Text = "Check Avalablity";
            checkAvalablityButton.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Exsisting", "New" });
            comboBox1.Location = new Point(63, 20);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 8;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(228, 65);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(71, 15);
            IDLabel.TabIndex = 9;
            IDLabel.Text = "ID/Passport:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(20, 126);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 10;
            addressLabel.Text = "Address:";
            // 
            // guestNameLabel
            // 
            guestNameLabel.AutoSize = true;
            guestNameLabel.Location = new Point(20, 65);
            guestNameLabel.Name = "guestNameLabel";
            guestNameLabel.Size = new Size(75, 15);
            guestNameLabel.TabIndex = 11;
            guestNameLabel.Text = "Guest Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new Point(228, 135);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(39, 15);
            emailLabel.TabIndex = 12;
            emailLabel.Text = "Email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(379, 65);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(91, 15);
            phoneLabel.TabIndex = 13;
            phoneLabel.Text = "Phone Number:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(20, 83);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 14;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(228, 83);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(100, 23);
            IDTextBox.TabIndex = 15;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(379, 83);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(100, 23);
            PhoneTextBox.TabIndex = 16;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(20, 153);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(100, 23);
            addressTextBox.TabIndex = 17;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(228, 153);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(148, 23);
            emailTextBox.TabIndex = 18;
            // 
            // button1
            // 
            button1.Location = new Point(526, 172);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(492, 672);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 23);
            clearButton.TabIndex = 20;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(591, 672);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.TabIndex = 21;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            // 
            // CVVTextBox
            // 
            CVVTextBox.Location = new Point(379, 42);
            CVVTextBox.Name = "CVVTextBox";
            CVVTextBox.Size = new Size(136, 23);
            CVVTextBox.TabIndex = 0;
            // 
            // CardNameTextBox
            // 
            this.CardNameTextBox.Location = new Point(20, 104);
            this.CardNameTextBox.Name = "CardNameTextBox";
            this.CardNameTextBox.Size = new Size(164, 23);
            this.CardNameTextBox.TabIndex = 1;
            // 
            // CardNoTextBox
            // 
            CardNoTextBox.Location = new Point(20, 42);
            CardNoTextBox.Name = "CardNoTextBox";
            CardNoTextBox.Size = new Size(164, 23);
            CardNoTextBox.TabIndex = 3;
            // 
            // ExpiryDateTimePicker
            // 
            ExpiryDateTimePicker.Format = DateTimePickerFormat.Custom;
            ExpiryDateTimePicker.Location = new Point(227, 42);
            ExpiryDateTimePicker.Name = "ExpiryDateTimePicker";
            ExpiryDateTimePicker.Size = new Size(101, 23);
            ExpiryDateTimePicker.TabIndex = 4;
            // 
            // CardNameLabel
            // 
            CardNameLabel.AutoSize = true;
            CardNameLabel.Location = new Point(20, 86);
            CardNameLabel.Name = "CardNameLabel";
            CardNameLabel.Size = new Size(109, 15);
            CardNameLabel.TabIndex = 5;
            CardNameLabel.Text = "Card Holder Name:";
            CardNameLabel.Click += label1_Click;
            // 
            // ExpirtyLabel
            // 
            ExpirtyLabel.AutoSize = true;
            ExpirtyLabel.Location = new Point(227, 24);
            ExpirtyLabel.Name = "ExpirtyLabel";
            ExpirtyLabel.Size = new Size(68, 15);
            ExpirtyLabel.TabIndex = 6;
            ExpirtyLabel.Text = "Expiry Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 7;
            label1.Text = "Credit Card Number:";
            // 
            // CVVLabel
            // 
            CVVLabel.AutoSize = true;
            CVVLabel.Location = new Point(379, 24);
            CVVLabel.Name = "CVVLabel";
            CVVLabel.Size = new Size(32, 15);
            CVVLabel.TabIndex = 8;
            CVVLabel.Text = "CVV:";
            // 
            // NewBookingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 717);
            Controls.Add(submitButton);
            Controls.Add(clearButton);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "NewBookingForm";
            Text = "New Booking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label checkInLabel;
        private Label checkOutLabel;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private ComboBox roomsComboBox;
        private Label roomsLabel;
        private Label guestLabel;
        private Button checkAvalablityButton;
        private Label guestNameLabel;
        private Label addressLabel;
        private Label IDLabel;
        private ComboBox comboBox1;
        private TextBox addressTextBox;
        private TextBox PhoneTextBox;
        private TextBox IDTextBox;
        private TextBox nameTextBox;
        private Label phoneLabel;
        private Label emailLabel;
        private TextBox emailTextBox;
        private TextBox CardNoTextBox;
        private TextBox TextBox;
        private TextBox textBox2;
        private TextBox CVVTextBox;
        private Button button1;
        private Button clearButton;
        private Button submitButton;
        private DateTimePicker ExpiryDateTimePicker;
        private Label CardNameLabel;
        private Label ExpirtyLabel;
        private Label CVVLabel;
        private Label label1;
    }
}