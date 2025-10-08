namespace Group5HotelsProject.Presentation
{
    partial class OccupancyReport
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
            dateTimePicker1 = new DateTimePicker();
            FromLabel = new Label();
            endLabel = new Label();
            dateTimePicker2 = new DateTimePicker();
            GenerateReportButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(GenerateReportButton);
            panel1.Controls.Add(endLabel);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(FromLabel);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Location = new Point(12, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 108);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(78, 180);
            panel2.Name = "panel2";
            panel2.Size = new Size(537, 108);
            panel2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(25, 45);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
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
            // GenerateReportButton
            // 
            GenerateReportButton.Location = new Point(596, 47);
            GenerateReportButton.Name = "GenerateReportButton";
            GenerateReportButton.Size = new Size(75, 23);
            GenerateReportButton.TabIndex = 4;
            GenerateReportButton.Text = "Generate Report";
            GenerateReportButton.UseVisualStyleBackColor = true;
            // 
            // OccupancyReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "OccupancyReport";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}