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
    public partial class AllRiwayat : UserControl
    {
        public AllRiwayat()
        {
            InitializeComponent();
            LoadAllRiwayatData();
        }
        private void LoadAllRiwayatData()
        {
            using (NpgsqlConnection conn = Database.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = @"
                SELECT 
                    pi.tgl_permintaan AS ""Tanggal_Permintaan"", 
                    u.username AS ""Petani"", 
                    l.luas AS ""Luas"", 
                    l.blok AS ""Blok"", 
                    j.jalan AS ""Jalan"", 
                    rt.rt AS ""RT"", 
                    rw.rw AS ""RW"", 
                    s.status AS ""Status""
                FROM permintaan_irigasi pi
                JOIN lahan l USING(id_lahan)
                JOIN users u USING(id_users)
                JOIN jalan j USING(id_jalan)
                JOIN rt rt USING(id_rt)
                JOIN rw rw USING(id_rw)
                JOIN status s USING(id_status)";

                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat data: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
