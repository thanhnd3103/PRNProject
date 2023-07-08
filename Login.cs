using PRNProject.Repository;
using PRNProject.Models;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace PRNProject
{
    public partial class Login : Form
    {
        UsersReposistory usersReposistory;
        public static class UserSession
        {
            public static string Username { get; set; }
            public static int UserID { get; set; }
            public static string PhoneNumber { get; set; }

            public static string Password { get; set; }

        }
        public Login()
        {
            InitializeComponent();
            usersReposistory = new UsersReposistory();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            var listAccount = usersReposistory.GetAll();



            if (listAccount.Where(P => (P.Username.Equals(username) || P.Username.Equals(username))
                         && P.Password.Equals(password))
                             .FirstOrDefault() != null)
            {
                //dang nhap thanh cong
                //MessageBox.Show("Dang nhap thanh cong", "Thong bao", MessageBoxButtons.OK);
                UserSession.Username = username;
                var dbContext = new PRNProjectContext();
                var user = dbContext.Users.FirstOrDefault(u => u.Username == username);
                if (user != null)
                {
                    UserSession.UserID = user.UserId;
                    UserSession.PhoneNumber = user.PhoneNumber;
                    UserSession.Password = user.Password;
                    // Use the userId as needed
                }



                this.Hide();
                var frmHome = new Form1();
                frmHome.ShowDialog();

            }
            else
            {
                //dang nhap that bai
                MessageBox.Show("Login failed", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new Register();
            frmHome.ShowDialog();
        }
    }
}