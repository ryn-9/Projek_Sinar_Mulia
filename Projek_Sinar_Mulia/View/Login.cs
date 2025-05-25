using Projek_Sinar_Mulia.View;

namespace Projek_Sinar_Mulia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbpassword.PasswordChar = '*';

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;

            string role = UserValid.CekRole(username, password);

            if (role != null)
            {
                MessageBox.Show("Login berhasil!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                if (role == "petani")
                {
                    var petaniForm = new HomepagePetani();
                    petaniForm.Show();
                }
                else if (role == "operator")
                {
                    var homepageoperator = new HomepageOperator();
                    homepageoperator.Show();
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            //bool success = UserValid.Login(username, password);
            //if (success)
            //{
            //    MessageBox.Show("Login berhasil!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    var homepage = new Homepage();
            //    homepage.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Username atau Password salah!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        //}

        private void lblregister_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }

        private void cbintip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbintip.Checked)
            {
                tbpassword.PasswordChar = '\0';
            }
            else
            {
                tbpassword.PasswordChar = '*';
            }
        }
    }
}
