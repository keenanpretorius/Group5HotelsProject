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
            // TableViewerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 728);
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
        }

        #endregion
        private BindingSource roomDBBindingSource;
        private DataGridView RoomDataGridView;
        private DataGridView BookingDataGridView;
        private BindingSource guestDBBindingSource;
        private DataGridView GuestDataGridView;
    }
}