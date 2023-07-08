using PRNProject.Repository;
using System;
using PRNProject.Models;
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
    public partial class Profile : Form
    {
        UsersReposistory usersReposistory;
        PRNProjectContext dbs = new PRNProjectContext();
        int EmpId = 0;
        public Profile()
        {
            InitializeComponent();
            usersReposistory = new UsersReposistory();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new Form1();
            frmHome.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var name = textBox1.Text;
            var phone = textBox2.Text;

            User user = new User();
            user.UserId = Login.UserSession.UserID;
            user.UserId = Login.UserSession.UserID;
            user.Username = name;
            user.PhoneNumber = phone;
            user.Password = Login.UserSession.Password;
            usersReposistory.Update(user);
            MessageBox.Show("Update Success", "Notification", MessageBoxButtons.OK);
            textBox1.Text = name;
            textBox2.Text = phone;

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            textBox1.Text = Login.UserSession.Username;
            textBox2.Text = Login.UserSession.PhoneNumber;

        }
    }
}
