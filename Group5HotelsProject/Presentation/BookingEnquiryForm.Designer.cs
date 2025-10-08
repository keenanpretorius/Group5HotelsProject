namespace Group5HotelsProject.Presentation
{
    partial class BookingEnquiryForm
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
            bookingEnquiryHeadingPanel = new Panel();
            backToMenuButton = new Button();
            bookingConfirmationHeader = new Label();
            searchGuestPanel = new Panel();
            dateToLabel = new Label();
            dateFromLabel = new Label();
            dateToPicker = new DateTimePicker();
            dateFromPicker = new DateTimePicker();
            statusComboBox = new ComboBox();
            searchByComboBox = new ComboBox();
            searchTermTextBox = new TextBox();
            searchButton = new Button();
            dataRangeLabel = new Label();
            filterLabel = new Label();
            searchTermLabel = new Label();
            seachByLabel = new Label();
            searchGuestHeadingLabel = new Label();
            bookingResultsPanel = new Panel();
            bookingResultsGrid = new DataGridView();
            referenceColumn = new DataGridViewTextBoxColumn();
            nameColumn = new DataGridViewTextBoxColumn();
            checkInColumn = new DataGridViewTextBoxColumn();
            checkOutColumn = new DataGridViewTextBoxColumn();
            totalColumn = new DataGridViewTextBoxColumn();
            balanceColumn = new DataGridViewTextBoxColumn();
            actionsColumn = new DataGridViewTextBoxColumn();
            bookinSearchResultsLabel = new Label();
            bookingSummaryPanel = new Panel();
            pendingTextBox = new TextBox();
            confirmedTextBox = new TextBox();
            totalBookingsTextBox = new TextBox();
            pendingLabel = new Label();
            confirmedLabel = new Label();
            totalBookingsLabel = new Label();
            bookingSummarLabel = new Label();
            bookingEnquiryHeadingPanel.SuspendLayout();
            searchGuestPanel.SuspendLayout();
            bookingResultsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bookingResultsGrid).BeginInit();
            bookingSummaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bookingEnquiryHeadingPanel
            // 
            bookingEnquiryHeadingPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingEnquiryHeadingPanel.Controls.Add(backToMenuButton);
            bookingEnquiryHeadingPanel.Controls.Add(bookingConfirmationHeader);
            bookingEnquiryHeadingPanel.Location = new Point(12, 12);
            bookingEnquiryHeadingPanel.Name = "bookingEnquiryHeadingPanel";
            bookingEnquiryHeadingPanel.Size = new Size(878, 69);
            bookingEnquiryHeadingPanel.TabIndex = 10;
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
            // bookingConfirmationHeader
            // 
            bookingConfirmationHeader.AutoSize = true;
            bookingConfirmationHeader.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bookingConfirmationHeader.Location = new Point(314, 11);
            bookingConfirmationHeader.Name = "bookingConfirmationHeader";
            bookingConfirmationHeader.Size = new Size(288, 46);
            bookingConfirmationHeader.TabIndex = 0;
            bookingConfirmationHeader.Text = "Booking Enquiry";
            // 
            // searchGuestPanel
            // 
            searchGuestPanel.BorderStyle = BorderStyle.FixedSingle;
            searchGuestPanel.Controls.Add(dateToLabel);
            searchGuestPanel.Controls.Add(dateFromLabel);
            searchGuestPanel.Controls.Add(dateToPicker);
            searchGuestPanel.Controls.Add(dateFromPicker);
            searchGuestPanel.Controls.Add(statusComboBox);
            searchGuestPanel.Controls.Add(searchByComboBox);
            searchGuestPanel.Controls.Add(searchTermTextBox);
            searchGuestPanel.Controls.Add(searchButton);
            searchGuestPanel.Controls.Add(dataRangeLabel);
            searchGuestPanel.Controls.Add(filterLabel);
            searchGuestPanel.Controls.Add(searchTermLabel);
            searchGuestPanel.Controls.Add(seachByLabel);
            searchGuestPanel.Controls.Add(searchGuestHeadingLabel);
            searchGuestPanel.Location = new Point(49, 87);
            searchGuestPanel.Name = "searchGuestPanel";
            searchGuestPanel.Size = new Size(814, 206);
            searchGuestPanel.TabIndex = 11;
            // 
            // dateToLabel
            // 
            dateToLabel.AutoSize = true;
            dateToLabel.Location = new Point(254, 163);
            dateToLabel.Name = "dateToLabel";
            dateToLabel.Size = new Size(28, 20);
            dateToLabel.TabIndex = 16;
            dateToLabel.Text = "To:";
            // 
            // dateFromLabel
            // 
            dateFromLabel.AutoSize = true;
            dateFromLabel.Location = new Point(254, 130);
            dateFromLabel.Name = "dateFromLabel";
            dateFromLabel.Size = new Size(46, 20);
            dateFromLabel.TabIndex = 15;
            dateFromLabel.Text = "From:";
            // 
            // dateToPicker
            // 
            dateToPicker.Location = new Point(306, 158);
            dateToPicker.Name = "dateToPicker";
            dateToPicker.Size = new Size(259, 27);
            dateToPicker.TabIndex = 14;
            // 
            // dateFromPicker
            // 
            dateFromPicker.Location = new Point(306, 125);
            dateFromPicker.Name = "dateFromPicker";
            dateFromPicker.Size = new Size(259, 27);
            dateFromPicker.TabIndex = 13;
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(14, 122);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(116, 28);
            statusComboBox.TabIndex = 12;
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
            searchTermTextBox.Size = new Size(125, 27);
            searchTermTextBox.TabIndex = 6;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(690, 149);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 36);
            searchButton.TabIndex = 5;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // dataRangeLabel
            // 
            dataRangeLabel.AutoSize = true;
            dataRangeLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataRangeLabel.Location = new Point(254, 99);
            dataRangeLabel.Name = "dataRangeLabel";
            dataRangeLabel.Size = new Size(94, 20);
            dataRangeLabel.TabIndex = 4;
            dataRangeLabel.Text = "Data Range:";
            // 
            // filterLabel
            // 
            filterLabel.AutoSize = true;
            filterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            filterLabel.Location = new Point(12, 99);
            filterLabel.Name = "filterLabel";
            filterLabel.Size = new Size(118, 20);
            filterLabel.TabIndex = 3;
            filterLabel.Text = "Filter by Status:";
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
            // bookingResultsPanel
            // 
            bookingResultsPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingResultsPanel.Controls.Add(bookingResultsGrid);
            bookingResultsPanel.Controls.Add(bookinSearchResultsLabel);
            bookingResultsPanel.Location = new Point(49, 299);
            bookingResultsPanel.Name = "bookingResultsPanel";
            bookingResultsPanel.Size = new Size(814, 246);
            bookingResultsPanel.TabIndex = 12;
            // 
            // bookingResultsGrid
            // 
            bookingResultsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookingResultsGrid.Columns.AddRange(new DataGridViewColumn[] { referenceColumn, nameColumn, checkInColumn, checkOutColumn, totalColumn, balanceColumn, actionsColumn });
            bookingResultsGrid.Location = new Point(14, 39);
            bookingResultsGrid.Name = "bookingResultsGrid";
            bookingResultsGrid.RowHeadersWidth = 51;
            bookingResultsGrid.Size = new Size(781, 188);
            bookingResultsGrid.TabIndex = 2;
            // 
            // referenceColumn
            // 
            referenceColumn.HeaderText = "Reference";
            referenceColumn.MinimumWidth = 6;
            referenceColumn.Name = "referenceColumn";
            referenceColumn.Width = 125;
            // 
            // nameColumn
            // 
            nameColumn.HeaderText = "Name";
            nameColumn.MinimumWidth = 6;
            nameColumn.Name = "nameColumn";
            nameColumn.Width = 125;
            // 
            // checkInColumn
            // 
            checkInColumn.HeaderText = "Check-in";
            checkInColumn.MinimumWidth = 6;
            checkInColumn.Name = "checkInColumn";
            checkInColumn.Width = 125;
            // 
            // checkOutColumn
            // 
            checkOutColumn.HeaderText = "Check-out";
            checkOutColumn.MinimumWidth = 6;
            checkOutColumn.Name = "checkOutColumn";
            checkOutColumn.Width = 125;
            // 
            // totalColumn
            // 
            totalColumn.HeaderText = "Total";
            totalColumn.MinimumWidth = 6;
            totalColumn.Name = "totalColumn";
            totalColumn.Width = 125;
            // 
            // balanceColumn
            // 
            balanceColumn.HeaderText = "Balance";
            balanceColumn.MinimumWidth = 6;
            balanceColumn.Name = "balanceColumn";
            balanceColumn.Width = 125;
            // 
            // actionsColumn
            // 
            actionsColumn.HeaderText = "Actions";
            actionsColumn.MinimumWidth = 6;
            actionsColumn.Name = "actionsColumn";
            actionsColumn.Width = 125;
            // 
            // bookinSearchResultsLabel
            // 
            bookinSearchResultsLabel.AutoSize = true;
            bookinSearchResultsLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            bookinSearchResultsLabel.Location = new Point(13, 13);
            bookinSearchResultsLabel.Name = "bookinSearchResultsLabel";
            bookinSearchResultsLabel.Size = new Size(130, 23);
            bookinSearchResultsLabel.TabIndex = 1;
            bookinSearchResultsLabel.Text = "Booking Results";
            // 
            // bookingSummaryPanel
            // 
            bookingSummaryPanel.BorderStyle = BorderStyle.FixedSingle;
            bookingSummaryPanel.Controls.Add(pendingTextBox);
            bookingSummaryPanel.Controls.Add(confirmedTextBox);
            bookingSummaryPanel.Controls.Add(totalBookingsTextBox);
            bookingSummaryPanel.Controls.Add(pendingLabel);
            bookingSummaryPanel.Controls.Add(confirmedLabel);
            bookingSummaryPanel.Controls.Add(totalBookingsLabel);
            bookingSummaryPanel.Controls.Add(bookingSummarLabel);
            bookingSummaryPanel.Location = new Point(49, 551);
            bookingSummaryPanel.Name = "bookingSummaryPanel";
            bookingSummaryPanel.Size = new Size(814, 148);
            bookingSummaryPanel.TabIndex = 13;
            // 
            // pendingTextBox
            // 
            pendingTextBox.Location = new Point(507, 74);
            pendingTextBox.Name = "pendingTextBox";
            pendingTextBox.Size = new Size(163, 27);
            pendingTextBox.TabIndex = 7;
            // 
            // confirmedTextBox
            // 
            confirmedTextBox.Location = new Point(261, 74);
            confirmedTextBox.Name = "confirmedTextBox";
            confirmedTextBox.Size = new Size(163, 27);
            confirmedTextBox.TabIndex = 6;
            // 
            // totalBookingsTextBox
            // 
            totalBookingsTextBox.Location = new Point(14, 74);
            totalBookingsTextBox.Name = "totalBookingsTextBox";
            totalBookingsTextBox.Size = new Size(163, 27);
            totalBookingsTextBox.TabIndex = 5;
            // 
            // pendingLabel
            // 
            pendingLabel.AutoSize = true;
            pendingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pendingLabel.Location = new Point(507, 51);
            pendingLabel.Name = "pendingLabel";
            pendingLabel.Size = new Size(70, 20);
            pendingLabel.TabIndex = 4;
            pendingLabel.Text = "Pending:";
            // 
            // confirmedLabel
            // 
            confirmedLabel.AutoSize = true;
            confirmedLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmedLabel.Location = new Point(261, 51);
            confirmedLabel.Name = "confirmedLabel";
            confirmedLabel.Size = new Size(87, 20);
            confirmedLabel.TabIndex = 3;
            confirmedLabel.Text = "Confirmed:";
            // 
            // totalBookingsLabel
            // 
            totalBookingsLabel.AutoSize = true;
            totalBookingsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalBookingsLabel.Location = new Point(12, 51);
            totalBookingsLabel.Name = "totalBookingsLabel";
            totalBookingsLabel.Size = new Size(165, 20);
            totalBookingsLabel.TabIndex = 2;
            totalBookingsLabel.Text = "Total Bookings Found:";
            // 
            // bookingSummarLabel
            // 
            bookingSummarLabel.AutoSize = true;
            bookingSummarLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Underline, GraphicsUnit.Point, 0);
            bookingSummarLabel.Location = new Point(12, 13);
            bookingSummarLabel.Name = "bookingSummarLabel";
            bookingSummarLabel.Size = new Size(149, 23);
            bookingSummarLabel.TabIndex = 1;
            bookingSummarLabel.Text = "Booking Summary";
            // 
            // BookingEnquiryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 714);
            Controls.Add(bookingSummaryPanel);
            Controls.Add(bookingResultsPanel);
            Controls.Add(searchGuestPanel);
            Controls.Add(bookingEnquiryHeadingPanel);
            Name = "BookingEnquiryForm";
            Text = "BookingEnquiry";
            bookingEnquiryHeadingPanel.ResumeLayout(false);
            bookingEnquiryHeadingPanel.PerformLayout();
            searchGuestPanel.ResumeLayout(false);
            searchGuestPanel.PerformLayout();
            bookingResultsPanel.ResumeLayout(false);
            bookingResultsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bookingResultsGrid).EndInit();
            bookingSummaryPanel.ResumeLayout(false);
            bookingSummaryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bookingEnquiryHeadingPanel;
        private Label bookingConfirmationHeader;
        private Panel searchGuestPanel;
        private Label filterLabel;
        private Label searchTermLabel;
        private Label seachByLabel;
        private Label searchGuestHeadingLabel;
        private TextBox searchTermTextBox;
        private Button searchButton;
        private Label dataRangeLabel;
        private Label dateToLabel;
        private Label dateFromLabel;
        private DateTimePicker dateToPicker;
        private DateTimePicker dateFromPicker;
        private ComboBox statusComboBox;
        private ComboBox searchByComboBox;
        private Panel bookingResultsPanel;
        private Label bookinSearchResultsLabel;
        private DataGridView bookingResultsGrid;
        private DataGridViewTextBoxColumn referenceColumn;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn checkInColumn;
        private DataGridViewTextBoxColumn checkOutColumn;
        private DataGridViewTextBoxColumn totalColumn;
        private DataGridViewTextBoxColumn balanceColumn;
        private DataGridViewTextBoxColumn actionsColumn;
        private Panel bookingSummaryPanel;
        private Label totalBookingsLabel;
        private Label bookingSummarLabel;
        private TextBox pendingTextBox;
        private TextBox confirmedTextBox;
        private TextBox totalBookingsTextBox;
        private Label pendingLabel;
        private Label confirmedLabel;
        private Button backToMenuButton;
    }
}