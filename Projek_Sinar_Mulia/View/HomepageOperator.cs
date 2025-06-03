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

namespace Projek_Sinar_Mulia.View
{
    public partial class HomepageOperator : Form
    {
        Panel panelIndicator;
        public HomepageOperator()
        {
            InitializeComponent();
            picindikator.Visible = false;
        }
        private void MoveIndicator(Control button)
        {
            picindikator.Top = button.Top;
            picindikator.Visible = true;
        }

        private void btnkelolapermintaan_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnkelolapermintaan);
            //UCMasuk(new UCkelolapermintaan());
        }

        private void btnriwayat_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnriwayat);
            //UCMasuk(new UCRiwayat());
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnabout);
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
    }
}
