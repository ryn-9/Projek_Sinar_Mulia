using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Projek_Sinar_Mulia
{
    public partial class LihatStatusPermintaan : UserControl
    {
        public LihatStatusPermintaan()
        {
            InitializeComponent();
            LoadRiwayatData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadRiwayatData()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=dinadin;Database=sinmul";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "select pi.tgl_permintaan as \"Tanggal_Permintaan\",pi.durasi as \"Durasi\", u.username as \"Petani\", l.luas as \"Luas\", l.blok as \"Blok\", j.jalan as \"Jalan\", rt.rt as \"RT\", rw.rw as \"RW\", s.status as \"Status\"from permintaan_irigasi pi\r\njoin lahan l using(id_lahan)\r\njoin users u using(id_users)\r\njoin jalan j using(id_jalan)\r\njoin rt rt using(id_rt)\r\njoin rw rw using(id_rw)\r\njoin status s using(id_status)";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message);
                }
            }
        }
    }
}
