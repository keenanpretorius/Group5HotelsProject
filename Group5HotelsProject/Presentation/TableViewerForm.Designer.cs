namespace Group5HotelsProject.Presentation
{
    partial class TableViewerForm
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
            components = new System.ComponentModel.Container();
            guestDBBindingSource = new BindingSource(components);
            RoomDataGridView = new DataGridView();
            BookingDataGridView = new DataGridView();
            roomDBBindingSource = new BindingSource(components);
            GuestDataGridView = new DataGridView();
            TableComboBox = new ComboBox();
            modeComboBox = new ComboBox();
            allInfoTextBox = new TextBox();
            SubmitButton = new Button();
            Panel = new Panel();
            ((System.ComponentModel.ISupportInitialize)guestDBBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RoomDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookingDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)roomDBBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GuestDataGridView).BeginInit();
            SuspendLayout();
            // 
            // guestDBBindingSource
            // 
            guestDBBindingSource.DataSource = typeof(Data.GuestDB);
            // 
            // RoomDataGridView
            // 
            RoomDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RoomDataGridView.Location = new Point(38, 199);
            RoomDataGridView.Name = "RoomDataGridView";
            RoomDataGridView.Size = new Size(660, 150);
            RoomDataGridView.TabIndex = 1;
            // 
            // BookingDataGridView
            // 
            BookingDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookingDataGridView.Location = new Point(38, 387);
            BookingDataGridView.Name = "BookingDataGridView";
            BookingDataGridView.Size = new Size(660, 150);
            BookingDataGridView.TabIndex = 2;
            // 
            // roomDBBindingSource
            // 
            roomDBBindingSource.DataSource = typeof(Data.RoomDB);
            // 
            // GuestDataGridView
            // 
            GuestDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GuestDataGridView.Location = new Point(38, 33);
            GuestDataGridView.Name = "GuestDataGridView";
            GuestDataGridView.Size = new Size(660, 150);
            GuestDataGridView.TabIndex = 3;
            // 
            // TableComboBox
            // 
            TableComboBox.FormattingEnabled = true;
            TableComboBox.Items.AddRange(new object[] { "Room", "Guest", "Booking" });
            TableComboBox.Location = new Point(38, 579);
            TableComboBox.Name = "TableComboBox";
            TableComboBox.Size = new Size(121, 23);
            TableComboBox.TabIndex = 4;
            // 
            // modeComboBox
            // 
            modeComboBox.FormattingEnabled = true;
            modeComboBox.Items.AddRange(new object[] { "Edit", "Delete", "Add" });
            modeComboBox.Location = new Point(180, 579);
            modeComboBox.Name = "modeComboBox";
            modeComboBox.Size = new Size(121, 23);
            modeComboBox.TabIndex = 5;
            // 
            // allInfoTextBox
            // 
            allInfoTextBox.Location = new Point(336, 579);
            allInfoTextBox.Name = "allInfoTextBox";
            allInfoTextBox.Size = new Size(455, 23);
            allInfoTextBox.TabIndex = 6;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(38, 624);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 7;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // Panel
            // 
            Panel.Location = new Point(729, 30);
            Panel.Name = "Panel";
            Panel.Size = new Size(509, 522);
            Panel.TabIndex = 8;
            // 
            // TableViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1324, 728);
            Controls.Add(Panel);
            Controls.Add(SubmitButton);
            Controls.Add(allInfoTextBox);
            Controls.Add(modeComboBox);
            Controls.Add(TableComboBox);
            Controls.Add(GuestDataGridView);
            Controls.Add(BookingDataGridView);
            Controls.Add(RoomDataGridView);
            Name = "TableViewerForm";
            Text = "Form1";
            Load += TableViewer_Load;
            ((System.ComponentModel.ISupportInitialize)guestDBBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)RoomDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookingDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)roomDBBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)GuestDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource roomDBBindingSource;
        private DataGridView RoomDataGridView;
        private DataGridView BookingDataGridView;
        private BindingSource guestDBBindingSource;
        private DataGridView GuestDataGridView;
        private ComboBox TableComboBox;
        private ComboBox modeComboBox;
        private TextBox allInfoTextBox;
        private Button SubmitButton;
        private Panel Panel;
    }
}