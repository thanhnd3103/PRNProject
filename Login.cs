using PRNProject.Repository;

namespace PRNProject
{
    public partial class Login : Form
    {
        UsersReposistory usersReposistory;
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

                this.Hide();
                var frmHome = new Home();
                frmHome.ShowDialog();

            }
            else
            {
                //dang nhap that bai
                MessageBox.Show("Login failed", "Notification", MessageBoxButtons.OK);
            }
        }
    }
}