using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRNProject
{
    public partial class Pomodoro : Form
    {
        private TimeSpan studyTime;
        private TimeSpan breakTime;
        private bool isStudying;
        private int h, m, s;
        public Pomodoro()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (ValidateTimeInput(txtStudyHour.Text, txtStudyMinute.Text, txtStudySecond.Text) &&
                ValidateTimeInput(txtBreakHour.Text, txtBreakMinute.Text, txtBreakSecond.Text))
            {
                // Lấy thời gian học và thời gian nghỉ từ TextBox
                bool temp = ValidateTimeInput(txtStudyHour.Text, txtStudyMinute.Text, txtStudySecond.Text);
                TimeSpan studyTime = GetTimeFromTextBox(txtStudyHour.Text, txtStudyMinute.Text, txtStudySecond.Text);
                temp = ValidateTimeInput(txtBreakHour.Text, txtBreakMinute.Text, txtBreakSecond.Text);
                TimeSpan breakTime = GetTimeFromTextBox(txtBreakHour.Text, txtBreakMinute.Text, txtBreakSecond.Text);

                if (studyTime.TotalSeconds <= 0 || breakTime.TotalSeconds <= 0)
                {
                    MessageBox.Show("Study time and break time must be greater than zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    BringToTop();
                    return;
                }

                isStudying = true;
                this.studyTime = studyTime;
                this.breakTime = breakTime;

                timer1.Start();
            }
            else
            {
                MessageBox.Show("Invalid time input. Please enter valid numbers in at least one of the three time units.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                BringToTop();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isStudying)
            {
                lblStatus.Text = "Studying...";
                studyTime = studyTime.Subtract(TimeSpan.FromSeconds(1));
                if (studyTime.TotalSeconds <= 0)
                {
                    isStudying = false; // Kết thúc giai đoạn học
                    timer1.Stop(); // Dừng đếm thời gian
                    ShowNotification("Study time finished!"); // Hiển thị thông báo

                    timer1.Start(); // Bắt đầu đếm ngược thời gian nghỉ
                    bool temp = ValidateTimeInput(txtStudyHour.Text, txtStudyMinute.Text, txtStudySecond.Text);
                    TimeSpan studyTime = GetTimeFromTextBox(txtStudyHour.Text, txtStudyMinute.Text, txtStudySecond.Text);
                    this.studyTime = studyTime;
                    BringToTop();
                }
            }
            else
            {
                lblStatus.Text = "Taking a break...";
                breakTime = breakTime.Subtract(TimeSpan.FromSeconds(1));
                if (breakTime.TotalSeconds <= 0)
                {
                    isStudying = true; // Bắt đầu giai đoạn học lại
                    timer1.Stop(); // Dừng đếm thời gian
                    ShowNotification("Break time finished!"); // Hiển thị thông báo

                    timer1.Start(); // Bắt đầu đếm ngược thời gian học
                    bool temp = ValidateTimeInput(txtBreakHour.Text, txtBreakMinute.Text, txtBreakSecond.Text);
                    TimeSpan breakTime = GetTimeFromTextBox(txtBreakHour.Text, txtBreakMinute.Text, txtBreakSecond.Text);
                    this.breakTime = breakTime;
                    BringToTop();
                }
            }

            UpdateTimeLabel();
        }

        private void UpdateTimeLabel()
        {
            TimeSpan currentTime = isStudying ? studyTime : breakTime;
            lblTime.Text = currentTime.ToString(@"hh\:mm\:ss"); // Cập nhật Label hiển thị thời gian
        }
        private void ShowNotification(string message)
        {
            MessageBox.Show(message, "Pomodoro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
        private bool ValidateTimeInput(string hour, string minute, string second)
        {
            if (string.IsNullOrEmpty(hour) && string.IsNullOrEmpty(minute) && string.IsNullOrEmpty(second))
            {
                return false;
            }
            if (string.IsNullOrEmpty(hour))
            {
                h = 0;
            }
            else
            {
                h = int.Parse(hour);
            }
            if (string.IsNullOrEmpty(minute))
            {
                m = 0;
            }
            else
            {
                m = int.Parse(minute);
            }
            if (string.IsNullOrEmpty(second))
            {
                s = 0;
            }
            else
            {
                s = int.Parse(second);
            }
            return true;
        }
        private TimeSpan GetTimeFromTextBox(string hour, string minute, string second)
        {
            // Chuyển đổi lố phút thành giờ
            if (m >= 60)
            {
                h += m / 60;
                m %= 60;
            }

            // Chuyển đổi lố giây thành phút
            if (s >= 60)
            {
                m += s / 60;
                s %= 60;
            }

            return new TimeSpan(h, m, s);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lblTime.Text = "00:00:00";
            isStudying = true;
            studyTime = TimeSpan.Zero;
            breakTime = TimeSpan.Zero;
        }
        public void BringToTop()
        {
            //Checks if the method is called from UI thread or not
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(BringToTop));
            }
            else
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                }

                //Keeps the current topmost status of form
                bool top = TopMost;
                //Brings the form to top
                TopMost = true;
                //Set form's topmost status back to whatever it was
                TopMost = top;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new Form1();
            frmHome.ShowDialog();
        }
    }
}
