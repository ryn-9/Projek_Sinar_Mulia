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
        public HomepagePetani()
        {
            InitializeComponent();
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
            //UCMasuk(new UCkelolapermintaan());
        }

        private void btnriwayat_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnriwayat);
            UCMasuk(new Riwayat());
        }

        private void btnlahan_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnlahan);
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
    }
}
