namespace Group5HotelsProject.Presentation
{
    partial class GuestManagementForm
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
            bookingSummaryPanel = new Panel();
            addNewGuestButton = new Button();
            PostalCodeTextBox = new TextBox();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            PostalCodeLabel = new Label();
            SurnameLabel = new Label();
            SurnameTextBox = new TextBox();
            cancelButton = new Button();
            idTextBox = new TextBox();
            guestIDLabel = new Label();
            emailTextBox = new TextBox();
            guestEmailLabel = new Label();
            addressTextBox = new TextBox();
            guestAddressLabel = new Label();
            phoneTextBox = new TextBox();
            guestPhoneLabel = new Label();
            nameTextBox = new TextBox();
            guestNameLabel = new Label();
            guestInformationLabel = new Label();
            saveChangesButton = new Button();
            guestResultsPanel = new Panel();
            guestResultsGrid = new DataGridView();
            guestSearchResultsLabel = new Label();
            searchGuestPanel = new Panel();
            searchButton = new Button();
            searchByComboBox = new ComboBox();
            searchTermTextBox = new TextBox();
            searchTermLabel = new Label();
            seachByLabel = new Label();
            searchGuestHeadingLabel = new Label();
            guestMangementHeadingPanel = new Panel();
            backToMenuButton = new Button();
            guestManagementHeader = new Label();
            bookingSummaryPanel.SuspendLayout();
            guestResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guestResultsGrid).BeginInit();
            searchGuestPanel.SuspendLayout();
            guestMangementHeadingPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bookingSummaryPanel
            // 
            bookingSummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingSummaryPanel.Controls.Add(addNewGuestButton);
            bookingSummaryPanel.Controls.Add(PostalCodeTextBox);
            bookingSummaryPanel.Controls.Add(CityTextBox);
            bookingSummaryPanel.Controls.Add(CityLabel);
            bookingSummaryPanel.Controls.Add(PostalCodeLabel);
            bookingSummaryPanel.Controls.Add(SurnameLabel);
            bookingSummaryPanel.Controls.Add(SurnameTextBox);
            bookingSummaryPanel.Controls.Add(cancelButton);
            bookingSummaryPanel.Controls.Add(idTextBox);
            bookingSummaryPanel.Controls.Add(guestIDLabel);
            bookingSummaryPanel.Controls.Add(emailTextBox);
            bookingSummaryPanel.Controls.Add(guestEmailLabel);
            bookingSummaryPanel.Controls.Add(addressTextBox);
            bookingSummaryPanel.Controls.Add(guestAddressLabel);
            bookingSummaryPanel.Controls.Add(phoneTextBox);
            bookingSummaryPanel.Controls.Add(guestPhoneLabel);
            bookingSummaryPanel.Controls.Add(nameTextBox);
            bookingSummaryPanel.Controls.Add(guestNameLabel);
            bookingSummaryPanel.Controls.Add(guestInformationLabel);
            bookingSummaryPanel.Location = new Point(43, 347);
            bookingSummaryPanel.Margin = new Padding(3, 2, 3, 2);
            bookingSummaryPanel.Name = "bookingSummaryPanel";
            bookingSummaryPanel.Size = new Size(712, 189);
            bookingSummaryPanel.TabIndex = 17;
            // 
            // addNewGuestButton
            // 
            addNewGuestButton.Location = new Point(474, 142);
            addNewGuestButton.Margin = new Padding(3, 2, 3, 2);
            addNewGuestButton.Name = "addNewGuestButton";
            addNewGuestButton.Size = new Size(145, 31);
            addNewGuestButton.TabIndex = 9;
            addNewGuestButton.Text = "Add New Guest";
            addNewGuestButton.UseVisualStyleBackColor = true;
            addNewGuestButton.Click += addNewGuestButton_Click;
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.Location = new Point(287, 100);
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.Size = new Size(100, 23);
            PostalCodeTextBox.TabIndex = 19;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(151, 100);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(100, 23);
            CityTextBox.TabIndex = 18;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(151, 82);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(31, 15);
            CityLabel.TabIndex = 17;
            CityLabel.Text = "City:";
            // 
            // PostalCodeLabel
            // 
            PostalCodeLabel.AutoSize = true;
            PostalCodeLabel.Location = new Point(287, 82);
            PostalCodeLabel.Name = "PostalCodeLabel";
            PostalCodeLabel.Size = new Size(73, 15);
            PostalCodeLabel.TabIndex = 16;
            PostalCodeLabel.Text = "Postal Code:";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Location = new Point(242, 37);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(57, 15);
            SurnameLabel.TabIndex = 15;
            SurnameLabel.Text = "Surname:";
            SurnameLabel.Click += label1_Click;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.Location = new Point(242, 54);
            SurnameTextBox.Margin = new Padding(3, 2, 3, 2);
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.Size = new Size(202, 23);
            SurnameTextBox.TabIndex = 14;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(328, 142);
            cancelButton.Margin = new Padding(3, 2, 3, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 31);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(12, 142);
            idTextBox.Margin = new Padding(3, 2, 3, 2);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(110, 23);
            idTextBox.TabIndex = 11;
            // 
            // guestIDLabel
            // 
            guestIDLabel.AutoSize = true;
            guestIDLabel.Location = new Point(12, 124);
            guestIDLabel.Name = "guestIDLabel";
            guestIDLabel.Size = new Size(68, 15);
            guestIDLabel.TabIndex = 10;
            guestIDLabel.Text = "ID/Passport";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(474, 99);
            emailTextBox.Margin = new Padding(3, 2, 3, 2);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(202, 23);
            emailTextBox.TabIndex = 9;
            // 
            // guestEmailLabel
            // 
            guestEmailLabel.AutoSize = true;
            guestEmailLabel.Location = new Point(471, 82);
            guestEmailLabel.Name = "guestEmailLabel";
            guestEmailLabel.Size = new Size(39, 15);
            guestEmailLabel.TabIndex = 8;
            guestEmailLabel.Text = "Email:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(12, 99);
            addressTextBox.Margin = new Padding(3, 2, 3, 2);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(110, 23);
            addressTextBox.TabIndex = 7;
            // 
            // guestAddressLabel
            // 
            guestAddressLabel.AutoSize = true;
            guestAddressLabel.Location = new Point(12, 79);
            guestAddressLabel.Name = "guestAddressLabel";
            guestAddressLabel.Size = new Size(52, 15);
            guestAddressLabel.TabIndex = 6;
            guestAddressLabel.Text = "Address:";
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(474, 54);
            phoneTextBox.Margin = new Padding(3, 2, 3, 2);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(202, 23);
            phoneTextBox.TabIndex = 5;
            // 
            // guestPhoneLabel
            // 
            guestPhoneLabel.AutoSize = true;
            guestPhoneLabel.Location = new Point(474, 37);
            guestPhoneLabel.Name = "guestPhoneLabel";
            guestPhoneLabel.Size = new Size(91, 15);
            guestPhoneLabel.TabIndex = 4;
            guestPhoneLabel.Text = "Phone Number:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(12, 54);
            nameTextBox.Margin = new Padding(3, 2, 3, 2);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(202, 23);
            nameTextBox.TabIndex = 3;
            // 
            // guestNameLabel
            // 
            guestNameLabel.AutoSize = true;
            guestNameLabel.Location = new Point(12, 37);
            guestNameLabel.Name = "guestNameLabel";
            guestNameLabel.Size = new Size(75, 15);
            guestNameLabel.TabIndex = 2;
            guestNameLabel.Text = "Guest Name:";
            // 
            // guestInformationLabel
            // 
            guestInformationLabel.AutoSize = true;
            guestInformationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            guestInformationLabel.Location = new Point(10, 10);
            guestInformationLabel.Name = "guestInformationLabel";
            guestInformationLabel.Size = new Size(120, 19);
            guestInformationLabel.TabIndex = 1;
            guestInformationLabel.Text = "Guest information";
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(551, 41);
            saveChangesButton.Margin = new Padding(3, 2, 3, 2);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(141, 31);
            saveChangesButton.TabIndex = 13;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // guestResultsPanel
            // 
            guestResultsPanel.BorderStyle = BorderStyle.FixedSingle;
            guestResultsPanel.Controls.Add(guestResultsGrid);
            guestResultsPanel.Controls.Add(guestSearchResultsLabel);
            guestResultsPanel.Location = new Point(43, 158);
            guestResultsPanel.Margin = new Padding(3, 2, 3, 2);
            guestResultsPanel.Name = "guestResultsPanel";
            guestResultsPanel.Size = new Size(712, 185);
            guestResultsPanel.TabIndex = 16;
            // 
            // guestResultsGrid
            // 
            guestResultsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guestResultsGrid.EditMode = DataGridViewEditMode.EditOnEnter;
            guestResultsGrid.Location = new Point(12, 31);
            guestResultsGrid.Margin = new Padding(3, 2, 3, 2);
            guestResultsGrid.Name = "guestResultsGrid";
            guestResultsGrid.RowHeadersWidth = 51;
            guestResultsGrid.Size = new Size(680, 141);
            guestResultsGrid.TabIndex = 2;
            // 
            // guestSearchResultsLabel
            // 
            guestSearchResultsLabel.AutoSize = true;
            guestSearchResultsLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            guestSearchResultsLabel.Location = new Point(11, 10);
            guestSearchResultsLabel.Name = "guestSearchResultsLabel";
            guestSearchResultsLabel.Size = new Size(92, 19);
            guestSearchResultsLabel.TabIndex = 1;
            guestSearchResultsLabel.Text = "Guest Results";
            // 
            // searchGuestPanel
            // 
            searchGuestPanel.BorderStyle = BorderStyle.FixedSingle;
            searchGuestPanel.Controls.Add(searchButton);
            searchGuestPanel.Controls.Add(searchByComboBox);
            searchGuestPanel.Controls.Add(searchTermTextBox);
            searchGuestPanel.Controls.Add(searchTermLabel);
            searchGuestPanel.Controls.Add(seachByLabel);
            searchGuestPanel.Controls.Add(searchGuestHeadingLabel);
            searchGuestPanel.Controls.Add(saveChangesButton);
            searchGuestPanel.Location = new Point(43, 65);
            searchGuestPanel.Margin = new Padding(3, 2, 3, 2);
            searchGuestPanel.Name = "searchGuestPanel";
            searchGuestPanel.Size = new Size(712, 89);
            searchGuestPanel.TabIndex = 15;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(444, 50);
            searchButton.Margin = new Padding(3, 2, 3, 2);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(82, 22);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchByComboBox
            // 
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Location = new Point(12, 52);
            searchByComboBox.Margin = new Padding(3, 2, 3, 2);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new Size(102, 23);
            searchByComboBox.TabIndex = 7;
            // 
            // searchTermTextBox
            // 
            searchTermTextBox.Location = new Point(222, 50);
            searchTermTextBox.Margin = new Padding(3, 2, 3, 2);
            searchTermTextBox.Name = "searchTermTextBox";
            searchTermTextBox.Size = new Size(149, 23);
            searchTermTextBox.TabIndex = 6;
            // 
            // searchTermLabel
            // 
            searchTermLabel.AutoSize = true;
            searchTermLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchTermLabel.Location = new Point(222, 33);
            searchTermLabel.Name = "searchTermLabel";
            searchTermLabel.Size = new Size(80, 15);
            searchTermLabel.TabIndex = 2;
            searchTermLabel.Text = "Search Term:";
            // 
            // seachByLabel
            // 
            seachByLabel.AutoSize = true;
            seachByLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seachByLabel.Location = new Point(10, 33);
            seachByLabel.Name = "seachByLabel";
            seachByLabel.Size = new Size(64, 15);
            seachByLabel.TabIndex = 1;
            seachByLabel.Text = "Search by:";
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
            // guestMangementHeadingPanel
            // 
            guestMangementHeadingPanel.BorderStyle = BorderStyle.FixedSingle;
            guestMangementHeadingPanel.Controls.Add(backToMenuButton);
            guestMangementHeadingPanel.Controls.Add(guestManagementHeader);
            guestMangementHeadingPanel.Location = new Point(10, 9);
            guestMangementHeadingPanel.Margin = new Padding(3, 2, 3, 2);
            guestMangementHeadingPanel.Name = "guestMangementHeadingPanel";
            guestMangementHeadingPanel.Size = new Size(768, 52);
            guestMangementHeadingPanel.TabIndex = 14;
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
            // 
            // guestManagementHeader
            // 
            guestManagementHeader.AutoSize = true;
            guestManagementHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestManagementHeader.Location = new Point(275, 8);
            guestManagementHeader.Name = "guestManagementHeader";
            guestManagementHeader.Size = new Size(268, 37);
            guestManagementHeader.TabIndex = 0;
            guestManagementHeader.Text = "Guest Management";
            // 
            // GuestManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 563);
            Controls.Add(bookingSummaryPanel);
            Controls.Add(guestResultsPanel);
            Controls.Add(searchGuestPanel);
            Controls.Add(guestMangementHeadingPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "GuestManagementForm";
            Text = "GuestManagementForm";
            Load += GuestManagementForm_Load;
            bookingSummaryPanel.ResumeLayout(false);
            bookingSummaryPanel.PerformLayout();
            guestResultsPanel.ResumeLayout(false);
            guestResultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)guestResultsGrid).EndInit();
            searchGuestPanel.ResumeLayout(false);
            searchGuestPanel.PerformLayout();
            guestMangementHeadingPanel.ResumeLayout(false);
            guestMangementHeadingPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bookingSummaryPanel;
        private Label guestInformationLabel;
        private Panel guestResultsPanel;
        private Label guestSearchResultsLabel;
        private Panel searchGuestPanel;
        private ComboBox searchByComboBox;
        private TextBox searchTermTextBox;
        private Label searchTermLabel;
        private Label seachByLabel;
        private Label searchGuestHeadingLabel;
        private Panel guestMangementHeadingPanel;
        private Button backToMenuButton;
        private Label guestManagementHeader;
        private Button addNewGuestButton;
        private Button searchButton;
        private TextBox idTextBox;
        private Label guestIDLabel;
        private TextBox emailTextBox;
        private Label guestEmailLabel;
        private TextBox addressTextBox;
        private Label guestAddressLabel;
        private TextBox phoneTextBox;
        private Label guestPhoneLabel;
        private TextBox nameTextBox;
        private Label guestNameLabel;
        private Button saveChangesButton;
        private Button cancelButton;
        private Label SurnameLabel;
        private TextBox SurnameTextBox;
        private TextBox CityTextBox;
        private Label CityLabel;
        private Label PostalCodeLabel;
        private TextBox PostalCodeTextBox;
        public DataGridView guestResultsGrid;
    }
}