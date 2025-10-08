namespace Group5HotelsProject.Presentation
{
    partial class OccupancyReportForm
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
            GenerateReportButton = new Button();
            endLabel = new Label();
            dateTimePicker2 = new DateTimePicker();
            FromLabel = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            panel3 = new Panel();
            OccupancyListView = new ListView();
            AverageOccupancyLabel = new Label();
            totalRevenueLabel = new Label();
            peakOccupancyDayLabel = new Label();
            peakOccuptancyTextBox = new TextBox();
            totalRevenueTextBox = new TextBox();
            AverageOccupancyTextBox = new TextBox();
            titlePanel = new Panel();
            occupancyReportLabel = new Label();
            reportNameLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(GenerateReportButton);
            panel1.Controls.Add(endLabel);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(FromLabel);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(12, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 108);
            panel1.TabIndex = 0;
            // 
            // GenerateReportButton
            // 
            GenerateReportButton.Location = new Point(648, 82);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(116, 23);
            GenerateReportButton.TabIndex = 4;
            GenerateReportButton.Text = "Generate Report";
            GenerateReportButton.UseVisualStyleBackColor = true;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(260, 27);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(50, 15);
            endLabel.TabIndex = 3;
            endLabel.Text = "To Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(260, 45);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 2;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(25, 27);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(65, 15);
            FromLabel.TabIndex = 1;
            FromLabel.Text = "From Date:";
            FromLabel.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(25, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(AverageOccupancyTextBox);
            panel2.Controls.Add(totalRevenueTextBox);
            panel2.Controls.Add(peakOccuptancyTextBox);
            panel2.Controls.Add(peakOccupancyDayLabel);
            panel2.Controls.Add(totalRevenueLabel);
            panel2.Controls.Add(AverageOccupancyLabel);
            panel2.Location = new Point(12, 675);
            panel2.Name = "panel2";
            panel2.Size = new Size(783, 84);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(reportNameLabel);
            panel3.Controls.Add(OccupancyListView);
            panel3.Location = new Point(12, 228);
            panel3.Name = "panel3";
            panel3.Size = new Size(783, 441);
            panel3.TabIndex = 2;
            // 
            // OccupancyListView
            // 
            OccupancyListView.Location = new Point(3, 37);
            OccupancyListView.Name = "OccupancyListView";
            OccupancyListView.Size = new Size(777, 401);
            OccupancyListView.TabIndex = 0;
            OccupancyListView.UseCompatibleStateImageBehavior = false;
            // 
            // AverageOccupancyLabel
            // 
            AverageOccupancyLabel.AutoSize = true;
            AverageOccupancyLabel.Location = new Point(51, 27);
            AverageOccupancyLabel.Name = "AverageOccupancyLabel";
            AverageOccupancyLabel.Size = new Size(113, 15);
            AverageOccupancyLabel.TabIndex = 0;
            AverageOccupancyLabel.Text = " Average Occupany:";
            // 
            // totalRevenueLabel
            // 
            totalRevenueLabel.AutoSize = true;
            totalRevenueLabel.Location = new Point(247, 27);
            totalRevenueLabel.Name = "totalRevenueLabel";
            totalRevenueLabel.Size = new Size(84, 15);
            totalRevenueLabel.TabIndex = 1;
            totalRevenueLabel.Text = "Total Revenue:";
            // 
            // peakOccupancyDayLabel
            // 
            peakOccupancyDayLabel.AutoSize = true;
            peakOccupancyDayLabel.Location = new Point(503, 27);
            peakOccupancyDayLabel.Name = "peakOccupancyDayLabel";
            peakOccupancyDayLabel.Size = new Size(121, 15);
            peakOccupancyDayLabel.TabIndex = 2;
            peakOccupancyDayLabel.Text = "Peak Occupancy Day:";
            // 
            // peakOccuptancyTextBox
            // 
            peakOccuptancyTextBox.Location = new Point(503, 45);
            peakOccuptancyTextBox.Name = "peakOccuptancyTextBox";
            peakOccuptancyTextBox.Size = new Size(174, 23);
            peakOccuptancyTextBox.TabIndex = 3;
            // 
            // totalRevenueTextBox
            // 
            totalRevenueTextBox.Location = new Point(247, 45);
            totalRevenueTextBox.Name = "totalRevenueTextBox";
            totalRevenueTextBox.Size = new Size(174, 23);
            totalRevenueTextBox.TabIndex = 4;
            // 
            // AverageOccupancyTextBox
            // 
            AverageOccupancyTextBox.Location = new Point(51, 45);
            AverageOccupancyTextBox.Name = "AverageOccupancyTextBox";
            AverageOccupancyTextBox.Size = new Size(156, 23);
            AverageOccupancyTextBox.TabIndex = 5;
            // 
            // titlePanel
            // 
            titlePanel.Controls.Add(occupancyReportLabel);
            titlePanel.Location = new Point(140, 12);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(525, 100);
            titlePanel.TabIndex = 3;
            titlePanel.Paint += titlePanel_Paint;
            // 
            // occupancyReportLabel
            // 
            occupancyReportLabel.AutoSize = true;
            occupancyReportLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            occupancyReportLabel.Location = new Point(32, 17);
            occupancyReportLabel.Name = "occupancyReportLabel";
            occupancyReportLabel.Size = new Size(440, 65);
            occupancyReportLabel.TabIndex = 0;
            occupancyReportLabel.Text = "Occupancy Report";
            // 
            // reportNameLabel
            // 
            reportNameLabel.AutoSize = true;
            reportNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            reportNameLabel.Location = new Point(3, 9);
            reportNameLabel.Name = "reportNameLabel";
            reportNameLabel.Size = new Size(131, 25);
            reportNameLabel.TabIndex = 1;
            reportNameLabel.Text = "Name Report";
            // 
            // OccupancyReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 807);
            Controls.Add(titlePanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OccupancyReportForm";
            Text = "Occupancy Report";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label FromLabel;
        private DateTimePicker dateTimePicker1;
        private Label endLabel;
        private DateTimePicker dateTimePicker2;
        private Button GenerateReportButton;
        private Panel panel3;
        private ListView OccupancyListView;
        private Label peakOccupancyDayLabel;
        private Label totalRevenueLabel;
        private Label AverageOccupancyLabel;
        private TextBox AverageOccupancyTextBox;
        private TextBox totalRevenueTextBox;
        private TextBox peakOccuptancyTextBox;
        private Panel titlePanel;
        private Label occupancyReportLabel;
        private Label reportNameLabel;
    }
}