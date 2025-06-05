using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Sinar_Mulia
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            tbpassword.PasswordChar = '*';
            tbvalidasi.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbusername.Text;
            string password = tbpassword.Text;
            string no_telephone = tbnotelp.Text;
            string validasi = tbvalidasi.Text;

            if (password != validasi)
            {
                MessageBox.Show("Password dan Konfirmasi Password tidak sama!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (PetaniController.CekUsername(username) || OperatorController.CekUsername(username))
            {
                MessageBox.Show("Username sudah digunakan!. Silakan pilih username yang lain!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PetaniController.CekNoTelp(no_telephone) || OperatorController.CekNoTelp(no_telephone))
            {
                MessageBox.Show("Nomor Telepon sudah digunakan!. Gunakan nomor telepon yang lain!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PetaniController.HanyaAngka(no_telephone) || no_telephone.Length < 10 || no_telephone.Length > 13)
            {
                MessageBox.Show("Nomor Telepon tidak valid!. Gunakan nomor telepon yang valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(validasi) ||
                string.IsNullOrWhiteSpace(no_telephone))
            {
                MessageBox.Show("Input tidak boleh kosong!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var newPetani = new PetaniModel
            {
                username = tbusername.Text,
                password = tbpassword.Text,
                no_telephone = tbnotelp.Text,
            };

            PetaniController.InsertPetani(newPetani);
            MessageBox.Show("Registrasi berhasil!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbvalidasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbintip1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbintip1.Checked)
            {
                tbpassword.PasswordChar = '\0';
            }
            else
            {
                tbpassword.PasswordChar = '*';
            }
        }

        private void cbintip2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbintip2.Checked)
            {
                tbvalidasi.PasswordChar = '\0';
            }
            else
            {
                tbvalidasi.PasswordChar = '*';
            }
        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
            var login = new Login();
            login.Show();
            this.Hide();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
