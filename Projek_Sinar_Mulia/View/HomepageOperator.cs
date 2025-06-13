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



namespace Projek_Sinar_Mulia.View
{
    public partial class HomepageOperator : Form
    {
        Panel panelIndicator;
        public HomepageOperator()
        {
            InitializeComponent();
            picindicator.Visible = false;
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

        }

        private void btnlihatstatus_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnlihatstatus);
        }

        private void btnabout_Click(object sender, EventArgs e)
        {
            MoveIndicator(btnabout);
        }
    }
}
