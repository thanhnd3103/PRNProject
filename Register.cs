using PRNProject.Models;
using PRNProject.Repository;
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
    public partial class Register : Form
    {
        UsersReposistory usersReposistory;
        public Register()
        {
            usersReposistory = new UsersReposistory();
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var frmLogin = new Login();
            this.Hide();
            frmLogin.ShowDialog();

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var registerUsername = txtRegisterUsername.Text;
            var registerPassword = txtRegisterPassword.Text;
            var registerConfirmPassword = txtRegisterConfirmPassword.Text;
            var phoneNumber = txtRegisterPhoneNumber.Text;
            Console.WriteLine("Wowy1");
            if (registerUsername.Trim().Equals(""))
            {
                lblRegisterUsernameError.Text = "Username cannot be empty";
                lblRegisterUsernameError.ForeColor = Color.Red;
            }
            else if (registerPassword.Trim().Equals(""))
            {
                lblRegisterPasswordError.Text = "Password cannot be empty";
                lblRegisterPasswordError.ForeColor = Color.Red;
            }
            else if (!registerConfirmPassword.Equals(registerPassword))
            {
                lblRegisterConfirmPasswordError.Text = "Passwords do not match!";
                lblRegisterConfirmPasswordError.ForeColor = Color.Red;
            }
            else
            {
                lblRegisterAccountSuccess.Text = "Account successfully created";
                lblRegisterAccountSuccess.ForeColor = Color.Green;
                lblRegisterUsernameError.Text = "";
                lblRegisterPasswordError.Text = "";
                lblRegisterConfirmPasswordError.Text = "";
                User user = new User();
                user.Username = registerUsername;
                user.Password = registerPassword;
                user.PhoneNumber = phoneNumber;
                usersReposistory.Add(user);

            }


        }
    }
}
