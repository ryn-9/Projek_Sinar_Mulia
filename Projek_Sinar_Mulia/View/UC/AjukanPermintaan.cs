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
            this.Load += new System.EventHandler(this.UserControl_Load);
        }
        private void AjukanPermintaan_Load(object sender, EventArgs e)
        {
            var lahanService = new LahanService();
            cbLokasi.DataSource = lahanService.GetAllLahan();
            cbLokasi.DisplayMember = "ToString"; // atau "id_lahan"
            cbLokasi.ValueMember = "id_lahan";
        }
        private void tbLokasi_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (cbLokasi.SelectedItem is not LahanModel selectedLahan)
            {
                MessageBox.Show("Silakan pilih lahan terlebih dahulu.");
                return;
            }
            if (!int.TryParse(tbDurasi.Text.Trim(), out int durasi) || durasi <= 0)
            {
                MessageBox.Show("Durasi harus berupa angka positif.");
                return;
            }

            DateTime tanggal = dateTimePicker1.Value.Date;
            var permintaanService = new PermintaanService();
            int total = permintaanService.GetJumlahPermintaanByTanggal(tanggal);

            if (total >= 3)
            {
                MessageBox.Show("Permintaan irigasi untuk tanggal ini sudah mencapai batas maksimal (3).");
                return;
            }

            permintaanService.SimpanPermintaan(selectedLahan.id_lahan, tanggal);
            MessageBox.Show("Permintaan irigasi berhasil disimpan.");
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {

        }

        private void lbLokasi_Click(object sender, EventArgs e)
        {

        }

        private void cbLokasi_SelectedIndexChanged(object sender, EventArgs e)
        {      

        }
        private void UserControl_Load(object sender, EventArgs e)
        {
            var LahanService = new LahanService();
            cbLokasi.DataSource = LahanService.GetAllLahan();
            cbLokasi.DisplayMember = "lahan";
            cbLokasi.ValueMember = "id_lahan";
            cbLokasi.SelectedIndex = -1;
        }
    }
}
