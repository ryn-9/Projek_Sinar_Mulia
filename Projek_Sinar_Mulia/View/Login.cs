using Microsoft.VisualBasic.ApplicationServices;
using Projek_Sinar_Mulia.View;
using Projek_Sinar_Mulia;

namespace Projek_Sinar_Mulia
{
    public partial class Login : Form
    {
        private int currentUserId;
        public Login()
        {
            InitializeComponent();
            tbpassword.PasswordChar = '*';            


        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;

            int? userId = UserController.GetUserId(username, password);
            int? roleId = UserController.GetRoleId(username, password);

            if (userId.HasValue && roleId.HasValue)
            {
                if (roleId.Value == 1)
                {
                    MessageBox.Show("Login sebagai Petani");
                    MessageBox.Show($"Login berhasil. userId = {userId}, roleId = {roleId}");



                    var form = new HomepagePetani(userId.Value, username);
                    form.Show();
                    this.Hide();
                }
                else if (roleId.Value == 2)
                {
                    MessageBox.Show("Login sebagai Operator");
                    var form = new HomepageOperator(username);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Role tidak dikenali.");
                }
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //if (roleId == 1)
            //{
            //    MessageBox.Show("Login sebagai Petani");
            //    var form = new HomepagePetani(userId); // ? tambahkan parameter
            //    form.Show();
            //    this.Hide();
            //}

            //else if (roleId == 2)
            //{
            //    MessageBox.Show("Login sebagai Operator");
            //    var form = new HomepageOperator();
            //    form.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //if (PetaniController.Login(username, password))
            //{
            //    MessageBox.Show("Login sebagai Petani");
            //    var form = new HomepagePetani();
            //    form.Show();
            //    this.Hide();
            //    return;
            //}

            // Kalau dua-duanya gagal
            //MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        }

        private void lblregister_Click(object sender, EventArgs e)
        {
            var registerForm = new Register();
            registerForm.Show();
            this.Hide();
        }




        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbintip_CheckedChanged_1(object sender, EventArgs e)
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
