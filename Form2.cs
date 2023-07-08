using GridScheduleSample;
using Syncfusion.Schedule;
using Syncfusion.Windows.Forms.Schedule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PRNProject
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            /* ScheduleControl scheduleControl1 = new ScheduleControl();
             scheduleControl1.Location = new Point(82, 12);
             scheduleControl1.Size = new Size(350, 360);
             this.Controls.Add(scheduleControl1); */

        }



        private void Form2_Load_1(object sender, EventArgs e)
        {
            SimpleScheduleDataProvider data;

            if (File.Exists("default.schedule"))
            {
                data = SimpleScheduleDataProvider.LoadBinary("default.schedule");
                data.FileName = "default.schedule";
            }

            else
            {
                data = new SimpleScheduleDataProvider();
                data.MasterList = new SimpleScheduleAppointmentList();
                data.FileName = "default.schedule";
            }
            this.scheduleControl1.ScheduleType = ScheduleViewType.Month;
            this.scheduleControl1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new Form1();
            frmHome.ShowDialog();
        }
    }

}
