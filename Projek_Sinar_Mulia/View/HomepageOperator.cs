using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Projek_Sinar_Mulia.View.UC;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;



namespace Projek_Sinar_Mulia.View
{
    public partial class HomepageOperator : Form
    {
        Panel panelIndicator;
        private string currentUsername;
        public HomepageOperator(string username)
        {
            InitializeComponent();
            picindicator.Visible = false;
            currentUsername = username;
        }
        private void MoveIndicator(Control button)
        {
            picindicator.Top = button.Top;
            picindicator.Visible = true;
        }

        private void btnpermintaan_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnpermintaan);
            UCMasuk(new KelolaPermintaan());
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

        private void HomepageOperator_Load(object sender, EventArgs e)
        {
            UCMasuk(new hai(currentUsername));
        }

        private void btnlihatriwayat_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnlihatriwayat);
            UCMasuk(new AllRiwayat());
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
    }
}
