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
            AverageOccupancyTextBox = new TextBox();
            totalRevenueTextBox = new TextBox();
            peakOccuptancyTextBox = new TextBox();
            peakOccupancyDayLabel = new Label();
            totalRevenueLabel = new Label();
            AverageOccupancyLabel = new Label();
            panel3 = new Panel();
            reportNameLabel = new Label();
            OccupancyListView = new ListView();
            titlePanel = new Panel();
            occupancyReportLabel = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            titlePanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(GenerateReportButton);
            panel1.Controls.Add(endLabel);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(FromLabel);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(14, 156);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(895, 144);
            panel1.TabIndex = 0;
            // 
            // GenerateReportButton
            // 
            GenerateReportButton.Location = new Point(727, 96);
            GenerateReportButton.Margin = new Padding(3, 4, 3, 4);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(133, 31);
            GenerateReportButton.TabIndex = 4;
            GenerateReportButton.Text = "Generate Report";
            GenerateReportButton.UseVisualStyleBackColor = true;
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new Point(297, 36);
            endLabel.Name = "endLabel";
            endLabel.Size = new Size(64, 20);
            endLabel.TabIndex = 3;
            endLabel.Text = "To Date:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(297, 60);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // FromLabel
            // 
            FromLabel.AutoSize = true;
            FromLabel.Location = new Point(29, 36);
            FromLabel.Name = "FromLabel";
            FromLabel.Size = new Size(82, 20);
            FromLabel.TabIndex = 1;
            FromLabel.Text = "From Date:";
            FromLabel.Click += label1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(29, 60);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(AverageOccupancyTextBox);
            panel2.Controls.Add(totalRevenueTextBox);
            panel2.Controls.Add(peakOccuptancyTextBox);
            panel2.Controls.Add(peakOccupancyDayLabel);
            panel2.Controls.Add(totalRevenueLabel);
            panel2.Controls.Add(AverageOccupancyLabel);
            panel2.Location = new Point(14, 900);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 112);
            panel2.TabIndex = 1;
            // 
            // AverageOccupancyTextBox
            // 
            AverageOccupancyTextBox.Location = new Point(58, 60);
            AverageOccupancyTextBox.Margin = new Padding(3, 4, 3, 4);
            AverageOccupancyTextBox.Name = "AverageOccupancyTextBox";
            AverageOccupancyTextBox.Size = new Size(178, 27);
            AverageOccupancyTextBox.TabIndex = 5;
            // 
            // totalRevenueTextBox
            // 
            totalRevenueTextBox.Location = new Point(282, 60);
            totalRevenueTextBox.Margin = new Padding(3, 4, 3, 4);
            totalRevenueTextBox.Name = "totalRevenueTextBox";
            totalRevenueTextBox.Size = new Size(198, 27);
            totalRevenueTextBox.TabIndex = 4;
            // 
            // peakOccuptancyTextBox
            // 
            peakOccuptancyTextBox.Location = new Point(575, 60);
            peakOccuptancyTextBox.Margin = new Padding(3, 4, 3, 4);
            peakOccuptancyTextBox.Name = "peakOccuptancyTextBox";
            peakOccuptancyTextBox.Size = new Size(198, 27);
            peakOccuptancyTextBox.TabIndex = 3;
            // 
            // peakOccupancyDayLabel
            // 
            peakOccupancyDayLabel.AutoSize = true;
            peakOccupancyDayLabel.Location = new Point(575, 36);
            peakOccupancyDayLabel.Name = "peakOccupancyDayLabel";
            peakOccupancyDayLabel.Size = new Size(148, 20);
            peakOccupancyDayLabel.TabIndex = 2;
            peakOccupancyDayLabel.Text = "Peak Occupancy Day:";
            // 
            // totalRevenueLabel
            // 
            totalRevenueLabel.AutoSize = true;
            totalRevenueLabel.Location = new Point(282, 36);
            totalRevenueLabel.Name = "totalRevenueLabel";
            totalRevenueLabel.Size = new Size(105, 20);
            totalRevenueLabel.TabIndex = 1;
            totalRevenueLabel.Text = "Total Revenue:";
            // 
            // AverageOccupancyLabel
            // 
            AverageOccupancyLabel.AutoSize = true;
            AverageOccupancyLabel.Location = new Point(58, 36);
            AverageOccupancyLabel.Name = "AverageOccupancyLabel";
            AverageOccupancyLabel.Size = new Size(140, 20);
            AverageOccupancyLabel.TabIndex = 0;
            AverageOccupancyLabel.Text = " Average Occupany:";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(reportNameLabel);
            panel3.Controls.Add(OccupancyListView);
            panel3.Location = new Point(14, 304);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(895, 588);
            panel3.TabIndex = 2;
            // 
            // reportNameLabel
            // 
            reportNameLabel.AutoSize = true;
            reportNameLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            reportNameLabel.Location = new Point(3, 12);
            reportNameLabel.Name = "reportNameLabel";
            reportNameLabel.Size = new Size(166, 32);
            reportNameLabel.TabIndex = 1;
            reportNameLabel.Text = "Name Report";
            // 
            // OccupancyListView
            // 
            OccupancyListView.Location = new Point(3, 49);
            OccupancyListView.Margin = new Padding(3, 4, 3, 4);
            OccupancyListView.Name = "OccupancyListView";
            OccupancyListView.Size = new Size(887, 533);
            OccupancyListView.TabIndex = 0;
            OccupancyListView.UseCompatibleStateImageBehavior = false;
            // 
            // titlePanel
            // 
            titlePanel.BorderStyle = BorderStyle.FixedSingle;
            titlePanel.Controls.Add(occupancyReportLabel);
            titlePanel.Location = new Point(160, 16);
            titlePanel.Margin = new Padding(3, 4, 3, 4);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(600, 133);
            titlePanel.TabIndex = 3;
            titlePanel.Paint += titlePanel_Paint;
            // 
            // occupancyReportLabel
            // 
            occupancyReportLabel.AutoSize = true;
            occupancyReportLabel.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            occupancyReportLabel.Location = new Point(37, 23);
            occupancyReportLabel.Name = "occupancyReportLabel";
            occupancyReportLabel.Size = new Size(549, 81);
            occupancyReportLabel.TabIndex = 0;
            occupancyReportLabel.Text = "Occupancy Report";
            // 
            // OccupancyReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(928, 1076);
            Controls.Add(titlePanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
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