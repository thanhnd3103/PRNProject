namespace PRNProject
{
    partial class Pomodoro
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
            lblTime = new Label();
            btnStart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            txtStudyHour = new TextBox();
            txtStudyMinute = new TextBox();
            txtStudySecond = new TextBox();
            txtBreakHour = new TextBox();
            txtBreakMinute = new TextBox();
            txtBreakSecond = new TextBox();
            btnReset = new Button();
            lblStudyTime = new Label();
            lblBreakTime = new Label();
            lblStatus = new Label();
            lblHour = new Label();
            lblMinute = new Label();
            lblSecond = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(471, 122);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(0, 31);
            lblTime.TabIndex = 0;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(200, 162);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(70, 25);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // txtStudyHour
            // 
            txtStudyHour.Location = new Point(150, 91);
            txtStudyHour.Name = "txtStudyHour";
            txtStudyHour.Size = new Size(70, 23);
            txtStudyHour.TabIndex = 4;
            // 
            // txtStudyMinute
            // 
            txtStudyMinute.Location = new Point(225, 91);
            txtStudyMinute.Name = "txtStudyMinute";
            txtStudyMinute.Size = new Size(70, 23);
            txtStudyMinute.TabIndex = 5;
            // 
            // txtStudySecond
            // 
            txtStudySecond.Location = new Point(301, 91);
            txtStudySecond.Name = "txtStudySecond";
            txtStudySecond.Size = new Size(70, 23);
            txtStudySecond.TabIndex = 6;
            // 
            // txtBreakHour
            // 
            txtBreakHour.Location = new Point(150, 119);
            txtBreakHour.Name = "txtBreakHour";
            txtBreakHour.Size = new Size(70, 23);
            txtBreakHour.TabIndex = 7;
            // 
            // txtBreakMinute
            // 
            txtBreakMinute.Location = new Point(225, 119);
            txtBreakMinute.Name = "txtBreakMinute";
            txtBreakMinute.Size = new Size(70, 23);
            txtBreakMinute.TabIndex = 8;
            // 
            // txtBreakSecond
            // 
            txtBreakSecond.Location = new Point(301, 119);
            txtBreakSecond.Name = "txtBreakSecond";
            txtBreakSecond.Size = new Size(70, 23);
            txtBreakSecond.TabIndex = 9;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(276, 162);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(70, 25);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lblStudyTime
            // 
            lblStudyTime.AutoSize = true;
            lblStudyTime.Location = new Point(7, 97);
            lblStudyTime.Name = "lblStudyTime";
            lblStudyTime.Size = new Size(127, 17);
            lblStudyTime.TabIndex = 11;
            lblStudyTime.Text = "Desire Study Time";
            // 
            // lblBreakTime
            // 
            lblBreakTime.AutoSize = true;
            lblBreakTime.Location = new Point(7, 122);
            lblBreakTime.Name = "lblBreakTime";
            lblBreakTime.Size = new Size(127, 17);
            lblBreakTime.TabIndex = 12;
            lblBreakTime.Text = "Desire Break Time";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(417, 79);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 29);
            lblStatus.TabIndex = 13;
            // 
            // lblHour
            // 
            lblHour.AutoSize = true;
            lblHour.Location = new Point(163, 62);
            lblHour.Name = "lblHour";
            lblHour.Size = new Size(36, 17);
            lblHour.TabIndex = 14;
            lblHour.Text = "Hour";
            // 
            // lblMinute
            // 
            lblMinute.AutoSize = true;
            lblMinute.Location = new Point(239, 62);
            lblMinute.Name = "lblMinute";
            lblMinute.Size = new Size(50, 17);
            lblMinute.TabIndex = 15;
            lblMinute.Text = "Minute";
            // 
            // lblSecond
            // 
            lblSecond.AutoSize = true;
            lblSecond.Location = new Point(313, 62);
            lblSecond.Name = "lblSecond";
            lblSecond.Size = new Size(50, 17);
            lblSecond.TabIndex = 16;
            lblSecond.Text = "Second";
            // 
            // button1
            // 
            button1.Location = new Point(12, 347);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Pomodoro
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 382);
            Controls.Add(button1);
            Controls.Add(lblSecond);
            Controls.Add(lblMinute);
            Controls.Add(lblHour);
            Controls.Add(lblStatus);
            Controls.Add(lblBreakTime);
            Controls.Add(lblStudyTime);
            Controls.Add(btnReset);
            Controls.Add(txtBreakSecond);
            Controls.Add(txtBreakMinute);
            Controls.Add(txtBreakHour);
            Controls.Add(txtStudySecond);
            Controls.Add(txtStudyMinute);
            Controls.Add(txtStudyHour);
            Controls.Add(btnStart);
            Controls.Add(lblTime);
            Name = "Pomodoro";
            Text = "Pomodoro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTime;
        private Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private TextBox txtStudyHour;
        private TextBox txtStudyMinute;
        private TextBox txtStudySecond;
        private TextBox txtBreakHour;
        private TextBox txtBreakMinute;
        private TextBox txtBreakSecond;
        private Button btnReset;
        private Label lblStudyTime;
        private Label lblBreakTime;
        private Label lblStatus;
        private Label lblHour;
        private Label lblMinute;
        private Label lblSecond;
        private Button button1;
    }
}