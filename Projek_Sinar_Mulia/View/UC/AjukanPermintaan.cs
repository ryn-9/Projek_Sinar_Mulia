using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projek_Sinar_Mulia
{
    public partial class AjukanPermintaan : UserControl
    {
        public AjukanPermintaan()
        {
            InitializeComponent();
        }

        private void tbLokasi_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            //string Lokasi = tbLokasi.Text;
            DateTime Tanggal = dateTimePicker1.Value;
            string Durasi = tbDurasi.Text;
            //string Luas = tbLuas.Text;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void lbLokasi_Click(object sender, EventArgs e)
        {

        }
    }
}
