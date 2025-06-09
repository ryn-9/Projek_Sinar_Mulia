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

namespace Projek_Sinar_Mulia.View.UC
{
    public partial class Riwayat: UserControl
    {
        public Riwayat()
        {
            InitializeComponent();
            LoadRiwayatData();
        }
        private void LoadRiwayatData()
        {
            string connString = "Host=localhost;Port=5432;Username=postgres;Password=dinadin;Database=sinarmulia";
            using (NpgsqlConnection conn = new NpgsqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string query = "select pi.luas_lahan, pi.tanggal_pengairan, p.username, o.username, a.jalan, a.rt, a.rw, s.status\r\nfrom permintaan_irigasi pi\r\njoin petani p using(id_petani)\r\njoin operator o using(id_operator)\r\njoin alamat a using(id_alamat)\r\njoin status s using(id_status)";
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
