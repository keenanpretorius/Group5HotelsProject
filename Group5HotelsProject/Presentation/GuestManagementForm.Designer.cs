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
            guestInformationLabel = new Label();
            guestResultsPanel = new Panel();
            guestResultsGrid = new DataGridView();
            guestSearchResultsLabel = new Label();
            searchGuestPanel = new Panel();
            searchByComboBox = new ComboBox();
            searchTermTextBox = new TextBox();
            searchTermLabel = new Label();
            seachByLabel = new Label();
            searchGuestHeadingLabel = new Label();
            guestMangementHeadingPanel = new Panel();
            backToMenuButton = new Button();
            guestManagementHeader = new Label();
            guestIDColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            phoneColumn = new DataGridViewTextBoxColumn();
            emailColumn = new DataGridViewTextBoxColumn();
            totalBookingsColumn = new DataGridViewTextBoxColumn();
            actionsColumn = new DataGridViewTextBoxColumn();
            searchButton = new Button();
            addNewGuestButton = new Button();
            guestNameLabel = new Label();
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            guestPhoneLabel = new Label();
            addressTextBox = new TextBox();
            guestAddressLabel = new Label();
            emailTextBox = new TextBox();
            guestEmailLabel = new Label();
            idTextBox = new TextBox();
            guestIDLabel = new Label();
            cancelButton = new Button();
            saveChangesButton = new Button();
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
            bookingSummaryPanel.Controls.Add(saveChangesButton);
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
            bookingSummaryPanel.Location = new Point(49, 463);
            bookingSummaryPanel.Name = "bookingSummaryPanel";
            bookingSummaryPanel.Size = new Size(814, 233);
            bookingSummaryPanel.TabIndex = 17;
            // 
            // guestInformationLabel
            // 
            guestInformationLabel.AutoSize = true;
            guestInformationLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            guestInformationLabel.Location = new Point(12, 13);
            guestInformationLabel.Name = "guestInformationLabel";
            guestInformationLabel.Size = new Size(148, 23);
            guestInformationLabel.TabIndex = 1;
            guestInformationLabel.Text = "Guest information";
            // 
            // guestResultsPanel
            // 
            guestResultsPanel.BorderStyle = BorderStyle.FixedSingle;
            guestResultsPanel.Controls.Add(guestResultsGrid);
            guestResultsPanel.Controls.Add(guestSearchResultsLabel);
            guestResultsPanel.Location = new Point(49, 211);
            guestResultsPanel.Name = "guestResultsPanel";
            guestResultsPanel.Size = new Size(814, 246);
            guestResultsPanel.TabIndex = 16;
            // 
            // guestResultsGrid
            // 
            guestResultsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            guestResultsGrid.Columns.AddRange(new DataGridViewColumn[] { guestIDColumn, nameColumn, phoneColumn, emailColumn, totalBookingsColumn, actionsColumn });
            guestResultsGrid.Location = new Point(14, 39);
            guestResultsGrid.Name = "guestResultsGrid";
            guestResultsGrid.RowHeadersWidth = 51;
            guestResultsGrid.Size = new Size(781, 188);
            guestResultsGrid.TabIndex = 2;
            // 
            // guestSearchResultsLabel
            // 
            guestSearchResultsLabel.AutoSize = true;
            guestSearchResultsLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            guestSearchResultsLabel.Location = new Point(13, 13);
            guestSearchResultsLabel.Name = "guestSearchResultsLabel";
            guestSearchResultsLabel.Size = new Size(112, 23);
            guestSearchResultsLabel.TabIndex = 1;
            guestSearchResultsLabel.Text = "Guest Results";
            // 
            // searchGuestPanel
            // 
            searchGuestPanel.BorderStyle = BorderStyle.FixedSingle;
            searchGuestPanel.Controls.Add(addNewGuestButton);
            searchGuestPanel.Controls.Add(searchButton);
            searchGuestPanel.Controls.Add(searchByComboBox);
            searchGuestPanel.Controls.Add(searchTermTextBox);
            searchGuestPanel.Controls.Add(searchTermLabel);
            searchGuestPanel.Controls.Add(seachByLabel);
            searchGuestPanel.Controls.Add(searchGuestHeadingLabel);
            searchGuestPanel.Location = new Point(49, 87);
            searchGuestPanel.Name = "searchGuestPanel";
            searchGuestPanel.Size = new Size(814, 118);
            searchGuestPanel.TabIndex = 15;
            // 
            // searchByComboBox
            // 
            searchByComboBox.FormattingEnabled = true;
            searchByComboBox.Location = new Point(14, 69);
            searchByComboBox.Name = "searchByComboBox";
            searchByComboBox.Size = new Size(116, 28);
            searchByComboBox.TabIndex = 7;
            // 
            // searchTermTextBox
            // 
            searchTermTextBox.Location = new Point(254, 67);
            searchTermTextBox.Name = "searchTermTextBox";
            searchTermTextBox.Size = new Size(170, 27);
            searchTermTextBox.TabIndex = 6;
            // 
            // searchTermLabel
            // 
            searchTermLabel.AutoSize = true;
            searchTermLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchTermLabel.Location = new Point(254, 44);
            searchTermLabel.Name = "searchTermLabel";
            searchTermLabel.Size = new Size(99, 20);
            searchTermLabel.TabIndex = 2;
            searchTermLabel.Text = "Search Term:";
            // 
            // seachByLabel
            // 
            seachByLabel.AutoSize = true;
            seachByLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            seachByLabel.Location = new Point(12, 44);
            seachByLabel.Name = "seachByLabel";
            seachByLabel.Size = new Size(80, 20);
            seachByLabel.TabIndex = 1;
            seachByLabel.Text = "Search by:";
            // 
            // searchGuestHeadingLabel
            // 
            searchGuestHeadingLabel.AutoSize = true;
            searchGuestHeadingLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            searchGuestHeadingLabel.Location = new Point(12, 9);
            searchGuestHeadingLabel.Name = "searchGuestHeadingLabel";
            searchGuestHeadingLabel.Size = new Size(117, 23);
            searchGuestHeadingLabel.TabIndex = 0;
            searchGuestHeadingLabel.Text = "Search Guests";
            // 
            // guestMangementHeadingPanel
            // 
            guestMangementHeadingPanel.BorderStyle = BorderStyle.FixedSingle;
            guestMangementHeadingPanel.Controls.Add(backToMenuButton);
            guestMangementHeadingPanel.Controls.Add(guestManagementHeader);
            guestMangementHeadingPanel.Location = new Point(12, 12);
            guestMangementHeadingPanel.Name = "guestMangementHeadingPanel";
            guestMangementHeadingPanel.Size = new Size(878, 69);
            guestMangementHeadingPanel.TabIndex = 14;
            // 
            // backToMenuButton
            // 
            backToMenuButton.Location = new Point(762, 11);
            backToMenuButton.Name = "backToMenuButton";
            backToMenuButton.Size = new Size(111, 29);
            backToMenuButton.TabIndex = 1;
            backToMenuButton.Text = "Back to Menu";
            backToMenuButton.UseVisualStyleBackColor = true;
            // 
            // guestManagementHeader
            // 
            guestManagementHeader.AutoSize = true;
            guestManagementHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guestManagementHeader.Location = new Point(314, 11);
            guestManagementHeader.Name = "guestManagementHeader";
            guestManagementHeader.Size = new Size(332, 46);
            guestManagementHeader.TabIndex = 0;
            guestManagementHeader.Text = "Guest Management";
            // 
            // guestIDColumn
            // 
            guestIDColumn.HeaderText = "GuestID";
            guestIDColumn.MinimumWidth = 6;
            guestIDColumn.Name = "guestIDColumn";
            guestIDColumn.Width = 125;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 125;
            // 
            // phoneColumn
            // 
            phoneColumn.HeaderText = "Phone";
            phoneColumn.MinimumWidth = 6;
            phoneColumn.Name = "phoneColumn";
            phoneColumn.Width = 125;
            // 
            // emailColumn
            // 
            emailColumn.HeaderText = "Email";
            emailColumn.MinimumWidth = 6;
            emailColumn.Name = "emailColumn";
            emailColumn.Width = 125;
            // 
            // totalBookingsColumn
            // 
            totalBookingsColumn.HeaderText = "Total";
            totalBookingsColumn.MinimumWidth = 6;
            totalBookingsColumn.Name = "totalBookingsColumn";
            totalBookingsColumn.Width = 125;
            // 
            // actionsColumn
            // 
            actionsColumn.HeaderText = "Actions";
            actionsColumn.MinimumWidth = 6;
            actionsColumn.Name = "actionsColumn";
            actionsColumn.Width = 125;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(507, 66);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 29);
            searchButton.TabIndex = 8;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // addNewGuestButton
            // 
            addNewGuestButton.Location = new Point(624, 67);
            addNewGuestButton.Name = "addNewGuestButton";
            addNewGuestButton.Size = new Size(138, 29);
            addNewGuestButton.TabIndex = 9;
            addNewGuestButton.Text = "Add New Guest";
            addNewGuestButton.UseVisualStyleBackColor = true;
            // 
            // guestNameLabel
            // 
            guestNameLabel.AutoSize = true;
            guestNameLabel.Location = new Point(14, 49);
            guestNameLabel.Name = "guestNameLabel";
            guestNameLabel.Size = new Size(93, 20);
            guestNameLabel.TabIndex = 2;
            guestNameLabel.Text = "Guest Name:";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(14, 72);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(230, 27);
            nameTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(371, 72);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(230, 27);
            phoneTextBox.TabIndex = 5;
            // 
            // guestPhoneLabel
            // 
            guestPhoneLabel.AutoSize = true;
            guestPhoneLabel.Location = new Point(371, 49);
            guestPhoneLabel.Name = "guestPhoneLabel";
            guestPhoneLabel.Size = new Size(111, 20);
            guestPhoneLabel.TabIndex = 4;
            guestPhoneLabel.Text = "Phone Number:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(14, 125);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(125, 27);
            addressTextBox.TabIndex = 7;
            // 
            // guestAddressLabel
            // 
            guestAddressLabel.AutoSize = true;
            guestAddressLabel.Location = new Point(14, 102);
            guestAddressLabel.Name = "guestAddressLabel";
            guestAddressLabel.Size = new Size(65, 20);
            guestAddressLabel.TabIndex = 6;
            guestAddressLabel.Text = "Address:";
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(371, 125);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(125, 27);
            emailTextBox.TabIndex = 9;
            // 
            // guestEmailLabel
            // 
            guestEmailLabel.AutoSize = true;
            guestEmailLabel.Location = new Point(371, 102);
            guestEmailLabel.Name = "guestEmailLabel";
            guestEmailLabel.Size = new Size(49, 20);
            guestEmailLabel.TabIndex = 8;
            guestEmailLabel.Text = "Email:";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(14, 189);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(125, 27);
            idTextBox.TabIndex = 11;
            // 
            // guestIDLabel
            // 
            guestIDLabel.AutoSize = true;
            guestIDLabel.Location = new Point(14, 166);
            guestIDLabel.Name = "guestIDLabel";
            guestIDLabel.Size = new Size(85, 20);
            guestIDLabel.TabIndex = 10;
            guestIDLabel.Text = "ID/Passport";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(375, 189);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(107, 27);
            cancelButton.TabIndex = 12;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(520, 189);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(161, 27);
            saveChangesButton.TabIndex = 13;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // GuestManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 729);
            Controls.Add(bookingSummaryPanel);
            Controls.Add(guestResultsPanel);
            Controls.Add(searchGuestPanel);
            Controls.Add(guestMangementHeadingPanel);
            Name = "GuestManagementForm";
            Text = "GuestManagementForm";
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
        private DataGridView guestResultsGrid;
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
        private DataGridViewTextBoxColumn guestIDColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn phoneColumn;
        private DataGridViewTextBoxColumn emailColumn;
        private DataGridViewTextBoxColumn totalBookingsColumn;
        private DataGridViewTextBoxColumn actionsColumn;
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
    }
}