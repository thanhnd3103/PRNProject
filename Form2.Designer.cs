namespace PRNProject
{
    partial class Form2
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
            monthCalendarAdv1 = new Syncfusion.Windows.Forms.Tools.MonthCalendarAdv();
            scheduleControl1 = new Syncfusion.Windows.Forms.Schedule.ScheduleControl();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)monthCalendarAdv1).BeginInit();
            SuspendLayout();
            // 
            // monthCalendarAdv1
            // 
            monthCalendarAdv1.BorderColor = Color.FromArgb(209, 211, 212);
            monthCalendarAdv1.BottomHeight = 27;
            monthCalendarAdv1.Culture = new System.Globalization.CultureInfo("");
            monthCalendarAdv1.DayNamesFont = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point);
            monthCalendarAdv1.DaysFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendarAdv1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            monthCalendarAdv1.HeaderFont = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            monthCalendarAdv1.HighlightColor = Color.Black;
            monthCalendarAdv1.Iso8601CalenderFormat = false;
            monthCalendarAdv1.Location = new Point(1, 1);
            monthCalendarAdv1.MetroColor = Color.FromArgb(22, 165, 220);
            monthCalendarAdv1.Name = "monthCalendarAdv1";
            // 
            // 
            // 
            monthCalendarAdv1.NoneButton.AutoSize = true;
            monthCalendarAdv1.NoneButton.Location = new Point(200, 0);
            monthCalendarAdv1.NoneButton.Size = new Size(72, 27);
            monthCalendarAdv1.NoneButton.Text = "None";
            monthCalendarAdv1.Size = new Size(272, 285);
            monthCalendarAdv1.TabIndex = 0;
            // 
            // 
            // 
            monthCalendarAdv1.TodayButton.AutoSize = true;
            monthCalendarAdv1.TodayButton.Location = new Point(0, 0);
            monthCalendarAdv1.TodayButton.Size = new Size(200, 27);
            monthCalendarAdv1.TodayButton.Text = "Today";
            monthCalendarAdv1.WeekFont = new Font("Verdana", 8F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // scheduleControl1
            // 
            scheduleControl1.Appearance.WeekHeaderFormat = "MMMM dd";
            scheduleControl1.Appearance.WeekMonthFullFormat = "dddd, dd MMMM yyyy";
            scheduleControl1.BackColor = Color.FromArgb(192, 201, 219);
            scheduleControl1.Culture = new System.Globalization.CultureInfo("");
            scheduleControl1.DataSource = null;
            scheduleControl1.EnableAlerts = true;
            scheduleControl1.ISO8601CalenderFormat = false;
            scheduleControl1.Location = new Point(279, 1);
            scheduleControl1.Name = "scheduleControl1";
            scheduleControl1.NavigationPanelFillWithCalendar = true;
            scheduleControl1.ShowAllSpansInAllDayPanel = true;
            scheduleControl1.ShowRoundedCorners = true;
            scheduleControl1.Size = new Size(640, 448);
            scheduleControl1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(94, 339);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 453);
            Controls.Add(button1);
            Controls.Add(scheduleControl1);
            Controls.Add(monthCalendarAdv1);
            Name = "Form2";
            Text = "Planed";
            Load += Form2_Load_1;
            ((System.ComponentModel.ISupportInitialize)monthCalendarAdv1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.MonthCalendarAdv monthCalendarAdv1;
        private Syncfusion.Windows.Forms.Schedule.ScheduleControl scheduleControl1;
        private Button button1;
    }
}