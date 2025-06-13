using Microsoft.VisualBasic.ApplicationServices;
using Projek_Sinar_Mulia.View.UC;
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
    public partial class HomepagePetani : Form
    {
        Panel panelIndicator;
        private int currentUserId;
        private int UserId;
        private string currentUsername;

        public HomepagePetani(int idUser, string username)
        {
            InitializeComponent();
            currentUserId = idUser;
            currentUsername = username;
            this.Load += new System.EventHandler(this.HomepagePetani_Load);
        }



        private void MoveIndicator(Control button)
        {
            picindikator.Top = button.Top;
            picindikator.Visible = true;
        }

        private void btnkelolapermintaan_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnkelolapermintaan);
            UCMasuk(new AjukanPermintaan());            
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah kamu yakin?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                var loginForm = new Login();
                loginForm.Show();
                this.Close();
            }
            else
            {

            }
        }

        private void btnlahan_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnlahan);
            UCMasuk(new TambahLahan());
            //UCMasuk(new UCabout());
        }
        private void UCMasuk(UserControl uc)
        {
            pnlutama.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlutama.Controls.Add(uc);
            uc.BringToFront();
        }
        private void picindikator_Click(object sender, EventArgs e)
        {

        }

        private void pnlutama_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picindikator_Click_1(object sender, EventArgs e)
        {

        }

        private void btnlihatstatus_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnlihatstatus);
            UCMasuk(new LihatStatusPermintaan());
        }
        private void HomepagePetani_Load(object sender, EventArgs e)
        {
            UCMasuk(new hai(currentUsername));
        }
    }
}
